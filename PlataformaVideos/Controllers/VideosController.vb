Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports BEUVideo

Namespace Controllers
    Public Class VideosController
        Inherits System.Web.Mvc.Controller

        Private db As New dbPortalVideosEntities

        ' GET: Videos
        Function Index() As ActionResult
            Return View(db.Video.ToList())
        End Function

        ' GET: Videos/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim video As Video = db.Video.Find(id)
            If IsNothing(video) Then
                Return HttpNotFound()
            End If
            Return View(video)
        End Function

        ' GET: Videos/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Videos/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="id,nombre,fecha_lanzamiento,categoria,duracion")> ByVal video As Video) As ActionResult
            If ModelState.IsValid Then
                db.Video.Add(video)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(video)
        End Function

        ' GET: Videos/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim video As Video = db.Video.Find(id)
            If IsNothing(video) Then
                Return HttpNotFound()
            End If
            Return View(video)
        End Function

        ' POST: Videos/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        'más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="id,nombre,fecha_lanzamiento,categoria,duracion")> ByVal video As Video) As ActionResult
            If ModelState.IsValid Then
                db.Entry(video).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(video)
        End Function

        ' GET: Videos/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim video As Video = db.Video.Find(id)
            If IsNothing(video) Then
                Return HttpNotFound()
            End If
            Return View(video)
        End Function

        ' POST: Videos/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim video As Video = db.Video.Find(id)
            db.Video.Remove(video)
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
