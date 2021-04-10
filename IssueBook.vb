Imports System.Globalization
Public Class IssueBook
    'Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim userDTO As UserDTO
    Dim bookDetailsDTOBorrow As BookDetailsDTO
    Dim bookDetailsDTOReserve As BookDetailsDTO
    Dim copies As New List(Of BookCopyDTO)
    Dim copyNum As New List(Of Integer)
    Dim viewBook As viewBook

    Public Sub New(ByRef viewBook As viewBook)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.viewBook = viewBook
    End Sub
    'End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub buttonBorrow_MouseEnter(sender As Object, e As EventArgs)
        Me.buttonBorrow.BackColor = Color.DodgerBlue
    End Sub

    Private Sub buttonBorrow_MouseLeave(sender As Object, e As EventArgs)
        Me.buttonBorrow.BackColor = Color.SlateGray
    End Sub

    Private Sub buttonReserve_MouseEnter(sender As Object, e As EventArgs)
        Me.buttonReserve.BackColor = Color.DodgerBlue
    End Sub

    Private Sub buttonReserve_MouseLeave(sender As Object, e As EventArgs)
        Me.buttonReserve.BackColor = Color.SlateGray
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchUserIdBtn.Click
        Try
            userDTO = UserController.getUser(textBoxId.Text.Trim)
            fNameTxtBx.Text = userDTO.fName
            mNameTxtBx.Text = userDTO.mName
            lNameTxtBx.Text = userDTO.lName
            userTypeTxtBx.Text = userDTO.type
            sectionTxtBx.Text = userDTO.sectionDTO.name
            addressTxtBx.Text = userDTO.address
        Catch ex As Exception
            If ex.Message.Equals("The remote server returned an error: (500) Internal Server Error.") Then
                MessageBox.Show("UserID:" + textBoxId.Text + " is not registered")
                Debug.WriteLine(ex.Message)
                Debug.WriteLine(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub setBookDetailsDTOBorrow(ByRef bookDetailsDTO As BookDetailsDTO, ByRef provider As CultureInfo, ByRef image As Image, ByRef idxCopy As Integer)

        TabControl1.SelectedIndex = 0
        bookPcBx.Image = image
        Me.bookDetailsDTOBorrow = bookDetailsDTO
        textBoxTitle.Text = bookDetailsDTO.title

        ' authors
        Dim authorsDisplay = ""
        Dim authors = bookDetailsDTO.authors
        If authors.Count <> 0 Then
            authorsDisplay = authorsDisplay + authors(0).f_name + " " + authors(0).m_name + " " + authors(0).l_name + vbCrLf
            For idx As Integer = 1 To authors.Count - 1
                authorsDisplay = authorsDisplay + authors(idx).f_name + " " + authors(idx).m_name + " " + authors(idx).l_name + vbCrLf
            Next
        End If
        textBoxAuthors.Text = authorsDisplay

        ' publication.
        Dim publisheDate = If(bookDetailsDTO.publishedDate Is Nothing,
                "", Date.ParseExact(bookDetailsDTO.publishedDate, "yyyy-MM-dd", provider).Year.ToString())
        Dim publisher = If(bookDetailsDTO.publisherAddress Is Nothing, "", "[" + bookDetailsDTO.publisherAddress + "]") + If(bookDetailsDTO.publisherName Is Nothing, "", " : " + bookDetailsDTO.publisherName) + ", " + publisheDate
        textBoxPubDate.Text = publisheDate
        textBoxPublisher.Text = publisher

        ' edition
        textBoxEdition.Text = If(bookDetailsDTO.edition = Nothing, "", bookDetailsDTO.edition.ToString)

        ' isbn
        textBoxISBN.Text = If(bookDetailsDTO.isbn Is Nothing, "", bookDetailsDTO.isbn)

        ' classifcation
        textBoxCategory.Text = If(bookDetailsDTO.categoryName Is Nothing, "", bookDetailsDTO.categoryName)
        ' language
        textBoxLanguage.Text = bookDetailsDTO.language
        setCopies(bookDetailsDTO, True, idxCopy)
    End Sub

    Public Sub setBookDetailsDTOReservation(ByRef bookDetailsDTO As BookDetailsDTO, ByRef provider As CultureInfo, ByRef image As Image, ByRef idxCopy As Integer)

        TabControl1.SelectedIndex = 1
        bookPcBx.Image = image
        Me.bookDetailsDTOReserve = bookDetailsDTO
        titleReserveTxtBx.Text = bookDetailsDTO.title

        ' authors
        Dim authorsDisplay = ""
        Dim authors = bookDetailsDTO.authors
        If authors.Count <> 0 Then
            authorsDisplay = authorsDisplay + authors(0).f_name + " " + authors(0).m_name + " " + authors(0).l_name + vbCrLf
            For idx As Integer = 1 To authors.Count - 1
                authorsDisplay = authorsDisplay + authors(idx).f_name + " " + authors(idx).m_name + " " + authors(idx).l_name + vbCrLf
            Next
        End If
        authorsReserveTxtBx.Text = authorsDisplay

        ' publication.
        Dim publisheDate = If(bookDetailsDTO.publishedDate Is Nothing,
                "", Date.ParseExact(bookDetailsDTO.publishedDate, "yyyy-MM-dd", provider).Year.ToString())
        Dim publisher = If(bookDetailsDTO.publisherAddress Is Nothing, "", "[" + bookDetailsDTO.publisherAddress + "]") + If(bookDetailsDTO.publisherName Is Nothing, "", " : " + bookDetailsDTO.publisherName) + ", " + publisheDate
        publisherDateReserveTxtBx.Text = publisheDate
        publisherReserveTxtBx.Text = publisher

        ' edition
        editionReserveTxtBx.Text = If(bookDetailsDTO.edition = Nothing, "", bookDetailsDTO.edition.ToString)

        ' isbn
        isbnReserveTxtBx.Text = If(bookDetailsDTO.isbn Is Nothing, "", bookDetailsDTO.isbn)

        ' classifcation
        categoryReserveTxtBx.Text = If(bookDetailsDTO.categoryName Is Nothing, "", bookDetailsDTO.categoryName)
        ' language
        languageReserveTxtBx.Text = bookDetailsDTO.language
        setCopies(bookDetailsDTO, False, idxCopy)
    End Sub

    Private Sub setCopies(bkDTO As BookDetailsDTO, isBorrow As Boolean, idxCopy As Integer)

        Me.userDTO = Nothing
        If IsNothing(bkDTO.copies) Then
            copies = CopyController.getCopies(bkDTO.bookId)
            copies.Sort(Function(x, y) x.copy_num.CompareTo(y.copy_num))
            bkDTO.copies = copies
        Else
            copies = bkDTO.copies
        End If

        For Each copyDTO As BookCopyDTO In copies
            copyNum.Add(copyDTO.copy_num)
        Next

        If isBorrow Then
            copyNumCmbBx.DataSource = copyNum
            copyNumCmbBx.SelectedIndex = idxCopy
            textBoxStatus.Text = copies.Item(idxCopy).status
        Else
            copyNumReserveCmbBx.DataSource = copyNum
            copyNumReserveCmbBx.SelectedIndex = idxCopy
            statusReserveTxtBx.Text = copies.Item(idxCopy).status
        End If
    End Sub

    Private Sub copyNumCmbBx_Changed(sender As Object, e As EventArgs) Handles copyNumCmbBx.SelectedIndexChanged
        textBoxStatus.Text = copies.Item(copyNumCmbBx.SelectedIndex).status
        If Not textBoxStatus.Text.Equals("Available") Then
            buttonBorrow.Enabled = False
        Else
            buttonBorrow.Enabled = True
        End If
    End Sub
    Private Sub copyNumReserveCmbBx_Changed(sender As Object, e As EventArgs) Handles copyNumReserveCmbBx.SelectedIndexChanged
        statusReserveTxtBx.Text = copies.Item(copyNumReserveCmbBx.SelectedIndex).status
        If Not statusReserveTxtBx.Text.Equals("Available") Then
            buttonReserve.Enabled = False
        Else
            buttonReserve.Enabled = True
        End If
    End Sub

    Private Sub buttonBorrow_Click(sender As Object, e As EventArgs) Handles buttonBorrow.Click
        If IsNothing(Me.userDTO) Then
            setUser()
        End If
        Dim newBorrow As BorrowDTO = New BorrowDTO()
        newBorrow.borrowId = -1
        newBorrow.bkCpyId = copies.Item(copyNumCmbBx.SelectedIndex).id
        copies.Item(copyNumCmbBx.SelectedIndex).status = "Borrowed"
        newBorrow.userDTO = Me.userDTO
        newBorrow.issueDate = issueDateTimePicker.Value.ToString("yyyy-MM-dd")
        newBorrow.dueDate = dueDateTimePicker.Value.ToString("yyyy-MM-dd")
        BookController.addBorrow(newBorrow)
        updateCopiesOfViewBook()
        MessageBox.Show("Book successfully borrowed!!")
        Me.Close()
    End Sub

    Private Sub buttonReserve_Click(sender As Object, e As EventArgs) Handles buttonReserve.Click
        If IsNothing(Me.userDTO) Then
            setUser()
        End If
        Dim newReservation As ReservationDTO = New ReservationDTO()
        newReservation.reservationId = -1
        newReservation.bkCpyId = copies.Item(copyNumReserveCmbBx.SelectedIndex).id
        copies.Item(copyNumReserveCmbBx.SelectedIndex).status = "Reserved"
        newReservation.userDTO = Me.userDTO
        newReservation.reservedDate = reserveDateTimePicker.Value.ToString("yyyy-MM-dd")
        BookController.addReservation(newReservation)
        updateCopiesOfViewBook()
        MessageBox.Show("Book successfully reserved!!")
        Me.Close()
    End Sub

    Private Sub updateCopiesOfViewBook()
        If Not IsNothing(Me.viewBook) Then
            Me.viewBook.setCopies()
        End If
    End Sub
    Private Sub setUser()
        Me.userDTO = New UserDTO()
        userDTO.id = textBoxId.Text.Trim
        userDTO.fName = fNameTxtBx.Text.Trim
        userDTO.mName = mNameTxtBx.Text.Trim
        userDTO.lName = lNameTxtBx.Text.Trim
        userDTO.type = userTypeTxtBx.Text.Trim
        Dim sectionDTO As New SectionDTO()
        sectionDTO.name = sectionTxtBx.Text.Trim
        userDTO.sectionDTO = sectionDTO
        userDTO.address = addressTxtBx.Text.Trim
    End Sub

    Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class