Imports Newtonsoft
Imports Newtonsoft.Json

Module AdminController
    Dim URL As String = HttpRequestController.URL

    Public Function login(credentials As Dictionary(Of String, String)) As String
        Dim newURL = HttpRequestController.URLWOPath + "/login"
        Dim mes = JsonConvert.SerializeObject(credentials)
        Return HttpRequestController.HttpRequestLogin(newURL, mes)
    End Function
    Public Function getId(ByVal currUsername As String) As Long
        Dim newURL = URL + "/admin/id"
        Debug.WriteLine(currUsername)
        Dim res = HttpRequestController.HttpRequestPost(newURL, currUsername, Authorization.authToken)
        Dim id As Long = JsonConvert.DeserializeObject(Of Long)(res)
        Debug.WriteLine(id)
        Return id
    End Function
    Public Sub updateAdmin(ByVal newCredentials As Dictionary(Of String, String))
        Dim newURL = URL + "/admin"
        Dim mes = JsonConvert.SerializeObject(newCredentials)
        Dim res = HttpRequestController.HttpRequestPost(newURL, mes, Authorization.authToken)
    End Sub
End Module
