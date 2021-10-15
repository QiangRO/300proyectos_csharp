using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace HuffmanAlgorithm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        ArrayList map_table;
        int usedCharCount;
        
        void huffman(string text)
        {
            treeView1.Nodes.Clear();
            codeTable.Items.Clear();

            int[] charList = new int[2000];
            map_table = new ArrayList();            

            for (int i = 0; i < text.Length; i++)
                charList[(int)char.Parse(text.Substring(i, 1))]++;

            for (int i = 0; i < 2000; i++)
                if (charList[i] > 0)
                {
                    TreeNode treeNode = new TreeNode(charList[i].ToString());                    
                    treeNode.ToolTipText = ((char)i).ToString();
                    map_table.Add(treeNode);
                }

            usedCharCount = map_table.Count;
                        
            for (int j = 1; j < usedCharCount; j++)
            {
                TreeNode min1 = null, min2 = null;
                for (int i = 0; i < map_table.Count; i++)
                {
                    TreeNode currentNode = (TreeNode)map_table[i];
                    if (min1 != null && min2 != null)
                    {
                        if (int.Parse(min1.Text) > int.Parse(min2.Text))
                        {
                            TreeNode temp = min1;
                            min1 = min2;
                            min2 = temp;
                        }
                        if (currentNode.Tag == null)
                        {
                            if (int.Parse(currentNode.Text) < int.Parse(min1.Text))
                            {
                                min2 = min1;
                                min1 = currentNode;
                            }
                            else
                                if (int.Parse(currentNode.Text) < int.Parse(min2.Text))
                                    min2 = currentNode;
                        }
                    }
                    else
                    {
                        if (currentNode.Tag == null)
                        {
                            if (min1 == null)
                                min1 = currentNode;
                            else
                                min2 = currentNode;
                        }
                    }
                }                
                TreeNode[] childrenNodes = new TreeNode[] { min1, min2 };
                TreeNode addNode = new TreeNode((int.Parse(min1.Text) + int.Parse(min2.Text)).ToString(), childrenNodes);
                addNode.ToolTipText = min1.ToolTipText + "_" + min2.ToolTipText;
                updateNodeFlag(addNode.Nodes[1], "1");
                updateNodeFlag(addNode.Nodes[0], "0");
                map_table.Add(addNode);

                min1.Tag = 1;
                min2.Tag = 1;
            }
            treeView1.Nodes.Add((TreeNode) map_table[map_table.Count-1]);
            treeView1.ExpandAll();            
        }

        private void updateNodeFlag(TreeNode treeNode, string flag)
        {
            if (treeNode.Nodes.Count == 0) treeNode.Name = flag + treeNode.Name;
            else
            {
                foreach (TreeNode node in treeNode.Nodes)
                    node.Name = flag + node.Name;

                updateNodeFlag(treeNode.Nodes[0], flag);
                updateNodeFlag(treeNode.Nodes[1], flag);
            }
        }

        public enum Compression : int
        {
            Compress, Decompress
        }

        private string compression(String text,Compression compress)
        {
            if (!string.IsNullOrEmpty(text))
            {
                if (compress == Compression.Compress)
                {
                    huffman(text);
                    for (int i = 0; i < usedCharCount; i++)
                        codeTable.Items.Add(((TreeNode)map_table[i]).ToolTipText + " >> " + ((TreeNode)map_table[i]).Name);

                    string result = string.Empty;
                    for (int i = 0; i < text.Length; i++)
                        result += search_char(text.Substring(i, 1));
                    return result;
                }
                else
                {
                    string result = string.Empty;
                    for (int i = 0, index = 0, len = 1; i < text.Length; i++)
                        search_binaryText(ref result, text.Substring(index, len), ref index, ref len);
                    
                    return result;
                }
            }
            return null;
        }

        private string search_char( string searchStr)
        {
            for (int i = 0; i < usedCharCount; i++)
                if (((TreeNode)map_table[i]).ToolTipText == searchStr)
                    return ((TreeNode)map_table[i]).Name;
            return null;

        }

        private void search_binaryText(ref string resultTxt, string text,ref int index,ref int len)
        {
            for (int i = 0; i < usedCharCount; i++)
                if (((TreeNode)map_table[i]).Name == text)
                {
                    index += len;
                    len = 1;
                    resultTxt+= ((TreeNode)map_table[i]).ToolTipText;
                    return;
                }
            len++;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show(e.Node.ToolTipText + " : " + e.Node.Name);
        }       

        private void inputRTxt_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "باز کردن فایل";
            openFileDialog.Filter = "فایل متنی (*.txt)|*.txt|انواع فایل ها (*.*)|*.*";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputRTxt.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
            catch
            {
                MessageBox.Show("خطا در خواندن فایل... نوع فایل یا سطح دسترسی به آنرا بررسی کنید.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void compressBtn_Click(object sender, EventArgs e)
        {
            compressedRTxt.Text = compression(inputRTxt.Text, Compression.Compress);
        }

        private void decompressBtn_Click(object sender, EventArgs e)
        {
            decompressedRTxt.Text = compression(compressedRTxt.Text, Compression.Decompress);
        }                

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                compressedRTxt.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.UnicodePlainText);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }        
    }
}