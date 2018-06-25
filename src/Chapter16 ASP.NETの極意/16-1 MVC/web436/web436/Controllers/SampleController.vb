Imports System.Web.Mvc

Namespace Controllers
    Public Class SampleController
        Inherits Controller

        ' GET: Sample
        Function Index() As ActionResult
            ViewData("Message") =
            String.Format("トップを開いた時刻：{0}", Session("現在時刻"))
            Return View()
        End Function
    End Class
End Namespace