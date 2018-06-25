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
        ViewBag.Message = ""
        If String.IsNullOrEmpty(model.Title) Or model.Price = 0 Then
            ViewBag.Message = "タイトルと価格を入力してください"
            Return View("Input", model)
        Else
            ' 結果ページを表示
            Return View("Result", model)
        End If
    End Function

    Function Result() As ActionResult
        Return View()
    End Function

End Class
