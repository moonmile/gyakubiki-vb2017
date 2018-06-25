Public Class Form1
    Private Sub Form1_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        右揃えToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.R
    End Sub

    Private Sub 左揃えToolStripMenuItem_Click(sender As Object,
e As EventArgs) Handles 左揃えToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub 中央揃えToolStripMenuItem_Click(sender As Object,
e As EventArgs) Handles 中央揃えToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub 右揃えToolStripMenuItem_Click(sender As Object,
e As EventArgs) Handles 右揃えToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Right
    End Sub

End Class
