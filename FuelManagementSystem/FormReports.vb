Public Class FormReports
    Private Sub btnGReport_Click(sender As Object, e As EventArgs) Handles btnGReport.Click

        Dim reportType = ComboBox1.SelectedItem?.ToString()?.ToLower()

        If String.IsNullOrEmpty(reportType) Then
            MessageBox.Show("Please select a report type.")
            Return
        End If

        DataGridView1.DataSource = ReportCRUD.GetReportData(reportType)
    End Sub

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox1.Items.AddRange({"Daily", "Weekly", "Monthly"})
        ComboBox1.SelectedIndex = 0
    End Sub


End Class