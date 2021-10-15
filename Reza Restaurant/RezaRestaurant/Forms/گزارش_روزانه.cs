using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using RezaRestaurant.Classes;

namespace RezaRestaurant
{
    public partial class Form_گزارش_روزانه : Form
    {
        RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext();

        /// <summary>
        /// نوع گزارش را مشخص می کند
        /// سالانه ، ماهانه ، روزانه
        /// این فیلد همیشه باید یکی از سه مقدار زیر را داشته باشد
        /// سال ، ماه ، روز
        /// </summary>
        string TypeOfReport = "روز";

        bool ExportFactor = false;

        public Form_گزارش_روزانه()
        {
            InitializeComponent();

            button_امروز_Click(null, null);
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        void Form_گزارش_روزانه_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticVariables.Form_گزارش_روزانه_IsShown = false;
        }

        void button_فاکتورهای_صادر_شده_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                listView1.Items.Clear();
                listView1.Columns.Clear();

                #region Makes ListView ColumnHeaders

                this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                this.columnHeader_ردیف,
                                this.columnHeader_نوع_فاکتور,
                                this.columnHeader_شماره_فاکتور,
                                this.columnHeader_شماره_میز,
                                this.columnHeader_مبلغ_فاکتور,
                                this.columnHeader_تاریخ});

                #endregion

                if (maskedTextBox_تاریخ.Text.Trim() == "")
                {
                    errorProvider1.SetError(this.maskedTextBox_تاریخ, "لطفا تاریخ را وارد کنید");
                    return;
                }

                DateTime endTime;
                DateTime startTime;

                //بررسی اینکه آیا گزارش روزانه است ، ماهانه است یا سالانه
                try
                {
                    string persianDate = maskedTextBox_تاریخ.Text.Trim().Replace(" ", "");

                    int year = int.Parse(persianDate.Substring(0, persianDate.IndexOf('/')));
                    int month = int.Parse(persianDate.Substring(persianDate.IndexOf('/') + 1, 2));
                    int day = int.Parse(persianDate.Substring(persianDate.LastIndexOf('/') + 1, 2));

                    //گزارش سالانه
                    if (day == 00 && month == 00)
                    {
                        startTime = endTime = GlobalMethods.ChristianDate(year + "/01/01");
                        endTime = endTime.AddYears(+1);
                        TypeOfReport = "سال";
                    }
                    //گزارش ماهانه
                    else if (day == 00)
                    {
                        startTime = endTime = GlobalMethods.ChristianDate(year + "/" + month.ToString("00") + "/01");
                        endTime = endTime.AddMonths(1);
                        TypeOfReport = "ماه";
                    }
                    //گزارش روزانه
                    else
                    {
                        startTime = endTime = GlobalMethods.ChristianDate(persianDate);
                        endTime = endTime.AddDays(1);
                        TypeOfReport = "روز";
                    }
                }
                catch
                {
                    errorProvider1.SetError(this.maskedTextBox_تاریخ, "لطفا تاریخ صحیح را وارد کنید");
                    return;
                }


                var query = from q in dbc.فاکتورهاs
                            where (q.تاریخ_ثبت >= startTime && q.تاریخ_ثبت < endTime)
                            orderby q.تاریخ_ثبت ascending
                            select new
                            {
                                q.شماره_فاکتور,
                                q.نوع_فاکتور,
                                q.شماره_میز,
                                q.مبلغ_فاکتور,
                                q.تاریخ_ثبت
                            };

                string totalPrice = "0";
                try
                {
                    totalPrice = query.Sum(q => q.مبلغ_فاکتور).ToString();
                }
                catch { }

                label_جمع_فاکتور.Text = totalPrice.MoneyFormat().ToPersianNumber();

                this.Cursor = Cursors.WaitCursor;

                int i = 0;
                foreach (var item in query)
                {
                    i++;
                    string tableNumber = item.شماره_میز.HasValue ? item.شماره_میز.Value.ToString() : "";
                    ListViewItem newItem = new ListViewItem(new string[] { i.ToString().ToPersianNumber(), 
                                                                           item.نوع_فاکتور, 
                                                                           item.شماره_فاکتور.ToString().ToPersianNumber(),
                                                                           tableNumber.ToPersianNumber(),
                                                                           item.مبلغ_فاکتور.ToString().MoneyFormat().ToPersianNumber(), 
                                                                           GlobalMethods.PersianDate(item.تاریخ_ثبت.ToString(), true,true).ToPersianNumber() });
                    newItem.Font = new Font("Tahoma", 12);
                    newItem.Name = "Item" + i.ToString();
                    listView1.Items.Add(newItem);
                }
                ExportFactor = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void button_اقلام_مصرف_شده_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                listView1.Items.Clear();
                listView1.Columns.Clear();

                #region Makes ListView ColumnHeaders

                ColumnHeader ColumnHeader_ردیف = new ColumnHeader();
                ColumnHeader_ردیف.Text = "ردیف";
                ColumnHeader_ردیف.Width = 50;

                ColumnHeader ColumnHeader_نام_غذا = new ColumnHeader();
                ColumnHeader_نام_غذا.Text = "نام غذا";
                ColumnHeader_نام_غذا.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                ColumnHeader_نام_غذا.Width = 300;

                ColumnHeader ColumnHeader_تعداد = new ColumnHeader();
                ColumnHeader_تعداد.Text = "تعداد";
                ColumnHeader_تعداد.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                ColumnHeader_تعداد.Width = 70;

                ColumnHeader ColumnHeader_قیمت_یک_واحد = new ColumnHeader();
                ColumnHeader_قیمت_یک_واحد.Text = "قیمت یک واحد";
                ColumnHeader_قیمت_یک_واحد.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                ColumnHeader_قیمت_یک_واحد.Width = 100;


                ColumnHeader ColumnHeader_مبلغ_فاکتور = new ColumnHeader();
                ColumnHeader_مبلغ_فاکتور.Text = "مجموع قیمت ، ریال";
                ColumnHeader_مبلغ_فاکتور.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                ColumnHeader_مبلغ_فاکتور.Width = 180;

                this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                                ColumnHeader_ردیف,
                                ColumnHeader_نام_غذا,
                                ColumnHeader_تعداد,
                                ColumnHeader_قیمت_یک_واحد,
                                ColumnHeader_مبلغ_فاکتور});

                #endregion

                DateTime endTime;
                DateTime startTime;

                //بررسی اینکه آیا گزارش روزانه است ، ماهانه است یا سالانه
                try
                {
                    string persianDate = maskedTextBox_تاریخ.Text.Trim().Replace(" ", "");

                    int year = int.Parse(persianDate.Substring(0, persianDate.IndexOf('/')));
                    int month = int.Parse(persianDate.Substring(persianDate.IndexOf('/') + 1, 2));
                    int day = int.Parse(persianDate.Substring(persianDate.LastIndexOf('/') + 1, 2));

                    //گزارش سالانه
                    if (day == 00 && month == 00)
                    {
                        startTime = endTime = GlobalMethods.ChristianDate(year + "/01/01");
                        endTime = endTime.AddYears(+1);
                        TypeOfReport = "سال";
                    }
                    //گزارش ماهانه
                    else if (day == 00)
                    {
                        startTime = endTime = GlobalMethods.ChristianDate(year + "/" + month.ToString("00") + "/01");
                        endTime = endTime.AddMonths(1);
                        TypeOfReport = "ماه";
                    }
                    //گزارش روزانه
                    else
                    {
                        startTime = endTime = GlobalMethods.ChristianDate(persianDate);
                        endTime = endTime.AddDays(1);
                        TypeOfReport = "روز";
                    }
                }
                catch
                {
                    errorProvider1.SetError(this.maskedTextBox_تاریخ, "لطفا تاریخ صحیح را وارد کنید");
                    return;
                }

                var query = from q in dbc.فاکتورهاs
                            where (q.تاریخ_ثبت >= startTime && q.تاریخ_ثبت <= endTime)
                            from c in dbc.اقلام_فروخته_شدهs
                            where (c.FacotrID == q.id)
                            select new
                            {
                                c.نام_غذا,
                                c.تعداد,
                                c.قیمت_یک_واحد,
                            };

                this.Cursor = Cursors.WaitCursor;

                int i = 0;
                foreach (var item in query)
                {
                    var theSameItems = listView1.Items.Find(item.نام_غذا, false);
                    //آیتم مورد نظر را که دارای نام غذا و قیمت واحد یکسان می باشد را پیدا می کند
                    var specificItem = from q in theSameItems
                                       where q.SubItems[3].Text.Replace("/", "").ToEnglishNumber() == item.قیمت_یک_واحد.ToString()
                                       select q;

                    if (specificItem.Count() >= 1)
                    {
                        int تعداد_قبلی_غذا = int.Parse(listView1.Items[specificItem.First().Index].SubItems[2].Text.ToEnglishNumber());
                        int تعداد_جدید_غذا = item.تعداد + تعداد_قبلی_غذا;
                        ///به روز کردن تعداد غذا
                        listView1.Items[specificItem.First().Index].SubItems[2].Text = تعداد_جدید_غذا.ToString().ToPersianNumber();
                        ///به روز کردن قیمت غذاها
                        listView1.Items[specificItem.First().Index].SubItems[4].Text = (تعداد_جدید_غذا * item.قیمت_یک_واحد).ToString().ToPersianNumber().MoneyFormat();
                    }
                    else
                    {
                        i++;
                        int price = item.تعداد * item.قیمت_یک_واحد;
                        ListViewItem newItem = new ListViewItem(new string[] { i.ToString().ToPersianNumber(), 
                                                                           item.نام_غذا,
                                                                           item.تعداد.ToString().ToPersianNumber(), 
                                                                           item.قیمت_یک_واحد.ToString().MoneyFormat().ToPersianNumber(),
                                                                           price.ToString().MoneyFormat().ToPersianNumber() });
                        newItem.Font = new Font("Tahoma", 12);
                        newItem.Name = item.نام_غذا;
                        listView1.Items.Add(newItem);
                    }
                }

                long allPrice = 0;
                foreach (ListViewItem item in listView1.Items)
                {
                    string txt = item.SubItems[4].Text.ToEnglishNumber();
                    allPrice += long.Parse(txt);
                }
                label_جمع_فاکتور.Text = allPrice.ToString().MoneyFormat();
                ExportFactor = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void button_امروز_Click(object sender, EventArgs e)
        {
            maskedTextBox_تاریخ.Text = GlobalMethods.PersianDate(DateTime.Now.ToString(), false, true);
        }

        void Form_گزارش_روزانه_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        void printReport_CrystalReport_فاکتورهای_صادر_شده()
        {
            try
            {
                string printerName = "";
                printerName = (from q in dbc.Settings where q.name == "چاپگر سالن" select q.value).First();
                GlobalMethods.SetDefaultPrinter(printerName);

                SQL.DatabaseDataSet ds1 = new SQL.DatabaseDataSet();

                foreach (ListViewItem item in listView1.Items)
                    ds1.DataTable_گزارش_فاکتورهای_صادر_شده.Rows.Add(
                        item.SubItems[0].Text,
                        item.SubItems[1].Text,
                        item.SubItems[2].Text,
                        item.SubItems[3].Text,
                        item.SubItems[4].Text,
                        item.SubItems[5].Text);

                CrystalReport.CrystalReport_فاکتورهای_صادر_شده cr1 = new RezaRestaurant.CrystalReport.CrystalReport_فاکتورهای_صادر_شده();
                cr1.SetDataSource(ds1);

                //برای تشخیص اینکه آیا گزارش ، گزارش روزانه ، ماهانه ، یا سالانه است
                string theDate = maskedTextBox_تاریخ.Text.Trim().ToPersianNumber().Replace(" ", "");
                if (this.TypeOfReport == "روز")
                    cr1.SetParameterValue("Date", theDate);
                else if (this.TypeOfReport == "ماه")
                    cr1.SetParameterValue("Date", theDate.Remove(theDate.LastIndexOf('/')) + "   " + this.TypeOfReport);//تاریخ روز حذف می شود
                else if (this.TypeOfReport == "سال")
                    cr1.SetParameterValue("Date", theDate.Remove(theDate.IndexOf('/')) + "   " + this.TypeOfReport);//تاریخ روز و ماه حذف می شود

                cr1.SetParameterValue("PrintDate", GlobalMethods.PersianDate(DateTime.Now.ToString(), true, true));
                cr1.SetParameterValue("TotalPrice", label_جمع_فاکتور.Text);

                //cr1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;

                cr1.PrintToPrinter(1, false, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void printReport_CrystalReport_اقلام_فروخته_شده()
        {
            try
            {
                string printerName = "";
                printerName = (from q in dbc.Settings where q.name == "چاپگر سالن" select q.value).First();
                GlobalMethods.SetDefaultPrinter(printerName);

                SQL.DatabaseDataSet ds1 = new SQL.DatabaseDataSet();

                foreach (ListViewItem item in listView1.Items)
                    ds1.DataTable_گزارش_اقلام_مصرف_شده.Rows.Add(
                        item.SubItems[0].Text,
                        item.SubItems[1].Text,
                        item.SubItems[2].Text,
                        item.SubItems[3].Text,
                        item.SubItems[4].Text);

                CrystalReport.CrystalReport_اقلام_فروخته_شده cr1 = new RezaRestaurant.CrystalReport.CrystalReport_اقلام_فروخته_شده();
                cr1.SetDataSource(ds1);

                //برای تشخیص اینکه آیا گزارش ، گزارش روزانه ، ماهانه ، یا سالانه است
                string theDate = maskedTextBox_تاریخ.Text.Trim().ToPersianNumber().Replace(" ", "");
                if (this.TypeOfReport == "روز")
                    cr1.SetParameterValue("Date", theDate);
                else if (this.TypeOfReport == "ماه")
                    cr1.SetParameterValue("Date", theDate.Remove(theDate.LastIndexOf('/')) + "   " + this.TypeOfReport);//تاریخ روز حذف می شود
                else if (this.TypeOfReport == "سال")
                    cr1.SetParameterValue("Date", theDate.Remove(theDate.IndexOf('/')) + "   " + this.TypeOfReport);//تاریخ روز و ماه حذف می شود

                cr1.SetParameterValue("TotalPrice", label_جمع_فاکتور.Text);
                cr1.SetParameterValue("PrintDate", RezaRestaurant.Classes.GlobalMethods.PersianDate(DateTime.Now.ToString(), true, true));

                //cr1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;

                cr1.PrintToPrinter(1, false, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void button_چاپ_Click(object sender, EventArgs e)
        {
            if (ExportFactor)
                printReport_CrystalReport_فاکتورهای_صادر_شده();
            else
                printReport_CrystalReport_اقلام_فروخته_شده();
        }

        #region Sorting ListView

        private ListViewColumnSorter lvwColumnSorter;

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
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
                this.listView1.Sort();
            }
            catch { }
        }

        #endregion
    }
}
