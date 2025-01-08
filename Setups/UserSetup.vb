Imports DevExpress.XtraBars
Imports System.Data.Common
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.BaseListBoxControl
Imports DevExpress.XtraReports.UI
Imports System.IO
Imports System
Imports System.Drawing

Public Class UserSetup

    Private dsSecurity As DataSet
    Private daSecurity As DbDataAdapter
    Private cbSecurity As DbCommandBuilder
    Private connSecurity As DbConnection
    Private LoadingPermissions As Boolean
    Private LoadingData As Boolean
    Private Saving As Boolean
    Private SelectedFormRow As DataRow
    Public Delegate Sub CrossThreadDelegate()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        SimpleButton1.FillColor = Colors.brand
        SimpleButton2.FillColor = Colors.brand
        SimpleButton3.FillColor = Colors.brand
        SimpleButton4.FillColor = Colors.brand
        SimpleButton5.FillColor = Colors.brand

    End Sub

    Private Sub UserSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Try
                With Me.lstPermissions
                    .Items.AddRange(New Object() {"Can Add", "Can Edit", "Can Delete", "Can Void", "Can PrintPreview", "Can Print"})
                End With
            Catch ex As Exception

            End Try

            PrepareUserSecurityInfo(Me.txtPK.Text)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub UserSetupForm_AfterRecordAdd() Handles MyBase.AfterRecordAdd
        PrepareUserSecurityInfo(Me.txtPK.Text)
        ResetPermissions()
    End Sub

    Private Sub ResetPermissions()
        LoadingPermissions = True
        For i As Integer = 0 To lstPermissions.Items.Count - 1
            lstPermissions.SetItemChecked(i, False)
        Next

        LoadingPermissions = False
    End Sub

    Private Sub PrepareUserSecurityInfo(ByVal RecordPK As String)
        Try
            LoadingData = True
            If dsSecurity Is Nothing Then dsSecurity = New DataSet
            If connSecurity Is Nothing Then
                connSecurity = DBFactory.GetConnection(AppData.DBProvider)
                connSecurity.ConnectionString = AppData.ConnectionString
            End If

            If Not IsNothing(dsSecurity.Tables("User Permissions")) Then
                dsSecurity.Tables("User Permissions").Clear()
            End If

            If Not daSecurity Is Nothing Then
                daSecurity = Nothing
                cbSecurity = Nothing
            End If

            daSecurity = DBFactory.GetDataAdapter(AppData.DBProvider)
            daSecurity.SelectCommand = DBFactory.GetCommand(AppData.DBProvider)
            daSecurity.SelectCommand.CommandType = CommandType.Text
            daSecurity.SelectCommand.CommandText = "Select PK_ScrtyPrm, FK_Role_ScrtyPrm,FormCaption_ScrtyPrm,Rights_ScrtyPrm FROM security_permissions Where FK_Role_ScrtyPrm = '" & RecordPK & "'"
            daSecurity.SelectCommand.Connection = connSecurity

            cbSecurity = DBFactory.GetCommandBuilder(AppData.DBProvider)
            cbSecurity.DataAdapter = daSecurity

            daSecurity.Fill(dsSecurity, "User Permissions")

            lstMenuItems.DataSource = dsSecurity.Tables("User Permissions")
            lstMenuItems.ValueMember = "PK_ScrtyPrm"
            lstMenuItems.DisplayMember = "FormCaption_ScrtyPrm"
            lstMenuItems.Refresh()
            LoadAvailableMenus()
            LoadingData = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadAvailableMenus()
        Try

            lstSystemWindows.Items.Clear()

            For Each FormName As String In AppMainForm.MenuAndForms
                If Not lstSystemWindows.Items.Contains(FormName) Then lstSystemWindows.Items.Add(FormName)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try
            With lstSystemWindows

                For i As Integer = 0 To lstSystemWindows.Items.Count - 1
                    CType(lstMenuItems.DataSource, DataTable).Rows.Add(New Object() {GenerateSystemPK(), Me.txtPK.Text, .Items(i), ""})
                Next
                lstSystemWindows.Items.Clear()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            With lstSystemWindows
                Dim lstSelectedItems() As String = .SelectedItems.Cast(Of String)().ToArray
                For Each frm As String In lstSelectedItems
                    CType(lstMenuItems.DataSource, DataTable).Rows.Add(New Object() {GenerateSystemPK(), Me.txtPK.Text, frm, ""}) '.Items(i).ToString, ""})
                    lstSystemWindows.Items.Remove(frm)
                Next

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            Dim tmpSelected As ArrayList = New ArrayList

            'get Selected Indices and Add Corresponding item to SystemWindowsList
            For Each indx As Integer In lstMenuItems.SelectedIndices
                tmpSelected.Add(indx)
                lstSystemWindows.Items.Add(lstMenuItems.GetItemText(indx))
            Next

            Dim View As IList = CType(lstMenuItems.DataSource, DataTable).DefaultView

            For i As Integer = tmpSelected.Count - 1 To 0 Step -1
                View.RemoveAt(CType(tmpSelected(i), Integer))
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Try

            Dim View As IList = CType(lstMenuItems.DataSource, DataTable).DefaultView

            While lstMenuItems.SelectedIndices.Count > 0
                View.RemoveAt(lstMenuItems.SelectedIndices(0))
            End While
            LoadAvailableMenus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            With DirectCast(lstMenuItems.DataSource, DataTable)
                Dim GrantedPermissions As String = getPermissions()
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i)("Rights_ScrtyPrm") = GrantedPermissions
                Next
            End With

            XtraMessageBox.Show("User Rights Syncronized...", "Sync Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

        End Try
    End Sub

    Private Function getPermissions() As String
        Dim resString As String = ""
        Try

            For i As Integer = 0 To lstPermissions.CheckedIndices.Count - 1
                resString &= lstPermissions.GetItemText(lstPermissions.CheckedIndices(i)) & ";"
            Next
        Catch ex As Exception

        End Try
        Return resString
    End Function

    Protected Overrides Sub SaveDetailRecords()
        'MyBase.SaveDetailRecords()
        Try
            Saving = True
            daSecurity.Update(dsSecurity, "User Permissions")
            dsSecurity.Tables("User Permissions").AcceptChanges()
            Saving = False
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub AddRecord()
        MyBase.AddRecord()

        If Me.FormState = EditorState.AddMode Then EnablePermissionControls(True)

    End Sub

    Protected Overrides Sub EditRecord()
        MyBase.EditRecord()
        If Me.FormState = EditorState.EditMode Then EnablePermissionControls(True)
    End Sub

    Protected Overrides Sub ViewMode(Optional ByVal LeaveCurrecntRecordOpen As Boolean = False)
        MyBase.ViewMode(LeaveCurrecntRecordOpen)
        If Me.FormState = EditorState.ViewMode Then EnablePermissionControls(False)

    End Sub

    Private Sub EnablePermissionControls(ByVal blenable As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(New CrossThreadMethodDelegate(AddressOf Me.EnablePermissionControls), blenable)
        Else
            lstSystemWindows.Enabled = blenable
            lstMenuItems.Enabled = blenable
            lstPermissions.Enabled = blenable
            SimpleButton3.Enabled = blenable
            SimpleButton1.Enabled = blenable
            SimpleButton2.Enabled = blenable
            SimpleButton4.Enabled = blenable
            SimpleButton5.Enabled = blenable
        End If

    End Sub

    Private Sub lstMenuItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMenuItems.SelectedIndexChanged
        Try
            If Not LoadingData AndAlso Not Saving Then
                LoadingPermissions = True
                For i As Integer = 0 To lstPermissions.Items.Count - 1
                    lstPermissions.SetItemChecked(i, False)
                Next
                Dim row As DataRowView = CType(lstMenuItems.SelectedItem, DataRowView)
                SplitPermissions(row("Rights_ScrtyPrm").ToString)
                LoadingPermissions = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SplitPermissions(ByVal permissions As String)
        Try
            Dim PermissionsGranted() As String = permissions.Split(New String() {";"}, StringSplitOptions.RemoveEmptyEntries)
            For i As Integer = 0 To PermissionsGranted.Length - 1
                Debug.Print(PermissionsGranted(i))
                Dim indx As Integer = lstPermissions.FindString(PermissionsGranted(i))
                If indx <> -1 Then lstPermissions.SetItemChecked(indx, True)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UserSetupForm_AfterRecordOpen() Handles MyBase.AfterRecordOpen
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New CrossThreadMethodInvokerDelegate(AddressOf Me.DeleteGrantedMenuItems))
            Else
                DeleteGrantedMenuItems()
            End If
            PrepareUserSecurityInfo(Me.txtPK.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DeleteGrantedMenuItems()
        Try

            For i As Integer = 0 To lstMenuItems.ItemCount - 1
                If lstSystemWindows.Items.Contains(lstMenuItems.GetItemText(i)) Then lstSystemWindows.Items.Remove(lstMenuItems.GetItemText(i))
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstPermissions_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles lstPermissions.ItemCheck
        Try
            If Not LoadingPermissions Then
                CType(lstMenuItems.DataSource, DataTable).Rows(lstMenuItems.SelectedIndex)("Rights_ScrtyPrm") = getPermissions()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstSystemWindows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSystemWindows.SelectedIndexChanged

    End Sub

    Private Sub PtTextInputGroup4_Load(sender As Object, e As EventArgs) 

    End Sub
End Class
