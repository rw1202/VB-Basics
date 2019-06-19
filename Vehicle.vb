Public Class Vehicle
    Public Shared Sub Audi()
        Dim Audi As New Product
        Audi._IsActive= True
        Audi._ListPrice= 30000.00d
        Audi._Name= "Audi"
        Audi._ProductNumber= 2
        Audi._SellStartDate= DateTime.Now

        Console.WriteLine(Audi._Name & " " & Audi._ListPrice)
    End Sub

    Public Shared Sub Mercedes()
        Dim Mercedes As New Product
        Mercedes._IsActive= True
        Mercedes._ListPrice= 20000.00d
        Mercedes._Name= "Mercedes"
        Mercedes._ProductNumber= 3
        Mercedes._SellStartDate= DateTime.Now
        Console.WriteLine(Mercedes._Name & " " & Mercedes._ListPrice )
    End Sub

    Public Shared Sub TenSpBike()
        Dim TenSpBike As New Product
        TenSpBike._IsActive= True
        TenSpBike._ListPrice= 999.99d
        TenSpBike._Name= "TenSpBike"
        TenSpBike._ProductNumber= 1
        TenSpBike._SellStartDate= DateTime.Now
        Console.WriteLine(TenSpBike._Name & " " & TenSpBike._ListPrice )
    End Sub


End Class
