Public Class balok
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtluas.Text = Val(txtlebar.Text) * Val(txtpanjang.Text) * Val(txttinggi.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class