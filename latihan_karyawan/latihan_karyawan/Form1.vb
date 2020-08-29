Imports System.Data.Odbc
Public Class Form1
    Dim CONN As OdbcConnection
    Dim cmd As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String

    Sub koneksi()
        LokasiData = "Driver ={MYSQL ODBC 3.51 driver}; database=karyawan; server=localhost;uid=root;"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub TampilGrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from karyawan", CONN)
        DS = New DataSet
        DA.Fill(DS, "karyawan")
        DataGridView1.DataSource = DS.Tables("karyawan")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()

    End Sub
    Sub kosongkandata()
        nik.Text = ""
        nama.Text = ""
        gaji.Text = ""
        kode.Text = ""
        jabatan.Text = ""
        kode.Text = ""
        tunjangan.Text = ""
        transport.Text = ""
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click

        If nik.Text = "" Or nama.Text = "" Or gaji.Text = "" Or kode.Text Or jabatan.Text = "" Or tunjangan.Text = "" Or transport.Text = "" Then
            MsgBox("silahkan Isi semua Form")
        Else
            Call koneksi()
            Dim simpan As String = "insert into karyawan values('" & nik.Text & "','" & nama.Text & "','" & gaji.Text & "','" &
                kode.Text & "','" & jabatan.Text & "','" & tunjangan.Text & "','" & transport.Text & "')"
            cmd = New OdbcCommand(simpan, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call TampilGrid()
            Call kosongkandata()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        Dim edit As String = "Update karyawan set nik='" & nik.Text & "',nama_karyawan='" & nama.Text & "',kode_jabatan='" & kode.Text & "',jabatan='" & jabatan.Text & "' where nik '" & nik.Text & "'"
        cmd = New OdbcCommand(edit, CONN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil DI Update")
        Call TampilGrid()
        Call kosongkandata()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click

    End Sub
End Class
