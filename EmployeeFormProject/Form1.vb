Imports System.Data.SqlClient

Public Class Form1
    Private Sub btnLoadEmployees_Click(sender As Object, e As EventArgs) Handles btnLoadEmployees.Click
        Dim connectionString As String = "Server=CYBERKNIGHT\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=True;"
        Dim query As String = "SELECT * FROM Employees"

        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)
                dgvEmployees.DataSource = table
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Employees Directory"
    End Sub
End Class