Imports System.Data.Odbc
Public Class Golongan
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
        DA = New OdbcDataAdapter("select * from golongan", CONN)
        DS = New DataSet
        DA.Fill(DS, "golongan")
        dgvgolongan.DataSource = DS.Tables("golongan")
        dgvgolongan.ReadOnly = True
    End Sub
    Sub kosongdata()
        txtgolongan.Text = ""
        txttunjangankeluarga.Text = ""
        txttunjangananak.Text = ""
        txttunjangantransport.Text = ""
        txttunjanganmakan.Text = ""
        txttunjanganlembur.Text = ""
        txtasuransikesehatan.Text = ""
    End Sub
    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Masterdata.Show()
        Me.Hide()
        Call kosongdata()
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtgolongan.Text = "" Or txttunjangankeluarga.Text = "" Or txttunjangananak.Text = "" Or txttunjangantransport.Text = "" Or txttunjanganmakan.Text = "" Or txttunjanganlembur.Text = "" Or txtasuransikesehatan.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call koneksi()
            Dim simpan As String = "insert into golongan values('" & txtgolongan.Text & "','" & txttunjangankeluarga.Text & "', '" & txttunjangananak.Text & "','" & txttunjangantransport.Text & "','" & txttunjanganmakan.Text & "','" & txttunjanganlembur.Text & "','" & txtasuransikesehatan.Text & "')"
            cmd = New OdbcCommand(simpan, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Input Data Telah Berhasil")
            Call tampilgrid()
            Call kosongdata()
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Call tampilgrid()
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        If MessageBox.Show("Yakin Data Akan Di edit...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim edit As String = "update golongan set Tunjangan_keluarga='" & txttunjangankeluarga.Text & "',Tunjangan_anak='" & txttunjangananak.Text & "',Tunjangan_transport='" & txttunjangantransport.Text & "',Tunjangan_makan='" & txttunjanganmakan.Text & "',Tunjangan_lembur='" & txttunjanganlembur.Text & "',Asuransi_kesehatan='" & txtasuransikesehatan.Text & "' where Golongan='" & txtgolongan.Text & "'"
            cmd = New OdbcCommand(edit, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Call tampilgrid()
            Call kosongdata()
        End If
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtgolongan.Text = "" Then
            MsgBox("Silahkan Pilih Data Yang Akan Dihapus Dengan Masukan Golongan dan ENTER")
        Else
            If MessageBox.Show("Yakin Data Akan Di hapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete From golongan where Golongan='" & txtgolongan.Text & "'"
                cmd = New OdbcCommand(hapus, CONN)
                cmd.ExecuteNonQuery()
                MsgBox("Delete Data Berhasil")
                Call tampilgrid()
                Call kosongdata()
            End If
        End If
    End Sub
    Private Sub dgvgolongan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvgolongan.CellMouseClick
        txtgolongan.Text = dgvgolongan.Rows(e.RowIndex).Cells(0).Value
        txttunjangankeluarga.Text = dgvgolongan.Rows(e.RowIndex).Cells(1).Value
        txttunjangananak.Text = dgvgolongan.Rows(e.RowIndex).Cells(2).Value
        txttunjangantransport.Text = dgvgolongan.Rows(e.RowIndex).Cells(3).Value
        txttunjanganmakan.Text = dgvgolongan.Rows(e.RowIndex).Cells(4).Value
        txttunjanganlembur.Text = dgvgolongan.Rows(e.RowIndex).Cells(5).Value
        txtasuransikesehatan.Text = dgvgolongan.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dgvgolongan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvgolongan.CellContentClick

    End Sub
End Class