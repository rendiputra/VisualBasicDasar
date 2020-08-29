Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 2
        If ProgressBar1.Value = 10 Then
            Timer1.Dispose()
            Me.Hide()
            Form3.show()
        End If
    End Sub
End Class