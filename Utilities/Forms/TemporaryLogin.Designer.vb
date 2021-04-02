<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemporaryLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.usernameTxtBx = New System.Windows.Forms.TextBox()
        Me.passwordTxtBx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'usernameTxtBx
        '
        Me.usernameTxtBx.Location = New System.Drawing.Point(152, 42)
        Me.usernameTxtBx.Name = "usernameTxtBx"
        Me.usernameTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.usernameTxtBx.TabIndex = 0
        '
        'passwordTxtBx
        '
        Me.passwordTxtBx.Location = New System.Drawing.Point(152, 78)
        Me.passwordTxtBx.Name = "passwordTxtBx"
        Me.passwordTxtBx.Size = New System.Drawing.Size(100, 20)
        Me.passwordTxtBx.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(161, 115)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'TemporaryLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordTxtBx)
        Me.Controls.Add(Me.usernameTxtBx)
        Me.Name = "TemporaryLogin"
        Me.Text = "TemporaryLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents usernameTxtBx As TextBox
    Friend WithEvents passwordTxtBx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loginBtn As Button
End Class
