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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(68, 12)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(203, 19)
        Me.TextBox3.TabIndex = 36
        Me.TextBox3.Text = "5000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 12)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Port"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(13, 143)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 106)
        Me.TextBox2.TabIndex = 34
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(68, 65)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(203, 19)
        Me.textBox1.TabIndex = 33
        Me.textBox1.Text = "1"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(11, 68)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(16, 12)
        Me.label1.TabIndex = 32
        Me.label1.Text = "ID"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(13, 102)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(260, 23)
        Me.button1.TabIndex = 31
        Me.button1.Text = "XML"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TextBox3 As TextBox
    Private WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
