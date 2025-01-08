Imports System
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design

Public Class PTGridLookupEditGroup
    Private Shared random As New Random()
    Public Event EditValueChanged()
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PtGridLookUpEdit1.Name = Me.PtGridLookUpEdit1.Name & DateTime.Now.Ticks.ToString() & random.Next(1, 9999).ToString()


    End Sub

    Private pLabel As String = "Label"
    Private pEditValue As Object
    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean
    Private pTableDisplayField As String
    Private pTableValueMember As String
    Private pTableFromString As String
    Private pTableColumnDefinitionString As String

    Public Property TableLabel() As String
        Get
            Return pLabel
        End Get
        Set(ByVal value As String)
            pLabel = value
            Me.PtLabelGrp1.Text = value
        End Set
    End Property

    Public Property EditValue() As Object
        Get
            Return Me.PtGridLookUpEdit1.EditValue
        End Get
        Set(ByVal value As Object)
            Me.PtGridLookUpEdit1.EditValue = value
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(pTableName)
        End Get
        Set(ByVal value As String)
            pTableName = value
            Me.PtGridLookUpEdit1.TableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(pTableField)
        End Get
        Set(ByVal value As String)
            pTableField = value
            Me.PtGridLookUpEdit1.TableField = value
        End Set
    End Property

    <DefaultValue(False)>
    Public Property RetainValue() As Boolean
        Get
            Return pRetainValue
        End Get
        Set(ByVal value As Boolean)
            pRetainValue = value
            Me.PtGridLookUpEdit1.RetainValue = value
        End Set
    End Property
    Public Property TableDisplayField() As String
        Get
            Return GetLowerCaseString(pTableDisplayField) 'IIf(IsNothing(pTableDisplayField) OrElse String.IsNullOrEmpty(pTableDisplayField), "", pTableDisplayField.ToLower)
        End Get
        Set(ByVal value As String)
            pTableDisplayField = value
            Me.PtGridLookUpEdit1.TableDisplayField = value
        End Set
    End Property

    Public Property TableValueMember() As String
        Get
            Return GetLowerCaseString(pTableValueMember) 'IIf(IsNothing(pTableValueMember) OrElse String.IsNullOrEmpty(pTableValueMember), "", pTableValueMember.ToLower)
        End Get
        Set(ByVal value As String)
            pTableValueMember = value
            Me.PtGridLookUpEdit1.TableValueMember = value
        End Set
    End Property


    <Category("CustomProperties")>
    Public Property TableFromString() As String
        Get
            Return GetLowerCaseString(pTableFromString) 'IIf(IsNothing(pTableFromString) OrElse String.IsNullOrEmpty(pTableFromString), "", pTableFromString.ToLower)
        End Get
        Set(ByVal value As String)
            pTableFromString = value
            Me.PtGridLookUpEdit1.TableFromString = value
        End Set
    End Property

    <Category("CustomProperties")>
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property TableColumnDefinitionString() As String
        Get
            Return GetLowerCaseString(pTableColumnDefinitionString) 'IIf(IsNothing(pTableColumnDefinitionString) OrElse String.IsNullOrEmpty(pTableColumnDefinitionString), "", pTableColumnDefinitionString.ToLower)
        End Get
        Set(ByVal value As String)
            pTableColumnDefinitionString = value
            Me.PtGridLookUpEdit1.TableColumnDefinitionString = value
        End Set
    End Property

    Private Sub PtGridLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PtGridLookUpEdit1.EditValueChanged
        RaiseEvent EditValueChanged()
    End Sub
End Class
