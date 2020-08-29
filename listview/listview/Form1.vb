Public Class Form1
    Private Sub ListViewdataobat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewdataobat.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Sub DaftarListview()
        Dim colsatu, coldua, coltiga, colempat, collima As ColumnHeader
        colsatu = New ColumnHeader
        With colsatu
            .Text = "Kode Obat"
            .TextAlign = HorizontalAlignment.Center
            .Width = 75

        End With

        coldua = New ColumnHeader
        With coldua
            Text = "Nama Obat"
            .TextAlign = HorizontalAlignment.Center
            .Width = 200

        End With
        coltiga = New ColumnHeader
        With coltiga
            .Text = "Satuan"
            .TextAlign = HorizontalAlignment.Center
            .Width = 75

        End With
        colempat = New ColumnHeader
        With colempat
            .Text = "Jumlah Obat"
            .TextAlign = HorizontalAlignment.Center
            .Width = 100

        End With
        collima = New ColumnHeader
        With collima
            .Text = "harga Satuan"
            .TextAlign = HorizontalAlignment.Center
            .Width = 100

        End With

        With Me.ListViewdataobat
            .Columns.Add(colsatu)
            .Columns.Add(coldua)
            .Columns.Add(coltiga)
            .Columns.Add(colempat)
            .Columns.Add(collima)
            .View = View.Details
            .GridLines = True
        End With
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "entri data obat"
        Me.GroupBox1.BackColor = Color.BurlyWood
        Me.ListViewdataobat.BackColor = Color.AliceBlue
        Me.StartPosition = FormStartPosition.CenterParent
        DaftarListview()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.txtkode_obat.Clear()
        Me.txtnama_obat.Clear()
        Me.txtjumlah.Clear()
        Me.txtkode_obat.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Integer
        i = Val(barisbuffer.Text)
        barisbuffer.Text = Str(Val(barisbuffer.Text) + 1)
        ListViewdataobat.Items.Add("")
        ListViewdataobat.Items(ListViewdataobat.Items.Count - 1).SubItems.Add("")
        ListViewdataobat.Items(ListViewdataobat.Items.Count - 1).SubItems.Add("")
        ListViewdataobat.Items(ListViewdataobat.Items.Count - 1).SubItems.Add("")
        ListViewdataobat.Items(ListViewdataobat.Items.Count - 1).SubItems.Add("")
        ListViewdataobat.Items(ListViewdataobat.Items.Count - 1).SubItems.Add("")
        ListViewdataobat.Items(ListViewdataobat.Items.Count - 1).SubItems.Add("")
        ListViewdataobat.Items(ListViewdataobat.Items.Count - 1).SubItems.Add("")
        ListViewdataobat.Items(i).SubItems(0).Text = txtkode_obat.Text
        ListViewdataobat.Items(i).SubItems(1).Text = txtnama_obat.Text
        ListViewdataobat.Items(i).SubItems(2).Text = cbsatuan.Text
        ListViewdataobat.Items(i).SubItems(3).Text = txtjumlah.Text
        ListViewdataobat.Items(i).SubItems(4).Text = txtharga.Text
        ListViewdataobat.Items(i).SubItems(5).Text = txtdokter.Text
        ListViewdataobat.Items(i).SubItems(6).Text = txtapotek.Text
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtapotek_TextChanged(sender As Object, e As EventArgs) Handles txtapotek.TextChanged

    End Sub

    Private Sub txtdokter_TextChanged(sender As Object, e As EventArgs) Handles txtdokter.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub barisbuffer_TextChanged(sender As Object, e As EventArgs) Handles barisbuffer.TextChanged

    End Sub

    Private Sub cbsatuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsatuan.SelectedIndexChanged

    End Sub

    Private Sub txtharga_TextChanged(sender As Object, e As EventArgs) Handles txtharga.TextChanged

    End Sub

    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged

    End Sub

    Private Sub txtnama_obat_TextChanged(sender As Object, e As EventArgs) Handles txtnama_obat.TextChanged

    End Sub

    Private Sub txtkode_obat_TextChanged(sender As Object, e As EventArgs) Handles txtkode_obat.TextChanged

    End Sub
End Class
