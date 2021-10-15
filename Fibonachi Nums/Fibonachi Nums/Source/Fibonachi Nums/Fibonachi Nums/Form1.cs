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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Clear();
                //++++++++++++++++++++++++++++++++++
                ulong n = Convert.ToUInt64(textBox1.Text);
                ulong[] a = new ulong[n + 1];
                a[1] = 1;
                a[2] = 1;
                for (ulong i = 3; i <= n; i++)
                    a[i] = a[i - 1] + a[i - 2];
                //++++++++++++++++++++++++++++++++++
                for (ulong i = 1; i <= n; i++)
                    listBox1.Items.Add(a[i].ToString());
            }
            else
            {
                MessageBox.Show("عدد مورد نظر را وارد کنید ", "هشدار ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox1.Focus();
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int f = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    f++;
                else
                    f--;
            }
            if (f != str.Length)
            {
                MessageBox.Show("Error,Please enter an intger number !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox1.Focus();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string about = "";
            about = "نویسنده برنامه : سالار اشگی \n" + "تحت زبان : سی شارپ 2008 \n" + "بهمن 87 ";
            MessageBox.Show(about, "درباره سازنده نرم افزار ", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
