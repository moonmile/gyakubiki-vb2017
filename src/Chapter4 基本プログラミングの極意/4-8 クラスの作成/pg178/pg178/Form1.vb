Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim tel = New SampleClassTel("山田はなこ", "090-XXXX-XXXX")
        MessageBox.Show("名前 　:  　" + tel.Name, "派生クラス")
    End Sub
End Class
'派生クラスの定義
Public Class SampleClassTel
    Inherits SampleClass
    Private _tel As String
    'コンストラクター（基本クラスのコンストラクターを呼び出す）
    Public Sub New(name As String, tel As String)
        MyBase.New(name)
        _tel = tel
    End Sub

    'Telの値を取得するプロパティ
    Public ReadOnly Property Tel() As String
        Get
            Return _tel
        End Get
    End Property
End Class

'基本クラスの定義
Public Class SampleClass
    Private _name As String
    Private _id As String
    'コンストラクター
    Public Sub New(cName As String)
        _name = cName
        _id = DateTime.Now.ToString("yymmddhhmm")
    End Sub

    'Nameの値を取得するプロパティ
    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property
End Class
