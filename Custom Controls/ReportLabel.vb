Imports DevExpress.XtraReports.UI

Public Class ReportLabel : Inherits XRLabel
    Private _FieldName As String

    Public Property FieldName() As String
        Get
            Return _FieldName
        End Get
        Set(ByVal value As String)
            _FieldName = value
        End Set
    End Property

End Class
