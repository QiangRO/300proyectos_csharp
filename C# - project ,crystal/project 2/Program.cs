using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace project_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form2 LoginDialog = new Form2();

            DialogResult dialogResult;
            bool passwordValid = false;

            do
            {
                dialogResult = LoginDialog.ShowDialog();
                passwordValid = Security.IsValidLogin(LoginDialog.Login, LoginDialog.Password);
                if (!passwordValid)
                {
                    LoginDialog.Message = "رمز وارد شده اشتباه است";
                }
            }
            while ((!passwordValid) & (dialogResult == DialogResult.OK));

            if (passwordValid & (dialogResult == DialogResult.OK))
            {
                Application.Run(new Form1());
            }
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}
