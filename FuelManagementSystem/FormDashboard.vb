Imports MySql.Data.MySqlClient

Public Class FormDashboard
    Dim con As New MySqlConnection("server=localhost;user id=root;password=yourpassword;database=yourdb")
    Dim cmd As New MySqlCommand("SELECT SUM(litres) FROM fuelsales", con)



    Private Sub btnFuelSales_Click(sender As Object, e As EventArgs) Handles btnEShift.Click

    End Sub

    Private Sub btnFuelStock_Click(sender As Object, e As EventArgs) Handles btnFuelStock.Click
        FormStock.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        FormReports.Show()
    End Sub

    Private Sub txtFuel_TextChanged(sender As Object, e As EventArgs) Handles txtFuel.TextChanged

    End Sub
End Class