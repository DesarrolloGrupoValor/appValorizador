'Modified:
'@01 20141016 BAL01 Se agrega opcion Eliminar asientos contables segun filtro (empresa, periodo y tipo de movimiento)
'@02 20141016 BAL01 Carga de datos para Verificacion vs CONCAR
'@03 20141030 BAL01 Solucion temporal, error en la carga de datos para el filtro
'@04 20141105 BAL01 Validacion, no se puede generar asiento contable si el periodo esta cerrado

Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion
Public Class frmcontabilidad

    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    '@02    A06
    Private EmpresaID As String
    Private EmpresaName As String
    Private Periodo As String
    Private PeriodoName As String
    Private TipoMovimiento As String
    Private TipoMovimientoName As String
    Private Clases As String


    Dim dvwRegistros As DataView
    Private _right As Object

    Private Property Right(p1 As String, p2 As Integer) As Object
        Get
            Return _right
        End Get
        Set(value As Object)
            _right = value
        End Set
    End Property

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub

    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"
    End Sub


    Private Sub frmcontabilidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboTipoContrato, "MovimientoCTB", SI.PL.clsEnumerado.enumPrimerValorCombo.Todos, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCheckcombo(Clbclases, clsUT_Dominio.domTABLA_DE_CLASES, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IDCodigoDescripcion)

        ObtenerPeriodos()

        fxgrdContabilidad.AllowFiltering = True
    End Sub
    Private Function ObtenerRegistros(ByVal empresa As String, ByVal periodo As String, ByVal clasesparm As String) As Boolean
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoTabla = empresa
            oContratoRO.oBEContratoLote.comentarios = cboPeriodo.SelectedValue  'Year(periodo) & IIf(Month(periodo).ToString.Length > 1, "", "0") & Month(periodo)
            oContratoRO.oBEContratoLote.codigoMovimiento = cboTipoContrato.SelectedValue  ' Year(periodo) & IIf(Month(periodo).ToString.Length > 1, "", "0") & Month(periodo)
            oContratoRO.oBEContratoLote.codigoClase = clasesparm

            dsregistros = oContratoRO.LeerListaToDSContabilidad
            'dvwContrato = New DataView(oContratoRO.LeerListaToDSContrato.Tables(0))

            If dsregistros.Tables.Count = 2 Then
                '@03    D04
                'fxgrdContabilidad.DataSource = Nothing
                'MsgBox("Período Contable ya fue declarado, No puede regenerar Asientos...", MsgBoxStyle.Critical, "Valorizador de Minerales")
                ''Exit Function
                'Return False
                '@03    A02
                dvwRegistros = New DataView(dsregistros.Tables(1))
                fxgrdContabilidad.DataSource = dvwRegistros
            Else
                dvwRegistros = New DataView(dsregistros.Tables(0))
                fxgrdContabilidad.DataSource = dvwRegistros
                Return True
            End If



            Return True
            'ColumnasID(fxgrdContrato)
            'ColumnasCodigo(fxgrdContrato)
            'blnCarga = True
            'fxgrdContrato_Click(Nothing, Nothing)
            'fxgrdContrato_SelChange(Nothing, Nothing)

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try

    End Function

  

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Try
            If Not Validar() Then Exit Sub

            Dim ClasesParam As String = ""
            '@02    A06
            Me.EmpresaID = cboEmpresa.SelectedValue
            Me.EmpresaName = cboEmpresa.Text
            Me.Periodo = cboPeriodo.SelectedValue
            Me.PeriodoName = cboPeriodo.Text
            Me.TipoMovimiento = cboTipoContrato.SelectedValue
            Me.TipoMovimientoName = cboTipoContrato.Text

            For idx As Integer = 0 To Me.Clbclases.CheckedItems.Count - 1
                ClasesParam = ClasesParam + CType(Clbclases.CheckedItems.Item(idx), clsBE_General).Codigo_Retorna
                If idx <> Me.Clbclases.CheckedItems.Count - 1 Then ClasesParam = ClasesParam + ","
            Next

            If Not ObtenerRegistros(cboEmpresa.SelectedValue, cboPeriodo.SelectedValue, ClasesParam) Then Exit Sub

            If Not dvwRegistros Is Nothing Then
                If dvwRegistros.Table.Rows.Count > 0 Then
                    tsbExportar.Enabled = True
                    tsbProcesar.Enabled = True
                Else
                    tsbExportar.Enabled = False
                    tsbProcesar.Enabled = False
                End If
            End If
            MsgBox("Proceso finalizo correctamente", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()

        End Try

    End Sub


    Private Function Validar(Optional ByVal sTipoValidacion As String = "")

        Dim strmensaje As String = ""
        Try

            If sTipoValidacion = "PERIODO" Then
                If cboPeriodo.SelectedIndex <= 0 Then
                    strmensaje = strmensaje & "* Seleccione Período" & vbCrLf
                End If
            Else
                If cboTipoContrato.SelectedIndex <= 0 Then
                    strmensaje = strmensaje & "* Seleccione Tipo Asiento" & vbCrLf
                End If

                If cboEmpresa.SelectedIndex <= 0 Then
                    strmensaje = strmensaje & "* Seleccione Empresa" & vbCrLf
                End If

                If cboPeriodo.SelectedIndex <= 0 Then
                    strmensaje = strmensaje & "* Seleccione Período" & vbCrLf
                End If
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

        If strmensaje.Length > 0 Then
            MsgBox(strmensaje, MsgBoxStyle.Critical, "Valorizador de Minerales")
            Return False
        End If
        Return True
    End Function

    Private Sub tsbExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportar.Click
        sfDialog.Filter = "Hojas de Excel|*.xls"
        sfDialog.ShowDialog()
        If sfDialog.FileName.Length > 0 Then
            fxgrdContabilidad.SaveExcel(sfDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If
    End Sub

    Private Sub tsbProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbProcesar.Click
        Dim oGeneralRO As New clsBC_GeneralRO
        Dim ClasesParam As String = ""
        Try
            '@04    AINI
            ' Verificar si datos mostrados corresponden al periodo filtrado (1)
            If Mid(fxgrdContabilidad.Rows(fxgrdContabilidad.RowSel).Item("DFECCOM").ToString, 1, 4) <> Mid(cboPeriodo.SelectedValue.ToString, 3, 4) Then
                MsgBox("Los registros no corresponden al periodo [" & cboPeriodo.Text _
                     & "]. Vuelva a procesar con el botón Previo ", MsgBoxStyle.OkOnly, "Valorizador de Minerales")

                Exit Sub
            End If
            ' Fin (1)

            ' Verificar si Periodo a Procesar está cerrado para cargar el Asiento (2)
            Dim p As New clsBC_PeriodoRO
            If Not p.ValidaPeriodoCerrado(cboEmpresa.SelectedValue, cboPeriodo.SelectedValue) Then
                MsgBox("No se puede generar los capturar los asientos porque el periodo [" & cboPeriodo.Text _
                       & "] no está cerrado.", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Exit Sub

            Else

                oGeneralRO.oBEGeneral.ValCampo1 = EmpresaID
                oGeneralRO.oBEGeneral.ValCampo2 = Periodo
                oGeneralRO.oBEGeneral.ValCampo3 = TipoMovimiento

                Dim ds As DataSet = oGeneralRO.Obtener_AsientosConcarDS

                If Not ds Is Nothing Then
                    If MsgBox("Existen asientos generados en el CONCAR. Desea eliminarlos y volver a cargar los Asientos ?", MsgBoxStyle.YesNo, "Valorizador de Minerales") = MsgBoxResult.No Then
                        Exit Sub
                    End If

                End If
            End If
            ' Fin (2)
            '@04    AFIN

            With oGeneralRO.oBEGeneral
                .ValCampo1 = cboEmpresa.SelectedValue
                .ValCampo2 = cboPeriodo.SelectedValue  'Year(dtPeriodo.Value) & IIf(Month(dtPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtPeriodo.Value)
                .ValCampo3 = cboTipoContrato.SelectedValue 'Year(dtPeriodo.Value) & IIf(Month(dtPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtPeriodo.Value)

                For idx As Integer = 0 To Me.Clbclases.CheckedItems.Count - 1
                    ClasesParam = ClasesParam + CType(Clbclases.CheckedItems.Item(idx), clsBE_General).Codigo_Retorna
                    If idx <> Me.Clbclases.CheckedItems.Count - 1 Then ClasesParam = ClasesParam + ","
                Next

                .ValCampo4 = ClasesParam
            End With

            If oGeneralRO.ProcesarContabilidad() Then
                MsgBox("Proceso finalizo correctamente", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
            Else
                MsgBox("Ocurrio Errores, verifica en CONCAR co Sistemas", MsgBoxStyle.Critical, "Valorizador de Minerales")
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub

    Private Sub tsbGenerarPreLiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarPreLiq.Click
        Try
            If Not Validar("PERIODO") Then Exit Sub

            Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO
            loclsBC_LiquidacionRO.fnPreliquidaciones(cboPeriodo.SelectedValue)
            loclsBC_LiquidacionRO.fnCalculaLote()
            MsgBox("Generación de Pre-Liquidaciones se finalizó correctamente", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub
    '@01    AINI
    Private Function VerificarFiltroCargaWithSeleccionActual() As Boolean
        Dim validacion As Boolean = True
        If Not cboEmpresa.SelectedValue = Me.EmpresaID Or _
                Not cboPeriodo.SelectedValue = Me.Periodo Or _
                Not cboTipoContrato.SelectedValue = Me.TipoMovimiento Then
            MsgBox("Los parametros con lo que cargo la data no corresponde con su seleccion actual. " _
                   & Chr(10) & "    Estos son:" _
                    & Chr(10) & "        Empresa: " & Me.EmpresaName _
                    & Chr(10) & "        Tipo de asiento: " & Me.TipoMovimientoName _
                    & Chr(10) & "        Periodo: " & Me.PeriodoName _
                   & Chr(10) & Chr(10) & "Considere cambiarlos o vuelva a filtrar.", MsgBoxStyle.Critical, "Valorizador de Minerales")
            validacion = False
        End If
        Return validacion
    End Function
    '@01    AFIN

    '@01    AINI
    Private Sub btnEliminarAsientoPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarAsientoPeriodo.Click
        If Validar(String.Empty) Then

            If Not VerificarFiltroCargaWithSeleccionActual() Then Exit Sub

            If MsgBox("¿Esta seguro de Eliminar los asientos para este periodo?", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                Dim oGeneralRO As New clsBC_GeneralRO
                Try
                    With oGeneralRO.oBEGeneral
                        .ValCampo1 = cboEmpresa.SelectedValue
                        .ValCampo2 = cboPeriodo.SelectedValue
                        .ValCampo3 = cboTipoContrato.SelectedValue
                    End With

                    If oGeneralRO.EliminarAsientoContableByFiltro() Then
                        MsgBox("Proceso de eliminacion correcto", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                    Else
                        MsgBox("Error inesperado, verifica en CONCAR y comuniquese con el area de Sistemas", MsgBoxStyle.Critical, "Valorizador de Minerales")
                    End If
                Catch ex As Exception
                    oMensajeError.txtMensaje.Text = ex.ToString()
                    oMensajeError.ShowDialog()
                End Try
            End If
        End If
    End Sub
    '@01    AFIN

    '@02    AINI
    Private Sub btnVerificarCONCAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificarCONCAR.Click
        If Validar(String.Empty) Then

            If Not VerificarFiltroCargaWithSeleccionActual() Then Exit Sub

            Dim frm As New frmVerificarVsConcar
            frm.empresaID = cboEmpresa.SelectedValue
            frm.periodo = cboPeriodo.SelectedValue
            frm.tipoMovimiento = cboTipoContrato.SelectedValue
            frm.Show()
        End If
    End Sub

    Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
        If cboPeriodo.SelectedIndex > 0 Then
            ' Se verifica que el año contable sea mayor a 2013
            If CInt(cboPeriodo.SelectedValue.ToString.Substring(0, 4)) < 2014 Then
                btnVerificarCONCAR.Enabled = False
            Else
                btnVerificarCONCAR.Enabled = True
            End If
        End If
    End Sub
    '@02    AFIN



    'Private Sub btnmatrizasiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmatrizasiento.Click
    '    If Validar(String.Empty) Then

    '        ' If Not VerificarFiltroCargaWithSeleccionActual() Then Exit Sub

    '        Dim frm As New FrmMatrizAsientos
    '        frm.pTipoFormulario = "MATRIZ_ASIENTOS"

    '        frm.empresaID = cboEmpresa.SelectedValue
    '        frm.periodo = cboPeriodo.SelectedValue.ToString.Substring(4, 2)
    '        frm.anio = cboPeriodo.SelectedValue.ToString.Substring(2, 2)
    '        frm.Show()
    '    End If
    'End Sub


    '1 cruce ventas
    Private Sub tsmValida2_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida2.Click
        Dim frm As New FrmMatrizAsientos

        frm.pTipoFormulario = "DIF_TMH_VENTAS"

        frm.empresaID = cboEmpresa.SelectedValue
        frm.periodo = cboPeriodo.SelectedValue
        frm.periodo_destino = cboPeriodo.SelectedValue

        frm.Show()
    End Sub

    '2 cuadre mezclas
    Private Sub tsmValida3_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida3.Click
        Dim frmMatrizMezcla As New MatrizMezcla
        'frmMatrizMezcla.MdiParent = MdiParent
        frmMatrizMezcla.pTipo_Extraccion = "B"
        frmMatrizMezcla.pEmpresa = cboEmpresa.SelectedValue
        frmMatrizMezcla.pPeriodo = cboPeriodo.SelectedValue
        frmMatrizMezcla.Show()
    End Sub

    '3 cruce saldos finales
    Private Sub tsmValida4_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida4.Click
        Dim frm As New frmValidarSaldoFinal
        'frm.MdiParent = MdiParent
        frm.sPeriodo = cboPeriodo.SelectedValue
        frm.Show()
    End Sub

    '4 mayorizacion de asientos
    Private Sub tsmValida5_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida5.Click
        If Validar(String.Empty) Then

            ' If Not VerificarFiltroCargaWithSeleccionActual() Then Exit Sub

            Dim frm As New FrmMatrizAsientos
            frm.pTipoFormulario = "MATRIZ_ASIENTOS"

            frm.empresaID = cboEmpresa.SelectedValue
            frm.periodo = cboPeriodo.SelectedValue.ToString.Substring(4, 2)
            frm.anio = cboPeriodo.SelectedValue.ToString.Substring(2, 2)
            frm.Show()
        End If
    End Sub

    Private Sub tsmValida1_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida1.Click
        Dim ofrmRumasPendientes As New frmRumasPendientes
        ofrmRumasPendientes.MdiParent = Me
        ofrmRumasPendientes.Show()
    End Sub

End Class