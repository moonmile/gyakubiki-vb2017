Public Class Form1

    Private Function sampleMethod(x As Object) As Object
        If TypeOf x Is String Then
            'int型の戻り値
            Return 365
        Else
            'string型の戻り値
            Return "文字列を返す"
        End If
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) _
        Handles button1.Click
        Dim o As Object
        'string型の引数を渡す。
        o = sampleMethod("Sample")
        Label1.Text = o.ToString()
        'int型の引数を渡す。
        o = sampleMethod(15)
        Label2.Text = o
    End Sub
End Class
