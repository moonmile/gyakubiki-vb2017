Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim num = 10.12345
        Dim myDate = DateTime.Now
        Label1.Text = myDate.ToString("yy/MM/dd(ddd) HH:mm:ss")
        Label2.Text = myDate.ToString("tt h:m:s")
        Label3.Text = myDate.ToString("D")
        Label4.Text = num.ToString("#.#")
        Label5.Text = num.ToString("000.000")
        Label6.Text = num.ToString("0.00%")
        Label7.Text = num.ToString("C")
        Label8.Text = num.ToString("P")
    End Sub
End Class
