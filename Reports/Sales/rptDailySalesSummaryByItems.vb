Imports DevExpress.XtraReports.UI

Public Class rptDailySalesSummaryByItems
    Dim cnt = 0
    Private Sub XrTableCell8_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell8.BeforePrint
        cnt += 1
        CType(sender, XRTableCell).Text = cnt
    End Sub
End Class