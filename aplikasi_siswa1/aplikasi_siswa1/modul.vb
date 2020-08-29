Imports System.Data.OleDb
Imports System.Data

Module modul
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public da As OleDbDataAdapter
    Public dr As OleDbDataReader
    Public ds As DataSet

    Public Sub koneksi()
        Try
            conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db_siswa.mdb")
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()

        End Try
    End Sub
End Module
