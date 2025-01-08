<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportFormBase
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportFormBase))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.ReportPanel = New System.Windows.Forms.Panel()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.FilterPanel = New System.Windows.Forms.Panel()
        Me.PtLabel1 = New NewTemplate.PTLabel()
        Me.PtDateFilter1 = New NewTemplate.PTDateFilter()
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.PreviewPanel = New System.Windows.Forms.Panel()
        Me.DocumentViewer1 = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExportWord = New FontAwesome.Sharp.IconButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExportExcel = New FontAwesome.Sharp.IconButton()
        Me.btnExportPDF = New FontAwesome.Sharp.IconButton()
        Me.btnZoomIn = New FontAwesome.Sharp.IconButton()
        Me.btnZoomOut = New FontAwesome.Sharp.IconButton()
        Me.btnPrint = New FontAwesome.Sharp.IconButton()
        Me.btnPrintDialog = New FontAwesome.Sharp.IconButton()
        Me.btnOpenNewWindow = New FontAwesome.Sharp.IconButton()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.FilterPanel.SuspendLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        Me.PreviewPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.lblHeaderTitle)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.LightGray
        Me.Guna2GradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1215, 34)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(1215, 30)
        Me.lblHeaderTitle.TabIndex = 5
        Me.lblHeaderTitle.Text = "REPORT FORM BASE"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.XtraTabControl2)
        Me.SplitContainerControl1.Panel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl3)
        Me.SplitContainerControl1.Panel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1215, 476)
        Me.SplitContainerControl1.SplitterPosition = 355
        Me.SplitContainerControl1.TabIndex = 3
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabControl1.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.Appearance.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.Header.Options.UseTextOptions = True
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 227)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(349, 249)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.ReportPanel)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(343, 221)
        Me.XtraTabPage1.Text = "REPORTS"
        '
        'ReportPanel
        '
        Me.ReportPanel.AutoScroll = True
        Me.ReportPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportPanel.Location = New System.Drawing.Point(0, 0)
        Me.ReportPanel.Name = "ReportPanel"
        Me.ReportPanel.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.ReportPanel.Size = New System.Drawing.Size(343, 221)
        Me.ReportPanel.TabIndex = 0
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabControl2.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.XtraTabControl2.Appearance.Options.UseBackColor = True
        Me.XtraTabControl2.Appearance.Options.UseFont = True
        Me.XtraTabControl2.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.XtraTabControl2.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl2.AppearancePage.Header.Options.UseTextOptions = True
        Me.XtraTabControl2.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabControl2.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.XtraTabControl2.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl2.Location = New System.Drawing.Point(3, 0)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl2.Size = New System.Drawing.Size(349, 227)
        Me.XtraTabControl2.TabIndex = 1
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage2.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage2.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage2.Controls.Add(Me.FilterPanel)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(343, 199)
        Me.XtraTabPage2.Text = "REPORT FILTERS"
        '
        'FilterPanel
        '
        Me.FilterPanel.BackColor = System.Drawing.Color.Transparent
        Me.FilterPanel.Controls.Add(Me.PtLabel1)
        Me.FilterPanel.Controls.Add(Me.PtDateFilter1)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FilterPanel.Location = New System.Drawing.Point(0, 0)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(343, 199)
        Me.FilterPanel.TabIndex = 0
        '
        'PtLabel1
        '
        Me.PtLabel1.AutoSize = True
        Me.PtLabel1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtLabel1.Location = New System.Drawing.Point(11, 16)
        Me.PtLabel1.Name = "PtLabel1"
        Me.PtLabel1.Size = New System.Drawing.Size(72, 14)
        Me.PtLabel1.TabIndex = 1
        Me.PtLabel1.TableField = ""
        Me.PtLabel1.TableName = ""
        Me.PtLabel1.Text = "Date Filter"
        Me.PtLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PtDateFilter1
        '
        Me.PtDateFilter1.EditValue = " Like '%2024-05-24%'"
        Me.PtDateFilter1.Location = New System.Drawing.Point(11, 33)
        Me.PtDateFilter1.Name = "PtDateFilter1"
        Me.PtDateFilter1.ReplaceDateField = Nothing
        Me.PtDateFilter1.Size = New System.Drawing.Size(320, 31)
        Me.PtDateFilter1.TabIndex = 0
        Me.PtDateFilter1.TableField = Nothing
        Me.PtDateFilter1.TableName = Nothing
        Me.PtDateFilter1.Tag = "5/24/2024"
        Me.PtDateFilter1.UseTableName = False
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabControl3.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.XtraTabControl3.Appearance.Options.UseBackColor = True
        Me.XtraTabControl3.Appearance.Options.UseFont = True
        Me.XtraTabControl3.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.XtraTabControl3.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl3.AppearancePage.Header.Options.UseTextOptions = True
        Me.XtraTabControl3.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabControl3.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.XtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl3.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl3.Location = New System.Drawing.Point(3, 0)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl3.Size = New System.Drawing.Size(849, 476)
        Me.XtraTabControl3.TabIndex = 4
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage3.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage3.Appearance.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabPage3.Appearance.PageClient.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabPage3.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage3.Controls.Add(Me.PreviewPanel)
        Me.XtraTabPage3.Controls.Add(Me.Panel1)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(843, 448)
        Me.XtraTabPage3.Text = "REPORT PREVIEW"
        '
        'PreviewPanel
        '
        Me.PreviewPanel.BackColor = System.Drawing.SystemColors.Control
        Me.PreviewPanel.Controls.Add(Me.DocumentViewer1)
        Me.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PreviewPanel.Location = New System.Drawing.Point(0, 53)
        Me.PreviewPanel.Name = "PreviewPanel"
        Me.PreviewPanel.Size = New System.Drawing.Size(843, 395)
        Me.PreviewPanel.TabIndex = 6
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentViewer1.IsMetric = False
        Me.DocumentViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentViewer1.Name = "DocumentViewer1"
        Me.DocumentViewer1.Size = New System.Drawing.Size(843, 395)
        Me.DocumentViewer1.TabIndex = 0
        Me.DocumentViewer1.Zoom = 0.9!
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnExportWord)
        Me.Panel1.Controls.Add(Me.btnExportExcel)
        Me.Panel1.Controls.Add(Me.btnExportPDF)
        Me.Panel1.Controls.Add(Me.btnZoomIn)
        Me.Panel1.Controls.Add(Me.btnZoomOut)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btnPrintDialog)
        Me.Panel1.Controls.Add(Me.btnOpenNewWindow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(843, 53)
        Me.Panel1.TabIndex = 0
        '
        'btnExportWord
        '
        Me.btnExportWord.BackColor = System.Drawing.Color.White
        Me.btnExportWord.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExportWord.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnExportWord.FlatAppearance.BorderSize = 2
        Me.btnExportWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportWord.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.btnExportWord.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnExportWord.IconColor = System.Drawing.Color.Black
        Me.btnExportWord.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExportWord.IconSize = 24
        Me.btnExportWord.ImageIndex = 2
        Me.btnExportWord.ImageList = Me.ImageList1
        Me.btnExportWord.Location = New System.Drawing.Point(570, 3)
        Me.btnExportWord.Name = "btnExportWord"
        Me.btnExportWord.Size = New System.Drawing.Size(81, 47)
        Me.btnExportWord.TabIndex = 13
        Me.btnExportWord.Text = "WORD"
        Me.btnExportWord.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportWord.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pdf.png")
        Me.ImageList1.Images.SetKeyName(1, "excel.png")
        Me.ImageList1.Images.SetKeyName(2, "word.png")
        '
        'btnExportExcel
        '
        Me.btnExportExcel.BackColor = System.Drawing.Color.White
        Me.btnExportExcel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnExportExcel.FlatAppearance.BorderSize = 2
        Me.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportExcel.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnExportExcel.IconColor = System.Drawing.Color.Black
        Me.btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExportExcel.IconSize = 24
        Me.btnExportExcel.ImageIndex = 1
        Me.btnExportExcel.ImageList = Me.ImageList1
        Me.btnExportExcel.Location = New System.Drawing.Point(489, 3)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(81, 47)
        Me.btnExportExcel.TabIndex = 12
        Me.btnExportExcel.Text = "EXCEL"
        Me.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportExcel.UseVisualStyleBackColor = False
        '
        'btnExportPDF
        '
        Me.btnExportPDF.BackColor = System.Drawing.Color.White
        Me.btnExportPDF.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnExportPDF.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnExportPDF.FlatAppearance.BorderSize = 2
        Me.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportPDF.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.btnExportPDF.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnExportPDF.IconColor = System.Drawing.Color.Black
        Me.btnExportPDF.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExportPDF.IconSize = 24
        Me.btnExportPDF.ImageIndex = 0
        Me.btnExportPDF.ImageList = Me.ImageList1
        Me.btnExportPDF.Location = New System.Drawing.Point(408, 3)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(81, 47)
        Me.btnExportPDF.TabIndex = 11
        Me.btnExportPDF.Text = "PDF"
        Me.btnExportPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportPDF.UseVisualStyleBackColor = False
        '
        'btnZoomIn
        '
        Me.btnZoomIn.BackColor = System.Drawing.Color.White
        Me.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnZoomIn.FlatAppearance.BorderSize = 2
        Me.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomIn.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.btnZoomIn.IconChar = FontAwesome.Sharp.IconChar.SearchPlus
        Me.btnZoomIn.IconColor = System.Drawing.Color.Black
        Me.btnZoomIn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnZoomIn.IconSize = 24
        Me.btnZoomIn.Location = New System.Drawing.Point(327, 3)
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(81, 47)
        Me.btnZoomIn.TabIndex = 10
        Me.btnZoomIn.Text = "ZOOM IN"
        Me.btnZoomIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnZoomIn.UseVisualStyleBackColor = False
        '
        'btnZoomOut
        '
        Me.btnZoomOut.BackColor = System.Drawing.Color.White
        Me.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnZoomOut.FlatAppearance.BorderSize = 2
        Me.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnZoomOut.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.btnZoomOut.IconChar = FontAwesome.Sharp.IconChar.SearchMinus
        Me.btnZoomOut.IconColor = System.Drawing.Color.Black
        Me.btnZoomOut.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnZoomOut.IconSize = 24
        Me.btnZoomOut.Location = New System.Drawing.Point(246, 3)
        Me.btnZoomOut.Name = "btnZoomOut"
        Me.btnZoomOut.Size = New System.Drawing.Size(81, 47)
        Me.btnZoomOut.TabIndex = 9
        Me.btnZoomOut.Text = "ZOOM OUT"
        Me.btnZoomOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnZoomOut.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnPrint.FlatAppearance.BorderSize = 2
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrint.IconColor = System.Drawing.Color.Black
        Me.btnPrint.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrint.IconSize = 24
        Me.btnPrint.Location = New System.Drawing.Point(165, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(81, 47)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "QUICK"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnPrintDialog
        '
        Me.btnPrintDialog.BackColor = System.Drawing.Color.White
        Me.btnPrintDialog.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrintDialog.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnPrintDialog.FlatAppearance.BorderSize = 2
        Me.btnPrintDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintDialog.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.btnPrintDialog.IconChar = FontAwesome.Sharp.IconChar.Print
        Me.btnPrintDialog.IconColor = System.Drawing.Color.Black
        Me.btnPrintDialog.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrintDialog.IconSize = 24
        Me.btnPrintDialog.Location = New System.Drawing.Point(84, 3)
        Me.btnPrintDialog.Name = "btnPrintDialog"
        Me.btnPrintDialog.Size = New System.Drawing.Size(81, 47)
        Me.btnPrintDialog.TabIndex = 7
        Me.btnPrintDialog.Text = "PRINT"
        Me.btnPrintDialog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintDialog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrintDialog.UseVisualStyleBackColor = False
        '
        'btnOpenNewWindow
        '
        Me.btnOpenNewWindow.BackColor = System.Drawing.Color.White
        Me.btnOpenNewWindow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnOpenNewWindow.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btnOpenNewWindow.FlatAppearance.BorderSize = 2
        Me.btnOpenNewWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenNewWindow.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.btnOpenNewWindow.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.btnOpenNewWindow.IconColor = System.Drawing.Color.Black
        Me.btnOpenNewWindow.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnOpenNewWindow.IconSize = 24
        Me.btnOpenNewWindow.Location = New System.Drawing.Point(3, 3)
        Me.btnOpenNewWindow.Name = "btnOpenNewWindow"
        Me.btnOpenNewWindow.Size = New System.Drawing.Size(81, 47)
        Me.btnOpenNewWindow.TabIndex = 4
        Me.btnOpenNewWindow.Text = "OPEN"
        Me.btnOpenNewWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOpenNewWindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOpenNewWindow.UseVisualStyleBackColor = False
        '
        'ReportFormBase
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1215, 510)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.DoubleBuffered = True
        Me.Name = "ReportFormBase"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.PreviewPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Protected Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Protected Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Protected Friend WithEvents FilterPanel As Panel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Protected Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Protected Friend WithEvents Panel1 As Panel
    Protected Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Protected Friend WithEvents ReportPanel As Panel
    Protected Friend WithEvents PreviewPanel As Panel
    Friend WithEvents DocumentViewer1 As DevExpress.XtraPrinting.Preview.DocumentViewer
    Friend WithEvents btnZoomIn As FontAwesome.Sharp.IconButton
    Friend WithEvents btnZoomOut As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrint As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrintDialog As FontAwesome.Sharp.IconButton
    Friend WithEvents btnOpenNewWindow As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExportPDF As FontAwesome.Sharp.IconButton
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnExportExcel As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExportWord As FontAwesome.Sharp.IconButton
    Protected Friend WithEvents PtDateFilter1 As PTDateFilter
    Protected Friend WithEvents PtLabel1 As PTLabel
    Protected Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Protected Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Protected Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
End Class
