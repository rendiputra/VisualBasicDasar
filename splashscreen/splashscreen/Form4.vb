Public Class Form4
    Private Sub Siswa7BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Siswa7BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Siswa7BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ulangan_cahya_vallenioDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ulangan_cahya_vallenioDataSet.siswa7' table. You can move, or remove it, as needed.
        Me.Siswa7TableAdapter.Fill(Me.Ulangan_cahya_vallenioDataSet.siswa7)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub
End Class