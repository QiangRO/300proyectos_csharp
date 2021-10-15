using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLLBooks.Entities;
using BLLBooks.Providers;

namespace PLPhonebookWinforms.Persons
{
    public partial class FrmEditPerson : Form
    {
        clsPersonProvider _personProvider;
        clsPersonEntity _currentPerson;

        public FrmEditPerson(clsPersonEntity pCurrentPerson)
        {
            InitializeComponent();

            DialogResult = DialogResult.None;
            btnBack.DialogResult = DialogResult.Cancel;
            FormClosing += new FormClosingEventHandler(FrmEditPerson_FormClosing);

            do_Init_CurrentPerson(pCurrentPerson);
            _personProvider = new clsPersonProvider();
        }

        private void do_Init_CurrentPerson(clsPersonEntity pCurrentPerson)
        {
            txtCurrentLastName.Text = pCurrentPerson.LastName;
            txtCurrentTel.Text = pCurrentPerson.Tel;
            txtCurrentAddress.Text = pCurrentPerson.Address;

            _currentPerson = new clsPersonEntity(pCurrentPerson);
        }

        private void FrmEditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK && DialogResult != DialogResult.Cancel)
                e.Cancel = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_personProvider.Update(new clsPersonEntity() { LastName = txtNewLastName.Text, Tel = txtNewTel.Text, Address = txtNewAddress.Text }, _currentPerson.LastName))
                {
                    DialogResult = DialogResult.OK;
                    MessageBox.Show("Updated");
                }
                else
                    MessageBox.Show("Not Updated");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
