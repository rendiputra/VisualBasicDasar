Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pilihan As String
        Dim I As Integer
        pilihan = ""
        For I = 1 To ListBox1.SelectedItems.Count
            pilihan = pilihan + ListBox1.SelectedItems(I - 1) + vbCrLf

        Next
        TextBox1.Text = pilihan
    End Sub
End Class
