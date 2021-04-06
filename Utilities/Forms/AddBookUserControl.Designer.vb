<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.layoutPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.shelfTxtBx = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
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
        Me.cancelPcBx = New System.Windows.Forms.PictureBox()
        Me.cancelHoverPcBx = New System.Windows.Forms.PictureBox()
        Me.addHoverPcBx = New System.Windows.Forms.PictureBox()
        Me.addPcBx = New System.Windows.Forms.PictureBox()
        Me.savePcBx = New System.Windows.Forms.PictureBox()
        Me.saveHoverPcBx = New System.Windows.Forms.PictureBox()
        Me.selectedAuthorLbl = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.updateAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.removeAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.getAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.addAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.authorNumTxtBx = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.authorLNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.authorMNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.authorFNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.authorsFNameLbl = New System.Windows.Forms.Label()
        Me.authorsNumLbl = New System.Windows.Forms.Label()
        Me.authorsLNameLbl = New System.Windows.Forms.Label()
        Me.authorsMNameLbl = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.layoutPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PublicationInformationPanel.SuspendLayout()
        Me.ImageSummaryPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.removeImgBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bkPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelHoverPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addHoverPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.savePcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saveHoverPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'layoutPanel
        '
        Me.layoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layoutPanel.BackColor = System.Drawing.Color.White
        Me.layoutPanel.Controls.Add(Me.Panel2)
        Me.layoutPanel.Controls.Add(Me.ImageSummaryPanel)
        Me.layoutPanel.Controls.Add(Me.cancelPcBx)
        Me.layoutPanel.Controls.Add(Me.cancelHoverPcBx)
        Me.layoutPanel.Controls.Add(Me.addHoverPcBx)
        Me.layoutPanel.Controls.Add(Me.addPcBx)
        Me.layoutPanel.Controls.Add(Me.savePcBx)
        Me.layoutPanel.Controls.Add(Me.saveHoverPcBx)
        Me.layoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.layoutPanel.Name = "layoutPanel"
        Me.layoutPanel.Size = New System.Drawing.Size(1050, 1444)
        Me.layoutPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel2.Location = New System.Drawing.Point(20, 285)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1010, 1103)
        Me.Panel2.TabIndex = 0
        '
        'shelfTxtBx
        '
        Me.shelfTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shelfTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelfTxtBx.ForeColor = System.Drawing.Color.Black
        Me.shelfTxtBx.Location = New System.Drawing.Point(19, 389)
        Me.shelfTxtBx.Name = "shelfTxtBx"
        Me.shelfTxtBx.Size = New System.Drawing.Size(946, 28)
        Me.shelfTxtBx.TabIndex = 6
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
        Me.Panel4.Location = New System.Drawing.Point(20, 781)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(945, 291)
        Me.Panel4.TabIndex = 88
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(40, 9)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 23)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Author List"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(17, 754)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 28)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "Authors"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 362)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 24)
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
        Me.Panel3.Location = New System.Drawing.Point(19, 645)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(945, 89)
        Me.Panel3.TabIndex = 84
        '
        'copyrightYearDTPckr
        '
        Me.copyrightYearDTPckr.CalendarFont = New System.Drawing.Font("Sitka Subheading", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyrightYearDTPckr.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.copyrightYearDTPckr.CustomFormat = "yyyy"
        Me.copyrightYearDTPckr.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.copyrightYearDTPckr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.copyrightYearDTPckr.Location = New System.Drawing.Point(42, 45)
        Me.copyrightYearDTPckr.MinimumSize = New System.Drawing.Size(0, 25)
        Me.copyrightYearDTPckr.Name = "copyrightYearDTPckr"
        Me.copyrightYearDTPckr.ShowCheckBox = True
        Me.copyrightYearDTPckr.Size = New System.Drawing.Size(67, 25)
        Me.copyrightYearDTPckr.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(211, 22)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 23)
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
        Me.copyrightNameTxtBx.Location = New System.Drawing.Point(215, 45)
        Me.copyrightNameTxtBx.Name = "copyrightNameTxtBx"
        Me.copyrightNameTxtBx.Size = New System.Drawing.Size(684, 28)
        Me.copyrightNameTxtBx.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(37, 22)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 23)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Year"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 618)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(176, 24)
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
        Me.PublicationInformationPanel.Location = New System.Drawing.Point(20, 455)
        Me.PublicationInformationPanel.Name = "PublicationInformationPanel"
        Me.PublicationInformationPanel.Size = New System.Drawing.Size(945, 150)
        Me.PublicationInformationPanel.TabIndex = 82
        '
        'publishedDatePicker
        '
        Me.publishedDatePicker.CalendarFont = New System.Drawing.Font("Sitka Subheading", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publishedDatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.publishedDatePicker.CalendarTrailingForeColor = System.Drawing.Color.Black
        Me.publishedDatePicker.CustomFormat = "MMMM yyyy"
        Me.publishedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.publishedDatePicker.Location = New System.Drawing.Point(41, 45)
        Me.publishedDatePicker.MinimumSize = New System.Drawing.Size(0, 29)
        Me.publishedDatePicker.Name = "publishedDatePicker"
        Me.publishedDatePicker.ShowCheckBox = True
        Me.publishedDatePicker.Size = New System.Drawing.Size(140, 29)
        Me.publishedDatePicker.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 79)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 23)
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
        Me.publisherAddrTxtBx.Location = New System.Drawing.Point(41, 102)
        Me.publisherAddrTxtBx.Name = "publisherAddrTxtBx"
        Me.publisherAddrTxtBx.Size = New System.Drawing.Size(857, 28)
        Me.publisherAddrTxtBx.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(211, 22)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 23)
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
        Me.publisherNameTxtBx.Location = New System.Drawing.Point(215, 45)
        Me.publisherNameTxtBx.Name = "publisherNameTxtBx"
        Me.publisherNameTxtBx.Size = New System.Drawing.Size(683, 28)
        Me.publisherNameTxtBx.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 23)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Published Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 430)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 24)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Publication Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 300)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 24)
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
        Me.classificationCmbBx.Location = New System.Drawing.Point(19, 327)
        Me.classificationCmbBx.Name = "classificationCmbBx"
        Me.classificationCmbBx.Size = New System.Drawing.Size(946, 31)
        Me.classificationCmbBx.TabIndex = 5
        '
        'languageTxtBx
        '
        Me.languageTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.languageTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.languageTxtBx.ForeColor = System.Drawing.Color.Black
        Me.languageTxtBx.Location = New System.Drawing.Point(19, 267)
        Me.languageTxtBx.Name = "languageTxtBx"
        Me.languageTxtBx.Size = New System.Drawing.Size(946, 28)
        Me.languageTxtBx.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 243)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
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
        Me.quantityTxtBx.Location = New System.Drawing.Point(19, 210)
        Me.quantityTxtBx.Name = "quantityTxtBx"
        Me.quantityTxtBx.Size = New System.Drawing.Size(946, 26)
        Me.quantityTxtBx.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
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
        Me.editionTxtBx.Location = New System.Drawing.Point(19, 149)
        Me.editionTxtBx.Name = "editionTxtBx"
        Me.editionTxtBx.Size = New System.Drawing.Size(946, 26)
        Me.editionTxtBx.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 126)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 24)
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
        Me.isbnTxtBx.Location = New System.Drawing.Point(19, 92)
        Me.isbnTxtBx.Name = "isbnTxtBx"
        Me.isbnTxtBx.Size = New System.Drawing.Size(946, 26)
        Me.isbnTxtBx.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 24)
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
        Me.titleTxtBx.Location = New System.Drawing.Point(19, 32)
        Me.titleTxtBx.Name = "titleTxtBx"
        Me.titleTxtBx.Size = New System.Drawing.Size(946, 28)
        Me.titleTxtBx.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 24)
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
        Me.ImageSummaryPanel.Location = New System.Drawing.Point(22, 16)
        Me.ImageSummaryPanel.Name = "ImageSummaryPanel"
        Me.ImageSummaryPanel.Size = New System.Drawing.Size(1008, 247)
        Me.ImageSummaryPanel.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.removeImgBtn)
        Me.Panel1.Controls.Add(Me.bkPicBx)
        Me.Panel1.Location = New System.Drawing.Point(18, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 226)
        Me.Panel1.TabIndex = 0
        '
        'removeImgBtn
        '
        Me.removeImgBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeImgBtn.BackColor = System.Drawing.Color.Transparent
        Me.removeImgBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.removeImgBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.x
        Me.removeImgBtn.Location = New System.Drawing.Point(181, 3)
        Me.removeImgBtn.Name = "removeImgBtn"
        Me.removeImgBtn.Size = New System.Drawing.Size(19, 13)
        Me.removeImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.removeImgBtn.TabIndex = 74
        Me.removeImgBtn.TabStop = False
        Me.removeImgBtn.Visible = False
        '
        'bkPicBx
        '
        Me.bkPicBx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bkPicBx.BackColor = System.Drawing.Color.White
        Me.bkPicBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bkPicBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.default_book
        Me.bkPicBx.Location = New System.Drawing.Point(3, 3)
        Me.bkPicBx.Name = "bkPicBx"
        Me.bkPicBx.Size = New System.Drawing.Size(197, 223)
        Me.bkPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bkPicBx.TabIndex = 0
        Me.bkPicBx.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(259, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 28)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Summary"
        '
        'summaryRichTxtBx
        '
        Me.summaryRichTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.summaryRichTxtBx.BackColor = System.Drawing.Color.White
        Me.summaryRichTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summaryRichTxtBx.Location = New System.Drawing.Point(263, 31)
        Me.summaryRichTxtBx.Name = "summaryRichTxtBx"
        Me.summaryRichTxtBx.Size = New System.Drawing.Size(714, 207)
        Me.summaryRichTxtBx.TabIndex = 1
        Me.summaryRichTxtBx.Text = ""
        '
        'cancelPcBx
        '
        Me.cancelPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cancelPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.cancel
        Me.cancelPcBx.Location = New System.Drawing.Point(619, 1403)
        Me.cancelPcBx.Name = "cancelPcBx"
        Me.cancelPcBx.Size = New System.Drawing.Size(260, 41)
        Me.cancelPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancelPcBx.TabIndex = 4
        Me.cancelPcBx.TabStop = False
        '
        'cancelHoverPcBx
        '
        Me.cancelHoverPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cancelHoverPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.canceHover
        Me.cancelHoverPcBx.Location = New System.Drawing.Point(619, 1403)
        Me.cancelHoverPcBx.Name = "cancelHoverPcBx"
        Me.cancelHoverPcBx.Size = New System.Drawing.Size(260, 41)
        Me.cancelHoverPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancelHoverPcBx.TabIndex = 5
        Me.cancelHoverPcBx.TabStop = False
        Me.cancelHoverPcBx.Visible = False
        '
        'addHoverPcBx
        '
        Me.addHoverPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addHoverPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.addHover
        Me.addHoverPcBx.Location = New System.Drawing.Point(190, 1403)
        Me.addHoverPcBx.Name = "addHoverPcBx"
        Me.addHoverPcBx.Size = New System.Drawing.Size(260, 41)
        Me.addHoverPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addHoverPcBx.TabIndex = 4
        Me.addHoverPcBx.TabStop = False
        Me.addHoverPcBx.Visible = False
        '
        'addPcBx
        '
        Me.addPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.addBookBtn
        Me.addPcBx.Location = New System.Drawing.Point(190, 1403)
        Me.addPcBx.Name = "addPcBx"
        Me.addPcBx.Size = New System.Drawing.Size(260, 41)
        Me.addPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addPcBx.TabIndex = 3
        Me.addPcBx.TabStop = False
        '
        'savePcBx
        '
        Me.savePcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.savePcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.save
        Me.savePcBx.Location = New System.Drawing.Point(190, 1403)
        Me.savePcBx.Name = "savePcBx"
        Me.savePcBx.Size = New System.Drawing.Size(260, 41)
        Me.savePcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.savePcBx.TabIndex = 5
        Me.savePcBx.TabStop = False
        Me.savePcBx.Visible = False
        '
        'saveHoverPcBx
        '
        Me.saveHoverPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.saveHoverPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.save2Hover
        Me.saveHoverPcBx.Location = New System.Drawing.Point(190, 1403)
        Me.saveHoverPcBx.Name = "saveHoverPcBx"
        Me.saveHoverPcBx.Size = New System.Drawing.Size(260, 41)
        Me.saveHoverPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.saveHoverPcBx.TabIndex = 6
        Me.saveHoverPcBx.TabStop = False
        Me.saveHoverPcBx.Visible = False
        '
        'selectedAuthorLbl
        '
        Me.selectedAuthorLbl.AutoSize = True
        Me.selectedAuthorLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedAuthorLbl.Location = New System.Drawing.Point(648, 23)
        Me.selectedAuthorLbl.Name = "selectedAuthorLbl"
        Me.selectedAuthorLbl.Size = New System.Drawing.Size(41, 16)
        Me.selectedAuthorLbl.TabIndex = 97
        Me.selectedAuthorLbl.Text = "None"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(535, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 23)
        Me.Label30.TabIndex = 96
        Me.Label30.Text = "Selected Author:"
        '
        'updateAuthorBtn
        '
        Me.updateAuthorBtn.Location = New System.Drawing.Point(636, 240)
        Me.updateAuthorBtn.Name = "updateAuthorBtn"
        Me.updateAuthorBtn.Size = New System.Drawing.Size(96, 32)
        Me.updateAuthorBtn.TabIndex = 8
        Me.updateAuthorBtn.Text = "Update"
        Me.updateAuthorBtn.UseSelectable = True
        '
        'removeAuthorBtn
        '
        Me.removeAuthorBtn.Location = New System.Drawing.Point(636, 202)
        Me.removeAuthorBtn.Name = "removeAuthorBtn"
        Me.removeAuthorBtn.Size = New System.Drawing.Size(96, 32)
        Me.removeAuthorBtn.TabIndex = 6
        Me.removeAuthorBtn.Text = "Remove"
        Me.removeAuthorBtn.UseSelectable = True
        '
        'getAuthorBtn
        '
        Me.getAuthorBtn.Location = New System.Drawing.Point(516, 240)
        Me.getAuthorBtn.Name = "getAuthorBtn"
        Me.getAuthorBtn.Size = New System.Drawing.Size(96, 32)
        Me.getAuthorBtn.TabIndex = 7
        Me.getAuthorBtn.Text = "Get"
        Me.getAuthorBtn.UseSelectable = True
        '
        'addAuthorBtn
        '
        Me.addAuthorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addAuthorBtn.Location = New System.Drawing.Point(516, 202)
        Me.addAuthorBtn.Name = "addAuthorBtn"
        Me.addAuthorBtn.Size = New System.Drawing.Size(96, 32)
        Me.addAuthorBtn.TabIndex = 5
        Me.addAuthorBtn.Text = "Add"
        Me.addAuthorBtn.UseSelectable = True
        '
        'authorNumTxtBx
        '
        Me.authorNumTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorNumTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorNumTxtBx.Location = New System.Drawing.Point(526, 158)
        Me.authorNumTxtBx.Name = "authorNumTxtBx"
        Me.authorNumTxtBx.Size = New System.Drawing.Size(204, 28)
        Me.authorNumTxtBx.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(460, 160)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 23)
        Me.Label22.TabIndex = 90
        Me.Label22.Text = "Number"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorLNameTxtBx
        '
        Me.authorLNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorLNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorLNameTxtBx.Location = New System.Drawing.Point(526, 122)
        Me.authorLNameTxtBx.Name = "authorLNameTxtBx"
        Me.authorLNameTxtBx.Size = New System.Drawing.Size(204, 28)
        Me.authorLNameTxtBx.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(446, 125)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 23)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Last Name"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorMNameTxtBx
        '
        Me.authorMNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorMNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorMNameTxtBx.Location = New System.Drawing.Point(526, 84)
        Me.authorMNameTxtBx.Name = "authorMNameTxtBx"
        Me.authorMNameTxtBx.Size = New System.Drawing.Size(204, 28)
        Me.authorMNameTxtBx.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(430, 87)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 23)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Middle Initial"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorFNameTxtBx
        '
        Me.authorFNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorFNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorFNameTxtBx.Location = New System.Drawing.Point(526, 44)
        Me.authorFNameTxtBx.Name = "authorFNameTxtBx"
        Me.authorFNameTxtBx.Size = New System.Drawing.Size(204, 28)
        Me.authorFNameTxtBx.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(442, 46)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 23)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "First Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorsFNameLbl
        '
        Me.authorsFNameLbl.AutoSize = True
        Me.authorsFNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsFNameLbl.Location = New System.Drawing.Point(53, 6)
        Me.authorsFNameLbl.Name = "authorsFNameLbl"
        Me.authorsFNameLbl.Size = New System.Drawing.Size(30, 23)
        Me.authorsFNameLbl.TabIndex = 99
        Me.authorsFNameLbl.Text = "FN"
        '
        'authorsNumLbl
        '
        Me.authorsNumLbl.AutoSize = True
        Me.authorsNumLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsNumLbl.Location = New System.Drawing.Point(0, 5)
        Me.authorsNumLbl.Name = "authorsNumLbl"
        Me.authorsNumLbl.Size = New System.Drawing.Size(33, 23)
        Me.authorsNumLbl.TabIndex = 98
        Me.authorsNumLbl.Text = "No."
        '
        'authorsLNameLbl
        '
        Me.authorsLNameLbl.AutoSize = True
        Me.authorsLNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsLNameLbl.Location = New System.Drawing.Point(263, 6)
        Me.authorsLNameLbl.Name = "authorsLNameLbl"
        Me.authorsLNameLbl.Size = New System.Drawing.Size(30, 23)
        Me.authorsLNameLbl.TabIndex = 101
        Me.authorsLNameLbl.Text = "LN"
        '
        'authorsMNameLbl
        '
        Me.authorsMNameLbl.AutoSize = True
        Me.authorsMNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsMNameLbl.Location = New System.Drawing.Point(163, 6)
        Me.authorsMNameLbl.Name = "authorsMNameLbl"
        Me.authorsMNameLbl.Size = New System.Drawing.Size(35, 23)
        Me.authorsMNameLbl.TabIndex = 100
        Me.authorsMNameLbl.Text = "MN"
        '
        'Panel11
        '
        Me.Panel11.AutoScroll = True
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.authorsMNameLbl)
        Me.Panel11.Controls.Add(Me.authorsLNameLbl)
        Me.Panel11.Controls.Add(Me.authorsNumLbl)
        Me.Panel11.Controls.Add(Me.authorsFNameLbl)
        Me.Panel11.Location = New System.Drawing.Point(37, 44)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(388, 213)
        Me.Panel11.TabIndex = 0
        '
        'AddBookUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.layoutPanel)
        Me.Name = "AddBookUserControl"
        Me.Size = New System.Drawing.Size(1054, 1450)
        Me.layoutPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PublicationInformationPanel.ResumeLayout(False)
        Me.PublicationInformationPanel.PerformLayout()
        Me.ImageSummaryPanel.ResumeLayout(False)
        Me.ImageSummaryPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.removeImgBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bkPicBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancelPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancelHoverPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addHoverPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.savePcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saveHoverPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents shelfTxtBx As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents copyrightYearDTPckr As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label14 As Label
    Friend WithEvents copyrightNameTxtBx As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PublicationInformationPanel As Panel
    Friend WithEvents publishedDatePicker As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label12 As Label
    Friend WithEvents publisherAddrTxtBx As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents publisherNameTxtBx As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents classificationCmbBx As ComboBox
    Friend WithEvents languageTxtBx As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents quantityTxtBx As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents editionTxtBx As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents isbnTxtBx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents titleTxtBx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ImageSummaryPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents removeImgBtn As PictureBox
    Friend WithEvents bkPicBx As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents summaryRichTxtBx As RichTextBox
    Friend WithEvents cancelPcBx As PictureBox
    Friend WithEvents cancelHoverPcBx As PictureBox
    Friend WithEvents addHoverPcBx As PictureBox
    Friend WithEvents addPcBx As PictureBox
    Friend WithEvents saveHoverPcBx As PictureBox
    Friend WithEvents savePcBx As PictureBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents authorsMNameLbl As Label
    Friend WithEvents authorsLNameLbl As Label
    Friend WithEvents authorsNumLbl As Label
    Friend WithEvents authorsFNameLbl As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents selectedAuthorLbl As Label
    Friend WithEvents removeAuthorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents updateAuthorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents addAuthorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents Label22 As Label
    Friend WithEvents getAuthorBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents authorNumTxtBx As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents authorLNameTxtBx As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents authorMNameTxtBx As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents authorFNameTxtBx As TextBox
End Class
