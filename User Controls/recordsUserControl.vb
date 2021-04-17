Public Class recordsUserControl
    Dim borrows As List(Of BorrowDTO)
    Dim returns As List(Of BorrowDTO)
    Dim reservations As List(Of ReservationDTO)
    Dim adminView As adminView

    Public Sub New(ByRef adminView As adminView)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.adminView = adminView
    End Sub

    'Public Sub on_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    loadBorrow()
    'End Sub

    Private Sub TabControl_Click() Handles TabControl.SelectedIndexChanged
        If TabControl.SelectedIndex = 0 Then
            loadBorrow()
        ElseIf TabControl.SelectedIndex = 1 Then
            ' return list
            loadReturn()
        ElseIf TabControl.SelectedIndex = 2 Then
            loadReserve()
        End If
    End Sub
    Public Sub loadBorrow()
        borrows = BookController.getAllBorrow()
        setDataGrid(borrows, borrowListDataGrid, True)
    End Sub
    Private Sub loadReturn()
        returns = BookController.getAllReturn()
        setDataGrid(returns, returnListDataGrid, False)
    End Sub
    Private Sub loadReserve()
        reservations = BookController.getAllReservation()
        setReserve(reservations)
    End Sub
    Private Sub borrowListDataGridView_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles borrowListDataGrid.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = 8 Then
                Dim copyId As Integer = borrowListDataGrid.Item("borrowId", e.RowIndex).Value
                BookController.returnBorrow(copyId)
                MessageBox.Show("Successfully Check In Borrow.")
                loadBorrow()
                adminView.viewBookuserCtl.initializeResult()
            End If
        End If
    End Sub

    Private Sub reservationListDataGridView_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles reservationListDataGrid.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            If e.ColumnIndex = 7 Then
                '  clicked checkin
                Dim copyId As Integer = reservationListDataGrid.Item("reservationId", e.RowIndex).Value
                BookController.deleteReservation(copyId)
                MessageBox.Show("Successfully Completed Reservation.")
                loadReserve()
                adminView.viewBookuserCtl.initializeResult()
            End If
        End If
    End Sub

    Private Sub searchBorrowBtn_Click(sender As Object, e As EventArgs) Handles searchBorrowBtn.Click
        Dim searchKey As String = searchBorrowTxtBx.Text.Trim()
        Dim borrowsList As List(Of BorrowDTO)
        If searchKey.Equals("") Then
            borrowsList = borrows
        Else
            borrowsList = borrows.FindAll(Function(borrow) borrow.userDTO.id.Equals(searchKey))
        End If
        setDataGrid(borrowsList, borrowListDataGrid, True)
    End Sub
    Private Sub searchReturnBtn_Click(sender As Object, e As EventArgs) Handles searchReturnBtn.Click
        Dim searchKey As String = searchReturnTxtBx.Text.Trim()
        Dim returnList As List(Of BorrowDTO)
        If searchKey.Equals("") Then
            returnList = returns
        Else
            returnList = returns.FindAll(Function(ret) ret.userDTO.id.Equals(searchKey))
        End If
        setDataGrid(returnList, returnListDataGrid, False)
    End Sub

    Private Sub searchReservationBtn_Click(sender As Object, e As EventArgs) Handles searchReservationBtn.Click
        Dim searchKey = searchReservationTxtBx.Text.Trim()
        Dim reservationList As List(Of ReservationDTO)
        If searchKey.Equals("") Then
            reservationList = reservations
        Else
            reservationList = reservations.FindAll(Function(reservation) reservation.userDTO.id.Equals(searchKey))
        End If
        setReserve(reservationList)
    End Sub
    'Private Sub setBorrow(ByRef borrowsList As List(Of BorrowDTO))
    '    borrowListDataGrid.Rows.Clear()
    '    For Each borrow In borrowsList
    '        Dim status As String = "Borrowed"
    '        borrowListDataGrid.Rows.Add({My.Resources.default_book, status, borrow.issueDate, borrow.dueDate, borrow.title, borrow.bkCpyNum, borrow.userDTO.id, borrow.borrowId})
    '    Next
    '    borrowListDataGrid.Refresh()
    'End Sub
    Private Sub setReserve(ByRef reserveList As List(Of ReservationDTO))
        reservationListDataGrid.Rows.Clear()
        For Each reservation In reserveList
            Dim status As String = "Reserve"
            reservationListDataGrid.Rows.Add({My.Resources.default_book, status, reservation.reservedDate, reservation.title, reservation.bkCpyNum, reservation.userDTO.id, reservation.reservationId})
        Next
        reservationListDataGrid.Refresh()
    End Sub

    'Private Sub setReturn(ByRef returnList As List(Of ReservationDTO))
    '    returnListDataGrid.Rows.Clear()
    '    For Each ret In returnList
    '        Dim status As String = "Returned"
    '        reservationListDataGrid.Rows.Add({My.Resources.default_book, status, ret.reservedDate, reservation.title, reservation.bkCpyNum, reservation.userDTO.id, reservation.reservationId})
    '    Next
    '    reservationListDataGrid.Refresh()
    'End Sub

    Private Sub setDataGrid(ByRef items As List(Of BorrowDTO), ByRef listDataGrid As DataGridView, ByRef isBorrow As Boolean)
        listDataGrid.Rows.Clear()
        Dim status = If(isBorrow, "Borrowed", "Returned")
        For Each item In items
            listDataGrid.Rows.Add({My.Resources.default_book, status, item.issueDate, item.dueDate, item.title, item.bkCpyNum, item.userDTO.id, item.borrowId})
        Next
        listDataGrid.Refresh()
    End Sub
End Class
