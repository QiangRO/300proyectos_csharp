using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Library
{
    public partial class RegisterUserForm : Form
    {
        SqlConnection objConnection = new SqlConnection("server=(local);database=Library;trusted_connection=yes");
        DataView objDataview = new DataView();
        private void ConnectTodatabase()
        {
            try
            {
                //Read Image Bytes into a byte array
                byte[] imageData = ReadFile(txtImagePath.Text);

                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "insert into RegisterUser (FirstName,LastName,NameOfFather,Jensiat,DateOfBurn,shomareshenasname,MojaradYamotahal,TellNumber,MObileNumber,shoghl,tahsilat,tarikheozviat,tozihat,address,ImageOriginalPath,ImageData) values (@FirstName,@LastName,@NameOfFather,@Jensiat,@DateOfBurn,@shomareshenasname,@MojaradYamotahal,@TellNumber,@MObileNumber,@shoghl,@tahsilat,@tarikheozviat,@tozihat,@address,@ImageOriginalPath,@ImageData)";
                objCommand.Parameters.AddWithValue("@FirstName", txtNameRegisterUser.Text);
                objCommand.Parameters.AddWithValue("@LastName", txtFamilyRegisterUser.Text);
                objCommand.Parameters.AddWithValue("@NameOfFather", txtNameOfFatherRegisterUser.Text);
                objCommand.Parameters.AddWithValue("@Jensiat", cboJensiatRegisterUser.SelectedItem);
                objCommand.Parameters.AddWithValue("@DateOfBurn", txtDateOfBurnRegisterUser_Masked.Text);
                objCommand.Parameters.AddWithValue("@shomareshenasname", txtShomareShenasnameRegisterUser.Text);
                objCommand.Parameters.AddWithValue("@MojaradYamotahal", CboMojaradYaMotahalRegisterUser.SelectedItem);
                objCommand.Parameters.AddWithValue("@TellNumber", txtTellNumber_Masked.Text);
                objCommand.Parameters.AddWithValue("@MObileNumber", txtMobileNumber_Masked.Text);
                objCommand.Parameters.AddWithValue("@shoghl", cboShoghlRegisterUser.SelectedItem);
                objCommand.Parameters.AddWithValue("@tahsilat", cboTahsilatRegisterUser.SelectedItem);
                objCommand.Parameters.AddWithValue("@tarikheozviat", txtTarikheOzviatregisterUser_Masked.Text);
                objCommand.Parameters.AddWithValue("@tozihat", txtTozihatRegisterUser.Text);
                objCommand.Parameters.AddWithValue("@address", txtAddressRegisterUser.Text);
                objCommand.Parameters.Add(new SqlParameter("@ImageOriginalPath", (object)txtImagePath.Text));
                objCommand.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

                objConnection.Open();
                objCommand.ExecuteNonQuery();
                objConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void EmptyFiled()
        {
            txtAddressRegisterUser.Text = string.Empty;
            txtFamilyRegisterUser.Text = string.Empty;
            txtNameOfFatherRegisterUser.Text = string.Empty;
            txtNameRegisterUser.Text = string.Empty;
            txtShomareShenasnameRegisterUser.Text = string.Empty;
            txtTozihatRegisterUser.Text = string.Empty;
        }
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            if ((txtNameRegisterUser.Text.Trim().Length > 0) && (txtFamilyRegisterUser.Text.Trim().Length > 0) && (txtNameOfFatherRegisterUser.Text.Trim().Length > 0) && (txtDateOfBurnRegisterUser_Masked.Text.Trim().Length > 0) && (txtShomareShenasnameRegisterUser.Text.Trim().Length > 0) && (txtTellNumber_Masked.Text.Trim().Length > 0) && (txtMobileNumber_Masked.Text.Trim().Length > 0) && (txtTarikheOzviatregisterUser_Masked.Text.Trim().Length > 0) && (txtTozihatRegisterUser.Text.Trim().Length > 0) && (txtAddressRegisterUser.Text.Trim().Length > 0) && (txtImagePath != null))
            {
                ConnectTodatabase();
                MessageBox.Show("کاربر با موفقیت ثبت شد");

            }

            else
            {
                MessageBox.Show("شما برای تکمیل عملیات باید فیلد های نام،نام خانوادگی،جنسیت،شماره ی شناسنامه،شماره تلفن،تحصیلات،تاریخ عضویت ، آدرس را پر کنید و یک عکس برای خود انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            objConnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmptyFiled();

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog opFileDl = new OpenFileDialog();

            opFileDl.Filter = "Your Picture For Store |*.JPG;*.JPEG;*.JPE;*.JFIF;*.bmp;*.dib,*.GIF;*.PNG| All File (*.*) |*.*";
            opFileDl.FilterIndex = 0;
            opFileDl.RestoreDirectory = true;


            if (opFileDl.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = opFileDl.FileName;
                txtImagePath.Text = opFileDl.FileName;
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

        private void button7_Click(object sender, EventArgs e)
        {
            EditReisterUser edit = new EditReisterUser();
            edit.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegisteredUserSearchFrom search = new RegisteredUserSearchFrom();
            search.ShowDialog(this);
        }
      
    }
}
