using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabbedBrowser
{
    public partial class frmBrowser : Form
    {
        private WebBrowser[] browser = new WebBrowser[50];
        private int browser_index = 0;
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {
            TabPage mainPage = new TabPage("Google");
            browser[browser_index] = new WebBrowser();
            browser[browser_index].Dock = DockStyle.Fill;
            browser[browser_index].Navigate("www.google.com");
            mainPage.Controls.Add(browser[browser_index]);
            this.tabControl.TabPages.Add(mainPage);
        }


        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser[tabControl.SelectedIndex].Navigate(txtUrl.Text);
                browser[tabControl.SelectedIndex].DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(frmBrowser_DocumentCompleted);
                browser[tabControl.SelectedIndex].ProgressChanged += new WebBrowserProgressChangedEventHandler(frmBrowser_ProgressChanged);
            }
        }

        void frmBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            int current_progress = Convert.ToInt32(e.CurrentProgress);
            int total_progress = Convert.ToInt32(e.MaximumProgress);
            this.progressBar.Value = (current_progress / total_progress)  * 100;
        }

        void frmBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.tabControl.SelectedTab.Text = browser[tabControl.SelectedIndex].DocumentTitle;
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewTab();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            browser[browser_index].GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            browser[browser_index].GoForward();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            browser[browser_index].Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            browser[browser_index].Stop();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrowser newBrowserWindow = new frmBrowser();
            newBrowserWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
        }

        public void AddNewTab()
        {
            browser_index++;
            TabPage newTabPage = new TabPage("Untitled");
            browser[browser_index] = new WebBrowser();
            browser[browser_index].Dock = DockStyle.Fill;
            browser[browser_index].Navigate("www.google.com");
            newTabPage.Controls.Add(browser[browser_index]);
            this.tabControl.TabPages.Add(newTabPage);
            this.tabControl.SelectTab(newTabPage);
        }
    }
}
