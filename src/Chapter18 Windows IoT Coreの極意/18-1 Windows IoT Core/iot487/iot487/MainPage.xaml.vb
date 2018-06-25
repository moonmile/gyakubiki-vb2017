' 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください
Imports Windows.Devices.Gpio

''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Dim gpio = GpioController.GetDefault()
        ledPin = gpio.OpenPin(4)
        ledPin.SetDriveMode(GpioPinDriveMode.Output)
    End Sub
    Private ledPin As GpioPin
    Private Sub toggleSwitch_Toggled(sender As Object, e As RoutedEventArgs)
        If ts.IsOn = True Then
            ledPin.Write(GpioPinValue.High)
        Else
            ledPin.Write(GpioPinValue.Low)
        End If
    End Sub
End Class
