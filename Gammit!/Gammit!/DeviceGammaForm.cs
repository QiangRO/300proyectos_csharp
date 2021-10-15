using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Gammit.Device;

namespace Gammit
{
    public partial class DeviceGammaForm : Form
    {
        private bool ForceExit;

        public DeviceGammaForm()
        {
            InitializeComponent();
        }

        private void DeviceGammaForm_Load(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DeviceGamma.SetGamma((float)nudGammaLevel.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SynchronizeOptionsToForm();
            Visible = false;
        }

        private void SynchronizeFormToOptions()
        {
            Configuration.Load();

            nudGammaLevel.Value = Configuration.GammaLevel;
            CloseOnTray.Checked = Configuration.CloseOnTray;
            ForceExit = !Configuration.CloseOnTray;
            ClickOnTray.Checked = Configuration.ClickOnTray;
            SilentStart.Checked = Configuration.SilentStart;
            ResetOnStart.Checked = Configuration.ResetOnStart;

            if (nudGammaLevel.Value == 0)
            {
                nudGammaLevel.Value = (decimal)DeviceGamma.GetGamma();
                Configuration.GammaLevel = nudGammaLevel.Value;
                Configuration.Save();
            }
        }

        private void SynchronizeOptionsToForm()
        {
            Configuration.GammaLevel = nudGammaLevel.Value;
            Configuration.CloseOnTray = CloseOnTray.Checked;
            ForceExit = !Configuration.CloseOnTray;
            Configuration.ClickOnTray = ClickOnTray.Checked;
            Configuration.SilentStart = SilentStart.Checked;
            Configuration.ResetOnStart = ResetOnStart.Checked;

            Configuration.Save();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void DeviceGammaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ForceExit)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void MenuShow_Click(object sender, EventArgs e)
        {
            Visible = true;
        }

        private void DeviceGammaForm_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                SynchronizeFormToOptions();
            }
        }


        private void TrayIcon_DoubleClick(object sender, EventArgs e)
        {
            if (Configuration.ClickOnTray)
            {
                DeviceGamma.SetGamma((float)Configuration.GammaLevel);
            }
            else
            {
                Visible = true;
            }
        }

        private void ClickOnTray_CheckedChanged(object sender, EventArgs e)
        {
            if (ClickOnTray.Checked)
            {
                ClickOnTray.Text = "Double Click on Tray: Reset";
            }
            else
            {
                ClickOnTray.Text = "Double Click on Tray: Show";
            }
        }

        public void Exit()
        {
            ForceExit = true;
            Close();
            Application.Exit();
        }

        private void DeviceGammaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}