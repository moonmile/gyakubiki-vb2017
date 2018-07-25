Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dynamicX As Object
        'string型の引数を渡す。
        dynamicX = sampleMethod("Sample")
        label1.Text = dynamicX.ToString()
        'int型の引数を渡す。
        dynamicX = sampleMethod(15)
        label2.Text = dynamicX
    End Sub
    Private Function sampleMethod(x As Object) As Object
        If TypeOf x Is String Then
            'int型の戻り値
            Return 365
        Else
            'string型の戻り値
            Return "return"
        End If
    End Function
End Class
