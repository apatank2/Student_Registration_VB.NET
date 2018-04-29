Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Main
    Public StudentId As Integer
    Private SQL As New SQL_Connection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameText.Text = GetStudentInfo(1)
        AgeText.Text = GetStudentInfo(2)
        UnivText.Text = GetStudentInfo(3)
        DataGridView1.DataSource = GetStudentList()
    End Sub
    Private Function GetStudentList() As DataTable
        Dim studentdtls As New DataTable
        Dim connectionstring As String = "Server=LAPTOP-F7MLHVFD;Database=Student_portal;Trusted_Connection=Yes"
        Using conn As New SqlConnection(connectionstring)
            Using cmd As New SqlCommand("select * from studentdetails where student_id = '" & StudentId & "' ", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                studentdtls.Load(reader)
            End Using
        End Using
        Return studentdtls
    End Function
    Private Function GetStudentInfo(Flag As Integer) As String
        ' CLEAR EXISTING RECORDS
        If SQL.SQLDS IsNot Nothing Then
            SQL.SQLDS.Clear()
        End If
        SQL.RunQuery("select student_name as name,CONVERT(int,ROUND(DATEDIFF(hour,CONVERT( datetime, student_dob ,103 ),GETDATE())/8766.0,0)) as age,univ_name as univ_name " &
                     "from registration " &
                     "where studentid = '" & StudentId & "' ")

        If Flag = 1 Then
            Return SQL.SQLDS.Tables(0).Rows(0).Item("name")
        ElseIf Flag = 2 Then
            Return SQL.SQLDS.Tables(0).Rows(0).Item("age")
        ElseIf Flag = 3 Then
            Return SQL.SQLDS.Tables(0).Rows(0).Item("univ_name")
        End If
        Return SQL.SQLDS.Tables(0).Rows(0).Item("name")
    End Function

    Private Sub Backup_Click(sender As Object, e As EventArgs) Handles Backup.Click
        Dim sqlConnectionString As String = "Server=LAPTOP-F7MLHVFD;Database=Student_portal;Trusted_Connection=Yes"

        Dim conn As New SqlConnection(sqlConnectionString)
        conn.Open()

        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "BACKUP DATABASE Student_portal TO DISK='F:\DATABASE.BAK'"
        cmd.Connection = conn
        cmd.ExecuteNonQuery()

        conn.Close()
        MsgBox("BACKUP DATABASE SUCCESSFUL!")
    End Sub

    Dim myConnection As SqlConnection
    Private Sub Export_Click(sender As Object, e As EventArgs) Handles Export.Click

        myConnection = New SqlConnection("Server=LAPTOP-F7MLHVFD;Database=Student_portal;Trusted_Connection=Yes")
        Try
            myConnection.Open()

            Dim myCMD As SqlCommand = New SqlCommand("select * from studentdetails where student_id = '" & StudentId & "' ", myConnection)
            Dim myReader As SqlDataReader = myCMD.ExecuteReader()
            Dim fileName As String = "F:\" & StudentId & ".txt"
            Dim outputStream As StreamWriter = New StreamWriter(fileName)

            Do While myReader.Read
                Dim values(myReader.FieldCount - 1) As Object
                myReader.GetValues(values)
                Dim line As String = String.Join(",", values)
                outputStream.WriteLine(line)
            Loop
            myReader.Close()
            outputStream.Close()


            MsgBox("Data Exported Successfully!")
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection Failed!", MessageBoxButtons.AbortRetryIgnore)
        End Try
    End Sub

    Private Sub TextFileImport_Click(sender As Object, e As EventArgs) Handles TextFileImport.Click
        Dim fileName As String = "F:\Student_" & StudentId & ".txt"
        For Each line As String In ReadingFile(fileName)
            If line = Nothing Then

                GoTo Exit1
            End If
            InsertingIntoDB(line)
        Next
Exit1:
        DataGridView1.DataSource = GetStudentList()
    End Sub
    Private Sub InsertingIntoDB(line As String)

        Using conn As New SqlConnection("Server=LAPTOP-F7MLHVFD;Database=Student_portal;Trusted_Connection=Yes")
            conn.Open()
            Dim query As String = "Insert into studentdetails(CRN,student_id,subject_student,course,section,course_title,campus,final_grade,attempted,earned,gpa_hrs,quality_points ) values(@CRN,@student_id,@subject_student,@course,@section,@course_title,@campus,@final_grade,@attempted,@earned,@gpa_hrs,@quality_points )"
            Using cmd As New SqlCommand(query, conn)

                Dim data As String() = line.Split(New Char() {","}, StringSplitOptions.RemoveEmptyEntries)

                cmd.Parameters.AddWithValue("@CRN", Integer.Parse(data(0)))
                cmd.Parameters.AddWithValue("@student_id", StudentId)
                cmd.Parameters.AddWithValue("@subject_student", data(1))
                cmd.Parameters.AddWithValue("@course", data(2))

                cmd.Parameters.AddWithValue("@section", Integer.Parse(data(3)))
                cmd.Parameters.AddWithValue("@course_title", data(4))
                cmd.Parameters.AddWithValue("@campus", data(5))
                cmd.Parameters.AddWithValue("@final_grade", data(6))
                cmd.Parameters.AddWithValue("@attempted", Integer.Parse(data(7)))
                cmd.Parameters.AddWithValue("@earned", Integer.Parse(data(8)))
                cmd.Parameters.AddWithValue("@gpa_hrs", Integer.Parse(data(9)))
                cmd.Parameters.AddWithValue("@quality_points", Integer.Parse(data(10)))


                Try
                    cmd.ExecuteNonQuery()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Try
                End Try

            End Using
        End Using


    End Sub
    Private Iterator Function ReadingFile(path As String) As IEnumerable(Of String)
        Using sr As New StreamReader(path)
            Dim line As String = Nothing
            While (InlineAssignHelper(line, sr.ReadLine())) IsNot Nothing
                Yield line
            End While
        End Using
    End Function
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Close()
        Form1.Username_Txt.Text = ""
        Form1.PasswordTxt.Text = ""
        Form1.Show()
    End Sub
End Class