using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace WindowsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerCRUP cusCRUP = new CustomerCRUP();
            cusCRUP.GetCustomer();
            dataGridView1.DataSource = cusCRUP.GetCustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sForm = new Form2();
            sForm.Show();
        }
    }
}