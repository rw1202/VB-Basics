Imports System.Data.Odbc

Public Class Loops

    Public Shared Function DewItWhile() As String
    Dim products As List(Of Product) = Lists.LoadProducts()
    Dim index As Integer =0
    Dim sum As Decimal = 0

    Do While  index < (products.Count -1)
    Console.WriteLine(products(index).ToString())
    sum += products(index).ListPrice

    index += 1
    Loop
    Console.WriteLine ("Sum: " & sum.ToString("c"))
    Console.ReadKey()
        End Function

    Public Shared Function DewIt() As String
        Dim products As List(Of Product) = Lists.LoadProducts()
        Dim index As Integer =0
        Dim sum As Decimal = 0
        Do 
            Console.WriteLine(products(index).ToString())
            sum += products(index).ListPrice
            index+=1
        Loop While index< (products.Count-1)

        Console.WriteLine("Sum: " & sum.ToString("c"))

        Console.ReadKey()
        End Function

'    Do until count is > index, Do Loop Until count > Index

    Public Shared Function ForL() As String
        Dim products As List(Of Product) = Lists.LoadProducts()
        For index As Integer = 0 To (products.Count -1) 
            Dim sum As Decimal = 0
            sum += products(index).ListPrice
            Console.WriteLine(products(index).ToString())

            Console.WriteLine("Sum: " & sum.ToString("c"))
        Next
'        Above Keyword "Next" will automatically increment through the List
        Console.ReadKey()
        End Function

    Public Shared Function ForE() As String 
        Dim products As List(Of Product) = Lists.LoadProducts()
        For Each prod As Product In products
            Console.WriteLine(prod.ToString)
        Next
        Console.Readkey()
    End Function
                End Class
