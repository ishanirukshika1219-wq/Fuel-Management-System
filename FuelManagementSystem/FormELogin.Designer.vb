<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormELogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblEname = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtEName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblSTime = New System.Windows.Forms.Label()
        Me.lblSDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbShiftTime = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblEname
        '
        Me.lblEname.AutoSize = True
        Me.lblEname.Location = New System.Drawing.Point(132, 78)
        Me.lblEname.Name = "lblEname"
        Me.lblEname.Size = New System.Drawing.Size(109, 16)
        Me.lblEname.TabIndex = 0
        Me.lblEname.Text = "Employee Name"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(138, 244)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 16)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(294, 334)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtEName
        '
        Me.txtEName.Location = New System.Drawing.Point(317, 63)
        Me.txtEName.Name = "txtEName"
        Me.txtEName.Size = New System.Drawing.Size(100, 22)
        Me.txtEName.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(317, 238)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 22)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblSTime
        '
        Me.lblSTime.AutoSize = True
        Me.lblSTime.Location = New System.Drawing.Point(139, 123)
        Me.lblSTime.Name = "lblSTime"
        Me.lblSTime.Size = New System.Drawing.Size(66, 16)
        Me.lblSTime.TabIndex = 6
        Me.lblSTime.Text = "Shift Time"
        '
        'lblSDate
        '
        Me.lblSDate.AutoSize = True
        Me.lblSDate.Location = New System.Drawing.Point(141, 179)
        Me.lblSDate.Name = "lblSDate"
        Me.lblSDate.Size = New System.Drawing.Size(64, 16)
        Me.lblSDate.TabIndex = 7
        Me.lblSDate.Text = "Shift Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(317, 179)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 8
        '
        'cmbShiftTime
        '
        Me.cmbShiftTime.FormattingEnabled = True
        Me.cmbShiftTime.Items.AddRange(New Object() {"8.00 A.M - 2.00 P.M", "2.00 P.M - 8.00 P.M"})
        Me.cmbShiftTime.Location = New System.Drawing.Point(317, 123)
        Me.cmbShiftTime.Name = "cmbShiftTime"
        Me.cmbShiftTime.Size = New System.Drawing.Size(121, 24)
        Me.cmbShiftTime.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(466, 244)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 20)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "SHOW"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormELogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cmbShiftTime)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblSDate)
        Me.Controls.Add(Me.lblSTime)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEName)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEname)
        Me.Name = "FormELogin"
        Me.Text = "FormELogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEname As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtEName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblSTime As Label
    Friend WithEvents lblSDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmbShiftTime As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
