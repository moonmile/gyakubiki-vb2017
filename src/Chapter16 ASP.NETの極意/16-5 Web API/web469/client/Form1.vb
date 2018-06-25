Imports System.Net.Http

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) _
    Handles button1.Click
        Dim port = Integer.Parse(TextBox5.Text)
        Dim id = textBox1.Text
        Dim uri = New Uri("http://localhost:" & port & "/api/Books/" & id)
        Dim cl = New HttpClient()
        Dim res = Await cl.GetAsync(uri)
        label5.Text = Await res.Content.ReadAsStringAsync()
    End Sub
End Class
