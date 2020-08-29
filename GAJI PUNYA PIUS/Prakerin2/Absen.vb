Imports System.Data.Odbc
Public Class Absen
    Dim CONN As OdbcConnection
    Dim cmd As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim dr As OdbcDataReader
    Dim LokasiData As String
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=prakerin; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labeltanggal.Text = Date.Today.ToString("dddddd, dd MMMM yyyy")
        Call tampilgrid()
    End Sub
    Sub tampilgrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from absensi", CONN)
        DS = New DataSet
        DA.Fill(DS, "absensi")
        DataGridView1.DataSource = DS.Tables("absensi")
        DataGridView1.ReadOnly = True
    End Sub
    Sub kosongkandata()
        txtnip.Text = ""
        txtnama.Text = ""
        txtjabatan.Text = ""
        txtmasuk.Text = ""
        txtkeluar.Text = ""
        txtlembur.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        If MessageBox.Show("Yakin Anda Mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Awal.Show()
            Me.Hide()
            Call kosongkandata()
        End If
    End Sub
    Private Sub btnabsen_Click(sender As Object, e As EventArgs) Handles btnabsen.Click
        Call koneksi()
        Dim simpan As String = "Insert into absensi values('" & txtnip.Text & "','" & txtnama.Text & "','" & txtjabatan.Text & "','" & labeltanggal.Text & "', '" & txtmasuk.Text & "', '" & txtkeluar.Text & "', '" & txtlembur.Text & "')"
                cmd = New OdbcCommand(simpan, CONN)
                cmd.ExecuteNonQuery()
            MsgBox("Absensi Kehadiran Telah Berhasil")
        Call kosongkandata()
        Call tampilgrid()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtnip.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtjabatan.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        labeltanggal.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtmasuk.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txtkeluar.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txtlembur.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        If MessageBox.Show("Yakin Data Akan Di edit...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim edit As String = "update absensi set Jam_masuk='" & txtmasuk.Text & "', Jam_keluar ='" & txtkeluar.Text & "', Jam_lembur ='" & txtlembur.Text & "' where Nip='" & txtnip.Text & "'"
            cmd = New OdbcCommand(edit, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Call tampilgrid()
            Call kosongkandata()
        End If
    End Sub
End Class