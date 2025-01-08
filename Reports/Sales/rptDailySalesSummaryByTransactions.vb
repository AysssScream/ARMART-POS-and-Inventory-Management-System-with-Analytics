Imports DevExpress.XtraReports.UI

Public Class rptDailySalesSummaryByTransactions
    Private Sub XrTableCell10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell10.BeforePrint
        CType(sender, XRTableCell).Text = CType(sender, XRTableCell).Text.Replace("Invoice", "")
    End Sub
End Class