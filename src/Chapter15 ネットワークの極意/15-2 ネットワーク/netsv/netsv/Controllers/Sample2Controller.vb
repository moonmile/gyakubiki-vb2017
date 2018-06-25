Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class Sample2Controller
        Inherits ApiController

        ' GET api/values
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET api/values/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST api/values
        Public Function PostValue(<FromBody> ByVal a As Person) As Person
            a.Age = a.Age + 1
            Return a
        End Function

        ' PUT api/values/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE api/values/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub

    End Class
End Namespace