Public Class Customer
    Inherits CommonBase 
    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String
    Sub New()
        MyBase.New()
        CustomerID = 2
        FirstName= "James"
        LastName= "Bond"
        CompanyName= "DW"
    End Sub

    Protected Overrides Function GetClassData() As String
        Dim data As New Text.StringBuilder(1024)

        data.AppendLine("Customer ID: " + CustomerID.ToString())
        data.AppendLine("Company Name: " + CompanyName.ToString())
        data.AppendLine("First Name: " + FirstName.ToString())
        data.AppendLine("Last Name: " + LastName.ToString())
        data.AppendLine(MyBase.GetClassData())

        Return data.ToString()
    End Function

End Class
