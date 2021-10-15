using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SafeCoolDisk
{
    public partial class Form1 : Form
    {
        bool flashdisk = false;
        string PATH = string.Empty;
        string dir = string.Empty;
        public Form1()
        {
            InitializeComponent();
             string exepath = Application.ExecutablePath;
             dir=System.IO.Directory.GetDirectoryRoot(exepath);
             PATH = dir + "$sgb110.bat";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (flashdisk == true)
                {
                    System.IO.DriveInfo dirinf = new System.IO.DriveInfo(dir);
                    if (dirinf.DriveFormat != "NTFS")
                    {
                        MessageBox.Show("pleas Format this Drive to NTFS");
                        
                        return;
                    }
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(PATH, false);
                    System.IO.File.SetAttributes(PATH, System.IO.FileAttributes.Hidden);
                    sw.Write("fsutil file createnew " + dir + "$sgb110LockFile " + dirinf.AvailableFreeSpace.ToString());
                    sw.Close();
                    System.Diagnostics.Process.Start(PATH);
                    button2.Enabled = true;
                    this.Text = "enjoy!";

                }
                else
                {
                    MessageBox.Show("This Program is running on fixed drive");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(dir + "$sgb110LockFile");
            System.IO.File.Delete(PATH);
            load();
        }
        private void load()
        {
            System.IO.DriveInfo dirinf = new System.IO.DriveInfo(dir);

            if (dirinf.DriveType == System.IO.DriveType.Removable)
                    flashdisk = true;
            this.Text = "sgb110@yahoo.com";
            if (dirinf.AvailableFreeSpace < 1)
                button1.Enabled = false;

            button2.Enabled = System.IO.File.Exists(dir + "$sgb110LockFile");
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load();

        }
    }
}
