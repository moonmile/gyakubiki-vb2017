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

    ''' 別のビューを開く
    Function Other() As ActionResult
        ViewData("Message") = "これは Other method から開かれました"
        Return View("About")
    End Function

End Class
