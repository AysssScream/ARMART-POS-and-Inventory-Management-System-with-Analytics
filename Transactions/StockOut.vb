Public Class StockOut
    Private Sub StockOut_BeforeRecordSave(ByRef Cancel As Boolean) Handles Me.BeforeRecordSave
        Try
            PtNumericInputGroup1.PtNumericInput1.Value = sg__transaction_ledger_inventories.FieldTotal("TotalAmount_LdgrInvty")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PickUnits_AdditionalWhereEvent(ByRef AddWhereClause As String) Handles PickUnits.AdditionalWhereEvent
        Try
            With sg__transaction_ledger_inventories
                .RowPosition = GridView1.FocusedRowHandle
                AddWhereClause = String.Format("FK_Invty_InvtyU = '{0}'", .Field("FK_Invty_LdgrInvty").ToString)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub sg__transaction_ledger_entries_Click(sender As Object, e As EventArgs) Handles sg__transaction_ledger_entries.Click

    End Sub

    Private Sub StockOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sg__transaction_ledger_entries.Visible = False  ' Add this line to hide the GL IMPACT section
        XtraTabControl1.TabPages.RemoveAt(1)
    End Sub

    Private Sub PtUserPKInput1_EditValueChanged(sender As Object, e As EventArgs) Handles PtUserPKInput1.EditValueChanged

    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click

    End Sub

    Private Sub sg__transaction_ledger_inventories_Click(sender As Object, e As EventArgs) Handles sg__transaction_ledger_inventories.Click

    End Sub
End Class
