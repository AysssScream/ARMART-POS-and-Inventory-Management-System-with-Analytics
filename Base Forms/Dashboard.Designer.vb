<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
    Inherits NewTemplate.BaseForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaPictureBox5 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDailyItemsSold = New System.Windows.Forms.Label()
        Me.Column4 = New System.Windows.Forms.Panel()
        Me.GunaPictureBox4 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCritical = New System.Windows.Forms.Label()
        Me.Column3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaPictureBox3 = New Guna.UI.WinForms.GunaPictureBox()
        Me.lblOnhand = New System.Windows.Forms.Label()
        Me.Column2 = New System.Windows.Forms.Panel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.Panel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.PieChartPanel = New System.Windows.Forms.Panel()
        Me.TopSellingPanel = New System.Windows.Forms.Panel()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.CriticalPanel = New System.Windows.Forms.Panel()
        Me.XtraTabControl3 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.ItemsSoldChartPanel = New System.Windows.Forms.Panel()
        Me.BarChartPanel = New System.Windows.Forms.Panel()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Column4.SuspendLayout()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Column3.SuspendLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Column2.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Column1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl3.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
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
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1731, 34)
        Me.Guna2GradientPanel1.TabIndex = 3
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHeaderTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(1731, 34)
        Me.lblHeaderTitle.TabIndex = 5
        Me.lblHeaderTitle.Text = "DASHBOARD"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 319.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Column4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Column3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Column2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Column1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 34)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1731, 125)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaPictureBox5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblDailyItemsSold)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(1417, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 115)
        Me.Panel1.TabIndex = 5
        '
        'GunaPictureBox5
        '
        Me.GunaPictureBox5.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox5.Image = CType(resources.GetObject("GunaPictureBox5.Image"), System.Drawing.Image)
        Me.GunaPictureBox5.Location = New System.Drawing.Point(3, 18)
        Me.GunaPictureBox5.Name = "GunaPictureBox5"
        Me.GunaPictureBox5.Size = New System.Drawing.Size(78, 77)
        Me.GunaPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox5.TabIndex = 6
        Me.GunaPictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Daily Items Sold"
        '
        'lblDailyItemsSold
        '
        Me.lblDailyItemsSold.AutoSize = True
        Me.lblDailyItemsSold.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblDailyItemsSold.ForeColor = System.Drawing.Color.White
        Me.lblDailyItemsSold.Location = New System.Drawing.Point(87, 30)
        Me.lblDailyItemsSold.Name = "lblDailyItemsSold"
        Me.lblDailyItemsSold.Size = New System.Drawing.Size(55, 30)
        Me.lblDailyItemsSold.TabIndex = 3
        Me.lblDailyItemsSold.Text = "0.00"
        '
        'Column4
        '
        Me.Column4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Column4.Controls.Add(Me.GunaPictureBox4)
        Me.Column4.Controls.Add(Me.Label7)
        Me.Column4.Controls.Add(Me.lblCritical)
        Me.Column4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Column4.Location = New System.Drawing.Point(1064, 5)
        Me.Column4.Margin = New System.Windows.Forms.Padding(5)
        Me.Column4.Name = "Column4"
        Me.Column4.Size = New System.Drawing.Size(343, 115)
        Me.Column4.TabIndex = 4
        '
        'GunaPictureBox4
        '
        Me.GunaPictureBox4.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox4.Image = CType(resources.GetObject("GunaPictureBox4.Image"), System.Drawing.Image)
        Me.GunaPictureBox4.Location = New System.Drawing.Point(3, 18)
        Me.GunaPictureBox4.Name = "GunaPictureBox4"
        Me.GunaPictureBox4.Size = New System.Drawing.Size(78, 77)
        Me.GunaPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox4.TabIndex = 6
        Me.GunaPictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(83, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 30)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Critical Items"
        '
        'lblCritical
        '
        Me.lblCritical.AutoSize = True
        Me.lblCritical.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblCritical.ForeColor = System.Drawing.Color.White
        Me.lblCritical.Location = New System.Drawing.Point(85, 30)
        Me.lblCritical.Name = "lblCritical"
        Me.lblCritical.Size = New System.Drawing.Size(55, 30)
        Me.lblCritical.TabIndex = 3
        Me.lblCritical.Text = "0.00"
        '
        'Column3
        '
        Me.Column3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Column3.Controls.Add(Me.Label4)
        Me.Column3.Controls.Add(Me.GunaPictureBox3)
        Me.Column3.Controls.Add(Me.lblOnhand)
        Me.Column3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Column3.Location = New System.Drawing.Point(711, 5)
        Me.Column3.Margin = New System.Windows.Forms.Padding(5)
        Me.Column3.Name = "Column3"
        Me.Column3.Size = New System.Drawing.Size(343, 115)
        Me.Column3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(86, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total On Hand (Stock)"
        '
        'GunaPictureBox3
        '
        Me.GunaPictureBox3.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox3.Image = CType(resources.GetObject("GunaPictureBox3.Image"), System.Drawing.Image)
        Me.GunaPictureBox3.Location = New System.Drawing.Point(3, 18)
        Me.GunaPictureBox3.Name = "GunaPictureBox3"
        Me.GunaPictureBox3.Size = New System.Drawing.Size(78, 77)
        Me.GunaPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox3.TabIndex = 5
        Me.GunaPictureBox3.TabStop = False
        '
        'lblOnhand
        '
        Me.lblOnhand.AutoSize = True
        Me.lblOnhand.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblOnhand.ForeColor = System.Drawing.Color.White
        Me.lblOnhand.Location = New System.Drawing.Point(85, 30)
        Me.lblOnhand.Name = "lblOnhand"
        Me.lblOnhand.Size = New System.Drawing.Size(55, 30)
        Me.lblOnhand.TabIndex = 3
        Me.lblOnhand.Text = "0.00"
        '
        'Column2
        '
        Me.Column2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Column2.Controls.Add(Me.GunaPictureBox2)
        Me.Column2.Controls.Add(Me.Label3)
        Me.Column2.Controls.Add(Me.lblSales)
        Me.Column2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Column2.Location = New System.Drawing.Point(358, 5)
        Me.Column2.Margin = New System.Windows.Forms.Padding(5)
        Me.Column2.Name = "Column2"
        Me.Column2.Size = New System.Drawing.Size(343, 115)
        Me.Column2.TabIndex = 2
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(3, 18)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(78, 77)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 4
        Me.GunaPictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(85, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 30)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Daily Sales"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblSales.ForeColor = System.Drawing.Color.White
        Me.lblSales.Location = New System.Drawing.Point(85, 27)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(55, 30)
        Me.lblSales.TabIndex = 2
        Me.lblSales.Text = "0.00"
        '
        'Column1
        '
        Me.Column1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Column1.Controls.Add(Me.GunaPictureBox1)
        Me.Column1.Controls.Add(Me.Label2)
        Me.Column1.Controls.Add(Me.lblInventory)
        Me.Column1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Column1.Location = New System.Drawing.Point(5, 5)
        Me.Column1.Margin = New System.Windows.Forms.Padding(5)
        Me.Column1.Name = "Column1"
        Me.Column1.Size = New System.Drawing.Size(343, 115)
        Me.Column1.TabIndex = 1
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(30, 18)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(78, 77)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 7
        Me.GunaPictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(103, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Line"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblInventory.ForeColor = System.Drawing.Color.White
        Me.lblInventory.Location = New System.Drawing.Point(103, 27)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(55, 30)
        Me.lblInventory.TabIndex = 1
        Me.lblInventory.Text = "0.00"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 159)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(451, 817)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage1.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage1.Appearance.Header.Options.UseTextOptions = True
        Me.XtraTabPage1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabPage1.Controls.Add(Me.PieChartPanel)
        Me.XtraTabPage1.Controls.Add(Me.TopSellingPanel)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(445, 789)
        Me.XtraTabPage1.Text = "TOP SELLING PRODUCTS"
        '
        'PieChartPanel
        '
        Me.PieChartPanel.AutoScroll = True
        Me.PieChartPanel.BackColor = System.Drawing.SystemColors.Control
        Me.PieChartPanel.Location = New System.Drawing.Point(0, 374)
        Me.PieChartPanel.Name = "PieChartPanel"
        Me.PieChartPanel.Size = New System.Drawing.Size(438, 412)
        Me.PieChartPanel.TabIndex = 1
        '
        'TopSellingPanel
        '
        Me.TopSellingPanel.AutoScroll = True
        Me.TopSellingPanel.BackColor = System.Drawing.SystemColors.Control
        Me.TopSellingPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopSellingPanel.Name = "TopSellingPanel"
        Me.TopSellingPanel.Size = New System.Drawing.Size(438, 368)
        Me.TopSellingPanel.TabIndex = 0
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.XtraTabControl2.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl2.Location = New System.Drawing.Point(451, 159)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl2.Size = New System.Drawing.Size(487, 817)
        Me.XtraTabControl2.TabIndex = 6
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage2.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage2.Appearance.Header.Options.UseTextOptions = True
        Me.XtraTabPage2.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabPage2.Controls.Add(Me.CriticalPanel)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(481, 789)
        Me.XtraTabPage2.Text = "CRITICAL PRODUCTS"
        '
        'CriticalPanel
        '
        Me.CriticalPanel.AutoScroll = True
        Me.CriticalPanel.BackColor = System.Drawing.SystemColors.Control
        Me.CriticalPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CriticalPanel.Location = New System.Drawing.Point(0, 0)
        Me.CriticalPanel.Name = "CriticalPanel"
        Me.CriticalPanel.Size = New System.Drawing.Size(481, 789)
        Me.CriticalPanel.TabIndex = 0
        '
        'XtraTabControl3
        '
        Me.XtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl3.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl3.Location = New System.Drawing.Point(938, 159)
        Me.XtraTabControl3.Name = "XtraTabControl3"
        Me.XtraTabControl3.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl3.Size = New System.Drawing.Size(793, 817)
        Me.XtraTabControl3.TabIndex = 7
        Me.XtraTabControl3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Appearance.Header.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XtraTabPage3.Appearance.Header.Options.UseFont = True
        Me.XtraTabPage3.Appearance.Header.Options.UseTextOptions = True
        Me.XtraTabPage3.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.XtraTabPage3.Controls.Add(Me.ItemsSoldChartPanel)
        Me.XtraTabPage3.Controls.Add(Me.BarChartPanel)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(787, 789)
        Me.XtraTabPage3.Text = "SALES"
        '
        'ItemsSoldChartPanel
        '
        Me.ItemsSoldChartPanel.AutoScroll = True
        Me.ItemsSoldChartPanel.AutoSize = True
        Me.ItemsSoldChartPanel.BackColor = System.Drawing.SystemColors.Control
        Me.ItemsSoldChartPanel.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemsSoldChartPanel.Location = New System.Drawing.Point(5, 358)
        Me.ItemsSoldChartPanel.Name = "ItemsSoldChartPanel"
        Me.ItemsSoldChartPanel.Size = New System.Drawing.Size(775, 417)
        Me.ItemsSoldChartPanel.TabIndex = 1
        '
        'BarChartPanel
        '
        Me.BarChartPanel.AutoScroll = True
        Me.BarChartPanel.AutoSize = True
        Me.BarChartPanel.BackColor = System.Drawing.SystemColors.Control
        Me.BarChartPanel.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarChartPanel.Location = New System.Drawing.Point(5, 3)
        Me.BarChartPanel.Name = "BarChartPanel"
        Me.BarChartPanel.Size = New System.Drawing.Size(775, 349)
        Me.BarChartPanel.TabIndex = 0
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1731, 976)
        Me.Controls.Add(Me.XtraTabControl3)
        Me.Controls.Add(Me.XtraTabControl2)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "Dashboard"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Column4.ResumeLayout(False)
        Me.Column4.PerformLayout()
        CType(Me.GunaPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Column3.ResumeLayout(False)
        Me.Column3.PerformLayout()
        CType(Me.GunaPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Column2.ResumeLayout(False)
        Me.Column2.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Column1.ResumeLayout(False)
        Me.Column1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.XtraTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl3.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Protected Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Column4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCritical As Label
    Friend WithEvents Column3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOnhand As Label
    Friend WithEvents Column2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents Column1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabControl3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BarChartPanel As Panel
    Friend WithEvents TopSellingPanel As Panel
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CriticalPanel As Panel
    Friend WithEvents GunaPictureBox4 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox3 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaPictureBox5 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDailyItemsSold As Label
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents ItemsSoldChartPanel As Panel
    Friend WithEvents PieChartPanel As Panel
End Class
