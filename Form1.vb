Public Class Form1

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        btn_black.Hide()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btn_white_Click(sender As Object, e As EventArgs) Handles btn_white.MouseHover

        btn_black.Show()
        btn_white.Hide()

    End Sub

    Private Sub btn_black_Click(sender As Object, e As EventArgs) Handles btn_black.MouseLeave

        btn_black.Hide()
        btn_white.Show()

    End Sub


End Class
