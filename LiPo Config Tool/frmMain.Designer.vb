<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbMain = New System.Windows.Forms.GroupBox()
        Me.txtVoltage = New System.Windows.Forms.TextBox()
        Me.lbConfigs = New System.Windows.Forms.ListBox()
        Me.txtCapacity = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbShowConnections = New System.Windows.Forms.CheckBox()
        Me.cbShowCells = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConfig = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.MsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsMain = New System.Windows.Forms.MenuStrip()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.txtCellCount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtArrangement = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numSeries = New System.Windows.Forms.NumericUpDown()
        Me.numParallel = New System.Windows.Forms.NumericUpDown()
        Me.numFreightCost = New System.Windows.Forms.NumericUpDown()
        Me.numCellCost = New System.Windows.Forms.NumericUpDown()
        Me.gbPricing = New System.Windows.Forms.GroupBox()
        Me.gbConfig = New System.Windows.Forms.GroupBox()
        Me.gbData = New System.Windows.Forms.GroupBox()
        Me.MsMain.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numParallel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFreightCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCellCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPricing.SuspendLayout()
        Me.gbConfig.SuspendLayout()
        Me.gbData.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(7, 24)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(39, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Series:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Parallel:"
        '
        'gbMain
        '
        Me.gbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMain.BackColor = System.Drawing.SystemColors.Control
        Me.gbMain.Location = New System.Drawing.Point(276, 27)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(321, 644)
        Me.gbMain.TabIndex = 12
        Me.gbMain.TabStop = False
        '
        'txtVoltage
        '
        Me.txtVoltage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVoltage.Location = New System.Drawing.Point(83, 345)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.ReadOnly = True
        Me.txtVoltage.Size = New System.Drawing.Size(174, 20)
        Me.txtVoltage.TabIndex = 45
        Me.txtVoltage.TabStop = False
        '
        'lbConfigs
        '
        Me.lbConfigs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbConfigs.FormattingEnabled = True
        Me.lbConfigs.Location = New System.Drawing.Point(5, 120)
        Me.lbConfigs.MinimumSize = New System.Drawing.Size(4, 90)
        Me.lbConfigs.Name = "lbConfigs"
        Me.lbConfigs.Size = New System.Drawing.Size(252, 82)
        Me.lbConfigs.TabIndex = 35
        '
        'txtCapacity
        '
        Me.txtCapacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCapacity.Location = New System.Drawing.Point(83, 371)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.ReadOnly = True
        Me.txtCapacity.Size = New System.Drawing.Size(174, 20)
        Me.txtCapacity.TabIndex = 50
        Me.txtCapacity.TabStop = False
        '
        'txtWidth
        '
        Me.txtWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWidth.Location = New System.Drawing.Point(83, 423)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.ReadOnly = True
        Me.txtWidth.Size = New System.Drawing.Size(174, 20)
        Me.txtWidth.TabIndex = 60
        Me.txtWidth.TabStop = False
        '
        'txtLength
        '
        Me.txtLength.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLength.Location = New System.Drawing.Point(83, 449)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.ReadOnly = True
        Me.txtLength.Size = New System.Drawing.Size(174, 20)
        Me.txtLength.TabIndex = 65
        Me.txtLength.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Voltage:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Capacity:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Width:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 452)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Length:"
        '
        'cbShowConnections
        '
        Me.cbShowConnections.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbShowConnections.AutoSize = True
        Me.cbShowConnections.Location = New System.Drawing.Point(17, 654)
        Me.cbShowConnections.Name = "cbShowConnections"
        Me.cbShowConnections.Size = New System.Drawing.Size(115, 17)
        Me.cbShowConnections.TabIndex = 80
        Me.cbShowConnections.TabStop = False
        Me.cbShowConnections.Text = "Show Connections"
        Me.cbShowConnections.UseVisualStyleBackColor = True
        '
        'cbShowCells
        '
        Me.cbShowCells.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbShowCells.AutoSize = True
        Me.cbShowCells.Location = New System.Drawing.Point(18, 631)
        Me.cbShowCells.Name = "cbShowCells"
        Me.cbShowCells.Size = New System.Drawing.Size(78, 17)
        Me.cbShowCells.TabIndex = 75
        Me.cbShowCells.TabStop = False
        Me.cbShowCells.Text = "Show Cells"
        Me.cbShowCells.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWeight.Location = New System.Drawing.Point(83, 397)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(174, 20)
        Me.txtWeight.TabIndex = 55
        Me.txtWeight.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Config:"
        '
        'txtConfig
        '
        Me.txtConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtConfig.Location = New System.Drawing.Point(83, 319)
        Me.txtConfig.Name = "txtConfig"
        Me.txtConfig.ReadOnly = True
        Me.txtConfig.Size = New System.Drawing.Size(174, 20)
        Me.txtConfig.TabIndex = 40
        Me.txtConfig.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 479)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Height:"
        '
        'txtHeight
        '
        Me.txtHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHeight.Location = New System.Drawing.Point(83, 476)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(174, 20)
        Me.txtHeight.TabIndex = 70
        Me.txtHeight.TabStop = False
        '
        'MsFile
        '
        Me.MsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msSettings, Me.MsExit})
        Me.MsFile.Name = "MsFile"
        Me.MsFile.Size = New System.Drawing.Size(37, 20)
        Me.MsFile.Text = "File"
        '
        'msSettings
        '
        Me.msSettings.AutoSize = False
        Me.msSettings.Image = CType(resources.GetObject("msSettings.Image"), System.Drawing.Image)
        Me.msSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.msSettings.Name = "msSettings"
        Me.msSettings.Size = New System.Drawing.Size(152, 22)
        Me.msSettings.Text = "Settings"
        '
        'MsExit
        '
        Me.MsExit.AutoSize = False
        Me.MsExit.Image = CType(resources.GetObject("MsExit.Image"), System.Drawing.Image)
        Me.MsExit.Name = "MsExit"
        Me.MsExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.MsExit.Size = New System.Drawing.Size(152, 22)
        Me.MsExit.Text = "Exit"
        '
        'MsMain
        '
        Me.MsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsFile})
        Me.MsMain.Location = New System.Drawing.Point(0, 0)
        Me.MsMain.Name = "MsMain"
        Me.MsMain.Size = New System.Drawing.Size(609, 24)
        Me.MsMain.TabIndex = 9
        Me.MsMain.Text = "MenuStrip1"
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbLogo.BackgroundImage = CType(resources.GetObject("pbLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbLogo.Location = New System.Drawing.Point(5, 211)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(252, 100)
        Me.pbLogo.TabIndex = 26
        Me.pbLogo.TabStop = False
        '
        'txtCellCount
        '
        Me.txtCellCount.Enabled = False
        Me.txtCellCount.Location = New System.Drawing.Point(83, 27)
        Me.txtCellCount.Name = "txtCellCount"
        Me.txtCellCount.ReadOnly = True
        Me.txtCellCount.Size = New System.Drawing.Size(174, 20)
        Me.txtCellCount.TabIndex = 20
        Me.txtCellCount.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Cell Count:"
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Location = New System.Drawing.Point(83, 56)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(174, 20)
        Me.txtTotalCost.TabIndex = 25
        Me.txtTotalCost.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Total Cost:"
        '
        'txtArrangement
        '
        Me.txtArrangement.Enabled = False
        Me.txtArrangement.Location = New System.Drawing.Point(83, 82)
        Me.txtArrangement.Name = "txtArrangement"
        Me.txtArrangement.ReadOnly = True
        Me.txtArrangement.Size = New System.Drawing.Size(174, 20)
        Me.txtArrangement.TabIndex = 30
        Me.txtArrangement.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Arrangement:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Freight / kg:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Cost / Cell:"
        '
        'numSeries
        '
        Me.numSeries.Location = New System.Drawing.Point(52, 22)
        Me.numSeries.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numSeries.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSeries.Name = "numSeries"
        Me.numSeries.Size = New System.Drawing.Size(50, 20)
        Me.numSeries.TabIndex = 1
        Me.numSeries.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numParallel
        '
        Me.numParallel.Location = New System.Drawing.Point(52, 48)
        Me.numParallel.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.numParallel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numParallel.Name = "numParallel"
        Me.numParallel.Size = New System.Drawing.Size(50, 20)
        Me.numParallel.TabIndex = 3
        Me.numParallel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numFreightCost
        '
        Me.numFreightCost.DecimalPlaces = 2
        Me.numFreightCost.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numFreightCost.Location = New System.Drawing.Point(84, 48)
        Me.numFreightCost.Name = "numFreightCost"
        Me.numFreightCost.Size = New System.Drawing.Size(57, 20)
        Me.numFreightCost.TabIndex = 81
        '
        'numCellCost
        '
        Me.numCellCost.DecimalPlaces = 2
        Me.numCellCost.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numCellCost.Location = New System.Drawing.Point(84, 22)
        Me.numCellCost.Name = "numCellCost"
        Me.numCellCost.Size = New System.Drawing.Size(57, 20)
        Me.numCellCost.TabIndex = 82
        '
        'gbPricing
        '
        Me.gbPricing.Controls.Add(Me.Label12)
        Me.gbPricing.Controls.Add(Me.numCellCost)
        Me.gbPricing.Controls.Add(Me.Label13)
        Me.gbPricing.Controls.Add(Me.numFreightCost)
        Me.gbPricing.Location = New System.Drawing.Point(120, 27)
        Me.gbPricing.Name = "gbPricing"
        Me.gbPricing.Size = New System.Drawing.Size(150, 78)
        Me.gbPricing.TabIndex = 83
        Me.gbPricing.TabStop = False
        Me.gbPricing.Text = "Pricing"
        '
        'gbConfig
        '
        Me.gbConfig.Controls.Add(Me.Label2)
        Me.gbConfig.Controls.Add(Me.lbl)
        Me.gbConfig.Controls.Add(Me.numParallel)
        Me.gbConfig.Controls.Add(Me.numSeries)
        Me.gbConfig.Location = New System.Drawing.Point(7, 27)
        Me.gbConfig.Name = "gbConfig"
        Me.gbConfig.Size = New System.Drawing.Size(107, 78)
        Me.gbConfig.TabIndex = 84
        Me.gbConfig.TabStop = False
        Me.gbConfig.Text = "Configuration"
        '
        'gbData
        '
        Me.gbData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbData.Controls.Add(Me.lbConfigs)
        Me.gbData.Controls.Add(Me.Label3)
        Me.gbData.Controls.Add(Me.txtHeight)
        Me.gbData.Controls.Add(Me.txtArrangement)
        Me.gbData.Controls.Add(Me.Label1)
        Me.gbData.Controls.Add(Me.Label10)
        Me.gbData.Controls.Add(Me.Label9)
        Me.gbData.Controls.Add(Me.Label11)
        Me.gbData.Controls.Add(Me.txtConfig)
        Me.gbData.Controls.Add(Me.txtTotalCost)
        Me.gbData.Controls.Add(Me.txtVoltage)
        Me.gbData.Controls.Add(Me.txtCapacity)
        Me.gbData.Controls.Add(Me.Label8)
        Me.gbData.Controls.Add(Me.txtWidth)
        Me.gbData.Controls.Add(Me.Label7)
        Me.gbData.Controls.Add(Me.txtLength)
        Me.gbData.Controls.Add(Me.pbLogo)
        Me.gbData.Controls.Add(Me.Label4)
        Me.gbData.Controls.Add(Me.Label5)
        Me.gbData.Controls.Add(Me.txtCellCount)
        Me.gbData.Controls.Add(Me.Label6)
        Me.gbData.Controls.Add(Me.txtWeight)
        Me.gbData.Location = New System.Drawing.Point(7, 111)
        Me.gbData.MinimumSize = New System.Drawing.Size(0, 506)
        Me.gbData.Name = "gbData"
        Me.gbData.Size = New System.Drawing.Size(263, 506)
        Me.gbData.TabIndex = 0
        Me.gbData.TabStop = False
        Me.gbData.Text = "Data"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 682)
        Me.Controls.Add(Me.gbData)
        Me.Controls.Add(Me.gbConfig)
        Me.Controls.Add(Me.gbPricing)
        Me.Controls.Add(Me.cbShowConnections)
        Me.Controls.Add(Me.cbShowCells)
        Me.Controls.Add(Me.MsMain)
        Me.Controls.Add(Me.gbMain)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(298, 721)
        Me.Name = "FrmMain"
        Me.Text = "FPV-POWER Li-ion Config Tool"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MsMain.ResumeLayout(False)
        Me.MsMain.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numParallel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFreightCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCellCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPricing.ResumeLayout(False)
        Me.gbPricing.PerformLayout()
        Me.gbConfig.ResumeLayout(False)
        Me.gbConfig.PerformLayout()
        Me.gbData.ResumeLayout(False)
        Me.gbData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbMain As GroupBox
    Friend WithEvents lbConfigs As ListBox
    Friend WithEvents txtVoltage As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbShowConnections As CheckBox
    Friend WithEvents cbShowCells As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConfig As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents MsFile As ToolStripMenuItem
    Friend WithEvents MsExit As ToolStripMenuItem
    Friend WithEvents MsMain As MenuStrip
    Friend WithEvents msSettings As ToolStripMenuItem
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents txtCellCount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtArrangement As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents numSeries As NumericUpDown
    Friend WithEvents numParallel As NumericUpDown
    Friend WithEvents numFreightCost As NumericUpDown
    Friend WithEvents numCellCost As NumericUpDown
    Friend WithEvents gbPricing As GroupBox
    Friend WithEvents gbConfig As GroupBox
    Friend WithEvents gbData As GroupBox
End Class
