Public Class Form1

End Class

Class SampleClass
    'イベントを定義する
    Public Event MyEvent As Action(Of Object, EventArgs)
    Public Event ev As EventHandler
    Public Sub MyMethod()
        Dim msg As String = DateTime.Now.ToString("HH:mm:ss")
        'イベントを発生させる
        RaiseEvent MyEvent(Me, EventArgs.Empty)
    End Sub
End Class

