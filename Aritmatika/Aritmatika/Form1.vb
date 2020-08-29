Public Class Form1
    Friend hasil As Single = 0
    Dim operasi As String = ""
    Dim operasihit As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        operasihit = False
        operasi = ""
        hasil = 0
        txtlayar.Text = "0"
    End Sub



    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        txtlayar.Text = "0"
        operasi = ""
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "0"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "0"
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "1"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "2"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "3"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "4"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "5"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "6"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "7"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "8"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If operasihit = True Or txtlayar.Text = "0" Then
            txtlayar.Text = "9"
            operasihit = False
        Else
            txtlayar.Text = txtlayar.Text + "9"
        End If
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        operasi = "tambah"
        hasil = Val(txtlayar.Text)
        operasihit = True
    End Sub

    Private Sub btnkurang_Click(sender As Object, e As EventArgs) Handles btnkurang.Click
        operasi = "kurang"
        hasil = Val(txtlayar.Text)
        operasihit = True
    End Sub

    Private Sub btnbagi_Click(sender As Object, e As EventArgs) Handles btnbagi.Click
        operasi = "bagi"
        hasil = Val(txtlayar.Text)
        operasihit = True
    End Sub

    Private Sub btnkali_Click(sender As Object, e As EventArgs) Handles btnkali.Click
        operasi = "kali"
        hasil = Val(txtlayar.Text)
        operasihit = True
    End Sub

    Private Sub btnsamadengan_Click(sender As Object, e As EventArgs) Handles btnsamadengan.Click
        Select Case operasi
            Case "kali"
                hasil = hasil * Val(txtlayar.Text)
            Case "bagi"
                hasil = hasil / Val(txtlayar.Text)
            Case "kurang"
                hasil = hasil - Val(txtlayar.Text)
            Case "tambah"
                hasil = hasil + Val(txtlayar.Text)
            Case "pangkat"
                hasil = hasil * hasil
        End Select
        txtlayar.Text = hasil
        operasihit = True

    End Sub

    Private Sub btnpangkat_Click(sender As Object, e As EventArgs) Handles btnpangkat.Click
        operasi = "pangkat"
        hasil = Val(txtlayar.Text)
        operasihit = True
    End Sub
End Class
