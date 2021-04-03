Public Class viewBookUserControl
    Public adminbookDP As New List(Of bookControlAdmin)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        For i As Integer = 0 To 5
            Dim book As New bookControlAdmin
            adminbookDP.Add(book)
            bookDisplayFlowPanel.Controls.Add(book)
        Next
    End Sub


End Class
