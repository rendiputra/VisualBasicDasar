Imports System.Data.Odbc
Public Class DataKaryawan
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
        DA = New OdbcDataAdapter("select * from karyawan", CONN)
        DS = New DataSet
        DA.Fill(DS, "karyawan")
        dgvdatakaryawan.DataSource = DS.Tables("karyawan")
        dgvdatakaryawan.ReadOnly = True
    End Sub
    Sub kosongdata()
        txtnip.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txtnotelp.Text = ""
        txtjeniskelamin.Text = ""
        txtstatus.Text = ""
        txtjumlahanak.Text = ""
        txtemail.Text = ""
        txtkodegolongan.Text = ""
        txtkodejabatan.Text = ""
    End Sub
    Private Sub btntutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Masterdata.Show()
        Me.Hide()
        Call kosongdata()
    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call koneksi()
        cmd = New OdbcCommand("Select * from karyawan where Nama Like '%" & txtsearch.Text & "%'", CONN)
        RD = cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Call koneksi()
            DA = New OdbcDataAdapter("select * from karyawan where Nama like '%" & txtsearch.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS)
            dgvdatakaryawan.DataSource = DS.Tables(0)
        Else
            MsgBox("Data Tidak Ditemukan")
        End If
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtnip.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or txtnotelp.Text = "" Or txtjeniskelamin.Text = "" Or txtstatus.Text = "" Or txtjumlahanak.Text = "" Or txtemail.Text = "" Or txtkodegolongan.Text = "" Or txtkodejabatan.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call koneksi()
            Dim simpan As String = "insert into karyawan values('" & txtnip.Text & "','" & txtnama.Text & "', '" & txtalamat.Text & "','" & txtnotelp.Text & "','" & txtjeniskelamin.Text & "','" & txtstatus.Text & "', '" & txtjumlahanak.Text & "','" & txtemail.Text & "','" & txtkodegolongan.Text & "','" & txtkodejabatan.Text & "')"
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
            Dim edit As String = "update karyawan set Nama='" & txtnama.Text & "', Alamat ='" & txtalamat.Text & "', No_telp ='" & txtnotelp.Text & "', Jenis_kelamin ='" & txtjeniskelamin.Text & "', Status ='" & txtstatus.Text & "', Jumlah_anak ='" & txtjumlahanak.Text & "', Email ='" & txtemail.Text & "', Kode_golongan ='" & txtkodegolongan.Text & "', Kode_jabatan ='" & txtkodejabatan.Text & "' where Nip='" & txtnip.Text & "'"
            cmd = New OdbcCommand(edit, CONN)
            cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
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
                Dim hapus As String = "delete From karyawan where Nip='" & txtnip.Text & "'"
                cmd = New OdbcCommand(hapus, CONN)
                cmd.ExecuteNonQuery()
                MsgBox("Delete Data Berhasil")
                Call tampilgrid()
                Call kosongdata()
            End If
        End If
    End Sub
    Private Sub DataKaryawan_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Call koneksi()
                cmd = New OdbcCommand("select Nama, Alamat, No_telp, Jenis_kelamin, Status, Jumlah_anak, Email, Kode_golongan, Kode_jabatan FROM karyawan where Nip = '" & txtnip.Text & "'", CONN)
                RD = cmd.ExecuteReader
                If RD.Read Then
                    txtnama.Text = RD(0).ToString
                    txtalamat.Text = RD(1).ToString
                    txtnotelp.Text = RD(2).ToString
                    txtjeniskelamin.Text = RD(3).ToString
                    txtstatus.Text = RD(4).ToString
                    txtjumlahanak.Text = RD(5).ToString
                    txtemail.Text = RD(6).ToString
                    txtkodegolongan.Text = RD(7).ToString
                    txtkodejabatan.Text = RD(8).ToString
                Else
                    Exit Sub
                End If
                CONN.Close()
                txtnip.Focus()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub DataKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub
    Private Sub txtnip_LostFocus(sender As Object, e As EventArgs) Handles txtnip.LostFocus
        Call koneksi()
        Try
            Dim sql As String = "select * from karyawan where Nip = '" & txtnip.Text & "'"
            cmd = New OdbcCommand(sql, CONN)
            RD = cmd.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                txtnama.Text = RD.Item("Nama")
                txtalamat.Text = RD.Item("Alamat")
                txtnotelp.Text = RD.Item("No_telp")
                txtjeniskelamin.Text = RD.Item("Jenis_kelamin")
                txtstatus.Text = RD.Item("Status")
                txtjumlahanak.Text = RD.Item("Jumlah_anak")
                txtemail.Text = RD.Item("Email")
                txtkodegolongan.Text = RD.Item("Kode_golongan")
                txtkodejabatan.Text = RD.Item("Kode_jabatan")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "warning")
        End Try
    End Sub
    Private Sub dgvdatakaryawan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvdatakaryawan.CellMouseClick
        txtnip.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(0).Value
        txtnama.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(1).Value
        txtalamat.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(2).Value
        txtnotelp.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(3).Value
        txtjeniskelamin.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(4).Value
        txtstatus.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(5).Value
        txtjumlahanak.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(6).Value
        txtemail.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(7).Value
        txtkodegolongan.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(8).Value()
        txtkodejabatan.Text = dgvdatakaryawan.Rows(e.RowIndex).Cells(9).Value()
    End Sub
    Private Sub btnkodegolongan_Click(sender As Object, e As EventArgs) Handles btnkodegolongan.Click
        Tabelgolongan.Show()
    End Sub
    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        Laporandatakaryawan.Show()
    End Sub
    Private Sub btnkodejabatan_Click(sender As Object, e As EventArgs) Handles btnkodejabatan.Click
        Tabeljabatan.Show()
    End Sub
End Class