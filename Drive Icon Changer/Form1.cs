using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace Drive_Icon_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OFD1.Filter = "Icon File (*.ICO) | *.ico";
            OFD1.ShowDialog();
            textBox2.Text = OFD1.FileName;
            //-----------------------------------------

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool EXS_File;
            EXS_File = File.Exists(textBox2.Text);
            if (EXS_File == true)
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\DriveIcons\\" + textBox1.Text.ToString() + "\\" + "DefaultIcon", "", textBox2.Text);
                MessageBox.Show("Changed Icon");
            }
            else
            {
                MessageBox.Show("Invalid File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}