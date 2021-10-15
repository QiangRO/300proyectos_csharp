Module Module1
    Public StrCon As String = "Provider=MicroSoft.Jet.OLEDB.4.0;data source='db1.mdb'"


    Public Con As New OleDb.OleDbConnection(StrCon)
    Public Cmd As New OleDb.OleDbCommand("", Con)
    Public Da As New OleDb.OleDbDataAdapter("", StrCon)

    Public Ds As New DataSet
    Public Dt As New DataTable
End Module
