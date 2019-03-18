Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion
Imports System.Configuration
Imports SI.PL.clsGeneral

Imports SI.PL
Imports Microsoft.Reporting.WinForms


Imports System
Imports System.IO
Imports System.Text

Public Class EstadisticaVenta
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    Private Sub Comercial_Composicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            ObtenerPeriodos()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub

    Private Sub ObtenerPeriodos()
        Try
            Dim dsAnio As DataSet
            Dim dsMes As DataSet
            Dim oBC_TablaDetRO As New clsBC_TablaDetRO

            dsAnio = oBC_TablaDetRO.LeerListaToDSAnio()
            cboAnioInicio.DataSource = dsAnio.Tables(0)
            cboAnioInicio.DisplayMember = "descripcion"
            cboAnioInicio.ValueMember = "codigo"
            cboAnioInicio.SelectedValue = 2013

            dsAnio = oBC_TablaDetRO.LeerListaToDSAnio()
            cboAnioFin.DataSource = dsAnio.Tables(0)
            cboAnioFin.DisplayMember = "descripcion"
            cboAnioFin.ValueMember = "codigo"

            dsAnio = oBC_TablaDetRO.LeerListaToDSAnio()
            cboAnio.DataSource = dsAnio.Tables(0)
            cboAnio.DisplayMember = "descripcion"
            cboAnio.ValueMember = "codigo"



            dsMes = oBC_TablaDetRO.LeerListaToDSMes()
            cboMesInicio1.DataSource = dsMes.Tables(0)
            cboMesInicio1.DisplayMember = "descripcion"
            cboMesInicio1.ValueMember = "codigo"
            cboMesInicio1.SelectedValue = "01"

            dsMes = oBC_TablaDetRO.LeerListaToDSMes()
            cboMesInicio2.DataSource = dsMes.Tables(0)
            cboMesInicio2.DisplayMember = "descripcion"
            cboMesInicio2.ValueMember = "codigo"
            cboMesInicio2.SelectedValue = "01"

            dsMes = oBC_TablaDetRO.LeerListaToDSMes()
            cboMesFin1.DataSource = dsMes.Tables(0)
            cboMesFin1.DisplayMember = "descripcion"
            cboMesFin1.ValueMember = "codigo"
            cboMesFin1.SelectedValue = "12"

            dsMes = oBC_TablaDetRO.LeerListaToDSMes()
            cboMesFin2.DataSource = dsMes.Tables(0)
            cboMesFin2.DisplayMember = "descripcion"
            cboMesFin2.ValueMember = "codigo"
            cboMesFin2.SelectedValue = "12"


            dsAnio = oBC_TablaDetRO.LeerListaToDSAnio()
            cboAnioOrigen.DataSource = dsAnio.Tables(0)
            cboAnioOrigen.DisplayMember = "descripcion"
            cboAnioOrigen.ValueMember = "codigo"

            dsAnio = oBC_TablaDetRO.LeerListaToDSAnio()
            cboAnioDestino.DataSource = dsAnio.Tables(0)
            cboAnioDestino.DisplayMember = "descripcion"
            cboAnioDestino.ValueMember = "codigo"

            dsMes = oBC_TablaDetRO.LeerListaToDSMes()
            cboMesOrigen.DataSource = dsMes.Tables(0)
            cboMesOrigen.DisplayMember = "descripcion"
            cboMesOrigen.ValueMember = "codigo"
            'cboMesOrigen.SelectedValue = "12"

            dsMes = oBC_TablaDetRO.LeerListaToDSMes()
            cboMesDestino.DataSource = dsMes.Tables(0)
            cboMesDestino.DisplayMember = "descripcion"
            cboMesDestino.ValueMember = "codigo"
            'cboMesDestino.SelectedValue = "12"

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub btnComparativo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComparativo.Click
        Try
            If Not cboAnioInicio.SelectedIndex > -1 Then
                MsgBox("Debe seleccionar año de inicio", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            If Not cboAnioFin.SelectedIndex > -1 Then
                MsgBox("Debe seleccionar año de fin", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            If Not cboAnioInicio.SelectedIndex > cboAnioFin.SelectedIndex Then
                MsgBox("Año de inicio debe ser menor a año de fin", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            If Not cboMesInicio1.SelectedIndex > 0 Then
                MsgBox("Debe seleccionar mes de inicio", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            If Not cboMesFin1.SelectedIndex > 0 Then
                MsgBox("Debe seleccionar mes de fin", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            If cboMesInicio1.SelectedIndex > cboMesFin1.SelectedIndex Then
                MsgBox("Mes de inicio debe ser menor a mes de fin", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            ObtenerRegistros("Ventas_entre_Anios")

            'MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub btnXanio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXanio.Click
        Try
            If Not cboAnio.SelectedIndex > -1 Then
                MsgBox("Debe seleccionar año", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            If Not cboMesInicio2.SelectedIndex > 0 Then
                MsgBox("Debe seleccionar mes de inicio", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            If Not cboMesFin2.SelectedIndex > 0 Then
                MsgBox("Debe seleccionar mes de fin", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            If cboMesInicio2.SelectedIndex > cboMesFin2.SelectedIndex Then
                MsgBox("Mes de inicio debe ser menor a mes de fin", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Exit Sub
            End If

            ObtenerRegistros("Ventas_x_Anio")

            'MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ObtenerRegistros(ByVal tipoReporte As String)
        Try
            Dim rpUsuario As New ReportParameter()
            rpUsuario.Name = "USUARIO"
            rpUsuario.Values.Add(pBEUsuario.descri)

            Dim parameters() As ReportParameter

            If tipoReporte = "Ventas_entre_Anios" Then
                Dim rpPeriodo As New ReportParameter()
                rpPeriodo.Name = "PERIODO_ORIGEN"
                rpPeriodo.Values.Add(cboAnioInicio.SelectedValue)

                Dim rpPeriodo2 As New ReportParameter()
                rpPeriodo2.Name = "PERIODO_DESTINO"
                rpPeriodo2.Values.Add(cboAnioFin.SelectedValue)

                Dim rpMesInicio As New ReportParameter()
                rpMesInicio.Name = "MES_INICIO"
                rpMesInicio.Values.Add(cboMesInicio1.SelectedValue)

                Dim rpMesFin As New ReportParameter()
                rpMesFin.Name = "MES_FIN"
                rpMesFin.Values.Add(cboMesFin1.SelectedValue)

                Dim rpMesInicioNombre As New ReportParameter()
                rpMesInicioNombre.Name = "MES_INICIO_NOMBRE"
                rpMesInicioNombre.Values.Add(cboMesInicio1.Text)

                Dim rpMesFinNombre As New ReportParameter()
                rpMesFinNombre.Name = "MES_FIN_NOMBRE"
                rpMesFinNombre.Values.Add(cboMesFin1.Text)

                Dim rpTMH As New ReportParameter()
                rpTMH.Name = "tmh"
                rpTMH.Values.Add(IIf(rbTMH.Checked, 1, 0))

                'Set the report parameters for the report
                parameters = {rpUsuario, rpPeriodo, rpPeriodo2, rpMesInicio, rpMesFin, rpMesInicioNombre, rpMesFinNombre, rpTMH}

            ElseIf tipoReporte = "Ventas_x_Anio" Then
                Dim rpPeriodo As New ReportParameter()
                rpPeriodo.Name = "PERIODO"
                rpPeriodo.Values.Add(cboAnio.SelectedValue)

                Dim rpMesInicio As New ReportParameter()
                rpMesInicio.Name = "MES_INICIO"
                rpMesInicio.Values.Add(cboMesInicio2.SelectedValue)

                Dim rpMesFin As New ReportParameter()
                rpMesFin.Name = "MES_FIN"
                rpMesFin.Values.Add(cboMesFin2.SelectedValue)

                Dim rpMesInicioNombre As New ReportParameter()
                rpMesInicioNombre.Name = "MES_INICIO_NOMBRE"
                rpMesInicioNombre.Values.Add(cboMesInicio2.Text)

                Dim rpMesFinNombre As New ReportParameter()
                rpMesFinNombre.Name = "MES_FIN_NOMBRE"
                rpMesFinNombre.Values.Add(cboMesFin2.Text)

                Dim rpTMH As New ReportParameter()
                rpTMH.Name = "tmh"
                rpTMH.Values.Add(IIf(rbTMH.Checked, 1, 0))

                'Set the report parameters for the report
                parameters = {rpUsuario, rpPeriodo, rpMesInicio, rpMesFin, rpMesInicioNombre, rpMesFinNombre, rpTMH}
            End If


            Dim oProcedimientos As New clsProcedimientos
            oProcedimientos.ConfigurationReporting(tipoReporte, rptReportViewer, parameters)

            rptReportViewer.ZoomMode = ZoomMode.Percent
            rptReportViewer.ZoomPercent = 100

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click

        Try
            Dim oclsBC_ReporteCompraVentaRO As New clsBC_ReporteCompraVentaRO
            'Dim nAnio_Origen, nAnio_Destino, nMes_Origen, nMes_Destino As Integer

            'nAnio_Origen = IIf(cboAnioOrigen.SelectedValue Is Nothing, 0, cboAnioOrigen.SelectedValue)
            'nAnio_Destino = IIf(cboAnioDestino.SelectedValue Is Nothing, 0, cboAnioDestino.SelectedValue)
            'nMes_Origen = IIf(cboMesOrigen.SelectedValue Is Nothing, 0, cboMesOrigen.SelectedValue)
            'nMes_Destino = IIf(cboMesDestino.SelectedValue Is Nothing, 0, cboMesDestino.SelectedValue)


            'oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.nAnio_Origen = nAnio_Origen
            'oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.nAnio_Destino = nAnio_Destino
            'oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.nMes_Origen = nMes_Origen
            'oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.nMes_Destino = nMes_Destino

            oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.periodo = ""

            'proceso el costo de venta de todos los tiempos
            oclsBC_ReporteCompraVentaRO.ProcesaComprasVentas()

            'oclsBC_ReporteCompraVentaRO.fnCalculaComparacionVentas()
            MsgBox("Finalización satisfactoria de la obtención de la información.", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try


    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        'Dim x As String = "C:\DATA - LMiyahira\05_Casos\05_ReporteResumen\rvreportescomercialescontables\documento.docx"
        'FileInUse(x)

        Try

            Dim oclsBC_ReporteCompraVentaRO As New clsBC_ReporteCompraVentaRO
            Dim nAnio_Origen, nAnio_Destino, nMes_Origen, nMes_Destino As Integer

            nAnio_Origen = IIf(cboAnioOrigen.SelectedValue Is Nothing, 0, cboAnioOrigen.SelectedValue)
            nAnio_Destino = IIf(cboAnioDestino.SelectedValue Is Nothing, 0, cboAnioDestino.SelectedValue)
            nMes_Origen = IIf(cboMesOrigen.SelectedValue Is Nothing, 0, cboMesOrigen.SelectedValue)
            nMes_Destino = IIf(cboMesDestino.SelectedValue Is Nothing, 0, cboMesDestino.SelectedValue)


            oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.nAnio_Origen = nAnio_Origen
            oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.nAnio_Destino = nAnio_Destino
            oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.nMes_Origen = nMes_Origen
            oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.nMes_Destino = nMes_Destino

            'oclsBC_ReporteCompraVentaRO.oBEReporteCompraVenta.periodo = ""

            'proceso el costo de venta de todos los tiempos
            'oclsBC_ReporteCompraVentaRO.ProcesaComprasVentas()

            oclsBC_ReporteCompraVentaRO.fnCalculaComparacionVentas()



            Dim path As String = System.Windows.Forms.Application.StartupPath + "\ReportesVentasVCM.xlsx"
            'path = "C:\Users\lmiyahira\Desktop\Debug\ReportesVentasVCM.xlsx"

            System.IO.File.OpenRead(path)

            If System.IO.File.Exists(path) = True Then
                Process.Start(path)
            Else
                MsgBox("File Does Not Exist")
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Public Function FileInUse(ByVal sFile As String) As Boolean
        Dim thisFileInUse As Boolean = False
        If System.IO.File.Exists(sFile) Then
            Try
                Using f As New IO.FileStream(sFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None)
                    ' thisFileInUse = False
                End Using
            Catch
                thisFileInUse = True
            End Try
        End If


        Try
            File.OpenRead(sFile)

            'File.Delete(sFile)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try



        If File.Exists("C:\DATA - LMiyahira\05_Casos\05_ReporteResumen\rvreportescomercialescontables\~$documento.docx") Then
            MsgBox("File is open")

        End If

        Return thisFileInUse
    End Function


End Class