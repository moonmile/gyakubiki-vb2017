Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim o = New SampleClass("新規お客様")
        'Nameプロパティに値を設定してから取得する
        o.Name = "山田はなこ"
        MessageBox.Show($"Nameプロパティの値： {o.Name}", "確認")
    End Sub
End Class

Public Class SampleClass
    Private _name As String
    '_nameの値を設定/取得するプロパティ
    Public Property Name() As String
        Get
            '_nameフィールドの値を返す
            Return _name
        End Get
        Set
            '_nameフィールドの値を設定
            _name = Value
        End Set
    End Property
    'クラスのコンストラクター
    Public Sub New(Name As String)
        _name = Name
    End Sub
End Class


Public Class SampleClass2
    Public Property Name As String
    Public Sub New(Name As String)
        Me.Name = Name
    End Sub
End Class