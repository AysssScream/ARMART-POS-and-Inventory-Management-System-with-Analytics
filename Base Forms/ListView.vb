Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports System.Data.Common
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports MySql.Data.MySqlClient

Imports Bunifu.UI.WinForms

Public Class ListView

    Private _SearchFormColumnDefinitionInfo As String
    Private _SearchFormTableFromInfo As String

    Private DetailGrid As DetailGrid
    Private DetailGridView As GridView

    Private MainNavigationData As DataSet
    Private MainNavigationColumnsInfo As Collection
    Private MainNavigationSQLQuery As String

    Public Event MainNavigationAdditionalWhere(ByRef AdditionalWhere As String)
    Private _AddNewForm As String
    Private _IsAddNewFormPopUp As Boolean
    Private _ShowEditButton As Boolean
    Private _ShowAddToCart As Boolean
    Private _ShowDeleteButton As Boolean
    Private _RecordPKCell As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.btnAddNew.FillColor = Colors.brand
        Me.btnPrint.FillColor = Colors.green
        Me.btnExcel.FillColor = Colors.green
        Me.lblHeaderTitle.Text = Me.lblHeaderTitle.Text.ToUpper
    End Sub

    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property SearchFormColumnDefinitionInfo() As String
        Get
            Return GetLowerCaseString(_SearchFormColumnDefinitionInfo)
        End Get
        Set(ByVal value As String)
            _SearchFormColumnDefinitionInfo = value
        End Set
    End Property

    Public Property SearchFormTableFromInfo() As String
        Get
            Return GetLowerCaseString(_SearchFormTableFromInfo)
        End Get
        Set(ByVal value As String)
            _SearchFormTableFromInfo = value
        End Set
    End Property

    Public Property AddNewForm() As String
        Get
            Return _AddNewForm
        End Get
        Set(ByVal value As String)
            _AddNewForm = value
        End Set
    End Property

    Public Property RecordPKCell() As String
        Get
            Return _RecordPKCell
        End Get
        Set(ByVal value As String)
            _RecordPKCell = value
        End Set
    End Property

    Public Property IsAddNewFormPopUp() As Boolean
        Set(ByVal value As Boolean)
            _IsAddNewFormPopUp = value
        End Set
        Get
            Return _IsAddNewFormPopUp
        End Get
    End Property


    <DefaultValue(False)>
    Public Property ShowEditButton() As Boolean
        Get
            Return _ShowEditButton
        End Get
        Set(ByVal value As Boolean)
            _ShowEditButton = value
        End Set
    End Property
    <DefaultValue(False)>
    Public Property ShowDeleteButton() As Boolean
        Get
            Return _ShowDeleteButton
        End Get
        Set(ByVal value As Boolean)
            _ShowDeleteButton = value
        End Set
    End Property
    <DefaultValue(False)>
    Public Property ShowAddToCart() As Boolean
        Get
            Return _ShowAddToCart
        End Get
        Set(ByVal value As Boolean)
            _ShowAddToCart = value
        End Set
    End Property

    Private Sub Lists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MainNavigationColumnsInfo = GetColumnInfo(Me.SearchFormColumnDefinitionInfo)
            BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BuildNavigationData()
        Try
            Dim searchText = Me.SearchBox.Text
            Dim searchWhere As String = "",
                sqlSelect As String = "",
                sqlFrom As String = "",
                sqlWhere As String = "",
                sqlOrderBy As String = "",
                sqlGroupBy As String = ""

            For Each col As ColumnInfo In MainNavigationColumnsInfo
                sqlSelect &= col.FieldName + ","
            Next

            sqlSelect = "SELECT " + sqlSelect.TrimEnd(",")

            Dim tmp() As String = Me.SearchFormTableFromInfo.Split("|")

            For i As Integer = 0 To UBound(tmp)
                If tmp(i) <> "" Then
                    With tmp(i).ToUpper
                        Select Case True
                            Case .Contains("FROM")
                                sqlFrom = tmp(i).Trim
                            Case .Contains("WHERE")
                                sqlWhere = tmp(i).Trim
                            Case .Contains("ORDER BY")
                                sqlOrderBy = tmp(i).Trim
                            Case .Contains("GROUP BY")
                                sqlGroupBy = tmp(i).Trim
                        End Select
                    End With
                End If
            Next

            Dim pQueryString As String
            Dim AdditionalCriteria As String
            'BUILD SQL QUERY STRING
            RaiseEvent MainNavigationAdditionalWhere(AdditionalCriteria)

            If Not IsEmptyString(Trim(sqlWhere)) Then
                If Not IsEmptyString(Trim(AdditionalCriteria)) Then
                    sqlWhere &= String.Format(" AND {0}", AdditionalCriteria)
                End If


            Else
                If Not IsEmptyString(Trim(AdditionalCriteria)) Then
                    sqlWhere = String.Format(" WHERE {0}", AdditionalCriteria)
                End If

            End If

            If Not IsEmptyString(searchText) Then
                Dim cnt = 0
                For Each col As ColumnInfo In MainNavigationColumnsInfo
                    If cnt = 0 Then
                        If IsEmptyString(Trim(sqlWhere)) Then
                            searchWhere &= " WHERE (" + col.FieldName + " LIKE '%" + searchText + "%'"
                        Else
                            searchWhere &= " AND (" + col.FieldName + " LIKE '%" + searchText + "%'"
                        End If
                    Else
                        searchWhere &= " OR " + col.FieldName + " LIKE '%" + searchText + "%'"
                    End If
                    cnt += 1
                Next
                searchWhere &= ")"
            End If

            pQueryString = String.Format("{0} {1} {2} {3} {4} {5}", sqlSelect, sqlFrom, sqlWhere, searchWhere, sqlGroupBy, sqlOrderBy)

            'Debug.Print(pQueryString)

            Using Connection As DbConnection = New MySqlConnection() ''DBFactory.GetConnection(AppData.DBProvider)
                Using tmpDbAdapter As DbDataAdapter = New MySqlDataAdapter() ''DBFactory.GetDataAdapter(AppData.DBProvider)
                    Try
                        Connection.ConnectionString = AppData.ConnectionString

                        With tmpDbAdapter
                            .SelectCommand = New MySqlCommand() ''DBFactory.GetCommand(AppData.DBProvider)
                            .SelectCommand.CommandType = CommandType.Text
                            .SelectCommand.CommandText = pQueryString
                            .SelectCommand.Connection = Connection
                            .SelectCommand.CommandTimeout = 5000
                        End With

                        MainNavigationData = New DataSet
                        MainNavigationData.Tables.Add("SearchGridData")
                        If Connection.State <> System.Data.ConnectionState.Open Then Connection.Open()
                        MainNavigationData.Tables("SearchGridData").BeginLoadData()
                        tmpDbAdapter.Fill(MainNavigationData, "SearchGridData")
                        MainNavigationData.Tables("SearchGridData").EndLoadData()
                        MainNavigationSQLQuery = pQueryString
                        'SourceQuery = pQueryString
                        'Return tmpData

                    Catch ex As Exception
                        MsgBox(ex)
                        'Return Nothing
                    Finally
                        If Not IsNothing(Connection) AndAlso
                            Connection.State <> System.Data.ConnectionState.Closed Then _
                                Connection.Close()
                    End Try
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Lists_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            SetNavigationData(MainNavigationColumnsInfo, MainNavigationData)
        Catch ex As Exception

        End Try
    End Sub

    Private IsAddedGridButton = False
    Public Sub SetNavigationData(ByVal ColumnsInfo As Collection, ByVal DataSource As DataSet)
        Try
            If Not IsNothing(ColumnsInfo) AndAlso Not IsNothing(DataSource) Then
                'SetGridDefaults()
                CreateDetailGridColumns(Me.sg_records, ColumnsInfo, Me)

                Try

                    Me.DetailGrid = CType(sg_records, DetailGrid)
                    DetailGridView = DirectCast(Me.DetailGrid.MainView, GridView)

                    AddHandler DetailGridView.RowCellClick, AddressOf RowCellClick

                    If Me.DetailGrid.ShowEditButton Then
                        Dim repUpdate As New RepositoryItemButtonEdit With {.Name = "updatebutton"}
                        DetailGrid.RepositoryItems.Add(repUpdate)
                        repUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
                        repUpdate.Buttons.Item(0).Tag = "update"
                        repUpdate.Buttons.Item(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
                        repUpdate.Buttons.Item(0).ImageOptions.Image = My.Resources.edit
                        repUpdate.Buttons.Item(0).EnableImageTransparency = True
                        repUpdate.ButtonsStyle = BorderStyles.NoBorder

                        AddHandler repUpdate.ButtonPressed, AddressOf RepItemButtonClick
                        Dim grdColumn = DetailGridView.Columns.AddField("")
                        With grdColumn
                            .Caption = ""
                            .Width = 20
                            .OptionsColumn.AllowSize = False
                            .OptionsColumn.FixedWidth = True
                            .VisibleIndex = DetailGridView.VisibleColumns.Count
                            .ColumnEdit = repUpdate
                            .ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
                            .UnboundType = DevExpress.Data.UnboundColumnType.String
                            .Visible = True
                        End With
                    End If

                    If Me.DetailGrid.ShowDeleteButton Then
                        Dim repDelete As New RepositoryItemButtonEdit With {.Name = "deletebutton"}
                        DetailGrid.RepositoryItems.Add(repDelete)
                        repDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
                        'repDelete.Buttons.Item(0).Kind = ButtonPredefines.Delete
                        repDelete.Buttons.Item(0).Tag = "delete"
                        repDelete.Buttons.Item(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
                        repDelete.Buttons.Item(0).ImageOptions.Image = My.Resources.delete
                        repDelete.Buttons.Item(0).EnableImageTransparency = True
                        repDelete.ButtonsStyle = BorderStyles.NoBorder

                        AddHandler repDelete.ButtonPressed, AddressOf RepItemButtonClick
                        Dim grdColumn = DetailGridView.Columns.AddField("")
                        With grdColumn
                            .Caption = ""
                            .Width = 20
                            .OptionsColumn.AllowSize = False
                            .OptionsColumn.FixedWidth = True
                            .VisibleIndex = DetailGridView.VisibleColumns.Count
                            .ColumnEdit = repDelete
                            .ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
                            .UnboundType = DevExpress.Data.UnboundColumnType.String
                            .Visible = True
                        End With
                    End If
                Catch ex As Exception

                End Try

                Me.sg_records.DataSource = DataSource
                Me.sg_records.DataMember = DataSource.Tables(0).TableName
                Me.sg_records.RefreshDataSource()
            Else
            End If

        Catch ex As Exception

        End Try
    End Sub

    Protected Overridable Sub RepItemButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        BuildNavigationData()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        SetNavigationData(MainNavigationColumnsInfo, MainNavigationData)
    End Sub

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Try
            BuildNavigationData()
            SetNavigationData(MainNavigationColumnsInfo, MainNavigationData)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Try
            Dim FormName = Me.AddNewForm
            Dim childForm = New Form

            Dim FullTypeName As String
            Dim FormInstanceType As Type

            FullTypeName = "NewTemplate." + Me.AddNewForm
            FormInstanceType = Type.GetType(FullTypeName, True, True)
            childForm = Activator.CreateInstance(FormInstanceType)
            childForm.Text = FormName

            If Me.IsAddNewFormPopUp = True Then
                Dim oform As Form
                oform = childForm
                If oform.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    With sg_records
                        .Refresh()
                    End With

                End If
            Else
                AppMainForm.OpenChildForm(FormName, Me.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub GridView3_DoubleClick(sender As Object, e As EventArgs) Handles GridView3.DoubleClick
        Try
            With sg_records
                If .DisplayOnly = False Then
                    .RowPosition = GridView3.FocusedRowHandle
                    AppMainForm.OpenChildForm(Me.AddNewForm, Me.Text, .Field((Me.RecordPKCell).ToString))
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Overridable Sub RowCellClick(sender As Object, e As RowCellClickEventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            Dim sd As New SaveFileDialog
            sd.Filter = "Excel Files (*.xls)|*.xls|All files (*.*)|*.*"
            sd.FilterIndex = 1
            sd.RestoreDirectory = True
            sd.FileName = Me.Text

            If sd.ShowDialog() = DialogResult.OK Then
                sg_records.ExportToXls(sd.FileName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        sg_records.ShowRibbonPrintPreview()
    End Sub

    Private Sub SearchBox_IconRightClick(sender As Object, e As EventArgs) Handles SearchBox.IconRightClick
        Try
            BuildNavigationData()
            SetNavigationData(MainNavigationColumnsInfo, MainNavigationData)
        Catch ex As Exception

        End Try
    End Sub
End Class
