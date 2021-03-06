using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Persian_Time
{
    public partial class Form1 : Form
    {
        string res_Hour, res_Minute, res_Second; 

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string Hour;
            Hour = DateTime.Now.TimeOfDay.Hours.ToString();
            switch (Hour)
            {
                case "0":
                    res_Hour = "بامداد";
                    break;
                case "1":
                    res_Hour = "یک";
                    break;
                case "2":
                    res_Hour = "دو";
                    break;
                case "3":
                    res_Hour = "سه";
                    break;
                case "4":
                    res_Hour = "چهار";
                    break;
                case "5":
                    res_Hour = "پنج";
                    break;
                case "6":
                    res_Hour = "شش";
                    break;
                case "7":
                    res_Hour = "هفت";
                    break;
                case "8":
                    res_Hour = "هشت";
                    break;
                case "9":
                    res_Hour = "نه";
                    break;
                case "10":
                    res_Hour = "ده";
                    break;
                case "11":
                    res_Hour = "یازده";
                    break;
                case "12":
                    res_Hour = "دوازده";
                    break;
                case "13":
                    res_Hour = "سیزده";
                    break;
                case "14":
                    res_Hour = "چهارده";
                    break;
                case "15":
                    res_Hour = "پانزده";
                    break;
                case "16":
                    res_Hour = "شانزده";
                    break;
                case "17":
                    res_Hour = "هفده";
                    break;
                case "18":
                    res_Hour = "هجده";
                    break;
                case "19":
                    res_Hour = "نوزده";
                    break;
                case "20":
                    res_Hour = "بیست";
                    break;
                case "21":
                    res_Hour = "بیست و یک";
                    break;
                case "22":
                    res_Hour = "بیست و دو";
                    break;
                case "23":
                    res_Hour = "بیست و سه";
                    break;
            }
            //------------------------------
            string Minute;
            Minute = DateTime.Now.TimeOfDay.Minutes.ToString();
            switch (Minute)
            {
                case "0":
                    res_Minute = "صفر";
                    break;
                case "1":
                    res_Minute = "یک";
                    break;
                case "2":
                    res_Minute = "دو";
                    break;
                case "3":
                    res_Minute = "سه";
                    break;
                case "4":
                    res_Minute = "چهار";
                    break;
                case "5":
                    res_Minute = "پنج";
                    break;
                case "6":
                    res_Minute = "شش";
                    break;
                case "7":
                    res_Minute = "هفت";
                    break;
                case "8":
                    res_Minute = "هشت";
                    break;
                case "9":
                    res_Minute = "نه";
                    break;
                case "10":
                    res_Minute = "ده";
                    break;
                case "11":
                    res_Minute = "یازده";
                    break;
                case "12":
                    res_Minute = "دوازده";
                    break;
                case "13":
                    res_Minute = "سیزده";
                    break;
                case "14":
                    res_Minute = "چهارده";
                    break;
                case "15":
                    res_Minute = "پانزده";
                    break;
                case "16":
                    res_Minute = "شانزده";
                    break;
                case "17":
                    res_Minute = "هفده";
                    break;
                case "18":
                    res_Minute = "هجده";
                    break;
                case "19":
                    res_Minute = "نوزده";
                    break;
                case "20":
                    res_Minute = "بیست";
                    break;
                case "21":
                    res_Minute = "بیست و یک";
                    break;
                case "22":
                    res_Minute = "بیست و دو";
                    break;
                case "23":
                    res_Minute = "بیست و سه";
                    break;
                case "24":
                    res_Minute = "بیست و چهار";
                    break;
                case "25":
                    res_Minute = "بیست و پنج";
                    break;
                case "26":
                    res_Minute = "بیست و شش";
                    break;
                case "27":
                    res_Minute = "بیست و هفت";
                    break;
                case "28":
                    res_Minute = "بیست و هشت";
                    break;
                case "29":
                    res_Minute = "بیست و نه";
                    break;
                case "30":
                    res_Minute = "سی";
                    break;
                case "31":
                    res_Minute = "سی و یک";
                    break;
                case "32":
                    res_Minute = "سی و دو";
                    break;
                case "33":
                    res_Minute = "سی و سه";
                    break;
                case "34":
                    res_Minute = "سی و چهار";
                    break;
                case "35":
                    res_Minute = "سی و پنچ";
                    break;
                case "36":
                    res_Minute = "سی و شش";
                    break;
                case "37":
                    res_Minute = "سی و هفت";
                    break;
                case "38":
                    res_Minute = "سی و هشت";
                    break;
                case "39":
                    res_Minute = "سی و نه";
                    break;
                case "40":
                    res_Minute = "جهل";
                    break;
                case "41":
                    res_Minute = "چهل و یک";
                    break;
                case "42":
                    res_Minute = "چهل و دو";
                    break;
                case "43":
                    res_Minute = "چهل و سه";
                    break;
                case "44":
                    res_Minute = "چهل و چهار";
                    break;
                case "45":
                    res_Minute = "چهل و پنج";
                    break;
                case "46":
                    res_Minute = "چهل و شش";
                    break;
                case "47":
                    res_Minute = "چهل و هفت";
                    break;
                case "48":
                    res_Minute = "چهل و هشت";
                    break;
                case "49":
                    res_Minute = "چهل و نه";
                    break;
                case "50":
                    res_Minute = "پنجاه";
                    break;
                case "51":
                    res_Minute = "پنجاه و یک";
                    break;
                case "52":
                    res_Minute = "پنجاه و دو ";
                    break;
                case "53":
                    res_Minute = "پنجاه و سه";
                    break;
                case "54":
                    res_Minute = "پنجاه و چهار";
                    break;
                case "55":
                    res_Minute = "پنجاه و پنج";
                    break;
                case "56":
                    res_Minute = "پنجاه و شش";
                    break;
                case "57":
                    res_Minute = "پنجاه و هفت";
                    break;
                case "58":
                    res_Minute = "پنجاه و هشت";
                    break;
                case "59":
                    res_Minute = "پنجاه و نه";
                    break;
            }
            //-----------------------------------
            string Second;
            Second = DateTime.Now.TimeOfDay.Seconds.ToString();
            switch (Second)
            {
                case "0":
                    res_Second = "صفر";
                    break;
                case "1":
                    res_Second = "یک";
                    break;
                case "2":
                    res_Second = "دو";
                    break;
                case "3":
                    res_Second = "سه";
                    break;
                case "4":
                    res_Second = "چهار";
                    break;
                case "5":
                    res_Second = "پنج";
                    break;
                case "6":
                    res_Second = "شش";
                    break;
                case "7":
                    res_Second = "هفت";
                    break;
                case "8":
                    res_Second = "هشت";
                    break;
                case "9":
                    res_Second = "نه";
                    break;
                case "10":
                    res_Second = "ده";
                    break;
                case "11":
                    res_Second = "یازده";
                    break;
                case "12":
                    res_Second = "دوازده";
                    break;
                case "13":
                    res_Second = "سیزده";
                    break;
                case "14":
                    res_Second = "چهارده";
                    break;
                case "15":
                    res_Second = "پانزده";
                    break;
                case "16":
                    res_Second = "شانزده";
                    break;
                case "17":
                    res_Second = "هفده";
                    break;
                case "18":
                    res_Second = "هجده";
                    break;
                case "19":
                    res_Second = "نوزده";
                    break;
                case "20":
                    res_Second = "بیست";
                    break;
                case "21":
                    res_Second = "بیست و یک";
                    break;
                case "22":
                    res_Second = "بیست و دو";
                    break;
                case "23":
                    res_Second = "بیست و سه";
                    break;
                case "24":
                    res_Second = "بیست و چهار";
                    break;
                case "25":
                    res_Second = "بیست و پنج";
                    break;
                case "26":
                    res_Second = "بیست و شش";
                    break;
                case "27":
                    res_Second = "بیست و هفت";
                    break;
                case "28":
                    res_Second = "بیست و هشت";
                    break;
                case "29":
                    res_Second = "بیست و نه";
                    break;
                case "30":
                    res_Second = "سی";
                    break;
                case "31":
                    res_Second = "سی و یک";
                    break;
                case "32":
                    res_Second = "سی و دو";
                    break;
                case "33":
                    res_Second = "سی و سه";
                    break;
                case "34":
                    res_Second = "سی و چهار";
                    break;
                case "35":
                    res_Second = "سی و پنچ";
                    break;
                case "36":
                    res_Second = "سی و شش";
                    break;
                case "37":
                    res_Second = "سی و هفت";
                    break;
                case "38":
                    res_Second = "سی و هشت";
                    break;
                case "39":
                    res_Second = "سی و نه";
                    break;
                case "40":
                    res_Second = "جهل";
                    break;
                case "41":
                    res_Second = "چهل و یک";
                    break;
                case "42":
                    res_Second = "چهل و دو";
                    break;
                case "43":
                    res_Second = "چهل و سه";
                    break;
                case "44":
                    res_Second = "چهل و چهار";
                    break;
                case "45":
                    res_Second = "چهل و پنج";
                    break;
                case "46":
                    res_Second = "چهل و شش";
                    break;
                case "47":
                    res_Second = "چهل و هفت";
                    break;
                case "48":
                    res_Second = "چهل و هشت";
                    break;
                case "49":
                    res_Second = "چهل و نه";
                    break;
                case "50":
                    res_Second = "پنجاه";
                    break;
                case "51":
                    res_Second = "پنجاه و یک";
                    break;
                case "52":
                    res_Second = "پنجاه و دو ";
                    break;
                case "53":
                    res_Second = "پنجاه و سه";
                    break;
                case "54":
                    res_Second = "پنجاه و چهار";
                    break;
                case "55":
                    res_Second = "پنجاه و پنج";
                    break;
                case "56":
                    res_Second = "پنجاه و شش";
                    break;
                case "57":
                    res_Second = "پنجاه و هفت";
                    break;
                case "58":
                    res_Second = "پنجاه و هشت";
                    break;
                case "59":
                    res_Second = "پنجاه و نه";
                    break;
            }
            textBox1.Text = res_Hour + " : " + res_Minute + " : " + res_Second;
        }
    }
}