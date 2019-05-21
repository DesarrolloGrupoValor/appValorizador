Imports SI.UT.clsUT_Funcion
Imports SI.PL.clsGeneral
Public Class configuracion
    Private clDialog As New ColorDialog
    Private Sub lblColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblColor.Click
        With clDialog
            .AnyColor = True
            .AllowFullOpen = True
            .ShowHelp = True
            .Color = lblColor.BackColor
            If (.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                lblColor.BackColor = .Color

            End If
        End With
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        Select Case keyData
            Case Keys.Escape

                Me.Dispose()

        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        setConfig("ColorRed", lblColor.BackColor.R)
        setConfig("ColorGreen", lblColor.BackColor.G)
        setConfig("ColorBlue", lblColor.BackColor.B)
        SetConfiguracion()
        Me.Dispose()
    End Sub

    Private Sub configuracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        lblColor.BackColor = ColorForm
    End Sub

    
End Class