Public Class Form1
    ''' ミューテックス
    Private objMutex As System.Threading.Mutex
    ''' 起動時
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        ' 二重起動を防止する
        objMutex = New System.Threading.Mutex(False, "app473")
        If objMutex.WaitOne(0, False) = False Then
            MessageBox.Show("すでにアプリケーションが起動しています")
            Me.Close()
        End If
    End Sub
    ''' フォームクローズ
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) _
        Handles MyBase.FormClosed
        ' フォームを閉じるときにミューテックスを解放する
        objMutex.Close()
    End Sub
End Class
