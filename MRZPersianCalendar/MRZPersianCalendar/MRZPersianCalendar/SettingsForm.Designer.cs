namespace MRZPersianCalendar
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.topMostCheckBox = new System.Windows.Forms.CheckBox();
            this.startupCheckBox = new System.Windows.Forms.CheckBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.opacityTrackBar = new System.Windows.Forms.TrackBar();
            this.OpacityLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorLable = new System.Windows.Forms.Label();
            this.colorNameLable = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // topMostCheckBox
            // 
            this.topMostCheckBox.AutoSize = true;
            this.topMostCheckBox.Location = new System.Drawing.Point(12, 12);
            this.topMostCheckBox.Name = "topMostCheckBox";
            this.topMostCheckBox.Size = new System.Drawing.Size(92, 17);
            this.topMostCheckBox.TabIndex = 0;
            this.topMostCheckBox.Text = "Always on top";
            this.topMostCheckBox.UseVisualStyleBackColor = true;
            this.topMostCheckBox.CheckedChanged += new System.EventHandler(this.topMostCheckBox_CheckedChanged);
            // 
            // startupCheckBox
            // 
            this.startupCheckBox.AutoSize = true;
            this.startupCheckBox.Location = new System.Drawing.Point(12, 35);
            this.startupCheckBox.Name = "startupCheckBox";
            this.startupCheckBox.Size = new System.Drawing.Size(113, 17);
            this.startupCheckBox.TabIndex = 1;
            this.startupCheckBox.Text = "Set as startup item";
            this.startupCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(130, 131);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(51, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // opacityTrackBar
            // 
            this.opacityTrackBar.LargeChange = 1;
            this.opacityTrackBar.Location = new System.Drawing.Point(67, 63);
            this.opacityTrackBar.Minimum = 1;
            this.opacityTrackBar.Name = "opacityTrackBar";
            this.opacityTrackBar.Size = new System.Drawing.Size(104, 45);
            this.opacityTrackBar.TabIndex = 3;
            this.opacityTrackBar.Value = 1;
            this.opacityTrackBar.ValueChanged += new System.EventHandler(this.opacityTrackBar_ValueChanged);
            // 
            // OpacityLable
            // 
            this.OpacityLable.AutoSize = true;
            this.OpacityLable.Location = new System.Drawing.Point(9, 67);
            this.OpacityLable.Name = "OpacityLable";
            this.OpacityLable.Size = new System.Drawing.Size(52, 13);
            this.OpacityLable.TabIndex = 4;
            this.OpacityLable.Text = "Opacity ; ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Background color : ";
            // 
            // colorLable
            // 
            this.colorLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLable.Location = new System.Drawing.Point(107, 101);
            this.colorLable.Name = "colorLable";
            this.colorLable.Size = new System.Drawing.Size(25, 20);
            this.colorLable.TabIndex = 6;
            this.colorLable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorLable_MouseClick);
            // 
            // colorNameLable
            // 
            this.colorNameLable.AutoSize = true;
            this.colorNameLable.Location = new System.Drawing.Point(136, 104);
            this.colorNameLable.Name = "colorNameLable";
            this.colorNameLable.Size = new System.Drawing.Size(35, 13);
            this.colorNameLable.TabIndex = 7;
            this.colorNameLable.Text = "label3";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(74, 131);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(51, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SettingForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 159);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.colorNameLable);
            this.Controls.Add(this.colorLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpacityLable);
            this.Controls.Add(this.opacityTrackBar);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startupCheckBox);
            this.Controls.Add(this.topMostCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opacityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox topMostCheckBox;
        private System.Windows.Forms.CheckBox startupCheckBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TrackBar opacityTrackBar;
        private System.Windows.Forms.Label OpacityLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label colorLable;
        private System.Windows.Forms.Label colorNameLable;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button cancelButton;
    }
}