using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColorFinder
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
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainForm() );
        }

        // توسط کدهای زیر، دکمه ها شکلشون در حین انتخاب عوض میشه که فقط جنبه زیبائی داره، نه چیز دیگه
        #region Just Style the Buttons

        public static void MakeButtonStyle( Button button )
        {
            button.MouseEnter += new EventHandler( button_MouseEnter );
            button.MouseLeave += new EventHandler( button_MouseLeave );
        }

        private static void button_MouseLeave( object sender, EventArgs e )
        {
            Button button = ( Button )sender;
            button.FlatStyle = FlatStyle.Standard;
            button.Font = new System.Drawing.Font( button.Font.FontFamily, button.Font.Size );
            button.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private static void button_MouseEnter( object sender, EventArgs e )
        {
            Button button = ( Button )sender;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new System.Drawing.Font( button.Font.FontFamily, button.Font.Size, System.Drawing.FontStyle.Bold );
            button.ForeColor = System.Drawing.Color.Green;
        }

        #endregion
    }
}