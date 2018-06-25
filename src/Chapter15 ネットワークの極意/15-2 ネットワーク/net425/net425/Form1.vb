Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        Dim cl As New HttpClient()
        Dim uri As New Uri("http://localhost:5000/api/Sample/10")
        Dim res = Await cl.GetStringAsync(uri)
        TextBox1.Text = res
    End Sub
End Class
