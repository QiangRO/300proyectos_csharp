using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Drawing.Imaging;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace project_2
{
    public partial class Form1 : Form
    {
        SqlConnection objconn = new SqlConnection("Data Source=.;Initial Catalog=project2;Integrated Security=True");
        SqlDataAdapter dataadapter = new SqlDataAdapter();
        DataSet objset = new DataSet();
        SqlDataAdapter objadapadap = new SqlDataAdapter();
        DataTable objtabe12=new DataTable();
        DataSet ds = new DataSet();
        public string dates;
        public string filename;
        public string filename1;
        
        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PersianCalendar objt = new PersianCalendar();
            label6.Text = (objt.GetYear(DateTime.Today) + "/" + objt.GetMonth(DateTime.Today) + "/" + objt.GetDayOfMonth(DateTime.Today)).ToString();
            label16.Text = (objt.GetYear(DateTime.Today) + "/" + objt.GetMonth(DateTime.Today) + "/" + objt.GetDayOfMonth(DateTime.Today)).ToString();
            label14.Text = (objt.GetYear(DateTime.Today) + "/" + objt.GetMonth(DateTime.Today) + "/" + objt.GetDayOfMonth(DateTime.Today)).ToString();
            label19.Text = (objt.GetYear(DateTime.Today) + "/" + objt.GetMonth(DateTime.Today) + "/" + objt.GetDayOfMonth(DateTime.Today)).ToString();
            label24.Text = (objt.GetYear(DateTime.Today) + "/" + objt.GetMonth(DateTime.Today) + "/" + objt.GetDayOfMonth(DateTime.Today)).ToString();
           
            try
            {
                dataadapter.SelectCommand = new SqlCommand();
                dataadapter.SelectCommand.Connection = objconn;
                dataadapter.SelectCommand.CommandText = "select code,fname,lname,position,office,pic from employee";
                dataadapter.FillSchema(objset, SchemaType.Source, "employee1");
                dataadapter.Fill(objset, "employee1");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = objset;
                dataGridView1.DataMember = "employee1";
                dataGridView1.Columns[0].HeaderText = "کد";
                dataGridView1.Columns[1].HeaderText = "نام ";
                dataGridView1.Columns[2].HeaderText = "نام خانوادگی";
                dataGridView1.Columns[3].HeaderText = "سمت";
                dataGridView1.Columns[4].HeaderText = "اداره مربوط";
                dataGridView1.Columns[5].HeaderText = "عکس";
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = objset;
                dataGridView2.DataMember = "employee1";
                dataGridView2.Columns[0].HeaderText = "کد";
                dataGridView2.Columns[1].HeaderText = "نام ";
                dataGridView2.Columns[2].HeaderText = "نام خانوادگی";
                dataGridView2.Columns[3].HeaderText = "سمت";
                dataGridView2.Columns[4].HeaderText = "اداره مربوط";
                dataGridView2.Columns[5].HeaderText = "عکس";
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.MultiSelect = false;
                dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView3.AutoGenerateColumns = true;
                dataGridView3.DataSource = objset;
                dataGridView3.DataMember = "employee1";
                dataGridView3.Columns[0].HeaderText = "کد";
                dataGridView3.Columns[1].HeaderText = "نام ";
                dataGridView3.Columns[2].HeaderText = "نام خانوادگی";
                dataGridView3.Columns[3].HeaderText = "سمت";
                dataGridView3.Columns[4].HeaderText = "اداره مربوط";
                dataGridView3.Columns[5].HeaderText = "عکس";
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView3.MultiSelect = false;
                dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
                groupBox1.Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.MultiSelect = false;
                dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
                
            }
            catch (Exception ex)
            {
                label7.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                    MessageBox.Show("اطلاعات را کامل کنید");
                else
                {
                    dataadapter.InsertCommand = new SqlCommand();
                    dataadapter.InsertCommand.Connection = objconn;
                    dataadapter.InsertCommand.CommandText = "insert into employee(fname,lname,position,office,pic) values(@fname,@lname,@position,@office,@i)";
                    dataadapter.InsertCommand.Parameters.AddWithValue("@fname", textBox2.Text.Trim());
                    dataadapter.InsertCommand.Parameters.AddWithValue("@lname", textBox3.Text.Trim());
                    dataadapter.InsertCommand.Parameters.AddWithValue("@position", textBox4.Text.Trim());
                    dataadapter.InsertCommand.Parameters.AddWithValue("@office", textBox5.Text.Trim());
                    System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open);
                    byte[] imagecontent = new byte[fs.Length];
                    fs.Read(imagecontent, 0, (int)fs.Length);
                    SqlParameter ping = new SqlParameter("@i", imagecontent);
                    ping.SqlDbType = SqlDbType.Image;
                    dataadapter.InsertCommand.Parameters.Add(ping);
                    objconn.Open();
                    dataadapter.InsertCommand.ExecuteNonQuery();
                    objconn.Close();
                    Form1_Load(sender, e);
                    MessageBox.Show("اطلاعات با موفقیت وارد شد");
                }
            }
            catch(Exception t)
            {
                label7.Text = t.Message;
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            pictureBox1.Image = null;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Trim() == "" || textBox7.Text.Trim() == "" || textBox7.Text.Trim() == "" || textBox10.Text.Trim() == "")
                MessageBox.Show("اطلاعات را کامل کنید");
            else
            {
                try
                {
                    dataGridView2.SelectedCells[1].Value = textBox7.Text.Trim();
                    dataGridView2.SelectedCells[2].Value = textBox8.Text.Trim();
                    dataGridView2.SelectedCells[3].Value = textBox9.Text.Trim();
                    dataGridView2.SelectedCells[4].Value = textBox10.Text.Trim();
                    dataGridView2.SelectedCells[5].Value = pictureBox2.Image;
                    MessageBox.Show("تغییرات اعمال شد");
                }
                catch (Exception t)
                {
                    label15.Text = t.Message;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Trim() == "" || textBox8.Text.Trim() == "" || textBox9.Text.Trim() == "" || textBox10.Text.Trim() == "")
                MessageBox.Show("اطلاعات را کامل کنید");
            else
            {
                try
                {
                    label15.Text = "";
                    SqlDataAdapter objadapter = new SqlDataAdapter();
                    objadapter.UpdateCommand = new SqlCommand();
                    objadapter.UpdateCommand.Connection = objconn;
                    objadapter.UpdateCommand.CommandText = "update employee set  fname=@fname1 , lname=@lname1 "
                    + ", position=@position1 ,office=@office1 ,pic=@i where code=@code1";
                    objadapter.UpdateCommand.Parameters.AddWithValue("@code1", textBox6.Text.Trim());
                    objadapter.UpdateCommand.Parameters.AddWithValue("@fname1", textBox7.Text.Trim());
                    objadapter.UpdateCommand.Parameters.AddWithValue("@lname1", textBox8.Text.Trim());
                    objadapter.UpdateCommand.Parameters.AddWithValue("@position1", textBox9.Text.Trim());
                    objadapter.UpdateCommand.Parameters.AddWithValue("@office1", textBox10.Text.Trim());
                    System.IO.FileStream fs = new System.IO.FileStream(filename1, System.IO.FileMode.Open);
                    byte[] imagecontent = new byte[fs.Length];
                    fs.Read(imagecontent, 0, (int)fs.Length);
                    SqlParameter ping = new SqlParameter("@i", imagecontent);
                    ping.SqlDbType = SqlDbType.Image;
                    objadapter.UpdateCommand.Parameters.Add(ping);
                    objconn.Open();
                    objadapter.UpdateCommand.ExecuteNonQuery();
                    MessageBox.Show("تغییرات با موفقیت ثبت شد");
                }
                catch (Exception t)
                {
                    label15.Text = t.Message;
                }
                finally
                {
                    objconn.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable objtb = objset.Tables["employee1"];
                objtb.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                dataGridView3.DataSource = objset;
                dataGridView3.DataMember = "employee1";
                MessageBox.Show("اطلاعات موردنظر حذف شد ");
            }
            catch (Exception t)
            {
                label22.Text = t.Message;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter objdata = new SqlDataAdapter();
                objdata.DeleteCommand = new SqlCommand();
                objdata.DeleteCommand.Connection = objconn;
                objdata.DeleteCommand.CommandText = "delete from employee where code=@code1";
                objdata.DeleteCommand.Parameters.AddWithValue("@code1", textBox6.Text.Trim());
                objconn.Open();
                objdata.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("اطلاعات حذف شده با موفقیت ثبت شد");
            }
            catch (Exception t)
            {
                label22.Text = t.Message;
            }
            finally
            {
                objconn.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Reset();
            try
            {
                switch (checkedListBox1.SelectedIndex)
                {
                    case 0:
                        checkedListBox1.SetItemChecked(0, true);
                        DataTable objtabe0 = new DataTable();
                        SqlCommand objcammand0 = new SqlCommand("select code from employee", objconn);
                        SqlDataAdapter objadapter0 = new SqlDataAdapter(objcammand0);
                        objconn.Open();
                        objadapter0.Fill(objtabe0);
                        objconn.Close();
                        comboBox1.DataSource = objtabe0;
                        comboBox1.DisplayMember = "code";
                        comboBox1.ValueMember = "code";
                        break;
                    case 1:
                        checkedListBox1.SetItemChecked(1, true);
                        groupBox1.Visible = true;
                        MessageBox.Show("ابتدای نام خانوادگی مورد جستجو را انتخاب کنید");
                        break;
                    case 2:
                        checkedListBox1.SetItemChecked(2, true);
                        DataTable objtabe2 = new DataTable();
                        SqlCommand objcammand2 = new SqlCommand("select distinct office from employee ", objconn);
                        SqlDataAdapter objadapter2 = new SqlDataAdapter(objcammand2);
                        objconn.Open();
                        objadapter2.Fill(objtabe2);
                        objconn.Close();
                        comboBox1.DataSource = objtabe2;
                        comboBox1.DisplayMember = "office";
                        comboBox1.ValueMember = "office";
                        break;
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }
        void Reset()
        {
            checkedListBox1.SetItemChecked(0, false);
            checkedListBox1.SetItemChecked(1, false);
            checkedListBox1.SetItemChecked(2, false);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            try
            {
                switch (checkedListBox1.SelectedIndex)
                {
                    case 0:
                        DataTable tabe0 = new DataTable();
                        SqlDataAdapter adapter0 = new SqlDataAdapter();
                        adapter0.SelectCommand = new SqlCommand("select code,fname,lname,position,office,pic from employee where code=@code", objconn);
                        adapter0.SelectCommand.Parameters.AddWithValue("@code", comboBox1.Text);
                        objconn.Open();
                        adapter0.Fill(tabe0);
                        objconn.Close();
                        dataGridView4.AutoGenerateColumns = true;
                        dataGridView4.DataSource = tabe0;
                        dataGridView4.Columns[0].HeaderText = "کد";
                        dataGridView4.Columns[1].HeaderText = "نام ";
                        dataGridView4.Columns[2].HeaderText = "نام خانوادگی";
                        dataGridView4.Columns[3].HeaderText = "سمت";
                        dataGridView4.Columns[4].HeaderText = "اداره مربوط";
                        dataGridView4.Columns[5].HeaderText = "عکس";
                        break;
                    case 1:
                        DataTable tabel = new DataTable();
                        SqlCommand cammand1 = new SqlCommand("select code,fname,lname,position,office,pic from employee where lname=@lname", objconn);
                        SqlDataAdapter adapter1 = new SqlDataAdapter(cammand1);
                        adapter1.SelectCommand.Parameters.AddWithValue("@lname", comboBox1.Text);
                        objconn.Open();
                        adapter1.Fill(tabel);
                        objconn.Close();
                        dataGridView4.AutoGenerateColumns = true;
                        dataGridView4.DataSource = tabel;
                        dataGridView4.Columns[0].HeaderText = "کد";
                        dataGridView4.Columns[1].HeaderText = "نام ";
                        dataGridView4.Columns[2].HeaderText = "نام خانوادگی";
                        dataGridView4.Columns[3].HeaderText = "سمت";
                        dataGridView4.Columns[4].HeaderText = "اداره مربوط";
                        dataGridView4.Columns[5].HeaderText = "عکس";
                        break;
                    case 2:
                        DataTable tabe2 = new DataTable();
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        adapter2.SelectCommand = new SqlCommand("select code,fname,lname,position,office,pic from employee where office=@office1", objconn);
                        adapter2.SelectCommand.Parameters.AddWithValue("@office1", comboBox1.Text);
                        objconn.Open();
                        adapter2.Fill(tabe2);
                        objconn.Close();
                        dataGridView4.AutoGenerateColumns = true;
                        dataGridView4.DataSource = tabe2;
                        dataGridView4.Columns[0].HeaderText = "کد";
                        dataGridView4.Columns[1].HeaderText = "نام ";
                        dataGridView4.Columns[2].HeaderText = "نام خانوادگی";
                        dataGridView4.Columns[3].HeaderText = "سمت";
                        dataGridView4.Columns[4].HeaderText = "اداره مربوط";
                        dataGridView4.Columns[5].HeaderText = "عکس";
                        break;
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }  
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected) > 0)
                {
                    textBox6.Text = dataGridView2.SelectedCells[0].Value.ToString();
                    textBox7.Text = dataGridView2.SelectedCells[1].Value.ToString();
                    textBox8.Text = dataGridView2.SelectedCells[2].Value.ToString();
                    textBox9.Text = dataGridView2.SelectedCells[3].Value.ToString();
                    textBox10.Text = dataGridView2.SelectedCells[4].Value.ToString();
                    MemoryStream ms = new MemoryStream((byte[])(dataGridView2.SelectedCells[5].Value));
                    pictureBox2.Image = Image.FromStream(ms);
                }
            }
            catch (Exception t)
            {
                label15.Text = t.Message;
            }
        }
        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            try
              {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ا%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel2_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ب%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count != 0)
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
                else
                {
                    MessageBox.Show("موردی یافت نشد");

                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel3_MouseClick(object sender, MouseEventArgs e)
        {
               try
               {
                   objtabe12.Rows.Clear();
                   comboBox1.Text = "";
                   objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'پ%'", objconn);
                   objadapadap.Fill(objtabe12);
                   objconn.Close();
                   if (objtabe12.Rows.Count == 0)
                       MessageBox.Show("موردی یافت نشد");
                   else
                   {
                       int i = objtabe12.Rows.Count;
                       MessageBox.Show(i + "مورد یافت شد  ");
                       comboBox1.DataSource = objtabe12;
                       comboBox1.DisplayMember = "lname";
                       comboBox1.ValueMember = "lname";
                   }
               }
               catch (Exception t)
               {
                   label21.Text = t.Message;
               }
        }

        private void linkLabel4_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ت%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }

        }

        private void linkLabel5_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ث%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel6_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ج%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel7_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'چ%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel8_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ح%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel9_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'خ%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel10_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'د%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel11_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ذ%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel12_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ر%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel13_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ز%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel14_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ژ%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel15_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'س%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel16_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ش%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel17_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ص%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel18_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ض%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel19_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ط%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel20_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ظ%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel21_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ع%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel22_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'غ%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel23_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ف%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel24_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ق%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel25_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ک%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel26_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'گ%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel27_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ل%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel28_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'م%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel29_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ن%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel32_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'و%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel30_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ه%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void linkLabel31_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                objtabe12.Rows.Clear();
                comboBox1.Text = "";
                objadapadap.SelectCommand = new SqlCommand("select lname from employee where lname like 'ي%'", objconn);
                objadapadap.Fill(objtabe12);
                objconn.Close();
                if (objtabe12.Rows.Count == 0)
                    MessageBox.Show("موردی یافت نشد");
                else
                {
                    int i = objtabe12.Rows.Count;
                    MessageBox.Show(i + "مورد یافت شد  ");
                    comboBox1.DataSource = objtabe12;
                    comboBox1.DisplayMember = "lname";
                    comboBox1.ValueMember = "lname";
                }
            }
            catch (Exception t)
            {
                label21.Text = t.Message;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images(*.jpg)|*.jpg|All files(*.*)|*.*)";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "browse";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                pictureBox1.ImageLocation = filename;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox12.Text.Trim()!= "")
                {
                    DataTable objta = new DataTable();
                    SqlCommand objc = new SqlCommand("select lname from employee where lname like'%" + textBox12.Text + "%'", objconn);
                    SqlDataAdapter obja = new SqlDataAdapter(objc);
                    objconn.Open();
                    obja.Fill(objta);
                    objconn.Close();
                    comboBox2.DataSource = objta;
                    comboBox2.DisplayMember = "lname";
                    comboBox2.ValueMember = "lname";
                }
                else
                    MessageBox.Show("جعبه متن را پر کنید");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            button14.Visible = false;
            button15.Visible = false;
            textBox12.Visible = false;
            comboBox2.Visible = false;
            radioButton2.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {

         try
            {
                ds.Clear();
                ReportDocument reportDocument = new ReportDocument();
                SqlDataAdapter objadapter = new SqlDataAdapter();
                objadapter.SelectCommand = new SqlCommand("select * from employee where lname=@l1 order by code", objconn);
                objadapter.SelectCommand.Parameters.AddWithValue("@l1", comboBox2.Text);
                objconn.Open();
                objadapter.Fill(ds,"employee");
                objconn.Close();

                ConnectionInfo connectionInfo = new ConnectionInfo();
                connectionInfo.ServerName = ".";
                connectionInfo.DatabaseName = "project2";
                connectionInfo.UserID = "";
                connectionInfo.Password = "";

                string reportPath = Application.StartupPath.Remove(Application.StartupPath.Length - 10);
                reportPath += @"\CrystalReport1.rpt";
                reportDocument.Load(reportPath);
                reportDocument.SetDataSource(ds);
                crystalReportViewer1.ReportSource = reportDocument;
                reportDocument.SetParameterValue("date", label24.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ReportDocument reportDocument = new ReportDocument();
            ConnectionInfo connectionInfo = new ConnectionInfo();
            connectionInfo.ServerName = ".";
            connectionInfo.DatabaseName = "project2";
            connectionInfo.UserID = "";
            connectionInfo.Password = "";

            string reportPath = Application.StartupPath.Remove(Application.StartupPath.Length - 10);
            reportPath += @"\CrystalReport1.rpt";
            reportDocument.Load(reportPath);
            //reportDocument.SetDataSource(ds);
            crystalReportViewer1.ReportSource = reportDocument;
            reportDocument.SetParameterValue("date", label24.Text);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
        }

        private void radioButton1_Click_1(object sender, EventArgs e)
        {
            button14.Visible = true;
            button15.Visible = true;
            textBox12.Visible = true;
            comboBox2.Visible = true;
            button4.Visible = false;
            radioButton2.Visible = true;
            MessageBox.Show("قسمتی از نام خانوادگی مورد جستجو را در جعبه متن زیر وارد کنید");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images(*.jpg)|*.jpg|All files(*.*)|*.*)";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "browse";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename1 = openFileDialog1.FileName;
                pictureBox2.ImageLocation = filename1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }     
    }
}
