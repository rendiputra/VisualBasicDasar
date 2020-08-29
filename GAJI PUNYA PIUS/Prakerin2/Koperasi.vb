Imports System.Data.Odbc
Public Class Koperasi
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
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox1.Focus()
    End Sub
    Sub DataBaru()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox2.Focus()
    End Sub
    Sub Tampilkan()
        Call koneksi()
        DA = New OdbcDataAdapter("Select * from Anggota", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "Anggota")
        DGV.DataSource = (ds.Tables("Anggota"))
        DGV.ReadOnly = True
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampilkan()
    End Sub
    Private Sub Textbox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 19
        If e.KeyChar = Chr(13) Then

            cmd = New OdbcCommand("select * from Anggota where nip='" & TextBox1.Text & "'", CONN)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                TextBox2.Text = rd.Item(1)
                TextBox3.Text = rd.Item(2)
                TextBox4.Text = rd.Item(3)
                TextBox5.Text = rd.Item(4)
                TextBox6.Text = rd.Item(5)
                TextBox7.Text = rd.Item(6)
                TextBox8.Text = rd.Item(7)
                TextBox2.Focus()
            Else
                Call DataBaru()
                TextBox2.Focus()
            End If

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub Textbox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Text = UCase(TextBox2.Text)
            TextBox3.Focus()
        End If

    End Sub
    Private Sub Textbox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox3.Text = UCase(TextBox3.Text)
            TextBox4.Focus()
        End If
    End Sub
    Private Sub Textbox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox5.Text = 50000
        TextBox6.Text = 250000
    End Sub
    Private Sub Textbox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then TextBox6.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub Textbox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Chr(13) Then TextBox7.Focus()
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub Textbox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox8.Text = Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox7.Text)
            TextBox8.Enabled = False
            BTNSimpan.Focus()
        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub
    Private Sub BTNSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            cmd = New OdbcCommand("Select * from Anggota where nip='" & TextBox1.Text & "'", CONN)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim tambah As String = "Insert into Anggota(nip, Nama, Alamat, Telepon, Simpanan_Wajib, Simpanan_Pokok, Simpanan_Sukarela, Saldo) values " & _
                "('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
                cmd = New OdbcCommand(tambah, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim edit As String = "Update Anggota set " & _
                "Nama='" & TextBox2.Text & "', " & _
                "Alamat='" & TextBox3.Text & "', " & _
                "Telepon='" & TextBox4.Text & "', " & _
                "Simpanan_Wajib='" & TextBox5.Text & "', " & _
                "Simpanan_Pokok='" & TextBox6.Text & "', " & _
                "Simpanan_Sukarela='" & TextBox7.Text & "', " & _
                "Saldo='" & TextBox6.Text & "' where nip='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(edit, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If

    End Sub
    Private Sub BTNBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Kosongkan()
    End Sub
    Private Sub BTNTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub
    Private Sub BTNHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TextBox1.Text = "" Then
            MsgBox("Isi kode Anggota terlebih dahulu")
            TextBox1.Focus()
            Exit Sub
        Else

            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("delete  from Anggota where nip='" & TextBox1.Text & "'", CONN)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub
    Private Sub BTNUbah_Click(sender As Object, e As EventArgs) Handles BTNUbah.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            cmd = New OdbcCommand("Select * from Anggota where nip='" & TextBox1.Text & "'", CONN)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim tambah As String = "Insert into Anggota(nip, Nama, Alamat, Telepon, Simpanan_Wajib, Simpanan_Pokok, Simpanan_Sukarela, Saldo) values " & _
                "('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
                cmd = New OdbcCommand(tambah, CONN)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim edit As String = "Update Anggota set " & _
                "Nama='" & TextBox2.Text & "', " & _
                "Alamat='" & TextBox3.Text & "', " & _
                "Telepon='" & TextBox4.Text & "', " & _
                "Simpanan_Wajib='" & TextBox5.Text & "', " & _
                "Simpanan_Pokok='" & TextBox6.Text & "', " & _
                "Simpanan_Sukarela='" & TextBox7.Text & "', " & _
                "Saldo='" & TextBox6.Text & "' where ID_Anggota='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(edit, CONN)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = UCase(TextBox1.Text)
        cmd = New OdbcCommand("select * from karyawan where Nip='" & TextBox1.Text & "'", CONN)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            TextBox2.Text = rd.Item(1)
            TextBox3.Text = rd.Item(2)
            TextBox4.Text = rd.Item(3)
        End If
    End Sub
    Private Sub BTNTutup_Click_1(sender As Object, e As EventArgs) Handles BTNTutup.Click
        Me.Close()
    End Sub
    Private Sub BTNBatal_Click_1(sender As Object, e As EventArgs) Handles BTNBatal.Click
        Call Kosongkan()
    End Sub
    Private Sub BTNHapus_Click_1(sender As Object, e As EventArgs) Handles BTNHapus.Click
        If TextBox1.Text = "" Then
            MsgBox("Isi kode Anggota terlebih dahulu")
            TextBox1.Focus()
            Exit Sub
        Else

            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OdbcCommand("delete  from Anggota where nip='" & TextBox1.Text & "'", CONN)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Call Kosongkan()
            End If
        End If
    End Sub
    Private Sub BTNSimpan_Click_1(sender As Object, e As EventArgs) Handles BTNSimpan.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            cmd = New OdbcCommand("Select * from Anggota where nip='" & TextBox1.Text & "'", CONN)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim tambah As String = "Insert into Anggota(nip, Nama, Alamat, Telepon, Simpanan_Wajib, Simpanan_Pokok, Simpanan_Sukarela, Saldo) values " & _
                "('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
                cmd = New OdbcCommand(tambah, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            Else
                Dim edit As String = "Update Anggota set " & _
                "Nama='" & TextBox2.Text & "', " & _
                "Alamat='" & TextBox3.Text & "', " & _
                "Telepon='" & TextBox4.Text & "', " & _
                "Simpanan_Wajib='" & TextBox5.Text & "', " & _
                "Simpanan_Pokok='" & TextBox6.Text & "', " & _
                "Simpanan_Sukarela='" & TextBox7.Text & "', " & _
                "Saldo='" & TextBox6.Text & "' where nip='" & TextBox1.Text & "'"
                cmd = New OdbcCommand(edit, Conn)
                cmd.ExecuteNonQuery()
                Call Kosongkan()
                Call Tampilkan()
            End If
        End If
    End Sub
End Class