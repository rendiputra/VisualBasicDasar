Public Class Form5
    Private Sub AnuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AnuBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AnuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TestDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.anu' table. You can move, or remove it, as needed.
        Me.AnuTableAdapter.Fill(Me.TestDataSet.anu)

    End Sub
End Class