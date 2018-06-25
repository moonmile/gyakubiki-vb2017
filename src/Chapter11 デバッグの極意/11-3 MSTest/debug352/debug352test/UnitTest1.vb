Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports debug352


<TestClass()> Public Class UnitTest1

    <TestMethod()>
    Public Sub TestMethod1()
        Dim t = New TargetClass()
        Dim obj = t.CreatePointer(-1, -1)
        Assert.IsNull(obj)
        Dim obj2 = t.CreatePointer(10, 20)
        Assert.IsNotNull(obj2)
        Assert.AreEqual(1, obj2.X)
        Assert.AreEqual(1, obj2.Y)
    End Sub

End Class