using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gammit.Device;
using Microsoft.Win32;

namespace Gammit
{
    static class Program
    {
        static DeviceGammaForm appForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SystemEvents.SessionEnded += new SessionEndedEventHandler(SystemEvents_SessionEnded);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Configuration.Load();
            if (Configuration.ResetOnStart)
            {
                DeviceGamma.SetGamma((float)Configuration.GammaLevel);
            }

            appForm = new DeviceGammaForm();

            if (Configuration.SilentStart)
            {
                appForm.Visible = false;
            }
            else
            {
                appForm.Visible = true;
            }
            

            Application.Run();
        }

        static void SystemEvents_SessionEnded(object sender, SessionEndedEventArgs e)
        {
            appForm.Close();
            Application.Exit();
        }
    }
}