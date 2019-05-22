Imports System.Net
Imports System.Security.Principal
Imports System.Web.Http
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication
    Public Shared users As UserList
    Public Shared lastAuthInfo As AuthInfo
    Public Sub New()
        users = New UserList
    End Sub


    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub

    Protected Sub Application_BeginRequest()
    End Sub

    Protected Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Protected Sub Application_AuthorizeRequest(ByVal sender As Object, ByVal e As EventArgs)

        Dim ut As New User(Me.User.Identity)

        If Me.User.Identity.IsAuthenticated Then

            If Not users.ContainsKey(ut.nameIdentifier) Then
                Dim dbc As DataAdapter = New DataAdapter(ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString, New User(-1))

                Dim pri As IPrincipal = Me.User
                Dim dt As DataTable = dbc.getUserInfo(ut.nameIdentifier)
                ut.Update(dt)

                If lastAuthInfo IsNot Nothing And ut.authType = AuthTypeEnum.None Then
                    ut.authInfo = lastAuthInfo
                    lastAuthInfo = Nothing

                    Dim wc As New WebClient
                    Dim data() As Byte = wc.DownloadData(ut.URL_UserImageSmall)
                    Dim ds As DataSet = dbc.Gestione("A_GestioneUtente", ut.utenteId, "MODIFICA_OAUTH_INFO", ut.authInfo.id, ut.authInfo.tipo, ,,, data)
                    ut.Update(ds.Tables(0))
                End If

                users.Add(ut)
            Else
                ut.Update(users(ut.nameIdentifier))
            End If




        End If
        Dim ri As RequestInfo = HttpContext.Current.Items("RI")

        If ri Is Nothing Then
            ri = New RequestInfo
            HttpContext.Current.Items("RI") = ri
        End If

        If (ut.utenteId = 0 And Request.IsLocal) Then
            '  ut = KaraTubeWeb.User.getUtenteAdminDiTest()
            '    '  ut = Utente.getUtenteDiTest()
        End If
        ri.user = ut
    End Sub

    Private Sub MvcApplication_PostAuthenticateRequest(sender As Object, e As EventArgs) Handles Me.PostAuthenticateRequest

    End Sub

    '1.Application_BeginRequest 
    '2.Application_AuthenticateRequest 
    '3.Application_AuthorizeRequest 
    '4.Application_ResolveRequestCache 
    '5.Application_AcquireRequestState 
    '6.Application_PreRequestHandlerExecute 
    '7.Application_PreSendRequestHeaders 
    '8.Application_PreSendRequestContent 
    '9.Application_PostRequestHandlerExecute 
    '10.Application_ReleaseRequestState 
    '11.Application_UpdateRequestCache 
    '12.Application_EndRequest 




End Class
