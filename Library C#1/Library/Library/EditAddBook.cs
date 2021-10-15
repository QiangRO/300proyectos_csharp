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
    public partial class EditAddBook : Form
    {
        
        SqlDataAdapter da;
        DataSet ds;
        public string IDNumber = "";

        private void UpdateDatabase()
        {
            using (SqlConnection conn = new SqlConnection("server=(local);database=Library;trusted_connection=yes"))
            {
                byte[] imageData = ReadFile(txtImagePath.Text);
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.Connection = conn;
                com.CommandText = "update BookDetails set BookName=N'" + txtNameBookAddBook.Text + "' , author=N'" + txtauthorAddBook.Text + "' , translator=N'" + txtMotarjemAddBook.Text + "' , NobatChap=N'" + txtNobateChapAddBook.Text + "' , Entesharat=N'" + txtEntesharatAddBook.Text + "' , Subject=N'" + txtSubjectAddBook.Text + "' , Tozihat=N'" + txtDescripeAddBook.Text + "' , KholaseKetab=N'" + txtAbstractAddBook.Text + "', MahaleKetabDarKetabKhane=N'" + txtMahaleketab.Text + "' , tedad=N'" + txtTedadAddBook.Text + "' , Isbn=N'" + txtISBNAddBook.Text + "' , tarikhenashr=N'" + txtTarikheNashrAddBook_masked.Text + "' , AksRoyeJeldOriginalPath=@AksRoyeJeldOriginalPath , ImageData=@ImageData where IDBook='" + IDNumber + "'";

                com.Parameters.Add(new SqlParameter("@AksRoyeJeldOriginalPath", (object)txtImagePath.Text));
                com.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));

                conn.Open();
                com.ExecuteNonQuery();
                conn.Close();
            }
        }

        public EditAddBook()
        {
            InitializeComponent();
        }

        private void EditAddBook_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=(local);database=Library;trusted_connection=yes");
            ds = new DataSet();
            da = new SqlDataAdapter("select * from BookDetails", conn);
            da.Fill(ds, "BookDetails");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "BookDetails";
            dataGridView1.Columns["IDBook"].Width = 30;
            dataGridView1.Columns["IDBook"].HeaderText = "#";
            dataGridView1.Columns["BookName"].HeaderText = "نام کتاب";
            dataGridView1.Columns["author"].HeaderText = "نویسنده";
            dataGridView1.Columns["translator"].HeaderText = "مترجم";
            dataGridView1.Columns["NobatChap"].HeaderText = "نوبت چاپ";
            dataGridView1.Columns["NobatChap"].Width = 80;
            dataGridView1.Columns["Entesharat"].HeaderText = "انتشارات";
            dataGridView1.Columns["Subject"].HeaderText = "موضوع";
            dataGridView1.Columns["Tozihat"].HeaderText = "توضیحات";
            dataGridView1.Columns["KholaseKetab"].HeaderText = "خلاصه";
            dataGridView1.Columns["AksRoyeJeldOriginalPath"].HeaderText = "آدرس عکس";
            dataGridView1.Columns["ImageData"].HeaderText = "عکس";
            dataGridView1.Columns["MahaleKetabDarKetabKhane"].HeaderText = "محل کتاب";
            dataGridView1.Columns["tedad"].HeaderText = "تعداد";
            dataGridView1.Columns["tedad"].Width = 40;
            dataGridView1.Columns["tarikhenashr"].HeaderText = "تاریخ نشر";
            dataGridView1.Columns["Status"].HeaderText = "وضعیت";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDNumber = dataGridView1.Rows[e.RowIndex].Cells["IDBook"].Value.ToString();
                txtNameBookAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["BookName"].Value.ToString();
                txtauthorAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["author"].Value.ToString();
                txtMotarjemAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["translator"].Value.ToString();
                txtNobateChapAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["NobatChap"].Value.ToString();
                txtEntesharatAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["Entesharat"].Value.ToString();
                txtSubjectAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["Subject"].Value.ToString();
                txtDescripeAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["Tozihat"].Value.ToString();
                txtAbstractAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["KholaseKetab"].Value.ToString();
                txtMahaleketab.Text = dataGridView1.Rows[e.RowIndex].Cells["MahaleKetabDarKetabKhane"].Value.ToString();
                txtTedadAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["tedad"].Value.ToString();
                txtISBNAddBook.Text = dataGridView1.Rows[e.RowIndex].Cells["Isbn"].Value.ToString();
                txtTarikheNashrAddBook_masked.Text = dataGridView1.Rows[e.RowIndex].Cells["tarikhenashr"].Value.ToString();


            }
            catch (System.Exception)
            {
                MessageBox.Show("برای انتخاب روی سطرها کلیک کنید");
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
             try 
                {
                UpdateDatabase();
               MessageBox.Show("اطلاعات با موفقیت بروز رسانی شد", "تراکنش موفق", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               IDNumber = string.Empty;
               txtNameBookAddBook.Text = string.Empty;
               txtauthorAddBook.Text = string.Empty;
               txtMotarjemAddBook.Text = string.Empty;
               txtNobateChapAddBook.Text = string.Empty;
               txtEntesharatAddBook.Text = string.Empty;
               txtSubjectAddBook.Text = string.Empty;
               txtDescripeAddBook.Text = string.Empty;
               txtAbstractAddBook.Text = string.Empty;
               txtMahaleketab.Text = string.Empty;
               txtTedadAddBook.Text = string.Empty;
               txtISBNAddBook.Text = string.Empty;
               txtTarikheNashrAddBook_masked.Text = string.Empty;
               EditAddBook_Load(sender, e);
             }
            catch (Exception ee)
             {
                     MessageBox.Show("مشکل در ثبت تغییرات"+"\n"+ee .Message );
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                //Get image data from gridview column.
                byte[] imageData = (byte[])dataGridView1.Rows[e.RowIndex].Cells["ImageData"].Value;
                txtImagePath.Text = dataGridView1.Rows[e.RowIndex].Cells["AksRoyeJeldOriginalPath"].Value.ToString();
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
                MessageBox.Show("عکسی انتخاب نشده است"+"\n"+ex .Message );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchBook search = new SearchBook();
            search.ShowDialog(this);
        }

        }
        
    }

