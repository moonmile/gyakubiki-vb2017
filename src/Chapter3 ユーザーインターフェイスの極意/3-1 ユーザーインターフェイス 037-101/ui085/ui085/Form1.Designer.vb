<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.左揃えToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.中央揃えToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.右揃えToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.左揃えToolStripMenuItem, Me.中央揃えToolStripMenuItem, Me.右揃えToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 70)
        '
        '左揃えToolStripMenuItem
        '
        Me.左揃えToolStripMenuItem.Name = "左揃えToolStripMenuItem"
        Me.左揃えToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.左揃えToolStripMenuItem.Text = "左揃え"
        '
        '中央揃えToolStripMenuItem
        '
        Me.中央揃えToolStripMenuItem.Name = "中央揃えToolStripMenuItem"
        Me.中央揃えToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.中央揃えToolStripMenuItem.Text = "中央揃え"
        '
        '右揃えToolStripMenuItem
        '
        Me.右揃えToolStripMenuItem.Name = "右揃えToolStripMenuItem"
        Me.右揃えToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.右揃えToolStripMenuItem.Text = "右揃え"
        '
        'TextBox1
        '
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.Location = New System.Drawing.Point(50, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 19)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox2.Location = New System.Drawing.Point(50, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(110, 19)
        Me.TextBox2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 116)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 左揃えToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 中央揃えToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 右揃えToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
