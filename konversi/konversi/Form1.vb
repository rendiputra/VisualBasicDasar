Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtpanjang.Text = ""
        txtluas.Text = ""
        txtkonversi.Text = ""
        txtlebar.Text = ""
        txtpanjang.Text = ""
        txtpanjang.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cbojenis.Items(0) = "KM"
        cbojenis.Items(1) = "M"
        cbojenis.Items(2) = "CM"
    End Sub

    Private Sub txtkonversi_TextChanged(sender As Object, e As EventArgs) Handles txtkonversi.TextChanged
        txtluas.Text = Val(txtpanjang.Text) * Val(txtlebar.Text) * Val(txtkonversi.Text)

    End Sub

    Private Sub txtpanjang_TextChanged(sender As Object, e As EventArgs) Handles txtpanjang.TextChanged
        txtluas.Text = Val(txtpanjang.Text) * Val(txtlebar.Text) * Val(txtkonversi.Text)
    End Sub

    Private Sub txtlebar_TextChanged(sender As Object, e As EventArgs) Handles txtlebar.TextChanged
        txtluas.Text = Val(txtpanjang.Text) * Val(txtlebar.Text) * Val(txtkonversi.Text)
    End Sub

    Private Sub txtluas_TextChanged(sender As Object, e As EventArgs) Handles txtluas.TextChanged

    End Sub

    Private Sub cbojenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbojenis.SelectedIndexChanged
        txtluas.Text = Val(txtpanjang.Text) * Val(txtlebar.Text) * Val(txtkonversi.Text)
        If cbojenis.SelectedIndex = 0 Then
            txtkonversi.Text = 100000
        Else
            If cbojenis.SelectedIndex = 1 Then
                txtkonversi.Text = 100
            Else
                txtkonversi.Text = 1
            End If

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form4.Show()
    End Sub
End Class
