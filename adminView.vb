
Public Class adminView
    Public viewBookuserCtl As New viewBookUserControl(Me)
    Public addBookuserCtl As New AddBookUserControl(Me)
    Dim recorduserCtl As New recordsUserControl
    Dim collectionsuserCtl As New collectionsUserControl

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

        viewBookPanel.Controls.Add(viewBookuserCtl)
        addBookPanel.Controls.Add(addBookuserCtl)
        recordsPanel.Controls.Add(recorduserCtl)
        collectionsPanel.Controls.Add(collectionsuserCtl)
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

        viewBookPanel.Visible = True
        addBookPanel.Visible = False
        recordsPanel.Visible = False
        collectionsPanel.Visible = False
        Dim btn As Button = sender

        '1.1. This includes the the blue highlight panel on the LEFT side of the button
        btn.BackColor = Color.FromArgb(171, 184, 197)
        highlightPanel.Height = btn.Height
        highlightPanel.Top = btn.Top

        '2. Switching of controls in the RIGHT panel
        Select Case btn.Name
            Case viewBookBtn.Name
                switchPanel(viewBookuserCtl)
            Case bokkAddBtn.Name
                switchPanel(addBookuserCtl)
            Case recordsBtn.Name
                'User_Acount.WindowState = System.Windows.Forms.FormWindowState.Maximized
                switchPanel(recorduserCtl)
            Case collectionsBtn.Name
                switchPanel(collectionsuserCtl)
            Case signOutBtn.Name
                'Smooth Exit
                Me.Hide()
                Main.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub viewBookBtn_Click(sender As Object, e As EventArgs) Handles viewBookBtn.Click
        viewBookPanel.Visible = True
        viewBookuserCtl.initializeResult()
        addBookPanel.Visible = False
        recordsPanel.Visible = False
        collectionsPanel.Visible = False
    'Helper sub for switching view controls in the RIGHT panel view
    Sub switchPanel(ByVal userControlPanel As UserControl)
        backgroundPanel.Controls.Clear()
        backgroundPanel.Controls.Add(userControlPanel)
        userControlPanel.Show()
    End Sub


    Public Sub bokkAddBtn_Click(sender As Object, e As EventArgs) Handles bokkAddBtn.Click
        viewBookPanel.Visible = False
        addBookPanel.Visible = True
        recordsPanel.Visible = False
        collectionsPanel.Visible = False
    End Sub

    Private Sub recordsBtn_Click(sender As Object, e As EventArgs) Handles recordsBtn.Click
        viewBookPanel.Visible = False
        addBookPanel.Visible = False
        recorduserCtl.onLoad(Nothing, Nothing)
        recordsPanel.Visible = True
        collectionsPanel.Visible = False
    End Sub


    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signOutBtn.LinkClicked
        Authorization.authToken = String.Empty
        Main.Show()
        Me.Close()
    End Sub

    Private Sub searchPcBx_Click(sender As Object, e As EventArgs) Handles searchPcBx.Click
        viewBookBtn_Click(Nothing, Nothing)
        viewBookuserCtl.setSearch(searchTextBox.Text)
    End Sub

    Private Sub collectionsPanel_Paint(sender As Object, e As PaintEventArgs) Handles collectionsPanel.Paint
    End Sub

End Class