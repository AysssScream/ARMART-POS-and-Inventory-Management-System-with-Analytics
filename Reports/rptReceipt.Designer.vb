<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptReceipt
    Inherits NewTemplate.ReportBase

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptReceipt))
        Me.ReportTable1 = New NewTemplate.ReportTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportTable2 = New NewTemplate.ReportTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportTable3 = New NewTemplate.ReportTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.ReportLabel1 = New NewTemplate.ReportLabel()
        Me.ReportTable5 = New NewTemplate.ReportTable()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportTable4 = New NewTemplate.ReportTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.Logo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'lblReportTitle
        '
        Me.lblReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(251.4583!, 0!)
        Me.lblReportTitle.SizeF = New System.Drawing.SizeF(32.54166!, 19.99998!)
        Me.lblReportTitle.StylePriority.UseFont = False
        Me.lblReportTitle.StylePriority.UseTextAlignment = False
        Me.lblReportTitle.Visible = False
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ReportTable3})
        Me.Detail.HeightF = 18.0!
        Me.Detail.MultiColumn.ColumnCount = 10
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 20.0!
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.HeightF = 0!
        '
        'lblReportDate
        '
        Me.lblReportDate.LocationFloat = New DevExpress.Utils.PointFloat(251.4583!, 20.00001!)
        Me.lblReportDate.SizeF = New System.Drawing.SizeF(32.54166!, 20.0!)
        Me.lblReportDate.StylePriority.UseFont = False
        Me.lblReportDate.StylePriority.UseTextAlignment = False
        Me.lblReportDate.Visible = False
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ReportTable2, Me.ReportTable1})
        Me.ReportHeader.HeightF = 185.0!
        Me.ReportHeader.StylePriority.UseTextAlignment = False
        Me.ReportHeader.Controls.SetChildIndex(Me.lblAddress, 0)
        Me.ReportHeader.Controls.SetChildIndex(Me.lblReportDate, 0)
        Me.ReportHeader.Controls.SetChildIndex(Me.lblReportTitle, 0)
        Me.ReportHeader.Controls.SetChildIndex(Me.lblContactNo, 0)
        Me.ReportHeader.Controls.SetChildIndex(Me.lblCompanyName, 0)
        Me.ReportHeader.Controls.SetChildIndex(Me.WinControlContainer1, 0)
        Me.ReportHeader.Controls.SetChildIndex(Me.Line, 0)
        Me.ReportHeader.Controls.SetChildIndex(Me.ReportTable1, 0)
        Me.ReportHeader.Controls.SetChildIndex(Me.ReportTable2, 0)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 20.0!
        '
        'PageFooter
        '
        Me.PageFooter.Visible = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(212.5!, 21.99999!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        '
        'lblPrintSig
        '
        Me.lblPrintSig.SizeF = New System.Drawing.SizeF(212.5!, 13.00001!)
        Me.lblPrintSig.StylePriority.UseFont = False
        Me.lblPrintSig.StylePriority.UseTextAlignment = False
        '
        'lblCompanyName
        '
        Me.lblCompanyName.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lblCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(0!, 41.75002!)
        Me.lblCompanyName.SizeF = New System.Drawing.SizeF(290.2084!, 16.0!)
        Me.lblCompanyName.StylePriority.UseFont = False
        Me.lblCompanyName.StylePriority.UseTextAlignment = False
        Me.lblCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lblAddress.LocationFloat = New DevExpress.Utils.PointFloat(0!, 57.75002!)
        Me.lblAddress.SizeF = New System.Drawing.SizeF(294.0!, 16.0!)
        Me.lblAddress.StylePriority.UseFont = False
        Me.lblAddress.StylePriority.UseTextAlignment = False
        Me.lblAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lblContactNo
        '
        Me.lblContactNo.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lblContactNo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 73.75002!)
        Me.lblContactNo.Multiline = True
        Me.lblContactNo.SizeF = New System.Drawing.SizeF(294.0!, 16.0!)
        Me.lblContactNo.StylePriority.UseFont = False
        Me.lblContactNo.StylePriority.UseTextAlignment = False
        Me.lblContactNo.Text = "09458219663"
        Me.lblContactNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Line
        '
        Me.Line.LocationFloat = New DevExpress.Utils.PointFloat(235.1668!, 13.6666!)
        Me.Line.SizeF = New System.Drawing.SizeF(16.29156!, 6.333373!)
        Me.Line.StylePriority.UseBorders = False
        Me.Line.Visible = False
        '
        'WinControlContainer1
        '
        Me.WinControlContainer1.LocationFloat = New DevExpress.Utils.PointFloat(61.45837!, 0!)
        Me.WinControlContainer1.SizeF = New System.Drawing.SizeF(173.7084!, 41.75002!)
        '
        'Logo
        '
        Me.Logo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Properties.Appearance.Options.UseBackColor = True
        Me.Logo.Size = New System.Drawing.Size(167, 40)
        '
        'ReportTable1
        '
        Me.ReportTable1.FieldName = Nothing
        Me.ReportTable1.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.ReportTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 102.75!)
        Me.ReportTable1.Name = "ReportTable1"
        Me.ReportTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow3})
        Me.ReportTable1.SizeF = New System.Drawing.SizeF(290.2084!, 47.99996!)
        Me.ReportTable1.StylePriority.UseFont = False
        Me.ReportTable1.StylePriority.UseTextAlignment = False
        Me.ReportTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Text = "Receipt Date :"
        Me.XrTableCell1.Weight = 0.59798992570520437R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Tag = "Date_TransH"
        Me.XrTableCell2.TextFormatString = "{0:dd-MMM-yyyy  hh:mm:ss tt}"
        Me.XrTableCell2.Weight = 1.4020100742947956R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell4})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.Text = "Receipt #:"
        Me.XrTableCell3.Weight = 0.59798992570520437R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell4.StylePriority.UsePadding = False
        Me.XrTableCell4.Tag = "UserPK_TransH"
        Me.XrTableCell4.Weight = 1.4020100742947956R
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.Text = "Cashier:"
        Me.XrTableCell5.Weight = 0.59798992570520437R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.Tag = "name_usr"
        Me.XrTableCell6.Weight = 1.4020100742947956R
        '
        'ReportTable2
        '
        Me.ReportTable2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.ReportTable2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ReportTable2.FieldName = Nothing
        Me.ReportTable2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ReportTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 166.9167!)
        Me.ReportTable2.Name = "ReportTable2"
        Me.ReportTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.ReportTable2.SizeF = New System.Drawing.SizeF(293.9999!, 18.0!)
        Me.ReportTable2.StylePriority.UseBorderDashStyle = False
        Me.ReportTable2.StylePriority.UseBorders = False
        Me.ReportTable2.StylePriority.UseFont = False
        Me.ReportTable2.StylePriority.UseTextAlignment = False
        Me.ReportTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell10, Me.XrTableCell11})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.Text = "Item"
        Me.XrTableCell7.Weight = 2.0000002076025507R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "Price"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell8.Weight = 1.1165797676917482R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UsePadding = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "Qty"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell10.Weight = 0.54377606571397541R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.StylePriority.UsePadding = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Total"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell11.Weight = 1.1672085242966928R
        '
        'ReportTable3
        '
        Me.ReportTable3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.ReportTable3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ReportTable3.FieldName = Nothing
        Me.ReportTable3.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.ReportTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ReportTable3.Name = "ReportTable3"
        Me.ReportTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.ReportTable3.SizeF = New System.Drawing.SizeF(294.0!, 18.0!)
        Me.ReportTable3.StylePriority.UseBorderDashStyle = False
        Me.ReportTable3.StylePriority.UseBorders = False
        Me.ReportTable3.StylePriority.UseFont = False
        Me.ReportTable3.StylePriority.UseTextAlignment = False
        Me.ReportTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell15, Me.XrTableCell16})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Tag = "Description_Invty"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell12.Weight = 2.0904200713052479R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell13.Tag = "Price_LdgrInvty"
        Me.XrTableCell13.Text = " "
        Me.XrTableCell13.TextFormatString = "{0:n2}"
        Me.XrTableCell13.Weight = 1.1374804978651638R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UsePadding = False
        Me.XrTableCell15.Tag = "QtyOut_LdgrInvty"
        Me.XrTableCell15.Text = " "
        Me.XrTableCell15.TextFormatString = "{0:n0}"
        Me.XrTableCell15.Weight = 0.56319943910611914R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell16.StylePriority.UsePadding = False
        Me.XrTableCell16.Tag = "TotalAmount_LdgrInvty"
        Me.XrTableCell16.Text = " "
        Me.XrTableCell16.TextFormatString = "{0:n2}"
        Me.XrTableCell16.Weight = 1.2089006191336038R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ReportLabel1, Me.ReportTable5, Me.ReportTable4})
        Me.GroupFooter1.HeightF = 176.0834!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'ReportLabel1
        '
        Me.ReportLabel1.FieldName = Nothing
        Me.ReportLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 153.0834!)
        Me.ReportLabel1.Name = "ReportLabel1"
        Me.ReportLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ReportLabel1.SizeF = New System.Drawing.SizeF(294.0!, 23.0!)
        Me.ReportLabel1.StylePriority.UseTextAlignment = False
        Me.ReportLabel1.Text = "THANK YOU!"
        Me.ReportLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportTable5
        '
        Me.ReportTable5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.ReportTable5.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.ReportTable5.FieldName = Nothing
        Me.ReportTable5.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.ReportTable5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 88.0!)
        Me.ReportTable5.Name = "ReportTable5"
        Me.ReportTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow10, Me.XrTableRow11})
        Me.ReportTable5.SizeF = New System.Drawing.SizeF(294.0!, 36.0!)
        Me.ReportTable5.StylePriority.UseBorderDashStyle = False
        Me.ReportTable5.StylePriority.UseBorders = False
        Me.ReportTable5.StylePriority.UseFont = False
        Me.ReportTable5.StylePriority.UseTextAlignment = False
        Me.ReportTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell25, Me.XrTableCell26})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100.0!)
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UsePadding = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.Text = "Cash:"
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell25.Weight = 2.0904200713052479R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell26.StylePriority.UsePadding = False
        Me.XrTableCell26.Tag = "TenderAmount_TransH"
        Me.XrTableCell26.Text = "TenderAmount_TransH"
        Me.XrTableCell26.TextFormatString = "{0:n2}"
        Me.XrTableCell26.Weight = 0.94228337685893826R
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 1.0R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell27.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell27.StylePriority.UseBorders = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UsePadding = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.Text = "Change:"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell27.Weight = 2.0904200713052479R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell28.StylePriority.UseBorders = False
        Me.XrTableCell28.StylePriority.UsePadding = False
        Me.XrTableCell28.Tag = "ChangeAmount_TransH"
        Me.XrTableCell28.Text = "ChangeAmount_TransH"
        Me.XrTableCell28.TextFormatString = "{0:n2}"
        Me.XrTableCell28.Weight = 0.94228337685893826R
        '
        'ReportTable4
        '
        Me.ReportTable4.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
        Me.ReportTable4.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.ReportTable4.FieldName = Nothing
        Me.ReportTable4.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.ReportTable4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 10.0!)
        Me.ReportTable4.Name = "ReportTable4"
        Me.ReportTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6, Me.XrTableRow7})
        Me.ReportTable4.SizeF = New System.Drawing.SizeF(294.0!, 36.0!)
        Me.ReportTable4.StylePriority.UseBorderDashStyle = False
        Me.ReportTable4.StylePriority.UseBorders = False
        Me.ReportTable4.StylePriority.UseFont = False
        Me.ReportTable4.StylePriority.UseTextAlignment = False
        Me.ReportTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell17, Me.XrTableCell21})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100.0!)
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.StylePriority.UsePadding = False
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.Text = "Total Sales:"
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell17.Weight = 2.0904200713052479R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell21.StylePriority.UsePadding = False
        Me.XrTableCell21.Tag = "TotalAmount_TransH"
        Me.XrTableCell21.Text = "TotalAmount_TransH"
        Me.XrTableCell21.TextFormatString = "{0:n2}"
        Me.XrTableCell21.Weight = 0.94228337685893826R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell18, Me.XrTableCell19})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell18.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell18.StylePriority.UseBorders = False
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UsePadding = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "Discount:"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell18.Weight = 2.0904200713052479R
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell19.StylePriority.UseBorders = False
        Me.XrTableCell19.StylePriority.UsePadding = False
        Me.XrTableCell19.Tag = "DiscountAmount_TransH"
        Me.XrTableCell19.Text = "DiscountAmount_TransH"
        Me.XrTableCell19.TextFormatString = "{0:n2}"
        Me.XrTableCell19.Weight = 0.94228337685893826R
        '
        'rptReceipt
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.ReportHeader, Me.TopMargin, Me.PageFooter, Me.GroupFooter1})
        Me.IsContinous = True
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 20, 20)
        Me.PageWidth = 314
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.QueryFromInfo = resources.GetString("$this.QueryFromInfo")
        Me.RollPaper = True
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "17.2"
        Me.Controls.SetChildIndex(Me.GroupFooter1, 0)
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
        CType(Me.ReportTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportTable1 As ReportTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportTable3 As ReportTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportTable2 As ReportTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents ReportTable4 As ReportTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportTable5 As ReportTable
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportLabel1 As ReportLabel
End Class
