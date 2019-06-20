Public Class Lists
    Public Shared Function LoadProducts() As List(Of Product)
        Dim products As New List(Of Product) From {
                New Product() With { .ProductId= 680, .Name= "HL Road Frame", .IsActive=True , .ListPrice= 100
                        },
                New Product() With { .ProductId= 650, .Name= "10 Speed Bike", .IsActive=True , .ListPrice= 1000
                        },
                New Product() With { .ProductId= 8, .Name= "Bike Helmet", .IsActive=True , .ListPrice= 25
                        },
                New Product() With { .ProductId= 101, .Name= "Inner Tube", .IsActive=True , .ListPrice= 100
                        },
                New Product() With { .ProductId= 858, .Name= "XL Tyre", .IsActive=True , .ListPrice= 100
                        }        
        }
        
        Console.WriteLine(products.Exists(Function(p) p.ProductID= 8))
'       Above should return true
        Console.WriteLine(products.Exists(Function(p) p.ProductID= 9))
'       Above should return false
      
       
   
        Console.ReadKey()
        Return products
    End Function

End Class
