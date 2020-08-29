Imports System.Data.Odbc
Public Class Form2
    Dim conn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim ds As New DataSet
    Dim da As OdbcDataAdapter
    Dim rd As OdbcDataReader
    Dim LokasiData As String

    'koneksi
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=syntax_vb; server=localhost; uid=root"
        conn = New OdbcConnection(LokasiData)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub tampilGrid()
        Call koneksi()
        da = New OdbcDataAdapter("select * from user", conn)
        ds = New DataSet
        da.Fill(ds, "user")
        DataGridView1.DataSource = ds.Tables("user")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilGrid()
    End Sub
    Sub reset()
        txtpw.Text = ""
        txtuser.Text = ""
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Call Reset()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Call koneksi()

        If txtuser.Text = "" And txtpw.Text = "" Then
            MsgBox("Isi Form terlebih dahulu")
        Else
            Dim simpan As String = "insert into user values (null ,'" & txtuser.Text & "','" & txtpw.Text & "')"
            cmd = New OdbcCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input telah berhasil")
            Call reset()
            Call tampilGrid()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class