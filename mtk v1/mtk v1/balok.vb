Public Class balok
    Private Sub luas_Click(sender As Object, e As EventArgs) Handles luas.Click
        lpk.Text = 2 * (Val(t.Text) * Val(p.Text) + (Val(p.Text) * Val(l.Text)) + (Val(l.Text) * Val(t.Text)))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        v.Text = p.Text * t.Text * l.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        v.Text = "0"
        lpk.Text = "0"
        t.Text = "0"
        l.Text = "0"
        p.Text = "0"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub l_KeyPress(sender As Object, e As KeyPressEventArgs) Handles l.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub p_KeyPress(sender As Object, e As KeyPressEventArgs) Handles p.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub t_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub

    Private Sub luas_MouseHover(sender As Object, e As EventArgs) Handles luas.MouseHover
        luas.Font = New Font(Button1.Font.Name, 11, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub luas_MouseLeave(sender As Object, e As EventArgs) Handles luas.MouseLeave
        luas.Font = New Font(Button1.Font.Name, 12, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.Font = New Font(Button1.Font.Name, 16, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.Font = New Font(Button1.Font.Name, 14, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.Font = New Font(Button1.Font.Name, 11, Button1.Font.Style, Button1.Font.Unit)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Font = New Font(Button1.Font.Name, 12, Button1.Font.Style, Button1.Font.Unit)
    End Sub
End Class