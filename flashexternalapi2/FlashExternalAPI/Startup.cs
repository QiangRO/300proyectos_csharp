using System;
using System.IO;
using System.Windows.Forms;

namespace Vml.FLVPlayer
{
	/// <summary>
	/// Summary description for Startup.
	/// </summary>
	public sealed class StartUp
	{
		private StartUp(){}

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(StartUp.UnhandledExceptionHandler);
            FLVPlayer startupForm;

            if(args.Length > 0 && File.Exists(args[0]))
            {
                startupForm = new FLVPlayer(args[0]);
            }
            else
            {
                startupForm = new FLVPlayer();
            }

            Application.Run(startupForm);
        }	

        private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                ExceptionUtilities.DisplayException("An unhandled exception has occurred.", (Exception)e.ExceptionObject);
            }
            catch(Exception ex){}
        }

	}
}
