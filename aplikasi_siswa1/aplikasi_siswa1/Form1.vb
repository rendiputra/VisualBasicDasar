Imports System.Data.OleDb

Public Class Form1
    Dim dt As New DataTable

    Public Sub refreshTable()
        DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT * FROM tb_siswa"
        cmd = New OleDbCommand
        da = New OleDbDataAdapter
        With cmd
            .CommandText = sql
            .Connection = conn
        End With
        With da
            .SelectCommand = cmd
            .Fill(dt)
        End With
        For i = 0 To dt.Rows.Count - 1
            With DataGridView1
                .Rows.Add(dt.Rows(i)("nis"), dt.Rows(i)("nama_siswa"), dt.Rows(i)("kelas"), dt.Rows(i)("jurusan"))
            End With
        Next
        dt.Rows.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        refreshTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        tambah_data.Show()
    End Sub
End Class
