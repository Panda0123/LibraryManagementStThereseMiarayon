Public Class collectionsUserControl
    Dim collections As List(Of CollectionDTO)

    Private Sub MyBaseLoad(sender As Object, e As EventArgs) Handles Me.Load
        collections = BookController.getBookCollection()
        setCollection(collections)
    End Sub

    Private Sub setCollection(ByRef collectionsLt As List(Of CollectionDTO))
        bookListView.Items.Clear()

        For Each collection In collectionsLt
            Dim newItem As New ListViewItem(collection.title)
            newItem.SubItems.Add(collection.isbn)
            newItem.SubItems.Add(collection.language)
            newItem.SubItems.Add(collection.classification)
            bookListView.Items.Add(newItem)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sample only
        Dim newItem As New ListViewItem("Sample")
        newItem.SubItems.Add("sample")
        newItem.SubItems.Add("sample")
        newItem.SubItems.Add("sample")
        bookListView.Items.Add(newItem)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ListView1_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles bookListView.ColumnWidthChanging
        e.Cancel = True
        e.NewWidth = bookListView.Columns(e.ColumnIndex).Width
    End Sub


End Class
