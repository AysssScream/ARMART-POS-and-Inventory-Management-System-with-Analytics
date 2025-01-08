Public Class PurchaseOrder
    Private Sub PurchaseOrder_BeforeRecordSave(ByRef Cancel As Boolean) Handles Me.BeforeRecordSave
        Try


            GrpSubTotal.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventorylogs.FieldTotal("SubTotalAmount_LdgrInvtyLog")).ToString("n2")

            GrpDiscount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventorylogs.FieldTotal("TotalDiscountAmount_LdgrInvtyLog")).ToString("n2")

            GrpNetOfTax.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventorylogs.FieldTotal("NetOfTax_LdgrInvtyLog")).ToString("n2")

            GrpTaxAmount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventorylogs.FieldTotal("TaxAmount_LdgrInvtyLog")).ToString("n2")

            GrpTotalAmount.PtNumericInput1.Value = sg__transaction_ledger_inventorylogs.FieldTotal("TotalAmount_LdgrInvtyLog")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PickUnits_AdditionalWhereEvent(ByRef AddWhereClause As String) Handles PickUnits.AdditionalWhereEvent
        Try
            With sg__transaction_ledger_inventorylogs
                .RowPosition = GridView1.FocusedRowHandle
                AddWhereClause = String.Format("FK_Invty_InvtyU = '{0}'", .Field("FK_Invty_LdgrInvtyLog").ToString)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PurchaseOrder_AfterRecordSave() Handles Me.AfterRecordSave
        Try
            UpdatePOStatus(txtPK.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName.ToLower = "rate_ldgrinvtylog" Or
                e.Column.FieldName.ToLower = "qtyin_ldgrinvtylog" Or
                e.Column.FieldName.ToLower = "unitconversion_ldgrinvtylog" Or
                e.Column.FieldName.ToLower = "discountpercent_ldgrinvtylog" Or
                e.Column.FieldName.ToLower = "taxpercent_ldgrinvtylog" Then
                With sg__transaction_ledger_inventorylogs
                    Dim rate = StrVal9(.Field("Rate_LdgrInvtyLog"))
                    Dim unitconversion = StrVal9(.Field("UnitConversion_LdgrInvtyLog"))
                    Dim qty = StrVal9(.Field("QtyIn_LdgrInvtyLog"))
                    Dim discpercent = StrVal9(.Field("DiscountPercent_LdgrInvtyLog"))
                    Dim taxpercent = StrVal9(.Field("TaxPercent_LdgrInvtyLog"))
                    Dim cost = rate / unitconversion
                    Dim discamount = cost * discpercent / 100
                    Dim totaldisc = discamount * qty
                    Dim netoftax = qty * cost - totaldisc
                    Dim taxamount = netoftax * taxpercent / 100

                    .Field("Cost_LdgrInvtyLog") = cost
                    .Field("SubTotalAmount_LdgrInvtyLog") = qty * cost
                    .Field("DiscountAmount_LdgrInvtyLog") = discamount
                    .Field("TotalDiscountAmount_LdgrInvtyLog") = totaldisc
                    .Field("NetOfTax_LdgrInvtyLog") = netoftax
                    .Field("TaxAmount_LdgrInvtyLog") = taxamount
                    .Field("TotalAmount_LdgrInvtyLog") = netoftax + taxamount
                End With
                lblSubTotal.Text = StrVal9(sg__transaction_ledger_inventorylogs.FieldTotal("SubTotalAmount_LdgrInvtyLog")).ToString("n2")

                lblDiscount.Text = StrVal9(sg__transaction_ledger_inventorylogs.FieldTotal("TotalDiscountAmount_LdgrInvtyLog")).ToString("n2")

                lblNetOfTax.Text = StrVal9(sg__transaction_ledger_inventorylogs.FieldTotal("NetOfTax_LdgrInvtyLog")).ToString("n2")

                lblTaxAmount.Text = StrVal9(sg__transaction_ledger_inventorylogs.FieldTotal("TaxAmount_LdgrInvtyLog")).ToString("n2")

                lblGrossAmount.Text = sg__transaction_ledger_inventorylogs.FieldTotal("TotalAmount_LdgrInvtyLog")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GrpTaxAmount_ValueChanged() Handles GrpTotalAmount.ValueChanged, GrpTaxAmount.ValueChanged, GrpSubTotal.ValueChanged, GrpNetOfTax.ValueChanged, GrpDiscount.ValueChanged

        lblSubTotal.Text = StrVal9(GrpSubTotal.PtNumericInput1.Value).ToString("n2")

        lblDiscount.Text = StrVal9(GrpDiscount.PtNumericInput1.Value).ToString("n2")

        lblNetOfTax.Text = StrVal9(GrpNetOfTax.PtNumericInput1.Value).ToString("n2")

        lblTaxAmount.Text = StrVal9(GrpTaxAmount.PtNumericInput1.Value).ToString("n2")

        lblGrossAmount.Text = StrVal9(GrpTotalAmount.PtNumericInput1.Value).ToString("n2")
    End Sub

    Private Sub GrpStatus_EditValueChanged() Handles GrpStatus.EditValueChanged
        lblStatus.Text = GrpStatus.PtTextInputGrp1.Text
    End Sub

    Private Sub PtTextInputGroup2_EditValueChanged() Handles GrpSubStatus.EditValueChanged
        lblSubStatus.Text = GrpSubStatus.PtTextInputGrp1.Text
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If Me.FormState = EditorState.EditMode Or Me.FormState = EditorState.ViewMode Then
                If Project.Instance.ActiveAccountType = "Admin" Then
                    Dim sqlApproved As String = String.Format("Update transaction_headers set SubStatus_TransH = 'APPROVED', ApprovedBy_TransH = '{0}' where PK_TransH = '{1}'", Project.Instance.ActiveUser.Name, txtPK.Text)
                    AppData.GetDataTable(sqlApproved)
                    GrpSubStatus.PtTextInputGrp1.Text = "APPROVED"
                    lblSubStatus.Text = "APPROVED"
                    MsgBox("Approved.")
                Else
                    MsgBox("You don't have permission to approved. Please ask your admin.")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
