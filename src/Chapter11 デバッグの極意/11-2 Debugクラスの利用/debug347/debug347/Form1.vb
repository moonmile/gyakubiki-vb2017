Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim eLog = New EventLogTraceListener("Debug347")
        Debug.Listeners.Add(eLog)
        ' 出力先を追加する
        Debug.WriteLine("Button1がクリックされました。")
        Debug.Flush()
        MessageBox.Show("イベントログに出力しました。", "通知")
    End Sub
End Class
