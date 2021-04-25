Imports Newtonsoft
Imports Newtonsoft.Json

Module AdminController
    Dim URL As String = HttpRequestMethods.URL

    Public Function login(credentials As Dictionary(Of String, String)) As String
        Dim newURL = HttpRequestMethods.URLWOPath + "/login"
        Dim mes = JsonConvert.SerializeObject(credentials)
        Return HttpRequestMethods.HttpRequestLogin(newURL, mes)
    End Function
    Public Function getId(ByVal currUsername As String) As Long
        Dim newURL = URL + "/admin/id"
        Dim res = HttpRequestMethods.HttpRequestPost(newURL, currUsername, Authorization.authToken)
        Dim id As Long = JsonConvert.DeserializeObject(Of Long)(res)
        Return id
    End Function
    Public Sub updateAdmin(ByVal newCredentials As Dictionary(Of String, String))
        Dim newURL = URL + "/admin"
        Dim mes = JsonConvert.SerializeObject(newCredentials)
        Dim res = HttpRequestMethods.HttpRequestPost(newURL, mes, Authorization.authToken)
    End Sub
End Module
