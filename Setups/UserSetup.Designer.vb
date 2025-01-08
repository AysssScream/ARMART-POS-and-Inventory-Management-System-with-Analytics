<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSetup))
        Me.PtTextInputGroup1 = New NewTemplate.PTTextInputGroup()
        Me.PtTextInputGroup2 = New NewTemplate.PTTextInputGroup()
        Me.PtTextInputGroup3 = New NewTemplate.PTTextInputGroup()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SimpleButton5 = New Guna.UI2.WinForms.Guna2Button()
        Me.lstPermissions = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.SimpleButton4 = New Guna.UI2.WinForms.Guna2Button()
        Me.SimpleButton2 = New Guna.UI2.WinForms.Guna2Button()
        Me.SimpleButton1 = New Guna.UI2.WinForms.Guna2Button()
        Me.SimpleButton3 = New Guna.UI2.WinForms.Guna2Button()
        Me.lstMenuItems = New DevExpress.XtraEditors.ListBoxControl()
        Me.lstSystemWindows = New DevExpress.XtraEditors.ListBoxControl()
        Me.PtComboBoxInputGroup1 = New NewTemplate.PTComboBoxInputGroup()
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
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.lstPermissions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstMenuItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lstSystemWindows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Size = New System.Drawing.Size(943, 30)
        Me.lblHeaderTitle.Text = "USER"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtComboBoxInputGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtTextInputGroup3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtTextInputGroup2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtTextInputGroup1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Size = New System.Drawing.Size(943, 694)
        Me.SplitContainerControl1.SplitterPosition = 192
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(943, 68)
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
        Me.RecordInfo.Size = New System.Drawing.Size(350, 762)
        '
        'SplitRecordInfo
        '
        Me.SplitRecordInfo.Size = New System.Drawing.Size(1298, 762)
        Me.SplitRecordInfo.SplitterPosition = 943
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
        Me.txtPK.TableField = "pk_usr"
        Me.txtPK.TableName = "users"
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
        'XtraTabPage1
        '
        Me.XtraTabPage1.Size = New System.Drawing.Size(321, 756)
        '
        'PtTextInputGroup1
        '
        Me.PtTextInputGroup1.Location = New System.Drawing.Point(12, 30)
        Me.PtTextInputGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtTextInputGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtTextInputGroup1.Name = "PtTextInputGroup1"
        Me.PtTextInputGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PtTextInputGroup1.TabIndex = 0
        Me.PtTextInputGroup1.TableField = "username_usr"
        Me.PtTextInputGroup1.TableLabel = "Username"
        Me.PtTextInputGroup1.TableName = "users"
        Me.PtTextInputGroup1.TextInputName = "PtTextInputGrp16383349742675303223941"
        '
        'PtTextInputGroup2
        '
        Me.PtTextInputGroup2.Location = New System.Drawing.Point(12, 81)
        Me.PtTextInputGroup2.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtTextInputGroup2.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtTextInputGroup2.Name = "PtTextInputGroup2"
        Me.PtTextInputGroup2.Size = New System.Drawing.Size(250, 45)
        Me.PtTextInputGroup2.TabIndex = 1
        Me.PtTextInputGroup2.TableField = "password_usr"
        Me.PtTextInputGroup2.TableLabel = "Password"
        Me.PtTextInputGroup2.TableName = "users"
        Me.PtTextInputGroup2.TextInputName = "PtTextInputGrp16383349743348618233740"
        '
        'PtTextInputGroup3
        '
        Me.PtTextInputGroup3.Location = New System.Drawing.Point(12, 132)
        Me.PtTextInputGroup3.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtTextInputGroup3.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtTextInputGroup3.Name = "PtTextInputGroup3"
        Me.PtTextInputGroup3.Size = New System.Drawing.Size(250, 45)
        Me.PtTextInputGroup3.TabIndex = 2
        Me.PtTextInputGroup3.TableField = "name_usr"
        Me.PtTextInputGroup3.TableLabel = "Name"
        Me.PtTextInputGroup3.TableName = "users"
        Me.PtTextInputGroup3.TextInputName = "PtTextInputGrp16383349744207262425204"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(943, 497)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Label8)
        Me.XtraTabPage3.Controls.Add(Me.Label7)
        Me.XtraTabPage3.Controls.Add(Me.Label6)
        Me.XtraTabPage3.Controls.Add(Me.SimpleButton5)
        Me.XtraTabPage3.Controls.Add(Me.lstPermissions)
        Me.XtraTabPage3.Controls.Add(Me.SimpleButton4)
        Me.XtraTabPage3.Controls.Add(Me.SimpleButton2)
        Me.XtraTabPage3.Controls.Add(Me.SimpleButton1)
        Me.XtraTabPage3.Controls.Add(Me.SimpleButton3)
        Me.XtraTabPage3.Controls.Add(Me.lstMenuItems)
        Me.XtraTabPage3.Controls.Add(Me.lstSystemWindows)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(937, 469)
        Me.XtraTabPage3.Text = "USER PERMISSIONS"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(634, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(260, 20)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Restrictions"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(355, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(260, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Can Access Forms"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(11, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Available Forms"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SimpleButton5
        '
        Me.SimpleButton5.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton5.BorderRadius = 15
        Me.SimpleButton5.CheckedState.Parent = Me.SimpleButton5
        Me.SimpleButton5.CustomBorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton5.CustomImages.Parent = Me.SimpleButton5
        Me.SimpleButton5.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.SimpleButton5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SimpleButton5.ForeColor = System.Drawing.Color.White
        Me.SimpleButton5.HoverState.Parent = Me.SimpleButton5
        Me.SimpleButton5.Location = New System.Drawing.Point(277, 249)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.ShadowDecoration.Parent = Me.SimpleButton5
        Me.SimpleButton5.Size = New System.Drawing.Size(72, 33)
        Me.SimpleButton5.TabIndex = 21
        Me.SimpleButton5.Text = "Sync"
        '
        'lstPermissions
        '
        Me.lstPermissions.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lstPermissions.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lstPermissions.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lstPermissions.Appearance.Options.UseBackColor = True
        Me.lstPermissions.Appearance.Options.UseFont = True
        Me.lstPermissions.Appearance.Options.UseForeColor = True
        Me.lstPermissions.Location = New System.Drawing.Point(634, 37)
        Me.lstPermissions.Name = "lstPermissions"
        Me.lstPermissions.Size = New System.Drawing.Size(260, 410)
        Me.lstPermissions.TabIndex = 20
        '
        'SimpleButton4
        '
        Me.SimpleButton4.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton4.BorderRadius = 15
        Me.SimpleButton4.CheckedState.Parent = Me.SimpleButton4
        Me.SimpleButton4.CustomBorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton4.CustomImages.Parent = Me.SimpleButton4
        Me.SimpleButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.SimpleButton4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SimpleButton4.ForeColor = System.Drawing.Color.White
        Me.SimpleButton4.HoverState.Parent = Me.SimpleButton4
        Me.SimpleButton4.Location = New System.Drawing.Point(277, 160)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.ShadowDecoration.Parent = Me.SimpleButton4
        Me.SimpleButton4.Size = New System.Drawing.Size(72, 33)
        Me.SimpleButton4.TabIndex = 19
        Me.SimpleButton4.Text = "<<"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.BorderRadius = 15
        Me.SimpleButton2.CheckedState.Parent = Me.SimpleButton2
        Me.SimpleButton2.CustomBorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton2.CustomImages.Parent = Me.SimpleButton2
        Me.SimpleButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.SimpleButton2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SimpleButton2.ForeColor = System.Drawing.Color.White
        Me.SimpleButton2.HoverState.Parent = Me.SimpleButton2
        Me.SimpleButton2.Location = New System.Drawing.Point(277, 121)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.ShadowDecoration.Parent = Me.SimpleButton2
        Me.SimpleButton2.Size = New System.Drawing.Size(72, 33)
        Me.SimpleButton2.TabIndex = 18
        Me.SimpleButton2.Text = "<"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.BorderRadius = 15
        Me.SimpleButton1.CheckedState.Parent = Me.SimpleButton1
        Me.SimpleButton1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.CustomImages.Parent = Me.SimpleButton1
        Me.SimpleButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.SimpleButton1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SimpleButton1.ForeColor = System.Drawing.Color.White
        Me.SimpleButton1.HoverState.Parent = Me.SimpleButton1
        Me.SimpleButton1.Location = New System.Drawing.Point(277, 82)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.ShadowDecoration.Parent = Me.SimpleButton1
        Me.SimpleButton1.Size = New System.Drawing.Size(72, 33)
        Me.SimpleButton1.TabIndex = 17
        Me.SimpleButton1.Text = ">"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.BorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.BorderRadius = 15
        Me.SimpleButton3.CheckedState.Parent = Me.SimpleButton3
        Me.SimpleButton3.CustomBorderColor = System.Drawing.Color.Transparent
        Me.SimpleButton3.CustomImages.Parent = Me.SimpleButton3
        Me.SimpleButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.SimpleButton3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.SimpleButton3.ForeColor = System.Drawing.Color.White
        Me.SimpleButton3.HoverState.Parent = Me.SimpleButton3
        Me.SimpleButton3.Location = New System.Drawing.Point(277, 43)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.ShadowDecoration.Parent = Me.SimpleButton3
        Me.SimpleButton3.Size = New System.Drawing.Size(72, 33)
        Me.SimpleButton3.TabIndex = 16
        Me.SimpleButton3.Text = ">>"
        '
        'lstMenuItems
        '
        Me.lstMenuItems.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lstMenuItems.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lstMenuItems.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lstMenuItems.Appearance.Options.UseBackColor = True
        Me.lstMenuItems.Appearance.Options.UseFont = True
        Me.lstMenuItems.Appearance.Options.UseForeColor = True
        Me.lstMenuItems.Location = New System.Drawing.Point(355, 38)
        Me.lstMenuItems.Name = "lstMenuItems"
        Me.lstMenuItems.Size = New System.Drawing.Size(260, 410)
        Me.lstMenuItems.TabIndex = 15
        '
        'lstSystemWindows
        '
        Me.lstSystemWindows.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lstSystemWindows.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.lstSystemWindows.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lstSystemWindows.Appearance.Options.UseBackColor = True
        Me.lstSystemWindows.Appearance.Options.UseFont = True
        Me.lstSystemWindows.Appearance.Options.UseForeColor = True
        Me.lstSystemWindows.Location = New System.Drawing.Point(11, 38)
        Me.lstSystemWindows.Name = "lstSystemWindows"
        Me.lstSystemWindows.Size = New System.Drawing.Size(260, 410)
        Me.lstSystemWindows.TabIndex = 14
        '
        'PtComboBoxInputGroup1
        '
        Me.PtComboBoxInputGroup1.AdditionalWhere = ""
        Me.PtComboBoxInputGroup1.DataSourceCustom = "User|Admin"
        Me.PtComboBoxInputGroup1.DataSourceUseCustom = True
        Me.PtComboBoxInputGroup1.Location = New System.Drawing.Point(292, 30)
        Me.PtComboBoxInputGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtComboBoxInputGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtComboBoxInputGroup1.Name = "PtComboBoxInputGroup1"
        Me.PtComboBoxInputGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PtComboBoxInputGroup1.TabIndex = 3
        Me.PtComboBoxInputGroup1.TableField = "accounttype_usr"
        Me.PtComboBoxInputGroup1.TableLabel = "User Type"
        Me.PtComboBoxInputGroup1.TableName = "users"
        '
        'UserSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1298, 762)
        Me.Name = "UserSetup"
        Me.SearchFormColumnDefinitionInfo = resources.GetString("$this.SearchFormColumnDefinitionInfo")
        Me.SearchFormTableFromInfo = "|from users"
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
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.lstPermissions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstMenuItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lstSystemWindows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PtTextInputGroup3 As PTTextInputGroup
    Friend WithEvents PtTextInputGroup2 As PTTextInputGroup
    Friend WithEvents PtTextInputGroup1 As PTTextInputGroup
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lstPermissions As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents SimpleButton4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SimpleButton2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SimpleButton1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SimpleButton3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lstMenuItems As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents lstSystemWindows As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents SimpleButton5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PtComboBoxInputGroup1 As PTComboBoxInputGroup
End Class
