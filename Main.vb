Imports System.Globalization
Public Class Main
    Public bookDP As New List(Of bookDisplay)
    Private newTitle_click As Integer = 0
    Private auth_click As Integer = 0
    Private pb_click As Integer = 0
    Private pub_click As Integer = 0
    Private sortBy As String = "DateAdded"  ' defeault is date added
    Private provider As CultureInfo = CultureInfo.InvariantCulture
    Private numPage As Integer = 1
    Private totalResult As Integer = 0

    Private PageIndex As Integer = 0
    Private BooksPerPage As Integer = 3 'number of books shown on each page

    Public Sub New()
        InitializeComponent()
        searchTextBox.SelectionStart = 0
        FlowLayoutPanel1.Controls.Clear()
        FlowLayoutPanel1.WrapContents = False

        'For x As Integer = 1 To 12
        '    Dim book As New bookDisplay
        '    bookDP.Add(book)
        '    If x <= BooksPerPage Then
        '        book.Label2.Text = x.ToString
        '        FlowLayoutPanel1.Controls.Add(book) 'add the first page of books when adding them to the List
        '    End If
        'Next

        initializeResult()
    End Sub

    Public Sub initializeResult()
        ' setup number of pages depending on BooksPerPage and TotalResult

        totalResult = BookController.getNumBkResult
        PageIndex = 0
        Dim displayResults As List(Of bookDisplay) = getBookDisplayResults()
        For Each bkDisplay As bookDisplay In displayResults
            FlowLayoutPanel1.Controls.Add(bkDisplay) 'add the first page of books when adding them to the List
        Next

        ' separatethread
        loadImage(displayResults)
    End Sub

    ' backward
    Private Sub Button_Back_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Button_Back.LinkClicked
        LoadPage(False) 'false indicates to go back a page
    End Sub

    ' forward
    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        LoadPage(True) 'true indicates to go forward a page
    End Sub


    Private Sub LoadPage(ByVal pgNext As Boolean)

        'make sure there is another page before adding 1 to the PageIndex
        If pgNext And (PageIndex + 1) * BooksPerPage < bookDP.Count - 1 Then
            PageIndex += 1
        ElseIf Not pgNext And PageIndex - 1 >= 0 Then 'make sure it is not on PageIndex 0 before going back a Page
            PageIndex -= 1
        Else
            Exit Sub 'exit the sub if already on Page1 or on the Last Page
        End If

        ' remove all the books from the this page
        For i As Integer = FlowLayoutPanel1.Controls.Count - 1 To 0 Step -1
            FlowLayoutPanel1.Controls.RemoveAt(i)
        Next

        'when going forward, make sure there Is 6 more books in the list. If Not then get the number of books left in the list.
        Dim endpage As Integer = Math.Min(((PageIndex * BooksPerPage) + BooksPerPage) - 1, bookDP.Count - 1)

        'add the books for the Page to the FlowLayoutPanel
        For i As Integer = (PageIndex * BooksPerPage) To endpage
            bookDP(i).Label2.Text = i.ToString
            FlowLayoutPanel1.Controls.Add(bookDP(i))

        Next

        PageNumLabel.Text = "Page " & (PageIndex + 1).ToString 'set the text to the Page Number
    End Sub




    Private Sub searchTextBox_mouseEnter(sender As Object, e As EventArgs) Handles searchTextBox.MouseHover, searchTextBox.Click, searchTextBox.KeyPress
        If searchTextBox.Text.Equals("Search...") Then
            searchTextBox.Text = ""
            searchTextBox.ForeColor = Color.FromArgb(0, 0, 0)
        End If

        ' sample search
        ' For Each book In bookDP
        ' book.Anchor = Anchor.Left
        ' book.Anchor = Anchor.Right
        'FlowLayoutPanel1.Controls.Add(book)
        '  Next

    End Sub

    Private Sub searchTextBox_mouseLeave(sender As Object, e As EventArgs) Handles searchTextBox.MouseLeave
        If searchTextBox.Text.Equals("") Then
            searchTextBox.Text = "Search..."
            searchTextBox.ForeColor = Color.FromArgb(119, 117, 117)
        End If
    End Sub



    Private Sub newTitleBtn_Click(sender As Object, e As EventArgs) Handles newTitleBtn.Click
        newTitle_click += 1
        utils.clickAnimation(newTitleBtn, newTitle_click)
        utils.dropDownAnimationNewTitle(newTitlePanel, authBtn, pbBtn, publisherBtn)


    End Sub

    Private Sub authBtn_Click(sender As Object, e As EventArgs) Handles authBtn.Click
        auth_click += 1
        utils.clickAnimation(authBtn, auth_click)
        utils.dropDownAnimationauthBtn(authPanel, pbBtn, publisherBtn)

    End Sub

    Private Sub pbBtn_Click(sender As Object, e As EventArgs) Handles pbBtn.Click
        pb_click += 1
        utils.clickAnimation(pbBtn, pb_click)
        utils.dropDownAnimationpy(pbPanel, publisherBtn)
    End Sub

    Private Sub publisherBtn_Click(sender As Object, e As EventArgs) Handles publisherBtn.Click
        pub_click += 1
        utils.clickAnimation(publisherBtn, pub_click)
        utils.dropDownAnimationpub(pubPanel)
    End Sub



    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        loginBtn.ForeColor = Color.FromArgb(0, 54, 99)
        login.ShowDialog()
    End Sub

    Private Sub advanceSearchLinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles advanceSearchLinkLbl.LinkClicked
        advanceSearch.ShowDialog()
    End Sub




    Private Sub loginBtn_mouseLeave(sender As Object, e As EventArgs)
        loginBtn.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        newTitlePanel.Height = 127

        authBtn.Location = New Point(authBtn.Location.X, authBtn.Location.Y + 127)
        pbBtn.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 127)
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)

        authPanel.Location = New Point(authBtn.Location.X, authBtn.Location.Y + 45)
        pbPanel.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 45)
        pubPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        authPanel.Height = 127

        pbBtn.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 127)
        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        pbPanel.Location = New Point(pbBtn.Location.X, pbBtn.Location.Y + 45)
        pubPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pbPanel.Height = 127

        publisherBtn.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 127)
        pubPanel.Location = New Point(publisherBtn.Location.X, publisherBtn.Location.Y + 45)

        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        pubPanel.Height = 127
        Timer4.Stop()
    End Sub

    Private Function getBookDisplayResults() As List(Of bookDisplay)
        Dim bkDTOs As List(Of BookDetailsDTO) = BookController.getBooksPaginationSortBy(PageIndex, BooksPerPage, sortBy)
        Dim bkDisplays As New List(Of bookDisplay)

        For Each bkDTO As BookDetailsDTO In bkDTOs
            Dim bkDisplay As bookDisplay = New bookDisplay()
            Dim title = bkDTO.title + If(bkDTO.publishedDate Is Nothing,
                "",
                "(" + Date.ParseExact(bkDTO.publishedDate, "yyyy-MM-dd", provider).Year.ToString() + ")")
            bkDisplay.bTitle.Text = title
            'author
            Dim authorsDisplay = String.Empty
            Dim authors = bkDTO.authors
            If authors.Count <> 0 Then
                authorsDisplay = authorsDisplay + authors(0).f_name + " " + authors(0).m_name + " " + authors(0).l_name + " "
                For idx As Integer = 1 To authors.Count - 1
                    authorsDisplay = authorsDisplay + ", " + authors(idx).f_name + " " + authors(idx).m_name + " " + authors(idx).l_name + " "
                Next
            End If
            bkDisplay.bAuthor.Text = authorsDisplay
            bkDisplay.bLanguage.Text = bkDTO.language
            Dim publisher = If(bkDTO.publisherAddress Is Nothing, "", "[" + bkDTO.publisherAddress + "]") + If(bkDTO.publisherName Is Nothing, "", " : " + bkDTO.publisherName)
            publisher = publisher + If(bkDTO.copyrightYear = 0, "", vbCrLf + "©" + bkDTO.copyrightYear.ToString) + If(bkDTO.copyrightName Is Nothing, " ", " " + bkDTO.copyrightName)
            bkDisplay.bPublisher.Text = publisher
            bkDisplay.imageName = bkDTO.image
            bkDisplays.Add(bkDisplay)
        Next
        Return bkDisplays
    End Function

    Private Sub loadImage(bkDisplays As List(Of bookDisplay))
        For Each bkDisplay As bookDisplay In bkDisplays
            If String.Compare(bkDisplay.imageName, "empty") <> 0 Then
                ' TODO: separate thread or process
                bkDisplay.PictureBox1.Image = getImage(bkDisplay.imageName)
            Else
                bkDisplay.PictureBox1.Image = My.Resources.default_book
            End If
        Next
    End Sub

End Class
