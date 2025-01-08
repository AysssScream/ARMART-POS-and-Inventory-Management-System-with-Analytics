Imports DevExpress.XtraEditors

Public Class PTPictureEdit : Inherits DevExpress.XtraEditors.PictureEdit
    Private pTableName As String
    Private pTableField As String
    Private _PTString As String


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

    Public Property PTString() As String
        Get
            Return _PTString
        End Get
        Set(ByVal value As String)
            _PTString = value
        End Set
    End Property
End Class
