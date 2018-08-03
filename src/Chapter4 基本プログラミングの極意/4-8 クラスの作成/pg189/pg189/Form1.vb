Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim tel = New SampleClassTel("山田はなこ", "090-XXXX-XXXX")
        tel.ShowData()       '派生クラスのメソッド
    End Sub
End Class

'基本クラス
Public Class SampleClass
    Public Property Name As String
    Public Property Id As String
    'コンストラクター
    Public Sub New(name As String)
        Me.Name = name
        Me.Id = DateTime.Now.ToString("yyMMddHHmm")
    End Sub
    'オーバーライド可能なメソッド
    Public Overridable Sub ShowData()
        MessageBox.Show($"お客様氏名：{Id}-{Name}", "確認")
    End Sub
End Class
'派生クラス
Public Class SampleClassTel
    Inherits SampleClass
    Public Property Tel As String

    'コンストラクター
    Public Sub New(name As String, tel As String)
        MyBase.New(name)
        Me.Tel = tel
    End Sub
    'オーバーライドしたメソッド
    Public Overrides Sub ShowData()
        MyBase.ShowData()
        '基本クラスのメソッドを呼び出す
        MessageBox.Show($"お客様電話番号：{Tel}", "確認")
    End Sub
End Class