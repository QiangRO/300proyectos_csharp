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
    public partial class EditTrusteeshipRegister : Form
    {
        public string IDNumber = "";
        SqlConnection conn = new SqlConnection("server=(local);database=Library;Trusted_connection=yes");
        SqlDataAdapter da;
        DataSet ds;

        private void UpdateData()
        {
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandType = CommandType.Text;
            com.CommandText = "update SabteAmanat set  IdBook='" + txtIdBook.Text + "',BookName=N'" + txtNameBook.Text + "',address=N'" + txtAddress.Text + "',DateAmanat=N'" + txtDateAmanat_Masked.Text + "',DateBack=N'" + txtToDate_Masked.Text + "', Tozihat=N'" + txtDescribe.Text + "' where ID='" + IDNumber + "'";
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
        }

        public EditTrusteeshipRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditTrusteeshipRegister_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from SabteAmanat", conn);
            da.Fill(ds, "SabteAmanat");
            dataGridView1.DataSource = ds;
            dataGridView1 .DataMember ="SabteAmanat";
            ///////
            dataGridView1.Columns["ID"].HeaderText = "#";
            dataGridView1.Columns["ID"].Width = 30;
            dataGridView1.Columns["IdBook"].HeaderText = "شماره کتاب";
            dataGridView1.Columns["IdBook"].Width = 30;
            dataGridView1.Columns["membershipID"].HeaderText = "شماره کاربری";
            dataGridView1.Columns["BookName"].HeaderText = "نام کتاب";
            dataGridView1.Columns["FirstName"].HeaderText = "نام";
            dataGridView1.Columns["LastName"].HeaderText = "فامیلی";
            dataGridView1.Columns["shomareshenasname"].HeaderText = "شناسنامه";
            dataGridView1.Columns["address"].HeaderText = "آدرس";
            dataGridView1.Columns["DateAmanat"].HeaderText = "تاریخ";
            dataGridView1.Columns["DateAmanat"].Width = 75;
            dataGridView1.Columns["DateBack"].HeaderText = "تا";
            dataGridView1.Columns["Tozihat"].HeaderText = "توضیح";
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDNumber = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtNameBook.Text = dataGridView1.Rows[e.RowIndex].Cells["BookName"].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
                txtShenasname.Text = dataGridView1.Rows[e.RowIndex].Cells["shomareshenasname"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtFamilyName.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtIdozviat.Text = dataGridView1.Rows[e.RowIndex].Cells["membershipID"].Value.ToString();
                txtDescribe.Text = dataGridView1.Rows[e.RowIndex].Cells["Tozihat"].Value.ToString();
                txtDateAmanat_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["DateAmanat"].Value.ToString();
                txtToDate_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["DateBack"].Value.ToString();
                txtIdBook.Text = dataGridView1.Rows[e.RowIndex].Cells["IdBook"].Value.ToString();

            }
            catch (System.Exception)
            {
                MessageBox.Show("برای انتخاب روی سطرها کلیک کنید");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateData();
                MessageBox.Show("اطلاعات با موفقیت بروز رسانی شد", "تراکنش موفق", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtIdBook.Text=string.Empty;
                txtToDate_Masked.Text = string.Empty;
                txtDateAmanat_Masked.Text = string.Empty;
                txtDescribe.Text = string.Empty;
                txtIdozviat.Text = string.Empty;
                txtFamilyName.Text = string.Empty;
                txtName.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtShenasname.Text = string.Empty;
                txtNameBook.Text = string.Empty;
                IDNumber = string.Empty;
                EditTrusteeshipRegister_Load(sender, e);
            }
            catch (Exception ee)
            {
                MessageBox.Show("مشکل در ثبت تغییرات" + "\n" + ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TrusteeshipSearch search = new TrusteeshipSearch();
            search.ShowDialog(this);
        }
    }
}
