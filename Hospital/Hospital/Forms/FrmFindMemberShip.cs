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
    public partial class FrmFindMemberShip : Form
    {
        DataSet objDS = new DataSet();
        //Declare Command
        OleDbCommand objCMD;
        OleDbDataReader reader;
        public string message;
        public Boolean active = false;
        public long usertype;
        public string con;
        DataSet ds;
        DataRow dr;
        OleDbCommand cmd = new OleDbCommand();
        public static FrmPatientHome pubMember;
        public FrmFindMemberShip()
        {
            InitializeComponent();
        }

        private void btnFindMember_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPatientHome.pubMember.LoadMemberRecords("Select * from Member_Details where Memberid = " + txtFindNameOfMember.Text + "");
            }
            catch (Exception)
            {
                throw;
            }       
            btnCancelFindMember.PerformClick();
        }

        private void btnCancelFindMember_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFindMemberShip_Load(object sender, EventArgs e)
        {
            btnFindMember.Enabled = false;
        }

        private void txtFindNameOfMember_TextChanged(object sender, EventArgs e)
        {
            btnFindMember.Enabled = true;
        }      
    }
}