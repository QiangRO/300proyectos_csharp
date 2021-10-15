using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BthDigitClock;


namespace TestBTHDigitClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Parandcs Digital Clock";
        }
        BthDigitClock.BthDigitClock x = new BthDigitClock.BthDigitClock();

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime objtime = DateTime.Now;
            x.Hour = objtime.Hour.ToString();
            x.Min = objtime.Minute.ToString();
            x.Sec = objtime.Second.ToString();
            x.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point mylocation = new Point(10, 10);
            x.Location = mylocation;
            this.Controls.Add(x);
            timer1.Start();
        }
    }
}