Public Class IssueBook
    Private Sub buttonReturnBook_Click(sender As Object, e As EventArgs) Handles buttonReturnBook.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Confirm book RETURN?", "RETURN book", MessageBoxButtons.YesNo)
    End Sub
End Class