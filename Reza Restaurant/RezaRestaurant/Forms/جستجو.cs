using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using RezaRestaurant.Classes;

namespace RezaRestaurant
{
    public partial class Form_جستجو : Form
    {
        public Form_جستجو()
        {
            InitializeComponent();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView_جستجو.ListViewItemSorter = lvwColumnSorter;
        }

        void Form_جستجو_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticVariables.Form_جستجو_IsShown = false;
        }

        void button_امروز_Click(object sender, EventArgs e)
        {
            maskedTextBox_تا_تاریخ.Text = GlobalMethods.PersianDate(DateTime.Now.ToString(), false, true);
            maskedTextBox_از_تاریخ.Text = GlobalMethods.PersianDate(DateTime.Now.ToString(), false, true);
        }

        void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_جستجو.Text.Trim() == "")
                {
                    listView_جستجو.Items.Clear();
                    return;
                }

                listView_جستجو.Items.Clear();
                pictureBox1.Visible = true;
                this.buttonSearch.Enabled = false;

                DateTime startTime = GlobalMethods.ChristianDate(maskedTextBox_از_تاریخ.Text.Trim());
                DateTime endTime = GlobalMethods.ChristianDate(maskedTextBox_تا_تاریخ.Text.Trim());
                endTime = endTime.AddDays(+1);

                using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
                {
                    //جستجو براساس تاریخ
                    var query1 = from q in dbc.فاکتورهاs
                                 where (q.تاریخ_ثبت >= startTime && q.تاریخ_ثبت <= endTime)
                                 from c in dbc.اقلام_فروخته_شدهs
                                 where (c.FacotrID == q.id)
                                 select new
                                 {
                                     q.شماره_فاکتور,
                                     q.نوع_فاکتور,
                                     c.نام_غذا,
                                     c.تعداد,
                                     q.شماره_میز,
                                     q.مبلغ_فاکتور,
                                     c.قیمت_یک_واحد,
                                     q.تاریخ_ثبت
                                 };

                    if (query1.Count() > 2000)
                    {
                        MessageBox.Show("بیش از 2000 آیتم پیدا شده است ، لطفا محدوده تاریخ را کوچکتر انتخاب کنید", "خطای نمایش داده ها", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        throw new Exception("overload");
                    }

                    //جستجو بر اساس متن وارد شده در textbox
                    var query2 = from q in query1
                                 where
                                     (
                                         (checkBox_تعداد.Checked && q.تعداد.ToString() == textBox_جستجو.Text.Trim()) ||
                                         (checkBox_نام_غذا.Checked && q.نام_غذا.Contains(textBox_جستجو.Text.Trim())) ||
                                         (checkBox_شماره_فاکتور.Checked && q.شماره_فاکتور.ToString() == textBox_جستجو.Text.Trim()) ||
                                         (checkBox_شماره_میز.Checked && q.شماره_میز.Value.ToString() == textBox_جستجو.Text.Trim()) ||
                                         (checkBox_مبلغ_فاکتور.Checked && q.مبلغ_فاکتور.ToString() == textBox_جستجو.Text.Trim())
                                     )
                                 orderby q.تاریخ_ثبت ascending
                                 select new
                                 {
                                     q.شماره_فاکتور,
                                     q.نوع_فاکتور,
                                     q.نام_غذا,
                                     q.تعداد,
                                     q.شماره_میز,
                                     q.مبلغ_فاکتور,
                                     q.قیمت_یک_واحد,
                                     q.تاریخ_ثبت
                                 };

                    int i = 0;
                    foreach (var item in query2)
                    {
                        i++;
                        string tableNumber = item.شماره_میز.HasValue ? item.شماره_میز.Value.ToString() : "----";
                        ListViewItem newItem = new ListViewItem(new string[] {  item.شماره_فاکتور.ToString().ToPersianNumber(),
                                                                                item.نوع_فاکتور,
                                                                                tableNumber.ToPersianNumber(),
                                                                                item.نام_غذا, 
                                                                                item.تعداد.ToString().ToPersianNumber(), 
                                                                                item.مبلغ_فاکتور.ToString().MoneyFormat().ToPersianNumber(),
                                                                                item.قیمت_یک_واحد.ToString().MoneyFormat().ToPersianNumber(),
                                                                                GlobalMethods.PersianDate(item.تاریخ_ثبت.ToString(), true, true).ToPersianNumber()});
                        newItem.Font = new Font("Tahoma", 12);
                        newItem.Name = "Item" + i;
                        listView_جستجو.Items.Add(newItem);
                    }
                }
            }
            catch { }
            finally
            {
                pictureBox1.Visible = false;
                this.buttonSearch.Enabled = true;
            }
        }

        void Form_جستجو_Activated(object sender, EventArgs e)
        {
            textBox_جستجو.Focus();
        }

        void Form_جستجو_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        void Form_جستجو_Shown(object sender, EventArgs e)
        {
            textBox_جستجو.Focus();
            button_امروز_Click(null, null);
        }

        private void textBox_جستجو_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                buttonSearch_Click(null, null);
        }

        #region Sorting ListView

        private ListViewColumnSorter lvwColumnSorter;

        private void listView_جستجو_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    if (lvwColumnSorter.Order == SortOrder.Ascending)
                    {
                        lvwColumnSorter.Order = SortOrder.Descending;
                    }
                    else
                    {
                        lvwColumnSorter.Order = SortOrder.Ascending;
                    }
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                this.listView_جستجو.Sort();
            }
            catch { }
        }

        #endregion
    }
}
