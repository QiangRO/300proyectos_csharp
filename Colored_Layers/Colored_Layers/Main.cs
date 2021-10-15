using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Transparent_layer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Image img2,img_org;
        
        private static Image fill_layer(PictureBox PicBox,Image img,Color Layer_color,int Percent)
        {
            PicBox.Image = img;
            Bitmap bmp_img = new Bitmap(PicBox.Image);
            Graphics ghp = Graphics.FromImage(bmp_img);
            LinearGradientBrush LineaBrush;
            LineaBrush = new LinearGradientBrush(new Rectangle(0, 0, bmp_img.Width, bmp_img.Height), Color.FromArgb(Percent, Layer_color), Color.FromArgb(Percent, Layer_color), LinearGradientMode.BackwardDiagonal);
            ghp.FillRectangle(LineaBrush, new Rectangle(0, 0, bmp_img.Width, bmp_img.Height));
            return (Image)bmp_img;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
            pictureBox1.Image = fill_layer(pictureBox1, img2, colorDialog1.Color, trackBar1.Value);
        }

        private void بازکردنعکسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    label1.Visible = false;
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    img_org = img2 = pictureBox1.Image;
                }
            }
            catch
            {
                pictureBox1.Image = null;
                label1.Visible = true;
            }
        }

        private void انتخابرنگToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                img2 = pictureBox1.Image;
                pictureBox1.Image = fill_layer(pictureBox1, img2, colorDialog1.Color, trackBar1.Value);
            }
        }

        private void تصویرپیشفرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 127;
            pictureBox1.Image = img2 = img_org;
        }

        private void ذخیرهعکسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG File (*.jpg)|*.jpg|Bitmap File (*.bmp)|*.bmp|PNG File(*.png)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(saveFileDialog1.FileName))
                {
                    case ".jpg":
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg); break;
                    case ".bmp":
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp); break;
                    case ".png":
                        pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Png); break;
                }
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}