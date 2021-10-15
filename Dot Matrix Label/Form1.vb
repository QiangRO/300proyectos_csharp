Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim Tick As Long

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents LbDotMatrix1 As Dot_Matrix_Label.lbDotMatrix
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LbDotMatrix2 As Dot_Matrix_Label.lbDotMatrix
    Friend WithEvents LbDotMatrix3 As Dot_Matrix_Label.lbDotMatrix
    Friend WithEvents LbDotMatrix4 As Dot_Matrix_Label.lbDotMatrix
    Friend WithEvents cmdTick1 As System.Windows.Forms.Button
    Friend WithEvents cmdTick As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdTick = New System.Windows.Forms.Button
        Me.cmdTick1 = New System.Windows.Forms.Button
        Me.LbDotMatrix4 = New Dot_Matrix_Label.lbDotMatrix
        Me.LbDotMatrix3 = New Dot_Matrix_Label.lbDotMatrix
        Me.LbDotMatrix2 = New Dot_Matrix_Label.lbDotMatrix
        Me.LbDotMatrix1 = New Dot_Matrix_Label.lbDotMatrix
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'cmdTick
        '
        Me.cmdTick.BackColor = System.Drawing.Color.DimGray
        Me.cmdTick.ForeColor = System.Drawing.Color.White
        Me.cmdTick.Location = New System.Drawing.Point(591, 270)
        Me.cmdTick.Name = "cmdTick"
        Me.cmdTick.Size = New System.Drawing.Size(112, 40)
        Me.cmdTick.TabIndex = 4
        Me.cmdTick.Text = "Start Timer"
        Me.cmdTick.UseVisualStyleBackColor = False
        '
        'cmdTick1
        '
        Me.cmdTick1.BackColor = System.Drawing.Color.DimGray
        Me.cmdTick1.ForeColor = System.Drawing.Color.White
        Me.cmdTick1.Location = New System.Drawing.Point(591, 270)
        Me.cmdTick1.Name = "cmdTick1"
        Me.cmdTick1.Size = New System.Drawing.Size(112, 40)
        Me.cmdTick1.TabIndex = 5
        Me.cmdTick1.Text = "Stop"
        Me.cmdTick1.UseVisualStyleBackColor = False
        '
        'LbDotMatrix4
        '
        Me.LbDotMatrix4.DotHeight = 20
        Me.LbDotMatrix4.DotSpace = 0
        Me.LbDotMatrix4.DotWidth = 20
        Me.LbDotMatrix4.Location = New System.Drawing.Point(45, 153)
        Me.LbDotMatrix4.Name = "LbDotMatrix4"
        Me.LbDotMatrix4.OffColor = System.Drawing.Color.Black
        Me.LbDotMatrix4.OffColorShadow = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbDotMatrix4.OnColor = System.Drawing.Color.LightGreen
        Me.LbDotMatrix4.OnColorShadow = System.Drawing.Color.Green
        Me.LbDotMatrix4.Size = New System.Drawing.Size(464, 104)
        Me.LbDotMatrix4.TabIndex = 3
        '
        'LbDotMatrix3
        '
        Me.LbDotMatrix3.DotHeight = 5
        Me.LbDotMatrix3.DotSpace = 0
        Me.LbDotMatrix3.DotWidth = 3
        Me.LbDotMatrix3.Location = New System.Drawing.Point(45, 103)
        Me.LbDotMatrix3.Name = "LbDotMatrix3"
        Me.LbDotMatrix3.OffColor = System.Drawing.Color.Black
        Me.LbDotMatrix3.OffColorShadow = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbDotMatrix3.OnColor = System.Drawing.Color.LightSkyBlue
        Me.LbDotMatrix3.OnColorShadow = System.Drawing.Color.DodgerBlue
        Me.LbDotMatrix3.Size = New System.Drawing.Size(552, 32)
        Me.LbDotMatrix3.TabIndex = 2
        '
        'LbDotMatrix2
        '
        Me.LbDotMatrix2.DotHeight = 8
        Me.LbDotMatrix2.DotSpace = 0
        Me.LbDotMatrix2.DotWidth = 8
        Me.LbDotMatrix2.Location = New System.Drawing.Point(45, 17)
        Me.LbDotMatrix2.Name = "LbDotMatrix2"
        Me.LbDotMatrix2.OffColor = System.Drawing.Color.Black
        Me.LbDotMatrix2.OffColorShadow = System.Drawing.Color.Maroon
        Me.LbDotMatrix2.OnColor = System.Drawing.Color.Tomato
        Me.LbDotMatrix2.OnColorShadow = System.Drawing.Color.Firebrick
        Me.LbDotMatrix2.Size = New System.Drawing.Size(560, 40)
        Me.LbDotMatrix2.TabIndex = 1
        '
        'LbDotMatrix1
        '
        Me.LbDotMatrix1.DotHeight = 5
        Me.LbDotMatrix1.DotSpace = 0
        Me.LbDotMatrix1.DotWidth = 3
        Me.LbDotMatrix1.Location = New System.Drawing.Point(45, 65)
        Me.LbDotMatrix1.Name = "LbDotMatrix1"
        Me.LbDotMatrix1.OffColor = System.Drawing.Color.Black
        Me.LbDotMatrix1.OffColorShadow = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LbDotMatrix1.OnColor = System.Drawing.Color.LightSkyBlue
        Me.LbDotMatrix1.OnColorShadow = System.Drawing.Color.DodgerBlue
        Me.LbDotMatrix1.Size = New System.Drawing.Size(552, 32)
        Me.LbDotMatrix1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(715, 317)
        Me.Controls.Add(Me.cmdTick1)
        Me.Controls.Add(Me.cmdTick)
        Me.Controls.Add(Me.LbDotMatrix4)
        Me.Controls.Add(Me.LbDotMatrix3)
        Me.Controls.Add(Me.LbDotMatrix2)
        Me.Controls.Add(Me.LbDotMatrix1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Dot Matrix Label Control Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LbDotMatrix1.Text = Date.Now.ToLongDateString
        LbDotMatrix2.Text = Date.Now.ToLongTimeString
        LbDotMatrix3.Text = Date.Now.ToShortDateString
    End Sub

    Private Sub cmdTick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTick.Click
        Timer2.Enabled = True
        cmdTick1.Visible = True
        cmdTick.Visible = False

    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Tick += 1
        LbDotMatrix4.Text = Tick
    End Sub

    Private Sub cmdTick1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTick1.Click
        Timer2.Enabled = False
        cmdTick.Visible = True
        cmdTick1.Visible = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdTick1.Visible = False
    End Sub
End Class
