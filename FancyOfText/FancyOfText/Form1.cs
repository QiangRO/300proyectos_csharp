using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace FancyOfText
{
    public partial class Form1 : Form
    {
        private Bitmap _bmpText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(258, 126);
            using (Font fnt = new Font("Arial", 32, FontStyle.Bold))
                _bmpText = (Bitmap)FancyText.ImageFromText("سلام چه خبر", fnt, Color.Red, Color.Yellow);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(_bmpText, 10, 40);
            base.OnPaint(e);
        }
    }
}