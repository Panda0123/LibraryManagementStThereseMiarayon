Public Class viewBookUserControl
    Public adminbookDP As New List(Of bookControlAdmin)

    Private numPage As Integer = 1
    Private totalResult As Integer = 0
    Private searchKey As String = String.Empty

    Private PageIndex As Integer = 0
    Private BooksPerPage As Integer = 2 'number of books shown on each page

    Private viewBook As New viewBook

    Private Sub viewBookUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeResult()
    End Sub
    Public Sub New(adminView)
        InitializeComponent()

        For x As Integer = 1 To BooksPerPage
            adminbookDP.Add(New bookControlAdmin(viewBook, adminView))
        Next

        setResult()
        initializeResult()
    End Sub

    Public Sub setSearch(ByRef key As String)
        If Not key.Equals("Search...") Then
            Me.searchKey = key.Replace(" ", "+")
        End If
        setResult()
        initializeResult()
    End Sub

    Public Sub setResult()
        PageIndex = 0
        totalResult = BookController.getNumBkResult(searchKey)
        numPage = totalResult / BooksPerPage
    End Sub
    Public Sub initializeResult()
        bookDisplayFlowPanel.Controls.Clear()

        setBookDisplayResults()
        loadImage()
        setPaginationControls()
    End Sub

    Private Sub prevLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles prevLnkLbl.LinkClicked
        ' LoadPage(False) 'false indicates to go back a page
        If PageIndex > 0 Then
            PageIndex -= 1
            initializeResult()
        End If
    End Sub

    Private Sub nextLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles nextLnkLbl.LinkClicked
        ' LoadPage(True) 'true indicates to go forward a page
        If PageIndex + 1 < numPage Then
            PageIndex += 1
            initializeResult()
        End If
    End Sub

    Private Sub setBookDisplayResults()
        Dim bkDTOs As List(Of BookDetailsDTO) = BookController.getBooksPaginationSortBy(PageIndex, BooksPerPage, "Title", searchKey)

        For idx As Integer = 0 To bkDTOs.Count - 1
            adminbookDP.Item(idx).setBkDTO(bkDTOs.Item(idx))
            bookDisplayFlowPanel.Controls.Add(adminbookDP.Item(idx))
        Next
    End Sub

    Private Sub loadImage()
        For Each bkDisplay As bookControlAdmin In bookDisplayFlowPanel.Controls
            If String.Compare(bkDisplay.imageName, "empty") <> 0 Then
                bkDisplay.coverPcBx.Image = getImage(bkDisplay.imageName)
            Else
                bkDisplay.coverPcBx.Image = My.Resources.default_book
            End If
        Next
    End Sub

    Private Sub setPaginationControls()
        If PageIndex + 1 >= numPage Then
            nextLnkLbl.Visible = False
        Else
            nextLnkLbl.Visible = True
        End If

        If PageIndex <= 0 Then
            prevLnkLbl.Visible = False
        Else
            prevLnkLbl.Visible = True
        End If
        PageNumLabel.Text = "Page " & (1 + PageIndex).ToString 'set the text to the Page Number
    End Sub

End Class
