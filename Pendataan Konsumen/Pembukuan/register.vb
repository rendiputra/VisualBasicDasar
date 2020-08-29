Imports System.Data.Odbc
Imports System.IO
Imports System.Drawing.Bitmap 'pengambilan gambar
Public Class register
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    Private PathFile As String = Nothing
    'membuat koneksi ke database "dbpembukuan"
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=dbpendataan;server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    'Proses Menampilkan Data Tabel tlogin Ke datagrid
    Sub TampilGrid1()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from tlogin", CONN)
        DS = New DataSet
        DA.Fill(DS, "tlogin")
        DataGridView1.DataSource = DS.Tables("tlogin")
        DataGridView1.ReadOnly = True
    End Sub
    'proses refresh data grid
    Private Sub refreshDatagrid1()
        Try
            Call koneksi()
            DS = New DataSet
            DA = New OdbcDataAdapter("SELECT * FROM tlogin", CONN)
            DA.Fill(DS, "tlogin")
            DataGridView1.Columns(0).HeaderText = "ID"
            DataGridView1.Columns(1).HeaderText = "Username"
            DataGridView1.Columns(2).HeaderText = "Password"
            DataGridView1.Columns(3).HeaderText = "Gambar"
            DataGridView1.Columns(4).HeaderText = "level"
            Dim GridView As New DataView(DS.Tables("tlogin"))
            DataGridView1.DataSource = GridView
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
    'Desain DGV
    Sub aturDGV()
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.DarkCyan
        DataGridView1.RowsDefaultCellStyle.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.DarkCyan
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 95
        DataGridView1.Columns(2).Width = 95
        DataGridView1.Columns(3).Visible = False
    End Sub
    'proses pengambilan link file gambar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|GIF Files(*.gif)|*.gif|PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp|TIFF Files(*.tiff)|*.tiff"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox1.Image = New Bitmap(OpenFileDialog1.FileName)
            Button1.Enabled = True
            PathFile = OpenFileDialog1.FileName
            txtlink.Text = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(txtlink.Text)
        End If
    End Sub
    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid1()
        Call aturDGV()
        level.Visible = False
        txtuser.MaxLength = 20
        txtpw.MaxLength = 30
        txtid.MaxLength = 10
    End Sub
    'proses Simpan
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtpw.Text = "" Or txtuser.Text = "" Or txtlink.Text = "" Then
            MessageBox.Show("Silahkan Isi Semua From", "Pendataan Konsumen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call koneksi()
            Try
                If MessageBox.Show("Apakah Anda Ingin Menghapus Data?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Dim Sql As String = "Insert into tlogin (id,username,password,gambar,level) values (?,?,?,?,?)"
                    Dim mycomm As OdbcCommand = New OdbcCommand(Sql, CONN)
                    With mycomm.Parameters
                        .Add("?", OdbcType.VarChar, 10).Value = txtid.Text.Trim
                        .Add("?", OdbcType.VarChar, 20).Value = txtuser.Text.Trim
                        .Add("?", OdbcType.VarChar, 30).Value = txtpw.Text.Trim
                        .Add("?", OdbcType.VarChar, 1000).Value = txtlink.Text.Trim
                        .Add("?", OdbcType.TinyInt, 10).Value = level.Text.Trim
                    End With
                    mycomm.ExecuteNonQuery()
                    mycomm = Nothing
                    MsgBox("Simpan Data User ke database berhasil", MsgBoxStyle.MsgBoxSetForeground, "Simpan")
                    Call kosongkandata()
                    Call refreshDatagrid1()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtadmin.SelectedIndexChanged
        If txtadmin.Text = "Admin" Then
            level.Text = 1
        ElseIf txtadmin.Text = "User Biasa"
            level.Text = 0
        Else
            level.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            btnsimpan.Enabled = False
            btnedit.Enabled = True
            btnhapus.Enabled = True
            txtid.Enabled = True
        Else
            txtid.Text = ""
            txtid.Enabled = False
            btnedit.Enabled = False
            btnhapus.Enabled = False
            btnsimpan.Enabled = True
        End If
    End Sub
    'proses hapus
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtid.Text = "" Then
            MessageBox.Show("Silahkan Pilih Data Yang Akan DIHAPUS dengan masukkan ID", "Pendataan Konsumen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Apakah Anda Ingin Menghapus Data?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete from tlogin where id='" & txtid.Text & "'"
                CMD = New OdbcCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call refreshDatagrid1()
                txtid.Text = ""
            End If
        End If
    End Sub
    'reset
    Sub kosongkandata()
        txtuser.Text = ""
        txtlink.Text = ""
        level.Text = ""
        txtpw.Text = ""
        txtid.Text = ""
        txtadmin.Text = "Admin"

        PictureBox1.Image = Nothing
    End Sub
    'proses edit
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txtid.Text = "" Or txtpw.Text = "" Or txtuser.Text = "" Or txtlink.Text = "" Or level.Text = "" Then
            MessageBox.Show("Silahkan Isi Semua From", "Pendataan Konsumen", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call koneksi()
            Try
                Dim edit As String = "update tlogin set username=? ,password=? ,gambar =? ,level=? where id=?"
                Dim CMD As OdbcCommand = New OdbcCommand(edit, CONN)
                With CMD.Parameters
                    .Add("?", OdbcType.VarChar, 30).Value = txtuser.Text.Trim
                    .Add("?", OdbcType.VarChar, 30).Value = txtpw.Text.Trim
                    .Add("?", OdbcType.VarChar, 1000).Value = txtlink.Text.Trim
                    .Add("?", OdbcType.TinyInt, 30).Value = level.Text.Trim
                    .Add("?", OdbcType.VarChar, 10).Value = txtid.Text.Trim
                End With
                CMD.ExecuteNonQuery()
                'CMD = Nothing
                MsgBox("Edit Data User ke database berhasil", MsgBoxStyle.MsgBoxSetForeground, "Edit")
                Call kosongkandata()
                Call refreshDatagrid1()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
    '    If txtid.Text = "" Or txtpw.Text = "" Or txtuser.Text = "" Or txtlink.Text = "" Or level.Text = "" Then
    '        MessageBox.Show("Silahkan Isi Semua From", "Pendataan Konsumen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    Else
    '        Call koneksi()
    '        Dim edit As String = "update tlogin set username='" & txtuser.Text & "' ,password='" & txtpw.Text & "' ,gambar ='" & txtlink.Text & "' ,level='" & level.Text & "' where id='" & txtid.Text & "'"
    '        Dim CMD As OdbcCommand = New OdbcCommand(edit, CONN)
    '        CMD.ExecuteNonQuery()
    '        MsgBox("Edit Data User ke database berhasil", MsgBoxStyle.MsgBoxSetForeground, "Edit")
    '        Call kosongkandata()
    '        Call refreshDatagrid1()
    '    End If
    'End Sub
    'proses auto complete pada Textbox apabila id di db sama dengan txtid di form"
    Sub tampiltextbox()
        CONN.Close()
        Call koneksi()
        CMD = New OdbcCommand("SELECT * FROM tlogin WHERE id='" & txtid.Text & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            txtuser.Text = RD.Item("username")
            txtpw.Text = RD.Item("password")
            txtlink.Text = RD.Item("gambar")
            level.Text = RD.Item("level")
            PictureBox1.ImageLocation = RD.Item("gambar")
            If level.Text = 1 Then
                txtadmin.Text = "Admin"
            Else
                txtadmin.Text = "User Biasa"
            End If
        Else
            Call kosongkandata()
        End If
    End Sub
    'proses cari data berdasarkan id, nama, alamat, nama marketing, Nama Teknisi, Tanggal
    Sub cari()
        Call koneksi()
        DA = New OdbcDataAdapter("Select * from tlogin Where id like '%" & txtcari.Text & "%' OR username like '%" & txtcari.Text & "%' OR password like '%" & txtcari.Text & "%'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tkonsumen")
        DataGridView1.DataSource = (DS.Tables("tkonsumen"))
        Dim tampil1 As String
        tampil1 = "select * from tkonsumen where id ='" & txtcari.Text & "'"
        CMD = New OdbcCommand(tampil1, CONN)
        RD = CMD.ExecuteReader
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call kosongkandata()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        Call tampiltextbox()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Call cari()
    End Sub
End Class