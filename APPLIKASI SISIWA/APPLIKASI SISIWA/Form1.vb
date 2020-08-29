Public Class Form1

    Private Sub KelasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles KelasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KelasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiswaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiswaDataSet.kelas' table. You can move, or remove it, as needed.
        Me.KelasTableAdapter.Fill(Me.SiswaDataSet.kelas)

    End Sub
End Class
