Imports System
Imports System.ComponentModel

Public Class PTComboBoxInputGroup
    Private Shared random As New Random()
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PtComboBoxInput1.Name = Me.PtComboBoxInput1.Name & DateTime.Now.Ticks.ToString() & random.Next(1, 9999).ToString()


    End Sub

    Private pLabel As String = "Label"
    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean

    Private pDataSourceCustom As String
    Private pUseCustomData As Boolean
    Private pDropDownSizeable As Boolean
    Private pAdditionalWhere As String

    Public Property TableLabel() As String
        Get
            Return pLabel
        End Get
        Set(ByVal value As String)
            pLabel = value
            Me.PtLabelGrp1.Text = value
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(pTableName)
        End Get
        Set(ByVal value As String)
            pTableName = value
            Me.PtComboBoxInput1.TableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(pTableField)
        End Get
        Set(ByVal value As String)
            pTableField = value
            Me.PtComboBoxInput1.TableField = value
        End Set
    End Property

    <DefaultValue(False)>
    Public Property RetainValue() As Boolean
        Get
            Return pRetainValue
        End Get
        Set(ByVal value As Boolean)
            pRetainValue = value
            Me.PtComboBoxInput1.RetainValue = value
        End Set
    End Property
    Public Property AdditionalWhere() As String
        Get
            Return GetLowerCaseString(pAdditionalWhere)
        End Get
        Set(ByVal value As String)
            pAdditionalWhere = value
            Me.PtComboBoxInput1.AdditionalWhere = value
        End Set
    End Property


    <DefaultValue(False)>
    Public Property DataSourceUseCustom() As Boolean
        Get
            Return pUseCustomData
        End Get
        Set(ByVal value As Boolean)
            pUseCustomData = value
            Me.PtComboBoxInput1.DataSourceUseCustom = value
            'If pUseCustomData Then
            '    Me.DataSourceSqlFrom = ""
            '    Me.DataSourceField = ""
            'End If
        End Set
    End Property

    Public Property DataSourceCustom() As String
        Get
            Return pDataSourceCustom
        End Get
        Set(ByVal value As String)
            pDataSourceCustom = value
            Me.PtComboBoxInput1.DataSourceCustom = value
        End Set
    End Property

    <DefaultValue(False)>
    Public Property DropDownSizeable() As Boolean
        Get
            Return pDropDownSizeable
        End Get
        Set(ByVal value As Boolean)
            pDropDownSizeable = value
            Me.PtComboBoxInput1.DropDownSizeable = value
        End Set
    End Property

End Class
