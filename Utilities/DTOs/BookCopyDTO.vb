Public Class BookCopyDTO
    'Inherits DataGridViewRow

    Property id As Int64
    Property copy_num As Int32
    Property status As String


    Public Sub New()

    End Sub
    Public Sub New(id As Int64, copy_num As Int32)
        Me.id = id
        Me.copy_num = copy_num
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim dTO = TryCast(obj, BookCopyDTO)
        Return dTO IsNot Nothing AndAlso
               copy_num = dTO.copy_num
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = -972142993
        hashCode = (hashCode * -1521134295 + copy_num.GetHashCode()).GetHashCode()
        Return hashCode
    End Function
End Class
