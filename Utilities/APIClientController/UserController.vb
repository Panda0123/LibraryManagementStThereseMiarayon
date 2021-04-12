Imports Newtonsoft.Json
Module UserController
    Private URL As String = "http://localhost:8080/api/v1/user"
    Public Function getUser(ByRef id As String) As UserDTO
        Dim newURL = URL + "/all/" + id
        Dim res = HttpRequestController.HttpRequestGet(newURL)
        Dim UserDTO As UserDTO = JsonConvert.DeserializeObject(Of UserDTO)(res)
        Return UserDTO
    End Function
End Module
