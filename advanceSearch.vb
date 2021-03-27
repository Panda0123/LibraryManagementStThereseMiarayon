Public Class advanceSearch


    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 2000 To 2020
            ComboBox2.Items.Add(i)
        Next
        ComboBox2.SelectionStart = 0
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class