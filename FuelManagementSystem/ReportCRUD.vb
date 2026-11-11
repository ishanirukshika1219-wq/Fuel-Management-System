Imports MySql.Data.MySqlClient
Module ReportCRUD
    Public Function GetReportData(type As String) As DataTable
        Dim dt As New DataTable()
        Dim quary As String = ""

        Select Case type.ToLower()
            Case "daily"
                quary = "SELECT FuelType, SUM(Liters) AS 'Total Liters', SUM(TotalPrice) AS 'Total Sales' FROM TblFuelSales WHERE DATE(SaleDate) = CURDATE() GROUP BY FuelType"
            Case "weekly"
                quary = "SELECT FuelType, SUM(liters) AS 'Total Liters', SUM(TotalPrice) AS 'Total Sales' FROM TblFuelSales WHERE YEARWEEK(SaleDate, 1) = YEARWEEK(CURDATE(), 1) GROUP BY FuelType"
            Case "monthly"
                quary = "SELECT FuelType, SUM(liters) AS 'Total Liters', SUM(TotalPrice) AS 'Total Sales' FROM TblFuelSales WHERE MONTH(SaleDate) = MONTH(CURDATE()) AND YEAR(SaleDate) = YEAR(CURDATE()) GROUP BY FuelType"
            Case Else
                Return dt
        End Select

        Using conn = DBConnection.GetConnection()
            Using da As New MySqlDataAdapter(quary, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function
End Module
