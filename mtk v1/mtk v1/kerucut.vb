﻿Public Class kerucut
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        v.Text = 3.14 * r.Text * r.Text * t.Text / 3
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lp.Text = "0"
        t.Text = "0"
        d.Text = "0"
        r.Text = "0"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub luas_Click(sender As Object, e As EventArgs) Handles luas.Click
        lp.Text = 3.14 * r.Text * (Val(r.Text) + Val(s.Text))
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
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.Font = New Font(Button1.Font.Name, 12, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.Font = New Font(Button1.Font.Name, 11, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub luas_MouseLeave(sender As Object, e As EventArgs) Handles luas.MouseLeave
        luas.Font = New Font(Button1.Font.Name, 12, Button1.Font.Style, Button1.Font.Unit)
    End Sub
    Private Sub luas_MouseHover(sender As Object, e As EventArgs) Handles luas.MouseHover
        luas.Font = New Font(Button1.Font.Name, 11, Button1.Font.Style, Button1.Font.Unit)
    End Sub
End Class