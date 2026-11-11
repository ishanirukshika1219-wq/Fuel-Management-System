Imports MySql.Data.MySqlClient

Public Class FormStock

    Private Sub btnAddStock_Click(sender As Object, e As EventArgs) Handles btnAddStock.Click
        Dim FuelType As String = txtFuelType.Text
        Dim LitersToAdd As Decimal = txtLAdd.Text
        Dim DateAdded As String = DateTimePicker1.Value

        If String.IsNullOrEmpty(txtFuelType.Text) Or String.IsNullOrEmpty(txtLAdd.Text) Or String.IsNullOrEmpty(DateTimePicker1.Value) Then
            MessageBox.Show("Please fill the Both Fuel Type, Liters To Add and Date Added!")
        Else
            CreateStock(FuelType, LitersToAdd, DateAdded)
            MessageBox.Show("Successfully Added!")
        End If
    End Sub

    Private Sub btnCurrentStock_Click(sender As Object, e As EventArgs) Handles btnCurrentStock.Click




    End Sub
End Class