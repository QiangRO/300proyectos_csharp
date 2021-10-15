using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using RezaRestaurant.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Globalization;
using System.IO;
using System.Data.Linq;

namespace RezaRestaurant
{
    public partial class MainForm : Form
    {
        MohammadDayyanCalendar.MDCalendar mdCalendar = new MohammadDayyanCalendar.MDCalendar();

        public MainForm()
        {
            InitializeComponent();

            ////////////////////////////////////
            timerForDate.Enabled = true;
            timerForDate.Start();

            //با نسبت دادن پروپرتی 
            //StaticVariables.LoginLabel 
            //به this.label_وضعیت_ورود
            //هر گاه پروپرتی اولی تغییر کند ، لیبل هم تغییر می کند
            //این کار برای تغییر لیبل وضعیت ورود توسط فرم های دیگر انجام داده شده
            StaticVariables.LoginLabel = this.label_وضعیت_ورود;
        }

        void button_صدور_فاکتور_Click(object sender, EventArgs e)
        {
            try
            {
                if (!StaticVariables.Form_صدور_فاکتور_IsShown)
                {
                    Form_صدور_فاکتور newForm = new Form_صدور_فاکتور();
                    newForm.Show();
                    StaticVariables.Form_صدور_فاکتور_IsShown = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void button_گزارش_روزانه_Click(object sender, EventArgs e)
        {
            try
            {
                if (!StaticVariables.Login)
                {
                    FormLogin loginForm = new FormLogin();
                    loginForm.ShowDialog();
                }
                if (StaticVariables.Login)
                {
                    if (!StaticVariables.Form_گزارش_روزانه_IsShown)
                    {
                        Form_گزارش_روزانه newForm = new Form_گزارش_روزانه();
                        newForm.Show();
                        StaticVariables.Form_گزارش_روزانه_IsShown = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void button_جستجو_Click(object sender, EventArgs e)
        {
            try
            {
                if (!StaticVariables.Login)
                {
                    FormLogin loginForm = new FormLogin();
                    loginForm.ShowDialog();
                }
                if (StaticVariables.Login)
                {
                    if (!StaticVariables.Form_جستجو_IsShown)
                    {
                        Form_جستجو searchForm = new Form_جستجو();
                        searchForm.Show();
                        StaticVariables.Form_جستجو_IsShown = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void button_خاموش_Click(object sender, EventArgs e)
        {
            try
            {
                StaticVariables.Message = "";

                Form_پیغام form = new Form_پیغام("آیا مطمئن هستید ؟");
                form.Text = "خاموش کردن سیستم";
                form.button01.Text = "بلی";
                form.button02.Text = "خیر";
                form.ShowDialog();

                if (StaticVariables.Message == "بلی")
                {
                    ManagementBaseObject mboShutdown = null;
                    ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
                    mcWin32.Get();
                    // You can't shutdown without security privileges
                    mcWin32.Scope.Options.EnablePrivileges = true;
                    ManagementBaseObject mboShutdownParams = mcWin32.GetMethodParameters("Win32Shutdown");
                    // Flag 1 means we want to shut down the system
                    mboShutdownParams["Flags"] = "1";
                    mboShutdownParams["Reserved"] = "0";
                    foreach (ManagementObject manObj in mcWin32.GetInstances())
                        mboShutdown = manObj.InvokeMethod("Win32Shutdown", mboShutdownParams, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void button_کدهای_غذا_Click(object sender, EventArgs e)
        {
            try
            {
                if (!StaticVariables.Login)
                {
                    FormLogin loginForm = new FormLogin();
                    loginForm.ShowDialog();
                }
                if (StaticVariables.Login)
                {
                    if (!StaticVariables.Form_کدهای_غذا_IsShown)
                    {
                        Form_کدهای_غذا form = new Form_کدهای_غذا();
                        form.Show();
                        StaticVariables.Form_کدهای_غذا_IsShown = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void button_تنظیمات_Click(object sender, EventArgs e)
        {
            try
            {
                if (!StaticVariables.Login)
                {
                    FormLogin loginForm = new FormLogin();
                    loginForm.ShowDialog();
                }
                if (StaticVariables.Login)
                {
                    if (!StaticVariables.Form_تنظیمات_نرم_افزار_IsShown)
                    {
                        Form_تنظیمات_نرم_افزار form = new Form_تنظیمات_نرم_افزار();
                        form.Show();
                        StaticVariables.Form_تنظیمات_نرم_افزار_IsShown = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void timerForDate_Tick(object sender, EventArgs e)
        {
            try
            {
                double IranTime = mdCalendar.Time() + (3.5 * 60 * 60);
                label1_تاریخ_امروز.Text = mdCalendar.Date("W D M Y", IranTime, true);
                label1_ساعت.Text = mdCalendar.Date("s : i : H", IranTime, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //    this.WindowState = FormWindowState.Maximized;
        }

        void button_لیست_غذاها_Click(object sender, EventArgs e)
        {
            if (!StaticVariables.Form_لیست_غذاها_IsShown)
            {
                Form_لیست_غذاها form = new Form_لیست_غذاها();
                form.Show();
                StaticVariables.Form_لیست_غذاها_IsShown = true;
            }
        }

        #region BackUp methods

        bool firstAttempt = true;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                if (firstAttempt)
                {
                    firstAttempt = false;
                    e.Cancel = true;
                    GetBackUp();
                }
            }
            catch
            {
                firstAttempt = false;
            }
        }

        /// <summary>
        /// این تابع از دیتا بیس پشتیبان تهیه می کند
        /// </summary>
        void GetBackUp()
        {
            try
            {
                using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
                {
                    string autoBackUp = dbc.Settings.Where(q => q.name == "پشتیبان گیری اتوماتیک").First().value;
                    if (autoBackUp == "غیر فعال")
                    {
                        this.Close();
                        return;
                    }

                    //بدست آوردن زمان پشتیبان گیری تعیین شده توسط کاربر
                    int autoBackupHours = 12;
                    if (autoBackUp == "هر 24 ساعت")
                        autoBackupHours = 24;
                    else if (autoBackUp == "هر 1 هفته")
                        autoBackupHours = 24 * 7;
                    else if (autoBackUp == "هر 1 ماه")
                        autoBackupHours = 24 * 30;

                    if (!Directory.Exists(StaticVariables.BackUPPath))
                        Directory.CreateDirectory(StaticVariables.BackUPPath);

                    PersianCalendar pc = new PersianCalendar();
                    int PersianYear = pc.GetYear(DateTime.Now);
                    int PersianMonth = pc.GetMonth(DateTime.Now);
                    int PersianDay = pc.GetDayOfMonth(DateTime.Now);

                    string path = StaticVariables.BackUPPath + PersianYear + "." + PersianMonth + "." + PersianDay + ".bak";

                    //بررسی اینکه آخرین زمان گرفتن پشتیبان از دیتا بیس کی بوده
                    var lastBackUpDate = dbc.Settings.Where(q => q.name == "آخرین تاریخ back up").First();
                    DateTime lastBackUp;

                    //اگر اصلا چیزی ثبت نشده باشه در دیتا بیس ، پشتیبان تهیه میشه
                    try
                    {
                        lastBackUp = DateTime.Parse(lastBackUpDate.value);
                    }
                    catch
                    {
                        BackupDatabase(dbc.Connection.ConnectionString, Application.StartupPath + "\\SQL\\" + dbc.Mapping.DatabaseName + ".mdf", path);
                        lastBackUpDate.value = DateTime.Now.ToString();
                        dbc.SubmitChanges();
                        return;
                    }

                    //همچنین اگر آخرین زمان گرفتن پشتیبان مربوط به 12 ساعت قبل باشه ، دوباره پشتیبان تهیه می شود
                    if (lastBackUp < DateTime.Now.AddHours(-autoBackupHours))
                    {
                        BackupDatabase(dbc.Connection.ConnectionString, Application.StartupPath + "\\SQL\\" + dbc.Mapping.DatabaseName + ".mdf", path);
                        lastBackUpDate.value = DateTime.Now.ToString();
                        dbc.SubmitChanges();
                    }

                    this.Close();
                    //\\
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstAttempt = false;
                this.Close();
            }
        }

        /// <summary>
        /// از دیتا بیس پشتیبان تهیه می کند
        /// </summary>
        /// <param name="sConnect">Connection String</param>
        /// <param name="dbName">Database name</param>
        /// <param name="backUpPath">مسیر ذخیره کردن فایل پشتیبان</param>
        void BackupDatabase(string sConnect, string dbName, string backUpPath)
        {
            this.label_وضعیت_ورود.Text = "پشتیبان گیری اتوماتیک از دیتا بیس فعال شد ، کمی صبر کنید";
            this.progressBarBackUp.Visible = true;
            using (SqlConnection cnn = new SqlConnection(sConnect))
            {
                cnn.Open();
                dbName = cnn.Database.ToString();

                ServerConnection sc = new ServerConnection(cnn);
                Server sv = new Server(sc);

                // Create backup device item for the backup
                BackupDeviceItem bdi = new BackupDeviceItem(backUpPath, DeviceType.File);

                // Create the backup informaton
                Backup bk = new Backup();
                bk.PercentComplete += new PercentCompleteEventHandler(bk_PercentComplete);
                bk.Complete += new ServerMessageEventHandler(bk_Complete);
                bk.Devices.Add(bdi);
                bk.Action = BackupActionType.Database;
                bk.PercentCompleteNotification = 1;
                bk.BackupSetDescription = dbName;
                bk.BackupSetName = dbName;
                bk.Database = dbName;
                //bk.ExpirationDate = DateTime.Now.AddDays(30);
                bk.LogTruncation = BackupTruncateLogType.Truncate;
                bk.FormatMedia = false;
                bk.Initialize = true;
                bk.Checksum = true;
                bk.ContinueAfterError = true;
                bk.Incremental = false;

                // Run the backup
                bk.SqlBackup(sv);
            }
        }

        void bk_Complete(object sender, ServerMessageEventArgs e)
        {
            this.progressBarBackUp.Value = this.progressBarBackUp.Maximum;
            this.Close();
        }

        void bk_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            this.progressBarBackUp.Value = e.Percent;
        }

        #endregion

        #region create database

        void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(StaticVariables.DBFolder))
                Directory.CreateDirectory(StaticVariables.DBFolder);

            string path = StaticVariables.DBFolder + "RRDB.mdf";
            RezaRestaurant.SQL.DataClasses1DataContext db = new RezaRestaurant.SQL.DataClasses1DataContext(path);

            try
            {
                if (!db.DatabaseExists() && !File.Exists(path))
                {
                    db.CreateDatabase();

                    SQL.Setting setting1 = new RezaRestaurant.SQL.Setting();
                    setting1.name = "چاپگر آشپزخانه";
                    setting1.value = null;

                    SQL.Setting setting2 = new RezaRestaurant.SQL.Setting();
                    setting2.name = "چاپگر سالن";
                    setting2.value = null;

                    SQL.Setting setting3 = new RezaRestaurant.SQL.Setting();
                    setting3.name = "آخرین تاریخ back up";
                    setting3.value = null;

                    SQL.Setting setting4 = new RezaRestaurant.SQL.Setting();
                    setting4.name = "پشتیبان گیری اتوماتیک";
                    setting4.value = "غیر فعال";

                    db.Settings.InsertOnSubmit(setting1);
                    db.Settings.InsertOnSubmit(setting2);
                    db.Settings.InsertOnSubmit(setting3);
                    db.Settings.InsertOnSubmit(setting4);

                    SQL.User user1 = new RezaRestaurant.SQL.User();
                    user1.pass = "827ccb0eea8a706c4c34a16891f84e7b";
                    SQL.User user2 = new RezaRestaurant.SQL.User();
                    user2.pass = "744004b072b72ab27abbbe6586917082";

                    db.Users.InsertOnSubmit(user1);
                    db.Users.InsertOnSubmit(user2);

                    db.SubmitChanges();
                }
            }
            catch
            {
                try
                {
                    if (db.DatabaseExists())
                        db.DeleteDatabase();
                }
                catch { }
                MessageBox.Show("دیتا بیس پیدا نشد ، لطفا برنامه را در جای دیگر کپی کنید و دوباره برنامه را اجرا کنید", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
