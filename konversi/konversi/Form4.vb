Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtluas.Text = 3.14 * Val(txtpanjang.Text) * Val(txtpanjang.Text)
    End Sub

    Private Sub txtpanjang_TextChanged(sender As Object, e As EventArgs) Handles txtpanjang.TextChanged
        txtluas.Text = 3.14 * Val(txtpanjang.Text) * Val(txtpanjang.Text)
    End Sub

    Private Sub txtluas_TextChanged(sender As Object, e As EventArgs) Handles txtluas.TextChanged
        txtluas.Text = 3.14 * Val(txtpanjang.Text) * Val(txtpanjang.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtpanjang.Text = ""
        txtluas.Text = ""
        txtpanjang.Text = ""
        txtpanjang.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
    End Sub
End Class