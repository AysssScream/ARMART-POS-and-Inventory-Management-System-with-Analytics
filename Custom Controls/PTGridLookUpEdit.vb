Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.Threading
Imports System.Data.Common
Imports DevExpress.XtraEditors.Repository
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors.Controls

Public Class PTGridLookupEdit : Inherits DevExpress.XtraEditors.GridLookUpEdit
    Private isButtonClicked As Boolean = True

    Private Delegate Sub PrepareGridDelegate()

    Private DataLoadDelegate As PrepareGridDelegate

    Private LoadStarted As Boolean = False
    Private pData As DataTable
    Private pDataView As DataView
    Private pDataAdapter As DbDataAdapter
    Private pQueryString As String
    Private pColumns As Collection
    Private pTableDisplayField As String
    Private pTableName As String
    Private pTableField As String
    Private pRetainValue As Boolean
    Private pTableFromString As String
    Private pTableColumnDefinitionString As String
    Private pTableValueMember As String
    Private pUsePoUpWidth As Boolean
    Private pPopUpWidth As Integer
    Private pPopUpWidthMult As Integer

    Private LoaderThread As Thread
    'Private LoaderThreadStart As New ThreadStart(AddressOf GetData)
    Private currFilter As String

    Private IsFirstLoad As Boolean = True
    Public Event AdditionalWhere(ByRef Criteria As String)

    Public Sub New()

        Me.PopUpWidth = 400
        Me.PopUpWidthMult = 3
        Me.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Properties.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Properties.Appearance.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Properties.Appearance.Options.UseBackColor = True
        Me.Properties.Appearance.Options.UseBorderColor = True
        Me.Properties.Appearance.Options.UseFont = True
        Me.Properties.Appearance.Options.UseForeColor = True
        Me.Properties.AppearanceDisabled.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceDisabled.BackColor2 = System.Drawing.SystemColors.ControlLightLight
        Me.Properties.AppearanceDisabled.BorderColor = System.Drawing.SystemColors.ControlLight
        Me.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Verdana", 8.5!)
        Me.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.DimGray
        Me.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.Properties.AppearanceDisabled.Options.UseFont = True
        Me.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Properties.AppearanceDropDown.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Properties.AppearanceDropDown.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Properties.AppearanceDropDown.Options.UseBackColor = True
        Me.Properties.AppearanceDropDown.Options.UseBorderColor = True
        Me.Properties.AppearanceFocused.BackColor = System.Drawing.Color.White
        Me.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.White
        Me.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.White
        Me.Properties.AppearanceReadOnly.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.DimGray
        Me.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Properties.AppearanceReadOnly.Options.UseBorderColor = True
        Me.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.Properties.AutoHeight = False
        Me.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Size = New System.Drawing.Size(200, 24)
        Me.TabIndex = 2
        Me.TableField = ""
        Me.TableName = ""
        Me.UsePoUpSize = True
    End Sub

#Region "Custom Properties"
    Private _RefreshOnFilterChange As Boolean
    <DefaultValue(False)>
    Public Property RefreshOnFilterChange() As Boolean
        Get
            Return _RefreshOnFilterChange
        End Get
        Set(ByVal value As Boolean)
            _RefreshOnFilterChange = value
        End Set
    End Property

    Public Property TableName() As String
        Get
            Return GetLowerCaseString(pTableName)
        End Get
        Set(ByVal value As String)
            pTableName = value
        End Set
    End Property

    Public Property TableField() As String
        Get
            Return GetLowerCaseString(pTableField)
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

    <Category("CustomProperties")>
    Public Property TableFromString() As String
        Get
            Return GetLowerCaseString(pTableFromString)
        End Get
        Set(ByVal value As String)
            pTableFromString = value
        End Set
    End Property

    <Category("CustomProperties")>
    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property TableColumnDefinitionString() As String
        Get
            Return GetLowerCaseString(pTableColumnDefinitionString)
        End Get
        Set(ByVal value As String)
            pTableColumnDefinitionString = value
        End Set
    End Property

    Public Property TableDisplayField() As String
        Get
            Return GetLowerCaseString(pTableDisplayField)
        End Get
        Set(ByVal value As String)
            pTableDisplayField = value

        End Set
    End Property

    Public Property TableValueMember() As String
        Get
            Return GetLowerCaseString(pTableValueMember)
        End Get
        Set(ByVal value As String)
            pTableValueMember = value
        End Set
    End Property

    <DefaultValue(False)>
    Public Property UsePoUpSize() As Boolean
        Get
            Return pUsePoUpWidth
        End Get
        Set(ByVal value As Boolean)
            pUsePoUpWidth = value
        End Set
    End Property

    Public Property PopUpWidth() As Integer
        Get
            Return pPopUpWidth
        End Get
        Set(ByVal value As Integer)
            pPopUpWidth = value
        End Set
    End Property

    Public Property PopUpWidthMult() As Integer
        Get
            Return pPopUpWidthMult
        End Get
        Set(ByVal value As Integer)
            pPopUpWidthMult = value
        End Set
    End Property

    Public ReadOnly Property GetColumns() As Collection
        Get
            Return pColumns
        End Get
    End Property

    Private _AdditionalFilter As String
    Friend WithEvents fProperties As RepositoryItemGridLookUpEdit
    Friend WithEvents fPropertiesView As GridView
    Friend WithEvents GridView1 As GridView
    Friend WithEvents GridView2 As GridView
    Private isReloadFromFilterChange As Boolean
    Public Property AdditionalFilter() As String
        Get
            Return _AdditionalFilter
        End Get
        Set(ByVal value As String)
            If value <> _AdditionalFilter Then
                _AdditionalFilter = value
                isReloadFromFilterChange = True
                Me.LoadData()
            End If

        End Set
    End Property

    Private Sub BuildGridData()
        Try

            If Not IsEmptyString(Me.TableFromString) AndAlso Not IsEmptyString(Me.TableColumnDefinitionString) Then
                If IsFirstLoad Then
                    SetGridDefaults()
                    CreateGridColumns()

                End If

                'EMPTY DATASOURCE & REMOVE ALL COLUMNS

                'Application.DoEvents()
                BuildQueryString()
                GetData()
                BindDataSourceToGrid()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Sub LoadData(Optional ByVal async As Boolean = True)
        Try
            'If async Then
            '    DataLoadDelegate = New PrepareGridDelegate(AddressOf Me.BuildGridData)
            '    DataLoadDelegate.BeginInvoke(Nothing, Nothing)
            'Else
            BuildGridData()
            'End If

        Catch ex As Exception
            Me.BackColor = origBackColor
        End Try

    End Sub

    Private Sub SetGridDefaults()
        Try
            If Me.FindForm.InvokeRequired Then
                Me.FindForm.Invoke(New PrepareGridDelegate(AddressOf Me.SetGridDefaults))
            Else
                Me.Properties.PopupFilterMode = PopupFilterMode.Contains
                Me.Properties.ImmediatePopup = True
                'me.Properties.AutoComplete = True
                With CType(Me.Properties.View, GridView)

                    With .OptionsView
                        .EnableAppearanceEvenRow = False
                        .EnableAppearanceOddRow = True
                        .ShowGroupPanel = False
                        .ShowColumnHeaders = True
                        .ShowAutoFilterRow = True
                        .ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                        .ShowFooter = False                             'set to enable if need to display summaries
                        .NewItemRowPosition = NewItemRowPosition.None   'change to NewItemRowPosition.Bottom for adding new rows
                    End With
                    With .OptionsMenu
                        .EnableColumnMenu = False
                        .EnableGroupPanelMenu = False
                        .EnableFooterMenu = False
                    End With
                    With .OptionsBehavior
                        .AutoPopulateColumns = False

                        .Editable = False
                        .EditorShowMode = DevExpress.Utils.EditorShowMode.Default
                    End With

                    .OptionsCustomization.AllowFilter = True
                    .OptionsNavigation.AutoFocusNewRow = True
                    .FocusRectStyle = DrawFocusRectStyle.RowFocus
                    With .OptionsSelection
                        .EnableAppearanceFocusedCell = True
                        .EnableAppearanceFocusedRow = True

                    End With
                    With .Appearance.FocusedRow
                        .BackColor = Color.White
                        .BackColor2 = Color.LightBlue
                        .GradientMode = Drawing2D.LinearGradientMode.Vertical
                        .ForeColor = Color.Black
                        .Font = New Font(.Font.Name, 8.25, FontStyle.Bold)
                    End With

                    .ColumnPanelRowHeight = 40 '20
                    With .Appearance.HeaderPanel
                        .Options.UseTextOptions = True
                        .TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap

                        .TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
                        '.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
                    End With
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CreateGridColumns()
        Try
            If Me.FindForm.InvokeRequired Then
                Me.FindForm.Invoke(New PrepareGridDelegate(AddressOf Me.CreateGridColumns))
            Else
                Dim columnView As GridView = CType(Me.Properties.View, GridView)
                With columnView
                    .Columns.Clear()

                    If Not IsEmptyString(Me.TableColumnDefinitionString) Then
                        pColumns = GetColumnInfo(Me.TableColumnDefinitionString)

                        If Not IsNothing(pColumns) Then
                            For Each col As ColumnInfo In pColumns
                                With .Columns.AddField(col.FieldName)
                                    .OptionsColumn.FixedWidth = False
                                    If col.Caption.ToUpper.Contains("\") Then
                                        .Caption = col.Caption.ToUpper.Split("\")(0) & Global.Microsoft.VisualBasic.ChrW(10) & col.Caption.ToUpper.Split("\")(1)
                                    Else
                                        .Caption = col.Caption.ToUpper
                                    End If
                                    '.Caption = col.Caption.ToUpper
                                    .Width = col.Width
                                    If Not IsEmptyString(col.Format) Then
                                        .DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
                                        .DisplayFormat.FormatString = col.Format
                                    End If

                                    .Visible = IIf(col.Width > 0, True, False)
                                    'add code for generating Summaries or comboedits
                                    .OptionsFilter.AutoFilterCondition = IIf(col.Format <> "", AutoFilterCondition.Default, AutoFilterCondition.Contains)

                                End With

                            Next

                        End If
                    End If

                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub ClearFilters()
        pDataView.RowFilter = ""
    End Sub

    Public Sub SetFilter(ByVal FilterExpression As String)
        Try
            pDataView.RowFilter = FilterExpression.ToLower
            currFilter = FilterExpression.ToLower
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetData()
        Try
            Using tmpCommand As DbCommand = New MySqlCommand()
                Using tmpConnection As DbConnection = New MySqlConnection()
                    Try

                        tmpConnection.ConnectionString = AppData.ConnectionString

                        tmpCommand.CommandText = pQueryString
                        tmpCommand.Connection = tmpConnection
                        tmpCommand.CommandTimeout = 5000

                        pDataAdapter = New MySqlDataAdapter()
                        pDataAdapter.SelectCommand = tmpCommand

                        If Not IsNothing(pData) Then
                            pData.Clear()
                        Else
                            pData = New DataTable
                        End If


                        pData.BeginLoadData()
                        pDataAdapter.Fill(pData)
                        pData.EndLoadData()

                    Catch ex As Exception
                        Clipboard.SetText(ex.Message + vbCrLf + ex.StackTrace, TextDataFormat.Text)
                    Finally
                        If Not tmpCommand Is Nothing Then tmpCommand.Dispose()
                        If Not tmpConnection Is Nothing Then tmpConnection.Dispose()
                    End Try
                End Using

            End Using
        Catch ex As Exception

        End Try
    End Sub
    Private origBackColor As Color
    Private Sub BindDataSourceToGrid()
        Try
            If Me.FindForm.InvokeRequired Then
                Me.FindForm.Invoke(New PrepareGridDelegate(AddressOf Me.BindDataSourceToGrid))
            Else
                Me.BackColor = origBackColor
                'Dim dvMain As DataView
                'Dim dvm As New DataViewManager(pData)
                'dvMain = dvm.CreateDataView(pData.Tables(0))
                pDataView = New DataView(pData)
                'pDataView.
                Me.Properties.DataSource = pDataView 'pData.Tables(0) 'dvMain
                Me.Properties.AutoComplete = True
                Me.Properties.NullText = ""
                Me.Properties.NullValuePrompt = ""
                Me.Properties.DisplayMember = Me.TableDisplayField.ToLower
                Me.Properties.ValueMember = Me.TableValueMember.ToLower

                If IsFirstLoad Then IsFirstLoad = False
                If isReloadFromFilterChange Then isReloadFromFilterChange = False
            End If
        Catch ex As Exception
            Me.BackColor = origBackColor
        End Try


    End Sub

    Private Sub BuildQueryString()
        Try
            Dim sqlSelect As String = "", sqlFrom As String = "", sqlWhere As String = "", sqlGroupBy As String = "", sqlOrderBy As String = "", sqlAdditionalCriteria As String = ""
            For Each col As ColumnInfo In pColumns

                'If Me.GridMode <> GridModeEnum.Navigation Then
                'If col.FieldName.Contains(MainTableSuffix) Then sqlSelect += col.FieldName + ","
                'Else
                sqlSelect &= col.FieldName + ","
                'End If

            Next

            'added for joined tables
            Dim columnView As GridView = CType(Me.Properties.View, GridView)
            With columnView
                For Each col As GridColumn In .Columns
                    If col.FieldName.ToLower.Contains(" as ") Then
                        col.FieldName = col.FieldName.Split(" ")(2)
                    End If
                Next
            End With


            sqlSelect = "SELECT " + sqlSelect.TrimEnd(",")
            '''''''''''''''''BUILD QUERY'''''''''''''''''
            'Build FROM SQL
            Dim tmp() As String = TableFromString.Split("|")

            For i As Integer = 0 To UBound(tmp)
                If tmp(i) <> "" Then
                    With tmp(i).ToUpper
                        Select Case True
                            Case .Contains("FROM")
                                sqlFrom = tmp(i).Trim
                            Case .Contains("WHERE")
                                sqlWhere = tmp(i).Trim
                            Case .Contains("GROUP BY")
                                sqlGroupBy = tmp(i).Trim
                            Case .Contains("ORDER BY")
                                sqlOrderBy = tmp(i).Trim
                        End Select
                    End With
                End If
            Next

            'BUILD SQL QUERY STRING
            'sqlAdditionalCriteria = ""
            'raise AdditionalWhere event only if not building query for AdditionalFilter value changed
            If Not isReloadFromFilterChange Then RaiseEvent AdditionalWhere(Me.AdditionalFilter)


            If Not IsEmptyString(Trim(sqlWhere)) Then

                If Not IsEmptyString(Trim(Me.AdditionalFilter)) Then sqlWhere += " AND " + Me.AdditionalFilter

            Else
                If Not IsEmptyString(Trim(Me.AdditionalFilter)) Then sqlWhere = "WHERE " + Me.AdditionalFilter
            End If


            pQueryString = String.Format("{0} {1} {2} {3} {4}", sqlSelect, sqlFrom, sqlWhere, sqlGroupBy, sqlOrderBy)
            'pQueryString = pQueryString.ToLower.Replace(CompanyName, AddQuote9(Project.Instance.CompanyGroup))
        Catch ex As Exception

        End Try

    End Sub
#End Region

    Private Sub GridLookupEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EditValueChanged


    End Sub



    Private Sub GridLookupEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
                Me.EditValue = Nothing
            ElseIf e.KeyCode = Keys.F11 Then
                If UserName = "" Then
                    Try
                        XtraMessageBox.Show(pQueryString)
                        Clipboard.SetText(pQueryString, TextDataFormat.Text)
                    Catch ex As Exception

                    End Try
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub InitializeComponent()

    End Sub

    Private Sub GridLookupEdit_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles Me.QueryPopUp
        Try
            BuildGridData()
            If currFilter <> "" Then pDataView.RowFilter = currFilter.ToLower
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReloadData()

        'RaiseEvent AdditionalWhere(Me.AdditionalFilter)
        ' LoadData()
        ' Dim pquerywhere As String = String.Format("{0} {1} {2} {3} {4}", sqlSelect, sqlFrom, sqlWhere+= " AND " + Me.AdditionalFilter, sqlGroupBy, sqlOrderBy)
        'Dim mydt As DataTable = AppData.GetDataTable(pQueryString)

        'Dim rcount As Integer = mydt.Rows.Count

        'If rcount > pData.Rows.Count Then
        BuildGridData()
        'End If

    End Sub
End Class


