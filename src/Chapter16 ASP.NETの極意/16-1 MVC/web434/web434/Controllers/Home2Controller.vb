Imports System.Web.Mvc

Namespace Controllers
    Public Class Home2Controller
        Inherits Controller

        ' GET: Home2
        Function Index() As ActionResult
            ViewData("Message") = "コントローラーでメッセージを設定します"
            Return View()
        End Function
    End Class
End Namespace