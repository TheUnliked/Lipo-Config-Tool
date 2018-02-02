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
        Me.lblShowVolt = New System.Windows.Forms.Label()
        Me.lblShowCapacity = New System.Windows.Forms.Label()
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
        Me.txtSeries = New System.Windows.Forms.TextBox()
        Me.txtParallel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.MsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.msSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MsMain = New System.Windows.Forms.MenuStrip()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btnParallelDown = New System.Windows.Forms.Button()
        Me.btnParallelUp = New System.Windows.Forms.Button()
        Me.btnSeriesDown = New System.Windows.Forms.Button()
        Me.btnSeriesUp = New System.Windows.Forms.Button()
        Me.txtCellCount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCellCost = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.txtFreightCost = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtArrangement = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MsMain.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(12, 30)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(39, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Series:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Parallel:"
        '
        'lblShowVolt
        '
        Me.lblShowVolt.AutoSize = True
        Me.lblShowVolt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblShowVolt.Location = New System.Drawing.Point(118, 31)
        Me.lblShowVolt.Name = "lblShowVolt"
        Me.lblShowVolt.Size = New System.Drawing.Size(0, 13)
        Me.lblShowVolt.TabIndex = 4
        '
        'lblShowCapacity
        '
        Me.lblShowCapacity.AutoSize = True
        Me.lblShowCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblShowCapacity.Location = New System.Drawing.Point(118, 55)
        Me.lblShowCapacity.Name = "lblShowCapacity"
        Me.lblShowCapacity.Size = New System.Drawing.Size(0, 13)
        Me.lblShowCapacity.TabIndex = 5
        '
        'gbMain
        '
        Me.gbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbMain.BackColor = System.Drawing.SystemColors.Control
        Me.gbMain.Location = New System.Drawing.Point(276, 27)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(403, 630)
        Me.gbMain.TabIndex = 12
        Me.gbMain.TabStop = False
        '
        'txtVoltage
        '
        Me.txtVoltage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVoltage.Location = New System.Drawing.Point(90, 453)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.ReadOnly = True
        Me.txtVoltage.Size = New System.Drawing.Size(180, 20)
        Me.txtVoltage.TabIndex = 45
        Me.txtVoltage.TabStop = False
        '
        'lbConfigs
        '
        Me.lbConfigs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbConfigs.FormattingEnabled = True
        Me.lbConfigs.Location = New System.Drawing.Point(12, 214)
        Me.lbConfigs.Name = "lbConfigs"
        Me.lbConfigs.Size = New System.Drawing.Size(258, 95)
        Me.lbConfigs.TabIndex = 35
        '
        'txtCapacity
        '
        Me.txtCapacity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCapacity.Location = New System.Drawing.Point(90, 479)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.ReadOnly = True
        Me.txtCapacity.Size = New System.Drawing.Size(180, 20)
        Me.txtCapacity.TabIndex = 50
        Me.txtCapacity.TabStop = False
        '
        'txtWidth
        '
        Me.txtWidth.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWidth.Location = New System.Drawing.Point(90, 531)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.ReadOnly = True
        Me.txtWidth.Size = New System.Drawing.Size(180, 20)
        Me.txtWidth.TabIndex = 60
        Me.txtWidth.TabStop = False
        '
        'txtLength
        '
        Me.txtLength.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLength.Location = New System.Drawing.Point(90, 557)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.ReadOnly = True
        Me.txtLength.Size = New System.Drawing.Size(180, 20)
        Me.txtLength.TabIndex = 65
        Me.txtLength.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Voltage:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 482)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Capacity:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 534)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Width:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 560)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Length:"
        '
        'cbShowConnections
        '
        Me.cbShowConnections.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbShowConnections.AutoSize = True
        Me.cbShowConnections.Location = New System.Drawing.Point(17, 640)
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
        Me.cbShowCells.Location = New System.Drawing.Point(18, 617)
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
        Me.Label7.Location = New System.Drawing.Point(12, 508)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtWeight.Location = New System.Drawing.Point(90, 505)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(180, 20)
        Me.txtWeight.TabIndex = 55
        Me.txtWeight.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 430)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Config:"
        '
        'txtConfig
        '
        Me.txtConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtConfig.Location = New System.Drawing.Point(90, 427)
        Me.txtConfig.Name = "txtConfig"
        Me.txtConfig.ReadOnly = True
        Me.txtConfig.Size = New System.Drawing.Size(180, 20)
        Me.txtConfig.TabIndex = 40
        Me.txtConfig.TabStop = False
        '
        'txtSeries
        '
        Me.txtSeries.Location = New System.Drawing.Point(57, 27)
        Me.txtSeries.Name = "txtSeries"
        Me.txtSeries.Size = New System.Drawing.Size(41, 20)
        Me.txtSeries.TabIndex = 1
        Me.txtSeries.Text = "1"
        '
        'txtParallel
        '
        Me.txtParallel.Location = New System.Drawing.Point(57, 52)
        Me.txtParallel.Name = "txtParallel"
        Me.txtParallel.Size = New System.Drawing.Size(41, 20)
        Me.txtParallel.TabIndex = 5
        Me.txtParallel.Text = "1"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 587)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Height:"
        '
        'txtHeight
        '
        Me.txtHeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtHeight.Location = New System.Drawing.Point(90, 584)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = True
        Me.txtHeight.Size = New System.Drawing.Size(180, 20)
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
        Me.MsMain.Size = New System.Drawing.Size(691, 24)
        Me.MsMain.TabIndex = 9
        Me.MsMain.Text = "MenuStrip1"
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbLogo.BackgroundImage = CType(resources.GetObject("pbLogo.BackgroundImage"), System.Drawing.Image)
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbLogo.Location = New System.Drawing.Point(12, 319)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(258, 100)
        Me.pbLogo.TabIndex = 26
        Me.pbLogo.TabStop = False
        '
        'btnParallelDown
        '
        Me.btnParallelDown.BackgroundImage = CType(resources.GetObject("btnParallelDown.BackgroundImage"), System.Drawing.Image)
        Me.btnParallelDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParallelDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParallelDown.Location = New System.Drawing.Point(98, 61)
        Me.btnParallelDown.Name = "btnParallelDown"
        Me.btnParallelDown.Size = New System.Drawing.Size(14, 10)
        Me.btnParallelDown.TabIndex = 16
        Me.btnParallelDown.TabStop = False
        Me.btnParallelDown.UseVisualStyleBackColor = True
        '
        'btnParallelUp
        '
        Me.btnParallelUp.BackgroundImage = CType(resources.GetObject("btnParallelUp.BackgroundImage"), System.Drawing.Image)
        Me.btnParallelUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParallelUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParallelUp.Location = New System.Drawing.Point(98, 52)
        Me.btnParallelUp.Name = "btnParallelUp"
        Me.btnParallelUp.Size = New System.Drawing.Size(14, 10)
        Me.btnParallelUp.TabIndex = 15
        Me.btnParallelUp.TabStop = False
        Me.btnParallelUp.UseVisualStyleBackColor = True
        '
        'btnSeriesDown
        '
        Me.btnSeriesDown.BackgroundImage = CType(resources.GetObject("btnSeriesDown.BackgroundImage"), System.Drawing.Image)
        Me.btnSeriesDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeriesDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeriesDown.Location = New System.Drawing.Point(98, 36)
        Me.btnSeriesDown.Name = "btnSeriesDown"
        Me.btnSeriesDown.Size = New System.Drawing.Size(14, 10)
        Me.btnSeriesDown.TabIndex = 14
        Me.btnSeriesDown.TabStop = False
        Me.btnSeriesDown.UseVisualStyleBackColor = True
        '
        'btnSeriesUp
        '
        Me.btnSeriesUp.BackgroundImage = CType(resources.GetObject("btnSeriesUp.BackgroundImage"), System.Drawing.Image)
        Me.btnSeriesUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeriesUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeriesUp.Location = New System.Drawing.Point(98, 27)
        Me.btnSeriesUp.Name = "btnSeriesUp"
        Me.btnSeriesUp.Size = New System.Drawing.Size(14, 10)
        Me.btnSeriesUp.TabIndex = 13
        Me.btnSeriesUp.TabStop = False
        Me.btnSeriesUp.UseVisualStyleBackColor = True
        '
        'txtCellCount
        '
        Me.txtCellCount.Enabled = False
        Me.txtCellCount.Location = New System.Drawing.Point(90, 133)
        Me.txtCellCount.Name = "txtCellCount"
        Me.txtCellCount.ReadOnly = True
        Me.txtCellCount.Size = New System.Drawing.Size(180, 20)
        Me.txtCellCount.TabIndex = 20
        Me.txtCellCount.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Cell Count:"
        '
        'txtCellCost
        '
        Me.txtCellCost.BackColor = System.Drawing.SystemColors.Window
        Me.txtCellCost.Location = New System.Drawing.Point(90, 107)
        Me.txtCellCost.Name = "txtCellCost"
        Me.txtCellCost.Size = New System.Drawing.Size(180, 20)
        Me.txtCellCost.TabIndex = 15
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BackColor = System.Drawing.SystemColors.Control
        Me.txtTotalCost.Enabled = False
        Me.txtTotalCost.Location = New System.Drawing.Point(90, 162)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(180, 20)
        Me.txtTotalCost.TabIndex = 25
        Me.txtTotalCost.TabStop = False
        '
        'txtFreightCost
        '
        Me.txtFreightCost.BackColor = System.Drawing.SystemColors.Window
        Me.txtFreightCost.Location = New System.Drawing.Point(90, 81)
        Me.txtFreightCost.Name = "txtFreightCost"
        Me.txtFreightCost.Size = New System.Drawing.Size(180, 20)
        Me.txtFreightCost.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Total Cost:"
        '
        'txtArrangement
        '
        Me.txtArrangement.Enabled = False
        Me.txtArrangement.Location = New System.Drawing.Point(90, 188)
        Me.txtArrangement.Name = "txtArrangement"
        Me.txtArrangement.ReadOnly = True
        Me.txtArrangement.Size = New System.Drawing.Size(180, 20)
        Me.txtArrangement.TabIndex = 30
        Me.txtArrangement.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 191)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Arrangement:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Freight / kg:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Cost / Cell:"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 668)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtArrangement)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFreightCost)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtCellCost)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCellCount)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnParallelDown)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnParallelUp)
        Me.Controls.Add(Me.txtVoltage)
        Me.Controls.Add(Me.btnSeriesDown)
        Me.Controls.Add(Me.txtConfig)
        Me.Controls.Add(Me.btnSeriesUp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtParallel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSeries)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.cbShowConnections)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbShowCells)
        Me.Controls.Add(Me.lbConfigs)
        Me.Controls.Add(Me.MsMain)
        Me.Controls.Add(Me.gbMain)
        Me.Controls.Add(Me.lblShowCapacity)
        Me.Controls.Add(Me.lblShowVolt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(298, 707)
        Me.Name = "FrmMain"
        Me.Text = "FPV-POWER Li-ion Config Tool"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MsMain.ResumeLayout(False)
        Me.MsMain.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblShowVolt As Label
    Friend WithEvents lblShowCapacity As Label
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
    Friend WithEvents txtSeries As TextBox
    Friend WithEvents txtParallel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents btnSeriesUp As Button
    Friend WithEvents btnSeriesDown As Button
    Friend WithEvents btnParallelDown As Button
    Friend WithEvents btnParallelUp As Button
    Friend WithEvents MsFile As ToolStripMenuItem
    Friend WithEvents MsExit As ToolStripMenuItem
    Friend WithEvents MsMain As MenuStrip
    Friend WithEvents msSettings As ToolStripMenuItem
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents txtCellCount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCellCost As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents txtFreightCost As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtArrangement As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
