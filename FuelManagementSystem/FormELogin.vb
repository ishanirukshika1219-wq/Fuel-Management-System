Public Class FormELogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim EmployeeName As String = txtEName.Text
        Dim Password As String = txtPassword.Text
        Dim ShiftTime As String = cmbShiftTime.Text
        Dim ShiftDate As String = DateTimePicker1.Text
        Dim correctPassword As String = "1234"

        If String.IsNullOrWhiteSpace(txtPassword.Text) Or String.IsNullOrEmpty(txtEName.Text) Or String.IsNullOrEmpty(cmbShiftTime.Text) Or String.IsNullOrEmpty(DateTimePicker1.Text) Then
            MsgBox("Please enter the password.", MsgBoxStyle.Critical)
            txtPassword.Focus()
            Return
        End If

        If txtPassword.Text = correctPassword Then
            MsgBox("Login successful! Welcome!", MsgBoxStyle.Information)
            Me.Hide()
            Dim frm As New FormDashboard()
            frm.Show()


        Else
            MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If


    End Sub

    Private Sub txtEName_TextChanged(sender As Object, e As EventArgs) Handles txtEName.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class