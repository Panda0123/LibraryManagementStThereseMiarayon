﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.leftMainScreenPanel = New System.Windows.Forms.Panel()
        Me.scrollablePanel = New System.Windows.Forms.Panel()
        Me.pubPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.pbPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.authPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.newTitlePanel = New System.Windows.Forms.Panel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.publisherBtn = New System.Windows.Forms.Button()
        Me.pbBtn = New System.Windows.Forms.Button()
        Me.authBtn = New System.Windows.Forms.Button()
        Me.newTitleBtn = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RadioButtonTitle = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAuthor = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNewlyAdded = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPublicationDate = New System.Windows.Forms.RadioButton()
        Me.pictureBoxRectangle = New System.Windows.Forms.PictureBox()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.PageNumLabel = New System.Windows.Forms.Label()
        Me.Button_Back = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel13 = New System.Windows.Forms.LinkLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.upperMainScreenPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.advanceSearchLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.leftMainScreenPanel.SuspendLayout()
        Me.scrollablePanel.SuspendLayout()
        Me.pubPanel.SuspendLayout()
        Me.pbPanel.SuspendLayout()
        Me.authPanel.SuspendLayout()
        Me.newTitlePanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxRectangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
        Me.upperMainScreenPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leftMainScreenPanel
        '
        Me.leftMainScreenPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.leftMainScreenPanel.AutoScroll = True
        Me.leftMainScreenPanel.Controls.Add(Me.scrollablePanel)
        Me.leftMainScreenPanel.Location = New System.Drawing.Point(220, 253)
        Me.leftMainScreenPanel.Name = "leftMainScreenPanel"
        Me.leftMainScreenPanel.Size = New System.Drawing.Size(287, 508)
        Me.leftMainScreenPanel.TabIndex = 11
        '
        'scrollablePanel
        '
        Me.scrollablePanel.Controls.Add(Me.pubPanel)
        Me.scrollablePanel.Controls.Add(Me.pbPanel)
        Me.scrollablePanel.Controls.Add(Me.authPanel)
        Me.scrollablePanel.Controls.Add(Me.newTitlePanel)
        Me.scrollablePanel.Controls.Add(Me.publisherBtn)
        Me.scrollablePanel.Controls.Add(Me.pbBtn)
        Me.scrollablePanel.Controls.Add(Me.authBtn)
        Me.scrollablePanel.Controls.Add(Me.newTitleBtn)
        Me.scrollablePanel.Controls.Add(Me.PictureBox4)
        Me.scrollablePanel.Controls.Add(Me.RadioButtonTitle)
        Me.scrollablePanel.Controls.Add(Me.RadioButtonAuthor)
        Me.scrollablePanel.Controls.Add(Me.RadioButtonNewlyAdded)
        Me.scrollablePanel.Controls.Add(Me.RadioButtonPublicationDate)
        Me.scrollablePanel.Controls.Add(Me.pictureBoxRectangle)
        Me.scrollablePanel.Location = New System.Drawing.Point(2, 0)
        Me.scrollablePanel.Name = "scrollablePanel"
        Me.scrollablePanel.Size = New System.Drawing.Size(265, 700)
        Me.scrollablePanel.TabIndex = 0
        '
        'pubPanel
        '
        Me.pubPanel.Controls.Add(Me.LinkLabel10)
        Me.pubPanel.Controls.Add(Me.LinkLabel11)
        Me.pubPanel.Controls.Add(Me.LinkLabel12)
        Me.pubPanel.Location = New System.Drawing.Point(38, 375)
        Me.pubPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.pubPanel.Name = "pubPanel"
        Me.pubPanel.Size = New System.Drawing.Size(203, 0)
        Me.pubPanel.TabIndex = 17
        '
        'LinkLabel10
        '
        Me.LinkLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel10.AutoSize = True
        Me.LinkLabel10.Location = New System.Drawing.Point(10, -35)
        Me.LinkLabel10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(96, 20)
        Me.LinkLabel10.TabIndex = 2
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "LinkLabel10"
        '
        'LinkLabel11
        '
        Me.LinkLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel11.AutoSize = True
        Me.LinkLabel11.Location = New System.Drawing.Point(10, -13)
        Me.LinkLabel11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(93, 20)
        Me.LinkLabel11.TabIndex = 1
        Me.LinkLabel11.TabStop = True
        Me.LinkLabel11.Text = "LinkLabel11"
        '
        'LinkLabel12
        '
        Me.LinkLabel12.AutoSize = True
        Me.LinkLabel12.Location = New System.Drawing.Point(10, 9)
        Me.LinkLabel12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(95, 20)
        Me.LinkLabel12.TabIndex = 0
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "LinkLabel12"
        '
        'pbPanel
        '
        Me.pbPanel.Controls.Add(Me.LinkLabel7)
        Me.pbPanel.Controls.Add(Me.LinkLabel8)
        Me.pbPanel.Controls.Add(Me.LinkLabel9)
        Me.pbPanel.Location = New System.Drawing.Point(38, 334)
        Me.pbPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.pbPanel.Name = "pbPanel"
        Me.pbPanel.Size = New System.Drawing.Size(203, 0)
        Me.pbPanel.TabIndex = 16
        '
        'LinkLabel7
        '
        Me.LinkLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel7.AutoSize = True
        Me.LinkLabel7.Location = New System.Drawing.Point(10, -35)
        Me.LinkLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(87, 20)
        Me.LinkLabel7.TabIndex = 2
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "LinkLabel7"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel8.AutoSize = True
        Me.LinkLabel8.Location = New System.Drawing.Point(10, -13)
        Me.LinkLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(88, 20)
        Me.LinkLabel8.TabIndex = 1
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "LinkLabel8"
        '
        'LinkLabel9
        '
        Me.LinkLabel9.AutoSize = True
        Me.LinkLabel9.Location = New System.Drawing.Point(10, 9)
        Me.LinkLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(88, 20)
        Me.LinkLabel9.TabIndex = 0
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "LinkLabel9"
        '
        'authPanel
        '
        Me.authPanel.Controls.Add(Me.LinkLabel4)
        Me.authPanel.Controls.Add(Me.LinkLabel5)
        Me.authPanel.Controls.Add(Me.LinkLabel6)
        Me.authPanel.Location = New System.Drawing.Point(38, 287)
        Me.authPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.authPanel.Name = "authPanel"
        Me.authPanel.Size = New System.Drawing.Size(203, 0)
        Me.authPanel.TabIndex = 15
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(10, -35)
        Me.LinkLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(88, 20)
        Me.LinkLabel4.TabIndex = 2
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "LinkLabel4"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(10, -13)
        Me.LinkLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(88, 20)
        Me.LinkLabel5.TabIndex = 1
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "LinkLabel5"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Location = New System.Drawing.Point(10, 9)
        Me.LinkLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(88, 20)
        Me.LinkLabel6.TabIndex = 0
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "LinkLabel6"
        '
        'newTitlePanel
        '
        Me.newTitlePanel.Controls.Add(Me.LinkLabel3)
        Me.newTitlePanel.Controls.Add(Me.LinkLabel2)
        Me.newTitlePanel.Controls.Add(Me.LinkLabel1)
        Me.newTitlePanel.Location = New System.Drawing.Point(38, 250)
        Me.newTitlePanel.Margin = New System.Windows.Forms.Padding(2)
        Me.newTitlePanel.Name = "newTitlePanel"
        Me.newTitlePanel.Size = New System.Drawing.Size(203, 0)
        Me.newTitlePanel.TabIndex = 14
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LinkLabel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(10, 18)
        Me.LinkLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(82, 28)
        Me.LinkLabel3.TabIndex = 0
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Last Year"
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LinkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(10, -14)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(134, 28)
        Me.LinkLabel2.TabIndex = 0
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Last Six Months"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(10, -50)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(155, 28)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Last Three Months"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        '
        'publisherBtn
        '
        Me.publisherBtn.BackColor = System.Drawing.Color.White
        Me.publisherBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.publisherBtn.FlatAppearance.BorderSize = 0
        Me.publisherBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.publisherBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.publisherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.publisherBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisherBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Polygon3
        Me.publisherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.publisherBtn.Location = New System.Drawing.Point(20, 334)
        Me.publisherBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.publisherBtn.Name = "publisherBtn"
        Me.publisherBtn.Size = New System.Drawing.Size(221, 42)
        Me.publisherBtn.TabIndex = 13
        Me.publisherBtn.Text = "Publisher"
        Me.publisherBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.publisherBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.publisherBtn.UseVisualStyleBackColor = False
        '
        'pbBtn
        '
        Me.pbBtn.BackColor = System.Drawing.Color.White
        Me.pbBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.pbBtn.FlatAppearance.BorderSize = 0
        Me.pbBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.pbBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.pbBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pbBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Polygon3
        Me.pbBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.pbBtn.Location = New System.Drawing.Point(20, 287)
        Me.pbBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.pbBtn.Name = "pbBtn"
        Me.pbBtn.Size = New System.Drawing.Size(221, 42)
        Me.pbBtn.TabIndex = 13
        Me.pbBtn.Text = "Publication Year"
        Me.pbBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.pbBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.pbBtn.UseVisualStyleBackColor = False
        '
        'authBtn
        '
        Me.authBtn.BackColor = System.Drawing.Color.White
        Me.authBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.authBtn.FlatAppearance.BorderSize = 0
        Me.authBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.authBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.authBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.authBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Polygon3
        Me.authBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.authBtn.Location = New System.Drawing.Point(20, 246)
        Me.authBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.authBtn.Name = "authBtn"
        Me.authBtn.Size = New System.Drawing.Size(221, 42)
        Me.authBtn.TabIndex = 13
        Me.authBtn.Text = "Author"
        Me.authBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.authBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.authBtn.UseVisualStyleBackColor = False
        '
        'newTitleBtn
        '
        Me.newTitleBtn.BackColor = System.Drawing.Color.White
        Me.newTitleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.newTitleBtn.FlatAppearance.BorderSize = 0
        Me.newTitleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.newTitleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.newTitleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newTitleBtn.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTitleBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Polygon3
        Me.newTitleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.newTitleBtn.Location = New System.Drawing.Point(20, 208)
        Me.newTitleBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.newTitleBtn.Name = "newTitleBtn"
        Me.newTitleBtn.Size = New System.Drawing.Size(221, 42)
        Me.newTitleBtn.TabIndex = 13
        Me.newTitleBtn.Text = "New Titles"
        Me.newTitleBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.newTitleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.newTitleBtn.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(2, 187)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(258, 744)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'RadioButtonTitle
        '
        Me.RadioButtonTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonTitle.AutoSize = True
        Me.RadioButtonTitle.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonTitle.Location = New System.Drawing.Point(20, 123)
        Me.RadioButtonTitle.Name = "RadioButtonTitle"
        Me.RadioButtonTitle.Size = New System.Drawing.Size(133, 34)
        Me.RadioButtonTitle.TabIndex = 11
        Me.RadioButtonTitle.TabStop = True
        Me.RadioButtonTitle.Text = "Sort By Title"
        Me.RadioButtonTitle.UseVisualStyleBackColor = True
        '
        'RadioButtonAuthor
        '
        Me.RadioButtonAuthor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonAuthor.AutoSize = True
        Me.RadioButtonAuthor.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonAuthor.Location = New System.Drawing.Point(20, 83)
        Me.RadioButtonAuthor.Name = "RadioButtonAuthor"
        Me.RadioButtonAuthor.Size = New System.Drawing.Size(154, 34)
        Me.RadioButtonAuthor.TabIndex = 11
        Me.RadioButtonAuthor.TabStop = True
        Me.RadioButtonAuthor.Text = "Sort By Author"
        Me.RadioButtonAuthor.UseVisualStyleBackColor = True
        '
        'RadioButtonNewlyAdded
        '
        Me.RadioButtonNewlyAdded.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonNewlyAdded.AutoSize = True
        Me.RadioButtonNewlyAdded.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonNewlyAdded.Location = New System.Drawing.Point(20, 3)
        Me.RadioButtonNewlyAdded.Name = "RadioButtonNewlyAdded"
        Me.RadioButtonNewlyAdded.Size = New System.Drawing.Size(204, 34)
        Me.RadioButtonNewlyAdded.TabIndex = 11
        Me.RadioButtonNewlyAdded.TabStop = True
        Me.RadioButtonNewlyAdded.Text = "Sort By Newly Added"
        Me.RadioButtonNewlyAdded.UseVisualStyleBackColor = True
        '
        'RadioButtonPublicationDate
        '
        Me.RadioButtonPublicationDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButtonPublicationDate.AutoSize = True
        Me.RadioButtonPublicationDate.Font = New System.Drawing.Font("Sitka Display", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonPublicationDate.Location = New System.Drawing.Point(20, 43)
        Me.RadioButtonPublicationDate.Name = "RadioButtonPublicationDate"
        Me.RadioButtonPublicationDate.Size = New System.Drawing.Size(229, 34)
        Me.RadioButtonPublicationDate.TabIndex = 11
        Me.RadioButtonPublicationDate.TabStop = True
        Me.RadioButtonPublicationDate.Text = "Sort By Publication Date"
        Me.RadioButtonPublicationDate.UseVisualStyleBackColor = True
        '
        'pictureBoxRectangle
        '
        Me.pictureBoxRectangle.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxRectangle.Image = CType(resources.GetObject("pictureBoxRectangle.Image"), System.Drawing.Image)
        Me.pictureBoxRectangle.Location = New System.Drawing.Point(2, 2)
        Me.pictureBoxRectangle.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBoxRectangle.Name = "pictureBoxRectangle"
        Me.pictureBoxRectangle.Size = New System.Drawing.Size(258, 165)
        Me.pictureBoxRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxRectangle.TabIndex = 10
        Me.pictureBoxRectangle.TabStop = False
        '
        'mainPanel
        '
        Me.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mainPanel.Controls.Add(Me.loginBtn)
        Me.mainPanel.Controls.Add(Me.PageNumLabel)
        Me.mainPanel.Controls.Add(Me.Button_Back)
        Me.mainPanel.Controls.Add(Me.LinkLabel13)
        Me.mainPanel.Controls.Add(Me.FlowLayoutPanel1)
        Me.mainPanel.Controls.Add(Me.upperMainScreenPanel)
        Me.mainPanel.Controls.Add(Me.leftMainScreenPanel)
        Me.mainPanel.Controls.Add(Me.ShapeContainer1)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1158, 762)
        Me.mainPanel.TabIndex = 12
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.White
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Sitka Display", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.Location = New System.Drawing.Point(0, 256)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(218, 46)
        Me.loginBtn.TabIndex = 17
        Me.loginBtn.Text = "Log In"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'PageNumLabel
        '
        Me.PageNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PageNumLabel.AutoSize = True
        Me.PageNumLabel.Location = New System.Drawing.Point(822, 728)
        Me.PageNumLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PageNumLabel.Name = "PageNumLabel"
        Me.PageNumLabel.Size = New System.Drawing.Size(53, 20)
        Me.PageNumLabel.TabIndex = 0
        Me.PageNumLabel.Text = "Page 1"
        '
        'Button_Back
        '
        Me.Button_Back.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Button_Back.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button_Back.AutoSize = True
        Me.Button_Back.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Back.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.Button_Back.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Button_Back.Location = New System.Drawing.Point(704, 728)
        Me.Button_Back.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(70, 20)
        Me.Button_Back.TabIndex = 16
        Me.Button_Back.TabStop = True
        Me.Button_Back.Text = "Previous"
        '
        'LinkLabel13
        '
        Me.LinkLabel13.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.LinkLabel13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LinkLabel13.AutoSize = True
        Me.LinkLabel13.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel13.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.LinkLabel13.Location = New System.Drawing.Point(926, 728)
        Me.LinkLabel13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LinkLabel13.Name = "LinkLabel13"
        Me.LinkLabel13.Size = New System.Drawing.Size(43, 20)
        Me.LinkLabel13.TabIndex = 16
        Me.LinkLabel13.TabStop = True
        Me.LinkLabel13.Text = "Next"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(513, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(643, 721)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'upperMainScreenPanel
        '
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox3)
        Me.upperMainScreenPanel.Controls.Add(Me.advanceSearchLinkLbl)
        Me.upperMainScreenPanel.Controls.Add(Me.searchTextBox)
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox2)
        Me.upperMainScreenPanel.Controls.Add(Me.Label1)
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox1)
        Me.upperMainScreenPanel.Location = New System.Drawing.Point(2, 3)
        Me.upperMainScreenPanel.Name = "upperMainScreenPanel"
        Me.upperMainScreenPanel.Size = New System.Drawing.Size(504, 246)
        Me.upperMainScreenPanel.TabIndex = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(454, 150)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'advanceSearchLinkLbl
        '
        Me.advanceSearchLinkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.advanceSearchLinkLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.advanceSearchLinkLbl.BackColor = System.Drawing.Color.Transparent
        Me.advanceSearchLinkLbl.Font = New System.Drawing.Font("Sitka Subheading", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advanceSearchLinkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.advanceSearchLinkLbl.Location = New System.Drawing.Point(178, 203)
        Me.advanceSearchLinkLbl.Name = "advanceSearchLinkLbl"
        Me.advanceSearchLinkLbl.Size = New System.Drawing.Size(143, 28)
        Me.advanceSearchLinkLbl.TabIndex = 7
        Me.advanceSearchLinkLbl.TabStop = True
        Me.advanceSearchLinkLbl.Text = "Advance Search"
        '
        'searchTextBox
        '
        Me.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchTextBox.Font = New System.Drawing.Font("Maiandra GD", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchTextBox.Location = New System.Drawing.Point(28, 155)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(390, 32)
        Me.searchTextBox.TabIndex = 4
        Me.searchTextBox.Text = "Search..."
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 138)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(499, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "St. Therese School of Miarayon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.St__Therese_School_of_Miarayon_logo
        Me.PictureBox1.Location = New System.Drawing.Point(-12, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1, Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1156, 760)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.CornerRadius = 41
        Me.RectangleShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.RectangleShape2.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(-160, 386)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.SelectionColor = System.Drawing.Color.White
        Me.RectangleShape2.Size = New System.Drawing.Size(245, 171)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.CornerRadius = 41
        Me.RectangleShape1.FillColor = System.Drawing.Color.White
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.RectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.BackwardDiagonal
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(156, 393)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.SelectionColor = System.Drawing.Color.White
        Me.RectangleShape1.Size = New System.Drawing.Size(339, 314)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.White
        Me.RectangleShape3.CornerRadius = 41
        Me.RectangleShape3.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.ForwardDiagonal
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(-228, 604)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.SelectionColor = System.Drawing.Color.White
        Me.RectangleShape3.Size = New System.Drawing.Size(339, 314)
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Timer4
        '
        '
        'Main
        '
        Me.AccessibleName = "Panel1_Paint"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1158, 762)
        Me.Controls.Add(Me.mainPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(938, 524)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.leftMainScreenPanel.ResumeLayout(False)
        Me.scrollablePanel.ResumeLayout(False)
        Me.scrollablePanel.PerformLayout()
        Me.pubPanel.ResumeLayout(False)
        Me.pubPanel.PerformLayout()
        Me.pbPanel.ResumeLayout(False)
        Me.pbPanel.PerformLayout()
        Me.authPanel.ResumeLayout(False)
        Me.authPanel.PerformLayout()
        Me.newTitlePanel.ResumeLayout(False)
        Me.newTitlePanel.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxRectangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.upperMainScreenPanel.ResumeLayout(False)
        Me.upperMainScreenPanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leftMainScreenPanel As Panel
    Friend WithEvents scrollablePanel As Panel
    Friend WithEvents RadioButtonTitle As RadioButton
    Friend WithEvents RadioButtonAuthor As RadioButton
    Friend WithEvents RadioButtonNewlyAdded As RadioButton
    Friend WithEvents RadioButtonPublicationDate As RadioButton
    Friend WithEvents pictureBoxRectangle As PictureBox
    Friend WithEvents mainPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents upperMainScreenPanel As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents advanceSearchLinkLbl As LinkLabel
    Friend WithEvents newTitleBtn As Button
    Friend WithEvents publisherBtn As Button
    Friend WithEvents pbBtn As Button
    Friend WithEvents authBtn As Button
    Friend WithEvents newTitlePanel As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents authPanel As Panel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents pbPanel As Panel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents pubPanel As Panel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button_Back As LinkLabel
    Friend WithEvents LinkLabel13 As LinkLabel
    Friend WithEvents PageNumLabel As Label
    Friend WithEvents loginBtn As Button
End Class
