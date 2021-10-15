using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Director
{
    public partial class Form1 : Form
    {
        private int count=0;
        private bool running = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            running = !running;
            if (running)
            {
                btnSet.Text = "Stop";
                prg.Show();
                lblStatus.Show();
            }
            else
            {
                btnSet.Text = "Set Files And Folders To Normal";
                prg.Hide();
                lblStatus.Hide();
            }
            setNormal(txtPath.Text);
            btnSet.Text = "Set Files And Folders To Normal";
            running = false;
            lblStatus.Text = "Number Of Scanned Files And Folders:" + count.ToString();
            prg.Hide();
        }

        private void setNormal(string dir)
        {
            if (!running)
                return;
            if (!Directory.Exists(dir))
            {
                lblStatus.Text = "Invalid path!";
                return;
            }
            if (chkSub.Checked)
            {
                try
                {
                    foreach (string d in System.IO.Directory.GetDirectories(dir))
                    {
                        lblStatus.Text = dir;
                        setNormal(d);
                        count += Directory.GetFiles(d).Length + Directory.GetDirectories(dir).Length;
                        prg.Maximum = Directory.GetFiles(d).Length + Directory.GetDirectories(dir).Length;
                        prg.Value = 0;
                        DirectoryInfo df = new DirectoryInfo(d);
                        try
                        {
                            df.Attributes = FileAttributes.Normal;
                            prg.Value++;
                        }
                        catch
                        {
                        }
                        foreach (string fil in System.IO.Directory.GetFiles(d))
                        {
                            FileInfo f = new FileInfo(fil);
                            try
                            {
                                f.Attributes = FileAttributes.Normal;
                                prg.Value++;
                                Application.DoEvents();
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                catch
                {
                }
            }
            else
            {
                count = Directory.GetFiles(dir).Length;
                prg.Maximum = count;
                prg.Value = 0;
                try
                {
                    foreach (string fil in System.IO.Directory.GetFiles(dir))
                    {
                        FileInfo f = new FileInfo(fil);
                        try
                        {
                            f.Attributes = FileAttributes.Normal;
                            prg.Value++;
                            Application.DoEvents();
                        }
                        catch
                        {
                        }
                    }
                }
                catch { }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "")
                txtPath.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
