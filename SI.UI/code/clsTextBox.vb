Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Data



Public Class clsTextBox
    Inherits TextBox

    Private Sub clsTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If ((Char.IsDigit(e.KeyChar) = False) And (Char.IsControl(e.KeyChar) <> True) And (e.KeyChar <> "."c)) Then
            e.Handled = True
        End If
        If ((CType(sender, TextBox).Text.Contains("."c) = True) And (e.KeyChar = "."c)) Then
            e.Handled = True
        End If
        If ((CType(sender, TextBox).Text = String.Empty)) Then
            e.Handled = True
        End If
    End Sub
End Class
