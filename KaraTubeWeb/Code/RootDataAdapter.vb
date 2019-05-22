Imports System.Data.SqlClient
Imports ServiziDB

Public MustInherit Class RootDataAdapter
    Public db As SERVIZI_DB
    Public utente As User

    Public Sub New(ConnectionString As String, _utente As User)
        db = New SERVIZI_DB
        db.ConnectionString = ConnectionString
        utente = _utente
        If utente Is Nothing Then utente = New User(0)
    End Sub

    Public Overloads Function Leggi(CommandText As String) As DataSet
        Dim cmd As New SqlCommand(CommandText)
        cmd.CommandType = CommandType.Text
        Dim ds As New DataSet
        db.CaricaDati(cmd, ds)
        Return ds
    End Function

    Public Function Gestione(StoredProcedureName As String, id As Integer, funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "", Optional P5 As String = "", Optional X As Byte() = Nothing)

        If P1 Is Nothing Then P1 = ""
        If P2 Is Nothing Then P2 = ""
        If P3 Is Nothing Then P3 = ""
        If P4 Is Nothing Then P4 = ""

        Dim cmd As New SqlCommand(StoredProcedureName)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@utenteId", utente.utenteId)
        cmd.Parameters.AddWithValue("@funzione", funzione)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@P1", IIf(P1 Is Nothing, "", P1))
        cmd.Parameters.AddWithValue("@P2", IIf(P2 Is Nothing, "", P2))
        cmd.Parameters.AddWithValue("@P3", IIf(P3 Is Nothing, "", P3))
        cmd.Parameters.AddWithValue("@P4", IIf(P4 Is Nothing, "", P4))

        If P5 <> "" Then
            cmd.Parameters.AddWithValue("@P5", IIf(P5 Is Nothing, "", P5))
        End If

        If X IsNot Nothing Then
            cmd.Parameters.AddWithValue("@X", X)
        End If

        Dim ds As New DataSet
        db.CaricaDati(cmd, ds)

        If db.LastActionSuccess Then
            Return ds
        Else
            Throw New Exception("errore interno: " & db.LastException.Message, db.LastException)
        End If
    End Function


    'Public Function Leggi(StoredProcedureName As String, TipoListaId As Integer, WhereClause As String, OrderByClause As String, P1 As String, P2 As String)
    '    Dim cmd As New SqlCommand(StoredProcedureName)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Parameters.AddWithValue("@Token", utente.utente.tokenInfo.token)
    '    cmd.Parameters.AddWithValue("@TipoListaID", TipoListaId)
    '    cmd.Parameters.AddWithValue("@WhereClause", WhereClause)
    '    cmd.Parameters.AddWithValue("@OrderByClause", OrderByClause)
    '    cmd.Parameters.AddWithValue("@P1", P1)
    '    cmd.Parameters.AddWithValue("@P2", P2)
    '    Dim ds As New DataSet
    '    db.CaricaDati(cmd, ds)
    '    Return ds
    'End Function



    Public Overloads Function Leggi(StoredProcedureName As String, funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "")
        Dim cmd As New SqlCommand(StoredProcedureName)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@utenteId", utente.utenteId)
        cmd.Parameters.AddWithValue("@funzione", funzione)
        cmd.Parameters.AddWithValue("@P1", P1)
        cmd.Parameters.AddWithValue("@P2", P2)
        cmd.Parameters.AddWithValue("@P3", P3)
        cmd.Parameters.AddWithValue("@P4", P4)
        Dim ds As New DataSet
        db.CaricaDati(cmd, ds)
        If db.LastActionSuccess Then
            Return ds
        Else
            Throw New Exception("errore interno: " & db.LastException.Message, db.LastException)
        End If

    End Function

End Class

