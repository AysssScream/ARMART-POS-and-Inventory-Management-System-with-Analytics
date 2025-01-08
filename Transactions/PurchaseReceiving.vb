Public Class PurchaseReceiving
    Private Sub PurchaseReceiving_BeforeRecordSave(ByRef Cancel As Boolean) Handles Me.BeforeRecordSave
        Try
            GrpSubTotal.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("SubTotalAmount_LdgrInvty")).ToString("n2")

            GrpDiscount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TotalDiscountAmount_LdgrInvty")).ToString("n2")

            GrpNetOfTax.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("NetOfTax_LdgrInvty")).ToString("n2")

            GrpTaxAmount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TaxAmount_LdgrInvty")).ToString("n2")

            GrpTotalAmount.PtNumericInput1.Value = sg__transaction_ledger_inventories.FieldTotal("TotalAmount_LdgrInvty")
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

    Private Sub PttGridLookupEditGroup1_EditValueChanged() Handles gleSupplier.EditValueChanged
        Try
            If Me.FormState = EditorState.EditMode Then
                Dim sql As String = String.Format("Select Terms_UM from universal_masters where pk_um = '{0}'", gleSupplier.PtGridLookUpEdit1.EditValue)
                Dim dt As DataTable = AppData.GetDataTable(sql)
                PTTerm.PtNumericInput1.Value = StrVal9(dt.Rows(0)("Terms_UM")).ToString("n0")
            End If
            If gleSupplier.PtGridLookUpEdit1.EditValue <> "" Then
                PttGridLookupEditGroup2.Enabled = True
                PttGridLookupEditGroup2.PtGridLookUpEdit1.AdditionalFilter = String.Format(" FK_UM_TransH = '{0}'", gleSupplier.PtGridLookUpEdit1.EditValue)
            Else
                PttGridLookupEditGroup2.Enabled = False
                PttGridLookupEditGroup2.PtGridLookUpEdit1.AdditionalFilter = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PttGridLookupEditGroup2_EditValueChanged() Handles PttGridLookupEditGroup2.EditValueChanged
        Try
            If (_FormState = EditorState.EditMode Or _FormState = EditorState.AddMode) And Not IsNothing(PttGridLookupEditGroup2.PtGridLookUpEdit1.EditValue) Then

                With sg__transaction_ledger_inventories
                    If .RowCount > 0 Then
                        .ForceInitialize()
                        For i As Integer = 0 To .RowCount - 1
                            .RowPosition = i
                            .DeleteRow()
                        Next
                        .RefreshData()
                    End If
                End With

                Dim sqlx As String = String.Format("Select Cost_LdgrInvtyLog,Rate_LdgrInvtyLog,UnitConversion_LdgrInvtyLog,FK_Invty_LdgrInvtyLog,PK_TransH,PK_LdgrInvtyLog,QtyIn_LdgrInvtyLog,QtyRR_LdgrInvtyLog,UOM_LdgrInvtyLog,ItemCode_Invty,FK_COAAsset_Invty,FK_UM_TransH,Description_Invty,Particulars_LdgrInvtyLog,DiscountPercent_LdgrInvtyLog,TaxPercent_LdgrInvtyLog " &
                           "FROM transaction_headers LEFT JOIN Transaction_Ledger_Inventorylogs LEFT JOIN Inventories ON FK_Invty_LdgrInvtyLog = PK_Invty ON PK_TransH = FK_TransH_LdgrInvtyLog WHERE FK_TransH_LdgrInvtyLog<>0 And Module_LdgrInvtyLog  = 'PO' AND FK_TransH_LdgrInvtyLog = '{0}'", PttGridLookupEditGroup2.PtGridLookUpEdit1.EditValue)
                Dim dtx As DataTable = AppData.GetDataTable(sqlx)

                If dtx.Rows.Count <> 0 Then
                    gleSupplier.PtGridLookUpEdit1.EditValue = dtx.Rows(0)("FK_UM_TransH")
                    For i As Integer = 0 To dtx.Rows.Count - 1
                        With sg__transaction_ledger_inventories
                            'Dim sqlRR As String = String.Format("Select SUM(QtyIn_LdgrInvty) as qtyrr from transaction_ledger_inventories where module_ldgrinvty = 'IN' AND FK_LdgrInvtyLog_LdgrInvty = '{0}'", dtx.Rows(i)("PK_LdgrInvtyLog"))
                            'Dim dtRR As DataTable = AppData.GetDataTable(sqlRR)
                            .AddNewRow()
                            .Field("FK_Invty_LdgrInvty") = dtx.Rows(i)("FK_Invty_LdgrInvtyLog")
                            .Field("FK_TransHSL_LdgrInvty") = dtx.Rows(i)("PK_TransH")
                            .Field("FK_LdgrInvtyLog_LdgrInvty") = dtx.Rows(i)("PK_LdgrInvtyLog")
                            .Field("QtyIn_LdgrInvtyLog") = dtx.Rows(i)("QtyIn_LdgrInvtyLog")
                            .Field("QtyRR_LdgrInvtyLog") = dtx.Rows(i)("QtyRR_LdgrInvtyLog")
                            .Field("UOM_LdgrInvty") = dtx.Rows(i)("UOM_LdgrInvtyLog")
                            .Field("ItemCode_Invty") = dtx.Rows(i)("ItemCode_Invty").ToString
                            .Field("Description_Invty") = dtx.Rows(i)("Description_Invty").ToString
                            .Field("Particulars_LdgrInvty") = dtx.Rows(i)("Particulars_LdgrInvtyLog")
                            .Field("DiscountPercent_LdgrInvty") = dtx.Rows(i)("DiscountPercent_LdgrInvtyLog")
                            .Field("TaxPercent_LdgrInvty") = dtx.Rows(i)("TaxPercent_LdgrInvtyLog")
                            .Field("Module_LdgrInvty") = "IN"
                            .Field("Cost_LdgrInvty") = dtx.Rows(i)("Cost_LdgrInvtyLog")
                            .Field("Rate_LdgrInvty") = dtx.Rows(i)("Rate_LdgrInvtyLog")
                            .Field("UnitConversion_LdgrInvty") = dtx.Rows(i)("UnitConversion_LdgrInvtyLog")
                            .Refresh()
                        End With
                    Next

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PurchaseReceiving_AfterRecordSave() Handles Me.AfterRecordSave
        Try
            UpdatePOStatus(PttGridLookupEditGroup2.PtGridLookUpEdit1.EditValue)
            UpdateAPStatus(txtPK.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName.ToLower = "cost_ldgrinvty" Or
                e.Column.FieldName.ToLower = "qtyin_ldgrinvty" Or
                e.Column.FieldName.ToLower = "discountpercent_ldgrinvty" Or
                e.Column.FieldName.ToLower = "taxpercent_ldgrinvty" Then
                With sg__transaction_ledger_inventories
                    Dim rate = StrVal9(.Field("Rate_LdgrInvty"))
                    Dim unitconversion = StrVal9(.Field("UnitConversion_LdgrInvty"))
                    Dim qty = StrVal9(.Field("QtyIn_LdgrInvty"))
                    Dim discpercent = StrVal9(.Field("DiscountPercent_LdgrInvty"))
                    Dim taxpercent = StrVal9(.Field("TaxPercent_LdgrInvty"))
                    Dim cost = StrVal9(.Field("Cost_LdgrInvty"))
                    Dim discamount = cost * discpercent / 100
                    Dim totaldisc = discamount * qty
                    Dim netoftax = qty * cost - totaldisc
                    Dim taxamount = netoftax * taxpercent / 100

                    .Field("SubTotalAmount_LdgrInvty") = qty * cost
                    .Field("DiscountAmount_LdgrInvty") = discamount
                    .Field("TotalDiscountAmount_LdgrInvty") = totaldisc
                    .Field("NetOfTax_LdgrInvty") = netoftax
                    .Field("TaxAmount_LdgrInvty") = taxamount
                    .Field("TotalAmount_LdgrInvty") = netoftax + taxamount
                End With
                lblSubTotal.Text = StrVal9(sg__transaction_ledger_inventories.FieldTotal("SubTotalAmount_LdgrInvty")).ToString("n2")

                lblDiscount.Text = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TotalDiscountAmount_LdgrInvty")).ToString("n2")

                lblNetOfTax.Text = StrVal9(sg__transaction_ledger_inventories.FieldTotal("NetOfTax_LdgrInvty")).ToString("n2")

                lblTaxAmount.Text = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TaxAmount_LdgrInvty")).ToString("n2")

                lblGrossAmount.Text = sg__transaction_ledger_inventories.FieldTotal("TotalAmount_LdgrInvty")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GrpTaxAmount_ValueChanged() Handles GrpTotalAmount.ValueChanged, GrpTaxAmount.ValueChanged, GrpSubTotal.ValueChanged, GrpNetOfTax.ValueChanged, GrpDiscount.ValueChanged, GrpTotalAmountDue.ValueChanged

        lblSubTotal.Text = StrVal9(GrpSubTotal.PtNumericInput1.Value).ToString("n2")

        lblDiscount.Text = StrVal9(GrpDiscount.PtNumericInput1.Value).ToString("n2")

        lblNetOfTax.Text = StrVal9(GrpNetOfTax.PtNumericInput1.Value).ToString("n2")

        lblTaxAmount.Text = StrVal9(GrpTaxAmount.PtNumericInput1.Value).ToString("n2")

        lblGrossAmount.Text = StrVal9(GrpTotalAmount.PtNumericInput1.Value).ToString("n2")

        lblAmountDue.Text = StrVal9(GrpTotalAmountDue.PtNumericInput1.Value).ToString("n2")
    End Sub

    Private Sub PTTerm_ValueChanged() Handles PTTerm.ValueChanged
        Try
            If Me.FormState = EditorState.EditMode Then
                Dim term As Integer = StrVal9(PTTerm.PtNumericInput1.Value)
                dateDue.EditValue = DateValue(dateCreated.EditValue).AddDays(term)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PtDateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles dateCreated.EditValueChanged
        Try
            If Me.FormState = EditorState.EditMode Then
                Dim term As Integer = StrVal9(PTTerm.PtNumericInput1.Value)
                dateDue.EditValue = DateValue(dateCreated.EditValue).AddDays(term)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GrpStatus_EditValueChanged() Handles GrpStatus.EditValueChanged
        lblStatus.Text = GrpStatus.PtTextInputGrp1.Text
    End Sub

    Private Sub PurchaseReceiving_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabControl1.TabPages.RemoveAt(1)
    End Sub
End Class
