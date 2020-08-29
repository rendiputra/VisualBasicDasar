Imports System.Data.Odbc
'deklarasi Variable
Public Class form1
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    'proses koneksi
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=dbabsen; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Private Sub MasterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataToolStripMenuItem.Click
        masterdata.Show()
        Me.Hide()
    End Sub
    Private Sub AbsensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.Click
        absensi.Show()
        Me.Hide()
    End Sub
    'proses tampil grid 1
    Sub TampilGrid1()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from tpegawai", CONN)
        DS = New DataSet
        DA.Fill(DS, "tpegawai")
        DataGridView1.DataSource = DS.Tables("tpegawai")
        DataGridView1.ReadOnly = True
    End Sub
    'proses tampil grid 2
    Sub TampilGrid2()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from tabsensi", CONN)
        DS = New DataSet
        DA.Fill(DS, "tabsensi")
        DataGridView2.DataSource = DS.Tables("tabsensi")
        DataGridView2.ReadOnly = True
    End Sub
    'memanggil tampil grid 1-2, tampilan grid
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid1()
        Call TampilGrid2()
        Call aturDGV()
        Timer1.Enabled = True
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        tentang.Show()
        Me.Hide()
    End Sub
    'tampil waktu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, “dddd, dd/MM/yyyy”)
        Label4.Text = Format(Now, “HH:mm:ss”)
    End Sub
    'proses keluar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Apakah Anda Ingin Keluar?", "Konfirmasi Keluar Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            End
        End If
    End Sub
    'tampilan grid view
    Sub aturDGV()
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView2.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(0).Width = 85
        DataGridView1.Columns(1).Width = 140
        DataGridView1.Columns(2).Width = 95
        DataGridView1.Columns(3).Width = 90
        DataGridView1.Columns(4).Width = 109
        DataGridView2.Columns(0).Width = 90
        DataGridView2.Columns(1).Width = 145
        DataGridView2.Columns(2).Width = 85
        DataGridView2.Columns(3).Width = 50
        DataGridView2.Columns(4).Width = 50
        DataGridView2.Columns(5).Width = 50
        DataGridView2.Columns(6).Width = 49
    End Sub
    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        report.Show()
        Me.Hide()
    End Sub
    'proses refresh dg1
    Private Sub refreshDatagrid1()
        Try
            Call koneksi()
            DS = New DataSet
            DA = New OdbcDataAdapter("SELECT * FROM tpegawai", CONN)
            DA.Fill(DS, "tpegawai")
            DataGridView1.Columns(0).HeaderText = "NIP"
            DataGridView1.Columns(1).HeaderText = "Nama"
            DataGridView1.Columns(2).HeaderText = "Telepon"
            DataGridView1.Columns(3).HeaderText = "Jabatan"
            DataGridView1.Columns(4).HeaderText = "Alamat"
            Dim GridView As New DataView(DS.Tables("tpegawai"))
            DataGridView1.DataSource = GridView
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    'proses refresh DG2
    Private Sub refreshDatagrid2()
        Try
            Call koneksi()
            DS = New DataSet
            DA = New OdbcDataAdapter("SELECT * FROM tabsensi", CONN)
            DA.Fill(DS, "tabsensi")
            DataGridView2.Columns(0).HeaderText = "NIP"
            DataGridView2.Columns(1).HeaderText = "nama"
            DataGridView2.Columns(2).HeaderText = "tanggal"
            DataGridView2.Columns(3).HeaderText = "hadir"
            DataGridView2.Columns(4).HeaderText = "sakit"
            DataGridView2.Columns(5).HeaderText = "izin"
            DataGridView2.Columns(6).HeaderText = "alpa"
            Dim GridView As New DataView(DS.Tables("tabsensi"))
            DataGridView2.DataSource = GridView
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    'proses cari1
    Sub cari1()
        Call koneksi()
        DA = New OdbcDataAdapter("Select * from tpegawai Where NIP like '" & Me.txtcari1.Text & "%'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tpegawai")
        DataGridView1.DataSource = (DS.Tables("tpegawai"))
        Dim tampil1 As String
        tampil1 = "select * from tpegawai where NIP ='" & txtcari1.Text & "'"
        CMD = New OdbcCommand(tampil1, CONN)
        RD = CMD.ExecuteReader
    End Sub
    'proses cari
    Sub cari2()
        Call koneksi()
        DA = New OdbcDataAdapter("Select * from tabsensi Where NIP like '" & Me.txtcari2.Text & "%'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tabsensi")
        DataGridView1.DataSource = (DS.Tables("tabsensi"))
        Dim tampil1 As String
        tampil1 = "select * from tabsensi where NIP ='" & txtcari2.Text & "'"
        CMD = New OdbcCommand(tampil1, CONN)
        RD = CMD.ExecuteReader
    End Sub
    'tombol refresh
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call aturDGV()
        Call refreshDatagrid1()
        Call refreshDatagrid2()
    End Sub
    Private Sub txtcari1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari1.KeyPress
        Call cari1()
    End Sub
    Private Sub txtcari2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari2.KeyPress
        Call cari2()
    End Sub
End Class
