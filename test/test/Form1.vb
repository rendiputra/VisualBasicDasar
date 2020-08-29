Public Class Form1
    Private Sub Tb_siswaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tb_siswaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tb_siswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_siswaDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.anu' table. You can move, or remove it, as needed.
        Me.AnuTableAdapter.Fill(Me.TestDataSet.anu)
        'TODO: This line of code loads data into the 'Db_siswaDataSet.tb_siswa' table. You can move, or remove it, as needed.
        Me.Tb_siswaTableAdapter.Fill(Me.Db_siswaDataSet.tb_siswa)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class
