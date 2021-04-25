Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Module CategoryController
    Private URL As String = HttpRequestMethods.URL + "/category"
    Public Function getCategories() As List(Of ClassificationDTO)
        Dim response As String = HttpRequestMethods.HttpRequestGet(URL + "/all")
        Dim responseDTOs As List(Of ClassificationDTO) = JsonConvert.DeserializeObject(Of List(Of ClassificationDTO))(response)
        Return responseDTOs
    End Function
End Module