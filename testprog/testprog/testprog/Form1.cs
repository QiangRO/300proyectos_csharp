using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;

namespace testprog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i.ToString());  
            }

            for (int i = 1300; i <= 1400; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }


            DateTime time1 = new DateTime();
            time1 = DateTime.Now; 
            PersianCalendar objCalender = new PersianCalendar();


            ConvertToDay_Month(objCalender.GetYear(time1).ToString (), objCalender.GetMonth(time1).ToString (), objCalender.GetDayOfMonth(time1).ToString ());
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertToDay_Month(comboBox3.Text,comboBox2.Text ,comboBox1.Text);
            
        }

        private void ConvertToDay_Month(string Year,string Month,string Day)
        {
            try
            {
                System.Globalization.PersianCalendar x = new System.Globalization.PersianCalendar();
                DateTime dt = x.ToDateTime(Convert.ToInt16(Year), Convert.ToInt16(Month), Convert.ToInt16(Day), 0, 0, 0, 0);
                int WeekOfYear = x.GetWeekOfYear(dt, CalendarWeekRule.FirstDay, 0);
                string DayOfWeek1 = x.GetDayOfWeek(dt).ToString();
                string MonthOfYear = x.GetMonth(dt).ToString();

                switch (MonthOfYear)
                {
                    case "1": { MonthOfYear = "فروردین"; }; break;
                    case "2": { MonthOfYear = "اردیبهشت"; }; break;
                    case "3": { MonthOfYear = "خرداد"; }; break;
                    case "4": { MonthOfYear = "تیر"; }; break;
                    case "5": { MonthOfYear = "مرداد"; }; break;
                    case "6": { MonthOfYear = "شهریور"; }; break;
                    case "7": { MonthOfYear = "مهر"; }; break;
                    case "8": { MonthOfYear = "آبان"; }; break;
                    case "9": { MonthOfYear = "آذر"; }; break;
                    case "10": { MonthOfYear = "دی"; }; break;
                    case "11": { MonthOfYear = "بهمن"; }; break;
                    case "12": { MonthOfYear = "اسفند"; }; break;
                }


                switch (DayOfWeek1)
                {
                    case "Saturday": { DayOfWeek1 = "شنبه"; }; break;
                    case "ُُSunday": { DayOfWeek1 = "یکشبه"; }; break;
                    case "Monday": { DayOfWeek1 = "دوشنبه"; }; break;
                    case "Tuesday": { DayOfWeek1 = "سه شنبه"; }; break;
                    case "Wednesday": { DayOfWeek1 = "چهارشنبه"; }; break;
                    case "Thursday": { DayOfWeek1 = "پنجشنبه"; }; break;
                    case "Friday": { DayOfWeek1 = "جمعه"; }; break;
                }

                if (DayOfWeek1 == "Sunday")
                    DayOfWeek1 = "یکشنبه";

                label2.Text = DayOfWeek1 + "  " + Day + "  " + MonthOfYear + "  " + Year ;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime time1 = new DateTime();
            time1 = DateTime.Now;
            PersianCalendar objCalender = new PersianCalendar();


            ConvertToDay_Month(objCalender.GetYear(time1).ToString(), objCalender.GetMonth(time1).ToString(), objCalender.GetDayOfMonth(time1).ToString());
        }





            
    }
}
