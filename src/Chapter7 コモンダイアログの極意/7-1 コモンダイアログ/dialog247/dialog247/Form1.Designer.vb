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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(89, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label4.Location = New System.Drawing.Point(15, 111)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(96, 13)
        Me.label4.TabIndex = 33
        Me.label4.Text = "選択したファイル："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label3.Location = New System.Drawing.Point(15, 86)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(80, 13)
        Me.label3.TabIndex = 34
        Me.label3.Text = "選択したパス："
        '
        'label5
        '
        Me.label5.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.label5.Location = New System.Drawing.Point(15, 20)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(389, 30)
        Me.label5.TabIndex = 32
        Me.label5.Text = "画像ファイルを選択するダイアログボックスを表示し、選択された画像をピクチャーボックスに表示します。"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(2)
        Me.Label2.Size = New System.Drawing.Size(287, 20)
        Me.Label2.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(2)
        Me.Label1.Size = New System.Drawing.Size(287, 20)
        Me.Label1.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(389, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "ファイルを開くダイアログボックスを表示する"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 342)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents openFileDialog1 As OpenFileDialog
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label5 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Button1 As Button
    Private WithEvents saveFileDialog1 As SaveFileDialog
End Class
