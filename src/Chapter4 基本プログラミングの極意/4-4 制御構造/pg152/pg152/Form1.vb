Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Select Case ComboBox1.Text
            Case "オレンジ"
                BackColor = Color.Orange
            Case "ブルー"
                BackColor = Color.Blue
            Case "イエロー"
                BackColor = Color.Yellow
            Case Else
                BackColor = Color.Empty
        End Select
    End Sub
End Class
