Module Security

    Public Function turnToValidStringQuery(ByRef query As String) As String
        query = query.Trim
        query = query.Replace(" ", "+")
        query = query.Replace("'", "''")  ' replace single quote to double quote
        Return query
    End Function

End Module
