Public Class Main
    Public books As New List(Of Book)
    Dim newPos As Point
    Public Sub New()
        InitializeComponent()
        btn_blk.Hide()
        searchTextBox.SelectionStart = 0
    End Sub




    Private Sub btn_blk_mouseLeave(sender As Object, e As EventArgs) Handles btn_blk.MouseLeave
        btn_white.Visible = True


        btn_blk.Visible = False


    End Sub

    Private Sub btn_white_mouseHover(sender As Object, e As EventArgs) Handles btn_white.MouseHover
        btn_white.Visible = False


        btn_blk.Visible = True
    End Sub

    Private Sub searchTextBox_mouseEnter(sender As Object, e As EventArgs) Handles searchTextBox.MouseHover, searchTextBox.Click, searchTextBox.KeyPress

        If searchTextBox.Text.Equals("Search...") Then
            searchTextBox.Text = ""
            searchTextBox.ForeColor = Color.FromArgb(0, 0, 0)
        End If

        BookDisplay.updateBookVisuals()



    End Sub

    Private Sub searchTextBox_mouseLeave(sender As Object, e As EventArgs) Handles searchTextBox.MouseLeave
        If searchTextBox.Text.Equals("") Then
            searchTextBox.Text = "Search..."
            searchTextBox.ForeColor = Color.FromArgb(119, 117, 117)
        End If

    End Sub

    Private Sub DisplayBookPanel_Paint(sender As Object, e As PaintEventArgs) Handles DisplayBookPanel.Paint

    End Sub
End Class
























