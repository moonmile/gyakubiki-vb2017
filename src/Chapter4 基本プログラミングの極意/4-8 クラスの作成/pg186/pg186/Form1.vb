Public Class Form1
    Private o As New SampleClass
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        ' イベントにイベントハンドラーを追加する
        AddHandler o.MyEvent, AddressOf o_MyEvent
    End Sub
    ''' <summary>
    ''' イベント発生
    ''' </summary>
    ''' <param name="s"></param>
    Private Sub o_MyEvent(s As String)
        Label1.Text = s
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        'Class1クラスのメソッドを実行する（イベントが発生）
        o.proc()
    End Sub
End Class

Class SampleClass
    'イベントを定義する
    Public Event MyEvent As Action(Of String)
    Public Sub proc()
        Dim msg As String = DateTime.Now.ToString("HH:mm:ss")
        'イベントを発生させる
        RaiseEvent MyEvent(msg)
    End Sub
End Class
