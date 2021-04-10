Public Class collectionsUserControl
    Dim collection As List(Of CollectionDTO)
    Dim checkBoxes As List(Of CheckBox)


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        checkBoxes = New List(Of CheckBox)({CheckBox0, CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5,
                                            CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10,
                                            CheckBox11, CheckBox12, CheckBox13, CheckBox14, CheckBox15,
                                            CheckBox16, CheckBox17, CheckBox18, CheckBox19, CheckBox20,
                                            CheckBox21})
        Debug.WriteLine(checkBoxes.Count)
        For Each checkBox As CheckBox In checkBoxes
            AddHandler checkBox.Click, AddressOf checkBoxHandler
        Next
        CheckBox0.Checked = True
    End Sub
    Private Sub checkBoxHandler()
        If CheckBox0.Checked Then
            setCollection(collection)
            Return
        End If
        Dim checkBoxClassification As New List(Of String)
        For Each checkBox In checkBoxes
            If checkBox.Checked Then
                checkBoxClassification.Add(checkBox.Text)
            End If
        Next
        Dim filteredCollections = collection.FindAll(Function(item) checkBoxClassification.Contains(item.classification))
        setCollection(filteredCollections)
    End Sub
    Private Sub MyBaseLoad(sender As Object, e As EventArgs) Handles Me.Load
        collection = BookController.getBookCollection()
        setCollection(collection)
    End Sub

    Private Sub setCollection(ByRef collectionLt As List(Of CollectionDTO))
        bookListView.Items.Clear()

        For Each item As CollectionDTO In collectionLt
            Dim newItem As New ListViewItem(item.title)
            newItem.SubItems.Add(item.isbn)
            newItem.SubItems.Add(item.language)
            newItem.SubItems.Add(item.classification)
            bookListView.Items.Add(newItem)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
