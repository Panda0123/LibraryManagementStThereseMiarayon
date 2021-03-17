<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainScreen
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.advanceSearchLinkLbl = New System.Windows.Forms.LinkLabel()
        Me.upperMainScreenPanel = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.leftMainScreenPanel = New System.Windows.Forms.Panel()
        Me.pictureBoxRectangle = New System.Windows.Forms.PictureBox()
        Me.RadioButtonTitle = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAuthor = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPublicationDate = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNewlyAdded = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.upperMainScreenPanel.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.leftMainScreenPanel.SuspendLayout()
        CType(Me.pictureBoxRectangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(445, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 78)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "St. Therese School of Miarayon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Library Management System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Maiandra GD", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(245, 171)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(544, 32)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Search"
        '
        'advanceSearchLinkLbl
        '
        Me.advanceSearchLinkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.advanceSearchLinkLbl.AutoSize = True
        Me.advanceSearchLinkLbl.BackColor = System.Drawing.Color.Transparent
        Me.advanceSearchLinkLbl.Font = New System.Drawing.Font("Sitka Subheading", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.advanceSearchLinkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.advanceSearchLinkLbl.Location = New System.Drawing.Point(479, 220)
        Me.advanceSearchLinkLbl.Name = "advanceSearchLinkLbl"
        Me.advanceSearchLinkLbl.Size = New System.Drawing.Size(143, 28)
        Me.advanceSearchLinkLbl.TabIndex = 7
        Me.advanceSearchLinkLbl.TabStop = True
        Me.advanceSearchLinkLbl.Text = "Advance Search"
        '
        'upperMainScreenPanel
        '
        Me.upperMainScreenPanel.Controls.Add(Me.advanceSearchLinkLbl)
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox3)
        Me.upperMainScreenPanel.Controls.Add(Me.TextBox1)
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox2)
        Me.upperMainScreenPanel.Controls.Add(Me.Label1)
        Me.upperMainScreenPanel.Controls.Add(Me.PictureBox1)
        Me.upperMainScreenPanel.Location = New System.Drawing.Point(0, 21)
        Me.upperMainScreenPanel.Name = "upperMainScreenPanel"
        Me.upperMainScreenPanel.Size = New System.Drawing.Size(1134, 258)
        Me.upperMainScreenPanel.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.LibraryManagementSystem.My.Resources.Resources.magnifying_glass
        Me.PictureBox3.Location = New System.Drawing.Point(816, 166)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.LibraryManagementSystem.My.Resources.Resources.Search
        Me.PictureBox2.Location = New System.Drawing.Point(221, 154)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(657, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.LibraryManagementSystem.My.Resources.Resources.St__Therese_School_of_Miarayon_logo
        Me.PictureBox1.Location = New System.Drawing.Point(213, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'leftMainScreenPanel
        '
        Me.leftMainScreenPanel.AutoScroll = True
        Me.leftMainScreenPanel.Controls.Add(Me.Panel1)
        Me.leftMainScreenPanel.Location = New System.Drawing.Point(0, 285)
        Me.leftMainScreenPanel.Name = "leftMainScreenPanel"
        Me.leftMainScreenPanel.Size = New System.Drawing.Size(288, 365)
        Me.leftMainScreenPanel.TabIndex = 9
        '
        'pictureBoxRectangle
        '
        Me.pictureBoxRectangle.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxRectangle.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_22
        Me.pictureBoxRectangle.Location = New System.Drawing.Point(2, 2)
        Me.pictureBoxRectangle.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBoxRectangle.Name = "pictureBoxRectangle"
        Me.pictureBoxRectangle.Size = New System.Drawing.Size(258, 165)
        Me.pictureBoxRectangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxRectangle.TabIndex = 10
        Me.pictureBoxRectangle.TabStop = False
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.RadioButtonTitle)
        Me.Panel1.Controls.Add(Me.RadioButtonAuthor)
        Me.Panel1.Controls.Add(Me.RadioButtonNewlyAdded)
        Me.Panel1.Controls.Add(Me.RadioButtonPublicationDate)
        Me.Panel1.Controls.Add(Me.pictureBoxRectangle)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 501)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.LibraryManagementSystem.My.Resources.Resources.Rectangle_22
        Me.PictureBox4.Location = New System.Drawing.Point(2, 187)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(258, 165)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'mainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1134, 655)
        Me.Controls.Add(Me.leftMainScreenPanel)
        Me.Controls.Add(Me.upperMainScreenPanel)
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mainScreen"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.TransparencyKey = System.Drawing.Color.WhiteSmoke
        Me.upperMainScreenPanel.ResumeLayout(False)
        Me.upperMainScreenPanel.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.leftMainScreenPanel.ResumeLayout(False)
        CType(Me.pictureBoxRectangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents advanceSearchLinkLbl As LinkLabel
    Friend WithEvents upperMainScreenPanel As Panel
    Friend WithEvents leftMainScreenPanel As Panel
    Friend WithEvents RadioButtonNewlyAdded As RadioButton
    Friend WithEvents RadioButtonPublicationDate As RadioButton
    Friend WithEvents pictureBoxRectangle As PictureBox
    Friend WithEvents RadioButtonAuthor As RadioButton
    Friend WithEvents RadioButtonTitle As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
End Class
