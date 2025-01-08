Public Class StockEntry
    Private Sub StockEntry_BeforeRecordSave(ByRef Cancel As Boolean) Handles Me.BeforeRecordSave
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

    Private Sub StockEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabControl1.TabPages.RemoveAt(1)
    End Sub
End Class
