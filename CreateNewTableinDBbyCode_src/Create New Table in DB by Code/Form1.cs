using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Create_New_Table_in_DB_by_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\DB\DataBase.accdb";
            this.myCommand.Connection = this.myConnection;   
            if (!GetTbNames()) { MessageBox.Show("دريافت اطلاعات از بانك با خطا مواجه شد"); btCreate.Enabled = false; }
        }
        
        private bool GetTbNames()
        {
            Boolean flag = true;
            try
            {
                
                myCommand.CommandText = "SELECT TBName FROM TbNames";
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                { tableList.Add(myReader.GetString(0).Clone()); i++; }
                label2.Text = i.ToString();
                myReader.Close();
                myConnection.Close();
            }
            catch { flag = false; }
            return flag;
        }

        #region "Show About Form"
        private void btAbout_Click(object sender, EventArgs e)
        {
            using (About f = new About()) { f.ShowDialog(); f.Dispose(); }
        }
        #endregion

        private void btCreate_Click(object sender, EventArgs e)
        {
            Create("SELECT * INTO " + textBox1.Text + " FROM Table1");
        }
        private bool Create(string CommandText)
        {
            bool flag=true;
            foreach (object tbname in tableList)
            { if (textBox1.Text == tbname.ToString()) { flag = false; break; } }
            if (flag)
            {
                try
                {
                    myCommand.CommandText = CommandText;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.CommandText = "INSERT INTO TbNames (ID, TBName) VALUES (" + (i-1) + ", '" + textBox1.Text + "')";
                    myCommand.ExecuteNonQuery(); myConnection.Close();
                    MessageBox.Show("جدول جديد با موفقيت ايجاد گرديد");
                    i++; label2.Text = i.ToString();
                    tableList.Add(textBox1.Text.Clone());
                }
                catch(Exception ex) { MessageBox.Show(ex.ToString()+"\n"+"ايجاد جدول جديد با مشكل مواجه شد"); }
            }
            else { MessageBox.Show("با اين نام قبلاً در ديتابيس جدولي ثبت شده است"); }
            return flag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create("CREATE TABLE " + textBox1.Text + "(ID NUMBER, Name CHAR(30))");
        }
    }
}
