Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Debug.WriteLine("インデント前")
        Debug.Indent()
        Debug.WriteLine("インデント1回目")
        Debug.Indent()
        Debug.WriteLine("インデント2回目")
        Debug.Unindent()
        Debug.WriteLine("インデントを1回戻した後")
        Debug.Unindent()
        Debug.WriteLine("インデントを2回戻した後")
    End Sub
End Class
