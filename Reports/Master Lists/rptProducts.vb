Imports DevExpress.XtraReports.UI

Public Class rptProducts
    Dim cnt = 0
    Private Sub XrTableCell18_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell18.BeforePrint
        cnt += 1
        CType(sender, XRTableCell).Text = cnt
    End Sub
End Class