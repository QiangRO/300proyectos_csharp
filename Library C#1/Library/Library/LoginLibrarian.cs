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
    public partial class LoginLibrarian : Form
    {
        SqlConnection objConnection = new SqlConnection("server=(local);database=Library;trusted_connection=yes");
        public LoginLibrarian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLoginUserName.Text.Trim().Length > 0 && txtLoginPassword.Text.Trim().Length > 0)
            {
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "select FirstName,shomareshenasname from librarian where FirstName= N'" + txtLoginUserName.Text + "' AND shomareshenasname='" + txtLoginPassword.Text + "'";
                SqlDataReader objDataReader;
                objConnection.Open();
                objDataReader = objCommand.ExecuteReader();
                if (objDataReader.HasRows == true)
                {
                    MessageBox.Show("! " + "ورود شما موفقیت آمیز بود");
                    objConnection.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("! " + "لطفا از صحت اطلاعات ورودی مطمئن شوید");
                    objConnection.Close();

                }

                objCommand = null;
                objDataReader = null;
            }
            else
            {
                MessageBox.Show("! " + "لطفا جاهای خالی را پر کنید ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا شما خواستار لغو عملیات هستید؟", "Cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                this.Close();
        }
    }
}
