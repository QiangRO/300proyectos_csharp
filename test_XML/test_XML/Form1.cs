using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Add this using
using System.Xml;
using System.IO;

namespace test_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Create the xml document containe
                XmlDocument doc = new XmlDocument();
                // Create the XML Declaration, and append it to XML document
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
                doc.AppendChild(dec);
                // Create the root element
                XmlElement root = doc.CreateElement("test");
                doc.AppendChild(root);
                XmlNode name = doc.CreateElement("name");
                name.InnerText = textBox1.Text;
                XmlNode x = doc.CreateElement("x");
                x.InnerText = numericUpDown1.Value.ToString();
                XmlNode y = doc.CreateElement("y");
                y.InnerText = numericUpDown2.Value.ToString();
                root.AppendChild(name);
                root.AppendChild(x);
                root.AppendChild(y);
                doc.Save(saveFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(openFileDialog1.FileName);
                XmlNode root = doc.DocumentElement;
                string name=root.ChildNodes[0].InnerText;
                int x = Convert.ToInt32(root.ChildNodes[1].InnerText);
                int y = Convert.ToInt32(root.ChildNodes[2].InnerText);
                MessageBox.Show(name+" "+x.ToString()+" "+ y.ToString());
            }
        }
    }
}
