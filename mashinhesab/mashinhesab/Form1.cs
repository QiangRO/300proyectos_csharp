using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mashinhesab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         double ali;
         double ali2;
            ali = double.Parse(a.Text);
            ali2 = double.Parse(b.Text);
            ali = ali + ali2;
            MessageBox.Show("ÌæÇÈ :" + ali);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ali;
            double ali2;
            ali = double.Parse(a.Text);
            ali2 = double.Parse(b.Text);
            ali = ali - ali2;
            MessageBox.Show("ÌæÇÈ :" + ali);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ali;
            double ali2;
            ali = double.Parse(a.Text);
            ali2 = double.Parse(b.Text);
            ali = ali * ali2;
            MessageBox.Show("ÌæÇÈ :" + ali);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double ali;
            double ali2;
            ali = double.Parse(a.Text);
            ali2 = double.Parse(b.Text);
            ali = ali / ali2;
            MessageBox.Show("ÌæÇÈ :" + ali);
        }
    }
}