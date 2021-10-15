using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int f = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] colors = Enum.GetNames(typeof(KnownColor));
            foreach (string s in colors)
            {
                listBox1.Items.Add(s);
            }
            timer1.Enabled = true;
            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromName(listBox1.SelectedItem.ToString());

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            f++;
            if (f % 2 == 0)
                label2.ForeColor = Color.Red;
            else
                label2.ForeColor = Color.Blue;


        }
    }
}
