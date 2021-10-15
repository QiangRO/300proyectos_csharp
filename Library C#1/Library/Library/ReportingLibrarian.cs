using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class ReportingLibrarian : Form
    {
        public ReportingLibrarian()
        {
            InitializeComponent();
        }

        private void ReportingLibrarian_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.librarian' table. You can move, or remove it, as needed.
            this.librarianTableAdapter.Fill(this.libraryDataSet.librarian);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registerlibrarian register = new Registerlibrarian();
            register.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditLibrarian edit = new EditLibrarian();
            edit.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
