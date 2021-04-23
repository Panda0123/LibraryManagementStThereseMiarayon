Public Class ReservationDTO
    Property reservationId As Long

    Property userDTO As UserDTO
    Property reservedDate As String

    Property bkCpyId As Long
    Property bkCpyNum As Integer
    Property title As String
    Property originalBookId As Long
    Property isbn As String
    Property edition As String
    Property imageName As String
    Property cover As Image
End Class
