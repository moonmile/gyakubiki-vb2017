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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioButton3 = New System.Windows.Forms.RadioButton()
        Me.radioButton6 = New System.Windows.Forms.RadioButton()
        Me.radioButton5 = New System.Windows.Forms.RadioButton()
        Me.radioButton4 = New System.Windows.Forms.RadioButton()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radioButton3)
        Me.groupBox1.Controls.Add(Me.radioButton6)
        Me.groupBox1.Controls.Add(Me.radioButton5)
        Me.groupBox1.Controls.Add(Me.radioButton4)
        Me.groupBox1.Controls.Add(Me.radioButton2)
        Me.groupBox1.Controls.Add(Me.radioButton1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(292, 88)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "好きな動物"
        '
        'radioButton3
        '
        Me.radioButton3.AutoSize = True
        Me.radioButton3.Location = New System.Drawing.Point(203, 27)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(39, 16)
        Me.radioButton3.TabIndex = 5
        Me.radioButton3.TabStop = True
        Me.radioButton3.Text = "リス"
        Me.radioButton3.UseVisualStyleBackColor = True
        '
        'radioButton6
        '
        Me.radioButton6.AutoSize = True
        Me.radioButton6.Location = New System.Drawing.Point(203, 61)
        Me.radioButton6.Name = "radioButton6"
        Me.radioButton6.Size = New System.Drawing.Size(47, 16)
        Me.radioButton6.TabIndex = 4
        Me.radioButton6.TabStop = True
        Me.radioButton6.Text = "恐竜"
        Me.radioButton6.UseVisualStyleBackColor = True
        '
        'radioButton5
        '
        Me.radioButton5.AutoSize = True
        Me.radioButton5.Location = New System.Drawing.Point(109, 61)
        Me.radioButton5.Name = "radioButton5"
        Me.radioButton5.Size = New System.Drawing.Size(58, 16)
        Me.radioButton5.TabIndex = 3
        Me.radioButton5.TabStop = True
        Me.radioButton5.Text = "ライオン"
        Me.radioButton5.UseVisualStyleBackColor = True
        '
        'radioButton4
        '
        Me.radioButton4.AutoSize = True
        Me.radioButton4.Location = New System.Drawing.Point(15, 61)
        Me.radioButton4.Name = "radioButton4"
        Me.radioButton4.Size = New System.Drawing.Size(39, 16)
        Me.radioButton4.TabIndex = 2
        Me.radioButton4.TabStop = True
        Me.radioButton4.Text = "トラ"
        Me.radioButton4.UseVisualStyleBackColor = True
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Location = New System.Drawing.Point(109, 27)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(41, 16)
        Me.radioButton2.TabIndex = 1
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "ネコ"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(15, 27)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(41, 16)
        Me.radioButton1.TabIndex = 0
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "イヌ"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 109)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(292, 23)
        Me.button1.TabIndex = 4
        Me.button1.Text = "ループの途中で処理を先頭にを戻す"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 152)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents radioButton3 As RadioButton
    Private WithEvents radioButton6 As RadioButton
    Private WithEvents radioButton5 As RadioButton
    Private WithEvents radioButton4 As RadioButton
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents button1 As Button
End Class
