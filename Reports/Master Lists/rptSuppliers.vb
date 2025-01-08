Imports DevExpress.XtraReports.UI

Public Class rptSuppliers
    Dim cnt = 0
    Private Sub XrTableCell9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell9.BeforePrint
        cnt += 1
        CType(sender, XRTableCell).Text = cnt
    End Sub
End Class