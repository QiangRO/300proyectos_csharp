using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registrationNewBookToolStrip_Click(object sender, EventArgs e)
        {
            AddBook AddBook = new AddBook();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(AddBook.panel1);
            

        }

        private void CreateNewMemberToolstrip_Click(object sender, EventArgs e)
        {
            RegisterUserForm regu = new RegisterUserForm();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(regu.RegisterUserPanel);
        }

        private void sabtAmanatToolStrip_Click(object sender, EventArgs e)
        {
            trusteeshipRegister SabteAmanat = new trusteeshipRegister();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(SabteAmanat.trusteeshipPanel);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            RegisterAdmin RegAdmin = new RegisterAdmin();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(RegAdmin.panel1);
        }

        private void ثبتکتابدارجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registerlibrarian RL = new Registerlibrarian();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(RL.RegisterLibrarianPanel);

        }

        private void پشتیبانگیریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupDeatabase baup = new BackupDeatabase();
            baup .ShowDialog (this );
        }

        private void وروداطلاعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreBackup restore = new RestoreBackup();
            restore.ShowDialog(this);
        }

        private void EditInformationMemberToolStrip_Click(object sender, EventArgs e)
        {
            EditReisterUser ed = new EditReisterUser();
            ed.ShowDialog(this);

        }

        private void editAmanatToolStrip_Click(object sender, EventArgs e)
        {
            EditTrusteeshipRegister edit = new EditTrusteeshipRegister();
            edit.ShowDialog(this);
        }

        private void EditInformationBookToolStrip_Click(object sender, EventArgs e)
        {
            EditAddBook edit = new EditAddBook();
            edit.ShowDialog(this);
        }

        private void ویرایشاطلاعاتکتابدارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditLibrarian edit = new EditLibrarian();
            edit.ShowDialog(this);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            EditRegisteredAdmin edit = new EditRegisteredAdmin();
            edit.ShowDialog(this);

        }

        private void SearchMemberToolStrip_Click(object sender, EventArgs e)
        {
            RegisteredUserSearchFrom search = new RegisteredUserSearchFrom();
            search.ShowDialog(this);
        }

        private void SearchBookToolStrip_Click(object sender, EventArgs e)
        {
            SearchBook search = new SearchBook();
            search.ShowDialog(this);

        }

        private void tamdidezamaneamanatToolStrip_Click(object sender, EventArgs e)
        {
            TrusteeshipSearch search = new TrusteeshipSearch();
            search.ShowDialog(this);
        }

        private void EnterManagerToolStrip_Click(object sender, EventArgs e)
        {
            LoginLibraryManagment login = new LoginLibraryManagment();
            MainPanel.Controls.Clear();
            MainFormPanel main = new MainFormPanel();
            MainPanel.Controls.Add(main.MainFormPanelstatusStrip);
            login.ShowDialog(this);
        }

        private void EnterlibrarianToolStrip_Click(object sender, EventArgs e)
        {
            LoginLibrarian login = new LoginLibrarian();
            MainPanel.Controls.Clear();
            MainFormPanel main = new MainFormPanel();
            MainPanel.Controls.Add(main.MainFormPanelstatusStrip);
            login.ShowDialog(this);
        }

        private void BookAzDorKharejToolStrip_Click(object sender, EventArgs e)
        {
            BookAzDorKharej bo = new BookAzDorKharej();
            bo.ShowDialog(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bebmaxDate.persianDate pd = new bebmaxDate.persianDate(DateTime.Now);
             toolStripStatusLabel1.Text = pd.CompletePrsDate();
        }

        private void گزارشگیریکتابدارانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportingLibrarian report = new ReportingLibrarian();
            MainPanel.Controls.Clear();
            MainFormPanel main = new MainFormPanel();
            MainPanel.Controls.Add(main.MainFormPanelstatusStrip);
            report.ShowDialog(this);
        }

        private void گزارشگیریازبخشامانتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportingTrusteeship report = new ReportingTrusteeship();
            MainPanel.Controls.Clear();
            MainFormPanel main = new MainFormPanel();
            MainPanel.Controls.Add(main.MainFormPanelstatusStrip);
            report.ShowDialog(this);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            SearchBook search = new SearchBook();
            search.ShowDialog(this);
        }

        private void بخشاصلیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainFormPanel main = new MainFormPanel();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(main.panel1);
            
            
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog(this);
        }
    }
}