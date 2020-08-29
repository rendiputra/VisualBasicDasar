Public Class tambah_data
    Private Sub addData()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "PILIH KELAS" Or ComboBox2.Text = "PILIH JURUSAN" Then
            MsgBox("Isi Data Terlebih Dahulu")
        Else
            Dim nis As Double = Val(TextBox1.Text)
            Dim kelas As Double = Val(ComboBox1.Text)
            Try
                Dim sql As String = "insert into tb_siswa values(" & nis & ",'" + TextBox2.Text + "'," & kelas & ",'" + ComboBox2.Text + "')"
                cmd = New OleDb.OleDbCommand(sql, conn)
                If cmd.ExecuteNonQuery > 0 Then
                    MsgBox("Sukses Tambah Data", MsgBoxStyle.Information, "Success")
                    Form1.refreshTable()
                Else
                    MsgBox("tambah data gagal ", MsgBoxStyle.Critical, "Try Again")

                End If
            Catch ex As Exception
                MsgBox("gagal menambahkan data karena nis sudah ada", MsgBoxStyle.Critical)
            End Try

        End If
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub tambah_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addData()

    End Sub
End Class