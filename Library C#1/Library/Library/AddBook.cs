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
    public partial class AddBook : Form
    {
        SqlConnection objConnection = new SqlConnection("server=(local);database=Library;trusted_connection=yes");
        

        private void ConnectTodatabaseAddBook()
        {
            try
            {
                //Read Image Bytes into a byte array
                byte[] imageData = ReadFile(txtImagePath.Text);

                SqlCommand objCommand = new SqlCommand();
                objCommand.Connection = objConnection;
                objCommand.CommandType = CommandType.Text;
                objCommand.CommandText = "insert into BookDetails(BookName,author,translator,NobatChap,Entesharat,Subject,Tozihat,KholaseKetab,AksRoyeJeldOriginalPath,ImageData,MahaleKetabDarKetabKhane,tedad,Isbn,tarikhenashr) values (@BookName,@author,@translator,@NobatChap,@Entesharat,@Subject,@Tozihat,@KholaseKetab,@AksRoyeJeldOriginalPath,@ImageData,@MahaleKetabDarKetabKhane,@tedad,@Isbn,@tarikhenashr)";
                objCommand .Parameters .AddWithValue ("@BookName",txtNameBookAddBook.Text );
                objCommand .Parameters .AddWithValue ("@author",txtauthorAddBook .Text );
                objCommand .Parameters .AddWithValue ("@translator",txtMotarjemAddBook .Text );
                objCommand .Parameters .AddWithValue ("@NobatChap",txtNobateChapAddBook .Text );
                objCommand .Parameters .AddWithValue ("@Entesharat",txtEntesharatAddBook .Text );
                objCommand .Parameters .AddWithValue ("@Subject",txtSubjectAddBook .Text );
                objCommand .Parameters .AddWithValue ("@Tozihat",txtDescripeAddBook .Text );
                objCommand .Parameters .AddWithValue ("@KholaseKetab",txtAbstractAddBook .Text );
                objCommand.Parameters.Add(new SqlParameter("@AksRoyeJeldOriginalPath", (object)txtImagePath.Text));
                objCommand.Parameters.Add(new SqlParameter("@ImageData", (object)imageData));
                objCommand .Parameters .AddWithValue ("@MahaleKetabDarKetabKhane",txtMahaleketab .Text );
                objCommand .Parameters .AddWithValue ("@tedad",txtTedadAddBook .Text );
                objCommand .Parameters .AddWithValue ("@Isbn",txtISBNAddBook .Text );
                objCommand .Parameters .AddWithValue ("@tarikhenashr",txtTarikheNashrAddBook_masked .Text ); 
                objConnection.Open();
                objCommand.ExecuteNonQuery();
                objConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public AddBook()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((txtNameBookAddBook.Text.Trim ().Length > 0) && (txtauthorAddBook.Text.Trim ().Length > 0) && (txtMotarjemAddBook.Text.Trim ().Length > 0) && (txtNobateChapAddBook.Text.Trim ().Length >0) && (txtEntesharatAddBook.Text.Trim ().Length >0) && (txtSubjectAddBook.Text.Trim ().Length >0) &&(txtDescripeAddBook.Text .Trim ().Length >0) && (txtAbstractAddBook.Text.Trim ().Length >0) && (txtMahaleketab.Text.Trim ().Length >0) && (txtTedadAddBook.Text.Trim ().Length >0) &&(txtISBNAddBook.Text.Trim ().Length >0) &&(txtTarikheNashrAddBook_masked.Text.Trim ().Length >0))
            {
                ConnectTodatabaseAddBook ();
                MessageBox .Show ("کتاب فوق با موفقیت در دیتابی ذخیره و ثبت شد");
            
            }
            else
            {
                MessageBox .Show ("لطفا جاهای خالی را پر کنید ");
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
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

        private void button6_Click(object sender, EventArgs e)
        {
            EditAddBook edit = new EditAddBook();
            edit.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SearchBook search = new SearchBook();
            search.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BookAzDorKharej book = new BookAzDorKharej();
            book.ShowDialog(this);

        }
      
    }
}
        