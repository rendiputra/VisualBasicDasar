Imports System.Data.Odbc
Imports System.Windows.Forms
Public Class Penggajian
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
    Sub NomorOtomatis()
        cmd = New OdbcCommand("select nomor from penggajian order by nomor desc", CONN)
        RD = cmd.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            txtnomor.Text = "0000000001"
        Else
            txtnomor.Text = Format(Microsoft.VisualBasic.Right(RD.Item("nomor"), 10) + 1, "0000000000")
        End If
    End Sub
    Sub tampilgrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from penggajian", CONN)
        DS = New DataSet
        DA.Fill(DS, "penggajian")
        DataGridView1.DataSource = DS.Tables("penggajian")
        DataGridView1.ReadOnly = True
    End Sub
    Sub kosongdata()
        txtnip.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txttelp.Text = ""
        txtemail.Text = ""
        txtjabatan.Text = ""
        txtstatus.Text = ""
        txtjmlanak.Text = ""
        txtgolongan.Text = ""
        txtgajipokok.Text = ""
        txttunjanganjabatan.Text = ""
        txtkeluarga.Text = ""
        txttunjangananak.Text = ""
        txtuanglembur.Text = ""
        txtuangmakan.Text = ""
        txtasuransikesehatan.Text = ""
        txttransport.Text = ""
        txttotalhadir.Text = ""
        txttotaluanghadir.Text = ""
        txttotallembur.Text = ""
        txttotaluanglembur.Text = ""
        txtpendapatan.Text = ""
        txtpotongan.Text = ""
        txtgajibersih.Text = ""
    End Sub
    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Masterdata.Show()
        Me.Hide()
        Call kosongdata()
    End Sub
    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Laporanpenggajian.Show()
    End Sub
    Private Sub Penggajian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labeltanggal.Text = Date.Today.ToString("dddddd, dd MMMM yyyy")
        Call tampilgrid()
        Call NomorOtomatis()
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txttelp.Text = "" Or txtemail.Text = "" Or txtjabatan.Text = "" Or txtstatus.Text = "" Or txtjmlanak.Text = "" Or txtgolongan.Text = "" Or txtgajipokok.Text = "" Or txttunjanganjabatan.Text = "" Or txtkeluarga.Text = "" Or txttunjangananak.Text = "" Or txtuanglembur.Text = "" Or txtuangmakan.Text = "" Or txtasuransikesehatan.Text = "" Or txttransport.Text = "" Or txttotalhadir.Text = "" Or txttotaluanghadir.Text = "" Or txttotallembur.Text = "" Or txttotaluanglembur.Text = "" Or txtpendapatan.Text = "" Or txtpotongan.Text = "" Or txtgajibersih.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call koneksi()
            Dim simpan As String = "insert into penggajian values('" & txtnip.Text & "','" & txtnomor.Text & "','" & labeltanggal.Text & "','" & txtnama.Text & "', '" & txtalamat.Text & "', '" & txttelp.Text & "', '" & txtemail.Text & "', '" & txtjabatan.Text & "', '" & txtstatus.Text & "', '" & txtjmlanak.Text & "', '" & txtgolongan.Text & "', '" & txtgajipokok.Text & "','" & txttunjanganjabatan.Text & "','" & txtkeluarga.Text & "','" & txttunjangananak.Text & "','" & txtuanglembur.Text & "','" & txtuangmakan.Text & "','" & txtasuransikesehatan.Text & "','" & txttransport.Text & "','" & txttotaluanghadir.Text & "','" & txttotaluanglembur.Text & "','" & txtpendapatan.Text & "','" & txtpotongan.Text & "','" & txtgajibersih.Text & "')"
            cmd = New OdbcCommand(simpan, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Input Data Telah Berhasil")
            Call tampilgrid()
            Call kosongdata()
        End If
    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtnip.Text = "" Then
            MsgBox("Silahkan Pilih Data Yang Akan Dihapus Dengan Masukan NIP dan ENTER")
        Else
            If MessageBox.Show("Yakin Data Akan Di hapus...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call koneksi()
                Dim hapus As String = "delete From penggajian where Nip='" & txtnip.Text & "'"
                cmd = New OdbcCommand(hapus, CONN)
                cmd.ExecuteNonQuery()
                MsgBox("Delete Data Berhasil")
                Call tampilgrid()
                Call kosongdata()
            End If
        End If
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        If MessageBox.Show("Yakin Data Akan Di edit...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim edit As String = "update penggajian set nama='" & txtnama.Text & "', alamat ='" & txtalamat.Text & "', no_telp ='" & txttelp.Text & "', email ='" & txtemail.Text & "', jabatan ='" & txtjabatan.Text & "', status ='" & txtstatus.Text & "', jumlah_anak ='" & txtjmlanak.Text & "', golongan ='" & txtgolongan.Text & "', gaji_pokok ='" & txtgajipokok.Text & "', tunjangan_jabatan ='" & txttunjanganjabatan.Text & "', tunjangan_keluarga ='" & txtkeluarga.Text & "', tunjangan_anak ='" & txttunjangananak.Text & "', uang_lembur ='" & txtuanglembur.Text & "', uang_makan ='" & txtuangmakan.Text & "', asuransi_kesehatan ='" & txtasuransikesehatan.Text & "', uang_transport ='" & txttransport.Text & "', uang_total_kehadiran ='" & txttotaluanghadir.Text & "', uang_total_lembur ='" & txttotaluanglembur.Text & "', pendapatan ='" & txtpendapatan.Text & "', potongan ='" & txtpotongan.Text & "', gaji_bersih ='" & txtgajibersih.Text & "' where nip='" & txtnip.Text & "'"
            cmd = New OdbcCommand(edit, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Call tampilgrid()
            Call kosongdata()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = New OdbcCommand("select * from jabatan ", CONN)
        cmd = New OdbcCommand("select * from golongan ", CONN)
        txttotaluanghadir.Text = Val(txttotalhadir.Text) * 75000
        txttotaluanglembur.Text = Val(txtuanglembur.Text) * Val(txttotallembur.Text)
        txtpendapatan.Text = Val(txtgajipokok.Text) + Val(txttotaluanglembur.Text) + Val(txtuangmakan.Text) + Val(txttransport.Text)
    End Sub
    Private Sub txtnip_LostFocus(sender As Object, e As EventArgs) Handles txtnip.LostFocus
            txtnip.Text = UCase(txtnip.Text)
            cmd = New OdbcCommand("select * from karyawan where Nip='" & txtnip.Text & "'", CONN)
            RD = cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                txtnama.Text = RD.Item(1)
                txtalamat.Text = RD.Item(2)
                txttelp.Text = RD.Item(3)
            txtemail.Text = RD.Item(7)
                txtstatus.Text = RD.Item(5)
                txtjmlanak.Text = RD.Item(6)
        End If
        cmd = New OdbcCommand("select * from jabatan ", CONN)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            txtjabatan.Text = RD.Item(1)
            txtgajipokok.Text = RD.Item(2)
            txttunjanganjabatan.Text = RD.Item(3)
        End If
        cmd = New OdbcCommand("select * from golongan ", CONN)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            txtgolongan.Text = RD.Item(0)
            txtkeluarga.Text = RD.Item(1)
            txttunjangananak.Text = RD.Item(2)
            txttransport.Text = RD.Item(3)
            txtuangmakan.Text = RD.Item(4)
            txtuanglembur.Text = RD.Item(5)
            txtasuransikesehatan.Text = RD.Item(6)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtpotongan.Text = txttotaluanghadir.Text
        txtgajibersih.Text = Val(txtpendapatan.Text) - Val(txtpotongan.Text)
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txtnip.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txtnomor.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        labeltanggal.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtalamat.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        txttelp.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        txtemail.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        txtjabatan.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        txtstatus.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        txtjmlanak.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        txtgolongan.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        txtgajipokok.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        txttunjanganjabatan.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
        txtkeluarga.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value
        txttunjangananak.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value
        txtuanglembur.Text = DataGridView1.Rows(e.RowIndex).Cells(15).Value
        txtuangmakan.Text = DataGridView1.Rows(e.RowIndex).Cells(16).Value
        txtasuransikesehatan.Text = DataGridView1.Rows(e.RowIndex).Cells(17).Value
        txttransport.Text = DataGridView1.Rows(e.RowIndex).Cells(18).Value
        txttotaluanghadir.Text = DataGridView1.Rows(e.RowIndex).Cells(19).Value
        txttotaluanglembur.Text = DataGridView1.Rows(e.RowIndex).Cells(20).Value
        txtpendapatan.Text = DataGridView1.Rows(e.RowIndex).Cells(21).Value
        txtpotongan.Text = DataGridView1.Rows(e.RowIndex).Cells(22).Value
        txtgajibersih.Text = DataGridView1.Rows(e.RowIndex).Cells(23).Value
    End Sub
End Class
