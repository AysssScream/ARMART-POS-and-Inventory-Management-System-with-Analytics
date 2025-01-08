Imports DevExpress.XtraCharts
Imports DevExpress.Utils

Public Class Dashboard

    Private Sub Dashboard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim dateToday As DateTime = Now()

        Dim totalProducts As String = String.Format("Select COUNT(PK_Invty) as cnt From inventories")
        Dim dtTotalProducts As DataTable = AppData.GetDataTable(totalProducts)
        lblInventory.Text = dtTotalProducts.Rows(0)("cnt")

        Dim dailySales As String = String.Format("Select SUM(TotalAmount_TransH) as sumSales From transaction_headers Where Module_TransH IN('cashinvoice','chargeinvoice','pos') AND Date_TransH = '{0}'", dateToday.ToString("yyyy-MM-dd"))
        Dim dtSales As DataTable = AppData.GetDataTable(dailySales)
        lblSales.Text = StrVal9(dtSales.Rows(0)("sumSales")).ToString("n2")

        Dim totalOnHand As String = String.Format("Select SUM(Quantity_Invty) as totalOnHand From inventories")
        Dim dtTotalOnHand As DataTable = AppData.GetDataTable(totalOnHand)
        lblOnhand.Text = StrVal9(dtTotalOnHand.Rows(0)("totalOnHand")).ToString("n0")

        Dim totalCritical As String = String.Format("Select COUNT(PK_Invty) as cnt From inventories Where CAST(IFNULL(quantity_invty,0) AS UNSIGNED) <= CAST(IFNULL(reorderlevel_invty,0) AS UNSIGNED)")
        Dim dtTotalCritical As DataTable = AppData.GetDataTable(totalCritical)
        lblCritical.Text = dtTotalCritical.Rows(0)("cnt")

        ' SQL query to calculate the total quantity of items sold today
        Dim sqlDailyItemsSold As String = String.Format("SELECT IFNULL(SUM(tli.QtyOut_LdgrInvty), 0) AS TotalItemsSold FROM transaction_ledger_inventories AS tli INNER JOIN transaction_headers AS th ON tli.FK_TransH_LdgrInvty = th.PK_TransH WHERE th.Date_TransH = '{0}' AND th.Module_TransH IN ('cashinvoice', 'chargeinvoice', 'pos')", dateToday.ToString("yyyy-MM-dd"))
        Dim dtDailyItemsSold As DataTable = AppData.GetDataTable(sqlDailyItemsSold)

        ' Update the label with the total items sold today
        lblDailyItemsSold.Text = Convert.ToInt32(dtDailyItemsSold.Rows(0)("TotalItemsSold")).ToString("N0") ' Format as number with commas

        ' Create the first chart for sales data
        Dim salesChart As New ChartControl()
        salesChart.Font = New System.Drawing.Font("Poppins", 12.0!)
        salesChart.ForeColor = Color.Black

        Dim series1 As New Series("Sales Data", ViewType.Line)
        Dim palette As New Palette("ModernPalette")
        palette.Add(Color.FromArgb(93, 173, 226))  ' Light blue
        palette.Add(Color.FromArgb(88, 214, 141))  ' Light green
        palette.Add(Color.FromArgb(245, 176, 65))  ' Light orange
        salesChart.PaletteRepository.Add(palette.Name, palette)
        salesChart.PaletteName = palette.Name

        For i As Integer = 6 To 0 Step -1
            Dim dateSales = DateAdd("d", i * -1, dateToday)
            Dim dateLabel = DateAdd("d", i * -1, dateToday)
            Dim sales As String = String.Format("Select SUM(TotalAmount_TransH) as sumSales from transaction_headers Where Module_TransH IN('cashinvoice','chargeinvoice','pos') AND Date_TransH = '{0}'", dateSales.ToString("yyyy-MM-dd"))
            Dim dtTotalSales As DataTable = AppData.GetDataTable(sales)
            series1.Points.Add(New SeriesPoint(dateLabel, StrVal9(dtTotalSales.Rows(0)("sumSales")).ToString("n2")))
        Next

        salesChart.Series.Add(series1)

        ' Make the line thicker
        Dim lineView1 As LineSeriesView = CType(series1.View, LineSeriesView)
        lineView1.LineStyle.Thickness = 7  ' Adjust the thickness as needed

        ' Chart styling
        salesChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        Dim diagram1 As XYDiagram = CType(salesChart.Diagram, XYDiagram)
        diagram1.Rotated = False
        diagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.False  ' Remove the "Date" title
        diagram1.AxisY.Title.Text = "Sales Amount ($)"
        diagram1.AxisX.Label.Font = New Font("Poppins", 10)
        diagram1.AxisY.Label.Font = New Font("Poppins", 10)

        ' Axis styling
        diagram1.AxisX.Label.TextColor = Color.Black
        diagram1.AxisY.Label.TextColor = Color.Black
        diagram1.AxisX.Label.Angle = 0  ' Set angle to 0 for horizontal labels
        diagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
        diagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False

        ' Grid lines
        diagram1.AxisX.GridLines.Visible = False
        diagram1.AxisY.GridLines.Visible = True
        diagram1.AxisX.GridLines.MinorVisible = False
        diagram1.AxisY.GridLines.MinorVisible = False
        diagram1.AxisY.GridLines.Color = Color.LightGray

        ' Title setup
        Dim chartTitle1 As New ChartTitle()
        chartTitle1.Text = "Sales Data Over the Last 7 Days"
        chartTitle1.Font = New Font("Poppins", 16.0!, FontStyle.Bold)
        chartTitle1.Alignment = StringAlignment.Center
        salesChart.Titles.Add(chartTitle1)

        ' Background and grid lines
        salesChart.BackColor = Color.White

        ' Add the sales chart to the form
        salesChart.Dock = DockStyle.Fill
        BarChartPanel.Controls.Add(salesChart)

        ' Create the second chart for items sold data
        Dim itemsSoldChart As New ChartControl()
        itemsSoldChart.Font = New System.Drawing.Font("Poppins", 12.0!)
        itemsSoldChart.ForeColor = Color.Black

        Dim series2 As New Series("Items Sold", ViewType.Line)

        For i As Integer = 6 To 0 Step -1
            Dim dateItemsSold = DateAdd("d", i * -1, dateToday)
            Dim dateLabel = DateAdd("d", i * -1, dateToday)
            Dim itemsSold As String = String.Format("SELECT IFNULL(SUM(tli.QtyOut_LdgrInvty), 0) AS TotalItemsSold FROM transaction_ledger_inventories AS tli INNER JOIN transaction_headers AS th ON tli.FK_TransH_LdgrInvty = th.PK_TransH WHERE th.Date_TransH = '{0}' AND th.Module_TransH IN ('cashinvoice', 'chargeinvoice', 'pos')", dateItemsSold.ToString("yyyy-MM-dd"))
            Dim dtItemsSold As DataTable = AppData.GetDataTable(itemsSold)
            series2.Points.Add(New SeriesPoint(dateLabel, Convert.ToInt32(dtItemsSold.Rows(0)("TotalItemsSold"))))
        Next

        itemsSoldChart.Series.Add(series2)

        ' Make the line thicker
        Dim lineView2 As LineSeriesView = CType(series2.View, LineSeriesView)
        lineView2.LineStyle.Thickness = 7  ' Adjust the thickness as needed

        ' Chart styling
        itemsSoldChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        Dim diagram2 As XYDiagram = CType(itemsSoldChart.Diagram, XYDiagram)
        diagram2.Rotated = False
        diagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.False  ' Remove the "Date" title
        diagram2.AxisY.Title.Text = "Items Sold"
        diagram2.AxisX.Label.Font = New Font("Poppins", 10)
        diagram2.AxisY.Label.Font = New Font("Poppins", 10)

        ' Axis styling
        diagram2.AxisX.Label.TextColor = Color.Black
        diagram2.AxisY.Label.TextColor = Color.Black
        diagram2.AxisX.Label.Angle = 0  ' Set angle to 0 for horizontal labels
        diagram2.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
        diagram2.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False

        ' Grid lines
        diagram2.AxisX.GridLines.Visible = False
        diagram2.AxisY.GridLines.Visible = True
        diagram2.AxisX.GridLines.MinorVisible = False
        diagram2.AxisY.GridLines.MinorVisible = False
        diagram2.AxisY.GridLines.Color = Color.LightGray

        ' Title setup for items sold chart
        Dim chartTitle2 As New ChartTitle()
        chartTitle2.Text = "Items Sold Over the Last 7 Days"
        chartTitle2.Font = New Font("Poppins", 16.0!, FontStyle.Bold)
        chartTitle2.Alignment = StringAlignment.Center
        itemsSoldChart.Titles.Add(chartTitle2)

        ' Background and grid lines for items sold chart
        itemsSoldChart.BackColor = Color.White

        ' Add the items sold chart to the form
        itemsSoldChart.Dock = DockStyle.Fill
        ItemsSoldChartPanel.Controls.Add(itemsSoldChart)

        ' Create the pie chart for top selling products by quantity
        Dim sqlTopSellingProducts As String = "SELECT Description_Invty, SUM(QtyOut_LdgrInvty) AS TotalQuantitySold " &
                                              "FROM transaction_ledger_inventories " &
                                              "LEFT JOIN inventories ON fk_invty_ldgrinvty = pk_invty " &
                                              "GROUP BY fk_invty_ldgrinvty " &
                                              "ORDER BY TotalQuantitySold DESC " &
                                              "LIMIT 5"
        Dim dtTopSellingProducts As DataTable = AppData.GetDataTable(sqlTopSellingProducts)

        Dim pieChart As New ChartControl()
        pieChart.Font = New System.Drawing.Font("Poppins", 12.0!)
        pieChart.ForeColor = Color.Black

        Dim pieSeries As New Series("Top Selling Products", ViewType.Pie)

        For Each row As DataRow In dtTopSellingProducts.Rows
            Dim productName As String = row("Description_Invty").ToString()
            Dim quantitySold As Integer = Convert.ToInt32(row("TotalQuantitySold"))
            pieSeries.Points.Add(New SeriesPoint(productName, quantitySold))
        Next

        pieChart.Series.Add(pieSeries)

        ' Customize the pie chart appearance
        Dim pieView As PieSeriesView = CType(pieSeries.View, PieSeriesView)
        pieView.Titles.Add(New SeriesTitle())
        pieView.Titles(0).Text = "Top Selling Products by Quantity"
        pieView.Titles(0).Font = New Font("Poppins", 16.0!, FontStyle.Bold)
        pieView.Titles(0).Alignment = StringAlignment.Center
        pieView.ExplodeMode = PieExplodeMode.UsePoints
        pieView.ExplodedPoints.Add(pieSeries.Points(0)) ' Explode the first slice for emphasis
        pieView.ExplodedDistancePercentage = 30
        pieView.RuntimeExploding = True

        ' Customize the pie chart labels to show name and percentage
        Dim pieSeriesLabel As PieSeriesLabel = CType(pieSeries.Label, PieSeriesLabel)
        pieSeriesLabel.TextPattern = "{A}: {VP:P0}" ' {A} is the argument (product name), {VP:P0} is the percentage value
        pieSeriesLabel.Position = PieSeriesLabelPosition.TwoColumns

        ' Enable tooltips
        pieChart.ToolTipEnabled = DefaultBoolean.True
        pieChart.ToolTipOptions.ShowForPoints = True

        ' Customize the tooltip content
        AddHandler pieChart.ObjectHotTracked, AddressOf OnPieChartObjectHotTracked

        pieChart.Dock = DockStyle.Fill
        PieChartPanel.Controls.Add(pieChart)

        ''Top Selling Products
        Try
            Dim sql As String = String.Format("Select SUM((QtyOut_LdgrInvty * Price_LdgrInvty)) as sumSales, Description_Invty, Name_Cat from transaction_ledger_inventories left join transaction_headers on FK_TransH_LdgrInvty = PK_TransH left join inventories on fk_invty_ldgrinvty = pk_invty left join categories on fk_cat_invty = pk_cat Where Module_TransH IN('cashinvoice','chargeinvoice','pos')  group by fk_invty_ldgrinvty order by sumSales desc limit 5")
            Dim dt As DataTable = AppData.GetDataTable(sql)

            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                Dim topSelling = New TopSellingProduct
                With topSelling
                    .Dock = DockStyle.Top
                    .lblCategory.Text = dt.Rows(i)("Name_Cat").ToString
                    .lblProduct.Text = dt.Rows(i)("Description_Invty").ToString
                    .lblTotal.Text = StrVal9(dt.Rows(i)("sumSales")).ToString("n2")
                    .lblNo.Text = i + 1
                    .Qty.Visible = False
                    .pbWarning.Visible = False
                End With

                TopSellingPanel.Controls.Add(topSelling)
            Next
        Catch ex As Exception
            ' Handle exceptions or log errors as needed
        End Try

        ''All Critical Products
        Try
            ' Update the query to select all critical products without the limit.
            Dim sql As String = String.Format("Select Description_Invty, Name_Cat, Quantity_Invty From inventories Join categories On fk_cat_invty = pk_cat Where CAST(IFNULL(Quantity_Invty, 0) AS UNSIGNED) <= CAST(IFNULL(ReorderLevel_Invty, 0) AS UNSIGNED) Order By Quantity_Invty Asc")
            Dim dt As DataTable = AppData.GetDataTable(sql)

            For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                Dim criticalProduct = New TopSellingProduct  ' Assuming you can reuse the same control or create a similar one for critical products
                With criticalProduct
                    .Dock = DockStyle.Top
                    .lblCategory.Text = dt.Rows(i)("Name_Cat").ToString
                    .lblProduct.Text = dt.Rows(i)("Description_Invty").ToString
                    .lblTotal.Text = StrVal9(dt.Rows(i)("Quantity_Invty")).ToString("n0")  ' Display quantity on hand
                    .lblNo.Text = i + 1
                    .Qty.Visible = True
                    .pbWarning.Visible = True
                End With

                CriticalPanel.Controls.Add(criticalProduct)  ' Assuming CriticalPanel is the name of the panel where you want to display critical products
            Next
        Catch ex As Exception
            ' Handle exceptions or log errors as needed
        End Try

        ''Expiring Products
        'Dim sql2 As String = String.Format("Select * from inventory_batches left join inventories on fk_invty_invtybtch = pk_invty Where Quantity_Invty```
        'Dim sql2 As String = String.Format("Select * from inventory_batches left join inventories on fk_invty_invtybtch = pk_invty Where Quantity_InvtyBtch > 0 AND ExpiryDate_InvtyBtch IS NOT NULL order by ExpiryDate_InvtyBtch asc limit 5")
        'Dim dt2 As DataTable = AppData.GetDataTable(sql2)

        'For i As Integer = dt2.Rows.Count - 1 To 0 Step -1
        '    Dim topSelling = New TopSellingProduct
        '    Dim dt As String = dt2.Rows(i)("ExpiryDate_InvtyBtch").ToString

        '    With topSelling
        '        .Dock = DockStyle.Top

        '        If dt <> "" Then
        '            .lblCategory.Text = dt2.Rows(i)("BatchNo_InvtyBtch").ToString & " | " & DateValue(dt2.Rows(i)("ExpiryDate_InvtyBtch").ToString).ToString("MMM dd, yyyy")
        '        Else
        '            .lblCategory.Text = dt2.Rows(i)("BatchNo_InvtyBtch").ToString
        '        End If

        '        .lblProduct.Text = dt2.Rows(i)("Description_Invty").ToString
        '        .lblTotal.Text = StrVal9(dt2.Rows(i)("Quantity_InvtyBtch")).ToString("n2") & vbCrLf & dt2.Rows(i)("PurchaseUnit_Invty").ToString
        '        .lblTotal.TextAlign = ContentAlignment.MiddleCenter
        '        .lblNo.Text = i + 1
        '    End With

        '    CriticalPanel.Controls.Add(topSelling)
        'Next

        ' Add a click event handler for the critical products label or panel
        AddHandler lblCritical.Click, AddressOf lblCritical_Click
    End Sub

    ' Event handler for customizing the tooltip content
    Private Sub OnPieChartObjectHotTracked(sender As Object, e As HotTrackEventArgs)
        If e.HitInfo.InSeries Then
            Dim point As SeriesPoint = e.HitInfo.SeriesPoint
            ToolTipController.DefaultController.ShowHint(String.Format("{0}: {1} sold", point.Argument, point.Values(0)), Cursor.Position)
        End If
    End Sub

    ' Event handler for the critical products label click event
    Private Sub lblCritical_Click(sender As Object, e As EventArgs)
        ' Open the CriticalProductsForm
        Dim criticalProductsForm As New CriticalProductsForm()
        criticalProductsForm.ShowDialog()
    End Sub

    Private Sub BarChartPanel_Paint(sender As Object, e As PaintEventArgs) Handles BarChartPanel.Paint

    End Sub

    Private Sub CriticalPanel_Paint(sender As Object, e As PaintEventArgs) Handles CriticalPanel.Paint

    End Sub

    Private Sub Column4_Paint(sender As Object, e As PaintEventArgs) Handles Column4.Paint

    End Sub

    Private Sub TopSellingPanel_Paint(sender As Object, e As PaintEventArgs) Handles TopSellingPanel.Paint

    End Sub
End Class


