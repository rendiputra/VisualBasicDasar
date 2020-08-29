Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtharga.Text = ""
        txtjumlah.Text = ""
        namatxt.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txttotal.Text = Val(txtjumlah.Text) * Val(txtharga.Text)
        txtnama.Text = namatxt.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Val(kembalian.Text) < Val(txttotal.Text) Then
            kembalian.Text = Val(txtkembali.Text) - Val(txttotal.Text)
        End If
    End Sub

    Private Sub txtkembali_TextChanged(sender As Object, e As EventArgs) Handles txtkembali.TextChanged

    End Sub

    Private Sub kembalian_Click(sender As Object, e As EventArgs) Handles kembalian.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class