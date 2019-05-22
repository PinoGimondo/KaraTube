Imports System.Data.SqlClient
Public Class DataAdapter
    Inherits RootDataAdapter

    Public Sub New(cs As String, u As User)
        MyBase.New(cs, u)
    End Sub

    Public Function getUserSecretData(userId As Integer, pin As String) As DataTable
        Dim ds As DataSet = Leggi("User_Manager", "SECRET_CODES", userId, pin)
        If ds.Tables.Count > 0 Then
            Return ds.Tables(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function getUserInfo(UserId As String) As DataTable
        Dim cmd As New SqlCommand("GetUserInfo")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@UserId", UserId)
        Dim dt As DataTable = Nothing
        db.CaricaDati(cmd, dt)
        Return dt
    End Function


    Public Function ListaArgomenti(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaArgomenti", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaInterventi(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaInterventi", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaPagine(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaPagine", funzione, P1, P2, P3, P4)
    End Function


    Public Function AdminCommand(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("S_AdminCommand", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaComputi(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaComputi", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaUtenti(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaUtenti", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaProgetti(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaProgetti", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaVoci(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaVoci", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaTag(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaTag", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaListini(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaListini", funzione, P1, P2, P3, P4)
    End Function

    Public Function ListaMisurazioni(funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Leggi("L_ListaMisurazioni", funzione, P1, P2, P3, P4)
    End Function

    Public Function GestioneVoce(id As Integer, funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "", Optional P5 As String = "") As DataSet
        Return Gestione("A_GestioneVoce", id, funzione, P1, P2, P3, P4, P5)
    End Function

    Public Function GestioneProgetto(id As Integer, funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Gestione("A_GestioneProgetto", id, funzione, P1, P2, P3, P4)
    End Function

    Public Function GestioneComputo(id As Integer, funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Gestione("A_GestioneComputo", id, funzione, P1, P2, P3, P4)
    End Function

    Public Function GestioneMisurazione(id As Integer, funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Gestione("A_GestioneMisurazione", id, funzione, P1, P2, P3, P4)
    End Function

    Public Function GestioneIntervento(id As Integer, funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Gestione("A_GestioneIntervento", id, funzione, P1, P2, P3, P4)
    End Function

    Public Function GestionePagina(id As Integer, funzione As String, Optional P1 As String = "", Optional P2 As String = "", Optional P3 As String = "", Optional P4 As String = "") As DataSet
        Return Gestione("A_GestionePagina", id, funzione, P1, P2, P3, P4)
    End Function

End Class
