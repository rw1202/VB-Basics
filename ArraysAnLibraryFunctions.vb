Public Class ArraysAnLibraryFunctions
    Public Shared Function LoadProductsLib As Dictionary(Of Integer, Product)
            Dim products As New Dictionary(Of  Integer, Product)
            Dim prod As Product


        prod = New Product()With { .ProductId=1, .Name="10 Speed Bike", .IsActive=True
               }
            products.Add(key := prod.ProductID, value:= prod)

        prod = New Product()With { .ProductId=2, .Name="Bike Helmet", .IsActive=True
               }
            products.Add(key := prod.ProductID, value:= prod)

        prod = New Product()With { .ProductId=3, .Name="Inner Tube", .IsActive=True
               }
            products.Add(key := prod.ProductID, value:= prod)
        Console.WriteLine(products(1).Name)
        Console.WriteLine(products(2).Name)
        Console.WriteLine(products(3).Name)

        Console.WriteLine(products.Count)
        Console.WriteLine(products.ContainsKey(1))
'True Or False. Will be true
'        Console.ReadKey()
'
'        products.Remove(1)
'
'        products.Clear()
'
'        Console.WriteLine(products.Count)
'


        Console.ReadKey()
            Return products
            End Function

       
    
   Public Shared Function  LoadProductsArrayL As ArrayList
        Dim products As New ArrayList From {
        New Product() With { .ProductId=1, .Name="1d0 Speed Bike", .IsActive=True
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
       Return products
        End Function 

'        ARRAY
   Public Shared Function LoadProductsArrayA As Array 
        Dim productsA(3) As String

        productsA (0) = "10 Speed Bike"
        productsA (1) = "Bike Helmet"
        productsA (2) = "Inner Tube"
'       
      Console.WriteLine(productsA(0))
      Console.WriteLine(productsA(1))
      Console.WriteLine(productsA(2))
     
        Console.ReadKey()
       Return productsA
    End Function 
'    OR
    Public Shared Function LoadProductsArrayB As Array
  Dim productsB As String() = 
                { "10 Speed Bike" ,"Bike Helmet" ,"Inner Tube"}
        Console.WriteLine(productsB(0))
        Console.WriteLine(productsB(1))
        Console.WriteLine(productsB(2))

        Console.WriteLine(productsB.Length)
        Console.ReadKey()
        Return productsB
        End Function

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

End Class
