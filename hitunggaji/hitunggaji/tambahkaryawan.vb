Imports System.Data.Odbc
Public Class tambahkaryawan
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, “dddd, dd MMMMM yyyy”) ' hari
    End Sub

    Private Sub txttanggal_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tambahkaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txttanggal.Value = Format(Now, "dd/MM/yyyy")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class