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
        string Reverse(string str)
        {
            string res = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                res += str[i].ToString();
            }
            return res;
        }
        //================================================
        string Money_Text(string str)
        {
            string rev = Reverse(str);
            string res = "";
            int f = 0;
            for (int i = 0; i < rev.Length; i++)
            {
                f++;
                res += rev[i].ToString();
                if (f == 3)
                {
                    res += ",";
                    f = 0;
                }
            }
            return Reverse(res);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Money_Text(textBox1.Text);
        }
    }
}
