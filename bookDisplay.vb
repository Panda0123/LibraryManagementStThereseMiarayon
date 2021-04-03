Public Class bookDisplay
    Private Title As String
    Private Author As List(Of String)
    Private img As Image
    Private Langauge As String
    Private Publisher As String
    Private Status As String
    Public imageName As String

    Private Sub bookDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim rm As Resources.ResourceManager
        'rm = New Resources.ResourceManager("LibraryManagementSystem.Resources", System.Reflection.Assembly.GetExecutingAssembly)

        'PictureBox1.Image = rm.GetObject("pic 1")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        viewBook.ShowDialog()
    End Sub


    'Public Sub New(Title As String, author As List(Of String), img As Image, Language As String, Publisher As String, Status As String)

    '    ' This call Is required by the designer.
    '    InitializeComponent()
    '    Me.Title = Title
    '    Me.Author = author
    '    Me.img = img
    '    Me.Langauge = Langauge
    '    Me.Publisher = Publisher
    '    Me.Status = Status
    '    ' Add any initialization after the InitializeComponent() Call.
    'End Sub

End Class
