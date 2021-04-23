Public Class recordsUserControl
    Dim borrows As List(Of BorrowDTO)
    Dim returns As List(Of BorrowDTO)
    Dim reservations As List(Of ReservationDTO)
    Dim adminView As adminView
    Private imageNames As New List(Of String)
    Private images As New List(Of Image)

    Public Sub New(ByRef adminView As adminView)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.adminView = adminView
    End Sub

    Private Sub TabControl_Click() Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedIndex = 0 Then
            loadBorrow()
        ElseIf TabControl.SelectedIndex = 1 Then
            loadReturn()
        ElseIf TabControl.SelectedIndex = 2 Then
            loadReserve()
        End If
    End Sub
    Public Sub loadBorrow()
        borrows = BookController.getAllBorrow()
        loadImages(borrows)
        setDataGrid(borrows, borrowListDataGrid, True)
    End Sub
    Private Sub loadReturn()
        returns = BookController.getAllReturn()
        loadImages(returns)
        setDataGrid(returns, returnListDataGrid, False)
    End Sub
    Private Sub loadReserve()
        reservations = BookController.getAllReservation()
        loadImages(reservations)
        setReserve(reservations)
    End Sub

    Private Sub loadImages(ByRef items As List(Of BorrowDTO))
        Dim img As Image
        For Each item In items
            If Not item.imageName.Equals("empty") Then
                If Not imageNames.Contains(item.imageName) Then
                    imageNames.Add(item.imageName)
                    img = ImageController.getImage(item.imageName)
                    item.cover = img
                    images.Add(img)
                Else
                    item.cover = images.Item(imageNames.IndexOf(item.imageName))
                End If
            End If
        Next
    End Sub
    Private Sub loadImages(ByRef items As List(Of ReservationDTO))
        Dim img As Image
        For Each item In items
            If Not item.imageName.Equals("empty") Then
                If Not imageNames.Contains(item.imageName) Then
                    imageNames.Add(item.imageName)
                    img = ImageController.getImage(item.imageName)
                    item.cover = img
                    images.Add(img)
                Else
                    item.cover = images.Item(imageNames.IndexOf(item.imageName))
                End If
            End If
        Next
    End Sub
    Private Sub borrowListDataGridView_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles borrowListDataGrid.CellContentClick
        Dim colname As String = borrowListDataGrid.Columns(e.ColumnIndex).Name
        'Dim senderGrid = DirectCast(sender, DataGridView)


        If colname.Equals("CheckIn_Column") Then
            If MsgBox("Do you want to return book?", vbQuestion + vbYesNo, "Check In") = vbYes Then
                Dim copyId As Integer = borrowListDataGrid.Item("borrowId", e.RowIndex).Value
                BookController.returnBorrow(copyId)
                MessageBox.Show("Successfully Check In Borrow.")
                loadBorrow()
                adminView.viewBookuserCtl.initializeResult()
            Else

            End If
        End If
    End Sub

    Private Sub reservationListDataGridView_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles reservationListDataGrid.CellContentClick


        Dim colname As String = reservationListDataGrid.Columns(e.ColumnIndex).Name

        If colname.Equals("Complete_Column") Then
            If MsgBox("Do you want to complete reservation?", vbQuestion + vbYesNo, "Complete Reservation") = vbYes Then
                Dim copyId As Integer = reservationListDataGrid.Item("reservationId", e.RowIndex).Value
                BookController.deleteReservation(copyId)
                MessageBox.Show("Successfully Completed Reservation.")
                loadReserve()
                adminView.viewBookuserCtl.initializeResult()
            Else

            End If
        End If


    End Sub

    Private Sub searchBorrowOrReturnBtn_Click(sender As Object, e As EventArgs) Handles searchBorrowBtn.Click, searchReturnBtn.Click
        Dim searchKey As String
        Dim listDTO As List(Of BorrowDTO)
        Select Case sender.name
            Case searchBorrowBtn.Name
                searchKey = searchBorrowTxtBx.Text.Trim()
                listDTO = If(searchKey.Equals(""), borrows, borrows.FindAll(Function(ret) ret.userDTO.id.Equals(searchKey)))
                setDataGrid(listDTO, borrowListDataGrid, True)
            Case searchReturnBtn.Name
                searchKey = searchReturnTxtBx.Text.Trim()
                listDTO = If(searchKey.Equals(""), returns, returns.FindAll(Function(ret) ret.userDTO.id.Equals(searchKey)))
                setDataGrid(listDTO, returnListDataGrid, False)
        End Select
    End Sub

    Private Sub searchReservationBtn_Click(sender As Object, e As EventArgs) Handles searchReservationBtn.Click
        Dim searchKey = searchReservationTxtBx.Text.Trim()
        Dim reservationList = If(searchKey.Equals(""), reservations, reservations.FindAll(Function(reservation) reservation.userDTO.id.Equals(searchKey)))
        setReserve(reservationList)
    End Sub
    Private Sub setReserve(ByRef reserveList As List(Of ReservationDTO))
        reservationListDataGrid.Rows.Clear()
        Dim img As Image
        For Each reservation In reserveList
            Dim status As String = "Reserve"
            img = If(reservation.imageName.Equals("empty"), My.Resources.default_book, reservation.cover)
            reservationListDataGrid.Rows.Add({img, status, reservation.reservedDate, reservation.isbn, reservation.title, reservation.edition, reservation.bkCpyNum, reservation.userDTO.id, reservation.reservationId})
        Next
        reservationListDataGrid.Refresh()
    End Sub
    Private Sub setDataGrid(ByRef items As List(Of BorrowDTO), ByRef listDataGrid As DataGridView, ByRef isBorrow As Boolean)
        listDataGrid.Rows.Clear()
        Dim status = If(isBorrow, "Borrowed", "Returned")
        Dim img As Image
        If isBorrow Then
            For Each item In items
                img = If(item.imageName.Equals("empty"), My.Resources.default_book, item.cover)
                listDataGrid.Rows.Add({img, item.issueDate, item.dueDate, item.isbn, item.title, item.edition, item.bkCpyNum, item.userDTO.id, item.borrowId})
            Next
        Else
            For Each item In items
                img = If(item.imageName.Equals("empty"), My.Resources.default_book, item.cover)
                listDataGrid.Rows.Add({img, item.issueDate, item.dueDate, item.returnedDate, item.isbn, item.title, item.edition, item.bkCpyNum, item.userDTO.id, item.borrowId})
            Next
        End If
        listDataGrid.Refresh()
    End Sub

    Private Sub recordsUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        ' Me.Height = Screen.PrimaryScreen.WorkingArea.Height
    End Sub

    Private Sub returnListDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles returnListDataGrid.CellContentClick

        Dim colname As String = returnListDataGrid.Columns(e.ColumnIndex).Name

        If colname.Equals("Ret_UpdateStatus_Column") Then
            If MsgBox("Do you want to update payment status?", vbQuestion + vbYesNo, "Update Payment Status") = vbYes Then

            Else

            End If
        End If
    End Sub

    Private Sub searchBorrowTxtBx_TextChanged(sender As Object, e As EventArgs) Handles searchBorrowTxtBx.KeyPress, searchBorrowTxtBx.Click
        If searchBorrowTxtBx.Text.Equals("Search ID number...") Then
            searchBorrowTxtBx.Text = ""
        End If
    End Sub

    Private Sub searchBorrowTxtBx_LostFocus(sender As Object, e As EventArgs) Handles searchBorrowTxtBx.LostFocus
        If searchBorrowTxtBx.Text.Equals("") Then
            searchBorrowTxtBx.Text = "Search ID number..."
        End If
    End Sub
End Class
