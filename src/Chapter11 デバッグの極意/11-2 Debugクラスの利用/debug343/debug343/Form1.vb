Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim tLis = New TextWriterTraceListener("C:\VB2017\Debug.txt")
        Debug.Listeners.Add(tLis)
        ' 出力先を追加する
        For i = 1 To 10
            Debug.WriteLine($"{i}回目")
        Next
        Debug.Flush()
        ' 出力バッファをフラッシュ
        MessageBox.Show("ファイルに出力しました。", "通知")
    End Sub
End Class
