using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RezaRestaurant.Classes;
using System.Drawing.Printing;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using System.IO;

namespace RezaRestaurant
{
    public partial class Form_تنظیمات_نرم_افزار : Form
    {
        public Form_تنظیمات_نرم_افزار()
        {
            InitializeComponent();

            ///////////////////////////////
            try
            {
                using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
                {
                    //کمبو باکس های چاپگر آشپزخانه و چاپگر سالن مقدار دهی می شوند
                    string kitchenPrinter = "";
                    string salonPrinter = "";

                    try
                    {
                        kitchenPrinter = (from q in dbc.Settings where q.name == "چاپگر آشپزخانه" select q.value).First();
                        comboBox_چاپگر_آشپزخانه.Items.Add(kitchenPrinter);
                        comboBox_چاپگر_آشپزخانه.SelectedIndex = 0;
                    }
                    catch { }

                    try
                    {
                        salonPrinter = (from q in dbc.Settings where q.name == "چاپگر سالن" select q.value).First();
                        comboBox_چاپگر_سالن.Items.Add(salonPrinter);
                        comboBox_چاپگر_سالن.SelectedIndex = 0;
                    }
                    catch { }

                    foreach (string strPrinter in PrinterSettings.InstalledPrinters)
                    {
                        if (strPrinter != salonPrinter)
                            comboBox_چاپگر_سالن.Items.Add(strPrinter);
                        if (strPrinter != kitchenPrinter)
                            comboBox_چاپگر_آشپزخانه.Items.Add(strPrinter);
                    }
                    //\\
                    //کمبو باکس پشتیبان گیری اتوماتیک مقدار دهی می شود
                    string autoBackUp = "غیر فعال";
                    try
                    {
                        autoBackUp = dbc.Settings.Where(p => p.name == "پشتیبان گیری اتوماتیک").First().value;
                    }
                    catch { }
                    int index = comboBox_پشتیبان_گیری_اتوماتیک.Items.IndexOf(autoBackUp);
                    comboBox_پشتیبان_گیری_اتوماتیک.SelectedIndex = index;
                }
            }
            catch { }
        }

        void button_ثبت_رمز_ورود_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                labelReport.Text = "";

                using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
                {
                    var oldPassword = from q in dbc.Users
                                      where q.pass.ToLower() == GlobalMethods.MD5(textBox_رمز_قدیمی.Text.Trim().ToLower())
                                      select q;
                    if (oldPassword.Count() >= 1)
                    {
                        oldPassword.First().pass = GlobalMethods.MD5(textBox_رمز_جدید.Text.Trim());
                        dbc.SubmitChanges();
                    }
                    else
                    {
                        errorProvider1.SetError(this.textBox_رمز_قدیمی, "رمز قدیمی را اشتباه وارد کرده اید !");
                        return;
                    }
                    StaticVariables.Login = false;

                    labelReport.Visible = true;
                    labelReport.Text = "تغییرات اعمال شد";
                }
            }
            catch (Exception ex)
            {
                labelReport.Text = ex.Message;
            }
        }

        void Form_تنظیمات_نرم_افزار_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticVariables.Form_تنظیمات_نرم_افزار_IsShown = false;
        }

        void button_ثبت_چاپگر_Click(object sender, EventArgs e)
        {
            try
            {
                labelReport.Text = "";

                using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
                {
                    var kitchenPrinter = (from q in dbc.Settings where q.name == "چاپگر آشپزخانه" select q).First();
                    kitchenPrinter.value = comboBox_چاپگر_آشپزخانه.Text;
                    var salonPrinter = (from q in dbc.Settings where q.name == "چاپگر سالن" select q).First();
                    salonPrinter.value = comboBox_چاپگر_سالن.Text;
                    dbc.SubmitChanges();

                    labelReport.Text = "تغییرات با موفقیت ثبت شد";
                    labelReport.Visible = true;
                }
            }
            catch (Exception ex)
            {
                labelReport.Text = ex.Message;
            }
        }

        void button_پشتیبان_گیری_Click(object sender, EventArgs e)
        {
            try
            {
                labelReport.Text = "";

                using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
                {
                    var autoBackUp = (from q in dbc.Settings where q.name == "پشتیبان گیری اتوماتیک" select q).First();
                    autoBackUp.value = comboBox_پشتیبان_گیری_اتوماتیک.Text;
                    dbc.SubmitChanges();

                    labelReport.Text = "تغییرات با موفقیت ثبت شد";
                    labelReport.Visible = true;
                }
            }
            catch (Exception ex)
            {
                labelReport.Text = ex.Message;
            }
        }

        void control_Enter(object sender, EventArgs e)
        {
            labelReport.Text = "";
        }

        void Form_تنظیمات_نرم_افزار_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        #region backup restore

        private void button_تهیه_نسخه_پشتیبان_Click(object sender, EventArgs e)
        {
            try
            {
                labelReport.Visible = false;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
                        BackupDatabase(dbc.Connection.ConnectionString, dbc.Mapping.DatabaseName, saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// پشتیبان تهیه شده را بر می گرداند
        /// </summary>
        /// <param name="sConnect">Connection String</param>
        /// <param name="dbName">Database name</param>
        /// <param name="backUpPath">مسیر فایل پشتیبان</param>
        void RestoreDatabase(string sConnect, string dbName, string backUpPath)
        {
            using (SqlConnection cnn = new SqlConnection(sConnect))
            {
                cnn.Open();
                cnn.ChangeDatabase("master");

                ServerConnection sc = new ServerConnection(cnn);
                Server sv = new Server(sc);

                if (!sv.Databases.Contains(dbName))
                    throw new Exception("this DataBase does not exist");

                // Create backup device item for the backup
                BackupDeviceItem bdi = new BackupDeviceItem(backUpPath, DeviceType.File);

                // Create the restore object
                Restore resDB = new Restore();
                resDB.PercentComplete += new PercentCompleteEventHandler(percentComplete);
                resDB.PercentCompleteNotification = 1;
                resDB.Devices.Add(bdi);
                resDB.NoRecovery = false;
                resDB.ReplaceDatabase = true;
                resDB.Database = dbName;
                resDB.Action = RestoreActionType.Database;

                // Restore the database
                resDB.SqlRestore(sv);
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
                bk.PercentComplete += new PercentCompleteEventHandler(percentComplete);
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

        void percentComplete(object sender, PercentCompleteEventArgs e)
        {
            this.progressBarBackUp.Value = e.Percent;
            if (progressBarBackUp.Value >= progressBarBackUp.Maximum)
            {
                labelReport.Visible = true;
                labelReport.Text = "تغییرات اعمال شد";
            }
        }

        void button_بازگردانی_دیتا_بیس_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا اطمینان دارید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
                labelReport.Visible = false;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(Application.StartupPath + "\\SQL\\"))
                        Directory.CreateDirectory(Application.StartupPath + "\\SQL\\");
                    using (RezaRestaurant.SQL.DataClasses1DataContext dbc = new RezaRestaurant.SQL.DataClasses1DataContext())
                        RestoreDatabase(dbc.Connection.ConnectionString, Application.StartupPath + "\\SQL\\" + dbc.Mapping.DatabaseName + ".mdf", openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
