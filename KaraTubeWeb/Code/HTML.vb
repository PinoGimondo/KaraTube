Public Class HTML
    Protected Shared drop_events As String = " ondragenter='c.d_enter(this, event)' ondragleave='c.d_leave(this, event)' ondragover='c.d_over(this, event)'  ondrop='c.d_drop(this, event)' onmouseout='c.m_out(this, event)' onmouseover='c.m_over(this, event)' "

    'Public Shared Function tr_misurazione(m As Misurazione) As String
    '    Dim t As New Text.StringBuilder(2000)

    '    t.AppendFormat("<tr data-numeroVoce='{3}' data-voceId='{0}' data-misurazioneId='{1}' data-tipo='misurazione' id='m_{1}' {4} >{2}", m.voceId, m.misurazioneId, vbCrLf, m.numeroVoce, drop_events)
    '    t.AppendFormat("    <td colspan = '2' style='padding:0px; padding-left:4px; padding-right:4px; text-align:right'>{0}</td>{1}", Format.Tag(m).ToHtmlString, vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:center'>{0}</td>{1}", m.numeroMisurazione, vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:left'>{0}</td>{1}", Format.Misurazione(m).ToHtmlString, vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:right'>{0}</td>{1}", Format.Parti(m).ToHtmlString, vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:right'>{0}</td>{1}", Format.Lunghezza(m).ToHtmlString, vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:right'>{0}</td>{1}", Format.Larghezza(m).ToHtmlString, vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:right'>{0}</td>{1}", Format.AltezzaPeso(m).ToHtmlString, vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:right'>{0}</td>{1}", Format.Quantita(m).ToHtmlString, vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:right'>{0}</td>{1}", "", vbCrLf)
    '    t.AppendFormat("    <td style='padding:0px; padding-left:4px; padding-right:4px; text-align:right'><div id='menu-misurazione-container_{0}'></div></td>{1}", m.misurazioneId, vbCrLf)
    '    t.AppendLine("</tr>")
    '    Return t.ToString
    'End Function

    'Public Shared Function tr_special(tipoRiga As String, Optional id As String = "", Optional extra As String = "") As String
    '    Dim t As New Text.StringBuilder(2000)
    '    Select Case tipoRiga
    '        Case "PIPPO"

    '            t.AppendLine("<tr style='height:0px' >")
    '            t.AppendLine("<td><div style='background-color:red' id='cth-0'>0</div></td>")
    '            t.AppendLine("<td id='cth-1' >1</td>")
    '            t.AppendLine("<td id='cth-2' >2</td>")
    '            t.AppendLine("<td id='cth-3' >3</td>")
    '            t.AppendLine("<td id='cth-4' >4</td>")
    '            t.AppendLine("<td id='cth-5' >5</td>")
    '            t.AppendLine("<td id='cth-6' >6</td>")
    '            t.AppendLine("<td id='cth-7' >7</td>")
    '            t.AppendLine("<td id='cth-8' >8</td>")
    '            t.AppendLine("<td id='cth-9' >9</td>")
    '            t.AppendLine("<td id='cth-10' >10</td>")
    '            t.AppendLine("<td id='cth-11' >11</td>")
    '            t.AppendLine("</tr>")

    '        Case "CHAT_SPACER"
    '            t.AppendLine("<tr id=""int_0"" style=""height: 95%;padding:2px""><td></td></tr>")

    '        Case "COMPUTO_END_EMPTY"
    '            t.AppendFormat("<tr id='{2}' data-tipo='{0}' {3} >{1}", tipoRiga, vbCrLf, id, drop_events)
    '            t.AppendFormat("    <td {1} colspan='11'><div style='text-align:center'>Questo computo non contiene ancora voci - fai drag&drop in questa posizione per inserire una voce</div></td>{0}", vbCrLf, extra)
    '            t.AppendLine("</tr>")

    '        Case Else
    '            t.AppendFormat("<tr id='{2}' data-tipo='{0}' {3} {4} >{1}", tipoRiga, vbCrLf, id, extra, drop_events)
    '            t.AppendFormat("    <td {1} colspan='11'></td>{0}", vbCrLf, extra)
    '            t.AppendLine("</tr>")

    '    End Select


    '    Return t.ToString
    'End Function

    'Public Shared Function table_header() As String
    '    Dim t As New Text.StringBuilder(4000)
    '    t.AppendLine("<table class='table computo' >")
    '    t.AppendFormat("<tr>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='numero d\'ordine della voce' Class='mini-titolo-voce'>N°</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='codice della tariffa' Class='mini-titolo-voce'>tariffa</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td colspan='2' style='width:70%;padding:0px'><div title='descrizione dei lavori' Class='mini-titolo-voce'>descrizione dei lavori</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td colspan='7' style='width:25%;padding:0px'><div class='mini-titolo-voce'>&nbsp;</div></td>{0}", vbCrLf)
    '    t.AppendLine("</tr>")

    '    t.AppendFormat("<tr>{0}", vbCrLf)
    '    t.AppendFormat("    <td colspan='2' style='padding:0px'><div title='sottoclasse misurazione' Class='mini-titolo'>sottoclasse</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='numero della misurazione' Class='mini-titolo'>n°</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:70%;padding:0px'><div title='descrizione della misurazione' Class='mini-titolo'>descrizione della misurazione</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='parti uguali' Class='mini-titolo'>parti u.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='lunghezza' Class='mini-titolo'>lung.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='larghezza' Class='mini-titolo'>larg.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='altezza o peso' Class='mini-titolo'>H/peso</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='quantità totale' Class='mini-titolo'>quant.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='costo unitario' Class='mini-titolo'>costo un.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='costo totale' Class='mini-titolo'>totale</div></td>{0}", vbCrLf)
    '    t.AppendLine("</tr>")
    '    t.AppendLine("</table>")
    '    Return t.ToString

    'End Function

    'Public Shared Function trs_voce(v As Voce) As String

    '    Dim t As New Text.StringBuilder(4000)

    '    t.AppendFormat("<tr style='height:8px;' data-numeroVoce='{2}' data-voceId='{0}' data-tipo='start-voce' id='start_{0}' {3} >{1}", v.voceId, vbCrLf, v.numeroVoce, drop_events)
    '    t.AppendFormat("    <td colspan='11' style='border-top:hidden; width:25%;padding:0px'><div></div></td>{0}", vbCrLf)
    '    t.AppendLine("</tr>")

    '    t.AppendFormat("<tr data-numeroVoce='{2}' data-voceId='{0}' data-tipo='menu-voce' id='ev_{0}' {3} >{1}", v.voceId, vbCrLf, v.numeroVoce, drop_events)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='numero d\'ordine della voce' Class='mini-titolo-voce'>N°</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='codice della tariffa' Class='mini-titolo-voce'>tariffa / listino</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td colspan='2' style='width:70%;padding:0px'><div title='descrizione dei lavori' Class='mini-titolo-voce'>descrizione dei lavori</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td colspan='7' style='width:25%;padding:0px'><div class='mini-titolo-voce'>&nbsp;</div></td>{0}", vbCrLf)
    '    t.AppendLine("</tr>")

    '    t.AppendFormat("<tr data-numeroVoce='{2}' data-voceId='{0}' data-tipo='voce' id='v_{0}' {3} >{1}", v.voceId, vbCrLf, v.numeroVoce, drop_events)
    '    t.AppendFormat("    <td style='font-size:20px'><span name='span_numero_voce'>{0}</span></td>{1}", v.numeroVoce, vbCrLf)
    '    t.AppendFormat("    <td>{0}<div class='small'>{1}<div></td>{2}", v.codiceTariffa, Format.Listino(v), vbCrLf)
    '    t.AppendFormat("    <td colspan='2' >{0}</td>{1}", v.descrizioneVoce, vbCrLf)
    '    t.AppendFormat("    <td colspan='7' style='text-align:right;padding:2px;' ><div id='menu-voce-container_{0}' ></div></td>{1}", v.voceId, vbCrLf)
    '    t.AppendLine("</tr>")

    '    t.AppendFormat("<tr data-numeroVoce='{2}' data-voceId='{0}' data-tipo='menu-misurazione' id='em_{0}' {3} >{1}", v.voceId, vbCrLf, v.numeroVoce, drop_events)
    '    t.AppendFormat("    <td colspan='2' style='padding:0px'><div title='sottoclasse misurazione' Class='mini-titolo'>sottoclasse</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='numero della misurazione' Class='mini-titolo'>n°</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:70%;padding:0px'><div title='descrizione della misurazione' Class='mini-titolo'>descrizione della misurazione</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='parti uguali' Class='mini-titolo'>parti u.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='lunghezza' Class='mini-titolo'>lung.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='larghezza' Class='mini-titolo'>larg.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='altezza o peso' Class='mini-titolo'>H/peso</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='quantità totale' Class='mini-titolo'>quant.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='costo unitario' Class='mini-titolo'>costo un.</div></td>{0}", vbCrLf)
    '    t.AppendFormat("    <td style='width:3%;padding:0px'><div title='costo totale' Class='mini-titolo'>totale</div></td>{0}", vbCrLf)
    '    t.AppendLine("</tr>")

    '    For Each m As Misurazione In v.misurazioni
    '        t.Append(HTML.tr_misurazione(m))
    '    Next

    '    t.AppendFormat("<tr data-numeroVoce='{2}' data-voceId='{0}' data-tipo='totali-voce' id='t_{0}' {3} >{1}", v.voceId, vbCrLf, v.numeroVoce, drop_events)
    '    t.AppendFormat("    <td colspan='4' style='padding:0px; padding-right:4px;text-align:right'>sommano {0}</td>{1}", v.unitaMisura, vbCrLf)
    '    t.AppendFormat("    <td colspan='5' style='padding:0px; padding-right:4px;text-align:right'>{0}</td>{1}", Format.Quantita(v), vbCrLf)
    '    t.AppendFormat("    <td  style='padding:0px; padding-right:4px;text-align:right'>{0}</td>{1}", Format.Prezzo(v), vbCrLf)
    '    t.AppendFormat("    <td  style='padding:0px; padding-right:4px;text-align:right'>{0}</td>{1}", Format.importo(v), vbCrLf)
    '    t.AppendLine("</tr>")

    '    t.AppendFormat("<tr style='height:8px' data-numeroVoce='{2}' data-voceId='{0}' data-tipo='stop-voce' id='stop_{0}' {3} >{1}", v.voceId, vbCrLf, v.numeroVoce, drop_events)
    '    t.AppendFormat("    <td colspan='11' style='border-bottom:hidden; height:2px;width:25%;padding:0px'><div></div></td>{0}", vbCrLf)
    '    t.AppendLine("</tr>")

    '    't.AppendFormat("<tr data-numeroVoce='{2}' data-voceId='{0}' data-tipo='spacer' id='s_{0}' ondragenter='c.d_enter(this,event)' ondragleave='c.d_leave(this,event)' onmouseout='c.m_out(this)' onmouseover='c.m_over(this)'>{1}", v.voceId, vbCrLf, v.numeroVoce)
    '    't.AppendFormat("    <td style='border-bottom: hidden; border-left:hidden; border-right:hidden;padding:0px;' colspan='11'>&nbsp;</td>{0}", vbCrLf)
    '    't.AppendLine("</tr>")

    '    Return t.ToString
    'End Function

    'Public Shared Function tr_Intervento(i As Intervento) As String
    '    Dim t As New Text.StringBuilder(8000)
    '    t.AppendFormat("<tr id=int_{0} style=""margin:2px;min-height:40px;padding:2px"">{1}", i.interventoId, vbCrLf)
    '    t.AppendLine("   <td style=""width:92%; padding:2px"" >")
    '    t.AppendLine("   <div style=""display:flex;flex-wrap: nowrap;margin-right:20px"">")
    '    t.AppendLine("       <div class=""flex-column"">")
    '    t.AppendLine("          <div Class=""intervento-foto"">")
    '    t.AppendFormat("          <img src=""{0}"" style=""border-radius: 3px;width:48px;height:48px""/>{1}", UtenteProgetto.urlImmagineProfilo(i.utenteId), vbCrLf)
    '    t.AppendLine("          </div>")
    '    t.AppendLine("       </div>")
    '    t.AppendLine("       <div class=""flex-fill"">")
    '    t.AppendLine("          <div class=""intervento-container"">")
    '    t.AppendFormat("          <div Class=""intervento-utente"">{0}</div>{1}", i.userName, vbCrLf)
    '    t.AppendFormat("          <div Class=""intervento-testo"">{0}</div>{1}", Format.Intervento(i), vbCrLf)
    '    t.AppendFormat("          <div Class=""intervento-ora"">{0}</div>{1}", i.ora.ToString("dd/MM/yy HH:mm"), vbCrLf)
    '    t.AppendLine("          </div>")
    '    t.AppendLine("       </div>")
    '    t.AppendLine("    </div>")
    '    t.AppendLine("  </td>")
    '    t.AppendLine("</tr>")

    '    Return t.ToString
    'End Function

    'Public Shared Function div_Pagina(p As Pagina, isModificabile As Boolean) As String
    '    Dim t As New Text.StringBuilder(2000)
    '    t.AppendFormat("<div id = ""titolo-pagina"" Class=""titolo-pagina"" >{0}</div>", Format.titolo(p, isModificabile))
    '    t.AppendFormat("<div id = ""abstract-pagina"" Class=""abstract-pagina"" >{0}</div>", Format.abstract(p, isModificabile))
    '    t.AppendFormat("<div id = ""contenuto-pagina"" Class=""contenuto-pagina"" >{0}</div>", Format.contenuto(p, isModificabile))
    '    Return t.ToString
    'End Function

End Class
