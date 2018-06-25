Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim a = 10
        Dim b = 0
        Try
            If b = 0 Then
                Throw New SampleException("0による除算はできません。")
            End If
            a = a / b
        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラー")
        End Try
    End Sub
End Class
Public Class SampleException
    Inherits Exception
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(msg As String)
        MyBase.New(msg)
    End Sub
    Public Sub New(msg As String, inner As Exception)
        MyBase.New(msg, inner)
    End Sub
End Class
