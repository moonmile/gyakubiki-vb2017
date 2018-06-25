Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports debug353
<TestClass()> Public Class UnitTest1

    <TestMethod()>
    Public Sub TestAddNumber()
        Dim t = New TargetClass()
        Dim ans = t.Add(10, 20)
        Assert.AreEqual(30, ans)
    End Sub

    <TestMethod()>
    Public Sub TestAddString()
        Dim t = New TargetClass()
        Dim ans = t.Add("増田", "智明")
        Assert.AreEqual("増田智明", ans)
    End Sub

    <TestMethod()>
    Public Sub TestNull()
        Dim t = New TargetClass()
        Dim obj = t.CreatePointer(-1, -1)
        Assert.IsNull(obj)
        Dim obj2 = t.CreatePointer(10, 20)
        Assert.IsNotNull(obj2)
        Assert.AreEqual(10, obj2.X)
        Assert.AreEqual(20, obj2.Y)
    End Sub
End Class