Public Class Form2
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        Me.Opacity = 0.8
        ProgressBar1.Value += 3
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            Form3.Show()
        End If
    End Sub
End Class