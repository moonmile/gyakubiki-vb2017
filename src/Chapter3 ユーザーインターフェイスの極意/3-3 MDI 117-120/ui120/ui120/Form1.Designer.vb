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
        Me.ファイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新規作成ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.閉じるToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ウィンドウToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.左右に整列ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上下に整列ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重ねて整列ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルToolStripMenuItem, Me.ウィンドウToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.ウィンドウToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(364, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルToolStripMenuItem
        '
        Me.ファイルToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新規作成ToolStripMenuItem, Me.閉じるToolStripMenuItem, Me.終了ToolStripMenuItem})
        Me.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem"
        Me.ファイルToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ファイルToolStripMenuItem.Text = "ファイル"
        '
        '新規作成ToolStripMenuItem
        '
        Me.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem"
        Me.新規作成ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.新規作成ToolStripMenuItem.Text = "新規作成"
        '
        '閉じるToolStripMenuItem
        '
        Me.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem"
        Me.閉じるToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.閉じるToolStripMenuItem.Text = "閉じる"
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'ウィンドウToolStripMenuItem
        '
        Me.ウィンドウToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.左右に整列ToolStripMenuItem, Me.上下に整列ToolStripMenuItem, Me.重ねて整列ToolStripMenuItem})
        Me.ウィンドウToolStripMenuItem.Name = "ウィンドウToolStripMenuItem"
        Me.ウィンドウToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ウィンドウToolStripMenuItem.Text = "ウィンドウ"
        '
        '左右に整列ToolStripMenuItem
        '
        Me.左右に整列ToolStripMenuItem.Name = "左右に整列ToolStripMenuItem"
        Me.左右に整列ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.左右に整列ToolStripMenuItem.Text = "左右に整列"
        '
        '上下に整列ToolStripMenuItem
        '
        Me.上下に整列ToolStripMenuItem.Name = "上下に整列ToolStripMenuItem"
        Me.上下に整列ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.上下に整列ToolStripMenuItem.Text = "上下に整列"
        '
        '重ねて整列ToolStripMenuItem
        '
        Me.重ねて整列ToolStripMenuItem.Name = "重ねて整列ToolStripMenuItem"
        Me.重ねて整列ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.重ねて整列ToolStripMenuItem.Text = "重ねて整列"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 341)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新規作成ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 閉じるToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ウィンドウToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 左右に整列ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 上下に整列ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重ねて整列ToolStripMenuItem As ToolStripMenuItem
End Class
