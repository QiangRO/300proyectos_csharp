namespace NotePad_
{
    static class Program
    {
        public static SplashForm splashForm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            splashForm.Show();

            MainForm mainForm = new MainForm();
            mainForm.Refresh();

            //System.Threading.Thread.Sleep(10000);
            //Application.Run(new MainForm());
            System.Windows.Forms.Application.Run(mainForm);
            
        }
    }
}
