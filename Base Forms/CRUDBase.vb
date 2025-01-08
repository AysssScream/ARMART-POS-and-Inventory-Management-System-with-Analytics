Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports System.Data.Common
Imports System.Linq
Imports System.IO
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports DevExpress.XtraReports.UI
Imports System.Xml
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraTab
Imports DevExpress.XtraEditors.Controls
Imports Guna.UI2.WinForms
Public Class CRUDBase

    'Delegates
    Protected Delegate Sub SetControlTextDelegate(ByVal Obj As Object, ByVal value As Object)
    Protected Delegate Sub CrossThreadMethodDelegate(ByVal val As Object)

    Protected _CtrlCollection As Collection
    'Private Variables
    Protected Resaving As Boolean
    Private Connection As DbConnection
    Private TableQueries As Collection
    Private TableNames As Collection
    Private PKControlCollection As Collection
    Private FKControlCollection As Collection
    Private FormData As DataSet
    Private DataAdapters As Collection
    Private CommandBuilders As Collection
    Private DetailGridWrappers As Collection
    Private SearchFilter As String
    Private IsSearching As Boolean = False
    Private FirstLoad As Boolean = True

    'Public variables
    Public ReportWrappers As Collection
    Public UsePKFilter As Boolean = True
    Public SearchForm As SearchFormBase

    'MainForm Navigation Storage
    Private MainNavigationData As DataSet
    Private MainNavigationColumnsInfo As Collection

    'Events
    Public Event BeforeRecordAdd(ByRef Cancel As Boolean)
    Public Event BeforeRecordEdit(ByRef Cancel As Boolean)
    Public Event BeforeRecordSave(ByRef Cancel As Boolean)
    Public Event BeforeRecordDelete(ByRef Cancel As Boolean)
    Public Event BeforeRecordPreview(ByRef Cancel As Boolean)
    Public Event BeforeRecordPrint(ByRef Cancel As Boolean)

    Public Event MainNavigationAdditionalWhere(ByRef AdditionalWhere As String)

    Public Event AfterRecordAdd()
    Public Event AfterRecordEdit()
    Public Event AfterRecordSave()
    Public Event AfterRecordDelete()
    Public Event AfterRecordOpen()

    Public Event FormInitComplete()
    Public Event FormStateChanged(ByVal FormState As EditorState)
    Public Event LoadDetailRecords(ByVal RecordPK As String)
    Public Event DeleteDetailRecords()

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = True

        Me.SplitRecordInfo.Panel2.Width = 300

        _PKControl = Me.txtPK
        _ModuleControl = Me.txtModule
        _ModuleTypeControl = Me.txtModuleType
        _BranchControl = Me.txtBranch
        _UserControl = Me.txtUser
    End Sub

#Region "Properties"
    'Property Holders
    Private _Reports As String
    Private _SearchFormColumnDefinitionInfo As String
    Private _SearchFormTableFromInfo As String
    Private _DetailTotalControl As BaseEdit
    Protected _FormState As EditorState
    Private _UserPkControl As Control
    Private _EnableLockData As Boolean
    Private _PKControl As Control
    Private _ModuleControl As Control
    Private _ModuleTypeControl As Control
    Private _BranchControl As Control
    Private _UserControl As Control

    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property AttachReports() As String
        Get
            Return _Reports
        End Get
        Set(ByVal value As String)
            _Reports = value
        End Set
    End Property

    <Editor(GetType(MultilineStringEditor), GetType(UITypeEditor))>
    Public Property SearchFormColumnDefinitionInfo() As String
        Get
            Return GetLowerCaseString(_SearchFormColumnDefinitionInfo) 'IIf(IsNothing() OrElse String.IsNullOrEmpty(_SearchFormColumnDefinitionInfo), "", _SearchFormColumnDefinitionInfo.ToLower)
        End Get
        Set(ByVal value As String)
            _SearchFormColumnDefinitionInfo = value
        End Set
    End Property

    Public Property SearchFormTableFromInfo() As String
        Get
            Return GetLowerCaseString(_SearchFormTableFromInfo) 'IIf(IsNothing() OrElse String.IsNullOrEmpty(_SearchFormTableFromInfo), "", _SearchFormTableFromInfo.ToLower)
        End Get
        Set(ByVal value As String)
            _SearchFormTableFromInfo = value
        End Set
    End Property

    Public Property DetailTotalControl() As BaseEdit
        Get
            Return _DetailTotalControl
        End Get
        Set(ByVal value As BaseEdit)
            _DetailTotalControl = value
        End Set
    End Property

    Public ReadOnly Property FormState() As EditorState
        Get
            Return _FormState
        End Get
    End Property

    Public Property UserPKControl() As Control
        Get
            Return _UserPkControl
        End Get
        Set(ByVal value As Control)
            _UserPkControl = value
        End Set
    End Property
    <DefaultValue(False)>
    Public Property EnableLockData() As Boolean
        Get
            Return _EnableLockData
        End Get
        Set(ByVal value As Boolean)
            _EnableLockData = value
        End Set
    End Property

    Public Property PKControl() As Control
        Get
            Return _PKControl
        End Get
        Set(ByVal value As Control)
            _PKControl = value
        End Set
    End Property

    Public ReadOnly Property ModuleControl() As Control
        Get
            Return _ModuleControl
        End Get
    End Property

    Public ReadOnly Property ModuleTypeControl() As Control
        Get
            Return _ModuleTypeControl
        End Get
    End Property
    Public ReadOnly Property BranchControl() As Control
        Get
            Return _BranchControl
        End Get
    End Property
    Public ReadOnly Property UserControl() As Control
        Get
            Return _UserControl
        End Get
    End Property

    Private IsGridOnly As Boolean = True

    <DefaultValue(False)>
    Public Property GridOnly()
        Get
            Return IsGridOnly
        End Get
        Set(ByVal value)
            IsGridOnly = value
        End Set
    End Property


    Private _IsFromDialog As Boolean = False
    <DefaultValue(False)>
    Public Property IsFromDialog() As Boolean
        Get
            Return _IsFromDialog
        End Get
        Set(ByVal value As Boolean)
            _IsFromDialog = value
        End Set
    End Property
#End Region
    Private Sub CrudBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then

            Me._FormState = EditorState.NullMode

            LoadFormDefaults()
            Me.SplitRecordInfo.PanelVisibility = SplitPanelVisibility.Panel1

            If Me.TempRecordSelected = "" Then
                'AddRecord()
            Else
                NewRecordSelected(Me.TempRecordSelected)
                'EditRecord()
            End If

        End If
    End Sub

    Protected Overridable Sub NewRecordSelected(ByVal RecordPK As String)
        Try
            IsSearching = True
            SearchFilter = RecordPK
            LoadFormData()
            'Me._FormState = EditorState.ViewMode
            RaiseEvent LoadDetailRecords(RecordPK)
            RaiseEvent AfterRecordOpen()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetControl(ByVal controlName As String) As Control
        Try
            Return _CtrlCollection(controlName.ToLower)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Protected Friend Sub LoadControlsToCollection(ByVal ctrlContainer As Control)

        For Each ctrl As Control In ctrlContainer.Controls
            Dim ctrlName As String = ctrl.Name

            'If ctrl.HasChildren Then
            '    'ctrl.TabStop = False
            '    LoadControlsToCollection(ctrl)
            '    Exit Sub
            'End If

            'Debug.Print(TypeName(ctrl))
            If TypeOf ctrl Is PTTextInput Or
               TypeOf ctrl Is PTNumericInput Or
               TypeOf ctrl Is PTUserPKInput Or
               TypeOf ctrl Is PTComboBoxInput Or
               TypeOf ctrl Is PTMemoInput Or
               TypeOf ctrl Is PTGridLookUpEdit Or
               TypeOf ctrl Is DetailGrid Or
               TypeOf ctrl Is PTDateEdit Or
               TypeOf ctrl Is PictureEdit Or
               TypeOf ctrl Is GridPickListInfo Or
               TypeOf ctrl Is PTCheckEdit Then

                'add handler/load default events for selected controls
                Select Case True
                    Case TypeOf (ctrl) Is PTGridLookUpEdit
                        With DirectCast(ctrl, PTGridLookUpEdit)
                            'If Not (.TableField <> "" AndAlso .TableName <> "") Then .TabStop = True

                            .LoadData()
                            .Refresh()
                            AddHandler .EditValueChanged, AddressOf GridLookupEdit_EditValueChanged
                            AddHandler .Popup, AddressOf GridLookupEdit_Popup
                            AddHandler .KeyDown, AddressOf Me.GridLookUp_KeyDown
                        End With

                    Case TypeOf (ctrl) Is PTComboBoxInput
                        With DirectCast(ctrl, PTComboBoxInput)
                            .LoadData()
                        End With
                    Case TypeOf (ctrl) Is PTDateEdit
                        With DirectCast(ctrl, DateEdit)
                            AddHandler .QueryPopUp, AddressOf DateEdit_QueryPopUp
                        End With
                    Case TypeOf (ctrl) Is PTPictureEdit
                        With DirectCast(ctrl, PTPictureEdit)
                            .Properties.NullText = "Double click to add pic"
                            .Properties.ShowMenu = False
                            AddHandler .DoubleClick, AddressOf PictureEdit_DoubleClick
                        End With
                End Select

                AddHandler ctrl.PreviewKeyDown, AddressOf PreviewKeyDown
                AddHandler ctrl.KeyDown, AddressOf ProcessTabKeyPress

                _CtrlCollection.Add(ctrl, ctrlName)
            Else
                'ctrl.TabStop = False
            End If

            If ctrl.HasChildren Then
                'ctrl.TabStop = False
                LoadControlsToCollection(ctrl)
            End If

        Next

    End Sub

    Private Sub AttachDetailWrappers()

        Dim DetailControls = From myChildControl As Object In Me._CtrlCollection
                             Where TypeOf (myChildControl) Is DetailGrid
                             Select myChildControl

        For Each DetailControl As Object In DetailControls
            Dim gridWrapper As PTDetailGridWrapper = New PTDetailGridWrapper(DirectCast(DetailControl, DetailGrid))
            AddHandler gridWrapper.FilterGridLookUp, AddressOf FilterGridLookUp
            AddHandler gridWrapper.FilterPickListBeforeShow, AddressOf Me.FilterPickList
            AddHandler gridWrapper.AfterPickListReturnValues, AddressOf AfterPickListReturnValues
            AddHandler gridWrapper.AfterLoadGridDetails, AddressOf AfterLoadGridDetails
            AddHandler gridWrapper.AfterRowSave, AddressOf AfterRowSave
            AddHandler gridWrapper.AfterRowDelete, AddressOf AfterRowDelete
            AddHandler gridWrapper.RepEditButtonItemClick, AddressOf RepItemButtonClick
            DetailGridWrappers.Add(gridWrapper, DetailControl.Name)

        Next
    End Sub

    Protected Overridable Sub Report_AdditionalWhere(ByRef AdditionalWhere As String) ''enhanced
        If UsePKFilter Then
            With DirectCast(Me.PKControl, PTTextInput)
                AdditionalWhere &= .TableName & "." & .TableField & " = " & AddQuote9(.Text.ToString)
            End With
        Else
            AdditionalWhere = String.Format("FK_CSession_TransH = '{0}'", Project.Instance.SessionId)
        End If
    End Sub

    Private Sub BuildReportMenu()
        Try
            'BarManager1.ForceInitialize()

            If Not IsEmptyString(Me.AttachReports) AndAlso Me.AttachReports.Split("@").Length > 1 Then

                Dim tmpMenu() As String = Me.AttachReports.Split("@")
                Dim rptCaption As String, rptClass As String

                For i As Integer = 1 To UBound(tmpMenu)

                    rptCaption = tmpMenu(i).Split("|")(1).TrimEnd(ChrW(Keys.Tab))
                    rptClass = tmpMenu(i).Split("|")(2).TrimEnd(ChrW(Keys.Tab))

                    Dim rptObj As ReportBase = CreateObject(rptClass.Trim)
                    Dim rptWrapper As New ReportWrapper(rptObj, rptCaption, ReportWrapper.ReportOwnerTypeEnum.TransactionForm)
                    AddHandler rptWrapper.AdditionalWhere, AddressOf Me.Report_AdditionalWhere
                    ReportWrappers.Add(rptWrapper, rptCaption)

                    Dim mnuitemPrint As New ToolStripMenuItem
                    mnuitemPrint.Name = rptClass
                    mnuitemPrint.Text = rptCaption
                    mnuitemPrint.AccessibleName = "Print"
                    AddHandler(mnuitemPrint.Click), AddressOf ReportMenuItemClick
                    PrintMenu.Items.Add(mnuitemPrint)

                    Dim mnuitemPreview As New ToolStripMenuItem
                    mnuitemPreview.Name = rptClass
                    mnuitemPreview.Text = rptCaption
                    mnuitemPreview.AccessibleName = "Preview"
                    AddHandler(mnuitemPreview.Click), AddressOf ReportMenuItemClick
                    PreviewMenu.Items.Add(mnuitemPreview)

                Next
            Else
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LoadFormData()
        Try
           ' ClearInputs()
            BuildFormSource()

            If FirstLoad Then
                FirstLoad = False
                Me.DefaultBehavior()
                RaiseEvent FormInitComplete()
            End If

            If IsSearching Then
                EnableInputs(True)
                DisplayData()
                EnableInputs(False)
                IsSearching = False
                SearchFilter = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadDefaultData()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New CrossThreadMethodInvokerDelegate(AddressOf Me.LoadDefaultData), New Object())
            Else
                SetDefaulPKFKValues()

                If Not IsNothing(Me.UserPKControl) Then
                    DirectCast(Me.UserPKControl, PTUserPKInput).GenerateUserPK()
                End If

                For Each dateCtrl As Control In _CtrlCollection
                    If TypeOf (dateCtrl) Is DateEdit AndAlso Not DirectCast(dateCtrl, PTDateEdit).IsBlankDate Then
                        DirectCast(dateCtrl, DateEdit).EditValue = Now.ToString("d")
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LoadFormDefaults()
        SearchForm = New SearchFormBase(Me.SearchFormColumnDefinitionInfo, Me.SearchFormTableFromInfo, Me.txtModule, Me.txtModuleType)
        SearchForm.Tag = Me.Name
        SearchForm.Text = Me.Text

        _CtrlCollection = New Collection
        LoadControlsToCollection(Me)

        ReportWrappers = New Collection
        BuildReportMenu()

        DetailGridWrappers = New Collection

        Me.AttachDetailWrappers()

        LoadFormData()

        AddHandler SearchForm.AdditionalWhere, AddressOf Me.AdditionalSearchFormFilter
        AddHandler SearchForm.RecordSelected, AddressOf Me.NewRecordSelected
    End Sub

    Private Sub DisplayData()
        Try
            If TableNames.Count > 0 Then
                For Each TableName As String In TableNames
                    Dim tbName As String = TableName
                    Dim myChildTextBoxes = From myChildControl As Object In Me._CtrlCollection
                                           Where (Not TypeOf (myChildControl) Is DetailGrid AndAlso
                                                  Not TypeOf (myChildControl) Is GridPickListInfo AndAlso
                                                  myChildControl.TableField <> "" AndAlso
                                                  myChildControl.TableName = tbName)
                                           Select myChildControl

                    If Not IsNothing(FormData.Tables(tbName)) AndAlso FormData.Tables(tbName).Rows.Count > 0 Then
                        With FormData.Tables(tbName).Rows(0)
                            For Each myChildTextBox As Object In myChildTextBoxes
                                Dim FieldValue As Object = .Item(DirectCast(myChildTextBox.TableField, String))
                                If IsDBNull(FieldValue) OrElse FieldValue.ToString = String.Empty Then
                                    FieldValue = Nothing
                                End If
                                If TypeOf (myChildTextBox) Is PTDateEdit Then
                                    If Not FieldValue Is Nothing Then
                                        FieldValue = DateValue(FieldValue).ToString("d")
                                    End If
                                    Me.Invoke(New SetControlTextDelegate(AddressOf SetControlEditValue), New Object() {myChildTextBox, FieldValue})
                                ElseIf TypeOf (myChildTextBox) Is PTTimeEdit Then
                                    If Not FieldValue Is Nothing Then
                                        FieldValue = TimeValue(FieldValue).ToString("t")
                                    End If
                                    Me.Invoke(New SetControlTextDelegate(AddressOf SetControlEditValue), New Object() {myChildTextBox, FieldValue})
                                ElseIf TypeOf (myChildTextBox) Is PTGridLookUpEdit Then
                                    If Not FieldValue Is Nothing Then
                                        FieldValue = (FieldValue)
                                    End If
                                    Me.Invoke(New SetControlTextDelegate(AddressOf SetControlEditValue), New Object() {myChildTextBox, FieldValue})
                                ElseIf TypeOf (myChildTextBox) Is PTPictureEdit Then

                                    If Not FieldValue Is Nothing Then
                                        Dim picdata() As Byte = FieldValue
                                        Using ms As New MemoryStream(picdata)
                                            FieldValue = Image.FromStream(ms)
                                        End Using
                                    End If
                                    Me.Invoke(New SetControlTextDelegate(AddressOf SetControlEditValue), New Object() {myChildTextBox, FieldValue})
                                Else
                                    If TypeOf (myChildTextBox) Is PTCheckEdit Then
                                        Me.Invoke(New SetControlTextDelegate(AddressOf SetControlEditValue), New Object() {myChildTextBox, FieldValue})
                                    Else
                                        Me.Invoke(New SetControlTextDelegate(AddressOf SetControlEditValue), New Object() {myChildTextBox, FieldValue})
                                    End If
                                End If
                            Next
                        End With
                    End If
                Next
            End If
            Me._FormState = EditorState.ViewMode
            SetMenuDisplay()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetDefaulPKFKValues()
        Try
            For i As Integer = 1 To PKControlCollection.Count
                DirectCast(PKControlCollection(i), PTTextInput).Text = GetPK()
            Next

            If FKControlCollection.Count > 0 Then
                For i As Integer = 1 To FKControlCollection.Count
                    DirectCast(FKControlCollection(i), PTTextInput).Text = DirectCast(Me.PKControl, PTTextInput).Text
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridLookupEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try

            Dim tmpInput As PTGridLookUpEdit = CType(sender, PTGridLookUpEdit)
            Dim cols As Collection = tmpInput.GetColumns
            Dim row As DataRowView = tmpInput.GetSelectedDataRow
            Dim tmpField As String
            If Not IsNothing(row) Then
                For Each col As ColumnInfo In cols
                    If col.OutputCtrl <> "" Then
                        tmpField = col.FieldName '.ToLower.Split(" ")(2)
                        If tmpField.Contains(" as ") Then
                            tmpField = tmpField.Substring(tmpField.IndexOf(" as ") + 4).Trim
                        End If
                        Dim ctrl = DirectCast(Me.FindForm, CRUDBase).GetControl(col.OutputCtrl)
                        Select Case TypeName(ctrl)
                            Case "PTDateEdit"
                                DirectCast(ctrl, DateEdit).EditValue = row(tmpField)
                            Case "PTGridLookupEdit"
                                DirectCast(ctrl, PTGridLookUpEdit).EditValue = row(tmpField)
                            Case "PTTextInput", "PTUserPKInput"
                                DirectCast(ctrl, PTTextInput).Text = row(tmpField)
                            Case "PTMemoInput"
                                DirectCast(ctrl, PTMemoInput).EditValue = row(tmpField)
                            Case "PTComboBoxInput"
                                DirectCast(ctrl, PTComboBoxInput).Text = row(tmpField)
                        End Select
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridLookupEdit_Popup(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim popup As DevExpress.Utils.Win.IPopupControl = DirectCast(sender, DevExpress.Utils.Win.IPopupControl)
            Dim popupForm As DevExpress.XtraEditors.Popup.PopupGridLookUpEditForm = DirectCast(popup.PopupWindow, DevExpress.XtraEditors.Popup.PopupGridLookUpEditForm)
            Dim maxWidth = DirectCast(sender, Control).FindForm.Width - DirectCast(sender, Control).Left
            Dim defWidth = DirectCast(sender, Control).Width * DirectCast(sender, PTGridLookUpEdit).PopUpWidthMult
            Dim popUpWidth = IIf(maxWidth < defWidth, maxWidth, defWidth)
            popupForm.Width = popUpWidth
            'set default focus
            Dim popupGrid As PTGridLookupEdit = CType(sender, PTGridLookupEdit)
            With popupGrid.Properties.View
                .FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
                .FocusedColumn = .Columns(popupGrid.TableDisplayField)
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridLookUp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.F5 Then
            CType(sender, PTGridLookUpEdit).LoadData()
        End If
    End Sub

    Private Sub DateEdit_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Me.FormState <> EditorState.AddMode AndAlso Me.FormState <> EditorState.EditMode Then
            e.Cancel = True
        End If
    End Sub

    Public Sub PictureEdit_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.FormState = EditorState.AddMode Or Me.FormState = EditorState.EditMode Then
            Dim fileName As String = ShowOpenFileDialog("Load Picture", "", "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*")

            If File.Exists(fileName) Then
                AutosizeImage(fileName, CType(sender, PictureEdit))
            End If
        End If

    End Sub

    Private Sub PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        e.IsInputKey = True
    End Sub

    Private Sub ProcessTabKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Delete AndAlso TypeOf (sender) Is PTGridLookUpEdit Then
                CType(sender, PTGridLookUpEdit).EditValue = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearInputs()
        'On Error Resume Next
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New CrossThreadMethodInvokerDelegate(AddressOf Me.ClearInputs), New Object())
            Else
                Dim myChildTextBoxes = From myChildControl As Object In Me._CtrlCollection
                                       Where (Not TypeOf (myChildControl) Is DetailGrid AndAlso
                                              Not TypeOf (myChildControl) Is GridPickListInfo AndAlso
                                              myChildControl.Tag <> "1" AndAlso myChildControl.RetainValue <> True)
                                       Select myChildControl

                For Each myChildTextBox As Object In myChildTextBoxes
                    If Me.InvokeRequired Then
                        Me.Invoke(New SetControlTextDelegate(AddressOf Me.SetControlText), New Object() {myChildTextBox, Nothing})
                    Else
                        If TypeOf (myChildTextBox) Is PTCheckEdit Then
                            DirectCast(myChildTextBox, PTCheckEdit).Checked = False
                            DirectCast(myChildTextBox, PTCheckEdit).CheckState = CheckState.Unchecked
                        ElseIf TypeOf (myChildTextBox) Is PTNumericInput Then
                            myChildTextBox.Text = 0
                        Else
                            myChildTextBox.EditValue = Nothing
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EnableInputs(ByVal blnenable As Boolean)
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New CrossThreadMethodDelegate(AddressOf Me.EnableInputs), New Object() {blnenable})
            Else
                Dim myChildTextBoxes = From myChildControl As Object In Me._CtrlCollection
                                       Where (Not TypeOf (myChildControl) Is DetailGrid AndAlso
                                              Not TypeOf (myChildControl) Is GridPickListInfo AndAlso
                                              myChildControl.Tag <> "1" AndAlso myChildControl.TableField <> "")
                                       Select myChildControl

                For Each myChildTextBox As Object In myChildTextBoxes
                    If Me.InvokeRequired Then
                        Me.Invoke(New SetControlTextDelegate(AddressOf Me.LockInput), New Object() {myChildTextBox, Not blnenable})
                    Else
                        myChildTextBox.Enabled = blnenable
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LockInput(ByVal objControl As Object, ByVal LockValue As Boolean)
        Try
            objControl.Properties.ReadOnly = LockValue
            If LockValue Then
                'objControl.Appearance
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ReportMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            Dim selMenu As String = sender.AccessibleName
            Dim selItem As String = sender.Text
            Dim SelectedReport As ReportWrapper = DirectCast(ReportWrappers(selItem), ReportWrapper)

            If selMenu.ToLower = "preview" Then
                If Project.Instance.ActiveUser.Name = "BACKDOOR" OrElse Project.Instance.ActiveUser.IsFunctionAllowed(Me.Text, "Can PrintPreview") OrElse Project.Instance.ActiveUser.IsFunctionAllowed(Me.Text, "Can Print") Then
                    SelectedReport.PreviewReport()
                Else
                    XtraMessageBox.Show("You are not allowed to use this function, Contact system admin...", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If Project.Instance.ActiveUser.Name = "BACKDOOR" OrElse Project.Instance.ActiveUser.IsFunctionAllowed(Me.Text, "Can Print") Then
                    SelectedReport.PrintReport()
                Else
                    XtraMessageBox.Show("You are not allowed to use this function, Contact system admin...", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetControlText(ByVal obj As Object, ByVal value As Object)
        Try
            If TypeOf (obj) Is CheckEdit Then
                CType(obj, CheckEdit).Checked = value
            ElseIf TypeOf (obj) Is PTComboBoxInput Then
                obj.SelectedItem = value
            Else
                obj.Text = value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetControlEditValue(ByVal obj As Object, ByVal value As Object)
        Try
            If TypeOf (obj) Is PTCheckEdit Then
                CType(obj, CheckEdit).Checked = value
            ElseIf TypeOf (obj) Is PTNumericInput Then
                CType(obj, PTNumericInput).Value = value
            Else
                obj.EditValue = value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuildFormSource()
        Try
            If TableQueries Is Nothing Then
                Try
                    ListTableNames()

                    TableQueries = New Collection
                    PKControlCollection = New Collection
                    FKControlCollection = New Collection

                    If TableNames.Count > 0 Then
                        For Each TableName As String In TableNames
                            Dim selectSql As String = ""
                            Dim tbName As String = TableName
                            Dim myChildTextBoxes = From myChildControl As Object In Me._CtrlCollection
                                                   Where (Not TypeOf (myChildControl) Is DetailGrid AndAlso
                                   Not TypeOf (myChildControl) Is GridPickListInfo AndAlso
                                   myChildControl.TableName = tbName AndAlso
                                   myChildControl.TableField <> "")
                                                   Select myChildControl

                            Dim PKSuffix As String = DirectCast(Me.PKControl, PTTextInput).TableField.Split("_")(1)
                            For Each myChildTextBox As Object In myChildTextBoxes
                                Dim FieldName As String = myChildTextBox.TableField
                                Dim dummyCollection As New Collection

                                If (FieldName.Contains("pk_") And Not FieldName.Contains("userpk_") And Not FieldName.Contains("storepk_")) AndAlso TypeOf (myChildTextBox) Is PTTextInput Then PKControlCollection.Add(myChildTextBox, tbName)
                                If FieldName.Contains("fk_") AndAlso FieldName.Contains(PKSuffix) AndAlso tbName <> DirectCast(Me.PKControl, PTTextInput).TableName AndAlso TypeOf (myChildTextBox) Is PTTextInput Then _
                                    FKControlCollection.Add(myChildTextBox, tbName)

                                If Not dummyCollection.Contains(FieldName) Then
                                    selectSql &= FieldName & ","
                                    dummyCollection.Add(FieldName, FieldName)
                                End If
                            Next

                            selectSql = String.Format("SELECT {0} FROM {1}", selectSql.TrimEnd(","), tbName)

                            TableQueries.Add(selectSql, tbName)
                        Next

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            If Not FormData Is Nothing Then FormData = Nothing
            If Not DataAdapters Is Nothing Then FormData = Nothing
            If Not CommandBuilders Is Nothing Then CommandBuilders = Nothing

            FormData = New DataSet
            DataAdapters = New Collection
            CommandBuilders = New Collection

            System.Threading.Thread.Sleep(50)
            If Connection Is Nothing Then
                Connection = New MySqlConnection
                Connection.ConnectionString = AppData.ConnectionString
            End If

            For Each tableName As String In TableNames
                Try
                    Dim Adapter As DbDataAdapter
                    Dim CommandBuilder As DbCommandBuilder

                    If Connection.State <> System.Data.ConnectionState.Open Then
                        Connection.Open()
                    End If

                    Adapter = New MySqlDataAdapter()
                    Adapter.SelectCommand = New MySqlCommand()
                    Adapter.SelectCommand.CommandType = CommandType.Text

                    Dim query As String = DirectCast(TableQueries(tableName), String)

                    Dim modWhere As String = ""
                    If tableName = DirectCast(Me.PKControl, PTTextInput).TableName Then
                        With DirectCast(Me.ModuleControl, PTTextInput)
                            If .TableField <> "" AndAlso .Text <> "" Then
                                modWhere &= String.Format("{0} = {1}", .TableField, AddQuote9(.Text))
                            End If
                        End With
                    End If
                    If modWhere <> "" Then modWhere = " WHERE " & modWhere

                    If Not IsSearching Then
                        If AppData.DBProvider = DataProviderType.Mysql Then '
                            query = String.Format("{0}{1} LIMIT 1 ", query, IIf(modWhere <> "", modWhere, ""))
                        Else
                            query = String.Format("{0}{1}", query, IIf(modWhere <> "", modWhere, ""))
                        End If
                    Else
                        Dim addQuery As String
                        If DirectCast(Me.PKControl, PTTextInput).TableName = tableName Then
                            addQuery = DirectCast(Me.PKControl, PTTextInput).TableField & " = " & AddQuote9(SearchFilter)
                        Else
                            addQuery = DirectCast(FKControlCollection(tableName), PTTextInput).TableField & " = " & AddQuote9(SearchFilter)
                        End If

                        query = String.Format("{0}{1}{2}", query,
                                              IIf(modWhere <> "", modWhere, ""),
                                              IIf(modWhere <> "", " AND " & addQuery, " WHERE " & addQuery))
                    End If

                    Debug.Print(query)

                    Adapter.SelectCommand.CommandText = query
                    Adapter.SelectCommand.CommandTimeout = 5000
                    Adapter.SelectCommand.Connection = Connection

                    CommandBuilder = New MySqlCommandBuilder()
                    CommandBuilder.DataAdapter = Adapter

                    Adapter.Fill(FormData, tableName)

                    DataAdapters.Add(Adapter, tableName)
                    CommandBuilders.Add(CommandBuilder, tableName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    If Not IsNothing(Connection) AndAlso Connection.State <> System.Data.ConnectionState.Closed Then
                        Connection.Close()
                    End If
                End Try
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListTableNames()
        Try
            TableNames = New Collection

            Dim myChildTextBoxes = (From myChildControl As Object In Me._CtrlCollection
                                    Where (Not TypeOf (myChildControl) Is DetailGrid AndAlso
                                       Not TypeOf (myChildControl) Is GridPickListInfo AndAlso
                                       myChildControl.TableName <> "")
                                    Select myChildControl.TableName).Distinct()
            For Each myChildTextBox As Object In myChildTextBoxes
                Dim tbName As String = CType(myChildTextBox, String)
                If Not TableNames.Contains(tbName) Then
                    TableNames.Add(tbName, tbName)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Overridable Sub DefaultBehavior()
        Me.NullMode()
    End Sub

    Protected Overridable Sub FilterGridLookUp(ByVal FieldName As String, ByRef FilterColumn As String, ByRef FilterValue As Object)

    End Sub

    Protected Overridable Sub FilterPickList(ByVal DetailGridName As String, ByRef FieldName As String, ByRef FilterValue As Object)

    End Sub

    Protected Overridable Sub AfterPickListReturnValues(ByVal GridName As String)

    End Sub

    Protected Overridable Sub AfterLoadGridDetails(ByVal GridName As String)

    End Sub

    Protected Overridable Sub AfterRowSave(ByVal GridName As String, ByVal dtRow As DataRow)

    End Sub

    Protected Overridable Sub AfterRowDelete(ByVal GridName As String, ByVal dtRow As DataRow)

    End Sub

    Protected Overridable Sub RepItemButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)

    End Sub
    Protected Overridable Sub AdditionalSearchFormFilter(ByRef AdditionalWhere As String)

    End Sub
    Protected Overridable Sub SetMenuDisplay(Optional ByVal DisableEditingControls As Boolean = False)

    End Sub

#Region "Formstate Mode"
    Public Sub NullMode()
        Me._FormState = EditorState.NullMode
        Me.SetMenuDisplay()
        ClearInputs()
        Me.EnableInputs(False)

        RaiseEvent FormStateChanged(Me.FormState)
        RaiseEvent LoadDetailRecords(Me.txtPK.Text)
    End Sub

    Protected Overridable Sub ViewMode(Optional ByVal LeaveCurrecntRecordOpen As Boolean = False)
        Try
            Dim prevIsAddMode As Boolean = False
            If Me.FormState = EditorState.AddMode Then
                If Not LeaveCurrecntRecordOpen Then
                    prevIsAddMode = True
                    ClearInputs()
                    RaiseEvent LoadDetailRecords(0)
                End If

            End If
            Me._FormState = EditorState.ViewMode
            Me.SetMenuDisplay(prevIsAddMode)
            Me.EnableInputs(False)
            RaiseEvent FormStateChanged(Me.FormState)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "CRUD"
    Protected Overridable Sub AddRecord()
        Try
            Dim Cancel As Boolean = False

            RaiseEvent BeforeRecordAdd(Cancel)

            If Not Cancel Then
                Me._FormState = EditorState.AddMode
                SetMenuDisplay()

                ClearInputs()
                EnableInputs(True)

                Me.LoadDefaultData()

                RaiseEvent FormStateChanged(Me.FormState)
                RaiseEvent LoadDetailRecords(Me.txtPK.Text)

                Try
                    txtUser.Text = Project.Instance.ActiveUserPK
                    txtBranch.Text = Project.Instance.BranchPK
                Catch ex As Exception

                End Try

                RaiseEvent AfterRecordAdd()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.GetBaseException.ToString, "Error adding new record...", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub ViewRecord()

    End Sub
    Protected Overridable Sub DeleteRecord()
        Try
            Dim Cancel As Boolean = False
            RaiseEvent BeforeRecordDelete(Cancel)
            If Not Cancel Then
                If XtraMessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then

                    Dim pkctrl As PTTextInput = CType(Me.PKControl, PTTextInput)
                    Dim isLock As Boolean = False
                    If Me.EnableLockData Then
                        Dim sqlCheckLock As String = String.Format("Select IsLocked from {0} where {1} = '{2}'", pkctrl.TableName, pkctrl.TableField, pkctrl.Text)
                        Dim dtCheckLock As DataTable = AppData.GetDataTable(sqlCheckLock)
                        If dtCheckLock.Rows.Count > 0 Then
                            isLock = dtCheckLock.Rows(0)("IsLocked")
                        End If
                    End If

                    If isLock = True Then
                        XtraMessageBox.Show("Can't delete locked data.", "DELETE RECORD FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Else
                        RaiseEvent DeleteDetailRecords()

                        For Each FKControl As Control In FKControlCollection

                            With CType(FKControl, PTTextInput)
                                Dim delSQL As String = String.Format("DELETE FROM {0} WHERE {1} = @{1};", .TableName, .TableField)
                                If IsNothing(Connection) Then
                                    Connection = New MySqlConnection()
                                    Connection.ConnectionString = AppData.ConnectionString
                                End If

                                If Connection.State <> System.Data.ConnectionState.Open Then Connection.Open()

                                Using cmd As DbCommand = New MySqlCommand()
                                    cmd.Connection = Connection
                                    cmd.CommandText = delSQL

                                    Dim p As DbParameter = New MySqlParameter()
                                    p.ParameterName = "@" & .TableField
                                    p.Value = .Text
                                    p.DbType = DbType.String
                                    cmd.Parameters.Add(p)
                                    cmd.ExecuteNonQuery()
                                End Using

                            End With

                        Next

                        Dim delMain As String = String.Format("DELETE FROM {0} WHERE {1} = @{1};", pkctrl.TableName, pkctrl.TableField)
                        If IsNothing(Connection) Then
                            Connection = New MySqlConnection() ''DBFactory.GetConnection(AppData.DBProvider)
                            Connection.ConnectionString = AppData.ConnectionString
                        End If

                        If Connection.State <> System.Data.ConnectionState.Open Then Connection.Open()

                        Using cmd As DbCommand = New MySqlCommand()
                            cmd.Connection = Connection
                            cmd.CommandText = delMain

                            Dim param As DbParameter = New MySqlParameter()
                            param.ParameterName = "@" & pkctrl.TableField
                            param.Value = pkctrl.Text
                            param.DbType = DbType.String

                            cmd.Parameters.Add(param)
                            cmd.ExecuteNonQuery()
                        End Using

                        RaiseEvent AfterRecordDelete()

                        XtraMessageBox.Show("Record Deleted Successfully", "DELETE RECORD SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                        ClearInputs()
                        Call Me.NullMode()
                    End If

                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Record Deleted failed", "DELETE RECORD FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Finally
            If Not IsNothing(Connection) Then
                If Connection.State <> System.Data.ConnectionState.Closed Then Connection.Close()
                Connection = Nothing
            End If
        End Try
    End Sub

    Protected Overridable Sub EditRecord()
        Try
            Dim Cancel As Boolean = False
            RaiseEvent BeforeRecordEdit(Cancel)

            If Not Cancel Then
                Me._FormState = EditorState.EditMode
                SetMenuDisplay()
                EnableInputs(True)
                RaiseEvent FormStateChanged(Me.FormState)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Protected Overridable Sub SaveRecord(Optional ByVal SilentSave As Boolean = False)
        If Me.InvokeRequired Then
            Me.Invoke(New CrossThreadMethodInvokerDelegate(AddressOf Me.SaveRecord), New Object() {SilentSave})
        Else
            If Not InputValidator.Validate Then
                MsgBox("Please fill-in all required data before saving...", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error")
                Exit Sub
            End If
            Dim cancel As Boolean = False
            RaiseEvent BeforeRecordSave(cancel)
            If Me.FormState <> EditorState.AddMode AndAlso Me.FormState <> EditorState.EditMode Then
                cancel = True
            End If

            If Not cancel Then
                Try
                    Dim UpdateCommands As New Collection
                    Dim PKField As String = DirectCast(Me.PKControl, PTTextInput).TableField
                    Dim PKValue As String = Me.PKControl.Text
                    If Me._FormState = EditorState.AddMode AndAlso Not IsNothing(Me.UserPKControl) Then
                        CType(Me.UserPKControl, PTUserPKInput).GenerateUserPK()
                    End If

                    If TableNames.Count > 0 Then

                        For Each TableName As String In TableNames
                            Dim tbName As String = TableName
                            'Dim NewRow As DataRow
                            Dim myChildTextBoxes = From myChildControl As Object In Me._CtrlCollection
                                                   Where ((TypeOf myChildControl Is PTTextInput Or
                                                        TypeOf myChildControl Is PTUserPKInput Or
                                                        TypeOf myChildControl Is PTNumericInput Or
                                                        TypeOf myChildControl Is PTComboBoxInput Or
                                                        TypeOf myChildControl Is PTMemoInput Or
                                                        TypeOf myChildControl Is PTGridLookUpEdit Or
                                                        TypeOf myChildControl Is PTDateEdit Or
                                                        TypeOf myChildControl Is PTPictureEdit Or
                                                        TypeOf myChildControl Is PTCheckEdit Or
                                                        TypeOf myChildControl Is PTTimeEdit) AndAlso
                                                        myChildControl.TableName <> "" AndAlso
                                                        myChildControl.TableName = tbName AndAlso
                                                        myChildControl.TableField <> "")
                                                   Select myChildControl

                            Dim paramType As DbType
                            Dim UpdateQuery As String
                            Dim UPDATE_PREFIX As String = ""

                            Dim CurrentRow As DataRow
                            If Me.FormState <> EditorState.AddMode Then
                                If FormData.Tables(tbName).Rows.Count > 0 Then
                                    CurrentRow = FormData.Tables(tbName).Rows(0)
                                    UpdateQuery = GetUpdateQuery(TableQueries(tbName))
                                Else
                                    UpdateQuery = GetInsertQuery(TableQueries(tbName))
                                End If
                            Else
                                CurrentRow = FormData.Tables(tbName).NewRow
                                UpdateQuery = GetInsertQuery(TableQueries(tbName))
                            End If

                            Dim cmd As DbCommand = New MySqlCommand() 'DBFactory.GetCommand(AppData.DBProvider)
                            cmd.CommandText = UpdateQuery

                            Try
                                For Each myChildTextBox As Object In myChildTextBoxes
                                    Dim EditValue As Object
                                    Dim paramName As String
                                    If TypeOf (myChildTextBox) Is PTDateEdit Then
                                        Dim ctrl As PTDateEdit = DirectCast(myChildTextBox, PTDateEdit)
                                        Try
                                            EditValue = DateValue(ctrl.Text).ToString("yyyy-MM-dd")

                                        Catch ex As Exception
                                            EditValue = DBNull.Value
                                        End Try
                                        paramType = DbType.DateTime
                                        paramName = "@" & ctrl.TableField

                                    ElseIf TypeOf (myChildTextBox) Is PTNumericInput Then
                                        Dim ctrl As PTNumericInput = DirectCast(myChildTextBox, PTNumericInput)
                                        Try
                                            Dim dvalue = IIf(Not IsNothing(ctrl.DefaultValue), StrVal9(ctrl.DefaultValue), 0)
                                            EditValue = IIf(ctrl.Text = "", dvalue, StrVal9(ctrl.Text))
                                        Catch ex As Exception
                                            EditValue = DBNull.Value
                                        End Try
                                        paramType = DbType.Decimal
                                        paramName = "@" & ctrl.TableField

                                    ElseIf TypeOf (myChildTextBox) Is PTComboBoxInput Then
                                        Dim ctrl As PTComboBoxInput = DirectCast(myChildTextBox, PTComboBoxInput)
                                        Try
                                            EditValue = IIf(Not IsNothing(ctrl.Text), ctrl.Text.Trim, DBNull.Value)
                                        Catch ex As Exception
                                            EditValue = DBNull.Value
                                        End Try
                                        paramType = DbType.String
                                        paramName = "@" & ctrl.TableField
                                    ElseIf TypeOf (myChildTextBox) Is PTTimeEdit Then
                                        Dim ctrl As PTTimeEdit = DirectCast(myChildTextBox, PTTimeEdit)
                                        Try
                                            EditValue = Now.ToString("yyyy-MM-dd") & CDate(ctrl.EditValue).ToString(" HH:mm:ss")
                                        Catch ex As Exception
                                            EditValue = DBNull.Value
                                        End Try
                                        paramType = DbType.DateTime
                                        paramName = "@" & ctrl.TableField
                                    ElseIf TypeOf (myChildTextBox) Is PTGridLookUpEdit Then
                                        Dim ctrl As PTGridLookUpEdit = DirectCast(myChildTextBox, PTGridLookUpEdit)
                                        If Not IsNothing(ctrl.EditValue) Then
                                            EditValue = IIf(Not IsEmptyString(ctrl.EditValue.ToString), ctrl.EditValue.ToString, "")
                                            paramType = DbType.String
                                        Else
                                            If InStr(ctrl.TableField, "FK") <> 0 Then
                                                EditValue = Guid.Empty
                                                paramType = DbType.Guid
                                            Else
                                                EditValue = DBNull.Value
                                                paramType = DbType.String
                                            End If
                                        End If
                                        paramName = "@" & ctrl.TableField
                                    ElseIf TypeOf (myChildTextBox) Is PTCheckEdit Then
                                        Dim ctrl As PTCheckEdit = DirectCast(myChildTextBox, PTCheckEdit)
                                        EditValue = IIf(ctrl.Checked, 1, 0)
                                        paramType = DbType.Byte
                                        paramName = "@" & ctrl.TableField
                                    ElseIf TypeOf (myChildTextBox) Is PTPictureEdit Then
                                        Dim picBox As PTPictureEdit = CType(myChildTextBox, PTPictureEdit)
                                        With picBox
                                            If Not IsDBNull(.EditValue) AndAlso Not IsNothing(.EditValue) Then
                                                Dim picBytes() As Byte
                                                Using ms As New MemoryStream
                                                    picBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                                                    picBytes = ms.ToArray
                                                End Using
                                                EditValue = picBytes
                                            Else
                                                EditValue = DBNull.Value
                                            End If
                                        End With
                                        paramType = DbType.Binary
                                        paramName = "@" & picBox.TableField
                                    Else
                                        If Not IsNothing(myChildTextBox.Text) AndAlso (myChildTextBox.TableField.ToString.ToLower.Contains("pk_") OrElse myChildTextBox.TableField.ToString.ToLower.Contains("fk_")) Then
                                            EditValue = myChildTextBox.Text
                                            paramType = DbType.String
                                        Else
                                            EditValue = IIf(Not IsNothing(myChildTextBox.Text), myChildTextBox.Text, DBNull.Value)
                                            paramType = DbType.String

                                            Dim Num As Double
                                            If Not IsDBNull(EditValue) AndAlso Not TypeOf (myChildTextBox) Is PTUserPKInput Then
                                                If Double.TryParse(EditValue, Num) Then
                                                    paramType = DbType.Decimal
                                                    If EditValue = "" Then
                                                        EditValue = 0
                                                    End If
                                                    EditValue = EditValue.ToString.Replace(",", "")
                                                End If
                                            End If
                                        End If
                                        paramName = "@" & myChildTextBox.TableField
                                    End If
                                    Dim dbparam As DbParameter = cmd.CreateParameter
                                    With dbparam
                                        .DbType = paramType
                                        .ParameterName = paramName
                                        .Value = EditValue
                                    End With
                                    Debug.Print("param type: " & paramType.ToString & " paramname: " & paramName & " param value: " & EditValue.ToString)
                                    cmd.Parameters.Add(dbparam)
                                Next

                            Catch ex As Exception
                                If UserName = "BACKDOOR" Then
                                    XtraMessageBox.Show(ex.GetBaseException.ToString, "Save Record Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                                End If
                            End Try

                            UpdateCommands.Add(cmd, tbName)
                        Next

                        If IsNothing(Connection) Then
                            Connection = New MySqlConnection()
                            Connection.ConnectionString = AppData.ConnectionString
                        End If

                        If Connection.State <> System.Data.ConnectionState.Open Then Connection.Open()

                        'SAVE PRIMARY TABLE FIRST
                        Dim pTable As String = Me.txtPK.TableName.ToString
                        With CType(UpdateCommands(pTable), DbCommand)
                            .Connection = Connection
                            .ExecuteNonQuery()
                        End With

                        Try
                            If TableNames.Count > 1 Then
                                For Each TableName As String In TableNames
                                    Dim tbName As String = TableName
                                    If tbName <> pTable Then
                                        With CType(UpdateCommands(tbName), DbCommand)
                                            .Connection = Connection
                                            .ExecuteNonQuery()
                                        End With
                                    End If
                                Next
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                        Me.SaveDetailRecords()
                        RaiseEvent AfterRecordSave()
                    End If

                    'silent save used for self updates /resaves
                    If Not SilentSave Then
                        If Not Resaving Then
                            If XtraMessageBox.Show("Record Saved" + IIf(Me.FormState = EditorState.AddMode, vbCrLf + "Would you like to add a new record?", ""),
                        "Save Record Successful", IIf(Me.FormState = EditorState.AddMode, MessageBoxButtons.YesNo, MessageBoxButtons.OK),
                            MessageBoxIcon.Information, IIf(Me.FormState = EditorState.AddMode, MessageBoxDefaultButton.Button2, MessageBoxDefaultButton.Button1)) = System.Windows.Forms.DialogResult.Yes Then
                                Me.AddRecord()
                            Else
                                NewRecordSelected(Me.txtPK.Text)
                            End If
                        Else
                            Me.ViewMode(True)
                        End If
                    End If



                Catch ex As Exception
                    If UserName = "BACKDOOR" Then
                        XtraMessageBox.Show(ex.GetBaseException.ToString, "Save Record Error", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)

                    End If
                Finally
                    If Not IsNothing(Connection) Then
                        If Connection.State <> System.Data.ConnectionState.Closed Then Connection.Close()
                        Connection = Nothing
                    End If

                End Try
            End If

        End If

    End Sub
#End Region
    Protected Overridable Sub SaveDetailRecords()
        Try
            For Each GridWrapperObject As PTDetailGridWrapper In DetailGridWrappers
                GridWrapperObject.SaveDetailRecords()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "CRUD Query"
    Private Function GetUpdateQuery(ByVal SelectQuery As String) As String
        Dim query As String = ""
        Try
            Dim tbName As String
            Dim splitQuery() As String
            Dim Columns() As String
            Dim PKField As String

            SelectQuery = SelectQuery.ToLower.Replace("select", "").Replace(" from ", "|")

            splitQuery = SelectQuery.Split("|")
            tbName = splitQuery(1).Trim
            Columns = splitQuery(0).Split(",")

            query = String.Format("UPDATE {0} SET ", tbName)
            For i As Integer = 0 To UBound(Columns)
                Dim colName As String = Columns(i).Trim
                If colName.Contains("pk") Or colName.Contains("pk_") Then
                    PKField = colName
                Else
                    query &= String.Format("{0} = @{0}", colName)
                    Debug.Print(String.Format("{0} query= {1}", i, query))
                    If i <> UBound(Columns) Then query &= ","
                End If

            Next
            query = query.TrimEnd(",")
            query &= String.Format(" WHERE {0} = @{0}", PKField)
        Catch ex As Exception

        End Try
        Return query
    End Function

    Public Function GetInsertQuery(ByVal SelectQuery As String) As String
        Dim query As String = ""
        Try
            Dim tbName As String
            Dim splitQuery() As String
            Dim Columns() As String
            Dim Fields As String = ""
            Dim Values As String = ""

            SelectQuery = SelectQuery.ToLower.Replace("select", "").Replace(" from ", "|")

            splitQuery = SelectQuery.Split("|")
            tbName = splitQuery(1).Trim
            Columns = splitQuery(0).Split(",")

            'query = String.Format("INSERT INTO {0} ", tbName)
            For i As Integer = 0 To UBound(Columns)
                Dim colName As String = Columns(i).Trim
                Fields &= colName
                Values &= "@" & colName
                If i <> UBound(Columns) Then
                    Fields &= ","
                    Values &= ","
                End If

            Next

            query &= String.Format("INSERT INTO {0} ({1}) VALUES ({2})", tbName, Fields, Values)
        Catch ex As Exception

        End Try
        Return query
    End Function
#End Region


    Private Sub CRUDBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'SaveFormLayout()
        'SaveConfigFile()
        DisposeObjects()
        e.Cancel = False
    End Sub


    Private Sub DisposeObjects()
        _CtrlCollection = Nothing
        PKControlCollection = Nothing
        FKControlCollection = Nothing
        TableNames = Nothing
        TableQueries = Nothing
        DataAdapters = Nothing
        CommandBuilders = Nothing
        Connection = Nothing
        FormData = Nothing
        SearchForm = Nothing
        _PKControl = Nothing
        _ModuleControl = Nothing
        _ModuleTypeControl = Nothing
        _BranchControl = Nothing
        _UserControl = Nothing
        _UserPkControl = Nothing
    End Sub

    Private Sub CRUDBase_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Me.Focus()

        If e.Control AndAlso e.KeyCode = Keys.R Then
            If SplitRecordInfo.PanelVisibility = SplitPanelVisibility.Both Then
                SplitRecordInfo.PanelVisibility = SplitPanelVisibility.Panel1
            Else
                SplitRecordInfo.PanelVisibility = SplitPanelVisibility.Both
            End If
        End If
    End Sub
End Class
