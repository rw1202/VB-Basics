Public Class Decision
    Public Shared Function FoeIf() As String 
        Dim products= Lists.LoadProducts()
        
        For index As Integer =0 To (products.Count-1)
            If products(index).Name= "10 Speed Bike"
                Console.WriteLine("Name : " _
                              & products(index).Name.ToString())
                  Console.ReadKey()
            End If
         
        Next
        
    End Function

    Public Shared Function FoeElIf() As String
        Dim products = Lists.LoadProducts()

        For index As Integer = 0 To (products.Count-1)
            If products(index).Name = "10 Speed Bike"
                Console.WriteLine("Product Search (10 Speed Bike) : " _
                                  & products(index).ToString())
                Else 
                    Console.WriteLine("All Others: " _
                                      & products(Index).ToString())
            End If
           
        Next
        Console.ReadKey()
    End Function 

    Public Shared Function FoeElIfEl() As String
        Dim products = Lists.LoadProducts()
        Dim search100 As New List(Of Product)()
        Dim allOthers As New List (Of Product)()
        For index As Integer = 0 To (products.Count-1)
            If products(Index).Name="10 Speed Bike"
                Console.WriteLine("Product Search (10 Speed Bike): " _
                                  & products(Index).ToString())

                ElseIf products(Index).ListPrice = 100
                search100.Add(products(Index))
'                    
                    Else 
                     AllOthers.Add(products(Index))
                 
            End If
           
                            
        Next

        Console.WriteLine("Product Search (List Price 100): ")
        For Each element In search100
            Console.WriteLine(element.ToString())
        Next

        Console.WriteLine("All Others: " )
        For Each element In allOthers
            Console.WriteLine(element.ToString())
            
                              
        Next
        Console.ReadKey()
    End Function
   

End Class
