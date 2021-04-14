
Public Class adminView
    Public viewBookuserCtl As New viewBookUserControl(Me)
    Public addBookuserCtl As New AddBookUserControl(Me)
    Dim recorduserCtl As New recordsUserControl(Me)
    Dim collectionsuserCtl As New collectionsUserControl

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
        recordsBtn.Click, collectionsBtn.Click, signOutBtn.Click

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
            Case signOutBtn.Name
                ' Smooth Exit
                Me.Hide()
                Main.Show()
                Me.Close()
                Authorization.authToken = String.Empty

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
        viewBookuserCtl.initializeResult()
        viewBookuserCtl.setSearch(searchTextBox.Text)
    End Sub



    Private Sub searchTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged

    End Sub
End Class