using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RezaRestaurant.Classes;

namespace RezaRestaurant.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            StaticVariables.Login = false;
            StaticVariables.LoginLabel.Text = "وارد نشده";
        }

        private void button_ورود_Click(object sender, EventArgs e)
        {
            using (RezaRestaurant.SQL.DataClasses1DataContext DataClasses1DataContext = new RezaRestaurant.SQL.DataClasses1DataContext())
            {
                errorProvider1.Clear();

                var user = from q in DataClasses1DataContext.Users
                           where q.pass.ToLower() == GlobalMethods.MD5(textBox_رمز.Text.Trim().ToLower())
                           select q;

                if (user.Count() >= 1)
                {
                    StaticVariables.Login = true;
                    StaticVariables.LoginLabel.Text = "وارد شده";
                    this.Close();
                }
                else
                {
                    StaticVariables.Login = false;
                    StaticVariables.LoginLabel.Text = "وارد نشده";
                    errorProvider1.SetError(this.textBox_رمز, "رمز عبور را اشتباه وارد کرده اید !");
                    return;
                }
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        private void textBox_رمز_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                button_ورود_Click(null, null);
        }
    }
}
