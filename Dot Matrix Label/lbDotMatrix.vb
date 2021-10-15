'|======================================================================|
'|                           Dot Matrix Label                           |
'|                           By: Ross Peoples                           |
'|                                                                      |
'|      This will create a dot matrix of any color and size using       |
'|      a user defined string for the text. One important thing to      |
'|      remember when using this control at run-time is that it         |
'|      will only Invalidate (refresh) when the Text property is        |
'|      changed. This solves some performance issues when any other     |
'|      property is changed. If a property needs to be changed and      |
'|      and updated at run-time, either reset the text, or call         |
'|      Invalidate().                                                   |
'|======================================================================|

Public Class lbDotMatrix
    Inherits System.Windows.Forms.UserControl

    Private eGraphics As Graphics
    Private iText As String = "abcd 1234 -=+[]{}!@#$"
    Private iAuto As Boolean
    Private bColor As Color = Color.Black
    Private dHeight As Integer = 5
    Private dWidth As Integer = 5
    Private dSpace As Integer = 0
    Private cOn As Color = Color.LightGreen
    Private cOnShadow As Color = Color.Green
    Private cOff As Color = Color.DarkGreen
    Private cOffShadow As Color = Color.Black

    Structure tMatrix
        Dim Dot(,) As Boolean
    End Structure

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'lbDotMatrix
        '
        Me.Name = "lbDotMatrix"
        Me.Size = New System.Drawing.Size(208, 32)

    End Sub

#End Region

#Region "Properties"

    Public Property AutoSize() As Boolean
        Get
            Return iAuto
        End Get
        Set(ByVal Value As Boolean)
            iAuto = Value
            Invalidate()
        End Set
    End Property

    Public Overrides Property Text() As String
        Get
            Return iText
        End Get
        Set(ByVal Value As String)
            iText = Value
            Invalidate()
        End Set
    End Property

    Public Overrides Property BackColor() As Color
        Get
            Return bColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            bColor = Value
            Invalidate()
        End Set
    End Property

    Public Property OnColor() As Color
        Get
            Return cOn
        End Get
        Set(ByVal Value As Color)
            cOn = Value
            Invalidate()
        End Set
    End Property

    Public Property OnColorShadow() As Color
        Get
            Return cOnShadow
        End Get
        Set(ByVal Value As Color)
            cOnShadow = Value
            Invalidate()
        End Set
    End Property

    Public Property OffColor() As Color
        Get
            Return cOff
        End Get
        Set(ByVal Value As Color)
            cOff = Value
            Invalidate()
        End Set
    End Property

    Public Property OffColorShadow() As Color
        Get
            Return cOffShadow
        End Get
        Set(ByVal Value As Color)
            cOffShadow = Value
            Invalidate()
        End Set
    End Property

    Public Property DotHeight() As Integer
        Get
            Return dHeight
        End Get
        Set(ByVal Value As Integer)
            dHeight = Value
            Invalidate()
        End Set
    End Property

    Public Property DotWidth() As Integer
        Get
            Return dWidth
        End Get
        Set(ByVal Value As Integer)
            dWidth = Value
            Invalidate()
        End Set
    End Property

    Public Property DotSpace() As Integer
        Get
            Return dSpace
        End Get
        Set(ByVal Value As Integer)
            dSpace = Value
            Invalidate()
        End Set
    End Property

#End Region

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Redraw(e.Graphics)
    End Sub

    Sub Redraw(ByVal eGraphics As Graphics)
        'declare brushes and graphic objects
        Dim i, ii, iii As Integer
        Dim txArray() As Char = Text.ToCharArray
        Dim DotMatrix(txArray.Length - 1) As tMatrix
        Dim gObject As Graphics = eGraphics
        Dim bBrush As SolidBrush = New SolidBrush(bColor)

        'enable smoothing to make it look clean
        gObject.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        'draw background
        gObject.FillRectangle(bBrush, 0, 0, Me.Size.Width, Me.Size.Height)

        'set all dots in the matrix to off color
        For i = 0 To DotMatrix.Length - 1
            ReDim DotMatrix(i).Dot(5, 4)
            For ii = 0 To 5
                For iii = 0 To 4
                    DotMatrix(i).Dot(ii, iii) = False
                Next
            Next
        Next

        'loop through all characters in text
        For i = 0 To txArray.Length - 1
            Select Case LCase(txArray(i))
                Case "a"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "b"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "c"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "d"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "e"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "f"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                Case "g"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "h"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "i"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(2, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(2, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "j"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(3, 1) = True
                    'row 2
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(3, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                Case "k"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(3, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(3, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "l"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "m"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(1, 1) = True
                    DotMatrix(i).Dot(3, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "n"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(1, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(3, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "0", "o"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "p"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                Case "q"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(3, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "r"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(3, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "s"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    'row 2
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "t"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(2, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(2, 3) = True
                    'row 4
                    DotMatrix(i).Dot(2, 4) = True
                Case "u"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "v"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(1, 3) = True
                    DotMatrix(i).Dot(3, 3) = True
                    'row 4
                    DotMatrix(i).Dot(2, 4) = True
                Case "w"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(2, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(2, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "x"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(1, 1) = True
                    DotMatrix(i).Dot(3, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(1, 3) = True
                    DotMatrix(i).Dot(3, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "y"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(1, 1) = True
                    DotMatrix(i).Dot(3, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(2, 3) = True
                    'row 4
                    DotMatrix(i).Dot(2, 4) = True
                Case "z"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(3, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(1, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "1"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(2, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(2, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "2"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(1, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                    DotMatrix(i).Dot(4, 4) = True
                Case "3"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "4"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(3, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(3, 3) = True
                    'row 4
                    DotMatrix(i).Dot(3, 4) = True
                Case "5"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "6"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    'row 2
                    DotMatrix(i).Dot(0, 2) = True
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "7"
                    'row 0
                    DotMatrix(i).Dot(0, 0) = True
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(2, 3) = True
                    'row 4
                    DotMatrix(i).Dot(2, 4) = True
                Case "8"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    'row 3
                    DotMatrix(i).Dot(0, 3) = True
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case "9"
                    'row 0
                    DotMatrix(i).Dot(1, 0) = True
                    DotMatrix(i).Dot(2, 0) = True
                    DotMatrix(i).Dot(3, 0) = True
                    'row 1
                    DotMatrix(i).Dot(0, 1) = True
                    DotMatrix(i).Dot(4, 1) = True
                    'row 2
                    DotMatrix(i).Dot(1, 2) = True
                    DotMatrix(i).Dot(2, 2) = True
                    DotMatrix(i).Dot(3, 2) = True
                    DotMatrix(i).Dot(4, 2) = True
                    'row 3
                    DotMatrix(i).Dot(4, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
                    DotMatrix(i).Dot(2, 4) = True
                    DotMatrix(i).Dot(3, 4) = True
                Case ":"
                    'row 1
                    DotMatrix(i).Dot(2, 1) = True
                    'row 3
                    DotMatrix(i).Dot(2, 3) = True
                Case "."
                    'row 4
                    DotMatrix(i).Dot(2, 4) = True
                Case "/"
                    'row 0
                    DotMatrix(i).Dot(4, 0) = True
                    'row 1
                    DotMatrix(i).Dot(3, 1) = True
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(1, 3) = True
                    'row 4
                    DotMatrix(i).Dot(0, 4) = True
                Case ","
                    'row 2
                    DotMatrix(i).Dot(2, 2) = True
                    'row 3
                    DotMatrix(i).Dot(2, 3) = True
                    'row 4
                    DotMatrix(i).Dot(1, 4) = True
            End Select
        Next

        'draw the matrix
        Dim cWidth As Integer = 5
        For i = 0 To txArray.Length - 1
            'defines char width (if last char in string, dont draw space)
            If i = txArray.Length - 1 Then
                cWidth = 4
            Else
                cWidth = 5
            End If
            For ii = 0 To cWidth
                For iii = 0 To 4
                    Dim dotX, dotY, offsetX As Integer
                    offsetX = i * (dWidth + dSpace) * 6
                    dotX = offsetX + (ii) * (dWidth + dSpace)
                    dotY = (iii) * (dHeight + dSpace)
                    Dim DotArea As Rectangle = New Rectangle(dotX, dotY, dWidth, dHeight)
                    Dim onBrush As Drawing2D.LinearGradientBrush = New Drawing2D.LinearGradientBrush(DotArea, cOn, cOnShadow, Drawing2D.LinearGradientMode.ForwardDiagonal)
                    Dim offBrush As Drawing2D.LinearGradientBrush = New Drawing2D.LinearGradientBrush(DotArea, cOff, cOffShadow, Drawing2D.LinearGradientMode.ForwardDiagonal)
                    If DotMatrix(i).Dot(ii, iii) = True Then
                        gObject.FillEllipse(onBrush, dotX, dotY, dWidth, dHeight)
                    Else
                        gObject.FillEllipse(offBrush, dotX, dotY, dWidth, dHeight)
                    End If
                Next
            Next
        Next

        'autosize if enabled
        If iAuto = True Then
            Dim newWidth, newHeight As Integer
            newWidth = txArray.Length * (dWidth) * 6
            newHeight = 5 * dHeight
            Me.Width = newWidth
            Me.Height = newHeight
        End If
    End Sub

End Class
