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
        Me.SuspendLayout()
        '
        'bookDisplayFlowPanel
        '
        Me.bookDisplayFlowPanel.AutoScroll = True
        Me.bookDisplayFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bookDisplayFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.bookDisplayFlowPanel.Location = New System.Drawing.Point(0, 0)
        Me.bookDisplayFlowPanel.Name = "bookDisplayFlowPanel"
        Me.bookDisplayFlowPanel.Size = New System.Drawing.Size(1414, 1740)
        Me.bookDisplayFlowPanel.TabIndex = 0
        Me.bookDisplayFlowPanel.WrapContents = False
        '
        'viewBookUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.bookDisplayFlowPanel)
        Me.Name = "viewBookUserControl"
        Me.Size = New System.Drawing.Size(1414, 1740)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bookDisplayFlowPanel As FlowLayoutPanel
End Class
