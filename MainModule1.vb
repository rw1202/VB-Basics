Module MainModule1
  
    
    Sub Main() 
        Dim products As New ArrayList From {
        New Product() With { .ProductId=1, .Name="10 Speed Bike", .IsActive=True
                },      
        New Product() With { .ProductId=2, .Name="Bike Helmet", .IsActive=True
            },        
        New Product() With { .ProductId=3, .Name="Inner Tube", .IsActive=True
            }
                }
        Console.WriteLine(DirectCast(products(0), Product).Name)
        Console.WriteLine(DirectCast(products(1), Product).Name)
        Console.WriteLine(DirectCast(products(2), Product).Name)

'        DirectCast tells the program what data type products is as an arrayList is 
'        untyped (without dataType)

        Console.ReadKey()
        End Sub

'        ARRAY
'    Sub Main()
'        Dim products(3) As String
'
'        products (0) = "10 Speed Bike"
'        products (1) = "Bike Helmet"
'        products (2) = "Inner Tube"
'        OR
'        Dim products As String() = 
'                { "10 Speed Bike" ,"Bike Helmet" ,"Inner Tube"}
'        Console.WriteLine(products(0))
'        Console.WriteLine(products(1))
'        Console.WriteLine(products(2))
'
'        Console.WriteLine(products.Length)
'        Console.ReadKey()
'    End Sub

'    Sub Main()
'        Dim prod As New Product With {
'                .ProductID = 700,
'                .Name= "Bike Lock",
'                .ProductNumber= "10-Sp"
'                }
'        Console.WriteLine(prod.ToString())
'
'        Dim cust As New Customer With{
'                .CustomerID= 1,
'                .CompanyName= "Beach Computer Consulting",
'                .FirstName= "Bruce",
'                .LastName= "Jones"
'                }
'
'        Console.WriteLine(cust.ToString())
'      
'       Vehicle.TenSpBike()
'        Vehicle.Mercedes()
'        Vehicle.Audi()
'        Console.WriteLine(Product.CalculateTheProfit(900, 1400))
'        Console.ReadKey()
'    End Sub

End Module
