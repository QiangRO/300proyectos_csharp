<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckBoxSample
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckBoxSample))
        Me.BrowseButton = New System.Windows.Forms.Button
        Me.TxtPath = New System.Windows.Forms.TextBox
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog
        Me.SS = New System.Windows.Forms.StatusStrip
        Me.EventsLoger = New System.Windows.Forms.ToolStripStatusLabel
        Me.Sep1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.TSPBar = New System.Windows.Forms.ToolStripProgressBar
        Me.Sep2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.FileFolder = New System.Windows.Forms.ToolStripStatusLabel
        Me.Sep3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.FLP = New System.Windows.Forms.FlowLayoutPanel
        Me.SS.SuspendLayout()
        Me.SuspendLayout()
        '
        'BrowseButton
        '
        Me.BrowseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseButton.Location = New System.Drawing.Point(548, 10)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(110, 23)
        Me.BrowseButton.TabIndex = 1
        Me.BrowseButton.Text = "Browse..."
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'TxtPath
        '
        Me.TxtPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPath.Location = New System.Drawing.Point(12, 12)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(530, 20)
        Me.TxtPath.TabIndex = 2
        '
        'FBD
        '
        Me.FBD.Description = "Select a Picture Folder:"
        Me.FBD.ShowNewFolderButton = False
        '
        'SS
        '
        Me.SS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EventsLoger, Me.Sep1, Me.TSPBar, Me.Sep2, Me.FileFolder, Me.Sep3})
        Me.SS.Location = New System.Drawing.Point(0, 462)
        Me.SS.Name = "SS"
        Me.SS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.SS.Size = New System.Drawing.Size(669, 22)
        Me.SS.SizingGrip = False
        Me.SS.TabIndex = 3
        Me.SS.Text = "StatusStrip1"
        '
        'EventsLoger
        '
        Me.EventsLoger.AutoSize = False
        Me.EventsLoger.BackColor = System.Drawing.SystemColors.Control
        Me.EventsLoger.Name = "EventsLoger"
        Me.EventsLoger.Size = New System.Drawing.Size(200, 17)
        Me.EventsLoger.Text = "Ready For Action!"
        Me.EventsLoger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sep1
        '
        Me.Sep1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Sep1.Name = "Sep1"
        Me.Sep1.Size = New System.Drawing.Size(10, 17)
        Me.Sep1.Text = "|"
        '
        'TSPBar
        '
        Me.TSPBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSPBar.AutoSize = False
        Me.TSPBar.Maximum = 1000
        Me.TSPBar.Name = "TSPBar"
        Me.TSPBar.Size = New System.Drawing.Size(200, 16)
        Me.TSPBar.Step = 1
        Me.TSPBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'Sep2
        '
        Me.Sep2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Sep2.Name = "Sep2"
        Me.Sep2.Size = New System.Drawing.Size(10, 17)
        Me.Sep2.Text = "|"
        '
        'FileFolder
        '
        Me.FileFolder.Name = "FileFolder"
        Me.FileFolder.Size = New System.Drawing.Size(12, 17)
        Me.FileFolder.Text = "?"
        '
        'Sep3
        '
        Me.Sep3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Sep3.Name = "Sep3"
        Me.Sep3.Size = New System.Drawing.Size(10, 17)
        Me.Sep3.Text = "|"
        '
        'FLP
        '
        Me.FLP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FLP.AutoScroll = True
        Me.FLP.BackColor = System.Drawing.Color.Transparent
        Me.FLP.Location = New System.Drawing.Point(12, 41)
        Me.FLP.Name = "FLP"
        Me.FLP.Size = New System.Drawing.Size(645, 418)
        Me.FLP.TabIndex = 0
        '
        'CheckBoxSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(669, 484)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.FLP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CheckBoxSample"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckBox Sample"
        Me.SS.ResumeLayout(False)
        Me.SS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrowseButton As System.Windows.Forms.Button
    Friend WithEvents TxtPath As System.Windows.Forms.TextBox
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SS As System.Windows.Forms.StatusStrip
    Friend WithEvents EventsLoger As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FLP As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents TSPBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Sep1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FileFolder As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Sep2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Sep3 As System.Windows.Forms.ToolStripStatusLabel

End Class
