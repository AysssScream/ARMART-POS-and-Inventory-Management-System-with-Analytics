Imports DevExpress.XtraReports.UI

Public Class ReportTable : Inherits XRTable
    Private _FieldName As String

    Sub New()

        Me.FieldName = Nothing
        Me.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.SizeF = New System.Drawing.SizeF(300.0!, 24.0!)
        Me.StylePriority.UseFont = False
        Me.StylePriority.UseTextAlignment = False
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
    End Sub

    Public Property FieldName() As String
        Get
            Return _FieldName
        End Get
        Set(ByVal value As String)
            _FieldName = value
        End Set
    End Property


    Private Sub InitializeComponent()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'fStyle
        '
        Me.fStyle.Font = New System.Drawing.Font("Verdana", 9.75!)
        '
        'ReportTable
        '
        Me.Font = New System.Drawing.Font("Verdana", 8.0!)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class
