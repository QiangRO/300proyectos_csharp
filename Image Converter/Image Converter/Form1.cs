using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        string res="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.95;
            label1.Text = "";
            button2.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            list.Clear();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Bmp image(*.bmp)|*.bmp|" + "Jpg image(*.jpg)|*.jpg|" + "Png image(*.png)|*.png|" +
                "Gif image(*.gif)|*.gif|" + "Emf image(*.emf)|*.emf|" + "Exif image(*.exif)|*.exif|" + "Icon image(*.ico)|*.ico|" +
                "Wmf image(*.wmf)|*.wmf|" + "Tiff image(*.tiff)|*.tiff|" + "All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] info = openFileDialog1.FileNames;
                foreach (string s in info)
                {
                    listBox1.Items.Add(Path.GetFileName(s));
                    list.Add(s);
                }
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
             string str="";
             int f = 0;
             if (comboBox1.SelectedIndex >= 0)
             {
                 str = comboBox1.Items[comboBox1.SelectedIndex].ToString();


                 string path = "";

                 foreach (string s in list)
                 {
                     Image img = Image.FromFile(@s);

                     path = res + "\\" + Path.GetFileNameWithoutExtension(s) + "." + str.ToLower();

                     switch (str)
                     {
                         case "Bmp":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Bmp);
                             break;
                         case "Jpg":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Jpeg);
                             break;
                         case "Gif":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Gif);
                             break;
                         case "Png":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Png);
                             break;
                         case "Emf":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Emf);
                             break;
                         case "Exif":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Exif);
                             break;
                         case "Ico":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Icon);
                             break;
                         case "Wmf":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Wmf);
                             break;
                         case "Tiff":
                             img.Save(@path, System.Drawing.Imaging.ImageFormat.Tiff);
                             break;
                     }
                     f++;
                 }
                 label1.Text = f.ToString() + " Images Converted Successfully !!!";

             }
             else
             {
                 MessageBox.Show("Select output format !", "*** Warning ***", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 comboBox1.Select();
                 comboBox1.Focus();
             }
             

                
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                res = folderBrowserDialog1.SelectedPath;
            }
            button2.Enabled = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string about = "";
            about = "نویسنده برنامه : سالار اشگی \n" + "تحت زبان : سی شارپ 2008 \n" + "تیر 88 ";
            MessageBox.Show(about, "درباره سازنده نرم افزار", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
