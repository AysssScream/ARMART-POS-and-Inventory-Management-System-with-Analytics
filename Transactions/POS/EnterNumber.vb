Public Class EnterNumber
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None
        Guna2ShadowForm1.SetShadowForm(Me)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub EnterNumber_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtNumber.Focus()
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (e.KeyChar <> "."c) AndAlso (e.KeyChar <> ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub EnterNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub EnterNumber_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtNumber.Focus()
        txtNumber.SelectAll()
    End Sub
End Class
