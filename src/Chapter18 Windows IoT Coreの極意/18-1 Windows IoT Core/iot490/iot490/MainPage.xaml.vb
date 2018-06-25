' 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください
Imports Windows.Devices.Gpio

''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        RPi.gpio = GpioController.GetDefault()
        Me.motor1 = New Motor(23, 24)
        ' ボタンイベント
        AddHandler Me.buttonForword.Click, Sub() Me.motor1.Direction = 1
        AddHandler Me.buttonBack.Click, Sub() Me.motor1.Direction = -1
        AddHandler Me.buttonStop.Click, Sub() Me.motor1.Direction = 0
    End Sub

    Private motor1 As Motor

End Class

Public NotInheritable Class RPi
    Public Shared Property gpio As GpioController
End Class

Public Class Motor
    Private Property out1 As GpioPin
    Private Property out2 As GpioPin
    Public Sub New(pin1 As Integer, pin2 As Integer)
        Me.out1 = RPi.gpio.OpenPin(pin1)
        Me.out2 = RPi.gpio.OpenPin(pin2)
        Me.out1.Write(GpioPinValue.Low)
        Me.out2.Write(GpioPinValue.Low)
        Me.out1.SetDriveMode(GpioPinDriveMode.Output)
        Me.out2.SetDriveMode(GpioPinDriveMode.Output)
        _dir = 0
    End Sub
    Private _dir As Integer = 0
    ''' <summary>
    ''' 回転方向を変える
    ''' </summary>
    Public Property Direction() As Integer
        Get
            Return _dir
        End Get
        Set
            If _dir <> Value Then
                _dir = Value
                If _dir = 0 Then
                    Me.out1.Write(GpioPinValue.Low)
                    Me.out2.Write(GpioPinValue.Low)
                ElseIf _dir > 0 Then
                    Me.out1.Write(GpioPinValue.High)
                    Me.out2.Write(GpioPinValue.Low)
                Else
                    Me.out1.Write(GpioPinValue.Low)
                    Me.out2.Write(GpioPinValue.High)
                End If
            End If
        End Set
    End Property
End Class


