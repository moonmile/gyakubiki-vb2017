Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim mc = New MyStruct(2) {}
        '構造体配列の宣言
        ListBox1.Items.Clear()
        'リストボックスをクリア
        For i As Integer = 0 To 2
            '各要素に値を代入して表示
            mc(i).CourseNo = (i + 1).ToString("00")
            mc(i).CourseName = "コース名未定"
            mc(i).Num = 20
            ListBox1.Items.Add(
                $"{mc(i).CourseNo}-{mc(i).CourseName}-{mc(i).Num}名")
        Next
    End Sub
End Class

Public Structure MyStruct
    '構造体を定義
    Public CourseNo As String
    Public CourseName As String
    Public Num As Integer
End Structure
