
Public Class POSv1
    Dim catpanewidth As Double = 0
    Dim isGridLoadedAfterSearch As Boolean = False

    Protected CategoryCollection As Collection
    Private currentCategory As CategoryButton
    Private selectedItem As OrderItem

    Dim isFirstLoad As Boolean = True

    Private Sub POSv1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            CategoryCollection = New Collection
            Dim sql As String = String.Format("Select * from categories order by Name_Cat ASC")
            Dim dt As DataTable = AppData.GetDataTable(sql)
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim category As New CategoryButton
                category.BaseColor = System.Drawing.SystemColors.ControlLight
                category.Tag = dt.Rows(i)("PK_Cat").ToString
                category.Text = dt.Rows(i)("Name_Cat").ToString
                category.Name = "Category" & i
                CategoryCollection.Add(category, category.Name)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub POSv1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            catpanewidth = CategoryPanel.Size.Width
            Dim categoryCount As Integer = CategoryCollection.Count
            Dim maxCategoryCount As Integer = catpanewidth / 140
            Dim categoryWidth As Integer = IIf(maxCategoryCount > categoryCount, catpanewidth / categoryCount, catpanewidth / maxCategoryCount)

            For Each ctrl As Control In CategoryCollection
                ctrl.Size = New Size(categoryWidth - 10, 40)
                AddHandler ctrl.Click, AddressOf Me.Category_Click
                CategoryPanel.Controls.Add(ctrl)
            Next
            SearchBox.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub POSv1_AfterRecordOpen() Handles Me.AfterRecordOpen
        isGridLoadedAfterSearch = 0
    End Sub

    Private Sub POSv1_BeforeRecordSave(ByRef Cancel As Boolean) Handles Me.BeforeRecordSave
        Try
            If Me.FormState = EditorState.AddMode Then
                With sg__transaction_ledger_inventories
                    For i As Integer = 0 To .RowCount - 1
                        .RowPosition = i
                        If StrVal9(.Field("quantity_invty")) < StrVal9(.Field("QtyOut_LdgrInvty")) Then
                            MsgBox("One of the item don't have enough quantity.")
                            Cancel = True
                            Exit Sub
                        End If
                    Next
                End With
            End If

            GrpSubTotal.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("SubTotalAmount_LdgrInvty")).ToString("n2")
            GrpDiscount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TotalDiscountAmount_LdgrInvty")).ToString("n2")
            GrpNetOfTax.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("NetOfTax_LdgrInvty")).ToString("n2")
            GrpTaxAmount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TaxAmount_LdgrInvty")).ToString("n2")
            GrpTotalAmount.PtNumericInput1.Value = sg__transaction_ledger_inventories.FieldTotal("TotalAmount_LdgrInvty")
        Catch ex As Exception

        End Try
    End Sub



    Private Sub ComputeDiscount(Optional ByVal i As Integer = 0)
        Try
            Dim isDiscPerTransaction = discTransaction.Value
            Dim isDiscPercent = discPercent.Value
            Dim discVal = discvalue.Value
            Dim subTotal As Double = sg__transaction_ledger_inventories.FieldTotal("SubTotalAmount_LdgrInvty")
            Dim discPer As Double = 0
            If Not isDiscPercent Then
                discPer = discVal / subTotal * 100
            End If

            If isDiscPerTransaction Then
                For x As Integer = 0 To sg__transaction_ledger_inventories.RowCount - 1
                    sg__transaction_ledger_inventories.RowPosition = x

                    Dim subTotalAmount As Double = StrVal9(sg__transaction_ledger_inventories.Field("SubTotalAmount_LdgrInvty"))
                    If isDiscPercent Then
                        sg__transaction_ledger_inventories.Field("DiscountPercent_LdgrInvty") = discVal
                    Else
                        sg__transaction_ledger_inventories.Field("DiscountPercent_LdgrInvty") = discPer
                    End If
                    ComputeTotal()
                Next
            Else
                sg__transaction_ledger_inventories.RowPosition = i
                Dim subTotalAmount As Double = StrVal9(sg__transaction_ledger_inventories.Field("SubTotalAmount_LdgrInvty"))
                If isDiscPercent Then
                    sg__transaction_ledger_inventories.Field("DiscountPercent_LdgrInvty") = discVal
                Else
                    sg__transaction_ledger_inventories.Field("DiscountPercent_LdgrInvty") = discPer
                End If
                ComputeTotal()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComputeTax(Optional ByVal i As Integer = 0)
        Try
            Dim isTaxPerTransaction = taxTransaction.Value
            Dim isTaxPercent = taxPercent.Value
            Dim taxVal = taxValue.Value
            Dim subTotal As Double = sg__transaction_ledger_inventories.FieldTotal("NetOfTax_LdgrInvty")
            Dim taxPer As Double = 0
            If Not isTaxPercent Then
                taxPer = taxVal / subTotal * 100
            End If

            If isTaxPerTransaction Then
                Dim index As Integer = 0
                For x As Integer = 0 To sg__transaction_ledger_inventories.RowCount - 1
                    sg__transaction_ledger_inventories.RowPosition = x

                    Dim subTotalAmount As Double = StrVal9(sg__transaction_ledger_inventories.Field("NetOfTax_LdgrInvty"))
                    If isTaxPercent Then
                        sg__transaction_ledger_inventories.Field("TaxPercent_LdgrInvty") = taxVal
                    Else
                        sg__transaction_ledger_inventories.Field("TaxPercent_LdgrInvty") = taxPer
                    End If
                    ComputeTotal()
                Next
            Else
                sg__transaction_ledger_inventories.RowPosition = i
                Dim subTotalAmount As Double = StrVal9(sg__transaction_ledger_inventories.Field("NetOfTax_LdgrInvty"))
                If isTaxPercent Then
                    sg__transaction_ledger_inventories.Field("TaxPercent_LdgrInvty") = taxVal
                Else
                    sg__transaction_ledger_inventories.Field("TaxPercent_LdgrInvty") = taxPer
                End If
                ComputeTotal()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GridView3_DoubleClick(sender As Object, e As EventArgs) Handles GridView3.DoubleClick
        AddItem()
    End Sub

    Private Sub AddItem()
        Try
            If Me.FormState = EditorState.AddMode Or Me.FormState = EditorState.EditMode Then
                With sg__inventories
                    .RowPosition = GridView3.FocusedRowHandle
                    Dim pk As String = .Field("PK_Invty").ToString
                    Dim desc As String = .Field("Description_Invty").ToString
                    Dim price As Double = StrVal9(.Field("Price_Invty/baseconversion_invty"))
                    Dim cost As Double = StrVal9(.Field("Cost_Invty/baseconversion_invty"))
                    Dim qtyonhand As Double = StrVal9(.Field("Quantity_Invty"))
                    Dim unit As String = .Field("SaleUnit_Invty").ToString
                    Dim unitconv As Double = IIf(StrVal9(.Field("BaseConversion_Invty")) = 0, 1, StrVal9(.Field("BaseConversion_Invty")))
                    Dim discpercent = 0
                    Dim taxpercent = 0
                    Dim discamount = price * discpercent / 100
                    Dim totaldisc = discamount
                    Dim netoftax = price - totaldisc
                    Dim taxamount = netoftax * taxpercent / 100

                    If qtyonhand <= 0 Then
                        MsgBox("No available quantity")
                        Exit Sub
                    End If

                    sg__transaction_ledger_inventories.AddNewRow()
                    sg__transaction_ledger_inventories.Field("FK_Invty_LdgrInvty") = pk
                    sg__transaction_ledger_inventories.Field("Description_Invty") = desc
                    sg__transaction_ledger_inventories.Field("UOM_LdgrInvty") = unit
                    sg__transaction_ledger_inventories.Field("Price_LdgrInvty") = price
                    sg__transaction_ledger_inventories.Field("Cost_LdgrInvty") = cost
                    sg__transaction_ledger_inventories.Field("UnitConversion_LdgrInvty") = unitconv
                    sg__transaction_ledger_inventories.Field("Rate_LdgrInvty") = cost
                    sg__transaction_ledger_inventories.Field("Quantity_Invty") = qtyonhand
                    sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty") = 1
                    sg__transaction_ledger_inventories.Field("SubTotalAmount_LdgrInvty") = price
                    sg__transaction_ledger_inventories.Field("DiscountAmount_LdgrInvty") = discamount
                    sg__transaction_ledger_inventories.Field("TotalDiscountAmount_LdgrInvty") = totaldisc
                    sg__transaction_ledger_inventories.Field("NetOfTax_LdgrInvty") = netoftax
                    sg__transaction_ledger_inventories.Field("TaxAmount_LdgrInvty") = taxamount
                    sg__transaction_ledger_inventories.Field("TotalAmount_LdgrInvty") = netoftax + taxamount
                    ComputeDiscount(GridView3.FocusedRowHandle)
                    ComputeTax(GridView3.FocusedRowHandle)
                    sg__transaction_ledger_inventories.Refresh()

                    'ComputeTotal()
                    isFirstLoad = False
                End With
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Category_Click(senderButton As Object, e As EventArgs)
        Try
            GridView3.ActiveFilterString = String.Format("[{0}] = '{1}'", "name_cat", CType(senderButton, CategoryButton).Text)
            If currentCategory IsNot Nothing Then
                If CType(currentCategory, CategoryButton).Text = CType(senderButton, CategoryButton).Text And CType(senderButton, CategoryButton).BaseColor = Colors.brand Then
                    currentCategory = senderButton
                    GridView3.ActiveFilterString = ""
                    currentCategory.BaseColor = System.Drawing.SystemColors.ControlLight
                Else
                    currentCategory.BaseColor = System.Drawing.SystemColors.ControlLight
                    currentCategory = senderButton
                    currentCategory.BaseColor = Colors.brand
                End If
            Else
                currentCategory = senderButton
                currentCategory.BaseColor = Colors.brand
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2TextBox1_IconLeftClick(sender As Object, e As EventArgs)
        gleCustomer.ShowPopup()
    End Sub

    Private Sub Guna2TextBox1_Click(sender As Object, e As EventArgs)
        gleCustomer.ShowPopup()
    End Sub

    Private Sub ComputeTotal()
        Try
            With sg__transaction_ledger_inventories
                .RowPosition = GridView1.FocusedRowHandle
                With sg__transaction_ledger_inventories
                    Dim rate = StrVal9(.Field("Rate_LdgrInvty"))
                    Dim rateprice = StrVal9(.Field("RatePrice_LdgrInvty"))
                    Dim unitconversion = StrVal9(.Field("UnitConversion_LdgrInvty"))
                    Dim qty = StrVal9(.Field("QtyOut_LdgrInvty"))
                    Dim discpercent = StrVal9(.Field("DiscountPercent_LdgrInvty"))
                    Dim taxpercent = StrVal9(.Field("TaxPercent_LdgrInvty"))
                    Dim price = StrVal9(.Field("Price_LdgrInvty"))
                    Dim cost = StrVal9(.Field("Cost_LdgrInvty"))
                    Dim discamount = price * discpercent / 100
                    Dim totaldisc = discamount * qty
                    Dim netoftax = qty * price - totaldisc
                    Dim taxamount = netoftax * taxpercent / 100

                    .Field("Cost_LdgrInvty") = cost
                    .Field("Price_LdgrInvty") = price
                    .Field("SubTotalAmount_LdgrInvty") = qty * price
                    .Field("DiscountAmount_LdgrInvty") = discamount
                    .Field("TotalDiscountAmount_LdgrInvty") = totaldisc
                    .Field("NetOfTax_LdgrInvty") = netoftax
                    .Field("TaxAmount_LdgrInvty") = taxamount
                    .Field("TotalAmount_LdgrInvty") = netoftax + taxamount
                End With

                '.Field("TotalAmount_LdgrInvty") = StrVal9(StrVal9(.Field("QtyOut_LdgrInvty")) * (StrVal9(.Field("Price_LdgrInvty")) - (StrVal9(.Field("Price_LdgrInvty")) * StrVal9(.Field("DiscountPercent_LdgrInvty"))))).ToString("n0")
                '.Field("DiscountAmount_LdgrInvty") = StrVal9(.Field("QtyOut_LdgrInvty")) * (StrVal9(.Field("Price_LdgrInvty")) * StrVal9(.Field("DiscountPercent_LdgrInvty")))

                GrpSubTotal.PtNumericInput1.Value = StrVal9(.FieldTotal("SubTotalAmount_LdgrInvty")).ToString("n2")
                GrpDiscount.PtNumericInput1.Value = StrVal9(.FieldTotal("TotalDiscountAmount_LdgrInvty")).ToString("n2")
                GrpNetOfTax.PtNumericInput1.Value = StrVal9(.FieldTotal("NetOfTax_LdgrInvty")).ToString("n2")
                GrpTaxAmount.PtNumericInput1.Value = StrVal9(.FieldTotal("TaxAmount_LdgrInvty")).ToString("n2")
                GrpTotalAmount.PtNumericInput1.Value = StrVal9(.FieldTotal("TotalAmount_LdgrInvty")).ToString("n2")
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GrpTaxAmount_ValueChanged() Handles GrpTotalAmount.ValueChanged, GrpTaxAmount.ValueChanged, GrpSubTotal.ValueChanged, GrpNetOfTax.ValueChanged, GrpDiscount.ValueChanged
        Try
            lblSubTotal.Text = StrVal9(GrpSubTotal.PtNumericInput1.Value).ToString("n2")
            lblDiscount.Text = StrVal9(GrpDiscount.PtNumericInput1.Value).ToString("n2")
            lblTaxAmount.Text = StrVal9(GrpTaxAmount.PtNumericInput1.Value).ToString("n2")
            lblGrossAmount.Text = StrVal9(GrpTotalAmount.PtNumericInput1.Value).ToString("n2")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub POSv1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                AddNew()
            ElseIf e.KeyCode = Keys.F2 Then
                Print()
            ElseIf e.KeyCode = Keys.F3 Then
                Pay()
            ElseIf e.KeyCode = Keys.F4 Then

            ElseIf e.KeyCode = Keys.F5 Then
                Search()
            ElseIf e.KeyCode = Keys.F6 Then
                Edit()
            ElseIf e.KeyCode = Keys.F7 Then
                Options()
            ElseIf e.KeyCode = Keys.F8 Then

            ElseIf e.KeyCode = Keys.F9 Then
                Qty()
            ElseIf e.KeyCode = Keys.F10 Then
                Price()
            ElseIf e.KeyCode = Keys.F11 Then
                Discount()
            ElseIf e.KeyCode = Keys.F12 Then
                Tax()
            ElseIf e.KeyCode = Keys.Delete Then
                DeleteItem()
            ElseIf e.KeyCode = Keys.Enter Then
                AddItem()
            ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
                sg__inventories.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        AddNew()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Print()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Pay()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Search()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Edit()
    End Sub
    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        DeleteItem()
    End Sub
    Private Sub btnQty_Click(sender As Object, e As EventArgs) Handles btnQty.Click
        Qty()
    End Sub
    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        Price()
    End Sub
    Private Sub btnDiscount_Click(sender As Object, e As EventArgs) Handles btnDiscount.Click
        Discount()
    End Sub
    Private Sub AddNew()
        AddRecord()
        sg__inventories.RefreshData()
    End Sub
    Private Sub Print()
        Try
            Me.UsePKFilter = True
            Dim SelectedReport As ReportWrapper = DirectCast(ReportWrappers(1), ReportWrapper)

            SelectedReport.PreviewReport()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Pay()
        Try
            Dim payfrm As New Payment
            payfrm.txtTotalSales.Text = StrVal9(lblGrossAmount.Text).ToString("n2")
            If payfrm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                txtChange.PtNumericInput1.Value = StrVal9(payfrm.txtChange.Text)
                txtTender.PtNumericInput1.Value = StrVal9(payfrm.txtTender.Text)
                SaveRecord(True)
                Print()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Search()
        Me.SearchForm.ShowDialog(Me)
    End Sub
    Private Sub Edit()
        EditRecord()
    End Sub
    Private Sub Options()
        Try
            Dim oform As New Options
            If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Qty()
        Try
            If Me.FormState = EditorState.AddMode Or Me.FormState = EditorState.EditMode Then
                Dim oform As New EnterNumber
                oform.lblHeaderTitle.Text = "INPUT QUANTITY"
                oform.txtNumber.Text = StrVal9(sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty")).ToString("n2")
                oform.txtNumber.Focus()
                oform.txtNumber.SelectAll()

                If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    If Me.FormState = EditorState.AddMode Then
                        With sg__transaction_ledger_inventories
                            For i As Integer = 0 To .RowCount - 1
                                .RowPosition = i
                                If StrVal9(.Field("quantity_invty")) < StrVal9(oform.txtNumber.Text) Then
                                    MsgBox("Not enough quantity.")
                                    Exit Sub
                                End If
                            Next
                        End With
                    End If

                    sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty") = oform.txtNumber.Text
                    ComputeTotal()
                End If
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Price()
        Try
            If Me.FormState = EditorState.AddMode Or Me.FormState = EditorState.EditMode Then
                Dim oform As New EnterNumber
                oform.lblHeaderTitle.Text = "INPUT PRICE"
                oform.txtNumber.Text = StrVal9(sg__transaction_ledger_inventories.Field("Price_LdgrInvty")).ToString("n2")
                oform.txtNumber.Focus()
                oform.txtNumber.SelectAll()

                Dim conv As Double = StrVal9(sg__transaction_ledger_inventories.Field("UnitConversion_LdgrInvty"))
                Dim qty As Double = StrVal9(sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty"))

                If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    sg__transaction_ledger_inventories.Field("Price_LdgrInvty") = StrVal9(oform.txtNumber.Text) * conv
                End If
                ComputeTotal()
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Discount()
        Try
            If Me.FormState = EditorState.AddMode Or Me.FormState = EditorState.EditMode Then
                Dim oform As New EnterDiscountOrTax
                oform.lblHeaderTitle.Text = "INPUT DISCOUNT"
                'oform.txtNumber.Text = StrVal9(sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty")).ToString("n2")
                oform.txtNumber.Focus()
                oform.txtNumber.SelectAll()

                If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    discPercent.Value = IIf(oform.rdPercent.Checked, 1, 0)
                    discTransaction.Value = IIf(oform.rdTransaction.Checked, 1, 0)
                    discvalue.Value = oform.txtNumber.Text
                    ComputeDiscount()
                End If
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Tax()
        Try
            If Me.FormState = EditorState.AddMode Or Me.FormState = EditorState.EditMode Then
                Dim oform As New EnterDiscountOrTax
                oform.lblHeaderTitle.Text = "INPUT TAX"
                'oform.txtNumber.Text = StrVal9(sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty")).ToString("n2")
                oform.txtNumber.Focus()
                oform.txtNumber.SelectAll()

                If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    taxPercent.Value = IIf(oform.rdPercent.Checked, 1, 0)
                    taxTransaction.Value = IIf(oform.rdTransaction.Checked, 1, 0)
                    taxValue.Value = oform.txtNumber.Text
                    ComputeTax()
                End If
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DeleteItem()
        Try
            If Me.FormState = EditorState.AddMode Or Me.FormState = EditorState.EditMode Then
                GridView1.DeleteRow(GridView1.FocusedRowHandle)
                ComputeTotal()
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub POSv1_AfterRecordAdd() Handles Me.AfterRecordAdd
        txtPreparedBy.PtTextInputGrp1.Text = Project.Instance.ActiveUser.Name
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Try
            GridView3.FindFilterText = SearchBox.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTax_Click(sender As Object, e As EventArgs) 
        Tax()
    End Sub

    Private Sub txtCustomer_TextChanged(sender As Object, e As EventArgs)
    End Sub
End Class
