Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports DevExpress.XtraGrid.Columns
Imports System.Data.Common
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Public Class SearchFormBase
    Private Delegate Function BuildDataAsyncDelegate() As DataSet
    Public Event AdditionalWhere(ByRef Criteria As String)
    Public Event RecordSelected(ByVal RecordPK As String)

    Protected pColumns As Collection
    Private AdditionalCriteria As String
    Private pQueryString As String
    Protected pData As DataSet

    Protected WithEvents pGridView As DetailGrid
    Private pCreateDataSourceAsyncDelegate As BuildDataAsyncDelegate
    Private _DefaultFocusedColumn As String
    Private _ColumnDefinitionInfo As String
    Private _TableFromInfo As String
    Protected DataLoaded As Boolean = False
    Private LayoutFileName As String
    Protected SourceQuery As String
    Private pkField As String
    '======================
    Private WithEvents bgw As New BackgroundWorker
    Private LoadDataInProgress As Boolean = False

    Private moduleCtrl As Control
    Private moduleTypeCtrl As Control

    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property ColumnDefinitionInfo() As String
        Get
            Return _ColumnDefinitionInfo
        End Get
        Set(ByVal value As String)
            _ColumnDefinitionInfo = value
        End Set
    End Property

    Public Property TableFromInfo() As String
        Get
            Return _TableFromInfo
        End Get
        Set(ByVal value As String)
            _TableFromInfo = value
        End Set
    End Property

    Public Property AdditionalFilter() As String
        Get
            Return AdditionalCriteria
        End Get
        Set(ByVal value As String)
            AdditionalCriteria = value
        End Set
    End Property

    Public Property DefaultFocusedColumn() As String
        Get
            Return _DefaultFocusedColumn
        End Get
        Set(ByVal value As String)
            _DefaultFocusedColumn = value
        End Set
    End Property

    Public Sub New(ByVal ColumnDefinitionInfo As String, ByVal TableFromInfo As String, Optional ByVal _moduleCtrl As Control = Nothing, Optional ByVal _moduletypeCtrl As Control = Nothing)

        InitializeComponent()
        If Not Me.DesignMode Then
            Try

                Me.ColumnDefinitionInfo = ColumnDefinitionInfo
                Me.TableFromInfo = TableFromInfo
                moduleCtrl = _moduleCtrl
                moduleTypeCtrl = _moduletypeCtrl
                pGridView = DirectCast(Me.SearchGrid, DetailGrid)
                SetGridDefaults()
                If Not IsEmptyString(Me.ColumnDefinitionInfo) Then pColumns = GetColumnInfo(Me.ColumnDefinitionInfo)
            Catch ex As Exception

            End Try
        End If

        ' Add any initialization after the InitializeComponent() call.

        Me.FormBorderStyle = FormBorderStyle.None

    End Sub

    Private Sub SetGridDefaults()

    End Sub

    Private Sub BuildQueryString()
        If pColumns IsNot Nothing Then
            Dim searchWhere As String = "",
                sqlSelect As String = "",
                sqlFrom As String = "",
                sqlWhere As String = "",
                sqlGroupBy As String = "",
                sqlOrderBy As String = ""

            For Each col As ColumnInfo In pColumns
                sqlSelect &= col.FieldName + ","
            Next

            sqlSelect = "SELECT " + sqlSelect.TrimEnd(",")

            Dim tmp() As String = Me.TableFromInfo.Split("|")

            For i As Integer = 0 To UBound(tmp)
                If tmp(i) <> "" Then
                    With tmp(i).ToUpper
                        Select Case True
                            Case .Contains("SELECT")
                                sqlSelect = tmp(i).Trim
                            Case .Contains("FROM ")
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

            'BUILD SQL QUERY STRING
            RaiseEvent AdditionalWhere(AdditionalCriteria)
            If Not IsEmptyString(Trim(sqlWhere)) Then
                If Not IsEmptyString(Trim(AdditionalCriteria)) Then sqlWhere &= " AND " + AdditionalCriteria
            Else
                If Not IsEmptyString(Trim(AdditionalCriteria)) Then sqlWhere = "WHERE " + AdditionalCriteria
            End If

            Try
                If Not IsNothing(moduleCtrl) AndAlso Not IsEmptyString(DirectCast(moduleCtrl, PTTextInput).TableField) AndAlso Not IsEmptyString(DirectCast(moduleCtrl, PTTextInput).Text) Then
                    sqlWhere &= String.Format(" AND  {2}.{0}='{1}'", CType(moduleCtrl, PTTextInput).TableField, CType(moduleCtrl, PTTextInput).Text, CType(moduleCtrl, PTTextInput).TableName)
                End If
            Catch ex As Exception

            End Try

            Try
                If Not IsNothing(moduleTypeCtrl) AndAlso Not IsEmptyString(DirectCast(moduleTypeCtrl, PTTextInput).TableField) AndAlso Not IsEmptyString(DirectCast(moduleTypeCtrl, PTTextInput).Text) Then
                    sqlWhere &= String.Format(" AND  {2}.{0}='{1}'", CType(moduleTypeCtrl, PTTextInput).TableField, CType(moduleTypeCtrl, PTTextInput).Text, CType(moduleTypeCtrl, PTTextInput).TableName)
                End If
            Catch ex As Exception

            End Try

            pQueryString = String.Format("{0} {1} {2} {3} {4}", sqlSelect, sqlFrom, sqlWhere, sqlGroupBy, sqlOrderBy)
            Debug.Print(pQueryString)

        End If


    End Sub


    Private Function PrepareData() As DataSet

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

                    Dim tmpData As New DataSet

                    If Connection.State <> System.Data.ConnectionState.Open Then Connection.Open()
                    tmpDbAdapter.Fill(tmpData, "SearchGridData")
                    SourceQuery = pQueryString
                    Return tmpData

                Catch ex As Exception
                    Return Nothing
                End Try
            End Using
        End Using
    End Function


    Private Sub SearchFormBase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If Not LoadDataInProgress Then LoadData()
    End Sub

    Private Sub SearchFormBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'SaveGridViewLayout()
        'e.Cancel = True
        'Me.Close()
    End Sub

    Private Sub SearchFormBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            Try
                PrepareGrid()
                LoadData()

                With pGridView
                    .Focus()
                End With
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub PrepareGrid()
        pkField = (From cInfo In Me.pColumns
                   Where cInfo.Caption.tolower = "pk"
                   Select cInfo.FieldName).FirstOrDefault

        'CreateGridColumns(Me.SearchGrid, Me.pColumns)
    End Sub



    Private Sub ListView_DoubleClick(sender As Object, e As EventArgs) Handles ListView.DoubleClick
        Try
            With SearchGrid
                If .DisplayOnly = False Then
                    .RowPosition = ListView.FocusedRowHandle
                    Dim pk = .Field((pkField).ToString)
                    Me.Hide()
                    RaiseEvent RecordSelected(pk)
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Protected Overridable Sub SearchGrid_ProcessGridKey(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
        ElseIf e.KeyCode = Keys.F5 Then
            ' Refresh()
        ElseIf e.KeyCode = Keys.F11 Then
            Try
                XtraMessageBox.Show(pQueryString)
                Clipboard.SetText(pQueryString, TextDataFormat.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DisposeObjects()
        pColumns = Nothing
        pData = Nothing
    End Sub

    Protected Overrides Sub Finalize()
        DisposeObjects()
        MyBase.Finalize()
    End Sub

    Private Sub SearchFormBase_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True AndAlso e.KeyCode = Keys.F5 Then
            Me.Refresh()
        ElseIf e.KeyCode = Keys.F5 Then
        ElseIf e.KeyCode = Keys.F11 Then   'SQL query
            If Project.Instance.ActiveUser.ToString.ToLower = "backdoor" Then
                Try
                    XtraMessageBox.Show(pQueryString)
                    Clipboard.SetText(pQueryString, TextDataFormat.Text)
                Catch ex As Exception

                End Try
            End If

        End If
    End Sub
    Private Sub LoadData()
        'If IsNothing(DataSource) OrElse Me.OwnerPickListInfo.ReloadPickListOnPopup Then
        LoadDataInProgress = True
        bgw.RunWorkerAsync()
        'End If
    End Sub


    Private Sub bgw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bgw.DoWork
        BuildQueryString()
        'Me.lblRecordCount.Text = "Please wait while loading Picklist Data..."
        pData = PrepareData()
    End Sub

    Private Sub bgw_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        If Not IsNothing(pData) Then
            Me.SearchGrid.DataSource = pData
            Me.SearchGrid.DataMember = pData.Tables(0).TableName

            Me.lblRecordCount.Text = pData.Tables("SearchGridData").Rows.Count & " Records on File..."
            LoadDataInProgress = False
            CreateDetailGridColumns(Me.SearchGrid, pColumns, Me)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub SearchGrid_Click(sender As Object, e As EventArgs) Handles SearchGrid.Click

    End Sub
End Class
