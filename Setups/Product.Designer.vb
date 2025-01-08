<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.sg__inventory_units = New NewTemplate.DetailGrid()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.sg__transaction_ledger_inventories = New NewTemplate.DetailGrid()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PtTextInputGroup1 = New NewTemplate.PTTextInputGroup()
        Me.PtMemoInputGroup1 = New NewTemplate.PTMemoInputGroup()
        Me.PttGridLookupEditGroup1 = New NewTemplate.PTGridLookupEditGroup()
        Me.PtComboBoxInputGroup1 = New NewTemplate.PTComboBoxInputGroup()
        Me.PtNumericInputGroup1 = New NewTemplate.PTNumericInputGroup()
        Me.PtNumericInputGroup2 = New NewTemplate.PTNumericInputGroup()
        Me.PtNumericInputGroup3 = New NewTemplate.PTNumericInputGroup()
        Me.txtStockUnit = New NewTemplate.PTTextInputGroup()
        Me.txtBaseUnit = New NewTemplate.PTTextInputGroup()
        Me.txtStockCoversion = New NewTemplate.PTNumericInputGroup()
        Me.txtBaseConversion = New NewTemplate.PTNumericInputGroup()
        Me.PtNumericInputGroup4 = New NewTemplate.PTNumericInputGroup()
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
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.sg__inventory_units, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.sg__transaction_ledger_inventories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Text = "PRODUCT"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtNumericInputGroup4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtBaseUnit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txtStockUnit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtNumericInputGroup3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtNumericInputGroup2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtNumericInputGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtComboBoxInputGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PttGridLookupEditGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtMemoInputGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtTextInputGroup1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.SplitterPosition = 241
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
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
        Me.txtPK.TableField = "pk_invty"
        Me.txtPK.TableName = "inventories"
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
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.txtBaseConversion)
        Me.XtraTabPage2.Controls.Add(Me.txtStockCoversion)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(833, 222)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.sg__inventory_units)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(827, 194)
        Me.XtraTabPage3.Text = "UNITS"
        '
        'sg__inventory_units
        '
        Me.sg__inventory_units.ColumnDefinitionInfo = resources.GetString("sg__inventory_units.ColumnDefinitionInfo")
        Me.sg__inventory_units.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sg__inventory_units.Location = New System.Drawing.Point(0, 0)
        Me.sg__inventory_units.MainView = Me.GridView1
        Me.sg__inventory_units.Name = "sg__inventory_units"
        Me.sg__inventory_units.RowPosition = -2147483648
        Me.sg__inventory_units.Size = New System.Drawing.Size(827, 194)
        Me.sg__inventory_units.TabIndex = 1
        Me.sg__inventory_units.TableFromInfo = "|from inventory_units |order by Conversion_InvtyU"
        Me.sg__inventory_units.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.sg__inventory_units.WithFK = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.sg__inventory_units
        Me.GridView1.Name = "GridView1"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.sg__transaction_ledger_inventories)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(827, 194)
        Me.XtraTabPage4.Text = "ITEM LEDGER"
        '
        'sg__transaction_ledger_inventories
        '
        Me.sg__transaction_ledger_inventories.ColumnDefinitionInfo = resources.GetString("sg__transaction_ledger_inventories.ColumnDefinitionInfo")
        Me.sg__transaction_ledger_inventories.DisplayOnly = True
        Me.sg__transaction_ledger_inventories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sg__transaction_ledger_inventories.Location = New System.Drawing.Point(0, 0)
        Me.sg__transaction_ledger_inventories.MainView = Me.GridView2
        Me.sg__transaction_ledger_inventories.Name = "sg__transaction_ledger_inventories"
        Me.sg__transaction_ledger_inventories.RowPosition = -2147483648
        Me.sg__transaction_ledger_inventories.Size = New System.Drawing.Size(827, 194)
        Me.sg__transaction_ledger_inventories.TabIndex = 2
        Me.sg__transaction_ledger_inventories.TableFromInfo = "|from transaction_ledger_inventories left join transaction_headers on fk_transh_l" &
    "dgrinvty = pk_transh left join inventories on fk_invty_ldgrinvty = pk_invty |ord" &
    "er by date_transh desc, id_Transh desc"
        Me.sg__transaction_ledger_inventories.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.sg__transaction_ledger_inventories.WithFK = True
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.sg__transaction_ledger_inventories
        Me.GridView2.Name = "GridView2"
        '
        'PtTextInputGroup1
        '
        Me.PtTextInputGroup1.Location = New System.Drawing.Point(12, 30)
        Me.PtTextInputGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtTextInputGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtTextInputGroup1.Name = "PtTextInputGroup1"
        Me.PtTextInputGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PtTextInputGroup1.TabIndex = 0
        Me.PtTextInputGroup1.TableField = "itemcode_invty"
        Me.PtTextInputGroup1.TableLabel = "Item Code"
        Me.PtTextInputGroup1.TableName = "inventories"
        Me.PtTextInputGroup1.TextInputName = "PtTextInputGrp16383349875490363671616"
        '
        'PtMemoInputGroup1
        '
        Me.PtMemoInputGroup1.Location = New System.Drawing.Point(12, 81)
        Me.PtMemoInputGroup1.MaximumSize = New System.Drawing.Size(500, 96)
        Me.PtMemoInputGroup1.MinimumSize = New System.Drawing.Size(200, 96)
        Me.PtMemoInputGroup1.Name = "PtMemoInputGroup1"
        Me.PtMemoInputGroup1.Size = New System.Drawing.Size(250, 96)
        Me.PtMemoInputGroup1.TabIndex = 1
        Me.PtMemoInputGroup1.TableField = "description_invty"
        Me.PtMemoInputGroup1.TableLabel = "Description"
        Me.PtMemoInputGroup1.TableName = "inventories"
        '
        'PttGridLookupEditGroup1
        '
        Me.PttGridLookupEditGroup1.EditValue = Nothing
        Me.PttGridLookupEditGroup1.Location = New System.Drawing.Point(12, 183)
        Me.PttGridLookupEditGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PttGridLookupEditGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PttGridLookupEditGroup1.Name = "PttGridLookupEditGroup1"
        Me.PttGridLookupEditGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PttGridLookupEditGroup1.TabIndex = 3
        Me.PttGridLookupEditGroup1.TableColumnDefinitionString = resources.GetString("PttGridLookupEditGroup1.TableColumnDefinitionString")
        Me.PttGridLookupEditGroup1.TableDisplayField = "name_cat"
        Me.PttGridLookupEditGroup1.TableField = "fk_cat_invty"
        Me.PttGridLookupEditGroup1.TableFromString = "|from categories |order by name_cat"
        Me.PttGridLookupEditGroup1.TableLabel = "Category"
        Me.PttGridLookupEditGroup1.TableName = "inventories"
        Me.PttGridLookupEditGroup1.TableValueMember = "pk_cat"
        '
        'PtComboBoxInputGroup1
        '
        Me.PtComboBoxInputGroup1.AdditionalWhere = ""
        Me.PtComboBoxInputGroup1.DataSourceCustom = Nothing
        Me.PtComboBoxInputGroup1.Location = New System.Drawing.Point(286, 30)
        Me.PtComboBoxInputGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtComboBoxInputGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtComboBoxInputGroup1.Name = "PtComboBoxInputGroup1"
        Me.PtComboBoxInputGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PtComboBoxInputGroup1.TabIndex = 4
        Me.PtComboBoxInputGroup1.TableField = "brand_invty"
        Me.PtComboBoxInputGroup1.TableLabel = "Brand"
        Me.PtComboBoxInputGroup1.TableName = "inventories"
        '
        'PtNumericInputGroup1
        '
        Me.PtNumericInputGroup1.DecimalPlaces = 0
        Me.PtNumericInputGroup1.Location = New System.Drawing.Point(286, 81)
        Me.PtNumericInputGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtNumericInputGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtNumericInputGroup1.Name = "PtNumericInputGroup1"
        Me.PtNumericInputGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PtNumericInputGroup1.TabIndex = 5
        Me.PtNumericInputGroup1.TableField = "cost_invty"
        Me.PtNumericInputGroup1.TableLabel = "Cost"
        Me.PtNumericInputGroup1.TableName = "inventories"
        Me.PtNumericInputGroup1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PtNumericInputGroup2
        '
        Me.PtNumericInputGroup2.DecimalPlaces = 0
        Me.PtNumericInputGroup2.Location = New System.Drawing.Point(286, 132)
        Me.PtNumericInputGroup2.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtNumericInputGroup2.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtNumericInputGroup2.Name = "PtNumericInputGroup2"
        Me.PtNumericInputGroup2.Size = New System.Drawing.Size(250, 45)
        Me.PtNumericInputGroup2.TabIndex = 6
        Me.PtNumericInputGroup2.TableField = "price_invty"
        Me.PtNumericInputGroup2.TableLabel = "Price"
        Me.PtNumericInputGroup2.TableName = "inventories"
        Me.PtNumericInputGroup2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PtNumericInputGroup3
        '
        Me.PtNumericInputGroup3.DecimalPlaces = 0
        Me.PtNumericInputGroup3.Enabled = False
        Me.PtNumericInputGroup3.Location = New System.Drawing.Point(561, 30)
        Me.PtNumericInputGroup3.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtNumericInputGroup3.MinimumSize = New System.Drawing.Size(70, 45)
        Me.PtNumericInputGroup3.Name = "PtNumericInputGroup3"
        Me.PtNumericInputGroup3.Size = New System.Drawing.Size(120, 45)
        Me.PtNumericInputGroup3.TabIndex = 7
        Me.PtNumericInputGroup3.TableField = "quantity_invty"
        Me.PtNumericInputGroup3.TableLabel = "Quantity (Stock)"
        Me.PtNumericInputGroup3.TableName = "inventories"
        Me.PtNumericInputGroup3.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtStockUnit
        '
        Me.txtStockUnit.Enabled = False
        Me.txtStockUnit.Location = New System.Drawing.Point(561, 81)
        Me.txtStockUnit.MaximumSize = New System.Drawing.Size(500, 45)
        Me.txtStockUnit.MinimumSize = New System.Drawing.Size(70, 45)
        Me.txtStockUnit.Name = "txtStockUnit"
        Me.txtStockUnit.Size = New System.Drawing.Size(120, 45)
        Me.txtStockUnit.TabIndex = 8
        Me.txtStockUnit.TableField = "purchaseunit_invty"
        Me.txtStockUnit.TableLabel = "Stock Unit"
        Me.txtStockUnit.TableName = "inventories"
        Me.txtStockUnit.TextInputName = "txtUOM"
        '
        'txtBaseUnit
        '
        Me.txtBaseUnit.Enabled = False
        Me.txtBaseUnit.Location = New System.Drawing.Point(561, 132)
        Me.txtBaseUnit.MaximumSize = New System.Drawing.Size(500, 45)
        Me.txtBaseUnit.MinimumSize = New System.Drawing.Size(70, 45)
        Me.txtBaseUnit.Name = "txtBaseUnit"
        Me.txtBaseUnit.Size = New System.Drawing.Size(120, 45)
        Me.txtBaseUnit.TabIndex = 9
        Me.txtBaseUnit.TableField = "saleunit_invty"
        Me.txtBaseUnit.TableLabel = "Base Unit"
        Me.txtBaseUnit.TableName = "inventories"
        Me.txtBaseUnit.TextInputName = "PtTextInputGrp16383352737665267113030"
        '
        'txtStockCoversion
        '
        Me.txtStockCoversion.DecimalPlaces = 0
        Me.txtStockCoversion.Location = New System.Drawing.Point(22, 32)
        Me.txtStockCoversion.MaximumSize = New System.Drawing.Size(500, 45)
        Me.txtStockCoversion.MinimumSize = New System.Drawing.Size(70, 45)
        Me.txtStockCoversion.Name = "txtStockCoversion"
        Me.txtStockCoversion.Size = New System.Drawing.Size(127, 45)
        Me.txtStockCoversion.TabIndex = 0
        Me.txtStockCoversion.TableField = "stockconversion_invty"
        Me.txtStockCoversion.TableLabel = "Stock Conversion"
        Me.txtStockCoversion.TableName = "inventories"
        Me.txtStockCoversion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtBaseConversion
        '
        Me.txtBaseConversion.DecimalPlaces = 0
        Me.txtBaseConversion.Location = New System.Drawing.Point(22, 97)
        Me.txtBaseConversion.MaximumSize = New System.Drawing.Size(500, 45)
        Me.txtBaseConversion.MinimumSize = New System.Drawing.Size(70, 45)
        Me.txtBaseConversion.Name = "txtBaseConversion"
        Me.txtBaseConversion.Size = New System.Drawing.Size(127, 45)
        Me.txtBaseConversion.TabIndex = 1
        Me.txtBaseConversion.TableField = "baseconversion_invty"
        Me.txtBaseConversion.TableLabel = "Base Conversion"
        Me.txtBaseConversion.TableName = "inventories"
        Me.txtBaseConversion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PtNumericInputGroup4
        '
        Me.PtNumericInputGroup4.DecimalPlaces = 0
        Me.PtNumericInputGroup4.Enabled = False
        Me.PtNumericInputGroup4.Location = New System.Drawing.Point(286, 183)
        Me.PtNumericInputGroup4.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtNumericInputGroup4.MinimumSize = New System.Drawing.Size(70, 45)
        Me.PtNumericInputGroup4.Name = "PtNumericInputGroup4"
        Me.PtNumericInputGroup4.Size = New System.Drawing.Size(120, 45)
        Me.PtNumericInputGroup4.TabIndex = 10
        Me.PtNumericInputGroup4.TableField = "reorderlevel_invty"
        Me.PtNumericInputGroup4.TableLabel = "Re-order Level"
        Me.PtNumericInputGroup4.TableName = "inventories"
        Me.PtNumericInputGroup4.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1148, 536)
        Me.Name = "Product"
        Me.SearchFormColumnDefinitionInfo = resources.GetString("$this.SearchFormColumnDefinitionInfo")
        Me.SearchFormTableFromInfo = "|from inventories left join categories on fk_cat_invty = pk_cat |order by descrip" &
    "tion_invty"
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
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.sg__inventory_units, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.sg__transaction_ledger_inventories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PtMemoInputGroup1 As PTMemoInputGroup
    Friend WithEvents PtTextInputGroup1 As PTTextInputGroup
    Friend WithEvents PttGridLookupEditGroup1 As PTGridLookupEditGroup
    Friend WithEvents PtComboBoxInputGroup1 As PTComboBoxInputGroup
    Friend WithEvents PtNumericInputGroup2 As PTNumericInputGroup
    Friend WithEvents PtNumericInputGroup1 As PTNumericInputGroup
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sg__inventory_units As DetailGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtStockUnit As PTTextInputGroup
    Friend WithEvents PtNumericInputGroup3 As PTNumericInputGroup
    Friend WithEvents txtBaseUnit As PTTextInputGroup
    Friend WithEvents txtBaseConversion As PTNumericInputGroup
    Friend WithEvents txtStockCoversion As PTNumericInputGroup
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents sg__transaction_ledger_inventories As DetailGrid
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PtNumericInputGroup4 As PTNumericInputGroup
End Class
