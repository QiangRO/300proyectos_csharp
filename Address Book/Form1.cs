using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Address_Book
{
    public partial class Form1 : Form
    {
        public string DataFileName
        {
            get
            {
                string folder;
                folder = Environment.CurrentDirectory;
                return folder + "\\AdressBook.xml";
            }

        }
        public void PopulateAddressFrom(Address address)
        {
            address.FirstName = txtFirstName.Text;
            address.LastName = txtLastName.Text;
            address.CompanyName= txtCompanyName.Text;
            address.Address1 = txtAddress1.Text;
            address.Address2 = txtAddress2.Text;
            address.City = txtCity.Text;
            address.Region= txtRegion.Text;
            address.PostalCode = txtPostalCode.Text;
            address.Country = txtCountry.Text;
            address.Email = txtEmail.Text;


        }
        public void PopulateFormFromAddress(Address address)
        // copy the values...
        {
            txtFirstName.Text = address.FirstName;
            txtLastName.Text = address.LastName;
            txtCompanyName.Text = address.CompanyName;
            txtAddress1.Text = address.Address1;
            txtAddress2.Text = address.Address2;
            txtCity.Text = address.City;
            txtRegion.Text = address.Region;
            txtPostalCode.Text = address.PostalCode;
            txtCountry.Text = address.Country;
            txtEmail.Text = address.Email;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load the address using a shared method on SerializableData...
            Address newAddress = (Address)SerializableData.Load(DataFileName,
                                        typeof(Address));
            // update the display...
            PopulateFormFromAddress(newAddress);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            PopulateAddressFrom(address);
            string filename = DataFileName;
            address.Save(filename);
            MessageBox.Show("the address was saved to" + filename);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           
        }

        private void lnkSendEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto: " + txtEmail.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }
    }
}