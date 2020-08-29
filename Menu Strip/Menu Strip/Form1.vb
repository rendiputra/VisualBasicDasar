Public Class Form1
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub KalkulatorSederhanaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KalkulatorSederhanaToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub AplikasiHitungLuasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiHitungLuasToolStripMenuItem.Click

    End Sub

    Private Sub LuasSegitigaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LuasSegitigaToolStripMenuItem.Click
        Form3.Show()
    End Sub
End Class
