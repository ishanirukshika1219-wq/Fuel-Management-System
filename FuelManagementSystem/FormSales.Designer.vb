<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSales))
        Me.txtLiters = New System.Windows.Forms.TextBox()
        Me.lblFuelType = New System.Windows.Forms.Label()
        Me.lblLiters = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTPrice = New System.Windows.Forms.TextBox()
        Me.cmbFuelType = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CFuelType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLiters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPricePerLiter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPricePerLiter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnCancel2 = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLiters
        '
        Me.txtLiters.Location = New System.Drawing.Point(195, 111)
        Me.txtLiters.Name = "txtLiters"
        Me.txtLiters.Size = New System.Drawing.Size(121, 22)
        Me.txtLiters.TabIndex = 1
        '
        'lblFuelType
        '
        Me.lblFuelType.AutoSize = True
        Me.lblFuelType.Location = New System.Drawing.Point(45, 31)
        Me.lblFuelType.Name = "lblFuelType"
        Me.lblFuelType.Size = New System.Drawing.Size(68, 16)
        Me.lblFuelType.TabIndex = 2
        Me.lblFuelType.Text = "Fuel Type"
        '
        'lblLiters
        '
        Me.lblLiters.AutoSize = True
        Me.lblLiters.Location = New System.Drawing.Point(41, 117)
        Me.lblLiters.Name = "lblLiters"
        Me.lblLiters.Size = New System.Drawing.Size(39, 16)
        Me.lblLiters.TabIndex = 3
        Me.lblLiters.Text = "Liters"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(178, 179)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(54, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(41, 238)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(72, 16)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total Price"
        '
        'txtTPrice
        '
        Me.txtTPrice.Location = New System.Drawing.Point(195, 235)
        Me.txtTPrice.Name = "txtTPrice"
        Me.txtTPrice.Size = New System.Drawing.Size(121, 22)
        Me.txtTPrice.TabIndex = 6
        '
        'cmbFuelType
        '
        Me.cmbFuelType.FormattingEnabled = True
        Me.cmbFuelType.Items.AddRange(New Object() {"Octane 92", "Octane 95", "Auto Diesel", "Super Diesel"})
        Me.cmbFuelType.Location = New System.Drawing.Point(195, 23)
        Me.cmbFuelType.Name = "cmbFuelType"
        Me.cmbFuelType.Size = New System.Drawing.Size(121, 24)
        Me.cmbFuelType.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CFuelType, Me.CLiters, Me.CPricePerLiter, Me.CTotalPrice})
        Me.DataGridView1.Location = New System.Drawing.Point(48, 314)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(555, 105)
        Me.DataGridView1.TabIndex = 8
        '
        'CFuelType
        '
        Me.CFuelType.HeaderText = "Fuel Type"
        Me.CFuelType.MinimumWidth = 6
        Me.CFuelType.Name = "CFuelType"
        Me.CFuelType.Width = 125
        '
        'CLiters
        '
        Me.CLiters.HeaderText = "Liters"
        Me.CLiters.MinimumWidth = 6
        Me.CLiters.Name = "CLiters"
        Me.CLiters.Width = 125
        '
        'CPricePerLiter
        '
        Me.CPricePerLiter.HeaderText = "Price Per Liter"
        Me.CPricePerLiter.MinimumWidth = 6
        Me.CPricePerLiter.Name = "CPricePerLiter"
        Me.CPricePerLiter.Width = 125
        '
        'CTotalPrice
        '
        Me.CTotalPrice.HeaderText = "Total Price"
        Me.CTotalPrice.MinimumWidth = 6
        Me.CTotalPrice.Name = "CTotalPrice"
        Me.CTotalPrice.Width = 125
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(56, 179)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(645, 305)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 27)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save Sale"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPricePerLiter
        '
        Me.txtPricePerLiter.Location = New System.Drawing.Point(195, 69)
        Me.txtPricePerLiter.Name = "txtPricePerLiter"
        Me.txtPricePerLiter.Size = New System.Drawing.Size(121, 22)
        Me.txtPricePerLiter.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Price Per Liter"
        '
        'PrintDocument1
        '
        '
        'btnCancel2
        '
        Me.btnCancel2.Location = New System.Drawing.Point(651, 394)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(80, 25)
        Me.btnCancel2.TabIndex = 14
        Me.btnCancel2.Text = "CANCEL"
        Me.btnCancel2.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(651, 351)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'FormSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 450)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPricePerLiter)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmbFuelType)
        Me.Controls.Add(Me.txtTPrice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblLiters)
        Me.Controls.Add(Me.lblFuelType)
        Me.Controls.Add(Me.txtLiters)
        Me.Name = "FormSales"
        Me.Text = "a"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLiters As TextBox
    Friend WithEvents lblFuelType As Label
    Friend WithEvents lblLiters As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTPrice As TextBox
    Friend WithEvents cmbFuelType As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents CFuelType As DataGridViewTextBoxColumn
    Friend WithEvents CLiters As DataGridViewTextBoxColumn
    Friend WithEvents CPricePerLiter As DataGridViewTextBoxColumn
    Friend WithEvents CTotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents txtPricePerLiter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnCancel2 As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
