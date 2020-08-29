Imports System.Data.Odbc
Public Class Jabatan
    Dim CONN As OdbcConnection
    Dim cmd As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=prakerin; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub tampilgrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from jabatan", CONN)
        DS = New DataSet
        DA.Fill(DS, "jabatan")
        dgvjabatan.DataSource = DS.Tables("jabatan")
        dgvjabatan.ReadOnly = True
    End Sub
    Sub kosongdata()
        txtkodejabatan.Text = ""
        txtnamajabatan.Text = ""
        txtgajipokok.Text = ""
        txttunjanganjabatan.Text = ""
    End Sub
    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Masterdata.Show()
        Me.Hide()
        Call kosongdata()
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkodejabatan.Text = "" Or txtnamajabatan.Text = "" Or txtgajipokok.Text = "" Or txttunjanganjabatan.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call koneksi()
            Dim simpan As String = "insert into jabatan values('" & txtkodejabatan.Text & "','" & txtnamajabatan.Text & "', '" & txtgajipokok.Text & "','" & txttunjanganjabatan.Text & "')"
            cmd = New OdbcCommand(simpan, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Input Data Telah Berhasil")
            Call tampilgrid()
            Call kosongdata()
        End If
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        If MessageBox.Show("Yakin Data Akan Di edit...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim edit As String = "update jabatan set Nama_jabatan='" & txtnamajabatan.Text & "', Gaji_pokok='" & txtgajipokok.Text & "',Tunjangan_jabatan='" & txttunjanganjabatan.Text & "' where Jabatan='" & txtkodejabatan.Text & "'"
            cmd = New OdbcCommand(edit, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Call tampilgrid()
            Call kosongdata()
        End If
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtkodejabatan.Text = "" Then
            MsgBox("Silahkan Pilih Data Yang Akan Dihapus Dengan Masukan Kode Jabatan dan ENTER")
        Else
            If MessageBox.Show("Yakin Data Akan Di hapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete From jabatan where Kode_jabatan='" & txtkodejabatan.Text & "'"
                cmd = New OdbcCommand(hapus, CONN)
                cmd.ExecuteNonQuery()
                MsgBox("Delete Data Berhasil")
                Call tampilgrid()
                Call kosongdata()
            End If
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Call tampilgrid()
    End Sub
    Private Sub dgvjabatan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvjabatan.CellMouseClick
        txtkodejabatan.Text = dgvjabatan.Rows(e.RowIndex).Cells(0).Value
        txtnamajabatan.Text = dgvjabatan.Rows(e.RowIndex).Cells(1).Value
        txtgajipokok.Text = dgvjabatan.Rows(e.RowIndex).Cells(2).Value
        txttunjanganjabatan.Text = dgvjabatan.Rows(e.RowIndex).Cells(3).Value
    End Sub
End Class