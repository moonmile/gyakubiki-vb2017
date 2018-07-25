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
        Me.button2 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(188, 89)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(112, 23)
        Me.button2.TabIndex = 25
        Me.button2.Text = "Stop"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label4.Location = New System.Drawing.Point(12, 22)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(288, 30)
        Me.label4.TabIndex = 24
        Me.label4.Text = "Startボタンを押してから、10秒台でStopボタンを押してください。"
        '
        'label1
        '
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.Location = New System.Drawing.Point(15, 57)
        Me.label1.Name = "label1"
        Me.label1.Padding = New System.Windows.Forms.Padding(2)
        Me.label1.Size = New System.Drawing.Size(285, 20)
        Me.label1.TabIndex = 23
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(15, 89)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(112, 23)
        Me.button1.TabIndex = 22
        Me.button1.Text = "Start"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 139)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
