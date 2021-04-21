Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateAccount
    Inherits MetroForm

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StyleManager = msmMain
    End Sub

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
        Me.components = New System.ComponentModel.Container()
        Me.msmMain = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.nxtBtn = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.newUsername = New System.Windows.Forms.TextBox()
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msmMain
        '
        Me.msmMain.Owner = Me
        '
        'nxtBtn
        '
        Me.nxtBtn.Location = New System.Drawing.Point(408, 305)
        Me.nxtBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.nxtBtn.Name = "nxtBtn"
        Me.nxtBtn.Size = New System.Drawing.Size(127, 50)
        Me.nxtBtn.TabIndex = 1
        Me.nxtBtn.Text = "Next"
        Me.nxtBtn.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(5, 14)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(141, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Update Account"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(37, 97)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(133, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "New Username"
        '
        'newUsername
        '
        Me.newUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.newUsername.Font = New System.Drawing.Font("Sitka Display", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newUsername.Location = New System.Drawing.Point(37, 139)
        Me.newUsername.Name = "newUsername"
        Me.newUsername.Size = New System.Drawing.Size(417, 33)
        Me.newUsername.TabIndex = 3
        '
        'UpdateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(586, 428)
        Me.Controls.Add(Me.newUsername)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.nxtBtn)
        Me.DisplayHeader = False
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateAccount"
        Me.Padding = New System.Windows.Forms.Padding(27, 44, 27, 25)
        Me.Resizable = False
        CType(Me.msmMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents msmMain As MetroFramework.Components.MetroStyleManager
    Private WithEvents nxtBtn As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents newUsername As TextBox
End Class
