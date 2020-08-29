Imports System.Data.Odbc
Public Class Form1
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    'membuat koneksi ke database "dbpendataan"
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=dbhit_gaji;server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        'Call TampilGrid1()
        'Call aturDGV()
        'inputdata.txttanggal.Text = ""
        Timer1.Enabled = True
        'Label1.Text = "Selamat datang " & login.txtuser.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, “dddd, dd MMMMM yyyy”) ' hari
        'Label4.Text = Format(Now, “HH:mm:ss”) ' jam
    End Sub

    Private Sub btnuser_Click(sender As Object, e As EventArgs) Handles btnuser.Click

    End Sub

    Private Sub txtcari_MouseClick(sender As Object, e As MouseEventArgs) Handles txtcari.MouseClick
        If txtcari.Text = "Search" Then
            txtcari.Text = ""
            txtcari.TextAlign = HorizontalAlignment.Left
        End If
    End Sub

    Private Sub txtcari_Leave(sender As Object, e As EventArgs) Handles txtcari.Leave
        If txtcari.Text = "" Then
            txtcari.Text = "Search"
            txtcari.TextAlign = HorizontalAlignment.Center
        End If
    End Sub
End Class