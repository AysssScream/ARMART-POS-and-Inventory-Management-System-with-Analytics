Imports DevExpress.XtraGrid.Views.Grid

Public Class StockAdjustment
    Private Sub StockAdjustment_BeforeRecordSave(ByRef Cancel As Boolean) Handles Me.BeforeRecordSave
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

    Private Sub PickProducts_AfterReturnValues(GridName As String) Handles PickProducts.AfterReturnValues
        Try
            'With sg__transaction_ledger_inventories
            '    .RowPosition = GridView1.FocusedRowHandle
            '    .Field("SystemStockCount_LdgrInvty") = .Field("QtyCount_LdgrInvty")
            'End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName.ToLower = "actualstockcount_ldgrinvty" Then
                With sg__transaction_ledger_inventories
                    Dim systemCount = StrVal9(.Field("SystemStockCount_LdgrInvty"))
                    Dim actualCount = StrVal9(.Field("ActualStockCount_LdgrInvty"))

                    If systemCount - actualCount > 0 Then
                        .Field("QtyIn_LdgrInvty") = 0
                        .Field("QtyOut_LdgrInvty") = systemCount - actualCount
                        .Field("Module_LdgrInvty") = "OUT"
                        .Field("QuantityAdjust_LdgrInvty") = actualCount - systemCount
                    ElseIf systemCount - actualCount < 0 Then
                        .Field("QtyOut_LdgrInvty") = 0
                        .Field("QtyIn_LdgrInvty") = actualCount - systemCount
                        .Field("Module_LdgrInvty") = "IN"
                        .Field("QuantityAdjust_LdgrInvty") = actualCount - systemCount
                    Else
                        .Field("QtyOut_LdgrInvty") = 0
                        .Field("QtyIn_LdgrInvty") = 0
                        .Field("Module_LdgrInvty") = "X"
                        .Field("QuantityAdjust_LdgrInvty") = 0
                    End If
                    .Field("TotalAmount_LdgrInvty") = StrVal9(.Field("Cost_LdgrInvty")) * StrVal9(.Field("QuantityAdjust_LdgrInvty"))
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click

    End Sub

    Private Sub StockAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabControl1.TabPages.RemoveAt(1)
    End Sub
End Class
