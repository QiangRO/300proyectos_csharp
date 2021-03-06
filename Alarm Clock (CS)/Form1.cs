using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Media;

namespace Alarm_Clock__CS_
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }
        public void Set_Tips()
        {
            Tip1.SetToolTip(Hour_txt, "ساعت");
            Tip1.SetToolTip(Minute_txt, "دقیقه");
            Tip1.SetToolTip(Second_txt, "ثانیه");
            Tip1.SetToolTip(Music_Path, "مسیر فایل موسیقی");
            Tip1.SetToolTip(btn_Set_Time, "انتخاب زمان مورد نظر");
            Tip1.SetToolTip(btn_Set_Music, "انتخاب موسیقی مورد نظر به عنوان زنگ هشدار");
            Tip1.SetToolTip(Pic_Clock, "برنامه نویس : علیرضا زارع");
        }

        public void Load_Setting()
        {

            Hour_txt.Text =(string) Registry.GetValue("HKEY_CURRENT_USER\\Software\\Alarm Clock (CS)\\Time", "Hour", 0);
            Minute_txt.Text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Alarm Clock (CS)\\Time", "Minute", 0);
            Second_txt.Text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Alarm Clock (CS)\\Time", "Second", 0);
            Music_Path.Text = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Alarm Clock (CS)\\Setting", "Music Path", 0);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Set_Tips();
            Load_Setting();
            //------------------
            MessageBox.Show ("Pogrammer : Alireza Zare " + "\n" + "Y-Mail : alireza_2297@yahoo.com" + "\n" + "G-Mail : jacksmith354@yahoo.com" + "\n" + "Web : www.ali-virus.blogfa.com","Information : ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_Set_Music_Click(object sender, EventArgs e)
        {
            OFD1.Filter = "Wave File (*.WAV)|*.wav";
            OFD1.ShowDialog();
            Music_Path.Text = OFD1.FileName;
            //---------------------------------------
            if (Music_Path.Text == "openFileDialog1")
            {
                Music_Path.Text = "";
            }
            //----------------------------------------
            // Save Music Path To The Registry For Use After.
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Alarm Clock (CS)\\Setting","Music Path",Music_Path.Text);
        }

        private void btn_Set_Time_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //-------------------------
            // Save Hour and Minute and Second To The Registry For Use After.
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Alarm Clock (CS)\\Time", "Hour", Hour_txt.Text);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Alarm Clock (CS)\\Time", "Minute", Minute_txt.Text);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Alarm Clock (CS)\\Time", "Second", Second_txt.Text);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            string Hour, Minute, Second;
            Hour = DateTime.Now.TimeOfDay.Hours.ToString();
            Minute = DateTime.Now.TimeOfDay.Minutes.ToString();
            Second = DateTime.Now.TimeOfDay.Seconds.ToString();
            //---------------------------------------

            //This Place is For Hour.
            switch (Hour_txt.Text)
            {
                case "00":
                    Hour_txt.Text="0";
                    break;
                case "01":
                    Hour_txt.Text = "1";
                    break;
                case "02":
                    Hour_txt.Text = "2";
                    break;
                case "03":
                    Hour_txt.Text = "3";
                    break;
                case "04":
                    Hour_txt.Text = "4";
                    break;
                case "05":
                    Hour_txt.Text = "5";
                    break;
                case "06":
                    Hour_txt.Text = "6";
                    break;
                case "07":
                    Hour_txt.Text = "7";
                    break;
                case "08":
                    Hour_txt.Text = "8";
                    break;
                case "09":
                    Hour_txt.Text = "9";
                    break;
            }

            //This Place is For Minute.
            switch (Minute_txt.Text)
            {
                case "00":
                    Minute_txt.Text = "0";
                    break;
                case "01":
                    Minute_txt.Text = "1";
                    break;
                case "02":
                    Minute_txt.Text = "2";
                    break;
                case "03":
                    Minute_txt.Text = "3";
                    break;
                case "04":
                    Minute_txt.Text = "4";
                    break;
                case "05":
                    Minute_txt.Text = "5";
                    break;
                case "06":
                    Minute_txt.Text = "6";
                    break;
                case "07":
                    Minute_txt.Text = "7";
                    break;
                case "08":
                    Minute_txt.Text = "8";
                    break;
                case "09":
                    Minute_txt.Text = "9";
                    break;
            }

            //This Place is For Second.
            switch (Second_txt.Text)
            {
                case "00":
                    Second_txt.Text = "0";
                    break;
                case "01":
                    Second_txt.Text = "1";
                    break;
                case "02":
                    Second_txt.Text = "2";
                    break;
                case "03":
                    Second_txt.Text = "3";
                    break;
                case "04":
                    Second_txt.Text = "4";
                    break;
                case "05":
                    Second_txt.Text = "5";
                    break;
                case "06":
                    Second_txt.Text = "6";
                    break;
                case "07":
                    Second_txt.Text = "7";
                    break;
                case "08":
                    Second_txt.Text = "8";
                    break;
                case "09":
                    Second_txt.Text = "9";
                    break;
            }

            if ((Hour_txt.Text == Hour) && (Minute_txt.Text == Minute) && (Second_txt.Text == Second))
            {
                string Exists;
                Exists = File.Exists(Music_Path.Text).ToString();
                if (Exists == "True")
                {
                    SoundPlayer SND_Play = new SoundPlayer (Music_Path.Text);
                    SND_Play.PlayLooping();
                }
                else
                {
                    MessageBox.Show("Alarm Clock !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //------------------------------------------------
                
            }
        }

        private void قطعصدایزنگToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer SND_Play = new SoundPlayer();
            SND_Play.Stop();
        }

    }
}