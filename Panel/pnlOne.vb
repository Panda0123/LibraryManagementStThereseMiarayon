
Public Class pnlOne
    Private click_eye As Integer = 0

    Private Sub pnlOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currPassword.UseSystemPasswordChar = True
        newPassword.UseSystemPasswordChar = True
    End Sub



    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click


        If MessageBox.Show("Are you sure of this Password?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If currPassword.Text.Equals("") And newPassword.Text.Equals("") Then
                MessageBox.Show("blanks are not allowed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                'if current != currPass.Text
                'then mag message sya 
                ' get id
                'else if sakto and dle blank verify dayonS
                Dim id = verify.checkCurrentPass(currPassword.Text)
                If id = -1 Then
                    MessageBox.Show("Current password is wrong.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
                If verify.checkPass(newPassword.Text) Then
                    verify.setNewPassword(newPassword.Text)
                    ' Add to database verify.getNewUsername and verify.getNewPassword
                    If verify.update(id) Then
                        If MessageBox.Show("Succesfully Updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.OK Then
                            Authorization.password = newPassword.Text
                            Authorization.username = UpdateAccount.newUsername.Text
                            Me.Parent.Dispose()
                        End If
                    End If

                Else
                    ErrorProvider1.SetError(Me.newPassword, "PASSWORD MUST BE:
At least one digit [0-9]
At least one lowercase character [a-z]
At least one uppercase character [A-Z]
At least one special character [@#$%^&+_=]
At least 8 characters in length, but no more than 32.
")
                End If
            End If
        Else
            Exit Sub
        End If



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        click_eye += 1

        If click_eye = 1 Then
            PictureBox1.Image = My.Resources.icons8_eye_24
            currPassword.UseSystemPasswordChar = False
            newPassword.UseSystemPasswordChar = False
        ElseIf click_eye = 2 Then
            PictureBox1.Image = My.Resources.icons8_hide_24
            click_eye = 0
            currPassword.UseSystemPasswordChar = True
            newPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
