' CriticalProductsForm.vb
Imports System.Data

Public Class CriticalProductsForm
    Private Sub CriticalProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCriticalProducts()
    End Sub

    Private Sub LoadCriticalProducts()
        Try
            ' Update the query to select all critical products.
            Dim sql As String = "Select Description_Invty, Name_Cat, Quantity_Invty From inventories Join categories On fk_cat_invty = pk_cat Where CAST(IFNULL(Quantity_Invty, 0) AS UNSIGNED) <= CAST(IFNULL(ReorderLevel_Invty, 0) AS UNSIGNED) Order By Quantity_Invty Asc"
            Dim dt As DataTable = AppData.GetDataTable(sql)

            ' Bind the data to a DataGridView or any other control to display the list
            DataGridViewCriticalProducts.DataSource = dt
        Catch ex As Exception
            ' Handle exceptions or log errors as needed
        End Try
    End Sub
End Class
