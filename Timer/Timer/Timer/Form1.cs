using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int i = 0;
        private int j = 0;
        private int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label26.Text = System.Convert.ToString(i = i + 1);
            if (i == 59)
            {
                i = 0;
                label24.Text = System.Convert.ToString(j = j + 1);
            }
            if (j == 59)
            {
                j = 0;
                label22.Text = System.Convert.ToString(k = k + 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            i = 0;
            j = 0;
            k = 0;
            label22.Text = "        ";
            label24.Text = "    ";
            label26.Text = "    ";
        }
    }
}