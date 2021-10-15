using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test()
        {
            MessageBox.Show("Multi Threading Test");
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Threading.Thread myThread1 = new System.Threading.Thread(test);
            myThread1.Start();
            System.Threading.Thread myThread2 = new System.Threading.Thread(test);
            myThread2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test();
            test();
        }
    }
}