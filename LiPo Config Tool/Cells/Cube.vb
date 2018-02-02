Public Class Cube
    Public Property Width As Double
    Public Property Length As Double
    Public ReadOnly Property Height As Integer

    Public Sub New(_width As Double, _length As Double, _height As Integer)
        Width = _width
        Length = _length
        Height = _height
    End Sub
End Class
