using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using n_Queens1;

namespace n_Queens1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                                                         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text ="%"+progressBar1.Value.ToString();   
            if (++progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Enabled = false; 
                MainFrm Frm = new MainFrm();
                Frm.ShowDialog(this); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.Table = Convert.ToInt16(comboBox1.Text); 
            timer1.Enabled = true; 
        }
    }
}
