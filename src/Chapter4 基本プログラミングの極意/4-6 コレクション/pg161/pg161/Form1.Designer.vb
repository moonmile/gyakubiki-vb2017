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
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.textBox1.Location = New System.Drawing.Point(86, 113)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(243, 20)
        Me.textBox1.TabIndex = 12
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(14, 116)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(66, 12)
        Me.label4.TabIndex = 16
        Me.label4.Text = "検索する値："
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label3.Location = New System.Drawing.Point(12, 19)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(317, 30)
        Me.label3.TabIndex = 14
        Me.label3.Text = "「東京、品川、新横浜」のリストに、下のリストボックスの要素を追加してから、テキストボックスの値を更新します。"
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 12
        Me.listBox1.Items.AddRange(New Object() {"静岡", "名古屋", "京都", "新大阪"})
        Me.listBox1.Location = New System.Drawing.Point(15, 52)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(314, 52)
        Me.listBox1.TabIndex = 15
        '
        'label1
        '
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.Location = New System.Drawing.Point(14, 142)
        Me.label1.Name = "label1"
        Me.label1.Padding = New System.Windows.Forms.Padding(3)
        Me.label1.Size = New System.Drawing.Size(314, 23)
        Me.label1.TabIndex = 17
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(14, 172)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(314, 23)
        Me.button1.TabIndex = 13
        Me.button1.Text = "コレクションの要素から値を検索する"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 215)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents listBox1 As ListBox
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
