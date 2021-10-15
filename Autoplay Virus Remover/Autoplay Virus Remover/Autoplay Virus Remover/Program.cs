using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Autoplay_Virus_Remover
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            int isrun = 0;
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process prc in process)
            {
                if (prc.ProcessName == "My Simple AntiVirus 1.0")
                {                    
                    isrun++;                    
                }
            }
            if (isrun <=1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmmain());
            }
            else MessageBox.Show("Apllication Is Run", "My Simple Antivirus 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}