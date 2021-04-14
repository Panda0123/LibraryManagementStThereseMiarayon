<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewBookUserControl
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
        Me.bookDisplayFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.PageNumLabel = New System.Windows.Forms.Label()
        Me.prevLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.nextLnkLbl = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'bookDisplayFlowPanel
        '
        Me.bookDisplayFlowPanel.AutoScroll = True
        Me.bookDisplayFlowPanel.BackColor = System.Drawing.Color.White
        Me.bookDisplayFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.bookDisplayFlowPanel.Location = New System.Drawing.Point(0, 50)
        Me.bookDisplayFlowPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bookDisplayFlowPanel.Name = "bookDisplayFlowPanel"
        Me.bookDisplayFlowPanel.Size = New System.Drawing.Size(1411, 1690)
        Me.bookDisplayFlowPanel.TabIndex = 0
        Me.bookDisplayFlowPanel.WrapContents = False
        '
        'PageNumLabel
        '
        Me.PageNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PageNumLabel.AutoSize = True
        Me.PageNumLabel.Location = New System.Drawing.Point(724, 16)
        Me.PageNumLabel.Name = "PageNumLabel"
        Me.PageNumLabel.Size = New System.Drawing.Size(53, 17)
        Me.PageNumLabel.TabIndex = 17
        Me.PageNumLabel.Text = "Page 1"
        '
        'prevLnkLbl
        '
        Me.prevLnkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.prevLnkLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.prevLnkLbl.AutoSize = True
        Me.prevLnkLbl.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prevLnkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.prevLnkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.prevLnkLbl.Location = New System.Drawing.Point(568, 10)
        Me.prevLnkLbl.Name = "prevLnkLbl"
        Me.prevLnkLbl.Size = New System.Drawing.Size(87, 25)
        Me.prevLnkLbl.TabIndex = 18
        Me.prevLnkLbl.TabStop = True
        Me.prevLnkLbl.Text = "Previous"
        '
        'nextLnkLbl
        '
        Me.nextLnkLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.nextLnkLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.nextLnkLbl.AutoSize = True
        Me.nextLnkLbl.Font = New System.Drawing.Font("Sitka Small", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextLnkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.nextLnkLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.nextLnkLbl.Location = New System.Drawing.Point(864, 10)
        Me.nextLnkLbl.Name = "nextLnkLbl"
        Me.nextLnkLbl.Size = New System.Drawing.Size(53, 25)
        Me.nextLnkLbl.TabIndex = 19
        Me.nextLnkLbl.TabStop = True
        Me.nextLnkLbl.Text = "Next"
        '
        'viewBookUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PageNumLabel)
        Me.Controls.Add(Me.prevLnkLbl)
        Me.Controls.Add(Me.nextLnkLbl)
        Me.Controls.Add(Me.bookDisplayFlowPanel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "viewBookUserControl"
        Me.Size = New System.Drawing.Size(1413, 1740)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bookDisplayFlowPanel As FlowLayoutPanel
    Friend WithEvents PageNumLabel As Label
    Friend WithEvents prevLnkLbl As LinkLabel
    Friend WithEvents nextLnkLbl As LinkLabel
End Class