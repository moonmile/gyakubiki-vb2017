

Imports Windows.Devices.I2C

Public Class PwmServo
    Const PCA9685_SUBADR1 As Integer = &H2
    Const PCA9685_SUBADR2 As Integer = &H3
    Const PCA9685_SUBADR3 As Integer = &H4
    Const PCA9685_MODE1 As Integer = &H0
    Const PCA9685_PRESCALE As Integer = &HFE

    Const LED0_ON_L As Integer = &H6
    Const LED0_ON_H As Integer = &H7
    Const LED0_OFF_L As Integer = &H8
    Const LED0_OFF_H As Integer = &H9

    Const ALLLED_ON_L As Integer = &HFA
    Const ALLLED_ON_H As Integer = &HFB
    Const ALLLED_OFF_L As Integer = &HFC
    Const ALLLED_OFF_H As Integer = &HFD

    Private _i2caddr As Integer
    Private i2c As I2cDevice
    Private _num As Integer = 0

    Const SERVOMIN As Integer = 150
    Const SERVOMAX As Integer = 600

    Public Sub New(i2cDev As I2cDevice, Optional num As Integer = 0, Optional addr As Integer = &H40)
        i2c = i2cDev
        _i2caddr = addr
        _num = num
    End Sub
    Public Sub Begin()
        Me.Reset()
    End Sub
    Public Sub Reset()
        write8(PCA9685_MODE1, 0)
    End Sub
    Public Async Sub SetPWMFreq(freq As Double)

        freq *= 0.9
        Dim prescaleval As Double = 25000000
        prescaleval /= 4096
        prescaleval /= freq
        prescaleval -= 1

        Dim prescale As Integer = CInt(prescaleval + 0.5)

        Dim oldmode As Integer = read8(PCA9685_MODE1)
        Dim newmode As Integer = (oldmode And &H7F) Or &H10
        ' sleep
        write8(PCA9685_MODE1, newmode)
        write8(PCA9685_PRESCALE, prescale)
        write8(PCA9685_MODE1, oldmode)
        Await Task.Delay(5)
        write8(PCA9685_MODE1, oldmode Or &HA1)
    End Sub
    Public Sub SetPWM(num As Integer, [on] As Integer, off As Integer)
        Dim data = New Byte() {
            CByte(LED0_ON_L + 4 * num),
            CByte([on] And 255),
            CByte([on] >> 8),
            CByte(off And 255),
            CByte(off >> 8)
        }
        i2c.Write(data)
    End Sub
    Public Sub SetPin(num As Integer, val As Integer, Optional invert As Boolean = False)
        ' Clamp value between 0 and 4095 inclusive.
        val = Math.Min(val, 4095)
        If invert Then
            If val = 0 Then
                ' Special value for signal fully on.
                SetPWM(num, 4096, 0)
            ElseIf val = 4095 Then
                ' Special value for signal fully off.
                SetPWM(num, 0, 4096)
            Else
                SetPWM(num, 0, 4095 - val)
            End If
        Else
            If val = 4095 Then
                ' Special value for signal fully on.
                SetPWM(num, 4096, 0)
            ElseIf val = 0 Then
                ' Special value for signal fully off.
                SetPWM(num, 0, 4096)
            Else
                SetPWM(num, 0, val)
            End If
        End If
    End Sub

    Private Function read8(addr As Integer) As Integer
        Dim wdata = New Byte() {CByte(addr)}
        Dim rdata = New Byte(0) {}

        i2c.WriteRead(wdata, rdata)
        Return CInt(rdata(0))
    End Function
    Private Sub write8(addr As Integer, d As Integer)
        Dim data = New Byte() {CByte(addr), CByte(d)}
        i2c.Write(data)
    End Sub

    Private _Position As Integer = 0
    Public Property Position() As Integer
        Get
            Return _Position
        End Get
        Set
            Value = Math.Max(0, Value)
            Value = Math.Min(Value, 180)
            _Position = Value
            Dim v As Integer = CInt((SERVOMAX - SERVOMIN) * CDbl(_Position) / 180.0 + SERVOMIN)
            Me.SetPWM(_num, 0, v)
        End Set
    End Property
End Class
