Imports MySql.Data.MySqlClient
Module ClientCRUD
    Public Sub CreateClient(UserName As String, VehicleNumber As String)
        Using conn As MySqlConnection = GetConnection()

            Dim query As String = "INSERT INTO TblClients (UserName, VehicleNumber) VALUES (@UserName, @VehicleNumber)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserName", UserName)
                cmd.Parameters.AddWithValue("@VehicleNumber", VehicleNumber)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
