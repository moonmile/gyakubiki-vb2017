Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname = TextBox1.Text
        Dim text = TextBox2.Text
        Using st = New StreamWriter(fname)
            st.WriteLine(DateTime.Now.ToString())   '日付
            st.Write(text) '出力データ
            st.WriteLine() '行終端文字
        End Using
        Label1.Text = "ファイルに出力しました。"
    End Sub
End Class
