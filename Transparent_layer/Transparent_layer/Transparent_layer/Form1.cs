using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Transparent_layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = fill_layer(pictureBox1,pictureBox2.Image, colorDialog1.Color,trackBar1.Value);
            }
        }

        private static Image fill_layer(PictureBox Pic_Box,Image img,Color Layer_color,int Percent)
        {
            Pic_Box.Image = img;
            Bitmap bmp_img = new Bitmap(Pic_Box.Image);
            Graphics ghp = Graphics.FromImage(bmp_img);
            LinearGradientBrush LineaBrush;
            LineaBrush = new LinearGradientBrush(new Rectangle(0, 0, bmp_img.Width, bmp_img.Height), Color.FromArgb(Percent, Layer_color), Color.FromArgb(Percent, Layer_color), LinearGradientMode.BackwardDiagonal);
            ghp.FillRectangle(LineaBrush, new Rectangle(0, 0, bmp_img.Width, bmp_img.Height));
            return (Image)bmp_img;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
            pictureBox1.Image = fill_layer(pictureBox1, pictureBox2.Image, colorDialog1.Color, trackBar1.Value);
        }
    }
}