Imports System.Text.RegularExpressions

Public Class FrmMain

    ReadOnly displayDataList As New List(Of CellConfiguration)
    ReadOnly listWidth As New List(Of Integer)
    ReadOnly listLength As New List(Of Integer)
    Dim parallelVal As Integer
    Dim seriesVal As Integer
    Dim canProcess As Boolean = False

    Private Sub Start()
        'INIT
        If Not canProcess Then Exit Sub
        If numSeries.Text = "" OrElse numParallel.Text = "" Then Exit Sub

        gbMain.Controls.Clear() 'clear all cells inside group box
        lbConfigs.Items.Clear()
        displayDataList.Clear()
        listWidth.Clear()
        listLength.Clear()



        'GET LIST OF DIMENSIONS
        Dim comb As New List(Of Integer)
        For i As Integer = 2 To parallelVal * seriesVal - 2 'find and load all possible arrangments of cells
            If Divisible(parallelVal * seriesVal, i) = True Then
                comb.Add(i)
            End If
        Next

        If Divisible(comb.Count, 2) = False Then
            'numbers are have square roots, resulting in uneven numbers of factors of cells
            comb.Insert(comb.Count / 2, comb((comb.Count - 1) / 2))
        End If

        listWidth.AddRange(comb.GetRange(0, comb.Count / 2))
        listLength.AddRange(comb.GetRange(comb.Count / 2, comb.Count / 2))
        listLength.Reverse()

        LoadInfo()

        DisplayCosts()


        If lbConfigs.Items.Count > 0 Then
            lbConfigs.SelectedIndex = 0
        Else
            'gbmain paints
            gbMain.Refresh()
        End If

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbMain.Location = New Point(lbConfigs.Right + 10, 10)
        gbMain.Size = New Size(Width - gbMain.Left, Height)

        'toggle showline enabled
        cbShowCells.Checked = My.Settings.cbShowCellsChecked
        cbShowConnections.Checked = My.Settings.cbShowConnectionsChecked


        cbShowConnections.Enabled = cbShowCells.Checked
        LoadSettings()
    End Sub

    Private Function Divisible(inputNum As Integer, divisor As Integer)
        If inputNum Mod divisor = 0 Then
            'divisible
            Return True
        Else
            Return False
        End If
    End Function

    Private Enum DrawMode
        All
        Cells
        Null
    End Enum
    Private _drawMode As DrawMode = DrawMode.Null

    Private Sub LbConfigs_SelectedIndexChanged() Handles lbConfigs.SelectedIndexChanged
        If Not lbConfigs.SelectedIndex = -1 Then
            ShowConfigData(lbConfigs.SelectedIndex)
            gbMain.Refresh()
        Else
            ClearConfigData()
        End If
    End Sub

    Private Sub DrawCellsLines()
        If cbShowCells.Checked Then
            _drawMode = DrawMode.Cells

            If cbShowConnections.Checked AndAlso cbShowConnections.Enabled AndAlso cbShowConnections.Checked Then
                _drawMode = DrawMode.All
            End If
        Else
            _drawMode = DrawMode.Null
        End If
        If lbConfigs.Items.Count > 0 Then
            gbMain.Refresh()
        End If
    End Sub


    Dim penWidth As Integer
    Private Sub MsExit_Click(sender As Object, e As EventArgs) Handles MsExit.Click
        Close()
    End Sub

    Private Sub CbShowCells_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowCells.CheckedChanged
        cbShowConnections.Enabled = cbShowCells.Checked
        DrawCellsLines()
    End Sub

    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Item("cbShowCellsChecked") = cbShowCells.Checked
        My.Settings.Item("cbShowConnectionsChecked") = cbShowConnections.Checked
        My.Settings.Save()
    End Sub

    Private Sub CbShowConnections_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowConnections.CheckedChanged
        DrawCellsLines()
    End Sub

    Dim cellSize As Integer
    Private Sub GbMain_Paint(sender As Object, e As PaintEventArgs) Handles gbMain.Paint
        If lbConfigs.Items.Count = 0 Then Exit Sub
        If lbConfigs.SelectedIndex = -1 Then Exit Sub
        If _drawMode = DrawMode.Null Then Exit Sub

        Dim myPen As New Pen(Color.Black, penWidth)
        Dim doIndex As Integer = lbConfigs.SelectedIndex

        DrawCells(e, doIndex, myPen)

        If _drawMode = DrawMode.Cells Then Exit Sub

        'drawlines
        Dim widthIndex As Integer
        Dim lengthIndex As Integer

        If Divisible(parallelVal, listLength(doIndex)) Then
            'do ||; or |_|''|

            'draw vertical lines. cellSize / 2 for left margin
            For drawVert As Integer = 1 To listWidth(doIndex)
                widthIndex = cellSize / 2 + drawVert * cellSize
                lengthIndex = cellSize * 1.5
                e.Graphics.DrawLine(myPen, widthIndex, lengthIndex, widthIndex, lengthIndex + (listLength(doIndex) - 1) * cellSize)
            Next

            'For xStart As Integer = cellSize * 1.5 To listWidth(doIndex) + cellSize / 2 Step cellSize
            '    For yStart As Integer = 1 To listLength(doIndex)

            '    Next
            'Next

        ElseIf Divisible(listWidth(doIndex), parallelVal) Then
            'do ==
            For drawLength As Integer = 1 To listLength(doIndex)
                widthIndex = cellSize * 1.5
                lengthIndex = cellSize / 2 + drawLength * cellSize
                For drawWidth = 1 To listWidth(doIndex) / parallelVal
                    e.Graphics.DrawLine(myPen, widthIndex, lengthIndex, widthIndex + (parallelVal - 1) * cellSize, lengthIndex)
                    widthIndex += parallelVal * cellSize
                Next
            Next
        ElseIf Divisible(parallelVal, listWidth(doIndex)) Then
            'do ] or 5
            lengthIndex = cellSize * 1.5
            For drawLength = 1 To listLength(doIndex) 'draw horizontal lines
                widthIndex = cellSize * 1.5
                e.Graphics.DrawLine(myPen, widthIndex, lengthIndex, widthIndex + (listWidth(doIndex) - 1) * cellSize, lengthIndex)
                lengthIndex += cellSize
            Next

            'draw vertical lines
            Dim side As String = "right"
            lengthIndex = cellSize * 1.5
            For i As Integer = 1 To listLength(doIndex)
                If Divisible(i, parallelVal / listWidth(doIndex)) = False Then
                    If side = "right" Then
                        e.Graphics.DrawLine(myPen, Integer.Parse(cellSize / 2) + listWidth(doIndex) * cellSize, lengthIndex, Integer.Parse(cellSize / 2) + listWidth(doIndex) * cellSize, lengthIndex + cellSize)
                        side = "left"
                    Else
                        e.Graphics.DrawLine(myPen, Integer.Parse(cellSize * 1.5), lengthIndex, Integer.Parse(cellSize * 1.5), lengthIndex + cellSize)
                        side = "right"
                    End If

                End If
                lengthIndex += cellSize
            Next
        Else
            Dim individualWidth As Integer = GetGcf(parallelVal, listWidth(doIndex))
            'draw horizontal lines
            For drawWidth As Integer = 1 To listWidth(doIndex) Step individualWidth
                widthIndex = (cellSize / 2) + (drawWidth * cellSize)
                lengthIndex = Integer.Parse(cellSize * 1.5)

                For drawLength = 1 To listLength(doIndex) 'draw horizontal lines
                    e.Graphics.DrawLine(myPen, widthIndex, lengthIndex, widthIndex + ((individualWidth - 1) * cellSize), lengthIndex)
                    lengthIndex += cellSize
                Next
            Next

            'draw vertical lines
            For drawWidth As Integer = 0 To listWidth(doIndex) - 1 Step individualWidth
                Dim side As String = "right"
                lengthIndex = Integer.Parse(cellSize * 1.5)
                widthIndex = Integer.Parse(cellSize * 1.5 + (drawWidth * cellSize))
                For drawLength As Integer = 1 To listLength(doIndex)
                    If Not Divisible(drawLength, parallelVal / individualWidth) Then
                        If side = "right" Then
                            e.Graphics.DrawLine(myPen, widthIndex + ((individualWidth - 1) * cellSize), lengthIndex, widthIndex + ((individualWidth - 1) * cellSize), lengthIndex + cellSize)
                            side = "left"
                        Else
                            e.Graphics.DrawLine(myPen, widthIndex, lengthIndex, widthIndex, lengthIndex + cellSize)
                            side = "right"
                        End If

                    End If
                    lengthIndex += cellSize
                Next
            Next
        End If
    End Sub

    Private Sub numSeries_ValueChanged(sender As Object, e As EventArgs) Handles numSeries.ValueChanged
        seriesVal = numSeries.Value
        Start()
    End Sub

    Private Sub numParallel_ValueChanged(sender As Object, e As EventArgs) Handles numParallel.ValueChanged
        parallelVal = numParallel.Value
        Start()
    End Sub

    Private Sub txtSeries_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Tab Then
            numParallel.Select(0, numParallel.Text.Length - 1)
        End If

    End Sub

    Private Function GetGcf(firstNumber As Integer, secondNumber As Integer)
        Dim firstFactors As New List(Of Integer)
        Dim secondFactors As New List(Of Integer)
        Dim gcf As Integer

        'get factors
        For loopfactor As Integer = firstNumber To 1 Step -1
            If Divisible(firstNumber, loopfactor) Then
                firstFactors.Add(loopfactor)
            End If
        Next
        For loopfactor As Integer = secondNumber To 1 Step -1
            If Divisible(secondNumber, loopfactor) Then
                secondFactors.Add(loopfactor)
            End If
        Next

        'find GCF
        For i As Integer = 0 To secondFactors.Count - 1
            If firstFactors.Contains(secondFactors(i)) Then
                gcf = secondFactors(i)
                Exit For
            End If
        Next

        Return gcf
    End Function

    Private Sub lbConfigs_MouseDown(sender As Object, e As MouseEventArgs) Handles lbConfigs.MouseDown
        If lbConfigs.IndexFromPoint(e.Location) = -1 Then
            lbConfigs.SelectedIndex = -1
        End If
    End Sub

    Private Sub frmMain_ClientSizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        gbMain.Refresh()
    End Sub

    Private Sub msSettings_Click(sender As Object, e As EventArgs) Handles msSettings.Click
        FrmSettings.ShowDialog()
    End Sub

    Dim cellCost As Double
    Dim freightCost As Double = 0.00
    Private Sub CostChanged(sender As Object, e As EventArgs) Handles txtFreightCost.TextChanged, txtCellCost.TextChanged

        canProcess = IsNumeric(txtCellCost.Text)

        If IsNumeric(txtCellCost.Text) Then
            cellCost = Val(txtCellCost.Text)
        Else
            Exit Sub
        End If

        If IsNumeric(txtFreightCost.Text) Then freightCost = Val(txtFreightCost.Text)

        Start()
    End Sub

    Private Sub DisplayCosts()
        Dim cellCount As Integer = parallelVal * seriesVal

        Dim totalFreightCost As Double
        totalFreightCost = freightCost / 1000 * Val(My.Resources.CellWeight)

        txtTotalCost.Text = "$" & (txtCellCost.Text + totalFreightCost) * cellCount
    End Sub

    Private Sub txtFreightCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFreightCost.KeyPress, txtCellCost.KeyPress
        'check if new character is digit or decimal point
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = Convert.ToChar(Keys.Back) AndAlso Not e.KeyChar = "." Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub
End Class