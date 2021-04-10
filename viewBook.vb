Imports System.Globalization

Public Class viewBook
    Private copies As List(Of BookCopyDTO)
    Private bkDTO As BookDetailsDTO
    Private provider As CultureInfo
    Private adminView As adminView
    'Private dataGridRows As List()
    Private Sub Location_Btn_Click(sender As Object, e As EventArgs) Handles Location_Btn.Click
        'LocationPage.Location = New Point(364, 0)
        'DetailsPage.Visible = False
        DetailsPanel.Visible = False
        LocationPage.Visible = True
        MoreInfoPage.Visible = False
        Details_Btn.BackColor = Color.Transparent
        Location_Btn.BackColor = Color.Gray
        MoreInformation_Btn.BackColor = Color.Transparent
    End Sub

    Private Sub Btn_Details_Click(sender As Object, e As EventArgs) Handles Details_Btn.Click
        'DetailsPage.Location = New Point(364, 0)
        'DetailsPage.Visible = True
        DetailsPanel.Visible = True
        LocationPage.Visible = False
        MoreInfoPage.Visible = False
        Details_Btn.BackColor = Color.Gray
        Location_Btn.BackColor = Color.Transparent
        MoreInformation_Btn.BackColor = Color.Transparent
    End Sub

    Private Sub MoreInformation_Btn_Click(sender As Object, e As EventArgs) Handles MoreInformation_Btn.Click
        'MoreInfoPage.Location = New Point(364, 0)
        'DetailsPage.Visible = False
        DetailsPanel.Visible = False
        LocationPage.Visible = False
        MoreInfoPage.Visible = True
        Details_Btn.BackColor = Color.Transparent
        Location_Btn.BackColor = Color.Transparent
        MoreInformation_Btn.BackColor = Color.Gray
    End Sub

    Public Sub setBkDTO(ByRef bkDTO As BookDetailsDTO, ByRef image As Image, ByRef provider As CultureInfo)
        Me.bkDTO = bkDTO
        Me.provider = provider
        coverPcBx.Image = image
        ' summary
        summaryRchTxtBx.Text = bkDTO.summary
        abstractRichTxtBx.Text = bkDTO.summary

        ' title
        titleLbl.Text = bkDTO.title
        titleSmallLbl.Text = bkDTO.title

        ' authors
        Dim authorsDisplay = "by "
        Dim authors = bkDTO.authors
        If authors.Count <> 0 Then
            authorsDisplay = authorsDisplay + authors(0).f_name + " " + authors(0).m_name + " " + authors(0).l_name + " "
            For idx As Integer = 1 To authors.Count - 1
                authorsDisplay = authorsDisplay + ", " + authors(idx).f_name + " " + authors(idx).m_name + " " + authors(idx).l_name + " "
            Next
        End If
        authorsSmallLbl.Text = authorsDisplay
        authorsLbl.Text = authorsDisplay

        ' publication.

        Dim publisheDate = If(bkDTO.publishedDate Is Nothing,
                "", Date.ParseExact(bkDTO.publishedDate, "yyyy-MM-dd", provider).Year.ToString())
        Dim publisher = If(bkDTO.publisherAddress Is Nothing, "", "[" + bkDTO.publisherAddress + "]") + If(bkDTO.publisherName Is Nothing, "", " : " + bkDTO.publisherName) + ", " + publisheDate
        publicationInformationLbl.Text = publisher

        ' edition
        editionLbl.Text = If(bkDTO.edition = Nothing, "", bkDTO.edition.ToString)

        ' isbn
        isbnLbl.Text = If(bkDTO.isbn Is Nothing, "", bkDTO.isbn)

        ' classifcation
        classificationLbl.Text = If(bkDTO.categoryName Is Nothing, "", bkDTO.categoryName)
        ' language
        languageLbl.Text = bkDTO.language


        ' copyright: Copyright ©2019 by Andrew Hamburg  
        ' copyright
        copyrightLbl.Text = "Copyright " + If(bkDTO.copyrightYear = 0, "", "©" + bkDTO.copyrightYear.ToString) + " by " + If(bkDTO.copyrightName Is Nothing, " ", " " + bkDTO.copyrightName)

        ' location
        shelfLocationLbl.Text = If(bkDTO.shelfName Is Nothing, "", bkDTO.shelfName)
        ' collection
        collectionLbl.Text = bkDTO.categoryName

        ' copies

        If IsNothing(bkDTO.copies) Then
            copies = CopyController.getCopies(bkDTO.bookId)
            copies.Sort(Function(x, y) x.copy_num.CompareTo(y.copy_num))
            bkDTO.copies = copies
        Else
            copies = bkDTO.copies
        End If
        setCopies()

            ' quantity, reserved, borrowed
            NumberOfBooksNO.Text = bkDTO.quantity
        Dim numberOfBorrowed As Integer = 0
        Dim numberOfReserved As Integer = 0
        Dim numberOfAvailable As Integer = 0
        For Each copy As BookCopyDTO In copies
            If copy.status.Equals("Borrowed") Then
                numberOfBorrowed += 1
            ElseIf copy.status.Equals("Reserved") Then
                numberOfReserved += 1
            End If
        Next
        ReservedNO.Text = numberOfReserved
        BorrowedNO.Text = numberOfBorrowed
        numberOfAvailable = bkDTO.quantity - numberOfBorrowed - numberOfReserved
        AvailabeNO.Text = numberOfAvailable

        'status
        If bkDTO.numAvailable = 0 Then
            mainStatusLbl.Text = "Not Available"
            mainStatusLbl.ForeColor = Color.Red
        Else
            mainStatusLbl.Text = "Available"
            mainStatusLbl.ForeColor = Color.Lime
        End If
    End Sub

    Public Sub setCopies()
        copiesDataGridView.Rows.Clear()
        For Each copy As BookCopyDTO In copies
            copiesDataGridView.Rows.Add({copy.copy_num, copy.status})
        Next
    End Sub
    Private Sub copiesDataGridView_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles copiesDataGridView.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
       e.RowIndex >= 0 Then
            'TODO - Button Clicked - Execute Code Here
            ' copiesDataGridView.Rows.Item(e.RowIndex)
            If (e.ColumnIndex = 2) Then
                ' checkout clicked
                Dim issueBk As New IssueBook(Me)
                issueBk.setBookDetailsDTOBorrow(Me.bkDTO, Me.provider, Me.coverPcBx.Image, e.RowIndex)
                issueBk.ShowDialog()
            ElseIf (e.ColumnIndex = 3) Then
                ' reserved clicked
                Dim issueBk As New IssueBook(Me)
                issueBk.setBookDetailsDTOReservation(Me.bkDTO, Me.provider, Me.coverPcBx.Image, e.RowIndex)
                issueBk.ShowDialog()
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_Details_Click(Nothing, Nothing)
        If Authorization.authToken.Equals(String.Empty) Then
            editBtn.Enabled = False
            copiesDataGridView.Columns.Item(2).Visible = False
            copiesDataGridView.Columns.Item(3).Visible = False
        Else
            editBtn.Enabled = True
            copiesDataGridView.Columns.Item(2).Visible = True
            copiesDataGridView.Columns.Item(3).Visible = True
        End If
    End Sub

    Private Sub editBtn_MouseLeave(sender As Object, e As EventArgs) Handles editBtn.MouseLeave
        editBtn.BackColor = Color.Transparent
    End Sub

    Private Sub editBtn_MouseEnter(sender As Object, e As EventArgs) Handles editBtn.MouseEnter
        editBtn.BackColor = Color.Gray
    End Sub

    Private Sub Btn_Details_MouseLeave(sender As Object, e As EventArgs) Handles Details_Btn.MouseLeave
        If DetailsPanel.Visible = False Then
            Me.Details_Btn.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Btn_Details_MouseEnter(sender As Object, e As EventArgs) Handles Details_Btn.MouseEnter
        Me.Details_Btn.BackColor = Color.Gray
    End Sub


    Private Sub Location_Btn_MouseLeave(sender As Object, e As EventArgs) Handles Location_Btn.MouseLeave
        If LocationPage.Visible = False Then
            Me.Location_Btn.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Location_Btn_MouseEnter(sender As Object, e As EventArgs) Handles Location_Btn.MouseEnter
        Me.Location_Btn.BackColor = Color.Gray
    End Sub

    Private Sub MoreInformation_Btn_MouseLeave(sender As Object, e As EventArgs) Handles MoreInformation_Btn.MouseLeave
        If MoreInfoPage.Visible = False Then
            Me.MoreInformation_Btn.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub MoreInformation_Btn_MouseEnter(sender As Object, e As EventArgs) Handles MoreInformation_Btn.MouseEnter
        Me.MoreInformation_Btn.BackColor = Color.Gray
    End Sub

    Private Sub NumberOfBooksNO_Click(sender As Object, e As EventArgs) Handles NumberOfBooksNO.Click
    End Sub

    Private Sub MoreInfoPage_Paint(sender As Object, e As PaintEventArgs) Handles MoreInfoPage.Paint
    End Sub
    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        Me.bkDTO.image = coverPcBx.Image
        Me.adminView.bokkAddBtn.PerformClick()
        Me.adminView.addBookuserCtl.setSelectedBook(Me.bkDTO)
        Me.Close()
    End Sub
    Public Sub setAdminView(ByRef adminView As adminView)
        Me.adminView = adminView
    End Sub
End Class