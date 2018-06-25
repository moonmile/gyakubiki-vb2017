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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(69, 29)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(203, 19)
        Me.TextBox5.TabIndex = 45
        Me.TextBox5.Text = "5000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 12)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Port"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 219)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(35, 12)
        Me.label5.TabIndex = 43
        Me.label5.Text = "label5"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(69, 141)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(203, 19)
        Me.textBox4.TabIndex = 42
        Me.textBox4.Text = "99"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(69, 116)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(203, 19)
        Me.textBox3.TabIndex = 41
        Me.textBox3.Text = "1000"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(69, 91)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(203, 19)
        Me.textBox2.TabIndex = 40
        Me.textBox2.Text = "新しい書籍を追加"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(69, 66)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(203, 19)
        Me.textBox1.TabIndex = 39
        Me.textBox1.Text = "100"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(10, 145)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(36, 12)
        Me.label4.TabIndex = 38
        Me.label4.Text = "Pages"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(10, 121)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(31, 12)
        Me.label3.TabIndex = 37
        Me.label3.Text = "Price"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(10, 95)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(28, 12)
        Me.label2.TabIndex = 36
        Me.label2.Text = "Title"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 69)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(16, 12)
        Me.label1.TabIndex = 35
        Me.label1.Text = "ID"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(14, 181)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(260, 23)
        Me.button1.TabIndex = 34
        Me.button1.Text = "Post"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TextBox5 As TextBox
    Private WithEvents Label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
