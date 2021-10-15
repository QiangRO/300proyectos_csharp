using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FiFa
{
    class Convertor
    {
        public static string ConvertToFinglish(string sourceText)
        {
            string temp = null;

            for (int counter = 0; counter < sourceText.Length; counter++)
            {
                switch (sourceText[counter])
                {
                    case 'a':
                        if (counter != 0 && sourceText[counter - 1] == 'a')
                            temp = temp.Substring(0, temp.Length - 1) + 'ا';
                        else
                            temp += "َ";
                        break;
                    case 'A':
                        temp += "آ";
                        break;
                    case 'b':
                        temp += "ب";
                        break;
                    case 'c':
                        temp += "ث";
                        break;
                    case 'd':
                        temp += "د";
                        break;
                    case 'e':
                        if (counter != 0 && sourceText[counter - 1] == 'e')
                            temp = temp.Substring(0, temp.Length - 1) + 'ه';
                        else
                            temp += "ِ";
                        break;
                    case 'E':
                        temp += "ع";
                        break;
                    case 'f':
                        temp += "ف";
                        break;
                    case 'g':
                        temp += 'گ';
                        break;
                    case 'h':
                        if (counter != 0 && sourceText[counter - 1] == 'c')
                            temp = temp.Substring(0, temp.Length - 1) + 'چ';
                        else if (counter != 0 && sourceText[counter - 1] == 'g')
                            temp = temp.Substring(0, temp.Length - 1) + 'ق';
                        else if (counter != 0 && sourceText[counter - 1] == 'G')
                            temp = temp.Substring(0, temp.Length - 1) + 'غ';
                        else if (counter != 0 && sourceText[counter - 1] == 'k')
                            temp = temp.Substring(0, temp.Length - 1) + 'خ';
                        else if (counter != 0 && sourceText[counter - 1] == 'j')
                            temp = temp.Substring(0, temp.Length - 1) + 'ژ';
                        else if (counter != 0 && sourceText[counter - 1] == 's')
                            temp = temp.Substring(0, temp.Length - 1) + 'ش';
                        else
                            temp += 'ه';
                        break;
                    case 'H':
                        temp += 'ح';
                        break;
                    case 'i':
                        if (counter != 0 && sourceText[counter - 1] == 'e')
                            temp = temp.Substring(0, temp.Length - 1) + 'ئ';
                        else
                            temp += 'ی';
                        break;
                    case 'I':
                        temp += "ای";
                        break;
                    case 'j':
                        temp += "ج";
                        break;
                    case 'k':
                        temp += "ک";
                        break;
                    case 'l':
                        temp += "ل";
                        break;
                    case 'm':
                        temp += "م";
                        break;
                    case 'n':
                        temp += "ن";
                        break;
                    case 'o':
                        if (counter != 0 && sourceText[counter - 1] == 'o')
                            temp = temp.Substring(0, temp.Length - 1) + 'و';
                        else
                            temp += "ُ";
                        break;
                    case 'p':
                        temp += "پ";
                        break;
                    case 'r':
                        temp += "ر";
                        break;
                    case 's':
                        temp += "س";
                        break;
                    case 'S':
                        temp += "ص";
                        break;
                    case 't':
                        temp += "ت";
                        break;
                    case 'T':
                        temp += "ط";
                        break;
                    case 'u':
                        temp += "و";
                        break;
                    case 'v':
                        temp += "و";
                        break;
                    case 'w':
                        temp += "";
                        break;
                    case 'x':
                        temp += "س";
                        break;
                    case 'y':
                        temp += "ی";
                        break;
                    case 'z':
                        temp += "ز";
                        break;
                    case 'Z':
                        temp += "ذ";
                        break;
                    default:
                        temp += sourceText[counter];
                        break;
                }
            }

            return temp;
        }
    }
}
