Imports CrystalDecisions.CrystalReports.Engine
Public Class Laporandatakaryawan
    Public cryrpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        cryrpt.Load("D:\DOCUMENT TUGAS\VB\GAJI PUNYA PIUS\Prakerin2\CrLapKaryawan.rpt")
        CrystalReportViewer1.ReportSource = cryrpt
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class