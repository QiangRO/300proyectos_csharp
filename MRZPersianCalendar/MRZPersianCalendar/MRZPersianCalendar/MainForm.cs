using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MRZPersianCalendar
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point mouseFirstPos;
        private static bool isSettingFormOpen = false;
        private PersianDate persianDate;

        public static bool IsSettingFormOpen
        {
            set 
            {
                isSettingFormOpen = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
            SetDateParameters();
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        private void TimeChangedEventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }
        private void TimeElapsedEventHandler(object sender, Microsoft.Win32.TimerElapsedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
        private void LoadSettings()
        {
            Settings settings = new Settings();

            if (settings.FirstRun)
            {
                settings.Location = GetDefaultLocation();
                settings.FirstRun = false;
                settings.Save();
            }
            this.Location = settings.Location;
            this.Opacity = settings.Opacity;
            this.TopMost = settings.TopMost;
            this.BackColor = settings.BackColor;
        }

        private Point GetDefaultLocation()
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int x = screenWidth - this.Width - (screenWidth * 1 / 100);
            int y = screenHeight - this.Height - (screenHeight * 1 / 100);

            Point location = new Point(x, y);
            return location;
        }
        private void SetDateParameters()
        {
            persianDate = new PersianDate();
            MonthYearLable.Text = persianDate.ToString("MMMM yyyy", true);
            DayLable.Text = persianDate.ToString("d", true);
            DayNameLable.Text = persianDate.DayOfWeek;
        }

        private void Mouse_Down_EventHandler(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseFirstPos = new Point(e.X, e.Y);
        }

        private void Mouse_Up_EventHandler(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Mouse_Move_EventHandler(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                this.Location = new Point(this.Location.X + (e.X - mouseFirstPos.X),
                    this.Location.Y + (e.Y - mouseFirstPos.Y));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSettingFormOpen)
            {
                Settings settings = new Settings();

                settings.Location = this.Location;
                settings.Opacity = this.Opacity;
                settings.TopMost = this.TopMost;
                settings.BackColor = this.BackColor;

                settings.Save();
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mouse_Click_EventHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Visible == true)
                {
                    this.Visible = false;
                    showHideToolStripMenuItem.Text = "Show";
                }
                else 
                {
                    this.Visible = true;
                    showHideToolStripMenuItem.Text = "Hide";
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isSettingFormOpen == false)
            {
                SettingForm settingForm = new SettingForm();
                MainForm.isSettingFormOpen = true;
                settingForm.Show(this);
            }
        }

        private void Mouse_Click_EventHandlerDayNameLable_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!persianDate.DateTime.Equals(DateTime.Now))
                SetDateParameters();
        }

    }
}
