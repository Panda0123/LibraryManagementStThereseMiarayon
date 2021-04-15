Imports Newtonsoft.Json

Module BookController
    Private URL As String = HttpRequestController.URL + "/book"
    Public Function getBooks() As List(Of BookDetailsDTO)
        Dim response As String = HttpRequestController.HttpRequestGet(URL + "/all")
        Dim responseDct As List(Of BookDetailsDTO) = JsonConvert.DeserializeObject(Of List(Of BookDetailsDTO))(response)
        Return responseDct
    End Function

    Public Function getBooksPaginationSortBy(ByRef paginationDTO As PaginationDTO) As List(Of BookDetailsDTO)
        Dim newURL = URL + "/all/pagination/?pageNum=" + paginationDTO.pageNum.ToString() + "&pageSize=" + paginationDTO.pageSize.ToString() + "&sortBy=" + paginationDTO.sortBy

        If Not paginationDTO.searchKey.Equals(String.Empty) Then
            newURL += "&searchKey=" + Security.turnToValidStringQuery(paginationDTO.searchKey)
        End If

        If Not paginationDTO.filterDateAdded.Equals(String.Empty) Then
            newURL += "&filterDateAdded=" + paginationDTO.filterDateAdded
        End If

        If Not paginationDTO.filterFirstPublicationYear.Equals(String.Empty) Then
            newURL += "&filterFirstPublicationYear=" + paginationDTO.filterFirstPublicationYear
        End If

        If Not paginationDTO.filterLastPublicationYear.Equals(String.Empty) Then
            newURL += "&filterLastPublicationYear=" + paginationDTO.filterLastPublicationYear
        End If

        If Not paginationDTO.filterClassification.Equals(String.Empty) Then
            newURL += "&filterClassification=" + Security.turnToValidStringQuery(paginationDTO.filterClassification)
        End If

        If Not paginationDTO.filterPublisher.Equals(String.Empty) Then
            newURL += "&filterPublisher=" + Security.turnToValidStringQuery(paginationDTO.filterPublisher)
        End If

        If Not paginationDTO.filterIsbn.Equals(String.Empty) Then
            newURL += "&filterIsbn=" + Security.turnToValidStringQuery(paginationDTO.filterIsbn)
        End If

        If Not paginationDTO.filterLanguage.Equals(String.Empty) Then
            newURL += "&filterLanguage=" + Security.turnToValidStringQuery(paginationDTO.filterLanguage)
        End If

        Dim response As String = HttpRequestController.HttpRequestGet(newURL)
        Dim responseDct As List(Of BookDetailsDTO) = JsonConvert.DeserializeObject(Of List(Of BookDetailsDTO))(response)
        Return responseDct
    End Function

    Public Function getBook(id As String) As BookDetailsDTO
        Dim newUrl = URL + "/all/" + id
        Dim response As String = HttpRequestController.HttpRequestGet(newUrl)
        Return JsonConvert.DeserializeObject(Of BookDetailsDTO)(response)
    End Function

    Public Function getNumBkResult(searchKey As String) As Integer
        Dim newURL = URL
        If String.Compare(searchKey, String.Empty) = 0 Then
            newURL += "/all/numBooks"
        Else
            newURL += "/all/numBooks/?searchKey=" + searchKey
        End If

        Dim response As String = HttpRequestController.HttpRequestGet(newURL)
        Dim responseInt As Integer = JsonConvert.DeserializeObject(Of Integer)(response)
        Return responseInt
    End Function

    Public Function addNewBook(newBk As BookDetailsDTO) As String
        Dim mes = JsonConvert.SerializeObject(newBk)
        Dim response = HttpRequestController.HttpRequestPost(URL + "/admin", mes, Authorization.authToken)
        Return JsonConvert.DeserializeObject(Of String)(response)
    End Function

    Public Sub updateBook(id As String, attrs As Dictionary(Of String, String))
        Dim newUrl = URL + "/admin/" + id + "/?"
        For Each key As String In attrs.Keys
            newUrl = newUrl + key + "=" + attrs.Item(key) + "&"
        Next
        HttpRequestController.HttpRequestPut(newUrl, Authorization.authToken)
    End Sub

    Public Sub updateAuthorOfBook(id As String, authors As List(Of AuthorDTO))
        Dim newUrl = URL + "/admin/" + id + "/authors"
        Dim mes = JsonConvert.SerializeObject(authors)
        HttpRequestController.HttpRequestPut(newUrl, mes, Authorization.authToken)
    End Sub

    Public Function addBorrow(newBorrow As BorrowDTO) As String
        Dim mes = JsonConvert.SerializeObject(newBorrow)
        Dim response = HttpRequestController.HttpRequestPost(URL + "/admin/borrow", mes, Authorization.authToken)
        Return JsonConvert.DeserializeObject(Of String)(response)
    End Function

    Public Function addReservation(newReservation As ReservationDTO) As String
        Dim mes = JsonConvert.SerializeObject(newReservation)
        Dim response = HttpRequestController.HttpRequestPost(URL + "/admin/reservation", mes, Authorization.authToken)
        Return JsonConvert.DeserializeObject(Of String)(response)
    End Function

    Public Function getAllBorrow() As List(Of BorrowDTO)
        Dim newUrl = URL + "/all/borrow"
        Dim response As String = HttpRequestController.HttpRequestGet(newUrl)
        Return JsonConvert.DeserializeObject(Of List(Of BorrowDTO))(response)
    End Function

    Public Function getAllReservation() As List(Of ReservationDTO)
        Dim newUrl = URL + "/all/reservation"
        Dim response As String = HttpRequestController.HttpRequestGet(newUrl)
        Return JsonConvert.DeserializeObject(Of List(Of ReservationDTO))(response)
    End Function
    Public Sub deleteBorrow(ByRef borrowId As Long)
        Dim newUrl = URL + "/admin/borrow/" + borrowId.ToString
        HttpRequestController.HttpRequestDelete(newUrl, Authorization.authToken)
    End Sub
    Public Sub deleteReservation(ByRef reservationId As Long)
        Dim newUrl = URL + "/admin/reservation/" + reservationId.ToString()
        HttpRequestController.HttpRequestDelete(newUrl, Authorization.authToken)
    End Sub

    Public Function getBookCollection() As List(Of CollectionDTO)
        Dim newUrl = URL + "/all/collection"
        Dim response As String = HttpRequestController.HttpRequestGet(newUrl)
        Return JsonConvert.DeserializeObject(Of List(Of CollectionDTO))(response)
    End Function
End Module
