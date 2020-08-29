Public Class kubus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub luas_Click(sender As Object, e As EventArgs) Handles luas.Click
        v.Text = pr.Text * pr.Text * 6
    End Sub
    Private Sub keliling_Click(sender As Object, e As EventArgs) Handles keliling.Click
        LP.Text = pr.Text * pr.Text * pr.Text
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LP.Text = "0"
        v.Text = "0"
        pr.Text = "0"
    End Sub
    Private Sub pr_KeyPress(sender As Object, d As KeyPressEventArgs) Handles pr.KeyPress
        If (d.KeyChar < "0" OrElse d.KeyChar > "9") _
    AndAlso d.KeyChar <> ControlChars.Back AndAlso d.KeyChar <> "." Then
            d.Handled = True
        End If
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.Font = New Font(Button1.Font.Name, 11, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Font = New Font(Button1.Font.Name, 12, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Font = New Font(Button1.Font.Name, 12, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.Font = New Font(Button1.Font.Name, 11, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub keliling_MouseHover(sender As Object, e As EventArgs) Handles keliling.MouseHover
        keliling.Font = New Font(Button1.Font.Name, 11, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub keliling_MouseLeave(sender As Object, e As EventArgs) Handles keliling.MouseLeave
        keliling.Font = New Font(Button1.Font.Name, 12, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub luas_MouseHover(sender As Object, e As EventArgs) Handles luas.MouseHover
        luas.Font = New Font(Button1.Font.Name, 11, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub luas_MouseLeave(sender As Object, e As EventArgs) Handles luas.MouseLeave
        luas.Font = New Font(Button1.Font.Name, 12, Button1.Font.Style, Button1.Font.Unit)
    End Sub
End Class