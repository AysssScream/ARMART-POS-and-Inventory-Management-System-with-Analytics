Public Class OrderItem
    Private _ItemPK As String
    Private _ItemPrice As Double = 0
    Private _ItemCost As Double = 0
    Private _ItemConversion As Double = 0
    Private _ItemDiscount As Double = 0
    Private _ItemTax As Double = 0

    Public Event OnItemClicked(sender As Object, e As EventArgs)

    Public Property ItemPK() As String
        Get
            Return _ItemPK
        End Get
        Set(ByVal value As String)
            _ItemPK = value
        End Set
    End Property

    ''STOCK PRICE
    Public Property ItemPrice() As Integer
        Get
            Return _ItemPrice
        End Get
        Set(ByVal value As Integer)
            _ItemPrice = value
        End Set
    End Property

    ''STOCK COST
    Public Property ItemCost() As Integer
        Get
            Return _ItemCost
        End Get
        Set(ByVal value As Integer)
            _ItemCost = value
        End Set
    End Property

    Public Property ItemConversion() As Integer
        Get
            Return _ItemConversion
        End Get
        Set(ByVal value As Integer)
            _ItemConversion = value
        End Set
    End Property

    Public Property ItemDiscount() As Integer
        Get
            Return _ItemDiscount
        End Get
        Set(ByVal value As Integer)
            _ItemDiscount = value
        End Set
    End Property

    Public Property ItemTax() As Integer
        Get
            Return _ItemTax
        End Get
        Set(ByVal value As Integer)
            _ItemTax = value
        End Set
    End Property

    Private Sub ItemName_Click(sender As Object, e As EventArgs) Handles Label1.Click, ItemTotalPrice.Click, ItemTaxAmount.Click, ItemQty.Click, ItemName.Click, ItemDiscountAmount.Click, AddDescription.Click
        RaiseEvent OnItemClicked(Me, e)
    End Sub
End Class
