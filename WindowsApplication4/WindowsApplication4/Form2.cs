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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EmployeeCRUP empCRUP=new EmployeeCRUP();
            dataGridView1.DataSource = empCRUP.GetEmployee();
        }
    }
}