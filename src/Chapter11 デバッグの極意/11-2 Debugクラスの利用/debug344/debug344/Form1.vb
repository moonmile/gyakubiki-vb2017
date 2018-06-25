Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim tLis = New TextWriterTraceListener("C:\VB2017\DebugAuto.txt")
        Debug.Listeners.Add(tLis)
        ' 出力先を追加する
        Debug.AutoFlush = True
        ' 自動的に出力する
        For i = 0 To 9
            Debug.WriteLine($"{i}回目")
        Next
        MessageBox.Show("ファイルに出力しました。", "通知")
    End Sub
End Class
