Public Enum AuthTypeEnum
    None = 0
    Facebook = 1
End Enum

Public Class AuthInfo
    Public Property tipo As AuthTypeEnum
    Public Property context As Microsoft.Owin.Security.Provider.BaseContext
    Public Property name As String
    Public Property accessToken As String
    Public Property id As String

    Public ReadOnly Property URL_UserImageSmall As String
        Get
            Select Case tipo
                Case AuthTypeEnum.Facebook
                    Return String.Format("https://graph.facebook.com/{0}/picture?type=small", id)
                Case Else
                    Return ""
            End Select
        End Get
    End Property
End Class
