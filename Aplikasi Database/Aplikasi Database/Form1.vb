Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Latihan1DataSet.Pegawai' table. You can move, or remove it, as needed.
        Me.PegawaiTableAdapter.Fill(Me.Latihan1DataSet.Pegawai)

    End Sub
    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        Me.PegawaiBindingSource.MoveFirst()
    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        Me.PegawaiBindingSource.MovePrevious()
    End Sub

    Private Sub btnbutton_Click(sender As Object, e As EventArgs) Handles btnbutton.Click
        Me.PegawaiBindingSource.MoveLast()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.PegawaiBindingSource.MoveNext()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.PegawaiBindingSource.AddNew()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.PegawaiBindingSource.RemoveCurrent()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.Validate()
        Me.PegawaiBindingSource.EndEdit()
        Me.PegawaiTableAdapter.Update(Me.Latihan1DataSet.Pegawai)
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub
End Class
