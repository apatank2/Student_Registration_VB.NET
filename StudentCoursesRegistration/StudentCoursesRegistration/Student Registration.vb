Imports System.Data.SqlClient

Public Class Registration
    Private SQL As New SQL_Connection
    Private Sub DOB_Click(sender As Object, e As EventArgs) Handles DOB.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles ReEnterPassword.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles UniversityName.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderBox.SelectedIndexChanged

    End Sub

    Private Sub Name_Box_TextChanged(sender As Object, e As EventArgs) Handles Name_Box.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles PasswordBox.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles CountryBox.TextChanged

    End Sub
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        If Name_Box.Text = "" Then

            MsgBox("Please enter the Name")
            GoTo ProcExit

        End If
        If EmailBox.Text = "" Then

            MsgBox("Please enter the EmailId")
            GoTo ProcExit

        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(EmailBox.Text, "@") Then
            MsgBox("EmailID is Not Valid")
            GoTo ProcExit
        End If

        If PasswordBox.Text = "" Then

            MsgBox("Please enter the Password")
            GoTo ProcExit

        End If
        If PasswordBox.Text.Length < 5 Then
            MsgBox("Length of password should be minimum 6 Characters")
            GoTo ProcExit
        End If
        Dim re As New Text.RegularExpressions.Regex("\d")
        If Not re.IsMatch(PasswordBox.Text) Then
            MsgBox("Password must contain at least one digit")
            GoTo ProcExit
        End If
        If Not System.Text.RegularExpressions.Regex.IsMatch(PasswordBox.Text, "[A-Za-z]") Then
            MsgBox("Password must contain at least one alphabet")
            GoTo ProcExit
        End If
        If CountryBox.Text = "" Then

            MsgBox("Please enter the Country of Residence")
            GoTo ProcExit

        End If
        If UniversityBox.Text = "" Then

            MsgBox("Please enter the name of a University")
            GoTo ProcExit

        End If
        If EmailBox.Text = ReEnterEmailBox.Text Then

        Else
            MsgBox("Email ID should be same")
            GoTo ProcExit
        End If

        If PasswordBox.Text = RePasswordBox.Text Then
        Else
            MsgBox("Password should be same")
            GoTo ProcExit
        End If
        If GenderBox.Text = "" Then

            MsgBox("Please select the Gender")
            GoTo ProcExit

        End If
        Dim query As String = String.Empty

        Dim strName As String = Name_Box.Text
        Dim strEmail As String = EmailBox.Text
        Dim strpasswd As String = PasswordBox.Text
        Dim strgender As String = GenderBox.Text
        Dim strcountry As String = CountryBox.Text
        Dim struniv_name As String = UniversityBox.Text
        Dim str_dob As String = DateTimePicker1.Value.ToShortDateString
        Dim intId As Integer = GetId()

        If SQL.HasConnection = True Then
            If AuthorizeRegistration() = True Then
                MsgBox("Enter an Email Address that isn't already in use.")
            Else

                query &= "INSERT INTO registration (studentid, student_name, student_Email, "
                query &= "                     student_passwd, student_gender, country,univ_name,student_dob)  "
                query &= "VALUES (@studentid,@student_name, @student_Email, @student_passwd,@student_gender, @country,@univ_name,@dob)"

                Using conn As New SqlConnection("Server=LAPTOP-F7MLHVFD;Database=Student_portal;Trusted_Connection=Yes")
                    Using comm As New SqlCommand()
                        With comm
                            .Connection = conn
                            .CommandType = CommandType.Text
                            .CommandText = query
                            .Parameters.AddWithValue("@studentid", intId)
                            .Parameters.AddWithValue("@student_name", strName)
                            .Parameters.AddWithValue("@student_Email", strEmail)
                            .Parameters.AddWithValue("@student_passwd", strpasswd)
                            .Parameters.AddWithValue("@student_gender", strgender)
                            .Parameters.AddWithValue("@country", strcountry)
                            .Parameters.AddWithValue("@univ_name", struniv_name)
                            .Parameters.AddWithValue("@dob", str_dob)
                        End With
                        Try
                            conn.Open()
                            comm.ExecuteNonQuery()
                            Close()
                            MsgBox("Registered Successfully!")
                            Form1.Show()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message.ToString(), "Error Message")
                        End Try
                    End Using
                End Using
            End If
        End If
ProcExit:
    End Sub
    Private Function AuthorizeRegistration() As Boolean
        ' CLEAR EXISTING RECORDS
        If SQL.SQLDS IsNot Nothing Then
            SQL.SQLDS.Clear()
        End If
        SQL.RunQuery("select count(student_email) As Student_Count " &
                     "from registration " &
                     "where student_email = '" & EmailBox.Text & "' ")

        If SQL.SQLDS.Tables(0).Rows(0).Item("Student_Count") = 1 Then
            Return True
        End If


        Return False


    End Function

    Private Function GetId() As Integer
        ' CLEAR EXISTING RECORDS
        If SQL.SQLDS IsNot Nothing Then
            SQL.SQLDS.Clear()
        End If
        SQL.RunQuery("select NEXT VALUE FOR Registration_Seq as Seq ")

        Return SQL.SQLDS.Tables(0).Rows(0).Item("Seq") + 1
    End Function
End Class