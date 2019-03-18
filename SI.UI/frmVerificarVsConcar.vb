Public Class frmVerificarVsConcar

    Public empresaID As String
    Public periodo As String
    Public tipoMovimiento As String

    Private oMensajeError As mensajeError = New mensajeError

    Private Sub frmVerificarVsConcar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oGeneralRO As New SI.BC.clsBC_GeneralRO()
        Try
            With oGeneralRO.oBEGeneral
                .ValCampo1 = empresaID
                .ValCampo2 = periodo
                .ValCampo3 = tipoMovimiento
            End With

            Dim ds As DataSet = oGeneralRO.Obtener_RegistrosToVerificarConcarDS

            If ds Is Nothing Then
                MsgBox("No hay registros de variacion para mostrar.", MsgBoxStyle.Information, "Valorizador de Minerales")
                Me.Dispose()
            Else
                fxgrdContabilidad.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName.Length > 0 Then
            fxgrdContabilidad.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If
    End Sub


End Class