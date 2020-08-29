Public Class Form1
    Dim tbllogin As DataTable
    Dim pross As New clskoneksi
    Sub bersih()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub
    Sub login()
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        tbllogin = Process.ExecuteQuery("select * from tbllogin where username = '" & TextBox1.Text & "' and password='" & TextBox2.Text & "'")
        If tbllogin.Rows.Count = 0 Then
            MessageBox.Show("Login tidak Berhasil...!!", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Focus()
        Else
            Form2.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call login()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
