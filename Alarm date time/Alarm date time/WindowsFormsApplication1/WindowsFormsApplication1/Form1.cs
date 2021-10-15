using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool ok;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DateTime date = new DateTime();
        //DateTime d=new DateTime(
        StringBuilder b = new StringBuilder();
        StringBuilder time = new StringBuilder();

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           label1.Text = b.ToString();
           label2.Text = DateTime.Now.ToLongTimeString();

           //if (label2.Text == time.ToString())
           //    MessageBox.Show("SASA");


            
           //if setting is true
           if (ok)
           {
               //Date check
               if (label1.Text == label7.Text)
               {
                   //Time check
                   if (label2.Text == time.ToString())
                   {
                       //shutdown
                       if (radioButton1.Checked)
                       {
                           if (comboBox1.Text == "Shutdown")//shutdown
                               System.Diagnostics.Process.Start("ShutDown", "/s");
                           if (comboBox1.Text == "Restart")//restart
                               System.Diagnostics.Process.Start("ShutDown", "/r");
                           if (comboBox1.Text == "Logoff")//logoff
                               System.Diagnostics.Process.Start("ShutDown", "/l");
                       }
                       //open file
                       if (radioButton2.Checked)
                       {
                           if (txtpathfile.Text != "")//
                               System.Diagnostics.Process.Start(txtpathfile.Text);
                       }
                       //play sound
                       if (radioButton3.Checked)
                       {
                           SoundPlayer p = new SoundPlayer(txtsound.Text);
                           p.Play();

                       }
                       //show message
                       if (radioButton4.Checked)
                       {
                           MessageBox.Show(txtMsg.Text);
                       }

                   }
               }
           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            btnsound.Enabled = BtnOpen.Enabled = txtMsg.Enabled = txtpathfile.Enabled = txtsound.Enabled = false;
            System.Globalization.PersianCalendar p = new System.Globalization.PersianCalendar();
            b.Append(p.GetYear(DateTime.Now));
            b.Append("/");
            b.Append(p.GetMonth(DateTime.Now));
            b.Append("/");
            b.Append(p.GetDayOfMonth(DateTime.Now));
            textBox1.Text = b.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text=="")
                MessageBox.Show("SET AM or PM");
           else if (radioButton1.Checked && comboBox1.Text == "")
                MessageBox.Show("SET Shutdown");
            else if (radioButton2.Checked && txtpathfile.Text == "")
                MessageBox.Show("SET File name");
            else if (radioButton3.Checked && txtsound.Text == "")
                MessageBox.Show("SET File name");
            else if (radioButton4.Checked && txtMsg.Text == "")
                MessageBox.Show("SET Message");
            else
            {
                ok = true;
                time.Remove(0, time.Length);
                time.Append(numericUpDown1.Value.ToString());
                time.Append(":");
                time.Append(numericUpDown2.Value.ToString());
                time.Append(":");
                time.Append(numericUpDown3.Value.ToString());
                time.Append(" ");
                time.Append(comboBox2.Text);
                label10.Text = time.ToString();
                label7.Text = textBox1.Text;
            }

        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Enabled = true;
                txtpathfile.Enabled = false;
            }
            else
                comboBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtpathfile.Enabled = BtnOpen.Enabled = true;
            }
            else
                txtpathfile.Enabled = BtnOpen.Enabled = false;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                txtsound.Enabled = btnsound.Enabled = true;
            }
            else
                txtsound.Enabled = btnsound.Enabled = false;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                txtMsg.Enabled = true;
            }
            else
                txtMsg.Enabled = false;
        }

        private void BtnOpen_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "EXE |*.exe| bath |*.bat";
            openFileDialog1.ShowDialog();
            txtpathfile.Text = openFileDialog1.FileName;
        }

        private void btnsound_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Wav |*.wav";
            openFileDialog1.ShowDialog();
            txtsound.Text = openFileDialog1.FileName;
        }




    }
}
