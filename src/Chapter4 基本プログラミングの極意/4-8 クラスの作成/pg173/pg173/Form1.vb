Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj = New SampleClass("新規お客様")

        'Nameプロパティに値を設定してから取得する
        obj.Name = "山田はなこ"
        MessageBox.Show("Nameプロパティの値： " + obj.Name, "確認")
    End Sub
End Class
'SampleClassクラス
Public Class SampleClass
    Private _name As String

    'thisNameの値を設定/取得するプロパティ
    Public Property Name() As String
        Get
            'thisNameプロパティの値を返す
            Return _name
        End Get
        Set
            'thisNameプロパティの値を設定
            _name = Value
        End Set
    End Property

    'クラスのコンストラクター
    Public Sub New(cName As String)
        _name = cName
    End Sub
End Class
