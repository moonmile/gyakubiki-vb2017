Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports debug348

<TestClass()>
Public Class UnitTest1
    <TestMethod()>
    Public Sub TestMethod1()
        Dim t = New TargetClass()
        Assert.AreEqual(30, t.Add(10, 20))
    End Sub
End Class