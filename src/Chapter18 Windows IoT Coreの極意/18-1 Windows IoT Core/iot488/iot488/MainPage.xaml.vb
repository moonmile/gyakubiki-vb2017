' 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください
Imports Windows.Devices.Gpio
Imports Windows.UI.Core

''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Sub New()
        InitializeComponent()
        Dim gpio = GpioController.GetDefault()
        Dim buttonPin = gpio.OpenPin(12)
        buttonPin.SetDriveMode(GpioPinDriveMode.InputPullDown)
        AddHandler buttonPin.ValueChanged, AddressOf buttonPin_ValueChanged
    End Sub
    Private redBrush As New SolidColorBrush(Windows.UI.Colors.Red)
    Private grayBrush As New SolidColorBrush(Windows.UI.Colors.LightGray)
    Public Async Sub buttonPin_ValueChanged(sender As GpioPin,
                                            e As GpioPinValueChangedEventArgs)
        If e.Edge = GpioPinEdge.FallingEdge Then
            ' チルトボタンが押されたとき
            Await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                Sub()
                    If ell.Fill.Equals(redBrush) Then
                        ell.Fill = grayBrush
                    Else
                        ell.Fill = redBrush
                    End If
                End Sub)
        End If
    End Sub
End Class
