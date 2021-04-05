<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBookUserControl
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
        Me.ImageSummaryPanel = New System.Windows.Forms.Panel()
        Me.summaryRichTxtBx = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bkPicBx = New System.Windows.Forms.PictureBox()
        Me.removeImgBtn = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.titleTxtBx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.isbnTxtBx = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.editionTxtBx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.quantityTxtBx = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.languageTxtBx = New System.Windows.Forms.TextBox()
        Me.classificationCmbBx = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PublicationInformationPanel = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.publisherNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.publisherAddrTxtBx = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.publishedDatePicker = New MetroFramework.Controls.MetroDateTime()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.copyrightNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.copyrightYearDTPckr = New MetroFramework.Controls.MetroDateTime()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.authorFNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.authorMNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.authorLNameTxtBx = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.authorNumTxtBx = New System.Windows.Forms.TextBox()
        Me.getAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.addAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.updateAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.removeAuthorBtn = New MetroFramework.Controls.MetroButton()
        Me.selectedAuthorLbl = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.authorsFNameLbl = New System.Windows.Forms.Label()
        Me.authorsNumLbl = New System.Windows.Forms.Label()
        Me.authorsLNameLbl = New System.Windows.Forms.Label()
        Me.authorsMNameLbl = New System.Windows.Forms.Label()
        Me.shelfTxtBx = New System.Windows.Forms.TextBox()
        Me.ImageSummaryPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.bkPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.removeImgBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PublicationInformationPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageSummaryPanel
        '
        Me.ImageSummaryPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageSummaryPanel.BackColor = System.Drawing.Color.White
        Me.ImageSummaryPanel.Controls.Add(Me.Panel1)
        Me.ImageSummaryPanel.Controls.Add(Me.Label5)
        Me.ImageSummaryPanel.Controls.Add(Me.summaryRichTxtBx)
        Me.ImageSummaryPanel.Location = New System.Drawing.Point(0, 0)
        Me.ImageSummaryPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ImageSummaryPanel.Name = "ImageSummaryPanel"
        Me.ImageSummaryPanel.Size = New System.Drawing.Size(1382, 304)
        Me.ImageSummaryPanel.TabIndex = 0
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
        Me.summaryRichTxtBx.Size = New System.Drawing.Size(989, 254)
        Me.summaryRichTxtBx.TabIndex = 1
        Me.summaryRichTxtBx.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(345, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 35)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Summary"
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
        'removeImgBtn
        '
        Me.removeImgBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeImgBtn.BackColor = System.Drawing.Color.Transparent
        Me.removeImgBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.removeImgBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.x
        Me.removeImgBtn.Location = New System.Drawing.Point(241, 4)
        Me.removeImgBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.removeImgBtn.Name = "removeImgBtn"
        Me.removeImgBtn.Size = New System.Drawing.Size(24, 16)
        Me.removeImgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.removeImgBtn.TabIndex = 74
        Me.removeImgBtn.TabStop = False
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
        Me.Panel2.Location = New System.Drawing.Point(28, 351)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1385, 1326)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Title"
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
        Me.titleTxtBx.Size = New System.Drawing.Size(1301, 33)
        Me.titleTxtBx.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 32)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "ISBN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'isbnTxtBx
        '
        Me.isbnTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.isbnTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbnTxtBx.ForeColor = System.Drawing.Color.Black
        Me.isbnTxtBx.Location = New System.Drawing.Point(25, 112)
        Me.isbnTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.isbnTxtBx.Name = "isbnTxtBx"
        Me.isbnTxtBx.Size = New System.Drawing.Size(1301, 30)
        Me.isbnTxtBx.TabIndex = 72
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 155)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 32)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Edition"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editionTxtBx
        '
        Me.editionTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editionTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editionTxtBx.ForeColor = System.Drawing.Color.Black
        Me.editionTxtBx.Location = New System.Drawing.Point(25, 182)
        Me.editionTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.editionTxtBx.Name = "editionTxtBx"
        Me.editionTxtBx.Size = New System.Drawing.Size(1301, 30)
        Me.editionTxtBx.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 32)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.quantityTxtBx.Size = New System.Drawing.Size(1301, 30)
        Me.quantityTxtBx.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 299)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 32)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Language"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.languageTxtBx.Size = New System.Drawing.Size(1301, 33)
        Me.languageTxtBx.TabIndex = 78
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
        Me.classificationCmbBx.Size = New System.Drawing.Size(1301, 37)
        Me.classificationCmbBx.TabIndex = 79
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 369)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 32)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Classification"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 529)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 32)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Publication Information"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.PublicationInformationPanel.Location = New System.Drawing.Point(28, 560)
        Me.PublicationInformationPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.PublicationInformationPanel.Name = "PublicationInformationPanel"
        Me.PublicationInformationPanel.Size = New System.Drawing.Size(1299, 184)
        Me.PublicationInformationPanel.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 29)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Published Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'publisherNameTxtBx
        '
        Me.publisherNameTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.publisherNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisherNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.publisherNameTxtBx.Location = New System.Drawing.Point(288, 55)
        Me.publisherNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.publisherNameTxtBx.Name = "publisherNameTxtBx"
        Me.publisherNameTxtBx.Size = New System.Drawing.Size(950, 33)
        Me.publisherNameTxtBx.TabIndex = 85
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(281, 28)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 29)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Name"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.publisherAddrTxtBx.Size = New System.Drawing.Size(1181, 33)
        Me.publisherAddrTxtBx.TabIndex = 87
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(49, 98)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 29)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Address"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.publishedDatePicker.MinimumSize = New System.Drawing.Size(0, 30)
        Me.publishedDatePicker.Name = "publishedDatePicker"
        Me.publishedDatePicker.ShowCheckBox = True
        Me.publishedDatePicker.Size = New System.Drawing.Size(185, 30)
        Me.publishedDatePicker.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 761)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(224, 32)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Copyright Information"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel3.Size = New System.Drawing.Size(1299, 110)
        Me.Panel3.TabIndex = 84
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(49, 28)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 29)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Year"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'copyrightNameTxtBx
        '
        Me.copyrightNameTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copyrightNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyrightNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.copyrightNameTxtBx.Location = New System.Drawing.Point(288, 55)
        Me.copyrightNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.copyrightNameTxtBx.Name = "copyrightNameTxtBx"
        Me.copyrightNameTxtBx.Size = New System.Drawing.Size(951, 33)
        Me.copyrightNameTxtBx.TabIndex = 85
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(281, 28)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 29)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "Name"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.copyrightYearDTPckr.MinimumSize = New System.Drawing.Size(0, 27)
        Me.copyrightYearDTPckr.Name = "copyrightYearDTPckr"
        Me.copyrightYearDTPckr.ShowCheckBox = True
        Me.copyrightYearDTPckr.Size = New System.Drawing.Size(88, 27)
        Me.copyrightYearDTPckr.TabIndex = 88
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 446)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 32)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Shelf Name/Number"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(22, 928)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 35)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "Authors"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel4.Location = New System.Drawing.Point(28, 961)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1299, 358)
        Me.Panel4.TabIndex = 88
        '
        'authorFNameTxtBx
        '
        Me.authorFNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorFNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorFNameTxtBx.Location = New System.Drawing.Point(701, 54)
        Me.authorFNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.authorFNameTxtBx.Name = "authorFNameTxtBx"
        Me.authorFNameTxtBx.Size = New System.Drawing.Size(272, 33)
        Me.authorFNameTxtBx.TabIndex = 83
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(589, 58)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 29)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "First Name"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorMNameTxtBx
        '
        Me.authorMNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorMNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorMNameTxtBx.Location = New System.Drawing.Point(701, 102)
        Me.authorMNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.authorMNameTxtBx.Name = "authorMNameTxtBx"
        Me.authorMNameTxtBx.Size = New System.Drawing.Size(272, 33)
        Me.authorMNameTxtBx.TabIndex = 85
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(572, 108)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 29)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Middle Initial"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorLNameTxtBx
        '
        Me.authorLNameTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorLNameTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorLNameTxtBx.Location = New System.Drawing.Point(701, 150)
        Me.authorLNameTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.authorLNameTxtBx.Name = "authorLNameTxtBx"
        Me.authorLNameTxtBx.Size = New System.Drawing.Size(272, 33)
        Me.authorLNameTxtBx.TabIndex = 87
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(595, 154)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(98, 29)
        Me.Label20.TabIndex = 86
        Me.Label20.Text = "Last Name"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(52, 11)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(102, 29)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Author List"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'authorNumTxtBx
        '
        Me.authorNumTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorNumTxtBx.ForeColor = System.Drawing.Color.Black
        Me.authorNumTxtBx.Location = New System.Drawing.Point(701, 194)
        Me.authorNumTxtBx.Margin = New System.Windows.Forms.Padding(4)
        Me.authorNumTxtBx.Name = "authorNumTxtBx"
        Me.authorNumTxtBx.Size = New System.Drawing.Size(272, 33)
        Me.authorNumTxtBx.TabIndex = 91
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
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(612, 198)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 29)
        Me.Label22.TabIndex = 90
        Me.Label22.Text = "Number"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(712, 22)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(145, 29)
        Me.Label30.TabIndex = 96
        Me.Label30.Text = "Selected Author:"
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
        Me.Panel11.Size = New System.Drawing.Size(518, 262)
        Me.Panel11.TabIndex = 102
        '
        'authorsFNameLbl
        '
        Me.authorsFNameLbl.AutoSize = True
        Me.authorsFNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsFNameLbl.Location = New System.Drawing.Point(71, 8)
        Me.authorsFNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.authorsFNameLbl.Name = "authorsFNameLbl"
        Me.authorsFNameLbl.Size = New System.Drawing.Size(38, 29)
        Me.authorsFNameLbl.TabIndex = 99
        Me.authorsFNameLbl.Text = "FN"
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
        'authorsLNameLbl
        '
        Me.authorsLNameLbl.AutoSize = True
        Me.authorsLNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsLNameLbl.Location = New System.Drawing.Point(351, 8)
        Me.authorsLNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.authorsLNameLbl.Name = "authorsLNameLbl"
        Me.authorsLNameLbl.Size = New System.Drawing.Size(38, 29)
        Me.authorsLNameLbl.TabIndex = 101
        Me.authorsLNameLbl.Text = "LN"
        '
        'authorsMNameLbl
        '
        Me.authorsMNameLbl.AutoSize = True
        Me.authorsMNameLbl.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.authorsMNameLbl.Location = New System.Drawing.Point(218, 8)
        Me.authorsMNameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.authorsMNameLbl.Name = "authorsMNameLbl"
        Me.authorsMNameLbl.Size = New System.Drawing.Size(44, 29)
        Me.authorsMNameLbl.TabIndex = 100
        Me.authorsMNameLbl.Text = "MN"
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
        Me.shelfTxtBx.Size = New System.Drawing.Size(1301, 33)
        Me.shelfTxtBx.TabIndex = 89
        '
        'addBookUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ImageSummaryPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "addBookUserControl"
        Me.Size = New System.Drawing.Size(1439, 1740)
        Me.ImageSummaryPanel.ResumeLayout(False)
        Me.ImageSummaryPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bkPicBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.removeImgBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PublicationInformationPanel.ResumeLayout(False)
        Me.PublicationInformationPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageSummaryPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents removeImgBtn As PictureBox
    Friend WithEvents bkPicBx As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents summaryRichTxtBx As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents shelfTxtBx As TextBox
    Friend WithEvents Panel4 As Panel
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
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents authorLNameTxtBx As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents authorMNameTxtBx As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents authorFNameTxtBx As TextBox
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
End Class
