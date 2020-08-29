Public Class panjang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtluas.Text = Val(txtlebar.Text) * Val(txtpanjang.Text)
    End Sub

    Private Sub txtlebar_TextChanged(sender As Object, e As EventArgs) Handles txtlebar.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class