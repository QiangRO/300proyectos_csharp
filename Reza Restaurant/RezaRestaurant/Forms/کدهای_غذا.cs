using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RezaRestaurant.Classes;
using System.Collections;

namespace RezaRestaurant
{
    public partial class Form_کدهای_غذا : Form
    {
        RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext();

        public Form_کدهای_غذا()
        {
            InitializeComponent();

            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView_غذاها.ListViewItemSorter = lvwColumnSorter;

        }

        void Form_کدهای_غذا_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticVariables.Form_کدهای_غذا_IsShown = false;
        }

        void Form_کدهای_غذا_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.Down)
            {
                listView_غذاها.Focus();
            }
        }

        void Form_کدهای_غذا_Shown(object sender, EventArgs e)
        {
            try
            {
                textBox_نام_غذا.Focus();

                int rowNumber = 0;
                var foods = dbc.غذاهاs.Select(q => q).OrderBy(q => q.کد_غذا);
                foreach (var item in foods)
                {
                    rowNumber++;
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        rowNumber.ToString().ToPersianNumber(),
                        item.نام_غذا,
                        item.قیمت.ToString().ToPersianNumber().MoneyFormat(),
                        item.کد_غذا.ToString().ToPersianNumber()
                    });
                    listViewItem.Font = new Font("Tahoma", 12);
                    listViewItem.Name = item.نام_غذا;
                    listView_غذاها.Items.Add(listViewItem);

                    textBox_نام_غذا.AutoCompleteCustomSource.Add(item.نام_غذا);
                }
            }
            catch { }
        }

        void button_ثبت_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                try
                {
                    int.Parse(textBox_قیمت.Text.Trim().Replace(",", ""));
                }
                catch
                {
                    errorProvider1.SetError(this.textBox_قیمت, "قیمت را صحیح وارد کنید");
                    return;
                }

                foreach (ListViewItem item in listView_غذاها.Items)
                {
                    if (item.SubItems[3].Text.ToEnglishNumber() == maskedTextBox_کد_غذا.Text.Trim().Replace(" ", "") &&
                        item.SubItems[1].Text != textBox_نام_غذا.Text.Trim())
                    {
                        errorProvider1.SetError(this.maskedTextBox_کد_غذا, "این کد غذا قبلا ثبت شده ، کد دیگری را انتخاب کنید");
                        return;
                    }
                }

                var theSameItem = listView_غذاها.Items.Find(textBox_نام_غذا.Text.Trim(), false);
                if (theSameItem.Count() >= 1)
                {
                    var theSameItemInDB = dbc.غذاهاs.Where(q => q.نام_غذا == textBox_نام_غذا.Text.Trim()).First();
                    theSameItemInDB.قیمت = int.Parse(textBox_قیمت.Text.Trim().Replace(",", ""));
                    theSameItemInDB.کد_غذا = int.Parse(maskedTextBox_کد_غذا.Text.Trim().Replace(" ", ""));
                    theSameItemInDB.نام_غذا = textBox_نام_غذا.Text.Trim();
                    dbc.SubmitChanges();

                    //به روز کردن listview
                    theSameItem.First().SubItems[1].Text = textBox_نام_غذا.Text.Trim();//به روز کردن نام غذا
                    theSameItem.First().SubItems[2].Text = textBox_قیمت.Text.Trim().Replace(",", "").MoneyFormat().ToPersianNumber();//به روز کردن قیمت غذا
                    theSameItem.First().SubItems[3].Text = maskedTextBox_کد_غذا.Text.Trim().ToPersianNumber();//به روز کردن کد غذا
                }
                else
                {
                    RezaRestaurant.SQL.غذاها newFoodItem = new RezaRestaurant.SQL.غذاها();
                    newFoodItem.قیمت = int.Parse(textBox_قیمت.Text.Trim().Replace(",", ""));
                    newFoodItem.کد_غذا = int.Parse(maskedTextBox_کد_غذا.Text.Trim().Replace(" ", ""));
                    newFoodItem.نام_غذا = textBox_نام_غذا.Text.Trim();
                    dbc.غذاهاs.InsertOnSubmit(newFoodItem);
                    dbc.SubmitChanges();

                    int rowNumber = int.Parse(listView_غذاها.Items[listView_غذاها.Items.Count - 1].SubItems[0].Text.ToEnglishNumber());
                    rowNumber++;

                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        rowNumber.ToString().ToPersianNumber(),
                        textBox_نام_غذا.Text.Trim(),
                        textBox_قیمت.Text.Trim().Replace(",","").ToPersianNumber().MoneyFormat(),
                        maskedTextBox_کد_غذا.Text.Trim().ToPersianNumber()});

                    listViewItem.Font = new Font("Tahoma", 12);
                    listViewItem.Name = textBox_نام_غذا.Text.Trim();
                    listView_غذاها.Items.Add(listViewItem);
                }

                textBox_نام_غذا.Focus();
            }
            catch { }
        }

        void listView_غذاها_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_نام_غذا.Text = listView_غذاها.Items[listView_غذاها.SelectedItems[0].Index].SubItems[1].Text;
                textBox_قیمت.Text = listView_غذاها.Items[listView_غذاها.SelectedItems[0].Index].SubItems[2].Text.ToEnglishNumber();
                maskedTextBox_کد_غذا.Text = listView_غذاها.Items[listView_غذاها.SelectedItems[0].Index].SubItems[3].Text.ToEnglishNumber();
            }
            catch { }
        }

        private void textBox_نام_غذا_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                textBox_قیمت.Focus();
        }

        private void textBox_قیمت_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                maskedTextBox_کد_غذا.Focus();
        }

        private void maskedTextBox_کد_غذا_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                button_ثبت.Focus();
        }

        private void listView_غذاها_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Delete) return;

                if (MessageBox.Show("آیا مطمئن هستید ؟", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                string foodName = listView_غذاها.SelectedItems[0].Name;
                var theFoodInDB = dbc.غذاهاs.Where(q => q.نام_غذا == foodName).First();
                dbc.غذاهاs.DeleteOnSubmit(theFoodInDB);
                dbc.SubmitChanges();

                this.listView_غذاها.SelectedItems[0].Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Sorting ListView

        private ListViewColumnSorter lvwColumnSorter;

        private void listView_غذاها_ColumnClick(object sender, ColumnClickEventArgs e)
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
                this.listView_غذاها.Sort();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
