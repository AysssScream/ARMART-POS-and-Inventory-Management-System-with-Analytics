Imports System.IO
Imports System.Windows
Imports DevExpress.XtraReports.UI
Imports Guna.UI.WinForms

Public Class ReportFormBase
    Private _DateField As String
    Private _ShowDateFilter As Boolean
    Private ReportWrappers As Collection
    Private FilterControlsCollection As Collection
    Private ReportsCollection As Collection
    Protected rptSelected As String
    Public _meReportWhere As String
    Public _datewhere As String
    Public tempvalue As String = ""
    Public isProceedPrint As Boolean = True
    Private report As XtraReport
    Dim SelectedReport As ReportWrapper

    Private currentButton As GunaButton

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Property DateField() As String
        Get
            Return _DateField
        End Get
        Set(ByVal value As String)
            _DateField = value
        End Set
    End Property

    Private Sub LoadControlsToCollection(ByVal ctrlContainer As Control)
        Try
            For Each ctrl As Control In ctrlContainer.Controls
                Dim ctrlName As String = ctrl.Name
                'Debug.Print(TypeName(ctrl))
                '
                If TypeOf ctrl Is PTTextInput Or
                        TypeOf ctrl Is PTComboBoxInput Or
                        TypeOf ctrl Is PTDateFilter Or
                        TypeOf ctrl Is PTGridLookUpEdit Then

                    If TypeOf ctrl Is PTComboBoxInput Then
                        CType(ctrl, PTComboBoxInput).LoadData()
                    End If

                    If TypeOf ctrl Is PTGridLookUpEdit Then
                        CType(ctrl, PTGridLookUpEdit).LoadData()
                    End If

                    FilterControlsCollection.Add(ctrl, ctrlName)

                End If

                If ctrl.HasChildren Then
                    LoadControlsToCollection(ctrl)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadReportsToCollection(ByVal ctrlContainer As Control)
        Try
            For Each ctrl As Control In ctrlContainer.Controls
                Dim ctrlName As String = ctrl.Name
                If TypeOf ctrl Is GunaButton Then
                    CType(ctrl, GunaButton).OnHoverBaseColor = Colors.brand
                    CType(ctrl, GunaButton).Font = New Font("Verdana", 8.5!, Drawing.FontStyle.Bold)
                    ReportsCollection.Add(ctrl, ctrlName)

                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AttachReports()
        Try

            Dim filteredFields = From ctrl In ReportsCollection
                                 Select ctrl

            For Each rptItem As GunaButton In filteredFields
                If Not IsNothing(rptItem.Tag) AndAlso rptItem.Tag <> String.Empty Then
                    'MsgBox(rptItem.Caption)
                    Dim rptCaption As String = rptItem.Text
                    Dim rptClass As String = rptItem.Tag

                    Dim rptObj As ReportBase = CreateObject(rptClass)
                    Dim rptWrapper As New ReportWrapper(rptObj, rptCaption, ReportWrapper.ReportOwnerTypeEnum.ReportForm)
                    AddHandler rptWrapper.AdditionalWhere, AddressOf Me.Report_AdditionalWhere
                    AddHandler rptWrapper.OverrideSQL, AddressOf Me._OVerrideSQL

                    ReportWrappers.Add(rptWrapper, rptCaption)

                    AddHandler rptItem.Click, AddressOf Me.RptItem_Click
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub
    Protected Overridable Sub _OVerrideSQL(ByRef rQuery As String, ByRef rpttitle As String)

    End Sub

    Private Sub Report_AdditionalWhere(ByRef AdditionalWhere As String)

        If AdditionalWhere <> "" Then
            AdditionalWhere &= IIf(BuildReportWhere() <> "", " AND " + BuildReportWhere(), "")
        Else
            AdditionalWhere &= IIf(BuildReportWhere() <> "", BuildReportWhere(), "")
        End If
    End Sub

    Private ReportFilters As Collection
    Private Function BuildReportWhere() As String
        Dim ReportWhere As String = ""

        ReportFilters = New Collection
        ' If IsNothing(ReportFilters) Then ReportFilters = New Collection
        Try
            ReportFilters.Clear()
            Dim filteredFields = From ctrl In FilterControlsCollection
                                 Where ctrl.TableField <> String.Empty _
                                    AndAlso ctrl.TableName <> String.Empty _
                                        AndAlso Not IsNothing(ctrl.EditValue)
                                 Select ctrl

            For Each FilteredField In filteredFields
                Dim filter As New FilterParam
                Dim ctrlname = TypeName(FilteredField)
                Select Case ctrlname
                    Case "PTTextInput"

                        With CType(FilteredField, PTTextInput)
                            If .Text.Trim <> "" Then
                                ReportWhere &= String.Format(" {0} = '{1}' AND", .TableField, .EditValue)
                                filter.FieldName = .TableField.ToLower
                                filter.Value = .EditValue
                            End If
                        End With

                    Case "PTComboBoxInput"
                        With CType(FilteredField, PTComboBoxInput)
                            If .Text.Trim <> "" Then
                                If InStr(.SelectedText, "'") <> 0 Then

                                    ReportWhere &= String.Format(" {0} = '{1}' AND", .TableField, .SelectedText.Split("'")(0) & "''" & .SelectedText.Split("'")(1))
                                Else

                                    ReportWhere &= String.Format(" {0} = '{1}' AND", .TableField, .SelectedText.ToString.Trim)
                                End If

                                filter.FieldName = .TableField.ToLower
                                filter.Value = .SelectedText
                            End If

                        End With
                    Case "PTDateFilter"
                        With CType(FilteredField, PTDateFilter)
                            If .EditValue.ToString <> "" And Not .IsBlankDate Then
                                filter.FieldName = .TableField.ToLower
                                filter.Value = .EditValue
                                If IsNothing(.ReplaceDateField) Then
                                    ReportWhere &= String.Format(" {0} AND", .EditValue)
                                Else
                                    ReportWhere &= String.Format(" {0} AND", .EditValue.Replace(.TableField, .ReplaceDateField))
                                End If

                                _datewhere &= String.Format(" {0} AND", .EditValue)
                            End If


                        End With
                    Case "PTGridLookUpEdit"
                        With CType(FilteredField, PTGridLookUpEdit)
                            If .EditValue.ToString <> "" Then
                                ReportWhere &= String.Format(" {0} = '{1}' AND", .TableField, .EditValue.ToString)
                                filter.FieldName = .TableField.ToLower
                                filter.Value = .EditValue
                            End If

                        End With
                End Select
                ReportFilters.Add(filter)
            Next
            If ReportWhere <> "" Then
                ReportWhere = ReportWhere.Substring(0, ReportWhere.Length - 3) 'remove trailing AND
            End If
        Catch ex As Exception
            ReportWhere = ""
        End Try
        _meReportWhere = ReportWhere
        Return ReportWhere
    End Function

    Private Sub ReportFormBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            currentButton = New GunaButton()

            FilterControlsCollection = New Collection
            ReportsCollection = New Collection
            ReportWrappers = New Collection
            LoadControlsToCollection(Me)
            LoadReportsToCollection(ReportPanel)
            AttachReports()
        Catch ex As Exception
            'MsgBox(ex.Message)
            'Clipboard.SetText(ex.StackTrace)
        End Try

    End Sub

    Private Sub RptItem_Click(sender As Object, e As EventArgs)
        Try
            If isProceedPrint Then
                If SelectedReport IsNot Nothing Then
                    SelectedReport = Nothing
                End If
                DeActivateCurrentButton(currentButton)
                currentButton = CType(sender, GunaButton)
                currentButton.BackColor = Colors.brand
                currentButton.ForeColor = Color.White

                Dim selItem As String = CType(sender, GunaButton).Text
                SelectedReport = DirectCast(ReportWrappers(selItem), ReportWrapper)
                rptSelected = selItem
                BuildReportWhere()
                SelectedReport.FileName = selItem
                SelectedReport.Temp = PtDateFilter1.EditValue
                SelectedReport.ReportObject.SetFilterParamsCollection(ReportFilters)
                SelectedReport.SetReportDate(PtDateFilter1.Tag)
                report = New XtraReport
                report = SelectedReport.PanelPreviewReport()

                DocumentViewer1.PrintingSystem = report.PrintingSystem
                DocumentViewer1.Dock = DockStyle.Fill
                report.CreateDocument()
                PtDateFilter1.ReplaceDateField = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DeActivateCurrentButton(ByVal previousButton As GunaButton)
        previousButton.BackColor = Color.Transparent
        previousButton.ForeColor = Color.Black
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs)
        report.PrintDialog()
    End Sub

    Private Sub btnOpenNewWindow_Click(sender As Object, e As EventArgs) Handles btnOpenNewWindow.Click
        report.ShowRibbonPreview()
    End Sub

    Private Sub btnPrintDialog_Click(sender As Object, e As EventArgs) Handles btnPrintDialog.Click
        report.PrintDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        report.Print()
    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click
        DocumentViewer1.ZoomOut()
    End Sub

    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        DocumentViewer1.ZoomIn()
    End Sub

    Private Sub btnExportPDF_Click(sender As Object, e As EventArgs) Handles btnExportPDF.Click
        Try

            Dim documentsFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim pdfFileName As String = SelectedReport.FileName + ".pdf"
            Dim pdfFilePath As String = Path.Combine(documentsFolderPath, pdfFileName)

            Dim newFileName As String = ""
            If File.Exists(pdfFilePath) Then
                ' If the file already exists, add a suffix to the filename
                Dim counter As Integer = 1

                Do
                    newFileName = Path.GetFileNameWithoutExtension(pdfFileName) & "(" & counter & ")" & Path.GetExtension(pdfFileName)
                    pdfFilePath = Path.Combine(documentsFolderPath, newFileName)
                    counter += 1
                Loop While File.Exists(pdfFilePath)
            End If

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveFileDialog.Title = "Save PDF File"
            saveFileDialog.FileName = newFileName

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                pdfFilePath = saveFileDialog.FileName
                report.ExportToPdf(pdfFilePath)
            End If

            Dim result As DialogResult = MessageBox.Show("Do you want to open the exported PDF file?", "Exported Successfully!", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                System.Diagnostics.Process.Start(pdfFilePath)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Try

            Dim documentsFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim excelFileName As String = SelectedReport.FileName + ".xlsx"
            Dim excelFilePath As String = Path.Combine(documentsFolderPath, excelFileName)

            Dim newFileName As String = ""
            If File.Exists(excelFilePath) Then
                ' If the file already exists, add a suffix to the filename
                Dim counter As Integer = 1

                Do
                    newFileName = Path.GetFileNameWithoutExtension(excelFileName) & "(" & counter & ")" & Path.GetExtension(excelFileName)
                    excelFilePath = Path.Combine(documentsFolderPath, newFileName)
                    counter += 1
                Loop While File.Exists(excelFilePath)
            End If

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "Save Excel File"
            saveFileDialog.FileName = newFileName

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                excelFilePath = saveFileDialog.FileName
                report.ExportToXlsx(excelFilePath)
            End If

            Dim result As DialogResult = MessageBox.Show("Do you want to open the exported Excel file?", "Exported Successfully!", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                System.Diagnostics.Process.Start(excelFilePath)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExportWord_Click(sender As Object, e As EventArgs) Handles btnExportWord.Click
        Try

            Dim documentsFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim wordFileName As String = SelectedReport.FileName + ".docx"
            Dim wordFilePath As String = Path.Combine(documentsFolderPath, wordFileName)

            Dim newFileName As String = ""
            If File.Exists(wordFilePath) Then
                ' If the file already exists, add a suffix to the filename
                Dim counter As Integer = 1

                Do
                    newFileName = Path.GetFileNameWithoutExtension(wordFileName) & "(" & counter & ")" & Path.GetExtension(wordFileName)
                    wordFilePath = Path.Combine(documentsFolderPath, newFileName)
                    counter += 1
                Loop While File.Exists(wordFilePath)
            End If

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Word Files (*.docx)|*.docx"
            saveFileDialog.Title = "Save Word File"
            saveFileDialog.FileName = newFileName

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                wordFilePath = saveFileDialog.FileName
                report.ExportToDocx(wordFilePath)
            End If

            Dim result As DialogResult = MessageBox.Show("Do you want to open the exported Word file?", "Exported Successfully!", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                System.Diagnostics.Process.Start(wordFilePath)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
