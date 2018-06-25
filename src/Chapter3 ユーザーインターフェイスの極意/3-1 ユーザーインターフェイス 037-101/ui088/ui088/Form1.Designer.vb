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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.新規作成NToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.開くOToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.上書き保存SToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.印刷PToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.切り取りUToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.コピーCToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.貼り付けPToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ヘルプLToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(284, 236)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(284, 261)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新規作成NToolStripButton, Me.開くOToolStripButton, Me.上書き保存SToolStripButton, Me.印刷PToolStripButton, Me.toolStripSeparator, Me.切り取りUToolStripButton, Me.コピーCToolStripButton, Me.貼り付けPToolStripButton, Me.toolStripSeparator1, Me.ヘルプLToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(239, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        '新規作成NToolStripButton
        '
        Me.新規作成NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.新規作成NToolStripButton.Image = CType(resources.GetObject("新規作成NToolStripButton.Image"), System.Drawing.Image)
        Me.新規作成NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.新規作成NToolStripButton.Name = "新規作成NToolStripButton"
        Me.新規作成NToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.新規作成NToolStripButton.Text = "新規作成(&N)"
        '
        '開くOToolStripButton
        '
        Me.開くOToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.開くOToolStripButton.Image = CType(resources.GetObject("開くOToolStripButton.Image"), System.Drawing.Image)
        Me.開くOToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.開くOToolStripButton.Name = "開くOToolStripButton"
        Me.開くOToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.開くOToolStripButton.Text = "開く(&O)"
        '
        '上書き保存SToolStripButton
        '
        Me.上書き保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.上書き保存SToolStripButton.Image = CType(resources.GetObject("上書き保存SToolStripButton.Image"), System.Drawing.Image)
        Me.上書き保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.上書き保存SToolStripButton.Name = "上書き保存SToolStripButton"
        Me.上書き保存SToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.上書き保存SToolStripButton.Text = "上書き保存(&S)"
        '
        '印刷PToolStripButton
        '
        Me.印刷PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.印刷PToolStripButton.Image = CType(resources.GetObject("印刷PToolStripButton.Image"), System.Drawing.Image)
        Me.印刷PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.印刷PToolStripButton.Name = "印刷PToolStripButton"
        Me.印刷PToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.印刷PToolStripButton.Text = "印刷(&P)"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        '切り取りUToolStripButton
        '
        Me.切り取りUToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.切り取りUToolStripButton.Image = CType(resources.GetObject("切り取りUToolStripButton.Image"), System.Drawing.Image)
        Me.切り取りUToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.切り取りUToolStripButton.Name = "切り取りUToolStripButton"
        Me.切り取りUToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.切り取りUToolStripButton.Text = "切り取り(&U)"
        '
        'コピーCToolStripButton
        '
        Me.コピーCToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.コピーCToolStripButton.Image = CType(resources.GetObject("コピーCToolStripButton.Image"), System.Drawing.Image)
        Me.コピーCToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.コピーCToolStripButton.Name = "コピーCToolStripButton"
        Me.コピーCToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.コピーCToolStripButton.Text = "コピー(&C)"
        '
        '貼り付けPToolStripButton
        '
        Me.貼り付けPToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.貼り付けPToolStripButton.Image = CType(resources.GetObject("貼り付けPToolStripButton.Image"), System.Drawing.Image)
        Me.貼り付けPToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.貼り付けPToolStripButton.Name = "貼り付けPToolStripButton"
        Me.貼り付けPToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.貼り付けPToolStripButton.Text = "貼り付け(&P)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ヘルプLToolStripButton
        '
        Me.ヘルプLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ヘルプLToolStripButton.Image = CType(resources.GetObject("ヘルプLToolStripButton.Image"), System.Drawing.Image)
        Me.ヘルプLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ヘルプLToolStripButton.Name = "ヘルプLToolStripButton"
        Me.ヘルプLToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ヘルプLToolStripButton.Text = "ヘルプ(&L)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents 新規作成NToolStripButton As ToolStripButton
    Friend WithEvents 開くOToolStripButton As ToolStripButton
    Friend WithEvents 上書き保存SToolStripButton As ToolStripButton
    Friend WithEvents 印刷PToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents 切り取りUToolStripButton As ToolStripButton
    Friend WithEvents コピーCToolStripButton As ToolStripButton
    Friend WithEvents 貼り付けPToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ヘルプLToolStripButton As ToolStripButton
End Class
