Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Module CategoryController
    Private URL As String = "http://localhost:8080/api/v1/category"
    Public Function getCategories() As List(Of ClassificationDTO)
        Dim response As String = HttpRequestController.HttpRequestGet(URL)
        Dim responseDTOs As List(Of ClassificationDTO) = JsonConvert.DeserializeObject(Of List(Of ClassificationDTO))(response)
        Return responseDTOs
    End Function

End Module
