Imports DevExpress.XtraReports.UI

Public Class rptDailyPurchaseOrdersSummaryByTransactions
    Private Sub XrTableCell10_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell10.BeforePrint
        CType(sender, XRTableCell).Text = CType(sender, XRTableCell).Text.Replace("PARTIALLY", "PARTIAL")
    End Sub
End Class