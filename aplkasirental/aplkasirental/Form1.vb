Public Class Form1
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles rbb.CheckedChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtnama.Text = ""
        txtlama.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txtbayar.Text = ""
        txtnama.Focus()
    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged
        txtjumlah.Text = txtlama.Text * Val(txtharga.Text)
    End Sub

    Private Sub txtharga_LostFocus(sender As Object, e As EventArgs) Handles txtharga.LostFocus

    End Sub

    Private Sub rb10_CheckedChanged(sender As Object, e As EventArgs) Handles rb10.CheckedChanged
        If rb10.Checked = True Then
            rb10.Checked = False
            txtbayar.Text = txtjumlah.Text - Val(txtjumlah.Text * 0.1)
        Else
            rb10.Checked = False
            txtbayar.Text = txtjumlah.Text - Val(txtjumlah.Text * 0)
        End If
    End Sub

    Private Sub DateTimePicker2_LostFocus(sender As Object, e As EventArgs) Handles DateTimePicker2.LostFocus
        txtlama.Text = Val(DateTimePicker1.Text) - Val(DateTimePicker2.Text)
        Dim lama As Integer
        Dim pinjam, kembali As String
        pinjam = DateTimePicker1.Text
        kembali = DateTimePicker2.Text
        lama = DateDiff("d", pinjam, kembali)
        txtlama.Text = lama
    End Sub
End Class
