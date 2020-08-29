Imports System.Data.Odbc
'deklarasi variable
Public Class masterdata
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    'koneksi ke DB
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=dbabsen; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    'Menampilkan datagrid
    Sub TampilGrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from tpegawai", CONN)
        DS = New DataSet
        DA.Fill(DS, "tpegawai")
        DataGridView1.DataSource = DS.Tables("tpegawai")
        DataGridView1.ReadOnly = True
    End Sub
    'mengkosongkan data
    Sub KosongkanData()
        txtnip.Text = ""
        txtnama.Text = ""
        txttelp.Text = ""
        txtjabatan.Text = ""
        txtalamat.Text = ""
    End Sub
    'mengatur lebar kolom datagrid
    Sub aturDGV()
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 155
        DataGridView1.Columns(2).Width = 110
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 136
    End Sub
    'proses auto complete
    Sub tampiltextbox()
        CONN.Close()
        Call koneksi()
        CMD = New OdbcCommand("SELECT * FROM tpegawai WHERE NIP='" & txtnip.Text & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            txtnama.Text = RD.Item("Nama")
            txttelp.Text = RD.Item("Telepon")
            txtjabatan.Text = RD.Item("Jabatan")
            txtalamat.Text = RD.Item("Alamat")
        End If
    End Sub
    'proses input
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or txtjabatan.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Then
            MsgBox("Silahkan Isi Semua From")
        Else
            Call koneksi()
            Dim Simpan As String = "insert into tpegawai values ('" & txtnip.Text & "','" & txtnama.Text & "', '" & txttelp.Text & "','" & txtjabatan.Text & "', '" & txtalamat.Text & "')"
            CMD = New OdbcCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Input Data BERHASIL")
            Call TampilGrid()
            Call KosongkanData()
        End If
    End Sub
    'memanggil tampil grid dan lebar grid
    Private Sub masterdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call aturDGV()
    End Sub
    'keluar
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Apakah Anda Ingin Keluar?", "Konfirmasi Keluar Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            End
        End If
    End Sub
    'proses edit
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or txtjabatan.Text = "" Or txttelp.Text = "" Or txtalamat.Text = "" Then
            MsgBox("Silahkan Isi Semua From")
        Else
            Call koneksi()
            Dim edit As String = "update tpegawai set Nama='" & txtnama.Text & "',Telepon='" & txttelp.Text & "',Jabatan='" & txtjabatan.Text & "',Alamat='" & txtalamat.Text & "'where NIP='" & txtnip.Text & "'"
            CMD = New OdbcCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Di UPDATE")
            Call TampilGrid()
            Call KosongkanData()
        End If
    End Sub
    'proses hapus
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtnip.Text = "" Then
            MsgBox("Silahkan Pilih Data Yang Akan DIHAPUS dengan masukkan NIP dan ENTER")
        Else
            If MessageBox.Show("Apakah Ingin Menghapus Data?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete from tpegawai where NIP='" & txtnip.Text & "'"
                CMD = New OdbcCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call TampilGrid()
                Call KosongkanData()
            End If
        End If
    End Sub
    'menustrip
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        form1.Show()
        Me.Hide()
    End Sub
    Private Sub AbsensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.Click
        absensi.Show()
        Me.Hide()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        tentang.Show()
        Me.Hide()
    End Sub
    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        report.Show()
        Me.Hide()
    End Sub
    'proses clear
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Call KosongkanData()
        Call refreshDatagrid()
    End Sub
    'pemanggilan proses tampiltextbox (autocomplete)
    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnip.KeyPress
        If (e.KeyChar <= Chr(20)) Then
            Call tampiltextbox()
        End If
    End Sub
    'refresh
    Private Sub refreshDatagrid()
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
    'proses cari
    Sub cari()
        Call koneksi()
        DA = New OdbcDataAdapter("Select * from tpegawai Where NIP like '" & Me.txtcari.Text & "%'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tpegawai")
        DataGridView1.DataSource = (DS.Tables("tpegawai"))
        Dim tampil1 As String
        tampil1 = "select * from tpegawai where NIP ='" & txtcari.Text & "'"
        CMD = New OdbcCommand(tampil1, CONN)
        RD = CMD.ExecuteReader
    End Sub
    'pemanggilan cari
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        Call cari()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class