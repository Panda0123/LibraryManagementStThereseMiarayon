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
End Class
