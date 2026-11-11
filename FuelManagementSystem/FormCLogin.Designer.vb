<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblVehicleNumber = New System.Windows.Forms.Label()
        Me.txtVehicleNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(118, 260)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(246, 48)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(35, 91)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(76, 16)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "User Name"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(152, 91)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(179, 22)
        Me.txtUserName.TabIndex = 2
        '
        'lblVehicleNumber
        '
        Me.lblVehicleNumber.AutoSize = True
        Me.lblVehicleNumber.Location = New System.Drawing.Point(35, 154)
        Me.lblVehicleNumber.Name = "lblVehicleNumber"
        Me.lblVehicleNumber.Size = New System.Drawing.Size(103, 16)
        Me.lblVehicleNumber.TabIndex = 3
        Me.lblVehicleNumber.Text = "Vehicle Number"
        '
        'txtVehicleNumber
        '
        Me.txtVehicleNumber.Location = New System.Drawing.Point(156, 154)
        Me.txtVehicleNumber.Name = "txtVehicleNumber"
        Me.txtVehicleNumber.Size = New System.Drawing.Size(175, 22)
        Me.txtVehicleNumber.TabIndex = 4
        '
        'FormCLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtVehicleNumber)
        Me.Controls.Add(Me.lblVehicleNumber)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnLogin)
        Me.Name = "FormCLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents lblVehicleNumber As Label
    Friend WithEvents txtVehicleNumber As TextBox
End Class
