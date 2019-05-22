Imports ServiziDB
Public Class Factory
    Inherits RootFactory

    'Public Shared Function leggiVoce(ds As DataSet, Optional o As Voce = Nothing) As Voce
    '    Dim dr As DataRow = GetDataRow(ds)
    '    If dr Is Nothing Then
    '        Return Nothing
    '    Else
    '        Dim v As Voce = Factory.leggiVoce(dr, o)
    '        If ds.Tables.Count > 1 Then
    '            v.misurazioni = New ListaMisurazioni
    '            Dim lm As ListaMisurazioni = leggiListaMisurazioni(ds.Tables(1))
    '            For Each m As Misurazione In lm
    '                If m.voceId = v.voceId Then
    '                    v.misurazioni.Add(m)
    '                End If
    '            Next
    '        End If
    '        Return v
    '    End If
    'End Function

    'Public Shared Function leggiVoce(dr As DataRow, Optional o As Voce = Nothing) As Voce
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Voce
    '        With o
    '            .progettoId = SupportoDB.LeggiString(dr("progettoId"))
    '            .computoId = SupportoDB.LeggiString(dr("computoId"))
    '            .voceId = SupportoDB.LeggiString(dr("voceId"))
    '            .codiceTariffa = SupportoDB.LeggiString(dr("codiceTariffa"))
    '            .voce = SupportoDB.LeggiString(dr("voce"))
    '            .descrizioneVoce = SupportoDB.LeggiString(dr("descrizioneVoce"))
    '            .unitaMisura = SupportoDB.LeggiString(dr("unitaMisura"))
    '            .descrizioneUnitaMisura = SupportoDB.LeggiString(dr("descrizioneUnitaMisura"))
    '            .prezzo = SupportoDB.LeggiDouble(dr("prezzo"))
    '            .soa = SupportoDB.LeggiString(dr("soa"))
    '            .descrizioneSoa = SupportoDB.LeggiString(dr("descrizioneSoa"))
    '            .numeroVoce = SupportoDB.LeggiInteger(dr("numeroVoce"))
    '            .importoVoce = SupportoDB.LeggiDouble(dr("importoVoce"))
    '            .quantita = SupportoDB.LeggiDouble(dr("quantita"))
    '            .nMisurazioni = SupportoDB.LeggiInteger(dr("nMisurazioni"))

    '            .utenteId = SupportoDB.LeggiString(dr("utenteId"))
    '            .accesso = SupportoDB.LeggiString(dr("accesso"))
    '            .listinoId = SupportoDB.LeggiString(dr("listinoId"))
    '            .listino = SupportoDB.LeggiString(dr("listino"))
    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaVoci(ds As DataSet) As ListaVoci
    '    Dim lv As ListaVoci = Nothing
    '    If ds IsNot Nothing Then

    '        If ds.Tables.Count > 0 Then
    '            lv = leggiListaVoci(ds.Tables(0))
    '            For Each v As Voce In lv
    '                v.misurazioni = New ListaMisurazioni
    '            Next
    '        End If
    '        If ds.Tables.Count > 1 Then
    '            Dim v As Voce
    '            Dim dv As New DizionarioVoci(lv)
    '            Dim lm As ListaMisurazioni = leggiListaMisurazioni(ds.Tables(1))
    '            For Each m As Misurazione In lm
    '                If dv.ContainsKey(m.voceId) Then
    '                    v = dv.Item(m.voceId)
    '                    v.misurazioni.Add(m)
    '                End If
    '            Next
    '        End If
    '    End If
    '    Return lv
    'End Function


    'Public Shared Function leggiListaVoci(dt As DataTable, Optional l As ListaVoci = Nothing) As ListaVoci
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaVoci
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiVoce(dr))
    '        Next
    '    End If
    '    Return l
    'End Function

    'Public Shared Function leggiDizionarioVoci(dt As DataTable, Optional l As ListaVoci = Nothing) As DizionarioVoci
    '    Dim lv As ListaVoci = leggiListaVoci(dt, l)
    '    Dim dv As New DizionarioVoci
    '    For Each v As Voce In lv
    '        dv.Add(v.voceId, v)
    '    Next
    '    Return dv
    'End Function

    'Public Shared Function leggiMisurazione(ds As DataSet, Optional o As Misurazione = Nothing) As Misurazione
    '    Dim dr As DataRow = GetDataRow(ds)
    '    If dr Is Nothing Then
    '        Return Nothing
    '    Else
    '        Dim m As Misurazione = leggiMisurazione(dr, o)
    '        Return m
    '    End If
    'End Function

    'Public Shared Function leggiMisurazione(dr As DataRow, Optional o As Misurazione = Nothing) As Misurazione
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Misurazione
    '        With o
    '            .progettoId = SupportoDB.LeggiString(dr("progettoId"))
    '            .computoId = SupportoDB.LeggiString(dr("computoId"))
    '            .voceId = SupportoDB.LeggiString(dr("voceId"))
    '            .misurazioneId = SupportoDB.LeggiString(dr("misurazioneId"))
    '            .misurazione = SupportoDB.LeggiString(dr("misurazione"))
    '            .codiceTariffa = SupportoDB.LeggiString(dr("codiceTariffa"))
    '            .prezzo = SupportoDB.LeggiDouble(dr("prezzo"))
    '            .quantita = SupportoDB.LeggiDouble(dr("quantita"))
    '            .importoMisurazione = SupportoDB.LeggiDouble(dr("importoMisurazione"))
    '            .parti = SupportoDB.LeggiInteger(dr("parti"))
    '            .lunghezza = SupportoDB.LeggiDouble(dr("lunghezza"))
    '            .larghezza = SupportoDB.LeggiDouble(dr("larghezza"))
    '            .altezzaPeso = SupportoDB.LeggiDouble(dr("altezzaPeso"))
    '            .unitaMisura = SupportoDB.LeggiString(dr("unitaMisura"))
    '            .descrizioneUnitaMisura = SupportoDB.LeggiString(dr("descrizioneUnitaMisura"))
    '            .a_parti = SupportoDB.LeggiBoolean(dr("a_parti"))
    '            .a_lunghezza = SupportoDB.LeggiBoolean(dr("a_lunghezza"))
    '            .a_larghezza = SupportoDB.LeggiBoolean(dr("a_larghezza"))
    '            .a_altezzaPeso = SupportoDB.LeggiBoolean(dr("a_altezzaPeso"))

    '            .tagId = SupportoDB.LeggiString(dr("tagId"))
    '            .tag = SupportoDB.LeggiString(dr("tag"))

    '            .numeroVoce = SupportoDB.LeggiString(dr("numeroVoce"))
    '            .numeroMisurazione = SupportoDB.LeggiString(dr("numeroMisurazione"))

    '            .utenteId = SupportoDB.LeggiString(dr("utenteId"))
    '            .accesso = SupportoDB.LeggiString(dr("accesso"))

    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaMisurazioni(dt As DataTable, Optional l As ListaMisurazioni = Nothing) As ListaMisurazioni
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaMisurazioni
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiMisurazione(dr))
    '        Next
    '    End If
    '    Return l
    'End Function

    'Public Shared Function leggiDizionarioMisurazioni(dt As DataTable, Optional l As ListaMisurazioni = Nothing) As DizionarioMisurazioni
    '    Dim lm As ListaMisurazioni = leggiListaMisurazioni(dt, l)
    '    Dim dm As New DizionarioMisurazioni
    '    For Each m As Misurazione In lm
    '        dm.Add(m.misurazioneId, m)
    '    Next
    '    Return dm
    'End Function

    'Public Shared Function leggiProgetto(dr As DataRow, Optional o As Progetto = Nothing) As Progetto
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Progetto
    '        With o
    '            .progettoId = SupportoDB.LeggiString(dr("progettoId"))
    '            .progetto = SupportoDB.LeggiString(dr("progetto"))
    '            .utenteId = SupportoDB.LeggiString(dr("utenteId"))
    '            .accesso = SupportoDB.LeggiString(dr("accesso"))

    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaProgetti(ds As DataSet) As ListaProgetti
    '    Dim l As ListaProgetti = Nothing
    '    If ds IsNot Nothing Then

    '        If ds.Tables.Count > 0 Then
    '            l = leggiListaProgetti(ds.Tables(0))
    '            For Each p As Progetto In l
    '                p.computi = New ListaComputi
    '            Next
    '        End If
    '        If ds.Tables.Count > 1 Then
    '            Dim p As Progetto
    '            Dim dp As New DizionarioProgetti(l)
    '            Dim lc As ListaComputi = leggiListaComputi(ds.Tables(1))
    '            For Each c As Computo In lc
    '                If dp.ContainsKey(c.progettoId) Then
    '                    p = dp.Item(c.progettoId)
    '                    p.computi.Add(c)
    '                End If
    '            Next
    '        End If
    '    End If
    '    Return l
    'End Function


    'Public Shared Function leggiListaProgetti(dt As DataTable, Optional l As ListaProgetti = Nothing) As ListaProgetti
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaProgetti
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiProgetto(dr))
    '        Next
    '    End If
    '    Return l
    'End Function

    'Public Shared Function leggiComputo(dr As DataRow, Optional o As Computo = Nothing) As Computo
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Computo
    '        With o
    '            .progettoId = SupportoDB.LeggiString(dr("progettoId"))
    '            .progetto = SupportoDB.LeggiString(dr("progetto"))
    '            .computoId = SupportoDB.LeggiString(dr("computoId"))
    '            .computo = SupportoDB.LeggiString(dr("computo"))
    '            .utenteId = SupportoDB.LeggiString(dr("utenteId"))
    '            .accesso = SupportoDB.LeggiString(dr("accesso"))
    '            If dr.Table.Columns.Contains("nVoci") Then
    '                .nVoci = SupportoDB.LeggiInteger(dr("nVoci"))
    '                .nMisurazioni = SupportoDB.LeggiInteger(dr("nMisurazioni"))
    '                .importo = SupportoDB.LeggiDouble(dr("importo"))
    '            End If
    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaComputi(dt As DataTable, Optional l As ListaComputi = Nothing) As ListaComputi
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaComputi
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiComputo(dr))
    '        Next
    '    End If
    '    Return l
    'End Function

    'Public Shared Function leggiTag(dr As DataRow, Optional o As Tag = Nothing) As Tag
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Tag
    '        With o
    '            .tagId = SupportoDB.LeggiString(dr("tagId"))
    '            .tag = SupportoDB.LeggiString(dr("tag"))
    '            .computoId = SupportoDB.LeggiString(dr("computoId"))
    '            .parentTagId = SupportoDB.LeggiString(dr("parentTagId"))
    '            .parentTag = SupportoDB.LeggiString(dr("parentTag"))
    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaTag(dt As DataTable, Optional l As ListaTag = Nothing) As ListaTag
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaTag
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiTag(dr))
    '        Next
    '    End If
    '    Return l
    'End Function

    'Public Shared Function leggiListino(dr As DataRow, Optional o As Listino = Nothing) As Listino
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Listino
    '        With o
    '            .listinoId = SupportoDB.LeggiString(dr("listinoId"))
    '            .progettoId = SupportoDB.LeggiString(dr("progettoId"))
    '            .listino = SupportoDB.LeggiString(dr("listino"))
    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaListini(dt As DataTable, Optional l As ListaListini = Nothing) As ListaListini
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaListini
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiListino(dr))
    '        Next
    '    End If
    '    Return l
    'End Function



    'Public Shared Function leggiArgomento(dr As DataRow, Optional o As Argomento = Nothing) As Argomento
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Argomento
    '        With o
    '            .progettoId = SupportoDB.LeggiString(dr("progettoId"))
    '            .argomentoId = SupportoDB.LeggiString(dr("argomentoId"))
    '            .argomento = SupportoDB.LeggiString(dr("argomento"))
    '            .creatoUtenteId = SupportoDB.LeggiString(dr("creatoUtenteId"))
    '            .creatoUserName = SupportoDB.LeggiString(dr("creatoUserName"))
    '            .creatoOra = SupportoDB.LeggiDateTime(dr("creatoOra"))
    '            .ultimoInterventoId = SupportoDB.LeggiString(dr("ultimoInterventoId"))
    '            .numeroUltimoIntervento = SupportoDB.LeggiInteger(dr("numeroUltimoIntervento"))
    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaArgomenti(dt As DataTable, Optional l As ListaArgomenti = Nothing) As ListaArgomenti
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaArgomenti
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiArgomento(dr))
    '        Next
    '    End If
    '    Return l
    'End Function

    'Public Shared Function leggiIntervento(dr As DataRow, Optional o As Intervento = Nothing) As Intervento
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Intervento
    '        With o
    '            .interventoId = SupportoDB.LeggiString(dr("interventoId"))
    '            .argomentoId = SupportoDB.LeggiString(dr("argomentoId"))
    '            .intervento = SupportoDB.LeggiString(dr("intervento"))
    '            .utenteId = SupportoDB.LeggiString(dr("utenteId"))
    '            .userName = SupportoDB.LeggiString(dr("UserName"))
    '            .ora = SupportoDB.LeggiDateTime(dr("ora"))
    '            .numeroIntervento = SupportoDB.LeggiString(dr("numeroIntervento"))
    '            .cancellato = SupportoDB.LeggiBoolean(dr("cancellato"))
    '            .isNew = SupportoDB.LeggiBoolean(dr("isNew"))
    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaInterventi(dt As DataTable, Optional l As ListaInterventi = Nothing) As ListaInterventi
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaInterventi
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiIntervento(dr))
    '        Next
    '    End If
    '    Return l
    'End Function

    'Public Shared Function leggiUtenteProgetto(dr As DataRow, Optional o As UtenteProgetto = Nothing) As UtenteProgetto
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New UtenteProgetto
    '        With o
    '            .utenteId = SupportoDB.LeggiString(dr("utenteId"))
    '            .userName = SupportoDB.LeggiString(dr("userName"))
    '            .Email = SupportoDB.LeggiString(dr("Email"))
    '            .isEnabled = SupportoDB.LeggiBoolean(dr("isEnabled"))
    '            .loginProvider = SupportoDB.LeggiString(dr("loginProvider"))
    '            .progettoId = SupportoDB.LeggiString(dr("progettoId"))
    '            .accesso = SupportoDB.LeggiString(dr("accesso"))

    '            Dim b() As Byte = dr("profileImage")
    '            If b.Length > 100 Then
    '                .profileImage = Convert.ToBase64String(b)
    '            End If

    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaUtentiProgetto(dt As DataTable, Optional l As ListaUtentiProgetto = Nothing) As ListaUtentiProgetto
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaUtentiProgetto
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiUtenteProgetto(dr))
    '        Next
    '    End If
    '    Return l
    'End Function

    'Public Shared Function leggiPagina(dr As DataRow, Optional o As Pagina = Nothing) As Pagina
    '    If dr IsNot Nothing Then
    '        If o Is Nothing Then o = New Pagina
    '        With o
    '            .paginaId = SupportoDB.LeggiString(dr("paginaId"))
    '            .parentId = SupportoDB.LeggiString(dr("parentId"))
    '            .titolo = SupportoDB.LeggiString(dr("titolo"))
    '            .abstract = SupportoDB.LeggiString(dr("abstract"))
    '            .contenuto = SupportoDB.LeggiString(dr("contenuto"))
    '            .tipo = SupportoDB.LeggiString(dr("tipo"))
    '            .utenteId = SupportoDB.LeggiString(dr("utenteId"))
    '            .userName = SupportoDB.LeggiString(dr("username"))
    '            .ultimaModifica = SupportoDB.LeggiDateTime(dr("ultimaModifica"))
    '        End With
    '    End If
    '    Return o
    'End Function

    'Public Shared Function leggiListaPagine(dt As DataTable, Optional l As ListaPagine = Nothing) As ListaPagine
    '    If dt IsNot Nothing Then
    '        If l Is Nothing Then
    '            l = New ListaPagine
    '        Else
    '            l.Clear()
    '        End If
    '        For Each dr As DataRow In dt.Rows
    '            l.Add(leggiPagina(dr))
    '        Next
    '    End If
    '    Return l
    'End Function


End Class
