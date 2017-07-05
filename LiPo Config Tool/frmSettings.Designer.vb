<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCellSize = New System.Windows.Forms.Label()
        Me.lblPenThickness = New System.Windows.Forms.Label()
        Me.ttMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.numudCellSize = New System.Windows.Forms.NumericUpDown()
        Me.numudThickness = New System.Windows.Forms.NumericUpDown()
        CType(Me.numudCellSize,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.numudThickness,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(15, 67)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 31)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "OK"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(129, 67)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 31)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'lblCellSize
        '
        Me.lblCellSize.AutoSize = true
        Me.lblCellSize.Location = New System.Drawing.Point(12, 9)
        Me.lblCellSize.Name = "lblCellSize"
        Me.lblCellSize.Size = New System.Drawing.Size(50, 13)
        Me.lblCellSize.TabIndex = 2
        Me.lblCellSize.Text = "Cell Size:"
        Me.ttMain.SetToolTip(Me.lblCellSize, "Value for cell size must be an even number")
        '
        'lblPenThickness
        '
        Me.lblPenThickness.AutoSize = true
        Me.lblPenThickness.Location = New System.Drawing.Point(12, 32)
        Me.lblPenThickness.Name = "lblPenThickness"
        Me.lblPenThickness.Size = New System.Drawing.Size(59, 13)
        Me.lblPenThickness.TabIndex = 3
        Me.lblPenThickness.Text = "Thickness:"
        Me.ttMain.SetToolTip(Me.lblPenThickness, "Indicates the thickness of the items drawn on the screen.")
        '
        'ttMain
        '
        Me.ttMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'numudCellSize
        '
        Me.numudCellSize.BackColor = System.Drawing.SystemColors.Window
        Me.numudCellSize.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numudCellSize.Location = New System.Drawing.Point(77, 7)
        Me.numudCellSize.Maximum = New Decimal(New Integer() {150, 0, 0, 0})
        Me.numudCellSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.numudCellSize.Name = "numudCellSize"
        Me.numudCellSize.ReadOnly = true
        Me.numudCellSize.Size = New System.Drawing.Size(169, 20)
        Me.numudCellSize.TabIndex = 4
        Me.ttMain.SetToolTip(Me.numudCellSize, "Value for cell size must be an even number")
        Me.numudCellSize.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'numudThickness
        '
        Me.numudThickness.Location = New System.Drawing.Point(77, 30)
        Me.numudThickness.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.numudThickness.Name = "numudThickness"
        Me.numudThickness.Size = New System.Drawing.Size(169, 20)
        Me.numudThickness.TabIndex = 5
        Me.ttMain.SetToolTip(Me.numudThickness, "Indicates the thickness of the items drawn on the screen.")
        Me.numudThickness.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 109)
        Me.Controls.Add(Me.numudThickness)
        Me.Controls.Add(Me.numudCellSize)
        Me.Controls.Add(Me.lblPenThickness)
        Me.Controls.Add(Me.lblCellSize)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        CType(Me.numudCellSize,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.numudThickness,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCellSize As Label
    Friend WithEvents ttMain As ToolTip
    Friend WithEvents lblPenThickness As Label
    Friend WithEvents numudCellSize As NumericUpDown
    Friend WithEvents numudThickness As NumericUpDown
End Class
