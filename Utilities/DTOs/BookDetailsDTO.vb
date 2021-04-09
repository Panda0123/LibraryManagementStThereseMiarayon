Public Class BookDetailsDTO
    Property bookId As Int64
    Property title As String
    Property publishedDate As String
    Property dateAdded As String
    Property language As String
    Property edition As Int16
    Property isbn As String
    Property imageName As String

    Property quantity As Int32
    Property numAvailable As Int32

    Property publisherId As Int64
    Property publisherName As String
    Property publisherAddress As String
    Property categoryId As Int64
    Property categoryName As String
    Property copyrightId As Int64
    Property copyrightName As String

    Property copyrightYear As Int16
    Property shelfId As Int16
    Property shelfName As String
    Property summary As String

    Property authors As List(Of AuthorDTO)
    Property copies As List(Of BookCopyDTO)
    Property image As Image

End Class
