Public Class PaginationDTO
    Property pageNum As Integer
    Property pageSize As Integer
    Property sortBy As String
    Property searchKey As String
    Property filterDateAdded As String
    Property filterFirstPublicationYear As String
    Property filterLastPublicationYear As String
    Property filterClassification As String
    Property filterPublisher As String
    Property filterIsbn As String

    Public Sub New()
        Me.pageNum = 1
        Me.pageSize = Configurations.BooksPerPage
        Me.sortBy = "Date Added"
        Me.searchKey = String.Empty
        Me.filterDateAdded = String.Empty
        Me.filterFirstPublicationYear = String.Empty
        Me.filterLastPublicationYear = String.Empty
        Me.filterClassification = String.Empty
        Me.filterPublisher = String.Empty
        Me.filterIsbn = String.Empty
    End Sub

    Public Sub setToDefault()
        Me.pageNum = 1
        Me.sortBy = "Date Added"
        Me.searchKey = String.Empty
        Me.filterDateAdded = String.Empty
        Me.filterFirstPublicationYear = String.Empty
        Me.filterLastPublicationYear = String.Empty
        Me.filterClassification = String.Empty
        Me.filterPublisher = String.Empty
        Me.filterIsbn = String.Empty
    End Sub

End Class
