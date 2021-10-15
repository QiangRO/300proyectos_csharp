///////////////////////////////////////////
//      Programmer: Mojtaba  AZAD        //
//     Contact: m_azad70@yahoo.com       //
//  Visit us: www.jsbank.mihanblog.com   //
//      1388/06/01  ---  2009/08/23      //
///////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Text;

namespace NTOL
{
    /// <summary>
    /// کلاسی برای تبدیل عدد به حروف
    /// </summary>
    public static class NumberToLetter
    {
        /// <summary>
        /// برای تبدیل یکان عدد به حرف استفاده می شود
        /// </summary>
        /// <param name="Literal">حاوی شکل حروفی اعداد تبدیل شده در مرحله قبل</param>
        /// <param name="digit_yekan">یکان عدد</param>
        /// <param name="digit_dahgan">دهگان عدد</param>
        /// <param name="haveup">آیا مرحله قبل وجود دارد</param>
        /// <returns>شکل حرفی عدد String</returns>
        private static string Ones(string Literal, int digit_yekan, int digit_dahgan, bool haveup)
        {

            if (digit_dahgan != 1)
            {
                if (digit_yekan == 0 && !haveup)
                    return Literal = "صفر";
                else if (digit_yekan == 0 && haveup)
                    return Literal;
                if (haveup)
                {
                    Literal += " و ";
                }
                switch (digit_yekan)
                {
                    case 1:
                        Literal += "یک";
                        break;
                    case 2:
                        Literal += "دو";
                        break;
                    case 3:
                        Literal += "سه";
                        break;
                    case 4:
                        Literal += "چهار";
                        break;
                    case 5:
                        Literal += "پنج";
                        break;
                    case 6:
                        Literal += "شش";
                        break;
                    case 7:
                        Literal += "هفت";
                        break;
                    case 8:
                        Literal += "هشت";
                        break;
                    default:
                        Literal += "نه";
                        break;
                }
            }
            return Literal;
        }
        /// <summary>
        /// برای تبدیل دهگان عدد به حرف استفاده می شود
        /// </summary>
        /// <param name="Literal">حاوی شکل حروفی اعداد تبدیل شده در مرحله قبل</param>
        /// <param name="digit_yekan">یکان عدد</param>
        /// <param name="digit_dahgan">دهگان عدد</param>
        /// <param name="haveup">آیا مرحله قبل وجود دارد</param>
        /// <returns>شکل حرفی عدد String</returns>
        private static string Tens(string Literal, int digit_yekan, int digit_dahgan, bool haveup)
        {
            if (haveup && digit_dahgan != 0)
                Literal += " و ";
            if (digit_dahgan == 1)
            {
                switch (digit_yekan)
                {
                    case 0:
                        Literal += "ده";
                        break;
                    case 1:
                        Literal += "یازده";
                        break;
                    case 2:
                        Literal += "دوازده";
                        break;
                    case 3:
                        Literal += "سیزده";
                        break;
                    case 4:
                        Literal += "چهارده";
                        break;
                    case 5:
                        Literal += "پانزده";
                        break;
                    case 6:
                        Literal += "شانزده";
                        break;
                    case 7:
                        Literal += "هفده";
                        break;
                    case 8:
                        Literal += "هجده";
                        break;
                    case 9:
                        Literal += "نوزده";
                        break;
                }
            }
            else
            {
                switch (digit_dahgan)
                {
                    case 2:
                        Literal += "بیست";
                        break;
                    case 3:
                        Literal += "سی";
                        break;
                    case 4:
                        Literal += "چهل";
                        break;
                    case 5:
                        Literal += "پنجاه";
                        break;
                    case 6:
                        Literal += "شصت";
                        break;
                    case 7:
                        Literal += "هفتاد";
                        break;
                    case 8:
                        Literal += "هشتاد";
                        break;
                    case 9:
                        Literal += "نود";
                        break;
                }
            }
            return Literal;

        }
        /// <summary>
        /// برای تبدیل صدگان عدد به حرف استفاده می شود
        /// </summary>
        /// <param name="Literal">حاوی شکل حروفی اعداد تبدیل شده در مرحله قبل</param>
        /// <param name="digit_sadgan">صدگان عدد</param>
        /// <param name="haveup">آیا مرحله قبل وجود دارد</param>
        /// <returns>شکل حرفی عدد String</returns>
        private static string Hundreds(string Literal, int digit_sadgan, bool haveup)
        {
            if (haveup)
                Literal += " و ";
            switch (digit_sadgan)
            {
                case 1:
                    Literal += "یکصد";
                    break;
                case 2:
                    Literal += "دویست";
                    break;
                case 3:
                    Literal += "سیصد";
                    break;
                case 4:
                    Literal += "چهارصد";
                    break;
                case 5:
                    Literal += "پانصد";
                    break;
                case 6:
                    Literal += "ششصد";
                    break;
                case 7:
                    Literal += "هفتصد";
                    break;
                case 8:
                    Literal += "هشتصد";
                    break;
                case 9:
                    Literal += "نهصد";
                    break;
            }
            return Literal;
        }
        /// <summary>
        /// تبدیل عدد سه رقمی به شکل حروفی اش
        /// </summary>
        /// <param name="input">یک عدد سه رقمی برای تبدیل شدن به شکل حروفی اش</param>
        /// <returns>شکل حروفی عدد وارد شده</returns>
        private static string Thousand(int input)
        {
            List<int> digits = new List<int>();
            while (input >= 0)
            {
                if (input == 0 && digits.Count == 0)
                {
                    digits.Add(input);
                    break;
                }
                else if (input == 0 && digits.Count != 0)
                    break;
                digits.Add(input % 10);
                input /= 10;
            }
            if (digits.Count == 1)
            {
                return Ones("", digits[0], 0, false);
            }
            else if (digits.Count == 2)
            {
                return Ones(Tens("", digits[0], digits[1], false), digits[0], digits[1], true);
            }
            else
            {
                return Ones(Tens(Hundreds("", digits[2], false), digits[0], digits[1], true), digits[0], digits[1], true);
            }


        }
        private static string Leveler(int level, bool flag)
        {
            if (flag)
            {
                switch (level)
                {
                    case 0:
                        return " ";
                    case 1:
                        return " هزار و ";
                    case 2:
                        return " میلیون و ";
                    case 3:
                        return " میلیارد و ";
                    case 4:
                        return " بیلیون و ";
                    case 5:
                        return " بیلیارد و ";
                    case 6:
                        return " تریلیون و ";
                    case 7:
                        return " تریلیارد و ";
                    case 8:
                        return " کادریلیون و ";
                    default:
                        return "ERROR";
                }
            }
            else
            {
                switch (level)
                {
                    case 0:
                        return " ";
                    case 1:
                        return " هزار ";
                    case 2:
                        return " میلیون ";
                    case 3:
                        return " میلیارد ";
                    case 4:
                        return " بیلیون ";
                    case 5:
                        return " بیلیارد ";
                    case 6:
                        return " تریلیون ";
                    case 7:
                        return " تریلیارد ";
                    case 8:
                        return " کادریلیون ";
                    default:
                        return "ERROR";
                }
            }
        }
        /// <summary>
        /// تبدیل عدد به حروف
        /// </summary>
        /// <param name="number">یک عدد حداکثر 27 رقمی به صورت رشته</param>
        /// <returns></returns>
        public static string Convert(string number)
        {
            int Length = number.Length, Level = 0;
            string Text = "";
            List<int> TriDigits = new List<int>();
            bool flag = false;

            if (Length != 0)
            {
                try
                {
                    while (Length != 0)
                    {
                        if (Length > 3)
                        {
                            TriDigits.Add(System.Convert.ToInt32(number.Substring(Length - 3, 3)));
                            Length -= 3;
                        }
                        else
                        {
                            TriDigits.Add(System.Convert.ToInt32(number.Substring(0, Length)));
                            Length = 0;
                        }
                    }
                }
                catch (Exception er)
                {
                    return "لطفا فقط عدد وارد کنید !";
                }

                foreach (int num in TriDigits)
                {
                    if (num != 0)
                    {
                        if (Leveler(Level, flag) == "ERROR")
                            break;
                        else
                        {
                            Text = Leveler(Level, flag) + Text;
                            Text = Thousand(num) + Text;
                            flag = true;
                        }
                    }
                    Level++;
                }
                if (Text == "")
                    return "صفر";
                else
                    return Text;
            }
            else
                return "لطفا عدد مورد نظر را وارد کنید !";

        }
    }
}
