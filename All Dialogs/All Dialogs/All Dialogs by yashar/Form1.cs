using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace All_Dialogs_by_Yashar
{
    public partial class Form1 : Form
    {
        private string stropen;
        private string strsave;
        public Form1()
        {
            InitializeComponent();
        }

        private void exToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cleanTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form2 aboutfrm = new Form2();
           aboutfrm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.BackColor = colorDialog1.Color;
                //menuStrip1.BackColor = colorDialog1.Color;
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text file (*.txt)|*.txt|All file(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                stropen = openFileDialog1.FileName;
                textBox1.Text = System.IO.File.ReadAllText(stropen);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All file(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strsave = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(strsave, textBox1.Text);
            }
        }

        private void openDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text file (*.txt)|*.txt|All file(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                stropen = openFileDialog1.FileName;
                textBox1.Text = System.IO.File.ReadAllText(stropen);
            }
        }

        private void saveDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt|All file(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strsave = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(strsave, textBox1.Text);
            }
        }

        private void fontDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;

            }
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.BackColor = colorDialog1.Color;
                //menuStrip1.BackColor = colorDialog1.Color;
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void browseDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}