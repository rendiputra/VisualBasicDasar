
Imports System.Data.Odbc
Public Class Form1
    Dim CONN As OdbcConnection
    Dim cmd As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    Sub koneksi()
        LokasiData = "Driver ={mysql ODBC 3.51 driver}; database=dbjmn; server=localhost;uid=root;"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If

    End Sub
    Sub TampilGrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from tblmahasiswa", CONN)
        DS = New DataSet
        DA.Fill(DS, "tblmahasiswa")
        DataGridView1.DataSource = DS.Tables("tblmahasiswa")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
        Call MunculCombo()
    End Sub
    Sub MunculCombo()
        ComboBox1.Items.Add("sastra")
        ComboBox1.Items.Add("Teknik Informatika")
        ComboBox1.Items.Add("Sistem Informasi")
    End Sub
    Sub kosongkandata()
        txtnim.Text = ""
        txtnama.Text = ""
        txttelepon.Text = ""
        txtalamat.Text = ""
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If txtnim.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txttelepon.Text Then
            MsgBox("silahkan Isi semua Form")
        Else
            Call koneksi()
            Dim simpan As String = "insert into tblmahasiswa values('" & txtnim.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" &
                txttelepon.Text & "','" & ComboBox1.Text & "')"
            cmd = New OdbcCommand(simpan, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call TampilGrid()
            Call kosongkandata()
        End If
    End Sub
    Private Sub txtnim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnim.KeyPress
        txtnim.MaxLength = 6
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New OdbcCommand("Select * from tbl mahasiswa where NIM ='" & txtnim.Text & "'", CONN)
            RD = cmd.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                MsgBox("NIM tidak ada , Silahkan Coba lagi")
                txtnim.Focus()
            Else
                txtnama.Text = RD.Item("namamhs")
                txtalamat.Text = RD.Item("alamatmhs")
                txttelepon.Text = RD.Item("teleponmhs")
                ComboBox1.Text = RD.Item("jurusanmhs")
                txtnama.Focus()
            End If
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        Dim edit As String = "Update tblmahasiswa set namamhs='" & txtnama.Text & "',alamatmhs='" & txtalamat.Text & "',teleponmhs='" & txttelepon.Text & "',jurusanmhs='" & ComboBox1.Text & "' where NIM '" & txtnim.Text & "'"
        cmd = New OdbcCommand(edit, CONN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil DI Update")
        Call TampilGrid()
        Call kosongkandata()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtnim.Text = "" Then
            MsgBox("Silahkan Pilih Data yang akan di hapus dengan masukan NIM dan ENTER")
        Else
            If MessageBox.Show("yakin akan dihapus...?", "", MessageBoxButtons.YesNo) = Windows.forms.DialogResult Then
                Call koneksi()
                Dim hapus As String = "Delete From tblmahasiswa where NIM '" & txtnim.Text & "'"
                cmd.ExecuteNonQuery()
                Call TampilGrid()
                Call kosongkandata()
            End If
        End If
    End Sub
End Class
