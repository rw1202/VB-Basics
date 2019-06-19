Public Module TenSpBike
   Public Sub Main()
        Dim ProductID As Integer= 1
        Dim isActive As Boolean= DEFAULT_ACTIVE
        Dim Name As String  = "10 Speed Bike"
        Dim ListPrice As Decimal = DEFAULT_LIST_PRICE
        Dim SellStartDate As DateTime = #1/1/2019#

       Console.WriteLine(ProductID)
       Console.WriteLine(Name)
       Console.WriteLine(isActive)
       Console.WriteLine(ListPrice)
       Console.WriteLine(SellStartDate)

       Console.ReadKey()
    End Sub
   
End Module
