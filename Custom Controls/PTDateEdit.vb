Imports DevExpress.XtraEditors
Imports System.ComponentModel

Public Class PTDateEdit : Inherits DateEdit
    Private pTableName As String
    Private pTableField As String
    Private pDefaultDate As Boolean
    Private pRetainValue As Boolean

    Public Sub New()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()

        Me.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.ForeColor = System.Drawing.Color.Black

        Me.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Properties.AutoHeight = False
        Me.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        EditorButtonImageOptions1.Image = Global.NewTemplate.My.Resources.Resources.calendar4
        SerializableAppearanceObject1.Image = Global.NewTemplate.My.Resources.Resources.delete
        SerializableAppearanceObject1.Options.UseImage = True
        Me.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Size = New System.Drawing.Size(200, 24)
    End Sub

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(pTableName) 'IIf(IsNothing(pTableName) OrElse String.IsNullOrEmpty(pTableName), "", pTableName.ToLower)
        End Get
        Set(ByVal value As String)
            pTableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(pTableField) 'IIf(IsNothing(pTableField) OrElse String.IsNullOrEmpty(pTableField), "", pTableField.ToLower)
        End Get
        Set(ByVal value As String)
            pTableField = value
        End Set
    End Property
    <DefaultValue(False)>
    Public Property IsBlankDate() As Boolean
        Get
            Return pDefaultDate
        End Get
        Set(ByVal value As Boolean)
            pDefaultDate = value
        End Set
    End Property

    <DefaultValue(False)>
    Public Property RetainValue() As Boolean
        Get
            Return pRetainValue
        End Get
        Set(ByVal value As Boolean)
            pRetainValue = value
        End Set
    End Property
End Class
