Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    Function Input() As ActionResult
        Return View()
    End Function

    <HttpPost>
    Function Post(model As MyModel) As ActionResult
        ' 結果ページを表示
        Return View("Result", model)
    End Function

End Class
