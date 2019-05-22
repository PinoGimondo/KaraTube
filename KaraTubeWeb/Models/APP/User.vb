Imports ServiziDB
Public Class User
    Protected _isEnabled As Boolean
    Protected _isAdmin As Boolean
    Protected _id As Integer = 0
    Protected _name As String
    Protected _nameIdentifier As String
    Protected _identity As System.Security.Principal.IIdentity
    Public Property authInfo As AuthInfo

    Protected Property _profileImage As String
    Protected Property _authType As AuthTypeEnum
    Protected Property _authId As String

    Public Sub New(id As Integer)
        _nameIdentifier = ""
        _name = ""
        _identity = Nothing
        Me._id = id
    End Sub


    Public Sub New(ident As System.Security.Principal.IIdentity)
        _nameIdentifier = ""
        _name = ""
        _identity = Nothing

        If ident Is Nothing Then

        Else
            If ident.IsAuthenticated Then
                _name = ident.Name
                If TypeOf ident Is System.Security.Claims.ClaimsIdentity Then
                    fromClaimsIdentity(CType(ident, Security.Claims.ClaimsIdentity))
                End If
                _identity = ident
            End If
        End If

    End Sub

    Public ReadOnly Property authType As AuthTypeEnum
        Get
            Return authType
        End Get
    End Property




    Public ReadOnly Property URL_InlineUserImageSmall As String
        Get
            If authInfo IsNot Nothing Then
                Return String.Format("data:image/jpeg;base64,{0}", _profileImage)
            Else
                Return ""
            End If
        End Get
    End Property


    Public ReadOnly Property URL_UserImageSmall As String
        Get
            If authInfo IsNot Nothing Then
                Return authInfo.URL_UserImageSmall
            Else
                Return "pippo"
            End If
        End Get
    End Property

    Public Sub fromClaimsIdentity(ident As System.Security.Claims.ClaimsIdentity)
        Dim c As System.Security.Claims.Claim = ident.Claims.Where(Function(x) x.Type = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").FirstOrDefault
        If c IsNot Nothing Then
            _nameIdentifier = c.Value
        End If
    End Sub

    Public Overloads Sub Update(ByRef dt As DataTable, Optional rowIndex As Integer = 0)
        Dim dr As DataRow = dt.Rows(rowIndex)
        _id = SupportoDB.LeggiInteger(dr("userId"))
        _isAdmin = SupportoDB.LeggiBoolean(dr("isSysAdmin"))
        _isEnabled = SupportoDB.LeggiBoolean(dr("isEnabled"))
        _authId = SupportoDB.LeggiString(dr("authId"))
        _authType = SupportoDB.LeggiInteger(dr("authType"))

        Dim b() As Byte = dr("profileImage")
        If b.Length > 100 Then
            _profileImage = Convert.ToBase64String(b)
        End If

    End Sub

    Public Overloads Sub Update(ut As User)
        _id = ut.utenteId
        _isAdmin = ut.isAdmin
        _isEnabled = ut.isEnabled
        authInfo = ut.authInfo
        _authId = ut._authId
        _authType = ut._authType
        Me._profileImage = ut._profileImage
    End Sub

    Public ReadOnly Property isEnabled As Boolean
        Get
            Return _isEnabled
        End Get
    End Property


    Public ReadOnly Property isAdmin As Boolean
        Get
            Return _isAdmin
        End Get
    End Property

    Public ReadOnly Property utenteId As Integer
        Get
            Return _id
        End Get
    End Property


    Public ReadOnly Property name As String
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property nameIdentifier As String
        Get
            Return _nameIdentifier
        End Get
    End Property

    Public ReadOnly Property identity As System.Security.Principal.IIdentity
        Get
            Return _identity
        End Get
    End Property

    Public Shared Function getUtenteNonAutenticato()
        Dim u As New User(0)
        Return u
    End Function


    Public Shared Function getUtenteAdminDiTest()
        Dim u As New User(0)
        u._id = 1
        u._isAdmin = True
        u._isEnabled = True
        u._name = "Utente Admin di test"
        Return u
    End Function

    Public Shared Function getUtenteDiTest()
        Dim u As New User(0)
        u._id = 1
        u._isAdmin = False
        u._isEnabled = True
        u._name = "Utente di test"
        Return u
    End Function

    Public Function isAuthenticated()
        Return utenteId > 0 And isEnabled
    End Function
End Class

Public Class UserList
    Inherits Dictionary(Of String, User)

    Public Overloads Function Add(u As User) As User
        If Me.ContainsKey(u.nameIdentifier) Then
            Me.Remove(u.nameIdentifier)
        End If
        Me.Add(u.nameIdentifier, u)
        Return u
    End Function

    Public Function getUtente(nameIdentifier As String) As User

        If Me.ContainsKey(nameIdentifier) Then
            Return Me.Item(nameIdentifier)
        Else
            Return Nothing
        End If

    End Function

    Public Function getUtenteByName(UserName As String) As User
        Return Me.Values.Where(Function(x) x.name = UserName).FirstOrDefault
    End Function


End Class
