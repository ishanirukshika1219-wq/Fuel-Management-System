<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReports
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
        Me.lblGReport = New System.Windows.Forms.Label()
        Me.btnGReport = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblRViewer = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGReport
        '
        Me.lblGReport.AutoSize = True
        Me.lblGReport.Location = New System.Drawing.Point(86, 132)
        Me.lblGReport.Name = "lblGReport"
        Me.lblGReport.Size = New System.Drawing.Size(107, 16)
        Me.lblGReport.TabIndex = 0
        Me.lblGReport.Text = "Generate Report"
        '
        'btnGReport
        '
        Me.btnGReport.Location = New System.Drawing.Point(318, 200)
        Me.btnGReport.Name = "btnGReport"
        Me.btnGReport.Size = New System.Drawing.Size(131, 23)
        Me.btnGReport.TabIndex = 1
        Me.btnGReport.Text = "Generate Report"
        Me.btnGReport.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        Me.ComboBox1.Location = New System.Drawing.Point(328, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Daily"
        '
        'lblRViewer
        '
        Me.lblRViewer.AutoSize = True
        Me.lblRViewer.Location = New System.Drawing.Point(86, 259)
        Me.lblRViewer.Name = "lblRViewer"
        Me.lblRViewer.Size = New System.Drawing.Size(92, 16)
        Me.lblRViewer.TabIndex = 4
        Me.lblRViewer.Text = "Report Viewer"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(158, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(496, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'FormReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblRViewer)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnGReport)
        Me.Controls.Add(Me.lblGReport)
        Me.Name = "FormReports"
        Me.Text = "FormReports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGReport As Label
    Friend WithEvents btnGReport As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblRViewer As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
