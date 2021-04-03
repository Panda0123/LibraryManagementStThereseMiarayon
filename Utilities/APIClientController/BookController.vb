Imports Newtonsoft.Json

Module BookController
    Private URL As String = "http://localhost:8080/api/v1/book"
    Public Function getBooks() As List(Of BookDetailsDTO)
        Dim response As String = HttpRequestController.HttpRequestGet(URL + "/all")
        Dim responseDct As List(Of BookDetailsDTO) = JsonConvert.DeserializeObject(Of List(Of BookDetailsDTO))(response)
        Return responseDct
    End Function

    Public Function getBooksPaginationSortBy(pageNum As Integer, pageSize As Integer, by As String) As List(Of BookDetailsDTO)
        Dim newURL = URL + "/all/pagination/sortBy" + by + "/?pageNum=" + pageNum.ToString() + "&pageSize=" + pageSize.ToString()
        Dim response As String = HttpRequestController.HttpRequestGet(newURL)
        Dim responseDct As List(Of BookDetailsDTO) = JsonConvert.DeserializeObject(Of List(Of BookDetailsDTO))(response)
        Return responseDct
    End Function

    Public Function getBook(id As String) As BookDetailsDTO
        Dim newUrl = URL + "/all/" + id
        Dim response As String = HttpRequestController.HttpRequestGet(newUrl)
        Return JsonConvert.DeserializeObject(Of BookDetailsDTO)(response)
    End Function

    Public Function getNumBkResult() As Integer
        Dim newURL = URL + "/all/numBooks"
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

End Module
