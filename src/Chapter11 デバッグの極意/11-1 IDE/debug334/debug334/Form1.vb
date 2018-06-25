Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim pa = New Person With {
            .Name = "増田智明",
            .Age = 49,
            .City = "板橋区",
            .Xml = New XElement(
                "person",
                New XElement("Name", "増田智明"),
                New XElement("Age", "49"),
                New XElement("City", "板橋区"))
        }
    End Sub
End Class

Public Class Person
    Public Property Name As String
    Public Property Age As String
    Public Property City As String
    Public Property Xml As XElement
End Class
