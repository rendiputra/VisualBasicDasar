Imports System.Data.Odbc
Public Class Form1
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=karyawan; server=localhost; uid=root"
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
    Sub MunculCombo()
        ComboBox1.Items.Add("boss")
        ComboBox1.Items.Add("Karyawan")
    End Sub
    Sub KosongkanData()
        txtnik.Text = ""
        txtnamakaryawan.Text = ""
        txtkodejabatan.Text = ""
        txtgajipokok.Text = ""
        txttunjangankesehatan.Text = ""
        txttransport.Text = ""
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If txtnik.Text = "" Or txtnamakaryawan.Text = "" Or txtkodejabatan.Text = "" Or txtgajipokok.Text = "" Or txttunjangankesehatan.Text = "" Or txttransport.Text = "" Then
            MsgBox("Silahkan Isi Semua From")
        Else
            Call koneksi()
            Dim Simpan As String = "insert into karyawan values ('" & txtnik.Text & "','" & txtnamakaryawan.Text & "', '" & txtkodejabatan.Text & "','" & ComboBox1.Text & "', '" & txtgajipokok.Text & "', '" & txttunjangankesehatan.Text & "' ,'" & txttransport.Text & "')"
            CMD = New OdbcCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Input Data BERHASIL")
            Call TampilGrid()
            Call KosongkanData()

        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtnik.Text = "" Then
            MsgBox("Silahkan Pilih Data Yang Akan DIHAPUS dengan masukkan NIM dan ENTER")
        Else
            If MessageBox.Show("Yakin akan dihapus..??", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete from karyawan where nik='" & txtnik.Text & "'"
                CMD = New OdbcCommand(hapus, CONN)
                CMD.ExecuteNonQuery()
                Call TampilGrid()
                Call KosongkanData()
            End If
        End If
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        Dim edit As String = "update karyawan set nama_karyawan='" & txtnamakaryawan.Text & "',kode_jabatan='" & txtkodejabatan.Text & "',jabatan='" & ComboBox1.Text & "',gaji_pokok='" & txtgajipokok.Text & "',tunjangan_kesehatan='" & txttunjangankesehatan.Text & "',transport='" & txttransport.Text & "'where nik='" & txtnik.Text & "'"
        CMD = New OdbcCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di UPDATE")
        Call TampilGrid()
        Call KosongkanData()
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call koneksi()
        CMD = New OdbcCommand("select * from karyawan where nama_karyawan like '%" & TextBox1.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("select * from karyawan where nama like '%" & TextBox1.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub
End Class
