Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion
Imports SI.PL.clsGeneral

Imports SI.PL

Imports System.Configuration
Imports Microsoft.Reporting.WinForms

Public Class GenerarQPs
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    Private Sub GenerarQPs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.Dock = DockStyle.Fill
        Me.WindowState = FormWindowState.Maximized


        'ObtenerRegistros("", "")
        ObtenerPeriodos()
        'Me.rptReportViewer.RefreshReport()
        'Me.rptReportViewer.RefreshReport()

        Obtener_GenerarQP()
    End Sub

    Private Sub Obtener_GenerarQP()
        Try
            Dim dsregistros As DataSet
            Dim oBC_GenerarQPRO As New clsBC_GenerarQPRO

            dsregistros = oBC_GenerarQPRO.fnGenerarQP_SellAll() '(cboPeriodo.SelectedValue)
            'dvwRegistros = New DataView(dsregistros.Tables(0))
            fgxGenerarQP.DataSource = dsregistros.Tables(0) ' dvwRegistros

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            
           
            ''dsregistros = oBC_GenerarQPRO.fnCalcular_QPs(cboPeriodo.SelectedValue)
            ' ''dvwRegistros = New DataView(dsregistros.Tables(0))
            ''fgxGenerarQP_N.DataSource = dsregistros.Tables(0)

            ''dsregistros = oBC_GenerarQPRO.fnCalcular_QPs_Detalle(cboPeriodo.SelectedValue)
            ''dvwRegistros = New DataView(dsregistros.Tables(0))
            ''fgxGenerarQPDetalleN.DataSource = dvwRegistros 'dsregistros.Tables(0)

            Dim oBC_GenerarQPTX As New clsBC_GenerarQPTX
            oBC_GenerarQPTX.fnCalcular_QPs(cboPeriodo.SelectedValue)

            Dim dsregistros As DataSet
            Dim oBC_GenerarQPRO As New clsBC_GenerarQPRO
            dsregistros = oBC_GenerarQPRO.fnGenerarQP_SellAll(cboPeriodo.SelectedValue)
            'dvwRegistros = New DataView(dsregistros.Tables(0))
            fgxGenerarQP_N.DataSource = dsregistros.Tables(0)

            dsregistros = oBC_GenerarQPRO.fnGenerarQP_Detalle_Sell(cboPeriodo.SelectedValue, "")
            dvwRegistros = New DataView(dsregistros.Tables(0))
            fgxGenerarQPDetalleN.DataSource = dvwRegistros 'dsregistros.Tables(0)


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub



    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalirGenerar.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub


    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ObtenerRegistros("", "")
    End Sub


    Private Sub ObtenerPeriodos()
        Try
            Dim dsPeriodo As DataSet
            Dim oBC_PeriodoRO As New clsBC_PeriodoRO
            dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

            cboPeriodo.DataSource = dsPeriodo.Tables(0)
            cboPeriodo.DisplayMember = "periodo"
            cboPeriodo.ValueMember = "periodoId"
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerar.Click
        tcControl.SelectedTab = tpGenerar
        If cboPeriodo.SelectedIndex > 0 Then
            ObtenerRegistros("", cboPeriodo.SelectedValue)
        Else
            MsgBox("Debe seleleccionar período", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
        End If
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Obtener_GenerarQP()
    End Sub

    Private Sub fgxGenerarQP_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgxGenerarQP.DoubleClick, fgxGenerarQP.SelChange
        Try
            If fgxGenerarQP.RowSel > -1 Then
                Dim sPeriodo As String
                Dim sVinculada As String
                sPeriodo = fgxGenerarQP.Rows(fgxGenerarQP.RowSel).Item("periodo")
                sVinculada = fgxGenerarQP.Rows(fgxGenerarQP.RowSel).Item("vinculada")
                Obtener_GenerarQPDetalle(sPeriodo, sVinculada)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub Obtener_GenerarQPDetalle(ByVal sPeriodo As String, ByVal sVinculada As String)
        Try
            Dim dsregistros As DataSet
            Dim oBC_GenerarQPRO As New clsBC_GenerarQPRO

            dsregistros = oBC_GenerarQPRO.fnGenerarQP_Detalle_Sell(sPeriodo, sVinculada)
            fgxGenerarQPDetalle.DataSource = dsregistros.Tables(0)

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub fgxGenerarQP_N_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgxGenerarQP_N.DoubleClick, fgxGenerarQP_N.SelChange
        Try
            If fgxGenerarQP_N.RowSel > -1 And dvwRegistros IsNot Nothing Then
                Dim strFiltro As String = fgxGenerarQP_N.Rows(fgxGenerarQP_N.RowSel).Item("vinculada")
                strFiltro = "loteVinculada='" & strFiltro.Substring(0, 2) & strFiltro.Substring(3, 2) & "'"
                dvwRegistros.RowFilter = strFiltro
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    'Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim oBC_GenerarQPTX As New clsBC_GenerarQPTX
    '    oBC_GenerarQPTX.InsertarGenerarQP(cboPeriodo.SelectedValue)

    '    MsgBox("Se guardo satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
    '    tcControl.SelectedTab = tpLista

    '    tsbRefrescar_Click(sender, e)

    'End Sub

    Private Sub tcControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcControl.SelectedIndexChanged
        tsbRefrescar_Click(sender, e)
        cboPeriodo.SelectedIndex = 0

    End Sub

    Private Sub tsbExportarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarDetalle.Click
        Try
            SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
            SaveFileDialog1.FileName = "QP_Detalle"
            SaveFileDialog1.ShowDialog()

            If SaveFileDialog1.FileName.Length > 0 Then
                If cboPeriodo.SelectedIndex = 0 Then
                    fgxGenerarQPDetalle.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
                Else
                    fgxGenerarQPDetalleN.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click
        Try
            SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
            SaveFileDialog1.FileName = "QP_Lotes"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName.Length > 0 Then
                fgxGenerarQP.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
End Class