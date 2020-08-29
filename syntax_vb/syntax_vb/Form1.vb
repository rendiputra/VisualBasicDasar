Imports System.Data.Odbc
Public Class Form1
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
    Sub reset()
        txtpw.Text = ""
        txtuser.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    'login
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Call koneksi()
        Dim da As New OdbcDataAdapter
        Dim login = "select * from user where username='" + txtuser.Text + "' and password='" + txtpw.Text + "'"
        Dim cmd As New OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = login
        da.SelectCommand = cmd
        Dim rd As OdbcDataReader
        rd = cmd.ExecuteReader()
        If rd.HasRows = 0 Then
            MsgBox("Username dan Password salah!! ",
                   MsgBoxStyle.Exclamation, "error login")
        Else
            conn.Close()
            Call koneksi()

            MsgBox("Login berhasil, Selamat datang " & txtuser.Text & "!", MsgBoxStyle.Information, "successfull login")
            Form2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        Call reset()
    End Sub
End Class
