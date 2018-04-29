Public Class Form1
    Private SQL As New SQL_Connection

    Private Sub StudentLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Username_Click(sender As Object, e As EventArgs) Handles UserName_Label.Click

    End Sub

    Private Sub LoginLabel_Click(sender As Object, e As EventArgs) Handles Login_Label.Click

    End Sub

    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register_Button.Click
        Hide()
        Username_Txt.Text = ""
        PasswordTxt.Text = ""
        Registration.Show()

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login_button.Click
        If SQL.HasConnection = True Then
            If AuthorizeStudent() = True Then
                MsgBox("Login Successful")
                Dim OBJ As New Main
                OBJ.StudentId = GetStudentId()
                Hide()
                OBJ.Show()
            End If
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Username_Txt.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PasswordTxt.TextChanged

    End Sub

    Private Function AuthorizeStudent() As Boolean
        ' CLEAR EXISTING RECORDS
        If SQL.SQLDS IsNot Nothing Then
            SQL.SQLDS.Clear()
        End If
        SQL.RunQuery("select count(student_email) As Student_Count " &
                     "from registration " &
                     "where student_email = '" & Username_Txt.Text & "' " &
                     " AND student_passwd = '" & PasswordTxt.Text & "' ")

        If SQL.SQLDS.Tables(0).Rows(0).Item("Student_Count") = 1 Then
            Return True
        End If

        MsgBox("Invalid Credentials", MsgBoxStyle.Critical, "Login Failed")
        Application.Restart()

        Me.Refresh()
        Return False


    End Function

    Private Function GetStudentId() As Integer
        ' CLEAR EXISTING RECORDS
        If SQL.SQLDS IsNot Nothing Then
            SQL.SQLDS.Clear()
        End If
        SQL.RunQuery("select studentid As studentid " &
                     "from registration " &
                     "where student_email = '" & Username_Txt.Text & "' " &
                     " AND student_passwd = '" & PasswordTxt.Text & "' ")


        Return SQL.SQLDS.Tables(0).Rows(0).Item("studentid")


    End Function
End Class
