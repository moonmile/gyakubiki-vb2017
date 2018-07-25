Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim tel = New SampleClassTel("山田はなこ", "090-XXXX-XXXX")
        tel.ShowData()       '派生クラスのメソッド
    End Sub
End Class
'派生クラス
Public Class SampleClassTel
    Inherits SampleClass
    Private _tel As String

    'コンストラクター
    Public Sub New(name As String, tel As String)
        MyBase.New(name)
        _tel = tel
    End Sub

    'オーバーライドしたメソッド
    Public Overrides Sub ShowData()
        MyBase.ShowData()
        '基本クラスのメソッドを呼び出す
        MessageBox.Show("お客様電話番号：" & _tel, "確認")
    End Sub
End Class

'基本クラス
Public Class SampleClass
    Private _name As String
    Private _id As String

    'コンストラクター
    Public Sub New(cName As String)
        _name = cName
        _id = DateTime.Now.ToString("yyMMddHHmm")
    End Sub

    'オーバーライド可能なメソッド
    Public Overridable Sub ShowData()
        MessageBox.Show("お客様氏名：" & _id & "-" & _name, "確認")
    End Sub
End Class
