Imports Excel = Microsoft.Office.Interop.Excel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        Label1.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Open("C:\VB2017\data\BookTodo.xlsx")
        Dim sh As Excel.Worksheet = wb.ActiveSheet
        ' 最終行を取得(1000行までに制限する)
        For r = 2 To 1000
            If sh.Cells(r, 1).Text = "" Or sh.Cells(r, 2).Text = TextBox1.Text Then
                sh.Cells(r, 1).Value = Label1.Text
                sh.Cells(r, 2).Value = TextBox1.Text
                sh.Cells(r, 3).Value = IIf(CheckBox1.Checked, "完了", "未完了")
                Exit For
            End If
        Next
        wb.Save()
        xapp.Quit()
    End Sub
End Class
