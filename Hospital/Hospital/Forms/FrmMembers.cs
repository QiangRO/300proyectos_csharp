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
    
    public partial class FrmPatient : Form
    {
       
        OleDbDataReader reader;
        public string message;
        public Boolean active = false;
        public string con;
        //MainClass mc = new MainClass();
        DataSet ds;
        DataRow dr;
        OleDbTransaction trans;
        OleDbCommand cmd = new OleDbCommand();
        public FrmPatient()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mc.con.Open();
            clsPublic.objConn.Open();
            string Query = "SELECT Memberid FROM Member_Details";
            //OleDbCommand cmd = new OleDbCommand(Query, mc.con);
            OleDbCommand cmd = new OleDbCommand(Query, clsPublic.objConn);
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //load Member id from Database
                    lblMemberidvalue.Text = reader["Memberid"].ToString();
                    long s;
                    s = Convert.ToInt32(lblMemberidvalue.Text);
                    s = s + 1;
                    tbMemberid.Text = s.ToString();
                }
            }
            else
            {
                tbMemberid.Text = "1";
            }
            //mc.con.Close();
            clsPublic.objConn.Close();
            
        }       
        private bool nonNumberEntered = false;
        private void tbAge_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;                       
                    }
                }
            }                 
        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }
               
        private void tbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCloseSaveChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChangesMember_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL;
                //if the clsPublic.BoolUpdateComputerRec == true it will indicate that I want
                //to do update an existing record, not insert a new record
                if (clsPublic.BoolUpdateComputerRec == true)
                {
                    //set the sql string that will be passed to the SaveComputerRecord
                    //method and to the command
                    //mname
                    //address
                    //mobileno
                    //emailid
                    //mamount
                    //discount
                    //tamount
                    //receivedby
                    //fduration
                    //tduration
                    strSQL = "Update Member_Details Set  mname = '" + tbName.Text +
                        "', address = '" + tbAddress.Text +
                        "', mobileno = " + tbMobileno.Text +
                        ", emailid = '" + tbEmailid.Text +
                        "', mamount = " + tbAmount.Text +
                        ", discount = " + tbDiscount.Text +
                        ", tamount = " + tbTotal.Text +
                        ", receivedby = '" + rbtCash.Text +
                        "', fduration = " + dtpFrom.Text +
                        ", tduration = " + dtpTo.Text +
                        ", otherinfo = '" + tbOtherinfo.Text +
                        "' Where Memberid = " + tbMemberid.Text + "";
                }

                //else...if the clsPublic.BoolUpdateComputerRec it is not true, which
                //means false, it will indicate that I want to insert a new record
                //not update an existing one
                else
                {
                    //set the sql string that will be passed to the SaveComputerRecord
                    //method and to the command
                    strSQL = "Insert Into Member_Details Values('" + tbMemberid.Text +
                        "', '" + tbName.Text +
                        "', '" + tbAddress.Text +
                        "', " + tbMobileno.Text +
                        ", '" + tbEmailid.Text +
                        "', " + tbAmount.Text +
                        ", " + tbDiscount.Text +
                        ", " + tbTotal.Text +
                        ", '" + rbtCash.Text +
                        "', " + dtpFrom.Text +
                        ", " + dtpTo.Text +
                        ", '" + tbOtherinfo.Text + "')";                        
                }

                //Calls the SaveComputerRecord method with the specified strSQL
                SaveComputerRecord(strSQL);
                btnClose.PerformClick();
            }

            catch (NullReferenceException NRE)
            {
                MessageBox.Show("Error:" + NRE.Message, "MMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Clear();
            //txtNameOfComputer.Focus();	
        }
        private void SaveComputerRecord(string srcSQL)
        {
            try
            {
                //Create the command and ste its sqlstring and connection
                OleDbCommand objCMD = new OleDbCommand(srcSQL, clsPublic.objConn);

                //Close any opened connection from previous actions
                clsPublic.objConn.Close();

                //Open up the connection
                clsPublic.objConn.Open();

                //Execute the command
                objCMD.ExecuteNonQuery();

                objCMD.Dispose();

                //Close the connection
                clsPublic.objConn.Close();

                //Display the confirmation that the record has been saved
                MessageBox.Show("Record has been successfully saved.", "Membership", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmPatientHome.pubMember.btnRefreshComputer.PerformClick();
            }
            catch (OleDbException ODBE)
            {
                MessageBox.Show("Error! Possible reasons:\nYou haven't specified all the necesary fields.\n\nThis window will close now." + ODBE.Source, "" + ODBE.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int returnValue = 0;
            number1 = int.Parse(tbAmount.Text);
            number2 = int.Parse(tbDiscount.Text);

            returnValue = Subtract(number1, number2);

            //MessageBox.Show(returnValue.ToString());
            tbTotal.Text = returnValue.ToString();
            lblDtotal.Text = returnValue.ToString();
        }
        private int Subtract(int firstNumber, int secondNumber)
        {
            int answer;
            answer = firstNumber - secondNumber;
            return answer;
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            tbTotal.Text = tbAmount.Text;
            lblDtotal.Text = tbAmount.Text;
        }

        private void rbtCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCheque.Checked = true)
            {
                gbCheque.Visible = true;
            }
            else
            {
                gbCheque.Visible = false;
            }

        }

        private void rbtCash_CheckedChanged(object sender, EventArgs e)
        {
            if (gbCheque.Visible = true)
            {
                gbCheque.Visible = false;
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            gbCheque.Visible = false;
            rbtCash.Checked = true;
        }

    }
}