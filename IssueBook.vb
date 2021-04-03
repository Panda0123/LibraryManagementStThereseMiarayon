Public Class IssueBook
    Private Sub buttonReturnBook_Click(sender As Object, e As EventArgs) Handles buttonReturnBook.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Confirm book RETURN?", "RETURN book", MessageBoxButtons.YesNo)
    End Sub

    Private Sub buttonReserveBook_Click(sender As Object, e As EventArgs) Handles buttonReserveBook.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Confirm book RETURN?", "RETURN book", MessageBoxButtons.YesNo)
    End Sub

    Private Sub buttonBorrowBook_Click(sender As Object, e As EventArgs) Handles buttonBorrowBook.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Confirm book RETURN?", "RETURN book", MessageBoxButtons.YesNo)
    End Sub
End Class