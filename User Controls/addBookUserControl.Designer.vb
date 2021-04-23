<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBookUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.layoutPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.isbnWarningLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.quantityLbl = New System.Windows.Forms.Label()
        Me.copiesDataGridView = New System.Windows.Forms.DataGridView()
        Me.copyNumCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.copiesDeleteCol = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.shelfTxtBx = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.authorsDataGrid = New System.Windows.Forms.DataGridView()
        Me.authorFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.authorMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.authorLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleteCol = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.saveHoverPcBx = New System.Windows.Forms.PictureBox()
        Me.savePcBx = New System.Windows.Forms.PictureBox()
        Me.addPcBx = New System.Windows.Forms.PictureBox()
        Me.addHoverPcBx = New System.Windows.Forms.PictureBox()
        Me.timerClearDataGrid = New System.Windows.Forms.Timer(Me.components)
        Me.layoutPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.copiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.authorsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PublicationInformationPanel.SuspendLayout()
        Me.ImageSummaryPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.removeImgBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bkPicBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancelHoverPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saveHoverPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.savePcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addHoverPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.layoutPanel.Controls.Add(Me.saveHoverPcBx)
        Me.layoutPanel.Controls.Add(Me.savePcBx)
        Me.layoutPanel.Controls.Add(Me.addPcBx)
        Me.layoutPanel.Controls.Add(Me.addHoverPcBx)
        Me.layoutPanel.Location = New System.Drawing.Point(4, 4)
        Me.layoutPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.layoutPanel.Name = "layoutPanel"
        Me.layoutPanel.Size = New System.Drawing.Size(1355, 2028)
        Me.layoutPanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.isbnWarningLbl)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel5)
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
        Me.Panel2.Controls.Add(Me.editionTxtBx)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.isbnTxtBx)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.titleTxtBx)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(27, 351)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1301, 1607)
        Me.Panel2.TabIndex = 0
        '
        'isbnWarningLbl
        '
        Me.isbnWarningLbl.AutoSize = True
        Me.isbnWarningLbl.BackColor = System.Drawing.Color.Transparent
        Me.isbnWarningLbl.ForeColor = System.Drawing.Color.Red
        Me.isbnWarningLbl.Location = New System.Drawing.Point(84, 94)
        Me.isbnWarningLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.isbnWarningLbl.Name = "isbnWarningLbl"
        Me.isbnWarningLbl.Size = New System.Drawing.Size(162, 17)
        Me.isbnWarningLbl.TabIndex = 93
        Me.isbnWarningLbl.Text = "Error: ISBN already exist"
        Me.isbnWarningLbl.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 1259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 35)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Copies"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.quantityLbl)
        Me.Panel5.Controls.Add(Me.copiesDataGridView)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(25, 1297)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1214, 292)
        Me.Panel5.TabIndex = 91
        '
        'quantityLbl
        '
        Me.quantityLbl.AutoSize = True
        Me.quantityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityLbl.Location = New System.Drawing.Point(88, 47)
        Me.quantityLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.quantityLbl.Name = "quantityLbl"
        Me.quantityLbl.Size = New System.Drawing.Size(24, 25)
        Me.quantityLbl.TabIndex = 91
        Me.quantityLbl.Text = "1"
        '
        'copiesDataGridView
        '
        Me.copiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.copiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.copiesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.copiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.copiesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.copiesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.copiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.copiesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.copyNumCol, Me.statusCol, Me.copiesDeleteCol})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.copiesDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.copiesDataGridView.Location = New System.Drawing.Point(240, 17)
        Me.copiesDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.copiesDataGridView.Name = "copiesDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.copiesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.copiesDataGridView.RowHeadersWidth = 51
        Me.copiesDataGridView.ShowEditingIcon = False
        Me.copiesDataGridView.Size = New System.Drawing.Size(465, 257)
        Me.copiesDataGridView.TabIndex = 90
        '
        'copyNumCol
        '
        Me.copyNumCol.HeaderText = "Copy #"
        Me.copyNumCol.MinimumWidth = 6
        Me.copyNumCol.Name = "copyNumCol"
        Me.copyNumCol.Width = 89
        '
        'statusCol
        '
        Me.statusCol.HeaderText = "Status"
        Me.statusCol.MinimumWidth = 6
        Me.statusCol.Name = "statusCol"
        Me.statusCol.ReadOnly = True
        Me.statusCol.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.statusCol.Width = 84
        '
        'copiesDeleteCol
        '
        Me.copiesDeleteCol.HeaderText = "Control"
        Me.copiesDeleteCol.MinimumWidth = 6
        Me.copiesDeleteCol.Name = "copiesDeleteCol"
        Me.copiesDeleteCol.Text = "Delete"
        Me.copiesDeleteCol.UseColumnTextForButtonValue = True
        Me.copiesDeleteCol.Width = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 32)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shelfTxtBx
        '
        Me.shelfTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shelfTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shelfTxtBx.ForeColor = System.Drawing.Color.Black
        Me.shelfTxtBx.Location = New System.Drawing.Point(25, 402)
        Me.shelfTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.shelfTxtBx.Name = "shelfTxtBx"
        Me.shelfTxtBx.Size = New System.Drawing.Size(1215, 33)
        Me.shelfTxtBx.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.authorsDataGrid)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Location = New System.Drawing.Point(27, 885)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1214, 358)
        Me.Panel4.TabIndex = 88
        '
        'authorsDataGrid
        '
        Me.authorsDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.authorsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.authorsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.authorsDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.authorsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.authorsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Sitka Display", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.authorsDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.authorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.authorsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.authorFirstName, Me.authorMiddleName, Me.authorLastName, Me.deleteCol})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.authorsDataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.authorsDataGrid.Location = New System.Drawing.Point(59, 44)
        Me.authorsDataGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.authorsDataGrid.Name = "authorsDataGrid"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.authorsDataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.authorsDataGrid.RowHeadersWidth = 51
        Me.authorsDataGrid.ShowEditingIcon = False
        Me.authorsDataGrid.Size = New System.Drawing.Size(1121, 290)
        Me.authorsDataGrid.TabIndex = 90
        '
        'authorFirstName
        '
        Me.authorFirstName.HeaderText = "First Name"
        Me.authorFirstName.MinimumWidth = 6
        Me.authorFirstName.Name = "authorFirstName"
        Me.authorFirstName.Width = 119
        '
        'authorMiddleName
        '
        Me.authorMiddleName.HeaderText = "Middle Name"
        Me.authorMiddleName.MinimumWidth = 6
        Me.authorMiddleName.Name = "authorMiddleName"
        Me.authorMiddleName.Width = 135
        '
        'authorLastName
        '
        Me.authorLastName.HeaderText = "Last Name"
        Me.authorLastName.MinimumWidth = 6
        Me.authorLastName.Name = "authorLastName"
        Me.authorLastName.Width = 115
        '
        'deleteCol
        '
        Me.deleteCol.HeaderText = "Control"
        Me.deleteCol.MinimumWidth = 6
        Me.deleteCol.Name = "deleteCol"
        Me.deleteCol.Text = "Delete"
        Me.deleteCol.UseColumnTextForButtonValue = True
        Me.deleteCol.Width = 72
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
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Sitka Display", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(23, 852)
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
        Me.Label13.Location = New System.Drawing.Point(21, 369)
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
        Me.Panel3.Location = New System.Drawing.Point(25, 718)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1214, 109)
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
        Me.copyrightYearDTPckr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.copyrightYearDTPckr.MinimumSize = New System.Drawing.Size(4, 25)
        Me.copyrightYearDTPckr.Name = "copyrightYearDTPckr"
        Me.copyrightYearDTPckr.ShowCheckBox = True
        Me.copyrightYearDTPckr.Size = New System.Drawing.Size(88, 25)
        Me.copyrightYearDTPckr.TabIndex = 0
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
        Me.copyrightNameTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.copyrightNameTxtBx.Name = "copyrightNameTxtBx"
        Me.copyrightNameTxtBx.Size = New System.Drawing.Size(865, 33)
        Me.copyrightNameTxtBx.TabIndex = 1
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
        Me.Label16.Location = New System.Drawing.Point(20, 684)
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
        Me.PublicationInformationPanel.Location = New System.Drawing.Point(27, 484)
        Me.PublicationInformationPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PublicationInformationPanel.Name = "PublicationInformationPanel"
        Me.PublicationInformationPanel.Size = New System.Drawing.Size(1214, 184)
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
        Me.publishedDatePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.publishedDatePicker.MinimumSize = New System.Drawing.Size(4, 29)
        Me.publishedDatePicker.Name = "publishedDatePicker"
        Me.publishedDatePicker.ShowCheckBox = True
        Me.publishedDatePicker.Size = New System.Drawing.Size(185, 29)
        Me.publishedDatePicker.TabIndex = 0
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
        Me.publisherAddrTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.publisherAddrTxtBx.Name = "publisherAddrTxtBx"
        Me.publisherAddrTxtBx.Size = New System.Drawing.Size(1096, 33)
        Me.publisherAddrTxtBx.TabIndex = 2
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
        Me.publisherNameTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.publisherNameTxtBx.Name = "publisherNameTxtBx"
        Me.publisherNameTxtBx.Size = New System.Drawing.Size(864, 33)
        Me.publisherNameTxtBx.TabIndex = 1
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
        Me.Label9.Location = New System.Drawing.Point(21, 453)
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
        Me.Label8.Location = New System.Drawing.Point(21, 293)
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
        Me.classificationCmbBx.Location = New System.Drawing.Point(25, 326)
        Me.classificationCmbBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.classificationCmbBx.Name = "classificationCmbBx"
        Me.classificationCmbBx.Size = New System.Drawing.Size(1215, 37)
        Me.classificationCmbBx.TabIndex = 5
        '
        'languageTxtBx
        '
        Me.languageTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.languageTxtBx.Font = New System.Drawing.Font("Sitka Subheading", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.languageTxtBx.ForeColor = System.Drawing.Color.Black
        Me.languageTxtBx.Location = New System.Drawing.Point(25, 252)
        Me.languageTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.languageTxtBx.Name = "languageTxtBx"
        Me.languageTxtBx.Size = New System.Drawing.Size(1215, 33)
        Me.languageTxtBx.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Display", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 32)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Language"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'editionTxtBx
        '
        Me.editionTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editionTxtBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editionTxtBx.ForeColor = System.Drawing.Color.Black
        Me.editionTxtBx.Location = New System.Drawing.Point(25, 183)
        Me.editionTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.editionTxtBx.Name = "editionTxtBx"
        Me.editionTxtBx.Size = New System.Drawing.Size(1215, 30)
        Me.editionTxtBx.TabIndex = 2
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
        Me.isbnTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.isbnTxtBx.Name = "isbnTxtBx"
        Me.isbnTxtBx.Size = New System.Drawing.Size(1215, 30)
        Me.isbnTxtBx.TabIndex = 1
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
        Me.titleTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.titleTxtBx.Name = "titleTxtBx"
        Me.titleTxtBx.Size = New System.Drawing.Size(1215, 33)
        Me.titleTxtBx.TabIndex = 0
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
        Me.ImageSummaryPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImageSummaryPanel.Name = "ImageSummaryPanel"
        Me.ImageSummaryPanel.Size = New System.Drawing.Size(1299, 304)
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 278)
        Me.Panel1.TabIndex = 0
        '
        'removeImgBtn
        '
        Me.removeImgBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeImgBtn.BackColor = System.Drawing.Color.Transparent
        Me.removeImgBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.removeImgBtn.Image = Global.LibraryManagementSystem.My.Resources.Resources.x
        Me.removeImgBtn.Location = New System.Drawing.Point(241, 4)
        Me.removeImgBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.removeImgBtn.Name = "removeImgBtn"
        Me.removeImgBtn.Size = New System.Drawing.Size(25, 16)
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
        Me.bkPicBx.Location = New System.Drawing.Point(4, 4)
        Me.bkPicBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.summaryRichTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.summaryRichTxtBx.Name = "summaryRichTxtBx"
        Me.summaryRichTxtBx.Size = New System.Drawing.Size(905, 254)
        Me.summaryRichTxtBx.TabIndex = 1
        Me.summaryRichTxtBx.Text = ""
        '
        'cancelPcBx
        '
        Me.cancelPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cancelPcBx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.cancel
        Me.cancelPcBx.Location = New System.Drawing.Point(783, 1974)
        Me.cancelPcBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cancelPcBx.Name = "cancelPcBx"
        Me.cancelPcBx.Size = New System.Drawing.Size(347, 50)
        Me.cancelPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancelPcBx.TabIndex = 4
        Me.cancelPcBx.TabStop = False
        '
        'cancelHoverPcBx
        '
        Me.cancelHoverPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cancelHoverPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.canceHover
        Me.cancelHoverPcBx.Location = New System.Drawing.Point(783, 1974)
        Me.cancelHoverPcBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cancelHoverPcBx.Name = "cancelHoverPcBx"
        Me.cancelHoverPcBx.Size = New System.Drawing.Size(347, 50)
        Me.cancelHoverPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cancelHoverPcBx.TabIndex = 5
        Me.cancelHoverPcBx.TabStop = False
        Me.cancelHoverPcBx.Visible = False
        '
        'saveHoverPcBx
        '
        Me.saveHoverPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.saveHoverPcBx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveHoverPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.save2Hover
        Me.saveHoverPcBx.Location = New System.Drawing.Point(221, 1974)
        Me.saveHoverPcBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.saveHoverPcBx.Name = "saveHoverPcBx"
        Me.saveHoverPcBx.Size = New System.Drawing.Size(347, 50)
        Me.saveHoverPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.saveHoverPcBx.TabIndex = 6
        Me.saveHoverPcBx.TabStop = False
        Me.saveHoverPcBx.Visible = False
        '
        'savePcBx
        '
        Me.savePcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.savePcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.save
        Me.savePcBx.Location = New System.Drawing.Point(221, 1974)
        Me.savePcBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.savePcBx.Name = "savePcBx"
        Me.savePcBx.Size = New System.Drawing.Size(347, 50)
        Me.savePcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.savePcBx.TabIndex = 5
        Me.savePcBx.TabStop = False
        Me.savePcBx.Visible = False
        '
        'addPcBx
        '
        Me.addPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.addBookBtn
        Me.addPcBx.Location = New System.Drawing.Point(221, 1974)
        Me.addPcBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addPcBx.Name = "addPcBx"
        Me.addPcBx.Size = New System.Drawing.Size(347, 50)
        Me.addPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addPcBx.TabIndex = 3
        Me.addPcBx.TabStop = False
        '
        'addHoverPcBx
        '
        Me.addHoverPcBx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addHoverPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.addHover
        Me.addHoverPcBx.Location = New System.Drawing.Point(221, 1974)
        Me.addHoverPcBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addHoverPcBx.Name = "addHoverPcBx"
        Me.addHoverPcBx.Size = New System.Drawing.Size(347, 50)
        Me.addHoverPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.addHoverPcBx.TabIndex = 4
        Me.addHoverPcBx.TabStop = False
        Me.addHoverPcBx.Visible = False
        '
        'AddBookUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.layoutPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AddBookUserControl"
        Me.Size = New System.Drawing.Size(1360, 2037)
        Me.layoutPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.copiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.authorsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.saveHoverPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.savePcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addHoverPcBx, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents authorsDataGrid As DataGridView
    Friend WithEvents timerClearDataGrid As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents copiesDataGridView As DataGridView
    Friend WithEvents quantityLbl As Label
    Friend WithEvents authorFirstName As DataGridViewTextBoxColumn
    Friend WithEvents authorMiddleName As DataGridViewTextBoxColumn
    Friend WithEvents authorLastName As DataGridViewTextBoxColumn
    Friend WithEvents deleteCol As DataGridViewButtonColumn
    Friend WithEvents copyNumCol As DataGridViewTextBoxColumn
    Friend WithEvents statusCol As DataGridViewTextBoxColumn
    Friend WithEvents copiesDeleteCol As DataGridViewButtonColumn
    Friend WithEvents isbnWarningLbl As Label
End Class
