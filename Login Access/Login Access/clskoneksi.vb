Imports System.Data.OleDb
Public Class clskoneksi
    Protected tbllogin = New DataTable
    Protected SQL As String
    Protected database As OleDb.OleDbConnection
    Protected cmd As OleDb.OleDbCommand
    Protected da As OleDb.OleDbDataAdapter
    Protected ds As DataSet
    Protected dt As DataTable
    Public Function openconn() As Boolean


        database = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0; Data source=password.accdb")
        database.Open()
        If database.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub closeconn()
        If Not IsNothing(database) Then
            database.Close()
            database = Nothing
        End If
    End Sub
    Public Function executequery(ByVal query As String) As DataTable
        If Not openconn() Then
            MsgBox("KONEKSI GAGAL....!", MsgBoxStyle.Critical, "access failed")
            Return Nothing
            Exit Function
        End If

        cmd = New OleDbCommand(query, database)
        da = New Data.OleDb.OleDbDataAdapter
        da.SelectCommand = cmd
        ds = New Data.DataSet
        da.Fill(ds)
        dt = ds.Tables(0)
        Return dt
        dt = Nothing
        ds = Nothing
        da = Nothing
        cmd = Nothing
    End Function
End Class
