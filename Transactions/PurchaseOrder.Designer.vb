<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchaseOrder
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseOrder))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.sg__transaction_ledger_inventorylogs = New NewTemplate.DetailGrid()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PtLabel1 = New NewTemplate.PTLabel()
        Me.PtUserPKInput1 = New NewTemplate.PTUserPKInput()
        Me.PtDateEdit1 = New NewTemplate.PTDateEdit()
        Me.PtMemoInputGroup1 = New NewTemplate.PTMemoInputGroup()
        Me.PtLabel2 = New NewTemplate.PTLabel()
        Me.PickProducts = New NewTemplate.GridPickListInfo()
        Me.PickUnits = New NewTemplate.GridPickListInfo()
        Me.PttGridLookupEditGroup1 = New NewTemplate.PTGridLookupEditGroup()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PtLabel7 = New NewTemplate.PTLabel()
        Me.PtLabel6 = New NewTemplate.PTLabel()
        Me.PtLabel5 = New NewTemplate.PTLabel()
        Me.PtLabel4 = New NewTemplate.PTLabel()
        Me.PtLabel3 = New NewTemplate.PTLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblGrossAmount = New NewTemplate.PTLabel()
        Me.lblTaxAmount = New NewTemplate.PTLabel()
        Me.lblNetOfTax = New NewTemplate.PTLabel()
        Me.lblDiscount = New NewTemplate.PTLabel()
        Me.lblSubTotal = New NewTemplate.PTLabel()
        Me.GrpTotalAmount = New NewTemplate.PTNumericInputGroup()
        Me.GrpSubTotal = New NewTemplate.PTNumericInputGroup()
        Me.GrpDiscount = New NewTemplate.PTNumericInputGroup()
        Me.GrpNetOfTax = New NewTemplate.PTNumericInputGroup()
        Me.GrpTaxAmount = New NewTemplate.PTNumericInputGroup()
        Me.PtTextInputGroup1 = New NewTemplate.PTTextInputGroup()
        Me.GrpStatus = New NewTemplate.PTTextInputGroup()
        Me.lblStatus = New NewTemplate.PTLabel()
        Me.GrpSubStatus = New NewTemplate.PTTextInputGroup()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSubStatus = New NewTemplate.PTLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
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
        CType(Me.sg__transaction_ledger_inventorylogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtUserPKInput1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtDateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtDateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PickProducts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PickUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.Size = New System.Drawing.Size(867, 30)
        Me.lblHeaderTitle.Text = "PURCHASE ORDER"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Guna2Button1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtTextInputGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PttGridLookupEditGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtLabel2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtMemoInputGroup1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtDateEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtUserPKInput1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PtLabel1)
        Me.SplitContainerControl1.Panel1.Text = "S"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainerControl1.Size = New System.Drawing.Size(867, 468)
        Me.SplitContainerControl1.SplitterPosition = 242
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(867, 68)
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
        'RecordInfo
        '
        Me.RecordInfo.Size = New System.Drawing.Size(322, 536)
        '
        'SplitRecordInfo
        '
        Me.SplitRecordInfo.Size = New System.Drawing.Size(1194, 536)
        Me.SplitRecordInfo.SplitterPosition = 867
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
        Me.txtModule.EditValue = "PurchaseOrder"
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
        Me.XtraTabPage2.Controls.Add(Me.GrpSubStatus)
        Me.XtraTabPage2.Controls.Add(Me.GrpStatus)
        Me.XtraTabPage2.Controls.Add(Me.GrpTaxAmount)
        Me.XtraTabPage2.Controls.Add(Me.GrpNetOfTax)
        Me.XtraTabPage2.Controls.Add(Me.GrpDiscount)
        Me.XtraTabPage2.Controls.Add(Me.GrpSubTotal)
        Me.XtraTabPage2.Controls.Add(Me.GrpTotalAmount)
        Me.XtraTabPage2.Controls.Add(Me.PickUnits)
        Me.XtraTabPage2.Controls.Add(Me.PickProducts)
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Size = New System.Drawing.Size(293, 530)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(867, 221)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.sg__transaction_ledger_inventorylogs)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(861, 193)
        Me.XtraTabPage3.Text = "ITEMS"
        '
        'sg__transaction_ledger_inventorylogs
        '
        Me.sg__transaction_ledger_inventorylogs.ColumnDefinitionInfo = resources.GetString("sg__transaction_ledger_inventorylogs.ColumnDefinitionInfo")
        Me.sg__transaction_ledger_inventorylogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sg__transaction_ledger_inventorylogs.InventoryEnabled = True
        Me.sg__transaction_ledger_inventorylogs.Location = New System.Drawing.Point(0, 0)
        Me.sg__transaction_ledger_inventorylogs.MainView = Me.GridView1
        Me.sg__transaction_ledger_inventorylogs.Name = "sg__transaction_ledger_inventorylogs"
        Me.sg__transaction_ledger_inventorylogs.RowPosition = -2147483648
        Me.sg__transaction_ledger_inventorylogs.ShowDeleteButton = True
        Me.sg__transaction_ledger_inventorylogs.Size = New System.Drawing.Size(861, 193)
        Me.sg__transaction_ledger_inventorylogs.TabIndex = 1
        Me.sg__transaction_ledger_inventorylogs.TableFromInfo = "|from transaction_ledger_inventorylogs left join inventories on fk_invty_ldgrinvt" &
    "ylog = pk_invty |order by id_ldgrinvtylog"
        Me.sg__transaction_ledger_inventorylogs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.sg__transaction_ledger_inventorylogs.WithFK = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.sg__transaction_ledger_inventorylogs
        Me.GridView1.Name = "GridView1"
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
        Me.PtUserPKInput1.Prefix = "PO-"
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
        Me.PtDateEdit1.Location = New System.Drawing.Point(292, 102)
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
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        SerializableAppearanceObject1.Image = CType(resources.GetObject("SerializableAppearanceObject1.Image"), System.Drawing.Image)
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
        Me.PtMemoInputGroup1.Location = New System.Drawing.Point(16, 132)
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
        Me.PtLabel2.Location = New System.Drawing.Point(289, 81)
        Me.PtLabel2.Name = "PtLabel2"
        Me.PtLabel2.Size = New System.Drawing.Size(37, 14)
        Me.PtLabel2.TabIndex = 5
        Me.PtLabel2.TableField = ""
        Me.PtLabel2.TableName = ""
        Me.PtLabel2.Text = "Date"
        Me.PtLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'PttGridLookupEditGroup1
        '
        Me.PttGridLookupEditGroup1.EditValue = Nothing
        Me.PttGridLookupEditGroup1.Location = New System.Drawing.Point(16, 81)
        Me.PttGridLookupEditGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PttGridLookupEditGroup1.MinimumSize = New System.Drawing.Size(200, 45)
        Me.PttGridLookupEditGroup1.Name = "PttGridLookupEditGroup1"
        Me.PttGridLookupEditGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PttGridLookupEditGroup1.TabIndex = 7
        Me.PttGridLookupEditGroup1.TableColumnDefinitionString = resources.GetString("PttGridLookupEditGroup1.TableColumnDefinitionString")
        Me.PttGridLookupEditGroup1.TableDisplayField = "name_um"
        Me.PttGridLookupEditGroup1.TableField = "fk_um_transh"
        Me.PttGridLookupEditGroup1.TableFromString = "|from universal_masters |where module_um = 'supplier' |order by name_um"
        Me.PttGridLookupEditGroup1.TableLabel = "Supplier"
        Me.PttGridLookupEditGroup1.TableName = "transaction_headers"
        Me.PttGridLookupEditGroup1.TableValueMember = "pk_um"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PtLabel7)
        Me.Panel1.Controls.Add(Me.PtLabel6)
        Me.Panel1.Controls.Add(Me.PtLabel5)
        Me.Panel1.Controls.Add(Me.PtLabel4)
        Me.Panel1.Controls.Add(Me.PtLabel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(568, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Panel1.Size = New System.Drawing.Size(264, 157)
        Me.Panel1.TabIndex = 9
        '
        'PtLabel7
        '
        Me.PtLabel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.PtLabel7.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.PtLabel7.Location = New System.Drawing.Point(0, 120)
        Me.PtLabel7.Name = "PtLabel7"
        Me.PtLabel7.Size = New System.Drawing.Size(129, 30)
        Me.PtLabel7.TabIndex = 11
        Me.PtLabel7.TableField = ""
        Me.PtLabel7.TableName = ""
        Me.PtLabel7.Text = "Gross Amount:"
        Me.PtLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PtLabel6
        '
        Me.PtLabel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PtLabel6.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.PtLabel6.Location = New System.Drawing.Point(0, 90)
        Me.PtLabel6.Name = "PtLabel6"
        Me.PtLabel6.Size = New System.Drawing.Size(129, 30)
        Me.PtLabel6.TabIndex = 10
        Me.PtLabel6.TableField = ""
        Me.PtLabel6.TableName = ""
        Me.PtLabel6.Text = "Tax Amount:"
        Me.PtLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PtLabel6.Visible = False
        '
        'PtLabel5
        '
        Me.PtLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PtLabel5.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.PtLabel5.Location = New System.Drawing.Point(0, 60)
        Me.PtLabel5.Name = "PtLabel5"
        Me.PtLabel5.Size = New System.Drawing.Size(129, 30)
        Me.PtLabel5.TabIndex = 9
        Me.PtLabel5.TableField = ""
        Me.PtLabel5.TableName = ""
        Me.PtLabel5.Text = "Net Of Tax:"
        Me.PtLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PtLabel5.Visible = False
        '
        'PtLabel4
        '
        Me.PtLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PtLabel4.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.PtLabel4.Location = New System.Drawing.Point(0, 30)
        Me.PtLabel4.Name = "PtLabel4"
        Me.PtLabel4.Size = New System.Drawing.Size(129, 30)
        Me.PtLabel4.TabIndex = 8
        Me.PtLabel4.TableField = ""
        Me.PtLabel4.TableName = ""
        Me.PtLabel4.Text = "Discount Amount:"
        Me.PtLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PtLabel3
        '
        Me.PtLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PtLabel3.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.PtLabel3.Location = New System.Drawing.Point(0, 0)
        Me.PtLabel3.Name = "PtLabel3"
        Me.PtLabel3.Size = New System.Drawing.Size(129, 30)
        Me.PtLabel3.TabIndex = 7
        Me.PtLabel3.TableField = ""
        Me.PtLabel3.TableName = ""
        Me.PtLabel3.Text = "Sub Total :"
        Me.PtLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblGrossAmount)
        Me.Panel2.Controls.Add(Me.lblTaxAmount)
        Me.Panel2.Controls.Add(Me.lblNetOfTax)
        Me.Panel2.Controls.Add(Me.lblDiscount)
        Me.Panel2.Controls.Add(Me.lblSubTotal)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(129, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(128, 155)
        Me.Panel2.TabIndex = 6
        '
        'lblGrossAmount
        '
        Me.lblGrossAmount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGrossAmount.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblGrossAmount.Location = New System.Drawing.Point(0, 120)
        Me.lblGrossAmount.Name = "lblGrossAmount"
        Me.lblGrossAmount.Size = New System.Drawing.Size(128, 30)
        Me.lblGrossAmount.TabIndex = 16
        Me.lblGrossAmount.TableField = ""
        Me.lblGrossAmount.TableName = ""
        Me.lblGrossAmount.Text = "0.00"
        Me.lblGrossAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTaxAmount.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTaxAmount.Location = New System.Drawing.Point(0, 90)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(128, 30)
        Me.lblTaxAmount.TabIndex = 15
        Me.lblTaxAmount.TableField = ""
        Me.lblTaxAmount.TableName = ""
        Me.lblTaxAmount.Text = "0.00"
        Me.lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTaxAmount.Visible = False
        '
        'lblNetOfTax
        '
        Me.lblNetOfTax.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNetOfTax.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblNetOfTax.Location = New System.Drawing.Point(0, 60)
        Me.lblNetOfTax.Name = "lblNetOfTax"
        Me.lblNetOfTax.Size = New System.Drawing.Size(128, 30)
        Me.lblNetOfTax.TabIndex = 14
        Me.lblNetOfTax.TableField = ""
        Me.lblNetOfTax.TableName = ""
        Me.lblNetOfTax.Text = "0.00"
        Me.lblNetOfTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNetOfTax.Visible = False
        '
        'lblDiscount
        '
        Me.lblDiscount.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDiscount.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDiscount.Location = New System.Drawing.Point(0, 30)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(128, 30)
        Me.lblDiscount.TabIndex = 13
        Me.lblDiscount.TableField = ""
        Me.lblDiscount.TableName = ""
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSubTotal.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSubTotal.Location = New System.Drawing.Point(0, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(128, 30)
        Me.lblSubTotal.TabIndex = 12
        Me.lblSubTotal.TableField = ""
        Me.lblSubTotal.TableName = ""
        Me.lblSubTotal.Text = "0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrpTotalAmount
        '
        Me.GrpTotalAmount.DecimalPlaces = 0
        Me.GrpTotalAmount.Location = New System.Drawing.Point(20, 366)
        Me.GrpTotalAmount.MaximumSize = New System.Drawing.Size(500, 45)
        Me.GrpTotalAmount.MinimumSize = New System.Drawing.Size(70, 45)
        Me.GrpTotalAmount.Name = "GrpTotalAmount"
        Me.GrpTotalAmount.Size = New System.Drawing.Size(250, 45)
        Me.GrpTotalAmount.TabIndex = 27
        Me.GrpTotalAmount.TableField = "totalamount_transh"
        Me.GrpTotalAmount.TableLabel = "Total Amount"
        Me.GrpTotalAmount.TableName = "transaction_headers"
        Me.GrpTotalAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GrpSubTotal
        '
        Me.GrpSubTotal.DecimalPlaces = 0
        Me.GrpSubTotal.Location = New System.Drawing.Point(20, 162)
        Me.GrpSubTotal.MaximumSize = New System.Drawing.Size(500, 45)
        Me.GrpSubTotal.MinimumSize = New System.Drawing.Size(70, 45)
        Me.GrpSubTotal.Name = "GrpSubTotal"
        Me.GrpSubTotal.Size = New System.Drawing.Size(250, 45)
        Me.GrpSubTotal.TabIndex = 28
        Me.GrpSubTotal.TableField = "subtotalamount_transh"
        Me.GrpSubTotal.TableLabel = "Sub Total"
        Me.GrpSubTotal.TableName = "transaction_headers"
        Me.GrpSubTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GrpDiscount
        '
        Me.GrpDiscount.DecimalPlaces = 0
        Me.GrpDiscount.Location = New System.Drawing.Point(20, 213)
        Me.GrpDiscount.MaximumSize = New System.Drawing.Size(500, 45)
        Me.GrpDiscount.MinimumSize = New System.Drawing.Size(70, 45)
        Me.GrpDiscount.Name = "GrpDiscount"
        Me.GrpDiscount.Size = New System.Drawing.Size(250, 45)
        Me.GrpDiscount.TabIndex = 29
        Me.GrpDiscount.TableField = "discountamount_transh"
        Me.GrpDiscount.TableLabel = "Discount Amount"
        Me.GrpDiscount.TableName = "transaction_headers"
        Me.GrpDiscount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GrpNetOfTax
        '
        Me.GrpNetOfTax.DecimalPlaces = 0
        Me.GrpNetOfTax.Location = New System.Drawing.Point(20, 264)
        Me.GrpNetOfTax.MaximumSize = New System.Drawing.Size(500, 45)
        Me.GrpNetOfTax.MinimumSize = New System.Drawing.Size(70, 45)
        Me.GrpNetOfTax.Name = "GrpNetOfTax"
        Me.GrpNetOfTax.Size = New System.Drawing.Size(250, 45)
        Me.GrpNetOfTax.TabIndex = 30
        Me.GrpNetOfTax.TableField = "netoftax_transh"
        Me.GrpNetOfTax.TableLabel = "Net Of VAT"
        Me.GrpNetOfTax.TableName = "transaction_headers"
        Me.GrpNetOfTax.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'GrpTaxAmount
        '
        Me.GrpTaxAmount.DecimalPlaces = 0
        Me.GrpTaxAmount.Location = New System.Drawing.Point(20, 315)
        Me.GrpTaxAmount.MaximumSize = New System.Drawing.Size(500, 45)
        Me.GrpTaxAmount.MinimumSize = New System.Drawing.Size(70, 45)
        Me.GrpTaxAmount.Name = "GrpTaxAmount"
        Me.GrpTaxAmount.Size = New System.Drawing.Size(250, 45)
        Me.GrpTaxAmount.TabIndex = 31
        Me.GrpTaxAmount.TableField = "taxamount_transh"
        Me.GrpTaxAmount.TableLabel = "Tax Amount"
        Me.GrpTaxAmount.TableName = "transaction_headers"
        Me.GrpTaxAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PtTextInputGroup1
        '
        Me.PtTextInputGroup1.Location = New System.Drawing.Point(292, 30)
        Me.PtTextInputGroup1.MaximumSize = New System.Drawing.Size(500, 45)
        Me.PtTextInputGroup1.MinimumSize = New System.Drawing.Size(70, 45)
        Me.PtTextInputGroup1.Name = "PtTextInputGroup1"
        Me.PtTextInputGroup1.Size = New System.Drawing.Size(250, 45)
        Me.PtTextInputGroup1.TabIndex = 10
        Me.PtTextInputGroup1.TableField = "refno_transh"
        Me.PtTextInputGroup1.TableLabel = "Reference #"
        Me.PtTextInputGroup1.TableName = "transaction_headers"
        Me.PtTextInputGroup1.TextInputName = "PtTextInputGrp16383419062100254749044"
        '
        'GrpStatus
        '
        Me.GrpStatus.Location = New System.Drawing.Point(20, 417)
        Me.GrpStatus.MaximumSize = New System.Drawing.Size(500, 45)
        Me.GrpStatus.MinimumSize = New System.Drawing.Size(70, 45)
        Me.GrpStatus.Name = "GrpStatus"
        Me.GrpStatus.Size = New System.Drawing.Size(250, 45)
        Me.GrpStatus.TabIndex = 32
        Me.GrpStatus.TableField = "status_transh"
        Me.GrpStatus.TableLabel = "Status"
        Me.GrpStatus.TableName = "transaction_headers"
        Me.GrpStatus.TextInputName = "PtTextInputGrp16383506836215361574880"
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(0, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(262, 19)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.TableField = ""
        Me.lblStatus.TableName = ""
        Me.lblStatus.Text = "Status"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpSubStatus
        '
        Me.GrpSubStatus.Location = New System.Drawing.Point(20, 468)
        Me.GrpSubStatus.MaximumSize = New System.Drawing.Size(500, 45)
        Me.GrpSubStatus.MinimumSize = New System.Drawing.Size(70, 45)
        Me.GrpSubStatus.Name = "GrpSubStatus"
        Me.GrpSubStatus.Size = New System.Drawing.Size(250, 45)
        Me.GrpSubStatus.TabIndex = 33
        Me.GrpSubStatus.TableField = "substatus_transh"
        Me.GrpSubStatus.TableLabel = "Sub-Status"
        Me.GrpSubStatus.TableName = "transaction_headers"
        Me.GrpSubStatus.TextInputName = "PtTextInputGrp1638"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblSubStatus)
        Me.Panel3.Controls.Add(Me.lblStatus)
        Me.Panel3.Location = New System.Drawing.Point(568, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 43)
        Me.Panel3.TabIndex = 12
        '
        'lblSubStatus
        '
        Me.lblSubStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSubStatus.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSubStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblSubStatus.Location = New System.Drawing.Point(0, 19)
        Me.lblSubStatus.Name = "lblSubStatus"
        Me.lblSubStatus.Size = New System.Drawing.Size(262, 19)
        Me.lblSubStatus.TabIndex = 13
        Me.lblSubStatus.TableField = ""
        Me.lblSubStatus.TableName = ""
        Me.lblSubStatus.Text = "SubStatus"
        Me.lblSubStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(312, 172)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 13
        Me.Guna2Button1.Text = "Approve"
        '
        'PurchaseOrder
        '
        Me.AttachReports = "|Key" & Global.Microsoft.VisualBasic.ChrW(9) & "|Report Caption" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|Report Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "@" & Global.Microsoft.VisualBasic.ChrW(9) & "|Purchase Order" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "|rptPurchaseOrder"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1194, 536)
        Me.Name = "PurchaseOrder"
        Me.SearchFormColumnDefinitionInfo = resources.GetString("$this.SearchFormColumnDefinitionInfo")
        Me.SearchFormTableFromInfo = "|from transaction_headers left join universal_masters on fk_um_transh = pk_um |wh" &
    "ere module_transh = 'purchaseorder' |order by date_transh desc,userpk_transh des" &
    "c"
        Me.TransactionType = NewTemplate.TransactionBase.TransactionTypesEnum.None
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
        CType(Me.sg__transaction_ledger_inventorylogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtUserPKInput1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtDateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtDateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PickProducts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PickUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents sg__transaction_ledger_inventorylogs As DetailGrid
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PtLabel1 As PTLabel
    Friend WithEvents PtUserPKInput1 As PTUserPKInput
    Friend WithEvents PtLabel2 As PTLabel
    Friend WithEvents PtMemoInputGroup1 As PTMemoInputGroup
    Friend WithEvents PtDateEdit1 As PTDateEdit
    Friend WithEvents PickProducts As GridPickListInfo
    Friend WithEvents PickUnits As GridPickListInfo
    Friend WithEvents PttGridLookupEditGroup1 As PTGridLookupEditGroup
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GrpTotalAmount As PTNumericInputGroup
    Friend WithEvents GrpTaxAmount As PTNumericInputGroup
    Friend WithEvents GrpNetOfTax As PTNumericInputGroup
    Friend WithEvents GrpDiscount As PTNumericInputGroup
    Friend WithEvents GrpSubTotal As PTNumericInputGroup
    Friend WithEvents PtLabel7 As PTLabel
    Friend WithEvents PtLabel6 As PTLabel
    Friend WithEvents PtLabel5 As PTLabel
    Friend WithEvents PtLabel4 As PTLabel
    Friend WithEvents PtLabel3 As PTLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblGrossAmount As PTLabel
    Friend WithEvents lblTaxAmount As PTLabel
    Friend WithEvents lblNetOfTax As PTLabel
    Friend WithEvents lblDiscount As PTLabel
    Friend WithEvents lblSubTotal As PTLabel
    Friend WithEvents PtTextInputGroup1 As PTTextInputGroup
    Friend WithEvents GrpStatus As PTTextInputGroup
    Friend WithEvents lblStatus As PTLabel
    Friend WithEvents GrpSubStatus As PTTextInputGroup
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblSubStatus As PTLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
