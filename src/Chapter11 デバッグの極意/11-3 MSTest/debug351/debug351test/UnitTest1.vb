Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports debug351


<TestClass()> Public Class UnitTest1

    <TestMethod()>
    Public Sub TestMethod1()
        Dim t = New TargetClass()
        Dim ans = t.Add("増田", "智明")
        Assert.AreEqual("増田智明", ans)
    End Sub

End Class