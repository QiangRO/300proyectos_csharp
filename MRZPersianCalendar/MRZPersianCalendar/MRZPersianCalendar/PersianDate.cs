using System;
using System.Collections.Generic;
using System.Text;

namespace MRZPersianCalendar
{
    class PersianDate
    {
        private int _month;
        private int _day;
        private int _year;
        private int _dayOfYear;
        private DateTime _dateTime;

        public int Day
        {
            get
            {
                return _day;
            }
        }
        public string DayOfWeek
        {
            get
            {
                return GetDayName(_dateTime.DayOfWeek.GetHashCode());
            }
        }
        public int DayOfYear
        {
            get
            {
                return _dayOfYear;
            }
        }
        public int Month
        {
            get
            {
                return _month;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
        }
        public DateTime DateTime
        {
            get
            {
                return this._dateTime;
            }
        }
        public PersianDate()
        {
            _dateTime = DateTime.Now;
            CalculatePersianDate();
        }
        public PersianDate(int year, int month, int day)
        {
            _dateTime = new DateTime(year, month, day);
            CalculatePersianDate();
        }
        private void CalculatePersianDate()
        {
            int[] monthDays = new int[12] { 31, 31, 31, 31, 31, 31, 30, 30, 30, 30, 30, 30 };

            int dayOfYear = _dateTime.DayOfYear;
            _dayOfYear = 0;
            int year = _dateTime.Year;
            int totalDays = ((DateTime.IsLeapYear(year - 1)) ? 366 : 365);
            int varianceDays = 79;

            if (dayOfYear > varianceDays)
            {
                this._year = year - 621;
                _dayOfYear = dayOfYear - varianceDays;
            }
            else
            {
                this._year = year - 622;
                _dayOfYear = totalDays - (varianceDays - dayOfYear);
            }

            int sumOfDay = 0;
            for (int index = 0; index < 12; index++)
            {
                sumOfDay += monthDays[index];
                if (_dayOfYear <= sumOfDay)
                {
                    this._month = index + 1;
                    this._day = _dayOfYear - (sumOfDay - monthDays[index]);
                    break;
                }
            }
        }
        private string GetMonthName(int month)
        {
            if (month > 0) month--;
            string[] monthNames = new string[] { "فروردین" , "اردیبهشت" , "خرداد" ,
                                                "تیر" ,"مرداد" ,"شهریور" ,"مهر" ,
                                                "آبان" ,"آذر" ,"دی" ,"بهمن" ,"اسفند"};
            return monthNames[month];
        }
        private string GetDayName(int day)
        {
            string[] dayNames = new string[] { "یکشنبه", "دوشنبه", "سه شنبه", 
                                            "چهارشنبه", "پنج شنبه", "جمعه", "شنبه" };
            return dayNames[day];
        }
        public string ToLongDateString()
        {
            return ToLongDateString(" ", false);
        }
        public string ToLongDateString(string seprator)
        {
            return ToLongDateString(seprator, false);
        }
        public string ToLongDateString(string seprator, bool byPersianDigit)
        {
            int day = DateTime.Now.DayOfWeek.GetHashCode();
            string date = this.GetDayName(day)
                            + seprator + this._day
                            + seprator + this.GetMonthName(this._month)
                            + seprator + this._year;
            if (byPersianDigit) date = this.ConvertToPersianDigit(date);
            return date;
        }
        public string ToShortDateString()
        {
            return ToShortDateString("/", false);
        }
        public string ToShortDateString(string seprator)
        {
            return ToShortDateString(seprator, false);
        }
        public string ToShortDateString(string seprator, bool byPersianDigit)
        {
            string date = this._year + seprator + this._month + seprator + this._day;
            if (byPersianDigit) date = this.ConvertToPersianDigit(date);
            return date;
        }
        public string ToString(string format)
        {
            return ToString(format, false);
        }
        public string ToString(string format, bool byPersianDigit)
        {
            format = format.Replace("dddd", DayOfWeek);
            format = format.Replace("dd", ((byPersianDigit) ? ConvertToPersianDigit(_day.ToString("00")) : _day.ToString("00")));
            format = format.Replace("d", ((byPersianDigit) ? ConvertToPersianDigit(_day.ToString()) : _day.ToString()));
            format = format.Replace("MMMM", GetMonthName(_month));
            format = format.Replace("MMM", GetMonthName(_month).Substring(0, 3));
            format = format.Replace("MM", ((byPersianDigit) ? ConvertToPersianDigit(_month.ToString("00")) : _month.ToString("00")));
            format = format.Replace("M", ((byPersianDigit) ? ConvertToPersianDigit(_month.ToString()) : _month.ToString()));
            format = format.Replace("yyyy", ((byPersianDigit) ? ConvertToPersianDigit(_year.ToString()) : _year.ToString()));
            format = format.Replace("yyy", ((byPersianDigit) ? ConvertToPersianDigit((_year % 1000).ToString("000")) : (_year % 1000).ToString("000")));
            format = format.Replace("yy", ((byPersianDigit) ? ConvertToPersianDigit((_year % 100).ToString("00")) : (_year % 100).ToString("00")));
            format = format.Replace("y", ((byPersianDigit) ? ConvertToPersianDigit((_year % 100).ToString()) : (_year % 100).ToString()));
            return format;
        }
        private string ConvertToPersianDigit(string date)
        {
            date = date.Replace('1', '۱');
            date = date.Replace('2', '۲');
            date = date.Replace('3', '۳');
            date = date.Replace('4', '۴');
            date = date.Replace('5', '۵');
            date = date.Replace('6', '۶');
            date = date.Replace('7', '۷');
            date = date.Replace('8', '۸');
            date = date.Replace('9', '۹');
            date = date.Replace('0', '۰');

            return date;
        }

    }
}
