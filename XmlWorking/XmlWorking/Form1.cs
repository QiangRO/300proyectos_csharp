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
                // «» œ« ¬»Ãﬂ  œÌ « Ì»· —Ê Å«ﬂ „Ìﬂ‰Ì„  « «ê— ç‰œ »«— ⁄„· ·ÊœÌ‰ê ’Ê—  ê—› 
                // œ«œÂ Â« »Â ’Ê—  ÅÌ«ÅÌ »Â ¬»Ãﬂ „Ê‰ «÷«›Â ‰‘Â
                this.dt.Clear();
                this.strDest = this.strSource;
                // œ— „—Õ·Â Ì «Ê· ﬂ«— »« «”‰«œ «Ìﬂ”-«„-«· «» œ« »«Ìœ Ìﬂ ”‰œ «Ìﬂ”-«„-«· «ÌÃ«œ ﬂ‰Ì„
                XmlDocument xmlDoc = new XmlDocument();
                // »⁄œ »«Ì” Ì ÌÂ ·Ì”  «“  „«„ ‰ÊœÂ«Ì –ŒÌ—Â ‘œÂ œ— ”‰œ —Ê »Â œ”  ¬Ê—Ì„
                //  ÊÃÂ : œ— «Ì‰Ã« ·Ì”  ‰ÊœÂ«° „À· Â„Ê‰ œÌ « Ì»· „Ì„Ê‰Â ﬂÂ Ìﬂ ·Ì” Ì «“ —ﬂÊ—œÂ« —Ê œ— ŒÊœ‘ ‰êÂ „Ìœ«—Â
                XmlNodeList xmlNodeList;
                // ﬂÂ ›ﬁÿ ÌÂ ‰Êœ —Ê œ— ŒÊœ‘ ‰êÂ „Ìœ«—Â ﬂÂ »Â „‰“·Â Ì Ìﬂ —ﬂÊ—œ „Ì„Ê‰Â
                XmlNode xmlNode;
                // ›«Ì· «Ìﬂ”-«„-«· „Ê—œ ‰Ÿ— —Ê «“ ÿ—Ìﬁ ›—«ŒÊ«‰Ì  «»⁄ “Ì— œ— ”‰œ «Ìﬂ”-«„-«· ŒÊœ„Ê‰ »«—ê–«—Ì „Ìﬂ‰Ì„
                xmlDoc.Load(this.strSource);
                // »« ›—«ŒÊ«‰Ì  «»⁄ “Ì—° ”‰œ «Ìﬂ”-«„-«· „« —ﬂÊ—œÂ« —Ê œ— „Ì«—Â Ê œ— ¬»Ãﬂ  „Ê—œ ‰Ÿ— ﬁ—«— „ÌœÂ
                //  ÊÃÂ : »«Ìœ »Â ”‰œ„Ê‰ »êÌ„ ﬂÂ ﬂœÊ„  ê° »Â „‰“·Â Ì ‘—Ê⁄ —ﬂÊ—œ„Ê‰ Â” ° «Ì‰  ê —Ê 
                // ﬁ»·« œ— ﬁ”„  –ŒÌ—Â Ì« Œ—ÊÃÌ »«Ì” Ì œ— ”‰œ„Ê‰ ﬁ—«— œ«œÂ »«‘Ì„
                xmlNodeList = xmlDoc.GetElementsByTagName("Record");
                int i;
                // ¬—«ÌÂ «Ì «“ ﬂ·«” ¬»Ãﬂ  »« ÿÊ·Ì «‰œ«“Â Ì  ⁄œ«œ ” Ê‰ Â«„Ê‰ „Ì”«“Ì„
                //  « „Õ ÊÌ«  ” Ê‰Â«Ì Â— —ﬂÊ—œ —Ê » Ê‰Ì„ œ— ⁄‰«’— „ ‰«Ÿ—‘ ﬁ—«— »œÌ„ 
                object[] list = new object[this.dt.Columns.Count];
                Application.DoEvents();
                // «Ì‰ Õ·ﬁÂ »Â «‰œ«“Â Ì  ⁄œ«œ —ﬂÊ—œÂ«Ì „ÊÃÊœ œ— ›«Ì· «Ã—« „Ì‘Êœ  «  „«„ ‰Êœ Â« —« œ— 
                // ¬»Ãﬂ  œÌ « Ì»· ﬁ—«— œÂœ
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
            // »—«Ì –ŒÌ—Â Ì —ﬂÊ—œÂ«Ì œÌ «ê—ÌœÊÌÊ »«Ì” Ì «»Ãﬂ  “Ì— —«  ⁄—Ì› ﬂ‰Ì„
            XmlTextWriter xmlTextWriter = new XmlTextWriter(destination, ASCIIEncoding.Default);
            // «Ì‰  «»⁄ ”‰œ «Ìﬂ”-«„-«· —« ¬„«œÂ ”«“Ì „Ìﬂ‰œ Ê «ÿ·«⁄« Ì „Œ ’— œ— „Ê—œ «Ìﬂ”-«„-«· —« œ— ¬‰ „Ì‰ÊÌ”œ
            xmlTextWriter.WriteStartDocument();
            //  Ê”ÿ «Ì‰  «»⁄ „Ì Ê«‰Ìœ ŒÊœ «‰° œ— ”‰œ «Ìﬂ”-«„-«·°  Ê÷ÌÕ«  «ÌÃ«œ ﬂ‰Ìœ
            //  ÊÃÂ : «” ›«œÂ «“ «Ì‰  «»⁄ «Œ Ì«—Ì «” 
            xmlTextWriter.WriteComment("This Document Created By Hamed Vaziri - 2007");
            // Â— ”‰œ «Ìﬂ”-«„-«· »«Ì” Ì Ìﬂ ⁄‰’— —Ì‘Â Ê „‰Õ’— »Â ›—œ œ«‘ Â »«‘œ
            //  Ê”ÿ «Ì‰  «»⁄  ê ‘—Ê⁄ ⁄‰’— „Ê—œ ‰Ÿ— —« «ÌÃ«œ Ê »«“ „Ìﬂ‰Ì„
            xmlTextWriter.WriteStartElement("root");
            int i;
            Application.DoEvents();
            // »Â «‰œ«“Â Ì  ⁄œ«œ —ﬂÊ—œÂ«Ì œÌ «ê—ÌœÊÌÊ° «Ì‰ Õ·ﬁÂ «Ã—« „Ì‘Êœ Ê œ«œÂ Â« —« œ— ”‰œ «Ìﬂ”-«„-«· „Ê—œ ‰Ÿ—
            // „Ì‰ÊÌ”œ
            for (i = 0; i <= gridView.Rows.Count - 2; i++)
            {
                this.toolStripStatusLabel1.Text = string.Format("Saving Record : {0}", i.ToString());
                // «Ì‰ Â„Ê‰ ⁄‰’— Ì«  êÌ Â”  ﬂÂ œ— »Œ‘ »«—ê–«—Ì œ«œÂ Â« »Â ¬»Ãﬂ  ”‰œ «Ìﬂ”-«„-«·„Ê‰ 
                // Å«” ﬂ—œÌ„° «Ì‰ ⁄‰’— »Â „⁄‰«Ì ‰ﬁÿÂ Ì ‘—Ê⁄ Â— —ﬂÊ—œ „Ì»«‘œ
                xmlTextWriter.WriteStartElement("Record");
                // «“ «Ì‰  «»⁄ »—«Ì ‰Ê‘ ‰ œ«œÂ Â«Ì ŒÊœ„Ê‰ œ— ”‰œ «Ìﬂ”-«„-«· «” ›«œÂ „Ìﬂ‰Ì„
                // Ê »«Ìœ œÊ  « Å«—«„ — »Â‘ Å«” ﬂ‰Ì„° ÌﬂÌ ‰«„ ” Ê‰ „Ê—œ ‰Ÿ— Ê œÌê—Ì „ﬁœ«—‘
                // ‰ﬂ Â 1 : Â„«‰ÿÊ— ﬂÂ „Ì»Ì‰Ìœ çÊ‰ „« 4  « ” Ê‰ œ«‘ Ì„° «Ì‰Ã« Â„ çÂ«— »«— „ œ „Ê—œ ‰Ÿ—
                // —Ê ›—«ŒÊ«‰Ì ﬂ—œÌ„ Ê ” Ê‰ Â« Ê „ﬁœ«—Â«‘Ê »Â‘ Å«” ﬂ—œÌ„
                xmlTextWriter.WriteAttributeString("ID", gridView.Rows[i].Cells[0].Value.ToString());
                xmlTextWriter.WriteAttributeString("Name", gridView.Rows[i].Cells[1].Value.ToString());
                xmlTextWriter.WriteAttributeString("Family", gridView.Rows[i].Cells[2].Value.ToString());
                xmlTextWriter.WriteAttributeString("Age", gridView.Rows[i].Cells[3].Value.ToString());
                // œ— Å«Ì«‰ ‰Ê‘ ‰ œ«œÂ Â«Ì Â— —ﬂÊ—œ° »Â Ê”Ì·Â Ì «Ì‰  «»⁄° œ«Œ·Ì  —Ì‰ ⁄‰’— Ì«  ê »«“ —Ê „Ì»‰œÌ„
                // Â„«‰ÿÊ— ﬂÂ „Ì»‰Ìœ „« œ— Õ«· Õ«÷— œÊ  ê »«“ œ«—Ì„° ÌﬂÌ  ê —Ì‘Â ﬂÂ œ— Œ«—Ã «“ Õ·ﬁÂ »«“ ﬂ—œÌ„
                // ÌﬂÌ Â„  ê —ﬂÊ—œ ﬂÂ œ— œ«Œ· Õ·ﬁÂ »«“ ﬂ—œÌ„° «·«‰ «Ì‰  «»⁄ »— œ«Œ·Ì  —Ì‰  ê Ì⁄‰Ì  ê —ﬂÊ—œ  «ÀÌ— 
                // „Ì–«—Â Ê «Ê‰ —Ê „Ì»‰œÂ
                xmlTextWriter.WriteEndElement();
            }
            // Å” «“ Å«Ì«‰ Õ·ﬁÂ Ê Ê«—œ ﬂ—œ‰ œ«œÂ Â« »Â ”‰œ «Ìﬂ”-«„-«·° »«Ìœ  ‰Â«  ê Ì« ⁄‰’— »«“ —Ê Â„ »»‰œÌ„
            // «Ì‰  «»⁄° Â„Ê‰  «»⁄Ì Â”  ﬂÂ œ— œ«Œ· Õ·ﬁÂ »Â ﬂ«— »—œÌ„° „‰ Â« «Ì‰Ã« »— —ÊÌ ⁄‰’— —Ì‘Â ﬂÂ  ‰Â« ⁄‰’— Ì«
            //  ê »«“ Â”   «ÀÌ— „Ì–«—Â Ê «Ê‰ —Ê „Ì»‰œÂ
            xmlTextWriter.WriteEndElement();
            // Õ«·« ﬂ«— „«  „«„ ‘œ Ê »«Ì” Ì ”‰œ «’·Ì «Ìﬂ”-«„-«· —Ê Â„ »»‰œÌ„
            xmlTextWriter.WriteEndDocument();
            // Õ«·« »«Ìœ Ã—Ì«‰ Œ—ÊÃÌ «Ì —Ê ﬂÂ  Ê”ÿ «Ì‰ ¬»Ãﬂ  »Â ”‰œ «Ìﬂ”-«„-«·„Ê‰ Ê’· Â”  —Ê Â„ »»‰œÌ„
            // çÊ‰ œÌêÂ ‰„ÌŒÊ«ÂÌ„ çÌ“Ì œ— ”‰œ„Ê‰ »‰ÊÌ”Ì„° Å” »«Ìœ œ—‘Ê »»‰œÌ„
            xmlTextWriter.Close();
            this.toolStripStatusLabel1.Text = string.Format("Xml Saved! [ Records : {0} ]", i.ToString());
        }

        // Â„«‰ÿÊ— ﬂÂ ﬁ»·« Â„ ê› Â »Êœ„° «Ì‰ „ œ »« „ œ „—»Êÿ »Â –ŒÌ—Â Ì œ«œÂ Â« ÂÌç ›—ﬁÌ »« Â„ ‰œ«—‰
        // ›ﬁÿ „”Ì— –ŒÌ—Â ”‰œ «Ìﬂ”-«„-«· »Â Ê”Ì·Â Ì ﬂ«—»— „‘Œ’ „Ì‘Â
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

        // «Ì‰  «»⁄ »Â ’Ê—  œÌ‰«„Ìﬂ° œÌ «ê—ÌœÊÌÊ —Ê «“ œ«œÂ Â« Å— „Ìﬂ‰Â
        private void LoadDynamicGridView(DataGridView gridView,int maxRecords)
        {
            // «Ê· œÌ «”Ê—” ê—Ìœ —Ê »—«»— »« ‰«· ﬁ—«— „ÌœÌ„  « » Ê‰Ì„ ” Ê‰Â« Ì« —ﬂÊ—œÂ«‘Ê œ— ’Ê—  ÊÃÊœ Õ–› ﬂ‰Ì„
            gridView.DataSource = null;
            if (gridView.Columns.Count > 0 || gridView.Rows.Count > 0)
            {
                gridView.Rows.Clear();
                gridView.Columns.Clear();
            }

            // »Â  ⁄œ«œ ” Ê‰Â«Ì ÃœÊ·„Ê‰ «“ «Ì‰ ¬»Ãﬂ  „Ì”«“Ì„ Ê «Ê‰« —Ê »Â ê—Ìœ„Ê‰ «÷«›Â „Ìﬂ‰Ì„
            // œ— «Ì‰Ã« „« 4 ” Ê‰ œ«‘ Ì„ Å” »«Ìœ 4 ¬»Ãﬂ  «“ «Ì‰ ﬂ·«” »”«“Ì„
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();

            // «”„ ” Ê‰Â«„Ê‰Ê »Â Å—«Å— Ì „Ê—œ ‰Ÿ— «“ 4 ¬»Ãﬂ „Ê‰ Å«” „Ìﬂ‰Ì„
            col1.HeaderText = "ID";
            col2.HeaderText = "Name";
            col3.HeaderText = "Family";
            col4.HeaderText = "Age";

            // ¬»Ãﬂ Â«ÌÌ ﬂÂ œ— »«·« „⁄—›Ì ﬂ—œÌ„ —Ê »Â ê—ÌœÊÌÊ «÷«›Â „Ìﬂ‰Ì„
            gridView.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4 });

            int i;
            Application.DoEvents();
            for (i = 0; i <= maxRecords - 1; i++)
            {
                // œ— «Ì‰ Õ·ﬁÂ ÌÂ «—«ÌÂ Ì 4 ⁄‰’—Ì «“ ﬂ·«” ¬»Ãﬂ  —Ê »Â —ﬂÊ—œ Ã«—Ì «“ ê—ÌœÊÌÊ «÷«›Â „Ìﬂ‰Ì„
                gridView.Rows.Add(new object[] { string.Format("id{0}", i.ToString()), string.Format("name{0}", i.ToString()), string.Format("family{0}", i.ToString()), string.Format("age{0}", i.ToString()) });                
            }
            this.toolStripStatusLabel1.Text = string.Format("Dynamic Load Done! Records : {0}", i.ToString());
        }
    }
}