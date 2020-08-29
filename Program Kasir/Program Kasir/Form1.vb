Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles total.Click

    End Sub

    Private Sub idmenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles idmenu.SelectedIndexChanged
        If idmenu.Text = 1 Then
            menu.Text = "kentang + Es teh manis"
            harga.Text = "8000"
        ElseIf idmenu.Text = 2 Then
            menu.Text = "ayam + Es jeruk"
            harga.Text = "10000"
        ElseIf idmenu.Text = 3 Then
            menu.Text = "bebeks + es teh manis"
            harga.Text = "9500"
        ElseIf idmenu.Text = 4 Then
            menu.Text = "Kerangs + es jeruk"
            harga.Text = "8678"
        ElseIf idmenu.Text = 5 Then
            menu.Text = "Telors + es teh manis"
            harga.Text = "7000"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pesanan_TextChanged(sender As Object, e As EventArgs) Handles pesanan.TextChanged
        total.Text = Val(pesanan.Text) * Val(harga.Text)
    End Sub

    Private Sub bayar_TextChanged(sender As Object, e As EventArgs) Handles bayar.TextChanged
        If Val(bayar.Text) >= total.Text Then
            kembali.Text = Val(bayar.Text) - Val(total.Text)
        Else
            kembali.Text = "Uang Anda Kurang"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        idmenu.Text = ""
        menu.Text = ""
        bayar.Text = ""
        total.Text = ""
        harga.Text = ""
        kembali.Text = ""
        pesanan.Text = ""
    End Sub

    Private Sub tanggal_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked_1(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Hello, I am not good")
    End Sub

    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class
