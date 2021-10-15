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
    public partial class RestoreBackup : Form
    {
        string path;

        public RestoreBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpath.Text.Length > 0)
            {
                //بازیابی بانک اطلاعاتی
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(local);database=Library;Integrated Security=SSPI";
                SqlCommand cmd = new SqlCommand();
                try
                {
                    con.Open();
                    //USE master RESTORE DATABASE [نام بانک اطلاعاتی] FROM DISK = 'مسیر فایل بانک اطلاعاتی'
                    string query = "USE master RESTORE DATABASE [Library] FROM DISK = '" + path + "'";

                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("بازیابی به درستی انجام شد");
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
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Restore File (*.MDF) |*.MDF";
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = op.FileName;
                path = op.FileName;
            }
        }
    }
}
