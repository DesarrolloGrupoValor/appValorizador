Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class ReporteReparticionUtilidad
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    'Public pTipo As String

    Dim dvwRegistros As DataView

    Public pEmpresa As String = ""
    Public pPeriodo As String = ""

    Private Sub ReporteReparticionUtilidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.WindowState = FormWindowState.Maximized
            'fxgrdComprasVentas.AutoGenerateColumns = False

            ObtenerPeriodos()
            Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosCombo(cboProducto, clsUT_Dominio.domTABLA_DE_PRODUCTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            If pEmpresa <> "" Then
                cboEmpresa.SelectedValue = pEmpresa
            End If

            If pPeriodo <> "" Then
                cboPeriodo.SelectedValue = pPeriodo
            End If


            'If pTipo = "Compraventa" Then
            '    Lbltitulo.Text = "Reporte : Compra con asignación de Venta"
            '    Me.Text = "Reporte Compras con asignación Ventas"
            'ElseIf pTipo = "ReparticionRentabilidad" Then
            '    Lbltitulo.Text = "Reporte : Distribución de Utilidad"
            '    Me.Text = "Reporte Distribución de Utilidad"
            'End If


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try



    End Sub

    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"
    End Sub


    Private Sub ObtenerRegistros()
        Try
            Dim dsregistros As New DataSet
            Dim oReporteCompraVentaRO As New clsBC_ReporteCompraVentaRO

            'oReporteCompraVentaRO.oBEReporteCompraVenta = New clsBE_ReporteCompraVenta
            oReporteCompraVentaRO.oBEReporteCompraVenta.empresa = cboEmpresa.SelectedValue  'cboEmpresa.SelectedValue
            oReporteCompraVentaRO.oBEReporteCompraVenta.periodo = cboPeriodo.SelectedValue  'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)
            'oReporteCompraVentaRO.oBEReporteCompraVenta.producto = cboProducto.SelectedValue

            dsregistros = oReporteCompraVentaRO.LeerListaToDSRepaticionRentabilidad

            'If pTipo = "Compraventa" Then
            '    dsregistros = oReporteCompraVentaRO.LeerListaToDSCompra_asignacion_Venta
            'ElseIf pTipo = "ReparticionRentabilidad" Then
            '    dsregistros = oReporteCompraVentaRO.LeerListaToDSRepaticionRentabilidad

            '    For i = 0 To fxgrdComprasVentas.Cols.Count - 1
            '        fxgrdComprasVentas.Cols.Remove(i)
            '    Next

            '    fxgrdComprasVentas.AutoGenerateColumns = True
            'End If


            dvwRegistros = New DataView(dsregistros.Tables(0))
            'fxgrdComprasVentas.AutoGenerateColumns = True
            fxgrdComprasVentas.DataSource = dvwRegistros

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbExportarExcel.Click
        SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName.Length > 0 Then
            'fxgrdExtraccionVCM.SaveExcel(SaveFileDialog1.FileName,, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            fxgrdComprasVentas.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If

        Dim exeName As String = "explorer.exe"
        Dim params As String = SaveFileDialog1.FileName
        Dim processInfo As New ProcessStartInfo(exeName, params)
        Process.Start(processInfo)

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub

    Private Sub tsbConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbConsultar.Click

        Try
            'If cboEmpresa.SelectedIndex < 1 Then
            '    MsgBox("Debe seleccionar empresa", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
            '    Return
            'End If

            If cboPeriodo.SelectedIndex < 1 Then
                MsgBox("Debe seleccionar periodo", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                Return
            End If

            'If cboProducto.SelectedIndex < 1 Then
            '    MsgBox("Debe seleccionar producto", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
            '    Return
            'End If

            ObtenerRegistros()
            'MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


    Private Sub tsbProcesar_Click(sender As System.Object, e As System.EventArgs)
        Try
            Dim dsregistros As New DataSet
            Dim oReporteCompraVentaRO As New clsBC_ReporteCompraVentaRO

            'oReporteCompraVentaRO.oBEReporteCompraVenta = New clsBE_ReporteCompraVenta
            oReporteCompraVentaRO.oBEReporteCompraVenta.periodo = cboPeriodo.SelectedValue
            oReporteCompraVentaRO.ProcesaComprasVentas()

            ObtenerRegistros()
            MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.Information, "Valorizador Comercial de Minerales")

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

End Class