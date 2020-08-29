Public Class segitiga
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Val(TextBox1.Text) * Val(TextBox3.Text) / 2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub segitiga_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class