<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.StudentInfo = New System.Windows.Forms.GroupBox()
        Me.UnivText = New System.Windows.Forms.Label()
        Me.AgeText = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.Label()
        Me.University = New System.Windows.Forms.Label()
        Me.Age = New System.Windows.Forms.Label()
        Me.NameGrid = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextFileImport = New System.Windows.Forms.Button()
        Me.Export = New System.Windows.Forms.Button()
        Me.Backup = New System.Windows.Forms.Button()
        Me.CourseWork = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.StudentInfo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentInfo
        '
        Me.StudentInfo.Controls.Add(Me.UnivText)
        Me.StudentInfo.Controls.Add(Me.AgeText)
        Me.StudentInfo.Controls.Add(Me.NameText)
        Me.StudentInfo.Controls.Add(Me.University)
        Me.StudentInfo.Controls.Add(Me.Age)
        Me.StudentInfo.Controls.Add(Me.NameGrid)
        Me.StudentInfo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentInfo.Location = New System.Drawing.Point(30, 46)
        Me.StudentInfo.Name = "StudentInfo"
        Me.StudentInfo.Size = New System.Drawing.Size(252, 136)
        Me.StudentInfo.TabIndex = 0
        Me.StudentInfo.TabStop = False
        Me.StudentInfo.Text = "Student Information"
        '
        'UnivText
        '
        Me.UnivText.AutoSize = True
        Me.UnivText.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnivText.Location = New System.Drawing.Point(84, 86)
        Me.UnivText.Name = "UnivText"
        Me.UnivText.Size = New System.Drawing.Size(55, 15)
        Me.UnivText.TabIndex = 11
        Me.UnivText.Text = "UnivText"
        Me.UnivText.UseMnemonic = False
        '
        'AgeText
        '
        Me.AgeText.AutoSize = True
        Me.AgeText.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeText.Location = New System.Drawing.Point(84, 58)
        Me.AgeText.Name = "AgeText"
        Me.AgeText.Size = New System.Drawing.Size(52, 15)
        Me.AgeText.TabIndex = 10
        Me.AgeText.Text = "AgeText"
        Me.AgeText.UseMnemonic = False
        '
        'NameText
        '
        Me.NameText.AutoSize = True
        Me.NameText.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameText.Location = New System.Drawing.Point(84, 30)
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(59, 15)
        Me.NameText.TabIndex = 8
        Me.NameText.Text = "NameText"
        Me.NameText.UseMnemonic = False
        '
        'University
        '
        Me.University.AutoSize = True
        Me.University.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.University.Location = New System.Drawing.Point(6, 86)
        Me.University.Name = "University"
        Me.University.Size = New System.Drawing.Size(69, 15)
        Me.University.TabIndex = 7
        Me.University.Text = "University :"
        Me.University.UseMnemonic = False
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age.Location = New System.Drawing.Point(6, 58)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(36, 15)
        Me.Age.TabIndex = 6
        Me.Age.Text = "Age :"
        Me.Age.UseMnemonic = False
        '
        'NameGrid
        '
        Me.NameGrid.AutoSize = True
        Me.NameGrid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameGrid.Location = New System.Drawing.Point(6, 30)
        Me.NameGrid.Name = "NameGrid"
        Me.NameGrid.Size = New System.Drawing.Size(43, 15)
        Me.NameGrid.TabIndex = 5
        Me.NameGrid.Text = "Name :"
        Me.NameGrid.UseMnemonic = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(288, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(661, 335)
        Me.DataGridView1.TabIndex = 1
        '
        'TextFileImport
        '
        Me.TextFileImport.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFileImport.Location = New System.Drawing.Point(305, 404)
        Me.TextFileImport.Name = "TextFileImport"
        Me.TextFileImport.Size = New System.Drawing.Size(118, 34)
        Me.TextFileImport.TabIndex = 2
        Me.TextFileImport.Text = "Import from text file"
        Me.TextFileImport.UseVisualStyleBackColor = True
        '
        'Export
        '
        Me.Export.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Export.Location = New System.Drawing.Point(557, 404)
        Me.Export.Name = "Export"
        Me.Export.Size = New System.Drawing.Size(121, 34)
        Me.Export.TabIndex = 3
        Me.Export.Text = "Export to text file"
        Me.Export.UseVisualStyleBackColor = True
        '
        'Backup
        '
        Me.Backup.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Backup.Location = New System.Drawing.Point(822, 404)
        Me.Backup.Name = "Backup"
        Me.Backup.Size = New System.Drawing.Size(113, 34)
        Me.Backup.TabIndex = 4
        Me.Backup.Text = "Back Up Database"
        Me.Backup.UseVisualStyleBackColor = True
        '
        'CourseWork
        '
        Me.CourseWork.AutoSize = True
        Me.CourseWork.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseWork.Location = New System.Drawing.Point(284, 9)
        Me.CourseWork.Name = "CourseWork"
        Me.CourseWork.Size = New System.Drawing.Size(152, 19)
        Me.CourseWork.TabIndex = 5
        Me.CourseWork.Text = "Graduate Course Work"
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(39, 390)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(127, 48)
        Me.logout.TabIndex = 6
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 450)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.CourseWork)
        Me.Controls.Add(Me.Backup)
        Me.Controls.Add(Me.Export)
        Me.Controls.Add(Me.TextFileImport)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StudentInfo)
        Me.Name = "Main"
        Me.Text = "Form2"
        Me.StudentInfo.ResumeLayout(False)
        Me.StudentInfo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentInfo As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextFileImport As Button
    Friend WithEvents Export As Button
    Friend WithEvents Backup As Button
    Friend WithEvents University As Label
    Friend WithEvents Age As Label
    Friend WithEvents NameGrid As Label
    Friend WithEvents UnivText As Label
    Friend WithEvents AgeText As Label
    Friend WithEvents NameText As Label
    Friend WithEvents CourseWork As Label
    Friend WithEvents logout As Button
End Class
