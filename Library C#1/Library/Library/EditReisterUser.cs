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
    public partial class EditReisterUser : Form
    {
        public string IDNumber = "";
        SqlConnection conn = new SqlConnection("server=(local);database=Library;Trusted_connection=yes");
        SqlDataAdapter da;
        DataSet ds;

        private void UpdateDatabase()
        {
            using (SqlConnection connection = new SqlConnection("server=(local);database=Library;Trusted_connection=yes"))
            {
                string Selectedjensiat;
                string SelectedMojaradyamotahal;
                string SelectedShoghl="";
                string SelectedTahsialt="";
                ////
                if (cboJensiatRegisterUser.SelectedIndex == 0)
                {
                    Selectedjensiat = "مرد";
                }
                else
                {
                    Selectedjensiat = "زن";
                }
                ///
                if (CboMojaradYaMotahalRegisterUser.SelectedIndex == 0)
                {
                    SelectedMojaradyamotahal = "متاهل";
                }
                else
                {
                    SelectedMojaradyamotahal = "مجرد";
                }
                switch (cboShoghlRegisterUser.SelectedIndex)
                {
                    case 0:
                        SelectedShoghl = "بیکار";
                        break;
                    case 1:
                        SelectedShoghl = "آزاد";
                        break;
                    case 2:
                        SelectedShoghl = "محصل";
                        break;
                    case 3:
                        SelectedShoghl = "کارمند";
                        break ;
                }
                switch (cboTahsilatRegisterUser.SelectedIndex)
                {
                    case 0:
                        SelectedTahsialt = "دیپلم";
                        break;
                    case 1:
                        SelectedTahsialt = "فوق دیپلم";
                        break;
                    case 2:
                        SelectedTahsialt = "لیسانس";
                        break;
                    case 3:
                        SelectedTahsialt = "فوق لیسانس";
                        break;
                    case 4:
                        SelectedTahsialt = "دکتر";
                        break;
                    case 5:
                        SelectedTahsialt = "دانش آموز";
                        break;
                    case 6:
                        SelectedTahsialt = "و...";
                        break;
                }

                byte[] imageData = ReadFile(txtImagePath.Text);
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.Connection = connection;
                com.CommandText = "update RegisterUser set FirstName=N'" + txtFNameRegisterUser.Text + "' , LastName=N'" + txtFamilyRegisterUser.Text + "' , NameOfFather=N'" + txtNameOfFatherRegisterUser.Text + "' , Jensiat=N'" + Selectedjensiat + "' , DateOfBurn=N'" + txtDateOfBurnRegisterUser_Masked.Text + "' , shomareshenasname=N'" + txtShomareShenasnameRegisterUser.Text + "' , MojaradYamotahal=N'" + SelectedMojaradyamotahal + "' , TellNumber=N'" + txtTellNumber_Masked.Text + "', MObileNumber=N'" + txtMobileNumber_Masked.Text + "' , shoghl=N'" + SelectedShoghl + "' , tahsilat=N'" + SelectedTahsialt + "' , tarikheozviat=N'" + txtTarikheOzviatregisterUser_Masked.Text + "' , tozihat=N'" + txtTozihatRegisterUser.Text + "' , address=N'" + txtAddressRegisterUser.Text + "' , ImageOriginalPath=@ImageOriginalPath , ImageData=@ImageData where ID='" + IDNumber + "'";

                com.Parameters.Add(new SqlParameter("@ImageOriginalPath", (object)txtImagePath.Text));
                com.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

                connection.Open();
                com.ExecuteNonQuery();
                connection.Close();
            }
        }

        public EditReisterUser()
        {
            InitializeComponent();
        }

        private void EditReisterUser_Load(object sender, EventArgs e)
        {

            ds = new DataSet();
            da = new SqlDataAdapter("select * From RegisterUser", conn);
            da.Fill(ds, "RegisterUser");
            new DataView(ds.Tables["RegisterUser"]);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "RegisterUser";

            DataGridViewCellStyle dv = new DataGridViewCellStyle();
            dv.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.Columns["ID"].HeaderCell.Value = "ردیف";
            dataGridView1.Columns["ID"].Width = 40;
            dataGridView1.Columns["FirstName"].HeaderCell.Value = "نام  کوچک";
            dataGridView1.Columns["LastName"].HeaderCell.Value = "نام بزرگ";
            dataGridView1.Columns["NameOfFather"].HeaderCell.Value = "نام پدر";
            dataGridView1.Columns["Jensiat"].HeaderCell.Value = "جنسیت";
            dataGridView1.Columns["DateOfBurn"].HeaderCell.Value = "تاریخ تولد";
            dataGridView1.Columns["shomareshenasname"].HeaderCell.Value = "شناسنامه";
            dataGridView1.Columns["MojaradYamotahal"].HeaderCell.Value = "مجرد/متاهل";
            dataGridView1.Columns["TellNumber"].HeaderCell.Value = "شماره تلفن";
            dataGridView1.Columns["MObileNumber"].HeaderCell.Value = "شماره تلفن";
            dataGridView1.Columns["shoghl"].HeaderCell.Value = "شغل";
            dataGridView1.Columns["tahsilat"].HeaderCell.Value = "تحصیلات";
            dataGridView1.Columns["address"].HeaderCell.Value = "آدرس";
            dataGridView1.Columns["tarikheozviat"].HeaderCell.Value = "تاریخ عضویت";
            dataGridView1.Columns["tozihat"].HeaderCell.Value = "توضیحات";
            dataGridView1.Columns["ImageOriginalPath"].HeaderCell.Value = "آدرس عکس";
            dataGridView1.Columns["ImageData"].HeaderCell.Value = "عکس";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDNumber = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtAddressRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
                txtDateOfBurnRegisterUser_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["DateOfBurn"].Value.ToString();
                txtFamilyRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                txtMobileNumber_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["MObileNumber"].Value.ToString();
                txtNameOfFatherRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["NameOfFather"].Value.ToString();
                txtFNameRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                txtShomareShenasnameRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["shomareshenasname"].Value.ToString();
                txtTarikheOzviatregisterUser_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["tarikheozviat"].Value.ToString();
                txtTellNumber_Masked.Text = dataGridView1.Rows[e.RowIndex].Cells["TellNumber"].Value.ToString();
                txtTozihatRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["tozihat"].Value.ToString();
                cboJensiatRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["Jensiat"].Value.ToString();
                CboMojaradYaMotahalRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["MojaradYamotahal"].Value.ToString();
                cboShoghlRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["shoghl"].Value.ToString();
                cboTahsilatRegisterUser.Text = dataGridView1.Rows[e.RowIndex].Cells["tahsilat"].Value.ToString();

            }
            catch (System.Exception)
            {
                MessageBox.Show("برای انتخاب روی سطرها کلیک کنید");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                UpdateDatabase();
                MessageBox.Show("اطلاعات با موفقیت بروز رسانی شد", "تراکنش موفق", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              
                txtAddressRegisterUser.Text = string.Empty;
                txtFamilyRegisterUser.Text = string.Empty;
                txtNameOfFatherRegisterUser.Text = string.Empty;
                txtFNameRegisterUser.Text = string.Empty;
                txtShomareShenasnameRegisterUser.Text = string.Empty;
                txtTozihatRegisterUser.Text = string.Empty;
                txtDateOfBurnRegisterUser_Masked.Text = string.Empty;
                txtMobileNumber_Masked.Text = string.Empty;
                txtTarikheOzviatregisterUser_Masked.Text = string.Empty;
                txtTellNumber_Masked.Text = string.Empty;
                cboJensiatRegisterUser.SelectedIndex = -1;
                CboMojaradYaMotahalRegisterUser.SelectedIndex = -1;
                CboMojaradYaMotahalRegisterUser.SelectedIndex = -1;
                cboShoghlRegisterUser.SelectedIndex = -1;
                cboTahsilatRegisterUser.SelectedIndex = -1;
                EditReisterUser_Load( sender, e);
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("مشکل در ثبت تغییرات" + "\n" + ee.Message);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Get image data from gridview column.
                byte[] imageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells["ImageData"].Value;
                txtImagePath.Text = dataGridView1.Rows[e.RowIndex].Cells["ImageOriginalPath"].Value.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            RegisteredUserSearchFrom search = new RegisteredUserSearchFrom();
            search.ShowDialog(this);
        }
    }
}