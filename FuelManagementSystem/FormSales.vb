Imports System.Drawing.Printing
Imports System.Drawing.Text

Public Class FormSales
    Private Sub btbSaveSale_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim FuelType As String = cmbFuelType.Text
        Dim Liters As Double
        Double.TryParse(txtLiters.Text, Liters)

        Dim pricePerLiter As Double
        Dim TotalPrice As Double = Liters * pricePerLiter

        'select fuel type
        Select Case FuelType
            Case "Octane 92"
                pricePerLiter = 356
            Case "Octane 95"
                pricePerLiter = 420
            Case "Auto Diesel"
                pricePerLiter = 330
            Case "Super Diesel"
                pricePerLiter = 365
            Case Else
                MsgBox("Please select a valid fuel type!", MsgBoxStyle.Critical)
                Exit Sub
        End Select

        If String.IsNullOrEmpty(txtLiters.Text) Then
            MsgBox("Please fill How many Liters do you want!", MsgBoxStyle.Critical)
        Else

            CreateSale(FuelType, Liters)
            MsgBox("Providing information is Successful!", MsgBoxStyle.Information)
        End If

        TotalPrice = Liters * pricePerLiter
        txtTPrice.Text = TotalPrice.ToString("F2")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if a row (excluding the blank new row) already exists
        If DataGridView1.Rows.Cast(Of DataGridViewRow).Count(Function(r) Not r.IsNewRow) >= 1 Then
            Exit Sub ' Do not add more rows
        End If


        Me.DataGridView1.Rows.Add(cmbFuelType.Text, txtLiters.Text, txtPricePerLiter.Text, txtTPrice.Text)



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cmbFuelType.Text = ""
        txtPricePerLiter.Text = ""
        txtLiters.Text = ""
    End Sub

    Private Sub cmbFuelType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFuelType.SelectedIndexChanged
        Select Case cmbFuelType.Text
            Case "Octane 92"
                txtPricePerLiter.Text = "Rs.356"
            Case "Octane 95"
                txtPricePerLiter.Text = "Rs.420"
            Case "Auto Diesel"
                txtPricePerLiter.Text = "Rs.330"
            Case "Super Diesel"
                txtPricePerLiter.Text = "Rs.365"
            Case Else
                txtPricePerLiter.Text = ""
        End Select
    End Sub

    Private Sub btnCancel2_Click(sender As Object, e As EventArgs) Handles btnCancel2.Click
        MessageBox.Show("Thank you! Drive safe and fuel responsibly")
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 10)
        Dim titleFont As New Font("Arial", 20, FontStyle.Bold)
        Dim subFont As New Font("Arial", 17, FontStyle.Bold)
        Dim QFont As New Font("Arial", 17, FontStyle.Italic)
        Dim pageWidth As Integer = e.PageBounds.Width

        Dim y As Integer = 80

        ' Fuel station name
        Dim stationName As String = "PetroSmart Fuel Station"
        Dim stationSize As SizeF = e.Graphics.MeasureString(stationName, titleFont)
        Dim stationX As Integer = (pageWidth - stationSize.Width) / 2
        e.Graphics.DrawString(stationName, titleFont, Brushes.Black, stationX, y)
        y += 30

        ' Location and contact
        Dim details As String = "Hambantota | Tel: +77-1234567"
        Dim detailsSize As SizeF = e.Graphics.MeasureString(details, subFont)
        Dim detailsX As Integer = (pageWidth - detailsSize.Width) / 2
        e.Graphics.DrawString(details, subFont, Brushes.Black, detailsX, y)
        y += 40

        ' Receipt Title
        Dim receiptTitle As String = "Fuel Receipt"
        Dim receiptSize As SizeF = e.Graphics.MeasureString(receiptTitle, QFont)
        Dim receiptX As Integer = (pageWidth - receiptSize.Width) / 2
        e.Graphics.DrawString(receiptTitle, subFont, Brushes.Black, receiptX, y)
        y += 40

        ' Column headers
        Dim headers() As String = {"Fuel Type", "Liters", "Price per Liter", "Total Price"}
        Dim startX As Integer = (pageWidth - (headers.Length * 120)) / 2

        For i As Integer = 0 To headers.Length - 1
            e.Graphics.DrawString(headers(i), font, Brushes.Black, startX + (i * 120), y)
        Next
        y += 25

        ' Rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                For i As Integer = 0 To headers.Length - 1
                    e.Graphics.DrawString(row.Cells(i).Value.ToString(), font, Brushes.Black, startX + (i * 120), y)
                Next
                y += 25
            End If
        Next

        ' Footer Quote
        y += 40
        Dim quote As String = """Thank you! Drive safe and fuel responsibly."""
        Dim quoteSize As SizeF = e.Graphics.MeasureString(quote, subFont)
        Dim quoteX As Integer = (pageWidth - quoteSize.Width) / 2
        e.Graphics.DrawString(quote, subFont, Brushes.Black, quoteX, y)

    End Sub


End Class