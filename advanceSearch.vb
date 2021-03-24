Public Class advanceSearch


    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 2000 To 2020
            ComboBox2.Items.Add(i)
        Next
    End Sub


End Class