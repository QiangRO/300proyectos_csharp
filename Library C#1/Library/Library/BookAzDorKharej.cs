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
    public partial class BookAzDorKharej : Form
    {
        SqlConnection conn = new SqlConnection("server=(local);database=Library;trusted_connection=yes");
        string IDNumber = "";
        SqlDataAdapter da;
        DataSet ds;
        string str = "azdorkharej";

        private void BookDoorExit()
        {
            SqlCommand comm = new SqlCommand();
            comm.CommandType = CommandType.Text;
            comm.Connection = conn;
            comm.CommandText = "update BookDetails set Status='" + str + "' where IDBook='" + IDNumber + "'";

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

        }

        public BookAzDorKharej()
        {
            InitializeComponent();
        }

        private void BookAzDorKharej_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select IDBook,BookName,author,translator,NobatChap,Entesharat,Subject,KholaseKetab,MahaleKetabDarKetabKhane,tedad,Isbn,tarikhenashr from BookDetails", conn);
            da.Fill(ds, "BookDetails");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "BookDetails";
            dataGridView1.Columns["IDBook"].Width = 65;
            dataGridView1.Columns["IDBook"].HeaderText = "آیدی";
            dataGridView1.Columns["BookName"].HeaderText = "نام کتاب";
            dataGridView1.Columns["author"].HeaderText = "نویسنده";
            dataGridView1.Columns["translator"].HeaderText = "مترجم";
            dataGridView1.Columns["NobatChap"].HeaderText = "نوبت چاپ";
            dataGridView1.Columns["Entesharat"].HeaderText = "انتشارات";
            dataGridView1.Columns["Subject"].HeaderText = "موضوع";
            dataGridView1.Columns["KholaseKetab"].HeaderText = "خلاصه";
            dataGridView1.Columns["MahaleKetabDarKetabKhane"].HeaderText = "محل کتاب";
            dataGridView1.Columns["tedad"].HeaderText = "تعداد";
            dataGridView1.Columns["tarikhenashr"].HeaderText = "تاریخ نشر";
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDNumber = dataGridView1.Rows[e.RowIndex].Cells["IDBook"].Value.ToString();
            txtNameBook.Text = dataGridView1.Rows[e.RowIndex].Cells["BookName"].Value.ToString();
            txtauthor.Text = dataGridView1.Rows[e.RowIndex].Cells["author"].Value.ToString();
            txtMotarjem.Text = dataGridView1.Rows[e.RowIndex].Cells["translator"].Value.ToString();
            txtNobateChap.Text = dataGridView1.Rows[e.RowIndex].Cells["NobatChap"].Value.ToString();
            txtEntesharat.Text = dataGridView1.Rows[e.RowIndex].Cells["Entesharat"].Value.ToString();
            txtSubject.Text = dataGridView1.Rows[e.RowIndex].Cells["Subject"].Value.ToString();
            txtAbstract.Text = dataGridView1.Rows[e.RowIndex].Cells["KholaseKetab"].Value.ToString();
            txtMahaleketab.Text = dataGridView1.Rows[e.RowIndex].Cells["MahaleKetabDarKetabKhane"].Value.ToString();
            txtTedad.Text = dataGridView1.Rows[e.RowIndex].Cells["tedad"].Value.ToString();
            txtISBN.Text = dataGridView1.Rows[e.RowIndex].Cells["Isbn"].Value.ToString();
            txtTarikheNashr_masked.Text = dataGridView1.Rows[e.RowIndex].Cells["tarikhenashr"].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchBook search = new SearchBook();
            search.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBook addbokk = new AddBook();
            addbokk.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtNameBook.Text.Trim().Length > 0) && (txtISBN.Text.Trim().Length > 0))
                {
                    BookDoorExit();
                    MessageBox.Show("کتاب مورد نظر از دور خارج شد");
                    IDNumber = string.Empty;
                    txtNameBook.Text = string.Empty;
                    txtauthor.Text = string.Empty;
                    txtMotarjem.Text = string.Empty;
                    txtNobateChap.Text = string.Empty;
                    txtEntesharat.Text = string.Empty;
                    txtSubject.Text = string.Empty;
                    txtAbstract.Text = string.Empty;
                    txtMahaleketab.Text = string.Empty;
                    txtTedad.Text = string.Empty;
                    txtISBN.Text = string.Empty;
                    txtTarikheNashr_masked.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("کتاب را انتخاب نکرده اید");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("مشکل در ثبت کتاب از دور خارج");
            }
        }
    }
}
    

