'Imports System.Globalization
Public Class adminView
    Public adminbookDP As New List(Of bookControlAdmin)
    Public addBookUserControl As New AddBookUserControl
    Public viewBookUserControl As New ViewBookUserControl

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sample
        For i As Integer = 0 To 5
            Dim book As New bookControlAdmin
            viewBookUserControl.bookDisp.Controls.Add(book)
        Next

        mainPanel.Controls.Add(viewBookUserControl)
    End Sub

    Private Sub viewBookBtn_Click(sender As Object, e As EventArgs) Handles viewBookBtn.Click
        If mainPanel.Controls.Contains(addBookUserControl) Then
            mainPanel.Controls.Remove(addBookUserControl)
        End If
        mainPanel.Controls.Add(viewBookUserControl)
    End Sub


    Private Sub bokkAddBtn_Click(sender As Object, e As EventArgs) Handles bokkAddBtn.Click
        If mainPanel.Controls.Contains(viewBookUserControl) Then
            mainPanel.Controls.Remove(viewBookUserControl)
        End If
        mainPanel.Controls.Add(addBookUserControl)
    End Sub

    Private Sub recordsBtn_Click(sender As Object, e As EventArgs) Handles recordsBtn.Click

    End Sub

    Private Sub collectionsBtn_Click(sender As Object, e As EventArgs) Handles collectionsBtn.Click

    End Sub

    Private Sub reservationBtn_Click(sender As Object, e As EventArgs)

    End Sub
End Class