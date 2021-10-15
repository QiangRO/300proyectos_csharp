///////////////////////////////////////////////////////////////////////////////////////
//                                                                                   //
//                   EmailChecker, barnamenevisi : Samson Davidoff                   //
//                                                                                   //
///////////////////////////////////////////////////////////////////////////////////////

// Code -1 : Email motabar ast.
// Code 1  : Email na-motabar ast, character @ bishaz 1bar tekrar shode ast.
// Code 2  : Email na-motabar ast, character noghte (dot) bishaz 1bar tekrar shode ast.
// Code 3  : Email na-motabar ast, akhare email be ".com" khatm nashode ast.
// Code 4  : Email na-motabar ast, name service dahandeye email na-motabar ast,
// (hichkodam az service'haye : yahoo, gmail, hotmail, msn nist.

using System;
using System.Collections.Generic;
using System.Text;

namespace EmailValidation
{
    public class EmailChecker
    {
        public static bool EmailIsValid(string email)
        {
            bool result = false;
            string[] parts = email.Split('@');
            // --------------------------------------
            if (parts.Length != 2)
                result = false;
            else
            {
                parts = email.Split('.');
                if (parts.Length != 2)
                    result = false;
                else
                {
                    if (parts[1] != "com")
                        result = false;
                    else
                    {
                        parts = email.Split('@');
                        string server = parts[1].Substring(0, parts[1].Length - 4);
                        switch (server.ToLower())
                        {
                            case "yahoo":
                                result = true;
                                break;
                            case "gmail":
                                result = true;
                                break;
                            case "hotmail":
                                result = true;
                                break;
                            case "msn":
                                result = true;
                                break;
                            default:
                                result = false;
                                break;
                        }
                    }
                }
            }
            // --------------------------------------
            return result;
        }

        public static int InvalidEmailErrorCode(string email)
        {
            int result = -1;
            string[] parts = email.Split('@');
            // --------------------------------------
            if (parts.Length != 2)
                result = 1;
            else
            {
                parts = email.Split('.');
                if (parts.Length != 2)
                    result = 2;
                else
                {
                    if (parts[1] != "com")
                        result = 3;
                    else
                    {
                        parts = email.Split('@');
                        string server = parts[1].Substring(0, parts[1].Length - 4);
                        switch (server.ToLower())
                        {
                            case "yahoo":
                                result = -1;
                                break;
                            case "gmail":
                                result = -1;
                                break;
                            case "hotmail":
                                result = -1;
                                break;
                            case "msn":
                                result = -1;
                                break;
                            default:
                                result = 4;
                                break;
                        }
                    }
                }
            }
            // --------------------------------------
            return result;
        }
    }
}
