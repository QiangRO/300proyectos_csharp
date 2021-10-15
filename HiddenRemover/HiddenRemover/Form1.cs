using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HiddenRemover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            txtFolder.Text = fbd.SelectedPath;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            HiddenRemove(txtFolder.Text);
            MessageBox.Show("Succeeded...!");
        }

        private void HiddenRemove(string path)
        {
            if (Directory.GetDirectoryRoot(path) != path && !path.Contains("System Volume Information"))
            {
                FileAttributes a = File.GetAttributes(path);
                if (a.ToString().Contains("Hidden") && a.ToString().Contains("Directory"))
                {
                    File.SetAttributes(path, FileAttributes.Directory);
                }
            }
            if (!path.Contains("System Volume Information"))
            {
                string[] dir = Directory.GetDirectories(path);
                for (int i = 0; i < dir.Length; i++)
                {
                    HiddenRemove(dir[i]);
                }
            }
        }
    }
}
