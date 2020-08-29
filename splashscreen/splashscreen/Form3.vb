Public Class Form3
    Private Sub Siswa8BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Siswa8BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Siswa8BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ulangan_cahya_vallenioDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ulangan_cahya_vallenioDataSet.siswa8' table. You can move, or remove it, as needed.
        Me.Siswa8TableAdapter.Fill(Me.Ulangan_cahya_vallenioDataSet.siswa8)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub
End Class