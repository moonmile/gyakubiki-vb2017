Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
    Handles Button1.Click
        Dim cl = New HttpClient()
        cl.DefaultRequestHeaders.Add("Accept", "application/xml")
        Dim uri = New Uri("http://localhost:5000/api/Sample2")
        Dim dic = New Dictionary(Of String, String)()
        dic.Add("name", TextBox1.Text)
        dic.Add("age", TextBox2.Text)
        Dim content = New FormUrlEncodedContent(dic)
        Dim res = Await cl.PostAsync(uri, content)
        Dim doc = System.Xml.Linq.XDocument.Load(
        Await res.Content.ReadAsStreamAsync())
        TextBox3.Text = doc.Root.Elements()(1).Value
        TextBox4.Text = doc.Root.Elements()(0).Value
    End Sub
End Class
