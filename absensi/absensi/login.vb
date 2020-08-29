Public Class login
    'clear
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtuser.Text = ""
        txtpw.Text = ""
    End Sub
    'proses login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtuser.Text = "admin" And txtpw.Text = "admin" Then
            form1.Show()
            Me.Hide()
        Else
            MsgBox("Username dan Password Salah!")
        End If
    End Sub
End Class