Public Class ReservationDTO
    Property reservationId As Long

    Property userDTO As UserDTO
    Property reservedDate As String

    ' Property bookCopyDTO As BookCopyDTO
    Property bkCpyId As Long
    Property bkCpyNum As Integer
    Property title As String
    Property originalBookId As Long
End Class
