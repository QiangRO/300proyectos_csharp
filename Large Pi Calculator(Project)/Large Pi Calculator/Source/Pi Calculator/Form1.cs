using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Salar_cpp_cs_PI;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.95;
            textBox2.Select();
            textBox2.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PI_Calculator pi = new PI_Calculator();
            textBox1.Text = pi.Get_PI(Convert.ToInt32(textBox2.Text));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string about = "";
            about = "نویسنده برنامه : سالار اشگی \n" + "تحت زبان : سی شارپ 2008 \n" + "تابستان 88";
            MessageBox.Show(about, "درباره ...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
