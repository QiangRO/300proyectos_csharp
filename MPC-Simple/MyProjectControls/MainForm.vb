Imports MyProjectControls
Imports MyProjectControls.MyProject

Public Class MainForm

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play(My.Resources.PMohajer, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub LB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB.Click
        RadioButtonSample.ShowDialog()

    End Sub

    Private Sub RB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB.Click
        CheckBoxSample.ShowDialog()

    End Sub

    Private Sub lblLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblLink.LinkClicked
        System.Diagnostics.Process.Start("iexplore.exe", "http://www.barnamenevis.org/forum/")

    End Sub
End Class