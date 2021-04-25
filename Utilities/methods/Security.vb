Module Security

    Public Function turnToValidStringQuery(ByVal query As String) As String
        query = query.Trim
        query = query.Replace(" ", "+")
        query = query.Replace("'", "''")  ' replace single quote to double quote
        Return query
    End Function
    Public Function isValuePositiveShort(ByVal value As String, ByVal name As String) As Boolean
        value = value.Trim
        Dim valueParseShort As Short
        If IsNumeric(value) Then
            MessageBox.Show(name + " not valid: must be numeric.")
            Return False
        End If
        Try
            valueParseShort = Short.Parse(value)
        Catch ex As Exception
            MessageBox.Show(name + " not valid: exceeded possible value (must be within 32,767).")
            Return False
        End Try
        If valueParseShort < 0 Then
            MessageBox.Show(name + " not valid: must be positive.")
            Return False
        End If
        Return True
    End Function

End Module
