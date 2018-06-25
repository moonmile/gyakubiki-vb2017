Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Index2() As ActionResult
        Dim lst = New List(Of MyModel)
        lst.Add(New MyModel() With {.ID = 1, .Title = "逆引き大全VB", .Price = 2000})
        lst.Add(New MyModel() With {.ID = 2, .Title = "逆引き大全C#", .Price = 1500})
        lst.Add(New MyModel() With {.ID = 3, .Title = "逆引き大全F#", .Price = 1000})
        lst.Add(New MyModel() With {.ID = 4, .Title = "リファレンス本", .Price = 1000})
        Return View(lst)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
