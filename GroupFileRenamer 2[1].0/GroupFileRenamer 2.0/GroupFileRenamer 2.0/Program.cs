using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace GroupFileRenamer_2._
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] arguments=Environment.GetCommandLineArgs();
            string[] myArgument;
            string myString;
            foreach(string argument in arguments)
            {
                char[] myChar ={'='};
                myArgument = argument.Split(myChar);
                myString = myArgument[0] ;
                //myString = myString.ToLower();
                if (myString.ToLower() == "/u")
                {
                    string guid = myArgument[1];
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.System);
                    ProcessStartInfo si;
                    si = new ProcessStartInfo(path + "\\msiexec.exe", "/i " + guid);
                    Process myProcess;
                    myProcess = Process.Start(si);
                    myProcess.Close();
                    Application.Exit();
                    return;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}