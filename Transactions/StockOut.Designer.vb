<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockOut
    Inherits NewTemplate.TransactionBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockOut))
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.sg__transaction_ledger_inventories = New NewTemplate.DetailGrid()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.sg__transaction_ledger_entries = New NewTemplate.DetailGrid()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PtLabel1 = New NewTemplate.PTLabel()
        Me.PtUserPKInput1 = New NewTemplate.PTUserPKInput()
        Me.PtDateEdit1 = New NewTemplate.PTDateEdit()
        Me.PtMemoInputGroup1 = New NewTemplate.PTMemoInputGroup()
        Me.PtLabel2 = New NewTemplate.PTLabel()
        Me.PtNumericInputGroup1 = New NewTemplate.PTNumericInputGroup()
        Me.PickProducts = New NewTemplate.GridPickListInfo()
        Me.PickUnits = New NewTemplate.GridPickListInfo()
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
        CType(Me.sg__transaction_ledger_inventories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.sg__transaction_ledger_entries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtUserPKInput1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtDateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtDateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PickProducts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PickUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Text = "STOCK OUT"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtNumericInputGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtLabel2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtMemoInputGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtDateEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtUserPKInput1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtLabel1)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.SplitterPosition = 214
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
        Me.txtPK.TableField = "pk_transh"
        Me.txtPK.TableName = "transaction_headers"
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
        Me.txtModule.EditValue = "StockOut"
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
        Me.txtModule.TableField = "module_transh"
        Me.txtModule.TableName = "transaction_headers"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PickUnits)
        Me.XtraTabPage2.Controls.Add(Me.PickProducts)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(833, 249)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.sg__transaction_ledger_inventories)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(827, 221)
        Me.XtraTabPage3.Text = "ITEMS"
        '
        'sg__transaction_ledger_inventories
        '
        Me.sg__transaction_ledger_inventories.ColumnDefinitionInfo = resources.GetString("sg__transaction_ledger_inventories.ColumnDefinitionInfo")
        Me.sg__transaction_ledger_inventories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sg__transaction_ledger_inventories.InventoryEnabled = True
        Me.sg__transaction_ledger_inventories.Location = New System.Drawing.Point(0, 0)
        Me.sg__transaction_ledger_inventories.MainView = Me.GridView1
        Me.sg__transaction_ledger_inventories.Name = "sg__transaction_ledger_inventories"
        Me.sg__transaction_ledger_inventories.RowPosition = -2147483648
        Me.sg__transaction_ledger_inventories.ShowDeleteButton = True
        Me.sg__transaction_ledger_inventories.Size = New System.Drawing.Size(827, 221)
        Me.sg__transaction_ledger_inventories.TabIndex = 1
        Me.sg__transaction_ledger_inventories.TableFromInfo = "|from transaction_ledger_inventories left join inventories on fk_invty_ldgrinvty " &
    "= pk_invty |order by id_ldgrinvty"
        Me.sg__transaction_ledger_inventories.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.sg__transaction_ledger_inventories.WithFK = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.sg__transaction_ledger_inventories
        Me.GridView1.Name = "GridView1"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.sg__transaction_ledger_entries)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(827, 221)
        Me.XtraTabPage4.Text = "GL IMPACT"
        '
        'sg__transaction_ledger_entries
        '
        Me.sg__transaction_ledger_entries.ColumnDefinitionInfo = resources.GetString("sg__transaction_ledger_entries.ColumnDefinitionInfo")
        Me.sg__transaction_ledger_entries.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sg__transaction_ledger_entries.GLEnabled = True
        Me.sg__transaction_ledger_entries.Location = New System.Drawing.Point(0, 0)
        Me.sg__transaction_ledger_entries.MainView = Me.GridView2
        Me.sg__transaction_ledger_entries.Name = "sg__transaction_ledger_entries"
        Me.sg__transaction_ledger_entries.RowPosition = -2147483648
        Me.sg__transaction_ledger_entries.ShowDeleteButton = True
        Me.sg__transaction_ledger_entries.Size = New System.Drawing.Size(827, 221)
        Me.sg__transaction_ledger_entries.TabIndex = 3
        Me.sg__transaction_ledger_entries.TableFromInfo = "|FROM transaction_ledger_entries left join chart_of_accounts on fk_coa_ldgrentrie" &
    "s = pk_coa |where module_ldgrentries like ""%GENENTRY"" |order by DRAmount_LdgrEnt" &
    "ries DESC"
        Me.sg__transaction_ledger_entries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.sg__transaction_ledger_entries.WithFK = True
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.sg__transaction_ledger_entries
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowSort = False
        '
        'PtLabel1
        '
        Me.PtLabel1.AutoSize = True
        Me.PtLabel1.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtLabel1.Location = New System.Drawing.Point(13, 30)
        Me.PtLabel1.Name = "PtLabel1"
        Me.PtLabel1.Size = New System.Drawing.Size(64, 14)
        Me.PtLabel1.TabIndex = 1
        Me.PtLabel1.TableField = ""
        Me.PtLabel1.TableName = ""
        Me.PtLabel1.Text = "Record #"
        Me.PtLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PtUserPKInput1
        '
        Me.PtUserPKInput1.AddWhere = ""
        Me.PtUserPKInput1.DisplayFormat = ""
        Me.PtUserPKInput1.Location = New System.Drawing.Point(16, 51)
        Me.PtUserPKInput1.Name = "PtUserPKInput1"
        Me.PtUserPKInput1.Prefix = "SR-"
        Me.PtUserPKInput1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PtUserPKInput1.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.PtUserPKInput1.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PtUserPKInput1.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtUserPKInput1.Properties.Appearance.Options.UseBackColor = True
        Me.PtUserPKInput1.Properties.Appearance.Options.UseBorderColor = True
        Me.PtUserPKInput1.Properties.Appearance.Options.UseFont = True
        Me.PtUserPKInput1.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtUserPKInput1.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.PtUserPKInput1.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtUserPKInput1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.PtUserPKInput1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.PtUserPKInput1.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.PtUserPKInput1.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.PtUserPKInput1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.PtUserPKInput1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.PtUserPKInput1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PtUserPKInput1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.PtUserPKInput1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.PtUserPKInput1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.PtUserPKInput1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.PtUserPKInput1.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtUserPKInput1.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.PtUserPKInput1.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtUserPKInput1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.PtUserPKInput1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.PtUserPKInput1.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.PtUserPKInput1.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.PtUserPKInput1.Properties.AutoHeight = False
        Me.PtUserPKInput1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PtUserPKInput1.Size = New System.Drawing.Size(250, 24)
        Me.PtUserPKInput1.TabIndex = 2
        Me.PtUserPKInput1.TableField = "userpk_transh"
        Me.PtUserPKInput1.TableName = "transaction_headers"
        Me.PtUserPKInput1.UseGroupDate = False
        Me.PtUserPKInput1.Where = ""
        '
        'PtDateEdit1
        '
        Me.PtDateEdit1.EditValue = Nothing
        Me.PtDateEdit1.Location = New System.Drawing.Point(292, 51)
        Me.PtDateEdit1.Name = "PtDateEdit1"
        Me.PtDateEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PtDateEdit1.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.PtDateEdit1.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.PtDateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtDateEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PtDateEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PtDateEdit1.Properties.Appearance.Options.UseBorderColor = True
        Me.PtDateEdit1.Properties.Appearance.Options.UseFont = True
        Me.PtDateEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.PtDateEdit1.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtDateEdit1.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.PtDateEdit1.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtDateEdit1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.PtDateEdit1.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.PtDateEdit1.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.PtDateEdit1.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.PtDateEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.PtDateEdit1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.PtDateEdit1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PtDateEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.PtDateEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.PtDateEdit1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.PtDateEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.PtDateEdit1.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PtDateEdit1.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.PtDateEdit1.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.PtDateEdit1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.PtDateEdit1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.PtDateEdit1.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.PtDateEdit1.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.PtDateEdit1.Properties.AutoHeight = False
        Me.PtDateEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        SerializableAppearanceObject1.Options.UseImage = True
        Me.PtDateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.PtDateEdit1.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PtDateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PtDateEdit1.Size = New System.Drawing.Size(250, 24)
        Me.PtDateEdit1.TabIndex = 3
        Me.PtDateEdit1.TableField = "date_transh"
        Me.PtDateEdit1.TableName = "transaction_headers"
        '
        'PtMemoInputGroup1
        '
        Me.PtMemoInputGroup1.Location = New System.Drawing.Point(16, 81)
        Me.PtMemoInputGroup1.MaximumSize = New System.Drawing.Size(500, 96)
        Me.PtMemoInputGroup1.MinimumSize = New System.Drawing.Size(200, 96)
        Me.PtMemoInputGroup1.Name = "PtMemoInputGroup1"
        Me.PtMemoInputGroup1.Size = New System.Drawing.Size(250, 96)
        Me.PtMemoInputGroup1.TabIndex = 4
        Me.PtMemoInputGroup1.TableField = "particulars_transh"
        Me.PtMemoInputGroup1.TableLabel = "Particulars"
        Me.PtMemoInputGroup1.TableName = "transaction_headers"
        '
        'PtLabel2
        '
        Me.PtLabel2.AutoSize = True
        Me.PtLabel2.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PtLabel2.Location = New System.Drawing.Point(289, 30)
        Me.PtLabel2.Name = "PtLabel2"
        Me.PtLabel2.Size = New System.Drawing.Size(37, 14)
        Me.PtLabel2.TabIndex = 5
        Me.PtLabel2.TableField = ""
        Me.PtLabel2.TableName = ""
        Me.PtLabel2.Text = "Date"
        Me.PtLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PtNumericInputGroup1
        '
        Me.PtNumericInputGroup1.DecimalPlaces = 0
        Me.PtNumericInputGroup1.Enabled = False
        Me.PtNumericInputGroup1.Location = New System.Drawing.Point(292, 81)
        Me.PtNumericInputGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtNumericInputGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PtNumericInputGroup1.Name = "PtNumericInputGroup1"
        Me.PtNumericInputGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PtNumericInputGroup1.TabIndex = 6
        Me.PtNumericInputGroup1.TableField = "totalamount_transh"
        Me.PtNumericInputGroup1.TableLabel = "Total Amount"
        Me.PtNumericInputGroup1.TableName = "transaction_headers"
        Me.PtNumericInputGroup1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PickProducts
        '
        Me.PickProducts._PickColumnsInfo = resources.GetString("PickProducts._PickColumnsInfo")
        Me.PickProducts._PickTableFromInfo = "|from inventories left join inventory_units on fk_invty_invtyu = pk_invty |where " &
    "IsPurchaseUnit_InvtyU = 1 |order by description_invty"
        Me.PickProducts.EditValue = resources.GetString("PickProducts.EditValue")
        Me.PickProducts.Location = New System.Drawing.Point(20, 40)
        Me.PickProducts.Name = "PickProducts"
        Me.PickProducts.OwnerGrid = Nothing
        Me.PickProducts.Size = New System.Drawing.Size(210, 27)
        Me.PickProducts.TabIndex = 25
        Me.PickProducts.ValueMember = Nothing
        '
        'PickUnits
        '
        Me.PickUnits._PickColumnsInfo = resources.GetString("PickUnits._PickColumnsInfo")
        Me.PickUnits._PickTableFromInfo = "|from inventory_units |order by Conversion_InvtyU"
        Me.PickUnits.EditValue = resources.GetString("PickUnits.EditValue")
        Me.PickUnits.Location = New System.Drawing.Point(20, 73)
        Me.PickUnits.Name = "PickUnits"
        Me.PickUnits.OwnerGrid = Nothing
        Me.PickUnits.ReloadPickListOnPopup = True
        Me.PickUnits.Size = New System.Drawing.Size(210, 27)
        Me.PickUnits.TabIndex = 26
        Me.PickUnits.ValueMember = Nothing
        '
        'StockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1148, 536)
        Me.EntriesGrid = Me.sg__transaction_ledger_entries
        Me.ItemsGrid = Me.sg__transaction_ledger_inventories
        Me.Name = "StockOut"
        Me.SearchFormColumnDefinitionInfo = resources.GetString("$this.SearchFormColumnDefinitionInfo")
        Me.SearchFormTableFromInfo = "|from transaction_headers |where module_transh = 'stockout' |order by date_transh" &
    " desc, id_transh desc"
        Me.TransactionType = NewTemplate.TransactionBase.TransactionTypesEnum.StockOut
        Me.TransDateControl = Me.PtDateEdit1
        Me.UserPKControl = Me.PtUserPKInput1
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
        CType(Me.sg__transaction_ledger_inventories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.sg__transaction_ledger_entries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtUserPKInput1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtDateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtDateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PickProducts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PickUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents sg__transaction_ledger_inventories As DetailGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PtLabel1 As PTLabel
    Friend WithEvents PtUserPKInput1 As PTUserPKInput
    Friend WithEvents PtLabel2 As PTLabel
    Friend WithEvents PtMemoInputGroup1 As PTMemoInputGroup
    Friend WithEvents PtDateEdit1 As PTDateEdit
    Friend WithEvents PtNumericInputGroup1 As PTNumericInputGroup
    Friend WithEvents PickProducts As GridPickListInfo
    Friend WithEvents PickUnits As GridPickListInfo
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents sg__transaction_ledger_entries As DetailGrid
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
