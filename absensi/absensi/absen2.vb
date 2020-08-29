Imports System.Data.Odbc
'deklarasi variable
Public Class absen2
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    'koneksi ke database
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=dbabsen; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    'menampilkan data gridview
    Sub TampilGrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from tabsensi2", CONN)
        DS = New DataSet
        DA.Fill(DS, "tabsensi2")
        DataGridView1.DataSource = DS.Tables("tabsensi2")
        DataGridView1.ReadOnly = True
    End Sub
    'proses auto complete
    Sub tampiltextbox()
        CONN.Close()
        Call koneksi()
        CMD = New OdbcCommand("SELECT * FROM tabsensi2 WHERE NIP='" & txtnip.Text & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            txtnama.Text = RD.Item("nama")
            txttglawal.Text = RD.Item("tanggalawal")
            txttglakhir.Text = RD.Item("tanggalakhir")
            txthadir.Text = RD.Item("hadir")
            txtsakit.Text = RD.Item("sakit")
            txtizin.Text = RD.Item("izin")
            txtalpa.Text = RD.Item("alpa")
            txttglawal.Enabled = False
            cbmulai.Checked = False
        End If
    End Sub
    'proses clear
    Sub kosongkandata()
        txtnip.Text = ""
        txtnama.Text = ""
        txttglakhir.Text = ""
        txthadir.Text = "0"
        txtizin.Text = "0"
        txtsakit.Text = "0"
        txtalpa.Text = "0"
        rdalpa.Checked = False
        rdhadir.Checked = False
        rdizin.Checked = False
        rdsakit.Checked = False
        rdizin.Enabled = True
        rdalpa.Enabled = True
        rdhadir.Enabled = True
        rdsakit.Enabled = True
        cbmulai.Checked = True
        txttglawal.ResetText()
    End Sub
    'mengatur tampilan data grid view
    Sub aturDGV()
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 175
        DataGridView1.Columns(2).Width = 120
        DataGridView1.Columns(3).Width = 120
        DataGridView1.Columns(4).Width = 61
        DataGridView1.Columns(5).Width = 61
        DataGridView1.Columns(6).Width = 61
        DataGridView1.Columns(7).Width = 60
    End Sub
    'keluar
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Apakah Anda Ingin Keluar?", "Konfirmasi Keluar Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            End
        End If
    End Sub
    'menampilkan waktu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Format(Now, “dddd, dd-MM-yyyy”)
        'Label7.Text = Format(Now, “HH:mm:ss”)
        txttglakhir.Text = Format(Now, “yyyy-MM-dd”)
    End Sub
    'proses hapus
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtnip.Text = "" Then
            MsgBox("Silahkan Pilih Data Yang Akan DIHAPUS dengan masukkan NIP dan ENTER")
        Else
            If MessageBox.Show("Apakah Ingin Menghapus Data?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete from tabsensi2 where NIP='" & txtnip.Text & "'"
                CMD = New OdbcCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call TampilGrid()
                Call kosongkandata()
            End If
        End If
    End Sub
    'memanggil tampilgrid & Atur DG
    Private Sub absensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call aturDGV()
    End Sub
    'proses edit
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or txttglawal.Text = "" Or txttglakhir.Text = "" Or txtizin.Text = "" Or txthadir.Text = "" Or txtsakit.Text = "" Or txtalpa.Text = "" Then
            MsgBox("Silahkan Isi Semua From")
        Else
            Call koneksi()
            Dim edit As String = "update tabsensi2 set nama='" & txtnama.Text & "',tanggalawal='" & txttglawal.Text & "',tanggalakhir='" & txttglakhir.Text & "',hadir='" & txthadir.Text & "',izin='" & txtizin.Text & "',sakit='" & txtsakit.Text & "',alpa='" & txtalpa.Text & "'where NIP='" & txtnip.Text & "'"
            CMD = New OdbcCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Di UPDATE")
            Call TampilGrid()
            Call kosongkandata()
        End If
    End Sub
    'proses clear
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call kosongkandata()
        Call refreshDatagrid()
    End Sub
    'proses tambah
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or txttglakhir.Text = "" Or txtizin.Text = "" Or txthadir.Text = "" Or txtsakit.Text = "" Or txtalpa.Text = "" Then
            MsgBox("Silahkan Isi Semua From")
        Else
            Call koneksi()
            Dim Simpan As String = "insert into tabsensi2 values ('" & txtnip.Text & "','" & txtnama.Text & "', '" & txttglawal.Value & "','" & txttglakhir.Text & "','" & txthadir.Text & "', '" & txtsakit.Text & "', '" & txtizin.Text & "' ,'" & txtalpa.Text & "')"
            CMD = New OdbcCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Input Data BERHASIL")
            Call TampilGrid()
            Call kosongkandata()
        End If
    End Sub
    'proses absen hadir
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdhadir.CheckedChanged
        If rdhadir.Checked = True Then
            txthadir.Text = Val(txthadir.Text) + 1
            rdizin.Enabled = False
            rdalpa.Enabled = False
            rdsakit.Enabled = False
        Else
            txthadir.Text = Val(txthadir.Text) + 0
        End If
    End Sub
    'proses absen izin
    Private Sub rdizin_CheckedChanged(sender As Object, e As EventArgs) Handles rdizin.CheckedChanged
        If rdizin.Checked = True Then
            txtizin.Text = Val(txtizin.Text) + 1
            rdhadir.Enabled = False
            rdalpa.Enabled = False
            rdsakit.Enabled = False
        Else
            txtizin.Text = Val(txtizin.Text) + 0
        End If
    End Sub
    'proses absen sakit
    Private Sub rdsakit_CheckedChanged(sender As Object, e As EventArgs) Handles rdsakit.CheckedChanged
        If rdsakit.Checked = True Then
            txtizin.Text = Val(txtizin.Text) + 1
            rdizin.Enabled = False
            rdalpa.Enabled = False
            rdhadir.Enabled = False
        Else
            txtsakit.Text = Val(txtsakit.Text) + 0
        End If
    End Sub
    'proses absen alpa
    Private Sub rdalpa_CheckedChanged(sender As Object, e As EventArgs) Handles rdalpa.CheckedChanged
        If rdalpa.Checked = True Then
            txtalpa.Text = Val(txtalpa.Text) + 1
            rdizin.Enabled = False
            rdhadir.Enabled = False
            rdsakit.Enabled = False
        Else
            txtalpa.Text = Val(txtalpa.Text) + 0
        End If
    End Sub
    'proses clear absen
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        rdalpa.Checked = False
        rdhadir.Checked = False
        rdizin.Checked = False
        rdsakit.Checked = False
        rdizin.Enabled = True
        rdalpa.Enabled = True
        rdhadir.Enabled = True
        rdsakit.Enabled = True
        txthadir.Text = "0"
        txtizin.Text = "0"
        txtsakit.Text = "0"
        txtalpa.Text = "0"
    End Sub
    'Proses MenuStrip
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        tentang.Show()
        Me.Hide()
    End Sub
    Private Sub MasterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataToolStripMenuItem.Click
        masterdata.Show()
        Me.Hide()
    End Sub
    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        report.Show()
        Me.Hide()
    End Sub
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        form1.Show()
        Me.Hide()
    End Sub
    'memanggil auto complete
    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnip.KeyPress
        If (e.KeyChar <= Chr(20)) Then
            Call tampiltextbox()
        End If
    End Sub
    'proses cari
    Sub cari()
        Call koneksi()
        DA = New OdbcDataAdapter("Select * from tabsensi2 Where NIP like '" & Me.txtcari.Text & "%'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tabsensi2")
        DataGridView1.DataSource = (DS.Tables("tabsensi2"))
        Dim tampil1 As String
        tampil1 = "select * from tabsensi2 where NIP ='" & txtcari.Text & "'"
        CMD = New OdbcCommand(tampil1, CONN)
        RD = CMD.ExecuteReader
    End Sub
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        Call cari()
    End Sub
    'refresh
    Private Sub refreshDatagrid()
        Try
            Call koneksi()
            DS = New DataSet
            DA = New OdbcDataAdapter("SELECT * FROM tabsensi2", CONN)
            DA.Fill(DS, "tabsensi2")
            DataGridView1.Columns(0).HeaderText = "NIP"
            DataGridView1.Columns(1).HeaderText = "nama"
            DataGridView1.Columns(2).HeaderText = "tanggal"
            DataGridView1.Columns(3).HeaderText = "hadir"
            DataGridView1.Columns(4).HeaderText = "sakit"
            DataGridView1.Columns(5).HeaderText = "izin"
            DataGridView1.Columns(6).HeaderText = "alpa"
            Dim GridView As New DataView(DS.Tables("tabsensi2"))
            DataGridView1.DataSource = GridView

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    'cek restart tgl awal
    Private Sub cbmulai_CheckedChanged(sender As Object, e As EventArgs) Handles cbmulai.CheckedChanged
        If cbmulai.Checked = True Then
            txttglawal.Enabled = True
            txttglawal.ResetText()
        Else
            txttglawal.Enabled = False
        End If
    End Sub

    Private Sub AbsensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.Click
        absensi.Show()
        Me.Hide()
    End Sub

End Class