Public Class collectionsUserControl



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'sample only
        Dim newItem As New ListViewItem("Sample")
        newItem.SubItems.Add("sample")
        newItem.SubItems.Add("sample")
        newItem.SubItems.Add("sample")
        bookListView.Items.Add(newItem)
    End Sub



    Private Sub ListView1_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles bookListView.ColumnWidthChanging
        e.Cancel = True
        e.NewWidth = bookListView.Columns(e.ColumnIndex).Width
    End Sub


End Class
