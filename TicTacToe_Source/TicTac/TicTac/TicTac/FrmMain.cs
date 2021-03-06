//////////////////////////////////
//				                //
//		   TicTacToe            //
//	         v1.0.3             //
//         everything		    //
//	         C0DED		        //
//    	       by		        //
//	        RED-C0DE		    //
//				                //
//				                //
//////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();

            // Two clicks will place two items.
            this.SetStyle(ControlStyles.StandardDoubleClick, false);

            // This will eliminate the flickering.
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

        }

//============================================================================

    #region Form Apearance :
        private void make_Board()
        {
            byte MAX = classCPU._MAX_;
            BOARDPanel.BackgroundImage= TicTacToe.Properties.Resources.Board;
            panelScores.BackgroundImage=TicTacToe.Properties.Resources.ScoreBoard;
            BOARDPanel.ResumeLayout(false );
            lblCells = new Label[MAX, MAX];
            int iLeft, iTop;
            iLeft =  14;
            iTop = 16;
            for (int i = 0; i < MAX; i++)
            {
                for (int j = 0; j < MAX; j++)
                {
                    lblCells[i,j] = new Label();
                    lblCells[i,j].BackColor = Color.Transparent  ;
                    lblCells[i, j].BorderStyle = BorderStyle.None;
                    lblCells[i,j].Size = new Size(25, 25);
                    lblCells[i, j].Font = new Font("tahoma", 6);
                    lblCells[i,j].Location = new Point(iLeft, iTop);
                    ////lblCells[i, j].Text = i.ToString() + "," + j.ToString();
                    lblCells[i, j].Tag = i.ToString() + "," + j.ToString();
                    BOARDPanel .Controls.Add(lblCells[i,j]);
                    lblCells[i, j].PerformLayout();
                    lblCells[i,j].BringToFront();
                    iLeft += 26;
                }
                iLeft = 14;
                iTop += 26;
            }
            blnArrPlayer1Selection = new bool[MAX, MAX];
            blnArrPlayer2Selection = new bool[MAX, MAX];
            BOARDPanel.ResumeLayout(true);
            BOARDPanel.PerformLayout();
        }
        private void board_ControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseClick += new MouseEventHandler(Control_MouseClick);
            e.Control.MouseMove += new MouseEventHandler(Control_MouseMove);
            e.Control.MouseLeave += new EventHandler(Control_MouseLeave);
        }
        private void mnuShowLastMove_Click(object sender, EventArgs e)
        {
            if (mnuShowLastMove.Checked)
            {
                chkShowLastMove.Checked = false;
                mnuShowLastMove.Checked = false;
            }
            else
            {
                mnuShowLastMove.Checked = true;
                chkShowLastMove.Checked = true;
            }
        }
        private void chkShowLastMove_CheckedChanged(object sender, EventArgs e)
        {
            if (strWhoIsWinner != "")
                return;
            if (chkShowLastMove.Checked)
            {
                mnuShowLastMove.Checked = true;
                if (strLastMove != "")
                    show_Last_Move(strLastMove);
            }
            else
            {
                mnuShowLastMove.Checked = false;
                if (strLastMove != "")
                    hide_Last_Move(strLastMove);
            }
        }
        private void reset_Table()
        {
            foreach (Label lbl in lblCells)
            {
                string strTag = lbl.Tag.ToString();
                string[] strArrTag = strTag.Split(',');
                int iTmp = strTag.IndexOf(',', strTag.Length - 2);
                if (strArrTag.Length == 3)
                    lbl.Tag = strTag.Substring(0, iTmp);
            }
        }
        private void about_Game(object sender, EventArgs e)
        {
            MessageBox.Show("//////TicTacToe v1.0.3 Coded by RED-C0DE\\\\\\\\");
        }
        private void exit_Game(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exit_Game(object sender, FormClosingEventArgs e)
        {
            if (blnForceExit)
            {
                return;
            }
            DialogResult result;
            if (strWhoIsWinner != "")
                result = MessageBox.Show("Exit the Game?", "Exit?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            else
                result = MessageBox.Show("R U sure to exit the Game?\nThe game is running.", "Exit?!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
        private void make_HighLight_5Cells(string[] str5Cells)
        {
            foreach (string str in str5Cells)
            {
                string[] strArr = str.Split(',');
                int iIndex1 = Convert.ToInt32(strArr[0]);
                int iIndex2 = Convert.ToInt32(strArr[1]);
                int iWhatPlayer = Convert.ToInt32(strArr[2]);
                if (iWhatPlayer == 1)
                    lblCells[iIndex1, iIndex2].Image = TicTacToe.Properties.Resources.CorssBarHighLight;
                else if (iWhatPlayer == 2)
                    lblCells[iIndex1, iIndex2].Image = TicTacToe.Properties.Resources.circleHighLight;
            }
        }
        private void initialize_New_Game(object sender, EventArgs e)
        {
            try
            {
                ICPU = new classCPU();
                frmNewGame = new FrmNewGame();
                rndTmp = new Random(DateTime.Now.Millisecond);
                sndAlarm = new System.Media.SoundPlayer(TicTacToe.Properties.Resources.TIMER);
                sndGameOver = new System.Media.SoundPlayer(TicTacToe.Properties.Resources.GAMEOVER);
                sndGameDraw = new System.Media.SoundPlayer(TicTacToe.Properties.Resources.GAMEDRAW);
                sndWin = new System.Media.SoundPlayer[4];
                sndWin[0] = new System.Media.SoundPlayer(TicTacToe.Properties.Resources.VOICE1);
                sndWin[1] = new System.Media.SoundPlayer(TicTacToe.Properties.Resources.VOICE2);
                sndWin[2] = new System.Media.SoundPlayer(TicTacToe.Properties.Resources.VOICE3);
                sndWin[3] = new System.Media.SoundPlayer(TicTacToe.Properties.Resources.VOICE4);

                axWindowsMediaPlayer1.URL = Application.StartupPath + "\\MUSICs\\Playlist1.m3u";

                if (!get_Players_Names())
                {
                    blnForceExit = true;
                    FormClosingEventArgs e2 = new FormClosingEventArgs(CloseReason.UserClosing, false);
                    Application.Exit(e2);
                }
                else
                {
                    make_Board();
                    //BoardControl BC = new BoardControl();
                    //this.BOARDPanel.Controls.Add(BC);
                    select_Random_Player();
                    reset_Varaiables_4_New_Game();
                    make_Tips();
                    timerKolli.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error <> : " + ex.Message);
            }
        }
        private void make_Tips()
        {
            string tmp1 = toolTip1.GetToolTip(lblPlayer1Timer);
            toolTip1.SetToolTip(lblPlayer1Timer,tmp1.Replace("%t", strPlayer1Name));
            tmp1 = toolTip1.GetToolTip(lblPlayer2Timer);
            toolTip1.SetToolTip(lblPlayer2Timer, tmp1.Replace("%t", strPlayer2Name));

            tmp1 = toolTip1.GetToolTip(listPlayer1);
            toolTip1.SetToolTip(listPlayer1, tmp1.Replace("%t", strPlayer1Name));
            tmp1 = toolTip1.GetToolTip(listPlayer2);
            toolTip1.SetToolTip(listPlayer2, tmp1.Replace("%t", strPlayer2Name));

            tmp1 = toolTip1.GetToolTip(lblPlayer1WinsCount);
            toolTip1.SetToolTip(lblPlayer1WinsCount, tmp1.Replace("%t", strPlayer1Name));
            tmp1 = toolTip1.GetToolTip(lblPlayer2WinsCount);
            toolTip1.SetToolTip(lblPlayer2WinsCount, tmp1.Replace("%t", strPlayer2Name));
        }
        DialogResult do_U_Want_New_Game()
        {
            return MessageBox.Show("New Game?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }
        private void new_Game(object sender, EventArgs e)
        {
            if (do_U_Want_New_Game() == DialogResult.Yes)
            {
                timerMoveCpu.Stop();
                stop_Timers_And_Reset_4_Finish();
                if (!get_Players_Names())
                    return;

                reset_Varaiables_4_New_Game();
                clear_Player_Selection();
                Application.DoEvents();
                lblPlayer1WinsCount.Text = iPlayer1WinsCount.ToString();
                lblPlayer2WinsCount.Text = iPlayer2WinsCount.ToString();
                lblDrawCount.Text = iPlayersDrawCount.ToString();
                select_Random_Player();
                timerKolli.Enabled = true;
                timerKolli.Start();
            }
            else
                mnuNewGame.Enabled = true;
        }
        private bool get_Players_Names()
        {//show NewGame Form & and get Players name & _WhoVsWho
            
            if (frmNewGame.ShowDialog(this) != DialogResult.OK)
            {
                mnuNewGame.Enabled = true;
                return false; 
            }

            if (_bWhoVsWho != 0 || strPlayer1Name=="" || strPlayer2Name=="")
            {
                if (get_Names_From_Local_Txt_File())
                {
                    if (strPlayer1Name == "" || strPlayer1Name == "CPU1")
                    {
                        strPlayer1Name = strArrNames[rndTmp.Next(0, strArrNames.Length)];
                    }
                    if (strPlayer2Name == "" || strPlayer2Name == "CPU" || strPlayer2Name == "CPU2")
                    {
                        strPlayer2Name = strArrNames[rndTmp.Next(0, strArrNames.Length)];
                    }
                }
                else
                {
                    if (strPlayer1Name == "" || strPlayer1Name == "CPU1")
                    {
                        strPlayer1Name = "Player 1";
                    }
                    if (strPlayer2Name == "" || strPlayer2Name == "CPU2")
                    {
                        strPlayer2Name = "Player 2";
                    }
                }
            }

            this.lblPlayer1Name.Text = this.lblPlayer1NameLog.Text = strPlayer1Name;
            this.lblPlayer2Name.Text = this.lblPlayer2NameLog.Text = strPlayer2Name;
            this.lblPlayer1NameLog.Text += " :";
            this.lblPlayer2NameLog.Text += " :";

            if (_bWhoVsWho != 2)//faghat vaghti k bazi-e CPU vs CPU hast New_Game ro enable kon 
                newGameMenu.Enabled = false;

            switch (_bWhoVsWho)
            {
                case 0:
                    {
                        picPlayer1.Image = picPlayer2.Image = TicTacToe.Properties.Resources.PlayerFace;
                        break;
                    }
                case 1:
                    {
                        picPlayer1.Image = TicTacToe.Properties.Resources.PlayerFace;
                        picPlayer2.Image = TicTacToe.Properties.Resources.CpuFace;
                        break;
                    }
                case 2:
                    {
                        picPlayer1.Image = picPlayer2.Image = TicTacToe.Properties.Resources.CpuFace;
                        break;
                    }
            }
            return true;
        }
        private bool get_Names_From_Local_Txt_File()
        {
            System.IO.StreamReader srNames;
            try
            {
                strArrNames = new string[0];
                string tmp;
                int index = 0;
                srNames= System.IO.File.OpenText(Application.StartupPath + "\\names.txt");

                while ((tmp=srNames.ReadLine())!=null)
                {
                    Array.Resize(ref strArrNames, ++index);
                    strArrNames[index-1]= tmp ;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Reading <get_Names> : " + ex.Message);
                return false;
                //throw;
            }
                
        }
        private void reset_Varaiables_4_New_Game()
        {
            if (_bWhoVsWho != 2)
                mnuNewGame.Enabled = false;
            else
                mnuNewGame.Enabled = true ;
            rndInterval = new Random(DateTime.Now.Millisecond*10);
            str5Cells = new string[classCPU._LEVEL_ ];
            iSeconds4TimerKolli=30;
            iSeconds4TimerPlayer1 = iSeconds4TimerPlayer2 = 60;
            iMinutes4TimerPlayer1 = iMinutes4TimerPlayer2 = 9;
            timerKolli.Interval = timerPlayer1.Interval = timerPlayer2.Interval = 1000;
            lblTimerKolli.Text = "30:00";
            lblPlayer1Timer.Text = lblPlayer2Timer.Text = "10:00";
            strLastMove = strWhoIsWinner = "";
            reset_Table();
            ICPU.Initialize_Table();
        }
        private void how2PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "این بازی بصورت 2 نفره، 1 نفره با کامپیوتر، و کامپیوتر با کامپیوتر (صرفا جهت تماشا و یادگیریِ نحوه بازی) قابل انجام است. هر بازیکن برای برنده شدن باید 5 مهره مخصوص خود را (مهره هر بازیکن کنار نام وی در کادر گوشه سمت راست بالای صفحه دیده می شود) در یک ردیف پشت سر هم قرار دهد. فرق نداره که این ردیف افقی باشه یا عمودی یا بصورت مورب. همچنین هر بازیکن برای فکر کردن و انجام هر حرکت 30 ثانیه زمان دارد که مسلما اگر در این وقت حرکت خود را انجام ندهد، بازنده خواهد بود... همچنین هر بازیکن 10 دقیقه برای کل حرکاتش زمان دارد که می تواند با سرعت عملی که در طی روند بازی می گیرد این زمانها را بی خیالی طی کند...****همچنین جهت یادگیری می توانید در صفحه "+ "\"بازی جدید\""+ " ، با انتخاب گزینه :\nCPU vs CPU \nبه تماشای بازی کامپیوتر بنشینید.در پایان از دوستان عزیزم در سایت برنامه نویس، که همیشه هنگام مشکلات فنی، راهنمایی های لازم را به من ارائه کرده اند تشکر و قدردانی می کنم\n\n++++++++++++C0DED+++++++++++++by+++++++++++RED-C0DE+++++++++++++";
            MessageBox.Show(msg , "How 2 Play?", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign );
        }
        private void clear_Selection_Highlight()
        {
            foreach (Label lbl in lblCells)
            {
                if (lbl.Image != null)
                    if (lbl.Image.Tag != null)
                        lbl.Image = null;
            }
        }
        private void make_Current_Player(int iPlayer)   //change Current Player 2 iPlayer
        {
            if (iPlayer == 1)
            {
                timerPlayer1.Start();
                timerPlayer2.Stop();
                if (_bWhoVsWho == 2)        //agar k "CPU vs CPU" hast bayad automatic tavassot-e CPU entekhab beshe
                {
                    BOARDPanel.UseWaitCursor = true;
                    timerMoveCpu.Start();
                }
                else
                    BOARDPanel.UseWaitCursor = false ;
                lblCurrent1.Visible = true;
                lblCurrent2.Visible = false;
                lblPlayer1Name.ForeColor = Color.Gold;
                lblPlayer1Timer.ForeColor = Color.Gold;
                lblPlayer1WinsCount.ForeColor = Color.Gold;
                lblPlayer2Name.ForeColor = Color.White;
                lblPlayer2Timer.ForeColor = Color.White;
                lblPlayer2WinsCount.ForeColor = Color.White;
            }
            else if (iPlayer == 2)
            {
                timerPlayer2.Start();
                timerPlayer1.Stop();
                if (_bWhoVsWho == 1 || _bWhoVsWho == 2)  //agar k "CPU vs Player || CPU vs CPU" hast bayad CPU Automatic entekhab kone:
                {
                    BOARDPanel.UseWaitCursor = true;
                    timerMoveCpu.Start();
                }
                else
                    BOARDPanel.UseWaitCursor = false;
                lblCurrent1.Visible = false;
                lblCurrent2.Visible = true;
                lblPlayer1Name.ForeColor = Color.White;
                lblPlayer1Timer.ForeColor = Color.White;
                lblPlayer1WinsCount.ForeColor = Color.White;
                lblPlayer2Name.ForeColor = Color.Gold;
                lblPlayer2Timer.ForeColor = Color.Gold;
                lblPlayer2WinsCount.ForeColor = Color.Gold;
            }
        }
        private void clear_Player_Selection()
        {
            foreach (Label lbl in lblCells)
            {
                lbl.BackColor = Color.Transparent;
                lbl.Image = null;
            }
            listPlayer1.Items.Clear();
            listPlayer2.Items.Clear();
            Array.Clear(blnArrPlayer1Selection, 0, blnArrPlayer1Selection.Length);
            Array.Clear(blnArrPlayer2Selection, 0, blnArrPlayer2Selection.Length);
        }
        private void select_Random_Player()
        {//b soorate Random (bedoone estefade az System.Random) 1 Player ro entekhab mikone ta harkat kone
            blnWait4CompleteOK = false ;
            int iMilliSec = DateTime.Now.Millisecond;
            if (iMilliSec <= 500)
            {
                blnFlagWhatPlayer = true;
                make_Current_Player(1);
                Application.DoEvents();
                MessageBox.Show(strPlayer1Name + " Must Play.");
                blnWait4CompleteOK = true ;
            }
            else
            {
                blnFlagWhatPlayer = false;
                make_Current_Player(2);
                Application.DoEvents();
                MessageBox.Show(strPlayer2Name + " Must Play.");
                blnWait4CompleteOK = true ;
            }
        }
        private void add_Player_Moving_2_ListBox(bool blnWhatPlayer, int iIndex1, int iIndex2)
        {
            if (blnWhatPlayer)
            {
                listPlayer1.Items.Add((listPlayer1.Items.Count+1).ToString()+ ":\t[" + iIndex1.ToString() + "," + iIndex2.ToString() + "]");
                listPlayer1.SelectedIndex = listPlayer1.Items.Count - 1;
            }
            else
            {
                listPlayer2.Items.Add((listPlayer2.Items.Count+1).ToString() + ":\t[" + iIndex1.ToString() + "," + iIndex2.ToString() + "]");
                listPlayer2.SelectedIndex = listPlayer2.Items.Count - 1;
            }
        }
        private void show_Last_Move(string strIndex)
        {
            try
            {
                string[] strArrIndex = strIndex.Split(',');
                if (strArrIndex.Length < 3)
                    return;
                int iIndex1 = Convert.ToInt32(strArrIndex[0]);
                int iIndex2 = Convert.ToInt32(strArrIndex[1]);
                int iWhatPlayer = Convert.ToInt32(strArrIndex[2]);

                if (iWhatPlayer == 1)
                {
                    lblCells[iIndex1, iIndex2].Image = TicTacToe.Properties.Resources.CorssBarHighLight;
                }
                else if (iWhatPlayer == 2)
                {
                    lblCells[iIndex1, iIndex2].Image = TicTacToe.Properties.Resources.circleHighLight;
                }
                strLastMove = strArrIndex[0] + ',' + strArrIndex[1] + ',' + strArrIndex[2];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error <show_Last_Move> : " + ex.Message);
            }
        }
        private void hide_Last_Move(string strIndex)
        {
            try
            {
                string[] strArrIndex = strIndex.Split(',');
                int iIndex1 = Convert.ToInt32(strArrIndex[0]);
                int iIndex2 = Convert.ToInt32(strArrIndex[1]);
                int iWhatPlayer = Convert.ToInt32(strArrIndex[2]);

                if (iWhatPlayer == 1)
                {
                    lblCells[iIndex1, iIndex2].Image = TicTacToe.Properties.Resources.CrossBar;
                }
                else if (iWhatPlayer == 2)
                {
                    lblCells[iIndex1, iIndex2].Image = TicTacToe.Properties.Resources.circle;
                }
                strLastMove = strArrIndex[0] + ',' + strArrIndex[1] + ',' + strArrIndex[2];
            }
            catch {}
        }
        private void reset_Timer_Kolli()
        {
            timerKolli.Enabled = false;
            timerKolli.Enabled = true;
            iSeconds4TimerKolli = 30;
            lblTimerKolli.Text = "30:00";
        }
    #endregion form apearance/

    #region Mouse Facts :
        void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (!blnWait4CompleteOK)
                return;
            
            //vaghti k Player click kone rooye 1 Cell bayad Index oon cell b do_Select_Cell() ferestade beshe :
            if (strWhoIsWinner == "" && _bWhoVsWho != 2)
            {
                //agar k in bazie "Player vs CPU" hast va alan nobate CPU hast nabayad Player betoone entekhab kone :
                if (_bWhoVsWho == 1 && !blnFlagWhatPlayer)
                    return;
                if (e.Button == MouseButtons.Left)
                {
                    Label lblTemp = (Label)sender;
                    string[] strIndex = lblTemp.Tag.ToString().Split(',');
                    byte bIndex1 = byte.Parse(strIndex[0]);
                    byte bIndex2 = byte.Parse(strIndex[1]);
                    //ok, alan ma Cell Indexes ro darim ,va bayad do_Select_Cell(bIndex1,bIndex2) :
                    do_Select_Cell(bIndex1, bIndex2);
                    Application.DoEvents();                    
                }
            }
        }
        void Control_MouseLeave(object sender, EventArgs e)
        {
            //agar k kasi barande shode ya alan 2 ta CPU daran bazi mikonan > Return :
            if (strWhoIsWinner != "" || _bWhoVsWho==2)
                return;
            Label lblTemp = (Label)sender;
            string[] strIndex = lblTemp.Tag.ToString().Split(',');
            int iIndex1 = Convert.ToInt32(strIndex[0]);
            int iIndex2 = Convert.ToInt32(strIndex[1]);
            if (blnArrPlayer2Selection[iIndex1, iIndex2] || blnArrPlayer1Selection[iIndex1, iIndex2]) 
                return ;
            lblCells[iIndex1, iIndex2].Image = null;
        }
        void Control_MouseMove(object sender, MouseEventArgs e)
        {
            //agar k kasi barande shode ya alan 2 ta CPU daran bazi mikonan > Return :
            if (strWhoIsWinner != "" || _bWhoVsWho==2)
                return ;
            Label lblTemp = (Label)sender;
            string[] strIndex = lblTemp.Tag.ToString().Split(',');
            byte bIndex1 = byte.Parse(strIndex[0]);
            byte bIndex2 = byte.Parse (strIndex[1]);
            //agar k por hast return :
            if (blnArrPlayer2Selection[bIndex1, bIndex2] || blnArrPlayer1Selection[bIndex1, bIndex2]) 
                return ;
            lblCells[bIndex1, bIndex2].Image = TicTacToe.Properties.Resources.CurrentHighLight;
            lblCells[bIndex1, bIndex2].Image.Tag = "1"; 
        }
#endregion mouse facts/
      
    #region Moving & Checking WINNER++++ :

        private bool check_Chap_2_Rast(int i, int j,bool blnArrPlayer1OR2)
        {             
            if (j > 12)
                return false ;
            else
                check_Chap_2_Rast(i, j + 1,blnArrPlayer1OR2 );

            if (blnArrPlayer1OR2)        //blnArrPlayer1OR2 = True => player1 else player2
                if (blnArrPlayer1Selection[i, j])
                {
                    if (index5Cells < classCPU._LEVEL_  && !Win)
                        str5Cells[index5Cells++] = lblCells[i, j].Tag.ToString();
                    sum++;
                    if (sum >= classCPU._LEVEL_)
                        Win = true;
                }
                else
                    sum = index5Cells = 0;

            else if (blnArrPlayer2Selection[i, j])
            {
                if (index5Cells < classCPU._LEVEL_ && !Win)
                    str5Cells[index5Cells++] = lblCells[i, j].Tag.ToString();
                sum++;
                if (sum >= classCPU._LEVEL_)
                    Win = true;
            }
            else
                sum = index5Cells = 0;

            if (Win)
                return true;
            else
                return false;
        }
        private bool check_Bala_2_Payin(int i, int j, bool blnArrPlayer1OR2)
        {
            if (i > 12)
                return false;
            else
                check_Bala_2_Payin(i + 1, j, blnArrPlayer1OR2);

            if (blnArrPlayer1OR2)        //blnArrPlayer1OR2 = True => player1 else player2
                if (blnArrPlayer1Selection[i, j])
                {
                    if (index5Cells < classCPU._LEVEL_ && !Win)
                        str5Cells[index5Cells++] = lblCells[i, j].Tag.ToString();
                    sum++;
                    if (sum >= classCPU._LEVEL_)
                        Win = true;
                }
                else
                    sum = index5Cells = 0;
            else if (blnArrPlayer2Selection[i, j])
            {
                if (index5Cells < classCPU._LEVEL_ && !Win)
                    str5Cells[index5Cells++] = lblCells[i, j].Tag.ToString();
                sum++;
                if (sum >= classCPU._LEVEL_)
                    Win = true;
            }
            else
                sum = index5Cells = 0;

            if (Win)
                return true;
            else
                return false;
        }
        private bool check_Ghotre_Asli(int i, int j, bool blnArrPlayer1OR2)
        {
            if ((i <= j && j > 12) || ((i > j && i > 12)))
                return false;
            else
                check_Ghotre_Asli(i + 1, j + 1, blnArrPlayer1OR2);

            if (blnArrPlayer1OR2)        //blnArrPlayer1OR2 = True => player1 else player2
                if (blnArrPlayer1Selection[i, j])
                {
                    if (index5Cells < classCPU._LEVEL_ && !Win)
                        str5Cells[index5Cells++] = lblCells[i, j].Tag.ToString();
                    sum++;
                    if (sum >= classCPU._LEVEL_)
                        Win = true;
                }
                else
                    sum = index5Cells = 0;

            else if (blnArrPlayer2Selection[i, j])
            {
                if (index5Cells < classCPU._LEVEL_ && !Win)
                    str5Cells[index5Cells++] = lblCells[i, j].Tag.ToString();
                sum++;
                if (sum >= classCPU._LEVEL_)
                    Win = true;
            }
            else
                sum = index5Cells = 0;

            if (Win)
                return true;
            else
                return false;
        }
        private bool check_Ghotre_Farei(int i, int j, bool blnArrPlayer1OR2)
        {
            if ((i > j && j < 0) || (i > j && i > 12))
                return false;
            else
                check_Ghotre_Farei(i + 1, j - 1, blnArrPlayer1OR2);

            if (blnArrPlayer1OR2)        //blnArrPlayer1OR2 = True => player1 else player2
                if (blnArrPlayer1Selection[i, j])
                {
                    if (index5Cells < classCPU._LEVEL_ && !Win)
                        str5Cells[index5Cells++] = lblCells[i, j].Tag.ToString();
                    sum++;
                    if (sum >= classCPU._LEVEL_)
                        Win = true;
                }
                else
                    sum = index5Cells = 0;
            else if (blnArrPlayer2Selection[i, j])
            {
                if (index5Cells < classCPU._LEVEL_ && !Win)
                    str5Cells[index5Cells++] = lblCells[i, j].Tag.ToString();
                sum++;
                if (sum >= classCPU._LEVEL_)
                    Win = true;
            }
            else
                sum = index5Cells = 0;              

            if (Win)
                return true;
            else
                return false;
        }
        //************:
        private bool check_Winner(bool blnWhatPlayer, int iIndex1, int iIndex2)
        {
            bool[] bln5Cells = new bool[classCPU._LEVEL_];

            int i = iIndex1; int j = iIndex2;   //baraye inke Indexha ro baraye Ghotre
            if (i < j)                          //Asli Temp konam
            { j = j - i; i = 0; }
            else if (i > j)
            { i = i - j; j = 0; }
            else
                i = j = 0;

            int i2 = iIndex1; int j2 = iIndex2;   //baraye inke Indexha ro baraye Ghotre
            if ((i2 + j2) >= 13)                  //Farei Temp konam
            {
                i2 = (i2 + j2) - 13 + 1;
                j2 = 13- 1;
            }
            else
            {
                j2 = (i2 + j2) - 0;
                i2 = 0;
            }

            strWhoIsWinner = "";
            Win = false; sum = 0; Array.Clear(str5Cells, 0, str5Cells.Length); index5Cells = 0;

            #region Player1
            if (!blnWhatPlayer)//PLAYER 1 :
            {
                if (check_Chap_2_Rast(iIndex1, 0, true))
                {
                    strWhoIsWinner = "Player1";
                    goto halt;
                }
                Win = false; sum = 0; Array.Clear(str5Cells, 0, str5Cells.Length); index5Cells = 0;
                if (check_Bala_2_Payin(0, iIndex2, true))
                {
                    strWhoIsWinner = "Player1";
                    goto halt;
                }
                Win = false; sum = 0; Array.Clear(str5Cells, 0, str5Cells.Length); index5Cells = 0;
                if (check_Ghotre_Asli(i, j, true))
                {
                    strWhoIsWinner = "Player1";
                    goto halt;
                }
                Win = false; sum = 0; Array.Clear(str5Cells, 0, str5Cells.Length); index5Cells = 0;
                if (check_Ghotre_Farei(i2, j2, true))
                {
                    strWhoIsWinner = "Player1";
                    goto halt;
                }
                //---
            }
            #endregion player1

            #region player2
            else//PLAYER 2 :
            {
                if (check_Chap_2_Rast(iIndex1, 0, false))
                {
                    strWhoIsWinner = "Player2";
                    goto halt;
                }
                Win = false; sum = 0; Array.Clear(str5Cells, 0, str5Cells.Length); index5Cells = 0;
                if (check_Bala_2_Payin(0, iIndex2, false))
                {
                    strWhoIsWinner = "Player2";
                    goto halt;
                }
                Win = false; sum = 0; Array.Clear(str5Cells, 0, str5Cells.Length); index5Cells = 0;
                if (check_Ghotre_Asli(i, j, false))
                {
                    strWhoIsWinner = "Player2";
                    goto halt;
                }
                Win = false; sum = 0; Array.Clear(str5Cells, 0, str5Cells.Length); index5Cells = 0;
                if (check_Ghotre_Farei(i2, j2, false))
                {
                    strWhoIsWinner = "Player2";
                    goto halt;
                }
            #endregion player2
            }

        halt:
            if (strWhoIsWinner != "")
            {
                hide_Last_Move(strLastMove);
                make_HighLight_5Cells(str5Cells);
                player_Is_Winner(strWhoIsWinner);
                return true;
            }
            return false;
        }//check Winner        
        private void timerKolli_Tick(object sender, EventArgs e)
        {
            ////timerKolli.Enabled = timerPlayer1.Enabled = timerPlayer2.Enabled = false;
            lblTimerKolli.Text ="00:"+ (--iSeconds4TimerKolli).ToString();
            if (iSeconds4TimerKolli <= 10)
            {
                play_Alarm();
            }

            if (iSeconds4TimerKolli <= 0)
            {
                if (blnFlagWhatPlayer)      //Player 1 Timeout => Player 2 is Winner
                {
                    strWhoIsWinner = "Player2";
                }
                else                        //Player 2 Timeout => Player 1 is Winner
                {
                    strWhoIsWinner = "Player1";
                }
                player_Is_Winner(strWhoIsWinner);
            }
        }
        private void timerPlayer1_Tick(object sender, EventArgs e)
        {
            --iSeconds4TimerPlayer1;
            if(iSeconds4TimerPlayer1.ToString().Length==1)
                lblPlayer1Timer.Text = iMinutes4TimerPlayer1.ToString() + ":0" + (iSeconds4TimerPlayer1.ToString());
            else
                lblPlayer1Timer.Text = iMinutes4TimerPlayer1.ToString() + ":" + (iSeconds4TimerPlayer1.ToString());

            if (iMinutes4TimerPlayer1 == 0 && iSeconds4TimerPlayer1 == 00)
            {
                //Player 1 Timeout & Player 2 is Winner :
                strWhoIsWinner = "Player2";
                player_Is_Winner(strWhoIsWinner );
            }
            if (iSeconds4TimerPlayer1 == 0)
            {
                iMinutes4TimerPlayer1--;
                iSeconds4TimerPlayer1 = 60;
            }
        }
        private void timerPlayer2_Tick(object sender, EventArgs e)
        {
            --iSeconds4TimerPlayer2;
            if(iSeconds4TimerPlayer2.ToString().Length==1)
                lblPlayer2Timer.Text = iMinutes4TimerPlayer2.ToString() + ":0" + (iSeconds4TimerPlayer2).ToString();
            else
                lblPlayer2Timer.Text = iMinutes4TimerPlayer2.ToString() + ":" + (iSeconds4TimerPlayer2.ToString());

            if (iMinutes4TimerPlayer2 == 0 && iSeconds4TimerPlayer2 == 00)
            {
                //Player 2 Timeout & Player 1 is Winner :
                strWhoIsWinner ="Player1";
                player_Is_Winner(strWhoIsWinner );
            }
            if (iSeconds4TimerPlayer2 == 0)
            {
                iMinutes4TimerPlayer2--;
                iSeconds4TimerPlayer2 = 60;
            }
        }
        private void timerMoveCpu_Tick(object sender, EventArgs e)
        {
            try
            {
                timerMoveCpu.Stop();  
                timerMoveCpu.Interval = rndInterval.Next(500, 5000);

                int bIndex1 = 0; int bIndex2 = 0;
                //Select Cell Max Priority :
                ICPU.CPU_Select_Max_Priority(ref bIndex1, ref bIndex2);
                if (bIndex1 == -99 && bIndex2 == -99)
                {
                    draw_The_Game();
                }
                else
                {
                    do_Select_Cell((byte)bIndex1, (byte)bIndex2);
                }
            }
            catch{}
        }
        private void stop_Timers_And_Reset_4_Finish()
        {
            timerKolli.Stop();
            timerPlayer1.Stop();
            timerPlayer2.Stop();
            timerMoveCpu.Stop();
            newGameMenu.Enabled = true;
            clear_Selection_Highlight();
            strLastMove = "";
        }
        private void player_Is_Winner(string strWhoIsWinner)
        {
            stop_Timers_And_Reset_4_Finish();
            if (strWhoIsWinner == "Player1")
            {
                lblPlayer1WinsCount.Text = (++iPlayer1WinsCount ).ToString();
                play_Ending_Sound(strWhoIsWinner );
                MessageBox.Show(strPlayer1Name + " is Winner with " + listPlayer1.Items.Count.ToString() + " choices.");
            }
            else if (strWhoIsWinner == "Player2")
            {
                lblPlayer2WinsCount.Text = (++iPlayer2WinsCount ).ToString();
                play_Ending_Sound(strWhoIsWinner);
                MessageBox.Show(strPlayer2Name + " is Winner with " + listPlayer2.Items.Count.ToString() + " choices.");
            }
            //start another game?
            new_Game(null, EventArgs.Empty);
        }
        private void play_Ending_Sound(string winner)
        {
            try
            {
                if (_bWhoVsWho == 1)
                {
                    if (winner == "Player1")
                    {
                        int iTmp = rndTmp.Next(0, 4);
                        sndWin[iTmp].Load();
                        Application.DoEvents();
                        //if (sndWin[iTmp].IsLoadCompleted)
                            sndWin[iTmp].Play();
                        Application.DoEvents();
                    }
                    else
                    {
                        sndGameOver.Load();
                        Application.DoEvents();
                        //if (sndGameDraw.IsLoadCompleted)
                            sndGameOver.Play();
                        Application.DoEvents();
                    }
                }
                else
                {
                    int iTmp = rndTmp.Next(0, 4);
                    sndWin[iTmp].Load();
                    Application.DoEvents();
                    sndWin[iTmp].Play();
                    Application.DoEvents();
                }
            }
            catch
            { }
        }
        private void play_Alarm()
        {
            sndAlarm.Play();
        }
        //************:
        private void do_Select_Cell(byte bIndex1,byte bIndex2)
        {
            //agar k kasi Winner shode bashe > return kon OR ||
            //if before in Cell entekhab shode bashe then exit :
            if (strWhoIsWinner != "" || blnArrPlayer1Selection[bIndex1, bIndex2] || blnArrPlayer2Selection[bIndex1, bIndex2]) 
                return;

            //Player 1  ||  CPU 
            if (blnFlagWhatPlayer)  //True = Player 1 >>> dar payan-e kar ham bayad beshe nobate Player 2(CPU)
            {
                lblCells[bIndex1, bIndex2].Image = TicTacToe.Properties.Resources.CrossBar;
                //yani in Cell ro Player 1 entekhab karde :
                blnArrPlayer1Selection[bIndex1, bIndex2] = true;
                lblCells[bIndex1, bIndex2].Tag += ",1";
                
                //yani beshe baraye dafaye bad, nobate Player2 (CPU)
                blnFlagWhatPlayer = !blnFlagWhatPlayer;

                //Inc++ Cells k ham-Masir hastan ba in cell entekhab shode tavassot-e Player1 :
                ICPU.CPU_Inc_Cells_Ham_Masir(bIndex1, bIndex2);
                //Dec-- PATHs k in Cell entekhab shode az tarafe Player1 dar anha mojood ast :
                ICPU.Dec_Paths_Priority_Contain_This_Cell(bIndex1, bIndex2);
                ICPU.CPU_Defence(bIndex1,bIndex2,true  );

                add_Player_Moving_2_ListBox(true, bIndex1, bIndex2);
                //check if player 1 is winner
                if (!check_Winner(false, bIndex1, bIndex2))//param1== False => Player1
                {
                    reset_Timer_Kolli();
                    if (strLastMove == "") strLastMove = lblCells[bIndex1, bIndex2].Tag.ToString();
                    hide_Last_Move(strLastMove);
                    strLastMove = lblCells[bIndex1, bIndex2].Tag.ToString();
                    make_Current_Player(2);
                }
            }
            else                    //False = Player 2 >>> hala bayad beshe nobate Player 1
            //Player 2
            {
                lblCells[bIndex1, bIndex2].Image = TicTacToe.Properties.Resources.circle;
                lblCells[bIndex1, bIndex2].Tag += ",2";
                blnFlagWhatPlayer = !blnFlagWhatPlayer;
                blnArrPlayer2Selection[bIndex1, bIndex2] = true;
                
                //HALA BAYAD in Celli k man (CPU) entekhab kardam
                //Priority khanehaye ham-Masir ba in ro 10 ta Dec-- konam :
                //Priority PATHs ham-Masir (in Cell dar in path-ha hast) ro ham afzayesh bedam :
                ICPU.CPU_Inc_Cells_Ham_Masir(bIndex1, bIndex2);
                ICPU.Inc_Paths_Priority_Contain_This_Cell(bIndex1, bIndex2);
                ICPU.CPU_Defence(bIndex1, bIndex2, false);

                add_Player_Moving_2_ListBox(false, bIndex1, bIndex2);
                //check if player 2 is winner
                if (!check_Winner(true, bIndex1, bIndex2))//param1== True => Player2
                {
                    reset_Timer_Kolli();
                    if (strLastMove == "") strLastMove = lblCells[bIndex1, bIndex2].Tag.ToString();
                    hide_Last_Move(strLastMove);
                    strLastMove = lblCells[bIndex1, bIndex2].Tag.ToString();
                    make_Current_Player(1);
                }
            }
            if (chkShowLastMove.Checked)
            {
                show_Last_Move(lblCells[bIndex1, bIndex2].Tag.ToString());
            }
        }
        private void draw_The_Game()
        {
            lblDrawCount.Text = (++iPlayersDrawCount).ToString();
            stop_Timers_And_Reset_4_Finish();
            sndGameDraw.Load();
            Application.DoEvents();
            sndGameDraw.Play();
            Application.DoEvents();
            MessageBox.Show(TicTacToe.Properties.Resources.strGameDraw);

            //start another game?
            new_Game(null, EventArgs.Empty);

        }

    #endregion moving & checking winner/
      

//============================================================================
    }
}