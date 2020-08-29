Imports System.Data.Odbc
'mendeklarasikan Variable
Public Class data_konsumen
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    'Membuat Koneksi Ke database "dbpembukuan"
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=dbpembukuan; server=192.168.1.3; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    'Proses Menampilkan tabel "tkonsumen" pada Data Grid
    Sub TampilGrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from tkonsumen", CONN)
        DS = New DataSet
        DA.Fill(DS, "tkonsumen")
        DataGridView1.DataSource = DS.Tables("tkonsumen")
        DataGridView1.ReadOnly = True
    End Sub
    'proses refresh dg1
    Private Sub refreshDatagrid1()
        Try
            Call koneksi()
            DS = New DataSet
            DA = New OdbcDataAdapter("SELECT * FROM tkonsumen", CONN)
            DA.Fill(DS, "tkonsumen")
            DataGridView1.Columns(0).HeaderText = "Nama"
            DataGridView1.Columns(1).HeaderText = "Tanggal"
            DataGridView1.Columns(2).HeaderText = "Alamat"
            DataGridView1.Columns(3).HeaderText = "Nama Marketing"
            DataGridView1.Columns(4).HeaderText = "Nama Teknisi"
            DataGridView1.Columns(5).HeaderText = "LB Antena"
            DataGridView1.Columns(6).HeaderText = "LB Parabola"
            DataGridView1.Columns(7).HeaderText = "LB CCTV"
            DataGridView1.Columns(8).HeaderText = "LB Petir"
            DataGridView1.Columns(9).HeaderText = "LB Kantor"
            DataGridView1.Columns(10).HeaderText = "Total LB"
            Dim GridView As New DataView(DS.Tables("tkonsumen"))
            DataGridView1.DataSource = GridView
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    'proses auto complete pada Textbox apabila id sama dengan txtid"
    Sub tampiltextbox()
        CONN.Close()
        Call koneksi()
        CMD = New OdbcCommand("SELECT * FROM tkonsumen WHERE id='" & txtid.Text & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            inputdata.txtnama.Text = RD.Item("Nama")
            inputdata.txttanggal.Text = RD.Item("Tanggal")
            inputdata.txtalamat.Text = RD.Item("Alamat")
            inputdata.txtmarketing.Text = RD.Item("Nama_Marketing")
            inputdata.txtteknisi.Text = RD.Item("Nama_Teknisi")
            inputdata.txtantena.Text = RD.Item("LB_Antena")
            inputdata.txtparabola.Text = RD.Item("LB_Parabola")
            inputdata.txtcctv.Text = RD.Item("LB_CCTV")
            inputdata.txtpetir.Text = RD.Item("LB_Petir")
            inputdata.txtkantor.Text = RD.Item("LB_Kantor")
            inputdata.txttotal.Text = RD.Item("Total_LB")
        End If
    End Sub
    'Desain DGV
    Sub aturDGV()
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.DarkCyan
        DataGridView1.RowsDefaultCellStyle.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.DarkCyan
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 175
        DataGridView1.Columns(2).Width = 165
        DataGridView1.Columns(3).Width = 160
        DataGridView1.Columns(4).Width = 140
        DataGridView1.Columns(5).Width = 105
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100
        DataGridView1.Columns(8).Width = 100
        DataGridView1.Columns(9).Width = 100
        DataGridView1.Columns(10).Width = 100
        Call refreshDatagrid()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub data_konsumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call aturDGV()
    End Sub
    'Menampilkan Tanggal di label3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, “dddd, dd/MM/yyyy”)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        inputdata.Show()
        Me.Hide()
    End Sub
    'proses refresh dg1
    Sub refreshDatagrid()
        Try
            Call koneksi()
            DS = New DataSet
            DA = New OdbcDataAdapter("SELECT * FROM tkonsumen", CONN)
            DA.Fill(DS, "tkonsumen")
            DataGridView1.Columns(0).HeaderText = "ID"
            DataGridView1.Columns(1).HeaderText = "Nama"
            DataGridView1.Columns(2).HeaderText = "Tanggal"
            DataGridView1.Columns(3).HeaderText = "Alamat"
            DataGridView1.Columns(4).HeaderText = "Nama Marketing"
            DataGridView1.Columns(5).HeaderText = "Nama Teknisi"
            DataGridView1.Columns(6).HeaderText = "LB Antena"
            DataGridView1.Columns(7).HeaderText = "LB Parabola"
            DataGridView1.Columns(8).HeaderText = "LB CCTV"
            DataGridView1.Columns(9).HeaderText = "LB Petir"
            DataGridView1.Columns(10).HeaderText = "LB Kantor"
            DataGridView1.Columns(11).HeaderText = "Total LB"
            Dim GridView As New DataView(DS.Tables("tkonsumen"))
            DataGridView1.DataSource = GridView
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    'menghapus Data Berdasarkan id pada txtid
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If txtid.Text = "" Then
            MsgBox("Silahkan Pilih Data Yang Akan DIHAPUS dengan masukkan ID")
        Else
            If MessageBox.Show("Apakah Ingin Menghapus Data?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete from tkonsumen where id='" & txtid.Text & "'"
                CMD = New OdbcCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call TampilGrid()
                txtid.Text = ""
            End If
        End If
    End Sub
    'proses pengiriman edit ke "inputdata" dengan membawa nilai id di "data_konsumen"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If inputdata.txtid.Text = txtid.Text Then
            inputdata.btninput.Enabled = False
        Else
            inputdata.btninput.Enabled = True
        End If
        If txtid.Text = "" Then
            inputdata.btninput.Enabled = True
        Else
            inputdata.btninput.Enabled = False
        End If
        If txtid.Text = "" Then
            MsgBox("Silahkan Masukan ID Yang Akan DIEDIT!")
        Else
            inputdata.txtid.Text = txtid.Text
            Call tampiltextbox()
            inputdata.Show()
            Me.Hide()
        End If
    End Sub
    'proses cari data berdasarkan id, nama, alamat, nama marketing, Nama Teknisi, Tanggal
    Sub cari()
        Call koneksi()
        DA = New OdbcDataAdapter("Select * from tkonsumen Where id like '%" & txtcari.Text & "%' OR nama like '%" & txtcari.Text & "%' OR Nama_Marketing like '%" & txtcari.Text & "%' OR Nama_Teknisi like '%" & txtcari.Text & "%' OR Tanggal like '%" & txtcari.Text & "%' OR Alamat like '%" & txtcari.Text & "%'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tkonsumen")
        DataGridView1.DataSource = (DS.Tables("tkonsumen"))
        Dim tampil1 As String
        tampil1 = "select * from tkonsumen where id ='" & txtcari.Text & "'"
        CMD = New OdbcCommand(tampil1, CONN)
        RD = CMD.ExecuteReader
    End Sub
    'panggil cari
    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        Call cari()
    End Sub
    'Panggil refresDatagrid
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call refreshDatagrid()
    End Sub
    'Hanya Angka dan titik saja
    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress
        '    If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
        '        AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
        '    e.Handled = True
        '    End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        formcetak.Show()
        Me.Hide()
    End Sub
End Class