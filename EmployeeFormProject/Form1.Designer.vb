<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLoadEmployees = New System.Windows.Forms.Button()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lb1Header = New System.Windows.Forms.Label()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadEmployees
        '
        Me.btnLoadEmployees.Location = New System.Drawing.Point(199, 48)
        Me.btnLoadEmployees.Name = "btnLoadEmployees"
        Me.btnLoadEmployees.Size = New System.Drawing.Size(124, 23)
        Me.btnLoadEmployees.TabIndex = 0
        Me.btnLoadEmployees.Text = "btnLoadEmployees"
        Me.btnLoadEmployees.UseVisualStyleBackColor = True
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(33, 95)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(565, 350)
        Me.dgvEmployees.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(555, 35)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lb1Header
        '
        Me.lb1Header.AutoSize = True
        Me.lb1Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1Header.Location = New System.Drawing.Point(60, 13)
        Me.lb1Header.Name = "lb1Header"
        Me.lb1Header.Size = New System.Drawing.Size(193, 24)
        Me.lb1Header.TabIndex = 3
        Me.lb1Header.Text = "Employee Directory"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lb1Header)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.btnLoadEmployees)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadEmployees As Button
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents lb1Header As Label
End Class
