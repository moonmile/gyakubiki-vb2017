Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Index2() As ActionResult
        Dim model As New MyModel With {
            .ID = 100,
            .Title = "逆引き大全VB2017サンプル",
            .Price = 2000
        }
        Return View(model)
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
