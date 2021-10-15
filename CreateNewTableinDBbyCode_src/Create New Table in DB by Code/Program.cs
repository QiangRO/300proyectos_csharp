using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Create_New_Table_in_DB_by_Code
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
