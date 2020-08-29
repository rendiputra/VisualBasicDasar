Public Class Form2

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = 0.8
        ProgressBar1.Value += 2
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Visible = False
            Form3.Show()
        End If
    End Sub
End Class