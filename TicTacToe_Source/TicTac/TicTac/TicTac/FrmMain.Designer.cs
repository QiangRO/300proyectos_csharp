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
using System.Windows.Forms;
using System.Drawing;
namespace TicTacToe
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.listPlayer1 = new System.Windows.Forms.ListBox();
            this.listPlayer2 = new System.Windows.Forms.ListBox();
            this.lblPlayer1NameLog = new System.Windows.Forms.Label();
            this.lblPlayer2NameLog = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.how2PlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerKolli = new System.Windows.Forms.Timer(this.components);
            this.chkShowLastMove = new System.Windows.Forms.CheckBox();
            this.timerPlayer1 = new System.Windows.Forms.Timer(this.components);
            this.timerPlayer2 = new System.Windows.Forms.Timer(this.components);
            this.panelLogsAndLastMove = new System.Windows.Forms.Panel();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.panelScores = new System.Windows.Forms.Panel();
            this.lblDrawCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer2WinsCount = new System.Windows.Forms.Label();
            this.lblPlayer2Timer = new System.Windows.Forms.Label();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1WinsCount = new System.Windows.Forms.Label();
            this.lblPlayer1Timer = new System.Windows.Forms.Label();
            this.lblTimerKolli = new System.Windows.Forms.Label();
            this.lblCurrent2 = new System.Windows.Forms.Label();
            this.lblCurrent1 = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.BOARDPanel = new System.Windows.Forms.Panel();
            this.timerMoveCpu = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowLastMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExitGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuH2P = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelLogsAndLastMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.panelScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listPlayer1
            // 
            this.listPlayer1.BackColor = System.Drawing.Color.Black;
            this.listPlayer1.ForeColor = System.Drawing.Color.OliveDrab;
            this.listPlayer1.FormattingEnabled = true;
            this.listPlayer1.Location = new System.Drawing.Point(3, 81);
            this.listPlayer1.Name = "listPlayer1";
            this.listPlayer1.Size = new System.Drawing.Size(101, 160);
            this.listPlayer1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listPlayer1, "لیست حرکتهای انجام شده توسط\r\n%t");
            // 
            // listPlayer2
            // 
            this.listPlayer2.BackColor = System.Drawing.Color.Black;
            this.listPlayer2.ForeColor = System.Drawing.Color.OliveDrab;
            this.listPlayer2.FormattingEnabled = true;
            this.listPlayer2.Location = new System.Drawing.Point(113, 81);
            this.listPlayer2.Name = "listPlayer2";
            this.listPlayer2.Size = new System.Drawing.Size(101, 160);
            this.listPlayer2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listPlayer2, "لیست حرکتهای انجام شده توسط\r\n%t\r\n");
            // 
            // lblPlayer1NameLog
            // 
            this.lblPlayer1NameLog.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1NameLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayer1NameLog.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPlayer1NameLog.Location = new System.Drawing.Point(0, 60);
            this.lblPlayer1NameLog.Name = "lblPlayer1NameLog";
            this.lblPlayer1NameLog.Size = new System.Drawing.Size(107, 18);
            this.lblPlayer1NameLog.TabIndex = 1;
            this.lblPlayer1NameLog.Text = "Player 1 :";
            this.lblPlayer1NameLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayer2NameLog
            // 
            this.lblPlayer2NameLog.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2NameLog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayer2NameLog.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblPlayer2NameLog.Location = new System.Drawing.Point(110, 60);
            this.lblPlayer2NameLog.Name = "lblPlayer2NameLog";
            this.lblPlayer2NameLog.Size = new System.Drawing.Size(110, 18);
            this.lblPlayer2NameLog.TabIndex = 1;
            this.lblPlayer2NameLog.Text = "Player 2 :";
            this.lblPlayer2NameLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenu,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameMenu
            // 
            this.newGameMenu.Image = global::TicTacToe.Properties.Resources.Current;
            this.newGameMenu.Name = "newGameMenu";
            this.newGameMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newGameMenu.Size = new System.Drawing.Size(144, 22);
            this.newGameMenu.Text = "&New Game";
            this.newGameMenu.Click += new System.EventHandler(this.new_Game);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exit_Game);
            // 
            // how2PlayToolStripMenuItem
            // 
            this.how2PlayToolStripMenuItem.Name = "how2PlayToolStripMenuItem";
            this.how2PlayToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.how2PlayToolStripMenuItem.Text = "How 2 Play?";
            this.how2PlayToolStripMenuItem.Click += new System.EventHandler(this.how2PlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_Game);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(35, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // timerKolli
            // 
            this.timerKolli.Interval = 1000;
            this.timerKolli.Tick += new System.EventHandler(this.timerKolli_Tick);
            // 
            // chkShowLastMove
            // 
            this.chkShowLastMove.BackColor = System.Drawing.Color.Transparent;
            this.chkShowLastMove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.chkShowLastMove.ForeColor = System.Drawing.Color.White;
            this.chkShowLastMove.Location = new System.Drawing.Point(3, 26);
            this.chkShowLastMove.Name = "chkShowLastMove";
            this.chkShowLastMove.Size = new System.Drawing.Size(211, 22);
            this.chkShowLastMove.TabIndex = 6;
            this.chkShowLastMove.Text = "Show last move";
            this.toolTip1.SetToolTip(this.chkShowLastMove, "فعال کردن این گزینه باعث می شود، آخرین حرکت انجام شده مشخص شود");
            this.chkShowLastMove.UseVisualStyleBackColor = false;
            this.chkShowLastMove.CheckedChanged += new System.EventHandler(this.chkShowLastMove_CheckedChanged);
            // 
            // timerPlayer1
            // 
            this.timerPlayer1.Interval = 1000;
            this.timerPlayer1.Tick += new System.EventHandler(this.timerPlayer1_Tick);
            // 
            // timerPlayer2
            // 
            this.timerPlayer2.Interval = 1000;
            this.timerPlayer2.Tick += new System.EventHandler(this.timerPlayer2_Tick);
            // 
            // panelLogsAndLastMove
            // 
            this.panelLogsAndLastMove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogsAndLastMove.BackColor = System.Drawing.Color.Transparent;
            this.panelLogsAndLastMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogsAndLastMove.Controls.Add(this.chkShowLastMove);
            this.panelLogsAndLastMove.Controls.Add(this.listPlayer1);
            this.panelLogsAndLastMove.Controls.Add(this.lblPlayer1NameLog);
            this.panelLogsAndLastMove.Controls.Add(this.listPlayer2);
            this.panelLogsAndLastMove.Controls.Add(this.lblPlayer2NameLog);
            this.panelLogsAndLastMove.Location = new System.Drawing.Point(412, 164);
            this.panelLogsAndLastMove.Name = "panelLogsAndLastMove";
            this.panelLogsAndLastMove.Size = new System.Drawing.Size(216, 244);
            this.panelLogsAndLastMove.TabIndex = 7;
            // 
            // picPlayer2
            // 
            this.picPlayer2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPlayer2.Location = new System.Drawing.Point(13, 79);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(14, 17);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer2.TabIndex = 8;
            this.picPlayer2.TabStop = false;
            // 
            // panelScores
            // 
            this.panelScores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelScores.BackColor = System.Drawing.Color.Transparent;
            this.panelScores.BackgroundImage = global::TicTacToe.Properties.Resources.ScoreBoard;
            this.panelScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelScores.Controls.Add(this.lblDrawCount);
            this.panelScores.Controls.Add(this.label2);
            this.panelScores.Controls.Add(this.picPlayer2);
            this.panelScores.Controls.Add(this.lblPlayer2WinsCount);
            this.panelScores.Controls.Add(this.lblPlayer2Timer);
            this.panelScores.Controls.Add(this.picPlayer1);
            this.panelScores.Controls.Add(this.lblPlayer1WinsCount);
            this.panelScores.Controls.Add(this.lblPlayer1Timer);
            this.panelScores.Controls.Add(this.lblTimerKolli);
            this.panelScores.Controls.Add(this.lblCurrent2);
            this.panelScores.Controls.Add(this.lblCurrent1);
            this.panelScores.Controls.Add(this.lblPlayer2Name);
            this.panelScores.Controls.Add(this.lblPlayer1Name);
            this.panelScores.Location = new System.Drawing.Point(399, 30);
            this.panelScores.Name = "panelScores";
            this.panelScores.Size = new System.Drawing.Size(234, 129);
            this.panelScores.TabIndex = 5;
            // 
            // lblDrawCount
            // 
            this.lblDrawCount.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawCount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDrawCount.ForeColor = System.Drawing.Color.White;
            this.lblDrawCount.Location = new System.Drawing.Point(56, 12);
            this.lblDrawCount.Name = "lblDrawCount";
            this.lblDrawCount.Size = new System.Drawing.Size(27, 14);
            this.lblDrawCount.TabIndex = 9;
            this.lblDrawCount.Text = "0";
            this.lblDrawCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblDrawCount, "تعداد تساویهای بین 2 بازیکن");
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Draw :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayer2WinsCount
            // 
            this.lblPlayer2WinsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2WinsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayer2WinsCount.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2WinsCount.Location = new System.Drawing.Point(80, 89);
            this.lblPlayer2WinsCount.Name = "lblPlayer2WinsCount";
            this.lblPlayer2WinsCount.Size = new System.Drawing.Size(39, 13);
            this.lblPlayer2WinsCount.TabIndex = 2;
            this.lblPlayer2WinsCount.Text = "0";
            this.lblPlayer2WinsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblPlayer2WinsCount, "تعداد پیروزیهای \r\n%t\r\n");
            // 
            // lblPlayer2Timer
            // 
            this.lblPlayer2Timer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Timer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayer2Timer.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Timer.Location = new System.Drawing.Point(161, 81);
            this.lblPlayer2Timer.Name = "lblPlayer2Timer";
            this.lblPlayer2Timer.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer2Timer.TabIndex = 2;
            this.lblPlayer2Timer.Text = "10:00";
            this.lblPlayer2Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblPlayer2Timer, "زمان سنج کلی برای\r\n%t\r\nاگر این زمان سنج 0 شود بازی را باخته اید");
            // 
            // picPlayer1
            // 
            this.picPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPlayer1.Location = new System.Drawing.Point(13, 41);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(14, 18);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1.TabIndex = 8;
            this.picPlayer1.TabStop = false;
            // 
            // lblPlayer1WinsCount
            // 
            this.lblPlayer1WinsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1WinsCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayer1WinsCount.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayer1WinsCount.Location = new System.Drawing.Point(80, 51);
            this.lblPlayer1WinsCount.Name = "lblPlayer1WinsCount";
            this.lblPlayer1WinsCount.Size = new System.Drawing.Size(39, 13);
            this.lblPlayer1WinsCount.TabIndex = 2;
            this.lblPlayer1WinsCount.Text = "0";
            this.lblPlayer1WinsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblPlayer1WinsCount, "تعداد پیروزیهای \r\n%t");
            // 
            // lblPlayer1Timer
            // 
            this.lblPlayer1Timer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Timer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayer1Timer.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayer1Timer.Location = new System.Drawing.Point(161, 41);
            this.lblPlayer1Timer.Name = "lblPlayer1Timer";
            this.lblPlayer1Timer.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer1Timer.TabIndex = 2;
            this.lblPlayer1Timer.Text = "10:00";
            this.lblPlayer1Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblPlayer1Timer, "زمان سنج کلی برای\r\n%t\r\nاگر این زمان سنج 0 شود بازی را باخته اید");
            // 
            // lblTimerKolli
            // 
            this.lblTimerKolli.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerKolli.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimerKolli.ForeColor = System.Drawing.Color.Orange;
            this.lblTimerKolli.Location = new System.Drawing.Point(161, 10);
            this.lblTimerKolli.Name = "lblTimerKolli";
            this.lblTimerKolli.Size = new System.Drawing.Size(53, 13);
            this.lblTimerKolli.TabIndex = 2;
            this.lblTimerKolli.Text = "30:00";
            this.lblTimerKolli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblTimerKolli, "زمان سنج برای حرکت هر بازیکن. هر بازیکن 30 ثانیه برای انجام هر حرکت خود فرصت دارد" +
                    ".اگر این زمان سنج هنگام حرکت یک بازیکن 0 شود، بازی را باخته است");
            // 
            // lblCurrent2
            // 
            this.lblCurrent2.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent2.Image = global::TicTacToe.Properties.Resources.currentCircleHighLight;
            this.lblCurrent2.Location = new System.Drawing.Point(30, 72);
            this.lblCurrent2.Name = "lblCurrent2";
            this.lblCurrent2.Size = new System.Drawing.Size(30, 29);
            this.lblCurrent2.TabIndex = 1;
            this.lblCurrent2.Visible = false;
            // 
            // lblCurrent1
            // 
            this.lblCurrent1.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent1.Image = global::TicTacToe.Properties.Resources.currentCrossBarHighLight;
            this.lblCurrent1.Location = new System.Drawing.Point(28, 33);
            this.lblCurrent1.Name = "lblCurrent1";
            this.lblCurrent1.Size = new System.Drawing.Size(31, 30);
            this.lblCurrent1.TabIndex = 1;
            this.lblCurrent1.Visible = false;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Name.Location = new System.Drawing.Point(66, 71);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(100, 18);
            this.lblPlayer2Name.TabIndex = 1;
            this.lblPlayer2Name.Text = "Player 2 :";
            this.lblPlayer2Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.Gold;
            this.lblPlayer1Name.Location = new System.Drawing.Point(66, 33);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(100, 18);
            this.lblPlayer1Name.TabIndex = 1;
            this.lblPlayer1Name.Text = "Player 1 :";
            this.lblPlayer1Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BOARDPanel
            // 
            this.BOARDPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BOARDPanel.BackColor = System.Drawing.Color.Transparent;
            this.BOARDPanel.Location = new System.Drawing.Point(8, 38);
            this.BOARDPanel.Name = "BOARDPanel";
            this.BOARDPanel.Size = new System.Drawing.Size(368, 368);
            this.BOARDPanel.TabIndex = 0;
            this.BOARDPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.board_ControlAdded);
            // 
            // timerMoveCpu
            // 
            this.timerMoveCpu.Interval = 1500;
            this.timerMoveCpu.Tick += new System.EventHandler(this.timerMoveCpu_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.LightCyan;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "TicTacToe:";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuH2P,
            this.mnuAbout});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(653, 24);
            this.MainMenu.TabIndex = 10;
            this.MainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.mnuShowLastMove,
            this.toolStripSeparator1,
            this.mnuExitGame});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Image = global::TicTacToe.Properties.Resources.Current;
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.mnuNewGame.Size = new System.Drawing.Size(168, 22);
            this.mnuNewGame.Text = "&New Game";
            this.mnuNewGame.Click += new System.EventHandler(this.new_Game);
            // 
            // mnuShowLastMove
            // 
            this.mnuShowLastMove.BackColor = System.Drawing.SystemColors.Control;
            this.mnuShowLastMove.Name = "mnuShowLastMove";
            this.mnuShowLastMove.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.mnuShowLastMove.Size = new System.Drawing.Size(168, 22);
            this.mnuShowLastMove.Text = "&Show last move";
            this.mnuShowLastMove.Click += new System.EventHandler(this.mnuShowLastMove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuExitGame
            // 
            this.mnuExitGame.BackColor = System.Drawing.SystemColors.Control;
            this.mnuExitGame.Name = "mnuExitGame";
            this.mnuExitGame.Size = new System.Drawing.Size(168, 22);
            this.mnuExitGame.Text = "E&xit";
            this.mnuExitGame.Click += new System.EventHandler(this.exit_Game);
            // 
            // mnuH2P
            // 
            this.mnuH2P.Name = "mnuH2P";
            this.mnuH2P.Size = new System.Drawing.Size(77, 20);
            this.mnuH2P.Text = "How 2 Play?";
            this.mnuH2P.Click += new System.EventHandler(this.how2PlayToolStripMenuItem_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(48, 20);
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.about_Game);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 410);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(653, 34);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(653, 444);
            this.Controls.Add(this.panelScores);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panelLogsAndLastMove);
            this.Controls.Add(this.BOARDPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe                              by                                RED-C0DE" +
                "";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exit_Game);
            this.Load += new System.EventHandler(this.initialize_New_Game);
            this.panelLogsAndLastMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.panelScores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        

        #region Decs:
        ICpu ICPU ;
        System.Random rndInterval;
        public static bool blnForceExit;
        public static byte _bWhoVsWho;
        public static int iPlayer1WinsCount;
        public static int iPlayer2WinsCount;
        public static int iPlayersDrawCount;
        public static int index5Cells = 0;
        public static string[] str5Cells ;
        public static int sum = 0;
        public static bool Win = false;
        private System.Windows.Forms.Panel BOARDPanel;
        public static Label[,] lblCells;
        public static bool blnWait4CompleteOK;
        public static bool blnFlagWhatPlayer;
        public static bool[,] blnArrPlayer1Selection;
        public static bool[,] blnArrPlayer2Selection;
        int iSeconds4TimerKolli;
        string strWhoIsWinner = "";
        string strLastMove = "";
        int iSeconds4TimerPlayer1;
        int iMinutes4TimerPlayer1;
        int iSeconds4TimerPlayer2;
        int iMinutes4TimerPlayer2;
        private string[] strArrNames;
        public static string strPlayer1Name;
        public static string strPlayer2Name;       
        private Label lblPlayer1Name;
        private Label lblPlayer2Name;
        private ListBox listPlayer1;
        private ListBox listPlayer2;
        private Label lblPlayer1NameLog;
        private Label lblPlayer2NameLog;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panelScores;
        private Label lblCurrent1;
        private Label lblCurrent2;
        private Label lblTimerKolli;
        private Label lblPlayer2Timer;
        private Label lblPlayer1Timer;
        private Label lblPlayer2WinsCount;
        private Label lblPlayer1WinsCount;
        private Timer timerKolli;
        private CheckBox chkShowLastMove;
        private Timer timerPlayer1;
        private Timer timerPlayer2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newGameMenu;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panelLogsAndLastMove;
        private System.Media.SoundPlayer sndAlarm;
        private System.Media.SoundPlayer sndGameOver;
        private System.Media.SoundPlayer sndGameDraw;
        private System.Random rndTmp;
        private System.Media.SoundPlayer[] sndWin;
        private FrmNewGame frmNewGame;
        private ToolStripMenuItem how2PlayToolStripMenuItem;
        private Timer timerMoveCpu;
        private ToolTip toolTip1;
        private PictureBox picPlayer2;
        private PictureBox picPlayer1;
        private Label lblDrawCount;
        private Label label2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MenuStrip MainMenu;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNewGame;
        private ToolStripMenuItem mnuShowLastMove;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuExitGame;
        private ToolStripMenuItem mnuH2P;
        private ToolStripMenuItem mnuAbout;
        #endregion decs/


    }
}

