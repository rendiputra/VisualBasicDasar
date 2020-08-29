Imports System.Data.Odbc
Public Class Form3
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
        ComboBox1.Items.Add("CEO")
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
        Dim edit As String = "update karyawan set nama_karyawan='" & txtnamakaryawan.Text & "',kode_jabatan='" & txtkodejabatan.Text & "',jabatan='" & ComboBox1.Text & "',gaji_pokok='" & txtgajipokok.Text & "',tunjangan='" & txttunjangankesehatan.Text & "',transport='" & txttransport.Text & "'where nik='" & txtnik.Text & "'"
        CMD = New OdbcCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di UPDATE")
        Call TampilGrid()
        Call KosongkanData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                If DataGridView1.Rows(i).Cells(j).Value = txtnik.Text Then
                    MsgBox("Item Found")
                    temp = 1
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox(" Item Not Found")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub
End Class
