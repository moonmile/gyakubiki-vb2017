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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.配置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.左揃えToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.中央揃えToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.右揃えToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 19)
        Me.TextBox1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.配置ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(254, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '配置ToolStripMenuItem
        '
        Me.配置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.左揃えToolStripMenuItem, Me.中央揃えToolStripMenuItem, Me.右揃えToolStripMenuItem})
        Me.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem"
        Me.配置ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.配置ToolStripMenuItem.Text = "配置"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 127)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 配置ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 左揃えToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 中央揃えToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 右揃えToolStripMenuItem As ToolStripMenuItem
End Class
