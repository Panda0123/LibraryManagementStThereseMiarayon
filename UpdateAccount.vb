Imports MetroFramework

Public Class UpdateAccount

    Private Sub metroButton1_Click_1(sender As Object, e As EventArgs) Handles nxtBtn.Click
        Dim _pnl As New pnlOne(Me)
        AddHandler _pnl.Closed, AddressOf pnl_Closed
        AddHandler _pnl.Shown, AddressOf pnl_Shown
        If MessageBox.Show("Are you sure of this username : " & newUsername.Text _
                            & " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            If newUsername.Text.Equals("") Then
                MessageBox.Show("blank is not allowed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                nxtBtn.Enabled = False
                _pnl.swipe(True)

            End If

        End If

    End Sub

    Private Sub pnl_Closed(sender As Object, e As EventArgs)
        nxtBtn.Enabled = True
    End Sub

    Private Sub pnl_Shown(sender As Object, e As EventArgs)

    End Sub

    Private Sub UpdateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Resizable = False
    End Sub


End Class
