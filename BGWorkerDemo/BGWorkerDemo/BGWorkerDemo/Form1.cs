using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BackgroundWorker worker;
        delegate void MyDelegate(string s);

        private void Form1_Load(object sender, EventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            MyDelegate md = new MyDelegate(AddItems);
            for (int i = 0; i < 10; i++)
            {                
                this.Invoke(md, (object)("ASync" + i.ToString()));
                System.Threading.Thread.Sleep(500);
            }
        }        

        private void AddItems(string s)
        {
            listBox1.Items.Add(s);
        }

        private void btnASync_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            worker.RunWorkerAsync();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("Sync" + i.ToString());
                System.Threading.Thread.Sleep(500);
            }
        }

    }
}