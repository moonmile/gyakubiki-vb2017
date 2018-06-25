Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        RadioButton4.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim myRB1, myRB2 As RadioButton
        Dim myText1 As String = "" : Dim myText2 As String = ""

        For Each myRB1 In GroupBox1.Controls
            If myRB1.Checked Then
                myText1 = myRB1.Text
                Exit For
            End If
        Next
        For Each myRB2 In GroupBox2.Controls
            If myRB2.Checked Then
                myText2 = myRB2.Text
                Exit For
            End If
        Next
        Label2.Text = "サイズ：" & myText1 & ControlChars.CrLf &
                  "　色　：" & myText2
    End Sub
End Class
