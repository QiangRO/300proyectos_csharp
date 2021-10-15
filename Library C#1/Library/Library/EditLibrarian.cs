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
    public partial class EditLibrarian : Form
    {
        
        SqlDataAdapter da;
        DataSet ds;
        public string IDNumber = "";

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection("server=(local);Database=Library;trusted_connection=yes"))
            {
                string selectionJensiat;
                if (combJensiat.SelectedIndex == 0)
                {
                    selectionJensiat = "مرد";
                }
                else
                {
                    selectionJensiat = "زن";
                }

                byte[] imageData = ReadFile(txtImagePath.Text);

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "update librarian set FirstName=N'" + txtFname.Text + "' , LastName=N'" + txtLname.Text + "' , Jensiat=N'" + selectionJensiat + "' , NameOfFather=N'" + txtNameOfFather.Text + "' , shomareshenasname=N'" + txtShomareShenasname.Text + "' , DateOfBurn=N'" + txtDateOfBurn_Masked.Text + "' , tarikheshorobekar=N'" + txtBeginManager_Masked.Text + "' , tarikheetmamekar=N'" + txtendManager_Masked.Text + "', HomeTell=N'" + txtHomeTell_Masked.Text + "' , MobileNumber=N'" + txtMObileNumber_Masked.Text + "' , HomeAddress=N'" + txtHomeAddress.Text + "' , Tozihat=N'" + txtTozihat.Text + "' ,CoedMelli=N'" + txtCodeMelli.Text + "', librarianOriginalPath=@librarianOriginalPath , ImageData=@ImageData where ID='" + IDNumber + "'";
                comm.Parameters.Add(new SqlParameter("@librarianOriginalPath", (object)txtImagePath.Text));
                comm.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();

            }
        }
        public EditLibrarian()
        {
            InitializeComponent();
        }

        private void EditLibrarian_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=(local);database=Library;trusted_connection=yes");
            da = new SqlDataAdapter("select * from librarian", conn);
            ds = new DataSet();
            da.Fill(ds, "librarian");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "librarian";
            dataGridView1.Columns["ID"].HeaderText = "#";
            dataGridView1.Columns["ID"].Width = 40;
            dataGridView1.Columns["FirstName"].HeaderText = "نام کوچک";
            dataGridView1.Columns["LastName"].HeaderText = "فامیلی";
            dataGridView1.Columns["Jensiat"].HeaderText = "جنسیت";
            dataGridView1.Columns["NameOfFather"].HeaderText = "نام پدر";
            dataGridView1.Columns["shomareshenasname"].HeaderText = "شناسنامه";
            dataGridView1.Columns["DateOfBurn"].HeaderText = "تاریخ تولد";
            dataGridView1.Columns["librarianOriginalPath"].HeaderText = "آدرس";
            dataGridView1.Columns["ImageData"].HeaderText = "عکس";
            dataGridView1.Columns["tarikheshorobekar"].HeaderText = "شروع";
            dataGridView1.Columns["tarikheetmamekar"].HeaderText = "اتمام";
            dataGridView1.Columns["HomeTell"].HeaderText = "تلفن";
            dataGridView1.Columns["MobileNumber"].HeaderText = "موبایل";
            dataGridView1.Columns["HomeAddress"].HeaderText = "آدرس";
            dataGridView1.Columns["Tozihat"].HeaderText = "توضیحات";
            dataGridView1.Columns["CoedMelli"].HeaderText = "کد ملی";
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {

            IDNumber = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtFname.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            txtLname.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            combJensiat.Text   = dataGridView1.Rows[e.RowIndex].Cells["Jensiat"].Value.ToString();
            txtNameOfFather.Text = dataGridView1.Rows[e.RowIndex].Cells["NameOfFather"].Value.ToString();
            txtShomareShenasname.Text = dataGridView1.Rows[e.RowIndex].Cells["shomareshenasname"].Value.ToString();
            txtDateOfBurn_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["DateOfBurn"].Value.ToString();
            txtBeginManager_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["tarikheshorobekar"].Value.ToString();
            txtendManager_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["tarikheetmamekar"].Value.ToString();
            txtHomeTell_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["HomeTell"].Value.ToString();
            txtMObileNumber_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["MobileNumber"].Value.ToString();
            txtHomeAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["HomeAddress"].Value.ToString();
            txtTozihat.Text = dataGridView1.Rows[e.RowIndex].Cells["Tozihat"].Value.ToString();
            txtCodeMelli.Text = dataGridView1.Rows[e.RowIndex].Cells["CoedMelli"].Value.ToString();

        }
            catch (Exception )
            {
                MessageBox.Show("برای انتخاب روی سطرها کلیک کنید");
            }
    }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Get image data from gridview column.
                byte[] imageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells["ImageData"].Value;
                txtImagePath.Text = dataGridView1.Rows[e.RowIndex].Cells["librarianOriginalPath"].Value.ToString();
                //Initialize image variable
                Image newImage;
                //Read image data into a memory stream
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);

                    //Set image variable value using memory stream.
                    newImage = Image.FromStream(ms, true);
                }

                //set picture
                pictureBox1.Image = newImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("عکسی انتخاب نشده است" + "\n" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateData();
                MessageBox.Show("اطلاعات با موفقیت بروز رسانی شد", "تراکنش موفق", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                combJensiat.SelectedIndex = -1;
                EditLibrarian_Load(sender, e);
                
            }

            catch (Exception ee)
            {
                MessageBox.Show("مشکل در ثبت تغییرات" + "\n" + ee.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}

