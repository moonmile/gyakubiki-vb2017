﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.label7 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label7.Location = New System.Drawing.Point(12, 70)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(91, 13)
        Me.label7.TabIndex = 33
        Me.label7.Text = "0秒1001ミリ秒："
        '
        'label3
        '
        Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label3.Location = New System.Drawing.Point(142, 66)
        Me.label3.Name = "label3"
        Me.label3.Padding = New System.Windows.Forms.Padding(2)
        Me.label3.Size = New System.Drawing.Size(167, 20)
        Me.label3.TabIndex = 32
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label5.Location = New System.Drawing.Point(12, 44)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(128, 13)
        Me.label5.TabIndex = 31
        Me.label5.Text = "0日25時間20分15秒："
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label4.Location = New System.Drawing.Point(12, 19)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(101, 13)
        Me.label4.TabIndex = 30
        Me.label4.Text = "20時間10分5秒："
        '
        'label2
        '
        Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label2.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label2.Location = New System.Drawing.Point(142, 40)
        Me.label2.Name = "label2"
        Me.label2.Padding = New System.Windows.Forms.Padding(2)
        Me.label2.Size = New System.Drawing.Size(167, 20)
        Me.label2.TabIndex = 29
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label1.Location = New System.Drawing.Point(142, 15)
        Me.label1.Name = "label1"
        Me.label1.Padding = New System.Windows.Forms.Padding(2)
        Me.label1.Size = New System.Drawing.Size(167, 20)
        Me.label1.TabIndex = 28
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 95)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(297, 23)
        Me.button1.TabIndex = 27
        Me.button1.Text = "任意の時間間隔を作成する"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 143)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label7 As Label
    Private WithEvents label3 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
