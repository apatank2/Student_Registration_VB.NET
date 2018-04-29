<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Login_Label = New System.Windows.Forms.Label()
        Me.Username_Txt = New System.Windows.Forms.TextBox()
        Me.UserName_Label = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Password_Label = New System.Windows.Forms.Label()
        Me.Login_button = New System.Windows.Forms.Button()
        Me.Register_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Login_Label
        '
        Me.Login_Label.AutoSize = True
        Me.Login_Label.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Label.Location = New System.Drawing.Point(169, 49)
        Me.Login_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Login_Label.Name = "Login_Label"
        Me.Login_Label.Size = New System.Drawing.Size(428, 31)
        Me.Login_Label.TabIndex = 0
        Me.Login_Label.Text = "Please enter your login information"
        '
        'Username_Txt
        '
        Me.Username_Txt.CausesValidation = False
        Me.Username_Txt.Location = New System.Drawing.Point(332, 132)
        Me.Username_Txt.MaxLength = 100
        Me.Username_Txt.Name = "Username_Txt"
        Me.Username_Txt.Size = New System.Drawing.Size(139, 26)
        Me.Username_Txt.TabIndex = 1
        '
        'UserName_Label
        '
        Me.UserName_Label.AutoSize = True
        Me.UserName_Label.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_Label.Location = New System.Drawing.Point(227, 135)
        Me.UserName_Label.Name = "UserName_Label"
        Me.UserName_Label.Size = New System.Drawing.Size(85, 19)
        Me.UserName_Label.TabIndex = 3
        Me.UserName_Label.Text = "User Name"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.CausesValidation = False
        Me.PasswordTxt.Location = New System.Drawing.Point(332, 176)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(139, 26)
        Me.PasswordTxt.TabIndex = 5
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'Password_Label
        '
        Me.Password_Label.AutoSize = True
        Me.Password_Label.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_Label.Location = New System.Drawing.Point(227, 179)
        Me.Password_Label.Name = "Password_Label"
        Me.Password_Label.Size = New System.Drawing.Size(72, 19)
        Me.Password_Label.TabIndex = 6
        Me.Password_Label.Text = "Password"
        '
        'Login_button
        '
        Me.Login_button.Location = New System.Drawing.Point(175, 246)
        Me.Login_button.Name = "Login_button"
        Me.Login_button.Size = New System.Drawing.Size(124, 45)
        Me.Login_button.TabIndex = 7
        Me.Login_button.Text = "Login"
        Me.Login_button.UseVisualStyleBackColor = True
        '
        'Register_Button
        '
        Me.Register_Button.Location = New System.Drawing.Point(473, 246)
        Me.Register_Button.Name = "Register_Button"
        Me.Register_Button.Size = New System.Drawing.Size(124, 45)
        Me.Register_Button.TabIndex = 8
        Me.Register_Button.Text = "Registration"
        Me.Register_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 369)
        Me.Controls.Add(Me.Register_Button)
        Me.Controls.Add(Me.Login_button)
        Me.Controls.Add(Me.Password_Label)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.UserName_Label)
        Me.Controls.Add(Me.Username_Txt)
        Me.Controls.Add(Me.Login_Label)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Student Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login_Label As Label
    Friend WithEvents Username_Txt As TextBox
    Friend WithEvents UserName_Label As Label
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents Password_Label As Label
    Friend WithEvents Login_button As Button
    Friend WithEvents Register_Button As Button
End Class
