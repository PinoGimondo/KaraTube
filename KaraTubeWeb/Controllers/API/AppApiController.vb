Imports System.Web.Http
Imports System.Web.Http.Controllers

Public Class AppAPIController
    Inherits ApiController
    Public da As DataAdapter
    Dim RI As RequestInfo
    Public ReadOnly Property utente As User
        Get
            If da IsNot Nothing Then
                Return da.utente
            Else
                Return Nothing
            End If
        End Get
    End Property

    Public Sub New()
        RI = HttpContext.Current.Items("RI")
        Inizializza(RI.user)
    End Sub

    Protected Overrides Sub Initialize(controllerContext As HttpControllerContext)
        MyBase.Initialize(controllerContext)
        Inizializza(RI.user)
    End Sub

    Public Sub Inizializza(utente As User)
        'If utente Is Nothing Then
        '    utente = Utente.getUtenteNonAutenticato
        'End If
        da = New DataAdapter(ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString, utente)
    End Sub

End Class
