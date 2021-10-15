using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace wqb
{
    public partial class Form1 : Form
    {
        string wq;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ali;
            int aliz;
            ali = textBox1.Text;
            ali = ali.ToLower();
            
            aliz = ali.Length;
            string[] qqq = new string[aliz+aliz];
            for (int a = 0; a <= aliz - 1; a++)
            {
                qqq[a+1] = ali.Substring(a, 1);
            }
            
            int[] aw = new int [aliz + aliz] ;
            for (int y = 1; y <= aliz; y++)
            {
                
                
                if (qqq[y] =="a")
                {
                    aw[y] = 1;
                }
                if (qqq[y] == "b")
                {
                    aw[y] = 2;
                }
                if (qqq[y] == "c")
                {
                    aw[y] = 3;
                }
                if (qqq[y] == "d")
                {
                    aw[y] = 4;
                }
                if (qqq[y] == "e")
                {
                    aw[y] = 5;
                }
                if (qqq[y] == "f")
                {
                    aw[y] = 6;
                }
                if (qqq[y] == "g")
                {
                    aw[y] = 7;
                }
                if (qqq[y] == "h")
                {
                    aw[y] = 8;
                }
                if (qqq[y] == "i")
                {
                    aw[y] = 9;
                }
                if (qqq[y] == "j")
                {
                    aw[y] = 10;
                }
                if (qqq[y] == "k")
                {
                    aw[y] = 11;
                } 
                if (qqq[y] == "l")
                {
                    aw[y] = 12;
                } 
                if (qqq[y] == "m")
                {
                    aw[y] = 13;
                }
                if (qqq[y] == "n")
                {
                    aw[y] = 14;
                }
                if (qqq[y] == "o")
                {
                    aw[y] = 15;
                }
                if (qqq[y] == "p")
                {
                    aw[y] = 16;
                }
                if (qqq[y] == "q")
                {
                    aw[y] = 17;
                }
                if (qqq[y] == "r")
                {
                    aw[y] = 18;
                }
                if (qqq[y] == "s")
                {
                    aw[y] = 19;
                }
                if (qqq[y] == "t")
                {
                    aw[y] = 20;
                }
                if (qqq[y] == "u")
                {
                    aw[y] = 21;
                }
                if (qqq[y] == "v")
                {
                    aw[y] = 22;
                }
                if (qqq[y] == "w")
                {
                    aw[y] =23;
                }
                if (qqq[y] == "x")
                {
                    aw[y] = 24;
                }
                if (qqq[y] == "y")
                {
                    aw[y] = 25;
                }
                if (qqq[y] == "z")
                {
                    aw[y] = 26;
                }
                
            }
            for (int iii = 1; iii <= aliz; iii++)
            {
                for (int lll = 1; lll < aliz; lll++)
                {
                    if (aw[lll] > aw[lll + 1])
                    {
                        int n;
                        n = aw[lll];
                        aw[lll] = aw[lll + 1];
                        aw[lll + 1] = n;

                        string m;
                        m = qqq[lll];
                        qqq[lll] = qqq[lll + 1]; ;
                        qqq[lll + 1] = m;
                    }

                }

            }

            
            for (int r = 1; r <= aliz; r++)
            {
                wq = wq + qqq[r];
            }

            textBox1.Text = wq;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}