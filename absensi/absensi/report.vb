Public Class report
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        form1.Show()
        Me.Hide()
    End Sub
    Private Sub MasterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataToolStripMenuItem.Click
        masterdata.Show()
        Me.Hide()
    End Sub
    Private Sub AbsensiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbsensiToolStripMenuItem.Click
        absensi.Show()
        Me.Hide()
    End Sub
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        tentang.Show()
        Me.Hide()
    End Sub

End Class