using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Access_pas
{
    public partial class Form1 : Form
    {
        #region "Construct"
        public Form1()
        { InitializeComponent(); GetIDs(); }

        //اين متد قبل از اجراي برنامه شماره كاربري هايي كه قبلاً ثبت شده از بانك خوانده و در يك كانلكشن قرار مي دهد
        private bool GetIDs()
        {
            bool flag = true;
            try
            {
                OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\App_Data\Focus_Team_TestPas.mdb;Jet OLEDB:Database Password=ahmad");
                OleDbCommand myCommand = new OleDbCommand();
                myConnection.Open();
                myCommand.Connection = myConnection;
                myCommand.CommandText = "SELECT COUNT(ID) FROM FT";
                if (myCommand.ExecuteScalar().ToString() != "0")
                {
                    myCommand.CommandText = "SELECT ID FROM FT";
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        Codes.Add(myReader.GetValue(0));
                    }
                    myReader.Close();
                    label5.Text = "تعداد كاربر موجود در بانك" + ":  " + Codes.Count.ToString();
                }
                myConnection.Close();
            }
            catch (Exception ex) { flag = false; MessageBox.Show("خطاي دريافت اطلاعات از بانك وجود دارد" + "." + "\n\n" + ex.ToString()); }
            return flag;
        }
        #endregion

        #region "Exit Form"
        private void btExit_Click(object sender, EventArgs e) { Close(); }
        #endregion

        #region "About Form"
        private void btAbout_Click(object sender, EventArgs e)
        { 
            using (About form = new About()) 
            { form.ShowDialog(); } }
        #endregion

        #region "Get Info"
        //دريافت اطلاعات كاربر با مشخص كردن شماره كاربري توسط اين متد انجام مي گردد
        private void btGet_Click(object sender, EventArgs e)
        {
            if (TxtPNull())
            {
                if (tbPass.Text == "ahmad")
                {
                    try
                    {
                        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\App_Data\Focus_Team_TestPas.mdb;Jet OLEDB:Database Password=" + tbPass.Text + "");
                        OleDbCommand myCommand = new OleDbCommand();
                        myConnection.Open();
                        myCommand.Connection = myConnection;
                        myCommand.CommandText = "SELECT FName, LName FROM FT WHERE ID=" + Int32.Parse(tbID.Text) + "";
                        OleDbDataReader myReader = myCommand.ExecuteReader();
                        if (myReader.Read())
                        {
                            tbFName.Text = myReader.GetString(0);
                            tbLName.Text = myReader.GetString(1);
                        }
                        else { MessageBox.Show("هيچ كاربري با اين شماره كاربري در بانك موجود نيست", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    catch (Exception ex) { MessageBox.Show("خطاي اتصال به بانك وجود دارد" + "." + "\n\n" + ex.ToString()); }
                }
                else {MessageBox.Show("پسورد وارد شده اشتباه مي باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("براي نمايش اطلاعات كاربر بايد شماره كاربري و پسورد بانك را وارد كنيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /// <summary>
        /// براي نمايش اطلاعات بايد شماره كاربري و پسورد بانك مشخص گردد. در صورت خالي بودن اين متد مقدار اشتباه باز مي گرداند
        /// </summary>
        /// <returns></returns>
        private bool TxtPNull()
        {
            return (tbPass.Text == string.Empty || tbPass.Text == "" ||
                 tbID.Text == string.Empty || tbID.Text == "") ? false : true;
        }
        #endregion

        #region "Insert NewUser"
        private void btInsert_Click(object sender, EventArgs e)
        {
            if (TxtNull())
            {
                if (IDExist())
                {
                    if (tbPass.Text == "ahmad")
                    {
                        try
                        {
                            OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\App_Data\Focus_Team_TestPas.mdb;Jet OLEDB:Database Password=" + tbPass.Text + "");
                            OleDbCommand myCommand = new OleDbCommand();
                            myConnection.Open();
                            myCommand.Connection = myConnection;
                            myCommand.CommandText = "INSERT INTO FT (ID, FName, LName) VALUES (" + Int32.Parse(tbID.Text) + ",'" + tbFName.Text + "','" + tbLName.Text + "')";
                            myCommand.ExecuteNonQuery();
                            myConnection.Close();
                            Codes.Add(tbID.Text.Clone());
                            label5.Text = "تعداد كاربر موجود در بانك" + ":  " + Codes.Count.ToString();
                            MessageBox.Show("ثبت با موفقيت انجام شد");
                        }
                        catch (Exception ex) { MessageBox.Show("خطاي اتصال به بانك وجود دارد" + "." + "\n\n" + ex.ToString()); }
                    }
                    else { MessageBox.Show("پسورد وارد شده اشتباه مي باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("كاربري با اين شماره قبلاً ثبت شده است"); }
            }
            else { MessageBox.Show("براي ادامه كار بايد تمام فيلدها را پر كنيد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /// <summary>
        /// اين متد اگر يكي از فيلدها خالي باشد مقدار اشتباه برمي گرداند
        /// </summary>
        /// <returns></returns>
        private bool TxtNull()
        {
            return (tbPass.Text == string.Empty || tbPass.Text == "" ||
                tbID.Text == string.Empty || tbID.Text == "" ||
                tbFName.Text == string.Empty || tbFName.Text == "" ||
                tbLName.Text == string.Empty || tbLName.Text == "") ? false : true;
        }

        /// <summary>
        /// اين متد اگر قبلاً كاربري با شماره كاربري كه در خواست ثبت آن را داريد يكي باشد مقدار اشتباه باز مي گرداند
        /// </summary>
        /// <returns></returns>
        private bool IDExist()
        {
            bool flag = true;
            if (Codes.Count != 0)
                foreach (object id in Codes)
                { if (tbID.Text.CompareTo(id.ToString()) == 0) { flag = false; break; } }
            return flag;
        }
        #endregion

        #region  "KeyEventHandler tbID"
        //اين بخش اجازه تايپ غير عددي در تكس باكس شماره كاربري را نمي دهد 
        private void tbID_keydown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            this.tbID.Capture = true;
            // Check if current key is number or not
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                    if (e.KeyCode != Keys.OemMinus)
                        if (e.KeyCode != Keys.Subtract)
                                if (e.KeyCode != Keys.Back)
                                    this.tbID.Capture = false;
        }

        private void tbID_keypress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (this.tbID.Capture == false)
                e.Handled = true;
        }

        #endregion
    }
}

