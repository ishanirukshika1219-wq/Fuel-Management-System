Public Class FormCLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim UserName As String = txtUserName.Text
        Dim VehicleNumber As String = txtVehicleNumber.Text

        If String.IsNullOrEmpty(txtUserName.Text) Or String.IsNullOrEmpty(txtVehicleNumber.Text) Then
            MsgBox("Please fill the Both User Name and Vehical Number!", MsgBoxStyle.Critical)
        Else
            CreateClient(UserName, VehicleNumber)
            MsgBox("Login Successfully!", MsgBoxStyle.Information)
            Me.Hide()
            Dim frm As New FormSales()
            frm.Show()
        End If
    End Sub
End Class