Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtnama.Text = ""
        txttinggi.Text = ""
        txtrata.Text = ""
        txtket.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mnilai As Double

        mnilai = Val(txtrata.Text)
        txtjumlah.Text = Val(txtpraktik.Text) + Val(txtharian.Text) + Val(txtuas.Text) + Val(txtuts.Text)
        txtrata.Text = Val(txtjumlah.Text) / 4
        If mnilai >= 80 Then
            If Val(txttinggi.Text) >= 175 Then
                txtket.Text = "LULUS"
            Else
                txtket.Text = "GAGAL"
            End If
        Else
            txtket.Text = "GAGAL"
        End If
    End Sub
End Class
