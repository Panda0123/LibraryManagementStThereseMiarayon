Public Class AuthorDTO
    Property id As Int64
    Property f_name As String
    Property m_name As String
    Property l_name As String

    Public Sub New()
    End Sub

    Public Sub New(id As Long, f_name As String, name As String, l_name As String)
        Me.id = id
        Me.f_name = f_name
        m_name = name
        Me.l_name = l_name
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim dTO = TryCast(obj, AuthorDTO)
        Return dTO IsNot Nothing AndAlso
               id = dTO.id
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 926444256
        hashCode = (hashCode * -1521134295 + id.GetHashCode()).GetHashCode()
        Return hashCode
    End Function

End Class
