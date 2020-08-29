﻿Public Class layang
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub luas_Click(sender As Object, e As EventArgs) Handles luas.Click
        le.Text = d1.Text * d2.Text / 2
    End Sub
    Private Sub keliling_Click(sender As Object, e As EventArgs) Handles keliling.Click
        k.Text = (2 * Val(d1.Text)) + (2 * Val(d2.Text))
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        k.Text = "0"
        d1.Text = "0"
        d2.Text = "0"
        s1.Text = "0"
        s2.Text = "0"
        le.Text = "0"
    End Sub
    Private Sub d2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles d2.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub d1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles d1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub s1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles s1.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub
    Private Sub s2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles s2.KeyPress
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