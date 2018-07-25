Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim student = New Integer(2)() {}      'ジャグ配列の宣言
        '0～2までの各要素を、それぞれ要素数と初期値を指定する
        student(0) = New Integer(2) {37, 35, 34}     '1年を3クラス分
        student(1) = New Integer(1) {41, 43}         '2年を2クラス分
        student(2) = New Integer(3) {33, 34, 33, 35} '3年を4クラス分
        listBox1.Items.Clear()
        For i As Integer = 0 To student.Length - 1
            listBox1.Items.Add((i + 1) & "年")
            For j As Integer = 0 To student(i).Length - 1
                listBox1.Items.Add(ControlChars.Tab & (j + 1) & "組：" & student(i)(j))
            Next
        Next
    End Sub
End Class
