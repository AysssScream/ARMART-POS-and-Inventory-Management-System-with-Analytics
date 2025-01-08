Public Class Product
    Private Sub Product_AfterRecordSave() Handles Me.AfterRecordSave
        UpdateInventory(txtPK.Text)
    End Sub

    Private Sub Product_BeforeRecordSave(ByRef Cancel As Boolean) Handles MyBase.BeforeRecordSave
        Try
            Dim pu As Boolean = False
            Dim su As Boolean = False
            With sg__inventory_units
                If .RowCount = 0 Then
                    Cancel = True
                    MsgBox("You need to add units for the product.")
                    Exit Sub
                End If

                For i As Integer = 0 To .RowCount - 1
                    .RowPosition = i
                    If StrVal9(.Field("IsPurchaseUnit_InvtyU")) = 1 Then
                        pu = True
                        txtStockUnit.PtTextInputGrp1.Text = .Field("Unit_InvtyU").ToString
                        txtStockCoversion.PtNumericInput1.Value = .Field("Conversion_InvtyU")
                    End If
                    If StrVal9(.Field("IsSellingUnit_InvtyU")) = 1 Then
                        su = True
                        txtBaseUnit.PtTextInputGrp1.Text = .Field("Unit_InvtyU").ToString
                        txtBaseConversion.PtNumericInput1.Value = .Field("Conversion_InvtyU")
                    End If
                Next

                If Not su Or Not pu Then
                    Cancel = True
                    MsgBox("You need to specify the purchase unit and sale unit of the product.")
                    Exit Sub
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XtraTabControl1.TabPages.RemoveAt(1)
    End Sub
End Class
