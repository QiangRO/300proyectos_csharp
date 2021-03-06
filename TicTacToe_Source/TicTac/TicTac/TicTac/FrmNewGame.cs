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
    public partial class FrmNewGame : Form
    {
        public FrmNewGame()
        {
            InitializeComponent();
        }

        private void exit_Game(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            FrmMain.blnWait4CompleteOK = false;
            FrmMain.strPlayer1Name = txtPlayer1Name.Text;
            FrmMain.strPlayer2Name = txtPlayer2Name.Text;
            classCPU._LEVEL_ = (byte ) numericUpDownLevel.Value;
        }

        private void rb_Checked_Changed(object sender, EventArgs e)
        {
            byte tmp;
            if (rbPvP.Checked)
            {
                txtPlayer1Name.Text = "Player1";
                txtPlayer2Name.Text = "Player2";
                tmp = 0;
                if (FrmMain._bWhoVsWho != tmp)
                {
                    FrmMain.iPlayersDrawCount= FrmMain.iPlayer1WinsCount = FrmMain.iPlayer2WinsCount = 0;
                    BlnPlayersChanged = true;
                }
                else
                {
                    BlnPlayersChanged = false;
                }
                FrmMain._bWhoVsWho = tmp ;
            }
            else if (rbPvC.Checked)
            {
                txtPlayer1Name.Text = "Player1";
                txtPlayer2Name.Text = "CPU";
                tmp = 1;
                if (FrmMain._bWhoVsWho != tmp)
                {
                    FrmMain.iPlayersDrawCount = FrmMain.iPlayer1WinsCount = FrmMain.iPlayer2WinsCount = 0;
                    BlnPlayersChanged = true;
                }
                else
                {
                    BlnPlayersChanged = false ;
                }
                FrmMain._bWhoVsWho = tmp;
            }
            else
            {
                txtPlayer1Name.Text = "CPU1";
                txtPlayer2Name.Text = "CPU2";
                tmp = 2;
                if (FrmMain._bWhoVsWho != tmp)
                {
                    FrmMain.iPlayersDrawCount = FrmMain.iPlayer1WinsCount = FrmMain.iPlayer2WinsCount = 0;
                    BlnPlayersChanged = true;
                }
                else
                {
                    BlnPlayersChanged = false ;
                }
                FrmMain._bWhoVsWho = tmp;
            }
            txtPlayer1Name.Focus();
            txtPlayer1Name.SelectAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmNewGame_Load(object sender, EventArgs e)
        {
            picPP1.Image = picPP2.Image = picPC1.Image = TicTacToe.Properties.Resources.PlayerFace;
            picPC2.Image = picCC1.Image = picCC2.Image = TicTacToe.Properties.Resources.CpuFace;
        }

        private void numericUpDownLevel_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownLevel.Value != 5)
            {
                rbPvP.Checked = true;
                rbPvC.Enabled = rbCvC.Enabled = false;
            }
            else
            {
                rbPvC.Enabled = rbCvC.Enabled = true ;
            }


        }

    }
}