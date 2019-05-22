Imports System.Web.Mvc

Namespace Controllers
    Public Class AppMVCController
        Inherits Controller

        Public Property RI As RequestInfo
        Public Property currentUser As User
        'Public Property path As New NavPath
        'Public Property menu As New NavPath

        Protected Overrides Sub OnAuthorization(filterContext As AuthorizationContext)
            MyBase.OnAuthorization(filterContext)
            RI = HttpContext.Items("RI")
            currentUser = RI.user
            ViewData("RI") = RI
            ViewBag.user = RI.user
            'ViewBag.path = path
            'ViewBag.menu = menu
            ViewBag.version = My.Settings.AppVersion
        End Sub

    End Class
End Namespace