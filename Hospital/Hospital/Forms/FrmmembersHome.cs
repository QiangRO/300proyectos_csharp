using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DraggableForm
{
    public partial class FrmPatientHome : Form
    {
        //Declare Dataset object
        DataSet objDS = new DataSet();

        //Declare Command
        OleDbCommand objCMD;
        public static FrmPatientHome pubMember;
        public FrmPatientHome()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            FrmPatient frmAddPat = new FrmPatient();
            frmAddPat.ShowDialog();
        }

        private void btnFindComputer_Click(object sender, EventArgs e)
        {
            FrmFindMemberShip frmFindMem = new FrmFindMemberShip();
            frmFindMem.ShowDialog();
        }

        private void btnModifyMember_Click(object sender, EventArgs e)
        {
            try
            {
                //Sets the clsPublic.BoolUpdateComputerRec value to true which will
                //indicate that I want to update a record not insert a new one
                clsPublic.BoolUpdateComputerRec = true;

                //make the frmAddComputer to popup and insert in to the textboxes
                //the values of the selected row in the lvMembers
                FrmPatient frmModifyMem = new FrmPatient();

                frmModifyMem.tbMemberid.Text = lvMembers.Items[lvMembers.FocusedItem.Index].Text;
                frmModifyMem.tbName.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[1].Text;
                frmModifyMem.tbAddress.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[2].Text;
                frmModifyMem.tbMobileno.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[3].Text;
                frmModifyMem.tbEmailid.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[4].Text;
                frmModifyMem.tbAmount.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[5].Text;
                frmModifyMem.tbDiscount.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[6].Text;
                frmModifyMem.tbTotal.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[7].Text;
                frmModifyMem.rbtCash.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[8].Text;
                frmModifyMem.dtpFrom.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[9].Text;
                frmModifyMem.dtpTo.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[10].Text;
                frmModifyMem.tbOtherinfo.Text = lvMembers.Items[lvMembers.FocusedItem.Index].SubItems[11].Text;                                            

                frmModifyMem.ShowDialog();
            }
            catch (NullReferenceException)
            {
            }
        }
        public void LoadMemberRecords(string srcSQL)
        {
            //listView2.Items.Clear(); is used to clear the listView2 when you want
            //to list the Find results
            lvMembers.Items.Clear();

            //Create the DataAdapter needed to fill the listView2
            OleDbDataAdapter objDA = new OleDbDataAdapter(srcSQL, clsPublic.objConn);

            //Clears the DataSet and fills the DataAdapter
            objDS.Clear();
            objDA.Fill(objDS, "Member_Details");

            //Calculates the number of records and prints it in a label
            int vTotal = objDS.Tables["Member_Details"].Rows.Count;
            lblTotalMembers.Text = Convert.ToString(vTotal);

            //Calls the WriteListView method from the class clsMethod to 
            //fill the listView2 with rows
            clsMethod.WriteListView(objDS, lvMembers);

            objDS.Dispose();
            objDA.Dispose();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            //If there are records in the listView2 do...
            if (lvMembers.Items.Count != 0)
            {
                //If the result == pressing the Yes button do...
                if (MessageBox.Show("Do you want to permanently delete this record?", "Membership", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    try
                    {
                        //Opens the connection to the database
                        clsPublic.objConn.Open();

                        //Creates a new command with the string to delete the record
                        int a = Convert.ToInt32(lvMembers.Items[lvMembers.FocusedItem.Index].Text);
                        //objCMD = new OleDbCommand("Delete from Member_Details where Memberid = '" + lvMembers.Items[lvMembers.FocusedItem.Index].Text + "'", clsPublic.objConn);
                        objCMD = new OleDbCommand("Delete from Member_Details where Memberid = " + a + "", clsPublic.objConn);
                        //It executes the command
                        objCMD.ExecuteNonQuery();
                        objCMD.Dispose();

                        //It closes the connection to the database
                        clsPublic.objConn.Close();

                        //Display the confirmation that the record has been deleted
                        MessageBox.Show("1 record deleted.", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Perform a refresh of the listView1
                        btnRefreshComputer.PerformClick();
                    }
                    catch (NullReferenceException)
                    {
                    }
                    catch (OleDbException)
                    {
                        throw;
                    }
                }
            }
        }

        private void btnRefreshComputer_Click(object sender, EventArgs e)
        {
            //Sets the string that will be used for the DataAdapter sql string
            //Calls the LoadComputerRecords method to load all the computer records
            // listView2.Items.Clear();
            string strSQL = "Select * from Member_Details order by Memberid";
            LoadMemberRecords(strSQL);
            //StatusLabel2.Text = " |  Curent date and time: " + DateTime.Now.ToString() + "";
            clsPublic.objConn.Close();
        }

        private void FrmPatientHome_Load(object sender, EventArgs e)
        {
            //On load it performs a refresh of the lvMembers
            btnRefreshComputer.PerformClick();
            pubMember = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StatusLabel2.Text = " |  Curent date and time: " + DateTime.Now.ToString() + "";
        }
    }
}