Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        'インスタンスの生成と同時にプロパティの値を設定する
        Dim sc As New SampleClass() With {
            .Name = "山田はなこ"
        }
        label1.Text = sc.Name
        'プロパティの値を表示
    End Sub
End Class
'SampleClassクラス
Public Class SampleClass
    Private _name As String
    'thisNameの値を設定/取得するプロパティ
    Public Property Name() As String
        Get
            'thisNameの値を返す
            Return _name
        End Get
        Set
            'thisNameの値を設定
            _name = Value
        End Set
    End Property
End Class
