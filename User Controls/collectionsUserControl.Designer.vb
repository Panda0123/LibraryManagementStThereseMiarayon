<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class collectionsUserControl
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
        Me.bookListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.moreClassCombobox = New System.Windows.Forms.ComboBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox0 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBox19 = New System.Windows.Forms.CheckBox()
        Me.CheckBox20 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bookListView
        '
        Me.bookListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bookListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.bookListView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bookListView.Font = New System.Drawing.Font("Sitka Subheading", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookListView.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.bookListView.GridLines = True
        Me.bookListView.HideSelection = False
        Me.bookListView.Location = New System.Drawing.Point(0, 171)
        Me.bookListView.Margin = New System.Windows.Forms.Padding(2)
        Me.bookListView.MultiSelect = False
        Me.bookListView.Name = "bookListView"
        Me.bookListView.Size = New System.Drawing.Size(1182, 1221)
        Me.bookListView.TabIndex = 0
        Me.bookListView.UseCompatibleStateImageBehavior = False
        Me.bookListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Title"
        Me.ColumnHeader1.Width = 518
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ISBN"
        Me.ColumnHeader2.Width = 320
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Language"
        Me.ColumnHeader3.Width = 158
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Classification"
        Me.ColumnHeader4.Width = 323
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox21)
        Me.Panel1.Controls.Add(Me.CheckBox17)
        Me.Panel1.Controls.Add(Me.CheckBox18)
        Me.Panel1.Controls.Add(Me.CheckBox19)
        Me.Panel1.Controls.Add(Me.CheckBox20)
        Me.Panel1.Controls.Add(Me.CheckBox13)
        Me.Panel1.Controls.Add(Me.CheckBox14)
        Me.Panel1.Controls.Add(Me.CheckBox15)
        Me.Panel1.Controls.Add(Me.CheckBox16)
        Me.Panel1.Controls.Add(Me.CheckBox12)
        Me.Panel1.Controls.Add(Me.moreClassCombobox)
        Me.Panel1.Controls.Add(Me.CheckBox8)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox10)
        Me.Panel1.Controls.Add(Me.CheckBox11)
        Me.Panel1.Controls.Add(Me.CheckBox7)
        Me.Panel1.Controls.Add(Me.CheckBox9)
        Me.Panel1.Controls.Add(Me.CheckBox0)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox6)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.CheckBox5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1182, 156)
        Me.Panel1.TabIndex = 1
        '
        'moreClassCombobox
        '
        Me.moreClassCombobox.Font = New System.Drawing.Font("Sitka Display", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moreClassCombobox.FormattingEnabled = True
        Me.moreClassCombobox.Location = New System.Drawing.Point(962, 110)
        Me.moreClassCombobox.Margin = New System.Windows.Forms.Padding(2)
        Me.moreClassCombobox.Name = "moreClassCombobox"
        Me.moreClassCombobox.Size = New System.Drawing.Size(207, 40)
        Me.moreClassCombobox.TabIndex = 2
        Me.moreClassCombobox.Text = "Others"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.Location = New System.Drawing.Point(349, 70)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(122, 27)
        Me.CheckBox8.TabIndex = 1
        Me.CheckBox8.Text = "Social Sciences"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(70, 98)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(270, 27)
        Me.CheckBox4.TabIndex = 1
        Me.CheckBox4.Text = "World History and History of Asia, etc"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox10.Location = New System.Drawing.Point(349, 127)
        Me.CheckBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(55, 27)
        Me.CheckBox10.TabIndex = 1
        Me.CheckBox10.Text = "Law"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox11.Location = New System.Drawing.Point(625, 8)
        Me.CheckBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(92, 27)
        Me.CheckBox11.TabIndex = 1
        Me.CheckBox11.Text = "Education"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.Location = New System.Drawing.Point(349, 39)
        Me.CheckBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(266, 27)
        Me.CheckBox7.TabIndex = 1
        Me.CheckBox7.Text = "Geography, Anthropology, Recreation"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox9.Location = New System.Drawing.Point(349, 98)
        Me.CheckBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(129, 27)
        Me.CheckBox9.TabIndex = 1
        Me.CheckBox9.Text = "Political Science"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox0
        '
        Me.CheckBox0.AutoSize = True
        Me.CheckBox0.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox0.Location = New System.Drawing.Point(2, 8)
        Me.CheckBox0.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox0.Name = "CheckBox0"
        Me.CheckBox0.Size = New System.Drawing.Size(46, 27)
        Me.CheckBox0.TabIndex = 1
        Me.CheckBox0.Text = "All"
        Me.CheckBox0.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(70, 70)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(209, 27)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.Text = "Auxiliary Sciences of History"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(349, 8)
        Me.CheckBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(216, 27)
        Me.CheckBox6.TabIndex = 1
        Me.CheckBox6.Text = "Local History of the Americas"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(70, 39)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(234, 27)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Philosophy. Psychology. Religion"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(70, 8)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 27)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "General Works"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(70, 127)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(155, 27)
        Me.CheckBox5.TabIndex = 1
        Me.CheckBox5.Text = "History of Americas"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox12.Location = New System.Drawing.Point(625, 39)
        Me.CheckBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(65, 27)
        Me.CheckBox12.TabIndex = 3
        Me.CheckBox12.Text = "Music"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox13.Location = New System.Drawing.Point(821, 8)
        Me.CheckBox13.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(85, 27)
        Me.CheckBox13.TabIndex = 7
        Me.CheckBox13.Text = "Medicine"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox14.Location = New System.Drawing.Point(625, 98)
        Me.CheckBox14.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(184, 27)
        Me.CheckBox14.TabIndex = 4
        Me.CheckBox14.Text = "Language and Literature"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox15.Location = New System.Drawing.Point(625, 127)
        Me.CheckBox15.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(75, 27)
        Me.CheckBox15.TabIndex = 5
        Me.CheckBox15.Text = "Science"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox16.Location = New System.Drawing.Point(625, 70)
        Me.CheckBox16.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(86, 27)
        Me.CheckBox16.TabIndex = 6
        Me.CheckBox16.Text = "Fine Arts"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox17.Location = New System.Drawing.Point(820, 127)
        Me.CheckBox17.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(114, 27)
        Me.CheckBox17.TabIndex = 11
        Me.CheckBox17.Text = "Naval Science"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox18.Location = New System.Drawing.Point(821, 70)
        Me.CheckBox18.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(101, 27)
        Me.CheckBox18.TabIndex = 8
        Me.CheckBox18.Text = "Technology"
        Me.CheckBox18.UseVisualStyleBackColor = True
        '
        'CheckBox19
        '
        Me.CheckBox19.AutoSize = True
        Me.CheckBox19.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox19.Location = New System.Drawing.Point(820, 98)
        Me.CheckBox19.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(128, 27)
        Me.CheckBox19.TabIndex = 9
        Me.CheckBox19.Text = "Military Science"
        Me.CheckBox19.UseVisualStyleBackColor = True
        '
        'CheckBox20
        '
        Me.CheckBox20.AutoSize = True
        Me.CheckBox20.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox20.Location = New System.Drawing.Point(820, 39)
        Me.CheckBox20.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(100, 27)
        Me.CheckBox20.TabIndex = 10
        Me.CheckBox20.Text = "Agriculture"
        Me.CheckBox20.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox21.Location = New System.Drawing.Point(947, 8)
        Me.CheckBox21.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(213, 27)
        Me.CheckBox21.TabIndex = 12
        Me.CheckBox21.Text = "Bibliography, Library Science"
        Me.CheckBox21.UseVisualStyleBackColor = True
        '
        'collectionsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.bookListView)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "collectionsUserControl"
        Me.Size = New System.Drawing.Size(1182, 1392)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bookListView As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents moreClassCombobox As ComboBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox0 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox21 As CheckBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox18 As CheckBox
    Friend WithEvents CheckBox19 As CheckBox
    Friend WithEvents CheckBox20 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
End Class
