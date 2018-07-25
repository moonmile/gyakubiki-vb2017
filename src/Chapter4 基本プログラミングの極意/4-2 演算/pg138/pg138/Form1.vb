Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        For Each o As Control In Controls
            If TypeOf o Is CheckBox Then 'CheckBoxと等しい場合
                'プロパティの値を変更
                o.Text = "Clicked!"
            End If
        Next
    End Sub
End Class
