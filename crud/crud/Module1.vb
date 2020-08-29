Imports System.Data
Imports System.Data.Sql

Module Module1
    Public database As OleDb.OleDbCommand
    Public Sub koneksi()
        Public database = New OleDb.OleDbConnection("provider=SQL.OleDb.1:intergrated security=SSPI; security info=false; initial catalog=dbsiswa; data source=SQLEXPRESS")
    database.open()
    Catch ex As Exception
        msgbox(ex.tostring)
End Module
