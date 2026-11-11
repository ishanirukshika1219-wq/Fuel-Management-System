<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStock
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
        Me.btnAddStock = New System.Windows.Forms.Button()
        Me.btnCurrentStock = New System.Windows.Forms.Button()
        Me.lblFuelType = New System.Windows.Forms.Label()
        Me.lblLitersToAdd = New System.Windows.Forms.Label()
        Me.lblDateAdded = New System.Windows.Forms.Label()
        Me.txtFuelType = New System.Windows.Forms.TextBox()
        Me.txtLAdd = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnAddStock
        '
        Me.btnAddStock.Location = New System.Drawing.Point(169, 328)
        Me.btnAddStock.Name = "btnAddStock"
        Me.btnAddStock.Size = New System.Drawing.Size(146, 56)
        Me.btnAddStock.TabIndex = 0
        Me.btnAddStock.Text = "Add Stock"
        Me.btnAddStock.UseVisualStyleBackColor = True
        '
        'btnCurrentStock
        '
        Me.btnCurrentStock.Location = New System.Drawing.Point(415, 328)
        Me.btnCurrentStock.Name = "btnCurrentStock"
        Me.btnCurrentStock.Size = New System.Drawing.Size(155, 56)
        Me.btnCurrentStock.TabIndex = 1
        Me.btnCurrentStock.Text = "Current Stock"
        Me.btnCurrentStock.UseVisualStyleBackColor = True
        '
        'lblFuelType
        '
        Me.lblFuelType.AutoSize = True
        Me.lblFuelType.Location = New System.Drawing.Point(151, 68)
        Me.lblFuelType.Name = "lblFuelType"
        Me.lblFuelType.Size = New System.Drawing.Size(68, 16)
        Me.lblFuelType.TabIndex = 2
        Me.lblFuelType.Text = "Fuel Type"
        '
        'lblLitersToAdd
        '
        Me.lblLitersToAdd.AutoSize = True
        Me.lblLitersToAdd.Location = New System.Drawing.Point(151, 127)
        Me.lblLitersToAdd.Name = "lblLitersToAdd"
        Me.lblLitersToAdd.Size = New System.Drawing.Size(87, 16)
        Me.lblLitersToAdd.TabIndex = 3
        Me.lblLitersToAdd.Text = "Liters To Add"
        '
        'lblDateAdded
        '
        Me.lblDateAdded.AutoSize = True
        Me.lblDateAdded.Location = New System.Drawing.Point(154, 192)
        Me.lblDateAdded.Name = "lblDateAdded"
        Me.lblDateAdded.Size = New System.Drawing.Size(80, 16)
        Me.lblDateAdded.TabIndex = 4
        Me.lblDateAdded.Text = "Data Added"
        '
        'txtFuelType
        '
        Me.txtFuelType.Location = New System.Drawing.Point(422, 71)
        Me.txtFuelType.Name = "txtFuelType"
        Me.txtFuelType.Size = New System.Drawing.Size(100, 22)
        Me.txtFuelType.TabIndex = 5
        '
        'txtLAdd
        '
        Me.txtLAdd.Location = New System.Drawing.Point(422, 130)
        Me.txtLAdd.Name = "txtLAdd"
        Me.txtLAdd.Size = New System.Drawing.Size(100, 22)
        Me.txtLAdd.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(421, 196)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'FormStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtLAdd)
        Me.Controls.Add(Me.txtFuelType)
        Me.Controls.Add(Me.lblDateAdded)
        Me.Controls.Add(Me.lblLitersToAdd)
        Me.Controls.Add(Me.lblFuelType)
        Me.Controls.Add(Me.btnCurrentStock)
        Me.Controls.Add(Me.btnAddStock)
        Me.Name = "FormStock"
        Me.Text = "FormStock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddStock As Button
    Friend WithEvents btnCurrentStock As Button
    Friend WithEvents lblFuelType As Label
    Friend WithEvents lblLitersToAdd As Label
    Friend WithEvents lblDateAdded As Label
    Friend WithEvents txtFuelType As TextBox
    Friend WithEvents txtLAdd As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
