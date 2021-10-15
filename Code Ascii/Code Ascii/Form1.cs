using System;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Code_Ascii
{
    public partial class Form1 : Form
    {
        int a;
        string b;
        public Form1()
        {
            InitializeComponent();
        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            if (textBox1.Text=="") 
                textBox2.Text=" ";
            else 
                a = Char.ConvertToUtf32(textBox1.Text,0);
            textBox2.Text = Convert.ToString(a);
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
           int h;
            textBox3.Text = Convert.ToString(e.KeyData);
            h = Convert.ToInt32(e.KeyCode);
            textBox5.Text = Convert.ToString(h);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            int h; 
            textBox3.Text = Convert.ToString( e.KeyData);
            h = Convert.ToInt32(e.KeyCode);
            textBox5.Text = Convert.ToString(h);
        }

       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int h;
            textBox3.Text = Convert.ToString(e.KeyData);
            h = Convert.ToInt32(e.KeyCode);
            textBox5.Text = Convert.ToString(h);
        }


        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int h;
            textBox3.Text = Convert.ToString(e.KeyData);
            h = Convert.ToInt32(e.KeyCode);
            textBox5.Text = Convert.ToString(h);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            int h;
            textBox3.Text = Convert.ToString(e.KeyData);
            h = Convert.ToInt32(e.KeyCode);
            textBox5.Text = Convert.ToString(h);
        }

        
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            int h;
            textBox3.Text = Convert.ToString(e.KeyData);
            h = Convert.ToInt32(e.KeyCode);
            textBox5.Text = Convert.ToString(h);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            if (numericUpDown1.Value == 0)
                textBox4.Text = " ";
            else
                b = Char.ConvertFromUtf32(Convert.ToInt32(numericUpDown1.Value));
            textBox4.Text =Convert.ToString( b);
        }
        }
}
        
