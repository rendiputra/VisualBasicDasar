Public Class Login
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If MessageBox.Show("Yakin Anda Mau keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Awal.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If txtuser.Text = "admin" And txtpass.Text = "admin1" Then
            MsgBox("Selamat Datang Admin", MsgBoxStyle.Information, "LOGIN")
            Masterdata.Show()
            Me.Hide()
            txtuser.Text = ""
            txtpass.Text = ""
        Else
            If txtuser.Text = "" And txtpass.Text = "" Then
                MsgBox("Tidak Ada Username Atau Password", MsgBoxStyle.Critical, "ERROR")
            Else
                If txtuser.Text = "" Then
                    MsgBox("Tidak Ada Username!", MsgBoxStyle.Critical, "ERROR")
                Else
                    If txtpass.Text = "" Then
                        MsgBox("Tidak Ada Password!", MsgBoxStyle.Critical, "ERROR")
                    Else
                        MsgBox("Username Atau Password Salah", MsgBoxStyle.Critical, "ERROR")
                    End If
                End If
            End If
        End If
    End Sub
End Class