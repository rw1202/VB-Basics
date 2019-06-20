Public Class Vehicle
    Inherits Product
     
   
    Public Shared Sub Audi()
        Dim Audi As New Product
                
        Audi.IsActive= True
        Audi.ListPrice= 30000.00d
        Audi.Name= "Audi"
        Audi.ProductNumber= "2"
        Audi.SellStartDate= DateTime.Now
        

        Console.WriteLine(Audi.Name & " " &"£"& Audi.ListPrice &" "& Audi.SellStartDate)
    End Sub

    Public Shared Sub Mercedes()
        Dim Mercedes As New Product
        Mercedes.IsActive= True
        Mercedes.ListPrice= 20000.00d
        Mercedes.Name= "Mercedes"
        Mercedes.ProductNumber= "3"
        Mercedes.SellStartDate= DateTime.Now
        Console.WriteLine(Mercedes.Name & " " &"£"& Mercedes.ListPrice &" "& Mercedes.SellStartDate)
    End Sub

    Public Shared Sub TenSpBike()
        Dim TenSpBike As New Product
        TenSpBike.IsActive= True
        TenSpBike.ListPrice= 999.99d
        TenSpBike.Name= "TenSpBike"
        TenSpBike.ProductNumber= "1"
        TenSpBike.SellStartDate= DateTime.Now
        Console.WriteLine(TenSpBike.Name & " " &"£"& TenSpBike.ListPrice & " " & TenSpBike.SellStartDate)
    End Sub


End Class
