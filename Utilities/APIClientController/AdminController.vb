Imports Newtonsoft
Imports Newtonsoft.Json

Module AdminController
    Dim URL As String = "http://localhost:8080"

    Public Function login(credentials As Dictionary(Of String, String)) As String
        Dim newURL = URL + "/login"
        Dim mes = JsonConvert.SerializeObject(credentials)
        Return HttpRequestController.HttpRequestLogin(newURL, mes)
    End Function

End Module
