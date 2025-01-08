Public Class SalesReports

    'Handles GunaButton9.Click, GunaButton11.Click
    Private Sub GunaButton9_Click_1(sender As Object, e As EventArgs) 
        Me.PtDateFilter1.ReplaceDateField = "datedue_transh"
    End Sub

    Private Sub GunaButton12_Click(sender As Object, e As EventArgs) 
        Try
            Me.PtDateFilter1.IsBlankDate = True
            If PtDateFilter1.cboFilterType.Text <> "As Of" Then
                MsgBox("You need to change the date filter to 'As Of'")
                isProceedPrint = False
            Else
                isProceedPrint = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblHeaderTitle_Click(sender As Object, e As EventArgs) Handles lblHeaderTitle.Click

    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

    End Sub
End Class
