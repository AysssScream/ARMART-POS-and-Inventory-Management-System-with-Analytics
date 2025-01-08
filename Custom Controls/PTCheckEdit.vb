Imports System.ComponentModel
Imports DevExpress.XtraEditors

Public Class PTCheckEdit : Inherits DevExpress.XtraEditors.CheckEdit

    Public Sub New()

        Me.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Properties.Appearance.Options.UseFont = True
        Me.Size = New System.Drawing.Size(200, 24)

    End Sub

    Private _TableField As String
    Private _TableName As String
    Private pRetainValue As Boolean

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(_TableName)
        End Get
        Set(ByVal value As String)
            _TableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(_TableField)
        End Get
        Set(ByVal value As String)
            _TableField = value
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
