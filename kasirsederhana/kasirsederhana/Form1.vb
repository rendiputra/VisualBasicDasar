Public Class Form1
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim pilihan As String
        Dim I As Integer
        pilihan = ""
        For I = 1 To ListBox1.SelectedItems.Count
            pilihan = pilihan + ListBox1.SelectedItems(I - 1) + vbCrLf

        Next
        namatxt.Text = pilihan
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub namatxt_TextChanged(sender As Object, e As EventArgs) Handles namatxt.TextChanged

    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged

    End Sub

    Private Sub txtnama_Click(sender As Object, e As EventArgs) Handles txtnama.Click

    End Sub
End Class
