namespace HuffmanAlgorithm
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.compressBtn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.codeTable = new System.Windows.Forms.ListBox();
            this.decompressBtn = new System.Windows.Forms.Button();
            this.inputRTxt = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.compressedRTxt = new System.Windows.Forms.RichTextBox();
            this.decompressedRTxt = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // compressBtn
            // 
            this.compressBtn.Location = new System.Drawing.Point(11, 165);
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Size = new System.Drawing.Size(378, 23);
            this.compressBtn.TabIndex = 1;
            this.compressBtn.Text = "فشرده سازی";
            this.compressBtn.UseVisualStyleBackColor = true;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Location = new System.Drawing.Point(395, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(270, 510);
            this.treeView1.TabIndex = 3;
            this.treeView1.TabStop = false;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // codeTable
            // 
            this.codeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.codeTable.FormattingEnabled = true;
            this.codeTable.HorizontalScrollbar = true;
            this.codeTable.Location = new System.Drawing.Point(671, 12);
            this.codeTable.Name = "codeTable";
            this.codeTable.Size = new System.Drawing.Size(170, 511);
            this.codeTable.TabIndex = 6;
            this.codeTable.TabStop = false;
            // 
            // decompressBtn
            // 
            this.decompressBtn.Location = new System.Drawing.Point(11, 347);
            this.decompressBtn.Name = "decompressBtn";
            this.decompressBtn.Size = new System.Drawing.Size(378, 23);
            this.decompressBtn.TabIndex = 3;
            this.decompressBtn.Text = "نا هم فشرده سازی";
            this.decompressBtn.UseVisualStyleBackColor = true;
            this.decompressBtn.Click += new System.EventHandler(this.decompressBtn_Click);
            // 
            // inputRTxt
            // 
            this.inputRTxt.BackColor = System.Drawing.SystemColors.Control;
            this.inputRTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputRTxt.ContextMenuStrip = this.contextMenuStrip1;
            this.inputRTxt.Location = new System.Drawing.Point(11, 12);
            this.inputRTxt.Name = "inputRTxt";
            this.inputRTxt.Size = new System.Drawing.Size(378, 147);
            this.inputRTxt.TabIndex = 0;
            this.inputRTxt.Text = "مصطفی بی تا";
            this.inputRTxt.DoubleClick += new System.EventHandler(this.inputRTxt_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.saveBtn,
            this.toolStripMenuItem1,
            this.resetBtn,
            this.toolStripMenuItem2,
            this.exitBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 104);
            // 
            // openBtn
            // 
            this.openBtn.Name = "openBtn";
            this.openBtn.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.openBtn.Size = new System.Drawing.Size(166, 22);
            this.openBtn.Text = "خواندن فایل";
            this.openBtn.Click += new System.EventHandler(this.inputRTxt_DoubleClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveBtn.Size = new System.Drawing.Size(166, 22);
            this.saveBtn.Text = "ذخیره متن";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 6);
            // 
            // resetBtn
            // 
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.resetBtn.Size = new System.Drawing.Size(166, 22);
            this.resetBtn.Text = "ریست فرم";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(163, 6);
            // 
            // exitBtn
            // 
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitBtn.Size = new System.Drawing.Size(166, 22);
            this.exitBtn.Text = "خروج";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // compressedRTxt
            // 
            this.compressedRTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.compressedRTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compressedRTxt.Location = new System.Drawing.Point(11, 194);
            this.compressedRTxt.Name = "compressedRTxt";
            this.compressedRTxt.ReadOnly = true;
            this.compressedRTxt.Size = new System.Drawing.Size(378, 147);
            this.compressedRTxt.TabIndex = 2;
            this.compressedRTxt.Text = "";
            // 
            // decompressedRTxt
            // 
            this.decompressedRTxt.BackColor = System.Drawing.SystemColors.Control;
            this.decompressedRTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decompressedRTxt.Location = new System.Drawing.Point(11, 376);
            this.decompressedRTxt.Name = "decompressedRTxt";
            this.decompressedRTxt.ReadOnly = true;
            this.decompressedRTxt.Size = new System.Drawing.Size(378, 146);
            this.decompressedRTxt.TabIndex = 4;
            this.decompressedRTxt.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 533);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.inputRTxt);
            this.Controls.Add(this.decompressedRTxt);
            this.Controls.Add(this.decompressBtn);
            this.Controls.Add(this.compressedRTxt);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.compressBtn);
            this.Controls.Add(this.codeTable);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button compressBtn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox codeTable;
        private System.Windows.Forms.Button decompressBtn;
        private System.Windows.Forms.RichTextBox inputRTxt;
        private System.Windows.Forms.RichTextBox compressedRTxt;
        private System.Windows.Forms.RichTextBox decompressedRTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openBtn;
        private System.Windows.Forms.ToolStripMenuItem resetBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        private System.Windows.Forms.ToolStripMenuItem saveBtn;
    }
}

