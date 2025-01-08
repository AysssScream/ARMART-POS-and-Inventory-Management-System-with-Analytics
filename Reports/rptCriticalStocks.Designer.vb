<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptCriticalStocks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptCriticalStocks))
        Me.ReportTable1 = New NewTemplate.ReportTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportTable3 = New NewTemplate.ReportTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        CType(Me.Logo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTable3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ReportTable1})
        Me.PageHeader.HeightF = 20.0!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.HeightF = 0!
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
        Me.lblPrintSig.SizeF = New System.Drawing.SizeF(554.1667!, 13.00001!)
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
        Me.ReportTable1.BackColor = System.Drawing.Color.Gainsboro
        Me.ReportTable1.BorderColor = System.Drawing.Color.DarkGray
        Me.ReportTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ReportTable1.FieldName = Nothing
        Me.ReportTable1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ReportTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ReportTable1.Name = "ReportTable1"
        Me.ReportTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.ReportTable1.SizeF = New System.Drawing.SizeF(799.0001!, 20.0!)
        Me.ReportTable1.StylePriority.UseBackColor = False
        Me.ReportTable1.StylePriority.UseBorderColor = False
        Me.ReportTable1.StylePriority.UseBorders = False
        Me.ReportTable1.StylePriority.UseFont = False
        Me.ReportTable1.StylePriority.UseTextAlignment = False
        Me.ReportTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell5, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell7.StylePriority.UsePadding = False
        Me.XrTableCell7.Text = "#"
        Me.XrTableCell7.Weight = 0.24701481883101062R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell1.Text = "Item Code"
        Me.XrTableCell1.Weight = 1.7059800736679653R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell2.Text = "Description"
        Me.XrTableCell2.Weight = 2.9343265904139879R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.Text = "Qty on hand"
        Me.XrTableCell5.Weight = 0.53545651120552407R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell3.Text = "Re-Order Level"
        Me.XrTableCell3.Weight = 1.3186975178002527R
        '
        'ReportTable3
        '
        Me.ReportTable3.BorderColor = System.Drawing.Color.DarkGray
        Me.ReportTable3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.ReportTable3.FieldName = Nothing
        Me.ReportTable3.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.ReportTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ReportTable3.Name = "ReportTable3"
        Me.ReportTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.ReportTable3.SizeF = New System.Drawing.SizeF(799.0001!, 20.0!)
        Me.ReportTable3.StylePriority.UseBorderColor = False
        Me.ReportTable3.StylePriority.UseBorders = False
        Me.ReportTable3.StylePriority.UseFont = False
        Me.ReportTable3.StylePriority.UseTextAlignment = False
        Me.ReportTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell15})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UsePadding = False
        Me.XrTableCell6.Text = "No."
        Me.XrTableCell6.Weight = 0.15592234023246793R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.Tag = "ItemCode_Invty"
        Me.XrTableCell10.Text = "ItemCode_Invty"
        Me.XrTableCell10.TextFormatString = "{0:d}"
        Me.XrTableCell10.Weight = 1.0768600907282191R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell11.Tag = "Description_Invty"
        Me.XrTableCell11.Text = "Description_Invty"
        Me.XrTableCell11.Weight = 1.8522251549770135R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell12.StylePriority.UsePadding = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Tag = "Quantity_Invty"
        Me.XrTableCell12.Text = "Quantity_Invty"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell12.TextFormatString = "{0:n0}"
        Me.XrTableCell12.Weight = 0.33799442085376735R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UsePadding = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Tag = "ReOrderLevel_Invty"
        Me.XrTableCell15.Text = "ReOrderLevel_Invty"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell15.TextFormatString = "{0:n0}"
        Me.XrTableCell15.Weight = 0.83239694522990382R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rptCriticalStocks
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.ReportHeader, Me.TopMargin, Me.PageFooter, Me.GroupFooter1})
        Me.QueryFromInfo = resources.GetString("$this.QueryFromInfo")
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
        CType(Me.ReportTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents ReportTable1 As ReportTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportTable3 As ReportTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
End Class
