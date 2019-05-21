Imports System.Math

Public Module EnhancedMath

    Private Delegate Function RoundingFunction(ByVal value As Double) As Double

    Private Enum RoundingDirection
        Up
        Down
    End Enum

    Public Function RoundUp(ByVal value As Double, ByVal precision As Integer) As Double
        Return Round(value, precision, RoundingDirection.Up)
    End Function

    Public Function RoundDown(ByVal value As Double, ByVal precision As Integer) _
 As Double
        Return Round(value, precision, RoundingDirection.Down)
    End Function

    Private Function Round(ByVal value As Double, ByVal precision As Integer, _
 ByVal roundingDirection As RoundingDirection) As Double
        Dim roundingFunction As RoundingFunction
        If roundingDirection = roundingDirection.Up Then
            roundingFunction = AddressOf Math.Ceiling
        Else
            roundingFunction = AddressOf Math.Floor
        End If
        value = value * Math.Pow(10, precision)
        value = roundingFunction(value)
        Return value * Math.Pow(10, -1 * precision)
    End Function

End Module
