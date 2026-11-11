Imports MySql.Data.MySqlClient

Module FuelCRUD

    ' Add a fuel sales
    Public Sub CreateSale(FuelType As String, Liters As Double)
        Using conn As MySqlConnection = GetConnection()
            Dim query As String = "INSERT INTO TblFuelSales (FuelType, Liters) VALUES (@FuelType, @Liters)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FuelType", FuelType)
                cmd.Parameters.AddWithValue("@liters", Liters)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'Add a fuel stock

    Public Sub CreateStock(FuelType As String, LitersToAdd As Decimal, DateAdded As String)
        Using conn = DBConnection.GetConnection()
            Dim query As String = "INSERT INTO TblFuelStock (FuelType, LitresToAdd, DateAdded) VALUES (@FuelType, @LitresToAdd, @DateAdded)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FuelType", FuelType)
                cmd.Parameters.AddWithValue("@LitresToAdd", LitersToAdd)
                cmd.Parameters.AddWithValue("@DateAdded", DateAdded)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
