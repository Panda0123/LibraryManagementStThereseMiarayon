Imports System.Text.RegularExpressions
Module verify
    Private _newUsername As String = Nothing
    Private _newPass As String = Nothing
    Public Function checkPass(ByVal password As String) As String
        Dim is_verify = Regex.IsMatch(password, "^.*(?=.{8,32})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$")
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
End Module
