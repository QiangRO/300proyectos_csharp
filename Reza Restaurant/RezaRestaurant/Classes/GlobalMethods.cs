using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Management;
using System.IO;
using System.Windows.Forms;

namespace RezaRestaurant.Classes
{
    public static class GlobalMethods
    {
        public static string MD5(string password)
        {
            byte[] textBytes = System.Text.Encoding.Default.GetBytes(password);
            try
            {
                MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                string ret = "";
                foreach (byte a in hash)
                {
                    if (a < 16)
                        ret += "0" + a.ToString("x");
                    else
                        ret += a.ToString("x");
                }
                return ret;
            }
            catch { throw; }
        }

        static string Reverse(string str)
        {
            string res = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                res += str[i].ToString();
            }
            return res;
        }

        /// <summary>
        /// متدی برای تبدیل یک رشته به فرمت پول
        /// </summary>
        static public string MoneyFormat(this string str)
        {
            str = str.Replace(" ", "");
            string rev = Reverse(str);
            string res = "";
            int f = 0;
            for (int i = 0; i < rev.Length; i++)
            {
                f++;
                res += rev[i].ToString();
                if (f == 3)
                {
                    res += "/";
                    f = 0;
                }
            }
            res = Reverse(res);
            if (res[0] == '/')
                res = res.Remove(0, 1);
            return res;
        }

        /// <summary>
        /// متدی برای تبدیل اعداد انگلیسی به فارسی
        /// </summary>
        public static string ToPersianNumber(this string input)
        {
            //۰ ۱ ۲ ۳ ۴ ۵ ۶ ۷ ۸ ۹

            input = input.Replace("0", "۰");
            input = input.Replace("1", "۱");
            input = input.Replace("2", "۲");
            input = input.Replace("3", "۳");
            input = input.Replace("4", "۴");
            input = input.Replace("5", "۵");
            input = input.Replace("6", "۶");
            input = input.Replace("7", "۷");
            input = input.Replace("8", "۸");
            input = input.Replace("9", "۹");

            return input;
        }

        /// <summary>
        /// متدی برای تبدیل اعداد فارسی به انگلیسی
        /// </summary>
        public static string ToEnglishNumber(this string input)
        {
            //۰ ۱ ۲ ۳ ۴ ۵ ۶ ۷ ۸ ۹
            input = input.Replace("/", "");
            input = input.Replace("۰", "0");
            input = input.Replace("۱", "1");
            input = input.Replace("۲", "2");
            input = input.Replace("۳", "3");
            input = input.Replace("۴", "4");
            input = input.Replace("۵", "5");
            input = input.Replace("۶", "6");
            input = input.Replace("۷", "7");
            input = input.Replace("۸", "8");
            input = input.Replace("۹", "9");

            return input;
        }

        public static bool SetDefaultPrinter(string defaultPrinter)
        {
            using (ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer"))
            {
                using (ManagementObjectCollection objectCollection = objectSearcher.Get())
                {
                    foreach (ManagementObject mo in objectCollection)
                    {
                        if (string.Compare(mo["Name"].ToString(), defaultPrinter, true) == 0)
                        {
                            mo.InvokeMethod("SetDefaultPrinter", null, null);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static string PersianDate(string ChristianDate, bool showClock, bool rightToLeft)
        {
            DateTime dateTime = DateTime.Parse(ChristianDate);
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();
            string str = "";
            if (rightToLeft)
            {
                str = persianCalendar.GetYear(dateTime).ToString("0000") + "/" +
                      persianCalendar.GetMonth(dateTime).ToString("00") + "/" +
                      persianCalendar.GetDayOfMonth(dateTime).ToString("00");
                if (showClock)
                {
                    str += "   " +
                    persianCalendar.GetHour(dateTime).ToString("00") + ":" +
                    persianCalendar.GetMinute(dateTime).ToString("00") + ":" +
                    persianCalendar.GetSecond(dateTime).ToString("00");
                }
            }
            else
            {
                if (showClock)
                {
                    str = persianCalendar.GetHour(dateTime).ToString("00") +
                      ":" + persianCalendar.GetMinute(dateTime).ToString("00") +
                      ":" + persianCalendar.GetSecond(dateTime).ToString("00");
                }
                str += "   " + persianCalendar.GetDayOfMonth(dateTime).ToString("00") +
                  "/" + persianCalendar.GetMonth(dateTime).ToString("00") +
                  "/" + persianCalendar.GetYear(dateTime).ToString("0000");
            }
            return str;
        }

        /// <summary>
        /// متن تاریخ را راست به چپ می کند
        /// </summary>
        /// <param name="DateString">۰۸:۴۱:۵۱   ۰۲/۰۷/۱۳۸۸</param>
        /// <returns>۱۳۸۸/۰۷/۰۲   ۰۸:۴۱:۵۱</returns>
        public static string SetRightToLeft(string DateString)
        {
            DateString = DateString.Replace(" ", "");

            string year = DateString.Substring(DateString.LastIndexOf('/') + 1, 4);
            string month = DateString.Substring(DateString.IndexOf('/') + 1, 2);
            string day = DateString.Substring(DateString.IndexOf('/') - 2, 2);

            string clock = DateString.Substring(0, 8);

            return year + "/" + month + "/" + day + "   " + clock;
        }

        /// <summary>
        /// تابع تبدیل تاریخ شمسی به میلادی
        /// </summary>
        /// <param name="PersianDate">تاریخ شمسی ، نیازی به حذف فاصله نیست</param>
        public static DateTime ChristianDate(string PersianDate)
        {
            PersianDate = PersianDate.Replace(" ", "");

            int year = int.Parse(PersianDate.Substring(0, PersianDate.IndexOf('/')));
            int month = int.Parse(PersianDate.Substring(PersianDate.IndexOf('/') + 1, 2));
            int day = int.Parse(PersianDate.Substring(PersianDate.LastIndexOf('/') + 1, 2));

            int hour = 0;
            int minute = 0;
            int second = 0;

            try
            {
                hour = int.Parse(PersianDate.Substring(10, 2));
                minute = int.Parse(PersianDate.Substring(13, 2));
                second = int.Parse(PersianDate.Substring(16, 2));
            }
            catch { }

            if (month > 12 || month < 01 || day > 31 || day < 01 || hour > 24 || hour < 00 || minute > 60 || minute < 00 || second > 60 || second < 00)
                throw new Exception("فرمت تاریخ اشتباه است");

            System.Globalization.PersianCalendar PCalendar = new System.Globalization.PersianCalendar();
            return PCalendar.ToDateTime(year, month, day, hour, minute, second, 0);
        }
    }
}
