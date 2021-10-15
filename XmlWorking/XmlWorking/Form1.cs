using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XmlWorking
{
    public partial class Form1 : Form
    {
        // declare two string for path of the Source & Destination of XML File (both have the same value)
        private string strSource;
        private string strDest;

        // declare an Instance of dataTable class and 4 DataColumn object 
        // for our table (because our table has 4 columns)
        private DataTable dt;
        private DataColumn dcID;
        private DataColumn dcName;
        private DataColumn dcFamily;
        private DataColumn dcAge;

        public Form1()
        {
            InitializeComponent();
            // initialize strings objects
            this.strSource = "test.xml";
            this.strDest = "test.xml";
            
            // initialize data objects
            this.dt = new DataTable();
            this.dcID = new DataColumn("ID");
            this.dcName = new DataColumn("Name");
            this.dcFamily = new DataColumn("Family");
            this.dcAge = new DataColumn("Age");

            // add DataColumn objects to our DataTable object.
            this.dt.Columns.Add(this.dcID);
            this.dt.Columns.Add(this.dcName);
            this.dt.Columns.Add(this.dcFamily);
            this.dt.Columns.Add(this.dcAge);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "Welcome to Xml Working Project Sample!";
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            // this method defined for loading records from existing xml file (test.xml) to
            // our datagridview
            this.LoadXML();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // this defined for Save our data to existing path as destination (test.xml)
            // Note : both methods (SaveXML,ExportXML) return the same result.
            this.SaveXML(this.dataGridView1, this.strDest);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            // this method like SaveXML, but it save data to a new file that set by user.
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ExportXML(this.dataGridView1,this.saveFileDialog1.FileName);
            }
        }

        private void btn_dynamicLoad_Click(object sender, EventArgs e)
        {
            // this method defined to create records on the fly and add
            // to dataGridview that pass to it as argument
            this.LoadDynamicGridView(this.dataGridView1, 100);
        }

        private void LoadXML()
        {
            if (!System.IO.File.Exists(this.strSource))
            {
                this.toolStripStatusLabel1.Text = string.Format("File : {0} does not exist!", this.strSource);
            }
            else
            {
                // ����� ����� �������� �� ��� ������ �� ǐ� ��� ��� ��� ����� ���� ����
                // ���� �� �� ���� ��ǁ� �� �������� ����� ���
                this.dt.Clear();
                this.strDest = this.strSource;
                // �� ����� � ��� ��� �� ����� ����-��-�� ����� ���� �� ��� ����-��-�� ����� ����
                XmlDocument xmlDoc = new XmlDocument();
                // ��� ������ �� ���� �� ���� ������ ����� ��� �� ��� �� �� ��� �����
                // ���� : �� ����� ���� ����ǡ ��� ���� �������� ������ �� �� ����� �� ������� �� �� ���� �� ������
                XmlNodeList xmlNodeList;
                // �� ��� �� ��� �� �� ���� �� ������ �� �� ����� � �� ����� ������
                XmlNode xmlNode;
                // ���� ����-��-�� ���� ��� �� �� ���� �������� ���� ��� �� ��� ����-��-�� ������ ��ѐ���� ������
                xmlDoc.Load(this.strSource);
                // �� �������� ���� ��ѡ ��� ����-��-�� �� ������� �� �� ����� � �� ����� ���� ��� ���� ����
                // ���� : ���� �� ������ Ȑ�� �� ���� ʐ� �� ����� � ���� �������� ��ʡ ��� ʐ �� 
                // ���� �� ���� ����� �� ����� ������ �� ������ ���� ���� �����
                xmlNodeList = xmlDoc.GetElementsByTagName("Record");
                int i;
                // ����� �� �� ���� ����� �� ���� ������ � ����� ���� ����� �������
                // �� ������� ������� �� ����� �� ������ �� ����� ������� ���� ���� 
                object[] list = new object[this.dt.Columns.Count];
                Application.DoEvents();
                // ��� ���� �� ������ � ����� �������� ����� �� ���� ���� ����� �� ���� ��� �� �� �� 
                // ����� �������� ���� ���
                for (i = 0; i <= xmlNodeList.Count - 1; i++)
                {
                    xmlNode = xmlNodeList.Item(i);
                    list[0] = xmlNode.Attributes.Item(0).Value;
                    list[1] = xmlNode.Attributes.Item(1).Value;
                    list[2] = xmlNode.Attributes.Item(2).Value;
                    list[3] = xmlNode.Attributes.Item(3).Value;
                    this.dt.Rows.Add(list);
                }
                this.dataGridView1.DataSource = this.dt.DefaultView;
                this.toolStripStatusLabel1.Text = string.Format("Numer of Records is : {0}", this.dt.Rows.Count.ToString());
            }
        }

        private void SaveXML(DataGridView gridView, string destination)
        {            
            // ���� ����� � �������� ���ǐ������ ������ ����� ��� �� ����� ����
            XmlTextWriter xmlTextWriter = new XmlTextWriter(destination, ASCIIEncoding.Default);
            // ��� ���� ��� ����-��-�� �� ����� ���� ����� � �������� ����� �� ���� ����-��-�� �� �� �� �������
            xmlTextWriter.WriteStartDocument();
            // ���� ��� ���� �������� ������ �� ��� ����-��-�� ������� ����� ����
            // ���� : ������� �� ��� ���� ������� ���
            xmlTextWriter.WriteComment("This Document Created By Hamed Vaziri - 2007");
            // �� ��� ����-��-�� ������ �� ���� ���� � ����� �� ��� ����� ����
            // ���� ��� ���� ʐ ���� ���� ���� ��� �� ����� � ��� ������
            xmlTextWriter.WriteStartElement("root");
            int i;
            Application.DoEvents();
            // �� ������ � ����� �������� ���ǐ������ ��� ���� ���� ����� � ���� �� �� �� ��� ����-��-�� ���� ���
            // �������
            for (i = 0; i <= gridView.Rows.Count - 2; i++)
            {
                this.toolStripStatusLabel1.Text = string.Format("Saving Record : {0}", i.ToString());
                // ��� ���� ���� �� ʐ� ��� �� �� ��� ��ѐ���� ���� �� �� ����� ��� ����-��-����� 
                // ��� ����� ��� ���� �� ����� ���� � ���� �� ����� ������
                xmlTextWriter.WriteStartElement("Record");
                // �� ��� ���� ���� ����� ���� ��� ������ �� ��� ����-��-�� ������� ������
                // � ���� �� �� ������� ��� ��� ���� ��� ��� ���� ���� ��� � ���� ������
                // ���� 1 : ������� �� ������� ��� �� 4 �� ���� ������ ����� �� ���� ��� ��� ���� ���
                // �� �������� ����� � ���� �� � ��������� ��� ��� �����
                xmlTextWriter.WriteAttributeString("ID", gridView.Rows[i].Cells[0].Value.ToString());
                xmlTextWriter.WriteAttributeString("Name", gridView.Rows[i].Cells[1].Value.ToString());
                xmlTextWriter.WriteAttributeString("Family", gridView.Rows[i].Cells[2].Value.ToString());
                xmlTextWriter.WriteAttributeString("Age", gridView.Rows[i].Cells[3].Value.ToString());
                // �� ����� ����� ���� ��� �� ����ϡ �� ����� � ��� ���ڡ ����� ���� ���� �� ʐ ��� �� �������
                // ������� �� ������ �� �� ��� ���� �� ʐ ��� ����� ��� ʐ ���� �� �� ���� �� ���� ��� �����
                // ��� �� ʐ ����� �� �� ���� ���� ��� ����� ���� ��� ���� �� ����� ���� ʐ ���� ʐ ����� ����� 
                // ������ � ��� �� ������
                xmlTextWriter.WriteEndElement();
            }
            // �� �� ����� ���� � ���� ���� ���� �� �� ��� ����-��-�� ���� ���� ʐ �� ���� ��� �� �� ������
            // ��� ���ڡ ���� ����� ��� �� �� ���� ���� �� ��� ����� ����� ����� �� ��� ���� ���� �� ���� ���� ��
            // ʐ ��� ��� ����� ������ � ��� �� ������
            xmlTextWriter.WriteEndElement();
            // ���� ��� �� ���� �� � ������ ��� ���� ����-��-�� �� �� ������
            xmlTextWriter.WriteEndDocument();
            // ���� ���� ����� ����� �� �� �� ���� ��� ����� �� ��� ����-��-����� ��� ��� �� �� ������
            // ��� ��� ��������� ���� �� ������ ������� �� ���� ���� ������
            xmlTextWriter.Close();
            this.toolStripStatusLabel1.Text = string.Format("Xml Saved! [ Records : {0} ]", i.ToString());
        }

        // ������� �� ���� �� ���� ���� ��� ��� �� ��� ����� �� ����� � ���� �� �� ���� �� �� �����
        // ��� ���� ����� ��� ����-��-�� �� ����� � ����� ���� ����
        private void ExportXML(DataGridView gridView,string destination)
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter(destination, ASCIIEncoding.Default);
            xmlTextWriter.WriteStartDocument();
            xmlTextWriter.WriteComment("This Document Created By Hamed Vaziri - 2007");
            xmlTextWriter.WriteStartElement("root");
            int i;
            Application.DoEvents();
            for (i = 0; i <= gridView.Rows.Count - 2; i++)
            {
                this.toolStripStatusLabel1.Text = string.Format("Exporting Record : {0}", i.ToString());
                xmlTextWriter.WriteStartElement("Record");
                xmlTextWriter.WriteAttributeString("ID", this.dataGridView1.Rows[i].Cells[0].Value.ToString());
                xmlTextWriter.WriteAttributeString("Name", this.dataGridView1.Rows[i].Cells[1].Value.ToString());
                xmlTextWriter.WriteAttributeString("Family", this.dataGridView1.Rows[i].Cells[2].Value.ToString());
                xmlTextWriter.WriteAttributeString("Age", this.dataGridView1.Rows[i].Cells[3].Value.ToString());
                xmlTextWriter.WriteEndElement();
            }
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Close();
            this.toolStripStatusLabel1.Text = string.Format("Xml Export Done! [ Records : {0} ]", i.ToString());
        }

        // ��� ���� �� ���� ������ߡ ���ǐ������ �� �� ���� �� �� �����
        private void LoadDynamicGridView(DataGridView gridView,int maxRecords)
        {
            // ��� �������� ���� �� ����� �� ��� ���� ����� �� ������ ������ �� ��������� �� ���� ���� ��� ����
            gridView.DataSource = null;
            if (gridView.Columns.Count > 0 || gridView.Rows.Count > 0)
            {
                gridView.Rows.Clear();
                gridView.Columns.Clear();
            }

            // �� ����� ������� ������� �� ��� ����� ������� � ���� �� �� ������� ����� ������
            // �� ����� �� 4 ���� ������ �� ���� 4 ����� �� ��� ���� ������
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();

            // ��� ���������� �� ��ǁ��� ���� ��� �� 4 �������� ��� ������
            col1.HeaderText = "ID";
            col2.HeaderText = "Name";
            col3.HeaderText = "Family";
            col4.HeaderText = "Age";

            // ��������� �� �� ���� ����� ����� �� �� ������� ����� ������
            gridView.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4 });

            int i;
            Application.DoEvents();
            for (i = 0; i <= maxRecords - 1; i++)
            {
                // �� ��� ���� �� ����� � 4 ����� �� ���� ����� �� �� ����� ���� �� ������� ����� ������
                gridView.Rows.Add(new object[] { string.Format("id{0}", i.ToString()), string.Format("name{0}", i.ToString()), string.Format("family{0}", i.ToString()), string.Format("age{0}", i.ToString()) });                
            }
            this.toolStripStatusLabel1.Text = string.Format("Dynamic Load Done! Records : {0}", i.ToString());
        }
    }
}