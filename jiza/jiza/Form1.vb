Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "rpl1" And TextBox2.Text = "rpl1" Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Password Salah", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
