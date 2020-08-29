Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "rpl" And
                TextBox2.Text = "telesandi" Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Password Salah", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub
End Class
