Imports System.Data.Odbc
Public Class Form3
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim lokasidata As String
    Sub koneksi()
        lokasidata = "Driver={MySQL ODBC 3.51 Driver};Database=siswadb;server=localhost;uid=root"
        conn = New OdbcConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub TampilGrid()
        Call koneksi()
        da = New OdbcDataAdapter("select * From siswa ", conn)
        ds = New DataSet
        da.Fill(ds, "siswa")
        DataGridView1.DataSource = ds.Tables("siswa")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call TampilGrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        cmd = New OdbcCommand("insert into siswa values")
    End Sub
End Class


