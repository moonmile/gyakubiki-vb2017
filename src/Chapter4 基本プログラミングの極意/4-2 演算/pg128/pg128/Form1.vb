Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For Each myObj As Control In Controls
            If TypeOf myObj Is Button Then 'Buttonと等しい場合
                'プロパティの値を変更
                myObj.Text = "Clicked!"
            End If
        Next
    End Sub
End Class
