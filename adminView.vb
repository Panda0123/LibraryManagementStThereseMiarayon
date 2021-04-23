
Public Class adminView
    Public addBookuserCtl As New AddBookUserControl(Me)
    Dim recorduserCtl As New recordsUserControl(Me)
    Dim collectionsuserCtl As New collectionsUserControl
    Dim paginationDTO As New PaginationDTO()
    Public viewBookuserCtl As New viewBookUserControl(Me, Me.paginationDTO)
    Public updateAccFrm As New UpdateAccount
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        backgroundPanel.Controls.Add(addBookuserCtl)
        backgroundPanel.Controls.Add(viewBookuserCtl)
        backgroundPanel.Controls.Add(recorduserCtl)
        backgroundPanel.Controls.Add(collectionsuserCtl)
        viewBookuserCtl.Hide()
        recorduserCtl.Hide()
        addBookuserCtl.Hide()
        collectionsuserCtl.Hide()
    End Sub

    Private Sub adminView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set default user control view
        viewBookBtn.PerformClick()
    End Sub

    Private Sub openUserControl_Click(sender As Object, e As EventArgs) Handles viewBookBtn.Click, bokkAddBtn.Click,
        recordsBtn.Click, collectionsBtn.Click

        '1. Responsive changing of color of LEFT panel
        viewBookBtn.BackColor = Color.FromArgb(225, 231, 237)
        bokkAddBtn.BackColor = Color.FromArgb(225, 231, 237)
        recordsBtn.BackColor = Color.FromArgb(225, 231, 237)
        collectionsBtn.BackColor = Color.FromArgb(225, 231, 237)

        Dim btn As Button = sender

        ' 1.1. This includes the the blue highlight panel on the LEFT side of the button
        btn.BackColor = Color.FromArgb(171, 184, 197)
        highlightPanel.Height = btn.Height
        highlightPanel.Top = btn.Top

        '2. Switching of controls in the RIGHT panel
        Select Case btn.Name
            Case viewBookBtn.Name
                viewBookuserCtl.initializeResult()
                switchPanel(viewBookuserCtl)
            Case bokkAddBtn.Name
                switchPanel(addBookuserCtl)
            Case recordsBtn.Name
                '  User_Acount.WindowState = System.Windows.Forms.FormWindowState.Maximized
                recorduserCtl.loadBorrow()
                switchPanel(recorduserCtl)
            Case collectionsBtn.Name
                switchPanel(collectionsuserCtl)
        End Select
    End Sub

    'Helper sub for switching view controls in the RIGHT panel view
    Sub switchPanel(ByVal userControlPanel As UserControl)
        For Each ctl As Control In backgroundPanel.Controls
            If ctl.Equals(userControlPanel) Then
                ctl.Show()
            Else
                ctl.Hide()
            End If
        Next
    End Sub

    Private Sub searchPcBx_Click(sender As Object, e As EventArgs) Handles searchPcBx.Click
        viewBookuserCtl.setSearch(searchTextBox.Text)
        viewBookuserCtl.initializeResult()
    End Sub

    Private Sub viewBookBtn_Click(sender As Object, e As EventArgs) Handles viewBookBtn.Click, bokkAddBtn.Click
        Dim found As Boolean = False
    End Sub

    Private Sub advanceSearchLinkLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles advanceSearchLinkLbl.LinkClicked
        Dim advSearch = New advanceSearch(paginationDTO, Me)
        advSearch.Show()
    End Sub


    Private Sub UpdateAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        Dim updateAccFrm As New UpdateAccount
        updateAccFrm.ShowDialog()

    End Sub

    Private Sub btnSignout_Click(sender As Object, e As EventArgs) Handles btnSignout.Click
        ' Smooth Exit
        Me.Hide()
        Main.Show()
        Me.Close()
        Authorization.authToken = String.Empty
        Authorization.username = String.Empty
        Authorization.password = String.Empty
    End Sub


    Private Sub searchTextBox_keyPress(sender As Object, e As EventArgs) Handles searchTextBox.KeyPress, searchTextBox.Click
        If searchTextBox.Text.Equals("Search...") Then
            searchTextBox.Text = ""
        End If
    End Sub

    Private Sub searchTextBox_LostFocus(sender As Object, e As EventArgs) Handles searchTextBox.LostFocus
        If searchTextBox.Text.Equals("") Then
            searchTextBox.Text = "Search..."
        End If
    End Sub
End Class