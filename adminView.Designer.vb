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
        Dim TopPanel As System.Windows.Forms.Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminView))
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TitleLogoSearchPanel = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.advanceSearchLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.btn_blk = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.btn_white = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.backgrounPanel = New System.Windows.Forms.Panel()
        Me.bookDisp = New System.Windows.Forms.FlowLayoutPanel()
        Me.LeftSidePanel = New System.Windows.Forms.Panel()
        Me.borrowersBtn = New System.Windows.Forms.Button()
        Me.recordsBtn = New System.Windows.Forms.Button()
        Me.collectionsBtn = New System.Windows.Forms.Button()
        Me.reservationBtn = New System.Windows.Forms.Button()
        Me.bokkAddBtn = New System.Windows.Forms.Button()
        Me.viewBookBtn = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.savePcBx = New System.Windows.Forms.PictureBox()
        Me.cancelPcBx = New System.Windows.Forms.PictureBox()
        Me.addBookBtn = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.shelfTxtBx = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.authorsMNameLbl = New System.Windows.Forms.Label()
        Me.authorsLNameLbl = New System.Windows.Forms.Label()
        Me.authorsNumLbl = New System.Windows.Forms.Label()
        Me.authorsFNameLbl = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.selectedAuthorLbl = New System.Windows.Forms.Label()
        Me.removeAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.updateAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.addAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.getAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.authorNumTxtBx = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.authorLNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.authorMNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.authorFNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.copyrightYearDTPckr = New MetroFramework.Controls.MetroDateTime()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.copyrightNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PublicationInformationPanel = New System.Windows.Forms.Panel()
        Me.publishedDatePicker = New MetroFramework.Controls.MetroDateTime()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.publisherAddrTxtBx = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.publisherNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.classificationCmbBx = New System.Windows.Forms.ComboBox()
        Me.languageTxtBx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.quantityTxtBx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.editionTxtBx = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.isbnTxtBx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.titleTxtBx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImageSummaryPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.removeImgBtn = New System.Windows.Forms.PictureBox()
        Me.bkPicBx = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.summaryRichTxtBx = New System.Windows.Forms.RichTextBox()
        Me.recordsDisplay = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.groupBorrowerDetails = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelPublisher = New System.Windows.Forms.Label()
        Me.labelPubDate = New System.Windows.Forms.Label()
        Me.labelAuthor = New System.Windows.Forms.Label()
        Me.labelLanguage = New System.Windows.Forms.Label()
        Me.textBoxShelfID = New System.Windows.Forms.TextBox()
        Me.textBoxTitle = New System.Windows.Forms.TextBox()
        Me.textBoxPublisher = New System.Windows.Forms.TextBox()
        Me.textBoxPubDate = New System.Windows.Forms.TextBox()
        Me.textBoxLanguage = New System.Windows.Forms.TextBox()
        Me.labelShelfID = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.textBoxStatus = New System.Windows.Forms.TextBox()
        Me.textBoxEdition = New System.Windows.Forms.TextBox()
        Me.textBoxSeries = New System.Windows.Forms.TextBox()
        Me.textBoxISBN = New System.Windows.Forms.TextBox()
        Me.textBoxCategory = New System.Windows.Forms.TextBox()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.labelEdition = New System.Windows.Forms.Label()
        Me.labelVolume = New System.Windows.Forms.Label()
        Me.labelSeries = New System.Windows.Forms.Label()
        Me.labelISBN = New System.Windows.Forms.Label()
        Me.labelCategory = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.buttonBorrow = New System.Windows.Forms.Button()
        Me.textBoxVolume = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.buttonReserve = New System.Windows.Forms.Button()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cover_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Status_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShelfID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complete_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        TopPanel = New System.Windows.Forms.Panel()
        TopPanel.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleLogoSearchPanel.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.backgrounPanel.SuspendLayout()
        Me.LeftSidePanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.savePcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addBookBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PublicationInformationPanel.SuspendLayout()
        Me.ImageSummaryPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.removeImgBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bkPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.recordsDisplay.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.groupBorrowerDetails.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        TopPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TopPanel.BackColor = System.Drawing.Color.White
        TopPanel.Controls.Add(Me.PictureBox4)
        TopPanel.Controls.Add(Me.TitleLogoSearchPanel)
        TopPanel.Controls.Add(Me.PictureBox16)
        TopPanel.Controls.Add(Me.ShapeContainer2)
        TopPanel.Location = New System.Drawing.Point(0, -2)
        TopPanel.Margin = New System.Windows.Forms.Padding(4)
        TopPanel.Name = "TopPanel"
        TopPanel.Size = New System.Drawing.Size(1432, 185)
        TopPanel.TabIndex = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(287, 17)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'TitleLogoSearchPanel
        '
        Me.TitleLogoSearchPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TitleLogoSearchPanel.BackColor = System.Drawing.Color.White
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox8)
        Me.TitleLogoSearchPanel.Controls.Add(Me.searchTextBox)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox9)
        Me.TitleLogoSearchPanel.Controls.Add(Me.Label1)
        Me.TitleLogoSearchPanel.Controls.Add(Me.advanceSearchLinkLbl)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox3)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox2)
        Me.TitleLogoSearchPanel.Controls.Add(Me.PictureBox1)
        Me.TitleLogoSearchPanel.Location = New System.Drawing.Point(480, 5)
        Me.TitleLogoSearchPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleLogoSearchPanel.MaximumSize = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.MinimumSize = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.Name = "TitleLogoSearchPanel"
        Me.TitleLogoSearchPanel.Size = New System.Drawing.Size(620, 169)
        Me.TitleLogoSearchPanel.TabIndex = 1
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.Image = Global.LibraryManagementSystem.My.Resources.Resources.magnifying_glass
        Me.PictureBox8.Location = New System.Drawing.Point(532, 95)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(32, 31)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 12
        Me.PictureBox8.TabStop = False
        '
        'searchTextBox
        '
        Me.searchTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchTextBox.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchTextBox.Location = New System.Drawing.Point(69, 96)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(349, 26)
        Me.searchTextBox.TabIndex = 8
        Me.searchTextBox.Text = "Search..."
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(47, 89)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 74)
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
        Me.advanceSearchLinkLbl.Location = New System.Drawing.Point(219, 127)
        Me.advanceSearchLinkLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.advanceSearchLinkLbl.Name = "advanceSearchLinkLbl"
        Me.advanceSearchLinkLbl.Size = New System.Drawing.Size(156, 33)
        Me.advanceSearchLinkLbl.TabIndex = 11
        Me.advanceSearchLinkLbl.TabStop = True
        Me.advanceSearchLinkLbl.Text = "Advance Search"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(500, 100)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(47, 92)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.PictureBox1.Location = New System.Drawing.Point(47, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox16.Image = Global.LibraryManagementSystem.My.Resources.Resources.AdminIcon
        Me.PictureBox16.Location = New System.Drawing.Point(1316, 14)
        Me.PictureBox16.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(49, 42)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox16.TabIndex = 3
        Me.PictureBox16.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.btn_blk, Me.btn_white})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1432, 185)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'btn_blk
        '
        Me.btn_blk.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_blk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_blk.BorderColor = System.Drawing.Color.White
        Me.btn_blk.CornerRadius = 20
        Me.btn_blk.Location = New System.Drawing.Point(1537, 7)
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
        Me.btn_white.Location = New System.Drawing.Point(1535, 11)
        Me.btn_white.Name = "btn_white"
        Me.btn_white.SelectionColor = System.Drawing.Color.White
        Me.btn_white.Size = New System.Drawing.Size(70, 55)
        '
        'backgrounPanel
        '
        Me.backgrounPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.backgrounPanel.BackColor = System.Drawing.Color.White
        Me.backgrounPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.backgrounPanel.Controls.Add(Me.LeftSidePanel)
        Me.backgrounPanel.Controls.Add(Me.MainPanel)
        Me.backgrounPanel.Location = New System.Drawing.Point(0, 186)
        Me.backgrounPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.backgrounPanel.Name = "backgrounPanel"
        Me.backgrounPanel.Size = New System.Drawing.Size(1653, 1809)
        Me.backgrounPanel.TabIndex = 3
        '
        'bookDisp
        '
        Me.bookDisp.AutoScroll = True
        Me.bookDisp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bookDisp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.bookDisp.Location = New System.Drawing.Point(0, 0)
        Me.bookDisp.Name = "bookDisp"
        Me.bookDisp.Size = New System.Drawing.Size(1340, 1738)
        Me.bookDisp.TabIndex = 6
        Me.bookDisp.WrapContents = False
        '
        'LeftSidePanel
        '
        Me.LeftSidePanel.BackColor = System.Drawing.Color.White
        Me.LeftSidePanel.Controls.Add(Me.borrowersBtn)
        Me.LeftSidePanel.Controls.Add(Me.recordsBtn)
        Me.LeftSidePanel.Controls.Add(Me.collectionsBtn)
        Me.LeftSidePanel.Controls.Add(Me.reservationBtn)
        Me.LeftSidePanel.Controls.Add(Me.bokkAddBtn)
        Me.LeftSidePanel.Controls.Add(Me.viewBookBtn)
        Me.LeftSidePanel.Location = New System.Drawing.Point(17, 6)
        Me.LeftSidePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.LeftSidePanel.Name = "LeftSidePanel"
        Me.LeftSidePanel.Size = New System.Drawing.Size(293, 639)
        Me.LeftSidePanel.TabIndex = 0
        '
        'borrowersBtn
        '
        Me.borrowersBtn.BackColor = System.Drawing.Color.White
        Me.borrowersBtn.FlatAppearance.BorderSize = 0
        Me.borrowersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borrowersBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowersBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_borrow_book_64
        Me.borrowersBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.borrowersBtn.Location = New System.Drawing.Point(10, 148)
        Me.borrowersBtn.Name = "borrowersBtn"
        Me.borrowersBtn.Size = New System.Drawing.Size(264, 74)
        Me.borrowersBtn.TabIndex = 10
        Me.borrowersBtn.Text = " Borrowers"
        Me.borrowersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.borrowersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.borrowersBtn.UseVisualStyleBackColor = False
        '
        'recordsBtn
        '
        Me.recordsBtn.BackColor = System.Drawing.Color.White
        Me.recordsBtn.FlatAppearance.BorderSize = 0
        Me.recordsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recordsBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordsBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.recordsBtn
        Me.recordsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.recordsBtn.Location = New System.Drawing.Point(24, 355)
        Me.recordsBtn.Name = "recordsBtn"
        Me.recordsBtn.Size = New System.Drawing.Size(207, 57)
        Me.recordsBtn.TabIndex = 12
        Me.recordsBtn.Text = "    Records"
        Me.recordsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.recordsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.recordsBtn.UseVisualStyleBackColor = False
        '
        'collectionsBtn
        '
        Me.collectionsBtn.BackColor = System.Drawing.Color.White
        Me.collectionsBtn.FlatAppearance.BorderSize = 0
        Me.collectionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.collectionsBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collectionsBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.bookPng
        Me.collectionsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.collectionsBtn.Location = New System.Drawing.Point(28, 291)
        Me.collectionsBtn.Name = "collectionsBtn"
        Me.collectionsBtn.Size = New System.Drawing.Size(207, 57)
        Me.collectionsBtn.TabIndex = 13
        Me.collectionsBtn.Text = "   Collections"
        Me.collectionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.collectionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.collectionsBtn.UseVisualStyleBackColor = False
        '
        'reservationBtn
        '
        Me.reservationBtn.BackColor = System.Drawing.Color.White
        Me.reservationBtn.FlatAppearance.BorderSize = 0
        Me.reservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reservationBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reservationBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.icons8_reserve_48
        Me.reservationBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reservationBtn.Location = New System.Drawing.Point(18, 228)
        Me.reservationBtn.Name = "reservationBtn"
        Me.reservationBtn.Size = New System.Drawing.Size(226, 57)
        Me.reservationBtn.TabIndex = 11
        Me.reservationBtn.Text = "   Reservations"
        Me.reservationBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.reservationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.reservationBtn.UseVisualStyleBackColor = False
        '
        'bokkAddBtn
        '
        Me.bokkAddBtn.BackColor = System.Drawing.Color.White
        Me.bokkAddBtn.FlatAppearance.BorderSize = 0
        Me.bokkAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bokkAddBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bokkAddBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.addIcon
        Me.bokkAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bokkAddBtn.Location = New System.Drawing.Point(21, 85)
        Me.bokkAddBtn.Name = "bokkAddBtn"
        Me.bokkAddBtn.Size = New System.Drawing.Size(207, 57)
        Me.bokkAddBtn.TabIndex = 9
        Me.bokkAddBtn.Text = "   Add"
        Me.bokkAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bokkAddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bokkAddBtn.UseVisualStyleBackColor = False
        '
        'viewBookBtn
        '
        Me.viewBookBtn.BackColor = System.Drawing.Color.White
        Me.viewBookBtn.FlatAppearance.BorderSize = 0
        Me.viewBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewBookBtn.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewBookBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.bookPng
        Me.viewBookBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.viewBookBtn.Location = New System.Drawing.Point(23, 21)
        Me.viewBookBtn.Name = "viewBookBtn"
        Me.viewBookBtn.Size = New System.Drawing.Size(207, 58)
        Me.viewBookBtn.TabIndex = 8
        Me.viewBookBtn.Text = "   View Book"
        Me.viewBookBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.viewBookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.viewBookBtn.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainPanel.Controls.Add(Me.recordsDisplay)
        Me.MainPanel.Controls.Add(Me.bookDisp)
        Me.MainPanel.Controls.Add(Me.savePcBx)
        Me.MainPanel.Controls.Add(Me.cancelPcBx)
        Me.MainPanel.Controls.Add(Me.addBookBtn)
        Me.MainPanel.Controls.Add(Me.Panel2)
        Me.MainPanel.Controls.Add(Me.ImageSummaryPanel)
        Me.MainPanel.Location = New System.Drawing.Point(318, 6)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1342, 1740)
        Me.MainPanel.TabIndex = 1
        '
        'savePcBx
        '
        Me.savePcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.savePcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.save
        Me.savePcBx.Location = New System.Drawing.Point(586, 1687)
        Me.savePcBx.Margin = New System.Windows.Forms.Padding(4)
        Me.savePcBx.Name = "savePcBx"
        Me.savePcBx.Size = New System.Drawing.Size(193, 50)
        Me.savePcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.savePcBx.TabIndex = 5
        Me.savePcBx.TabStop = False
        Me.savePcBx.Visible = False
        '
        'cancelPcBx
        '
        Me.cancelPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cancelPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.cancel
        Me.cancelPcBx.Location = New System.Drawing.Point(795, 1689)
        Me.cancelPcBx.Margin = New System.Windows.Forms.Padding(4)
        Me.cancelPcBx.Name = "cancelPcBx"
        Me.cancelPcBx.Size = New System.Drawing.Size(347, 50)
        Me.cancelPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancelPcBx.TabIndex = 4
        Me.cancelPcBx.TabStop = False
        '
        'addBookBtn
        '
        Me.addBookBtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addBookBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.addBookBtn
        Me.addBookBtn.Location = New System.Drawing.Point(222, 1689)
        Me.addBookBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addBookBtn.Name = "addBookBtn"
        Me.addBookBtn.Size = New System.Drawing.Size(347, 50)
        Me.addBookBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addBookBtn.TabIndex = 3
        Me.addBookBtn.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.shelfTxtBx)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.PublicationInformationPanel)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.classificationCmbBx)
        Me.Panel2.Controls.Add(Me.languageTxtBx)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.quantityTxtBx)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.editionTxtBx)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.isbnTxtBx)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.titleTxtBx)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(27, 351)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1287, 1326)
        Me.Panel2.TabIndex = 1
        '
        'shelfTxtBx
        '
        Me.shelfTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shelfTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelfTxtBx.ForeColor = System.Drawing.Color.Black
        Me.shelfTxtBx.Location = New System.Drawing.Point(25, 479)
        Me.shelfTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.shelfTxtBx.Name = "shelfTxtBx"
        Me.shelfTxtBx.Size = New System.Drawing.Size(1203, 33)
        Me.shelfTxtBx.TabIndex = 89
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel11)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.selectedAuthorLbl)
        Me.Panel4.Controls.Add(Me.removeAuthorBtn)
        Me.Panel4.Controls.Add(Me.updateAuthorBtn)
        Me.Panel4.Controls.Add(Me.addAuthorBtn)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.getAuthorBtn)
        Me.Panel4.Controls.Add(Me.authorNumTxtBx)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.authorLNameTxtBx)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.authorMNameTxtBx)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.authorFNameTxtBx)
        Me.Panel4.Location = New System.Drawing.Point(27, 961)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1202, 358)
        Me.Panel4.TabIndex = 88
        '
        'Panel11
        '
        Me.Panel11.AutoScroll = True
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.authorsMNameLbl)
        Me.Panel11.Controls.Add(Me.authorsLNameLbl)
        Me.Panel11.Controls.Add(Me.authorsNumLbl)
        Me.Panel11.Controls.Add(Me.authorsFNameLbl)
        Me.Panel11.Location = New System.Drawing.Point(49, 54)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(517, 262)
        Me.Panel11.TabIndex = 102
        '
        'authorsMNameLbl
        '
        Me.authorsMNameLbl.AutoSize = True
        Me.authorsMNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsMNameLbl.Location = New System.Drawing.Point(217, 7)
        Me.authorsMNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.authorsMNameLbl.Name = "authorsMNameLbl"
        Me.authorsMNameLbl.Size = New System.Drawing.Size(44, 29)
        Me.authorsMNameLbl.TabIndex = 100
        Me.authorsMNameLbl.Text = "MN"
        '
        'authorsLNameLbl
        '
        Me.authorsLNameLbl.AutoSize = True
        Me.authorsLNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsLNameLbl.Location = New System.Drawing.Point(351, 7)
        Me.authorsLNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.authorsLNameLbl.Name = "authorsLNameLbl"
        Me.authorsLNameLbl.Size = New System.Drawing.Size(38, 29)
        Me.authorsLNameLbl.TabIndex = 101
        Me.authorsLNameLbl.Text = "LN"
        '
        'authorsNumLbl
        '
        Me.authorsNumLbl.AutoSize = True
        Me.authorsNumLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsNumLbl.Location = New System.Drawing.Point(0, 6)
        Me.authorsNumLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.authorsNumLbl.Name = "authorsNumLbl"
        Me.authorsNumLbl.Size = New System.Drawing.Size(42, 29)
        Me.authorsNumLbl.TabIndex = 98
        Me.authorsNumLbl.Text = "No."
        '
        'authorsFNameLbl
        '
        Me.authorsFNameLbl.AutoSize = True
        Me.authorsFNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsFNameLbl.Location = New System.Drawing.Point(71, 7)
        Me.authorsFNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.authorsFNameLbl.Name = "authorsFNameLbl"
        Me.authorsFNameLbl.Size = New System.Drawing.Size(38, 29)
        Me.authorsFNameLbl.TabIndex = 99
        Me.authorsFNameLbl.Text = "FN"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(713, 22)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(145, 29)
        Me.Label30.TabIndex = 96
        Me.Label30.Text = "Selected Author:"
        '
        'selectedAuthorLbl
        '
        Me.selectedAuthorLbl.AutoSize = True
        Me.selectedAuthorLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedAuthorLbl.Location = New System.Drawing.Point(864, 28)
        Me.selectedAuthorLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.selectedAuthorLbl.Name = "selectedAuthorLbl"
        Me.selectedAuthorLbl.Size = New System.Drawing.Size(48, 20)
        Me.selectedAuthorLbl.TabIndex = 97
        Me.selectedAuthorLbl.Text = "None"
        '
        'removeAuthorBtn
        '
        Me.removeAuthorBtn.Location = New System.Drawing.Point(848, 249)
        Me.removeAuthorBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.removeAuthorBtn.Name = "removeAuthorBtn"
        Me.removeAuthorBtn.Size = New System.Drawing.Size(128, 39)
        Me.removeAuthorBtn.TabIndex = 95
        Me.removeAuthorBtn.Text = "Remove"
        Me.removeAuthorBtn.UseSelectable = True
        '
        'updateAuthorBtn
        '
        Me.updateAuthorBtn.Location = New System.Drawing.Point(848, 295)
        Me.updateAuthorBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.updateAuthorBtn.Name = "updateAuthorBtn"
        Me.updateAuthorBtn.Size = New System.Drawing.Size(128, 39)
        Me.updateAuthorBtn.TabIndex = 94
        Me.updateAuthorBtn.Text = "Update"
        Me.updateAuthorBtn.UseSelectable = True
        '
        'addAuthorBtn
        '
        Me.addAuthorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addAuthorBtn.Location = New System.Drawing.Point(688, 249)
        Me.addAuthorBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addAuthorBtn.Name = "addAuthorBtn"
        Me.addAuthorBtn.Size = New System.Drawing.Size(128, 39)
        Me.addAuthorBtn.TabIndex = 93
        Me.addAuthorBtn.Text = "Add"
        Me.addAuthorBtn.UseSelectable = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(613, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 29)
        Me.Label22.TabIndex = 90
        Me.Label22.Text = "Number"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'getAuthorBtn
        '
        Me.getAuthorBtn.Location = New System.Drawing.Point(688, 295)
        Me.getAuthorBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.getAuthorBtn.Name = "getAuthorBtn"
        Me.getAuthorBtn.Size = New System.Drawing.Size(128, 39)
        Me.getAuthorBtn.TabIndex = 92
        Me.getAuthorBtn.Text = "Get"
        Me.getAuthorBtn.UseSelectable = True
        '
        'authorNumTxtBx
        '
        Me.authorNumTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorNumTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorNumTxtBx.Location = New System.Drawing.Point(701, 194)
        Me.authorNumTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.authorNumTxtBx.Name = "authorNumTxtBx"
        Me.authorNumTxtBx.Size = New System.Drawing.Size(271, 33)
        Me.authorNumTxtBx.TabIndex = 91
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(53, 11)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 29)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Author List"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(595, 154)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 29)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Last Name"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorLNameTxtBx
        '
        Me.authorLNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorLNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorLNameTxtBx.Location = New System.Drawing.Point(701, 150)
        Me.authorLNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.authorLNameTxtBx.Name = "authorLNameTxtBx"
        Me.authorLNameTxtBx.Size = New System.Drawing.Size(271, 33)
        Me.authorLNameTxtBx.TabIndex = 87
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(573, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 29)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Middle Initial"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorMNameTxtBx
        '
        Me.authorMNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorMNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorMNameTxtBx.Location = New System.Drawing.Point(701, 103)
        Me.authorMNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.authorMNameTxtBx.Name = "authorMNameTxtBx"
        Me.authorMNameTxtBx.Size = New System.Drawing.Size(271, 33)
        Me.authorMNameTxtBx.TabIndex = 85
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(589, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 29)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "First Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorFNameTxtBx
        '
        Me.authorFNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorFNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorFNameTxtBx.Location = New System.Drawing.Point(701, 54)
        Me.authorFNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.authorFNameTxtBx.Name = "authorFNameTxtBx"
        Me.authorFNameTxtBx.Size = New System.Drawing.Size(271, 33)
        Me.authorFNameTxtBx.TabIndex = 83
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(23, 928)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 35)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "Authors"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 446)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 32)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Shelf Name/Number"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.copyrightYearDTPckr)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.copyrightNameTxtBx)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Location = New System.Drawing.Point(25, 794)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1202, 109)
        Me.Panel3.TabIndex = 84
        '
        'copyrightYearDTPckr
        '
        Me.copyrightYearDTPckr.CalendarFont = New System.Drawing.Font("Sitka Subheading", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyrightYearDTPckr.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.copyrightYearDTPckr.CustomFormat = "yyyy"
        Me.copyrightYearDTPckr.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.copyrightYearDTPckr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.copyrightYearDTPckr.Location = New System.Drawing.Point(56, 55)
        Me.copyrightYearDTPckr.Margin = New System.Windows.Forms.Padding(4)
        Me.copyrightYearDTPckr.MinimumSize = New System.Drawing.Size(4, 27)
        Me.copyrightYearDTPckr.Name = "copyrightYearDTPckr"
        Me.copyrightYearDTPckr.ShowCheckBox = True
        Me.copyrightYearDTPckr.Size = New System.Drawing.Size(88, 27)
        Me.copyrightYearDTPckr.TabIndex = 88
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(281, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 29)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Name"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'copyrightNameTxtBx
        '
        Me.copyrightNameTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copyrightNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyrightNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.copyrightNameTxtBx.Location = New System.Drawing.Point(287, 55)
        Me.copyrightNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.copyrightNameTxtBx.Name = "copyrightNameTxtBx"
        Me.copyrightNameTxtBx.Size = New System.Drawing.Size(853, 33)
        Me.copyrightNameTxtBx.TabIndex = 85
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(49, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 29)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Year"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 761)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(224, 32)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Copyright Information"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PublicationInformationPanel
        '
        Me.PublicationInformationPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PublicationInformationPanel.BackColor = System.Drawing.Color.White
        Me.PublicationInformationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PublicationInformationPanel.Controls.Add(Me.publishedDatePicker)
        Me.PublicationInformationPanel.Controls.Add(Me.Label12)
        Me.PublicationInformationPanel.Controls.Add(Me.publisherAddrTxtBx)
        Me.PublicationInformationPanel.Controls.Add(Me.Label11)
        Me.PublicationInformationPanel.Controls.Add(Me.publisherNameTxtBx)
        Me.PublicationInformationPanel.Controls.Add(Me.Label10)
        Me.PublicationInformationPanel.Location = New System.Drawing.Point(27, 560)
        Me.PublicationInformationPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.PublicationInformationPanel.Name = "PublicationInformationPanel"
        Me.PublicationInformationPanel.Size = New System.Drawing.Size(1202, 184)
        Me.PublicationInformationPanel.TabIndex = 82
        '
        'publishedDatePicker
        '
        Me.publishedDatePicker.CalendarFont = New System.Drawing.Font("Sitka Subheading", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publishedDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.publishedDatePicker.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.publishedDatePicker.CustomFormat = "MMMM yyyy"
        Me.publishedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.publishedDatePicker.Location = New System.Drawing.Point(55, 55)
        Me.publishedDatePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.publishedDatePicker.MinimumSize = New System.Drawing.Size(4, 30)
        Me.publishedDatePicker.Name = "publishedDatePicker"
        Me.publishedDatePicker.ShowCheckBox = True
        Me.publishedDatePicker.Size = New System.Drawing.Size(185, 30)
        Me.publishedDatePicker.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 29)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Address"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'publisherAddrTxtBx
        '
        Me.publisherAddrTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.publisherAddrTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisherAddrTxtBx.ForeColor = System.Drawing.Color.Black
        Me.publisherAddrTxtBx.Location = New System.Drawing.Point(55, 126)
        Me.publisherAddrTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.publisherAddrTxtBx.Name = "publisherAddrTxtBx"
        Me.publisherAddrTxtBx.Size = New System.Drawing.Size(1084, 33)
        Me.publisherAddrTxtBx.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(281, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 29)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'publisherNameTxtBx
        '
        Me.publisherNameTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.publisherNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisherNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.publisherNameTxtBx.Location = New System.Drawing.Point(287, 55)
        Me.publisherNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.publisherNameTxtBx.Name = "publisherNameTxtBx"
        Me.publisherNameTxtBx.Size = New System.Drawing.Size(852, 33)
        Me.publisherNameTxtBx.TabIndex = 85
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 29)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Published Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 529)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 32)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Publication Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 32)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Classification"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'classificationCmbBx
        '
        Me.classificationCmbBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.classificationCmbBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classificationCmbBx.FormattingEnabled = True
        Me.classificationCmbBx.Location = New System.Drawing.Point(25, 402)
        Me.classificationCmbBx.Margin = New System.Windows.Forms.Padding(4)
        Me.classificationCmbBx.Name = "classificationCmbBx"
        Me.classificationCmbBx.Size = New System.Drawing.Size(1203, 37)
        Me.classificationCmbBx.TabIndex = 79
        '
        'languageTxtBx
        '
        Me.languageTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.languageTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.languageTxtBx.ForeColor = System.Drawing.Color.Black
        Me.languageTxtBx.Location = New System.Drawing.Point(25, 329)
        Me.languageTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.languageTxtBx.Name = "languageTxtBx"
        Me.languageTxtBx.Size = New System.Drawing.Size(1203, 33)
        Me.languageTxtBx.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 32)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Language"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'quantityTxtBx
        '
        Me.quantityTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quantityTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityTxtBx.ForeColor = System.Drawing.Color.Black
        Me.quantityTxtBx.Location = New System.Drawing.Point(25, 258)
        Me.quantityTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.quantityTxtBx.Name = "quantityTxtBx"
        Me.quantityTxtBx.Size = New System.Drawing.Size(1203, 30)
        Me.quantityTxtBx.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 32)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editionTxtBx
        '
        Me.editionTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editionTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editionTxtBx.ForeColor = System.Drawing.Color.Black
        Me.editionTxtBx.Location = New System.Drawing.Point(25, 183)
        Me.editionTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.editionTxtBx.Name = "editionTxtBx"
        Me.editionTxtBx.Size = New System.Drawing.Size(1203, 30)
        Me.editionTxtBx.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 32)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Edition"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'isbnTxtBx
        '
        Me.isbnTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.isbnTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnTxtBx.ForeColor = System.Drawing.Color.Black
        Me.isbnTxtBx.Location = New System.Drawing.Point(25, 113)
        Me.isbnTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.isbnTxtBx.Name = "isbnTxtBx"
        Me.isbnTxtBx.Size = New System.Drawing.Size(1203, 30)
        Me.isbnTxtBx.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 32)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "ISBN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titleTxtBx
        '
        Me.titleTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleTxtBx.ForeColor = System.Drawing.Color.Black
        Me.titleTxtBx.Location = New System.Drawing.Point(25, 39)
        Me.titleTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.titleTxtBx.Name = "titleTxtBx"
        Me.titleTxtBx.Size = New System.Drawing.Size(1203, 33)
        Me.titleTxtBx.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Title"
        '
        'ImageSummaryPanel
        '
        Me.ImageSummaryPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageSummaryPanel.BackColor = System.Drawing.Color.White
        Me.ImageSummaryPanel.Controls.Add(Me.Panel1)
        Me.ImageSummaryPanel.Controls.Add(Me.Label5)
        Me.ImageSummaryPanel.Controls.Add(Me.summaryRichTxtBx)
        Me.ImageSummaryPanel.Location = New System.Drawing.Point(29, 20)
        Me.ImageSummaryPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ImageSummaryPanel.Name = "ImageSummaryPanel"
        Me.ImageSummaryPanel.Size = New System.Drawing.Size(1284, 304)
        Me.ImageSummaryPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.removeImgBtn)
        Me.Panel1.Controls.Add(Me.bkPicBx)
        Me.Panel1.Location = New System.Drawing.Point(24, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 278)
        Me.Panel1.TabIndex = 75
        '
        'removeImgBtn
        '
        Me.removeImgBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeImgBtn.BackColor = System.Drawing.Color.Transparent
        Me.removeImgBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.removeImgBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.x
        Me.removeImgBtn.Location = New System.Drawing.Point(241, 4)
        Me.removeImgBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.removeImgBtn.Name = "removeImgBtn"
        Me.removeImgBtn.Size = New System.Drawing.Size(25, 16)
        Me.removeImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.removeImgBtn.TabIndex = 74
        Me.removeImgBtn.TabStop = False
        '
        'bkPicBx
        '
        Me.bkPicBx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bkPicBx.BackColor = System.Drawing.Color.White
        Me.bkPicBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bkPicBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.default_book
        Me.bkPicBx.Location = New System.Drawing.Point(4, 4)
        Me.bkPicBx.Margin = New System.Windows.Forms.Padding(4)
        Me.bkPicBx.Name = "bkPicBx"
        Me.bkPicBx.Size = New System.Drawing.Size(262, 274)
        Me.bkPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bkPicBx.TabIndex = 0
        Me.bkPicBx.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(345, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 35)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Summary"
        '
        'summaryRichTxtBx
        '
        Me.summaryRichTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.summaryRichTxtBx.BackColor = System.Drawing.Color.White
        Me.summaryRichTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryRichTxtBx.Location = New System.Drawing.Point(351, 38)
        Me.summaryRichTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.summaryRichTxtBx.Name = "summaryRichTxtBx"
        Me.summaryRichTxtBx.Size = New System.Drawing.Size(891, 254)
        Me.summaryRichTxtBx.TabIndex = 1
        Me.summaryRichTxtBx.Text = ""
        '
        'recordsDisplay
        '
        Me.recordsDisplay.Controls.Add(Me.SplitContainer1)
        Me.recordsDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.recordsDisplay.Location = New System.Drawing.Point(0, 0)
        Me.recordsDisplay.Name = "recordsDisplay"
        Me.recordsDisplay.Size = New System.Drawing.Size(1340, 1738)
        Me.recordsDisplay.TabIndex = 7
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1340, 1738)
        Me.SplitContainer1.SplitterDistance = 462
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.groupBorrowerDetails)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1340, 462)
        Me.SplitContainer2.SplitterDistance = 665
        Me.SplitContainer2.TabIndex = 0
        '
        'groupBorrowerDetails
        '
        Me.groupBorrowerDetails.Controls.Add(Me.TextBox23)
        Me.groupBorrowerDetails.Controls.Add(Me.TextBox7)
        Me.groupBorrowerDetails.Controls.Add(Me.TextBox6)
        Me.groupBorrowerDetails.Controls.Add(Me.Label46)
        Me.groupBorrowerDetails.Controls.Add(Me.Label29)
        Me.groupBorrowerDetails.Controls.Add(Me.Label28)
        Me.groupBorrowerDetails.Controls.Add(Me.TextBox5)
        Me.groupBorrowerDetails.Controls.Add(Me.TextBox4)
        Me.groupBorrowerDetails.Controls.Add(Me.TextBox3)
        Me.groupBorrowerDetails.Controls.Add(Me.TextBox2)
        Me.groupBorrowerDetails.Controls.Add(Me.Button1)
        Me.groupBorrowerDetails.Controls.Add(Me.TextBox1)
        Me.groupBorrowerDetails.Controls.Add(Me.Label23)
        Me.groupBorrowerDetails.Controls.Add(Me.Label24)
        Me.groupBorrowerDetails.Controls.Add(Me.Label25)
        Me.groupBorrowerDetails.Controls.Add(Me.Label26)
        Me.groupBorrowerDetails.Controls.Add(Me.Label27)
        Me.groupBorrowerDetails.Controls.Add(Me.PictureBox5)
        Me.groupBorrowerDetails.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBorrowerDetails.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBorrowerDetails.Location = New System.Drawing.Point(0, 0)
        Me.groupBorrowerDetails.Name = "groupBorrowerDetails"
        Me.groupBorrowerDetails.Size = New System.Drawing.Size(665, 478)
        Me.groupBorrowerDetails.TabIndex = 3
        Me.groupBorrowerDetails.TabStop = False
        Me.groupBorrowerDetails.Text = "Borrower Details"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(671, 446)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(663, 404)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Borrow"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82517!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.15618!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.41492!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.37063!))
        Me.TableLayoutPanel1.Controls.Add(Me.labelTitle, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.labelPublisher, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.labelPubDate, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.labelAuthor, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.labelLanguage, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxShelfID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxTitle, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxPublisher, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxPubDate, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxLanguage, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.labelShelfID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label32, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox8, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker1, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePicker2, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxStatus, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxEdition, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxSeries, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxISBN, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxCategory, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.labelStatus, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.labelEdition, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.labelVolume, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.labelSeries, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.labelISBN, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.labelCategory, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.buttonBorrow, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.textBoxVolume, 3, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(657, 398)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'labelTitle
        '
        Me.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelTitle.AutoSize = True
        Me.labelTitle.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.Location = New System.Drawing.Point(92, 45)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(68, 29)
        Me.labelTitle.TabIndex = 2
        Me.labelTitle.Text = "TITLE:"
        '
        'labelPublisher
        '
        Me.labelPublisher.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelPublisher.AutoSize = True
        Me.labelPublisher.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPublisher.Location = New System.Drawing.Point(45, 85)
        Me.labelPublisher.Name = "labelPublisher"
        Me.labelPublisher.Size = New System.Drawing.Size(115, 29)
        Me.labelPublisher.TabIndex = 3
        Me.labelPublisher.Text = "PUBLISHER:"
        '
        'labelPubDate
        '
        Me.labelPubDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelPubDate.AutoSize = True
        Me.labelPubDate.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPubDate.Location = New System.Drawing.Point(37, 120)
        Me.labelPubDate.Name = "labelPubDate"
        Me.labelPubDate.Size = New System.Drawing.Size(123, 40)
        Me.labelPubDate.TabIndex = 4
        Me.labelPubDate.Text = "PUBLISHING DATE:"
        '
        'labelAuthor
        '
        Me.labelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelAuthor.AutoSize = True
        Me.labelAuthor.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelAuthor.Location = New System.Drawing.Point(50, 165)
        Me.labelAuthor.Name = "labelAuthor"
        Me.labelAuthor.Size = New System.Drawing.Size(110, 29)
        Me.labelAuthor.TabIndex = 5
        Me.labelAuthor.Text = "AUTHOR/S:"
        '
        'labelLanguage
        '
        Me.labelLanguage.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelLanguage.AutoSize = True
        Me.labelLanguage.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelLanguage.Location = New System.Drawing.Point(47, 245)
        Me.labelLanguage.Name = "labelLanguage"
        Me.labelLanguage.Size = New System.Drawing.Size(113, 29)
        Me.labelLanguage.TabIndex = 7
        Me.labelLanguage.Text = "LANGUAGE:"
        '
        'textBoxShelfID
        '
        Me.textBoxShelfID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxShelfID.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxShelfID.Location = New System.Drawing.Point(166, 5)
        Me.textBoxShelfID.Name = "textBoxShelfID"
        Me.textBoxShelfID.Size = New System.Drawing.Size(172, 29)
        Me.textBoxShelfID.TabIndex = 12
        '
        'textBoxTitle
        '
        Me.textBoxTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxTitle.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxTitle.Location = New System.Drawing.Point(166, 45)
        Me.textBoxTitle.Name = "textBoxTitle"
        Me.textBoxTitle.ReadOnly = True
        Me.textBoxTitle.Size = New System.Drawing.Size(172, 29)
        Me.textBoxTitle.TabIndex = 13
        '
        'textBoxPublisher
        '
        Me.textBoxPublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxPublisher.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxPublisher.Location = New System.Drawing.Point(166, 85)
        Me.textBoxPublisher.Name = "textBoxPublisher"
        Me.textBoxPublisher.ReadOnly = True
        Me.textBoxPublisher.Size = New System.Drawing.Size(172, 29)
        Me.textBoxPublisher.TabIndex = 14
        '
        'textBoxPubDate
        '
        Me.textBoxPubDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxPubDate.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxPubDate.Location = New System.Drawing.Point(166, 125)
        Me.textBoxPubDate.Name = "textBoxPubDate"
        Me.textBoxPubDate.ReadOnly = True
        Me.textBoxPubDate.Size = New System.Drawing.Size(172, 29)
        Me.textBoxPubDate.TabIndex = 15
        '
        'textBoxLanguage
        '
        Me.textBoxLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxLanguage.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxLanguage.Location = New System.Drawing.Point(166, 245)
        Me.textBoxLanguage.Name = "textBoxLanguage"
        Me.textBoxLanguage.ReadOnly = True
        Me.textBoxLanguage.Size = New System.Drawing.Size(172, 29)
        Me.textBoxLanguage.TabIndex = 17
        '
        'labelShelfID
        '
        Me.labelShelfID.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelShelfID.AutoSize = True
        Me.labelShelfID.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelShelfID.Location = New System.Drawing.Point(64, 5)
        Me.labelShelfID.Name = "labelShelfID"
        Me.labelShelfID.Size = New System.Drawing.Size(96, 29)
        Me.labelShelfID.TabIndex = 29
        Me.labelShelfID.Text = "SHELF ID:"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(30, 325)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(130, 29)
        Me.Label31.TabIndex = 30
        Me.Label31.Text = "ISSUED DATE:"
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(56, 365)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 29)
        Me.Label32.TabIndex = 31
        Me.Label32.Text = "DUE DATE:"
        '
        'TextBox8
        '
        Me.TextBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox8.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(166, 163)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.TextBox8, 2)
        Me.TextBox8.Size = New System.Drawing.Size(172, 74)
        Me.TextBox8.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.SetColumnSpan(Me.DateTimePicker1, 2)
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 325)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(279, 29)
        Me.DateTimePicker1.TabIndex = 33
        '
        'DateTimePicker2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DateTimePicker2, 2)
        Me.DateTimePicker2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(166, 363)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(279, 29)
        Me.DateTimePicker2.TabIndex = 34
        '
        'textBoxStatus
        '
        Me.textBoxStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxStatus.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxStatus.Location = New System.Drawing.Point(465, 245)
        Me.textBoxStatus.Name = "textBoxStatus"
        Me.textBoxStatus.ReadOnly = True
        Me.textBoxStatus.Size = New System.Drawing.Size(189, 29)
        Me.textBoxStatus.TabIndex = 25
        '
        'textBoxEdition
        '
        Me.textBoxEdition.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxEdition.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxEdition.Location = New System.Drawing.Point(465, 205)
        Me.textBoxEdition.Name = "textBoxEdition"
        Me.textBoxEdition.ReadOnly = True
        Me.textBoxEdition.Size = New System.Drawing.Size(189, 29)
        Me.textBoxEdition.TabIndex = 22
        '
        'textBoxSeries
        '
        Me.textBoxSeries.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxSeries.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxSeries.Location = New System.Drawing.Point(465, 125)
        Me.textBoxSeries.Name = "textBoxSeries"
        Me.textBoxSeries.ReadOnly = True
        Me.textBoxSeries.Size = New System.Drawing.Size(189, 29)
        Me.textBoxSeries.TabIndex = 20
        '
        'textBoxISBN
        '
        Me.textBoxISBN.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxISBN.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxISBN.Location = New System.Drawing.Point(465, 85)
        Me.textBoxISBN.Name = "textBoxISBN"
        Me.textBoxISBN.ReadOnly = True
        Me.textBoxISBN.Size = New System.Drawing.Size(189, 29)
        Me.textBoxISBN.TabIndex = 19
        '
        'textBoxCategory
        '
        Me.textBoxCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxCategory.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxCategory.Location = New System.Drawing.Point(465, 45)
        Me.textBoxCategory.Name = "textBoxCategory"
        Me.textBoxCategory.ReadOnly = True
        Me.textBoxCategory.Size = New System.Drawing.Size(189, 29)
        Me.textBoxCategory.TabIndex = 18
        '
        'labelStatus
        '
        Me.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelStatus.AutoSize = True
        Me.labelStatus.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStatus.Location = New System.Drawing.Point(376, 245)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(83, 29)
        Me.labelStatus.TabIndex = 24
        Me.labelStatus.Text = "STATUS:"
        '
        'labelEdition
        '
        Me.labelEdition.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelEdition.AutoSize = True
        Me.labelEdition.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelEdition.Location = New System.Drawing.Point(368, 205)
        Me.labelEdition.Name = "labelEdition"
        Me.labelEdition.Size = New System.Drawing.Size(91, 29)
        Me.labelEdition.TabIndex = 11
        Me.labelEdition.Text = "EDITION:"
        '
        'labelVolume
        '
        Me.labelVolume.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelVolume.AutoSize = True
        Me.labelVolume.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVolume.Location = New System.Drawing.Point(367, 165)
        Me.labelVolume.Name = "labelVolume"
        Me.labelVolume.Size = New System.Drawing.Size(92, 29)
        Me.labelVolume.TabIndex = 10
        Me.labelVolume.Text = "VOLUME:"
        '
        'labelSeries
        '
        Me.labelSeries.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelSeries.AutoSize = True
        Me.labelSeries.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSeries.Location = New System.Drawing.Point(380, 125)
        Me.labelSeries.Name = "labelSeries"
        Me.labelSeries.Size = New System.Drawing.Size(79, 29)
        Me.labelSeries.TabIndex = 9
        Me.labelSeries.Text = "SERIES:"
        '
        'labelISBN
        '
        Me.labelISBN.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelISBN.AutoSize = True
        Me.labelISBN.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelISBN.Location = New System.Drawing.Point(400, 85)
        Me.labelISBN.Name = "labelISBN"
        Me.labelISBN.Size = New System.Drawing.Size(59, 29)
        Me.labelISBN.TabIndex = 8
        Me.labelISBN.Text = "ISBN:"
        '
        'labelCategory
        '
        Me.labelCategory.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.labelCategory.AutoSize = True
        Me.labelCategory.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCategory.Location = New System.Drawing.Point(349, 45)
        Me.labelCategory.Name = "labelCategory"
        Me.labelCategory.Size = New System.Drawing.Size(110, 29)
        Me.labelCategory.TabIndex = 6
        Me.labelCategory.Text = "CATEGORY:"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(344, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 34)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'buttonBorrow
        '
        Me.buttonBorrow.BackColor = System.Drawing.Color.SlateGray
        Me.buttonBorrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonBorrow.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonBorrow.Location = New System.Drawing.Point(465, 323)
        Me.buttonBorrow.Name = "buttonBorrow"
        Me.TableLayoutPanel1.SetRowSpan(Me.buttonBorrow, 2)
        Me.buttonBorrow.Size = New System.Drawing.Size(189, 74)
        Me.buttonBorrow.TabIndex = 36
        Me.buttonBorrow.Text = "BORROW BOOK"
        Me.buttonBorrow.UseVisualStyleBackColor = False
        '
        'textBoxVolume
        '
        Me.textBoxVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxVolume.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxVolume.Location = New System.Drawing.Point(465, 165)
        Me.textBoxVolume.Name = "textBoxVolume"
        Me.textBoxVolume.ReadOnly = True
        Me.textBoxVolume.Size = New System.Drawing.Size(189, 29)
        Me.textBoxVolume.TabIndex = 37
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage2.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(663, 404)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reserve"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82517!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.15618!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.41492!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.37063!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label33, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label34, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label35, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label36, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label37, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox9, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox10, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox11, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox12, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox13, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label38, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label39, 0, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox14, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.DateTimePicker3, 1, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox15, 3, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox16, 3, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox18, 3, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox19, 3, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox20, 3, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label40, 2, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label41, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label42, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label43, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label44, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label45, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Button4, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.buttonReserve, 3, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.TextBox17, 3, 4)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 11
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(657, 398)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(92, 45)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 29)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "TITLE:"
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(45, 85)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(115, 29)
        Me.Label34.TabIndex = 3
        Me.Label34.Text = "PUBLISHER:"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(37, 120)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(123, 40)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "PUBLISHING DATE:"
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(50, 165)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(110, 29)
        Me.Label36.TabIndex = 5
        Me.Label36.Text = "AUTHOR/S:"
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(47, 245)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(113, 29)
        Me.Label37.TabIndex = 7
        Me.Label37.Text = "LANGUAGE:"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(166, 5)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(172, 29)
        Me.TextBox9.TabIndex = 12
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(166, 45)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(172, 29)
        Me.TextBox10.TabIndex = 13
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(166, 85)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(172, 29)
        Me.TextBox11.TabIndex = 14
        '
        'TextBox12
        '
        Me.TextBox12.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox12.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(166, 125)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(172, 29)
        Me.TextBox12.TabIndex = 15
        '
        'TextBox13
        '
        Me.TextBox13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox13.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(166, 245)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(172, 29)
        Me.TextBox13.TabIndex = 17
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(64, 5)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 29)
        Me.Label38.TabIndex = 29
        Me.Label38.Text = "SHELF ID:"
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(15, 325)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(145, 29)
        Me.Label39.TabIndex = 30
        Me.Label39.Text = "RESERVE DATE:"
        '
        'TextBox14
        '
        Me.TextBox14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox14.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(166, 163)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TableLayoutPanel3.SetRowSpan(Me.TextBox14, 2)
        Me.TextBox14.Size = New System.Drawing.Size(172, 74)
        Me.TextBox14.TabIndex = 32
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel3.SetColumnSpan(Me.DateTimePicker3, 2)
        Me.DateTimePicker3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(166, 325)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(293, 29)
        Me.DateTimePicker3.TabIndex = 33
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox15.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(465, 245)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(189, 29)
        Me.TextBox15.TabIndex = 25
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(465, 205)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(189, 29)
        Me.TextBox16.TabIndex = 22
        '
        'TextBox18
        '
        Me.TextBox18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox18.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(465, 125)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(189, 29)
        Me.TextBox18.TabIndex = 20
        '
        'TextBox19
        '
        Me.TextBox19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox19.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(465, 85)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(189, 29)
        Me.TextBox19.TabIndex = 19
        '
        'TextBox20
        '
        Me.TextBox20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox20.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(465, 45)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(189, 29)
        Me.TextBox20.TabIndex = 18
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(376, 245)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(83, 29)
        Me.Label40.TabIndex = 24
        Me.Label40.Text = "STATUS:"
        '
        'Label41
        '
        Me.Label41.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(368, 205)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(91, 29)
        Me.Label41.TabIndex = 11
        Me.Label41.Text = "EDITION:"
        '
        'Label42
        '
        Me.Label42.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(367, 165)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(92, 29)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "VOLUME:"
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(380, 125)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(79, 29)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "SERIES:"
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(400, 85)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(59, 29)
        Me.Label44.TabIndex = 8
        Me.Label44.Text = "ISBN:"
        '
        'Label45
        '
        Me.Label45.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(349, 45)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(110, 29)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "CATEGORY:"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(344, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 34)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'buttonReserve
        '
        Me.buttonReserve.BackColor = System.Drawing.Color.SlateGray
        Me.buttonReserve.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonReserve.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buttonReserve.Location = New System.Drawing.Point(465, 323)
        Me.buttonReserve.Name = "buttonReserve"
        Me.TableLayoutPanel3.SetRowSpan(Me.buttonReserve, 2)
        Me.buttonReserve.Size = New System.Drawing.Size(189, 74)
        Me.buttonReserve.TabIndex = 36
        Me.buttonReserve.Text = "RESERVE BOOK"
        Me.buttonReserve.UseVisualStyleBackColor = False
        '
        'TextBox17
        '
        Me.TextBox17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox17.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(465, 165)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(189, 29)
        Me.TextBox17.TabIndex = 21
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(3, 51)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1333, 1237)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage3.Controls.Add(Me.Panel5)
        Me.TabPage3.Controls.Add(Me.Panel6)
        Me.TabPage3.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1325, 1195)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Borrow List"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.DataGridView1)
        Me.Panel5.Location = New System.Drawing.Point(1, 67)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1324, 655)
        Me.Panel5.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cover_Column, Me.Status_Column, Me.BorrowDate_Column, Me.DueDate_Column, Me.Title_Column, Me.ShelfID_Column, Me.ID_Column, Me.Button_Column})
        Me.DataGridView1.Location = New System.Drawing.Point(1, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1324, 646)
        Me.DataGridView1.TabIndex = 0
        '
        'Cover_Column
        '
        Me.Cover_Column.HeaderText = "Cover"
        Me.Cover_Column.MinimumWidth = 6
        Me.Cover_Column.Name = "Cover_Column"
        Me.Cover_Column.Width = 125
        '
        'Status_Column
        '
        Me.Status_Column.HeaderText = "Status"
        Me.Status_Column.MinimumWidth = 6
        Me.Status_Column.Name = "Status_Column"
        Me.Status_Column.Width = 125
        '
        'BorrowDate_Column
        '
        Me.BorrowDate_Column.HeaderText = "Borrow Date"
        Me.BorrowDate_Column.MinimumWidth = 6
        Me.BorrowDate_Column.Name = "BorrowDate_Column"
        Me.BorrowDate_Column.Width = 125
        '
        'DueDate_Column
        '
        Me.DueDate_Column.HeaderText = "Due Date"
        Me.DueDate_Column.MinimumWidth = 6
        Me.DueDate_Column.Name = "DueDate_Column"
        Me.DueDate_Column.Width = 125
        '
        'Title_Column
        '
        Me.Title_Column.HeaderText = "Title"
        Me.Title_Column.MinimumWidth = 6
        Me.Title_Column.Name = "Title_Column"
        Me.Title_Column.Width = 250
        '
        'ShelfID_Column
        '
        Me.ShelfID_Column.HeaderText = "Shelf ID"
        Me.ShelfID_Column.MinimumWidth = 6
        Me.ShelfID_Column.Name = "ShelfID_Column"
        Me.ShelfID_Column.Width = 125
        '
        'ID_Column
        '
        Me.ID_Column.HeaderText = "ID No."
        Me.ID_Column.MinimumWidth = 6
        Me.ID_Column.Name = "ID_Column"
        Me.ID_Column.Width = 125
        '
        'Button_Column
        '
        Me.Button_Column.HeaderText = "Check In"
        Me.Button_Column.MinimumWidth = 6
        Me.Button_Column.Name = "Button_Column"
        Me.Button_Column.Text = "Check In"
        Me.Button_Column.UseColumnTextForButtonValue = True
        Me.Button_Column.Width = 125
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Controls.Add(Me.TextBox22)
        Me.Panel6.Location = New System.Drawing.Point(1, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(749, 69)
        Me.Panel6.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(317, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 38)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox22
        '
        Me.TextBox22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox22.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.TextBox22.Location = New System.Drawing.Point(42, 20)
        Me.TextBox22.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox22.Multiline = True
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(273, 37)
        Me.TextBox22.TabIndex = 19
        Me.TextBox22.Text = "Search ID number..."
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1325, 1243)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Return List"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage5.Controls.Add(Me.Panel7)
        Me.TabPage5.Controls.Add(Me.Panel8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1325, 1243)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Reserve List"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.DataGridView2)
        Me.Panel7.Location = New System.Drawing.Point(1, 67)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1324, 669)
        Me.Panel7.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn1, Me.ReserveDate_Column, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Complete_Column})
        Me.DataGridView2.Location = New System.Drawing.Point(1, 9)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1325, 646)
        Me.DataGridView2.TabIndex = 0
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Cover"
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'ReserveDate_Column
        '
        Me.ReserveDate_Column.HeaderText = "Reserve Date"
        Me.ReserveDate_Column.MinimumWidth = 6
        Me.ReserveDate_Column.Name = "ReserveDate_Column"
        Me.ReserveDate_Column.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Shelf ID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID No."
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Complete_Column
        '
        Me.Complete_Column.HeaderText = "Complete"
        Me.Complete_Column.MinimumWidth = 6
        Me.Complete_Column.Name = "Complete_Column"
        Me.Complete_Column.Text = "Complete"
        Me.Complete_Column.UseColumnTextForButtonValue = True
        Me.Complete_Column.Width = 125
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Button5)
        Me.Panel8.Controls.Add(Me.TextBox21)
        Me.Panel8.Location = New System.Drawing.Point(1, 1)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(749, 69)
        Me.Panel8.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(317, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 38)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox21
        '
        Me.TextBox21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox21.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.TextBox21.Location = New System.Drawing.Point(42, 20)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox21.Multiline = True
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(273, 37)
        Me.TextBox21.TabIndex = 17
        Me.TextBox21.Text = "Search ID number..."
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(460, 126)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(196, 212)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(-4, 62)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(118, 29)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "ID NUMBER:"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(-10, 102)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(124, 29)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "FIRST NAME:"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(-28, 142)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(142, 29)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "MIDDLE NAME:"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(-3, 182)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 29)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "LAST NAME:"
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(17, 222)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(97, 29)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "ADDRESS:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(152, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 29)
        Me.TextBox1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(318, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(151, 104)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(261, 29)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(151, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(261, 29)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(152, 184)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(260, 29)
        Me.TextBox4.TabIndex = 19
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(151, 224)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(260, 100)
        Me.TextBox5.TabIndex = 19
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(-4, 343)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(113, 29)
        Me.Label28.TabIndex = 20
        Me.Label28.Text = "USER TYPE:"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(-14, 382)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(122, 29)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "YEAR LEVEL:"
        '
        'Label46
        '
        Me.Label46.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(15, 419)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(94, 29)
        Me.Label46.TabIndex = 21
        Me.Label46.Text = "SECTION:"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(151, 345)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(261, 29)
        Me.TextBox6.TabIndex = 22
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(151, 385)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(261, 29)
        Me.TextBox7.TabIndex = 22
        '
        'TextBox23
        '
        Me.TextBox23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox23.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(151, 423)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.ReadOnly = True
        Me.TextBox23.Size = New System.Drawing.Size(261, 29)
        Me.TextBox23.TabIndex = 22
        '
        'adminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1762, 746)
        Me.Controls.Add(Me.backgrounPanel)
        Me.Controls.Add(TopPanel)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1553, 783)
        Me.Name = "adminView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        TopPanel.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleLogoSearchPanel.ResumeLayout(False)
        Me.TitleLogoSearchPanel.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.backgrounPanel.ResumeLayout(False)
        Me.LeftSidePanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        CType(Me.savePcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancelPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addBookBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PublicationInformationPanel.ResumeLayout(False)
        Me.PublicationInformationPanel.PerformLayout()
        Me.ImageSummaryPanel.ResumeLayout(False)
        Me.ImageSummaryPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.removeImgBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bkPicBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.recordsDisplay.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.groupBorrowerDetails.ResumeLayout(False)
        Me.groupBorrowerDetails.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents advanceSearchLinkLbl As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents btn_blk As PowerPacks.RectangleShape
    Friend WithEvents btn_white As PowerPacks.RectangleShape
    Friend WithEvents TitleLogoSearchPanel As Panel
    Friend WithEvents backgrounPanel As Panel
    Friend WithEvents LeftSidePanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents ImageSummaryPanel As Panel
    Friend WithEvents bkPicBx As PictureBox
    Friend WithEvents summaryRichTxtBx As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents titleTxtBx As TextBox
    Friend WithEvents isbnTxtBx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents editionTxtBx As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents quantityTxtBx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents languageTxtBx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents classificationCmbBx As ComboBox
    Friend WithEvents PublicationInformationPanel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents publisherAddrTxtBx As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents publisherNameTxtBx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents copyrightNameTxtBx As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents authorFNameTxtBx As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents authorLNameTxtBx As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents authorMNameTxtBx As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents authorNumTxtBx As TextBox
    Friend WithEvents removeAuthorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents updateAuthorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents addAuthorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents getAuthorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents addBookBtn As PictureBox
    Friend WithEvents cancelPcBx As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents publishedDatePicker As MetroFramework.Controls.MetroDateTime
    Friend WithEvents copyrightYearDTPckr As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label30 As Label
    Friend WithEvents selectedAuthorLbl As Label
    Friend WithEvents authorsNumLbl As Label
    Friend WithEvents authorsLNameLbl As Label
    Friend WithEvents authorsMNameLbl As Label
    Friend WithEvents authorsFNameLbl As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents shelfTxtBx As TextBox
    Friend WithEvents savePcBx As PictureBox
    Friend WithEvents removeImgBtn As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents viewBookBtn As Button
    Friend WithEvents bokkAddBtn As Button
    Friend WithEvents borrowersBtn As Button
    Friend WithEvents reservationBtn As Button
    Friend WithEvents recordsBtn As Button
    Friend WithEvents collectionsBtn As Button
    Friend WithEvents bookDisp As FlowLayoutPanel
    Friend WithEvents recordsDisplay As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents groupBorrowerDetails As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents labelTitle As Label
    Friend WithEvents labelPublisher As Label
    Friend WithEvents labelPubDate As Label
    Friend WithEvents labelAuthor As Label
    Friend WithEvents labelLanguage As Label
    Friend WithEvents textBoxShelfID As TextBox
    Friend WithEvents textBoxTitle As TextBox
    Friend WithEvents textBoxPublisher As TextBox
    Friend WithEvents textBoxPubDate As TextBox
    Friend WithEvents textBoxLanguage As TextBox
    Friend WithEvents labelShelfID As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents textBoxStatus As TextBox
    Friend WithEvents textBoxEdition As TextBox
    Friend WithEvents textBoxSeries As TextBox
    Friend WithEvents textBoxISBN As TextBox
    Friend WithEvents textBoxCategory As TextBox
    Friend WithEvents labelStatus As Label
    Friend WithEvents labelEdition As Label
    Friend WithEvents labelVolume As Label
    Friend WithEvents labelSeries As Label
    Friend WithEvents labelISBN As Label
    Friend WithEvents labelCategory As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents buttonBorrow As Button
    Friend WithEvents textBoxVolume As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents buttonReserve As Button
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cover_Column As DataGridViewImageColumn
    Friend WithEvents Status_Column As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents DueDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents Title_Column As DataGridViewTextBoxColumn
    Friend WithEvents ShelfID_Column As DataGridViewTextBoxColumn
    Friend WithEvents ID_Column As DataGridViewTextBoxColumn
    Friend WithEvents Button_Column As DataGridViewButtonColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ReserveDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Complete_Column As DataGridViewButtonColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
