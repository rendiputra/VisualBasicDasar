Imports System.Data.Odbc
Public Class Pengambilan
    Dim CONN As OdbcConnection
    Dim cmd As OdbcCommand
    Dim DS As New DataSet
    Dim DA As OdbcDataAdapter
    Dim rd As OdbcDataReader
    Dim LokasiData As String
    Sub koneksi()
        LokasiData = "Driver={MySQL ODBC 3.51 Driver}; Database=prakerin; server=localhost; uid=root"
        CONN = New OdbcConnection(LokasiData)
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
    End Sub
    Sub Kosongkan()
        ComboBox1.Text = ""
        LblSaldo.Text = ""
        LblSukaRela.Text = ""
        TxtJumlah.Clear()
        LblNama.Text = ""
        ComboBox1.Focus()
    End Sub
    Sub TampilGrid()
        da = New OdbcDataAdapter("select * from Pengambilan", Conn)
        ds = New DataSet
        da.Fill(ds, "Pengambilan")
        DGV.DataSource = ds.Tables("Pengambilan")
    End Sub
    Sub TampilAnggota()
        cmd = New OdbcCommand("Select * from anggota", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            ComboBox1.Items.Add(rd.Item(0))
        Loop
    End Sub
    Sub Otomatis()
        cmd = New OdbcCommand("Select * from pengambilan where ID_Pengambilan in (select max(ID_Pengambilan) from Pengambilan) order by ID_Pengambilan desc", CONN)
        Dim urutan As String
        Dim hitung As Long
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            urutan = "ABL" + Format(Now, "yyMMdd") + "001"
        Else
            If Microsoft.VisualBasic.Mid(rd.GetString(0), 4, 6) <> Format(Now, "yyMMdd") Then
                urutan = "ABL" + Format(Now, "yyMMdd") + "001"
            Else
                hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
                urutan = "ABL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
            End If
        End If
        LblNomor.Text = urutan
    End Sub
    Private Sub Pengambilan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Otomatis()
        LblTanggal.Text = Today()
    End Sub
    Private Sub Pengambilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Kosongkan()
        TampilAnggota()
    End Sub
    Private Sub BTNTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then TxtJumlah.Focus()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OdbcCommand("select * from anggota where nip='" & ComboBox1.Text & "'", CONN)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            LblNama.Text = rd.Item(1)
            LblSaldo.Text = rd.Item(7)
            LblSukaRela.Text = rd.Item(6)
        End If
    End Sub
    Private Sub TxtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtJumlah.Text) > Val(LblSukaRela.Text) Then
                MsgBox("saldo simpanan sukarela tidak mencukupi")
                TxtJumlah.Clear()
            Else
                BTNSimpan.Focus()
            End If
        End If
    End Sub
    Private Sub BTNSimpan_Click_1(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        If ComboBox1.Text = "" Or TxtJumlah.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else

            Dim simpan As String
            simpan = "Insert into pengambilan (ID_Pengambilan, Tanggal, nip, Jumlah) values " &
            "('" & LblNomor.Text & "','" & Format(DateValue(LblTanggal.Text), "yyyy-MM-dd") & "','" & ComboBox1.Text & "','" & TxtJumlah.Text & "')"
            cmd = New OdbcCommand(simpan, Conn)
            cmd.ExecuteNonQuery()

            cmd = New OdbcCommand("select * from anggota where nip='" & ComboBox1.Text & "'", CONN)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim editsaldo = "update anggota set saldo= '" & Val(LblSaldo.Text) - Val(TxtJumlah.Text) & "' where nip='" & ComboBox1.Text & "'"
                cmd = New OdbcCommand(editsaldo, Conn)
                cmd.ExecuteNonQuery()

                Dim editsukarela = "update anggota set Simpanan_Sukarela= '" & Val(rd.Item(6)) - Val(TxtJumlah.Text) & "' where nip='" & ComboBox1.Text & "'"
                cmd = New OdbcCommand(editsukarela, Conn)
                cmd.ExecuteNonQuery()
            End If
            Call Otomatis()
            Call TampilGrid()
            Call Kosongkan()
        End If
    End Sub
    Private Sub BTNBatal_Click_1(sender As Object, e As EventArgs) Handles BTNBatal.Click
        Call Kosongkan()
    End Sub

    Private Sub BTNTutup_Click_1(sender As Object, e As EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub
End Class