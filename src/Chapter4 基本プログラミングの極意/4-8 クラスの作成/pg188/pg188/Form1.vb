Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim tel = New SampleClassTel("山田はなこ", "090-XXXX-XXXX")
        MessageBox.Show($"名前 　:  　{tel.Name}", "派生クラス")
    End Sub
End Class

'基本クラスの定義
Public Class SampleClass
    Public ReadOnly Property Name As String
    Public Property Id As String
    'コンストラクター
    Public Sub New(name As String)
        Me.Name = name
        Me.Id = DateTime.Now.ToString("yymmddhhmm")
    End Sub
End Class
'派生クラスの定義
Public Class SampleClassTel
    Inherits SampleClass
    Public ReadOnly Property Tel As String
    'コンストラクター（基本クラスのコンストラクターを呼び出す）
    Public Sub New(name As String, tel As String)
        MyBase.New(name)
        Me.Tel = tel
    End Sub
End Class
