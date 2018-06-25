Imports System.Web.Mvc

Namespace Controllers
    Public Class Home2Controller
        Inherits Controller

        ' GET: Home2
        Function Index() As ActionResult
            Dim model = New SampleModel With {
            .Title = "Hello ASP.NET MVC World."
        }
            Return View(model)
        End Function
    End Class
End Namespace