using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace n_Queens1
{
    public partial class MainFrm : Form
    {
        Solution Solution1 = new Solution();
        Variables Variables1 = new Variables();

        int[,] Queens = new int[10, 10];
        int PromisingOutput, Counter = 1,SolutionCounter = 0;
        int N = Variables.Table;
        int Flag;

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Form1 Frm = new Form1();
            Frm.Close();

            t00.Visible = false;
            t01.Visible = false;
            t02.Visible = false;
            t03.Visible = false;
            t04.Visible = false;
            t05.Visible = false;
            t06.Visible = false;
            t07.Visible = false;


            t10.Visible = false;
            t11.Visible = false;
            t12.Visible = false;
            t13.Visible = false;
            t14.Visible = false;
            t15.Visible = false;
            t16.Visible = false;
            t17.Visible = false;



            t20.Visible = false;
            t21.Visible = false;
            t22.Visible = false;
            t23.Visible = false;
            t24.Visible = false;
            t25.Visible = false;
            t26.Visible = false;
            t27.Visible = false;

            t30.Visible = false;
            t31.Visible = false;
            t32.Visible = false;
            t33.Visible = false;
            t34.Visible = false;
            t35.Visible = false;
            t36.Visible = false;
            t37.Visible = false;

            t40.Visible = false;
            t41.Visible = false;
            t42.Visible = false;
            t43.Visible = false;
            t44.Visible = false;
            t45.Visible = false;
            t46.Visible = false;
            t47.Visible = false;


            t50.Visible = false;
            t51.Visible = false;
            t52.Visible = false;
            t53.Visible = false;
            t54.Visible = false;
            t55.Visible = false;
            t56.Visible = false;
            t57.Visible = false;

            t60.Visible = false;
            t61.Visible = false;
            t62.Visible = false;
            t63.Visible = false;
            t64.Visible = false;
            t65.Visible = false;
            t66.Visible = false;
            t67.Visible = false;

            t70.Visible = false;
            t71.Visible = false;
            t72.Visible = false;
            t73.Visible = false;
            t74.Visible = false;
            t75.Visible = false;
            t76.Visible = false;
            t77.Visible = false;

            //------- Load 4 Queens Table ---------
            if (Variables.Table == 4)
            {
                panel1.Width = 169;
                panel1.Height = 167;

                //   panel1.Location.X = 233;
                //   panel1.Location.Y = 174;
                t00.Visible = true;
                t01.Visible = true;
                t02.Visible = true;
                t03.Visible = true;

                t10.Visible = true;
                t11.Visible = true;
                t12.Visible = true;
                t13.Visible = true;

                t20.Visible = true;
                t21.Visible = true;
                t22.Visible = true;
                t23.Visible = true;

                t30.Visible = true;
                t31.Visible = true;
                t32.Visible = true;
                t33.Visible = true;
            }
            //------------------------------------

            //------- Load 8 Queens Table ---------

            if (Variables.Table == 8)
            {
                panel1.Width = 333;
                panel1.Height = 336;

                t00.Visible = true;
                t01.Visible = true;
                t02.Visible = true;
                t03.Visible = true;
                t04.Visible = true;
                t05.Visible = true;
                t06.Visible = true;
                t07.Visible = true;

                t10.Visible = true;
                t11.Visible = true;
                t12.Visible = true;
                t13.Visible = true;
                t14.Visible = true;
                t15.Visible = true;
                t16.Visible = true;
                t17.Visible = true;

                t20.Visible = true;
                t21.Visible = true;
                t22.Visible = true;
                t23.Visible = true;
                t24.Visible = true;
                t25.Visible = true;
                t26.Visible = true;
                t27.Visible = true;

                t30.Visible = true;
                t31.Visible = true;
                t32.Visible = true;
                t33.Visible = true;
                t34.Visible = true;
                t35.Visible = true;
                t36.Visible = true;
                t37.Visible = true;

                t40.Visible = true;
                t41.Visible = true;
                t42.Visible = true;
                t43.Visible = true;
                t44.Visible = true;
                t45.Visible = true;
                t46.Visible = true;
                t47.Visible = true;

                t50.Visible = true;
                t51.Visible = true;
                t52.Visible = true;
                t53.Visible = true;
                t54.Visible = true;
                t55.Visible = true;
                t56.Visible = true;
                t57.Visible = true;

                t60.Visible = true;
                t61.Visible = true;
                t62.Visible = true;
                t63.Visible = true;
                t64.Visible = true;
                t65.Visible = true;
                t66.Visible = true;
                t67.Visible = true;

                t70.Visible = true;
                t71.Visible = true;
                t72.Visible = true;
                t73.Visible = true;
                t74.Visible = true;
                t75.Visible = true;
                t76.Visible = true;
                t77.Visible = true;
            }
            //-------------------------------------            





            //---- Comput All Node ----------
            double n = Variables.Table;
            double n1 = Variables.Table + 1;
            double Power = Math.Pow(n, n1);
            double Result = (Power - 1) / (n - 1);
            //-------------------------------



            //----- Comput All Good Nodes ----
            double Fact = n;
            double Sum = 1.0 + n;

            for (double i = n - 1; i >= 1; i--)
            {
                Fact *= i;
                Sum += Fact;
            }
            //--------------------------------



            //------- Result Of Computes -----
            label1.Text = "Page : " + Variables.Table.ToString();
            label2.Text = "All Type : " + (Variables.Table * Variables.Table).ToString();
            label4.Text = "Total Good Nodes : " + Sum.ToString();
            label3.Text = "Total Nodes : " + Result.ToString();
            //---------------------------------
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_Leave(object sender, EventArgs e)
        {
            t00.Visible = false;
            t01.Visible = false;
            t02.Visible = false;
            t03.Visible = false;

            t10.Visible = false;
            t11.Visible = false;
            t12.Visible = false;
            t13.Visible = false;

            t20.Visible = false;
            t21.Visible = false;
            t22.Visible = false;
            t23.Visible = false;

            t30.Visible = false;
            t31.Visible = false;
            t32.Visible = false;
            t33.Visible = false;

            t40.Visible = false;
            t41.Visible = false;
            t42.Visible = false;
            t43.Visible = false;

            t50.Visible = false;
            t51.Visible = false;
            t52.Visible = false;
            t53.Visible = false;

            t60.Visible = false;
            t61.Visible = false;
            t62.Visible = false;
            t63.Visible = false;

            t70.Visible = false;
            t71.Visible = false;
            t72.Visible = false;
            t73.Visible = false;
        }
        //===All Solutio=========
        int Solutions(int n)
        {

            return 1;
        }
        //===All Solutio=========


        private void button1_Click(object sender, EventArgs e)
        {
            Solution1.AllSolution(N); 
            
        }

        private void t00_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[0, 0] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t00.ForeColor = Color.Black;
                    t00.Text = "O";
                    Variables.CountError = 0;
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show ("You Have Solution Now")  ;

                }
                else
                {

                    t00.ForeColor = Color.Red;
                    t00.Text = "X";
                    Queens[0, 0] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear () ;

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[0, 0] = 1;
                t00.ForeColor = Color.Black;
                t00.Text = "O";
                Counter++;
            }
        }
        private void t01_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[0,1] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t01.ForeColor = Color.Black;
                    t01.Text = "O";
                    Variables.CountError = 0;
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t01.ForeColor = Color.Red;
                    t01.Text = "X";
                    Queens[0, 1] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                    }
                    //---------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[0, 1] = 1;
                t01.ForeColor = Color.Black;
                t01.Text = "O";
                Counter++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counter = 0;
            SolutionCounter = 0;
            Variables.CountError = 0; 
            label5.Text = "True"; 
        
            //-- Clear Tables ---------
            t00.Clear();
            t01.Clear();
            t02.Clear();
            t03.Clear();
            t04.Clear();
            t05.Clear();
            t06.Clear();
            t07.Clear();

            t10.Clear();
            t11.Clear();
            t12.Clear();
            t13.Clear();
            t14.Clear();
            t15.Clear();
            t16.Clear();
            t17.Clear();

            t20.Clear();
            t21.Clear();
            t22.Clear();
            t23.Clear();
            t24.Clear();
            t25.Clear();
            t26.Clear();
            t27.Clear();

            t30.Clear();
            t31.Clear();
            t32.Clear();
            t33.Clear();
            t34.Clear();
            t35.Clear();
            t36.Clear();
            t37.Clear();

            t40.Clear();
            t41.Clear();
            t42.Clear();
            t43.Clear();
            t44.Clear();
            t45.Clear();
            t46.Clear();
            t47.Clear();

            t50.Clear();
            t51.Clear();
            t52.Clear();
            t53.Clear();
            t54.Clear();
            t55.Clear();
            t56.Clear();
            t57.Clear();

            t60.Clear();
            t61.Clear();
            t62.Clear();
            t63.Clear();
            t64.Clear();
            t65.Clear();
            t66.Clear();
            t67.Clear();

            t70.Clear();
            t71.Clear();
            t72.Clear();
            t73.Clear();
            t74.Clear();
            t75.Clear();
            t76.Clear();
            t77.Clear();
            //---------------------------------
            //----- Set Null To Matris ---------
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                {
                    Queens[i, j] = 0;
                }
            //----------------------------------
            Counter = 1 ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void t02_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[0, 2] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t02.ForeColor = Color.Black;
                    t02.Text = "O";
                    Variables.CountError = 0;
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t02.ForeColor = Color.Red;
                    t02.Text = "X";
                    Queens[0, 2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[0, 2] = 1;
                t02.ForeColor = Color.Black;
                t02.Text = "O";
                Counter++;
                
            }
        }

        private void t03_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[0, 3] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t03.ForeColor = Color.Black;
                    t03.Text = "O";
                    Variables.CountError = 0;
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t03.ForeColor = Color.Red;
                    t03.Text = "X";
                    Queens[0, 3] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                    

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[0, 3] = 1;
                t03.ForeColor = Color.Black;
                t03.Text = "O";
                Counter++;

            }
        }

        private void t04_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[0, 4] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t04.ForeColor = Color.Black;
                    t04.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t04.ForeColor = Color.Red;
                    t04.Text = "X";
                    Queens[0, 4] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[0, 4] = 1;
                t04.ForeColor = Color.Black;
                t04.Text = "O";
                Counter++;
            }
        }

        private void t05_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[0, 5] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t05.ForeColor = Color.Black;
                    t05.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t05.ForeColor = Color.Red;
                    t05.Text = "X";
                    Queens[0, 5] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[0, 5] = 1;
                t05.ForeColor = Color.Black;
                t05.Text = "O";
                Counter++;
            }
        }

        private void t06_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[0, 6] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t06.ForeColor = Color.Black;
                    t06.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t06.ForeColor = Color.Red;
                    t06.Text = "X";
                    Queens[0, 6] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[0, 6] = 1;
                t06.ForeColor = Color.Black;
                t06.Text = "O";
                Counter++;
            }
        }

        private void t07_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[0, 7] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t07.ForeColor = Color.Black;
                    t07.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t07.ForeColor = Color.Red;
                    t07.Text = "X";
                    Queens[0, 7] = 0;


                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[0, 7] = 1;
                t07.ForeColor = Color.Black;
                t07.Text = "O";
                Counter++;
            }
        }

        private void t10_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[1, 0] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t10.ForeColor = Color.Black;
                    t10.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t10.ForeColor = Color.Red;
                    t10.Text = "X";
                    Queens[1, 0] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[1, 0] = 1;
                t10.ForeColor = Color.Black;
                t10.Text = "O";
                Counter++;
            }
        }

        private void t11_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[1, 1] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t11.ForeColor = Color.Black;
                    t11.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t11.ForeColor = Color.Red;
                    t11.Text = "X";
                    Queens[1, 1] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();  

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[1, 1] = 1;
                t11.ForeColor = Color.Black;
                t11.Text = "O";
                Counter++;
            }
        }

        private void t12_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[1, 2] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t12.ForeColor = Color.Black;
                    t12.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t12.ForeColor = Color.Red;
                    t12.Text = "X";
                    Queens[1, 2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[1, 2] = 1;
                t12.ForeColor = Color.Black;
                t12.Text = "O";
                Counter++;
            }
        }

        private void t13_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[1, 3] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t13.ForeColor = Color.Black;
                    t13.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t13.ForeColor = Color.Red;
                    t13.Text = "X";
                    Queens[1, 3] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[1, 3] = 1;
                t13.ForeColor = Color.Black;
                t13.Text = "O";
                Counter++;
            }
        }

        private void t14_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[1, 4] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t14.ForeColor = Color.Black;
                    t14.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t14.ForeColor = Color.Red;
                    t14.Text = "X";
                    Queens[1, 4] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[1, 4] = 1;
                t14.ForeColor = Color.Black;
                t14.Text = "O";
                Counter++;
            }
        }

        private void t15_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[1, 5] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t15.ForeColor = Color.Black;
                    t15.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t15.ForeColor = Color.Red;
                    t15.Text = "X";
                    Queens[1, 5] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[1, 5] = 1;
                t15.ForeColor = Color.Black;
                t15.Text = "O";
                Counter++;
            }
        }

        private void t16_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[1, 6] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t16.ForeColor = Color.Black;
                    t16.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t16.ForeColor = Color.Red;
                    t16.Text = "X";
                    Queens[1, 6] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[1, 6] = 1;
                t16.ForeColor = Color.Black;
                t16.Text = "O";
                Counter++;
            }
        }

        private void t17_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[1, 7] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t17.ForeColor = Color.Black;
                    t17.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t17.ForeColor = Color.Red;
                    t17.Text = "X";
                    Queens[1, 7] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[1, 7] = 1;
                t17.ForeColor = Color.Black;
                t17.Text = "O";
                Counter++;
            }
        }

        private void t20_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[2, 0] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t20.ForeColor = Color.Black;
                    t20.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t20.ForeColor = Color.Red;
                    t20.Text = "X";
                    Queens[2, 0] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear () ;

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[2, 0] = 1;
                t20.ForeColor = Color.Black;
                t20.Text = "O";
                Counter++;
            }

        }

        private void t21_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[2,1] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t21.ForeColor = Color.Black;
                    t21.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t21.ForeColor = Color.Red;
                    t21.Text = "X";
                    Queens[2,1] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[2,1] = 1;
                t21.ForeColor = Color.Black;
                t21.Text = "O";
                Counter++;
            }

        }

        private void t22_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[2,2] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t22.ForeColor = Color.Black;
                    t22.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t22.ForeColor = Color.Red;
                    t22.Text = "X";
                    Queens[2,2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[2,2] = 1;
                t22.ForeColor = Color.Black;
                t22.Text = "O";
                Counter++;
            }

        }

        private void t23_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[2,3] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t23.ForeColor = Color.Black;
                    t23.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t23.ForeColor = Color.Red;
                    t23.Text = "X";
                    Queens[2,3] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[2,3] = 1;
                t23.ForeColor = Color.Black;
                t23.Text = "O";
                Counter++;
            }

        }

        private void t24_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[2,4] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t24.ForeColor = Color.Black;
                    t24.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t24.ForeColor = Color.Red;
                    t24.Text = "X";
                    Queens[2,4] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[2,4] = 1;
                t24.ForeColor = Color.Black;
                t24.Text = "O";
                Counter++;
            }

        }

        private void t25_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[2,5] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t25.ForeColor = Color.Black;
                    t25.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t25.ForeColor = Color.Red;
                    t25.Text = "X";
                    Queens[2,5] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[2,5] = 1;
                t25.ForeColor = Color.Black;
                t25.Text = "O";
                Counter++;
            }

        }

        private void t26_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[2,6] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t26.ForeColor = Color.Black;
                    t26.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t26.ForeColor = Color.Red;
                    t26.Text = "X";
                    Queens[2,6] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[2,6] = 1;
                t26.ForeColor = Color.Black;
                t26.Text = "O";
                Counter++;
            }

        }

        private void t27_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[2,7] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t27.ForeColor = Color.Black;
                    t27.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t27.ForeColor = Color.Red;
                    t27.Text = "X";
                    Queens[2,7] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[2,7] = 1;
                t27.ForeColor = Color.Black;
                t27.Text = "O";
                Counter++;
            }

        }

        private void t30_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[3, 0] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t30.ForeColor = Color.Black;
                    t30.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t30.ForeColor = Color.Red;
                    t30.Text = "X";
                    Queens[3, 0] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[3,0] = 1;
                t30.ForeColor = Color.Black;
                t30.Text = "O";
                Counter++;
            }

        }

        private void t31_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[3,1] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t31.ForeColor = Color.Black;
                    t31.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t31.ForeColor = Color.Red;
                    t31.Text = "X";
                    Queens[3,1] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[3,1] = 1;
                t31.ForeColor = Color.Black;
                t31.Text = "O";
                Counter++;
            }
        }

        private void t32_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[3,2] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t32.ForeColor = Color.Black;
                    t32.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t32.ForeColor = Color.Red;
                    t32.Text = "X";
                    Queens[3,2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[3,2] = 1;
                t32.ForeColor = Color.Black;
                t32.Text = "O";
                Counter++;
            }
        }

        private void t33_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[3,3] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t33.ForeColor = Color.Black;
                    t33.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t33.ForeColor = Color.Red;
                    t33.Text = "X";
                    Queens[3,3] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[3,3] = 1;
                t33.ForeColor = Color.Black;
                t33.Text = "O";
                Counter++;
            }
        }

        private void t34_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[3,4] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t34.ForeColor = Color.Black;
                    t34.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t34.ForeColor = Color.Red;
                    t34.Text = "X";
                    Queens[3,4] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[3,4] = 1;
                t34.ForeColor = Color.Black;
                t34.Text = "O";
                Counter++;
            }
        }

        private void t35_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[3,5] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t35.ForeColor = Color.Black;
                    t35.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t35.ForeColor = Color.Red;
                    t35.Text = "X";
                    Queens[3,5] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[3,5] = 1;
                t35.ForeColor = Color.Black;
                t35.Text = "O";
                Counter++;
            }
        }

        private void t36_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[3,6] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t36.ForeColor = Color.Black;
                    t36.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t36.ForeColor = Color.Red;
                    t36.Text = "X";
                    Queens[3,6] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------
                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[3,6] = 1;
                t36.ForeColor = Color.Black;
                t36.Text = "O";
                Counter++;
            }
        }

        private void t37_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[3,7] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t37.ForeColor = Color.Black;
                    t37.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t37.ForeColor = Color.Red;
                    t37.Text = "X";
                    Queens[3,7] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[3,7] = 1;
                t37.ForeColor = Color.Black;
                t37.Text = "O";
                Counter++;
            }
        }

        private void t40_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[4,0] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t40.ForeColor = Color.Black;
                    t40.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t40.ForeColor = Color.Red;
                    t40.Text = "X";
                    Queens[4,0] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[4,0] = 1;
                t40.ForeColor = Color.Black;
                t40.Text = "O";
                Counter++;
            }
        }

        private void t41_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[4,1] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t41.ForeColor = Color.Black;
                    t41.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t41.ForeColor = Color.Red;
                    t41.Text = "X";
                    Queens[4,1] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[4,1] = 1;
                t41.ForeColor = Color.Black;
                t41.Text = "O";
                Counter++;
            }
        }

        private void t42_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[4,2] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t42.ForeColor = Color.Black;
                    t42.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t42.ForeColor = Color.Red;
                    t42.Text = "X";
                    Queens[4,2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[4,2] = 1;
                t42.ForeColor = Color.Black;
                t42.Text = "O";
                Counter++;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
            if (Flag  == 0)
            {
                listBox1.Visible = false;
                Flag = 1;
            }
        else
            {
                listBox1.Visible = true;
                Flag = 0;
            }

        }

        private void t43_Click(object sender, EventArgs e)
        {

            if (Counter > 1)
            {
                Queens[4,3] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t43.ForeColor = Color.Black;
                    t43.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t43.ForeColor = Color.Red;
                    t43.Text = "X";
                    Queens[4, 3] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0; 
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[4,3] = 1;
                t43.ForeColor = Color.Black;
                t43.Text = "O";
                Counter++;
            }

        }

        private void t44_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[4,4] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t44.ForeColor = Color.Black;
                    t44.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t44.ForeColor = Color.Red;
                    t44.Text = "X";
                    Queens[4,4] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0; 
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[4,4] = 1;
                t44.ForeColor = Color.Black;
                t44.Text = "O";
                Counter++;
            }

        }

        private void t45_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[4,5] = 1;
                if (Solution1.Promising(Queens,N) == 1)
                {
                    t45.ForeColor = Color.Black;
                    t45.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t45.ForeColor = Color.Red;
                    t45.Text = "X";
                    Queens[4,5] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[4,5] = 1;
                t45.ForeColor = Color.Black;
                t45.Text = "O";
                Counter++;
            }

        }

        private void t46_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[4,6] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t46.ForeColor = Color.Black;
                    t46.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");

                }
                else
                {
                    t46.ForeColor = Color.Red;
                    t46.Text = "X";
                    Queens[4,6] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[4,6] = 1;
                t46.ForeColor = Color.Black;
                t46.Text = "O";
                Counter++;
            }

        }

        private void t47_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[4,7] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t47.ForeColor = Color.Black;
                    t47.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t47.ForeColor = Color.Red;
                    t47.Text = "X";
                    Queens[4,7] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[4,7] = 1;
                t47.ForeColor = Color.Black;
                t47.Text = "O";
                Counter++;
            }

        }

        private void t50_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[5,0] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t50.ForeColor = Color.Black;
                    t50.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t50.ForeColor = Color.Red;
                    t50.Text = "X";
                    Queens[5,0] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[5,0] = 1;
                t50.ForeColor = Color.Black;
                t50.Text = "O";
                Counter++;
            }

        }

        private void t51_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[5,1] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t51.ForeColor = Color.Black;
                    t51.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t51.ForeColor = Color.Red;
                    t51.Text = "X";
                    Queens[5,1] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[5,1] = 1;
                t51.ForeColor = Color.Black;
                t51.Text = "O";
                Counter++;
            }
        }

        private void t52_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[5,2] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t52.ForeColor = Color.Black;
                    t52.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t52.ForeColor = Color.Red;
                    t52.Text = "X";
                    Queens[5,2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[5,2] = 1;
                t52.ForeColor = Color.Black;
                t52.Text = "O";
                Counter++;
            }
        }

        private void t53_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[5,3] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t53.ForeColor = Color.Black;
                    t53.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t53.ForeColor = Color.Red;
                    t53.Text = "X";
                    Queens[5,3] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[5,3] = 1;
                t53.ForeColor = Color.Black;
                t53.Text = "O";
                Counter++;
            }
        }

        private void t54_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[5,4] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t54.ForeColor = Color.Black;
                    t54.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t54.ForeColor = Color.Red;
                    t54.Text = "X";
                    Queens[5,4] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[5,4] = 1;
                t54.ForeColor = Color.Black;
                t54.Text = "O";
                Counter++;
            }
        }

        private void t55_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[5,5] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t55.ForeColor = Color.Black;
                    t55.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t55.ForeColor = Color.Red;
                    t55.Text = "X";
                    Queens[5,5] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[5,5] = 1;
                t55.ForeColor = Color.Black;
                t55.Text = "O";
                Counter++;
            }
        }

        private void t56_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[5,6] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t56.ForeColor = Color.Black;
                    t56.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t56.ForeColor = Color.Red;
                    t56.Text = "X";
                    Queens[5,6] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[5,6] = 1;
                t56.ForeColor = Color.Black;
                t56.Text = "O";
                Counter++;
            }
        }

        private void t57_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[5,7] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t57.ForeColor = Color.Black;
                    t57.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t57.ForeColor = Color.Red;
                    t57.Text = "X";
                    Queens[5,7] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[5,7] = 1;
                t57.ForeColor = Color.Black;
                t57.Text = "O";
                Counter++;
            }
        }

        private void t60_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[6,0] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t60.ForeColor = Color.Black;
                    t60.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t60.ForeColor = Color.Red;
                    t60.Text = "X";
                    Queens[6,0] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[6, 0] = 1;
                t60.ForeColor = Color.Black;
                t60.Text = "O";
                Counter++;
            }
        }

        private void t61_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[6,1] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t61.ForeColor = Color.Black;
                    t61.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t61.ForeColor = Color.Red;
                    t61.Text = "X";
                    Queens[6,1] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[6,1] = 1;
                t61.ForeColor = Color.Black;
                t61.Text = "O";
                Counter++;
            }
        }

        private void t62_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[6,2] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t62.ForeColor = Color.Black;
                    t62.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t62.ForeColor = Color.Red;
                    t62.Text = "X";
                    Queens[6,2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();  

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[6,2] = 1;
                t62.ForeColor = Color.Black;
                t62.Text = "O";
                Counter++;
            }
        }

        private void t63_Click(object sender, EventArgs e)
        {

            if (Counter > 1)
            {
                Queens[6,3] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t63.ForeColor = Color.Black;
                    t63.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t63.ForeColor = Color.Red;
                    t63.Text = "X";
                    Queens[6,3] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[6,3] = 1;
                t63.ForeColor = Color.Black;
                t63.Text = "O";
                Counter++;
            }

        }

        private void t64_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[6,4] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t64.ForeColor = Color.Black;
                    t64.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t64.ForeColor = Color.Red;
                    t64.Text = "X";
                    Queens[6,4] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[6,4] = 1;
                t64.ForeColor = Color.Black;
                t64.Text = "O";
                Counter++;
            }
        }

        private void t65_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[6,5] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t65.ForeColor = Color.Black;
                    t65.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t65.ForeColor = Color.Red;
                    t65.Text = "X";
                    Queens[6,5] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[6,5] = 1;
                t65.ForeColor = Color.Black;
                t65.Text = "O";
                Counter++;
            }
        }

        private void t66_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[6,6] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t66.ForeColor = Color.Black;
                    t66.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t66.ForeColor = Color.Red;
                    t66.Text = "X";
                    Queens[6, 2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[6,6] = 1;
                t66.ForeColor = Color.Black;
                t66.Text = "O";
                Counter++;
            }
        }

        private void t67_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[6,7] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t67.ForeColor = Color.Black;
                    t67.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t67.ForeColor = Color.Red;
                    t67.Text = "X";
                    Queens[6,7] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[6,7] = 1;
                t67.ForeColor = Color.Black;
                t67.Text = "O";
                Counter++;
            }
        }

        private void t70_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[7,0] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t70.ForeColor = Color.Black;
                    t70.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t70.ForeColor = Color.Red;
                    t70.Text = "X";
                    Queens[7,0] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[7,0] = 1;
                t70.ForeColor = Color.Black;
                t70.Text = "O";
                Counter++;
            }
        }

        private void t71_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[7,1] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t71.ForeColor = Color.Black;
                    t71.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t71.ForeColor = Color.Red;
                    t71.Text = "X";
                    Queens[7,1] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[7,1] = 1;
                t71.ForeColor = Color.Black;
                t71.Text = "O";
                Counter++;
            }
        }

        private void t72_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[7,2] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t72.ForeColor = Color.Black;
                    t72.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t72.ForeColor = Color.Red;
                    t72.Text = "X";
                    Queens[7,2] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[7,2] = 1;
                t72.ForeColor = Color.Black;
                t72.Text = "O";
                Counter++;
            }
        }

        private void t73_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[7,3] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t73.ForeColor = Color.Black;
                    t73.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t73.ForeColor = Color.Red;
                    t73.Text = "X";
                    Queens[7,3] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[7,3] = 1;
                t73.ForeColor = Color.Black;
                t73.Text = "O";
                Counter++;
            }
        }

        private void t74_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[7,4] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t74.ForeColor = Color.Black;
                    t74.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t74.ForeColor = Color.Red;
                    t74.Text = "X";
                    Queens[7,4] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[7,4] = 1;
                t74.ForeColor = Color.Black;
                t74.Text = "O";
                Counter++;
            }
        }

        private void t75_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[7,5] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t75.ForeColor = Color.Black;
                    t75.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t75.ForeColor = Color.Red;
                    t75.Text = "X";
                    Queens[7,5] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[7,5] = 1;
                t75.ForeColor = Color.Black;
                t75.Text = "O";
                Counter++;
            }
        }

        private void t76_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[7,6] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t76.ForeColor = Color.Black;
                    t76.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t76.ForeColor = Color.Red;
                    t76.Text = "X";
                    Queens[7,6] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[7,6] = 1;
                t76.ForeColor = Color.Black;
                t76.Text = "O";
                Counter++;
            }
        }

        private void t77_Click(object sender, EventArgs e)
        {
            if (Counter > 1)
            {
                Queens[7,7] = 1;
                if (Solution1.Promising(Queens, N) == 1)
                {
                    t77.ForeColor = Color.Black;
                    t77.Text = "O";
                    SolutionCounter++;
                    if (SolutionCounter == N)
                        MessageBox.Show("You Have Solution Now");
                }
                else
                {
                    t77.ForeColor = Color.Red;
                    t77.Text = "X";
                    Queens[7,7] = 0;

                    //------ Check Errors ------------
                    if (Variables.CountError > 0)
                    {
                        label5.Text = "You Have " + Variables.CountError.ToString() + " Error";
                        listBox1.Items.Clear();

                        for (int i = 1; i <= Variables.CountError; i++)
                        {
                            listBox1.Items.Add(Variables.Errors[i]);
                        }
                        Variables.CountError = 0;
                    }
                    //--------------------------------

                }
            }

            else
            {
                SolutionCounter++;
                if (SolutionCounter == N)
                    MessageBox.Show("You Have Solution Now");
                Queens[7,7] = 1;
                t77.ForeColor = Color.Black;
                t77.Text = "O";
                Counter++;
            }
        }

        private void t04_TextChanged(object sender, EventArgs e)
        {

        }


 
     }
}