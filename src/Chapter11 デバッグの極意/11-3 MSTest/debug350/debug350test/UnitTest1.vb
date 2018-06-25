Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports debug350

<TestClass()>
Public Class UnitTest1
    <TestMethod()>
    Public Sub TestMethod1()
        Dim t = New TargetClass()
        Dim ans = t.Add(10, 20)
        Assert.AreEqual(30, ans)
    End Sub
End Class