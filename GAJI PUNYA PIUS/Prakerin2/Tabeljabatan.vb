Imports System.Data.Odbc
Public Class Tabeljabatan
    Dim CONN As OdbcConnection
    Dim cmd As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=prakerin; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub tampilgrid()
        Call koneksi()
        DA = New OdbcDataAdapter("select * from jabatan", CONN)
        DS = New DataSet
        DA.Fill(DS, "jabatan")
        DataGridView1.DataSource = DS.Tables("jabatan")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Tabeljabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilgrid()
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        DataKaryawan.txtkodejabatan.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Me.Close()
        DataKaryawan.Show()
    End Sub
End Class