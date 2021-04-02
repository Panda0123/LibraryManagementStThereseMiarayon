Public Class TemporaryLogin
    Public authToken As String = String.Empty
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim credentials As New Dictionary(Of String, String)
        credentials.Add("username", usernameTxtBx.Text)
        credentials.Add("password", passwordTxtBx.Text)
        authToken = AdminController.login(credentials)
        If String.Compare(authToken, "Credentials are wrong") = 0 Then
            MessageBox.Show(authToken)
            Return
        End If
        Authorization.authToken = authToken
        AddBook.Show()
        Me.Close()
    End Sub

    Private Sub TemporaryLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class