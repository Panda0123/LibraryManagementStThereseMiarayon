﻿Imports System.Globalization
Public Class bookControlAdmin

    Private bkDTO As BookDetailsDTO
    Private viewBook As viewBook
    Private issueBook As IssueBook
    Private provider As CultureInfo = CultureInfo.InvariantCulture
    Public imageName As String = ""
    Private adminView As adminView

    Public Sub New(ByRef viewBook As viewBook, ByRef adminView As adminView)
        InitializeComponent()
        Me.viewBook = viewBook
        Me.adminView = adminView

    End Sub

    Public Sub setBkDTO(ByRef bkDTO As BookDetailsDTO)
        Me.bkDTO = bkDTO
        ' Add any initialization after the InitializeComponent() call.
        Dim title = bkDTO.title + If(bkDTO.publishedDate Is Nothing,
                "",
                " (" + Date.ParseExact(bkDTO.publishedDate, "yyyy-MM-dd", provider).Year.ToString() + ")")
        bTitle.Text = title
        'author
        Dim authorsDisplay = String.Empty
        Dim authors = bkDTO.authors
        If authors.Count <> 0 Then
            authorsDisplay = authorsDisplay + authors(0).f_name + " " + authors(0).m_name + " " + authors(0).l_name + " "
            For idx As Integer = 1 To authors.Count - 1
                authorsDisplay = authorsDisplay + ", " + authors(idx).f_name + " " + authors(idx).m_name + " " + authors(idx).l_name + " "
            Next
        End If
        bAuthor.Text = authorsDisplay
        bLanguage.Text = bkDTO.language
        Dim publisher = If(bkDTO.publisherAddress Is Nothing, "", "[" + bkDTO.publisherAddress + "]") + If(bkDTO.publisherName Is Nothing, "", " : " + bkDTO.publisherName)
        ' publisher = publisher + If(bkDTO.copyrightYear = 0, "", vbCrLf + "©" + bkDTO.copyrightYear.ToString) + If(bkDTO.copyrightName Is Nothing, " ", " " + bkDTO.copyrightName)
        bPublisher.Text = publisher
        imageName = bkDTO.imageName
        setCopies()
    End Sub

    Public Sub setCopies()
        If IsNothing(bkDTO.copies) Then
            bkDTO.copies = CopyController.getCopies(bkDTO.bookId)
            bkDTO.copies.Sort(Function(x, y) x.copy_num.CompareTo(y.copy_num))
        End If

        If bkDTO.copies.Any(Function(x) x.status.Equals("Available")) Then
            bStatus.Text = "Available"
            bStatus.ForeColor = Color.Lime
        Else
            bStatus.Text = "Unavailable"
            bStatus.ForeColor = Color.Red
        End If
    End Sub


    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles viewBookLnkLbl.LinkClicked
        viewBook.setBkDTO(Me.bkDTO, Me.coverPcBx.Image, provider, Me, Me.adminView)
        Me.viewBook.ShowDialog()
    End Sub


    Private Sub checkOutLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles checkOutLnkLbl.LinkClicked
        Dim issueBk As New IssueBook(Nothing, Me)
        issueBk.setBookDetailsDTO(Me.bkDTO, provider, Me.coverPcBx.Image, 0, True)
        issueBk.TabControl1.TabPages.Remove(issueBk.TabPage2)
        issueBk.ShowDialog()

    End Sub

    Private Sub reserveLnkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles reserveLnkLbl.LinkClicked
        Dim issueBk As New IssueBook(Nothing, Me)
        issueBk.setBookDetailsDTO(Me.bkDTO, provider, Me.coverPcBx.Image, 0, False)
        issueBk.TabControl1.TabPages.Remove(issueBk.TabPage1)
        issueBk.ShowDialog()
    End Sub

End Class
