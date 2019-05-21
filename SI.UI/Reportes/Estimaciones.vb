Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class Estimaciones
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    Private Sub Estimaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ObtenerPeriodos()
    End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoTabla = "" 'empresa
            oContratoRO.oBEContratoLote.comentarios = periodo  'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)

            dsregistros = oContratoRO.LeerListaToDSContable_Estimaciones
            dvwRegistros = New DataView(dsregistros.Tables(0))


            'fxgrdExtraccionBd.AutoGenerateColumns = False
            fxgrdExtraccionBd.DataSource = dvwRegistros


            fxgrdExtraccionBd.Cols(3).Width = 120
            fxgrdExtraccionBd.Cols(5).Width = 300


            fxgrdExtraccionBd.Cols(9).Width = 70
            fxgrdExtraccionBd.Cols(10).Width = 70


            fxgrdExtraccionBd.Cols(9).Format = "N2"
            fxgrdExtraccionBd.Cols(10).Format = "N2"
            fxgrdExtraccionBd.Cols(11).Format = "N2"

            fxgrdExtraccionBd.Refresh()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    'Private Sub tsMantenimiento_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    'End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName.Length > 0 Then
                fxgrdExtraccionBd.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub

    'Private Sub gpoContratos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpoContratos.Enter

    'End Sub

    'Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
    '    ObtenerRegistros("", "")
    'End Sub

    'Private Sub tsbConsular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsular.Click
    '    ObtenerRegistros("", "")
    'End Sub

    'Private Sub gpoContratos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    'Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub


    Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
        If cboPeriodo.SelectedIndex > 0 Then
            ObtenerRegistros("", cboPeriodo.SelectedValue)
        End If
    End Sub

    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"
    End Sub

End Class