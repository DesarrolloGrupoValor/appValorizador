Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class LiquidacionesLote
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    Private Sub LiquidacionesLote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ObtenerRegistros(ByVal periodo As String)
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
            oContratoRO.oBEContratoLote.comentarios = periodo  'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)

            dsregistros = oContratoRO.LeerListaToDSContable_Liquidacioneslote
            dvwRegistros = New DataView(dsregistros.Tables(0))


            'fxgrdExtraccionBd.AutoGenerateColumns = False
            fxgrdLiquidaciones.DataSource = dvwRegistros

            fxgrdLiquidaciones.Cols(1).Width = 50
            fxgrdLiquidaciones.Cols(2).Width = 50
            fxgrdLiquidaciones.Cols(3).Width = 50
            fxgrdLiquidaciones.Cols(6).Width = 300
            fxgrdLiquidaciones.Cols(7).Width = 200
            fxgrdLiquidaciones.Cols(8).Width = 50
            fxgrdLiquidaciones.Cols(9).Width = 50
            fxgrdLiquidaciones.Cols(10).Width = 50
            fxgrdLiquidaciones.Cols(11).Width = 50
            fxgrdLiquidaciones.Cols(12).Width = 50


            fxgrdLiquidaciones.Cols(9).Width = 70
            fxgrdLiquidaciones.Cols(10).Width = 70

            fxgrdLiquidaciones.Cols(8).Format = "N2"
            fxgrdLiquidaciones.Cols(9).Format = "N2"
            fxgrdLiquidaciones.Cols(10).Format = "N2"
            fxgrdLiquidaciones.Cols(15).Format = "N2"
            fxgrdLiquidaciones.Cols(16).Format = "N2"
            fxgrdLiquidaciones.Cols(17).Format = "N2"
            fxgrdLiquidaciones.Cols(18).Format = "N2"
            fxgrdLiquidaciones.Cols(19).Format = "N2"
            fxgrdLiquidaciones.Cols(20).Format = "N2"

            fxgrdLiquidaciones.Refresh()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName.Length > 0 Then
                fxgrdLiquidaciones.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub


    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If TbxPeriodo.Text.Length > 0 Then
            ObtenerRegistros(TbxPeriodo.Text)
        End If
    End Sub

    Private Sub TsbSalir_Click_1(sender As System.Object, e As System.EventArgs) Handles TsbSalir.Click
        Me.Dispose()
    End Sub
End Class
