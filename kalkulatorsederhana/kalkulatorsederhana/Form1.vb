Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txthasil.Text = Val(TextBox1.Text) + (TextBox2.Text)
    End Sub

    Private Sub kurang_Click(sender As Object, e As EventArgs) Handles kurang.Click
        txthasil.Text = Val(TextBox1.Text) - (TextBox2.Text)
    End Sub

    Private Sub bagi_Click(sender As Object, e As EventArgs) Handles bagi.Click
        txthasil.Text = Val(TextBox1.Text) / (TextBox2.Text)
    End Sub

    Private Sub kali_Click(sender As Object, e As EventArgs) Handles kali.Click
        txthasil.Text = Val(TextBox1.Text) * (TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
