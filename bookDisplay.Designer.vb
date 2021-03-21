<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookDisplay
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
        Me.bAuthor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bLanguage = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bPublisher = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bStatus = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bTitle = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bAuthor
        '
        Me.bAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAuthor.AutoSize = True
        Me.bAuthor.Font = New System.Drawing.Font("Maiandra GD", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAuthor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.bAuthor.Location = New System.Drawing.Point(208, 50)
        Me.bAuthor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bAuthor.Name = "bAuthor"
        Me.bAuthor.Size = New System.Drawing.Size(135, 26)
        Me.bAuthor.TabIndex = 2
        Me.bAuthor.Text = "Adcock, F. E."
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Language:"
        '
        'bLanguage
        '
        Me.bLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bLanguage.AutoSize = True
        Me.bLanguage.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bLanguage.Location = New System.Drawing.Point(286, 98)
        Me.bLanguage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bLanguage.Name = "bLanguage"
        Me.bLanguage.Size = New System.Drawing.Size(57, 23)
        Me.bLanguage.TabIndex = 4
        Me.bLanguage.Text = "English"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Publisher:"
        '
        'bPublisher
        '
        Me.bPublisher.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bPublisher.AutoSize = True
        Me.bPublisher.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bPublisher.Location = New System.Drawing.Point(286, 103)
        Me.bPublisher.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bPublisher.Name = "bPublisher"
        Me.bPublisher.Size = New System.Drawing.Size(333, 23)
        Me.bPublisher.TabIndex = 5
        Me.bPublisher.Text = "Solon, Ohio : Findaway World, LLC, [2020] ℗2020"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 180)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Status:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'bStatus
        '
        Me.bStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bStatus.AutoSize = True
        Me.bStatus.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bStatus.ForeColor = System.Drawing.Color.Lime
        Me.bStatus.Location = New System.Drawing.Point(116, 180)
        Me.bStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bStatus.Name = "bStatus"
        Me.bStatus.Size = New System.Drawing.Size(67, 23)
        Me.bStatus.TabIndex = 5
        Me.bStatus.Text = "Available"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(25, 16)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'bTitle
        '
        Me.bTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bTitle.AutoSize = True
        Me.bTitle.Font = New System.Drawing.Font("Maiandra GD", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.bTitle.Location = New System.Drawing.Point(207, 16)
        Me.bTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.bTitle.Name = "bTitle"
        Me.bTitle.Size = New System.Drawing.Size(710, 32)
        Me.bTitle.TabIndex = 1
        Me.bTitle.Text = "Star wars: the rise of Skywalker the visual dictionary (2019)"
        '
        'bookDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.bPublisher)
        Me.Controls.Add(Me.bStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bLanguage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bAuthor)
        Me.Controls.Add(Me.bTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "bookDisplay"
        Me.Size = New System.Drawing.Size(972, 215)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bAuthor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bLanguage As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bPublisher As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bStatus As Label
    Friend WithEvents bTitle As Label
End Class
