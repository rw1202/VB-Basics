Public Class LibraryFunctions1
    Public Shared Function LibraryFunctions() As Dictionary(Of Integer, Product)
    Dim products = ListsFunctions.LoadProductsLib()
'        Sum of all List Prices 
        Console.WriteLine(
            products.Sum(Function(p)
                Return p.Value.ListPrice
                         End Function).ToString("c"))


'        Display the average of all List Prices
        Console .WriteLine(products.Average(Function (p)
                                                Return p.Value.ListPrice
                                            End Function).ToString("c"))
        

    Console.WriteLine(products.Count)
    Console.WriteLine(products.ContainsKey(1))
'True Or False. Will be true
    Console.ReadKey()

    products.Remove(1)

    products.Clear()

    Console.WriteLine(products.Count)

    Console.ReadKey()
        End Function 
End Class
