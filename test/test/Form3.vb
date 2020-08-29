Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtuser.Text = "user" And
            txtpw.Text = "pw" Then
            Me.Hide()
            Form4.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtpw.Text = ""
        txtuser.Text = ""
    End Sub
End Class