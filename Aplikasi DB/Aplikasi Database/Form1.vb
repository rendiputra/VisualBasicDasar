Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LatihanDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.LatihanDataSet.Table1)

    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        Me.Table1BindingSource.MoveFirst()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        Me.Table1BindingSource.MoveNext()
    End Sub

    Private Sub btnbuttom_Click(sender As Object, e As EventArgs) Handles btnbuttom.Click
        Me.Table1BindingSource.MoveLast()
    End Sub

    Private Sub btnprevesios_Click(sender As Object, e As EventArgs) Handles btnprevesios.Click
        Me.Table1BindingSource.MovePrevious()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.Table1BindingSource.AddNew()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Me.Table1BindingSource.RemoveCurrent()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.Table1TableAdapter.Update(Me.LatihanDataSet.Table1)
    End Sub
End Class
