Public Class BorrowDTO

    Property borrowId As Long
    Property userDTO As UserDTO
    Property issueDate As String
    Property returnedDate As String
    Property dueDate As String
    ' Property bookCopyDTO As BookCopyDTO
    Property bkCpyId As Long
    Property bkCpyNum As Integer
    Property title As String
    Property originalBookId As Long
    Property isbn As String
    Property edition As String
    Property imageName As String
    Property cover As Image

End Class
