Public Class advanceSearch
    Private paginationDTO As PaginationDTO

    Public Sub New(ByRef paginationDTO As PaginationDTO)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.paginationDTO = paginationDTO
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub loginBtnLoginForm_Click(sender As Object, e As EventArgs) Handles loginBtnLoginForm.Click
        paginationDTO.searchKey = titleSearch.Text.Trim
        ' TODO: author
        paginationDTO.filterClassification = classificationSearch.Text.Trim
        ' TODO: publisher name
        ' TODO: isbn
        ' TODO: language
        paginationDTO.filterFirstPublicationYear = firstPublicationYear.Text.Trim
        paginationDTO.filterLastPublicationYear = lastPublicationYear.Text.Trim
        ' TODO: empty other filters in paginationDTO and set the Main controls to the current paginationDTO

        Main.setResult()
        Main.updateUIForCurPaginationDTO()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, MyBase.Closed
        Main.empty()
    End Sub

End Class