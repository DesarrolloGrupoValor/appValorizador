Imports SI.BC
Imports SI.BE

Public Class frmLotesValorizadosVariacion

    Private oMensajeError As mensajeError = New mensajeError

    Private Sub frmLotesValorizadosLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        fxgLotesValorizadosVaricion.AutoGenerateColumns = False

        ObtenerLotesValorizadosVariacion()
    End Sub


    Private Sub ObtenerLotesValorizadosVariacion()
        Dim oLotesValorizadosVariacion As New clsBC_LotesValorizadosLogRO
        Dim dsLotesValorizadosVaricion As DataSet
        dsLotesValorizadosVaricion = oLotesValorizadosVariacion.LeerListaToDSLotesValorizadosVariacion(dtpInicio.Text, dtpFin.Text)

        fxgLotesValorizadosVaricion.AutoGenerateColumns = False

        fxgLotesValorizadosVaricion.DataSource = dsLotesValorizadosVaricion.Tables(0)
        'C1FlexGrid1.FilterDefinition = "<ColumnFilters />"

    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        tbLotesValorizados.SelectedTab = tpVariacion
        ObtenerLotesValorizadosVariacion()
    End Sub

    Private Sub frmLotesValorizadosVariacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        'tbLotesValorizados.SelectedTab = tpVariacion
        'ObtenerLotesValorizadosVariacion()
    End Sub


    Private Sub ObtenerLotesValorizadosLog(ByVal sLoteVCM As String, ByVal sContratoLoteId As String)
        Dim oLotesValorizadosLog As New clsBC_LotesValorizadosLogRO
        Dim dsLotesValorizadosLog As DataSet
        oLotesValorizadosLog.oBE_ContratoLote = New clsBE_ContratoLote
        oLotesValorizadosLog.oBE_ContratoLote.contratoLoteId = sContratoLoteId
        dsLotesValorizadosLog = oLotesValorizadosLog.LeerListaToDSLotesValorizadosLog()

        fxgLotesValorizadosLog.AutoGenerateColumns = False
        fxgLotesValorizadosTmLog.AutoGenerateColumns = False

        fxgLotesValorizadosLog.DataSource = dsLotesValorizadosLog.Tables(0)
        'fxgLotesValorizadosLog.FilterDefinition = "<ColumnFilters />"
        'fxgLotesValorizadosLog.FilterDefinition = "<ColumnFilters><ColumnFilter ColumnIndex='2' ColumnName='LoteVCM'><ValueFilter><ShowValues><Value Value='" & sLoteVCM & "' /></ShowValues></ValueFilter></ColumnFilter></ColumnFilters>"

        If fxgLotesValorizadosLog.Rows.Count > 1 Then
            ObtenerLotesValorizadosTMLog(fxgLotesValorizadosLog.Item(1, "contratoLoteId"), fxgLotesValorizadosLog.Item(1, "liquidacionId"), fxgLotesValorizadosLog.Item(1, "LotesValorizadosLogID"))
        End If


    End Sub

    Private Sub ObtenerLotesValorizadosTMLog(ByVal sContratoLoteId As String, ByVal sLiquidacion As String, ByVal nLotesValorizadosLogID As Integer)
        Dim oLotesValorizadosTMLog As New clsBC_LotesValorizadosTMLogRO
        Dim dsLotesValorizadosTMLog As DataSet
        dsLotesValorizadosTMLog = oLotesValorizadosTMLog.LeerListaToDSLotesValorizadosTMLog(sContratoLoteId, sLiquidacion, nLotesValorizadosLogID)

        fxgLotesValorizadosTmLog.DataSource = dsLotesValorizadosTMLog.Tables(0)

    End Sub

    Private Sub fxgLotesValorizados_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgLotesValorizadosLog.SelChange ', fxgLotesValorizadosTmLog.SelChange
        If fxgLotesValorizadosLog.RowSel > 0 And fxgLotesValorizadosLog.Cols.Count > 2 Then
            ObtenerLotesValorizadosTMLog(fxgLotesValorizadosLog.Item(fxgLotesValorizadosLog.RowSel, "contratoLoteId").ToString, fxgLotesValorizadosLog.Item(fxgLotesValorizadosLog.RowSel, "liquidacionId").ToString, fxgLotesValorizadosLog.Item(fxgLotesValorizadosLog.RowSel, "LotesValorizadosLogID").ToString)
        End If
    End Sub

    Private Sub fxgLotesValorizadosVaricion_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgLotesValorizadosVaricion.DoubleClick
        fxgLotesValorizadosLog.AutoGenerateColumns = False
        fxgLotesValorizadosTmLog.AutoGenerateColumns = False

        ObtenerLotesValorizadosLog(fxgLotesValorizadosVaricion.Item(fxgLotesValorizadosVaricion.RowSel, "LoteVCM").ToString, fxgLotesValorizadosVaricion.Item(fxgLotesValorizadosVaricion.RowSel, "contratoloteId").ToString)

        'tpDetalleLog.sele
        tbLotesValorizados.SelectedTab = tpDetalleLog
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub

    Private Sub tsbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditar.Click
        Try
            If fxgLotesValorizadosVaricion.RowSel >= 0 Then

                Dim cdForm As New editlote
                ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
                cdForm.MdiParent = MdiParent
                cdForm.pstrCorrelativo = fxgLotesValorizadosVaricion.Rows(fxgLotesValorizadosVaricion.RowSel).Item("contratoLoteId")
                'cdForm.pstrAdministrador = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("Administrador")
                cdForm.Show()

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
End Class