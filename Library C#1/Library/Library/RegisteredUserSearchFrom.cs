using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class RegisteredUserSearchFrom : Form
    {
        public RegisteredUserSearchFrom()
        {
            InitializeComponent();
        }

        private void RegisteredUserSearchFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.RegisterUser' table. You can move, or remove it, as needed.
            this.registerUserTableAdapter.Fill(this.libraryDataSet.RegisterUser);
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text;
            if (comboBox1.Text == "شماره شناسنامه")
            {
                comboBox2.Text = "عین عبارت";
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "شماره شناسنامه")
            {
                registerUserBindingSource.Filter = "shomareshenasname=" + textBox1.Text + "";
            }
            if (comboBox1.Text == "نام")
            {

                if (comboBox2.Text == "مشابه عبارت از سمت راست")
                {
                    registerUserBindingSource.Filter = "FirstName like '" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "مشابه عبارت")
                {
                    registerUserBindingSource.Filter = "FirstName like'%" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "عین عبارت")
                {
                    registerUserBindingSource.Filter = "FirstName='" + textBox1.Text + "'";
                }

            }
            if (comboBox1.Text == "نام خانوادگی")
            {

                if (comboBox2.Text == "مشابه عبارت از سمت راست")
                {
                    registerUserBindingSource.Filter = "LastName like '" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "مشابه عبارت")
                {
                    registerUserBindingSource.Filter = "LastName like'%" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "عین عبارت")
                {
                    registerUserBindingSource.Filter = "LastName='" + textBox1.Text + "'";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditReisterUser ed = new EditReisterUser();
            ed.ShowDialog(this);
        }
    }
}

