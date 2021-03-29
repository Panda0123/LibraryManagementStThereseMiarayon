Public Class Main
    Public bookDP As List(Of bookDisplay)
    Dim newPos As Point
    Public Sub New()
        InitializeComponent()
        bookDP = New List(Of bookDisplay)
        btn_blk.Hide()

        searchTextBox.SelectionStart = 0

        FlowLayoutPanel1.Controls.Clear()

        FlowLayoutPanel1.WrapContents = False

        bookDP.Add(New bookDisplay) 'sample only
        bookDP.Add(New bookDisplay) 'sample only
        bookDP.Add(New bookDisplay) 'sample only
        displayBookvb.loadBooks(bookDP)

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



        For Each book In bookDP
            book.Anchor = Anchor.Left
            book.Anchor = Anchor.Right
            FlowLayoutPanel1.Controls.Add(book)
        Next

    End Sub

    Private Sub searchTextBox_mouseLeave(sender As Object, e As EventArgs) Handles searchTextBox.MouseLeave
        If searchTextBox.Text.Equals("") Then
            searchTextBox.Text = "Search..."
            searchTextBox.ForeColor = Color.FromArgb(119, 117, 117)
        End If

    End Sub

End Class
























