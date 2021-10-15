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
    public partial class Registerlibrarian : Form
    {
        SqlConnection MyConnection = new SqlConnection("server=(local);database=Library;Trusted_Connection=yes");



        private void ConnectToDatabase()
        {
            try
            {
                //Read Image Bytes into a byte array
                byte[] imageData = ReadFile(txtPicPath.Text);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = MyConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into librarian (FirstName,LastName,Jensiat,NameOfFather,shomareshenasname,DateOfBurn,librarianOriginalPath,ImageData,tarikheshorobekar,tarikheetmamekar,HomeTell,MobileNumber,HomeAddress,tozihat,CoedMelli)  values (@FisrName,@LastName,@Jensuat,@NameOfFather,@shomareshenasname,@DateOfBurn,@librarianOriginalPath,@ImageData,@tarikheshorobekar,@tarikheetmamekar,@HomeTell,@MobileNumber,@HomeAddress,@tozihat,@CodeMelli)";
                cmd.Parameters.AddWithValue("@FisrName", txtFname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmd.Parameters.AddWithValue("@Jensuat", combJensiat.SelectedItem);
                cmd.Parameters.AddWithValue("@NameOfFather", txtNameOfFather.Text);
                cmd.Parameters.AddWithValue("@shomareshenasname", txtShomareShenasname.Text);
                cmd.Parameters.AddWithValue("@DateOfBurn", txtDateOfBurn_Masked.Text);
                cmd.Parameters.Add(new SqlParameter("@librarianOriginalPath", (object)txtPicPath.Text));
                cmd.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));
                cmd.Parameters.AddWithValue("@tarikheshorobekar", txtBeginManager_Masked.Text);
                cmd.Parameters.AddWithValue("@tarikheetmamekar", txtendManager_Masked.Text);
                cmd.Parameters.AddWithValue("@HomeTell", txtHomeTell_Masked.Text);
                cmd.Parameters.AddWithValue("@MobileNumber", txtMObileNumber_Masked.Text);
                cmd.Parameters.AddWithValue("@HomeAddress", txtHomeAddress.Text);
                cmd.Parameters.AddWithValue("@tozihat", txtTozihat.Text);
                cmd.Parameters.AddWithValue("@CodeMelli", txtCodeMelli.Text);

                MyConnection.Open();
                cmd.ExecuteNonQuery();
                MyConnection.Close();
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }
        }


        public Registerlibrarian()
        {
            InitializeComponent();
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(System.Globalization.CultureInfo.CreateSpecificCulture("fa-IR"));

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog opFileDl = new OpenFileDialog();

            opFileDl.Filter = "Your Picture For Store |*.JPG;*.JPEG;*.JPE;*.JFIF;*.bmp;*.dib,*.GIF;*.PNG| All File (*.*) |*.*";
            opFileDl.FilterIndex = 0;
            opFileDl.RestoreDirectory = true;


            if (opFileDl.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = opFileDl.FileName;
                txtPicPath.Text = opFileDl.FileName;
            }
        }
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBeginManager_Masked.Text = string.Empty;
            txtCodeMelli.Text = string.Empty;
            txtDateOfBurn_Masked.Text = string.Empty;
            txtendManager_Masked.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtHomeAddress.Text = string.Empty;
            txtHomeTell_Masked.Text = string.Empty;
            txtPicPath.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtMObileNumber_Masked.Text = string.Empty;
            txtNameOfFather.Text = string.Empty;
            txtShomareShenasname.Text = string.Empty;
            txtTozihat.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((txtBeginManager_Masked.Text.Length > 0) && (txtCodeMelli.Text.Length > 0) && (txtDateOfBurn_Masked.Text.Length > 0) && (txtendManager_Masked.Text.Length > 0) && (txtFname.Text.Length > 0) && (txtHomeAddress.Text.Length > 0) && (txtHomeTell_Masked.Text.Length > 0) && (txtPicPath.Text.Length > 0) && (txtLname.Text.Length > 0) && (txtMObileNumber_Masked.Text.Length > 0) && (txtNameOfFather.Text.Length > 0) && (txtShomareShenasname.Text.Length > 0) && (txtTozihat.Text.Length > 0))
            {
                ConnectToDatabase();
                MessageBox.Show("کتابدار ثبت شد", "تراکنش", MessageBoxButtons.OK);
                txtBeginManager_Masked.Text = string.Empty;
                txtCodeMelli.Text = string.Empty;
                txtDateOfBurn_Masked.Text = string.Empty;
                txtendManager_Masked.Text = string.Empty;
                txtFname.Text = string.Empty;
                txtHomeAddress.Text = string.Empty;
                txtHomeTell_Masked.Text = string.Empty;
                txtPicPath.Text = string.Empty;
                txtLname.Text = string.Empty;
                txtMObileNumber_Masked.Text = string.Empty;
                txtNameOfFather.Text = string.Empty;
                txtShomareShenasname.Text = string.Empty;
                txtTozihat.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("جاهای خالی را پر کنید");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtPicPath.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditLibrarian edit = new EditLibrarian();
            edit.ShowDialog(this);
        }
    }
}