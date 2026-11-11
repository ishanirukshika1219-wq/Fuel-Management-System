Imports MySql.Data.MySqlClient

Module EmployeeCRUD
    Public Sub CreateEmployee(EmployeeName As String, Shiftime As String, ShiftDate As String, Password As String)
        Using conn As MySqlConnection = GetConnection()

            Dim query As String = "INSERT INTO TblEmployeeShifts (EmployeeName,ShiftTime,ShiftDate,Password) VALUES (@EmployeeName, @ShiftTime,@ShiftDate,@Password)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@EmployeeName", EmployeeName)
                cmd.Parameters.AddWithValue("@ShiftTime", Shiftime)
                cmd.Parameters.AddWithValue("@ShiftDate", ShiftDate)
                cmd.Parameters.AddWithValue("@Password", Password)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
