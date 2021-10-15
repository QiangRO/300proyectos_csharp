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
        int power(int n, int i)
        {
            int k = 0;
            if (n % i == 0)
            {
                while (n % i == 0)
                {
                    n /= i;
                    k++;
                }
            }
            return k;
        }
        //===============================
        bool is_prime(int n)
        {
            bool res=true;
            if(n<=1)
                return false;
            else
            {
                for(int i=2;i<=Math.Sqrt(n);i++)
                {
                    if(n%i==0)
                    {
                        res = false;
                        break;
                    }
                }
                return res;
            }
        }
        //===============================             



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int n = Convert.ToInt32(textBox1.Text);
                List<int> primes = new List<int>();
                List<int> pows = new List<int>();
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0 && is_prime(i))
                    {
                        primes.Add(i);
                        pows.Add(power(n, i));
                    }
                }
                //=================================
                List<int> index = new List<int>();
                List<int> list = new List<int>();
                List<int> pows2 = new List<int>();
                //=================================
                for (int i = 0; i < pows.Count; i++)
                {
                    if (pows[i] == 1)
                    {
                        list.Add(primes[i]);
                    }
                    if (pows[i] >= 2)
                    {
                        if (pows[i] % 2 == 0)
                        {
                            pows2.Add(pows[i] / 2);
                            index.Add(i);
                        }
                        else
                        {
                            pows2.Add(pows[i] / 2);
                            index.Add(i);
                            list.Add(primes[i]);
                        }
                    }
                }
                //======================================
                int a = 1;
                int b = 1;
                for (int i = 0; i < index.Count; i++)
                {
                    a *= (int)(Math.Pow(primes[index[i]], pows2[i]));
                }
                for (int i = 0; i < list.Count; i++)
                {
                    b *= list[i];
                }
                //======================================
                textBox2.Text = a.ToString();
                textBox3.Text = b.ToString();
            }
            else
            {
                MessageBox.Show("Enter Number First !!!", "*** Warning ***", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Select();
                textBox1.Focus();
            }


                        

                        
            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string about = "";
            about = "نویسنده برنامه : سالار اشگی \n" + "تحت زبان : سی شارپ 2008 \n" + "تیر 88 ";
            MessageBox.Show(about, "درباره ...", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
