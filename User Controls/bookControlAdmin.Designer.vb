﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookControlAdmin
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
        Me.bPublisher = New System.Windows.Forms.Label()
        Me.bStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bLanguage = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bAuthor = New System.Windows.Forms.Label()
        Me.bTitle = New System.Windows.Forms.Label()
        Me.coverPcBx = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.checkOutLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.reserveLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.viewBookLnkLbl = New System.Windows.Forms.LinkLabel()
        CType(Me.coverPcBx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bPublisher
        '
        Me.bPublisher.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bPublisher.AutoSize = True
        Me.bPublisher.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPublisher.Location = New System.Drawing.Point(243, 105)
        Me.bPublisher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bPublisher.Name = "bPublisher"
        Me.bPublisher.Size = New System.Drawing.Size(333, 23)
        Me.bPublisher.TabIndex = 13
        Me.bPublisher.Text = "Solon, Ohio : Findaway World, LLC, [2020] ℗2020"
        '
        'bStatus
        '
        Me.bStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bStatus.AutoSize = True
        Me.bStatus.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bStatus.ForeColor = System.Drawing.Color.Lime
        Me.bStatus.Location = New System.Drawing.Point(243, 136)
        Me.bStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bStatus.Name = "bStatus"
        Me.bStatus.Size = New System.Drawing.Size(67, 23)
        Me.bStatus.TabIndex = 14
        Me.bStatus.Text = "Available"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 136)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Status:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(168, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Publisher:"
        '
        'bLanguage
        '
        Me.bLanguage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bLanguage.AutoSize = True
        Me.bLanguage.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLanguage.Location = New System.Drawing.Point(244, 75)
        Me.bLanguage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bLanguage.Name = "bLanguage"
        Me.bLanguage.Size = New System.Drawing.Size(57, 23)
        Me.bLanguage.TabIndex = 12
        Me.bLanguage.Text = "English"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Language:"
        '
        'bAuthor
        '
        Me.bAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAuthor.AutoSize = True
        Me.bAuthor.Font = New System.Drawing.Font("Maiandra GD", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.bAuthor.Location = New System.Drawing.Point(167, 44)
        Me.bAuthor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bAuthor.Name = "bAuthor"
        Me.bAuthor.Size = New System.Drawing.Size(135, 26)
        Me.bAuthor.TabIndex = 10
        Me.bAuthor.Text = "Adcock, F. E."
        '
        'bTitle
        '
        Me.bTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bTitle.AutoSize = True
        Me.bTitle.Font = New System.Drawing.Font("Maiandra GD", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.bTitle.Location = New System.Drawing.Point(166, 19)
        Me.bTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bTitle.Name = "bTitle"
        Me.bTitle.Size = New System.Drawing.Size(577, 26)
        Me.bTitle.TabIndex = 9
        Me.bTitle.Text = "Star wars: the rise of Skywalker the visual dictionary (2019)"
        '
        'coverPcBx
        '
        Me.coverPcBx.Image = Global.LibraryManagementSystem.My.Resources.Resources.pic_1
        Me.coverPcBx.Location = New System.Drawing.Point(22, 23)
        Me.coverPcBx.Margin = New System.Windows.Forms.Padding(2)
        Me.coverPcBx.Name = "coverPcBx"
        Me.coverPcBx.Size = New System.Drawing.Size(158, 136)
        Me.coverPcBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.coverPcBx.TabIndex = 8
        Me.coverPcBx.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1054, 185)
        Me.ShapeContainer1.TabIndex = 17
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RectangleShape1.CornerRadius = 20
        Me.RectangleShape1.Location = New System.Drawing.Point(19, 12)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1020, 162)
        '
        'checkOutLnkLbl
        '
        Me.checkOutLnkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.checkOutLnkLbl.AutoSize = True
        Me.checkOutLnkLbl.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkOutLnkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.checkOutLnkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.checkOutLnkLbl.Location = New System.Drawing.Point(632, 136)
        Me.checkOutLnkLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.checkOutLnkLbl.Name = "checkOutLnkLbl"
        Me.checkOutLnkLbl.Size = New System.Drawing.Size(94, 28)
        Me.checkOutLnkLbl.TabIndex = 18
        Me.checkOutLnkLbl.TabStop = True
        Me.checkOutLnkLbl.Text = "Check Out"
        '
        'reserveLnkLbl
        '
        Me.reserveLnkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.reserveLnkLbl.AutoSize = True
        Me.reserveLnkLbl.Font = New System.Drawing.Font("Sitka Display", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reserveLnkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.reserveLnkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.reserveLnkLbl.Location = New System.Drawing.Point(734, 136)
        Me.reserveLnkLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.reserveLnkLbl.Name = "reserveLnkLbl"
        Me.reserveLnkLbl.Size = New System.Drawing.Size(76, 28)
        Me.reserveLnkLbl.TabIndex = 19
        Me.reserveLnkLbl.TabStop = True
        Me.reserveLnkLbl.Text = "Reserve"
        '
        'viewBookLnkLbl
        '
        Me.viewBookLnkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.viewBookLnkLbl.AutoSize = True
        Me.viewBookLnkLbl.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewBookLnkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.viewBookLnkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.viewBookLnkLbl.Location = New System.Drawing.Point(879, 75)
        Me.viewBookLnkLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.viewBookLnkLbl.Name = "viewBookLnkLbl"
        Me.viewBookLnkLbl.Size = New System.Drawing.Size(111, 32)
        Me.viewBookLnkLbl.TabIndex = 18
        Me.viewBookLnkLbl.TabStop = True
        Me.viewBookLnkLbl.Text = "View Book"
        '
        'bookControlAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.viewBookLnkLbl)
        Me.Controls.Add(Me.reserveLnkLbl)
        Me.Controls.Add(Me.checkOutLnkLbl)
        Me.Controls.Add(Me.bPublisher)
        Me.Controls.Add(Me.bStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bLanguage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bAuthor)
        Me.Controls.Add(Me.bTitle)
        Me.Controls.Add(Me.coverPcBx)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "bookControlAdmin"
        Me.Size = New System.Drawing.Size(1054, 185)
        CType(Me.coverPcBx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bPublisher As Label
    Friend WithEvents bStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bLanguage As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bAuthor As Label
    Friend WithEvents bTitle As Label
    Friend WithEvents coverPcBx As PictureBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents checkOutLnkLbl As LinkLabel
    Friend WithEvents reserveLnkLbl As LinkLabel
    Friend WithEvents viewBookLnkLbl As LinkLabel
End Class
