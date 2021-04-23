Imports System.Globalization

Public Class AddBookUserControl
    Private selectedBook As BookDetailsDTO
    Private adminView As adminView
    Private provider As CultureInfo = CultureInfo.InvariantCulture

    Private authors As New List(Of AuthorDTO)
    Private copies As New List(Of BookCopyDTO)
    Private prevCopies As New List(Of BookCopyDTO)
    Private imgFlName As String = ""
    Private status As New List(Of String)({"Available", "Borrowed", "Reserved"})

    Public Sub New(ByRef adminView As adminView)
        ' This call is required by the designer.
        InitializeComponent()
        Me.adminView = adminView
        ' Add any initialization after the InitializeComponent() call.
        AddBook_Load(Nothing, Nothing)

    End Sub

    Private Sub AddBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(GlobalSource.classifications) Then
            GlobalSource.setClass()
        End If
        classificationCmbBx.DataSource = GlobalSource.classificationNames
        empty()
    End Sub

    '  EVENT HANDLERS
    ' books
    Private Sub addBookBtn_Click(sender As Object, e As EventArgs) Handles addHoverPcBx.Click

        If Not checks() Then
            Return
        End If

        Dim newBook As New BookDetailsDTO

        newBook.title = titleTxtBx.Text.Trim
        newBook.isbn = If(isbnTxtBx.Text.Trim.Equals(""), Nothing, isbnTxtBx.Text.Trim)
        newBook.language = languageTxtBx.Text.Trim
        newBook.summary = summaryRichTxtBx.Text.Trim

        newBook.edition = If(editionTxtBx.Text.Trim.Equals(""), Nothing, editionTxtBx.Text)

        If publishedDatePicker.Checked Then
            newBook.publishedDate = publishedDatePicker.Value.ToString("yyyy-MM-dd")
        End If
        If Not publisherNameTxtBx.Text.Trim.Equals("") Then
            newBook.publisherName = publisherNameTxtBx.Text.Trim
        End If
        If Not publisherAddrTxtBx.Text.Trim.Equals("") Then
            newBook.publisherAddress = publisherAddrTxtBx.Text
        End If
        If Not copyrightNameTxtBx.Text.Trim.Equals("") Then
            newBook.copyrightName = copyrightNameTxtBx.Text
        End If
        If copyrightYearDTPckr.Checked Then
            newBook.copyrightYear = copyrightYearDTPckr.Value.ToString("yyyy")
        End If

        Dim idx = classificationNames.FindIndex(Function(name) name.Equals(classificationCmbBx.Text.Trim))
        If idx <> -1 Then
            newBook.categoryId = idx + 1
        Else
            MessageBox.Show("Classification invalid: choose one of the existing classification.")
            Return
        End If
        newBook.shelfName = shelfTxtBx.Text.Trim

        Dim hasImg As Boolean = False
        Dim ext = ""
        ' image
        If Not imgFlName.Equals("") Then
            hasImg = True
            Dim strt = imgFlName.LastIndexOf(".")
            ext = imgFlName.Substring(strt, imgFlName.Length - strt)
            newBook.imageName = "new" + ext
        Else
            newBook.imageName = "empty"
        End If

        authorsDataGrid.CurrentCell = Nothing
        setAuthors()
        newBook.authors = authors
        copiesDataGridView.CurrentCell = Nothing
        setCopies()
        newBook.copies = copies
        newBook.quantity = copies.Count
        Dim response = BookController.addNewBook(newBook)
        selectedBook = newBook

        If hasImg Then
            uploadImage(response + ext)  ' upload the image
        End If

        MessageBox.Show("Successfully added book!")
        empty()
        populate(response)
        adminView.viewBookuserCtl.initializeResult()
    End Sub


    Private Sub savePcBx_Click(sender As Object, e As EventArgs) Handles saveHoverPcBx.Click

        If Not checks() Then
            Return
        End If

        Dim attrs As New Dictionary(Of String, String)
        If Not selectedBook.title.Trim.Equals(selectedBook.title) Then
            attrs.Add("title", selectedBook.title.Trim)
        End If
        If Not isbnTxtBx.Text.Trim.Equals(selectedBook.isbn) Then
            attrs.Add("isbn", If(isbnTxtBx.Text.Trim.Equals(""), Nothing, isbnTxtBx.Text.Trim))
        End If
        If Not languageTxtBx.Text.Trim.Equals(selectedBook.language) Then
            attrs.Add("language", languageTxtBx.Text.Trim)
        End If
        If Not summaryRichTxtBx.Text.Trim.Equals(selectedBook.summary) Then
            attrs.Add("summary", summaryRichTxtBx.Text.Trim)
        End If
        If selectedBook.edition IsNot Nothing AndAlso Not editionTxtBx.Text.Trim.Equals(selectedBook.edition.ToString) Then
            attrs.Add("edition", editionTxtBx.Text.Trim)
        ElseIf selectedBook.edition Is Nothing AndAlso Not editionTxtBx.Text.Trim.Equals("") Then
            attrs.Add("edition", editionTxtBx.Text.Trim)
        End If

        If publishedDatePicker.Checked Then
            If String.Compare(publishedDatePicker.Value.ToString("yyyy-MM-dd"), selectedBook.publishedDate) <> 0 Then
                attrs.Add("publishedDate", publishedDatePicker.Value.ToString("yyyy-MM-dd"))
            End If
        Else
            attrs.Add("publishedDate", Nothing)
        End If

        If Not publisherNameTxtBx.Text.Trim.Equals(selectedBook.publisherName) Then
            If String.Compare(publisherNameTxtBx.Text.Trim, "") <> 0 Then
                attrs.Add("publisherName", publisherNameTxtBx.Text.Trim)
            Else
                attrs.Add("publisherName", Nothing)
            End If
        End If
        If Not publisherAddrTxtBx.Text.Trim.Equals(selectedBook.publisherAddress) Then
            If String.Compare(publisherAddrTxtBx.Text.Trim, "") <> 0 Then
                attrs.Add("publisherAddress", publisherAddrTxtBx.Text.Trim)
            Else
                attrs.Add("publisherAddress", Nothing)
            End If
        End If
        If Not copyrightNameTxtBx.Text.Trim.Equals(selectedBook.copyrightName) Then
            If String.Compare(copyrightNameTxtBx.Text.Trim, "") <> 0 Then
                attrs.Add("copyrightName", copyrightNameTxtBx.Text.Trim)
            Else
                attrs.Add("copyrightName", Nothing)
            End If
        End If
        If copyrightYearDTPckr.Checked Then
            If Not copyrightYearDTPckr.Value.ToString("yyyy").Equals(selectedBook.copyrightYear) Then
                attrs.Add("copyrightYear", copyrightYearDTPckr.Value.ToString("yyyy"))
            End If
        Else
            attrs.Add("copyrightYear", Nothing)
        End If

        Dim idx = classificationNames.FindIndex(Function(name) name.Equals(classificationCmbBx.Text.Trim))
        If idx <> -1 Then
            attrs.Add("categoryId", idx + 1)
        Else
            MessageBox.Show("Classification invalid: choose one of the existing classification.")
            Return
        End If

        If Not shelfTxtBx.Text.Trim.Equals(selectedBook.shelfName) Then
            If Not shelfTxtBx.Text.Trim.Equals("") Then
                attrs.Add("shelfName", shelfTxtBx.Text.Trim)
            Else
                attrs.Add("shelfName", Nothing)
            End If
        End If

        ' check if there is changes in authors
        ' authorsDataGrid.ClearSelection()
        authorsDataGrid.CurrentCell = Nothing
        setAuthors()
        Dim updateAuthor As Boolean = False
        If authors.Count <> selectedBook.authors.Count Then
            updateAuthor = True
        Else
            For Each author As AuthorDTO In authors
                If Not selectedBook.authors.Contains(author) Then
                    updateAuthor = True
                    Exit For
                End If
            Next
        End If

        ' check if there is changes in copies
        copiesDataGridView.CurrentCell = Nothing
        setCopies()
        Dim updateCopies As Boolean = False
        If copies.Count <> prevCopies.Count Then
            updateCopies = True
        Else
            For Each copy As BookCopyDTO In copies
                If Not prevCopies.Contains(copy) Then
                    updateCopies = True
                    Exit For
                End If
            Next
        End If

        ' image
        Dim uploadImg As Boolean = False
        Dim removeImg As Boolean = False
        Dim ext = ""

        If Not imgFlName.Equals(selectedBook.imageName) Then
            If imgFlName.Equals("") AndAlso Not selectedBook.imageName.Equals("empty") Then
                removeImg = True
                attrs.Add("imageName", "empty")
            Else
                uploadImg = True
                Dim strt = imgFlName.LastIndexOf(".")
                ext = imgFlName.Substring(strt, imgFlName.Length - strt)
                selectedBook.imageName = selectedBook.bookId.ToString + ext
                attrs.Add("imageName", selectedBook.imageName)
            End If
        End If

        If attrs.Count <> 0 Then
            ' call request for update author
            BookController.updateBook(selectedBook.bookId, attrs)
        End If

        If updateAuthor Then
            BookController.updateAuthorOfBook(selectedBook.bookId, authors)
        End If

        If updateCopies Then
            CopyController.updateCopiesOfBook(selectedBook.bookId, copies)
        End If

        If uploadImg Then
            uploadImage(selectedBook.imageName)  ' upload the image
        ElseIf removeImg Then
            ImageController.removeImage(selectedBook.imageName)
        End If
        MessageBox.Show("Successfully updated!")
        populate(selectedBook.bookId)
        adminView.viewBookuserCtl.initializeResult()
    End Sub

    Private Sub cancelHoverBtn_Click(sender As Object, e As EventArgs) Handles cancelHoverPcBx.Click
        empty()
    End Sub

    ' authors
    Private Sub setAuthors()
        authors.Clear()
        For idx As Integer = 0 To authorsDataGrid.Rows.Count - 2
            Dim newAuthor As New AuthorDTO
            Dim f_name = If(IsNothing(authorsDataGrid.Item(0, idx).Value), "", authorsDataGrid.Item(0, idx).Value.ToString().Trim)
            Dim m_name = If(IsNothing(authorsDataGrid.Item(1, idx).Value), "", authorsDataGrid.Item(1, idx).Value.ToString().Trim)
            Dim l_name = If(IsNothing(authorsDataGrid.Item(2, idx).Value), "", authorsDataGrid.Item(2, idx).Value.ToString().Trim)
            If f_name.Equals("") AndAlso m_name.Equals("") AndAlso l_name.Equals("") Then
                Continue For
            End If

            Dim attrs As New Dictionary(Of String, String)
            attrs.Add("fName", f_name)
            attrs.Add("mName", m_name)
            attrs.Add("lName", l_name)

            Dim prevAuthor = AuthorController.findAuthorByName(attrs)
            If prevAuthor.id <> -1 Then
                newAuthor = prevAuthor
            Else
                newAuthor.id = -1
                newAuthor.f_name = f_name
                newAuthor.m_name = m_name
                newAuthor.l_name = l_name
            End If
            authors.Add(newAuthor)
        Next
        If authors.Count = 0 Then
            authors.Add(New AuthorDTO(-1, Nothing, Nothing, Nothing))
        End If
    End Sub

    Private Sub setCopies()
        copies.Clear()
        For idx As Integer = 0 To copiesDataGridView.Rows.Count - 2
            Dim copy As New BookCopyDTO
            copy.id = -1
            copy.copy_num = copiesDataGridView.Item(0, idx).Value.ToString().Trim
            copy.status = copiesDataGridView.Item(1, idx).Value.ToString().Trim
            If copy.copy_num.Equals("") Then
                Continue For
            End If
            If copies.Contains(copy) Then
                MessageBox.Show("Failed: Instances contain same Copy #")
            Else
                copies.Add(copy)
            End If
        Next
    End Sub

    ' image
    Private Sub addImgBtn_click(sender As Object, e As EventArgs) Handles bkPicBx.Click
        Dim fileDialog = New OpenFileDialog()
        fileDialog.Filter = "Picture Files (*)|*.bmp;*.jpg;*.png"

        If fileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgFlName = fileDialog.FileName
            bkPicBx.Image = Image.FromFile(imgFlName)
            removeImgBtn.Visible = True
        End If
    End Sub

    Private Sub removeImgBtn_Click(sender As Object, e As EventArgs) Handles removeImgBtn.Click
        bkPicBx.Image = My.Resources.default_book
        imgFlName = ""
        removeImgBtn.Visible = False
    End Sub

    ' HELPER FUNCTIONS/SUBS
    Private Sub populate(bookId As String)
        selectedBook = BookController.getBook(bookId)
        setSelectedBook(selectedBook)
    End Sub

    Public Sub setSelectedBook(ByRef selectedBook As BookDetailsDTO)
        Me.selectedBook = selectedBook
        titleTxtBx.Text = selectedBook.title
        isbnTxtBx.Text = selectedBook.isbn
        languageTxtBx.Text = selectedBook.language
        editionTxtBx.Text = If(selectedBook.edition Is Nothing, "", selectedBook.edition)
        'numAvailableLbl.Text = selectedBook.numAvailable

        publisherNameTxtBx.Text = selectedBook.publisherName
        publisherAddrTxtBx.Text = selectedBook.publisherAddress
        If selectedBook.publishedDate <> Nothing Then
            publishedDatePicker.Value = Date.ParseExact(selectedBook.publishedDate, "yyyy-MM-dd", provider)
        Else
            publishedDatePicker.Value = publishedDatePicker.MinDate
            publishedDatePicker.Checked = False
        End If

        classificationCmbBx.SelectedIndex = selectedBook.categoryId - 1
        copyrightNameTxtBx.Text = selectedBook.copyrightName
        If selectedBook.copyrightYear <> 0 Then
            copyrightYearDTPckr.Value = Date.ParseExact(selectedBook.copyrightYear, "yyyy", provider)

        Else
            copyrightYearDTPckr.Value = copyrightYearDTPckr.MinDate
            copyrightYearDTPckr.Checked = False
        End If

        shelfTxtBx.Text = selectedBook.shelfName
        summaryRichTxtBx.Text = selectedBook.summary
        ' authors
        authors = New List(Of AuthorDTO)
        For Each author As AuthorDTO In selectedBook.authors
            authors.Add(New AuthorDTO(author.id, author.f_name, author.m_name, author.l_name))
        Next
        populateAuthors()

        ' load copies
        If IsNothing(selectedBook.copies) Then
            copies = CopyController.getCopies(selectedBook.bookId)
        Else
            copies = selectedBook.copies
        End If
        prevCopies.AddRange(copies)  ' created a copy to check if there is difference when saving later on 
        populateCopies()
        quantityLbl.Text = copiesDataGridView.Rows.Count - 1

        ' image
        Dim img As Image
        imgFlName = selectedBook.imageName
        If imgFlName.Equals("empty") Then
            img = My.Resources.default_book
            removeImgBtn.Visible = False
        Else
            If IsNothing(selectedBook.image) Then
                img = ImageController.getImage(imgFlName)
            Else
                img = selectedBook.image
            End If
            removeImgBtn.Visible = True
        End If
        bkPicBx.Image = img
        addPcBx.Visible = False
        savePcBx.Visible = True
        isbnLbl_leave(Nothing, Nothing)
    End Sub


    Private Sub populateAuthors()
        authorsDataGrid.Rows.Clear()
        For Each author In authors
            authorsDataGrid.Rows.Add({author.f_name, author.m_name, author.l_name})
        Next
    End Sub

    Private Sub populateCopies()
        copiesDataGridView.Rows.Clear()
        For Each copy In copies
            copiesDataGridView.Rows.Add({copy.copy_num, copy.status})
            'copiesDataGridView.Rows.Add({copy.copy_num, "Not Available"})
        Next
    End Sub

    Private Sub uploadImage(flNm As String)
        bkPicBx.Image.Dispose()
        Dim res As String = ImageController.uploadImage(imgFlName, flNm)
        bkPicBx.Image = Image.FromFile(imgFlName)
    End Sub

    Private Sub loadImage(flNm As String)
        Dim imgRetuned = ImageController.getImage(flNm)
        bkPicBx.Image = imgRetuned
    End Sub

    Private Sub empty()
        selectedBook = Nothing
        titleTxtBx.Text = String.Empty
        isbnTxtBx.Text = String.Empty
        publisherNameTxtBx.Text = String.Empty
        publisherAddrTxtBx.Text = String.Empty
        publishedDatePicker.Value = Date.Now()
        publishedDatePicker.Checked = True
        classificationCmbBx.SelectedIndex = 0
        copyrightNameTxtBx.Text = String.Empty
        copyrightYearDTPckr.Value = Date.Now()
        copyrightYearDTPckr.Checked = True
        shelfTxtBx.Text = String.Empty
        summaryRichTxtBx.Text = String.Empty
        authors.Clear()
        authorsDataGrid.Rows.Clear()
        copies.Clear()
        copiesDataGridView.Rows.Clear()
        copiesDataGridView.Rows.Add({1, status.Item(0)})
        quantityLbl.Text = 1
        bkPicBx.Image = My.Resources.default_book
        removeImgBtn.Visible = False
        savePcBx.Visible = False
        addPcBx.Visible = True
        isbnWarningLbl.Visible = False
        selectedBook = Nothing
        imgFlName = String.Empty
        editionTxtBx.Text = String.Empty
        populateAuthors()
    End Sub

    ' elements

    Private Sub authorsDataGrid_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles authorsDataGrid.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
       e.RowIndex >= 0 Then
            If (e.ColumnIndex = 3) Then
                ' delete clicked
                Try
                    authorsDataGrid.Rows.RemoveAt(e.RowIndex)
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Private Sub copiesDataGridView_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles copiesDataGridView.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
       e.RowIndex >= 0 Then
            If (e.ColumnIndex = 2) Then
                ' delete clicked
                Try
                    copiesDataGridView.Rows.RemoveAt(e.RowIndex)
                    quantityLbl.Text = copiesDataGridView.Rows.Count() - 1
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub copiesDataGridView_CellChanged(sender As Object, e As EventArgs) Handles copiesDataGridView.CellLeave
        quantityLbl.Text = copiesDataGridView.Rows.Count - 1
    End Sub
    Private Sub copiesDataGridView_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles copiesDataGridView.DefaultValuesNeeded
        ' copiesDataGridView.Rows.Item(1).Cells.Item(1).Cell
        e.Row.Cells("statusCol").Value = "Available"
    End Sub
    Private Sub cancelPcBx_Hover(sender As Object, e As EventArgs) Handles cancelPcBx.MouseHover
        cancelHoverPcBx.Visible = True
        cancelPcBx.Visible = False
    End Sub
    Private Sub cancelHoverPcBx_Hover(sender As Object, e As EventArgs) Handles cancelHoverPcBx.MouseLeave
        cancelHoverPcBx.Visible = False
        cancelPcBx.Visible = True
    End Sub

    Private Sub savePcBx_Hover(sender As Object, e As EventArgs) Handles savePcBx.MouseHover
        saveHoverPcBx.Visible = True
        savePcBx.Visible = False
    End Sub

    Private Sub saveHoverPcBx_Hover(sender As Object, e As EventArgs) Handles saveHoverPcBx.MouseLeave
        saveHoverPcBx.Visible = False
        savePcBx.Visible = True
    End Sub
    Private Sub addPcBx_Hover(sender As Object, e As EventArgs) Handles addPcBx.MouseHover
        addHoverPcBx.Visible = True
        addPcBx.Visible = False
    End Sub

    Private Sub addHoverPcBx_Hover(sender As Object, e As EventArgs) Handles addHoverPcBx.MouseLeave
        addHoverPcBx.Visible = False
        addPcBx.Visible = True
    End Sub

    ' check if isbn exist
    Private Function isbnLbl_leave(sender As Object, e As EventArgs) As Boolean Handles isbnTxtBx.Leave

        ' check if admin is adding or updating book
        Dim check = IsNothing(selectedBook)
        check = If(check, Not isbnTxtBx.Text.Trim.Equals(""), If(IsNothing(selectedBook.isbn), Not isbnTxtBx.Text.Trim.Equals(""), Not isbnTxtBx.Text.Trim.Equals("") AndAlso Not selectedBook.isbn.Equals(isbnTxtBx.Text.Trim)))
        Dim isbnExist = check AndAlso BookController.checkIsbn(isbnTxtBx.Text.Trim)

        If isbnExist Then
            isbnWarningLbl.Visible = True
            Return True
        Else
            isbnWarningLbl.Visible = False
            Return False
        End If
    End Function

    Private Function checks() As Boolean
        If languageTxtBx.Text.Trim.Length > 100 Then
            MessageBox.Show("Language invalid: Exceeded 100 characterss")
            Return False
        End If
        Dim isbn = isbnTxtBx.Text.Trim
        If isbn.Length > 17 Then
            MessageBox.Show("ISBN invalid: Exceeded 17 characters")
            Return False
        End If
        If isbnLbl_leave(Nothing, Nothing) Then
            MessageBox.Show("ISBN invalid: already exist")
            Return False
        End If

        Return True
    End Function

End Class
