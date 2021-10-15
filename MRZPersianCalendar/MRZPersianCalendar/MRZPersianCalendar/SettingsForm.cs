using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MRZPersianCalendar
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            Owner.BackColor = settings.BackColor;
            Owner.Opacity = settings.Opacity;
            Owner.TopMost = settings.TopMost;

            MainForm.IsSettingFormOpen = false;
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            settings.TopMost = topMostCheckBox.Checked;
            settings.BackColor = colorLable.BackColor;
            settings.Opacity = (double)(opacityTrackBar.Value) / 10;
            settings.Startup = startupCheckBox.Checked;

            settings.Save();

            RegistryKey cu = Registry.CurrentUser;
            RegistryKey software = cu.OpenSubKey("Software", true);
            RegistryKey microsoft = software.OpenSubKey("Microsoft", true);
            RegistryKey windows = microsoft.OpenSubKey("Windows", true);
            RegistryKey currentversion = windows.OpenSubKey("CurrentVersion", true);
            RegistryKey run = currentversion.OpenSubKey("Run", true);

            if (startupCheckBox.Checked)
            {
                run.SetValue("MRZPersianCalendar", Application.ExecutablePath);
            }
            else 
            {
                run.DeleteValue("MRZPersianCalendar");
            }

            MainForm.IsSettingFormOpen = false;
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            colorNameLable.Text = settings.BackColor.Name;
            colorLable.BackColor = settings.BackColor;
            opacityTrackBar.Value = (int)(settings.Opacity * 10);
            topMostCheckBox.Checked = settings.TopMost;
            startupCheckBox.Checked = settings.Startup;
        }

        private void opacityTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Owner.Opacity = (double)(opacityTrackBar.Value) / 10;
        }

        private void topMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Owner.TopMost = topMostCheckBox.Checked;
        }

        private void colorLable_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                colorDialog1.ShowDialog();
                colorLable.BackColor = colorDialog1.Color;
                colorNameLable.Text = colorDialog1.Color.Name;
                Owner.BackColor = colorDialog1.Color;
            }
        }
    }
}
