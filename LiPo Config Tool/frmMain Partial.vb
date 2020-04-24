Partial Public Class FrmMain
    Private Sub LoadInfo()
        For i As Integer = 0 To listWidth.Count - 1

            Dim currentConfigData As New CellConfiguration
            With currentConfigData
                .Voltage = seriesVal * 3.7
                .Capacity = parallelVal * 3500
                .Dimensions = New Cube(listWidth(i) * 18.5, listLength(i) * 18.5, My.Resources.CellHeight)
                .CellCount = listWidth(i) * listLength(i)
                .Weight = .CellCount * My.Resources.CellWeight
                .Config = seriesVal & "S" & parallelVal & "P"
                .Arrangement = listWidth(i) & " X " & listLength(i)

                displayDataList.Add(currentConfigData)
                lbConfigs.Items.Add(.Dimensions.Height & "mm (H) x " & .Dimensions.Length & "mm (L) x " & .Dimensions.Width & "mm (W)")
            End With
        Next


        'costs
        Dim cellCount As Integer = parallelVal * seriesVal

        Dim totalFreightCost As Double
        totalFreightCost = freightCost / 1000 * Val(My.Resources.CellWeight)

        txtTotalCost.Text = "$" & (numCellCost.Text + totalFreightCost) * cellCount
    End Sub

    Public Sub LoadSettings()
        penWidth = My.Settings.Item("penWidth")
        cellSize = My.Settings.Item("CellSize")
        gbMain.Refresh()
    End Sub

    Private Sub ClearConfigData()
        txtConfig.Clear()
        txtVoltage.Clear()
        txtCapacity.Clear()
        txtWeight.Clear()
        txtWidth.Clear()
        txtLength.Clear()
        txtHeight.Clear()
        txtCellCount.Clear()
    End Sub

    Private Sub ShowConfigData(configListIndex As Integer)
        With displayDataList.Item(configListIndex) 'disp. data
            txtVoltage.Text = .Voltage & "V"
            txtCapacity.Text = .Capacity & " mAh"
            txtWidth.Text = .Dimensions.Width & " mm"
            txtLength.Text = .Dimensions.Length & " mm"
            txtHeight.Text = .Dimensions.Height & " mm"
            txtCellCount.Text = .CellCount
            txtWeight.Text = .Weight & "g"
            txtConfig.Text = .Config
            txtArrangement.Text = .Arrangement
        End With
    End Sub


End Class
