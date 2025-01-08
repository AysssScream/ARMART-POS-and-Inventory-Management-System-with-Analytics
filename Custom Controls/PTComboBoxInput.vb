Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports System.Threading
Imports System.Data.Common

Public Class PTComboBoxInput : Inherits ComboBoxEdit
    Private Delegate Sub PrepareComboDataDelegate()

    Private LoadComboDataDelegate As PrepareComboDataDelegate
    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean
    Private pQuery As String
    Private pQueryFrom As String
    Private pFieldSource As String
    Private pData As New DataSet
    Private pDataSourceCustom As String
    Private pUseCustomData As Boolean
    Private pDropDownSizeable As Boolean
    Private pAdditionalWhere As String
    Private LoadStarted As Boolean = False
    Private FieldName As String
    Private LoaderThread As Thread
    Private LoaderThreadStart As New ThreadStart(AddressOf GetData)

    Public Sub New()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()

        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()

        Me.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Properties.AppearanceDropDown.Options.UseFont = True
        Me.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.Properties.AutoHeight = False
        Me.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.Size = New System.Drawing.Size(200, 24)
    End Sub

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

    <DefaultValue(False)>
    Public Property RetainValue() As Boolean
        Get
            Return pRetainValue
        End Get
        Set(ByVal value As Boolean)
            pRetainValue = value
        End Set
    End Property

    Public Property AdditionalWhere() As String
        Get
            Return GetLowerCaseString(pAdditionalWhere)
        End Get
        Set(ByVal value As String)
            pAdditionalWhere = value
        End Set
    End Property


    <DefaultValue(False)>
    Public Property DataSourceUseCustom() As Boolean
        Get
            Return pUseCustomData
        End Get
        Set(ByVal value As Boolean)
            pUseCustomData = value
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
        End Set
    End Property

    <DefaultValue(False)>
    Public Property DropDownSizeable() As Boolean
        Get
            Return pDropDownSizeable
        End Get
        Set(ByVal value As Boolean)
            pDropDownSizeable = value
        End Set
    End Property

    Private Sub LoadDefaultProperties()
        Try
            If Me.FindForm.InvokeRequired Then
                Me.FindForm.Invoke(New PrepareComboDataDelegate(AddressOf LoadDefaultProperties))
            Else
                With Me.Properties
                    .TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
                    .ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.SingleClick
                    .HighlightedItemStyle = HighlightStyle.Default
                    .DropDownItemHeight = 0
                    .PopupSizeable = Me.DropDownSizeable
                    .AutoComplete = True
                    .HotTrackItems = True
                End With
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub LoadCustomData()
        Try
            If Me.FindForm.InvokeRequired Then
                Me.FindForm.Invoke(New PrepareComboDataDelegate(AddressOf Me.LoadCustomData))
            Else
                Dim lstItems() As String = pDataSourceCustom.Split("|")
                Me.Properties.Items.Clear()
                If Not IsNothing(lstItems) Then
                    For i As Integer = 0 To UBound(lstItems)

                        If Not String.IsNullOrEmpty(lstItems(i).ToString.Trim) Then Me.Properties.Items.Add(lstItems(i).ToString.Trim)

                    Next
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadComboData()
        Try
            LoadDefaultProperties()
            If pUseCustomData Then
                If Not String.IsNullOrEmpty(pDataSourceCustom) Then
                    LoadCustomData()
                End If
            Else
                If Not IsEmptyString(Me.TableField) AndAlso Not IsEmptyString(Me.TableName) Then
                    BuildComboSourceQry()
                    GetData()
                    LoadComboItems()
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Public Sub LoadData()
        Try
            LoadComboDataDelegate = New PrepareComboDataDelegate(AddressOf Me.LoadComboData)
            LoadComboDataDelegate.BeginInvoke(Nothing, Nothing)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GetData()

        Dim tblQuery As String = "" 'pTableQuery.Item(TableName)
        Dim tmpCommand As DbCommand
        Dim tmpConnection As DbConnection
        Dim tmpDataAdapter As DbDataAdapter
        Try

            tmpConnection = DBFactory.GetConnection(AppData.DBProvider)
            tmpConnection.ConnectionString = AppData.ConnectionString

            tmpCommand = DBFactory.GetCommand(AppData.DBProvider)
            tmpCommand.CommandText = pQuery
            tmpCommand.Connection = tmpConnection
            tmpCommand.CommandTimeout = 5000

            tmpDataAdapter = DBFactory.GetDataAdapter(AppData.DBProvider)
            tmpDataAdapter.SelectCommand = tmpCommand

            tmpDataAdapter.Fill(pData)


        Catch ex As Exception
            'Throw (New Exception(ex.Message))
        Finally
            If Not tmpCommand Is Nothing Then tmpCommand.Dispose()
            If Not tmpConnection Is Nothing Then tmpConnection.Dispose()
            If Not tmpDataAdapter Is Nothing Then tmpDataAdapter.Dispose()
        End Try

        'With Data
        '    .CallSource = "ComboInput:" + Me.Name + " - GetData"
        '    pData = .GetDataSet(pQuery)
        'End With


        'Invoke(New CallCrossThreadMethod(AddressOf Me.LoadComboItems))

    End Sub

    Private Sub LoadComboItems()

        Try
            If Me.FindForm.InvokeRequired Then
                Me.FindForm.Invoke(New PrepareComboDataDelegate(AddressOf Me.LoadComboItems))
            Else
                With Me.Properties.Items
                    .Clear()
                    If pData.Tables(0).Rows.Count > 0 Then
                        For Each row As DataRow In pData.Tables(0).Rows
                            Dim item As String = row.Item(FieldName).ToString
                            If Not IsEmptyString(item) Then
                                .Add(ProperCase(item))
                            End If
                        Next
                    End If
                End With
            End If

        Catch ex As Exception
        Finally
            If Not pData Is Nothing Then pData.Dispose()
        End Try


    End Sub

    Private Sub BuildComboSourceQry()
        Try
            Dim tmpFrom As String = "",
         tmpWhere As String = "",
         tmpOrderBy As String = ""
            FieldName = Me.TableField
            If FieldName.Contains(".") Then
                FieldName = FieldName.Split(".")(1)
            End If
            Dim TableName As String = Me.TableName
            If TableName.ToLower.Contains(" as ") Then
                TableName = TableName.Split(" ")(0)
            End If
            pQuery = String.Format("SELECT DISTINCT({0})", FieldName)
            tmpOrderBy = "ORDER BY " + FieldName

            If TypeOf (Me.FindForm) Is CRUDBase Then
                Dim myEditor As CRUDBase = DirectCast(Me.FindForm, CRUDBase)
                Dim pkCtrl As PTTextInput = DirectCast(myEditor.PKControl, PTTextInput)
                Dim modCtrl As PTTextInput = DirectCast(myEditor.ModuleControl, PTTextInput)
                Dim modTypeCtrl As PTTextInput = DirectCast(myEditor.ModuleTypeControl, PTTextInput)

                tmpFrom = "FROM " + TableName

                If TableName = pkCtrl.TableName Then
                    tmpWhere = ""
                    If Not IsEmptyString(modCtrl.TableName) AndAlso Not IsEmptyString(modCtrl.TableField) Then
                        tmpWhere += String.Format("WHERE {0}={1} ", modCtrl.TableField, AddQuote9(modCtrl.Text))
                    End If

                    If Not IsEmptyString(modTypeCtrl.TableName) AndAlso Not IsEmptyString(modTypeCtrl.TableField) Then
                        tmpWhere += String.Format("{0} {1}={2}", IIf(tmpWhere <> "", "AND", "WHERE"), modTypeCtrl.TableField, AddQuote9(modTypeCtrl.Text))

                        If Me.AdditionalWhere <> "" Then tmpWhere += Me.AdditionalWhere

                    End If
                End If
                'ElseIf TypeOf (Me.FindForm) Is ReportFormBase Then
                '    tmpFrom = "FROM " + TableName
                '    tmpWhere = IIf(Me.AdditionalWhere <> "", "WHERE " + Me.AdditionalWhere, "")
            Else
                tmpFrom = "FROM " + TableName
            End If



            pQuery = String.Format("{0} {1} {2} {3}", pQuery, tmpFrom, tmpWhere, tmpOrderBy)
        Catch ex As Exception

        End Try

    End Sub

End Class
