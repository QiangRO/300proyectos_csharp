Imports MyProjectControls.MyProject
Imports System.IO

Public Class RadioButtonSample

    Private PicAddress As String

    Private Function Thumbnail(ByVal ImagePath As String) As Image
        Dim Image As Image = Image.FromFile(ImagePath)
        Dim Thumb As Image = Image.GetThumbnailImage(70, 70, New Image.GetThumbnailImageAbort(AddressOf CallBackData), IntPtr.Zero)
        Return Thumb
    End Function

    Private Function CallBackData() As Boolean
        Return False

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseButton.Click
        EventsLoger.Text = "Processing..."
        If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then
            FLP.Controls.Clear()
            ViewImg.Enabled = False
            TxtPath.Text = FBD.SelectedPath
            CreateButtons(FBD.SelectedPath)
        Else
            EventsLoger.Text = "Ready For Action!"
        End If
    End Sub

    Private Sub CreateButtons(ByVal ImagesPath As String)
        Dim Images() As String = Nothing
        Try
            Images = Directory.GetFiles(ImagesPath)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        'If Images.Length > 30 Then
        'MsgBox("Max Files = 30", MsgBoxStyle.Critical)
        'Exit Sub
        'End If

        Dim TempPath As String
        Dim TempImage As Image
        Dim CheckBox As RadioButton
        Dim ImageCount As Integer = 0

        TSPBar.Style = ProgressBarStyle.Blocks
        TSPBar.Maximum = Images.Length
        TSPBar.Value = 0

        For I As Integer = 0 To Images.Length - 1
            TempPath = Images(I)
            If TempPath.EndsWith(".jpg") OrElse TempPath.EndsWith(".png") OrElse TempPath.EndsWith(".bmp") Then
                ImageCount += 1
                Try
                    TempImage = Thumbnail(Images(I))
                    CheckBox = New RadioButton
                    CheckBox.Width = 100
                    CheckBox.Height = 100
                    CheckBox.BackColor = Me.BackColor
                    CheckBox.Image = TempImage
                    CheckBox.Tag = TempPath
                    CheckBox.Margin = New System.Windows.Forms.Padding(2)
                    AddHandler CheckBox.Click, AddressOf RadioButton_Click

                    FLP.Controls.Add(CheckBox)
                    Application.DoEvents()
                    TSPBar.Value += 1


                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)

                End Try
            End If
        Next
        TSPBar.Value = Images.Length
        TSPBar.Style = ProgressBarStyle.Marquee
        FileFolder.Text = ImageCount.ToString + " image(s)"
        EventsLoger.Text = "Loading Complete!"
    End Sub

    Private Sub RadioButton_Click()
        Dim Ctrl As Control
        Dim SI As RadioButton
        For Each Ctrl In Me.FLP.Controls
            SI = CType(Ctrl, RadioButton)

            If Not SI Is Nothing Then
                If SI.Checked Then
                    Dim NPosition As Integer = SI.Tag.ToString.LastIndexOf("\") + 1
                    Dim FileName As String = SI.Tag.ToString.Substring(NPosition, SI.Tag.ToString.Length - NPosition)
                    If NPosition = 3 Then
                        EventsLoger.Text = SI.Tag.ToString

                    Else
                        EventsLoger.Text = SI.Tag.ToString.Substring(0, 3) + "...\" + FileName
                    End If
                    PicAddress = SI.Tag.ToString
                    ViewImg.Enabled = True

                    Exit For
                Else
                    EventsLoger.Text = "Ready For Action!"
                End If
                End If
        Next
        'Play a sound when click on button
        'My.Computer.Audio.Play(My.Resources.BtnClick, AudioPlayMode.Background)
    End Sub

    Private Sub TxtPath_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPath.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            FLP.Controls.Clear
            CreateButtons(TxtPath.Text)

        End If
    End Sub

    Private Sub ViewImg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewImg.Click
        System.Diagnostics.Process.Start(PicAddress)

    End Sub

    Private Sub RadioButtonSample_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()

    End Sub
End Class