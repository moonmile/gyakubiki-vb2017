Imports System.Net.Http

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) _
        Handles button1.Click
        Dim port = Integer.Parse(TextBox5.Text)
        Dim uri = New Uri("http://localhost:" & port & "/api/Books/")
        Dim cl = New HttpClient()
        Dim dic = New Dictionary(Of String, String)()
        dic.Add("ID", textBox1.Text)
        dic.Add("Title", textBox1.Text)
        dic.Add("Price", textBox1.Text)
        dic.Add("Pages", textBox1.Text)
        Dim content = New FormUrlEncodedContent(dic)
        Dim res = Await cl.PostAsync(uri, content)
        label5.Text = Await res.Content.ReadAsStringAsync()
    End Sub
End Class
