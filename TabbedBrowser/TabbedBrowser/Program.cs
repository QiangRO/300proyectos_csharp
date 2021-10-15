using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TabbedBrowser
{
    static class Program
    {
        public static frmBrowser frmBrowserForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmBrowserForm = new frmBrowser();
            Application.Run(frmBrowserForm);
        }
    }
}
