Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Class MyModel
    Inherits BindableBase
    Private _text As String
    Private _fillColor As Brush

    Public Property Text() As String
        Get
            Return _text
        End Get
        Set
            Me.SetProperty(Me._text, Value)
        End Set
    End Property
    Public Property FillColor() As Brush
        Get
            Return _fillColor
        End Get
        Set
            Me.SetProperty(Me._fillColor, Value)
        End Set
    End Property

    Public Property ClickRed() As ICommand
        Get
            Return _ClickRed
        End Get
        Set
            _ClickRed = Value
        End Set
    End Property
    Private _ClickRed As ICommand
    Public Property ClickBlue() As ICommand
        Get
            Return _ClickBlue
        End Get
        Set
            _ClickBlue = Value
        End Set
    End Property
    Private _ClickBlue As ICommand
    Public Property ClickYellow() As ICommand
        Get
            Return _ClickYellow
        End Get
        Set
            _ClickYellow = Value
        End Set
    End Property
    Private _ClickYellow As ICommand

    Private Class ClickCommand
        Implements ICommand
        Public Event CanExecuteChanged As EventHandler _
            Implements ICommand.CanExecuteChanged
        Public Event OnClick As Action

        Public Sub New(handler As Action)
            AddHandler Me.OnClick, handler
        End Sub
        Public Function CanExecute(parameter As Object) As Boolean _
            Implements ICommand.CanExecute
            Return True
        End Function

        Public Sub Execute(parameter As Object) _
            Implements ICommand.Execute
            RaiseEvent OnClick()
        End Sub
    End Class

    Public Sub New()
        ClickRed = New ClickCommand(
            Sub()
                Text = "赤ボタンをクリック"
                FillColor = New SolidColorBrush(Colors.Red)
            End Sub)
        ClickBlue = New ClickCommand(
            Sub()
                Text = "青ボタンをクリック"
                FillColor = New SolidColorBrush(Colors.Blue)
            End Sub)
        ClickYellow = New ClickCommand(
            Sub()
                Text = "黄色ボタンをクリック"
                FillColor = New SolidColorBrush(Colors.Yellow)
            End Sub)
    End Sub
End Class

Public MustInherit Class BindableBase
    Implements INotifyPropertyChanged
    ''' <summary>
    ''' プロパティの変更を通知するためのマルチキャスト イベント。
    ''' </summary>
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ''' <summary>
    ''' プロパティが既に目的の値と一致しているかどうかを確認します。必要な場合のみ、
    ''' プロパティを設定し、リスナーに通知します。
    ''' </summary>
    ''' <typeparam name="T">プロパティの型。</typeparam>
    ''' <param name="storage">get アクセス操作子と set アクセス操作子両方を使用したプロパティへの参照。</param>
    ''' <param name="value">プロパティに必要な値。</param>
    ''' <param name="propertyName">リスナーに通知するために使用するプロパティの名前。
    ''' この値は省略可能で、
    ''' CallerMemberName をサポートするコンパイラから呼び出す場合に自動的に指定できます。</param>
    ''' <returns>値が変更された場合は true、既存の値が目的の値に一致した場合は
    ''' false です。</returns>
    Protected Function SetProperty(Of T)(ByRef storage As T, value As T, <CallerMemberName> Optional propertyName As [String] = Nothing) As Boolean
        If Object.Equals(storage, value) Then
            Return False
        End If

        storage = value
        Me.OnPropertyChanged(propertyName)
        Return True
    End Function

    ''' <summary>
    ''' プロパティ値が変更されたことをリスナーに通知します。
    ''' </summary>
    ''' <param name="propertyName">リスナーに通知するために使用するプロパティの名前。
    ''' この値は省略可能で、
    ''' <see cref="CallerMemberNameAttribute"/> をサポートするコンパイラから呼び出す場合に自動的に指定できます。</param>
    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class
