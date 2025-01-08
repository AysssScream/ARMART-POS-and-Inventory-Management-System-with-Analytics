Imports DevExpress.XtraEditors
Imports Guna.UI2.WinForms
Imports System.ComponentModel


Public Class PTNumericInput : Inherits Guna2NumericUpDown

    Public Sub New()
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DefaultValue = 0R
        Me.DecimalPlaces = 2
        Me.DisabledState.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.DisabledState.FillColor = System.Drawing.SystemColors.ControlLightLight
        Me.DisabledState.ForeColor = System.Drawing.Color.DimGray
        Me.DisabledState.UpDownButtonFillColor = System.Drawing.SystemColors.ControlLightLight
        Me.DisabledState.UpDownButtonForeColor = System.Drawing.Color.DimGray
        Me.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FocusedState.FillColor = System.Drawing.Color.White
        Me.FocusedState.ForeColor = System.Drawing.Color.Black
        Me.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Location = New System.Drawing.Point(580, 146)
        Me.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.Size = New System.Drawing.Size(200, 24)
        Me.ThousandsSeparator = True
        Me.UpDownButtonFillColor = System.Drawing.Color.White
        Me.UpDownButtonForeColor = System.Drawing.Color.Black

    End Sub

    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean
    Private pDefaultValue As Double

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(pTableName)
        End Get
        Set(ByVal value As String)
            pTableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(pTableField)
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

    Public Property DefaultValue() As Double
        Get
            Return pDefaultValue
        End Get
        Set(ByVal value As Double)
            pDefaultValue = value
        End Set
    End Property

End Class
