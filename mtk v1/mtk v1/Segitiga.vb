Public Class Segitiga
    Private Sub luas_Click(sender As Object, e As EventArgs) Handles luas.Click
        l.Text = 1 / 2 * ps.Text * tinggi.Text
    End Sub
    Private Sub keliling_Click(sender As Object, e As EventArgs) Handles keliling.Click
        k.Text = kel.Text * 3
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        l.Text = "0"
        k.Text = "0"
        ps.Text = "0"
        tinggi.Text = "0"
        kel.Text = "0"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub kel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kel.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub
    Private Sub ps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ps.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub
    Private Sub tinggi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tinggi.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub luas_MouseHover(sender As Object, e As EventArgs) Handles luas.MouseHover
        luas.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub luas_MouseLeave(sender As Object, e As EventArgs) Handles luas.MouseLeave
        luas.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub keliling_MouseHover(sender As Object, e As EventArgs) Handles keliling.MouseHover
        keliling.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub keliling_MouseLeave(sender As Object, e As EventArgs) Handles keliling.MouseLeave
        keliling.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
End Class