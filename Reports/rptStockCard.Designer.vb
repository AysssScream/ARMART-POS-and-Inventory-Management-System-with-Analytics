<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptStockCard
    Inherits NewTemplate.ReportBase

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptStockCard))
        Me.ReportTable1 = New NewTemplate.ReportTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.ReportTable2 = New NewTemplate.ReportTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportTable3 = New NewTemplate.ReportTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.ReportLabel1 = New NewTemplate.ReportLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.ReportTable4 = New NewTemplate.ReportTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.Logo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'lblReportTitle
        '
        Me.lblReportTitle.StylePriority.UseFont = False
        Me.lblReportTitle.StylePriority.UseTextAlignment = False
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ReportTable3})
        Me.Detail.HeightF = 20.0!
        Me.Detail.MultiColumn.ColumnCount = 10
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ReportTable4})
        Me.GroupHeader1.HeightF = 20.0!
        '
        'lblReportDate
        '
        Me.lblReportDate.StylePriority.UseFont = False
        Me.lblReportDate.StylePriority.UseTextAlignment = False
        '
        'ReportHeader
        '
        Me.ReportHeader.StylePriority.UseTextAlignment = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        '
        'lblPrintSig
        '
        Me.lblPrintSig.StylePriority.UseFont = False
        Me.lblPrintSig.StylePriority.UseTextAlignment = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.StylePriority.UseFont = False
        Me.lblCompanyName.StylePriority.UseTextAlignment = False
        '
        'lblAddress
        '
        Me.lblAddress.StylePriority.UseFont = False
        Me.lblAddress.StylePriority.UseTextAlignment = False
        '
        'lblContactNo
        '
        Me.lblContactNo.StylePriority.UseFont = False
        Me.lblContactNo.StylePriority.UseTextAlignment = False
        '
        'Line
        '
        Me.Line.StylePriority.UseBorders = False
        '
        'Logo
        '
        Me.Logo.EditValue = CType(resources.GetObject("Logo.EditValue"), Object)
        Me.Logo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Properties.Appearance.Options.UseBackColor = True
        '
        'ReportTable1
        '
        Me.ReportTable1.BorderColor = System.Drawing.Color.DarkGray
        Me.ReportTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ReportTable1.FieldName = Nothing
        Me.ReportTable1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ReportTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.0!)
        Me.ReportTable1.Name = "ReportTable1"
        Me.ReportTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.ReportTable1.SizeF = New System.Drawing.SizeF(747.9167!, 20.0!)
        Me.ReportTable1.StylePriority.UseBorderColor = False
        Me.ReportTable1.StylePriority.UseBorders = False
        Me.ReportTable1.StylePriority.UseFont = False
        Me.ReportTable1.StylePriority.UseTextAlignment = False
        Me.ReportTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell3, Me.XrTableCell9})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Text = "Date"
        Me.XrTableCell1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Text = "Transaction #"
        Me.XrTableCell2.Weight = 1.0R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.StylePriority.UsePadding = False
        Me.XrTableCell4.Text = "Module"
        Me.XrTableCell4.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Qty In"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Qty Out"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell3.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "Balance"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell9.Weight = 0.98333349609375R
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ReportTable1, Me.ReportTable2})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("PK_Invty", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.HeightF = 40.0!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.Tag = "PK_Invty"
        '
        'ReportTable2
        '
        Me.ReportTable2.BackColor = System.Drawing.Color.Gainsboro
        Me.ReportTable2.FieldName = Nothing
        Me.ReportTable2.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.ReportTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ReportTable2.Name = "ReportTable2"
        Me.ReportTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.ReportTable2.SizeF = New System.Drawing.SizeF(750.0!, 20.0!)
        Me.ReportTable2.StylePriority.UseBackColor = False
        Me.ReportTable2.StylePriority.UseFont = False
        Me.ReportTable2.StylePriority.UseTextAlignment = False
        Me.ReportTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell16})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.Tag = "ItemCode_Invty"
        Me.XrTableCell6.Text = "ItemCode_Invty"
        Me.XrTableCell6.Weight = 0.75R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.Tag = "BarCode_Invty"
        Me.XrTableCell7.Text = "BarCode_Invty"
        Me.XrTableCell7.Weight = 0.75R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell8.Tag = "Description_Invty"
        Me.XrTableCell8.Text = "Description_Invty"
        Me.XrTableCell8.Weight = 2.2395834350585937R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.Tag = "PK_Invty"
        Me.XrTableCell16.Visible = False
        Me.XrTableCell16.Weight = 0.010416564941406248R
        '
        'ReportTable3
        '
        Me.ReportTable3.BorderColor = System.Drawing.Color.DarkGray
        Me.ReportTable3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ReportTable3.FieldName = Nothing
        Me.ReportTable3.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ReportTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ReportTable3.Name = "ReportTable3"
        Me.ReportTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.ReportTable3.SizeF = New System.Drawing.SizeF(747.9167!, 20.0!)
        Me.ReportTable3.StylePriority.UseBorderColor = False
        Me.ReportTable3.StylePriority.UseBorders = False
        Me.ReportTable3.StylePriority.UseFont = False
        Me.ReportTable3.StylePriority.UseTextAlignment = False
        Me.ReportTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.Tag = "Date_TransH"
        Me.XrTableCell10.Text = "Date"
        Me.XrTableCell10.TextFormatString = "{0:d}"
        Me.XrTableCell10.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.Tag = "UserPK_TransH"
        Me.XrTableCell11.Text = "Transaction #"
        Me.XrTableCell11.Weight = 1.0R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.Tag = "Module_TransH"
        Me.XrTableCell12.Text = "Module"
        Me.XrTableCell12.Weight = 1.0R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell13.StylePriority.UsePadding = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        Me.XrTableCell13.Tag = "QtyIn_LdgrInvty"
        Me.XrTableCell13.Text = "Quantity In"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell13.TextFormatString = "{0:n2}"
        Me.XrTableCell13.Weight = 1.0R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell14.StylePriority.UseTextAlignment = False
        Me.XrTableCell14.Tag = "QtyOut_LdgrInvty"
        Me.XrTableCell14.Text = "Quantity Out"
        Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell14.TextFormatString = "{0:n2}"
        Me.XrTableCell14.Weight = 1.0R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UsePadding = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "Balance"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell15.TextFormatString = "{0:n0}"
        Me.XrTableCell15.Weight = 0.98333349609375R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ReportLabel1})
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 23.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'ReportLabel1
        '
        Me.ReportLabel1.BorderColor = System.Drawing.Color.DarkGray
        Me.ReportLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ReportLabel1.FieldName = Nothing
        Me.ReportLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ReportLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ReportLabel1.Name = "ReportLabel1"
        Me.ReportLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ReportLabel1.SizeF = New System.Drawing.SizeF(747.9167!, 23.0!)
        Me.ReportLabel1.StylePriority.UseBorderColor = False
        Me.ReportLabel1.StylePriority.UseBorders = False
        Me.ReportLabel1.StylePriority.UseFont = False
        Me.ReportLabel1.StylePriority.UseTextAlignment = False
        Me.ReportLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.ReportLabel1.TextFormatString = "{0:n0}"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.HeightF = 0!
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'ReportTable4
        '
        Me.ReportTable4.BorderColor = System.Drawing.Color.DarkGray
        Me.ReportTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ReportTable4.FieldName = Nothing
        Me.ReportTable4.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ReportTable4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ReportTable4.Name = "ReportTable4"
        Me.ReportTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.ReportTable4.SizeF = New System.Drawing.SizeF(747.9167!, 20.0!)
        Me.ReportTable4.StylePriority.UseBorderColor = False
        Me.ReportTable4.StylePriority.UseBorders = False
        Me.ReportTable4.StylePriority.UseFont = False
        Me.ReportTable4.StylePriority.UseTextAlignment = False
        Me.ReportTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell17, Me.XrTableCell22})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell17.StylePriority.UseBorders = False
        Me.XrTableCell17.Text = "P R E V I O U S    B A L A N C E"
        Me.XrTableCell17.Weight = 1.6596933215763179R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell22.StylePriority.UseBorders = False
        Me.XrTableCell22.StylePriority.UsePadding = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.Text = "Balance"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell22.TextFormatString = "{0:n0}"
        Me.XrTableCell22.Weight = 0.3264063840475242R
        '
        'rptStockCard
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.ReportHeader, Me.TopMargin, Me.PageFooter, Me.GroupHeader2, Me.GroupFooter1, Me.GroupFooter2})
        Me.QueryFromInfo = resources.GetString("$this.QueryFromInfo")
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.2"
        Me.Controls.SetChildIndex(Me.GroupFooter2, 0)
        Me.Controls.SetChildIndex(Me.GroupFooter1, 0)
        Me.Controls.SetChildIndex(Me.GroupHeader2, 0)
        Me.Controls.SetChildIndex(Me.PageFooter, 0)
        Me.Controls.SetChildIndex(Me.TopMargin, 0)
        Me.Controls.SetChildIndex(Me.ReportHeader, 0)
        Me.Controls.SetChildIndex(Me.GroupHeader1, 0)
        Me.Controls.SetChildIndex(Me.PageHeader, 0)
        Me.Controls.SetChildIndex(Me.BottomMargin, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        CType(Me.Logo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents ReportTable1 As ReportTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents ReportTable2 As ReportTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportTable3 As ReportTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents ReportLabel1 As ReportLabel
    Friend WithEvents ReportTable4 As ReportTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
End Class
