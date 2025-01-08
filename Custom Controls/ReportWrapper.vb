Imports DevExpress.XtraReports.UI
Imports System.Data.Common
Imports DevExpress.XtraPrinting

'Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports System.Net.Mail
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ReportWrapper
    Public Enum ReportOwnerTypeEnum
        SetupForm
        TransactionForm
        ReportForm
    End Enum

    Private _SourceQuery As String
    Private _AdditionalWhere As String
    Private _OVerrideSQL As String
    Private _FileName As String

    Private OwnerTypeForm As ReportOwnerTypeEnum
    Private Controls As Collection
    Private Report As XtraReport
    Private ReportTitle As String
    Private QueryFrom As String
    Private QuerySelect As String
    Public Temp As String

    Private _SELECT As String
    Private _FROM As String
    Private _WHERE As String
    Private _ORDERBY As String
    Private _GROUPBY As String
    Private _HAVING As String

    Private ReportConnection As DbConnection
    Private ReportDataAdapter As DbDataAdapter
    Private ReportData As DataSet


    Public Event AdditionalWhere(ByRef Criteria As String)
    Public Event BeforeShow(ByRef Report As XtraReport)
    Public Event OverrideSQL(ByRef rQuery As String, ByRef rptname As String)

    Private SoftDeleteAddWhere As String

    Public Sub New(ByVal rptObject As XtraReport, ByVal ReportTitle As String, Optional ByVal ReportOwner As ReportOwnerTypeEnum = ReportOwnerTypeEnum.TransactionForm)
        Try
            Me.Report = rptObject

            DirectCast(Me.Report, ReportBase).ReportTitle = ReportTitle
            RaiseEvent BeforeShow(Me.Report)

            Me.OwnerTypeForm = ReportOwner
            Me.QueryFrom = DirectCast(Me.Report, ReportBase).QueryFromInfo
            Me.Controls = New Collection

            LoadControlsToCollection(Me.Report)
            BuildSelectQuery()
            BuildFromQuery()
        Catch ex As Exception

        End Try

    End Sub

    Public Property FileName() As String
        Get
            Return _FileName
        End Get
        Set(ByVal value As String)
            _FileName = value
        End Set
    End Property

    Public ReadOnly Property ReportObject() As ReportBase
        Get
            Return CType(Report, ReportBase)
        End Get
    End Property

    Private Sub BuildReportData()
        Try

            If ReportConnection Is Nothing Then
                ReportConnection = DBFactory.GetConnection(AppData.DBProvider)
                ReportConnection.ConnectionString = AppData.ConnectionString
            End If

            Me._SourceQuery = ""

            Me._AdditionalWhere = ""
            RaiseEvent AdditionalWhere(_AdditionalWhere)

            Me._SourceQuery &= Me._SELECT.TrimEnd(",") & " "

            Me._SourceQuery &= Me._FROM & " "

            Dim QueryWhere As String = ""

            If _SourceQuery.ToString.Contains("cash_counts") Then
                QueryWhere &= String.Format(" WHERE FK_CSession_CC = '{0}' ", Project.Instance.SessionId)
            Else
                QueryWhere &= IIf(Me._WHERE <> String.Empty,
                                       Me._WHERE & IIf(Me._AdditionalWhere <> String.Empty, " AND " & Me._AdditionalWhere, ""),
                                       IIf(Me._AdditionalWhere <> String.Empty, " WHERE " & Me._AdditionalWhere, "")) & " "
            End If


            Me._SourceQuery &= String.Format(" {0} ", QueryWhere)
            Me._SourceQuery &= Me._GROUPBY & " "
            Me._SourceQuery &= Me._HAVING & " "
            Me._SourceQuery &= Me._ORDERBY
            DirectCast(Me.Report, ReportBase).addwherefrp = Me._AdditionalWhere


            RaiseEvent OverrideSQL(_OVerrideSQL, DirectCast(Me.Report, ReportBase).reportName)

            If IsNothing(ReportDataAdapter) Then ReportDataAdapter = New MySqlDataAdapter()

            With ReportDataAdapter
                .SelectCommand = New MySqlCommand()
                .SelectCommand.CommandType = System.Data.CommandType.Text
                .SelectCommand.CommandText = IIf(Not IsNothing(_OVerrideSQL), _OVerrideSQL, Me._SourceQuery)
                .SelectCommand.Connection = ReportConnection
                .SelectCommand.CommandTimeout = 15000
            End With

            If ReportConnection.State <> System.Data.ConnectionState.Open Then _
                ReportConnection.Open()
            ReportDataAdapter.Fill(ReportData, "ReportData")
            '
        Catch ex As Exception
            MessageBox.Show(ex, "Build Report Data Error!")
            If Project.Instance.ActiveUser.Name.ToString = "BACKDOOR" Then
                Clipboard.SetText(IIf(_OVerrideSQL <> "", _OVerrideSQL, Me._SourceQuery)) 'Me._SourceQuery)
            End If
        Finally
            If ReportConnection.State <> System.Data.ConnectionState.Closed Then _
              ReportConnection.Close()
        End Try
    End Sub

    Private Function GetMacroValues(ByVal qry As String) As String
        Try
        Catch ex As Exception
            Return qry
        End Try

    End Function
    Private Function GetBranchGroup(ByVal qry As String) As String
        Try
        Catch ex As Exception
            Return qry
        End Try
    End Function


    Private Sub BuildFromQuery()
        Dim tmp() As String = Me.QueryFrom.Split("|")

        For i As Integer = 0 To UBound(tmp)
            If tmp(i) <> "" Then
                With tmp(i).ToUpper
                    Select Case True
                        Case .Contains("SELECT")
                            Me._SELECT = tmp(i).Trim
                        Case .Contains("FROM")
                            Me._FROM = tmp(i).Trim
                        Case .Contains("WHERE")
                            Me._WHERE = tmp(i).Trim
                        Case .Contains("GROUP BY")
                            Me._GROUPBY = tmp(i).Trim
                        Case .Contains("HAVING")
                            Me._HAVING = tmp(i).Trim
                        Case .Contains("ORDER BY")
                            Me._ORDERBY = tmp(i).Trim
                    End Select
                End With
            End If
        Next

    End Sub

    Private Sub BuildSelectQuery()
        Try
            Dim fields As New ArrayList
            Me._SELECT = "SELECT "
            If Not Me.Controls Is Nothing AndAlso Me.Controls.Count > 0 Then
                For Each ctrl As XRControl In Me.Controls
                    If Not fields.Contains(ctrl.Tag.ToString) Then
                        Dim field = ctrl.Tag.ToString.Replace("alias", "as")
                        Me._SELECT &= field & ","
                        fields.Add(field)
                    End If
                Next
                If Me.QueryFrom.Contains("SELECT") Then
                    Me._SELECT = Me.QueryFrom.Split("|")(0).TrimEnd(",")
                Else
                    Me._SELECT = Me._SELECT.TrimEnd(",")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex, "Build Select Query Error!")
        End Try

    End Sub

    Private Sub LoadControlsToCollection(ByVal ctrlContainer As XRControl)


        For Each ctrl As XRControl In ctrlContainer.Controls
            Dim ctrlName As String = ctrl.Name
            If TypeOf ctrl Is XRTableCell Or _
                TypeOf ctrl Is XRLabel Or _
                    TypeOf ctrl Is XRCheckBox Or _
                        TypeOf ctrl Is XRPictureBox Then

                If ctrl.Tag.ToString <> String.Empty Then
                    Controls.Add(ctrl, ctrlName)
                End If

            End If

            If ctrl.HasChildren Then
                LoadControlsToCollection(ctrl)
            End If

        Next

    End Sub

    Private Sub BindControlsToData()
        Try
            For Each ctrl As XRControl In Me.Controls
                With ctrl
                    .DataBindings.Clear()
                    Dim fieldName As String = ctrl.Tag.ToString
                    If fieldName.ToLower.Contains("alias") Then
                        fieldName = fieldName.ToLower.Split(New String() {" alias "}, StringSplitOptions.None)(1)
                    Else
                        fieldName = fieldName.ToLower ''fieldName.ToLower.Split(" ")(0)
                    End If
                    If TypeOf (ctrl) Is XRPictureBox Then
                        .DataBindings.Add("Image", Nothing, fieldName)
                    ElseIf TypeOf (ctrl) Is XRCheckBox Then
                    Else
                        .DataBindings.Add("Text", Nothing, fieldName, IIf(.XlsxFormatString <> String.Empty, .XlsxFormatString, ""))
                    End If

                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex, "Bind Controls to Data Error!")
        End Try
    End Sub

    Protected Overridable Sub getManualParams(ByRef param As String, ByRef rpttitle As String)

    End Sub

    Public Sub SetReportDate(ByVal rptDateFilter As String)
        DirectCast(Me.Report, ReportBase).lblReportDate.Text = rptDateFilter
        DirectCast(Me.Report, ReportBase).ReportDateFilter = rptDateFilter
        DirectCast(Me.Report, ReportBase).TempValue = Me.Temp
    End Sub

    Public Sub PreviewReport(Optional ByVal isSubreportPreview As Boolean = False)
        Try
            ReportData = New DataSet
            BuildReportData()


            With Me.Report
                .DataSource = ReportData
                .DataMember = ReportData.Tables(0).TableName
            End With

            BindControlsToData()

            Me.Report.ExportOptions.Xls.TextExportMode = TextExportMode.Text
            Me.Report.ExportOptions.Xlsx.TextExportMode = TextExportMode.Text
            Me.Report.CreateDocument(True)

            If Not isSubreportPreview Then Me.Report.ShowRibbonPreviewDialog()


        Catch ex As Exception
            MessageBox.Show(ex, "Preview Report Error!")
        End Try
    End Sub

    Public Function PanelPreviewReport()
        Try
            ReportData = New DataSet
            BuildReportData()


            With Me.Report
                .DataSource = ReportData
                .DataMember = ReportData.Tables(0).TableName
            End With

            BindControlsToData()

            Me.Report.ExportOptions.Xls.TextExportMode = TextExportMode.Text
            Me.Report.ExportOptions.Xlsx.TextExportMode = TextExportMode.Text
            Return Me.Report


        Catch ex As Exception
            MessageBox.Show(ex, "Preview Report Error!")
        End Try
    End Function

    Public Sub PrintReport()
        Try
            ReportData = New DataSet
            BuildReportData()


            With Me.Report

                .DataSource = ReportData
                .DataMember = ReportData.Tables(0).TableName
            End With

            BindControlsToData()

            Me.Report.CreateDocument()
            Me.Report.Print()
        Catch ex As Exception
            MessageBox.Show(ex, "Print Report Error!")
        End Try

    End Sub
End Class
