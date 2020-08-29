Imports System.Data.Odbc
Public Class Form1
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=tugascrud; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub TampilGrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from tugascrud", CONN)
        DS = New DataSet
        DA.Fill(DS, "tugascrud")
        DataGridView1.DataSource = DS.Tables("tugascrud")
        DataGridView1.ReadOnly = True
    End Sub

    Sub KosongkanData()
        txtnis.Text = ""
        txtnama.Text = ""
        txtkelas.Text = ""
        txtjurusan.Text = ""
        txtulangan.Text = ""
        txtuts.Text = ""
        txtuas.Text = ""
        txtrata.Text = ""
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If txtnis.Text = "" Or txtnama.Text = "" Or txtkelas.Text = "" Or txtjurusan.Text = "" Or txtulangan.Text = "" Or txtuts.Text = "" Or txtuas.Text = "" Or txtrata.Text = "" Then
            MsgBox("Silahkan Isi Semua From")
        Else
            Call koneksi()
            Dim Simpan As String = "insert into tugascrud values ('" & txtnis.Text & "','" & txtnama.Text & "', '" & txtkelas.Text & "','" & txtjurusan.Text & "', '" & txtulangan.Text & "', '" & txtuts.Text & "' ,'" & txtuas.Text & "' ,'" & txtrata.Text & "')"
            CMD = New OdbcCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Input Data BERHASIL")
            Call TampilGrid()
            Call KosongkanData()

        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        Dim edit As String = "update tugascrud set nama='" & txtnama.Text & "',kelas ='" & txtkelas.Text & "',jurusan='" & txtjurusan.Text & "',nilaiulangan='" & txtulangan.Text & "',nilaiuts='" & txtuts.Text & "',nilaiuas='" & txtuas.Text & "'where nis='" & txtnis.Text & "'"
        CMD = New OdbcCommand(edit, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Di UPDATE")
        Call TampilGrid()
        Call KosongkanData()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Call koneksi()
        Dim hapus As String = "delete from tugascrud where nis='" & txtnis.Text & "'"
        CMD = New OdbcCommand(hapus, CONN)
        CMD.ExecuteNonQuery()
        Call TampilGrid()
        Call KosongkanData()
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Dim temp As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                If DataGridView1.Rows(i).Cells(j).Value = txtnis.Text Then
                    MsgBox("item found")
                    temp = 1
                End If
            Next
        Next
        If temp = 0 Then
            MsgBox("item not found")
        End If
    End Sub
    Private Sub txtulangan_TextChanged(sender As Object, e As EventArgs) Handles txtulangan.TextChanged
        txtrata.Text = (Val(txtulangan.Text) + Val(txtuts.Text) + Val(txtuas.Text)) / 3
    End Sub

    Private Sub txtuts_TextChanged(sender As Object, e As EventArgs) Handles txtuts.TextChanged
        txtrata.Text = (Val(txtulangan.Text) + Val(txtuts.Text) + Val(txtuas.Text)) / 3
    End Sub

    Private Sub txtuas_TextChanged(sender As Object, e As EventArgs) Handles txtuas.TextChanged
        txtrata.Text = (Val(txtulangan.Text) + Val(txtuts.Text) + Val(txtuas.Text)) / 3
    End Sub
End Class
