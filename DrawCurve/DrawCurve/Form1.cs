using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;

namespace DrawCurve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> p = new List<Point>();
        Graphics g;
        List<Button> buttons = new List<Button>();
        int x, y;
        bool check;

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                check = true;
                Invalidate();

                p.Add(e.Location);


                Button b = new Button();
                b.Name = buttons.Count.ToString();
                b.Location = e.Location;
                b.Size = new Size(5, 5);
                b.Cursor = Cursors.Hand;
                b.MouseDown += new MouseEventHandler(b_MouseDown);
                b.MouseMove += new MouseEventHandler(b_MouseMove);
                buttons.Add(b);

                panel1.Controls.AddRange(buttons.ToArray());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            if (buttons.Count < 2)
                g.Clear(panel1.BackColor);
            if (check)
                if (p.Count > 1)
                {
                    g.Clear(panel1.BackColor);
                    g.DrawCurve(Pens.Red, p.ToArray());

                }
        }

        private void b_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button b = sender as Button;
                int i = buttons.IndexOf(b);
                panel1.Controls.RemoveAt(i);
                buttons.RemoveAt(i);
                p.RemoveAt(i);
            }
            x = e.X;
            y = e.Y;
        }

        private void b_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            int i = buttons.IndexOf(b);
            if (e.Button == MouseButtons.Left)
            {
                b.Location = new Point(b.Location.X + (e.X - x), b.Location.Y + (e.Y - y));
                p[i] = b.Location;
            }
            panel1_Paint(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            p.Clear();
            for (int i = 0; i < buttons.Count; i++)
            {
                panel1.Controls.Remove(buttons[i]);
            }
            buttons.Clear();
        }


    }
}
