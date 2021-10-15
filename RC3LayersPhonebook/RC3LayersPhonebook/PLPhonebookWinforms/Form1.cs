using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BLLBooks.Providers;
using PLPhonebookWinforms.Persons;
using BLLBooks.Entities;

namespace PLBooksWinforms
{
    public partial class Form1 : Form
    {
        private clsPersonProvider _personProvider;

        public Form1()
        {
            InitializeComponent();

            _personProvider = new clsPersonProvider();
            show_All();
        }

        private void show_All()
        {
            dataGridView1.DataSource = _personProvider.Get_All_Items();
        }
        private void add_New_Person()
        {
            //ba estefade az PersonProvider (clsPersonProvider) darkhast mide ta 
            //person e jadid b DB Add beshe..
            try
            {
                if (_personProvider.Add(new BLLBooks.Entities.clsPersonEntity()
                {
                    LastName = txtLastName.Text,
                    Tel = txtTel.Text,
                    Address = txtAddress.Text
                }))
                    MessageBox.Show("Added");
                else
                    MessageBox.Show("Not Added!!!");
            }
            catch (ArgumentNullException ex)
            {
                //dar doorati k LastName ya Tel# ro por nakarde bashe 
                //inja Exception i k rokh mide ro Catch mikone
                //...
                MessageBox.Show(ex.Message);
            }
        }
        private void find_Person()
        {
            dataGridView1.DataSource = _personProvider.Get_Items_By_LastName(txtFindLastName.Text);
        }
        private void delete_Person()
        {
            if (_personProvider.Delete(txtDeleteLastName.Text))
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Found or !Deleted");
        }
        private void edit_Person()
        {
            //ebteda Person e morede nazar (k ba LastName find mishe) 
            //ro peida mikone, age found beshe edaameye kar
            List<clsPersonEntity> foundPersons = _personProvider.Get_Items_By_LastName(txtEditLastName.Text);
            if (foundPersons.Count == 0)
            {
                MessageBox.Show("Nobody found");
                return;
            }

            //Constructor e form e FrmEditPerson 1 clsPersonEntity migire k 
            //ba inkar Person i k peida shode ro negah midare (baraye Update laazem mishe)
            FrmEditPerson frmEditPerson = new FrmEditPerson(
                new clsPersonEntity()
                {
                    LastName = foundPersons[0].LastName,
                    Address = foundPersons[0].Address,
                    Tel = foundPersons[0].Tel
                });

            frmEditPerson.ShowDialog();
        }


        private void btnShowAllPersons_Click(object sender, EventArgs e)
        {
            show_All();
        }
        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            edit_Person();
        }
        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            delete_Person();
        }
        private void btnFindByLastName_Click(object sender, EventArgs e)
        {
            find_Person();
        }
        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            add_New_Person();
        }
    }
}