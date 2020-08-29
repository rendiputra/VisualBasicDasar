

Imports System.Data.OleDb
Module mdb
    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" &
        Application.StartupPath & "/dbcoba.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(constring)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Public Sub ambil_last_id(sql As String, ByRef pangka As Integer)
        Dim dt As New DataTable
        Dim id_awal As String
        Dim angka As Integer
        'sql
        cmd = New OleDbCommand(sql, con)
        'OPEN CON,RETIEVE ,FILL DGVIEW
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)
            'FILL DGVIEW
            If dt.Rows.Count > 0 Then
                id_awal = dt.Rows(0)(0).ToString()
                angka = Microsoft.VisualBasic.Right(id_awal, 2)
                angka = +1
            Else
                angka = 1
            End If
            con.Close()
            'CLEAR DT
            dt.Rows.Clear()


        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
        pangka = angka
    End Sub
    Public Sub insertdb(sql As String)
        cmd = New oledbcommand(sql, con)
        'OPEN CON, EXECUTE UPDATE, CLOSE'
        Try
            Con.open()
            If cmd.executenonquery() > 0 Then
                msgox("successfully inserted")
            End If
            Con.close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try
    End Sub
End Module
