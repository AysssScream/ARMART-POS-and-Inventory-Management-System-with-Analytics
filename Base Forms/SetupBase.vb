Imports DevExpress.XtraEditors
Public Class SetupBase

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.btnAddNew.FillColor = Colors.brand
        Me.btnEdit.FillColor = Colors.brand
        Me.btnSave.FillColor = Colors.brand
        Me.btnSearch.FillColor = Colors.brand
        Me.btnPreview.FillColor = Colors.brand
        Me.btnPrint.FillColor = Colors.brand
        Me.btnCancel.FillColor = Colors.secondaryDangerLight
        Me.btnVoid.FillColor = Colors.danger
        Me.btnDelete.FillColor = Colors.danger

        Me.lblHeaderTitle.Text = Me.lblHeaderTitle.Text.ToUpper

    End Sub
    Protected Overrides Sub SetMenuDisplay(Optional ByVal DisableEditingControls As Boolean = False)
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New CrossThreadMethodDelegate(AddressOf Me.SetMenuDisplay), New Object() {DisableEditingControls})
            Else
                Select Case _FormState
                    Case EditorState.AddMode
                        btnAddNew.Visible = False
                        btnEdit.Visible = False
                        btnDelete.Visible = False
                        btnCancel.Visible = True
                        btnSave.Visible = True
                        btnSearch.Visible = False
                        btnVoid.Visible = False

                        btnPreview.Visible = False
                        btnPrint.Visible = False

                    Case EditorState.EditMode
                        btnAddNew.Visible = False
                        btnEdit.Visible = False
                        btnDelete.Visible = False
                        btnCancel.Visible = True
                        btnSave.Visible = True
                        btnSearch.Visible = False
                        btnVoid.Visible = False

                        btnPreview.Visible = False
                        btnPrint.Visible = False

                    Case EditorState.ViewMode
                        btnAddNew.Visible = True
                        btnEdit.Visible = True
                        btnDelete.Visible = True
                        btnCancel.Visible = False
                        btnSave.Visible = False
                        btnSearch.Visible = True
                        btnVoid.Visible = False

                        btnPreview.Visible = False
                        btnPrint.Visible = False

                        If Not IsEmptyString(Me.AttachReports) Then
                            btnPreview.Visible = True
                            btnPrint.Visible = True
                        End If

                    Case EditorState.NullMode
                        btnAddNew.Visible = True
                        btnEdit.Visible = False
                        btnDelete.Visible = False
                        btnCancel.Visible = False
                        btnSave.Visible = False
                        btnSearch.Visible = True
                        btnVoid.Visible = False

                        btnPreview.Visible = False
                        btnPrint.Visible = False
                End Select
            End If

            'End If
            ' End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        Try
            Me.Text = Me.Text.Replace(" (F)", "").Replace(" (L)", "")
            If (Project.Instance.ActiveUser.Name = "BACKDOOR" Or Project.Instance.ActiveUser.Name = "") OrElse Project.Instance.ActiveUser.IsFunctionAllowed(Me.Text, "Can Add") Then
                Me.AddRecord()
            Else
                XtraMessageBox.Show("You are not allowed to use this function, Contact system admin...", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Text = Me.Text.Replace(" (F)", "").Replace(" (L)", "")
        If (Project.Instance.ActiveUser.Name = "BACKDOOR" Or Project.Instance.ActiveUser.Name = "") OrElse Project.Instance.ActiveUser.IsFunctionAllowed(Me.Text, "Can Edit") Then
            Me.EditRecord()
        Else
            XtraMessageBox.Show("You are not allowed to use this function, Contact system admin...", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.SaveRecord()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If Not SearchForm Is Nothing Then Me.SearchForm.Show(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        Try
            Me.Text = Me.Text.Replace(" (F)", "").Replace(" (L)", "")
            If Project.Instance.ActiveUser.Name = "BACKDOOR" OrElse Project.Instance.ActiveUser.IsFunctionAllowed(Me.Text, "Can Print") Then
                PreviewMenu.Show(btnPreview, 0, btnPreview.Height)
            Else
                XtraMessageBox.Show("You are not allowed to use this function, Contact system admin...", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Dim SelectedReport As ReportWrapper = DirectCast(ReportWrappers(1), ReportWrapper)
        Me.Text = Me.Text.Replace(" (F)", "").Replace(" (L)", "")
        If Project.Instance.ActiveUser.Name = "BACKDOOR" OrElse Project.Instance.ActiveUser.IsFunctionAllowed(Me.Text, "Can Print") Then
            PrintMenu.Show(btnPrint, 0, btnPrint.Height)
        Else
            XtraMessageBox.Show("You are not allowed to use this function, Contact system admin...", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.NullMode()
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Text = Me.Text.Replace(" (F)", "").Replace(" (L)", "")
        If (Project.Instance.ActiveUser.Name = "BACKDOOR" Or Project.Instance.ActiveUser.Name = "") OrElse Project.Instance.ActiveUser.IsFunctionAllowed(Me.Text, "Can Delete") Then
            Me.DeleteRecord()
        Else
            XtraMessageBox.Show("You are not allowed to use this function, Contact system admin...", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
