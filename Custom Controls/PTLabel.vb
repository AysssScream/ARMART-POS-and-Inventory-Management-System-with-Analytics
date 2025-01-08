Imports DevExpress.XtraEditors
Imports System.ComponentModel

Public Class PTLabel

    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.AutoSize = False
        Me.TextAlign = ContentAlignment.MiddleLeft
        Me.Size = New System.Drawing.Size(94, 24)
        Me.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

    End Sub


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

End Class
