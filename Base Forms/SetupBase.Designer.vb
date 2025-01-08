<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupBase
    Inherits NewTemplate.CRUDBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.EditorButtonPanel = New System.Windows.Forms.Panel()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVoid = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPreview = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddNew = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        CType(Me.RecordInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordInfo.SuspendLayout()
        CType(Me.SplitRecordInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitRecordInfo.SuspendLayout()
        CType(Me.txtPK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModuleType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.EditorButtonPanel.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitRecordInfo
        '
        Me.SplitRecordInfo.Panel1.Controls.Add(Me.SplitContainerControl1)
        Me.SplitRecordInfo.Panel1.Controls.Add(Me.Guna2GradientPanel1)
        '
        'txtPK
        '
        Me.txtPK.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPK.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtPK.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtPK.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.txtPK.Properties.Appearance.Options.UseBackColor = True
        Me.txtPK.Properties.Appearance.Options.UseBorderColor = True
        Me.txtPK.Properties.Appearance.Options.UseFont = True
        Me.txtPK.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPK.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtPK.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtPK.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.txtPK.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtPK.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txtPK.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtPK.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txtPK.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtPK.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPK.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtPK.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtPK.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtPK.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtPK.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtPK.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtPK.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtPK.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.txtPK.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtPK.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txtPK.Properties.AppearanceReadOnly.Options.UseForeColor = True
        '
        'txtUser
        '
        Me.txtUser.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUser.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtUser.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtUser.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.txtUser.Properties.Appearance.Options.UseBackColor = True
        Me.txtUser.Properties.Appearance.Options.UseBorderColor = True
        Me.txtUser.Properties.Appearance.Options.UseFont = True
        Me.txtUser.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUser.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtUser.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtUser.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.txtUser.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtUser.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txtUser.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtUser.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txtUser.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtUser.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtUser.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtUser.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtUser.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtUser.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtUser.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtUser.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtUser.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.txtUser.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtUser.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txtUser.Properties.AppearanceReadOnly.Options.UseForeColor = True
        '
        'txtBranch
        '
        Me.txtBranch.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtBranch.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtBranch.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtBranch.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.txtBranch.Properties.Appearance.Options.UseBackColor = True
        Me.txtBranch.Properties.Appearance.Options.UseBorderColor = True
        Me.txtBranch.Properties.Appearance.Options.UseFont = True
        Me.txtBranch.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBranch.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtBranch.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtBranch.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.txtBranch.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtBranch.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txtBranch.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtBranch.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txtBranch.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtBranch.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBranch.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtBranch.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtBranch.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtBranch.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtBranch.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtBranch.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtBranch.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtBranch.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.txtBranch.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtBranch.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txtBranch.Properties.AppearanceReadOnly.Options.UseForeColor = True
        '
        'txtModuleType
        '
        Me.txtModuleType.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtModuleType.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtModuleType.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtModuleType.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.txtModuleType.Properties.Appearance.Options.UseBackColor = True
        Me.txtModuleType.Properties.Appearance.Options.UseBorderColor = True
        Me.txtModuleType.Properties.Appearance.Options.UseFont = True
        Me.txtModuleType.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtModuleType.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtModuleType.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtModuleType.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.txtModuleType.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtModuleType.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txtModuleType.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtModuleType.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txtModuleType.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtModuleType.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModuleType.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtModuleType.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtModuleType.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtModuleType.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtModuleType.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtModuleType.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtModuleType.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtModuleType.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.txtModuleType.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtModuleType.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txtModuleType.Properties.AppearanceReadOnly.Options.UseForeColor = True
        '
        'txtModule
        '
        Me.txtModule.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtModule.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.txtModule.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtModule.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.txtModule.Properties.Appearance.Options.UseBackColor = True
        Me.txtModule.Properties.Appearance.Options.UseBorderColor = True
        Me.txtModule.Properties.Appearance.Options.UseFont = True
        Me.txtModule.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtModule.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.txtModule.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.txtModule.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.txtModule.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtModule.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.txtModule.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtModule.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.txtModule.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.txtModule.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtModule.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txtModule.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtModule.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtModule.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtModule.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtModule.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtModule.Properties.AppearanceReadOnly.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.txtModule.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.txtModule.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txtModule.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.txtModule.Properties.AppearanceReadOnly.Options.UseForeColor = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.EditorButtonPanel)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblHeaderTitle)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.LightGray
        Me.Guna2GradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(833, 68)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'EditorButtonPanel
        '
        Me.EditorButtonPanel.Controls.Add(Me.btnDelete)
        Me.EditorButtonPanel.Controls.Add(Me.btnVoid)
        Me.EditorButtonPanel.Controls.Add(Me.btnCancel)
        Me.EditorButtonPanel.Controls.Add(Me.btnPrint)
        Me.EditorButtonPanel.Controls.Add(Me.btnPreview)
        Me.EditorButtonPanel.Controls.Add(Me.btnSearch)
        Me.EditorButtonPanel.Controls.Add(Me.btnSave)
        Me.EditorButtonPanel.Controls.Add(Me.btnEdit)
        Me.EditorButtonPanel.Controls.Add(Me.btnAddNew)
        Me.EditorButtonPanel.Location = New System.Drawing.Point(4, 33)
        Me.EditorButtonPanel.Name = "EditorButtonPanel"
        Me.EditorButtonPanel.Size = New System.Drawing.Size(665, 30)
        Me.EditorButtonPanel.TabIndex = 7
        '
        'btnDelete
        '
        Me.btnDelete.BorderColor = System.Drawing.Color.Transparent
        Me.btnDelete.BorderRadius = 13
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDelete.Location = New System.Drawing.Point(576, 0)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Padding = New System.Windows.Forms.Padding(3)
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.Size = New System.Drawing.Size(72, 30)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "DELETE"
        '
        'btnVoid
        '
        Me.btnVoid.BorderColor = System.Drawing.Color.Transparent
        Me.btnVoid.BorderRadius = 13
        Me.btnVoid.CheckedState.Parent = Me.btnVoid
        Me.btnVoid.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnVoid.CustomImages.Parent = Me.btnVoid
        Me.btnVoid.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVoid.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnVoid.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnVoid.ForeColor = System.Drawing.Color.White
        Me.btnVoid.HoverState.Parent = Me.btnVoid
        Me.btnVoid.Location = New System.Drawing.Point(504, 0)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Padding = New System.Windows.Forms.Padding(3)
        Me.btnVoid.ShadowDecoration.Parent = Me.btnVoid
        Me.btnVoid.Size = New System.Drawing.Size(72, 30)
        Me.btnVoid.TabIndex = 12
        Me.btnVoid.Text = "VOID"
        '
        'btnCancel
        '
        Me.btnCancel.BorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.BorderRadius = 13
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(432, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(3)
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.Size = New System.Drawing.Size(72, 30)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "CANCEL"
        '
        'btnPrint
        '
        Me.btnPrint.BorderColor = System.Drawing.Color.Transparent
        Me.btnPrint.BorderRadius = 13
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.Location = New System.Drawing.Point(360, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Padding = New System.Windows.Forms.Padding(3)
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(72, 30)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "PRINT"
        '
        'btnPreview
        '
        Me.btnPreview.BorderColor = System.Drawing.Color.Transparent
        Me.btnPreview.BorderRadius = 13
        Me.btnPreview.CheckedState.Parent = Me.btnPreview
        Me.btnPreview.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnPreview.CustomImages.Parent = Me.btnPreview
        Me.btnPreview.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPreview.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPreview.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.HoverState.Parent = Me.btnPreview
        Me.btnPreview.Location = New System.Drawing.Point(288, 0)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Padding = New System.Windows.Forms.Padding(3)
        Me.btnPreview.ShadowDecoration.Parent = Me.btnPreview
        Me.btnPreview.Size = New System.Drawing.Size(72, 30)
        Me.btnPreview.TabIndex = 9
        Me.btnPreview.Text = "PREVIEW"
        '
        'btnSearch
        '
        Me.btnSearch.BorderColor = System.Drawing.Color.Transparent
        Me.btnSearch.BorderRadius = 13
        Me.btnSearch.CheckedState.Parent = Me.btnSearch
        Me.btnSearch.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnSearch.CustomImages.Parent = Me.btnSearch
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.Parent = Me.btnSearch
        Me.btnSearch.Location = New System.Drawing.Point(216, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(72, 30)
        Me.btnSearch.TabIndex = 8
        Me.btnSearch.Text = "SEARCH"
        '
        'btnSave
        '
        Me.btnSave.BorderColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 13
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.Location = New System.Drawing.Point(144, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Padding = New System.Windows.Forms.Padding(3)
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.Size = New System.Drawing.Size(72, 30)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "SAVE"
        '
        'btnEdit
        '
        Me.btnEdit.BorderColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderRadius = 13
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.Location = New System.Drawing.Point(72, 0)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(3)
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.Size = New System.Drawing.Size(72, 30)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "EDIT"
        '
        'btnAddNew
        '
        Me.btnAddNew.BorderColor = System.Drawing.Color.Transparent
        Me.btnAddNew.BorderRadius = 13
        Me.btnAddNew.CheckedState.Parent = Me.btnAddNew
        Me.btnAddNew.CustomBorderColor = System.Drawing.Color.Transparent
        Me.btnAddNew.CustomImages.Parent = Me.btnAddNew
        Me.btnAddNew.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAddNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAddNew.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.HoverState.Parent = Me.btnAddNew
        Me.btnAddNew.Location = New System.Drawing.Point(0, 0)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAddNew.ShadowDecoration.Parent = Me.btnAddNew
        Me.btnAddNew.Size = New System.Drawing.Size(72, 30)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "NEW"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(833, 30)
        Me.lblHeaderTitle.TabIndex = 5
        Me.lblHeaderTitle.Text = "SETUP"
        Me.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 68)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(833, 468)
        Me.SplitContainerControl1.SplitterPosition = 220
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'SetupBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1148, 536)
        Me.Name = "SetupBase"
        CType(Me.RecordInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordInfo.ResumeLayout(False)
        CType(Me.SplitRecordInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitRecordInfo.ResumeLayout(False)
        CType(Me.txtPK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModuleType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.EditorButtonPanel.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents lblHeaderTitle As Label
    Protected Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Protected Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Protected Friend WithEvents EditorButtonPanel As Panel
    Protected Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnVoid As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnPreview As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Protected Friend WithEvents btnAddNew As Guna.UI2.WinForms.Guna2Button
End Class
