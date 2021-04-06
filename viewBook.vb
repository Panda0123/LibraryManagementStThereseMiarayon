Imports System.Globalization

Public Class viewBook
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
        coverPcBx.Image = image
        ' summary
        summaryRchTxtBx.Text = bkDTO.summary
        abstractRichTxtBx.Text = bkDTO.summary

        ' title
        titleLbl.Text = bkDTO.title
        titleSmallLbl.Text = bkDTO.title

        ' authors

        Dim authorsDisplay = String.Empty
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
        'status
        ' TODO: get status

        ' number of Books
        NumberOfBooksNO.Text = bkDTO.quantity

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class