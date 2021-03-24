Module utils
    Public authOpen As Boolean = False
    Public pbOpen As Boolean = False
    Public pubOpen As Boolean = False



    'Custiom Animation
    'create an illusinary animation for changing arrow key and drop down

    Public Sub clickAnimation(btnObject As Button, ByRef clicks As Integer)
        If clicks = 1 Then
            btnObject.Image = My.Resources.Polygon_2
        ElseIf clicks = 2 Then
            btnObject.Image = My.Resources.Polygon3
            clicks = 0
        End If
    End Sub

    Public Sub dropDownAnimationNewTitle(panel As Panel, tailObj1 As Button, tailObj2 As Button, tailObj3 As Button)
        Main.Timer1.Start()
        panel.Location = New Point(Main.newTitleBtn.Location.X, Main.newTitleBtn.Location.Y + 55)
        If Not panel.Height = 0 Then
            panel.Height = 0
            Main.authPanel.Location = New Point(Main.authBtn.Location.X, Main.authBtn.Location.Y - 77)
            Main.pbPanel.Location = New Point(Main.pbBtn.Location.X, Main.pbBtn.Location.Y - 77)
            Main.pubPanel.Location = New Point(Main.publisherBtn.Location.X, Main.publisherBtn.Location.Y - 77)
            tailObj1.Location = New Point(tailObj1.Location.X, tailObj1.Location.Y - 127)
            tailObj2.Location = New Point(tailObj2.Location.X, tailObj2.Location.Y - 127)
            tailObj3.Location = New Point(tailObj3.Location.X, tailObj3.Location.Y - 127)
            Main.Timer1.Enabled = False

        End If

    End Sub

    Public Sub dropDownAnimationauthBtn(panel As Panel, tailObj1 As Button, tailObj2 As Button)
        Main.Timer2.Start()
        panel.Location = New Point(Main.authBtn.Location.X, Main.authBtn.Location.Y + 55)
        If Not panel.Height = 0 Then
            panel.Height = 0
            Main.pbPanel.Location = New Point(Main.pbBtn.Location.X, Main.pbBtn.Location.Y - 77)
            Main.pubPanel.Location = New Point(Main.publisherBtn.Location.X, Main.publisherBtn.Location.Y - 77)
            tailObj1.Location = New Point(tailObj1.Location.X, tailObj1.Location.Y - 127)
            tailObj2.Location = New Point(tailObj2.Location.X, tailObj2.Location.Y - 127)
            Main.Timer2.Enabled = False

        End If
        authOpen = True
    End Sub

    Public Sub dropDownAnimationpy(panel As Panel, tailObj1 As Button)
        Main.Timer3.Start()
        panel.Location = New Point(Main.pbBtn.Location.X, Main.pbBtn.Location.Y + 55)
        If Not panel.Height = 0 Then
            panel.Height = 0
            Main.pubPanel.Location = New Point(Main.publisherBtn.Location.X, Main.publisherBtn.Location.Y - 77)
            tailObj1.Location = New Point(tailObj1.Location.X, tailObj1.Location.Y - 127)
            Main.Timer3.Enabled = False
        End If
        pbOpen = True
    End Sub

    Public Sub dropDownAnimationpub(panel As Panel)
        Main.Timer4.Start()
        panel.Location = New Point(Main.publisherBtn.Location.X, Main.publisherBtn.Location.Y + 55)
        If Not panel.Height = 0 Then
            panel.Height = 0
            Main.Timer4.Enabled = False
        End If
        pubOpen = True
    End Sub


End Module
