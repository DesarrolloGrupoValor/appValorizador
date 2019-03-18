Imports SI.BC

Public Class frmLotesValorizadosLog

    Private Sub frmLotesValorizadosLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        fxgLotesValorizadosLog.AutoGenerateColumns = False
        fxgLotesValorizadosTmLog.AutoGenerateColumns = False

        ObtenerLotesValorizadosLog()
    End Sub


    Private Sub ObtenerLotesValorizadosLog()
        Dim oLotesValorizadosLog As New clsBC_LotesValorizadosLogRO
        Dim dsLotesValorizadosLog As DataSet
        dsLotesValorizadosLog = oLotesValorizadosLog.LeerListaToDSLotesValorizadosLog()

        fxgLotesValorizadosLog.AutoGenerateColumns = False
        fxgLotesValorizadosTmLog.AutoGenerateColumns = False

        fxgLotesValorizadosLog.DataSource = dsLotesValorizadosLog.Tables(0)
        fxgLotesValorizadosLog.FilterDefinition = "<ColumnFilters />"

        ObtenerLotesValorizadosTMLog("", "", 0)

    End Sub

    Private Sub ObtenerLotesValorizadosTMLog(ByVal sContratoLoteId As String, ByVal sLiquidacion As String, ByVal nLotesValorizadosLogID As Integer)
        Dim oLotesValorizadosTMLog As New clsBC_LotesValorizadosTMLogRO
        Dim dsLotesValorizadosTMLog As DataSet
        dsLotesValorizadosTMLog = oLotesValorizadosTMLog.LeerListaToDSLotesValorizadosTMLog(sContratoLoteId, sLiquidacion, nLotesValorizadosLogID)

        fxgLotesValorizadosTmLog.DataSource = dsLotesValorizadosTMLog.Tables(0)

    End Sub

    Private Sub fxgLotesValorizados_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgLotesValorizadosLog.SelChange, fxgLotesValorizadosTmLog.SelChange
        If fxgLotesValorizadosLog.RowSel > 0 And fxgLotesValorizadosLog.Cols.Count > 2 Then
            ObtenerLotesValorizadosTMLog(fxgLotesValorizadosLog.Item(fxgLotesValorizadosLog.RowSel, "contratoLoteId").ToString, fxgLotesValorizadosLog.Item(fxgLotesValorizadosLog.RowSel, "liquidacionId").ToString, fxgLotesValorizadosLog.Item(fxgLotesValorizadosLog.RowSel, "LotesValorizadosLogID").ToString)
        End If
    End Sub


    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        ObtenerLotesValorizadosLog()
    End Sub

    Private Sub frmLotesValorizadosLog_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ObtenerLotesValorizadosLog()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub
End Class