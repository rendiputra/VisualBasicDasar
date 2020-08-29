Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LuasPersegiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuasPersegiToolStripMenuItem.Click
        persegi.Show()
        Me.Hide()
    End Sub

    Private Sub LuasPersegiPanjangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuasPersegiPanjangToolStripMenuItem.Click
        panjang.Show()
        Me.Hide()
    End Sub

    Private Sub VolumeKubusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeKubusToolStripMenuItem.Click
        kubus.Show()
        Me.Hide()
    End Sub

    Private Sub VolumeBalokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeBalokToolStripMenuItem.Click
        balok.Show()
        Me.Hide()
    End Sub
End Class
