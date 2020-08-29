Imports System.Data
Imports System.Data.Sql
Module Module1
    Public database As OleDb.OleDbConnection
    Public Sub koneksi()
        Try
            database = New OleDb.OleDbConnection("Provider=SQLOledb.1; integrated Security=SSPI;Persist security Info=false; initial catalog=dbsiswa;data source=tugas/SQLSERVER")
            database.Open()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Module cexgirflv