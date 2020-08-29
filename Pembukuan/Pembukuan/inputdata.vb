Imports System.Data.Odbc
'Pendeklarasikan Variable
Public Class inputdata
    Dim CONN As OdbcConnection
    Dim CMD As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim RD As OdbcDataReader
    Dim LokasiData As String
    'koneksi ke database "dbpembukaan"
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=dbpembukuan; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    'proses auto complete pada Textbox "apabila nama sama dengan txtnama"
    Sub tampiltextbox()
        CONN.Close()
        Call koneksi()
        CMD = New OdbcCommand("SELECT * FROM tkonsumen WHERE Nama='" & txtnama.Text & "'", CONN)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            txtnama.Text = RD.Item("Nama")
            txtalamat.Text = RD.Item("Alamat")
            txtmarketing.Text = RD.Item("Nama_Marketing")
            txtteknisi.Text = RD.Item("Nama_Teknisi")
            txttanggal.Text = RD.Item("Tanggal")
            txtantena.Text = RD.Item("LB_Antena")
            txtparabola.Text = RD.Item("LB_Parabola")
            txtcctv.Text = RD.Item("LB_CCTV")
            txtpetir.Text = RD.Item("LB_Petir")
            txtkantor.Text = RD.Item("LB_Kantor")
            txttotal.Text = RD.Item("Total_LB")
        End If
    End Sub
    'proses Mengsongkan(clear/reset) Textbox
    Sub kosongkandata()
        txtid.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txtmarketing.Text = ""
        txtteknisi.Text = ""
        txttanggal.Text = ""
        txtantena.Text = "0"
        txtparabola.Text = "0"
        txtcctv.Text = "0"
        txtpetir.Text = "0"
        txtkantor.Text = "0"
        txttotal.Text = "0"
        btninput.Enabled = True
    End Sub
    'Proses Keluar
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MessageBox.Show("Apakah Anda Ingin Keluar?", "Konfirmasi Keluar Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Call Form1.refreshDatagrid1()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Call data_konsumen.refreshDatagrid
        data_konsumen.Show()
        Me.Hide()
    End Sub
    'Menampilkan Waktu pada Label 3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Format(Now, “dddd, dd/MM/yyyy”)
    End Sub
    'Proses Simpan Pada tabel konsumen txtid.Text = data_konsumen.txtid.Text
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btninput.Click
        If txtnama.Text = "" Or txtalamat.Text = "" Or txtmarketing.Text = "" Or txtteknisi.Text = "0" Or txtantena.Text = "0" Or txttanggal.Text = "0" Or txtparabola.Text = "0" Then
            MsgBox("Silahkan Isi Semua From")
        Else
            Call koneksi()
            Dim Simpan As String = "insert into tkonsumen values (NULL, '" & txttanggal.Value & "','" & txtnama.Text & "','" & txtalamat.Text & "', '" & txtmarketing.Text & "','" & txtteknisi.Text & "', '" & txtantena.Text & "', '" & txtparabola.Text & "' ,'" & txtcctv.Text & "' ,'" & txtpetir.Text & "' ,'" & txtkantor.Text & "' ,'" & txttotal.Text & "')"
            CMD = New OdbcCommand(Simpan, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Input Data BERHASIL")
            Call kosongkandata()
        End If
    End Sub
    'panggil script kosongkandata
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call kosongkandata()
    End Sub
    'proses edit bersarkan id pada txtid yang diambil dari Form data_Konsumen
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If txtnama.Text = "" Or txtalamat.Text = "" Or txtmarketing.Text = "" Or txtteknisi.Text = "" Or txtantena.Text = "" Or txttanggal.Text = "" Or txtparabola.Text = "" Then
            MsgBox("Silahkan Isi Semua From")
        Else
            Call koneksi()
            Dim edit As String = "update tkonsumen set tanggal='" & txttanggal.Text & "',nama='" & txtnama.Text & "',Alamat ='" & txtalamat.Text & "',Nama_Marketing='" & txtmarketing.Text & "',Nama_Teknisi='" & txtteknisi.Text & "',LB_Antena='" & txtantena.Text & "',LB_Parabola='" & txtparabola.Text & "',LB_CCTV='" & txtcctv.Text & "',LB_Petir='" & txtpetir.Text & "',LB_Kantor ='" & txtkantor.Text & "',Total_LB='" & txttotal.Text & "'where id='" & txtid.Text & "'"
            CMD = New OdbcCommand(edit, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil Di UPDATE")
            Call kosongkandata()
            'Call data_konsumen.refreshDatagrid()
            data_konsumen.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub inputdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtantena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtantena.KeyPress
        txttotal.Text = Val(txtparabola.Text) + Val(txtantena.Text) + Val(txtcctv.Text) + Val(txtkantor.Text) + Val(txtpetir.Text)
    End Sub

    Private Sub txtcctv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcctv.KeyPress
        txttotal.Text = Val(txtparabola.Text) + Val(txtantena.Text) + Val(txtcctv.Text) + Val(txtkantor.Text) + Val(txtpetir.Text)
    End Sub

    Private Sub txtpetir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpetir.KeyPress
        txttotal.Text = Val(txtparabola.Text) + Val(txtantena.Text) + Val(txtcctv.Text) + Val(txtkantor.Text) + Val(txtpetir.Text)
    End Sub

    Private Sub txtparabola_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtparabola.KeyPress
        txttotal.Text = Val(txtparabola.Text) + Val(txtantena.Text) + Val(txtcctv.Text) + Val(txtkantor.Text) + Val(txtpetir.Text)
    End Sub

    Private Sub txtkantor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkantor.KeyPress
        txttotal.Text = Val(txtparabola.Text) + Val(txtantena.Text) + Val(txtcctv.Text) + Val(txtkantor.Text) + Val(txtpetir.Text)
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotal.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") And (e.KeyChar < "A" OrElse e.KeyChar > "Z") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" Then
            e.Handled = True
        End If
    End Sub
End Class