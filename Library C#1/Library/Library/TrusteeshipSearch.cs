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
    public partial class TrusteeshipSearch : Form
    {
        public TrusteeshipSearch()
        {
            InitializeComponent();
        }

        private void TrusteeshipSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.SabteAmanat' table. You can move, or remove it, as needed.
            this.sabteAmanatTableAdapter.Fill(this.libraryDataSet.SabteAmanat);
          
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditTrusteeshipRegister edit = new EditTrusteeshipRegister();
            edit.ShowDialog(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "نام")
            {
                if (comboBox2.Text == "عین عبارت")
                {
                    sabteAmanatBindingSource.Filter = "FirstName='" + textBox1.Text + "'";
                }
                if (comboBox2.Text == "مشابه عبارت")
                {
                    sabteAmanatBindingSource.Filter = "FirstName like '%" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "مشابه عبارت از سمت راست")
                {
                    sabteAmanatBindingSource.Filter = "FirstName like '" + textBox1.Text + "%'";
                }
            }
            if (comboBox1.Text == "نام خانوادگی")
            {
                if (comboBox2.Text == "عین عبارت")
                {
                    sabteAmanatBindingSource.Filter = "LastName ='" + textBox1.Text + "'";
                }
                if (comboBox2.Text == "مشابه عبارت")
                {
                    sabteAmanatBindingSource.Filter = "LastName like '%" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "مشابه عبارت از سمت راست")
                {
                    sabteAmanatBindingSource.Filter = "LastName like '" + textBox1.Text + "%'";
                }
            }
            if (comboBox1.Text == "نام کتاب")
            {
                if (comboBox2.Text == "عین عبارت")
                {
                    sabteAmanatBindingSource.Filter = "BookName= '" + textBox1.Text + "'";
                }
                if (comboBox2.Text == "مشابه عبارت")
                {
                    sabteAmanatBindingSource.Filter = "BookName like '%" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "مشابه عبارت از سمت راست")
                {
                    sabteAmanatBindingSource.Filter = "BookName like '" + textBox1.Text + "%'";
                }
            }
        }
    }
}
