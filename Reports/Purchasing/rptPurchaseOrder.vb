Imports DevExpress.XtraReports.UI

Public Class rptPurchaseOrder
    Dim cnt = 0
    Private Sub XrTableCell18_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell18.BeforePrint
        cnt += 1
        CType(sender, XRTableCell).Text = cnt
    End Sub

    Private Sub XrTableCell37_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell37.BeforePrint
        CType(sender, XRTableCell).Text = Project.Instance.ActiveUser.Name
    End Sub
End Class