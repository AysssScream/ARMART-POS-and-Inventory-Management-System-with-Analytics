Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class rptCriticalStocks

    Private previousBalance = 0
    Private runningBalance = 0
    Private cnt = 0
    Private Sub rptStockCard_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        cnt = 0
    End Sub

    Private Sub XrTableCell6_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrTableCell6.BeforePrint
        cnt += 1
        CType(sender, XRTableCell).Text = cnt
    End Sub
End Class