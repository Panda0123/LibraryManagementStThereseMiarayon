<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recordsUserControl
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Cover_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Status_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShelfID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complete_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1723, 1500)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1715, 1458)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Borrow List"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(1, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1714, 655)
        Me.Panel2.TabIndex = 1
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
        Me.DataGridView1.Size = New System.Drawing.Size(1714, 1338)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox22)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 69)
        Me.Panel1.TabIndex = 0
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
        Me.TabPage4.Size = New System.Drawing.Size(1715, 1458)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Return List"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage5.Controls.Add(Me.Panel4)
        Me.TabPage5.Controls.Add(Me.Panel3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1715, 1458)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Reserve List"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.DataGridView2)
        Me.Panel4.Location = New System.Drawing.Point(1, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(756, 669)
        Me.Panel4.TabIndex = 2
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
        Me.DataGridView2.Size = New System.Drawing.Size(1065, 646)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.TextBox21)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(749, 69)
        Me.Panel3.TabIndex = 1
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
        'recordsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "recordsUserControl"
        Me.Size = New System.Drawing.Size(1723, 1500)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cover_Column As DataGridViewImageColumn
    Friend WithEvents Status_Column As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents DueDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents Title_Column As DataGridViewTextBoxColumn
    Friend WithEvents ShelfID_Column As DataGridViewTextBoxColumn
    Friend WithEvents ID_Column As DataGridViewTextBoxColumn
    Friend WithEvents Button_Column As DataGridViewButtonColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ReserveDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Complete_Column As DataGridViewButtonColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox21 As TextBox
End Class
