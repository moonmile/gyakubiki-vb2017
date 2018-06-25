Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ' 現在時刻を保持しておく
        Session("現在時刻") = DateTime.Now
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
End Class
