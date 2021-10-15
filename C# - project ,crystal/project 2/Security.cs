using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace project_2
{
    class Security
    {
        public static bool IsValidLogin(string login, string password)
        {
            //Login as always case insensitive
            int LoginMatch = String.Compare(login, "Admin", true, CultureInfo.CurrentCulture);
            int PasswordMatch = String.Compare(password, "1234", false, CultureInfo.CurrentCulture);

            if (Math.Abs(LoginMatch) + Math.Abs(PasswordMatch) == 0)
                return true;
            else return false;
        }
    }
}
