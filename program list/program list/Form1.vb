Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
        ListBox3.Items.Remove(ListBox3.SelectedItem)

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ListBox1.Items.Add(ListBox2.SelectedItem)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 
        ListBox2.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) 
        ListBox3.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) 
        ListBox2.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) 
        ListBox3.Items.Add(ListBox2.SelectedItem)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) 
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) 
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) 
        ListBox3.Items.Remove(ListBox3.SelectedItem)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox3.Items.Add(ListBox1.SelectedItem)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) 

    End Sub
End Class
