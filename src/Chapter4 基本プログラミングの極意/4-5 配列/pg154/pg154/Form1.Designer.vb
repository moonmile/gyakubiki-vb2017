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
        Me.listBox3 = New System.Windows.Forms.ListBox()
        Me.listBox2 = New System.Windows.Forms.ListBox()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listBox3
        '
        Me.listBox3.FormattingEnabled = True
        Me.listBox3.ItemHeight = 12
        Me.listBox3.Location = New System.Drawing.Point(212, 37)
        Me.listBox3.Name = "listBox3"
        Me.listBox3.Size = New System.Drawing.Size(83, 64)
        Me.listBox3.TabIndex = 44
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.ItemHeight = 12
        Me.listBox2.Location = New System.Drawing.Point(112, 37)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(83, 64)
        Me.listBox2.TabIndex = 43
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 12
        Me.listBox1.Location = New System.Drawing.Point(12, 37)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(83, 64)
        Me.listBox1.TabIndex = 42
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 111)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(284, 23)
        Me.button1.TabIndex = 41
        Me.button1.Text = "配列の要素を並べ替える"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.Location = New System.Drawing.Point(209, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(81, 13)
        Me.label1.TabIndex = 39
        Me.label1.Text = "降順でソート："
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label5.Location = New System.Drawing.Point(109, 21)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(81, 13)
        Me.label5.TabIndex = 40
        Me.label5.Text = "昇順でソート："
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label4.Location = New System.Drawing.Point(12, 21)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 13)
        Me.label4.TabIndex = 38
        Me.label4.Text = "ソート前："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 157)
        Me.Controls.Add(Me.listBox3)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listBox3 As ListBox
    Private WithEvents listBox2 As ListBox
    Private WithEvents listBox1 As ListBox
    Private WithEvents button1 As Button
    Private WithEvents label1 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
End Class
