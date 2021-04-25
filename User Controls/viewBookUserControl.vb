Public Class viewBookUserControl
    Public adminBookDP As New List(Of bookControlAdmin)
    Private paginationDTO As PaginationDTO

    Private numPage As Double = 1
    Private totalResult As Integer = 0
    Private viewBook As New viewBook

    Public Sub New(ByRef adminView As adminView, ByRef paginationDTO As PaginationDTO)
        InitializeComponent()
        Me.paginationDTO = paginationDTO

        For x As Integer = 1 To BooksPerPage
            adminBookDP.Add(New bookControlAdmin(viewBook, adminView))
        Next

        setResult()
    End Sub

    Public Sub setSearch(ByRef key As String)
        If Not key.Equals("Search...") Then
            paginationDTO.searchKey = key.Replace(" ", "+")
        End If
        setResult()
    End Sub

    Public Sub setResult()
        totalResult = BookController.getNumBkResult(paginationDTO)
        numPage = totalResult / BooksPerPage
        paginationDTO.pageNum = 0
        initializeResult()
    End Sub
    Public Sub initializeResult()
        bookDisplayFlowPanel.Controls.Clear()
        setBookDisplayResults()
        loadImage()
        setPaginationControls()
    End Sub

    Private Sub prevLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles prevLnkLbl.LinkClicked
        ' LoadPage(False) 'false indicates to go back a page
        If paginationDTO.pageNum > 0 Then
            paginationDTO.pageNum -= 1
            Me.initializeResult()
        End If
    End Sub

    Private Sub nextLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles nextLnkLbl.LinkClicked
        ' LoadPage(True) 'true indicates to go forward a page
        If paginationDTO.pageNum + 1 < numPage Then
            paginationDTO.pageNum += 1
            Me.initializeResult()
        End If
    End Sub

    Private Sub setBookDisplayResults()
        Dim bkDTOs As List(Of BookDetailsDTO) = BookController.getBooksPaginationSortBy(paginationDTO)

        For idx As Integer = 0 To bkDTOs.Count - 1
            adminBookDP.Item(idx).setBkDTO(bkDTOs.Item(idx))
            bookDisplayFlowPanel.Controls.Add(adminBookDP.Item(idx))
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
        If paginationDTO.pageNum + 1 >= numPage Then
            nextLnkLbl.Visible = False
        Else
            nextLnkLbl.Visible = True
        End If

        If paginationDTO.pageNum <= 0 Then
            prevLnkLbl.Visible = False
        Else
            prevLnkLbl.Visible = True
        End If
        PageNumLabel.Text = "Page " & (1 + paginationDTO.pageNum).ToString 'set the text to the Page Number
    End Sub

    Public Sub empty()
        paginationDTO.setToDefault()
        adminView.searchTextBox.Text = String.Empty
        setResult()
    End Sub

    Public Sub updateUIForCurPaginationDTO()
        adminView.searchTextBox.Text = paginationDTO.searchKey
    End Sub
End Class
