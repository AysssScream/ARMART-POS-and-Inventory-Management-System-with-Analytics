Imports System
Imports System.ComponentModel

Public Class PTTextInputGroup
    Private Shared random As New Random()
    Public Event EditValueChanged()

    Private pLabel As String = "Label"
    Private pFieldName As String
    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PtTextInputGrp1.Name = Me.PtTextInputGrp1.Name & DateTime.Now.Ticks.ToString() & random.Next(1, 9999).ToString()
        pFieldName = Me.PtTextInputGrp1.Name

    End Sub

    Public Property TableLabel() As String
        Get
            Return pLabel
        End Get
        Set(ByVal value As String)
            pLabel = value
            Me.PtLabelGrp1.Text = value
        End Set
    End Property

    Public Property TextInputName() As String
        Get
            Return pFieldName
        End Get
        Set(ByVal value As String)
            pFieldName = value
            Me.PtTextInputGrp1.Name = IIf(value = "", Me.PtTextInputGrp1.Name, value)
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(pTableName)
        End Get
        Set(ByVal value As String)
            pTableName = value
            Me.PtTextInputGrp1.TableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(pTableField)
        End Get
        Set(ByVal value As String)
            pTableField = value
            Me.PtTextInputGrp1.TableField = value
        End Set
    End Property

    <DefaultValue(False)>
    Public Property RetainValue() As Boolean
        Get
            Return pRetainValue
        End Get
        Set(ByVal value As Boolean)
            pRetainValue = value
            Me.PtTextInputGrp1.RetainValue = value
        End Set
    End Property

    Private Sub PtTextInputGrp1_EditValueChanged(sender As Object, e As EventArgs) Handles PtTextInputGrp1.EditValueChanged
        RaiseEvent EditValueChanged()
    End Sub
End Class
