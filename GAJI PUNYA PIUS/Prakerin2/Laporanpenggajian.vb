Imports CrystalDecisions.CrystalReports.Engine
Public Class Laporanpenggajian
    Public cryrpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        cryrpt.Load("C:\Users\Yudha\Desktop\Prakerin2\Prakerin2\CrLapPenggajian.rpt")
        CrystalReportViewer1.ReportSource = cryrpt
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class