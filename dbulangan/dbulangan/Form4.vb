Imports System.Data.Odbc
Public Class Form4
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim rd As OdbcDataReader
    Dim lokasidata As String

    Sub koneksi()
        lokasidata = "Driver={MySQL ODBC 3.51 Driver}; Database=dbulangan; server=localhost; uid=root"
        conn = New OdbcConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub kosongkandata()
        txtmp.Text = ""
        txtnama.Text = ""
        txtno.Text = ""
    End Sub
    Sub tampilgrid()
        Call koneksi()
        da = New OdbcDataAdapter("select * from ulangan2", conn)
        ds = New DataSet
        da.Fill(ds, "ulangan2")
        DataGridView1.DataSource = ds.Tables("ulangan2")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Dim simpan As String = "insert into ulangan2 values('" & txtno.Text & "','" & txtnama.Text & "','" & txtmp.Text & "')"
        cmd = New OdbcCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil")
        Call tampilgrid()
        Call kosongkandata()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        Dim hapus As String = "delete from ulangan2 where no='" & txtno.Text & "'"
        cmd = New OdbcCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data DI HAPUS")
        Call tampilgrid()
        Call kosongkandata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        Dim edit As String = "update ulangan2 set nama_guru='" & txtnama.Text & "',mp='" & txtmp.Text & "'where no='" & txtno.Text & "'"
        cmd = New OdbcCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Telah Di Edit")
        Call tampilgrid()
        Call kosongkandata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class