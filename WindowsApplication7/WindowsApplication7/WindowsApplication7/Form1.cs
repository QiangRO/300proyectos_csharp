using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication7
{
    public partial class Form1 : Form
    {
        int mouse = 0;
        int[] x = new int[20] /*{ 120, 50, 40, 30, 110, 21, 42, 50, 41, 10, 130, 10, 21 }*/;
        int[] y = new int[20] /*{ 100, 95, 42, 16, 73, 150, 65, 3, 120, 75, 100, 95, 42 }*/;
        bool[] sy = new bool[] { true, true, false, true, false, false, true, false, false, true, true, false, true, true, false, true ,false, true, false, true};
        bool[] sx = new bool[] { false, true, false, true, false, true, false, false, true, false, true, false, true, false, true, true, true, true, false, true };
        /*int[] s = new int[] { 1, 2, 1, 2, 2, 1, 2 };
        int[] d = new int[] { 1, 2, 2, 1, 2, 2, 2 };*/
        int s = 2;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox[] pp = new PictureBox[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13,p14,p15,p16,p17,p18,p19,p20};
            for (int i = 0; i < 20; i++)
            {
                move(i);
                pp[i].Location = new Point(x[i], y[i]);
                check(i);
            }            
        }
        private void move(int a)
        {
            int w = this.Width - 25;
            int h = this.Height - 65;
            if (x[a] >= w) sx[a] = false;
            if (x[a] <= 0) sx[a] = true;
            if (y[a] >= h) sy[a] = false;
            if (y[a] <= 0) sy[a] = true;
           /* if (sx[a]) x[a] += s[a]; else x[a]-=s[a];
            if (sy[a]) y[a] += d[a]; else y[a] -=d[a];*/
            if (sx[a]) x[a] += s; else x[a] -= s;
            if (sy[a]) y[a] += s; else y[a] -= s;
        }
        private void check(int b)
        {
            PictureBox[] p = new PictureBox[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20 };
            for (int k = 0; k <= 19; k++)
                for (int j = (k+1); j <= 19; j++)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        if (p[j].Top + (8 + i) == p[k].Top && ((p[j].Left - 2 < p[k].Left && p[j].Left + 12 > p[k].Left) || (p[j].Left - 2 < p[k].Left + 12 && p[j].Left + 12 > p[k].Left + 12)))
                        {
                            sy[k] = true;
                            sy[j] = false; 
                        }
                        if (p[j].Top == p[k].Top + (8 + i) && ((p[j].Left - 2 < p[k].Left && p[j].Left + 12 > p[k].Left) || (p[j].Left - 2 < p[k].Left + 12 && p[j].Left + 12 > p[k].Left + 12)))
                        {
                            sy[k] = false;
                            sy[j] = true; 
                        }
                        if (p[j].Left == p[k].Left + (8 + i) && ((p[j].Top - 2 < p[k].Top && p[j].Top + 12 > p[k].Top) || (p[j].Top - 2 < p[k].Top + 12 && p[j].Top + 12 > p[k].Top + 12)))
                        {
                            sx[k] = false;
                            sx[j] = true; 
                        }
                        if (p[j].Left + (8 + i) == p[k].Left && ((p[j].Top - 2 < p[k].Top && p[j].Top + 12 > p[k].Top) || (p[j].Top - 2 < p[k].Top + 12 && p[j].Top + 12 > p[k].Top + 12)))
                        {
                            sx[k] = true;
                            sx[j] = false;
                        }
                    }
                }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && timer1.Enabled )
            {
                toolStripStatusLabel1.Text = "You can resize form...";
                if (mouse < 19)
                {
                    mouse++;
                    x[mouse] = e.X;
                    y[mouse] = e.Y;
                }
            }
           if(e.Button==MouseButtons.Middle)
                timer1.Enabled = false;
            if (e.Button == MouseButtons.Right)
                timer1.Enabled = true;
            this.Text = "number of Specks:" + Convert.ToString((mouse + 1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to increase the specks until 20 specks...";
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can stop with middle click and run with right...";
        }

        
    }
}