Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        MonthCalendar1.MaxSelectionCount = 15
    End Sub

    Private Sub Button1_Click(sender As Object,
    e As EventArgs) Handles Button1.Click
        Dim startDay As DateTime = MonthCalendar1.SelectionStart
        Dim endDay As DateTime = MonthCalendar1.SelectionEnd
        Label1.Text = startDay.ToLongDateString
        Label2.Text = endDay.ToLongDateString
        Label3.Text = endDay.Subtract(startDay).Days + 1
    End Sub
End Class
