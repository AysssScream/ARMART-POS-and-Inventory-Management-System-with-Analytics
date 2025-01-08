Imports System
Imports System.ComponentModel
Public Class PTMemoInputGroup
    Private Shared random As New Random()
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PtMemoInput1.Name = Me.PtMemoInput1.Name & DateTime.Now.Ticks.ToString() & random.Next(1, 9999).ToString()


    End Sub

    Private pLabel As String = "Label"
    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean


    Public Property TableLabel() As String
        Get
            Return pLabel
        End Get
        Set(ByVal value As String)
            pLabel = value
            Me.PtLabel1.Text = value
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(pTableName)
        End Get
        Set(ByVal value As String)
            pTableName = value
            Me.PtMemoInput1.TableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(pTableField)
        End Get
        Set(ByVal value As String)
            pTableField = value
            Me.PtMemoInput1.TableField = value
        End Set
    End Property

    <DefaultValue(False)>
    Public Property RetainValue() As Boolean
        Get
            Return pRetainValue
        End Get
        Set(ByVal value As Boolean)
            pRetainValue = value
            Me.PtMemoInput1.RetainValue = value
        End Set
    End Property
End Class
