Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Public Class Masterdata
    Private Sub btnkaryawan_Click(sender As Object, e As EventArgs) Handles btnkaryawan.Click
        DataKaryawan.Show()
        Me.Hide()
    End Sub
    Private Sub btngaji_Click(sender As Object, e As EventArgs) Handles btngaji.Click
        Penggajian.Show()
        Me.Hide()
    End Sub
    Private Sub btngolongan_Click(sender As Object, e As EventArgs) Handles btngolongan.Click
        Panel2.Controls.Clear()
        Golongan.TopLevel = False
        Panel2.Controls.Add(Golongan)
        Golongan.Show()
    End Sub
    Private Sub btnjabatan_Click(sender As Object, e As EventArgs) Handles btnjabatan.Click
        Panel2.Controls.Clear()
        Jabatan.TopLevel = False
        Panel2.Controls.Add(Jabatan)
        Jabatan.Show()
    End Sub
    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Awal.Show()
        Me.Hide()
    End Sub
    Private Sub btnkoperasi_Click(sender As Object, e As EventArgs) Handles btnkoperasi.Click
        Koperasi.Show()
    End Sub
    Private Sub btnsimpanan_Click(sender As Object, e As EventArgs) Handles btnsimpanan.Click
        Simpanan.Show()
    End Sub
    Private Sub btnpengambilan_Click(sender As Object, e As EventArgs) Handles btnpengambilan.Click
        Pengambilan.Show()
    End Sub
End Class