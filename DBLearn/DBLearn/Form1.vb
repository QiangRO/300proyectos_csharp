Public Class Form1
    Private Sub FillGrid1()
        Da.SelectCommand.CommandText = "SELECT tblStudent.Code AS Code,tblStudent.Name AS Name,tblStudent.Family AS Family , tblReshte.Name AS ReshteName,tblSexuality.Name AS Sexuality   FROM tblStudent,tblReshte,tblSexuality WHERE tblStudent.ReshteCode=tblReshte.Code AND  tblStudent.SexCode=tblSexuality.Code  ORDER BY tblStudent.Name"
        Da.Fill(Ds, "tblStudent")
        DataGridView1.DataSource = Ds.Tables("tblStudent")
        DataGridView1.Columns("Code").HeaderText = "˜Ï"

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Da.SelectCommand.CommandText = "SELECT * FROM tblReshte ORDER BY Name"
        Da.Fill(Ds, "tblReshte")
        comboReshteCode.DisplayMember = "Name"
        comboReshteCode.ValueMember = "Code"
        comboReshteCode.DataSource = Ds.Tables("tblReshte")

        Da.SelectCommand.CommandText = "SELECT * FROM tblSexuality ORDER BY Name"
        Da.Fill(Ds, "tblSexuality")
        comboSexCode.DisplayMember = "Name"
        comboSexCode.ValueMember = "Code"
        comboSexCode.DataSource = Ds.Tables("tblSexuality")


        FillGrid1()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        If comboReshteCode.SelectedIndex < 0 Then
            MsgBox("Select Reshte")
            comboReshteCode.Focus()
            Exit Sub
        End If

        If comboSexCode.SelectedIndex < 0 Then
            MsgBox("Select Sexuality")
            comboSexCode.Focus()
            Exit Sub
        End If


        Cmd.CommandText = "INSERT INTO tblStudent (Code,Name,Family,ReshteCode,SexCode) VALUES (" + txtCode.Text + ",'" + txtName.Text.Trim + "','" + txtFamily.Text.Trim + "'," + comboReshteCode.SelectedValue.ToString + "," + comboSexCode.SelectedValue.ToString + ")"


        Try
            Con.Open()

            If Cmd.ExecuteNonQuery = 1 Then
                MsgBox("Item Inserted")

                Ds.Tables("tblStudent").Clear()
                FillGrid1()
            Else
                MsgBox("Error in Insert Operation")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Con.Close()
    End Sub
End Class
