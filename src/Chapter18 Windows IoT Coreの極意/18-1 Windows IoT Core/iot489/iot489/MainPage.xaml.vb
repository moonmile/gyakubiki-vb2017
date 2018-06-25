' 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください
Imports Windows.Devices.Enumeration
Imports Windows.Devices.I2c

''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded, AddressOf MainPage_Loaded

        AddHandler Me.buttonStop.Click, Sub() pwm1.Reset()
        AddHandler Me.button0.Click, Sub() pwm1.Position = 0
        AddHandler Me.button90.Click, Sub() pwm1.Position = 90
        AddHandler Me.button180.Click, Sub() pwm1.Position = 180
    End Sub

    Private Async Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs)
        Try
            Dim aqs As String = I2cDevice.GetDeviceSelector()
            Dim dis = Await DeviceInformation.FindAllAsync(aqs)
            Dim settings = New I2cConnectionSettings(PWM_I2C_ADDR)
            settings.BusSpeed = I2cBusSpeed.StandardMode
            I2CPwm = Await I2cDevice.FromIdAsync(dis(0).Id, settings)
            pwm1 = New PwmServo(I2CPwm, 0)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)
            Return
        End Try
        pwm1.Begin()
        pwm1.SetPWMFreq(60)   ' 60Hz 
    End Sub


    Private pwm1 As PwmServo
    Private I2CPwm As I2cDevice
    Private Const PWM_I2C_ADDR = &H40
End Class
