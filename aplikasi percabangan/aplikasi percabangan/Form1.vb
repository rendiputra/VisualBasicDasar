Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtbanyak.Text = ""
        txtharga.Text = ""
        txtbayar.Text = ""
        txtjumlah.Text = ""
        txtdiskon.Text = ""
        txtpembayaran.Text = ""
        txtkembalian.Text = ""
        txtbanyak.Focus()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mdis As Double
        txtjumlah.Text = Val(txtbanyak.Text) * Val(txtharga.Text)
        If txtjumlah.Text > 1500000 Then
            mdis = txtjumlah.Text * 0.5
            txtdiskon.Text = mdis
            rb50.Checked = True
        Else
            If txtjumlah.Text > 1000000 Then
            mdis = txtjumlah.Text * 0.3
            txtdiskon.Text = mdis
            rb30.Checked = True
        Else
                If txtjumlah.Text > 500000 Then
                    mdis = txtjumlah.Text * 0.2
                    txtdiskon.Text = mdis
                    rb20.Checked = True

                Else
                    If txtjumlah.Text > 100000 Then
                        mdis = txtjumlah.Text * 0.1
                        txtdiskon.Text = mdis
                        rb10.checked = True
                    Else
                        mdis = txtjumlah.Text * 0
                        txtdiskon.Text = mdis
                    End If
                End If
            End If
        End If
        txtbayar.Text = txtjumlah.Text - mdis
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Val(txtpembayaran.Text) >= Val(txtbayar.Text) Then

            txtkembalian.Text = Val(txtpembayaran.Text) - Val(txtbayar.Text)
        Else txtkembalian.Text = "Uangnya Kurang"
        End If
    End Sub
End Class
