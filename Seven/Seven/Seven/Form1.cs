using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Seven
{
    public partial class Form1 : Form
    {
        ListView.ListViewItemCollection lst, board;
        int player;
        Random rand = new Random();
        int seven = 0;
        bool two = false;

        public Form1()
        {
            InitializeComponent();
            lst = new ListView.ListViewItemCollection(new ListView());
            board = new ListView.ListViewItemCollection(new ListView());
        }

        void Change_Player()
        {
            if (player == 1)
            {
                listView3.Visible = true;
                player = 2;
                pictureBox2.BackColor = Color.Silver;
                pictureBox3.BackColor = Color.Ivory;
            }
            else
            {
                listView3.Visible = false;
                player = 1;
                pictureBox2.BackColor = Color.Ivory;
                pictureBox3.BackColor = Color.Silver;
            }
        }

        bool Check_Win()
        {
            if (listView1.Items.Count == 0 || listView3.Items.Count == 0)
            {
                listView2.Items[0].ImageIndex = 3 + player;
                listView2.Items[0].Text = "Player " + player.ToString();
                label1.Text = "Count : " + lst.Count.ToString();
                label2.Text = "Count : " + listView1.Items.Count.ToString();
                label3.Text = "Count : " + listView3.Items.Count.ToString();
                if (MessageBox.Show("Player (" + player.ToString() + ") Wins" + (char)13 + "play again?", "Winner", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    Application.Restart();             
                return true;
            }
            return false;
        }

        void Show_Hint(string grp, string num)
        {
            bool is_hint = false;
            ListView list;
            if (player == 1)
                list = listView1;
            else
                list = listView3;
            for (int i = 0; i < list.Items.Count; i++)
                if (list.Items[i].Text == num || list.Items[i].Group.Header == grp)
                {
                    list.Items[i].ForeColor = Color.DeepSkyBlue;
                    is_hint = true;
                }
                else
                    list.Items[i].ForeColor = SystemColors.WindowText;
            if (!is_hint)
            {
                if (num == "7")
                    penalty(seven);
                else
                    penalty(seven = 1);
            }
            label1.Text = "Count : " + lst.Count.ToString();
            label2.Text = "Count : " + listView1.Items.Count.ToString();
            label3.Text = "Count : " + listView3.Items.Count.ToString();
        }

        void select(ListView ply)
        {
            int r;
            ListViewGroup grp;
            ListViewItem item;
            for (int i = 0; i < 10; i++)
            {
                r = rand.Next(0, lst.Count);
                item = lst[r];
                int index = (int)lst[r].Group.Header[0] - (int)'A';
                grp = ply.Groups[index];
                lst.Remove(item);
                item.Group = grp;
                ply.Items.Add(item);
            }
        }

        void penalty(int count)
        {
            ListViewGroup grp;
            ListViewItem item;
            if (lst.Count - count <= 0)
            {
                for (int i = 0; i < board.Count - 1; i++)
                {
                    item = board[i];
                    grp = board[i].Group;
                    board.Remove(item);
                    item.Group = grp;
                    lst.Add(item);
                }
                listBox1.Items.Clear();
                listBox1.Items.Add(listView2.Items[0].ToolTipText + " : " + listView2.Items[0].Text);
            }
            if (count == 1)
                pictureBox1.BackColor = Color.DeepSkyBlue;
            else
                pictureBox1.BackColor = Color.Red;
        }

        void manager(ListView list)
        {
            ListViewItem item = list.SelectedItems[0];
            ListViewGroup group = list.SelectedItems[0].Group;
            list.SelectedItems[0].Remove();
            if (two)
            {
                if (player == 1)
                {
                    int index = (int)group.Header[0] - (int)'A';
                    item.Group = listView3.Groups[index];
                    listView3.Items.Add(item);
                }
                else
                {
                    int index = (int)group.Header[0] - (int)'A';
                    item.Group = listView1.Groups[index];
                    listView1.Items.Add(item);
                }
                two = false;
                if (Check_Win())
                    return;
                Change_Player();
                Show_Hint(group.Header, item.Text);
            }
            else
            {
                item.Group = group;
                listView2.Items[0].ImageIndex = item.ImageIndex;
                listView2.Items[0].Text = item.Text;
                listView2.Items[0].ToolTipText = group.Header;
                listBox1.Items.Add(group.Header + " : " + item.Text);
                board.Add(item);
                if (Check_Win())
                    return;
                if (item.Text == "7")
                    seven += 2;
                if (item.Text == "1" || item.Text == "2" || item.Text == "7" || item.Text == "8" || item.Text == "10")
                    right(group.Header, item.Text);
                else
                {
                    Change_Player();
                    Show_Hint(group.Header, item.Text);
                }
            }
        }

        void right(string group, string item)
        {
            switch (item)
            {
                case "1":
                case "8":
                case "10":
                    MessageBox.Show("***** You have got a bonus. *****", "Bonus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Show_Hint(group, item);
                    break;
                case "2":
                    MessageBox.Show("##### Next player have a doom. #####", "Doom", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (player == 1)
                        for (int i = 0; i < listView1.Items.Count; i++)
                            listView1.Items[i].ForeColor = Color.DeepSkyBlue;
                    else
                        for (int i = 0; i < listView3.Items.Count; i++)
                            listView3.Items[i].ForeColor = Color.DeepSkyBlue;
                    two = true;
                    label1.Text = "Count : " + lst.Count.ToString();
                    label2.Text = "Count : " + listView1.Items.Count.ToString();
                    label3.Text = "Count : " + listView3.Items.Count.ToString();
                    break;
                case "7":
                    Change_Player();
                    Show_Hint("", "7");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView3.Items.Clear();
            for (int i = 0; i < 40; i++)
                lst.Add(new ListViewItem(
                    new string[] { ((i + 1) - (i / 10) * 10).ToString() }
                    , i / 10, Color.Empty, SystemColors.Window
                    , new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
                    , listView1.Groups[i / 10]));
            select(listView1);
            select(listView3);
            int r = rand.Next(0, lst.Count);
            ListViewItem item = lst[r];
            ListViewGroup group = lst[r].Group;
            listView2.Items[0].Text = lst[r].Text;
            listView2.Items[0].ImageIndex = lst[r].ImageIndex;
            listView2.Items[0].ToolTipText = lst[r].Group.Header;
            listBox1.Items.Add(group.Header + " : " + item.Text);
            lst.Remove(lst[r]);
            item.Group = group;
            board.Add(item);
            label1.Text = "Count : 19";
            label2.Text = "Count : 10";
            label3.Text = "Count : 10";
            player = rand.Next(1, 3);
            Change_Player();
            Show_Hint(listView2.Items[0].ToolTipText, listView2.Items[0].Text);
        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems[0].ForeColor == SystemColors.WindowText)
            {
                MessageBox.Show("Not Allowed !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            manager(((ListView)sender));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char ch = (char)(13);
            MessageBox.Show(ch + "Bahman Akbarzadeh" + ch + ch + "Kayvan Jamshidi" + ch + ch + "Hassan Farahnaki         ", "Productors ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == SystemColors.Control)
            {
                MessageBox.Show("Not Allowed !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int r;
            ListViewGroup grp;
            ListViewItem item;
            for (int i = 0; i < seven; i++)
            {
                r = rand.Next(0, lst.Count);
                item = lst[r];
                int index = (int)lst[r].Group.Header[0] - (int)'A';
                if (player == 1)
                {
                    grp = listView1.Groups[index];
                    lst.Remove(item);
                    item.Group = grp;
                    listView1.Items.Add(item);
                }
                else
                {
                    grp = listView3.Groups[index];
                    lst.Remove(item);
                    item.Group = grp;
                    listView3.Items.Add(item);
                }
            }
            seven = 0;
            pictureBox1.BackColor = SystemColors.Control;
            Change_Player();
            Show_Hint(listView2.Items[0].ToolTipText, listView2.Items[0].Text);
        }
    }
}