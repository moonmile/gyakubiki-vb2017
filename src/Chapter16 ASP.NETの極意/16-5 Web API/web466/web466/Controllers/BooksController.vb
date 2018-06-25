Imports System.Net
Imports System.Web.Http

Public Class BooksController
    Inherits ApiController

    Private _lst As List(Of Book)
    Sub New()
        _lst = New List(Of Book)
        _lst.Add(New Book() With {
                 .ID = 1, .Title = "逆引き大全VB",
                 .Price = 2000, .Pages = 300})
        _lst.Add(New Book() With {
                 .ID = 2, .Title = "逆引き大全C#",
                 .Price = 1500, .Pages = 500})
        _lst.Add(New Book() With {
                 .ID = 3, .Title = "逆引き大全F#",
                 .Price = 1000, .Pages = 200})
        _lst.Add(New Book() With {
                 .ID = 4, .Title = "リファレンス本",
                 .Price = 1000, .Pages = 500})
    End Sub

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return _lst
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As Book
        Return _lst.FirstOrDefault(Function(x) x.ID = id)
    End Function

    ' POST api/<controller>
    Public Function PostValue(<FromBody()> ByVal value As Book)
        Return String.Format("post Title:{0}", value.Title)
    End Function

    ' PUT api/<controller>/5
    Public Function PutValue(ByVal id As Integer,
                             <FromBody()> ByVal value As Book)
        Return String.Format("put Title:{0}", value.Title)
    End Function

    ' DELETE api/<controller>/5
    Public Function DeleteValue(ByVal id As Integer)
        Return String.Format("delete ID:{0}", id)
    End Function
End Class
