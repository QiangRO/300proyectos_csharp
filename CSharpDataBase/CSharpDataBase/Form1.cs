using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CSharpDataBase
{
	public class Form1 : System.Windows.Forms.Form
	{
		#region
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button btnChap;
		private System.Windows.Forms.TextBox txtTelephon;
		private System.Windows.Forms.TextBox txtFamily;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button btnJostejoo;
		private System.Windows.Forms.Button btnHazf;
		private System.Windows.Forms.Button btnVirayesh;
		private System.Windows.Forms.Button btnDarj;
		private System.Windows.Forms.DataGrid DataGrid1;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;

		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();

		}
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnChap = new System.Windows.Forms.Button();
			this.txtTelephon = new System.Windows.Forms.TextBox();
			this.txtFamily = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnJostejoo = new System.Windows.Forms.Button();
			this.btnHazf = new System.Windows.Forms.Button();
			this.btnVirayesh = new System.Windows.Forms.Button();
			this.btnDarj = new System.Windows.Forms.Button();
			this.DataGrid1 = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(224, 248);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(58, 16);
			this.Label3.TabIndex = 23;
			this.Label3.Text = "ÔãÇÑå ÊáÝä";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(224, 224);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(63, 16);
			this.Label2.TabIndex = 22;
			this.Label2.Text = "äÇã ÎÇäæÇÏí";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(224, 200);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(17, 16);
			this.Label1.TabIndex = 21;
			this.Label1.Text = "äÇã";
			// 
			// btnChap
			// 
			this.btnChap.Font = new System.Drawing.Font("Tahoma", 8F);
			this.btnChap.Location = new System.Drawing.Point(32, 272);
			this.btnChap.Name = "btnChap";
			this.btnChap.TabIndex = 8;
			this.btnChap.Text = "Ç";
			this.btnChap.Click += new System.EventHandler(this.btnChap_Click);
			// 
			// txtTelephon
			// 
			this.txtTelephon.Location = new System.Drawing.Point(120, 248);
			this.txtTelephon.Name = "txtTelephon";
			this.txtTelephon.TabIndex = 3;
			this.txtTelephon.Text = "";
			// 
			// txtFamily
			// 
			this.txtFamily.Location = new System.Drawing.Point(120, 224);
			this.txtFamily.Name = "txtFamily";
			this.txtFamily.TabIndex = 2;
			this.txtFamily.Text = "";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(120, 200);
			this.txtName.Name = "txtName";
			this.txtName.TabIndex = 1;
			this.txtName.Text = "";
			// 
			// btnJostejoo
			// 
			this.btnJostejoo.Font = new System.Drawing.Font("Tahoma", 8F);
			this.btnJostejoo.Location = new System.Drawing.Point(32, 248);
			this.btnJostejoo.Name = "btnJostejoo";
			this.btnJostejoo.TabIndex = 7;
			this.btnJostejoo.Text = "ÌÓÊÌæ";
			this.btnJostejoo.Click += new System.EventHandler(this.btnJostejoo_Click);
			// 
			// btnHazf
			// 
			this.btnHazf.Font = new System.Drawing.Font("Tahoma", 8F);
			this.btnHazf.Location = new System.Drawing.Point(32, 224);
			this.btnHazf.Name = "btnHazf";
			this.btnHazf.TabIndex = 6;
			this.btnHazf.Text = "ÍÐÝ ";
			this.btnHazf.Click += new System.EventHandler(this.btnHazf_Click);
			// 
			// btnVirayesh
			// 
			this.btnVirayesh.Font = new System.Drawing.Font("Tahoma", 8F);
			this.btnVirayesh.Location = new System.Drawing.Point(32, 200);
			this.btnVirayesh.Name = "btnVirayesh";
			this.btnVirayesh.TabIndex = 5;
			this.btnVirayesh.Text = "æíÑÇíÔ";
			this.btnVirayesh.Click += new System.EventHandler(this.btnVirayesh_Click);
			// 
			// btnDarj
			// 
			this.btnDarj.Font = new System.Drawing.Font("Tahoma", 8F);
			this.btnDarj.Location = new System.Drawing.Point(32, 176);
			this.btnDarj.Name = "btnDarj";
			this.btnDarj.TabIndex = 4;
			this.btnDarj.Text = "ÏÑÌ";
			this.btnDarj.Click += new System.EventHandler(this.btnDarj_Click);
			// 
			// DataGrid1
			// 
			this.DataGrid1.BackgroundColor = System.Drawing.Color.Linen;
			this.DataGrid1.CaptionBackColor = System.Drawing.Color.PeachPuff;
			this.DataGrid1.DataMember = "";
			this.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DataGrid1.Location = new System.Drawing.Point(8, 8);
			this.DataGrid1.Name = "DataGrid1";
			this.DataGrid1.Size = new System.Drawing.Size(280, 160);
			this.DataGrid1.TabIndex = 0;
			this.DataGrid1.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								  this.dataGridTableStyle1});
			this.DataGrid1.TabStop = false;
			this.DataGrid1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGrid1_MouseUp);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.AlternatingBackColor = System.Drawing.Color.Wheat;
			this.dataGridTableStyle1.DataGrid = this.DataGrid1;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn3});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "äÇã";
			this.dataGridTextBoxColumn1.MappingName = "name";
			this.dataGridTextBoxColumn1.NullText = "";
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "äÇã ÎÇäæÇÏå";
			this.dataGridTextBoxColumn2.MappingName = "family";
			this.dataGridTextBoxColumn2.NullText = "";
			this.dataGridTextBoxColumn2.Width = 75;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "ÊáÝä";
			this.dataGridTextBoxColumn3.MappingName = "tel";
			this.dataGridTextBoxColumn3.NullText = "";
			this.dataGridTextBoxColumn3.Width = 75;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 310);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnChap);
			this.Controls.Add(this.txtTelephon);
			this.Controls.Add(this.txtFamily);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.btnJostejoo);
			this.Controls.Add(this.btnHazf);
			this.Controls.Add(this.btnVirayesh);
			this.Controls.Add(this.btnDarj);
			this.Controls.Add(this.DataGrid1);
			this.Font = new System.Drawing.Font("Tahoma", 8F);
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ÏÝÊÑå ÊáÝä";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		#endregion

		#region "Variabels"
		string nam, famil;
		#endregion

		#region "FormLoad"
		//'dar inja 
		//'-1-zaban farsi mishavad
		//'-2-datagrid az ettelaat por mishavad
		private void Form1_Load(System.Object sender ,System.EventArgs e)
		{
			//'farsi saz
			System.Globalization.CultureInfo language=new System.Globalization.CultureInfo("fa-ir");
			InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);

			DataTable dt=new DataTable();
			//'sakhte yek nemoone az class DataBase
			 DataBase db=new  DataBase();
			//'seda zadan function==>MySelect baraye jostejoo dar bank
			dt = db.MySelect("select * from telephon");
			DataGrid1.DataSource = dt;
		}
		#endregion

		private void DataGrid1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			#region "DataGrid1_MouseUp-Bind to TextBoxes"
			//'in event kare bind kardane ettelaat dakhele datagrid be textboxha ro anjam mide-
			//'motaasefane natoonestam ba click roye datagrid hamin kar ro anjam bedam
			//'click roye datagrid moshkel peyda mikone
			//'doostan mara az rahnemaishon mahroom nakonan
			//'mamnoon
			txtName.Text = DataGrid1[DataGrid1.CurrentRowIndex, 0].ToString().Trim();
			txtFamily.Text = DataGrid1[DataGrid1.CurrentRowIndex, 1].ToString().Trim();
			txtTelephon.Text = DataGrid1[DataGrid1.CurrentRowIndex, 2].ToString().Trim();

			//'baraye amaliate update and delete
			nam = txtName.Text;
			famil = txtFamily.Text;
			#endregion
		}

		private void btnDarj_Click(object sender, System.EventArgs e)
		{
			#region "Darj dar bank"
			//'ba click roye dokme ettelaate dakhele textBoxha be bank miravad
			//        Dim db As New DataBase
			 DataBase db=new  DataBase();
			db.DoCommand("insert into telephon values('" + txtName.Text + "','" + txtFamily.Text + "','" + txtTelephon.Text + "')");
			//'fill and update datagrid1
			Form1_Load(sender, e);
			MessageBox.Show("Inserted");
			#endregion
		}

		private void btnVirayesh_Click(object sender, System.EventArgs e)
		{
			#region "Update"
			 DataBase db=new  DataBase();
			db.DoCommand("update telephon set name='" + txtName.Text + "',family='" + txtFamily.Text + "',tel='" + txtTelephon.Text + "' where name='" + nam + "' and family='" + famil + "'");
			//'UPDATE DATAGRID
			Form1_Load(sender, e);
			MessageBox.Show("Updated");    
			#endregion
		}

		private void btnHazf_Click(object sender, System.EventArgs e)
		{
			#region "Delete"
			 DataBase db=new  DataBase();
			db.DoCommand("delete from telephon where name='" + txtName.Text + "' and family='" + txtFamily.Text + "'");
			//'update datagrid
			Form1_Load(sender, e);

			MessageBox.Show("Deleted");
			#endregion
		}

		private void btnJostejoo_Click(object sender, System.EventArgs e)
		{
			#region "Search"
			string str= "select * from telephon where ";

			//'inja deghat konid ke mitavan faghat ghesmati az name ra nevesht va jostejoo kard 
			if (txtName.Text != "") str += "name like '%" + txtName.Text + "' and ";

			if (txtFamily.Text !="") str += "family='" + txtFamily.Text + "' and ";
			if (txtTelephon.Text !="") str += "tel='" + txtTelephon.Text + "' and ";
			//'inja str control mishavad va , and akhari bardashte mishavad
			if (str == "select * from telephon where ")
				str = "select * from telephon";
			else
				str = str.Remove(str.Length - 4, 4);																											
			DataTable dt=new DataTable();
			DataBase db=new DataBase();
			dt=db.MySelect(str);
			MessageBox.Show(dt.Rows.Count.ToString() + " Rows founded.");
			DataGrid1.DataSource = dt;
			#endregion
		}

		private void btnChap_Click(object sender, System.EventArgs e)
		{
			#region "Chap"
        //'ebteda yek jostejoo sepas chap
			string str= "select * from telephon where ";

			//'inja deghat konid ke mitavan faghat ghesmati az name ra nevesht va jostejoo kard 
			if (txtName.Text != "") str += "name like '%" + txtName.Text + "' and ";

			if (txtFamily.Text !="") str += "family='" + txtFamily.Text + "' and ";
			if (txtTelephon.Text !="") str += "tel='" + txtTelephon.Text + "' and ";
			//'inja str control mishavad va , and akhari bardashte mishavad
			if (str == "select * from telephon where ")
				str = "select * from telephon";
			else
				str = str.Remove(str.Length - 4, 4);																											
			DataTable dt=new DataTable();
			DataBase db=new DataBase();
			dt=db.MySelect(str);
			DataGrid1.DataSource = dt;
			MessageBox.Show(dt.Rows.Count.ToString() + " Rows founded.");
			Reports r=new Reports();
			r.ShowReport(dt,"reports\\telephon.rpt");			
		#endregion
		}
	}
}
