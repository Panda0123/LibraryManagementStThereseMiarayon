'Imports Newtonsoft.Json

'Module BookController
'    Private URL As String = "http://localhost:8080/api/v1/book"
'    Public Function getBooks() As List(Of BookDetailsDTO)
'        Dim response As String = HttpRequestController.HttpRequestGet(URL)
'        Dim responseDct As List(Of BookDetailsDTO) = JsonConvert.DeserializeObject(Of List(Of BookDetailsDTO))(response)
'        Return responseDct
'    End Function

'    Public Function getBook(id As String) As BookDetailsDTO
'        Dim newUrl = URL + "/" + id
'        Dim response As String = HttpRequestController.HttpRequestGet(newUrl)
'        Return JsonConvert.DeserializeObject(Of BookDetailsDTO)(response)
'    End Function
'    Public Function addNewBook(newBk As BookDetailsDTO) As String
'        Dim mes = JsonConvert.SerializeObject(newBk)
'        Dim response = HttpRequestController.HttpRequestPost(URL, mes)
'        Return JsonConvert.DeserializeObject(Of String)(response)
'    End Function

'    Public Sub updateBook(id As String, attrs As Dictionary(Of String, String))
'        Dim newUrl = URL + "/" + id + "/?"
'        For Each key As String In attrs.Keys
'            newUrl = newUrl + key + "=" + attrs.Item(key) + "&"
'        Next
'        HttpRequestController.HttpRequestPut(newUrl)

'    End Sub

'    Public Sub updateAuthorOfBook(id As String, authors As List(Of AuthorDTO))
'        Dim newUrl = URL + "/" + id + "/authors"
'        Dim mes = JsonConvert.SerializeObject(authors)
'        HttpRequestController.HttpRequestPut(newUrl, mes)
'    End Sub


'End Module

