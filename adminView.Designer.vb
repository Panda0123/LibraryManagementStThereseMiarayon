<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminView
    Inherits System.Windows.Forms.Form

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
        Dim TopPanel As System.Windows.Forms.Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminView))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TitleLogoSearchPanel = New System.Windows.Forms.Panel()
        Me.searchPcBx = New System.Windows.Forms.PictureBox()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.advanceSearchLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btn_blk = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btn_white = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.btnSignout = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.backgroundPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LeftSidePanel = New System.Windows.Forms.Panel()
        Me.highlightPanel = New System.Windows.Forms.Panel()
        Me.recordsBtn = New System.Windows.Forms.Button()
        Me.collectionsBtn = New System.Windows.Forms.Button()
        Me.bokkAddBtn = New System.Windows.Forms.Button()
        Me.viewBookBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        TopPanel = New System.Windows.Forms.Panel()
        TopPanel.SuspendLayout()
        Me.TitleLogoSearchPanel.SuspendLayout()
        CType(Me.searchPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroContextMenu1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.LeftSidePanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        TopPanel.BackColor = System.Drawing.Color.White
        TopPanel.Controls.Add(Me.Panel3)
        TopPanel.Controls.Add(Me.Panel2)
        TopPanel.Controls.Add(Me.TitleLogoSearchPanel)
        TopPanel.Controls.Add(Me.ShapeContainer2)
        TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        TopPanel.Location = New System.Drawing.Point(0, 0)
        TopPanel.Margin = New System.Windows.Forms.Padding(6)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New System.Drawing.Size(1702, 190)
        TopPanel.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1702, 6)
        Me.Panel3.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 178)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1702, 12)
        Me.Panel2.TabIndex = 2
        '
        'TitleLogoSearchPanel
        '
        Me.TitleLogoSearchPanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TitleLogoSearchPanel.BackColor = System.Drawing.Color.White
        Me.TitleLogoSearchPanel.Controls.Add(Me.searchPcBx)
        Me.TitleLogoSearchPanel.Controls.Add(Me.searchTextBox)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox9)
        Me.TitleLogoSearchPanel.Controls.Add(Me.Label1)
        Me.TitleLogoSearchPanel.Controls.Add(Me.advanceSearchLinkLbl)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox3)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox2)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox1)
        Me.TitleLogoSearchPanel.Location = New System.Drawing.Point(442, 17)
        Me.TitleLogoSearchPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.TitleLogoSearchPanel.MaximumSize = New System.Drawing.Size(969, 264)
        Me.TitleLogoSearchPanel.MinimumSize = New System.Drawing.Size(969, 264)
        Me.TitleLogoSearchPanel.Name = "TitleLogoSearchPanel"
        Me.TitleLogoSearchPanel.Size = New System.Drawing.Size(969, 264)
        Me.TitleLogoSearchPanel.TabIndex = 1
        '
        'searchPcBx
        '
        Me.searchPcBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchPcBx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.magnifying_glass
        Me.searchPcBx.Location = New System.Drawing.Point(532, 96)
        Me.searchPcBx.Margin = New System.Windows.Forms.Padding(5)
        Me.searchPcBx.Name = "searchPcBx"
        Me.searchPcBx.Size = New System.Drawing.Size(32, 31)
        Me.searchPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.searchPcBx.TabIndex = 12
        Me.searchPcBx.TabStop = False
        '
        'searchTextBox
        '
        Me.searchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchTextBox.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchTextBox.Location = New System.Drawing.Point(69, 96)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(456, 26)
        Me.searchTextBox.TabIndex = 8
        Me.searchTextBox.Text = "Search..."
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(48, 89)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(536, 48)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 6
        Me.PictureBox9.TabStop = False
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 74)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "St. Therese School of Miarayon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'advanceSearchLinkLbl
        '
        Me.advanceSearchLinkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.advanceSearchLinkLbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.advanceSearchLinkLbl.BackColor = System.Drawing.Color.Transparent
        Me.advanceSearchLinkLbl.Font = New System.Drawing.Font("Sitka Subheading", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advanceSearchLinkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.advanceSearchLinkLbl.Location = New System.Drawing.Point(219, 128)
        Me.advanceSearchLinkLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.advanceSearchLinkLbl.Name = "advanceSearchLinkLbl"
        Me.advanceSearchLinkLbl.Size = New System.Drawing.Size(156, 32)
        Me.advanceSearchLinkLbl.TabIndex = 11
        Me.advanceSearchLinkLbl.TabStop = True
        Me.advanceSearchLinkLbl.Text = "Advance Search"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(500, 100)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(48, 92)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(504, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.St__Therese_School_of_Miarayon_logo
        Me.PictureBox1.Location = New System.Drawing.Point(48, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.btn_blk, Me.btn_white})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1702, 190)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'btn_blk
        '
        Me.btn_blk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_blk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_blk.BorderColor = System.Drawing.Color.White
        Me.btn_blk.CornerRadius = 20
        Me.btn_blk.Location = New System.Drawing.Point(1047, 7)
        Me.btn_blk.Name = "btn_blk"
        Me.btn_blk.SelectionColor = System.Drawing.Color.White
        Me.btn_blk.Size = New System.Drawing.Size(70, 60)
        '
        'btn_white
        '
        Me.btn_white.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_white.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_white.BorderColor = System.Drawing.Color.White
        Me.btn_white.CornerRadius = 20
        Me.btn_white.Location = New System.Drawing.Point(1045, 11)
        Me.btn_white.Name = "btn_white"
        Me.btn_white.SelectionColor = System.Drawing.Color.White
        Me.btn_white.Size = New System.Drawing.Size(70, 55)
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.ContextMenuStrip = Me.MetroContextMenu1
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.LibraryManagementSystem.My.Resources.Resources.AdminIcon
        Me.PictureBox4.Location = New System.Drawing.Point(56, 57)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSignout, Me.UpdateAccountToolStripMenuItem})
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(190, 56)
        '
        'btnSignout
        '
        Me.btnSignout.Image = Global.LibraryManagementSystem.My.Resources.Resources.log_in
        Me.btnSignout.Name = "btnSignout"
        Me.btnSignout.Size = New System.Drawing.Size(189, 26)
        Me.btnSignout.Text = "Sign Out"
        '
        'UpdateAccountToolStripMenuItem
        '
        Me.UpdateAccountToolStripMenuItem.Image = Global.LibraryManagementSystem.My.Resources.Resources.server_storage
        Me.UpdateAccountToolStripMenuItem.Name = "UpdateAccountToolStripMenuItem"
        Me.UpdateAccountToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.UpdateAccountToolStripMenuItem.Text = "Update Account"
        '
        'backgroundPanel
        '
        Me.backgroundPanel.AutoScroll = True
        Me.backgroundPanel.BackColor = System.Drawing.SystemColors.Window
        Me.backgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backgroundPanel.Location = New System.Drawing.Point(0, 190)
        Me.backgroundPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.backgroundPanel.Name = "backgroundPanel"
        Me.backgroundPanel.Size = New System.Drawing.Size(1702, 865)
        Me.backgroundPanel.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.LeftSidePanel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.backgroundPanel)
        Me.SplitContainer1.Panel2.Controls.Add(TopPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(1924, 1055)
        Me.SplitContainer1.SplitterDistance = 217
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 21
        '
        'LeftSidePanel
        '
        Me.LeftSidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.LeftSidePanel.Controls.Add(Me.highlightPanel)
        Me.LeftSidePanel.Controls.Add(Me.recordsBtn)
        Me.LeftSidePanel.Controls.Add(Me.collectionsBtn)
        Me.LeftSidePanel.Controls.Add(Me.bokkAddBtn)
        Me.LeftSidePanel.Controls.Add(Me.viewBookBtn)
        Me.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftSidePanel.Location = New System.Drawing.Point(0, 190)
        Me.LeftSidePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.LeftSidePanel.Name = "LeftSidePanel"
        Me.LeftSidePanel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LeftSidePanel.Size = New System.Drawing.Size(217, 865)
        Me.LeftSidePanel.TabIndex = 1
        '
        'highlightPanel
        '
        Me.highlightPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.highlightPanel.Location = New System.Drawing.Point(0, 0)
        Me.highlightPanel.Margin = New System.Windows.Forms.Padding(5)
        Me.highlightPanel.Name = "highlightPanel"
        Me.highlightPanel.Size = New System.Drawing.Size(10, 91)
        Me.highlightPanel.TabIndex = 0
        '
        'recordsBtn
        '
        Me.recordsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.recordsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.recordsBtn.FlatAppearance.BorderSize = 0
        Me.recordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recordsBtn.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordsBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.contract
        Me.recordsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.recordsBtn.Location = New System.Drawing.Point(10, 273)
        Me.recordsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.recordsBtn.Name = "recordsBtn"
        Me.recordsBtn.Size = New System.Drawing.Size(207, 91)
        Me.recordsBtn.TabIndex = 12
        Me.recordsBtn.Text = " Records"
        Me.recordsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.recordsBtn.UseVisualStyleBackColor = False
        '
        'collectionsBtn
        '
        Me.collectionsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.collectionsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.collectionsBtn.FlatAppearance.BorderSize = 0
        Me.collectionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.collectionsBtn.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collectionsBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.server_storage
        Me.collectionsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.collectionsBtn.Location = New System.Drawing.Point(10, 182)
        Me.collectionsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.collectionsBtn.Name = "collectionsBtn"
        Me.collectionsBtn.Size = New System.Drawing.Size(207, 91)
        Me.collectionsBtn.TabIndex = 13
        Me.collectionsBtn.Text = " Collections"
        Me.collectionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.collectionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.collectionsBtn.UseVisualStyleBackColor = False
        '
        'bokkAddBtn
        '
        Me.bokkAddBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.bokkAddBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.bokkAddBtn.FlatAppearance.BorderSize = 0
        Me.bokkAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bokkAddBtn.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bokkAddBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.add
        Me.bokkAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bokkAddBtn.Location = New System.Drawing.Point(10, 91)
        Me.bokkAddBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.bokkAddBtn.Name = "bokkAddBtn"
        Me.bokkAddBtn.Size = New System.Drawing.Size(207, 91)
        Me.bokkAddBtn.TabIndex = 9
        Me.bokkAddBtn.Text = " Add"
        Me.bokkAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bokkAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bokkAddBtn.UseVisualStyleBackColor = False
        '
        'viewBookBtn
        '
        Me.viewBookBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.viewBookBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.viewBookBtn.FlatAppearance.BorderSize = 0
        Me.viewBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewBookBtn.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewBookBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.Data_View_Details_icon
        Me.viewBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewBookBtn.Location = New System.Drawing.Point(10, 0)
        Me.viewBookBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.viewBookBtn.Name = "viewBookBtn"
        Me.viewBookBtn.Size = New System.Drawing.Size(207, 91)
        Me.viewBookBtn.TabIndex = 8
        Me.viewBookBtn.Text = " View Book"
        Me.viewBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.viewBookBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 190)
        Me.Panel1.TabIndex = 2
        '
        'adminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MinimumSize = New System.Drawing.Size(1918, 1028)
        Me.Name = "adminView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        TopPanel.ResumeLayout(False)
        Me.TitleLogoSearchPanel.ResumeLayout(False)
        Me.TitleLogoSearchPanel.PerformLayout()
        CType(Me.searchPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroContextMenu1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.LeftSidePanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backgroundPanel As Panel
    Friend WithEvents addPcBx As PictureBox
    Friend WithEvents cancelPcBx As PictureBox
    Friend WithEvents savePcBx As PictureBox
    Friend WithEvents TitleLogoSearchPanel As Panel
    Friend WithEvents searchPcBx As PictureBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents advanceSearchLinkLbl As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents btn_blk As PowerPacks.RectangleShape
    Friend WithEvents btn_white As PowerPacks.RectangleShape
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents LeftSidePanel As Panel
    Friend WithEvents recordsBtn As Button
    Friend WithEvents collectionsBtn As Button
    Friend WithEvents bokkAddBtn As Button
    Friend WithEvents viewBookBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents highlightPanel As Panel
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents btnSignout As ToolStripMenuItem
    Friend WithEvents UpdateAccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox4 As PictureBox
End Class
