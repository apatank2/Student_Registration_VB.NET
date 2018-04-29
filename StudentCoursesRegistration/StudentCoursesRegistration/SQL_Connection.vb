Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQL_Connection
    Public SQLConnect As New SqlConnection With {.ConnectionString = "Server=LAPTOP-F7MLHVFD;Database=Student_portal;Trusted_Connection=Yes"}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDS As DataSet
    Public Function HasConnection() As Boolean
        Try
            SQLConnect.Open()
            SQLConnect.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub RunQuery(Query As String)
        Try
            SQLConnect.Open()
            ' CREATE COMMAND
            SQLCmd = New SqlCommand(Query, SQLConnect)

            ' FILL DATASET
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDS = New DataSet
            SQLDA.fill(SQLDS)
            SQLConnect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            SQLConnect.Close()
        End Try
    End Sub
End Class
