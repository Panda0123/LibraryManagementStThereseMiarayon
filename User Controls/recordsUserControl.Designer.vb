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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.borrowListTabPage = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.borrowListDataGrid = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.searchBorrowBtn = New System.Windows.Forms.Button()
        Me.searchBorrowTxtBx = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.reserveListTabPage = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.reservationListDataGrid = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.searchReservationBtn = New System.Windows.Forms.Button()
        Me.searchReservationTxtBx = New System.Windows.Forms.TextBox()
        Me.Cover_Column = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Status_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BorrowDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShelfID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.borrowId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDate_Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reservationId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complete_Column = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabControl.SuspendLayout()
        Me.borrowListTabPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.borrowListDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.reserveListTabPage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.reservationListDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.borrowListTabPage)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Controls.Add(Me.reserveListTabPage)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1292, 1219)
        Me.TabControl.TabIndex = 1
        '
        'borrowListTabPage
        '
        Me.borrowListTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.borrowListTabPage.Controls.Add(Me.Panel2)
        Me.borrowListTabPage.Controls.Add(Me.Panel1)
        Me.borrowListTabPage.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowListTabPage.Location = New System.Drawing.Point(4, 32)
        Me.borrowListTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.borrowListTabPage.Name = "borrowListTabPage"
        Me.borrowListTabPage.Padding = New System.Windows.Forms.Padding(2)
        Me.borrowListTabPage.Size = New System.Drawing.Size(1284, 1183)
        Me.borrowListTabPage.TabIndex = 0
        Me.borrowListTabPage.Text = "Borrow List"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.borrowListDataGrid)
        Me.Panel2.Location = New System.Drawing.Point(1, 54)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1286, 532)
        Me.Panel2.TabIndex = 1
        '
        'borrowListDataGrid
        '
        Me.borrowListDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.borrowListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.borrowListDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cover_Column, Me.Status_Column, Me.BorrowDate_Column, Me.DueDate_Column, Me.Title_Column, Me.ShelfID_Column, Me.ID_Column, Me.borrowId, Me.Button_Column})
        Me.borrowListDataGrid.Location = New System.Drawing.Point(1, 7)
        Me.borrowListDataGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.borrowListDataGrid.Name = "borrowListDataGrid"
        Me.borrowListDataGrid.RowHeadersWidth = 51
        Me.borrowListDataGrid.RowTemplate.Height = 24
        Me.borrowListDataGrid.Size = New System.Drawing.Size(1286, 1087)
        Me.borrowListDataGrid.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.searchBorrowBtn)
        Me.Panel1.Controls.Add(Me.searchBorrowTxtBx)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 56)
        Me.Panel1.TabIndex = 0
        '
        'searchBorrowBtn
        '
        Me.searchBorrowBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.searchBorrowBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBorrowBtn.Location = New System.Drawing.Point(238, 15)
        Me.searchBorrowBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.searchBorrowBtn.Name = "searchBorrowBtn"
        Me.searchBorrowBtn.Size = New System.Drawing.Size(70, 31)
        Me.searchBorrowBtn.TabIndex = 20
        Me.searchBorrowBtn.Text = "Search"
        Me.searchBorrowBtn.UseVisualStyleBackColor = True
        '
        'searchBorrowTxtBx
        '
        Me.searchBorrowTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchBorrowTxtBx.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBorrowTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchBorrowTxtBx.Location = New System.Drawing.Point(32, 16)
        Me.searchBorrowTxtBx.Margin = New System.Windows.Forms.Padding(2)
        Me.searchBorrowTxtBx.Multiline = True
        Me.searchBorrowTxtBx.Name = "searchBorrowTxtBx"
        Me.searchBorrowTxtBx.Size = New System.Drawing.Size(206, 31)
        Me.searchBorrowTxtBx.TabIndex = 19
        Me.searchBorrowTxtBx.Text = "Search ID number..."
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage4.Location = New System.Drawing.Point(4, 32)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Size = New System.Drawing.Size(1284, 1183)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Return List"
        '
        'reserveListTabPage
        '
        Me.reserveListTabPage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.reserveListTabPage.Controls.Add(Me.Panel4)
        Me.reserveListTabPage.Controls.Add(Me.Panel3)
        Me.reserveListTabPage.Location = New System.Drawing.Point(4, 32)
        Me.reserveListTabPage.Margin = New System.Windows.Forms.Padding(2)
        Me.reserveListTabPage.Name = "reserveListTabPage"
        Me.reserveListTabPage.Padding = New System.Windows.Forms.Padding(2)
        Me.reserveListTabPage.Size = New System.Drawing.Size(1284, 1183)
        Me.reserveListTabPage.TabIndex = 2
        Me.reserveListTabPage.Text = "Reserve List"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.reservationListDataGrid)
        Me.Panel4.Location = New System.Drawing.Point(1, 54)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1076, 544)
        Me.Panel4.TabIndex = 2
        '
        'reservationListDataGrid
        '
        Me.reservationListDataGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reservationListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reservationListDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn1, Me.ReserveDate_Column, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.reservationId, Me.Complete_Column})
        Me.reservationListDataGrid.Location = New System.Drawing.Point(1, 7)
        Me.reservationListDataGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.reservationListDataGrid.Name = "reservationListDataGrid"
        Me.reservationListDataGrid.RowHeadersWidth = 51
        Me.reservationListDataGrid.RowTemplate.Height = 24
        Me.reservationListDataGrid.Size = New System.Drawing.Size(1075, 525)
        Me.reservationListDataGrid.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.searchReservationBtn)
        Me.Panel3.Controls.Add(Me.searchReservationTxtBx)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(562, 56)
        Me.Panel3.TabIndex = 1
        '
        'searchReservationBtn
        '
        Me.searchReservationBtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.searchReservationBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReservationBtn.Location = New System.Drawing.Point(238, 15)
        Me.searchReservationBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.searchReservationBtn.Name = "searchReservationBtn"
        Me.searchReservationBtn.Size = New System.Drawing.Size(70, 31)
        Me.searchReservationBtn.TabIndex = 18
        Me.searchReservationBtn.Text = "Search"
        Me.searchReservationBtn.UseVisualStyleBackColor = True
        '
        'searchReservationTxtBx
        '
        Me.searchReservationTxtBx.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchReservationTxtBx.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchReservationTxtBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.searchReservationTxtBx.Location = New System.Drawing.Point(32, 16)
        Me.searchReservationTxtBx.Margin = New System.Windows.Forms.Padding(2)
        Me.searchReservationTxtBx.Multiline = True
        Me.searchReservationTxtBx.Name = "searchReservationTxtBx"
        Me.searchReservationTxtBx.Size = New System.Drawing.Size(206, 31)
        Me.searchReservationTxtBx.TabIndex = 17
        Me.searchReservationTxtBx.Text = "Search ID number..."
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
        Me.Status_Column.ReadOnly = True
        Me.Status_Column.Width = 125
        '
        'BorrowDate_Column
        '
        Me.BorrowDate_Column.HeaderText = "Borrow Date"
        Me.BorrowDate_Column.MinimumWidth = 6
        Me.BorrowDate_Column.Name = "BorrowDate_Column"
        Me.BorrowDate_Column.ReadOnly = True
        Me.BorrowDate_Column.Width = 125
        '
        'DueDate_Column
        '
        Me.DueDate_Column.HeaderText = "Due Date"
        Me.DueDate_Column.MinimumWidth = 6
        Me.DueDate_Column.Name = "DueDate_Column"
        Me.DueDate_Column.ReadOnly = True
        Me.DueDate_Column.Width = 125
        '
        'Title_Column
        '
        Me.Title_Column.HeaderText = "Title"
        Me.Title_Column.MinimumWidth = 6
        Me.Title_Column.Name = "Title_Column"
        Me.Title_Column.ReadOnly = True
        Me.Title_Column.Width = 250
        '
        'ShelfID_Column
        '
        Me.ShelfID_Column.HeaderText = "Copy #"
        Me.ShelfID_Column.MinimumWidth = 6
        Me.ShelfID_Column.Name = "ShelfID_Column"
        Me.ShelfID_Column.ReadOnly = True
        Me.ShelfID_Column.Width = 125
        '
        'ID_Column
        '
        Me.ID_Column.HeaderText = "ID No."
        Me.ID_Column.MinimumWidth = 6
        Me.ID_Column.Name = "ID_Column"
        Me.ID_Column.ReadOnly = True
        Me.ID_Column.Width = 125
        '
        'borrowId
        '
        Me.borrowId.HeaderText = "BorrowID"
        Me.borrowId.Name = "borrowId"
        Me.borrowId.Visible = False
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
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Cover"
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'ReserveDate_Column
        '
        Me.ReserveDate_Column.HeaderText = "Reserve Date"
        Me.ReserveDate_Column.MinimumWidth = 6
        Me.ReserveDate_Column.Name = "ReserveDate_Column"
        Me.ReserveDate_Column.ReadOnly = True
        Me.ReserveDate_Column.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Copy #"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID No."
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'reservationId
        '
        Me.reservationId.HeaderText = "ReservationID"
        Me.reservationId.Name = "reservationId"
        Me.reservationId.ReadOnly = True
        Me.reservationId.Visible = False
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
        'recordsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "recordsUserControl"
        Me.Size = New System.Drawing.Size(1292, 1219)
        Me.TabControl.ResumeLayout(False)
        Me.borrowListTabPage.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.borrowListDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.reserveListTabPage.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.reservationListDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents borrowListTabPage As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents borrowListDataGrid As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents searchBorrowBtn As Button
    Friend WithEvents searchBorrowTxtBx As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents reserveListTabPage As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents reservationListDataGrid As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents searchReservationBtn As Button
    Friend WithEvents searchReservationTxtBx As TextBox
    Friend WithEvents Cover_Column As DataGridViewImageColumn
    Friend WithEvents Status_Column As DataGridViewTextBoxColumn
    Friend WithEvents BorrowDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents DueDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents Title_Column As DataGridViewTextBoxColumn
    Friend WithEvents ShelfID_Column As DataGridViewTextBoxColumn
    Friend WithEvents ID_Column As DataGridViewTextBoxColumn
    Friend WithEvents borrowId As DataGridViewTextBoxColumn
    Friend WithEvents Button_Column As DataGridViewButtonColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ReserveDate_Column As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents reservationId As DataGridViewTextBoxColumn
    Friend WithEvents Complete_Column As DataGridViewButtonColumn
End Class
