using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        regression reg;
        Form2 f1= new Form2();
        Panel PM, P1, P2;
        int tedad = 0;
        int state = -1;
        public Form1()
        {
            InitializeComponent();
        }

         private void timer1_Tick(object sender, EventArgs e)
        {
            if (state == 0)
            {
                float[] arr = new float[50]; int i;
                arr = reg.show_input();
                Input_list2.Items.Clear();
                for (i = 0; i < tedad; i++)
                {
                    Input_list2.Items.Add(System.Convert.ToString(arr[i]));
                }
                arr = reg.show_output();
                Output_list2.Items.Clear();
                for (i = 0; i < tedad; i++)
                {
                    Output_list2.Items.Add(System.Convert.ToString(arr[i]));
                }
                if (P_Edit.Visible == false)
                    state = 1;
                else
                    timer1.Enabled = false;
            }
            else if (state == 1)
            {
                if (timer1.Tag == "send")
                {
                    if (PM.Left > -172)
                    {
                        P1.Left += 5;
                        PM.Left -= 5;

                    }
                    else
                    {
                        timer1.Tag = "Back";
                        P2.Left = P1.Left;
                        P2.Top = P1.Top;
                        P1.Visible = false;
                        P2.Visible = true;
                    }
                }
                else
                {

                    if (PM.Left < 12)
                    {
                        PM.Left += 5;
                        P2.Left -= 5;
                    }
                    else
                    {
                        timer1.Enabled = false;
                        this.UseWaitCursor = false;
                    }
                }

            }/**/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float[] arr = new float[50]; int i;
            tedad = Output_list.Items.Count;
            for (i = 0; i < tedad; i++)
            {
                Output_list.SelectedIndex = i;
                arr[i] = System.Convert.ToSingle(Output_list.SelectedItem);
            }
            if (reg.get_Output(arr, tedad) == 0)
            {
                MessageBox.Show("Output array dont set.");
            }
            else
            {
                MessageBox.Show("Output array is set with Successfully.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            timer1.Tag = "send";
            state = 1;
            timer1.Enabled = true;
            panel1.Left = P_Menu.Left;
            panel1.Top = P_Menu.Top;
            panel1.Visible = true;
            PM = P_Menu;
            P1 = panel1;
            P2 = P_Send;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Interval = 3;
            P_Edit.Left = P_Menu.Left;
            P_Edit.Top = P_Menu.Top;
            button3.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            f1.Width = 700;
            f1.Height = 600;
            reg.draw(f1);
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.LightYellow;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.White;
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox3.Text != "")
            {
                Output_list.Items.Add(textBox3.Text);
                textBox3.Text = "";
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            this.textBox6.BackColor = Color.LightYellow;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            this.textBox6.BackColor = Color.White;
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox6.Text != "")
            {
                Input_list.Items.Add(textBox6.Text);
                textBox6.Text = "";
            }
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {
            Output_list.BackColor = Color.LightYellow;
        }

        private void listBox2_Enter(object sender, EventArgs e)
        {
            Input_list.BackColor = Color.LightYellow;
        }

        private void listBox2_Leave(object sender, EventArgs e)
        {
            Input_list.BackColor = Color.White;
        }

        private void listBox1_Leave(object sender, EventArgs e)
        {
            Output_list.BackColor = Color.White;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            float[] arr = new float[50]; int i;
            tedad = Input_list.Items.Count;
            for (i = 0; i < tedad; i++)
            {
                Input_list.SelectedIndex = i;
                arr[i] = System.Convert.ToSingle(Input_list.SelectedItem);
            }
            if (reg.get_Input(arr, tedad) == 0)
            {
                MessageBox.Show("Input array dont set.");
            }
            else
            {
                MessageBox.Show("Input array is set with Successfully.");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Input_list.Items.Clear();
            Output_list.Items.Clear();
        }

        private void Input_list_DoubleClick(object sender, EventArgs e)
        {
            if (Input_list.SelectedIndex != -1)
                Input_list.Items.RemoveAt(Input_list.SelectedIndex);
        }

        private void Output_list_DoubleClick(object sender, EventArgs e)
        {
            if (Output_list.SelectedIndex != -1)
                Output_list.Items.RemoveAt(Output_list.SelectedIndex);
        }
        private void Out_btn1_Click(object sender, EventArgs e)
        {
            reg.SetflagIO("o");
            if (Output_list2.SelectedIndex != -1)
            {
                int s = (int)Output_list2.SelectedIndex;
                reg[s]++;
            }
            else
                reg++;
            state = 0;
            timer1.Enabled = true;
        }

        private void Out_btn2_Click(object sender, EventArgs e)
        {
            reg.SetflagIO("o");
            if (Output_list2.SelectedIndex != -1)
            {
                int s = (int)Output_list2.SelectedIndex;
                reg[s]--;
            }
            else
                reg--;
            state = 0;
            timer1.Enabled = true;
        }

        private void Out_btn3_Click(object sender, EventArgs e)
        {
            if (Output_text.Text != "")
            {
                reg.SetflagIO("o");
                float number = float.Parse(Output_text.Text);
                if (Output_list2.SelectedIndex != -1)
                {
                    int s = (int)Output_list2.SelectedIndex;
                    reg[s] = reg[s] + number;
                }
                else
                    reg = reg + number;
            state = 0;
            timer1.Enabled = true;
            }
            else
                MessageBox.Show("TextBox is Empty.");
        }

        private void Out_btn4_Click(object sender, EventArgs e)
        {
            if (Output_text.Text != "")
            {
                reg.SetflagIO("o");
                float number = float.Parse(Output_text.Text);
                if (Output_list2.SelectedIndex != -1)
                {
                    int s = (int)Output_list2.SelectedIndex;
                    reg[s] = reg[s] - number;
                }
                else
                    reg = reg - number;
                state = 0;
                timer1.Enabled = true;
            }
            else
                MessageBox.Show("TextBox is Empty.");
        }

        private void In_btn3_Click(object sender, EventArgs e)
        {
            if (Input_text.Text != "")
            {
                reg.SetflagIO("i");
                float number = float.Parse(Input_text.Text);
                if (Input_list2.SelectedIndex != -1)
                {
                    int s = (int)Input_list2.SelectedIndex;
                    reg[s] = reg[s] + number;
                }
                else
                    reg = reg + number;
                state = 0;
                timer1.Enabled = true;
            }
            else
                MessageBox.Show("TextBox is Empty.");
        }

        private void In_btn4_Click(object sender, EventArgs e)
        {
            if (Input_text.Text != "")
            {
                reg.SetflagIO("i");
                float number = float.Parse(Input_text.Text);
                if (Input_list2.SelectedIndex != -1)
                {
                    int s = (int)Input_list2.SelectedIndex;
                    reg[s] = reg[s] - number;
                }
                else
                    reg = reg - number;
                state = 0;
                timer1.Enabled = true;
            }
            else
                MessageBox.Show("TextBox is Empty.");
        }

        private void In_btn1_Click(object sender, EventArgs e)
        {
            reg.SetflagIO("i");
            if (Input_list2.SelectedIndex != -1)
            {
                int s = (int)Input_list2.SelectedIndex;
                reg[s]++;
            }
            else
                reg++;
            state = 0;
            timer1.Enabled = true;
        }

        private void In_btn2_Click(object sender, EventArgs e)
        {
            reg.SetflagIO("i");
            if (Input_list2.SelectedIndex != -1)
            {
                int s = (int)Input_list2.SelectedIndex;
                reg[s]--;
            }
            else
                reg--;
            state = 0;
            timer1.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            timer1.Tag = "send";
            state = 0;
            timer1.Enabled = true;
            panel2.Left = P_Menu.Left;
            panel2.Top = P_Menu.Top;
            panel2.Visible = true;
            PM = P_Menu;
            P1 = panel2;
            P2 = P_Edit;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            lbl_linear.Text = reg.linear();
            lbl_quad.Text = reg.quadratic();
            timer1.Tag = "send";
            state = 1;
            timer1.Enabled = true;
            panel3.Left = P_Menu.Left;
            panel3.Top = P_Menu.Top;
            panel3.Visible = true;
            PM = P_Menu;
            P1 = panel3;
            P2 = P_Reg;
        }

        private void Input_list2_Enter(object sender, EventArgs e)
        {
            Input_list2.BackColor = Color.LightYellow;
        }

        private void Input_list2_Leave(object sender, EventArgs e)
        {
            Input_list2.BackColor = Color.White;
        }

        private void Output_list2_Enter(object sender, EventArgs e)
        {
            Output_list2.BackColor = Color.LightYellow;
        }

        private void Output_list2_Leave(object sender, EventArgs e)
        {
            Output_list2.BackColor = Color.White;
        }

        private void Input_text_Enter(object sender, EventArgs e)
        {
            Input_text.BackColor = Color.LightYellow;
        }

        private void Input_text_Leave(object sender, EventArgs e)
        {
            Input_text.BackColor = Color.White;
        }

        private void Output_text_Enter(object sender, EventArgs e)
        {
            Output_text.BackColor = Color.LightYellow;
        }

        private void Output_text_Leave(object sender, EventArgs e)
        {
            Output_text.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            P_Send.Visible = false;
            panel1.Top = P_Send.Top;
            panel1.Left = P_Send.Left;
        }
        private void button29_Click(object sender, EventArgs e)
        {
            P_Reg.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            P_Edit.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            reg=new regression();
            tedad = 0;
            button4.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button13.Enabled = true;
        }

        private void P_About_Click(object sender, EventArgs e)
        {
            P_About.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            P_About.Left = 40;
            P_About.Top = 38;
            P_About.Visible = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            P_Help.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            P_Help.Left = P_Menu.Left;
            P_Help.Top = P_Menu.Top;
            P_Help.Visible = true;
        }

    }
}