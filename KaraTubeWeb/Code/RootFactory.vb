Public Class RootFactory
    Public Shared Function GetDataRow(ds As DataSet, Optional dtIndex As Integer = 0, Optional drIndex As Integer = 0) As DataRow
        Dim dr As DataRow = Nothing
        If ds IsNot Nothing Then
            If ds.Tables.Count > dtIndex Then
                Dim dt As DataTable = ds.Tables(dtIndex)
                If dt.Rows.Count >= drIndex Then
                    dr = dt.Rows(dtIndex)
                End If
            End If
        End If
        Return dr
    End Function
End Class
