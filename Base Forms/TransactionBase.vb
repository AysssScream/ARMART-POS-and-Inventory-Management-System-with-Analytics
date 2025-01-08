Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid

Public Class TransactionBase
    Public Enum TransactionTypesEnum
        None
        CashInvoice
        ChargeInvoice
        ReceivingReport
        StockEntry
        StockOut
        StockAdjustment
        Custom
    End Enum

    Private Delegate Sub UpdateOnHandAsyncDelegate(ByVal itemsGrid As DetailGrid)
    Private Delegate Sub UpdateEntriesPosting(ByVal entriedGrid As DetailGrid)

    Private _ItemsGrid As DetailGrid
    Private _EntriesGrid As DetailGrid
    Private _TransactionType As TransactionTypesEnum
    Private _TransactAccount As BaseEdit
    Private _TransactAccountPT As PTGridLookupEditGroup
    Private _DetailTotalControl As BaseEdit
    Private _DateControl As DateEdit
    Private _DateDueControl As DateEdit
    Protected clsGE As GenerateAccountingEntries '(Me.EntriesGrid)

    Private DefaultNewItems As DetailGrid
    Private ReferenceNo As Long
    Private AddNewRecordOnLoad As Boolean

#Region "DEFAULT ACCOUNT ENTRIES"
    Protected Overridable Function GetInventoryReceivedNotBilledCOA() As String
        Return AppData.GetPKCOA("Inventory Received Not Billed")
    End Function
    Protected Overridable Function GetVATOnPurchasesCOA() As String
        Return AppData.GetPKCOA("VAT on Purchases")
    End Function
    Protected Overridable Function GetVATOnSalesCOA() As String
        Return AppData.GetPKCOA("VAT on Sales")
    End Function
    Protected Overridable Function GetPurchaseDiscountCOA() As String
        Return AppData.GetPKCOA("Purchase Discount")
    End Function
    Protected Overridable Function GetAccountsPayableCOA() As String
        Return AppData.GetPKCOA("Accounts Payable")
    End Function
    Protected Overridable Function GetCWTCOA() As String
        Return AppData.GetPKCOA("Creditable Withholding Tax ")
    End Function

    Protected Overridable Function GetAccountsReceivableCOA() As String
        Return AppData.GetPKCOA("Accounts Receivable")
    End Function

    Protected Overridable Function GetCashInBankCOA() As String
        Return AppData.GetPKCOA("Cash in Bank")
    End Function

    Protected Overridable Function GetCashOnHandCOA() As String
        Return AppData.GetPKCOA("Cash on Hand")
    End Function
    Protected Overridable Function GetUndepositedFundsCOA() As String
        Return AppData.GetPKCOA("Undeposited Funds")
    End Function

    Protected Overridable Function GetSalesDisccountCOA() As String
        Return AppData.GetPKCOA("Sales Discount")
    End Function

    Protected Overridable Function GetInventoryCOA() As String
        Return AppData.GetPKCOA("Inventory")
    End Function
    Protected Overridable Function GetConsignmentInventoryCOA() As String
        Return AppData.GetPKCOA("Consignment Inventory")
    End Function

    Protected Overridable Function GetCOGSCOA() As String
        Return AppData.GetPKCOA("Cost of Goods Sold")
    End Function

    Protected Overridable Function GetSalesCOA() As String
        Return AppData.GetPKCOA("Sales")
    End Function

    Protected Overridable Function GetUserPKCOA(ByVal pk As String) As String
        Return AppData.GetUserPKCOA(pk)
    End Function

    Protected Overridable Function GetTitleCOA(ByVal pk As String) As String
        Return AppData.GetTitleCOA(pk)
    End Function
#End Region

    <DefaultValue(TransactionTypesEnum.None)>
    Public Property TransactionType() As TransactionTypesEnum
        Get
            Return _TransactionType
        End Get
        Set(ByVal value As TransactionTypesEnum)
            _TransactionType = value
        End Set
    End Property

    Public Property TransactAccount() As BaseEdit
        Get
            Return _TransactAccount
        End Get
        Set(ByVal value As BaseEdit)
            _TransactAccount = value
        End Set
    End Property

    Public Property TransactAccountPT() As PTGridLookupEditGroup
        Get
            Return _TransactAccountPT
        End Get
        Set(ByVal value As PTGridLookupEditGroup)
            _TransactAccountPT = value
        End Set
    End Property

    Public Property ItemsGrid() As DetailGrid
        Get
            Return _ItemsGrid
        End Get
        Set(ByVal value As DetailGrid)
            _ItemsGrid = value
        End Set
    End Property

    Public Property EntriesGrid() As DetailGrid
        Get
            Return _EntriesGrid
        End Get
        Set(ByVal value As DetailGrid)
            If Not IsNothing(value) Then
                _EntriesGrid = value
                Me.clsGE = New GenerateAccountingEntries(_EntriesGrid)
            End If

        End Set
    End Property

    Public Property DetailTotalControl() As BaseEdit
        Get
            Return _DetailTotalControl
        End Get
        Set(ByVal value As BaseEdit)
            _DetailTotalControl = value
        End Set
    End Property

    Public Property TransDateControl() As DateEdit
        Get
            Return _DateControl
        End Get
        Set(ByVal value As DateEdit)
            _DateControl = value
        End Set
    End Property

    Public Property TransDateDueControl() As DateEdit
        Get
            Return _DateDueControl
        End Get
        Set(ByVal value As DateEdit)
            _DateDueControl = value
        End Set
    End Property
    Protected Overrides Sub SaveDetailRecords()
        Try
            Dim oldARPK As String = ""
            Dim newARPK As String = ""
            'for update/ set code block to update entries instead of regenerating
            If Not IsNothing(Me.EntriesGrid) AndAlso Me.FormState = EditorState.EditMode Then
                With Me.EntriesGrid
                    .ForceInitialize()
                    If .RowCount > 0 Then
                        For i As Integer = Me.EntriesGrid.RowCount - 1 To 0 Step -1
                            .RowPosition = i
                            Dim str As String = If(IsDBNull(.Field("moduletrans_ldgrentries")), String.Empty, .Field("moduletrans_ldgrentries"))
                            If str = "PAY" Or str = "ADJ" Then
                                If .Field("type_coa").ToString.Contains("receivable") _
                                    OrElse .Field("type_coa").ToString.Contains("payable") Then
                                    .Field("FK_LdgrEntriesSL_LdgrEntries") = .Field("PK_LdgrEntries")
                                End If
                            Else
                                .DeleteRow()
                            End If

                        Next
                    End If
                    .RefreshData()
                End With
            End If

            Select Case Me.TransactionType
                Case TransactionTypesEnum.None

                Case TransactionTypesEnum.CashInvoice
                    Me.GenerateCashInvoiceEntries()
                Case TransactionTypesEnum.ChargeInvoice
                    Me.GenerateChargeInvoiceEntries()
                Case TransactionTypesEnum.ReceivingReport
                    Me.GenerateReceivingReportEntries()
                Case TransactionTypesEnum.StockEntry
                    Me.GenerateStockEntryEntries()
                Case TransactionTypesEnum.StockOut
                    Me.GenerateStockOutEntries()
                Case TransactionTypesEnum.StockAdjustment
                    Me.GenerateStockAdjustmentEntries()
                Case TransactionTypesEnum.Custom
                    Me.GenerateEntriesCustom()
            End Select


            MyBase.SaveDetailRecords()

            If Not IsNothing(Me.ItemsGrid) AndAlso Me.ItemsGrid.InventoryEnabled Then
                Dim UpdateInvetory As UpdateOnHandAsyncDelegate
                UpdateInvetory = New UpdateOnHandAsyncDelegate(AddressOf UpdateQuantityOnHand)

                UpdateInvetory.BeginInvoke(Me.ItemsGrid, Nothing, Nothing)
            End If

        Catch ex As Exception

        End Try


    End Sub

    Protected Overridable Sub GenerateEntriesCustom()

    End Sub
    Protected Overridable Sub GenerateCashInvoiceEntries()
        Try
            Me.EntriesGrid.ForceInitialize()
            Dim clsGE As New GenerateAccountingEntries(Me.EntriesGrid)

            Dim cashAmount As Double = StrVal9(Me.ItemsGrid.FieldTotal("TotalAmount_LdgrInvty"))
            Dim vatAmount As Double = StrVal9(Me.ItemsGrid.FieldTotal("TaxAmount_LdgrInvty"))
            Dim discAmount As Double = StrVal9(Me.ItemsGrid.FieldTotal("TotalDiscountAmount_LdgrInvty"))

            With clsGE
                'cash
                .AttachCOAValue = Me.GetCashOnHandCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccount.EditValue
                .AttachMeDebitAmountValue = cashAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .GenerateEntry()

                'discount
                .AttachCOAValue = Me.GetSalesDisccountCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccount.EditValue
                .AttachMeDebitAmountValue = discAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .GenerateEntry()

                'vat
                .AttachCOAValue = Me.GetVATOnSalesCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccount.EditValue
                .AttachMeCreditAmountValue = vatAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .GenerateEntry()

                For i As Integer = 0 To Me.ItemsGrid.RowCount - 1
                    Me.ItemsGrid.RowPosition = i

                    Dim saleAmount As Double = StrVal9(Me.ItemsGrid.Field("SubTotalAmount_LdgrInvty"))
                    Dim costAmount As Double = StrVal9(Me.ItemsGrid.Field("Cost_LdgrInvty")) * StrVal9(Me.ItemsGrid.Field("QtyOut_LdgrInvty"))

                    Dim cat As String = Me.ItemsGrid.Field("Name_Cat").ToString.ToLower

                    If cat <> "office supplies" Then
                        'cogs
                        .AttachCOAValue = Me.GetCOGSCOA ''Me.ItemsGrid.Field("FK_COACOGS_Invty")
                        .AttachMeFKTransHValue = Me.txtPK.Text
                        .AttachMeFKUMValue = Me.TransactAccount.EditValue
                        .AttachMeDebitAmountValue = costAmount
                        .AttachMeDateValue = Me.TransDateControl.EditValue
                        .GenerateEntry()

                        'asset
                        .AttachCOAValue = Me.GetInventoryCOA ''Me.ItemsGrid.Field("FK_COAAsset_Invty")
                        .AttachMeFKTransHValue = Me.txtPK.Text
                        .AttachMeFKUMValue = Me.TransactAccount.EditValue
                        .AttachMeCreditAmountValue = costAmount
                        .AttachMeDateValue = Me.TransDateControl.EditValue
                        .GenerateEntry()

                        'sales
                        .AttachCOAValue = Me.GetVATOnSalesCOA ''Me.ItemsGrid.Field("FK_COAIncome_Invty")
                        .AttachMeFKTransHValue = Me.txtPK.Text
                        .AttachMeFKUMValue = Me.TransactAccount.EditValue
                        .AttachMeCreditAmountValue = saleAmount
                        .AttachMeDateValue = Me.TransDateControl.EditValue
                        .GenerateEntry()
                    End If

                Next
            End With

        Catch ex As Exception

        End Try
    End Sub
    Protected Overridable Sub GenerateChargeInvoiceEntries()
        Try
            Me.EntriesGrid.ForceInitialize()
            Dim clsGE As New GenerateAccountingEntries(Me.EntriesGrid)

            Dim arAmount As Double = StrVal9(Me.ItemsGrid.FieldTotal("TotalAmount_LdgrInvty"))
            Dim vatAmount As Double = StrVal9(Me.ItemsGrid.FieldTotal("TaxAmount_LdgrInvty"))
            Dim discAmount As Double = StrVal9(Me.ItemsGrid.FieldTotal("TotalDiscountAmount_LdgrInvty"))

            With clsGE
                'ar
                .AttachCOAValue = Me.GetAccountsReceivableCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                .AttachMeDebitAmountValue = arAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .AttachMeDateDueValue = Me.TransDateDueControl.EditValue
                .AttachMeModule = "AR-GENENTRY"
                .GenerateEntry(Me.txtPK.Text)

                'discount
                .AttachCOAValue = Me.GetSalesDisccountCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                .AttachMeDebitAmountValue = discAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .AttachMeModule = "GENENTRY"
                .GenerateEntry()

                'vat
                .AttachCOAValue = Me.GetVATOnSalesCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                .AttachMeCreditAmountValue = vatAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .AttachMeModule = "GENENTRY"
                .GenerateEntry()

                For i As Integer = 0 To Me.ItemsGrid.RowCount - 1
                    Me.ItemsGrid.RowPosition = i

                    Dim saleAmount As Double = StrVal9(Me.ItemsGrid.Field("SubTotalAmount_LdgrInvty"))
                    Dim costAmount As Double = StrVal9(Me.ItemsGrid.Field("Cost_LdgrInvty")) * StrVal9(Me.ItemsGrid.Field("QtyOut_LdgrInvty"))

                    .AttachCOAValue = Me.GetCOGSCOA ''Me.ItemsGrid.Field("FK_COACOGS_Invty")
                    .AttachMeFKTransHValue = Me.txtPK.Text
                    .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                    .AttachMeDebitAmountValue = costAmount
                    .AttachMeDateValue = Me.TransDateControl.EditValue
                    .AttachMeModule = "GENENTRY"
                    .GenerateEntry()

                    'asset
                    .AttachCOAValue = Me.GetInventoryCOA ''Me.ItemsGrid.Field("FK_COAAsset_Invty")
                    .AttachMeFKTransHValue = Me.txtPK.Text
                    .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                    .AttachMeCreditAmountValue = costAmount
                    .AttachMeDateValue = Me.TransDateControl.EditValue
                    .AttachMeModule = "GENENTRY"
                    .GenerateEntry()

                    'sales
                    .AttachCOAValue = Me.GetSalesCOA ''Me.ItemsGrid.Field("FK_COAIncome_Invty")
                    .AttachMeFKTransHValue = Me.txtPK.Text
                    .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                    .AttachMeCreditAmountValue = saleAmount
                    .AttachMeDateValue = Me.TransDateControl.EditValue
                    .AttachMeModule = "GENENTRY"
                    .GenerateEntry()

                Next
            End With

        Catch ex As Exception

        End Try
    End Sub
    Protected Overridable Sub GenerateReceivingReportEntries()
        Try

            Me.EntriesGrid.ForceInitialize()
            Dim clsGE As New GenerateAccountingEntries(Me.EntriesGrid)

            Dim taxAmount As Double = Me.ItemsGrid.FieldTotal("TaxAmount_LdgrInvty")
            Dim discountAmount As Double = Me.ItemsGrid.FieldTotal("TotalDiscountAmount_LdgrInvty")
            Dim netOfTax As Double = Me.ItemsGrid.FieldTotal("NetOfTax_LdgrInvty")
            Dim inventory As Double = Me.ItemsGrid.FieldTotal("SubTotalAmount_LdgrInvty")

            With clsGE

                 .AttachCOAValue = Me.GetInventoryCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                .AttachMeDebitAmountValue = inventory
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .GenerateEntry()

                ''Tax
                .AttachCOAValue = Me.GetVATOnPurchasesCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                .AttachMeDebitAmountValue = taxAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .GenerateEntry()

                ''Discount
                .AttachCOAValue = Me.GetPurchaseDiscountCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                .AttachMeCreditAmountValue = discountAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .GenerateEntry()

                ''AP
                .AttachCOAValue = Me.GetAccountsPayableCOA
                .AttachMeFKTransHValue = Me.txtPK.Text
                .AttachMeFKUMValue = Me.TransactAccountPT.EditValue
                .AttachMeCreditAmountValue = netOfTax + taxAmount
                .AttachMeDateValue = Me.TransDateControl.EditValue
                .AttachMeDateDueValue = Me.TransDateDueControl.EditValue
                '.AttachMeDateDueValue = Me.TransDateDueControl.EditValue
                .AttachMeModule = "AP-GENENTRY"
                .GenerateEntry(Me.txtPK.Text)

            End With


        Catch ex As Exception

        End Try


    End Sub
    Protected Overridable Sub GenerateStockEntryEntries()
        Try
            Me.EntriesGrid.ForceInitialize()
            Dim clsGE As New GenerateAccountingEntries(Me.EntriesGrid)

            With clsGE
                For i As Integer = 0 To Me.ItemsGrid.RowCount - 1
                    Me.ItemsGrid.RowPosition = i

                    .AttachCOAValue = Me.GetInventoryCOA
                    .AttachMeFKTransHValue = Me.txtPK.Text
                    '.AttachMeFKUMValue = Me.TransactAccount.EditValue
                    .AttachMeDebitAmountValue = StrVal9(Me.ItemsGrid.Field("TotalAmount_LdgrInvty"))
                    .AttachMeDateValue = Me.TransDateControl.EditValue
                    .GenerateEntry()

                    .AttachCOAValue = Me.GetCOGSCOA
                    .AttachMeFKTransHValue = Me.txtPK.Text
                    '.AttachMeFKUMValue = Me.TransactAccount.EditValue
                    .AttachMeCreditAmountValue = StrVal9(Me.ItemsGrid.Field("TotalAmount_LdgrInvty"))
                    .AttachMeDateValue = Me.TransDateControl.EditValue
                    .GenerateEntry()

                Next
            End With
        Catch ex As Exception

        End Try
    End Sub
    Protected Overridable Sub GenerateStockOutEntries()
        Try
            Me.EntriesGrid.ForceInitialize()
            Dim clsGE As New GenerateAccountingEntries(Me.EntriesGrid)

            With clsGE
                For i As Integer = 0 To Me.ItemsGrid.RowCount - 1
                    Me.ItemsGrid.RowPosition = i

                    .AttachCOAValue = Me.GetCOGSCOA
                    .AttachMeFKTransHValue = Me.txtPK.Text
                    '.AttachMeFKUMValue = Me.TransactAccount.EditValue
                    .AttachMeDebitAmountValue = StrVal9(Me.ItemsGrid.Field("TotalAmount_LdgrInvty"))
                    .AttachMeDateValue = Me.TransDateControl.EditValue
                    .GenerateEntry()

                    .AttachCOAValue = Me.GetInventoryCOA
                    .AttachMeFKTransHValue = Me.txtPK.Text
                    '.AttachMeFKUMValue = Me.TransactAccount.EditValue
                    .AttachMeCreditAmountValue = StrVal9(Me.ItemsGrid.Field("TotalAmount_LdgrInvty"))
                    .AttachMeDateValue = Me.TransDateControl.EditValue
                    .GenerateEntry()

                Next
            End With
        Catch ex As Exception

        End Try
    End Sub
    Protected Overridable Sub GenerateStockAdjustmentEntries()
        Try
            Me.EntriesGrid.ForceInitialize()
            Dim clsGE As New GenerateAccountingEntries(Me.EntriesGrid)

            With clsGE
                For i As Integer = 0 To Me.ItemsGrid.RowCount - 1
                    Me.ItemsGrid.RowPosition = i

                    If StrVal9(Me.ItemsGrid.Field("QuantityAdjust_LdgrInvty")) > 0 Then
                        .AttachCOAValue = Me.GetInventoryCOA
                        .AttachMeFKTransHValue = Me.txtPK.Text
                        '.AttachMeFKUMValue = Me.TransactAccount.EditValue
                        .AttachMeDebitAmountValue = StrVal9(Me.ItemsGrid.Field("TotalAmount_LdgrInvty"))
                        .AttachMeDateValue = Me.TransDateControl.EditValue
                        .GenerateEntry()

                        .AttachCOAValue = Me.GetCOGSCOA
                        .AttachMeFKTransHValue = Me.txtPK.Text
                        '.AttachMeFKUMValue = Me.TransactAccount.EditValue
                        .AttachMeCreditAmountValue = StrVal9(Me.ItemsGrid.Field("TotalAmount_LdgrInvty"))
                        .AttachMeDateValue = Me.TransDateControl.EditValue
                        .GenerateEntry()
                    Else
                        .AttachCOAValue = Me.GetCOGSCOA
                        .AttachMeFKTransHValue = Me.txtPK.Text
                        '.AttachMeFKUMValue = Me.TransactAccount.EditValue
                        .AttachMeDebitAmountValue = StrVal9(Me.ItemsGrid.Field("TotalAmount_LdgrInvty")) * -1
                        .AttachMeDateValue = Me.TransDateControl.EditValue
                        .GenerateEntry()

                        .AttachCOAValue = Me.GetInventoryCOA
                        .AttachMeFKTransHValue = Me.txtPK.Text
                        '.AttachMeFKUMValue = Me.TransactAccount.EditValue
                        .AttachMeCreditAmountValue = StrVal9(Me.ItemsGrid.Field("TotalAmount_LdgrInvty")) * -1
                        .AttachMeDateValue = Me.TransDateControl.EditValue
                        .GenerateEntry()
                    End If
                Next
            End With
        Catch ex As Exception

        End Try
    End Sub

    Protected Overridable Sub UpdateQuantityOnHand(ByVal ItemsGrid As DetailGrid)

        Try
            If Me.InvokeRequired Then
                Me.Invoke(New CrossThreadMethodDelegate(AddressOf Me.UpdateQuantityOnHand), New Object() {ItemsGrid})
            Else
                If Not IsNothing(ItemsGrid) AndAlso Me.ItemsGrid.InventoryEnabled Then
                    Dim dtItems As DataTable = CType(ItemsGrid.DataSource, DataSet).Tables(0)
                    With dtItems
                        System.Threading.Thread.Sleep(50)
                        For i As Integer = .Rows.Count - 1 To 0 Step -1
                            UpdateInventory(.Rows(i)("FK_Invty_LdgrInvty").ToString)
                        Next
                    End With

                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub UpdateSOItems(ByVal ldgrinvtyPK As String, ByVal soQty As Double)
        Try
            Dim sqlInvoice As String = String.Format("Select IFNULL(SUM(QtyOut_LdgrInvty),0) as QtyOut_LdgrInvty from transaction_ledger_inventories where fk_ldgrinvtysl_ldgrinvty = '{0}' and module_ldgrinvty = 'OUT' AND IsVoid_LdgrInvty = 0", ldgrinvtyPK)
            Dim sqlDR As String = String.Format("Select IFNULL(SUM(QtyOut_LdgrInvty),0) as QtyOut_LdgrInvty from transaction_ledger_inventories left join transaction_headers on fk_transh_ldgrinvty = pk_transh where module_transh = 'DR' and fk_ldgrinvtylog_ldgrinvty = '{0}' and module_ldgrinvty = 'X' AND IsVoid_LdgrInvty = 0", ldgrinvtyPK)
            Dim invoiceQty = AppData.ExecuteScalar(sqlInvoice)
            Dim drQty = AppData.ExecuteScalar(sqlDR)
            Dim status = "OPEN"

            If invoiceQty > 0 Then
                If soQty > invoiceQty Then
                    status = "PARTIALLY INVOICE"
                ElseIf invoiceQty = soQty Then
                    status = "INVOICE"
                Else
                    status = "OVER"
                End If
            End If

            Dim sqlUpdate As String = String.Format("Update transaction_ledger_inventories SET Status_LdgrInvty = '{0}', QtyRR_LdgrInvty = '{1}', QtyBilled_LdgrInvty = '{2}' Where PK_LdgrInvty = '{3}'", status, invoiceQty, drQty, ldgrinvtyPK)
            AppData.ExecuteNonQuery(sqlUpdate)

        Catch ex As Exception

        End Try
    End Sub
    Public Sub UpdatePOItems(ByVal ldgrinvtylogPK As String, ByVal poQty As Double)
        Try
            Dim sql As String = String.Format("Select IFNULL(SUM(QtyIn_LdgrInvty),0) as QtyIn_LdgrInvty from transaction_ledger_inventories " &
                    "where fk_ldgrinvtylog_ldgrinvty = '{0}' and module_ldgrinvty = 'IN'  AND IsVoid_LdgrInvty = 0", ldgrinvtylogPK)
            Dim dt As DataTable = AppData.GetDataTable(sql)

            Dim sqlvb As String = String.Format("Select IFNULL(SUM(QtyIn_LdgrInvty),0) as QtyIn_LdgrInvty from transaction_ledger_inventories " &
                    "where fk_ldgrinvtylog_ldgrinvty = '{0}' and module_ldgrinvty = 'VB' AND IsVoid_LdgrInvty = 0", ldgrinvtylogPK)
            Dim dtvb As DataTable = AppData.GetDataTable(sqlvb)

            Dim rrQty As Double = dt.Rows(0)("QtyIn_LdgrInvty")
            Dim vbQty As Double = dtvb.Rows(0)("QtyIn_LdgrInvty")
            Dim status = "OPEN"

            If rrQty > 0 Then
                If poQty > rrQty Then
                    status = "PARTIALLY RECEIVED"
                ElseIf rrQty = poQty Then
                    status = "RECEIVED"
                Else
                    status = "OVER"
                End If
            End If

            Dim sqlUpdate As String = String.Format("Update transaction_ledger_inventorylogs SET Status_LdgrInvtyLog = '{0}', QtyRR_LdgrInvtyLog = '{1}', QtyBilled_LdgrInvtyLog = '{2}' Where PK_LdgrInvtyLog = '{3}'", status, rrQty, vbQty, ldgrinvtylogPK)
            AppData.ExecuteNonQuery(sqlUpdate)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateSOStatus(ByVal so_pk As String)
        Try
            If so_pk <> "" Then

                Dim sqlSOItems As String = String.Format("Select PK_LdgrInvty, IFNULL(QtyOut_LdgrInvty,0) as QtyOut_LdgrInvty,FK_TransH_LdgrInvty,FK_Invty_LdgrInvty " +
                               "FROM transaction_ledger_inventories WHERE FK_TransH_LdgrInvty = '{0}'", so_pk)
                Dim dtSOItems As DataTable = AppData.GetDataTable(sqlSOItems)

                For i As Integer = 0 To dtSOItems.Rows.Count - 1
                    UpdateSOItems(dtSOItems.Rows(i)("PK_LdgrInvty"), StrVal9(dtSOItems.Rows(i)("QtyOut_LdgrInvty")))
                    UpdateInventory(dtSOItems.Rows(i)("FK_Invty_LdgrInvty"))
                Next

                Dim sqlUpdatedSOItems As String = String.Format("Select IFNULL(Status_LdgrInvty,'OPEN') as Status_LdgrInvty,IFNULL(QtyOut_LdgrInvty,0),IFNULL(QtyRR_LdgrInvty,0),IFNULL(QtyBilled_LdgrInvty,0) " +
                               "FROM transaction_ledger_inventories WHERE FK_TransH_LdgrInvty = '{0}'", so_pk)
                Dim dtUpdatedSOItems As DataTable = AppData.GetDataTable(sqlUpdatedSOItems)

                Dim sqlSumSOItems As String = String.Format("Select IFNULL(SUM(QtyOut_LdgrInvty),0) as QtyOut_LdgrInvty,IFNULL(SUM(QtyRR_LdgrInvty),0) as QtyRR_LdgrInvty,IFNULL(SUM(QtyBilled_LdgrInvty),0) as QtyBilled_LdgrInvty " +
                               "FROM transaction_ledger_inventories WHERE FK_TransH_LdgrInvty = '{0}'  AND IsVoid_LdgrInvty = 0", so_pk)
                Dim dtSumSOItems As DataTable = AppData.GetDataTable(sqlSumSOItems)

                Dim qtySO As Double = StrVal9(dtSumSOItems(0)("QtyOut_LdgrInvty"))
                Dim qtyInvoiced As Double = StrVal9(dtSumSOItems(0)("QtyRR_LdgrInvty"))
                Dim qtyDR As Double = StrVal9(dtSumSOItems(0)("QtyBilled_LdgrInvty"))

                Dim partialCount As Integer = 0
                Dim openCount As Integer = 0
                Dim receivedCount As Integer = 0

                For x As Integer = 0 To dtUpdatedSOItems.Rows.Count - 1
                    Dim ledgerStatus = dtUpdatedSOItems.Rows(x)("Status_LdgrInvty")
                    If ledgerStatus = "OPEN" Then
                        openCount += 1
                    ElseIf ledgerStatus = "PARTIALLY INVOICED" Then
                        partialCount += 1
                    Else
                        receivedCount += 1
                    End If
                Next

                Dim status As String = "PENDING ORDER"
                Dim substatus As String = ""

                If qtyInvoiced > 0 And qtyDR = 0 Then
                    substatus = "PENDING DELIVERY"
                ElseIf (qtyDR > 0) And qtyInvoiced > qtyDR Then
                    substatus = "PARTIALLY DELIVERED"
                ElseIf qtySO = qtyDR Then
                    substatus = "FULLY DELIVERED"
                Else
                    substatus = ""
                End If

                If partialCount = 0 And receivedCount = 0 Then
                    status = "PENDING ORDER"
                ElseIf partialCount > 0 Then
                    status = "PARTIALLY INVOICED"
                ElseIf openCount = 0 And partialCount = 0 Then
                    If qtySO <> qtyInvoiced Then
                        status = "PARTIALLY ORDERED/FULLY INVOICED"
                    Else
                        status = "FULLY INVOICED"
                    End If
                End If

                Dim sqlUpdate As String = String.Format("Update transaction_headers SET Status_TransH = '{0}',SubStatus_TransH = '{1}' WHERE PK_TransH = '{2}'", status, substatus, so_pk)
                AppData.ExecuteNonQuery(sqlUpdate)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdatePOStatus(ByVal po_pk As String)
        Try
            If po_pk <> "" Then

                Dim sqlPOItems As String = String.Format("Select PK_LdgrInvtyLog, IFNULL(QtyIn_LdgrInvtyLog,0) as QtyIn_LdgrInvtyLog,FK_TransH_LdgrInvtyLog,FK_Invty_LdgrInvtyLog " +
                               "FROM transaction_ledger_inventorylogs WHERE FK_TransH_LdgrInvtyLog = '{0}'", po_pk)
                Dim dtPOItems As DataTable = AppData.GetDataTable(sqlPOItems)

                For i As Integer = 0 To dtPOItems.Rows.Count - 1
                    UpdatePOItems(dtPOItems.Rows(i)("PK_LdgrInvtyLog"), StrVal9(dtPOItems.Rows(i)("QtyIn_LdgrInvtyLog")))
                    UpdateInventory(dtPOItems.Rows(i)("FK_Invty_LdgrInvtyLog"))
                Next

                Dim sqlUpdatedPOItems As String = String.Format("Select Status_LdgrInvtyLog,IFNULL(QtyIn_LdgrInvtyLog,0),IFNULL(QtyRR_LdgrInvtyLog,0),IFNULL(QtyBilled_LdgrInvtyLog,0) " +
                               "FROM transaction_ledger_inventorylogs WHERE FK_TransH_LdgrInvtyLog = '{0}'", po_pk)
                Dim dtUpdatedPOItems As DataTable = AppData.GetDataTable(sqlUpdatedPOItems)

                Dim sqlSumPOItems As String = String.Format("Select IFNULL(SUM(QtyIn_LdgrInvtyLog),0) as QtyIn_LdgrInvtyLog,IFNULL(SUM(QtyRR_LdgrInvtyLog),0) as QtyRR_LdgrInvtyLog,IFNULL(SUM(QtyBilled_LdgrInvtyLog),0) as QtyBilled_LdgrInvtyLog " +
                               "FROM transaction_ledger_inventorylogs WHERE FK_TransH_LdgrInvtyLog = '{0}' AND IsVoid_LdgrInvtyLog = 0", po_pk)
                Dim dtSumPOItems As DataTable = AppData.GetDataTable(sqlSumPOItems)

                Dim qtyPO As Double = StrVal9(dtSumPOItems(0)("QtyIn_LdgrInvtyLog"))
                Dim qtyRR As Double = StrVal9(dtSumPOItems(0)("QtyRR_LdgrInvtyLog"))
                Dim qtyVB As Double = StrVal9(dtSumPOItems(0)("QtyBilled_LdgrInvtyLog"))

                Dim partialCount As Integer = 0
                Dim openCount As Integer = 0
                Dim receivedCount As Integer = 0

                For x As Integer = 0 To dtUpdatedPOItems.Rows.Count - 1
                    Dim ledgerStatus = dtUpdatedPOItems.Rows(x)("Status_LdgrInvtyLog")
                    If ledgerStatus = "OPEN" Then
                        openCount += 1
                    ElseIf ledgerStatus = "PARTIALLY RECEIVED" Then
                        partialCount += 1
                    Else
                        receivedCount += 1
                    End If
                Next

                Dim status As String = "OPEN"
                Dim substatus As String = ""

                If qtyRR > 0 And qtyVB = 0 Then
                    substatus = "PENDING BILLING"
                ElseIf (qtyVB > 0) And qtyRR > qtyVB Then
                    substatus = "PARTIALLY BILLED"
                ElseIf qtyPO = qtyVB Then
                    substatus = "FULLY BILLED"
                Else
                    substatus = ""
                End If

                If partialCount = 0 And receivedCount = 0 Then
                    status = "OPEN"
                ElseIf partialCount > 0 Then
                    status = "PARTIALLY RECEIVED"
                ElseIf openCount = 0 And partialCount = 0 Then
                    status = "FULLY RECEIVED"
                End If

                Dim sqlUpdate As String = String.Format("Update transaction_headers SET Status_TransH = '{0}',SubStatus_TransH = '{1}' WHERE PK_TransH = '{2}'", status, substatus, po_pk)
                AppData.ExecuteNonQuery(sqlUpdate)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdateRFStatus(ByVal rf_pk As String)
        Try
            Dim sql As String = String.Format("Select COUNT(*) as cnt from transaction_headers where fk_transHsl_TransH = '{0}' and Module_TransH ='REVOLVINGEXP' and IsVoid_TransH = 0", rf_pk)
            Dim dt As DataTable = AppData.GetDataTable(sql)

            Dim status As String = IIf(StrVal9(dt.Rows(0)("cnt")) > 0, "RETURNED", "RELEASED")

            AppData.ExecuteNonQuery(String.Format("Update transaction_headers set Status_TransH = '{0}' where PK_TransH = '{1}'", status, rf_pk))

        Catch ex As Exception

        End Try
    End Sub
    Public Sub UpdateAPStatus(ByVal vb_pk As String)
        Try
            If vb_pk <> "" Then
                Dim sqlAP As String = String.Format("Select IFNULL(CRAmount_LdgrEntries,0) as CRAmount_LdgrEntries from transaction_ledger_entries where PK_LdgrEntries = '{0}' AND Module_LdgrEntries = 'AP-GENENTRY'", vb_pk)
                Dim dtAP As DataTable = AppData.GetDataTable(sqlAP)
                Dim apAmount As Double = IIf(dtAP.Rows.Count = 0, 0, StrVal9(dtAP.Rows(0)("CRAmount_LdgrEntries")))

                Dim slAP As String = String.Format("Select IFNULL(SUM(DRAmount_LdgrEntries),0) as DRAmount_LdgrEntries from transaction_ledger_entries where FK_LdgrEntriesSL_LdgrEntries = '{0}' AND Module_LdgrEntries = 'GENENTRY' AND IsVoid_LdgrEntries = 0", vb_pk)
                Dim dtSLAP As DataTable = AppData.GetDataTable(slAP)
                Dim apSLAmount As Double = 0
                If dtSLAP.Rows.Count > 0 Then
                    apSLAmount = StrVal9(dtSLAP.Rows(0)("DRAmount_LdgrEntries"))
                End If

                Dim status As String = "UNPAID"

                If apAmount > apSLAmount And apSLAmount <> 0 Then
                    status = "PARTIALLY PAID"
                ElseIf apAmount = apSLAmount Then
                    status = "FULLY PAID"
                Else
                    status = "UNPAID"
                End If

                Dim updateLedgerAP As String = String.Format("Update transaction_ledger_entries set AmountPaid_LdgrEntries = '{0}',AmountDue_LdgrEntries = '{1}',Status_LdgrEntries = '{2}' where PK_LdgrEntries = '{3}'", apSLAmount, apAmount - apSLAmount, status, vb_pk)
                AppData.ExecuteNonQuery(updateLedgerAP)

                Dim updateVB As String = String.Format("Update transaction_headers set AmountDue_TransH = '{0}',Status_TransH = '{1}' where PK_TransH = '{2}'", apAmount - apSLAmount, status, vb_pk)
                AppData.ExecuteNonQuery(updateVB)

                ''Update Balance
                Dim umpk = AppData.ExecuteScalar(String.Format("Select FK_UM_TransH from transaction_headers where PK_TransH = '{0}'", vb_pk))

                Dim balance = AppData.ExecuteScalar(String.Format("Select SUM(AmountDue_LdgrEntries) as AmountDue_LdgrEntries from transaction_ledger_entries left join transaction_headers on fk_transh_ldgrentries = pk_transh where module_ldgrentries = 'AP-GENENTRY' and fk_um_transh = '{0}'", umpk))

                AppData.ExecuteNonQuery(String.Format("Update universal_masters set balance_um = '{0}' where pk_um = '{1}'", balance, umpk))
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub UpdateChargeInvoiceStatus(ByVal chgsi_pk As String)
        Try
            If chgsi_pk <> "" Then
                Dim sqlAR As String = String.Format("Select IFNULL(DRAmount_LdgrEntries,0) as DRAmount_LdgrEntries from transaction_ledger_entries where PK_LdgrEntries = '{0}' AND Module_LdgrEntries = 'AR-GENENTRY'", chgsi_pk)
                Dim dtAR As DataTable = AppData.GetDataTable(sqlAR)
                Dim arAmount As Double = IIf(dtAR.Rows.Count = 0, 0, StrVal9(dtAR.Rows(0)("DRAmount_LdgrEntries")))

                Dim slAR As String = String.Format("Select IFNULL(SUM(CRAmount_LdgrEntries),0) as CRAmount_LdgrEntries from transaction_ledger_entries where FK_LdgrEntriesSL_LdgrEntries = '{0}' AND Module_LdgrEntries = 'GENENTRY' AND IsVoid_LdgrEntries = 0", chgsi_pk)
                Dim dtSLAR As DataTable = AppData.GetDataTable(slAR)

                Dim sqlSumSIItems As String = String.Format("Select IFNULL(SUM(QtyOut_LdgrInvty),0) as QtyOut_LdgrInvty " +
                               "FROM transaction_ledger_inventories WHERE FK_TransH_LdgrInvty = '{0}'  AND IsVoid_LdgrInvty = 0", chgsi_pk)
                Dim dtSumSIItems As DataTable = AppData.GetDataTable(sqlSumSIItems)
                Dim qtySI As Double = StrVal9(dtSumSIItems(0)("QtyOut_LdgrInvty"))

                Dim sqlSumDRItems As String = String.Format("Select IFNULL(SUM(QtyOut_LdgrInvty),0) as QtyOut_LdgrInvty " +
                               "FROM transaction_ledger_inventories left join transaction_headers on fk_transh_ldgrinvty = pk_transh " +
                               "WHERE FK_TransHSL_TransH = '{0}'  AND IsVoid_LdgrInvty = 0", chgsi_pk)
                Dim dtSumDRItems As DataTable = AppData.GetDataTable(sqlSumDRItems)
                Dim qtyDR As Double = StrVal9(dtSumDRItems(0)("QtyOut_LdgrInvty"))



                Dim arSLAmount As Double = 0
                If dtSLAR.Rows.Count > 0 Then
                    arSLAmount = StrVal9(dtSLAR.Rows(0)("CRAmount_LdgrEntries"))
                End If

                Dim status As String = "UNPAID"
                Dim substatus As String = "PENDING DELIVERY"

                If qtySI > qtyDR And qtyDR > 0 Then
                    substatus = "PARTIALLY DELIVERED"
                ElseIf qtySI = qtyDR Then
                    substatus = "FULLY DELIVERED"
                ElseIf qtySI < qtyDR Then
                    substatus = "OVER DELIVERED"
                Else
                    substatus = "PENDING DELIVERY"
                End If

                If arAmount > arSLAmount And arSLAmount <> 0 Then
                    status = "PARTIALLY PAID"
                ElseIf arAmount = arSLAmount Then
                    status = "FULLY PAID"
                Else
                    status = "UNPAID"
                End If

                Dim updateLedgerAR As String = String.Format("Update transaction_ledger_entries set AmountPaid_LdgrEntries = '{0}',AmountDue_LdgrEntries = '{1}',Status_LdgrEntries = '{2}' where PK_LdgrEntries = '{3}'", arSLAmount, arAmount - arSLAmount, status, chgsi_pk)
                AppData.ExecuteNonQuery(updateLedgerAR)

                Dim updateVB As String = String.Format("Update transaction_headers set AmountDue_TransH = '{0}',Status_TransH = '{1}', SubStatus_TransH = '{2}' where PK_TransH = '{3}'", arAmount - arSLAmount, status, substatus, chgsi_pk)
                AppData.ExecuteNonQuery(updateVB)

                ''Update Balance
                Dim umpk = AppData.ExecuteScalar(String.Format("Select FK_UM_TransH from transaction_headers where PK_TransH = '{0}'", chgsi_pk))

                Dim balance = AppData.ExecuteScalar(String.Format("Select SUM(AmountDue_LdgrEntries) as AmountDue_LdgrEntries from transaction_ledger_entries left join transaction_headers on fk_transh_ldgrentries = pk_transh where module_ldgrentries = 'AR-GENENTRY' and fk_um_transh = '{0}'", umpk))

                AppData.ExecuteNonQuery(String.Format("Update universal_masters set balance_um = '{0}' where pk_um = '{1}'", balance, umpk))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub UpdateUndepositedStatus(ByVal record_pk As String, ByVal trans_pk As String)
        Try
            If record_pk <> "" Then
                Dim undepositedCOA As String = Me.GetUndepositedFundsCOA
                Dim sqlUF As String = String.Format("Select IFNULL(SUM(DRAmount_LdgrEntries),0) as DRAmount_LdgrEntries from transaction_ledger_entries where PK_LdgrEntries = '{0}' AND Module_LdgrEntries = 'GENENTRY' AND FK_COA_LdgrEntries = '{1}'", record_pk, undepositedCOA)
                Dim dtUF As DataTable = AppData.GetDataTable(sqlUF)
                Dim ufAmount As Double = IIf(dtUF.Rows.Count = 0, 0, StrVal9(dtUF.Rows(0)("DRAmount_LdgrEntries")))

                Dim slUF As String = String.Format("Select IFNULL(SUM(CRAmount_LdgrEntries),0) as CRAmount_LdgrEntries from transaction_ledger_entries where FK_LdgrEntriesSL_LdgrEntries = '{0}' AND Module_LdgrEntries = 'GENENTRY' AND IsVoid_LdgrEntries = 0", record_pk)
                Dim dtSLUF As DataTable = AppData.GetDataTable(slUF)
                Dim ufSLAmount As Double = 0
                If dtSLUF.Rows.Count > 0 Then
                    ufSLAmount = StrVal9(dtSLUF.Rows(0)("CRAmount_LdgrEntries"))
                End If

                Dim status As String = ""
                If ufAmount > 0 Then
                    If ufAmount = ufSLAmount And ufSLAmount <> 0 Then
                        status = "DEPOSITED"
                    Else
                        status = "NOT DEPOSITED"
                    End If
                End If

                Dim updateLedgerAR As String = String.Format("Update transaction_ledger_entries set AmountPaid_LdgrEntries = '{0}',AmountDue_LdgrEntries = '{1}',Status_LdgrEntries = '{2}' where PK_LdgrEntries = '{3}'", ufSLAmount, ufAmount - ufSLAmount, status, record_pk)
                AppData.ExecuteNonQuery(updateLedgerAR)

                Dim updateVB As String = String.Format("Update transaction_headers set UndepositedAmount_TransH = '{0}',Status_TransH = '{1}' where PK_TransH = '{2}'", ufAmount - ufSLAmount, status, trans_pk)
                AppData.ExecuteNonQuery(updateVB)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected OrigPayables As New Collection
    Protected Overridable Sub POSTPayments()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New CrossThreadMethodDelegate(AddressOf Me.POSTPayments))
            Else
                If Not IsNothing(Me.ItemsGrid) AndAlso Me.ItemsGrid.RowCount > 0 Then
                    With Me.ItemsGrid
                        For i As Integer = 0 To .RowCount - 1
                            .RowPosition = i
                            If Not IsDBNull(.Field("fk_ldgrentriessl_ldgrentries")) Then
                                PostPayment(.Field("fk_ldgrentriessl_ldgrentries").ToString, .Field("title_coa").ToString) 'GetTitleCOA(.Field("fk_coa_ldgrentries").ToString))
                                System.Threading.Thread.Sleep(50)
                            End If

                        Next
                    End With


                End If

            End If
        Catch ex As Exception

        End Try

    End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        'InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.New(Nothing)
    End Sub

    Public Sub New(ByVal NewItemsGrid As DetailGrid)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not IsNothing(NewItemsGrid) Then
            AddNewRecordOnLoad = True
            DefaultNewItems = NewItemsGrid
        Else
            AddNewRecordOnLoad = False
        End If
    End Sub

    Private Sub TransactionBase_BeforeRecordDelete(ByRef Cancel As Boolean) Handles Me.BeforeRecordDelete
        If Not IsNothing(EntriesGrid) Then
            With EntriesGrid
                For i As Integer = 0 To .RowCount - 1
                    .RowPosition = i
                    EntriesGrid.Field("CRAmount_LdgrEntries") = 0
                    EntriesGrid.Field("DRAmount_LdgrEntries") = 0
                    'Me.SaveDetailRecords()
                Next
            End With
        End If
    End Sub

    Private Sub TransactionBase_BeforeRecordSave(ByRef Cancel As Boolean) Handles Me.BeforeRecordSave

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class
