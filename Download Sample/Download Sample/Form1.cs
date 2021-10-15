using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Download_Sample  // Coded By Yashar ::: Email : Y_ashar@yahoo.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileAsync(new Uri(textBox1.Text.Trim().ToString()), textBox2.Text.Trim());

        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download completed!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
            string select = textBox1.Text.ToString();
            string[] wordarry = select.Split('/');
            for (int i = 0; i < Int32.Parse(wordarry.Length.ToString()); i++)
            {
                if (i == Int32.Parse(wordarry.Length.ToString()) - 1)
                {
                    textBox2.Text += "\\"+wordarry[i].ToString();
                }

            }
        }
    }
}
