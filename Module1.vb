﻿Module MainModule2
    
    Sub Main()
        Dim products(3) As String

        products (0) = "10 Speed Bike"
        products (1) = "Bike Helmet"
        products (2) = "Inner Tube"

        Console.WriteLine(products(0))
        Console.WriteLine(products(1))
        Console.WriteLine(products(2))

        Console.WriteLine(products.Length)
        Console.ReadKey()
    End Sub

End Module
