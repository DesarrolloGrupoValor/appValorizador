Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion
Imports System.Configuration
Imports SI.PL.clsGeneral

Imports SI.PL
Imports Microsoft.Reporting.WinForms

Public Class Comercial_Composicion
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Public tipoReporte As String = ""
    Dim dvwRegistros As DataView

    Private Sub Comercial_Composicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try

            cboPeriodo2.Visible = False

            Select Case tipoReporte

                Case "Composicion_Mezcla"
                    lblTitulo.Text = "Composición de Mezclas"
                    Me.Text = "Composición de Mezclas"

                Case "Composicion_Venta"
                    lblTitulo.Text = "Composición de Vinculadas / Ventas"
                    Me.Text = "Composición de Vinculadas / Ventas"

                Case "Resumen_Comercial"
                    lblTitulo.Text = "Reporte: Resumen Comercial"
                    Me.Text = "Resumen Comercial"

                Case "Indicadores_Resumen"
                    lblTitulo.Text = "Reporte: Indicadores Resumen"
                    Me.Text = "Indicadores Resumen"

                    cboPeriodo2.Visible = True

                Case "Indicador_Comercial"
                    lblTitulo.Text = "Reporte: Indicadores"
                    Me.Text = "Indicador Comercial"

                Case "CN_Historial_Venta"
                    lblTitulo.Text = "Reporte: Historial Venta - Vinculadas"
                    Me.Text = "Historial Venta - Vinculadas"

                Case "CostoVentasSeg"
                    lblTitulo.Text = "Reporte: Resumen de Ventas Contable-Comercial"
                    Me.Text = "Resumen de Ventas Contable-Comercial"

                    cboPeriodo2.Visible = True
                    CbSabana.Visible = True

                Case "Entregas_x_Proveedor"

                    lblTitulo.Text = "Reporte: Entregas por Proveedor"
                    Me.Text = "Resumen Entregas por Proveedor"

                    cboPeriodo2.Visible = True
                    CbSabana.Visible = False
            End Select



            'ObtenerRegistros("", "")
            ObtenerPeriodos()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub ObtenerRegistros(ByVal periodo As String)
        Try
            Dim rpUsuario As New ReportParameter()
            rpUsuario.Name = "USUARIO"
            rpUsuario.Values.Add(pBEUsuario.descri)

            Dim parameters() As ReportParameter

            If tipoReporte = "Indicadores_Resumen" Then
                Dim rpPeriodo As New ReportParameter()
                rpPeriodo.Name = "PERIODO_ORIGEN"
                rpPeriodo.Values.Add(periodo)

                Dim rpPeriodo2 As New ReportParameter()
                rpPeriodo2.Name = "PERIODO_DESTINO"
                rpPeriodo2.Values.Add(cboPeriodo2.SelectedValue)

                'Set the report parameters for the report
                parameters = {rpUsuario, rpPeriodo, rpPeriodo2}
            ElseIf tipoReporte = "CostoVentasSeg" Or tipoReporte = "CostoVentaSegSab" Then
                Dim rpPeriodo As New ReportParameter()
                rpPeriodo.Name = "PERIODO"
                rpPeriodo.Values.Add(periodo)

                Dim rpPeriodo2 As New ReportParameter()
                rpPeriodo2.Name = "PERIODO_DESTINO"
                rpPeriodo2.Values.Add(cboPeriodo2.SelectedValue)

                If CbSabana.Checked Then
                    tipoReporte = "CostoVentaSegSab"
                Else
                    tipoReporte = "CostoVentasSeg"
                End If

                'Set the report parameters for the report
                parameters = {rpPeriodo, rpPeriodo2}
            ElseIf tipoReporte = "Entregas_x_Proveedor" Then
                Dim rpPeriodo As New ReportParameter()
                rpPeriodo.Name = "PERIODO"
                rpPeriodo.Values.Add(periodo)

                Dim rpPeriodo2 As New ReportParameter()
                rpPeriodo2.Name = "PERIODO_DESTINO"
                rpPeriodo2.Values.Add(cboPeriodo2.SelectedValue)

                'tipoReporte = "Entregas_x_ Proveedor"

                parameters = {rpPeriodo, rpPeriodo2}
            Else
                Dim rpPeriodo As New ReportParameter()
                rpPeriodo.Name = "PERIODO"
                rpPeriodo.Values.Add(periodo)

                'Set the report parameters for the report
                parameters = {rpUsuario, rpPeriodo}


            End If


            Dim oProcedimientos As New clsProcedimientos
            oProcedimientos.ConfigurationReporting(tipoReporte, rptReportViewer, parameters)

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

    'Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
    '    ObtenerRegistros("", "")
    'End Sub

    'Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
    '    If cboPeriodo.SelectedIndex > 0 Then
    '        ObtenerRegistros("", cboPeriodo.SelectedValue)
    '    End If
    'End Sub

    Private Sub ObtenerPeriodos()
        Try
            Dim dsPeriodo As DataSet
            Dim oBC_PeriodoRO As New clsBC_PeriodoRO
            dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

            cboPeriodo.DataSource = dsPeriodo.Tables(0)
            cboPeriodo.DisplayMember = "periodo"
            cboPeriodo.ValueMember = "periodoId"


            dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()
            cboPeriodo2.DataSource = dsPeriodo.Tables(0)
            cboPeriodo2.DisplayMember = "periodo"
            cboPeriodo2.ValueMember = "periodoId"

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbConsular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsular.Click
        Try
           If cboPeriodo.SelectedIndex > 0 Then
                If cboPeriodo.SelectedValue > cboPeriodo2.SelectedValue And cboPeriodo2.Visible Then
                    MsgBox("El periodo inicio debe ser menor al periodo de fin", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Else
                    ObtenerRegistros(cboPeriodo.SelectedValue)
                End If
            Else
                MsgBox("Debe seleccionar periodo", MsgBoxStyle.Critical, "Valorizador de Minerales")
            End If

            'MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub
End Class