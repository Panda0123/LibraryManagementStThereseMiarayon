Imports System.IO
Imports System.Net
Imports System.Text

Module HttpRequestController
    Private address = Convert.ToString(System.Configuration.ConfigurationSettings.AppSettings("address")).Trim
    Private port = Convert.ToString(System.Configuration.ConfigurationSettings.AppSettings("port")).Trim
    Public URLWOPath = "http://" + address + ":" + port
    Public URL As String = URLWOPath + "/api/v" + 1.ToString
    Public Function HttpRequestGet(URL As String) As String
        Dim request As WebRequest = WebRequest.Create(URL)
        Dim dataStream As Stream = request.GetResponse.GetResponseStream()
        Dim sr As New StreamReader(dataStream)
        Return sr.ReadToEnd()
    End Function

    Public Function HttpRequestGet(URL As String, authToken As String) As String

        Dim request As WebRequest
        request = WebRequest.Create(URL)
        request.Method = "Get"
        If Not authToken Is Nothing Then
            request.Headers.Add("Authorization", authToken)
        End If

        Dim stream As Stream = request.GetRequestStream()
        Dim response = request.GetResponse()
        Dim sr As New StreamReader(response.GetResponseStream())
        Dim responseContent As String = String.Empty

        Using res = DirectCast(request.GetResponse(), HttpWebResponse),
            responseStream = res.GetResponseStream(),
            reader = New StreamReader(responseStream)
            responseContent = reader.ReadToEnd()
        End Using
        Return responseContent
    End Function

    Public Function HttpRequestGetStream(URL As String) As Stream
        Dim request As WebRequest = WebRequest.Create(URL)
        Dim res = CType(request.GetResponse(), HttpWebResponse)
        Return res.GetResponseStream()
    End Function

    Public Function HttpRequestPost(URL As String, mes As String, authToken As String) As String

        Dim request As WebRequest
        request = WebRequest.CreateHttp(URL)
        Dim response As WebResponse
        Dim postData As String = mes
        Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(postData)


        request.Method = "POST"
        request.ContentType = "application/json; charset=utf-8"
        request.ContentLength = jsonBytes.Length

        If Not authToken Is Nothing Then
            request.Headers.Add("Authorization", authToken)
        End If

        Dim stream As Stream = request.GetRequestStream()
        stream.Write(jsonBytes, 0, jsonBytes.Length)
        stream.Close()

        response = request.GetResponse()
        Dim sr As New StreamReader(response.GetResponseStream())
        Dim responseContent As String = String.Empty

        Using res = DirectCast(request.GetResponse(), HttpWebResponse),
            responseStream = res.GetResponseStream(),
            reader = New StreamReader(responseStream)
            responseContent = reader.ReadToEnd()
        End Using
        Return responseContent
    End Function

    Public Function HttpRequestLogin(URL As String, mes As String) As String

        Dim request As WebRequest
        request = WebRequest.CreateHttp(URL)
        Dim response As WebResponse
        Dim postData As String = mes
        Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(postData)


        request.Method = "POST"
        request.ContentType = "application/json; charset=utf-8"
        request.ContentLength = jsonBytes.Length

        Dim stream As Stream = request.GetRequestStream()
        stream.Write(jsonBytes, 0, jsonBytes.Length)
        stream.Close()

        Try
            response = request.GetResponse()
        Catch ex As Exception
            Return "Credentials are wrong"
        End Try

        Dim sr As New StreamReader(response.GetResponseStream())
        Dim authToken As String = String.Empty

        Using res = DirectCast(request.GetResponse(), HttpWebResponse)
            authToken = res.Headers.Item("Authorization")
        End Using
        Return authToken
    End Function


    Public Sub HttpRequestPut(URL As String)

        Dim request As WebRequest
        request = WebRequest.Create(URL)

        request.Method = "PUT"

        Dim stream As Stream = request.GetRequestStream()

        Dim response = request.GetResponse()
        Dim sr As New StreamReader(response.GetResponseStream())
        Dim responseContent As String = String.Empty

        Using res = DirectCast(request.GetResponse(), HttpWebResponse),
            responseStream = res.GetResponseStream(),
            reader = New StreamReader(responseStream)
            responseContent = reader.ReadToEnd()
        End Using
    End Sub

    Public Sub HttpRequestPut(URL As String, authToken As String)

        Dim request As WebRequest
        request = WebRequest.Create(URL)

        request.Method = "PUT"
        If Not authToken Is Nothing Then
            request.Headers.Add("Authorization", authToken)
        End If

        Dim stream As Stream = request.GetRequestStream()
        Dim response = request.GetResponse()
        Dim sr As New StreamReader(response.GetResponseStream())
        Dim responseContent As String = String.Empty

        Using res = DirectCast(request.GetResponse(), HttpWebResponse),
            responseStream = res.GetResponseStream(),
            reader = New StreamReader(responseStream)
            responseContent = reader.ReadToEnd()
        End Using
    End Sub

    Sub HttpRequestPut(URL As String,
                        mes As String,
                       authToken As String)
        Dim request As WebRequest
        request = WebRequest.CreateHttp(URL)
        Dim response As WebResponse
        Dim postData As String = mes
        Dim jsonBytes As Byte() = Encoding.UTF8.GetBytes(postData)


        request.Method = "PUT"
        request.ContentType = "application/json; charset=utf-8"
        request.ContentLength = jsonBytes.Length
        request.Headers.Add("Authorization", authToken)

        Dim stream As Stream = request.GetRequestStream()
        stream.Write(jsonBytes, 0, jsonBytes.Length)
        stream.Close()

        response = request.GetResponse()
        Dim sr As New StreamReader(response.GetResponseStream())
        Dim responseContent As String = String.Empty

        Using res = DirectCast(request.GetResponse(), HttpWebResponse),
            responseStream = res.GetResponseStream(),
            reader = New StreamReader(responseStream)
            responseContent = reader.ReadToEnd()
        End Using
    End Sub

    Sub HttpRequestDelete(URL As String, authToken As String)
        Dim request As WebRequest = WebRequest.Create(URL)
        request.Method = "DELETE"

        request.Headers.Add("Authorization", authToken)

        Dim response = request.GetResponse()
        Dim sr As New StreamReader(response.GetResponseStream())
        Dim responseContent As String = String.Empty

        Using res = DirectCast(request.GetResponse(), HttpWebResponse),
            responseStream = res.GetResponseStream(),
            reader = New StreamReader(responseStream)
            responseContent = reader.ReadToEnd()
        End Using
    End Sub

End Module
