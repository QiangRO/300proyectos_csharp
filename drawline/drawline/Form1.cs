using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        System.Drawing.Pen p = new Pen(Color.Blue);
        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Refresh();
            g.DrawLine(p, e.X, 0, e.X, this.Height  );
            g.DrawLine(p, 0, e.Y, this.Width, e.Y);
            this.Text="X="+e.X.ToString()+"  Y="+e.Y.ToString();
        }
    }
}