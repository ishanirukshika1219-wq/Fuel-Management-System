<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Me.btnEShift = New System.Windows.Forms.Button()
        Me.btnFuelStock = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEShift
        '
        Me.btnEShift.Location = New System.Drawing.Point(339, 167)
        Me.btnEShift.Name = "btnEShift"
        Me.btnEShift.Size = New System.Drawing.Size(201, 36)
        Me.btnEShift.TabIndex = 2
        Me.btnEShift.Text = "Employee Shifts"
        Me.btnEShift.UseVisualStyleBackColor = True
        '
        'btnFuelStock
        '
        Me.btnFuelStock.Location = New System.Drawing.Point(40, 158)
        Me.btnFuelStock.Name = "btnFuelStock"
        Me.btnFuelStock.Size = New System.Drawing.Size(241, 45)
        Me.btnFuelStock.TabIndex = 3
        Me.btnFuelStock.Text = "Add Fuel Stock"
        Me.btnFuelStock.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(592, 167)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(158, 46)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total fuel in tank"
        '
        'txtFuel
        '
        Me.txtFuel.Location = New System.Drawing.Point(329, 54)
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.Size = New System.Drawing.Size(100, 22)
        Me.txtFuel.TabIndex = 6
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFuel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnFuelStock)
        Me.Controls.Add(Me.btnEShift)
        Me.Name = "FormDashboard"
        Me.Text = "FormDashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEShift As Button
    Friend WithEvents btnFuelStock As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFuel As TextBox
End Class
