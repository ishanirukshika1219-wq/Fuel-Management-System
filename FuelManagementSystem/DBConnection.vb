Imports MySql.Data.MySqlClient
Module DBConnection

    Private ReadOnly connString As String = "Server=localhost;Database=fuelmanagementsystem;User Id=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            MsgBox("Connection Successfull!", MsgBoxStyle.Information)
        Catch ex As Exception
            MessageBox.Show("Database Connection Failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conn
    End Function

End Module
