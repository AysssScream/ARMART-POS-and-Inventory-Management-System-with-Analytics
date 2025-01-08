<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Supplier
    Inherits NewTemplate.SetupBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier))
        Me.PtTextInputGroup1 = New NewTemplate.PTTextInputGroup()
        Me.PtMemoInputGroup1 = New NewTemplate.PTMemoInputGroup()
        Me.PtTextInputGroup2 = New NewTemplate.PTTextInputGroup()
        Me.PtTextInputGroup4 = New NewTemplate.PTTextInputGroup()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PtTextInputGroup3 = New NewTemplate.PTTextInputGroup()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.EditorButtonPanel.SuspendLayout()
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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Size = New System.Drawing.Size(1609, 30)
        Me.lblHeaderTitle.Text = "SUPPLIER"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Appearance.Image = CType(resources.GetObject("SplitContainerControl1.Appearance.Image"), System.Drawing.Image)
        Me.SplitContainerControl1.Appearance.Options.UseImage = True
        Me.SplitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.SplitContainerControl1.Panel1.Appearance.Image = CType(resources.GetObject("SplitContainerControl1.Panel1.Appearance.Image"), System.Drawing.Image)
        Me.SplitContainerControl1.Panel1.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl1.Panel1.Appearance.Options.UseImage = True
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1609, 464)
        Me.SplitContainerControl1.SplitterPosition = 463
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1609, 68)
        '
        'btnDelete
        '
        Me.btnDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnDelete.CheckedState.Parent = Me.btnDelete
        Me.btnDelete.CustomImages.Parent = Me.btnDelete
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDelete.HoverState.Parent = Me.btnDelete
        Me.btnDelete.ShadowDecoration.Parent = Me.btnDelete
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnDelete.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnVoid
        '
        Me.btnVoid.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnVoid.CheckedState.Parent = Me.btnVoid
        Me.btnVoid.CustomImages.Parent = Me.btnVoid
        Me.btnVoid.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnVoid.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnVoid.HoverState.Parent = Me.btnVoid
        Me.btnVoid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnVoid.ShadowDecoration.Parent = Me.btnVoid
        Me.btnVoid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnVoid.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnVoid.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnCancel
        '
        Me.btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnCancel.CheckedState.Parent = Me.btnCancel
        Me.btnCancel.CustomImages.Parent = Me.btnCancel
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCancel.HoverState.Parent = Me.btnCancel
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnCancel.ShadowDecoration.Parent = Me.btnCancel
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnCancel.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnPrint
        '
        Me.btnPrint.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPrint.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnPrint.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnPreview
        '
        Me.btnPreview.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnPreview.CheckedState.Parent = Me.btnPreview
        Me.btnPreview.CustomImages.Parent = Me.btnPreview
        Me.btnPreview.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPreview.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnPreview.HoverState.Parent = Me.btnPreview
        Me.btnPreview.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPreview.ShadowDecoration.Parent = Me.btnPreview
        Me.btnPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnPreview.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnPreview.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnSearch
        '
        Me.btnSearch.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnSearch.CheckedState.Parent = Me.btnSearch
        Me.btnSearch.CustomImages.Parent = Me.btnSearch
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSearch.HoverState.Parent = Me.btnSearch
        Me.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnSearch.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnSave
        '
        Me.btnSave.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnSave.CheckedState.Parent = Me.btnSave
        Me.btnSave.CustomImages.Parent = Me.btnSave
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSave.HoverState.Parent = Me.btnSave
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSave.ShadowDecoration.Parent = Me.btnSave
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnSave.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnEdit
        '
        Me.btnEdit.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnEdit.CheckedState.Parent = Me.btnEdit
        Me.btnEdit.CustomImages.Parent = Me.btnEdit
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnEdit.HoverState.Parent = Me.btnEdit
        Me.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEdit.ShadowDecoration.Parent = Me.btnEdit
        Me.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnEdit.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'btnAddNew
        '
        Me.btnAddNew.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton
        Me.btnAddNew.CheckedState.Parent = Me.btnAddNew
        Me.btnAddNew.CustomImages.Parent = Me.btnAddNew
        Me.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAddNew.HoverState.Parent = Me.btnAddNew
        Me.btnAddNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAddNew.ShadowDecoration.Parent = Me.btnAddNew
        Me.btnAddNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAddNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.btnAddNew.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None
        '
        'RecordInfo
        '
        Me.RecordInfo.Size = New System.Drawing.Size(310, 532)
        '
        'SplitRecordInfo
        '
        Me.SplitRecordInfo.Size = New System.Drawing.Size(1924, 532)
        Me.SplitRecordInfo.SplitterPosition = 1609
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
        Me.txtPK.TableField = "pk_um"
        Me.txtPK.TableName = "universal_masters"
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
        Me.txtModule.EditValue = "Supplier"
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
        Me.txtModule.TableField = "module_um"
        Me.txtModule.TableName = "universal_masters"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Size = New System.Drawing.Size(281, 526)
        '
        'PtTextInputGroup1
        '
        Me.PtTextInputGroup1.Location = New System.Drawing.Point(142, 30)
        Me.PtTextInputGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtTextInputGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtTextInputGroup1.Name = "PtTextInputGroup1"
        Me.PtTextInputGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PtTextInputGroup1.TabIndex = 0
        Me.PtTextInputGroup1.TableField = "name_um"
        Me.PtTextInputGroup1.TableLabel = "Name"
        Me.PtTextInputGroup1.TableName = "universal_masters"
        Me.PtTextInputGroup1.TextInputName = "PtTextInputGrp16383349873347787135318"
        '
        'PtMemoInputGroup1
        '
        Me.PtMemoInputGroup1.Location = New System.Drawing.Point(142, 105)
        Me.PtMemoInputGroup1.MaximumSize = New System.Drawing.Size(500, 96)
        Me.PtMemoInputGroup1.MinimumSize = New System.Drawing.Size(200, 96)
        Me.PtMemoInputGroup1.Name = "PtMemoInputGroup1"
        Me.PtMemoInputGroup1.Size = New System.Drawing.Size(250, 96)
        Me.PtMemoInputGroup1.TabIndex = 1
        Me.PtMemoInputGroup1.TableField = "address_um"
        Me.PtMemoInputGroup1.TableLabel = "Address:"
        Me.PtMemoInputGroup1.TableName = "universal_masters"
        '
        'PtTextInputGroup2
        '
        Me.PtTextInputGroup2.Location = New System.Drawing.Point(424, 30)
        Me.PtTextInputGroup2.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtTextInputGroup2.MinimumSize = New System.Drawing.Size(70, 45)
        Me.PtTextInputGroup2.Name = "PtTextInputGroup2"
        Me.PtTextInputGroup2.Size = New System.Drawing.Size(250, 45)
        Me.PtTextInputGroup2.TabIndex = 2
        Me.PtTextInputGroup2.TableField = "contactperson_um"
        Me.PtTextInputGroup2.TableLabel = "Contact Person:"
        Me.PtTextInputGroup2.TableName = "universal_masters"
        Me.PtTextInputGroup2.TextInputName = "PtTextInputGrp16385214240841813138689"
        '
        'PtTextInputGroup4
        '
        Me.PtTextInputGroup4.Location = New System.Drawing.Point(708, 30)
        Me.PtTextInputGroup4.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtTextInputGroup4.MinimumSize = New System.Drawing.Size(70, 45)
        Me.PtTextInputGroup4.Name = "PtTextInputGroup4"
        Me.PtTextInputGroup4.Size = New System.Drawing.Size(162, 45)
        Me.PtTextInputGroup4.TabIndex = 4
        Me.PtTextInputGroup4.TableField = "tin_um"
        Me.PtTextInputGroup4.TableLabel = "TIN:"
        Me.PtTextInputGroup4.TableName = "universal_masters"
        Me.PtTextInputGroup4.TextInputName = "PtTextInputGrp16385214241746526474161"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PtTextInputGroup4)
        Me.Panel1.Controls.Add(Me.PtTextInputGroup1)
        Me.Panel1.Controls.Add(Me.PtTextInputGroup2)
        Me.Panel1.Controls.Add(Me.PtTextInputGroup3)
        Me.Panel1.Controls.Add(Me.PtMemoInputGroup1)
        Me.Panel1.Location = New System.Drawing.Point(270, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1057, 388)
        Me.Panel1.TabIndex = 0
        '
        'PtTextInputGroup3
        '
        Me.PtTextInputGroup3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PtTextInputGroup3.Location = New System.Drawing.Point(424, 105)
        Me.PtTextInputGroup3.Margin = New System.Windows.Forms.Padding(6)
        Me.PtTextInputGroup3.MaximumSize = New System.Drawing.Size(438, 40)
        Me.PtTextInputGroup3.MinimumSize = New System.Drawing.Size(61, 40)
        Me.PtTextInputGroup3.Name = "PtTextInputGroup3"
        Me.PtTextInputGroup3.Size = New System.Drawing.Size(250, 40)
        Me.PtTextInputGroup3.TabIndex = 3
        Me.PtTextInputGroup3.TableField = "contactnos_um"
        Me.PtTextInputGroup3.TableLabel = "Contact Number: "
        Me.PtTextInputGroup3.TableName = "universal_masters"
        Me.PtTextInputGroup3.TextInputName = "PtTextInputGrp16385214241336900224401"
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1924, 532)
        Me.Name = "Supplier"
        Me.SearchFormColumnDefinitionInfo = resources.GetString("$this.SearchFormColumnDefinitionInfo")
        Me.SearchFormTableFromInfo = "|from universal_masters |where module_um = ""supplier"""
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.EditorButtonPanel.ResumeLayout(False)
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
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PtTextInputGroup1 As PTTextInputGroup
    Friend WithEvents PtMemoInputGroup1 As PTMemoInputGroup
    Friend WithEvents PtTextInputGroup4 As PTTextInputGroup
    Friend WithEvents PtTextInputGroup2 As PTTextInputGroup
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PtTextInputGroup3 As PTTextInputGroup
End Class
