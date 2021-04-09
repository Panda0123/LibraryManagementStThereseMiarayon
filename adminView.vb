'Imports System.Globalization
Public Class adminView
    Public viewBookuserCtl As New viewBookUserControl(Me)
    Public addBookuserCtl As New AddBookUserControl(Me)
    Dim recorduserCtl As New recordsUserControl
    Dim collectionsuserCtl As New collectionsUserControl

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        viewBookPanel.Controls.Add(viewBookuserCtl)
        addBookPanel.Controls.Add(addBookuserCtl)
        recordsPanel.Controls.Add(recorduserCtl)
        collectionsPanel.Controls.Add(collectionsuserCtl)

        viewBookPanel.Visible = True
        addBookPanel.Visible = False
        recordsPanel.Visible = False
        collectionsPanel.Visible = False
    End Sub

    Private Sub viewBookBtn_Click(sender As Object, e As EventArgs) Handles viewBookBtn.Click
        viewBookPanel.Visible = True
        viewBookuserCtl.initializeResult()
        addBookPanel.Visible = False
        recordsPanel.Visible = False
        collectionsPanel.Visible = False
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

    Private Sub collectionsBtn_Click(sender As Object, e As EventArgs) Handles collectionsBtn.Click
        viewBookPanel.Visible = False
        addBookPanel.Visible = False
        recordsPanel.Visible = False
        collectionsPanel.Visible = True
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