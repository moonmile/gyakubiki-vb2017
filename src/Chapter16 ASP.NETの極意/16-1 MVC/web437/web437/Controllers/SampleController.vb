Imports System.Web.Mvc

Namespace Controllers
    Public Class SampleController
        Inherits Controller

        ' GET: Sample
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace