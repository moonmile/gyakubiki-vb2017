Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class SampleController
        Inherits ApiController

        ' GET api/values
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET api/values/5
        Public Function GetValue(ByVal id As Integer) As String
            Return String.Format("get ID is {0}", id)
        End Function

        ' POST api/values
        <HttpPost>
        Public Function PostValue(<FromBody()> ByVal a As Person) As String
            Return String.Format("post name is {0}", a.Name)
        End Function

        ' PUT api/values/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE api/values/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub

    End Class
    Public Class Person
        Public Property Name As String
        Public Property Age As Integer
    End Class
End Namespace