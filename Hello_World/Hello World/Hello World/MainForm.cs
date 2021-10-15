using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class MainForm : Form
    {
        int mx, my;

        //Drawing
        Brush fillbr = new SolidBrush(Color.FromArgb(200,Color.Violet));
        Brush fillbr1 = new SolidBrush(Color.FromArgb(200, Color.Red));
        Pen drawpen = new Pen(Color.Blue);
        Pen drawpen1 = new Pen(Color.FromArgb(200,Color.GreenYellow),3);

        //Walkers
        int wnum = 10;
        Walker[] walkers;

        public MainForm()
        {
            InitializeComponent();

            //Set Walkers

            walkers = new Walker[wnum];
            for (int i = 0; i < wnum; i++)
            {
                walkers[i] = new Walker(0, 0, 5);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            walkers[0].MoveTo(mx, my);
            for (int i = 1; i < wnum; i++)
            {
                walkers[i].MoveTo(walkers[i - 1].X, walkers[i - 1].Y);
            }
            drawboard.Invalidate();
        }

        private void drawboard_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X; my = e.Y;
        }

        private void drawboard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = wnum-1; i > 0; i--)
            {
                if (walkers[i].IsOn(mx,my))
                {
                    e.Graphics.FillEllipse(fillbr, walkers[i].X - 5, walkers[i].Y - 5, 10, 10);
                }
                else
                {
                    e.Graphics.FillEllipse(fillbr1, walkers[i].X - 5, walkers[i].Y - 5, 10, 10);
                }
            }
            e.Graphics.DrawEllipse(drawpen, mx - 4, my - 4, 8, 8);
            e.Graphics.DrawEllipse(drawpen1, mx - 2, my - 2, 4, 4);
        }

        private void drawboard_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void drawboard_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
    }
}
