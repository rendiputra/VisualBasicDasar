Public Class jargen
    Private Sub luas_Click(sender As Object, e As EventArgs) Handles luas.Click
        k.Text = (2 * Val(a.Text)) + (2 * Val(s.Text))
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        l.Text = "0"
        a.Text = "0"
        t.Text = "0"
        s.Text = "0"
        k.Text = "0"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles a.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub t_TextChanged(sender As Object, e As EventArgs) Handles t.TextChanged
    End Sub
    Private Sub t_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub s_KeyPress(sender As Object, e As KeyPressEventArgs) Handles s.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        l.Text = a.Text * t.Text
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub luas_MouseHover(sender As Object, e As EventArgs) Handles luas.MouseHover
        luas.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub luas_MouseLeave(sender As Object, e As EventArgs) Handles luas.MouseLeave
        luas.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
End Class