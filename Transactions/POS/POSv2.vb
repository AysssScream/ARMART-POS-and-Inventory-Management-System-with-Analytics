
Public Class POSv2
    Dim catpanewidth As Double = 0
    Dim isGridLoadedAfterSearch As Boolean = False

    Protected CategoryCollection As Collection
    Private currentCategory As CategoryButton
    Private selectedItem As OrderItem


    Private Sub POSv2_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub POSv2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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

    Private Sub POSv2_AfterRecordOpen() Handles Me.AfterRecordOpen
        isGridLoadedAfterSearch = 0
    End Sub

    Private Sub POSv2_BeforeRecordSave(ByRef Cancel As Boolean) Handles Me.BeforeRecordSave
        Try
            GrpSubTotal.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("SubTotalAmount_LdgrInvty")).ToString("n2")
            GrpDiscount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TotalDiscountAmount_LdgrInvty")).ToString("n2")
            GrpNetOfTax.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("NetOfTax_LdgrInvty")).ToString("n2")
            GrpTaxAmount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TaxAmount_LdgrInvty")).ToString("n2")
            GrpTotalAmount.PtNumericInput1.Value = sg__transaction_ledger_inventories.FieldTotal("TotalAmount_LdgrInvty")
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub AfterLoadGridDetails(ByVal GridName As String)
        Try
            If (GridName = "sg__transaction_ledger_inventories") And Not isGridLoadedAfterSearch Then
                OrderPanel.Controls.Clear()
                isGridLoadedAfterSearch = True
                With sg__transaction_ledger_inventories
                    For i As Integer = 0 To .RowCount - 1
                        .RowPosition = i
                        Dim pk As String = .Field("FK_Invty_LdgrInvty").ToString
                        Dim desc As String = .Field("Description_Invty").ToString
                        Dim conv As Double = StrVal9(.Field("UnitConversion_LdgrInvty"))
                        Dim price As Double = StrVal9(.Field("RatePrice_LdgrInvty"))
                        Dim unitprice As Double = StrVal9(.Field("Price_LdgrInvty"))
                        Dim subtotal As Double = StrVal9(.Field("SubTotalAmount_LdgrInvty"))
                        Dim qty As Double = StrVal9(.Field("QtyOut_LdgrInvty"))
                        Dim unit As String = .Field("UOM_LdgrInvty").ToString
                        Dim tax As Double = StrVal9(.Field("TaxAmount_LdgrInvty"))
                        Dim disc As Double = StrVal9(.Field("TotalDiscountAmount_LdgrInvty"))

                        Try
                            Dim OrderItem As New OrderItem
                            OrderItem.Dock = DockStyle.Top
                            OrderItem.ItemName.Text = desc
                            OrderItem.ItemQty.Text = qty
                            OrderItem.ItemUnit.Text = unit
                            OrderItem.ItemUnitPrice.Text = "@ " & StrVal9(unitprice).ToString("n2")
                            OrderItem.ItemTotalPrice.Text = StrVal9(subtotal).ToString("n2")
                            OrderItem.ItemTaxAmount.Text = StrVal9(tax).ToString("n2")
                            OrderItem.ItemDiscountAmount.Text = StrVal9(disc).ToString("n2")

                            OrderItem.ItemPrice = StrVal9(price).ToString("n2")
                            OrderItem.ItemDiscount = StrVal9(disc).ToString("n2")
                            OrderItem.ItemTax = StrVal9(tax).ToString("n2")
                            OrderItem.ItemConversion = StrVal9(conv).ToString("n2")
                            AddHandler OrderItem.OnItemClicked, AddressOf Me.OrderItem_Clicked

                            OrderPanel.Controls.Add(OrderItem)
                            'OrderPanel.Controls.SetChildIndex(OrderItem, 0)
                            SelectOrderItem(OrderItem)

                            selectedItem = OrderItem
                            sg__transaction_ledger_inventories.RowPosition = sg__transaction_ledger_inventories.RowCount - 1
                        Catch ex As Exception

                        End Try
                    Next
                End With
            End If
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
                Dim index As Integer = 0
                For Each ctrl As Control In OrderPanel.Controls
                    Dim orderItem As OrderItem = CType(ctrl, OrderItem)
                    index = OrderPanel.Controls.IndexOf(ctrl)
                    sg__transaction_ledger_inventories.RowPosition = index

                    Dim subTotalAmount As Double = StrVal9(sg__transaction_ledger_inventories.Field("SubTotalAmount_LdgrInvty"))
                    If isDiscPercent Then
                        sg__transaction_ledger_inventories.Field("DiscountPercent_LdgrInvty") = discVal
                        'orderItem.ItemDiscountAmount.Text = StrVal9(subTotalAmount * discVal / 100).ToString("n2")
                    Else
                        sg__transaction_ledger_inventories.Field("DiscountPercent_LdgrInvty") = discPer
                        'orderItem.ItemDiscountAmount.Text = StrVal9(subTotalAmount * discPer / 100).ToString("n2")
                    End If
                Next
            Else
                Dim orderItem As OrderItem = CType(OrderPanel.Controls(i), OrderItem)
                sg__transaction_ledger_inventories.RowPosition = i
                Dim subTotalAmount As Double = StrVal9(sg__transaction_ledger_inventories.Field("SubTotalAmount_LdgrInvty"))
                If isDiscPercent Then
                    sg__transaction_ledger_inventories.Field("DiscountPercent_LdgrInvty") = discVal
                    'orderItem.ItemDiscountAmount.Text = StrVal9(subTotalAmount * discVal / 100).ToString("n2")
                Else
                    sg__transaction_ledger_inventories.Field("DiscountPercent_LdgrInvty") = discPer
                    'OrderItem.ItemDiscountAmount.Text = StrVal9(subTotalAmount * discPer / 100).ToString("n2")
                End If
            End If
            ComputeTotal()
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
                For Each ctrl As Control In OrderPanel.Controls
                    Dim orderItem As OrderItem = CType(ctrl, OrderItem)
                    index = OrderPanel.Controls.IndexOf(ctrl)
                    sg__transaction_ledger_inventories.RowPosition = index

                    Dim subTotalAmount As Double = StrVal9(sg__transaction_ledger_inventories.Field("NetOfTax_LdgrInvty"))
                    If isTaxPercent Then
                        sg__transaction_ledger_inventories.Field("TaxPercent_LdgrInvty") = taxVal
                        'orderItem.ItemTaxAmount.Text = StrVal9(subTotalAmount * taxVal / 100).ToString("n2")
                    Else
                        sg__transaction_ledger_inventories.Field("TaxPercent_LdgrInvty") = taxPer
                        'orderItem.ItemTaxAmount.Text = StrVal9(subTotalAmount * taxPer / 100).ToString("n2")
                    End If
                Next
            Else
                Dim orderItem As OrderItem = CType(OrderPanel.Controls(i), OrderItem)
                sg__transaction_ledger_inventories.RowPosition = i
                Dim subTotalAmount As Double = StrVal9(sg__transaction_ledger_inventories.Field("NetOfTax_LdgrInvty"))
                If isTaxPercent Then
                    sg__transaction_ledger_inventories.Field("TaxPercent_LdgrInvty") = taxVal
                    'orderItem.ItemDiscountAmount.Text = StrVal9(subTotalAmount * taxVal / 100).ToString("n2")
                Else
                    sg__transaction_ledger_inventories.Field("TaxPercent_LdgrInvty") = taxPer
                    'orderItem.ItemDiscountAmount.Text = StrVal9(subTotalAmount * taxPer / 100).ToString("n2")
                End If
            End If
            ComputeTotal()
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
                    Dim price As Double = StrVal9(.Field("Price_Invty"))
                    Dim cost As Double = StrVal9(.Field("Cost_Invty"))
                    Dim qtyonhand As Double = StrVal9(.Field("Quantity_Invty"))
                    Dim unit As String = .Field("SaleUnit_Invty").ToString
                    Dim unitconv As Double = IIf(StrVal9(.Field("BaseConversion_Invty")) = 0, 1, StrVal9(.Field("BaseConversion_Invty")))

                    If qtyonhand <= 0 Then
                        MsgBox("No available quantity")
                        Exit Sub
                    End If

                    sg__transaction_ledger_inventories.AddNewRow()
                    sg__transaction_ledger_inventories.Field("FK_Invty_LdgrInvty") = pk
                    sg__transaction_ledger_inventories.Field("Description_Invty") = desc
                    sg__transaction_ledger_inventories.Field("UOM_LdgrInvty") = unit
                    sg__transaction_ledger_inventories.Field("RatePrice_LdgrInvty") = price
                    sg__transaction_ledger_inventories.Field("UnitConversion_LdgrInvty") = unitconv
                    sg__transaction_ledger_inventories.Field("Rate_LdgrInvty") = cost
                    sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty") = 1
                    sg__transaction_ledger_inventories.Refresh()

                    AddItemOrder(pk, desc, price, cost, unit, unitconv)
                    ComputeTotal()
                End With
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddItemOrder(ByVal pk As String, ByVal desc As String, ByVal price As Double, ByVal cost As Double, ByVal unit As String, ByVal conv As Integer)
        Try
            Dim OrderItem As New OrderItem
            OrderItem.Dock = DockStyle.Top
            OrderItem.ItemName.Text = desc
            OrderItem.ItemQty.Text = 1
            OrderItem.ItemUnit.Text = unit
            OrderItem.ItemUnitPrice.Text = "@" & StrVal9(price / conv).ToString("n2")
            OrderItem.ItemTotalPrice.Text = StrVal9(price).ToString("n2")
            OrderItem.ItemDiscountAmount.Text = "0.00"
            OrderItem.ItemTaxAmount.Text = "0.00"
            AddHandler OrderItem.OnItemClicked, AddressOf Me.OrderItem_Clicked

            OrderPanel.Controls.Add(OrderItem)
            'OrderPanel.Controls.SetChildIndex(OrderItem, 0)
            SelectOrderItem(OrderItem)
            selectedItem = OrderItem
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
    Private Sub OrderItem_Clicked(sender As Object, e As EventArgs)
        Try
            SelectOrderItem(sender)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SelectOrderItem(sender As Object)
        Try
            Dim index As Integer = 0
            If selectedItem IsNot Nothing Then
                selectedItem.MainPanel.BackColor = System.Drawing.SystemColors.ControlLight
            End If
            selectedItem = sender
            index = OrderPanel.Controls.IndexOf(selectedItem)
            sg__transaction_ledger_inventories.RowPosition = index
            selectedItem.MainPanel.BackColor = Color.PaleTurquoise
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Try
            If e.Column.FieldName.ToLower = "rate_ldgrinvty" Or
                e.Column.FieldName.ToLower = "rateprice_ldgrinvty" Or
                e.Column.FieldName.ToLower = "qtyout_ldgrinvty" Or
                e.Column.FieldName.ToLower = "unitconversion_ldgrinvty" Or
                e.Column.FieldName.ToLower = "discountpercent_ldgrinvty" Or
                e.Column.FieldName.ToLower = "taxpercent_ldgrinvty" Then
                With sg__transaction_ledger_inventories
                    Dim rate = StrVal9(.Field("Rate_LdgrInvty"))
                    Dim rateprice = StrVal9(.Field("RatePrice_LdgrInvty"))
                    Dim unitconversion = StrVal9(.Field("UnitConversion_LdgrInvty"))
                    Dim qty = StrVal9(.Field("QtyOut_LdgrInvty"))
                    Dim discpercent = StrVal9(.Field("DiscountPercent_LdgrInvty"))
                    Dim taxpercent = StrVal9(.Field("TaxPercent_LdgrInvty"))
                    Dim price = rateprice / unitconversion
                    Dim cost = rate / unitconversion
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

                ComputeTotal()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2TextBox1_IconLeftClick(sender As Object, e As EventArgs) Handles txtCustomer.IconLeftClick
        gleCustomer.ShowPopup()
    End Sub

    Private Sub Guna2TextBox1_Click(sender As Object, e As EventArgs) Handles txtCustomer.Click
        gleCustomer.ShowPopup()
    End Sub

    Private Sub gleCustomer_EditValueChanged(sender As Object, e As EventArgs) Handles gleCustomer.EditValueChanged
        txtCustomer.Text = gleCustomer.Text
    End Sub

    Private Sub ComputeTotal()
        Try
            GrpSubTotal.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("SubTotalAmount_LdgrInvty")).ToString("n2")
            GrpDiscount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TotalDiscountAmount_LdgrInvty")).ToString("n2")
            GrpNetOfTax.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("NetOfTax_LdgrInvty")).ToString("n2")
            GrpTaxAmount.PtNumericInput1.Value = StrVal9(sg__transaction_ledger_inventories.FieldTotal("TaxAmount_LdgrInvty")).ToString("n2")
            GrpTotalAmount.PtNumericInput1.Value = sg__transaction_ledger_inventories.FieldTotal("TotalAmount_LdgrInvty")

            With sg__transaction_ledger_inventories
                For i As Integer = 0 To .RowCount - 1
                    .RowPosition = i
                    Dim orderItem As OrderItem = CType(OrderPanel.Controls(i), OrderItem)

                    Dim pk As String = .Field("FK_Invty_LdgrInvty").ToString
                    Dim desc As String = .Field("Description_Invty").ToString
                    Dim conv As Double = StrVal9(.Field("UnitConversion_LdgrInvty"))
                    Dim price As Double = StrVal9(.Field("RatePrice_LdgrInvty"))
                    Dim unitprice As Double = StrVal9(.Field("Price_LdgrInvty"))
                    Dim subtotal As Double = StrVal9(.Field("SubTotalAmount_LdgrInvty"))
                    Dim qty As Double = StrVal9(.Field("QtyOut_LdgrInvty"))
                    Dim unit As String = .Field("UOM_LdgrInvty").ToString
                    Dim tax As Double = StrVal9(.Field("TaxAmount_LdgrInvty"))
                    Dim disc As Double = StrVal9(.Field("TotalDiscountAmount_LdgrInvty"))

                    Try
                        orderItem.Dock = DockStyle.Top
                        orderItem.ItemName.Text = desc
                        orderItem.ItemQty.Text = qty
                        orderItem.ItemUnit.Text = unit
                        orderItem.ItemUnitPrice.Text = "@" & StrVal9(unitprice).ToString("n2")
                        orderItem.ItemTotalPrice.Text = StrVal9(subtotal).ToString("n2")
                        orderItem.ItemTaxAmount.Text = StrVal9(tax).ToString("n2")
                        orderItem.ItemDiscountAmount.Text = StrVal9(disc).ToString("n2")

                        orderItem.ItemPrice = StrVal9(price).ToString("n2")
                        orderItem.ItemDiscount = StrVal9(disc).ToString("n2")
                        orderItem.ItemTax = StrVal9(tax).ToString("n2")
                        orderItem.ItemConversion = StrVal9(conv).ToString("n2")
                    Catch ex As Exception

                    End Try

                Next
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

    Private Sub POSv2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
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
    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Options()
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
    Private Sub btnTax_Click(sender As Object, e As EventArgs) Handles btnTax.Click
        Tax()
    End Sub

    Private Sub AddNew()
        AddRecord()
        OrderPanel.Controls.Clear()
    End Sub
    Private Sub Print()

    End Sub
    Private Sub Pay()
        Try
            Dim payfrm As New Payment
            If payfrm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                SaveRecord()
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
                If Not IsNothing(selectedItem) Then
                    Dim oform As New EnterNumber
                    oform.lblHeaderTitle.Text = "INPUT QUANTITY"
                    oform.txtNumber.Text = StrVal9(sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty")).ToString("n2")
                    oform.txtNumber.Focus()
                    oform.txtNumber.SelectAll()

                    If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                        selectedItem.ItemQty.Text = oform.txtNumber.Text
                        selectedItem.ItemTotalPrice.Text = StrVal9(oform.txtNumber.Text) * (StrVal9(selectedItem.ItemPrice) / StrVal9(selectedItem.ItemConversion))

                        With sg__inventories
                            sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty") = oform.txtNumber.Text
                        End With
                    End If
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
                If Not IsNothing(selectedItem) Then
                    Dim oform As New EnterNumber
                    oform.lblHeaderTitle.Text = "INPUT PRICE"
                    oform.txtNumber.Text = StrVal9(sg__transaction_ledger_inventories.Field("Price_LdgrInvty")).ToString("n2")
                    oform.txtNumber.Focus()
                    oform.txtNumber.SelectAll()

                    Dim conv As Double = StrVal9(sg__transaction_ledger_inventories.Field("UnitConversion_LdgrInvty"))
                    Dim qty As Double = StrVal9(sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty"))

                    If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                        With sg__inventories
                            sg__transaction_ledger_inventories.Field("RatePrice_LdgrInvty") = StrVal9(oform.txtNumber.Text) * conv
                        End With
                    End If
                End If
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Discount()
        Try
            If Me.FormState = EditorState.AddMode Or Me.FormState = EditorState.EditMode Then
                If Not IsNothing(selectedItem) Then
                    Dim oform As New EnterDiscountOrTax
                    oform.lblHeaderTitle.Text = "INPUT DISCOUNT"
                    'oform.txtNumber.Text = StrVal9(sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty")).ToString("n2")
                    oform.txtNumber.Focus()
                    oform.txtNumber.SelectAll()

                    If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                        discPercent.Value = IIf(oform.rdPercent.Checked, 1, 0)
                        discTransaction.Value = IIf(oform.rdTransaction.Checked, 1, 0)
                        discvalue.Value = oform.txtNumber.Text
                        ComputeDiscount(OrderPanel.Controls.IndexOf(selectedItem))
                    End If
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
                If Not IsNothing(selectedItem) Then
                    Dim oform As New EnterDiscountOrTax
                    oform.lblHeaderTitle.Text = "INPUT TAX"
                    'oform.txtNumber.Text = StrVal9(sg__transaction_ledger_inventories.Field("QtyOut_LdgrInvty")).ToString("n2")
                    oform.txtNumber.Focus()
                    oform.txtNumber.SelectAll()

                    If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                        taxPercent.Value = IIf(oform.rdPercent.Checked, 1, 0)
                        taxTransaction.Value = IIf(oform.rdTransaction.Checked, 1, 0)
                        taxValue.Value = IIf(oform.rdTransaction.Checked, oform.txtNumber.Text, 0)
                        ComputeTax(OrderPanel.Controls.IndexOf(selectedItem))
                    End If
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
                If Not IsNothing(selectedItem) Then
                    Dim index As Integer = OrderPanel.Controls.IndexOf(selectedItem)
                    OrderPanel.Controls.Remove(selectedItem)
                    GridView1.DeleteRow(index)
                    ComputeTotal()
                End If
            Else
                MsgBox("Please Add or Edit Transaction.")
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
