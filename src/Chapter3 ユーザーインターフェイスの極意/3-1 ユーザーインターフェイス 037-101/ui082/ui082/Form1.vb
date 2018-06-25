Public Class Form1
    Private Sub 左揃えToolStripMenuItem_Click(sender As Object,
    e As EventArgs) Handles 左揃えToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Left
        左揃えToolStripMenuItem.Enabled = False
        中央揃えToolStripMenuItem.Enabled = True
        右揃えToolStripMenuItem.Enabled = True
    End Sub

    Private Sub 中央揃えToolStripMenuItem_Click(sender As Object,
    e As EventArgs) Handles 中央揃えToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Center
        左揃えToolStripMenuItem.Enabled = True
        中央揃えToolStripMenuItem.Enabled = False
        右揃えToolStripMenuItem.Enabled = True
    End Sub

    Private Sub 右揃えToolStripMenuItem_Click(sender As Object,
    e As EventArgs) Handles 右揃えToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Right
        左揃えToolStripMenuItem.Enabled = True
        中央揃えToolStripMenuItem.Enabled = True
        右揃えToolStripMenuItem.Enabled = False
    End Sub
End Class
