<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRUDBase
    Inherits NewTemplate.BaseForm

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
        Me.components = New System.ComponentModel.Container()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.InputValidator = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.PrintMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PreviewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SplitRecordInfo = New DevExpress.XtraEditors.SplitContainerControl()
        Me.RecordInfo = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtUser = New NewTemplate.PTTextInput()
        Me.txtBranch = New NewTemplate.PTTextInput()
        Me.txtModuleType = New NewTemplate.PTTextInput()
        Me.txtModule = New NewTemplate.PTTextInput()
        Me.txtPK = New NewTemplate.PTTextInput()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.InputValidator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitRecordInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitRecordInfo.SuspendLayout()
        CType(Me.RecordInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecordInfo.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBranch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModuleType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintMenu
        '
        Me.PrintMenu.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PrintMenu.Name = "PrintMenu"
        Me.PrintMenu.Size = New System.Drawing.Size(61, 4)
        '
        'PreviewMenu
        '
        Me.PreviewMenu.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.PreviewMenu.Name = "PreviewMenu"
        Me.PreviewMenu.Size = New System.Drawing.Size(61, 4)
        '
        'SplitRecordInfo
        '
        Me.SplitRecordInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitRecordInfo.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.SplitRecordInfo.Location = New System.Drawing.Point(0, 0)
        Me.SplitRecordInfo.Name = "SplitRecordInfo"
        Me.SplitRecordInfo.Panel1.Text = "Panel1"
        Me.SplitRecordInfo.Panel2.Controls.Add(Me.RecordInfo)
        Me.SplitRecordInfo.Panel2.MinSize = 310
        Me.SplitRecordInfo.Panel2.Text = "Panel2"
        Me.SplitRecordInfo.Size = New System.Drawing.Size(1148, 536)
        Me.SplitRecordInfo.SplitterPosition = 833
        Me.SplitRecordInfo.TabIndex = 4
        Me.SplitRecordInfo.Text = "SplitContainerControl1"
        '
        'RecordInfo
        '
        Me.RecordInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecordInfo.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.RecordInfo.Location = New System.Drawing.Point(0, 0)
        Me.RecordInfo.Name = "RecordInfo"
        Me.RecordInfo.SelectedTabPage = Me.XtraTabPage1
        Me.RecordInfo.Size = New System.Drawing.Size(310, 536)
        Me.RecordInfo.TabIndex = 3
        Me.RecordInfo.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txtUser)
        Me.XtraTabPage1.Controls.Add(Me.txtBranch)
        Me.XtraTabPage1.Controls.Add(Me.txtModuleType)
        Me.XtraTabPage1.Controls.Add(Me.txtModule)
        Me.XtraTabPage1.Controls.Add(Me.txtPK)
        Me.XtraTabPage1.Controls.Add(Me.Label5)
        Me.XtraTabPage1.Controls.Add(Me.Label4)
        Me.XtraTabPage1.Controls.Add(Me.Label3)
        Me.XtraTabPage1.Controls.Add(Me.Label2)
        Me.XtraTabPage1.Controls.Add(Me.Label1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(281, 530)
        Me.XtraTabPage1.Text = "Record Info"
        '
        'txtUser
        '
        Me.txtUser.DisplayFormat = ""
        Me.txtUser.Location = New System.Drawing.Point(12, 214)
        Me.txtUser.Name = "txtUser"
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
        Me.txtUser.Properties.AutoHeight = False
        Me.txtUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtUser.RetainValue = True
        Me.txtUser.Size = New System.Drawing.Size(258, 24)
        Me.txtUser.TabIndex = 23
        Me.txtUser.TableField = ""
        Me.txtUser.TableName = ""
        '
        'txtBranch
        '
        Me.txtBranch.DisplayFormat = ""
        Me.txtBranch.Location = New System.Drawing.Point(12, 169)
        Me.txtBranch.Name = "txtBranch"
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
        Me.txtBranch.Properties.AutoHeight = False
        Me.txtBranch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtBranch.RetainValue = True
        Me.txtBranch.Size = New System.Drawing.Size(258, 24)
        Me.txtBranch.TabIndex = 22
        Me.txtBranch.TableField = ""
        Me.txtBranch.TableName = ""
        '
        'txtModuleType
        '
        Me.txtModuleType.DisplayFormat = ""
        Me.txtModuleType.Location = New System.Drawing.Point(12, 118)
        Me.txtModuleType.Name = "txtModuleType"
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
        Me.txtModuleType.Properties.AutoHeight = False
        Me.txtModuleType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtModuleType.RetainValue = True
        Me.txtModuleType.Size = New System.Drawing.Size(258, 24)
        Me.txtModuleType.TabIndex = 21
        Me.txtModuleType.TableField = ""
        Me.txtModuleType.TableName = ""
        '
        'txtModule
        '
        Me.txtModule.DisplayFormat = ""
        Me.txtModule.Location = New System.Drawing.Point(12, 70)
        Me.txtModule.Name = "txtModule"
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
        Me.txtModule.Properties.AutoHeight = False
        Me.txtModule.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtModule.RetainValue = True
        Me.txtModule.Size = New System.Drawing.Size(258, 24)
        Me.txtModule.TabIndex = 20
        Me.txtModule.TableField = ""
        Me.txtModule.TableName = ""
        '
        'txtPK
        '
        Me.txtPK.DisplayFormat = ""
        Me.txtPK.Location = New System.Drawing.Point(12, 25)
        Me.txtPK.Name = "txtPK"
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
        Me.txtPK.Properties.AutoHeight = False
        Me.txtPK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtPK.Size = New System.Drawing.Size(258, 24)
        Me.txtPK.TabIndex = 4
        Me.txtPK.TableField = ""
        Me.txtPK.TableName = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "User PK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Branch PK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Module Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Module"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PK"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(281, 530)
        Me.XtraTabPage2.Text = "Other Controls"
        '
        'CRUDBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 536)
        Me.Controls.Add(Me.SplitRecordInfo)
        Me.KeyPreview = True
        Me.Name = "CRUDBase"
        Me.Text = "CRUDBase"
        CType(Me.InputValidator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitRecordInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitRecordInfo.ResumeLayout(False)
        CType(Me.RecordInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecordInfo.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBranch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModuleType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents InputValidator As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents PrintMenu As ContextMenuStrip
    Friend WithEvents PreviewMenu As ContextMenuStrip
    Protected Friend WithEvents RecordInfo As DevExpress.XtraTab.XtraTabControl
    Protected Friend WithEvents SplitRecordInfo As DevExpress.XtraEditors.SplitContainerControl
    Protected Friend WithEvents txtPK As PTTextInput
    Protected Friend WithEvents txtUser As PTTextInput
    Protected Friend WithEvents txtBranch As PTTextInput
    Protected Friend WithEvents txtModuleType As PTTextInput
    Protected Friend WithEvents txtModule As PTTextInput
    Protected Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Protected Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Protected Friend WithEvents Label5 As Label
    Protected Friend WithEvents Label4 As Label
    Protected Friend WithEvents Label3 As Label
    Protected Friend WithEvents Label2 As Label
    Protected Friend WithEvents Label1 As Label
End Class
