Imports System.ComponentModel
Imports System.ComponentModel.Design


Public Class PTUserPKInput : Inherits PTTextInput

    Private pPrefix As String = ""
    Private pWhere As String = ""
    Private pAddWhere As String = ""
    Private pQuery As String = ""
    Private _UserPKType As UserPkTypeEnum
    Private _UseBaseForm As Boolean
    Private _AdditionalWhere As String
    Private _UseGroupDate As Boolean
    Public Event AdditionalWhere(ByRef Criteria As String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder

    End Sub

    Public Enum UserPkTypeEnum
        System
        Custom
    End Enum

    <DefaultValue(False)>
    Public Property UseBaseForm() As Boolean
        Get
            Return _UseBaseForm
        End Get
        Set(ByVal value As Boolean)
            _UseBaseForm = value
        End Set
    End Property

    Public Property Prefix() As String
        Get
            Return pPrefix
        End Get
        Set(ByVal value As String)
            pPrefix = value
        End Set
    End Property

    Public Property UseGroupDate() As Boolean
        Get
            Return _UseGroupDate
        End Get
        Set(ByVal value As Boolean)
            _UseGroupDate = value
        End Set
    End Property

    Public Property AddWhere() As String
        Get
            Return pAddWhere
        End Get
        Set(ByVal value As String)
            pAddWhere = value
        End Set
    End Property

    Public Property Where() As String
        Get
            Return pWhere
        End Get
        Set(ByVal value As String)
            pWhere = value
        End Set
    End Property

    <DefaultValue(UserPkTypeEnum.System)>
    Public Property UserPKType() As UserPkTypeEnum
        Get
            Return _UserPKType
        End Get
        Set(ByVal value As UserPkTypeEnum)
            _UserPKType = value
            If UserPKType = UserPkTypeEnum.System Then
                Me.ReadOnly = True
            Else
                Me.ReadOnly = False
            End If
        End Set
    End Property

    Public Sub GenerateUserPK()
        _AdditionalWhere = ""
        pQuery = ""
        Dim Prefix = ""
        Dim PrefixDate As DateTime
        Try
            If Me.UseGroupDate Then
                Dim date_p As DateTime = Now
                Prefix = date_p.ToString("yyyyMMdd")
                PrefixDate = date_p.ToString("yyyy-MM-dd")
            End If
            If Me.UserPKType <> UserPkTypeEnum.Custom Then
                Dim userPK As Object, userPKString As String
                If String.IsNullOrEmpty(pQuery) Then

                    Dim OwnerForm As CRUDBase = DirectCast(Me.FindForm, CRUDBase)
                    'If AppData.DBProvider = DataProviderType.Mysql Then

                    Dim UserPKWhere As String = "" ''Me.TableField + " REGEXP '^[0-9]+$' "
                    AdditionalWhere9(OwnerForm.txtModule, UserPKWhere)
                    AdditionalWhere9(OwnerForm.txtModuleType, UserPKWhere)

                    'RaiseEvent AdditionalWhere(_AdditionalWhere)

                    If AddWhere <> String.Empty Then
                        AdditionalWhere9(Me.AddWhere, UserPKWhere)
                    End If
                    pQuery = String.Format("SELECT {0} FROM {1} WHERE {2} ", Me.TableField, Me.TableName, UserPKWhere)

                End If
                RaiseEvent AdditionalWhere(_AdditionalWhere)
                'If _AdditionalWhere <> "FK_branch_transh=''" Then
                pQuery = pQuery & IIf(Me._AdditionalWhere <> String.Empty, " AND " & Me._AdditionalWhere, "")
                pQuery = pQuery & IIf(Me.UseGroupDate, String.Format(" AND Date_TransH LIKE '%{0}%' AND UserPK_TransH LIKE '{1}%' AND UserPK_TransH NOT LIKE 'E%'", PrefixDate.ToString("yyyy-MM-dd"), Prefix), "")
                pQuery = pQuery & " ORDER BY ID_TransH DESC LIMIT 1"
                'End If

                Dim dt As DataTable = AppData.GetDataTable(pQuery)
                If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                    userPK = dt.Rows(0).Item(0)
                End If


                If IsNothing(userPK) Or IsDBNull(userPK) Or userPK = "" Then
                    If Me.UseGroupDate Then
                        userPKString = Me.Prefix + Prefix + CStr(1)
                    Else
                        userPKString = Me.Prefix + CStr(1)
                    End If
                Else
                    If Me.UseGroupDate Then
                        Dim seriesNo = CInt(userPK.ToString.Replace(Prefix, ""))
                        userPKString = CStr(seriesNo + 1)
                        userPKString = Me.Prefix + Prefix + userPKString
                    Else
                        userPK = IIf(Not IsNothing(Me.Prefix), userPK.ToString.Split("-")(1), userPK)
                        userPKString = Me.Prefix + CStr(StrVal9(userPK) + 1)
                    End If
                End If
                Me.Text = userPKString
            Else
                'Me.EditValue = Nothing
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub UserPKInput_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlAdded
        With Me
            .ReadOnly = True
        End With
    End Sub
End Class
