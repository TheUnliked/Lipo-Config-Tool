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
        Me.txtArrangement = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCellCount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MsMain.SuspendLayout
        CType(Me.pbLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lbl
        '
        Me.lbl.AutoSize = true
        Me.lbl.Location = New System.Drawing.Point(12, 30)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(39, 13)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "Series:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Parallel:"
        '
        'lblShowVolt
        '
        Me.lblShowVolt.AutoSize = true
        Me.lblShowVolt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblShowVolt.Location = New System.Drawing.Point(118, 31)
        Me.lblShowVolt.Name = "lblShowVolt"
        Me.lblShowVolt.Size = New System.Drawing.Size(0, 13)
        Me.lblShowVolt.TabIndex = 4
        '
        'lblShowCapacity
        '
        Me.lblShowCapacity.AutoSize = true
        Me.lblShowCapacity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblShowCapacity.Location = New System.Drawing.Point(118, 55)
        Me.lblShowCapacity.Name = "lblShowCapacity"
        Me.lblShowCapacity.Size = New System.Drawing.Size(0, 13)
        Me.lblShowCapacity.TabIndex = 5
        '
        'gbMain
        '
        Me.gbMain.BackColor = System.Drawing.SystemColors.Control
        Me.gbMain.Location = New System.Drawing.Point(276, 27)
        Me.gbMain.Name = "gbMain"
        Me.gbMain.Size = New System.Drawing.Size(694, 823)
        Me.gbMain.TabIndex = 12
        Me.gbMain.TabStop = false
        '
        'txtVoltage
        '
        Me.txtVoltage.Location = New System.Drawing.Point(90, 411)
        Me.txtVoltage.Name = "txtVoltage"
        Me.txtVoltage.ReadOnly = true
        Me.txtVoltage.Size = New System.Drawing.Size(180, 20)
        Me.txtVoltage.TabIndex = 5
        '
        'lbConfigs
        '
        Me.lbConfigs.FormattingEnabled = true
        Me.lbConfigs.Location = New System.Drawing.Point(12, 128)
        Me.lbConfigs.Name = "lbConfigs"
        Me.lbConfigs.Size = New System.Drawing.Size(258, 251)
        Me.lbConfigs.TabIndex = 3
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(90, 437)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.ReadOnly = true
        Me.txtCapacity.Size = New System.Drawing.Size(180, 20)
        Me.txtCapacity.TabIndex = 6
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(90, 489)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.ReadOnly = true
        Me.txtWidth.Size = New System.Drawing.Size(180, 20)
        Me.txtWidth.TabIndex = 10
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(90, 515)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.ReadOnly = true
        Me.txtLength.Size = New System.Drawing.Size(180, 20)
        Me.txtLength.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Voltage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Capacity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(12, 492)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Width:"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(12, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Length:"
        '
        'cbShowConnections
        '
        Me.cbShowConnections.AutoSize = true
        Me.cbShowConnections.Location = New System.Drawing.Point(17, 706)
        Me.cbShowConnections.Name = "cbShowConnections"
        Me.cbShowConnections.Size = New System.Drawing.Size(115, 17)
        Me.cbShowConnections.TabIndex = 17
        Me.cbShowConnections.Text = "Show Connections"
        Me.cbShowConnections.UseVisualStyleBackColor = true
        '
        'cbShowCells
        '
        Me.cbShowCells.AutoSize = true
        Me.cbShowCells.Location = New System.Drawing.Point(18, 683)
        Me.cbShowCells.Name = "cbShowCells"
        Me.cbShowCells.Size = New System.Drawing.Size(78, 17)
        Me.cbShowCells.TabIndex = 16
        Me.cbShowCells.Text = "Show Cells"
        Me.cbShowCells.UseVisualStyleBackColor = true
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(12, 466)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Weight:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(90, 463)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = true
        Me.txtWeight.Size = New System.Drawing.Size(180, 20)
        Me.txtWeight.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(12, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Config:"
        '
        'txtConfig
        '
        Me.txtConfig.Location = New System.Drawing.Point(90, 385)
        Me.txtConfig.Name = "txtConfig"
        Me.txtConfig.ReadOnly = true
        Me.txtConfig.Size = New System.Drawing.Size(180, 20)
        Me.txtConfig.TabIndex = 4
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
        Me.txtParallel.TabIndex = 2
        Me.txtParallel.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(12, 545)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Height:"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(90, 542)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.ReadOnly = true
        Me.txtHeight.Size = New System.Drawing.Size(180, 20)
        Me.txtHeight.TabIndex = 12
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
        Me.msSettings.AutoSize = false
        Me.msSettings.Image = CType(resources.GetObject("msSettings.Image"),System.Drawing.Image)
        Me.msSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.msSettings.Name = "msSettings"
        Me.msSettings.Size = New System.Drawing.Size(152, 22)
        Me.msSettings.Text = "Settings"
        '
        'MsExit
        '
        Me.MsExit.AutoSize = false
        Me.MsExit.Image = CType(resources.GetObject("MsExit.Image"),System.Drawing.Image)
        Me.MsExit.Name = "MsExit"
        Me.MsExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4),System.Windows.Forms.Keys)
        Me.MsExit.Size = New System.Drawing.Size(152, 22)
        Me.MsExit.Text = "Exit"
        '
        'MsMain
        '
        Me.MsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsFile})
        Me.MsMain.Location = New System.Drawing.Point(0, 0)
        Me.MsMain.Name = "MsMain"
        Me.MsMain.Size = New System.Drawing.Size(982, 24)
        Me.MsMain.TabIndex = 9
        Me.MsMain.Text = "MenuStrip1"
        '
        'pbLogo
        '
        Me.pbLogo.BackgroundImage = CType(resources.GetObject("pbLogo.BackgroundImage"),System.Drawing.Image)
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbLogo.Location = New System.Drawing.Point(15, 577)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(258, 100)
        Me.pbLogo.TabIndex = 26
        Me.pbLogo.TabStop = false
        '
        'btnParallelDown
        '
        Me.btnParallelDown.BackgroundImage = CType(resources.GetObject("btnParallelDown.BackgroundImage"),System.Drawing.Image)
        Me.btnParallelDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParallelDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParallelDown.Location = New System.Drawing.Point(98, 61)
        Me.btnParallelDown.Name = "btnParallelDown"
        Me.btnParallelDown.Size = New System.Drawing.Size(14, 10)
        Me.btnParallelDown.TabIndex = 16
        Me.btnParallelDown.UseVisualStyleBackColor = true
        '
        'btnParallelUp
        '
        Me.btnParallelUp.BackgroundImage = CType(resources.GetObject("btnParallelUp.BackgroundImage"),System.Drawing.Image)
        Me.btnParallelUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnParallelUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnParallelUp.Location = New System.Drawing.Point(98, 52)
        Me.btnParallelUp.Name = "btnParallelUp"
        Me.btnParallelUp.Size = New System.Drawing.Size(14, 10)
        Me.btnParallelUp.TabIndex = 15
        Me.btnParallelUp.UseVisualStyleBackColor = true
        '
        'btnSeriesDown
        '
        Me.btnSeriesDown.BackgroundImage = CType(resources.GetObject("btnSeriesDown.BackgroundImage"),System.Drawing.Image)
        Me.btnSeriesDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeriesDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeriesDown.Location = New System.Drawing.Point(98, 36)
        Me.btnSeriesDown.Name = "btnSeriesDown"
        Me.btnSeriesDown.Size = New System.Drawing.Size(14, 10)
        Me.btnSeriesDown.TabIndex = 14
        Me.btnSeriesDown.UseVisualStyleBackColor = true
        '
        'btnSeriesUp
        '
        Me.btnSeriesUp.BackgroundImage = CType(resources.GetObject("btnSeriesUp.BackgroundImage"),System.Drawing.Image)
        Me.btnSeriesUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSeriesUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeriesUp.Location = New System.Drawing.Point(98, 27)
        Me.btnSeriesUp.Name = "btnSeriesUp"
        Me.btnSeriesUp.Size = New System.Drawing.Size(14, 10)
        Me.btnSeriesUp.TabIndex = 13
        Me.btnSeriesUp.UseVisualStyleBackColor = true
        '
        'txtArrangement
        '
        Me.txtArrangement.Location = New System.Drawing.Point(90, 78)
        Me.txtArrangement.Name = "txtArrangement"
        Me.txtArrangement.ReadOnly = true
        Me.txtArrangement.Size = New System.Drawing.Size(180, 20)
        Me.txtArrangement.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Location = New System.Drawing.Point(12, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Arrangement:"
        '
        'txtCellCount
        '
        Me.txtCellCount.Location = New System.Drawing.Point(90, 102)
        Me.txtCellCount.Name = "txtCellCount"
        Me.txtCellCount.ReadOnly = true
        Me.txtCellCount.Size = New System.Drawing.Size(180, 20)
        Me.txtCellCount.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(12, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Cell Count:"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 891)
        Me.Controls.Add(Me.txtArrangement)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCellCount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVoltage)
        Me.Controls.Add(Me.txtCapacity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.btnParallelDown)
        Me.Controls.Add(Me.btnParallelUp)
        Me.Controls.Add(Me.btnSeriesDown)
        Me.Controls.Add(Me.btnSeriesUp)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtParallel)
        Me.Controls.Add(Me.txtSeries)
        Me.Controls.Add(Me.txtConfig)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbShowConnections)
        Me.Controls.Add(Me.cbShowCells)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbConfigs)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.MsMain)
        Me.Controls.Add(Me.gbMain)
        Me.Controls.Add(Me.lblShowCapacity)
        Me.Controls.Add(Me.lblShowVolt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl)
        Me.DoubleBuffered = true
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.Name = "FrmMain"
        Me.Text = "FPV-POWER Li-ion Config Tool"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MsMain.ResumeLayout(false)
        Me.MsMain.PerformLayout
        CType(Me.pbLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

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
    Friend WithEvents txtArrangement As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCellCount As TextBox
    Friend WithEvents Label6 As Label
End Class
