Public Class BaseForm
    Private _TempRecordSelected As String
    Public Property TempRecordSelected() As String
        Get
            Return _TempRecordSelected
        End Get
        Set(ByVal value As String)
            _TempRecordSelected = value
        End Set
    End Property
End Class