<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalSales = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtChange = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtTender = New NewTemplate.PTTextInput()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button200 = New FontAwesome.Sharp.IconButton()
        Me.Button100 = New FontAwesome.Sharp.IconButton()
        Me.ButtonDot = New FontAwesome.Sharp.IconButton()
        Me.Button3 = New FontAwesome.Sharp.IconButton()
        Me.Button2 = New FontAwesome.Sharp.IconButton()
        Me.Button1 = New FontAwesome.Sharp.IconButton()
        Me.ButtonClr = New FontAwesome.Sharp.IconButton()
        Me.Button500 = New FontAwesome.Sharp.IconButton()
        Me.Button0 = New FontAwesome.Sharp.IconButton()
        Me.Button6 = New FontAwesome.Sharp.IconButton()
        Me.Button5 = New FontAwesome.Sharp.IconButton()
        Me.Button4 = New FontAwesome.Sharp.IconButton()
        Me.ButtonDel = New FontAwesome.Sharp.IconButton()
        Me.Button1000 = New FontAwesome.Sharp.IconButton()
        Me.Button00 = New FontAwesome.Sharp.IconButton()
        Me.Button9 = New FontAwesome.Sharp.IconButton()
        Me.Button8 = New FontAwesome.Sharp.IconButton()
        Me.Button7 = New FontAwesome.Sharp.IconButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.txtTender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.NewTemplate.My.Resources.Resources.logo_system
        Me.Panel1.Controls.Add(Me.lblHeaderTitle)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 39)
        Me.Panel1.TabIndex = 1
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(6, 9)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(82, 18)
        Me.lblHeaderTitle.TabIndex = 5
        Me.lblHeaderTitle.Text = "Payment"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(488, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(28, 39)
        Me.Panel4.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnClose.IconColor = System.Drawing.Color.White
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 24
        Me.btnClose.Location = New System.Drawing.Point(0, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 39)
        Me.btnClose.TabIndex = 1
        Me.btnClose.TabStop = False
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(10)
        Me.Panel2.Size = New System.Drawing.Size(516, 375)
        Me.Panel2.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 74)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(496, 62)
        Me.TableLayoutPanel3.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtTotalSales)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 56)
        Me.Panel3.TabIndex = 0
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotalSales.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotalSales.Location = New System.Drawing.Point(0, 18)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.Size = New System.Drawing.Size(240, 36)
        Me.txtTotalSales.TabIndex = 1
        Me.txtTotalSales.Text = "0.00"
        Me.txtTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TOTAL SALES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtChange)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(251, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(242, 56)
        Me.Panel5.TabIndex = 1
        '
        'txtChange
        '
        Me.txtChange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChange.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txtChange.Location = New System.Drawing.Point(0, 18)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(240, 36)
        Me.txtChange.TabIndex = 2
        Me.txtChange.Text = "0.00"
        Me.txtChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CHANGE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtTender)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(10, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Panel6.Size = New System.Drawing.Size(496, 64)
        Me.Panel6.TabIndex = 6
        '
        'txtTender
        '
        Me.txtTender.DisplayFormat = ""
        Me.txtTender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTender.EditValue = "0"
        Me.txtTender.Location = New System.Drawing.Point(3, 0)
        Me.txtTender.Name = "txtTender"
        Me.txtTender.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTender.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtTender.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtTender.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 36.0!)
        Me.txtTender.Properties.Appearance.Options.UseBackColor = True
        Me.txtTender.Properties.Appearance.Options.UseBorderColor = True
        Me.txtTender.Properties.Appearance.Options.UseFont = True
        Me.txtTender.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTender.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtTender.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtTender.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.txtTender.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtTender.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txtTender.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTender.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txtTender.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtTender.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTender.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtTender.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtTender.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTender.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtTender.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTender.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtTender.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtTender.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.txtTender.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtTender.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txtTender.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.txtTender.Properties.AutoHeight = False
        Me.txtTender.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTender.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTender.Size = New System.Drawing.Size(490, 64)
        Me.txtTender.TabIndex = 5
        Me.txtTender.TableField = ""
        Me.txtTender.TableName = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button200, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Button100, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonDot, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Button3, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonClr, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button500, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button0, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button6, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonDel, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1000, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button00, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button9, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button8, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button7, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(10, 136)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(496, 184)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'Button200
        '
        Me.Button200.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button200.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button200.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button200.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button200.ForeColor = System.Drawing.Color.Black
        Me.Button200.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button200.IconColor = System.Drawing.Color.Black
        Me.Button200.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button200.Location = New System.Drawing.Point(398, 125)
        Me.Button200.Name = "Button200"
        Me.Button200.Size = New System.Drawing.Size(95, 56)
        Me.Button200.TabIndex = 21
        Me.Button200.Text = "200"
        Me.Button200.UseVisualStyleBackColor = False
        '
        'Button100
        '
        Me.Button100.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button100.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button100.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button100.ForeColor = System.Drawing.Color.Black
        Me.Button100.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button100.IconColor = System.Drawing.Color.Black
        Me.Button100.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button100.Location = New System.Drawing.Point(299, 125)
        Me.Button100.Name = "Button100"
        Me.Button100.Size = New System.Drawing.Size(93, 56)
        Me.Button100.TabIndex = 20
        Me.Button100.Text = "100"
        Me.Button100.UseVisualStyleBackColor = False
        '
        'ButtonDot
        '
        Me.ButtonDot.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDot.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonDot.ForeColor = System.Drawing.Color.Black
        Me.ButtonDot.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonDot.IconColor = System.Drawing.Color.Black
        Me.ButtonDot.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonDot.Location = New System.Drawing.Point(225, 125)
        Me.ButtonDot.Name = "ButtonDot"
        Me.ButtonDot.Size = New System.Drawing.Size(68, 56)
        Me.ButtonDot.TabIndex = 19
        Me.ButtonDot.Text = "."
        Me.ButtonDot.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button3.IconColor = System.Drawing.Color.Black
        Me.Button3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button3.Location = New System.Drawing.Point(151, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 56)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button2.IconColor = System.Drawing.Color.Black
        Me.Button2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button2.Location = New System.Drawing.Point(77, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 56)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button1.IconColor = System.Drawing.Color.Black
        Me.Button1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button1.Location = New System.Drawing.Point(3, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 56)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ButtonClr
        '
        Me.ButtonClr.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonClr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClr.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonClr.ForeColor = System.Drawing.Color.Black
        Me.ButtonClr.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonClr.IconColor = System.Drawing.Color.Black
        Me.ButtonClr.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonClr.Location = New System.Drawing.Point(398, 64)
        Me.ButtonClr.Name = "ButtonClr"
        Me.ButtonClr.Size = New System.Drawing.Size(95, 55)
        Me.ButtonClr.TabIndex = 15
        Me.ButtonClr.Text = "Clr"
        Me.ButtonClr.UseVisualStyleBackColor = False
        '
        'Button500
        '
        Me.Button500.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button500.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button500.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button500.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button500.ForeColor = System.Drawing.Color.Black
        Me.Button500.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button500.IconColor = System.Drawing.Color.Black
        Me.Button500.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button500.Location = New System.Drawing.Point(299, 64)
        Me.Button500.Name = "Button500"
        Me.Button500.Size = New System.Drawing.Size(93, 55)
        Me.Button500.TabIndex = 14
        Me.Button500.Text = "500"
        Me.Button500.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button0.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button0.ForeColor = System.Drawing.Color.Black
        Me.Button0.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button0.IconColor = System.Drawing.Color.Black
        Me.Button0.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button0.Location = New System.Drawing.Point(225, 64)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(68, 55)
        Me.Button0.TabIndex = 13
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button6.IconColor = System.Drawing.Color.Black
        Me.Button6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button6.Location = New System.Drawing.Point(151, 64)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(68, 55)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button5.IconColor = System.Drawing.Color.Black
        Me.Button5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button5.Location = New System.Drawing.Point(77, 64)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(68, 55)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button4.IconColor = System.Drawing.Color.Black
        Me.Button4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button4.Location = New System.Drawing.Point(3, 64)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 55)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ButtonDel
        '
        Me.ButtonDel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonDel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDel.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonDel.ForeColor = System.Drawing.Color.Black
        Me.ButtonDel.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonDel.IconColor = System.Drawing.Color.Black
        Me.ButtonDel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonDel.Location = New System.Drawing.Point(398, 3)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(95, 55)
        Me.ButtonDel.TabIndex = 9
        Me.ButtonDel.Text = "Del"
        Me.ButtonDel.UseVisualStyleBackColor = False
        '
        'Button1000
        '
        Me.Button1000.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1000.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1000.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button1000.ForeColor = System.Drawing.Color.Black
        Me.Button1000.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button1000.IconColor = System.Drawing.Color.Black
        Me.Button1000.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button1000.Location = New System.Drawing.Point(299, 3)
        Me.Button1000.Name = "Button1000"
        Me.Button1000.Size = New System.Drawing.Size(93, 55)
        Me.Button1000.TabIndex = 8
        Me.Button1000.Text = "1000"
        Me.Button1000.UseVisualStyleBackColor = False
        '
        'Button00
        '
        Me.Button00.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button00.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button00.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button00.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button00.ForeColor = System.Drawing.Color.Black
        Me.Button00.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button00.IconColor = System.Drawing.Color.Black
        Me.Button00.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button00.Location = New System.Drawing.Point(225, 3)
        Me.Button00.Name = "Button00"
        Me.Button00.Size = New System.Drawing.Size(68, 55)
        Me.Button00.TabIndex = 7
        Me.Button00.Text = "00"
        Me.Button00.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button9.IconColor = System.Drawing.Color.Black
        Me.Button9.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button9.Location = New System.Drawing.Point(151, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(68, 55)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button8.IconColor = System.Drawing.Color.Black
        Me.Button8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button8.Location = New System.Drawing.Point(77, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(68, 55)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Button7.IconColor = System.Drawing.Color.Black
        Me.Button7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Button7.Location = New System.Drawing.Point(3, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(68, 55)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.IconButton2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.IconButton1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 320)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(496, 45)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.Location = New System.Drawing.Point(251, 3)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(242, 39)
        Me.IconButton2.TabIndex = 3
        Me.IconButton2.Text = "PAY"
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold)
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.Location = New System.Drawing.Point(3, 3)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(242, 39)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "CANCEL"
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(516, 414)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtTender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Protected Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnClose As FontAwesome.Sharp.IconButton
    Protected Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button200 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button100 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonDot As FontAwesome.Sharp.IconButton
    Friend WithEvents Button3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonClr As FontAwesome.Sharp.IconButton
    Friend WithEvents Button500 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button0 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button6 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button5 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button4 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonDel As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1000 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button00 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button9 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button8 As FontAwesome.Sharp.IconButton
    Friend WithEvents Button7 As FontAwesome.Sharp.IconButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTotalSales As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtChange As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtTender As PTTextInput
End Class
