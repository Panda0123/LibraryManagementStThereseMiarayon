Public Class advanceSearch
    Private paginationDTO As PaginationDTO
    Private parent As Object

    Public Sub New(ByRef paginationDTO As PaginationDTO, ByRef parent As Object)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.paginationDTO = paginationDTO
        Me.parent = parent
    End Sub

    Private Sub searchBtnForm_Click(sender As Object, e As EventArgs) Handles searchBtnForm.Click
        paginationDTO.searchKey = titleSearch.Text
        paginationDTO.filterAuthor = authorSearch.Text
        paginationDTO.filterClassification = classificationSearch.Text
        paginationDTO.filterPublisher = publisherSearch.Text
        paginationDTO.filterIsbn = ISBNsearch.Text
        paginationDTO.filterLanguage = languageSearch.Text
        paginationDTO.filterFirstPublicationYear = firstPublicationYear.Text.Trim
        paginationDTO.filterLastPublicationYear = lastPublicationYear.Text.Trim

        If parent.GetType.Equals(GetType(Main)) Then
            Debug.WriteLine("Main")
            CType(parent, Main).setResult()
            CType(parent, Main).updateUIForCurPaginationDTO()
        ElseIf parent.GetType.Equals(GetType(adminView)) Then
            Debug.WriteLine("AdminView")
            CType(parent, adminView).viewBookuserCtl.setResult()
            CType(parent, adminView).viewBookuserCtl.updateUIForCurPaginationDTO()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, MyBase.Closed
        Me.empty()
        If parent.GetType.Equals(GetType(Main)) Then
            Debug.WriteLine("Main")
            CType(parent, Main).empty()
        ElseIf parent.GetType.Equals(GetType(adminView)) Then
            Debug.WriteLine("AdminView")
            CType(parent, adminView).viewBookuserCtl.empty()
        End If
    End Sub
    Private Sub empty()
        titleSearch.Text = String.Empty
        authorSearch.Text = String.Empty
        classificationSearch.Text = String.Empty
        publisherSearch.Text = String.Empty
        ISBNsearch.Text = String.Empty
        languageSearch.Text = String.Empty
        firstPublicationYear.Text = String.Empty
        lastPublicationYear.Text = String.Empty
    End Sub

End Class