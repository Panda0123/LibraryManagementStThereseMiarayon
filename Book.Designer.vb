<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book
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
        Me.img = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Author = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.langauge = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.publisher = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img
        '
        Me.img.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img.Image = Global.LibraryManagementSystem.My.Resources.Resources.pic_11
        Me.img.Location = New System.Drawing.Point(14, 3)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(192, 308)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.img.TabIndex = 0
        Me.img.TabStop = False
        '
        'Title
        '
        Me.Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Maiandra GD", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(295, 22)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(608, 34)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Star wars: the rise of Skywalker the visual diction"
        '
        'Author
        '
        Me.Author.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Author.AutoSize = True
        Me.Author.Font = New System.Drawing.Font("Maiandra GD", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Author.Location = New System.Drawing.Point(295, 66)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(149, 29)
        Me.Author.TabIndex = 2
        Me.Author.Text = "Adcock, F. E."
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Display", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Language:"
        '
        'langauge
        '
        Me.langauge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.langauge.AutoSize = True
        Me.langauge.Font = New System.Drawing.Font("Sitka Display", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.langauge.Location = New System.Drawing.Point(384, 130)
        Me.langauge.Name = "langauge"
        Me.langauge.Size = New System.Drawing.Size(68, 28)
        Me.langauge.TabIndex = 3
        Me.langauge.Text = "English"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Display", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 28)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Publisher:"
        '
        'publisher
        '
        Me.publisher.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.publisher.AutoSize = True
        Me.publisher.Font = New System.Drawing.Font("Sitka Display", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher.Location = New System.Drawing.Point(384, 158)
        Me.publisher.Name = "publisher"
        Me.publisher.Size = New System.Drawing.Size(398, 28)
        Me.publisher.TabIndex = 3
        Me.publisher.Text = "Solon, Ohio : Findaway World, LLC, [2020] ℗2020"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Display", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Status:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Display", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(366, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Available"
        '
        'Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Controls.Add(Me.publisher)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.langauge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Author)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.img)
        Me.Name = "Book"
        Me.Size = New System.Drawing.Size(935, 320)
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents Author As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents langauge As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents publisher As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
