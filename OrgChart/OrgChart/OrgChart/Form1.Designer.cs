namespace OrgChart
{
    partial class Form1
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
            dotnetCHARTING.WinForms.Annotation annotation1 = new dotnetCHARTING.WinForms.Annotation();
            this.button1 = new System.Windows.Forms.Button();
            this.Chart1 = new dotnetCHARTING.WinForms.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(998, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chart1
            // 
            this.Chart1.Background.Color = System.Drawing.Color.White;
            annotation1.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            annotation1.DynamicSize = true;
            annotation1.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            annotation1.InteriorLine.Visible = true;
            annotation1.Line.Color = System.Drawing.Color.Gray;
            annotation1.Line.Visible = true;
            annotation1.Orientation = dotnetCHARTING.WinForms.Orientation.TopRight;
            annotation1.Shadow.Visible = false;
            annotation1.Size = new System.Drawing.Size(230, 198);
            annotation1.Visible = true;
            this.Chart1.Box = annotation1;
            this.Chart1.ChartArea.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.Chart1.ChartArea.CornerTopLeft = dotnetCHARTING.WinForms.BoxCorner.Square;
            this.Chart1.ChartArea.DefaultElement.DefaultSubValue.Line.Color = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(28)))), ((int)(((byte)(59)))));
            this.Chart1.ChartArea.DefaultElement.DefaultSubValue.Line.Visible = true;
            this.Chart1.ChartArea.DefaultElement.DefaultSubValue.Visible = true;
            this.Chart1.ChartArea.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.Chart1.ChartArea.DefaultElement.LegendEntry.DividerLine.Visible = true;
            this.Chart1.ChartArea.DefaultElement.Outline.Visible = true;
            this.Chart1.ChartArea.InteriorLine.Color = System.Drawing.Color.LightGray;
            this.Chart1.ChartArea.InteriorLine.Visible = true;
            this.Chart1.ChartArea.Label.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Chart1.ChartArea.LegendBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.Chart1.ChartArea.LegendBox.CornerBottomRight = dotnetCHARTING.WinForms.BoxCorner.Cut;
            this.Chart1.ChartArea.LegendBox.DefaultEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.Chart1.ChartArea.LegendBox.DefaultEntry.DividerLine.Visible = true;
            this.Chart1.ChartArea.LegendBox.HeaderEntry.DividerLine.Color = System.Drawing.Color.Gray;
            this.Chart1.ChartArea.LegendBox.HeaderEntry.DividerLine.Visible = true;
            this.Chart1.ChartArea.LegendBox.HeaderEntry.Name = "Name";
            this.Chart1.ChartArea.LegendBox.HeaderEntry.SortOrder = -1;
            this.Chart1.ChartArea.LegendBox.HeaderEntry.Value = "Value";
            this.Chart1.ChartArea.LegendBox.HeaderEntry.Visible = false;
            this.Chart1.ChartArea.LegendBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.ChartArea.LegendBox.InteriorLine.Visible = true;
            this.Chart1.ChartArea.LegendBox.Line.Color = System.Drawing.Color.Gray;
            this.Chart1.ChartArea.LegendBox.Line.Visible = true;
            this.Chart1.ChartArea.LegendBox.Padding = 4;
            this.Chart1.ChartArea.LegendBox.Position = dotnetCHARTING.WinForms.LegendBoxPosition.Top;
            this.Chart1.ChartArea.LegendBox.Visible = true;
            this.Chart1.ChartArea.Line.Color = System.Drawing.Color.Gray;
            this.Chart1.ChartArea.Line.Visible = true;
            this.Chart1.ChartArea.StartDateOfYear = new System.DateTime(((long)(0)));
            this.Chart1.ChartArea.TitleBox.Background.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.Chart1.ChartArea.TitleBox.InteriorLine.Color = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Chart1.ChartArea.TitleBox.InteriorLine.Visible = true;
            this.Chart1.ChartArea.TitleBox.Label.Color = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(45)))), ((int)(((byte)(38)))));
            this.Chart1.ChartArea.TitleBox.Label.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Chart1.ChartArea.TitleBox.Line.Color = System.Drawing.Color.Gray;
            this.Chart1.ChartArea.TitleBox.Line.Visible = true;
            this.Chart1.ChartArea.TitleBox.Visible = true;
            this.Chart1.ChartArea.XAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.Chart1.ChartArea.XAxis.DefaultTick.GridLine.Visible = true;
            this.Chart1.ChartArea.XAxis.DefaultTick.Line.Length = 3;
            this.Chart1.ChartArea.XAxis.DefaultTick.Line.Visible = true;
            this.Chart1.ChartArea.XAxis.MinorTimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.Chart1.ChartArea.XAxis.TickLabelSeparatorLine.Visible = true;
            this.Chart1.ChartArea.XAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.Chart1.ChartArea.XAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.Chart1.ChartArea.XAxis.ZeroTick.GridLine.Visible = true;
            this.Chart1.ChartArea.XAxis.ZeroTick.Line.Length = 3;
            this.Chart1.ChartArea.XAxis.ZeroTick.Line.Visible = true;
            this.Chart1.ChartArea.YAxis.DefaultTick.GridLine.Color = System.Drawing.Color.LightGray;
            this.Chart1.ChartArea.YAxis.DefaultTick.GridLine.Visible = true;
            this.Chart1.ChartArea.YAxis.DefaultTick.Line.Length = 3;
            this.Chart1.ChartArea.YAxis.DefaultTick.Line.Visible = true;
            this.Chart1.ChartArea.YAxis.TickLabelSeparatorLine.Visible = true;
            this.Chart1.ChartArea.YAxis.TimeIntervalAdvanced.Start = new System.DateTime(((long)(0)));
            this.Chart1.ChartArea.YAxis.ZeroTick.GridLine.Color = System.Drawing.Color.Red;
            this.Chart1.ChartArea.YAxis.ZeroTick.GridLine.Visible = true;
            this.Chart1.ChartArea.YAxis.ZeroTick.Line.Length = 3;
            this.Chart1.ChartArea.YAxis.ZeroTick.Line.Visible = true;
            this.Chart1.DataGrid = null;
            this.Chart1.DefaultElement.DefaultSubValue.Line.Visible = true;
            this.Chart1.DefaultElement.DefaultSubValue.Visible = true;
            this.Chart1.DefaultElement.LegendEntry.DividerLine.Color = System.Drawing.Color.Empty;
            this.Chart1.DefaultElement.LegendEntry.DividerLine.Visible = true;
            this.Chart1.DefaultElement.Outline.Visible = true;
            this.Chart1.Location = new System.Drawing.Point(12, 12);
            this.Chart1.Name = "Chart1";
            this.Chart1.NoDataLabel.Text = "No Data";
            this.Chart1.ObjectChart = null;
            this.Chart1.Size = new System.Drawing.Size(44, 38);
            this.Chart1.SmartLabelLine.Visible = true;
            this.Chart1.StartDateOfYear = new System.DateTime(((long)(0)));
            this.Chart1.TabIndex = 2;
            this.Chart1.TempDirectory = "C:\\Documents and Settings\\kia\\Local Settings\\Temp\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 604);
            this.Controls.Add(this.Chart1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private dotnetCHARTING.WinForms.Chart Chart1;
    }
}

