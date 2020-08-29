Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = namatxt.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = kelastxt.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = alamattxt.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = nistxt.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = jurusantxt.Text
        DataGridView1.Update()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        namatxt.Text = ""
        kelastxt.Text = ""
        alamattxt.Text = ""
        nistxt.Text = ""
        jurusantxt.Text = ""
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = ""
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = ""
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = ""
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(3).Value = ""
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(4).Value = ""
        DataGridView1.Update()
    End Sub
End Class
