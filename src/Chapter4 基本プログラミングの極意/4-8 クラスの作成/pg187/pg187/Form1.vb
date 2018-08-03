Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        'インスタンスの生成と同時にプロパティの値を設定する
        Dim o As New SampleClass() With {
            .Name = "山田はなこ"
        }
        'プロパティの値を表示
        Label1.Text = o.Name
    End Sub
End Class

Public Class SampleClass
    Public Property Name As String
End Class
