using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DB_DLL;

namespace DB_WinApp
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        public string EmpID = "";
        private void mainFrm_Load(object sender, EventArgs e)
        {
            fillDgView();
        }

        public void fillDgView()
        {
            string cnStr = "Data Source = " + System.Net.Dns.GetHostName() + ";Initial Catalog = Northwind;;Integrated Security = true";
            if (DB.dbConnected(cnStr))
            {
                DB myDB = new DB();
                dgView.DataSource = myDB.select(cnStr, "Select * from Employees").Tables[0];
                EmpID = "";
                txtUFirstName.Text = "";
                txtULastName.Text = "";
            }
            else
            {
                MessageBox.Show("Connection failed." + Environment.NewLine + "Check your connection string.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public DataSet getDataSet()
        {
            DataSet myDS = new DataSet();
            string cnStr = "Data Source = " + System.Net.Dns.GetHostName() + ";Initial Catalog = Northwind;;Integrated Security = true";
            if (DB.dbConnected(cnStr))
            {
                DB myDB = new DB();
                myDS = myDB.select(cnStr, "Select * from Employees");
            }
            return myDS;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0 && txtLastName.Text.Length > 0)
            {
                string cnStr = "Data Source = " + System.Net.Dns.GetHostName() + ";Initial Catalog = Northwind;;Integrated Security = true";
                if (DB.dbConnected(cnStr))
                {
                    DB myDB = new DB();
                    string insCmd = "Insert into Employees(LastName,FirstName) values('" + txtLastName.Text + "','" + txtFirstName.Text + "')";
                    MessageBox.Show(myDB.insert(cnStr, insCmd));
                    fillDgView();
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                }
                else
                {
                    MessageBox.Show("Connection failed." + Environment.NewLine + "Check your connection string.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Information not complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUFirstName.Text.Length > 0 && txtULastName.Text.Length > 0)
            {
                string cnStr = "Data Source = " + System.Net.Dns.GetHostName() + ";Initial Catalog = Northwind;;Integrated Security = true";
                if (DB.dbConnected(cnStr))
                {
                    DB myDB = new DB();
                    string updCmd = "Update Employees set LastName ='" + txtULastName.Text + "', FirstName ='" + txtUFirstName.Text + "' where EmployeeID ='" + EmpID +"'";
                    MessageBox.Show(myDB.update(cnStr,updCmd));
                    fillDgView();
                }
                else
                {
                    MessageBox.Show("Connection failed." + Environment.NewLine + "Check your connection string.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Information not complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgView_MouseUp(object sender, MouseEventArgs e)
        {
            EmpID = getDataSet().Tables[0].Rows[dgView.CurrentCell.RowIndex][0].ToString();
            txtULastName.Text = getDataSet().Tables[0].Rows[dgView.CurrentCell.RowIndex][1].ToString();
            txtUFirstName.Text = getDataSet().Tables[0].Rows[dgView.CurrentCell.RowIndex][2].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUFirstName.Text.Length > 0 && txtULastName.Text.Length > 0)
            {
                string cnStr = "Data Source = " + System.Net.Dns.GetHostName() + ";Initial Catalog = Northwind;;Integrated Security = true";
                if (DB.dbConnected(cnStr))
                {
                    DB myDB = new DB();
                    string delCmd = "Delete from Employees where EmployeeID = '" + EmpID + "'";
                    MessageBox.Show(myDB.delete(cnStr, delCmd));
                    fillDgView();
                }
                else
                {
                    MessageBox.Show("Connection failed." + Environment.NewLine + "Check your connection string.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Information not complete.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}