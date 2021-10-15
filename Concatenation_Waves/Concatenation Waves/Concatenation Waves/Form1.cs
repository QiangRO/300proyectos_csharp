using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Concatenation_Waves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string[] files = new string[2] { @textBox1.Text, @textBox2.Text };

            WaveIO wa = new WaveIO();
            wa.Merge(files, @textBox3.Text);

            FileStream fs = new FileStream(@"c:\oou.wav", FileMode.Open, FileAccess.Read);
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(fs);
            sp.Play();
        }
    }
}