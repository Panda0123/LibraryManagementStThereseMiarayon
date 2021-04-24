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

        btnFullRowSelect.Image = ImageList1.Images(0)
        bookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        btnSingleSelect.Image = ImageList1.Images(0)
    End Sub

    Private Sub setCollection(ByRef collectionLt As List(Of CollectionDTO))
        bookDataGridView.Rows.Clear()
        For Each item As CollectionDTO In collectionLt
            bookDataGridView.Rows.Add(New String() {item.title, item.isbn, item.edition, item.language, item.classification, item.id})
        Next
    End Sub


    Sub deleteRecord()
        If MessageBox.Show("Are you sure to delete this record : " & bookDataGridView.CurrentRow.Cells(0).Value _
                           & " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Delete code here
            BookController.deleteBookById(bookDataGridView.CurrentRow.Cells(5).Value)
            MessageBox.Show("Deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnRefresh_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deleteRecord()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        collection = BookController.getBookCollection()
        setCollection(collection)
    End Sub

    Private Sub btnMultiSelect_Click(sender As Object, e As EventArgs) Handles btnMultiSelect.Click
        bookDataGridView.MultiSelect = True
        btnMultiSelect.Image = ImageList1.Images(0)
        btnSingleSelect.Image = Nothing
    End Sub

    Private Sub btnSingleSelect_Click(sender As Object, e As EventArgs) Handles btnSingleSelect.Click
        bookDataGridView.MultiSelect = False
        btnMultiSelect.Image = Nothing
        btnSingleSelect.Image = ImageList1.Images(0)
    End Sub

    Private Sub btnFullRowSelect_Click(sender As Object, e As EventArgs) Handles btnFullRowSelect.Click
        btnFullRowSelect.Image = ImageList1.Images(0)
        bookDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        btnCellSelect.Image = Nothing
    End Sub

    Private Sub btnCellSelect_Click(sender As Object, e As EventArgs) Handles btnCellSelect.Click
        btnCellSelect.Image = ImageList1.Images(0)
        bookDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect
        btnFullRowSelect.Image = Nothing
    End Sub
End Class
