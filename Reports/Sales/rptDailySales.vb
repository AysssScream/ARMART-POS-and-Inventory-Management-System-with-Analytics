Imports DevExpress.XtraReports.UI

Public Class rptDailySales
    Dim cnt = 0
    Private Sub XrTableCell8_BeforePrint_1(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell8.BeforePrint
        cnt += 1
        CType(sender, XRTableCell).Text = cnt
    End Sub

    Private Sub GroupHeader1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        cnt = 0
    End Sub
End Class