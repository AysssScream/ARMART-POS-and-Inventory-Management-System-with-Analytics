Imports FontAwesome.Sharp

Public Class Payment
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

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button00.Click, Button0.Click
        txtTender.Text += CType(sender, IconButton).Text
    End Sub

    Private Sub Button1000_Click(sender As Object, e As EventArgs) Handles Button500.Click, Button200.Click, Button1000.Click, Button100.Click
        txtTender.Text = CType(sender, IconButton).Text
    End Sub

    Private Sub ButtonClr_Click(sender As Object, e As EventArgs) Handles ButtonClr.Click
        txtTender.Text = ""
    End Sub

    Private Sub ButtonDel_Click(sender As Object, e As EventArgs) Handles ButtonDel.Click
        Try
            If txtTender.Text.Length > 0 Then
                txtTender.Text = txtTender.Text.Substring(0, txtTender.Text.Length - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtTender.Text = ""
        txtTender.Focus()
    End Sub

    Private Sub Payment_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtTender.Text = ""
        txtTender.Focus()
    End Sub

    Private Sub txtTender_EditValueChanged(sender As Object, e As EventArgs) Handles txtTender.EditValueChanged
        Try
            Dim totalSales As Double = StrVal9(txtTotalSales.Text)
            Dim tenderAmount As Double = StrVal9(txtTender.Text)
            txtChange.Text = StrVal9(tenderAmount - totalSales).ToString("n2")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        If StrVal9(txtTender.Text) >= StrVal9(txtTotalSales.Text) Then
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("Tender amount should be greater than or equal to Total Sales.")
        End If
    End Sub

    Private Sub Payment_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If StrVal9(txtTender.Text) >= StrVal9(txtTotalSales.Text) Then
                    Me.DialogResult = DialogResult.OK
                Else
                    MsgBox("Tender amount should be greater than or equal to Total Sales.")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
