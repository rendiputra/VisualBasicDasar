Imports System.Data.Odbc
Public Class Simpanan
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
            TxtJumlah.Clear()
            LblNama.Text = ""
            ComboBox2.Text = ""
            ComboBox1.Focus()
        End Sub
        Sub TampilGrid()
            da = New odbcDataAdapter("select * from simpanan", Conn)
            ds = New DataSet
            da.Fill(ds, "simpanan")
            DGV.DataSource = ds.Tables("Simpanan")
        End Sub
        Sub TampilAnggota()
            cmd = New odbcCommand("Select * from anggota", Conn)
            rd = cmd.ExecuteReader
            Do While rd.Read
                ComboBox1.Items.Add(rd.Item(0))
            Loop
        End Sub
        Sub Otomatis()
        cmd = New OdbcCommand("Select * from simpanan where ID_Simpanan in (select max(ID_Simpanan) from simpanan) order by ID_Simpanan desc", CONN)
            Dim urutan As String
            Dim hitung As Long
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                urutan = "SPN" + Format(Now, "yyMMdd") + "001"
            Else
                If Microsoft.VisualBasic.Mid(rd.GetString(0), 4, 6) <> Format(Now, "yyMMdd") Then
                    urutan = "SPN" + Format(Now, "yyMMdd") + "001"
                Else
                    hitung = Microsoft.VisualBasic.Right(rd.GetString(0), 9) + 1
                    urutan = "SPN" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
                End If
            End If
            LblNomor.Text = urutan
        End Sub
    Private Sub Simpanan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Otomatis()
        LblTanggal.Text = Today()
    End Sub
    Private Sub Simpanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call TampilGrid()
        Call Kosongkan()
        TampilAnggota()
        ComboBox2.Items.Add("Wajib")
        ComboBox2.Items.Add("Pokok")
        ComboBox2.Items.Add("Suka Rela")
    End Sub
        Private Sub BTNTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.Close()
        End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then ComboBox2.Focus()
    End Sub
        Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Call Kosongkan()
        End Sub
    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then TxtJumlah.Focus()
    End Sub
    Private Sub TxtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then BTNSimpan.Focus()

        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub BTNTutup_Click_2(sender As Object, e As EventArgs) Handles BTNTutup.Click
        Masterdata.Show()
        Me.Close()
    End Sub
    Private Sub TxtJumlah_TextChanged(sender As Object, e As EventArgs) Handles TxtJumlah.TextChanged
        If ComboBox2.Text = "Wajib" Then
            TxtJumlah.Text = "50000"
            TxtJumlah.Enabled = False
        ElseIf ComboBox2.Text = "Pokok" Then
            TxtJumlah.Text = "250000"
            TxtJumlah.Enabled = False
        Else
            TxtJumlah.Enabled = True
        End If
    End Sub
    Private Sub BTNSimpan_Click(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        If ComboBox1.Text = "" Or ComboBox2.Text = "" Or TxtJumlah.Text = "" Then
            MsgBox("Data belum lengkap")
            Exit Sub
        Else
            Dim simpan As String
            simpan = "Insert into simpanan (ID_Simpanan,Tanggal,nip,Jenis_Simpanan,Jumlah) values " &
                "('" & LblNomor.Text & "','" & Format(DateValue(LblTanggal.Text), "yyyy-MM-dd") & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TxtJumlah.Text & "')"
            cmd = New OdbcCommand(simpan, CONN)
            cmd.ExecuteNonQuery()

            cmd = New OdbcCommand("select * from anggota where nip='" & ComboBox1.Text & "'", CONN)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Dim editsaldo = "update Anggota set saldo= '" & Val(LblSaldo.Text) + Val(TxtJumlah.Text) & "' where nip='" & ComboBox1.Text & "'"
                cmd = New OdbcCommand(editsaldo, CONN)
                cmd.ExecuteNonQuery()
                If ComboBox2.Text = "Wajib" Then
                    Dim editwajib = "update Anggota set Simpanan_wajib= '" & Val(rd.Item(4)) + Val(TxtJumlah.Text) & "' where nip='" & ComboBox1.Text & "'"
                    cmd = New OdbcCommand(editwajib, CONN)
                    cmd.ExecuteNonQuery()
                ElseIf ComboBox2.Text = "Pokok" Then
                    Dim editpokok = "update Anggota set Simpanan_pokok= '" & Val(rd.Item(5)) + Val(TxtJumlah.Text) & "' where nip='" & ComboBox1.Text & "'"
                    cmd = New OdbcCommand(editpokok, CONN)
                    cmd.ExecuteNonQuery()
                ElseIf ComboBox2.Text = "Suka Rela" Then
                    Dim editsukarela = "update Anggota set Simpanan_sukarela= '" & Val(rd.Item(6)) + Val(TxtJumlah.Text) & "' where nip='" & ComboBox1.Text & "'"
                    cmd = New OdbcCommand(editsukarela, CONN)
                    cmd.ExecuteNonQuery()
                End If
                Call TampilGrid()
                Call Kosongkan()
                Call Otomatis()
            End If
        End If
    End Sub
    Private Sub BTNBatal_Click_2(sender As Object, e As EventArgs) Handles BTNBatal.Click
        Call Kosongkan()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OdbcCommand("select * from anggota where nip='" & ComboBox1.Text & "'", CONN)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            LblNama.Text = rd.Item(1)
            LblSaldo.Text = rd.Item(7)
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        cmd = New OdbcCommand("select * from simpanan where Jenis_Simpanan='" & ComboBox2.Text & "'", CONN)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TxtJumlah.Text = rd.Item(3)
        End If
    End Sub
End Class
