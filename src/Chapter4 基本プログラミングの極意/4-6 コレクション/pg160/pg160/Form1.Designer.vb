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
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBox3
        '
        Me.listBox3.FormattingEnabled = True
        Me.listBox3.ItemHeight = 12
        Me.listBox3.Location = New System.Drawing.Point(224, 35)
        Me.listBox3.Name = "listBox3"
        Me.listBox3.Size = New System.Drawing.Size(100, 88)
        Me.listBox3.TabIndex = 17
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.ItemHeight = 12
        Me.listBox2.Location = New System.Drawing.Point(118, 35)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(100, 88)
        Me.listBox2.TabIndex = 16
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 12
        Me.listBox1.Location = New System.Drawing.Point(12, 35)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(100, 88)
        Me.listBox1.TabIndex = 15
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label3.Location = New System.Drawing.Point(221, 19)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(81, 13)
        Me.label3.TabIndex = 20
        Me.label3.Text = "逆順でソート："
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label2.Location = New System.Drawing.Point(115, 19)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(57, 13)
        Me.label2.TabIndex = 19
        Me.label2.Text = "ソート後："
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label5.Location = New System.Drawing.Point(9, 19)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(57, 13)
        Me.label5.TabIndex = 18
        Me.label5.Text = "ソート前："
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 132)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(313, 23)
        Me.button1.TabIndex = 14
        Me.button1.Text = "Listジェネリッククラスの要素を並べ替える"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 179)
        Me.Controls.Add(Me.listBox3)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listBox3 As ListBox
    Private WithEvents listBox2 As ListBox
    Private WithEvents listBox1 As ListBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label5 As Label
    Private WithEvents button1 As Button
End Class
