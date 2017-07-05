Public Class FrmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numudCellSize.Value = My.Settings.Item("CellSize")
        numudThickness.Value = My.Settings.Item("PenWidth")
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Item("CellSize") = numudCellSize.Value
        My.Settings.Item("PenWidth") = numudThickness.Value
        My.Settings.Save()
        frmMain.LoadSettings()
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class