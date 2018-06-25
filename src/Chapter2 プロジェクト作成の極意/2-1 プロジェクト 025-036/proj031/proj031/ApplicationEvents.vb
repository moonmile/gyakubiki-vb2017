Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' 次のイベントは MyApplication に対して利用できます:
    ' Startup:アプリケーションが開始されたとき、スタートアップ フォームが作成される前に発生します。
    ' Shutdown:アプリケーション フォームがすべて閉じられた後に発生します。このイベントは、アプリケーションが異常終了したときには発生しません。
    ' UnhandledException:ハンドルされない例外がアプリケーションで発生したときに発生します。
    ' StartupNextInstance:単一インスタンス アプリケーションが起動され、それが既にアクティブであるときに発生します。 
    ' NetworkAvailabilityChanged:ネットワーク接続が接続されたとき、または切断されたときに発生します。
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim ans As Integer
            ans = MessageBox.Show("プログラムを開始します", "プログラムの開始",
                                  MessageBoxButtons.OKCancel)
            If ans = vbCancel Then e.Cancel = True
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            MessageBox.Show("終了時間:" & Now.ToString)
        End Sub
    End Class
End Namespace
