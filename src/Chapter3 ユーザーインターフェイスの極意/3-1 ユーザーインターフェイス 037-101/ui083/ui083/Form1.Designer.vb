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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.スタイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.太字ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.斜体ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.スタイルToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(254, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'スタイルToolStripMenuItem
        '
        Me.スタイルToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.太字ToolStripMenuItem, Me.斜体ToolStripMenuItem})
        Me.スタイルToolStripMenuItem.Name = "スタイルToolStripMenuItem"
        Me.スタイルToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.スタイルToolStripMenuItem.Text = "スタイル"
        '
        '太字ToolStripMenuItem
        '
        Me.太字ToolStripMenuItem.Name = "太字ToolStripMenuItem"
        Me.太字ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.太字ToolStripMenuItem.Text = "太字"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 19)
        Me.TextBox1.TabIndex = 1
        '
        '斜体ToolStripMenuItem
        '
        Me.斜体ToolStripMenuItem.Name = "斜体ToolStripMenuItem"
        Me.斜体ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.斜体ToolStripMenuItem.Text = "斜体"
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

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents スタイルToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 太字ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 斜体ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
End Class
