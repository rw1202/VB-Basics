Module MainModule1
  
    Sub Main()
        Dim prod As New Product With {
                .ProductID = 700,
                .Name= "Bike Lock",
                .ProductNumber= "10-Sp"
                }
        Console.WriteLine(prod.ToString())

        Dim cust As New Customer With{
                .CustomerID= 1,
                .CompanyName= "Beach Computer Consulting",
                .FirstName= "Bruce",
                .LastName= "Jones"
                }

        Console.WriteLine(cust.ToString())
      
       Vehicle.TenSpBike()
        Vehicle.Mercedes()
        Vehicle.Audi()
        Console.WriteLine(Product.CalculateTheProfit(900, 1400))
        Console.ReadKey()
    End Sub

End Module
