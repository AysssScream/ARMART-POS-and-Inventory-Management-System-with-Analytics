Imports System.ComponentModel
Imports DevExpress.XtraEditors

Public Class PTMemoInput : Inherits MemoEdit
    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean

    Public Sub New()
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
        Me.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))

        Me.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Properties.AutoHeight = False
        Me.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Size = New System.Drawing.Size(200, 63)
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
    Public Property RetainValue() As Boolean
        Get
            Return pRetainValue
        End Get
        Set(ByVal value As Boolean)
            pRetainValue = value
        End Set
    End Property
End Class
