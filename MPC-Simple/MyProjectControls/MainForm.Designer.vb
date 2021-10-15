<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LB = New System.Windows.Forms.Button
        Me.RB = New System.Windows.Forms.Button
        Me.lblAuthor = New System.Windows.Forms.Label
        Me.lblLink = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'LB
        '
        Me.LB.Location = New System.Drawing.Point(65, 12)
        Me.LB.Name = "LB"
        Me.LB.Size = New System.Drawing.Size(140, 140)
        Me.LB.TabIndex = 0
        Me.LB.Text = "Radio Button Sample"
        Me.LB.UseVisualStyleBackColor = True
        '
        'RB
        '
        Me.RB.Location = New System.Drawing.Point(226, 12)
        Me.RB.Name = "RB"
        Me.RB.Size = New System.Drawing.Size(140, 140)
        Me.RB.TabIndex = 1
        Me.RB.Text = "CheckBox Sample"
        Me.RB.UseVisualStyleBackColor = True
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(74, 162)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(194, 13)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Created By Saleh Bagheri, Powered By "
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.Location = New System.Drawing.Point(263, 162)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(96, 13)
        Me.lblLink.TabIndex = 3
        Me.lblLink.TabStop = True
        Me.lblLink.Text = "BarnameNevis.Org"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 184)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.RB)
        Me.Controls.Add(Me.LB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB As System.Windows.Forms.Button
    Friend WithEvents RB As System.Windows.Forms.Button
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents lblLink As System.Windows.Forms.LinkLabel
End Class
