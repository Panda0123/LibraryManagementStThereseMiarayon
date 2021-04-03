Public Class IssueBook
    Private Sub buttonReturnBook_Click(sender As Object, e As EventArgs) Handles buttonReturnBook.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Confirm book RETURN?", "RETURN book", MessageBoxButtons.YesNo)
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub buttonBorrow_MouseEnter(sender As Object, e As EventArgs) Handles buttonBorrow.MouseEnter
        Me.buttonBorrow.BackColor = Color.DodgerBlue
    End Sub

    Private Sub buttonBorrow_MouseLeave(sender As Object, e As EventArgs) Handles buttonBorrow.MouseLeave
        Me.buttonBorrow.BackColor = Color.SlateGray
    End Sub

    Private Sub buttonReserve_MouseEnter(sender As Object, e As EventArgs) Handles buttonReserve.MouseEnter
        Me.buttonReserve.BackColor = Color.DodgerBlue
    End Sub

    Private Sub buttonReserve_MouseLeave(sender As Object, e As EventArgs) Handles buttonReserve.MouseLeave
        Me.buttonReserve.BackColor = Color.SlateGray
    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click


    End Sub
End Class