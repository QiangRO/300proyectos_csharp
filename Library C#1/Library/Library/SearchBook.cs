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
    public partial class SearchBook : Form
    {
        public SearchBook()
        {
            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.BookDetails' table. You can move, or remove it, as needed.
            this.bookDetailsTableAdapter.Fill(this.libraryDataSet.BookDetails);
            
            comboBox1.Items.Add("ISBN");
            comboBox1.Items.Add("نام کتاب");
            comboBox1.Items.Add("نویسنده");
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("عین عبارت");
            comboBox2.Items.Add("مشابه عبارت");
            comboBox2.Items.Add("مشابه عبارت از سمت راست");
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ISBN")
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
            if (comboBox1.Text == "ISBN")
            {
                bookDetailsBindingSource.Filter = "Isbn ='" + textBox1.Text + "'";
            }
            if (comboBox1.Text == "نام کتاب")
            {
                if (comboBox2.Text == "عین عبارت")
                {
                    bookDetailsBindingSource.Filter = "BookName='" + textBox1.Text + "'";
                }
                if (comboBox2.Text == "مشابه عبارت")
                {
                    bookDetailsBindingSource.Filter = "BookName like '%" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "مشابه عبارت از سمت راست")
                {
                    bookDetailsBindingSource.Filter = "BookName like '" + textBox1.Text + "%'";
                }
            }
            if (comboBox1.Text == "نویسنده")
            {
                if (comboBox2.Text == "عین عبارت")
                {
                    bookDetailsBindingSource.Filter = "author='" + textBox1.Text + "'";
                }
                if (comboBox2.Text == "مشابه عبارت")
                {
                    bookDetailsBindingSource.Filter = "author like '%" + textBox1.Text + "%'";
                }
                if (comboBox2.Text == "مشابه عبارت از سمت راست")
                {
                    bookDetailsBindingSource.Filter = "author like '" + textBox1.Text + "%'";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditAddBook edit = new EditAddBook();
            edit.ShowDialog(this);

        }
    }
}