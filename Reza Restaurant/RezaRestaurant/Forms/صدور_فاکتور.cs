using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using RezaRestaurant.Forms;
using RezaRestaurant.Classes;
using System.Drawing.Printing;
using System.IO;
using System.Threading;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace RezaRestaurant
{
    public partial class Form_صدور_فاکتور : Form
    {
        #region fields

        /// <summary>
        /// این فیلد برای کار با دیتا بیس است
        /// </summary>
        RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext();

        /// <summary>
        /// شماره فاکتور
        /// </summary>
        int FactorNumber;

        /// <summary>
        /// شماره میز
        /// </summary>
        int? TableNumber;

        /// <summary>
        /// فرم لیست غذاهای موجود 
        /// در ابتدای نمایش فرم ، نمایش داده می شود
        /// </summary>
        Form_لیست_غذاها listOfFoodsForm = new Form_لیست_غذاها();

        /// <summary>
        /// کد غذای وارد شده
        /// </summary>
        int? foodCode = 0;

        /// <summary>
        /// اگر این فیلد صحیح باشد نشان دهنده این است که
        /// این فاکتور قبلا ثبت شده و عملیاتی که الان روی آن اعمال می شود باید 
        /// به صورت اصلاحیه باشد
        /// </summary>
        bool alreadyExist;

        /// <summary>
        /// شماره ردیف
        /// </summary>
        int rowNumber = 0;

        #endregion

        #region form's methods

        public Form_صدور_فاکتور()
        {
            InitializeComponent();

            lvwColumnSorter = new ListViewColumnSorter();
            this.listView_فاکتور.ListViewItemSorter = lvwColumnSorter;
        }

        void Form_صدور_فاکتور_Shown(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    FactorNumber = (from q in dbc.فاکتورهاs
                                    where (q.نوع_فاکتور == FactorType && q.تاریخ_ثبت >= TodayMorning)
                                    select q.شماره_فاکتور).Max();
                }
                catch { }
                FactorNumber++;

                long factorID = 0;
                try
                {
                    factorID = dbc.فاکتورهاs.Max(q => q.id);
                }
                catch { }
                factorID++;

                maskedTextBox_شماره_فاکتور.Text = FactorNumber.ToString();
                label_شماره_سریال.Text = factorID.ToString();

                if (!StaticVariables.Form_لیست_غذاها_IsShown)
                {
                    this.listOfFoodsForm.Show();
                    StaticVariables.Form_لیست_غذاها_IsShown = true;
                }
                this.textBox_شماره_میز.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Form_صدور_فاکتور_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.F5 && label_نوع_فاکتور.Text != "میز داخلی")
                {
                    label_نوع_فاکتور.Text = "میز داخلی";
                }
                else if (e.KeyData == Keys.F5 && label_نوع_فاکتور.Text != "سفارش خارجی")
                {
                    label_نوع_فاکتور.Text = "سفارش خارجی";
                }
                else if (e.KeyData == Keys.Left)
                {
                    e.SuppressKeyPress = true;
                    buttonBack_Click(null, null);
                }
                else if (e.KeyData == Keys.Right)
                {
                    e.SuppressKeyPress = true;
                    buttonNext_Click(null, null);
                }
                else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    UpDownArrow_Pressed();
                }
                else if (e.KeyCode == Keys.Back)
                {
                    e.SuppressKeyPress = true;
                    BackSpace();
                }
                else if (e.Shift && e.KeyCode == Keys.Delete)
                {
                    e.SuppressKeyPress = true;
                    ShiftDelete();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Form_صدور_فاکتور_Activated(object sender, EventArgs e)
        {
            this.textBox_شماره_میز.Focus();
        }

        void Form_صدور_فاکتور_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticVariables.Form_صدور_فاکتور_IsShown = false;
            if (StaticVariables.Form_لیست_غذاها_IsShown)
                this.listOfFoodsForm.Close();
            dbc.Connection.Close();
        }

        #endregion

        #region buttons's events

        void ShiftDelete()
        {
            try
            {
                long currentID = long.Parse(label_شماره_سریال.Text);
                var currentFactor = dbc.فاکتورهاs.Where(q => q.id == currentID);
                if (currentFactor.Count() <= 0) return;

                Form_پیغام form = new Form_پیغام("این فاکتور پاک می شود ،\n آیا مطمئن هستید ؟");
                form.button01.Text = "بلی";
                form.button02.Text = "خیر";
                form.Text = "اخطار";
                form.ShowDialog();

                if (StaticVariables.Message == "بلی")
                {
                    dbc.فاکتورهاs.DeleteAllOnSubmit(currentFactor);
                    dbc.SubmitChanges();
                    listView_فاکتور.Items.Clear();
                }
            }
            catch { }
        }

        void BackSpace()
        {
            if (listView_فاکتور.Items.Count == 0) return;
            uint allPrice = 0;
            uint lastRowPrice = 0;
            try
            {
                allPrice = uint.Parse(label_جمع_فاکتور.Text.ToEnglishNumber());
                lastRowPrice = uint.Parse(listView_فاکتور.Items[listView_فاکتور.Items.Count - 1].SubItems[4].Text.ToEnglishNumber());
            }
            catch { }

            allPrice -= lastRowPrice;
            label_جمع_فاکتور.Text = allPrice.ToString().MoneyFormat().ToPersianNumber();
            listView_فاکتور.Items[listView_فاکتور.Items.Count - 1].Remove();
        }

        void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                bool IsThereCurrentFactorNumberInDB = dbc.فاکتورهاs.Any(q =>
                                                                    q.شماره_فاکتور == FactorNumber &&
                                                                    q.نوع_فاکتور == FactorType &&
                                                                    q.تاریخ_ثبت >= TodayMorning);
                if (!IsThereCurrentFactorNumberInDB)
                {
                    listView_فاکتور.Items.Clear();
                    label_جمع_فاکتور.Text = "جمع فاکتور";
                    return;
                }

                bool IsThereNextFactorNumberInDB = dbc.فاکتورهاs.Any(q => q.شماره_فاکتور == (FactorNumber + 1) &&
                                                                    q.نوع_فاکتور == FactorType &&
                                                                    q.تاریخ_ثبت >= TodayMorning);
                if (!IsThereNextFactorNumberInDB)
                {
                    FactorNumber++;
                    maskedTextBox_شماره_فاکتور.Text = FactorNumber.ToString();
                    label_شماره_سریال.Text = (dbc.فاکتورهاs.Select(q => q.id).Max() + 1).ToString();
                    listView_فاکتور.Items.Clear();
                    label_جمع_فاکتور.Text = "جمع فاکتور";
                    textBox_شماره_میز.Clear();

                    return;
                }

                var nextFactor = (from q in dbc.فاکتورهاs
                                  where (q.شماره_فاکتور == (FactorNumber + 1) &&
                                         q.نوع_فاکتور == FactorType &&
                                         q.تاریخ_ثبت >= TodayMorning)
                                  select q).First();

                var nextFactorSoldItems = from q in dbc.اقلام_فروخته_شدهs
                                          where (q.FacotrID == nextFactor.id)
                                          select q;

                FactorNumber++;
                maskedTextBox_شماره_فاکتور.Text = FactorNumber.ToString();
                textBox_شماره_میز.Text = nextFactor.شماره_میز.HasValue ? nextFactor.شماره_میز.Value.ToString() : "";
                label_شماره_سریال.Text = nextFactor.id.ToString();

                listView_فاکتور.Items.Clear();

                int i = 0;
                foreach (var item in nextFactorSoldItems)
                {
                    i++;
                    string totalPrice = (item.قیمت_یک_واحد * item.تعداد).ToString();
                    ListViewItem newItem = new ListViewItem(new string[] { i.ToString().ToPersianNumber(), 
                                                                           item.نام_غذا, 
                                                                           item.تعداد.ToString().ToPersianNumber(), 
                                                                           item.قیمت_یک_واحد.ToString().MoneyFormat().ToPersianNumber(), 
                                                                           totalPrice.MoneyFormat().ToPersianNumber() });
                    newItem.Font = new Font("Tahoma", 12);
                    newItem.Name = item.نام_غذا;
                    listView_فاکتور.Items.Add(newItem);
                }

                long allPrice = 0;
                foreach (ListViewItem item in listView_فاکتور.Items)
                {
                    string txt = item.SubItems[4].Text.ToEnglishNumber();
                    allPrice += long.Parse(txt);
                }
                label_جمع_فاکتور.Text = allPrice.ToString().MoneyFormat();
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (FactorNumber - 1 == 0) return;

                bool IsTherePreviousFactorNumberInDB = dbc.فاکتورهاs.Any(q => q.شماره_فاکتور == (FactorNumber - 1) &&
                                                                         q.نوع_فاکتور == FactorType &&
                                                                         q.تاریخ_ثبت >= TodayMorning);
                if (!IsTherePreviousFactorNumberInDB)
                {
                    FactorNumber--;
                    maskedTextBox_شماره_فاکتور.Text = FactorNumber.ToString();
                    label_شماره_سریال.Text = (dbc.فاکتورهاs.Select(q => q.id).Max() + 1).ToString();
                    listView_فاکتور.Items.Clear();
                    label_جمع_فاکتور.Text = "جمع فاکتور";
                    textBox_شماره_میز.Clear();
                    return;
                }

                var previousFactor = (from q in dbc.فاکتورهاs
                                      where (q.شماره_فاکتور == (FactorNumber - 1) &&
                                             q.نوع_فاکتور == FactorType &&
                                             q.تاریخ_ثبت >= TodayMorning)
                                      select q).First();

                var previousFactorSoldItems = from q in dbc.اقلام_فروخته_شدهs
                                              where (q.FacotrID == previousFactor.id)
                                              select q;

                FactorNumber = previousFactor.شماره_فاکتور;
                maskedTextBox_شماره_فاکتور.Text = FactorNumber.ToString();
                label_شماره_سریال.Text = previousFactor.id.ToString();
                textBox_شماره_میز.Text = previousFactor.شماره_میز.HasValue ? previousFactor.شماره_میز.Value.ToString() : "";

                listView_فاکتور.Items.Clear();
                int i = 0;
                foreach (var item in previousFactorSoldItems)
                {
                    i++;
                    string totalPrice = (item.قیمت_یک_واحد * item.تعداد).ToString();
                    ListViewItem newItem = new ListViewItem(new string[] { i.ToString().ToPersianNumber(), 
                                                                           item.نام_غذا, 
                                                                           item.تعداد.ToString().ToPersianNumber(), 
                                                                           item.قیمت_یک_واحد.ToString().MoneyFormat().ToPersianNumber(), 
                                                                           totalPrice.MoneyFormat().ToPersianNumber() });
                    newItem.Font = new Font("Tahoma", 12);
                    newItem.Name = item.نام_غذا;
                    listView_فاکتور.Items.Add(newItem);
                }

                long allPrice = 0;
                foreach (ListViewItem item in listView_فاکتور.Items)
                {
                    string txt = item.SubItems[4].Text.ToEnglishNumber();
                    allPrice += long.Parse(txt);
                }
                label_جمع_فاکتور.Text = allPrice.ToString().MoneyFormat();
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void UpDownArrow_Pressed()
        {
            try
            {
                this.listView_فاکتور.Select();
            }
            catch { }
        }

        void button_ثبت_و_چاپ_فاکتور_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                rowNumber = 0;

                if (listView_فاکتور.Items.Count <= 0) return;
                if (textBox_شماره_میز.Text.Trim() == "" && textBox_شماره_میز.Enabled)
                {
                    errorProvider1.SetError(this.textBox_شماره_میز, "شماره میز را وارد کنید");
                    return;
                }

                //////////////
                long factorID = 0;
                try
                {
                    factorID = (from q in dbc.فاکتورهاs select q.id).Max();
                }
                catch { }
                factorID++;

                try
                {
                    if (textBox_شماره_میز.Enabled)
                        TableNumber = int.Parse(textBox_شماره_میز.Text.Trim());
                    else
                        TableNumber = null;
                }
                catch
                {
                    errorProvider1.SetError(this.textBox_شماره_میز, "شماره میز را صحیح وارد کنید");
                    return;
                }
                FactorNumber = int.Parse(maskedTextBox_شماره_فاکتور.Text.Trim());

                alreadyExist = dbc.فاکتورهاs.Any(q => q.شماره_فاکتور == FactorNumber &&
                                                      q.نوع_فاکتور == FactorType &&
                                                      q.تاریخ_ثبت >= TodayMorning);

                try
                {
                    printReport_CrystalReport();
                }
                catch
                {
                    MessageBox.Show("عملیات چاپ ناموفق بود ، اطلاعاتی ثبت نشد", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //////////////
                ///اگر فاکتوری با چنین شماره ای در امروز ثبت شده بود ، اطلاعات اصلاح می شود
                if (alreadyExist)
                {
                    RezaRestaurant.SQL.فاکتورها previousFactor = (from q in dbc.فاکتورهاs
                                                                  where (q.شماره_فاکتور == FactorNumber && q.نوع_فاکتور == FactorType && q.تاریخ_ثبت >= TodayMorning)
                                                                  select q).First();
                    factorID = previousFactor.id;

                    var previousSoldItems = from q in dbc.اقلام_فروخته_شدهs
                                            where q.FacotrID == previousFactor.id
                                            select q;
                    dbc.اقلام_فروخته_شدهs.DeleteAllOnSubmit(previousSoldItems);

                    previousFactor.مبلغ_فاکتور = long.Parse(label_جمع_فاکتور.Text.ToEnglishNumber());
                    previousFactor.شماره_فاکتور = FactorNumber;
                    previousFactor.شماره_میز = this.TableNumber;

                    dbc.SubmitChanges();
                }
                //اگر فاکتور از قبل در دیتا بیس وجود نداشت ، اطلاعات فاکتور جدید در دیتا بیس اضافه می شود
                else
                {
                    RezaRestaurant.SQL.فاکتورها NewFoodFactor = new RezaRestaurant.SQL.فاکتورها();
                    NewFoodFactor.id = factorID;
                    NewFoodFactor.تاریخ_ثبت = DateTime.Now;
                    NewFoodFactor.شماره_فاکتور = this.FactorNumber;
                    NewFoodFactor.نوع_فاکتور = label_نوع_فاکتور.Text;
                    NewFoodFactor.شماره_میز = this.TableNumber;
                    NewFoodFactor.مبلغ_فاکتور = long.Parse(label_جمع_فاکتور.Text.ToEnglishNumber());
                    dbc.فاکتورهاs.InsertOnSubmit(NewFoodFactor);
                    dbc.SubmitChanges();
                }

                foreach (ListViewItem item in listView_فاکتور.Items)
                {
                    RezaRestaurant.SQL.اقلام_فروخته_شده SoldItems = new RezaRestaurant.SQL.اقلام_فروخته_شده();
                    SoldItems.FacotrID = factorID;
                    SoldItems.نام_غذا = item.SubItems[1].Text.ToEnglishNumber();
                    SoldItems.تعداد = int.Parse(item.SubItems[2].Text.ToEnglishNumber());
                    SoldItems.قیمت_یک_واحد = int.Parse(item.SubItems[3].Text.ToEnglishNumber());
                    dbc.اقلام_فروخته_شدهs.InsertOnSubmit(SoldItems);
                    dbc.SubmitChanges();
                }

                bool IsFactorNumberWrong = true;
                while (IsFactorNumberWrong)
                {
                    this.FactorNumber++;
                    factorID++;
                    IsFactorNumberWrong = dbc.فاکتورهاs.Any(q => q.شماره_فاکتور == this.FactorNumber &&
                                                                 q.نوع_فاکتور == FactorType &&
                                                                 q.تاریخ_ثبت >= TodayMorning);
                }
                maskedTextBox_شماره_فاکتور.Text = FactorNumber.ToString();
                label_شماره_سریال.Text = factorID.ToString();

                listView_فاکتور.Items.Clear();
                label_جمع_فاکتور.Text = "جمع فاکتور";
                textBox_تعداد_غذا.Clear();
                textBox_کد_غذا.Clear();
                textBox_شماره_میز.Clear();

                textBox_شماره_میز.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void label_نوع_فاکتور_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.FactorType == "سفارش خارجی")
                {
                    textBox_شماره_میز.Enabled = label_شماره_میز.Enabled = false;
                    textBox_کد_غذا.Focus();
                    TableNumber = null;
                }
                else
                {
                    textBox_شماره_میز.Enabled = label_شماره_میز.Enabled = true;
                    textBox_شماره_میز.Focus();
                }

                try
                {
                    label_شماره_سریال.Text = (dbc.فاکتورهاs.Select(q => q.id).Max() + 1).ToString();
                }
                catch { }
                listView_فاکتور.Items.Clear();
                textBox_شماره_میز.Clear();
                textBox_تعداد_غذا.Clear();
                textBox_کد_غذا.Clear();

                var lastItemsFactor = from q in dbc.فاکتورهاs
                                      where (q.نوع_فاکتور == FactorType && q.تاریخ_ثبت >= TodayMorning)
                                      select q.شماره_فاکتور;
                if (lastItemsFactor.Count() <= 0)
                {
                    FactorNumber = 1;
                    maskedTextBox_شماره_فاکتور.Text = "1";
                    return;
                }
                FactorNumber = lastItemsFactor.Max() + 1;
                maskedTextBox_شماره_فاکتور.Text = FactorNumber.ToString();

            }
            catch { }
        }

        #endregion

        #region textbox's events

        void textBox_کد_غذا_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                TextBox senderTextBox = sender as TextBox;

                if (e.KeyData == Keys.Return)
                {
                    this.foodCode = int.Parse(textBox_کد_غذا.Text.Trim());
                    string foodName = "";
                    foodName = dbc.غذاهاs.Where(q => q.کد_غذا == foodCode).First().نام_غذا;
                    textBox_کد_غذا.Text = foodName;

                    textBox_تعداد_غذا.Text = "";
                    textBox_تعداد_غذا.Focus();
                }
                else if (e.KeyCode == Keys.Back)
                    e.SuppressKeyPress = true;
                else if (e.KeyCode == Keys.Delete)
                    senderTextBox.Text = "";
            }
            catch
            {
                (sender as TextBox).Text = "";
            }
        }

        void textBox_تعداد_غذا_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Return)
                {
                    if (textBox_کد_غذا.Text.Trim() == "" || textBox_تعداد_غذا.Text.Trim() == "") return;

                    //if (listView_فاکتور.Items.Count >= 1)
                    //    rowNumber = int.Parse(listView_فاکتور.Items[listView_فاکتور.Items.Count - 1].SubItems[0].Text.ToEnglishNumber());
                    string foodName = textBox_کد_غذا.Text.Trim();
                    int? foodPrice = 0;
                    long? allPrice = 0;

                    var theSameItems = listView_فاکتور.Items.Find(foodName, false);
                    if (theSameItems.Count() >= 1)
                    {
                        int تعداد_قبلی_غذا = int.Parse(listView_فاکتور.Items[theSameItems.First().Index].SubItems[2].Text.ToEnglishNumber());
                        int تعداد_جدید_غذا = int.Parse(textBox_تعداد_غذا.Text.Trim()) + تعداد_قبلی_غذا;
                        foodPrice = int.Parse(listView_فاکتور.Items[theSameItems.First().Index].SubItems[3].Text.ToEnglishNumber());
                        ///به روز کردن تعداد غذا
                        listView_فاکتور.Items[theSameItems.First().Index].SubItems[2].Text = تعداد_جدید_غذا.ToString().ToPersianNumber();
                        ///به روز کردن قیمت غذاها
                        listView_فاکتور.Items[theSameItems.First().Index].SubItems[4].Text = (تعداد_جدید_غذا * foodPrice.Value).ToString().ToPersianNumber().MoneyFormat();
                    }
                    else
                    {
                        foodPrice = dbc.غذاهاs.Where(q => q.کد_غذا == this.foodCode).First().قیمت;
                        allPrice = foodPrice * int.Parse(textBox_تعداد_غذا.Text.Trim());

                        rowNumber++;
                        ListViewItem newItem = new ListViewItem(new string[] { rowNumber.ToString().ToPersianNumber(), 
                                                                           textBox_کد_غذا.Text.Trim(), 
                                                                           textBox_تعداد_غذا.Text.Trim().ToPersianNumber(), 
                                                                           foodPrice.ToString().MoneyFormat().ToPersianNumber(), 
                                                                           allPrice.ToString().MoneyFormat().ToPersianNumber() });
                        newItem.Font = new Font("Tahoma", 12);
                        newItem.Name = foodName;
                        listView_فاکتور.Items.Add(newItem);
                    }

                    textBox_کد_غذا.Text = "";
                    textBox_کد_غذا.Focus();

                    allPrice = 0;
                    foreach (ListViewItem item in listView_فاکتور.Items)
                    {
                        string txt = item.SubItems[4].Text.ToEnglishNumber();
                        allPrice += long.Parse(txt);
                    }
                    label_جمع_فاکتور.Text = allPrice.ToString().MoneyFormat();

                }
                else if (e.KeyCode == Keys.Back)
                    e.SuppressKeyPress = true;
                else if (e.KeyCode == Keys.Delete)
                    (sender as TextBox).Text = "";
            }
            catch
            {
                (sender as TextBox).Text = "";
            }
        }

        void maskedTextBox_شماره_فاکتور_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (maskedTextBox_شماره_فاکتور.Text.Trim() == "") return;
                this.FactorNumber = int.Parse(maskedTextBox_شماره_فاکتور.Text.Trim());

                if (e.KeyCode == Keys.Delete)
                {
                    maskedTextBox_شماره_فاکتور.Text = "";
                    return;
                }
                else if (e.KeyCode != Keys.Return) return;

                if (FactorNumber <= 0) return;

                bool IsThereCurrentFactorNumberInDB = dbc.فاکتورهاs.Any(q => q.تاریخ_ثبت >= TodayMorning &&
                                                                        q.شماره_فاکتور == FactorNumber &&
                                                                        q.نوع_فاکتور == FactorType);
                if (!IsThereCurrentFactorNumberInDB)
                {
                    MessageBox.Show("چنین شماره فاکتوری در امروز ثبت نشده", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                var theFactor = (from q in dbc.فاکتورهاs
                                 where (q.شماره_فاکتور == FactorNumber && q.تاریخ_ثبت >= TodayMorning && q.نوع_فاکتور == FactorType)
                                 select q).First();

                var theSoldItems = from q in dbc.اقلام_فروخته_شدهs
                                   where (q.FacotrID == theFactor.id)
                                   select q;

                listView_فاکتور.Items.Clear();
                label_شماره_سریال.Text = theFactor.id.ToString();

                int i = 0;
                foreach (var item in theSoldItems)
                {
                    i++;
                    string totalPrice = (item.قیمت_یک_واحد * item.تعداد).ToString();
                    ListViewItem newItem = new ListViewItem(new string[] { i.ToString().ToPersianNumber(), 
                                                                           item.نام_غذا, 
                                                                           item.تعداد.ToString().ToPersianNumber(), 
                                                                           item.قیمت_یک_واحد.ToString().MoneyFormat().ToPersianNumber(), 
                                                                           totalPrice.MoneyFormat().ToPersianNumber() });
                    newItem.Font = new Font("Tahoma", 12);
                    newItem.Name = item.نام_غذا;
                    listView_فاکتور.Items.Add(newItem);
                }
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void textBox_شماره_میز_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Return)
                {
                    this.TableNumber = int.Parse((sender as TextBox).Text.Trim());
                    this.textBox_کد_غذا.Focus();
                }
                else if (e.KeyData == Keys.Delete)
                    this.textBox_شماره_میز.Text = "";

                int.Parse((sender as TextBox).Text.Trim());
            }
            catch
            {
                (sender as TextBox).Text = "";
            }
        }

        #endregion

        #region print methods

        void printReport_CrystalReport()
        {
            SQL.DatabaseDataSet ds1 = new SQL.DatabaseDataSet();
            foreach (ListViewItem item in listView_فاکتور.Items)
                ds1.DataTable_فاکتور.Rows.Add(
                    item.SubItems[0].Text,
                    item.SubItems[1].Text, item.SubItems[2].Text,
                    item.SubItems[3].Text, item.SubItems[4].Text);

            CrystalReport.CrystalReport_فاکتور cr1 = new RezaRestaurant.CrystalReport.CrystalReport_فاکتور();
            cr1.SetDataSource(ds1);

            ///نمایش متن اصلاحیه در فاکتور
            if (alreadyExist)
                cr1.SetParameterValue("Modify", "اصلاحیه");
            else
                cr1.SetParameterValue("Modify", "");
            ///

            cr1.SetParameterValue("FactorType", FactorType);//نوع فاکتور
            cr1.SetParameterValue("TotalPrice", label_جمع_فاکتور.Text);//مجموع قیمت فاکتور
            cr1.SetParameterValue("FactorNumber", this.FactorNumber);//شماره فاکتور
            if (TableNumber.Equals(null)) cr1.SetParameterValue("TableNumber", ""); else cr1.SetParameterValue("TableNumber", this.TableNumber);//شماره میز
            cr1.SetParameterValue("SerialNumber", label_شماره_سریال.Text);//شماره سریال فاکتور
            cr1.SetParameterValue("Date", GlobalMethods.PersianDate(DateTime.Now.ToString(), true, true));//تاریخ چاپ فاکتور

            //cr1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3;
            string printerName = "";
            printerName = (from q in dbc.Settings where q.name == "چاپگر سالن" select q.value).First();
            GlobalMethods.SetDefaultPrinter(printerName);
            cr1.PrintToPrinter(3, false, 0, 0);

            //printerName = "";
            //printerName = (from q in dbc.Settings where q.name == "چاپگر آشپزخانه" select q.value).First();
            //GlobalMethods.SetDefaultPrinter(printerName);
            //cr1.PrintToPrinter(2, false, 0, 0);
        }

        void printReport_HTML()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(StaticVariables.BackUPPath))
                {
                    sw.WriteLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
                    sw.WriteLine("<html xmlns=\"http://www.w3.org/1999/xhtml\">");
                    sw.WriteLine("<head>");
                    sw.WriteLine("<title>فاکتور</title>");
                    sw.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
                    sw.WriteLine("<style type=\"text/css\">.Btitr {	font: 24px \"B Titr\";}.Bzar{	font:24px \"B Zar\";}.Byekan{	font:22px \"B Yekan\";}</style>");
                    sw.WriteLine("</head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<table width=\"100%\" border=\"1\" align=\"center\">");
                    sw.WriteLine("<tr><td colspan=\"5\" align=\"center\" class=\"Btitr\">رستوران رضا</td></tr>");

                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td align=\"center\" class=\"Byekan\">جمع ريال</td>");
                    sw.WriteLine("<td align=\"center\" class=\"Byekan\"> مبلغ یک واحد ريال</td>");
                    sw.WriteLine("<td align=\"center\" class=\"Byekan\">تعداد</td>");
                    sw.WriteLine("<td align=\"center\" class=\"Byekan\">نوع غذا</td>");
                    sw.WriteLine("<td align=\"center\" class=\"Byekan\">شماره ردیف</td>");
                    sw.WriteLine("</tr>");

                    foreach (ListViewItem item in listView_فاکتور.Items)
                    {
                        sw.WriteLine("<tr>");
                        sw.WriteLine("<td align=\"center\" class=\"Bzar\">" + item.SubItems[4].Text + "</td>");
                        sw.WriteLine("<td align=\"center\" class=\"Bzar\">" + item.SubItems[3].Text + "</td>");
                        sw.WriteLine("<td align=\"center\" class=\"Bzar\">" + item.SubItems[2].Text + "</td>");
                        sw.WriteLine("<td align=\"center\" class=\"Bzar\">" + item.SubItems[1].Text + "</td>");
                        sw.WriteLine("<td align=\"center\" class=\"Bzar\">" + item.SubItems[0].Text + "</td>");
                        sw.WriteLine("</tr>");
                    }

                    sw.WriteLine("</table></body></html>");
                    sw.Close();
                }

                string printerName = "";
                printerName = (from q in dbc.Settings where q.name == "چاپگر سالن" select q.value).First();

                WebBrowser webBrowser1 = new WebBrowser();
                webBrowser1.Navigate(StaticVariables.BackUPPath);
                webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Print the document now that it is fully loaded.
            ((WebBrowser)sender).Print();

            // Dispose the WebBrowser now that the task is complete. 
            ((WebBrowser)sender).Dispose();
        }

        #endregion

        #region ListView's events

        void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listView_فاکتور.SelectedItems[0].Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void listView_فاکتور_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                    contextMenuStrip1.Show(this.listView_فاکتور, new Point(e.X, e.Y));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void listView_فاکتور_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                    this.listView_فاکتور.SelectedItems[0].Remove();

                long allPrice = 0;
                foreach (ListViewItem item in listView_فاکتور.Items)
                {
                    string txt = item.SubItems[4].Text.ToEnglishNumber();
                    allPrice += long.Parse(txt);
                }
                label_جمع_فاکتور.Text = allPrice.ToString().MoneyFormat();
            }
            catch { }
        }

        #endregion

        #region properties

        string FactorType
        {
            get
            {
                if (label_نوع_فاکتور.Text.Contains("میز داخلی"))
                    return "میز داخلی";
                else
                    return "سفارش خارجی";
            }
            set
            {
                label_نوع_فاکتور.Text = value;
            }
        }

        DateTime TodayMorning
        {
            get { return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day); }
        }

        DateTime _24HoursFormer
        {
            get { return DateTime.Now.AddHours(-24); }
        }

        #endregion

        #region Sorting ListView

        private ListViewColumnSorter lvwColumnSorter;

        private void listView_فاکتور_Click(object sender, ColumnClickEventArgs e)
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
                this.listView_فاکتور.Sort();
            }
            catch { }
        }

        #endregion
    }
}
