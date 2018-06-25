Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim cl As New HttpClient()
        Dim uri As New Uri("http://localhost:5000/api/Sample")
        Dim dic As New Dictionary(Of String, String)()
        dic.Add("name", TextBox1.Text)
        Dim content = New FormUrlEncodedContent(dic)
        Dim res = Await cl.PostAsync(uri, content)
        TextBox2.Text = Await res.Content.ReadAsStringAsync()
    End Sub
End Class
