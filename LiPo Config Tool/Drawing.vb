Partial Public Class FrmMain
    Private Sub DrawCells(ByRef e As PaintEventArgs, doIndex As Integer, myPen As Pen)
        For cellLengthIndex As Integer = 1 To listLength(doIndex)
            For cellWidthIndex As Integer = 1 To listWidth(doIndex)
                e.Graphics.DrawEllipse(myPen, cellWidthIndex * cellSize, cellLengthIndex * cellSize, cellSize - 2, cellSize - 2)
            Next
        Next
    End Sub

End Class
