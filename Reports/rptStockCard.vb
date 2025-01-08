Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Public Class rptStockCard

    Private previousBalance = 0
    Private runningBalance = 0
    Private Sub rptStockCard_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint
        previousBalance = 0
        runningBalance = 0
    End Sub

    Private Sub XrTableCell15_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrTableCell15.BeforePrint
        Try
            runningBalance += StrVal9(StrVal9(GetCurrentColumnValue("QtyIn_LdgrInvty")) - StrVal9(GetCurrentColumnValue("QtyOut_LdgrInvty"))).ToString("n2")
            CType(sender, XRTableCell).Text = StrVal9(runningBalance).ToString("n0")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupHeader2_BeforePrint(sender As Object, e As PrintEventArgs) Handles GroupHeader2.BeforePrint
        previousBalance = 0
        runningBalance = 0

        Dim prevDate As Date
        Dim dateFilter = lblReportDate.Text.ToLower
        If dateFilter.Contains("as of") Then
            GroupHeader1.Visible = False
            Exit Sub
        Else
            GroupHeader1.Visible = True
            If dateFilter.Contains("to") Then
                prevDate = DateAdd("d", -1, dateFilter.Split(" to ")(0))
            Else
                prevDate = DateAdd("d", -1, dateFilter)
            End If
        End If

        Dim sql As String = String.Format("Select IFNULL(SUM(QtyIn_LdgrInvty) - SUM(QtyOut_LdgrInvty),0) as prevBalance From transaction_ledger_inventories left join transaction_headers on fk_transh_ldgrinvty = pk_transh where date_transh <= '{0}' AND fk_invty_ldgrinvty = '{1}'", prevDate.ToString("yyyy-MM-dd"), GetCurrentColumnValue("PK_Invty"))
        Dim dt As DataTable = AppData.GetDataTable(sql)
        runningBalance = dt.Rows(0)("prevBalance")
    End Sub

    Private Sub XrTableCell22_BeforePrint(sender As Object, e As PrintEventArgs) Handles XrTableCell22.BeforePrint
        Try
            CType(sender, XRTableCell).Text = StrVal9(runningBalance).ToString("n0")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReportLabel1_BeforePrint(sender As Object, e As PrintEventArgs) Handles ReportLabel1.BeforePrint
        CType(sender, ReportLabel).Text = StrVal9(runningBalance).ToString("n0")
    End Sub
End Class