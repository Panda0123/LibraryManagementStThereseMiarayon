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
        Dim colname As String = borrowListDataGrid.Columns(e.ColumnIndex).Name
        'Dim senderGrid = DirectCast(sender, DataGridView)


        If colname.Equals("CheckIn_Column") Then
            If MsgBox("Do you want to return book?", vbQuestion + vbYesNo, "Check In") = vbYes Then

            Else

            End If
        End If



        'If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
        'If e.ColumnIndex = 8 Then
        'Dim copyId As Integer = borrowListDataGrid.Item("borrowId", e.RowIndex).Value
        'BookController.returnBorrow(copyId)
        'MessageBox.Show("Successfully Check In Borrow.")
        'loadBorrow()
        'adminView.viewBookuserCtl.initializeResult()
        'End If
        'End If
    End Sub

    Private Sub reservationListDataGridView_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) _
                                           Handles reservationListDataGrid.CellContentClick


        Dim colname As String = reservationListDataGrid.Columns(e.ColumnIndex).Name

        If colname.Equals("Complete_Column") Then
            If MsgBox("Do you want to complete reservation?", vbQuestion + vbYesNo, "Complete Reservation") = vbYes Then

            Else

            End If
        End If




        ' Dim senderGrid = DirectCast(sender, DataGridView)
        ' If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
        ' If e.ColumnIndex = 7 Then
        'Dim copyId As Integer = reservationListDataGrid.Item("reservationId", e.RowIndex).Value
        'BookController.deleteReservation(copyId)
        'MessageBox.Show("Successfully Completed Reservation.")
        'loadReserve()
        'adminView.viewBookuserCtl.initializeResult()
        'End If
        'End If
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
        For Each reservation In reserveList
            Dim status As String = "Reserve"
            reservationListDataGrid.Rows.Add({My.Resources.default_book, status, reservation.reservedDate, reservation.title, reservation.bkCpyNum, reservation.userDTO.id, reservation.reservationId})
        Next
        reservationListDataGrid.Refresh()
    End Sub
    Private Sub setDataGrid(ByRef items As List(Of BorrowDTO), ByRef listDataGrid As DataGridView, ByRef isBorrow As Boolean)
        listDataGrid.Rows.Clear()
        Dim status = If(isBorrow, "Borrowed", "Returned")
        For Each item In items
            listDataGrid.Rows.Add({My.Resources.default_book, status, item.issueDate, item.dueDate, item.title, item.bkCpyNum, item.userDTO.id, item.borrowId})
        Next
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
End Class
