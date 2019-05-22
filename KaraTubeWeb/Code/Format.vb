Public Class Format
    Public Shared num As String = "###,##0.00"
    Public Shared nnn As HtmlString = New HtmlString("<div style='color:gray; text-align:center' title=""elemento non modificabile perché incompatibile con l'unità di misura utilizzata in questa misurazione"">&nbsp;-&nbsp;</div>")

    Protected Shared Function getVal(src As Object, propName As String) As Object
        Return src.GetType().GetProperty(propName).GetValue(src, Nothing)
    End Function

    Protected Shared Function getPrepJS(campo As String, defalutValue As String, objectId As String)
        Return String.Format("ondblclick=""c.p(this, '{0}','{1}','{2}')""", campo, defalutValue, objectId)
    End Function

    'Public Shared Function IncapsulaContenutoStatico(o As OggettoGecola, campo As String, Optional valueToShow As String = "") As IHtmlString
    '    Dim value As String = o.GetType().GetProperty(campo).GetValue(o, Nothing)
    '    If valueToShow = "" Then valueToShow = value

    '    Dim t As New StringBuilder(100)
    '    t.AppendFormat("<div class='inactive-control-container' id='{0}' data-o_id='{1}' data-f_name='{2}' >", campo & "_" & o.uid, o.oggettoId, campo)
    '    t.Append(valueToShow)
    '    t.Append("</div>")

    '    Return New HtmlString(t.ToString)

    'End Function

    'Public Shared Function Incapsula(o As OggettoGecola, campo As String, Optional campoId As String = "", Optional modificabile As Boolean = True, Optional valueToShow As String = "", Optional valueToStore As String = "") As IHtmlString

    '    If modificabile Then
    '        If campoId = "" Then campoId = campo
    '        Dim value As String = o.GetType().GetProperty(campo).GetValue(o, Nothing)
    '        Dim valueId As String = o.GetType().GetProperty(campoId).GetValue(o, Nothing)
    '        If valueToShow = "" Then valueToShow = value

    '        If valueToStore <> "" Then
    '            value = valueToStore
    '            valueId = ""
    '        End If

    '        Dim t As New StringBuilder(100)
    '        t.AppendFormat("<div title='fare doppio click per modificare questo elemento' class='active-control-container' id='{0}' data-o_id='{1}' data-f_name='{2}' data-f_value=""{3}"" data-f_valueId='{4}' ondblclick=c.p(this) >", campo & "_" & o.uid, o.oggettoId, campo, value, valueId)
    '        t.Append(valueToShow)
    '        t.Append("</div>")
    '        Return New HtmlString(t.ToString)
    '    Else
    '        Return IncapsulaContenutoStatico(o, campo, valueToShow)
    '    End If

    'End Function


    'Public Shared Function Tag(m As Misurazione) As IHtmlString
    '    Return Incapsula(m, "tag", "tagId")
    'End Function

    'Public Shared Function Misurazione(m As Misurazione) As IHtmlString
    '    Return Incapsula(m, "misurazione")
    'End Function

    'Public Shared Function Parti(m As Misurazione) As IHtmlString
    '    If m.a_parti Then
    '        Return Incapsula(m, "parti",, m.a_parti, IIf(m.parti > 1, m.parti, "&nbsp;"))
    '    Else
    '        Return nnn
    '    End If
    'End Function

    'Public Shared Function Lunghezza(m As Misurazione) As IHtmlString
    '    If m.a_lunghezza Then
    '        Return Incapsula(m, "lunghezza",, m.a_lunghezza, IIf(m.lunghezza > 0, m.lunghezza.ToString(num), "&nbsp;"))
    '    Else
    '        Return nnn
    '    End If
    'End Function

    'Public Shared Function Larghezza(m As Misurazione) As IHtmlString
    '    If m.a_larghezza Then
    '        Return Incapsula(m, "larghezza",, m.a_larghezza, IIf(m.larghezza > 0, m.larghezza.ToString(num), "&nbsp;"))
    '    Else
    '        Return nnn
    '    End If

    'End Function

    'Public Shared Function AltezzaPeso(m As Misurazione) As IHtmlString
    '    If m.a_altezzaPeso Then
    '        Return Incapsula(m, "altezzaPeso",, m.a_altezzaPeso, IIf(m.altezzaPeso > 0, m.altezzaPeso.ToString(num), "&nbsp;"))
    '    Else
    '        Return nnn
    '    End If
    'End Function

    ''Public Shared Function Peso(m As Misurazione) As String
    ''    Dim contenuto As String = m.peso.ToString(num)
    ''    If contenuto = nullnum1 Then contenuto = ""
    ''    Return contenuto
    ''End Function
    'Public Shared Function Quantita(m As Misurazione) As IHtmlString
    '    Return IncapsulaContenutoStatico(m, "quantita", m.quantita.ToString(num))
    'End Function

    'Public Shared Function Listino(v As Voce) As IHtmlString
    '    Return Incapsula(v, "listino", "listinoId")
    'End Function
    'Public Shared Function Quantita(v As Voce) As IHtmlString
    '    Return IncapsulaContenutoStatico(v, "quantita", v.quantita.ToString(num))
    'End Function

    'Public Shared Function Prezzo(v As Voce) As IHtmlString
    '    Return IncapsulaContenutoStatico(v, "prezzo", v.prezzo.ToString(num))
    'End Function

    'Public Shared Function importo(v As Voce) As IHtmlString
    '    Return IncapsulaContenutoStatico(v, "importoVoce", v.importoVoce.ToString(num))
    'End Function
    'Public Shared Function Intervento(i As Intervento) As IHtmlString
    '    Dim t As New StringBuilder(i.intervento)
    '    t = t.Replace(vbCrLf, "<br />")
    '    Return New HtmlString(t.ToString)
    'End Function

    'Public Shared Function titolo(p As Pagina, modificabile As Boolean) As IHtmlString
    '    Return Incapsula(p, "titolo",, modificabile,, "*")
    'End Function

    'Public Shared Function abstract(p As Pagina, modificabile As Boolean) As IHtmlString
    '    Return Incapsula(p, "abstract",, modificabile,, "*")
    'End Function

    'Public Shared Function contenuto(p As Pagina, modificabile As Boolean) As IHtmlString
    '    Return Incapsula(p, "contenuto",, modificabile,, "*")
    'End Function


End Class
