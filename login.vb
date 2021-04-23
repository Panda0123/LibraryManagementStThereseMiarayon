Public Class login
    Dim username As String = "admin"
    Dim pass As String = "admin"
    Private Sub loginBtnLoginForm_Click(sender As Object, e As EventArgs) Handles loginBtnLoginForm.Click
        loginBtnLoginForm.ForeColor = Color.FromArgb(0, 54, 99)

        Dim credentials As New Dictionary(Of String, String)
        credentials.Add("username", userNameTxtbox.Text)
        credentials.Add("password", passTxtBox.Text)
        authToken = AdminController.login(credentials)
        If String.Compare(authToken, "Credentials are wrong") = 0 Then
            failedLoginLbl.Visible = True
        Else
            failedLoginLbl.Visible = False
            Authorization.authToken = authToken
            Authorization.username = userNameTxtbox.Text
            Authorization.password = passTxtBox.Text
            adminView.Show()
            Me.Close()
            Main.Close()
        End If
    End Sub

    Private Sub loginBtnLoginForm_mouseLeave(sender As Object, e As EventArgs) Handles loginBtnLoginForm.MouseLeave
        loginBtnLoginForm.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub


End Class