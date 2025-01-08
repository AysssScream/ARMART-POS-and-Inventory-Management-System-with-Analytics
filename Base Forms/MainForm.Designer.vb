<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ButtonLogout = New FontAwesome.Sharp.IconButton()
        Me.LogoPanel = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.TopPanel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMenu = New FontAwesome.Sharp.IconButton()
        Me.ButtonMinimized = New FontAwesome.Sharp.IconButton()
        Me.ButtonMaximized = New FontAwesome.Sharp.IconButton()
        Me.ButtonClose = New FontAwesome.Sharp.IconButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.AutoScroll = True
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MenuPanel.BackgroundImage = CType(resources.GetObject("MenuPanel.BackgroundImage"), System.Drawing.Image)
        Me.MenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuPanel.Controls.Add(Me.ButtonLogout)
        Me.MenuPanel.Controls.Add(Me.LogoPanel)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MenuPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.MenuPanel.ShadowDepth = 0
        Me.MenuPanel.ShadowShift = 0
        Me.MenuPanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.MenuPanel.Size = New System.Drawing.Size(236, 595)
        Me.MenuPanel.TabIndex = 14
        Me.MenuPanel.Visible = False
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogout.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonLogout.IconColor = System.Drawing.Color.Black
        Me.ButtonLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonLogout.Location = New System.Drawing.Point(0, 572)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(236, 23)
        Me.ButtonLogout.TabIndex = 15
        Me.ButtonLogout.Text = "IconButton2"
        Me.ButtonLogout.UseVisualStyleBackColor = True
        Me.ButtonLogout.Visible = False
        '
        'LogoPanel
        '
        Me.LogoPanel.BackColor = System.Drawing.Color.Transparent
        Me.LogoPanel.BackgroundImage = CType(resources.GetObject("LogoPanel.BackgroundImage"), System.Drawing.Image)
        Me.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoPanel.FillColor = System.Drawing.Color.Transparent
        Me.LogoPanel.ForeColor = System.Drawing.Color.Transparent
        Me.LogoPanel.Location = New System.Drawing.Point(0, 0)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.ShadowColor = System.Drawing.Color.Transparent
        Me.LogoPanel.ShadowDepth = 0
        Me.LogoPanel.ShadowShift = 0
        Me.LogoPanel.Size = New System.Drawing.Size(236, 95)
        Me.LogoPanel.TabIndex = 14
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.Label2)
        Me.TopPanel.Controls.Add(Me.btnMenu)
        Me.TopPanel.Controls.Add(Me.ButtonMinimized)
        Me.TopPanel.Controls.Add(Me.ButtonMaximized)
        Me.TopPanel.Controls.Add(Me.ButtonClose)
        Me.TopPanel.CustomBorderColor = System.Drawing.Color.LightGray
        Me.TopPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(236, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.ShadowDecoration.Parent = Me.TopPanel
        Me.TopPanel.Size = New System.Drawing.Size(1028, 39)
        Me.TopPanel.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(621, 39)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "SALES, PURCHASE AND INVENTORY MANAGEMENT SYSTEM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.ForeColor = System.Drawing.Color.BlanchedAlmond
        Me.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars
        Me.btnMenu.IconColor = System.Drawing.Color.White
        Me.btnMenu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMenu.IconSize = 24
        Me.btnMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 39)
        Me.btnMenu.TabIndex = 7
        Me.btnMenu.UseVisualStyleBackColor = False
        Me.btnMenu.Visible = False
        '
        'ButtonMinimized
        '
        Me.ButtonMinimized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMinimized.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMinimized.FlatAppearance.BorderSize = 0
        Me.ButtonMinimized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimized.ForeColor = System.Drawing.Color.Black
        Me.ButtonMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.ButtonMinimized.IconColor = System.Drawing.Color.White
        Me.ButtonMinimized.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonMinimized.IconSize = 24
        Me.ButtonMinimized.Location = New System.Drawing.Point(945, 7)
        Me.ButtonMinimized.Name = "ButtonMinimized"
        Me.ButtonMinimized.Size = New System.Drawing.Size(24, 24)
        Me.ButtonMinimized.TabIndex = 5
        Me.ButtonMinimized.UseVisualStyleBackColor = False
        '
        'ButtonMaximized
        '
        Me.ButtonMaximized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMaximized.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMaximized.FlatAppearance.BorderSize = 0
        Me.ButtonMaximized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonMaximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMaximized.ForeColor = System.Drawing.Color.White
        Me.ButtonMaximized.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.ButtonMaximized.IconColor = System.Drawing.Color.White
        Me.ButtonMaximized.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonMaximized.IconSize = 24
        Me.ButtonMaximized.Location = New System.Drawing.Point(972, 7)
        Me.ButtonMaximized.Name = "ButtonMaximized"
        Me.ButtonMaximized.Size = New System.Drawing.Size(24, 24)
        Me.ButtonMaximized.TabIndex = 4
        Me.ButtonMaximized.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.BackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.ForeColor = System.Drawing.Color.Black
        Me.ButtonClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.ButtonClose.IconColor = System.Drawing.Color.White
        Me.ButtonClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonClose.IconSize = 24
        Me.ButtonClose.Location = New System.Drawing.Point(999, 7)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(24, 24)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabControl1.Appearance.BackColor2 = System.Drawing.SystemColors.Control
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.PageClient.BackColor = System.Drawing.SystemColors.Control
        Me.XtraTabControl1.AppearancePage.PageClient.Options.UseBackColor = True
        Me.XtraTabControl1.BackgroundImage = CType(resources.GetObject("XtraTabControl1.BackgroundImage"), System.Drawing.Image)
        Me.XtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.None
        Me.XtraTabControl1.Location = New System.Drawing.Point(236, 39)
        Me.XtraTabControl1.LookAndFeel.SkinName = "The Bezier"
        Me.XtraTabControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.Size = New System.Drawing.Size(1028, 556)
        Me.XtraTabControl1.TabIndex = 17
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.LineColor = System.Drawing.Color.Black
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.Location = New System.Drawing.Point(682, 485)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(200, 200)
        Me.GunaLinePanel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1064, 558)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 595)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents TopPanel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ButtonMinimized As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMaximized As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonClose As FontAwesome.Sharp.IconButton
    Friend WithEvents LogoPanel As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btnMenu As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents ButtonLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
