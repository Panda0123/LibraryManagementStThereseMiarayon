Imports System.Text.RegularExpressions
Module verify
    Private _newUsername As String = Nothing
    Private _newPass As String = Nothing
    Public Function checkPass(ByVal password As String) As Boolean
        Dim is_verify = Regex.IsMatch(password, "^.*(?=.{8,32})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$") ' kulangan ug underscore
        checkPass = is_verify
    End Function

    Public Sub setNewUsername(ByVal username As String)
        _newUsername = username
    End Sub

    Public Sub setNewPassword(ByVal password As String)
        _newPass = password
    End Sub

    Public Function getNewUsername() As String
        getNewUsername = _newUsername
    End Function

    Public Function getNewPassword() As String
        getNewPassword = _newPass
    End Function

    Public Function update(ByVal id As Integer) As Boolean
        Dim newCredentials As New Dictionary(Of String, String)
        newCredentials.Add("id", id)
        newCredentials.Add("username", _newUsername)
        newCredentials.Add("password", _newPass)
        Try
            AdminController.updateAdmin(newCredentials)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Function checkCurrentPass(ByVal currPassword As String) As Long
        If Not currPassword.Equals(Authorization.password) Then
            Return -1
        End If
        Return AdminController.getId(Authorization.username)
    End Function


End Module
