Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class MyModel
    Inherits BindableBase

    Private _height As Double = 0.0 '身長(m)
    Private _weight As Double = 0.0 '体重(kg)

    Public Property Height As Double
        Get
            Return _height * 100.0
        End Get
        Set(value As Double)
            SetProperty(_height, value / 100.0)
            OnPropertyChanged(NameOf(BMI))
        End Set
    End Property
    Public Property Weight As Double
        Get
            Return _weight
        End Get
        Set(value As Double)
            SetProperty(_weight, value)
            OnPropertyChanged(NameOf(BMI))
        End Set
    End Property
    Public ReadOnly Property BMI As Double
        Get
            If _height = 0.0 Then
                Return 0.0
            Else
                Return _weight / (_height ^ 2)
            End If
        End Get
    End Property
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
