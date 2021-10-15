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
        void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //================================
        void perm(int[] a, int k,ListBox list)
        {
            string res = "";
            if (k == a.Length - 1)
            {
                foreach (int i in a)
                {
                    res += i.ToString() + ",";
                }
                res += "\r\n";
                list.Items.Add(res );
                res = "";
            }
            else
            {
                for (int i = k; i < a.Length; i++)
                {
                    swap(ref a[i], ref a[k]);
                    perm(a, k + 1,list);
                    swap(ref a[i], ref a[k]);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox2.Text);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = i + 1;
           
            perm(a, 0,listBox1);
            label1.Text = listBox1.Items.Count.ToString() + " حالت ";
            
        }
    }
}
