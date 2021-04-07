<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewBookUserControl
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
        Me.bookDisp = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'bookDisp
        '
        Me.bookDisp.AutoSize = True
        Me.bookDisp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.bookDisp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.bookDisp.Location = New System.Drawing.Point(3, 3)
        Me.bookDisp.Name = "bookDisp"
        Me.bookDisp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.bookDisp.Size = New System.Drawing.Size(0, 0)
        Me.bookDisp.TabIndex = 0
        '
        'ViewBookUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.bookDisp)
        Me.Name = "ViewBookUserControl"
        Me.Size = New System.Drawing.Size(6, 6)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bookDisp As FlowLayoutPanel
End Class
