Public Class trape
    Private Sub trape_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = keliling
        AcceptButton = luas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub keliling_Click(sender As Object, e As EventArgs) Handles keliling.Click
        k.Text = Val(c.Text) + Val(a.Text) + Val(b.Text) + Val(d.Text)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        k.Text = "0"
        c.Text = "0"
        b.Text = "0"
        d.Text = "0"
        t.Text = "0"
        a.Text = "0"
        l.text = "0"
        a.Focus()
    End Sub
    Private Sub luas_Click(sender As Object, e As EventArgs) Handles luas.Click
        l.Text = ((Val(a.Text) + Val(c.Text)) / 2) * t.Text
    End Sub
    Private Sub c_KeyPress(sender As Object, e As KeyPressEventArgs) Handles c.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub b_KeyPress(sender As Object, e As KeyPressEventArgs) Handles b.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub a_KeyPress(sender As Object, e As KeyPressEventArgs) Handles a.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub d_KeyPress(sender As Object, e As KeyPressEventArgs) Handles d.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub t_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t.KeyPress
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
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub keliling_MouseLeave(sender As Object, e As EventArgs) Handles keliling.MouseLeave
        keliling.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub keliling_MouseHover(sender As Object, e As EventArgs) Handles keliling.MouseHover
        keliling.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub luas_MouseHover(sender As Object, e As EventArgs) Handles luas.MouseHover
        luas.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub luas_MouseLeave(sender As Object, e As EventArgs) Handles luas.MouseLeave
        luas.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub
End Class