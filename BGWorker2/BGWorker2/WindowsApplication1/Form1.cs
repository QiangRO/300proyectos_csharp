using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BackgroundWorker worker = new BackgroundWorker();

        private void button1_Click(object sender, EventArgs e)
        {
            worker.WorkerReportsProgress = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerAsync(new DirectoryInfo(@"C:\Windows"));
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listBox1.Items.Add(e.ProgressPercentage.ToString() + " : " + e.UserState.ToString());
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            DirectoryInfo primaryDir = e.Argument as DirectoryInfo;
            int i = 0;
            foreach (DirectoryInfo dir in primaryDir.GetDirectories())
            {
                foreach (FileInfo file in dir.GetFiles())
                {
                    worker.ReportProgress(i++, file.FullName);
                }
                
            }
            
        }        
    }
}