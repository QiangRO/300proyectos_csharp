using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Library
{
    public partial class trusteeshipRegister : Form
    {
        public string StrConnection = "server=(local);database=Library;trusted_connection=yes";
        SqlDataReader Reader;
        SqlDataReader Reader2;
        SqlDataReader imageReader;
        bool boolCheckExistUsr = false;
        bool boolCheckExistBook = false;
        Image newImage;

        public bool CheckForExistUser()
        {
            using (SqlConnection Connection = new SqlConnection(StrConnection))
            {
                int IDForUser = Int32.Parse(txtIdozviat.Text);
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = Connection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "select ID,FirstName,LastName,shomareshenasname from RegisterUser where ID=" + IDForUser + "AND  FirstName=N'" + txtName.Text + "' AND LastName=N'" + txtFamilyName.Text + "' AND shomareshenasname='" + txtShenasname.Text + "'";
                
                Connection.Open();
                Reader = objCommand.ExecuteReader();
                
                if (Reader.HasRows == true)
                {
                    label1.BackColor = Color.Green;
                    label1.Text = "وجود دارد";
                    label4.BackColor = Color.Green;
                    label4.Text = "وجود دارد";
                    label5.BackColor = Color.Green;
                    label5.Text = "وجود دارد";
                    label6.BackColor = Color.Green;
                    label6.Text = "وجود دارد";
                    boolCheckExistUsr = true;
                    return boolCheckExistUsr;
                }
                else
                {
                    label1.BackColor = Color.Red;
                    label1.Text = "وجود ندارد";
                    label4.BackColor = Color.Red;
                    label4.Text = "وجود ندارد";
                    label5.BackColor = Color.Red;
                    label5.Text = "وجود ندارد";
                    label6.BackColor = Color.Red;
                    label6.Text = "وجود ندارد";
                    boolCheckExistUsr = false;
                    return boolCheckExistUsr;
                }

            }
        }

        private bool CheckExisBook()
        {
            using (SqlConnection Connection = new SqlConnection(StrConnection))
            {
                int IdForBook = Int32.Parse(txtIdBook.Text);
                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = Connection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "select IDBook,BookName from BookDetails where IDBook=" + IdForBook + " AND BookName=N'" + txtNameBook.Text + "'";

                if (Connection.State != ConnectionState.Open)
                    Connection.Open();

                Reader2 = objCommand.ExecuteReader();

                if (Reader2.HasRows == true)
                {
                    label2.BackColor = Color.Green;
                    label2.Text = label2.Text = "وجود دارد";
                    label7.BackColor = Color.Green;
                    label7.Text = label2.Text = "وجود دارد";
                    boolCheckExistBook = true;
                    return boolCheckExistBook;

                }
                else
                {
                    label2.BackColor = Color.Red;
                    label2.Text = "وجود ندارد";
                    label7.BackColor = Color.Red;
                    label7.Text = "وجود ندارد";
                    boolCheckExistBook = false;
                    return boolCheckExistBook;
                }
            }
        }
        private void GetImageRegisterUser()
        {
            using (SqlConnection Connection = new SqlConnection(StrConnection))
            {
                SqlCommand imageCommand = new SqlCommand("select ImageData,FirstName from RegisterUser where FirstName=N'"+txtName .Text +"'", Connection);
                if (Connection.State != ConnectionState.Open)
                    Connection.Open();
                imageReader = imageCommand.ExecuteReader();
                if (imageReader.HasRows == true)
                    imageReader.Read();
                byte[] ByteImage = (byte[])imageReader[0];
                MemoryStream Ms = new MemoryStream(ByteImage, 0, ByteImage.Length);
                Ms.Write(ByteImage, 0, ByteImage.Length);
                newImage = Image.FromStream(Ms, true);
                pictureBox1.Image = newImage;
                Connection.Close();
            }
        }
        public trusteeshipRegister()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection objConnection = new SqlConnection(StrConnection))
            {
                if ((txtName.Text.Length > 0) && (txtFamilyName.Text.Length > 0) && (txtNameBook.Text.Length > 0) && (txtToDate_Masked.Text.Length > 0) && (txtDateAmanat_Masked.Text.Length > 0))
                {
                    CheckForExistUser();
                    CheckExisBook();
                    GetImageRegisterUser();
                    if (boolCheckExistUsr == true && boolCheckExistBook == true)
                    {
                        int IdForBook = Int32.Parse(txtIdBook.Text);
                        int IdUser = Int32.Parse(txtIdozviat.Text);
                        try
                        {
                            SqlCommand objCommand = new SqlCommand();
                            objCommand.CommandType = CommandType.Text;
                            objCommand.Connection = objConnection;
                            objCommand.CommandText = "insert into SabteAmanat (IdBook,membershipID,BookName,FirstName,LastName,shomareshenasname,address,DateAmanat,DateBack,Tozihat) values (@IdBook,@membershipID,@BookName,@FirstName,@LastName,@shomareshenasname,@address,@DateAmanat,@DateBack,@Tozihat)";
                            objCommand.Parameters.AddWithValue("@IdBook", IdForBook);
                            objCommand.Parameters.AddWithValue("@membershipID", IdUser);
                            objCommand.Parameters.AddWithValue("@BookName", txtNameBook .Text );
                            objCommand.Parameters.AddWithValue("@FirstName", txtNameBook .Text );
                            objCommand.Parameters.AddWithValue("@LastName", txtFamilyName .Text );
                            objCommand.Parameters.AddWithValue("@shomareshenasname", txtShenasname .Text );
                            objCommand.Parameters.AddWithValue("@address", txtAddress .Text );
                            objCommand.Parameters.AddWithValue("@DateAmanat", txtDateAmanat_Masked .Text );
                            objCommand.Parameters.AddWithValue("@DateBack", txtToDate_Masked .Text );
                            objCommand.Parameters.AddWithValue("@Tozihat", txtDescribe .Text );
                            
                            if (objConnection.State != ConnectionState.Open)
                                objConnection.Open();

                            objCommand.ExecuteNonQuery();
                            objConnection.Close();
                        }
                        catch (SqlException ee)
                        {
                            MessageBox.Show(ee.Message);
                        }
                        MessageBox.Show("امانت در دیتابیس ذخیره شد");
                    }
                    else
                    {
                        MessageBox.Show("مقادیر وارد شده صحیح نمی باشند");
                    }
                }
                else
                {
                    MessageBox.Show("لطفا جاهای خالی را پر کنید");
                } objConnection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
       
            txtDateAmanat_Masked.Text = string.Empty;
            txtDescribe.Text = string.Empty;
            txtFamilyName.Text = string.Empty;
            txtIdozviat.Text = string.Empty;
            txtName.Text = string.Empty;
            txtNameBook.Text = string.Empty;
            txtIdBook.Text = string.Empty;
            txtToDate_Masked.Text = string.Empty;
            txtShenasname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            pictureBox1.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditTrusteeshipRegister edit = new EditTrusteeshipRegister();
            edit.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TrusteeshipSearch search = new TrusteeshipSearch();
            search.ShowDialog(this);
        }
    }
}