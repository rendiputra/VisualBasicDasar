Public Class Form1
    Public Class form1
        Dim table1 As OleDb.OleDbDataAdapter
        Dim record As New BindingSource
    End Class
    Sub bersih()
            txtnis.Text = ""
            txtnama.Text = ""
            txtkelas.Text = ""
            Call data_siswa

        End Sub
    Sub data_siswa()
        Call koneksi()
        tabel = New Data.OleDb.OleDbDataAdapter("select * from tblsiswa", database)
    End Sub
    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub
End Class
