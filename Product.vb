Public Class Product
    Inherits CommonBase
    Sub New()
        ListPrice=560d

    End Sub
    Public Property ProductId As Integer
    Public Property ProductNumber As String
    Public Property Name As String
    Public Property ListPrice As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime

    Function CalculateSellEndDate(ByVal days As Integer) As DateTime
        CalculateSellEndDate = SellStartDate.AddDays(days)
        Return SellEndDate
    End Function

    Shared Function CalculateTheProfit (ByVal cost As Decimal, ByVal price As Decimal) As Decimal 
        Return price - cost 
    End Function

    Protected Overrides Function GetClassData() As String
        Dim data As New Text.StringBuilder(1024)

        data.AppendLine("Customer ID: " + ProductId.ToString())
        data.AppendLine("Name: " + Name.ToString() )
        data.AppendLine("List Price: " + ListPrice.ToString())
        data.AppendLine("Product Number: " + ProductNumber.ToString())
        data.AppendLine(MyBase.GetClassData())

        Return data.ToString()
    End Function

End Class
