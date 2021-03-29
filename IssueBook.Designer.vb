<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IssueBook
    Inherits System.Windows.Forms.Form

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
        Me.tbControlMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tabPage_BookCirculation = New System.Windows.Forms.TabPage()
        Me.splitContainer_BookCirculation = New System.Windows.Forms.SplitContainer()
        Me.button_IssueBook = New System.Windows.Forms.Button()
        Me.tbControlMain.SuspendLayout()
        Me.tabPage_BookCirculation.SuspendLayout()
        CType(Me.splitContainer_BookCirculation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer_BookCirculation.Panel1.SuspendLayout()
        Me.splitContainer_BookCirculation.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbControlMain
        '
        Me.tbControlMain.Controls.Add(Me.TabPage1)
        Me.tbControlMain.Controls.Add(Me.tabPage_BookCirculation)
        Me.tbControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbControlMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbControlMain.Location = New System.Drawing.Point(0, 0)
        Me.tbControlMain.Name = "tbControlMain"
        Me.tbControlMain.SelectedIndex = 0
        Me.tbControlMain.Size = New System.Drawing.Size(1214, 605)
        Me.tbControlMain.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1125, 624)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tabPage_BookCirculation
        '
        Me.tabPage_BookCirculation.Controls.Add(Me.splitContainer_BookCirculation)
        Me.tabPage_BookCirculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPage_BookCirculation.Location = New System.Drawing.Point(4, 34)
        Me.tabPage_BookCirculation.Name = "tabPage_BookCirculation"
        Me.tabPage_BookCirculation.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage_BookCirculation.Size = New System.Drawing.Size(1206, 567)
        Me.tabPage_BookCirculation.TabIndex = 1
        Me.tabPage_BookCirculation.Text = "Book Circulation"
        Me.tabPage_BookCirculation.UseVisualStyleBackColor = True
        '
        'splitContainer_BookCirculation
        '
        Me.splitContainer_BookCirculation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer_BookCirculation.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer_BookCirculation.Location = New System.Drawing.Point(3, 3)
        Me.splitContainer_BookCirculation.Name = "splitContainer_BookCirculation"
        '
        'splitContainer_BookCirculation.Panel1
        '
        Me.splitContainer_BookCirculation.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.splitContainer_BookCirculation.Panel1.Controls.Add(Me.button_IssueBook)
        Me.splitContainer_BookCirculation.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splitContainer_BookCirculation.Size = New System.Drawing.Size(1200, 561)
        Me.splitContainer_BookCirculation.SplitterDistance = 249
        Me.splitContainer_BookCirculation.TabIndex = 0
        '
        'button_IssueBook
        '
        Me.button_IssueBook.Location = New System.Drawing.Point(40, 157)
        Me.button_IssueBook.Name = "button_IssueBook"
        Me.button_IssueBook.Size = New System.Drawing.Size(192, 60)
        Me.button_IssueBook.TabIndex = 0
        Me.button_IssueBook.Text = "Issue Book"
        Me.button_IssueBook.UseVisualStyleBackColor = True
        '
        'BorrowBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 605)
        Me.Controls.Add(Me.tbControlMain)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "BorrowBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BorrowBook"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbControlMain.ResumeLayout(False)
        Me.tabPage_BookCirculation.ResumeLayout(False)
        Me.splitContainer_BookCirculation.Panel1.ResumeLayout(False)
        CType(Me.splitContainer_BookCirculation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer_BookCirculation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbControlMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tabPage_BookCirculation As TabPage
    Friend WithEvents splitContainer_BookCirculation As SplitContainer
    Friend WithEvents button_IssueBook As Button
End Class
