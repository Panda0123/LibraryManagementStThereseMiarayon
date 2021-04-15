Module Security

    Public Function turnToValidStringQuery(ByVal query As String) As String
        query = query.Trim
        query = query.Replace(" ", "+")
        query = query.Replace("'", "''")  ' replace single quote to double quote
        Debug.WriteLine(query)
        Return query
    End Function

End Module
