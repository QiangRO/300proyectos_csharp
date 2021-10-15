using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace gerd
{
    public partial class Form1 : Form
    {
        int i=MousePosition.X,j=MousePosition.Y  ;
        public Form1()
        {
            InitializeComponent();
            
        }
    
        private void load()
        {
            this.pic.Location = new System.Drawing.Point(i, j);
            this.Controls.Add(this.pic);
            
        }

        private void pic_Click(object sender, EventArgs e)
        {
            am();
            
        }
        private void rand()
        {
            Random r1 = new Random();
            
            
            int te = r1.Next(1, 4);
            if (te == 1)
            {
                i = 0;
                j = r1.Next(0, 600);
            }
            else if (te == 2)
            {
                i = r1.Next(0, 800);
                j = 600;
            }
            else if (te == 3)
            {
                i = 800;
                j = r1.Next(0, 600);
            }
            else
            {
                i = r1.Next(0, 800);
                j = 0;
            }
            
        }
        private void am()
        {
            rand();
            int x, y, c, d;

            x = i;
            y = j;
            i = pic.Location.X;
            j = pic.Location.Y;

            for (int r = 0; (x != i || y != j) && r < 20; r++)
            {
                if (i > x)
                {

                    c = (i - x) / 30;
                    if (c == 0)
                        c = 1;
                    i -= c;
                }
                else
                {

                    c = (x - i) / 30;
                    if (c == 0)
                        c = 1;
                    i += c;
                }

                if (j > y)
                {

                    d = (j - y) / 30;
                    if (d == 0)
                        d = 1;
                    j -= d;
                }
                else
                {

                    d = (y - j) / 30;
                    if (d == 0)
                        d = 1;
                    j += d;
                }

                load();
                Application.DoEvents();
                textBox1.Text = "i:" + i + " j:" + j + "--- c:" + c + " d:" + d + "--- x:" + x + " y:" + y + " --- r" + r;
            }
            am();
        }


    }
}