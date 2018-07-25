Public Class Form1
    'Class1クラスのインスタンスを生成し、myClassに取得する
    Private obj As New Class1()
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        'イベントにイベントハンドラーを追加する
        AddHandler obj.MyEvent, AddressOf MyClass_MyEvent
        'Class1クラスのメソッドを実行する（イベントが発生）
        obj.myMethod()
    End Sub
    'Class1クラスのイベントmyEventのイベントハンドラー
    Private Sub MyClass_MyEvent(obj As String)
        label1.Text = obj
    End Sub
End Class
'Class1クラス
Class Class1
    'イベントを定義する
    Public Event MyEvent As Action(Of String)

    Public Sub myMethod()
        Dim msg As String = DateTime.Now.ToString("HH:mm:ss")
        'イベントを発生させる
        RaiseEvent MyEvent(msg)
    End Sub
End Class
