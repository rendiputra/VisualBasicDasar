Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = 0.8
        ProgressBar1.Value += 4
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            Form2.Show()
        End If
    End Sub
End Class
