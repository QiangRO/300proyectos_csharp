using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace WindowsFormsApplication28
{
    public partial class ShowString : Form
    {
        public ShowString()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = PersianDate.Now.ToLongDateString();
            if (textBox1.Text != "")
            {
                //string str = "ما ز یاران چشم یاری داشتیم ... خود غلط بود آنچه ما پنداشتیم";
                string str = textBox1.Text;
                GraphicsPath p = new GraphicsPath();
                Point po = new Point(0, 100);
                p.AddString(str, new FontFamily("Arial"), 1, 50, po, new StringFormat());
                Region = new Region(p);
                po = new Point(0, 0);
                Point po1 = PointToScreen(po);
                e.Graphics.TranslateTransform(((float)Left - po1.X), ((float)Top - po1.Y));
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(Brushes.Black, p);
                e.Graphics.DrawPath(new Pen(Color.Red, 5f), p);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("این برنامه فرم رو به شکل یه رشته در میاره !" + "        طراح : وحید میرزایی");
        }
    }
}
