using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class BackupDeatabase : Form
    {
        string MasterPath = "";

        public BackupDeatabase()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            if (browse.ShowDialog() == DialogResult.OK)
            {
                MasterPath = browse.SelectedPath;
                textBox1.Text = MasterPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                MessageBox.Show("در حین عملیات به چیزی دست نزنید");
                System.IO.Directory.CreateDirectory(MasterPath + @"\BackupLibrary");
                //پشتیبان گیری از بانک اطلاعاتی
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(local);database=Library;Integrated Security=SSPI";
                SqlCommand cmd = new SqlCommand();
                try
                {
                    con.Open();
                    //BACKUP DATABASE نام بانک اطلاعاتی TO DISK = 'مسیر پشتیبان گیری بانک اطلاعاتی'
                    string query = "BACKUP DATABASE Library TO DISK = '" + MasterPath + @"\BackupLibrary" + "\\Library.MDF" + "'";
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("پشتیبان گیری به درستی انجام شد");
                }
                catch
                {
                    MessageBox.Show("اشکال در ارتباط با بانک اطلاعاتی");
                }
            }
            else
            {
                MessageBox.Show(" ! " + "مسیر انتخاب نشده است", "خطا");
            }
        }
    }
}
