Imports System
Imports System.ComponentModel

Public Class PTNumericInputGroup
    Private Shared random As New Random()
    Public Event ValueChanged()

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PtNumericInput1.Name = Me.PtNumericInput1.Name & DateTime.Now.Ticks.ToString() & random.Next(1, 9999).ToString()


    End Sub

    Private pLabel As String = "Label"
    Private pValue As Object
    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean
    Private pDecimalPlaces As Integer

    Public Property TableLabel() As String
        Get
            Return pLabel
        End Get
        Set(ByVal value As String)
            pLabel = value
            Me.PtLabelGrp1.Text = value
        End Set
    End Property

    Public Property Value() As Object
        Get
            Return Me.PtNumericInput1.Value
        End Get
        Set(ByVal value As Object)
            Me.PtNumericInput1.Value = value
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(pTableName)
        End Get
        Set(ByVal value As String)
            pTableName = value
            Me.PtNumericInput1.TableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(pTableField)
        End Get
        Set(ByVal value As String)
            pTableField = value
            Me.PtNumericInput1.TableField = value
        End Set
    End Property

    Public Property DecimalPlaces() As Integer
        Get
            Return pDecimalPlaces
        End Get
        Set(ByVal value As Integer)
            pDecimalPlaces = value
            Me.PtNumericInput1.DecimalPlaces = value
        End Set
    End Property

    <DefaultValue(False)>
    Public Property RetainValue() As Boolean
        Get
            Return pRetainValue
        End Get
        Set(ByVal value As Boolean)
            pRetainValue = value
            Me.PtNumericInput1.RetainValue = value
        End Set
    End Property

    Private Sub PtNumericInput1_ValueChanged(sender As Object, e As EventArgs) Handles PtNumericInput1.ValueChanged
        RaiseEvent ValueChanged()
    End Sub
End Class
