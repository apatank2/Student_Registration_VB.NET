<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_Box = New System.Windows.Forms.TextBox()
        Me.DOB = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Email_Text = New System.Windows.Forms.Label()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.ReEnterEmail = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.ReEnterPassword = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.Country = New System.Windows.Forms.Label()
        Me.UniversityName = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ReEnterEmailBox = New System.Windows.Forms.TextBox()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.RePasswordBox = New System.Windows.Forms.TextBox()
        Me.CountryBox = New System.Windows.Forms.TextBox()
        Me.UniversityBox = New System.Windows.Forms.TextBox()
        Me.GenderBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Name_Box
        '
        Me.Name_Box.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Box.Location = New System.Drawing.Point(341, 42)
        Me.Name_Box.Name = "Name_Box"
        Me.Name_Box.Size = New System.Drawing.Size(167, 22)
        Me.Name_Box.TabIndex = 1
        '
        'DOB
        '
        Me.DOB.AutoSize = True
        Me.DOB.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.Location = New System.Drawing.Point(174, 76)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(52, 22)
        Me.DOB.TabIndex = 2
        Me.DOB.Text = "DOB"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(341, 78)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(167, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Email_Text
        '
        Me.Email_Text.AutoSize = True
        Me.Email_Text.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Text.Location = New System.Drawing.Point(174, 109)
        Me.Email_Text.Name = "Email_Text"
        Me.Email_Text.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Email_Text.Size = New System.Drawing.Size(58, 22)
        Me.Email_Text.TabIndex = 4
        Me.Email_Text.Text = "Email"
        '
        'EmailBox
        '
        Me.EmailBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailBox.Location = New System.Drawing.Point(341, 111)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(167, 22)
        Me.EmailBox.TabIndex = 5
        '
        'ReEnterEmail
        '
        Me.ReEnterEmail.AutoSize = True
        Me.ReEnterEmail.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReEnterEmail.Location = New System.Drawing.Point(174, 143)
        Me.ReEnterEmail.Name = "ReEnterEmail"
        Me.ReEnterEmail.Size = New System.Drawing.Size(134, 22)
        Me.ReEnterEmail.TabIndex = 6
        Me.ReEnterEmail.Text = "Re-enter Email"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(174, 174)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(90, 22)
        Me.Password.TabIndex = 7
        Me.Password.Text = "Password"
        '
        'ReEnterPassword
        '
        Me.ReEnterPassword.AutoSize = True
        Me.ReEnterPassword.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReEnterPassword.Location = New System.Drawing.Point(174, 206)
        Me.ReEnterPassword.Name = "ReEnterPassword"
        Me.ReEnterPassword.Size = New System.Drawing.Size(166, 22)
        Me.ReEnterPassword.TabIndex = 8
        Me.ReEnterPassword.Text = "Re-enter Password"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.Location = New System.Drawing.Point(174, 242)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(71, 22)
        Me.Gender.TabIndex = 9
        Me.Gender.Text = "Gender"
        '
        'Country
        '
        Me.Country.AutoSize = True
        Me.Country.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Country.Location = New System.Drawing.Point(174, 275)
        Me.Country.Name = "Country"
        Me.Country.Size = New System.Drawing.Size(77, 22)
        Me.Country.TabIndex = 10
        Me.Country.Text = "Country"
        '
        'UniversityName
        '
        Me.UniversityName.AutoSize = True
        Me.UniversityName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniversityName.Location = New System.Drawing.Point(174, 308)
        Me.UniversityName.Name = "UniversityName"
        Me.UniversityName.Size = New System.Drawing.Size(145, 22)
        Me.UniversityName.TabIndex = 11
        Me.UniversityName.Text = "University Name"
        '
        'RegisterButton
        '
        Me.RegisterButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(260, 346)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(157, 33)
        Me.RegisterButton.TabIndex = 12
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'ReEnterEmailBox
        '
        Me.ReEnterEmailBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReEnterEmailBox.Location = New System.Drawing.Point(341, 143)
        Me.ReEnterEmailBox.Name = "ReEnterEmailBox"
        Me.ReEnterEmailBox.Size = New System.Drawing.Size(167, 22)
        Me.ReEnterEmailBox.TabIndex = 13
        '
        'PasswordBox
        '
        Me.PasswordBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.Location = New System.Drawing.Point(341, 174)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(167, 22)
        Me.PasswordBox.TabIndex = 14
        Me.PasswordBox.UseSystemPasswordChar = True
        '
        'RePasswordBox
        '
        Me.RePasswordBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RePasswordBox.Location = New System.Drawing.Point(341, 206)
        Me.RePasswordBox.Name = "RePasswordBox"
        Me.RePasswordBox.Size = New System.Drawing.Size(167, 22)
        Me.RePasswordBox.TabIndex = 15
        Me.RePasswordBox.UseSystemPasswordChar = True
        '
        'CountryBox
        '
        Me.CountryBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryBox.Location = New System.Drawing.Point(341, 275)
        Me.CountryBox.Name = "CountryBox"
        Me.CountryBox.Size = New System.Drawing.Size(167, 22)
        Me.CountryBox.TabIndex = 16
        '
        'UniversityBox
        '
        Me.UniversityBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniversityBox.Location = New System.Drawing.Point(341, 308)
        Me.UniversityBox.Name = "UniversityBox"
        Me.UniversityBox.Size = New System.Drawing.Size(167, 22)
        Me.UniversityBox.TabIndex = 17
        '
        'GenderBox
        '
        Me.GenderBox.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderBox.FormattingEnabled = True
        Me.GenderBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderBox.Location = New System.Drawing.Point(341, 242)
        Me.GenderBox.Name = "GenderBox"
        Me.GenderBox.Size = New System.Drawing.Size(167, 23)
        Me.GenderBox.TabIndex = 18
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GenderBox)
        Me.Controls.Add(Me.UniversityBox)
        Me.Controls.Add(Me.CountryBox)
        Me.Controls.Add(Me.RePasswordBox)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.ReEnterEmailBox)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.UniversityName)
        Me.Controls.Add(Me.Country)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.ReEnterPassword)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.ReEnterEmail)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.Email_Text)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DOB)
        Me.Controls.Add(Me.Name_Box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registration"
        Me.Text = "Student Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Name_Box As TextBox
    Friend WithEvents DOB As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Email_Text As Label
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents ReEnterPassword As Label
    Friend WithEvents Gender As Label
    Friend WithEvents Country As Label
    Friend WithEvents UniversityName As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents ReEnterEmailBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents RePasswordBox As TextBox
    Friend WithEvents CountryBox As TextBox
    Friend WithEvents UniversityBox As TextBox
    Friend WithEvents ReEnterEmail As Label
    Friend WithEvents GenderBox As ComboBox
End Class
