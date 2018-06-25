Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports web453

Namespace Controllers
    Public Class ProductController
        Inherits System.Web.Mvc.Controller

        Private db As New Database1Entities

        ' GET: Product
        Function Index() As ActionResult
            Return View(db.商品.ToList())
        End Function

        ' GET: Product/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim 商品 As 商品 = db.商品.Find(id)
            If IsNothing(商品) Then
                Return HttpNotFound()
            End If
            Return View(商品)
        End Function

        ' GET: Product/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Product/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="商品ID,商品名,単価")> ByVal 商品 As 商品) As ActionResult
            If ModelState.IsValid Then
                db.商品.Add(商品)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(商品)
        End Function

        ' GET: Product/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim 商品 As 商品 = db.商品.Find(id)
            If IsNothing(商品) Then
                Return HttpNotFound()
            End If
            Return View(商品)
        End Function

        ' POST: Product/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 を参照してください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="商品ID,商品名,単価")> ByVal 商品 As 商品) As ActionResult
            If ModelState.IsValid Then
                db.Entry(商品).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(商品)
        End Function

        ' GET: Product/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim 商品 As 商品 = db.商品.Find(id)
            If IsNothing(商品) Then
                Return HttpNotFound()
            End If
            Return View(商品)
        End Function

        ' POST: Product/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim 商品 As 商品 = db.商品.Find(id)
            db.商品.Remove(商品)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
