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
    public partial class RegisterAdmin : Form
    {
        SqlConnection Myconnection = new SqlConnection("server=(local);database=Library;trusted_connection=yes");

        private void ConnectToDatabase()
        {
            
            try
            {
                //Read Image Bytes into a byte array
                byte[] imageData = ReadFile(txtImagePath.Text);

            SqlCommand cmd=new SqlCommand ();
            cmd .Connection =Myconnection ;
            cmd .CommandType =CommandType .Text ;
            cmd .CommandText ="insert into RegisterManager (FisrName,LastName,Jensuat,NameOfFather,shomareshenasname,DateOfBurn,ManagerOriginalPath,ImageData,Tarikheshoroemodiriat,Tarikheetmamemodiriat,HomeTell,MobileNumber,HomeAddress,tozihat,CodeMelli)  values (@FisrName,@LastName,@Jensuat,@NameOfFather,@shomareshenasname,@DateOfBurn,@ManagerOriginalPath,@ImageData,@Tarikheshoroemodiriat,@Tarikheetmamemodiriat,@HomeTell,@MobileNumber,@HomeAddress,@tozihat,@CodeMelli)";
            cmd .Parameters .AddWithValue ("@FisrName",txtFname .Text );
            cmd .Parameters .AddWithValue ("@LastName",txtLname .Text  );
                cmd .Parameters .AddWithValue ("@Jensuat",comboBox1 .SelectedItem  );
                cmd .Parameters .AddWithValue ("@NameOfFather",txtNameOfFather .Text  );
                cmd .Parameters .AddWithValue ("@shomareshenasname",txtShomareShenasname .Text  );
                cmd .Parameters .AddWithValue ("@DateOfBurn",txtDateOfBurn_Masked .Text  );
                cmd.Parameters.Add(new SqlParameter("@ManagerOriginalPath", (object)txtImagePath.Text));
                cmd.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));
                cmd .Parameters .AddWithValue ("@Tarikheshoroemodiriat",txtBeginManager_Masked .Text  );
                cmd .Parameters .AddWithValue ("@Tarikheetmamemodiriat",txtendManager_Masked .Text  );
                cmd .Parameters .AddWithValue ("@HomeTell",txtHomeTell_Masked .Text  );
                cmd .Parameters .AddWithValue ("@MobileNumber",txtMObileNumber_Masked .Text  );
                cmd .Parameters .AddWithValue ("@HomeAddress",txtHomeAddress .Text  );
                cmd .Parameters .AddWithValue ("@tozihat",txtTozihat .Text  );
                cmd .Parameters .AddWithValue ("@CodeMelli",txtCodeMelli .Text  );
                
                Myconnection .Open ();
                cmd .ExecuteNonQuery ();
                Myconnection.Close();
            }
            catch (SqlException ee)
            {
                MessageBox .Show (ee .Message );
            }
        }

        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            comboBox1 .Items .Add ("مرد");
            comboBox1 .Items .Add ("زن");
            comboBox1 .SelectedIndex =0;
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

        private void button5_Click(object sender, EventArgs e)
        {
            txtBeginManager_Masked.Text = string.Empty;
            txtCodeMelli.Text = string.Empty;
            txtDateOfBurn_Masked.Text = string.Empty;
            txtendManager_Masked.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtHomeAddress.Text = string.Empty;
            txtHomeTell_Masked.Text = string.Empty;
            txtImagePath.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtMObileNumber_Masked.Text = string.Empty;
            txtNameOfFather.Text = string.Empty;
            txtShomareShenasname.Text = string.Empty;
            txtTozihat.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((txtBeginManager_Masked.Text.Length > 0) && (txtCodeMelli.Text.Length > 0) && (txtDateOfBurn_Masked.Text.Length > 0) && (txtendManager_Masked.Text.Length > 0) && (txtFname.Text.Length > 0) && (txtHomeAddress.Text.Length > 0) && (txtHomeTell_Masked.Text.Length > 0) && (txtImagePath.Text.Length > 0) && (txtLname.Text.Length > 0) && (txtMObileNumber_Masked.Text.Length > 0) && (txtNameOfFather.Text.Length > 0) && (txtShomareShenasname.Text.Length > 0) && (txtTozihat.Text.Length > 0))
            {
                ConnectToDatabase();
                MessageBox.Show("مدیر مربوطه ثبت شد  /n برای دسترسی های لازم به مدیر مربوطه از کنترل پنل مدیریت اقدام فذمایید", "تراکنش", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("جاهای خالی را پر کنید");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            txtImagePath.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditRegisteredAdmin edit = new EditRegisteredAdmin();
            edit.ShowDialog(this);
        }
        }
      
    }

       
