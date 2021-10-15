namespace MicrosoftOfficeChart11_Example
{
    partial class ChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChartSpace1 = new AxOWC11.AxChartSpace();
            this.ChartSpace2 = new AxOWC11.AxChartSpace();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ChartSpace3 = new AxOWC11.AxChartSpace();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSpace2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSpace3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 420);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChartSpace1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ChartSpace1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChartSpace2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ChartSpace2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChartSpace1
            // 
            this.ChartSpace1.DataSource = null;
            this.ChartSpace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartSpace1.Enabled = true;
            this.ChartSpace1.Location = new System.Drawing.Point(3, 3);
            this.ChartSpace1.Name = "ChartSpace1";
            this.ChartSpace1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ChartSpace1.OcxState")));
            this.ChartSpace1.Size = new System.Drawing.Size(539, 388);
            this.ChartSpace1.TabIndex = 1;
            // 
            // ChartSpace2
            // 
            this.ChartSpace2.DataSource = null;
            this.ChartSpace2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartSpace2.Enabled = true;
            this.ChartSpace2.Location = new System.Drawing.Point(3, 3);
            this.ChartSpace2.Name = "ChartSpace2";
            this.ChartSpace2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ChartSpace2.OcxState")));
            this.ChartSpace2.Size = new System.Drawing.Size(539, 388);
            this.ChartSpace2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ChartSpace3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(545, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ChartSpace3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ChartSpace3
            // 
            this.ChartSpace3.DataSource = null;
            this.ChartSpace3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartSpace3.Enabled = true;
            this.ChartSpace3.Location = new System.Drawing.Point(3, 3);
            this.ChartSpace3.Name = "ChartSpace3";
            this.ChartSpace3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ChartSpace3.OcxState")));
            this.ChartSpace3.Size = new System.Drawing.Size(539, 388);
            this.ChartSpace3.TabIndex = 2;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(553, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartSpace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSpace2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartSpace3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private AxOWC11.AxChartSpace ChartSpace1;
        private System.Windows.Forms.TabPage tabPage2;
        private AxOWC11.AxChartSpace ChartSpace2;
        private System.Windows.Forms.TabPage tabPage3;
        private AxOWC11.AxChartSpace ChartSpace3;
    }
}

