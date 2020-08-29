Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admon" And TextBox2.Text = "admon" Then
            Me.Hide()
            Form2.show()
        End If
    End Sub
End Class
