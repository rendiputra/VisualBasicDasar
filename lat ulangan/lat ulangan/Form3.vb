Imports System.Data.Odbc
Public Class Form3
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim rd As OdbcDataReader
    Dim lokasidata As String

    Sub koneksi()
        lokasidata = "Driver={MySQL ODBC 3.51 Driver}; Database=vbsiswa; server=localhost; uid=root"
        conn = New OdbcConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub tampilgrid()
        Call koneksi()
        da = New OdbcDataAdapter("select * from siswa", conn)
        ds = New DataSet
        da.Fill(ds, "siswa")
        DataGridView1.DataSource = ds.Tables("siswa")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub
    Sub kosongkandata()
        nis.Text = ""
        nama.Text = ""
        kelas.Text = ""
        jurusan.Text = ""
        nis.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Dim simpan As String = "insert into siswa values('" & nis.Text & "','" & nama.Text & "','" & kelas.Text & "','" & jurusan.Text & "')"
        cmd = New OdbcCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data berhasil")
        Call tampilgrid()
        Call kosongkandata()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call koneksi()
        Dim hapus As String = "delete from siswa where nis='" & nis.Text & "'"
        cmd = New OdbcCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data DI HAPUS")
        Call tampilgrid()
        Call kosongkandata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call koneksi()
        Dim edit As String = "update from siswa set nama='" & nama.Text & "',kelas='" & kelas.Text & "',jurusan='" & jurusan.Text & "'where nis='" & nis.Text & "'"
        cmd = New OdbcCommand
        cmd.ExecuteNonQuery()
        MsgBox("Data Telah Di Edit")
        Call tampilgrid()
        Call kosongkandata()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim temp As String = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                If DataGridView1.Rows(i).Cells(j).Value = nis.Text Then
                    MsgBox("Item Ada !")
                    temp = 1
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("Item tidak ada !")
        End If
    End Sub
End Class