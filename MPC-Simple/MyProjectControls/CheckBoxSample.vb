Imports MyProjectControls.MyProject
Imports System.IO


Public Class CheckBoxSample

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
        Dim CheckBox As CheckBox
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
                    CheckBox = New CheckBox
                    CheckBox.Width = 100
                    CheckBox.Height = 100
                    CheckBox.BackColor = Me.BackColor
                    CheckBox.Image = TempImage
                    CheckBox.Tag = TempPath
                    CheckBox.Margin = New System.Windows.Forms.Padding(2)
                    AddHandler CheckBox.Click, AddressOf CheckBox_Click

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

    Private Sub CheckBox_Click()
        Dim SelectedPhotos As System.Collections.Generic.List(Of String) = GetSelectedImages()
        If Not SelectedPhotos.Count = 0 Then
            EventsLoger.Text = "You selected " + SelectedPhotos.Count.ToString + " item(s)."
        Else
            EventsLoger.Text = "Ready For Action!"
        End If

        'Play Sound on Clicking button
        'My.Computer.Audio.Play(My.Resources.BtnClick, AudioPlayMode.Background)
    End Sub

    Public Function GetSelectedImages() As System.Collections.Generic.List(Of String)

        Dim Photos As New System.Collections.Generic.List(Of String)
        Dim TempImage As CheckBox

        Dim ctl As Control
        For Each ctl In Me.FLP.Controls
            TempImage = CType(ctl, CheckBox)
            If Not TempImage Is Nothing Then
                If (TempImage.Checked) Then
                    Photos.Add(TempImage.Tag.ToString)
                End If
            End If
        Next

        Return Photos
    End Function

    Private Sub TxtPath_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPath.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            FLP.Controls.Clear()
            CreateButtons(TxtPath.Text)

        End If
    End Sub

    Private Sub CheckBoxSample_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()

    End Sub

    Private Sub CheckBoxSample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
