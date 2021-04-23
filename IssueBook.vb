Imports System.Globalization
Public Class IssueBook
    'Private Sub IssueBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Dim userDTO As UserDTO
    Dim bookDetailsDTOBorrow As BookDetailsDTO
    Dim bookDetailsDTOReserve As BookDetailsDTO
    Dim bookDetailsDTO As BookDetailsDTO
    Dim copies As New List(Of BookCopyDTO)
    Dim copyNum As New List(Of Integer)
    Dim viewBook As viewBook
    Dim bookControlAdmin As bookControlAdmin
    Dim selectedCopy As BookCopyDTO
    Dim provider As CultureInfo

    Public Sub New(ByRef viewBook As viewBook, ByRef bookControlAdmin As bookControlAdmin)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.viewBook = viewBook
        Me.bookControlAdmin = bookControlAdmin
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
            addressTxtBx.Text = userDTO.address
            sectionTxtBx.Text = userDTO.sectionDTO.name
            gradeLevelTxtBx.Text = userDTO.gradeLevelDTO.level
        Catch ex As Exception
            If ex.Message.Equals("The remote server returned an error: (500) Internal Server Error.") Then
                MessageBox.Show("UserID:" + textBoxId.Text + " is not registered")
            End If
        End Try
    End Sub

    Public Sub setBookDetailsDTO(ByRef bookDetailsDTO As BookDetailsDTO, ByRef provider As CultureInfo, ByRef image As Image, ByRef idxCopy As Integer, ByRef isBorrow As Boolean)

        bookPcBx.Image = image
        Me.bookDetailsDTO = bookDetailsDTO
        Me.provider = provider

        textBoxTitle.Text = bookDetailsDTO.title
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
        textBoxAuthors.Text = authorsDisplay
        authorsReserveTxtBx.Text = authorsDisplay

        ' publication.
        Dim publisheDate = If(bookDetailsDTO.publishedDate Is Nothing,
                "", Date.ParseExact(bookDetailsDTO.publishedDate, "yyyy-MM-dd", provider).Year.ToString())
        Dim publisher = If(bookDetailsDTO.publisherAddress Is Nothing, "", "[" + bookDetailsDTO.publisherAddress + "]") + If(bookDetailsDTO.publisherName Is Nothing, "", " : " + bookDetailsDTO.publisherName) + ", " + publisheDate
        textBoxPubDate.Text = publisheDate
        textBoxPublisher.Text = publisher
        publisherDateReserveTxtBx.Text = publisheDate
        publisherReserveTxtBx.Text = publisher

        ' edition
        textBoxEdition.Text = bookDetailsDTO.edition
        editionReserveTxtBx.Text = bookDetailsDTO.edition

        ' isbn
        textBoxISBN.Text = bookDetailsDTO.isbn
        isbnReserveTxtBx.Text = bookDetailsDTO.isbn

        ' classifcation
        textBoxCategory.Text = bookDetailsDTO.categoryName
        categoryReserveTxtBx.Text = bookDetailsDTO.categoryName

        ' language
        textBoxLanguage.Text = bookDetailsDTO.language
        languageReserveTxtBx.Text = bookDetailsDTO.language
        setCopies(bookDetailsDTO, idxCopy)

        If isBorrow Then
            TabControl1.SelectedIndex = 0
        Else
            TabControl1.SelectedIndex = 1
        End If
        issueDateTimePicker.Value = Date.Now()
        dueDateTimePicker.MinDate = Date.Now()
        reserveDateTimePicker.MinDate = Date.Now()
    End Sub

    Private Sub setCopies(bkDTO As BookDetailsDTO, idxCopy As Integer)

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

        copyNumCmbBx.DataSource = copyNum
        copyNumCmbBx.SelectedIndex = idxCopy
        textBoxStatus.Text = copies.Item(idxCopy).status
        copyNumReserveCmbBx.DataSource = copyNum
        copyNumReserveCmbBx.SelectedIndex = idxCopy
        statusReserveTxtBx.Text = copies.Item(idxCopy).status
    End Sub

    Private Sub copyNumCmbBx_Changed(sender As Object, e As EventArgs) Handles copyNumCmbBx.Leave, copyNumCmbBx.SelectedIndexChanged
        Dim val As String = copyNumCmbBx.Text.Trim
        Dim idx = If(IsNumeric(val), copies.IndexOf(New BookCopyDTO(-1, CType(val, Int32))), -1)

        If idx <> -1 Then
            selectedCopy = copies.Item(idx)
            textBoxStatus.Text = selectedCopy.status
            If Not textBoxStatus.Text.Equals("Available") Then
                buttonBorrow.Enabled = False
            Else
                buttonBorrow.Enabled = True
                dueDateTimePickerVaueChanged_Handler(Nothing, Nothing)
            End If
        Else
            selectedCopy = Nothing
        End If

    End Sub
    Private Sub copyNumReserveCmbBx_Changed(sender As Object, e As EventArgs) Handles copyNumReserveCmbBx.Leave, copyNumReserveCmbBx.SelectedIndexChanged
        Dim val As String = copyNumReserveCmbBx.Text.Trim
        Dim idx = If(IsNumeric(val), copies.IndexOf(New BookCopyDTO(-1, CType(val, Int32))), -1)

        If idx <> -1 Then
            selectedCopy = copies.Item(idx)
            statusReserveTxtBx.Text = selectedCopy.status
            Dim isAvailable = statusReserveTxtBx.Text.Equals("Available")
            If Not isAvailable Then
                buttonReserve.Enabled = False
            Else
                buttonReserve.Enabled = True
            End If

            If Not IsNothing(selectedCopy.reserved_date) Then
                buttonReserve.Enabled = False
                ' only one person can reserve at a time and borrow
                warningCopyReservedAlreadyLbl.Text = "Warning: Copy is already reserved on " + Date.ParseExact(selectedCopy.reserved_date, "yyyy-MM-dd", provider).ToString("MMM d, yyyy")
                warningCopyReservedAlreadyLbl.Visible = True
            Else
                buttonReserve.Enabled = isAvailable
                warningCopyReservedAlreadyLbl.Visible = False
            End If
        Else
            selectedCopy = Nothing
        End If
    End Sub

    Private Sub buttonBorrow_Click(sender As Object, e As EventArgs) Handles buttonBorrow.Click
        If Not setUser() Then
            Return
        End If
        Dim newBorrow As BorrowDTO = New BorrowDTO()
        newBorrow.borrowId = -1
        newBorrow.bkCpyId = copies.Item(copyNumCmbBx.SelectedIndex).id
        copies.Item(copyNumCmbBx.SelectedIndex).status = "Borrowed"
        newBorrow.userDTO = Me.userDTO
        newBorrow.issueDate = issueDateTimePicker.Value.ToString("yyyy-MM-dd")
        newBorrow.dueDate = dueDateTimePicker.Value.ToString("yyyy-MM-dd")
        BookController.addBorrow(newBorrow)
        updateCopiesOfChild()
        MessageBox.Show("Book successfully borrowed!!")
        Me.Close()
    End Sub

    Private Sub buttonReserve_Click(sender As Object, e As EventArgs) Handles buttonReserve.Click

        If Not setUser() Then
            Return
        End If
        Dim newReservation As ReservationDTO = New ReservationDTO()
        Dim reservedDate As String = reserveDateTimePicker.Value.ToString("yyyy-MM-dd")
        newReservation.reservationId = -1
        newReservation.bkCpyId = copies.Item(copyNumReserveCmbBx.SelectedIndex).id
        newReservation.userDTO = Me.userDTO
        newReservation.reservedDate = reservedDate
        copies.Item(copyNumReserveCmbBx.SelectedIndex).status = If(reservedDate.Equals(Date.Now().ToString("yyyy-MM-dd")), "Reserved", "Available")
        copies.Item(copyNumReserveCmbBx.SelectedIndex).reserved_date = reservedDate
        BookController.addReservation(newReservation)
        updateCopiesOfChild()
        MessageBox.Show("Book successfully reserved!!")
        Me.Close()
    End Sub

    Private Sub updateCopiesOfChild()
        If Not IsNothing(Me.viewBook) Then
            Me.viewBook.setCopies()
        End If
        If Not IsNothing(Me.bookControlAdmin) Then
            Me.bookControlAdmin.setCopies()
        End If
    End Sub
    Private Function setUser() As Boolean
        If textBoxId.Text.Trim.Equals("") Then
            MessageBox.Show("ID Number invalid: must not be empty.")
            Me.userDTO = Nothing
            Return False
        End If
        If Not IsNumeric(gradeLevelTxtBx.Text.Trim) Then
            MessageBox.Show("Grade Level invalid: must be a number.")
            Me.userDTO = Nothing
            Return False
        End If

        Me.userDTO = New UserDTO()
        userDTO.id = textBoxId.Text.Trim
        userDTO.fName = fNameTxtBx.Text.Trim
        userDTO.mName = mNameTxtBx.Text.Trim
        userDTO.lName = lNameTxtBx.Text.Trim
        userDTO.type = userTypeTxtBx.Text.Trim
        userDTO.address = addressTxtBx.Text.Trim

        Dim sectionDTO As New SectionDTO()
        sectionDTO.name = sectionTxtBx.Text.Trim

        Dim gradeLevelDTO As New GradeLevelDTO()
        gradeLevelDTO.level = CType(gradeLevelTxtBx.Text.Trim, Integer)
        userDTO.gradeLevelDTO = gradeLevelDTO

        userDTO.sectionDTO = sectionDTO
        Return True
    End Function
    Private Sub dueDateTimePickerVaueChanged_Handler(sender As Object, e As EventArgs) Handles dueDateTimePicker.ValueChanged
        If selectedCopy IsNot Nothing AndAlso selectedCopy.reserved_date IsNot Nothing Then
            Dim reserved = Date.ParseExact(selectedCopy.reserved_date, "yyyy-MM-dd", provider)
            If issueDateTimePicker.Value < reserved AndAlso reserved <= dueDateTimePicker.Value Then
                warningCopyReservedLbl.Text = "Warning: Copy is reserved on " + reserved.ToString("MMM d, yyyy")
                warningCopyReservedLbl.Visible = True
                buttonBorrow.Enabled = False
                Return
            End If
        End If
        warningCopyReservedLbl.Visible = False
        buttonBorrow.Enabled = If(textBoxStatus.Text.Trim.Equals("Available"), True, False)
    End Sub
End Class