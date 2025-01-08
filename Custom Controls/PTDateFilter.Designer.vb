<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PTDateFilter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PTDateFilter))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.DateEnd = New NewTemplate.PTDateEdit()
        Me.DateStart = New NewTemplate.PTDateEdit()
        Me.cboFilterType = New NewTemplate.PTComboBoxInput()
        CType(Me.DateEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFilterType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateEnd
        '
        Me.DateEnd.EditValue = Nothing
        Me.DateEnd.Location = New System.Drawing.Point(206, 4)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DateEnd.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.DateEnd.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.DateEnd.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.DateEnd.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.DateEnd.Properties.Appearance.Options.UseBackColor = True
        Me.DateEnd.Properties.Appearance.Options.UseBorderColor = True
        Me.DateEnd.Properties.Appearance.Options.UseFont = True
        Me.DateEnd.Properties.Appearance.Options.UseForeColor = True
        Me.DateEnd.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateEnd.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.DateEnd.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.DateEnd.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.DateEnd.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.DateEnd.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.DateEnd.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.DateEnd.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.DateEnd.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.DateEnd.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateEnd.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.DateEnd.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.DateEnd.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DateEnd.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.DateEnd.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateEnd.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.DateEnd.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.DateEnd.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.DateEnd.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.DateEnd.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.DateEnd.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.DateEnd.Properties.AutoHeight = False
        Me.DateEnd.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        SerializableAppearanceObject1.Image = CType(resources.GetObject("SerializableAppearanceObject1.Image"), System.Drawing.Image)
        SerializableAppearanceObject1.Options.UseImage = True
        Me.DateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.DateEnd.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEnd.Size = New System.Drawing.Size(110, 24)
        Me.DateEnd.TabIndex = 2
        Me.DateEnd.TableField = ""
        Me.DateEnd.TableName = ""
        '
        'DateStart
        '
        Me.DateStart.EditValue = Nothing
        Me.DateStart.Location = New System.Drawing.Point(90, 3)
        Me.DateStart.Name = "DateStart"
        Me.DateStart.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.DateStart.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.DateStart.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.DateStart.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.DateStart.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.DateStart.Properties.Appearance.Options.UseBackColor = True
        Me.DateStart.Properties.Appearance.Options.UseBorderColor = True
        Me.DateStart.Properties.Appearance.Options.UseFont = True
        Me.DateStart.Properties.Appearance.Options.UseForeColor = True
        Me.DateStart.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateStart.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.DateStart.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.DateStart.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.DateStart.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.DateStart.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.DateStart.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.DateStart.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.DateStart.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.DateStart.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateStart.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.DateStart.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.DateStart.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.DateStart.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.DateStart.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateStart.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.DateStart.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.DateStart.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.DateStart.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.DateStart.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.DateStart.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.DateStart.Properties.AutoHeight = False
        Me.DateStart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        SerializableAppearanceObject5.Image = CType(resources.GetObject("SerializableAppearanceObject5.Image"), System.Drawing.Image)
        SerializableAppearanceObject5.Options.UseImage = True
        Me.DateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.DateStart.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.DateStart.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateStart.Size = New System.Drawing.Size(110, 24)
        Me.DateStart.TabIndex = 1
        Me.DateStart.TableField = ""
        Me.DateStart.TableName = ""
        '
        'cboFilterType
        '
        Me.cboFilterType.AdditionalWhere = ""
        Me.cboFilterType.DataSourceCustom = "As Of|Period From|Today|This Week|This Month|This Year|Equals"
        Me.cboFilterType.DataSourceUseCustom = True
        Me.cboFilterType.Location = New System.Drawing.Point(3, 3)
        Me.cboFilterType.Name = "cboFilterType"
        Me.cboFilterType.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cboFilterType.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.cboFilterType.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.cboFilterType.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.cboFilterType.Properties.Appearance.Options.UseBackColor = True
        Me.cboFilterType.Properties.Appearance.Options.UseBorderColor = True
        Me.cboFilterType.Properties.Appearance.Options.UseFont = True
        Me.cboFilterType.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cboFilterType.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.cboFilterType.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.cboFilterType.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.cboFilterType.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cboFilterType.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.cboFilterType.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cboFilterType.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.cboFilterType.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboFilterType.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.cboFilterType.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.cboFilterType.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboFilterType.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.cboFilterType.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cboFilterType.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.cboFilterType.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cboFilterType.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cboFilterType.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.cboFilterType.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.cboFilterType.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.cboFilterType.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.cboFilterType.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.cboFilterType.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.cboFilterType.Properties.AutoHeight = False
        Me.cboFilterType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cboFilterType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFilterType.Size = New System.Drawing.Size(81, 24)
        Me.cboFilterType.TabIndex = 0
        Me.cboFilterType.TableField = ""
        Me.cboFilterType.TableName = ""
        '
        'PTDateFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DateEnd)
        Me.Controls.Add(Me.DateStart)
        Me.Controls.Add(Me.cboFilterType)
        Me.Name = "PTDateFilter"
        Me.Size = New System.Drawing.Size(320, 31)
        CType(Me.DateEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateStart.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFilterType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboFilterType As PTComboBoxInput
    Friend WithEvents DateStart As PTDateEdit
    Friend WithEvents DateEnd As PTDateEdit
End Class
