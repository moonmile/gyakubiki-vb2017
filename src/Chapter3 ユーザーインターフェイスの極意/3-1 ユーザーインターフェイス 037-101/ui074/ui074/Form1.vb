Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        Dim myArray() As String = {"A4用紙", "B3用紙", "B4用紙",
                           "クリアファイル", "修正液", "付箋"}
        ListBox1.Items.AddRange(myArray)
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        ListBox2.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim myList As Object
        '選択された項目をListBox2に追加
        For Each myList In ListBox1.SelectedItems
            ListBox2.Items.Add(myList)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object,
    e As EventArgs) Handles Button2.Click
        Dim i As Integer
        For i = ListBox1.Items.Count - 1 To 0 Step -1
            '指定したインデックスの項目が選択されていたら削除
            If ListBox1.GetSelected(i) Then
                ListBox1.Items.RemoveAt(i)
            End If
        Next
    End Sub

End Class
