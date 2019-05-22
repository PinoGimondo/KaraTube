Imports System.IO

Public Class S
    Public Shared Function GetPropertyValue(ByVal obj As Object, ByVal PropName As String) As Object
        Try
            Dim pnc() As String = PropName.Split(".")

            Dim objType As Type = obj.GetType()
            Dim pInfo As System.Reflection.PropertyInfo = objType.GetProperty(pnc(0))
            Dim PropValue As Object = pInfo.GetValue(obj, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing)
            If pnc.Length > 1 Then
                Return GetPropertyValue(PropValue, PropName.Remove(0, pnc(0).Length + 1))
            Else
                Return PropValue
            End If

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function GetPropertiesValuesAsArray(l As IEnumerable(Of Object), ByVal PropNames() As String, Optional firstRowAreTitles As Boolean = True) As String(,)
        Dim nRows As Integer = l.Count
        Dim nCols As Integer = PropNames.Count
        Dim r As Integer = 0

        If firstRowAreTitles Then
            nRows += 1
        End If

        Dim a(nCols - 1, nRows - 1) As String

        If firstRowAreTitles Then
            For i As Integer = 0 To nCols - 1
                a(i, r) = PropNames(i).Split(".").ToList.Last
            Next
            r += 1
        End If

        Try
            For Each o As Object In l
                For i As Integer = 0 To nCols - 1
                    a(i, r) = GetPropertyValue(o, Trim(PropNames(i)))
                Next
                r += 1
            Next

        Catch ex As Exception

        End Try
        Return a

    End Function

    'Public Shared Function objectToJSON(o As Object, tipo As Type) As String
    '    Dim ms As MemoryStream = New MemoryStream()
    '    Dim ser As DataContractJsonSerializer = New DataContractJsonSerializer(tipo)
    '    ser.WriteObject(ms, o)
    '    Dim json As Byte() = ms.ToArray()
    '    ms.Close()
    '    Return Encoding.UTF8.GetString(json, 0, json.Length)
    'End Function


End Class
