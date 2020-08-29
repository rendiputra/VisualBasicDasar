Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pilihan As String
        Dim I As Integer
        pilihan = ""
        For I = 1 To ListBox1.SelectedItems.Count
            pilihan = pilihan + ListBox1.SelectedItems(I - 1) + vbCrLf

        Next
        txtnama.Text = pilihan
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txttotal.Text = Val(txtharga.Text) * Val(txtjumlah.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtharga.Text = ""
        txtnama.Text = ""
        txttotal.Text = ""
        txtjumlah.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged

    End Sub
End Class
