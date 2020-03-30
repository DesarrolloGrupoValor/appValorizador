'Modified:
'@01 20141006 BAL01 Se agregan campos, validacion y calculos para PP
'@02 20141010 BAL01 Validacion para la des-asociacion de rumas
'@03 20141015 BAL01 Validacion, no se puede eliminar liquidacion cuyo periodo
' este cerrado
'@04 20141016 BAL01 Validacion, no se puede eliminar liquidacion cuyo asiento contable haya sido generado
'@05 20141022 BAL01 Validacion, no se permite editar el periodo en caso este cerrado
'@06 20141022 BAL01 Validacion, no se permite editar el periodo (no cerrado) por otro cerrado
'@07 20141105 BAL01 Se quita validacion @04 segun requerimiento CTB JS

Imports SI.PL.clsFuncion
Imports SI.PL.clsGeneral
Imports SI.PL.clsProcedimientos
Imports SI.UT
Imports SI.BC
Imports System.Data
Imports System.Drawing.Drawing2D
Imports SI.BE
Imports SI.UT.clsUT_Enumerado
Imports System.Configuration

Imports Microsoft.Reporting.WinForms

Public Class editlote
#Region "Variables Publicas"
    Public pblnNuevo As Boolean
    Public pblnCopia As Boolean
    Public pblnLoteContrato As Boolean
    Public pstrCorrelativo As String
    Public pstrCorrelativoLiquidacion As String
    Public pstrCorrelativoLiquidacionTM As String
    Public pstrCorrelativoLiquidacionDscto As String
    Public pstrCorrelativoLiquidacionServicio As String
    Public pstrAdministrador As String
    Public pblnDesdeContrato As Boolean
    Public MesActual As String
    Public AnioActual As String

    Public pEstadoLiquidacion As String


    Public pAccionFormulario As String


    Public pDireccion As Boolean = True

    Public pParametros As New Hashtable

    'Item de interface de adelantos
    Public nItem As Integer = 0
#End Region
#Region "Variables Privadas"
    Private lblneditandoPagable As Boolean
    Private lblneditandoPenalizable As Boolean
    Private drowPenalizable As DataRow
    Private dtPenalizable As DataTable
    Private dtTablaDet As DataTable
    Private dsPenalizable As New DataSet
    Private dvwPenalizable As DataView
    Private drowPagable As DataRow
    Private dtPagable As DataTable
    Private dsPagable As New DataSet
    Private dvwPagable As DataView
    Private dsServicio As New DataSet
    Private dvwServicio As DataView
    Private dvwLiquidacion As DataView
    Private dsAjuste As New DataSet
    Private dvwAjuste As DataView
    Private dvwAdelantoFactura As DataView

    Private oContratoLoteRO As New clsBC_ContratoLoteRO
    Private oContratoLoteTX As New clsBC_ContratoLoteTX
    Private oValorizadorPenalizableRO As New clsBC_ValorizadorPenalizableRO
    Private oValorizadorPagableRO As New clsBC_ValorizadorPagableRO
    Private oLiquidacionRO As New clsBC_LiquidacionRO
    Private oLiquidacionTX As New clsBC_LiquidacionTX
    Private dtLiquidacion As DataTable
    Private oPenalizableTX As New clsBC_ValorizadorPenalizableTX
    Private oPagableTX As New clsBC_ValorizadorPagableTX
    Private oMovimientoTX As New clsBC_LogisticaMovimientoTX
    Private dtAjuste As DataTable
    Private dtAdelantoFactura As DataTable
    Private drowAjuste As DataRow
    Private dtServicio As DataTable
    Private drowServicio As DataRow
    Private oLiquidacionServicioRO As New clsBC_LiquidacionServicioRO
    Private oLiquidacionTotalRO As New clsBC_LiquidacionTotalRO
    Private oLiquidacionDsctoRO As New clsBC_LiquidacionDsctoRO
    Private oLiquidacionServicioTX As New clsBC_LiquidacionServicioTX
    Private oLiquidacionDsctoTX As New clsBC_LiquidacionDsctoTX
    Private oLiquidacionTMTX As New clsBC_LiquidacionTmTX
    Private oLiquidacionTMRO As New clsBC_LiquidacionTmRO
    Private oTableDet As New clsBC_TablaDetRO
    'Private ioclsDB_LogisticaMovimientoTX As New clsBC_LogisticaMovimientoTX

    Private dtLiquidacionTM As DataTable
    Private dvwLiquidacionTM As DataView


    Private dtLiquidacionTMTotal As DataTable
    Private dvwLiquidacionTMTotal As DataView


    Dim oLogisticaMovimientoRO As New clsBC_LogisticaMovimientoRO
    Dim dvwLogisticaMovimiento As DataView
    'Calculos
    Dim dblPrecio As Double = 8700
    Dim dblPrecioEsc As Double = 8700
    Dim dblDeducRc As Double = 0

    'Private dblRedondedo As Double = 0.00005
    Private dblRedondedo As Double = 0

    'control de errores
    Private oMensajeError As mensajeError = New mensajeError


    Private bVisibleButtonsRumas = True

    Private pRucEmpresa As String


    Private sLOTE_CERRADO As String



#End Region
#Region "Eventos Formulario "


    Private Sub ValidarTipoMovimiento()
        Try

            btnVenta.Visible = False
            'btnVenta.Visible = True

            If cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.MEZCLA.Value Then
                'txtNumeroLote.Text = Month(Now()) & "-" & oGeneral.LstGeneral.Item(0).NomCampo4
                cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                cboClase.Enabled = False
                cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad
                btnCalidad.Enabled = False
                'cboTrader.SelectedValue = oContratoLoteRO.oBEContratoLote.codigo
                cboIncoterm.Enabled = False
                cboDeposito.Enabled = False
                lblmaquila.Visible = False
                txtMaquila.Visible = False
                CuGroupBox1.Visible = False
                gpopenalizable.Visible = False

                CuGroupBox4.Visible = False

                Label25.Visible = False
                Label26.Visible = False
                Label9.Visible = False
                Label19.Visible = False
                Label51.Visible = False

                Label3.Visible = False
                Label8.Visible = False
                Label16.Visible = False
                Label33.Visible = False
                Label17.Visible = False
                Label18.Visible = False
                Detraccion.Visible = False
                provisional.Visible = False

                ctxtTotalServicios.Visible = False
                txtTotalTMSN.Visible = False
                txtAjuste.Visible = False
                txtPUnitario.Visible = False
                txtPorImpuesto.Visible = False

                txtValor.Visible = False
                txtImpuesto.Visible = False
                txtTotal.Visible = False
                txtAdelanto.Visible = False
                txtProvisional.Visible = False
                txtDetraccion.Visible = False
                txtDescuentos.Visible = False
                txtNetoAPagar.Visible = False

                Label6.Visible = True
                txtValorMezcla.Visible = True
                txtValorMezcla.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.valorVenta, 2)

                Label29.Visible = True
                txtCalculoPrecioUnitario.Visible = True
                txtCalculoPrecioUnitario.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.calculoPrecioUnitario, 2)

                Label52.Visible = True
                Label53.Visible = True
                Label54.Visible = True

                txtCalculoTmh.Visible = True
                txtCalculoTmh.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.calculoTmh, 3)

                txtCalculoTms.Visible = True
                txtCalculoTms.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.calculoTms, 3)

                txtCalculoTmsn.Visible = True
                txtCalculoTmsn.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.calculoTMSN, 3)

                lblperiodo.Visible = True
                dtPeriodo.Visible = True
                dtPeriodo.Enabled = True

                'Dim strCadena As String = "Elem,Ley,Contenido,Precio,LeyCambUnid"
                Dim strCadena As String = "Elem,Contenido,Precio,LeyCambUnid"
                For Each sCol As DataGridViewColumn In dgvPagables.Columns

                    If InStr(strCadena, sCol.Name, CompareMethod.Text) > 0 And (sCol.Name <> "Ley") Then
                        sCol.Visible = True

                        If sCol.HeaderText = "Precio" Then
                            sCol.ReadOnly = True
                            'sCol.DataGridView.Enabled = False
                            sCol.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(204, 204, 204)
                        End If
                    Else
                        sCol.Visible = False
                    End If
                Next


            ElseIf cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VINCULADA.Value Then
                lblperiodo.Visible = True
                dtPeriodo.Visible = True

                btnVenta.Visible = True
                txtNumeroLote.Enabled = False

                If dgvLiquidacionTM.RowCount > 0 Then
                    btnVenta.Enabled = False
                End If

            ElseIf cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VENTA.Value Then
                lblperiodo.Visible = True
                dtPeriodo.Visible = True

            ElseIf cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.COMPRA.Value Then
                lblperiodo.Visible = True
                dtPeriodo.Visible = True
                dtPeriodo.Enabled = False
            Else

                ' txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo4
                cboClase.Enabled = True
                btnCalidad.Enabled = True
                cboIncoterm.Enabled = False
                cboDeposito.Enabled = False
                lblmaquila.Visible = True
                txtMaquila.Visible = True
                CuGroupBox1.Visible = True
                gpopenalizable.Visible = True
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub NombrarEtiquetas()
        Select Case cboTipo.SelectedValue
            Case "P", "B"
                lblempresa.Text = "Comprador"
                lblproveedor.Text = "Vendedor"
            Case "V", "S"
                lblempresa.Text = "Vendedor"
                lblproveedor.Text = "Comprador"
            Case Else
                lblempresa.Text = "Empresa"
                lblproveedor.Text = "Cliente/Proveedor"
        End Select
    End Sub


    Private Sub configuracionControles()
        tsTerminosPagables.Visible = True
        tsTerminosPenalizables.Visible = True
        tsLiquidacion.Visible = True

        tbcTerminos.TabPages.RemoveByKey("tpTraslado")

    End Sub

    Private Sub editlote_InputLanguageChanging(sender As Object, e As System.Windows.Forms.InputLanguageChangingEventArgs) Handles Me.InputLanguageChanging

    End Sub

    Private Sub editcontrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        configuracionControles()

        tbcTerminos.TabPages.RemoveByKey("tpCosto")


        'Auditoria
        oContratoLoteRO.oBE_AuditoriaD = New clsBE_AuditoriaD
        oContratoLoteRO.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria
        oContratoLoteRO.oBE_AuditoriaD.IdMenu = "Edit Lote"

        oContratoLoteTX.oBE_AuditoriaD = New clsBE_AuditoriaD
        oContratoLoteTX.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria
        oContratoLoteTX.oBE_AuditoriaD.IdMenu = "Edit Lote"

        oMovimientoTX.oBE_AuditoriaD = New clsBE_AuditoriaD
        oMovimientoTX.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria
        oMovimientoTX.oBE_AuditoriaD.IdMenu = "Edit Lote"

        oLiquidacionRO.oBE_AuditoriaD = New clsBE_AuditoriaD
        oLiquidacionRO.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria
        oLiquidacionRO.oBE_AuditoriaD.IdMenu = "Edit Lote"

        dgvProfitLossLoteCalculado.AutoGenerateColumns = False

        Try
            ConfiguraForm(Me)
            CargarParametros()

            cboTipo.Enabled = False
            cboProducto.Enabled = False

            cboEmpresa.Enabled = False
            cboSocio.Enabled = False
            btnsocio.Enabled = False


            cboIncoterm.Enabled = False
            cboDeposito.Enabled = False


            lblUCrea.Text = ""
            lblUModi.Text = ""
            lblFCrea.Text = ""
            lblFModi.Text = ""

            cbxHumedad.Checked = False

            If pblnDesdeContrato Then
                pblnNuevo = True
                Me.Text = "Nuevo Lote-Administrador : " & pstrAdministrador
                ObtenerLote(pstrCorrelativo, True)
                pstrCorrelativoLiquidacion = "0000000001"
                pstrCorrelativoLiquidacionTM = "0000000001"
                ObtenerLiquidacion(pstrCorrelativo)

                ObtenerPagables(pstrCorrelativo)
                ObtenerPenalizables(pstrCorrelativo)
                'btnContrato.Enabled = False
                txtNumeroLote.ReadOnly = False
                cboSocio.Enabled = False
                cboCalidad.Enabled = True
                cboTrader.Enabled = False
                cboAdministrador.Enabled = False
                'btnTrader.Enabled = False

                ObtenerDatosContrato(pstrCorrelativo)
                ValidarTipoMovimiento()

                'kmn 22/08/2012
                pstrCorrelativo = Obtener_Correlativo(SI.PL.clsEnumerado.enumTipoCorrelativo.Lote)
                txtCorrelativo.Text = pstrCorrelativo

                DefinirAjustes()
                DefinirServicios()

                dtLiquidacionTM = oLiquidacionTMRO.DefineTablaLiquidacionTm
                dtLiquidacion = oLiquidacionRO.DefinirTablaLiquidacion
                'kmn 22/08/2012


                Calculo_IGV()

                'Dim oTablaDetRO As New clsBC_TablaDetRO
                'oTablaDetRO.oBETablaDet.tablaId = "impuesto"
                'oTablaDetRO.oBETablaDet.tablaDetId = "igv"
                'oTablaDetRO.LeerTablaDet()

                ''EXPORTACION (IGV 18%)
                'If cboCategoria.SelectedValue = "0000000002" Then
                '    txtPorImpuesto.Text = 0
                'Else
                '    txtPorImpuesto.Text = oTablaDetRO.oBETablaDet.descri.ToString()
                'End If

                'txtPorImpuesto.Text = oTablaDetRO.oBETablaDet.descri.ToString()

            ElseIf pblnNuevo Then

                pstrCorrelativo = Obtener_Correlativo(SI.PL.clsEnumerado.enumTipoCorrelativo.Lote)
                pstrCorrelativoLiquidacion = Obtener_Correlativo("tbLiquidacion", "liquidacionID", "contratoloteid", pstrCorrelativo)
                pstrCorrelativoLiquidacionTM = Obtener_Correlativo("tbLiquidacion", "liquidacionID", "contratoloteid", pstrCorrelativo)
                txtCorrelativo.Text = pstrCorrelativo
                txtcorrelativoliquidacion.Text = pstrCorrelativoLiquidacion

                Me.Cursor = Cursors.Default
                Me.Text = "Nuevo Lote"
                DefinirAjustes()
                DefinirServicios()
                dtLiquidacionTM = oLiquidacionTMRO.DefineTablaLiquidacionTm
                dtLiquidacion = oLiquidacionRO.DefinirTablaLiquidacion
                btnContrato.Enabled = True
                txtNumeroLote.ReadOnly = False
                cboSocio.Enabled = False
                cboTrader.Enabled = False
                cboAdministrador.Enabled = False
                cboCalidad.Enabled = True

                Calculo_IGV()
                'Dim oTablaDetRO As New clsBC_TablaDetRO
                'oTablaDetRO.oBETablaDet.tablaId = "impuesto"
                'oTablaDetRO.oBETablaDet.tablaDetId = "igv"
                'oTablaDetRO.LeerTablaDet()
                'txtPorImpuesto.Text = oTablaDetRO.oBETablaDet.descri.ToString()

            ElseIf pblnCopia Then
                Dim strCorrelativo As String
                strCorrelativo = pstrCorrelativo
                pstrCorrelativo = Obtener_Correlativo(SI.PL.clsEnumerado.enumTipoCorrelativo.Lote)
                ObtenerLote(strCorrelativo, True)
                pstrCorrelativoLiquidacion = "0000000001"
                pstrCorrelativoLiquidacionTM = "0000000001"
                txtCorrelativo.Text = pstrCorrelativo
                txtcorrelativoliquidacion.Text = "0000000001"

                dtLiquidacionTM = oLiquidacionTMRO.DefineTablaLiquidacionTm
                dtLiquidacion = oLiquidacionRO.DefinirTablaLiquidacion

                ObtenerLiquidacion(strCorrelativo + "C")
                'ObtenerLiquidacionDscto(strCorrelativo + "C")
                ' Cjulca 05-08-2016
                ObtenerLiquidacionServicio(strCorrelativo + "C")
                ' Fin Cjulca
                'ObtenerLiquidacionTotal(strCorrelativo)
                ' Cjulca 05-08-2016
                ObtenerPagables(strCorrelativo + "C")
                ObtenerPenalizables(strCorrelativo + "C")
                ' Fin Cjulca 05-08-2016
                Me.Cursor = Cursors.Default
                Me.Text = "Copiando Lote"
                btnContrato.Enabled = False
                txtNumeroLote.ReadOnly = False
                cboSocio.Enabled = False
                cboTrader.Enabled = False
                cboAdministrador.Enabled = False
                cboCalidad.Enabled = True
                ValidarTipoMovimiento()


            Else
                'Me.Text = "Editando Lote-Administrador : " & pstrAdministrador
                ObtenerLote(pstrCorrelativo)
                Me.Text = "Editando Lote : " & cboTipo.Text & txtNumero.Text & "/" & txtNumeroLote.Text
                pstrCorrelativoLiquidacion = "0000000001"
                pstrCorrelativoLiquidacionTM = "0000000001"
                ObtenerLiquidacion(pstrCorrelativo)
                ObtenerLiquidacionDscto(pstrCorrelativo)
                ObtenerLiquidacionServicio(pstrCorrelativo)
                ObtenerLiquidacionTotal(pstrCorrelativo)
                ObtenerLiquidacionTM(pstrCorrelativo)
                ObtenerPagables(pstrCorrelativo)
                ObtenerPenalizables(pstrCorrelativo)
                btnContrato.Enabled = False
                'txtNumeroLote.ReadOnly = True
                cboSocio.Enabled = False
                cboTrader.Enabled = False
                cboAdministrador.Enabled = False
                cboCalidad.Enabled = True
                'btnTrader.Enabled = False
                'dgvLiquidacion2.Columns("liquidacionID").Visible = False
                ValidarTipoMovimiento()
                tsbLiquidacion.Visible = True
            End If
            NombrarEtiquetas()
            ResumenGeneral()

            txtTMH.Enabled = False
            txtH20.Enabled = False
            txtTMS.Enabled = False
            nupdMerma.Enabled = True
            txtTMSN.Enabled = False

            txtTMH.ReadOnly = True
            txtH20.ReadOnly = True
            txtTMS.ReadOnly = True
            nupdMerma.ReadOnly = False
            txtTMSN.ReadOnly = True

           
            'txtpstrAdministrador.Text = pstrAdministrador

            'dgvPagables.Columns("contenido").Frozen = True
            'dgvPagables.Columns("pu").Frozen = True
            If cboTipo.SelectedValue = "B" Then
                Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO
                'dgvComposicion.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicion(txtCorrelativo.Text.Trim())

                If cboTipo.SelectedValue = "B" Then
                    dgvComposicionM.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicion(txtCorrelativo.Text.Trim())
                ElseIf cboTipo.SelectedValue = "V" Then
                    dgvComposicionM.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicionVinculada(txtCorrelativo.Text.Trim())
                End If
                'dgvComposicionM.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicion(txtCorrelativo.Text.Trim())
                dgvComposicionM.AutoGenerateColumns = True
                dgvComposicionM.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvComposicionM.Columns("Lote").Frozen = True


                dgvComposicionM.Columns("Tipo").Width = 30
                dgvComposicionM.Columns("Ruma Actual").Width = 85
                dgvComposicionM.Columns("Ruma Destino").Width = 85

                dgvComposicionM.Columns("Lote").Width = 75
                dgvComposicionM.Columns("Estado").Width = 45

                dgvComposicionM.Columns("TMH_SLC").Width = 60
                dgvComposicionM.Columns("TMH").Width = 60
                dgvComposicionM.Columns("H2O").Width = 60
                dgvComposicionM.Columns("TMS").Width = 60
                dgvComposicionM.Columns("Merma").Width = 60
                dgvComposicionM.Columns("TMSN").Width = 60
                dgvComposicionM.Columns("CU").Width = 60
                dgvComposicionM.Columns("PB").Width = 60
                dgvComposicionM.Columns("ZN").Width = 60
                dgvComposicionM.Columns("AG").Width = 60
                dgvComposicionM.Columns("AU").Width = 60

                dgvComposicionM.Columns("Precio CU").Width = 80
                dgvComposicionM.Columns("Precio PB").Width = 80
                dgvComposicionM.Columns("Precio ZN").Width = 80
                dgvComposicionM.Columns("Precio AG").Width = 80
                dgvComposicionM.Columns("Precio AU").Width = 80
                dgvComposicionM.Columns("Cont CU").Width = 80
                dgvComposicionM.Columns("Cont PB").Width = 80
                dgvComposicionM.Columns("Cont ZN").Width = 80
                dgvComposicionM.Columns("Cont AG").Width = 80
                dgvComposicionM.Columns("Cont AU").Width = 80
                dgvComposicionM.Columns("Valor Neto").Width = 100


                dgvComposicionM.Columns("TMH_SLC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("TMH").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("H2O").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("TMS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Merma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("TMSN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("CU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("PB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("ZN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("AG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("AU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvComposicionM.Columns("Precio CU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Precio PB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Precio ZN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Precio AG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Precio AU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont CU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont PB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont ZN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont AG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont AU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Valor Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


                dgvComposicionM.Columns("TMH_SLC").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("TMH").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("H2O").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("TMS").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Merma").DefaultCellStyle.Format = "#,0.00;(#,0.00);'-'"
                dgvComposicionM.Columns("TMSN").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("CU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("PB").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("ZN").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("AG").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("AU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"

                dgvComposicionM.Columns("Precio CU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Precio PB").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Precio ZN").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Precio AG").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Precio AU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont CU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont PB").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont ZN").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont AG").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont AU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Valor Neto").DefaultCellStyle.Format = "#,0.0000;(#,0.00);'-'"

            ElseIf cboTipo.SelectedValue = "V" Then
                Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO

                If cboTipo.SelectedValue = "B" Then
                    dgvComposicionM.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicion(txtCorrelativo.Text.Trim())
                ElseIf cboTipo.SelectedValue = "V" Then
                    dgvComposicionM.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicionVinculada(txtCorrelativo.Text.Trim())
                End If
                'dgvComposicionM.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicion(txtCorrelativo.Text.Trim())
                dgvComposicionM.AutoGenerateColumns = True
                dgvComposicionM.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                dgvComposicionM.Columns("periodo").Visible = False
                dgvComposicionM.Columns("ContratoVinculada").Visible = False
                dgvComposicionM.Columns("LoteVinculada").Visible = False

                dgvComposicionM.Columns("Lote").Frozen = True

                dgvComposicionM.Columns("Tipo").Width = 30
                dgvComposicionM.Columns("Ruma Actual").Width = 85
                dgvComposicionM.Columns("Ruma Destino").Width = 85

                dgvComposicionM.Columns("Lote").Width = 75
                dgvComposicionM.Columns("Estado").Width = 45

                dgvComposicionM.Columns("TMH_SLC").Width = 60
                dgvComposicionM.Columns("TMH").Width = 60
                dgvComposicionM.Columns("H2O").Width = 60
                dgvComposicionM.Columns("TMS").Width = 60
                dgvComposicionM.Columns("Merma").Width = 60
                dgvComposicionM.Columns("TMSN").Width = 60
                dgvComposicionM.Columns("CU").Width = 60
                dgvComposicionM.Columns("PB").Width = 60
                dgvComposicionM.Columns("ZN").Width = 60
                dgvComposicionM.Columns("AG").Width = 60
                dgvComposicionM.Columns("AU").Width = 60

                dgvComposicionM.Columns("Precio CU").Width = 80
                dgvComposicionM.Columns("Precio PB").Width = 80
                dgvComposicionM.Columns("Precio ZN").Width = 80
                dgvComposicionM.Columns("Precio AG").Width = 80
                dgvComposicionM.Columns("Precio AU").Width = 80
                dgvComposicionM.Columns("Cont CU").Width = 80
                dgvComposicionM.Columns("Cont PB").Width = 80
                dgvComposicionM.Columns("Cont ZN").Width = 80
                dgvComposicionM.Columns("Cont AG").Width = 80
                dgvComposicionM.Columns("Cont AU").Width = 80
                dgvComposicionM.Columns("Valor Neto").Width = 100

                dgvComposicionM.Columns("TMH_SLC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("TMH").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("H2O").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("TMS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Merma").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("TMSN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("CU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("PB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("ZN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("AG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("AU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvComposicionM.Columns("Precio CU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Precio PB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Precio ZN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Precio AG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Precio AU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont CU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont PB").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont ZN").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont AG").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Cont AU").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvComposicionM.Columns("Valor Neto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                dgvComposicionM.Columns("TMH_SLC").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("TMH").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("H2O").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("TMS").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Merma").DefaultCellStyle.Format = "#,0.00;(#,0.00);'-'"
                dgvComposicionM.Columns("TMSN").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("CU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("PB").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("ZN").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("AG").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("AU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"

                dgvComposicionM.Columns("Precio CU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Precio PB").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Precio ZN").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Precio AG").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Precio AU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont CU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont PB").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont ZN").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont AG").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Cont AU").DefaultCellStyle.Format = "#,0.0000;(#,0.0000);'-'"
                dgvComposicionM.Columns("Valor Neto").DefaultCellStyle.Format = "#,0.0000;(#,0.00);'-'"
            Else
                tbcTerminos.TabPages.RemoveByKey("TabPage7")
            End If




            '********************************************************************************************
            '20-01-2013: FIJACIONES
            'FIJACIONES
            tsbFijar.Visible = False

            '@01    D02
            'txtProduccionPropia.Visible = False
            'lblProduccionPropia.Visible = False

            Select Case cboTipo.SelectedValue
                Case "P"
                    txtNumeroLote.MaxLength = 3

                    '@01    D02
                    'txtProduccionPropia.Visible = True
                    'lblProduccionPropia.Visible = True

                    '@01    A04
                    'txtTipoCambioPP.Visible = True
                    'lblTipoCambioPP.Visible = True
                    'txtValorSolesPP.Visible = True
                    'lblValorSolesPP.Visible = True

                Case "S"
                    txtNumeroLote.MaxLength = 3

                Case "V"
                    txtNumeroLote.MaxLength = 3

                Case "B"
                    txtNumeroLote.MaxLength = 5
                    tsbLiquidacion.Visible = False

                Case "T"

                    cboEmpresa.Enabled = True
                    'cboSocio.Enabled = True
                    btnsocio.Enabled = True
            End Select


            '********************************************************************************************
            tsbFijar.Visible = False
            EditarColumnasModificables(dgvPagables, "pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,ProtCont") ',FinPrecio
            Select Case cboTipo.SelectedValue
                Case "P"
                    txtNumeroLote.MaxLength = 3
                    tsbFijar.Visible = True

                Case "S"
                    txtNumeroLote.MaxLength = 3
                    tsbFijar.Visible = True

                Case "V"
                    txtNumeroLote.MaxLength = 3
                    EditarColumnasModificables(dgvPagables, "pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio,FinPrecio") ',FinPrecio

                Case "B"
                    txtNumeroLote.MaxLength = 5
                    tsbLiquidacion.Visible = False

                Case "T"

                    cboEmpresa.Enabled = True
                    'cboSocio.Enabled = True
                    btnsocio.Enabled = True
            End Select
            '********************************************************************************************



            If (cboClase.SelectedValue <> "0000000003" Or cboClase.SelectedValue <> "0000000004") Then
                If cboTipo.SelectedValue <> "P" Then
                    tbcTerminos.TabPages.RemoveByKey("tpProfitAndLoss")
                End If
            End If


            ' ''kmn (vinculadas)
            'txtNumeroLote.Enabled = True
            'txtNumeroLote.ReadOnly = False

            ObtienerContratoVinculadas()

            PermisoTabs()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


    Private Sub PermisoTabs()
        gbxEstadoContable.Visible = False

        'Permiso de solo compras
        If pBEUsuario.campo6 = "1" Then
            tbcTerminos.TabPages.RemoveByKey("tpProfitAndLoss")
        End If

        'Permiso de Autorización Contable
        If pBEUsuario.campo9 = "1" Then
            gbxEstadoContable.Visible = True
        End If


    End Sub


    Private Sub ObtienerContratoVinculadas()
        If cboTipo.Text = "S" Then
            Dim sContratoLoteId As String = txtCorrelativo.Text.Trim()
            Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO
            Dim ds As DataSet
            ds = loclsBC_LiquidacionRO.LeerListaDSRumasVinculadas(sContratoLoteId)

            dgvVinculadasContrato.DataSource = ds.Tables(0)
            dgvVinculadasLote.DataSource = ds.Tables(1)
        End If
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Try
            Select Case keyData
                Case Keys.Escape
                    CerrarFormulario()
                Case Keys.F11

                    ResumenGeneral()

            End Select
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

#End Region

    Private Sub ObtenerLote(ByVal contratoloteid As String, Optional ByVal bTipo As Boolean = False)
        Try
            With oContratoLoteRO.oBEContratoLote
                .contratoLoteId = contratoloteid
            End With
            oContratoLoteRO.LeerContratoLote()
            With oContratoLoteRO.oBEContratoLote

                txtNumero.Text = oContratoLoteRO.oBEContratoLote.contrato.Trim
                txtCorrelativo.Text = oContratoLoteRO.oBEContratoLote.contratoLoteId
                cboTipo.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoMovimiento
                txtNumero.Text = .contrato.Trim
                cboEmpresa.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoEmpresa
                cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
                txtNumeroLote.Text = .lote.Trim

                If bTipo Then
                    txtNumeroLote.Text = .loteNuevo.Trim
                End If

                cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto
                txtprocedencia.Text = .procedencia
                txtComentarios.Text = .comentarios
                cboModo.SelectedValue = .codigoModo
                cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad


                pRucEmpresa = oContratoLoteRO.oBEContratoLote.rucEmpresa


                cboCategoria.SelectedValue = oContratoLoteRO.oBEContratoLote.categoria

                Dim oTablaDetRO As New clsBC_TablaDetRO
                oTablaDetRO.oBETablaDet.tablaId = "Usuario"
                oTablaDetRO.oBETablaDet.tablaDetId = oContratoLoteRO.oBEContratoLote.uc
                oTablaDetRO.LeerTablaDet()
                'lblUCrea.Text = oTablaDetRO.oBETablaDet.descri
                lblUCrea.Text = pBEUsuario.descri
                lblFCrea.Text = oContratoLoteRO.oBEContratoLote.fc

                oTablaDetRO.oBETablaDet.tablaDetId = oContratoLoteRO.oBEContratoLote.um
                oTablaDetRO.LeerTablaDet()
                lblUModi.Text = oTablaDetRO.oBETablaDet.descri
                lblFModi.Text = oContratoLoteRO.oBEContratoLote.fm

                sLOTE_CERRADO = IIf(pblnCopia, "", oContratoLoteRO.oBEContratoLote.LOTE_CERRADO)
                cbxLOTE_CERRADO.Checked = IIf(sLOTE_CERRADO = "C", True, False)

                'preliquidacion fija (estimacion)
                cbxPreliquidacionFija.Checked = IIf(oContratoLoteRO.oBEContratoLote.preliquidacionFija = "1", True, False)

            End With

            obtenerLoteVenta()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub ObtenerLiquidacion(ByVal contratoloteid As String)

        Dim tipoLiq As String = Strings.Right(contratoloteid, 1)

        ' dtPeriodo.Value.Year.ToString & Microsoft.VisualBasic.Right("0" & dtPeriodo.Value.Month.ToString, 2)
        MesActual = Microsoft.VisualBasic.Right("0" & Now.Month.ToString, 2)
        AnioActual = Now.Year.ToString("####")


        Try
            With oLiquidacionRO.oBELiquidacion
                .contratoLoteId = contratoloteid
                .liquidacionId = pstrCorrelativoLiquidacion
                oLiquidacionRO.LeerLiquidacion()
                nupdMerma.Value = oLiquidacionRO.oBELiquidacion.porcentajeMerma
                nupdPorcentaje.Value = oLiquidacionRO.oBELiquidacion.pp
                nupdPorcPago.Value = oLiquidacionRO.oBELiquidacion.porcentajePago
                txtbasepart.Text = oLiquidacionRO.oBELiquidacion.basepp
                txtbase1.Text = oLiquidacionRO.oBELiquidacion.base1
                txtbase2.Text = oLiquidacionRO.oBELiquidacion.base2
                txtbasemas1.Text = oLiquidacionRO.oBELiquidacion.escaladorMas1
                txtbasemas2.Text = oLiquidacionRO.oBELiquidacion.escaladorMas2
                txtbasemenos1.Text = oLiquidacionRO.oBELiquidacion.escaladorMenos1
                txtbasemenos2.Text = oLiquidacionRO.oBELiquidacion.escaladorMenos2
                txtMaquila.Text = oLiquidacionRO.oBELiquidacion.maquila
                txttasa.Text = oLiquidacionRO.oBELiquidacion.tasaInteres
                txttiempo.Text = oLiquidacionRO.oBELiquidacion.tasaTiempo
                txttasamora.Text = oLiquidacionRO.oBELiquidacion.tasaMoratoria
                txtAjuste.Text = oLiquidacionRO.oBELiquidacion.cargoAjuste
                BaseRc.Text = oLiquidacionRO.oBELiquidacion.baseRc
                Rcmas.Text = oLiquidacionRO.oBELiquidacion.RcMas
                Rcmenos.Text = oLiquidacionRO.oBELiquidacion.RcMenos
                RcBasecon.Text = oLiquidacionRO.oBELiquidacion.RcBaseCon
                ContMas.Text = oLiquidacionRO.oBELiquidacion.ContMas
                ContMenos.Text = oLiquidacionRO.oBELiquidacion.ContMenos

                If oLiquidacionRO.oBELiquidacion.periodo = "" Then
                    oLiquidacionRO.oBELiquidacion.periodo = "190001"
                End If

                If oLiquidacionRO.oBELiquidacion.periodo.Length = 4 Then
                    dtPeriodo.Value = Convert.ToDateTime("01/01/" & oLiquidacionRO.oBELiquidacion.periodo)
                Else
                    If pblnCopia Then
                        dtPeriodo.Value = Convert.ToDateTime("01/" & MesActual + "/" & AnioActual)
                    Else
                        dtPeriodo.Value = Convert.ToDateTime("01/" & oLiquidacionRO.oBELiquidacion.periodo.Substring(4, 2) + "/" & oLiquidacionRO.oBELiquidacion.periodo.Substring(0, 4))
                    End If
                End If
                '@05    D03
                'If cboTipo.SelectedValue = "B" Then
                '    dtPeriodo.Value = "01/01/1900"
                'End If


                txtPorImpuesto.Text = oLiquidacionRO.oBELiquidacion.valorIgv


                cboModo.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoTasa
                nupdPorcentaje.Value = oLiquidacionRO.oBELiquidacion.pp
                cboIncoterm.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoIncoterm
                cboDeposito.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoDeposito

                cboTrader.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoTrader

                If (tipoLiq = "C") Then
                    cboAdministrador.SelectedValue = ""
                Else
                    cboAdministrador.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoAdministrador
                End If

                cbxHumedad.Checked = IIf(oLiquidacionRO.oBELiquidacion.H2O = 0, False, True)

                '@01    D01
                'txtProduccionPropia.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.Ajuste, 2)

                '@01    A03
                ''txtCostoOperativo.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.valorPP, 2)
                ''txtValorSolesPP.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.valorPPSol, 2)
                ''txtTipoCambioPP.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.valorTipoCambioPP, 2)

                txtCostoVenta.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.costoOperativo, 2)

                If oLiquidacionRO.oBELiquidacion.periodoComercial = "" Then
                    dtpPeriodoComercial.Value = dtPeriodo.Value
                    'dtpPeriodoComercial.Value = Today
                Else
                    If oLiquidacionRO.oBELiquidacion.periodoComercial.Length = 4 Then
                        dtpPeriodoComercial.Value = Convert.ToDateTime("01/01/" & oLiquidacionRO.oBELiquidacion.periodoComercial)
                    Else
                        If pblnCopia Then
                            dtPeriodo.Value = Convert.ToDateTime("01/" & MesActual + "/" & AnioActual)
                        Else
                            dtpPeriodoComercial.Value = Convert.ToDateTime("01/" & oLiquidacionRO.oBELiquidacion.periodoComercial.Substring(4, 2) + "/" & oLiquidacionRO.oBELiquidacion.periodoComercial.Substring(0, 4))
                        End If
                    End If
                End If

                txtValorLiquidacion.Text = FormatNumber(oLiquidacionRO.oBELiquidacion.ValorNeto, 2)

            End With

            obtenerProfitLossLote(contratoloteid)

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub obtenerProfitLossLote(ByVal contratoloteid As String)
        Dim oBC_ProfitLossLoteRO As New clsBC_ProfitLossLoteRO
        Dim oBE_ProfitLossLote As New clsBE_ProfitLossLote

        Dim dsProfitLossLote As DataSet

        oBE_ProfitLossLote.contratoloteId = contratoloteid
        oBE_ProfitLossLote.liquidacionId = pstrCorrelativoLiquidacion

        oBC_ProfitLossLoteRO.LeerListaToDSProfitLoss(contratoloteid)
        dsProfitLossLote = oBC_ProfitLossLoteRO.oDSProfitLossLote
        dgvProfitLossLote.DataSource = dsProfitLossLote.Tables(0)
        dgvProfitLossLoteCalculado.DataSource = dsProfitLossLote.Tables(1)

        oBC_ProfitLossLoteRO = New clsBC_ProfitLossLoteRO
        oBC_ProfitLossLoteRO.LeerListaToDSProfitLoss_Sel(oBE_ProfitLossLote)
        dsProfitLossLote = oBC_ProfitLossLoteRO.oDSProfitLossLote
        If dsProfitLossLote.Tables.Count > 0 Then
            If dsProfitLossLote.Tables(0).Rows.Count > 0 Then
                txtPL_Flete.Text = dsProfitLossLote.Tables(0).Rows(0)("flete").ToString
                txtPL_Estibas.Text = dsProfitLossLote.Tables(0).Rows(0)("estibas").ToString
                txtPL_Supervision.Text = dsProfitLossLote.Tables(0).Rows(0)("supervision").ToString
                txtPL_Seguridad.Text = dsProfitLossLote.Tables(0).Rows(0)("seguridad").ToString
                txtPL_Ensayes.Text = dsProfitLossLote.Tables(0).Rows(0)("ensayes").ToString
                txtPL_Otros.Text = dsProfitLossLote.Tables(0).Rows(0)("otros").ToString
                txtPL_total.Text = dsProfitLossLote.Tables(0).Rows(0)("total").ToString

            End If
        End If
    End Sub

    Private Sub ObtenerLiquidacionTM(ByVal contratoloteid As String)
        Try
            With oLiquidacionTMRO.oBELiquidacionTm
                .contratoLoteId = contratoloteid
                .liquidacionId = pstrCorrelativoLiquidacion
                .liquidacionTmId = pstrCorrelativoLiquidacionTM
                'oLiquidacionTMRO.LeerLiquidacionTm()
                txtTMH.Text = .tmh
                txtTMS.Text = .tms
                txtTMSN.Text = .tmsn
                txtH20.Text = .h2o

                dtLiquidacionTM = oLiquidacionTMRO.LeerListaToDSLiquidacion.Tables(0)
                'dsPagable = dtPagable.DataSet
                dvwLiquidacionTM = New DataView(dtLiquidacionTM)


                dgvLiquidacionTM.AutoGenerateColumns = False
                dgvLiquidacionTM.DataSource = dvwLiquidacionTM

                EditarColumnasModificables(dgvLiquidacionTM, "")
                EditarColumnasModificables(dgvLiquidacionTMTotal, "")
                dgvLiquidacionTM.Columns("PagAg").Visible = False
                dgvLiquidacionTM.Columns("PagAu").Visible = False
            End With


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub ObtenerLiquidacionTMTraslado(ByVal contratoloteid As String)
        Try
            Dim oLiquidacionTMROTraslado As New clsBC_LiquidacionTmRO

            With oLiquidacionTMROTraslado.oBELiquidacionTm
                .contratoLoteId = contratoloteid
                .liquidacionId = pstrCorrelativoLiquidacion

                dtLiquidacionTM = oLiquidacionTMROTraslado.LeerListaToDSLiquidacion.Tables(0)

                dgvLiquidacionTMTraslado.AutoGenerateColumns = False
                dgvLiquidacionTMTraslado.DataSource = dvwLiquidacionTM

            End With


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub obtenerLoteVenta()
        If cboTipo.Text = "V" Then

            Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
            Dim oBE_ContratoLote As New clsBE_ContratoLote
            oBE_ContratoLote.contratoLoteId = txtNumeroLote.Text
            oBC_ContratoLoteRO.ContratoLote_Sel_Venta(oBE_ContratoLote)
            If Not oBC_ContratoLoteRO.oBEContratoLote Is Nothing Then
                txtContratoLoteVenta.Text = oBC_ContratoLoteRO.oBEContratoLote.lote
            End If
            btnVenta.Visible = True
        End If

        If cboTipo.Text <> "S" Then
            'tpVinculadas .visib
            tbcTerminos.TabPages.RemoveByKey("tpVinculadas")
        End If


    End Sub


    Private Sub obtenerLoteCosto()

        Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
        Dim oBE_ContratoLote As New clsBE_ContratoLote
        oBE_ContratoLote.contratoLoteId = txtCorrelativo.Text
        Dim dsContratoLoteCosto As DataSet = oBC_ContratoLoteRO.LeerListaToDSContratoLoteCosto(oBE_ContratoLote)

        dgvContratoLoteCosto.DataSource = dsContratoLoteCosto.Tables(0)

    End Sub

    Private Sub ObtenerLiquidacionDscto(ByVal contratoloteid As String)
        Try
            With oLiquidacionDsctoRO.oBELiquidacionDscto
                .contratoLoteId = contratoloteid
                .liquidacionId = pstrCorrelativoLiquidacion
                .liquidacionDsctoId = pstrCorrelativoLiquidacionDscto
                dtAjuste = oLiquidacionDsctoRO.LeerListaToDSLiquidacionDscto.Tables(0)
                'dsPagable = dtPagable.DataSet
                dvwAjuste = New DataView(dtAjuste)
                'dvwAjuste = New DataView(oLiquidacionDsctoRO.LeerListaToDSLiquidacionDscto.Tables(0))
                dgvAjustes.AutoGenerateColumns = False
                dgvAjustes.DataSource = dvwAjuste
                EditarColumnasModificables(dgvAjustes, "importeTotal")

                If cboTipo.SelectedValue = "S" Or cboTipo.SelectedValue = "V" Then
                    EditarColumnasModificables(dgvAjustes, "descriDscto,importeDscto,importeTotal")
                End If

                dgvDstoProvisionales.AutoGenerateColumns = False
                dgvDstoProvisionales.DataSource = oLiquidacionDsctoRO.ObtenerProvisionalDscto.Tables(0)

                ' Para mostrar Prestamos de Comercial
                'Dim oPrestamoComRO As New clsBC_FINANCIANDO_CLIRO
                'oPrestamoComRO.oBEFINANCIANDO_CLI.proveedor = cboSocio.SelectedValue
                'oPrestamoComRO.oBEFINANCIANDO_CLI.empresa = cboEmpresa.SelectedValue
                'dgvPrestamosCom.DataSource = oPrestamoComRO.LeerListaToDSPRESTAMO_COM.Tables(0)

                ' Para mostrar Prestamos de Caja Chica
                Dim oContratoRO As New clsBC_FINANCIANDO_CLIRO
                oContratoRO.oBEFINANCIANDO_CLI.proveedor = cboSocio.SelectedValue
                dgvPrestamosCchica.DataSource = oContratoRO.LeerListaToDSPRESTAMO_CCH.Tables(0)

                dgvPrestamosCchica.Columns(0).Width = 80
                dgvPrestamosCchica.Columns(1).Width = 50
                dgvPrestamosCchica.Columns(2).Width = 80
                dgvPrestamosCchica.Columns(3).Width = 50
                dgvPrestamosCchica.Columns(4).Width = 80
                dgvPrestamosCchica.Columns(5).Width = 250
                dgvPrestamosCchica.Columns(6).Width = 80
                dgvPrestamosCchica.Columns(7).Width = 300
                dgvPrestamosCchica.Columns(8).Width = 100
                dgvPrestamosCchica.Columns(9).Width = 100

                dgvPrestamosCchica.Columns(0).HeaderText = "Empresa"
                dgvPrestamosCchica.Columns(1).HeaderText = "Td"
                dgvPrestamosCchica.Columns(2).HeaderText = "Doc"
                dgvPrestamosCchica.Columns(3).HeaderText = "Mon"
                dgvPrestamosCchica.Columns(4).HeaderText = "Saldo"
                dgvPrestamosCchica.Columns(5).HeaderText = "Observaciones"
                dgvPrestamosCchica.Columns(6).HeaderText = "Contrato"
                dgvPrestamosCchica.Columns(7).HeaderText = "Calidad"
                dgvPrestamosCchica.Columns(8).HeaderText = "Fecha"
                dgvPrestamosCchica.Columns(9).HeaderText = "Ruc"

                dgvPrestamosCchica.Columns(10).Visible = False
                dgvPrestamosCchica.Columns(11).Visible = False
                dgvPrestamosCchica.Columns(12).Visible = False


            End With
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ObtenerLiquidacionServicio(ByVal contratoloteid As String)
        Try
            With oLiquidacionServicioRO.oBELiquidacionServicio
                .contratoLoteId = contratoloteid
                .liquidacionId = pstrCorrelativoLiquidacion
                .liquidacionServicioId = pstrCorrelativoLiquidacionServicio
                dtServicio = oLiquidacionServicioRO.LeerListaToDSLiquidacionServicio.Tables(0)
                dvwServicio = New DataView(dtServicio)
                dgvServicios.AutoGenerateColumns = False
                dgvServicios.DataSource = dvwServicio
                EditarColumnasModificables(dgvServicios, "descriServicio,importeServicio,dgvcalculoservicio,indservicio")
            End With
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
   
    Private Sub ObtenerLiquidacionTotal(ByVal contratoloteid As String)
        Try
            With oLiquidacionTotalRO.oBELiquidacionTotal
                .contratoLoteId = contratoloteid
                .liquidacionId = pstrCorrelativoLiquidacion
                .liquidacionTotalId = pstrCorrelativoLiquidacionServicio 'ver
                dtLiquidacion = oLiquidacionTotalRO.LeerListaToDSLiquidacionTotal.Tables(0)
                'dvwLiquidacion = New DataView(dtLiquidacion)
                'dgvLiquidacion.AutoGenerateColumns = False
                dgvLiquidacion.DataSource = dtLiquidacion
                'EditarColumnasModificables(dgvLiquidacion, "descriServicio,importeServicio,dgvcalculoservicio")
                oTableDet.oBETablaDet.tablaId = "documento"
                dtTablaDet = oTableDet.LeerListaToDSTablaDet().Tables(0)
                C1TrueDBDropdown1.ValueMember = "tablaDetId"
                C1TrueDBDropdown1.DisplayMember = "descri"
                C1TrueDBDropdown1.DataSource = dtTablaDet
                C1TrueDBDropdown1.AlternatingRows = True
                C1TrueDBDropdown1.Row = 0

                Dim col As C1.Win.C1TrueDBGrid.C1DataColumn

                For Each col In C1TrueDBDropdown1.Columns

                    If col.DataField.ToString().Trim() <> "tablaDetId" And col.DataField.ToString().Trim() <> "descri" Then
                        C1TrueDBDropdown1.DisplayColumns(col.DataField.ToString().Trim()).Visible = False
                    End If

                Next col


                dgvLiquidacion.Splits(0).DisplayColumns("descri").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("numeroCalculo").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("liquidacionId").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("ValorNeto").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("ValorIgv").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("ValorTotal").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("fc").Locked = True

                dgvLiquidacion.Splits(0).DisplayColumns("Adelanto").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("Descuentos").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("Neto A Pagar").Locked = True

                dgvLiquidacion.Splits(0).DisplayColumns("Eliminar").Visible = False
                dgvLiquidacion.Splits(0).DisplayColumns("liquidacionid").Visible = False

                dgvLiquidacion.Splits(0).DisplayColumns("ValorNetoAnterior").Visible = False
                dgvLiquidacion.Splits(0).DisplayColumns("TipoDocumento").Visible = False
                dgvLiquidacion.Splits(0).DisplayColumns("codigoCalculo").Visible = False

                dgvLiquidacion.Splits(0).DisplayColumns("codigoDocumento").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("numeroDocumento").Locked = True
                dgvLiquidacion.Splits(0).DisplayColumns("fechaDocumento").Locked = True


                dgvLiquidacion.Splits(0).DisplayColumns("FLG_VALIDA").Visible = False

                dgvLiquidacion.Columns("descri").Caption = "Calculo"
                dgvLiquidacion.Columns("numeroCalculo").Caption = "Número"
                dgvLiquidacion.Columns("liquidacionId").Caption = "Liquidación"
                dgvLiquidacion.Columns("ValorNeto").Caption = "Valor Neto"
                dgvLiquidacion.Columns("ValorIgv").Caption = "Valor IGV"
                dgvLiquidacion.Columns("ValorTotal").Caption = "Valor Total"
                dgvLiquidacion.Columns("fc").Caption = "Fecha"
                dgvLiquidacion.Columns("Eliminar").Caption = "Eliminar"
                dgvLiquidacion.Columns("codigoDocumento").Caption = "Tipo Doc."
                dgvLiquidacion.Columns("numeroDocumento").Caption = "Nro Doc."
                dgvLiquidacion.Columns("fechaDocumento").Caption = "Fecha Doc."

                dgvLiquidacion.Columns("ValorNeto").NumberFormat = "N2"
                dgvLiquidacion.Columns("ValorIgv").NumberFormat = "N2"
                dgvLiquidacion.Columns("ValorTotal").NumberFormat = "N2"

                dgvLiquidacion.Columns("Adelanto").NumberFormat = "N2"
                dgvLiquidacion.Columns("Descuentos").NumberFormat = "N2"
                dgvLiquidacion.Columns("Neto A Pagar").NumberFormat = "N2"

                dgvLiquidacion.Columns("codigoDocumento").DropDown = C1TrueDBDropdown1
                dgvLiquidacion.Columns("codigoDocumento").ValueItems.Translate = True
                C1TrueDBDropdown1.ValueTranslate = True

                dgvLiquidacion.Splits(0).DisplayColumns("numeroCalculo").Width = 50

                dgvLiquidacion.Columns("valorPP").NumberFormat = "N2"
                dgvLiquidacion.Columns("valorPPSol").NumberFormat = "N2"
                dgvLiquidacion.Columns("valorPP").Caption = "Valor Contable"
                dgvLiquidacion.Columns("valorPPSol").Caption = "Valor Ctb Soles"
                dgvLiquidacion.Splits(0).DisplayColumns("valorPP").Width = 90
                dgvLiquidacion.Splits(0).DisplayColumns("valorPPSol").Width = 90


                dgvLiquidacion.Splits(0).DisplayColumns("ValorNeto").Width = 80
                dgvLiquidacion.Splits(0).DisplayColumns("ValorIgv").Width = 80
                dgvLiquidacion.Splits(0).DisplayColumns("ValorTotal").Width = 80

                dgvLiquidacion.Splits(0).DisplayColumns("Adelanto").Width = 80
                dgvLiquidacion.Splits(0).DisplayColumns("Descuentos").Width = 80
                dgvLiquidacion.Splits(0).DisplayColumns("Neto A Pagar").Width = 80

                dgvLiquidacion.Splits(0).DisplayColumns("periodo").Width = 70
                dgvLiquidacion.Splits(0).DisplayColumns("calculo").Width = 90

                dgvLiquidacion.Splits(0).DisplayColumns("fechaDocumento").Width = 70
                dgvLiquidacion.Splits(0).DisplayColumns("fc").Width = 70
                dgvLiquidacion.Splits(0).DisplayColumns("numeroDocumento").Width = 80


                Dim oTablaDetRO As New clsBC_TablaDetRO
                oTablaDetRO.oBETablaDet.tablaId = "FacturaAnulada"
                oTablaDetRO.oBETablaDet.campo0 = txtCorrelativo.Text
                dgvFacturasAnuladas.AutoGenerateColumns = False
                dgvFacturasAnuladas.DataSource = oTablaDetRO.LeerListaToDSTablaDetCondicion.Tables(0)

            End With
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub ObtenerPagables(ByVal contratoloteid As String)
        Try
            With oValorizadorPagableRO.oBEValorizadorPagable
                .contratoLoteId = contratoloteid
                .liquidacionId = "0000000001"
            End With
            dtPagable = oValorizadorPagableRO.LeerListaToDSPagable.Tables(0)
            dvwPagable = New DataView(dtPagable)
            dgvPagables.AutoGenerateColumns = False
            dgvPagables.DataSource = dvwPagable

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
  
    Private Sub ObtenerPenalizables(ByVal contratoloteid As String)
        Try
            With oValorizadorPenalizableRO.oBEValorizadorPenalizable
                .contratoLoteId = contratoloteid
                .liquidacionId = "0000000001" 'pstrCorrelativoLiquidacion
            End With
            dtPenalizable = oValorizadorPenalizableRO.LeerListaToDSValorizadorPenalizable.Tables(0)
            dvwPenalizable = New DataView(dtPenalizable)
            dgvPenalizable.AutoGenerateColumns = False
            dgvPenalizable.DataSource = dvwPenalizable
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub CargarParametros()
        Try
            Obtener_ParametrosCombo(cboIncoterm, clsUT_Dominio.domTABLA_DE_INCOTERM, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboClase, clsUT_Dominio.domTABLA_DE_CLASES, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboCalidad, "Calidad", SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboProducto, clsUT_Dominio.domTABLA_DE_PRODUCTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosComboEN(cboDeposito, "COM_DEPOSITOS")
            Obtener_ParametrosComboEN(cboSocio, "PUB_PERSONAS")


            If pBEUsuario.campo2.Length > 0 Then
                ObtenerTipoMovimientoCombo(cboTipo, pBEUsuario.campo2)
            Else
                ObtenerTipoMovimientoCombo(cboTipo)
            End If

            Obtener_ParametrosCombo(tsCboAjuste, clsUT_Dominio.domTABLA_DE_AJUSTES, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(tsCboServicio, clsUT_Dominio.domTABLA_DE_SERVICIOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)


            Obtener_ParametrosCombo(cboModo, "Modo", SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IDCodigoDescripcion)
            Obtener_ParametrosCombo(cboTrader, clsUT_Dominio.domTRADER, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboAdministrador, clsUT_Dominio.domADMINISTRADOR, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosGridView(dgvTipo, clsUT_Dominio.domTIPO_DE_DEDUCCION)
            Obtener_ParametrosGridView(dgvMerc, clsUT_Dominio.domMERCADO)
            Obtener_ParametrosGridView(dgvCalculoServicio, "CalculoServicio")

            Obtener_ParametrosGridView(dgvqpAjuste, clsUT_Dominio.domTIPO_DE_AJUSTE_DE_QP)
            Obtener_ParametrosGridView(dgvQP, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION)

            Obtener_ParametrosCombo(tsCboPagable, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(tsCboPenalizable, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosCombo(cboCategoria, clsUT_Dominio.domTIPO_CATEGORIA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            EditarColumnasModificables(dgvPenalizable, "min,max,unid,pen,indLey")
            'EditarColumnasModificables(dgvPenalizable, "leyp,min,max,unid,pen,indLey")

            EditarColumnasModificables(dgvPagables, "pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio,ProtCont") ',FinPrecio

            'EditarColumnasModificables(dgvPagables, "ley,pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Function GrabarRegistro()
        Try
            Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO

            '************************************************************************
            'Auditoria
            loclsBC_LiquidacionRO.oBE_AuditoriaD = New clsBE_AuditoriaD
            loclsBC_LiquidacionRO.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria
            loclsBC_LiquidacionRO.oBE_AuditoriaD.IdMenu = "Edit Lote"
            '************************************************************************

            With oContratoLoteTX.oBEContratoLote
                .codigoTabla = TABLA.LOTE.Value
                .contratoLoteId = txtCorrelativo.Text
                .codigoMovimiento = cboTipo.SelectedValue
                .contrato = txtNumero.Text
                .codigoEmpresa = cboEmpresa.SelectedValue
                .codigoSocio = cboSocio.SelectedValue
                .lote = txtNumeroLote.Text
                .codigoClase = cboClase.SelectedValue

                .codigoProducto = cboProducto.SelectedValue
                .procedencia = txtprocedencia.Text
                .comentarios = txtComentarios.Text
                .codigoModo = cboModo.SelectedValue
                .codigoCalidad = cboCalidad.SelectedValue

                .categoria = cboCategoria.SelectedValue
                .LOTE_CERRADO = IIf(cbxLOTE_CERRADO.Checked, "1", "0")
                .preliquidacionFija = IIf(cbxPreliquidacionFija.Checked, "1", "0")

                .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                .uc = pBEUsuario.tablaDetId
                .um = pBEUsuario.tablaDetId
                oContratoLoteTX.LstContratoLote.Add(oContratoLoteTX.oBEContratoLote)
            End With
            If pblnNuevo Then
                oContratoLoteTX.InsertarContratoLote()
                pstrCorrelativo = oContratoLoteTX.oBEContratoLote.contratoLoteId

                Grabarliquidacion()
                GrabarAjustes()
                GrabarServicios()
                GrabarLiquidacionTm()
                'oMovimientoTX.ActualizaEstadoLogisticaMovimiento()
                GrabarPagables()
                GrabarPenalizables()
                oLiquidacionDsctoTX.EliminarDscto()
                oLiquidacionServicioTX.Eliminarservicio()
                oPagableTX.EliminarPagable()
                oPenalizableTX.EliminarPenalizable()
                oLiquidacionTMTX.EliminarLiquidacion()

                ''2014-01-29: calcula costos desde el MLC
                costoServicio()

                'Return True
            ElseIf pblnCopia Then
                oContratoLoteTX.InsertarContratoLote()
                pstrCorrelativo = oContratoLoteTX.oBEContratoLote.contratoLoteId

                Grabarliquidacion()
                GrabarAjustes()
                GrabarServicios()
                GrabarLiquidacionTm()
                'oMovimientoTX.ActualizaEstadoLogisticaMovimiento()
                GrabarPagables()
                GrabarPenalizables()
                oLiquidacionDsctoTX.EliminarDscto()
                oLiquidacionServicioTX.Eliminarservicio()
                oPagableTX.EliminarPagable()
                oPenalizableTX.EliminarPenalizable()

                oLiquidacionTMTX.EliminarLiquidacion()

                'Return True
            Else
                oContratoLoteTX.ModificarContratoLote()
                Grabarliquidacion()
                GrabarAjustes()
                GrabarServicios()
                GrabarLiquidacionTm()
                With oLiquidacionTMRO.oBELiquidacionTm
                    '.contratoLoteId = contratoloteid
                    .liquidacionId = pstrCorrelativoLiquidacion
                    .liquidacionTmId = pstrCorrelativoLiquidacionTM
                    oLiquidacionTMRO.LeerLiquidacionTm()
                End With
                dtLiquidacionTM = oLiquidacionTMRO.LeerListaToDSLiquidacion.Tables(0)
                dvwLiquidacionTM = New DataView(dtLiquidacionTM)
                dgvLiquidacionTM.AutoGenerateColumns = False
                dgvLiquidacionTM.DataSource = dvwLiquidacionTM

                'oMovimientoTX.ActualizaEstadoLogisticaMovimiento()

                GrabarPagables()
                oPagableTX.EliminarPagable()
                oPagableTX.LstValorizadorPagable.Clear()
                oPagableTX.LstValorizadorPagableIns.Clear()
                oPagableTX.LstValorizadorPagableUpd.Clear()
                GrabarPenalizables()
                oLiquidacionDsctoTX.EliminarDscto()
                oLiquidacionServicioTX.Eliminarservicio()

                oPenalizableTX.EliminarPenalizable()

                oLiquidacionTMTX.EliminarLiquidacion()


                ''2014-01-29: calcula costos desde el MLC
                costoServicio()

            End If


            'Grabar Profit and Loss
            If (cboClase.SelectedValue <> "0000000003" Or cboClase.SelectedValue <> "0000000004") Then
                If cboTipo.SelectedValue = "P" Then
                    GrabarProfitAndLoss()
                End If
            End If

            loclsBC_LiquidacionRO.fnCalculaLote(oContratoLoteTX.oBEContratoLote.contratoLoteId, pBEUsuario.tablaDetId, pAccionFormulario)

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
        Return True

    End Function


    Private Sub GrabarProfitAndLoss()
        Dim oBC_ProfitLossLoteTX As New clsBC_ProfitLossLoteTX
        Dim oBE_ProfitLossLote As New clsBE_ProfitLossLote

        oBE_ProfitLossLote.contratoloteId = pstrCorrelativo
        oBE_ProfitLossLote.liquidacionId = pstrCorrelativoLiquidacion

        oBE_ProfitLossLote.flete = txtPL_Flete.Text
        oBE_ProfitLossLote.estibas = txtPL_Estibas.Text
        oBE_ProfitLossLote.supervision = txtPL_Supervision.Text
        oBE_ProfitLossLote.seguridad = txtPL_Seguridad.Text
        oBE_ProfitLossLote.ensayes = txtPL_Ensayes.Text
        oBE_ProfitLossLote.otros = txtPL_Otros.Text

        oBC_ProfitLossLoteTX.oBEProfitLoss = oBE_ProfitLossLote

        If pblnCopia Or pblnNuevo Then
            oBC_ProfitLossLoteTX.InsertarProfitLoss()
        Else
            oBC_ProfitLossLoteTX.ModificarProfitLoss()
        End If

    End Sub

    Private Function GrabarLiquidacionTm()
        Try
            For Each row As DataGridViewRow In dgvLiquidacionTM.Rows
                oLiquidacionTMTX.NuevaEntidad()
                With oLiquidacionTMTX.oBELiquidacionTm
                    .contratoLoteId = pstrCorrelativo
                    .liquidacionId = pstrCorrelativoLiquidacion
                    '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
                    .tmh = row.Cells("tmh").Value
                    .tms = row.Cells("tms").Value
                    .tmsn = row.Cells("tmsn").Value
                    .h2o = row.Cells("h2o").Value
                    .idtablaint = row.Cells("id").Value
                    .codigoLote = row.Cells("codigo").Value
                    .PagCu = row.Cells("pagcu").Value
                    '.PagPb = row.Cells("pagpb").Value
                    '.PagZn = row.Cells("pagzn").Value
                    .PagAg = row.Cells("pagag").Value
                    .PagAu = row.Cells("pagau").Value

                    .PenAs = row.Cells("penas").Value
                    .PenSb = row.Cells("pensb").Value
                    .PenBi = row.Cells("penbi").Value
                    .PenZn = row.Cells("penzn").Value
                    .PenPb = row.Cells("penpb").Value
                    .PenHg = row.Cells("penhg").Value
                    .PenSiO2 = row.Cells("pensio2").Value
                    .Pen1 = row.Cells("pen1").Value
                    .Pen2 = row.Cells("pen2").Value
                    '.Pen3 = row.Cells("pen3").Value


                    .PenCl = row.Cells("PenCl").Value
                    .PenCd = row.Cells("PenCd").Value
                    .PenF = row.Cells("PenF").Value
                    .PenS = row.Cells("PenS").Value
                    .PenFe = row.Cells("PenFe").Value
                    .PenAl203 = row.Cells("PenAl203").Value
                    .PenCo = row.Cells("PenCo").Value
                    .PenMo = row.Cells("PenMo").Value
                    .PenP = row.Cells("PenP").Value
                    .Pen20 = row.Cells("Pen20").Value
                    .Pen21 = row.Cells("Pen21").Value
                    .Pen22 = row.Cells("Pen22").Value
                    .Pen23 = row.Cells("Pen23").Value
                    .Pen24 = row.Cells("Pen24").Value
                    .Pen25 = row.Cells("Pen25").Value
                    .Pen26 = row.Cells("Pen26").Value
                    .Pen27 = row.Cells("Pen27").Value
                    .Pen28 = row.Cells("Pen28").Value
                    .Pen29 = row.Cells("Pen29").Value
                    .Pen30 = row.Cells("Pen30").Value


                    .ticket = row.Cells("ticket").Value
                    .guia = row.Cells("guia").Value
                    If Not IsDBNull(row.Cells("ingreso").Value) Then
                        .fecha_ingreso = row.Cells("ingreso").Value
                    End If
                    .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                    .uc = pBEUsuario.tablaDetId
                    .um = pBEUsuario.tablaDetId
                    If String.IsNullOrEmpty(row.Cells("liquidacionTmId").Value.ToString) Then
                        .liquidacionTmId = ""
                        oLiquidacionTMTX.LstLiquidacionTmIns.Add(oLiquidacionTMTX.oBELiquidacionTm)
                    Else
                        If pblnCopia Or pblnNuevo Then
                            .liquidacionTmId = ""
                            oLiquidacionTMTX.LstLiquidacionTmIns.Add(oLiquidacionTMTX.oBELiquidacionTm)
                        Else
                            .liquidacionTmId = row.Cells("liquidacionTmId").Value
                            oLiquidacionTMTX.LstLiquidacionTmUpd.Add(oLiquidacionTMTX.oBELiquidacionTm)
                        End If
                    End If

                End With
            Next
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
        'If pblnNuevo Or pblnCopia Then
        Return oLiquidacionTMTX.InsertarLiquidacion + oLiquidacionTMTX.ModificarLiquidacionTm

    End Function

    Private Sub ActualizarEstadoLogistica(ByVal id As Integer, Optional ByVal contratoloteid As String = "", Optional ByVal estado As String = "", Optional ByVal liquidacionid As String = "", Optional ByVal liquidaciontmid As String = "")
        Try
            oMovimientoTX.NuevaEntidad()
            With oMovimientoTX.oBELogisticaMovimiento
                .ID = id
                .EstadoVCM = estado
                .ContratoLoteId = contratoloteid
                .LiquidacionId = liquidacionid
                .LiquidacionTmId = liquidaciontmid
                oMovimientoTX.LstLogisticaMovimiento.Add(oMovimientoTX.oBELogisticaMovimiento)
            End With
            oMovimientoTX.ActualizaEstadoLogisticaMovimiento()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ActualizarEstadoLogisticaDesasociar(ByVal piId As Long)
        oMovimientoTX.ActualizaEstadoLogisticaDesasociar(piId)
    End Sub

    Private Function Grabarliquidacion()
        Try
            With oLiquidacionTX.oBELiquidacion
                .contratoLoteId = pstrCorrelativo
                .liquidacionId = pstrCorrelativoLiquidacion
                .porcentajeMerma = nupdMerma.Value
                .pp = nupdPorcentaje.Value
                .porcentajePago = nupdPorcPago.Value
                .basepp = txtbasepart.Text
                .base1 = txtbase1.Text
                .base2 = txtbase2.Text
                .escaladorMas1 = txtbasemas1.Text
                .escaladorMas2 = txtbasemas2.Text
                .escaladorMenos1 = txtbasemenos1.Text
                .escaladorMenos2 = txtbasemenos2.Text
                .maquila = txtMaquila.Text
                .codigoIncoterm = cboIncoterm.SelectedValue
                .codigoDeposito = cboDeposito.SelectedValue
                .tasaInteres = txttasa.Text
                .tasaTiempo = txttiempo.Text
                .tasaMoratoria = txttasamora.Text
                .codigoTasa = cboModo.SelectedValue
                .codigoTrader = cboTrader.SelectedValue
                .codigoCalculo = "ACT"
                'KMN 31/08/2012
                .cargoAjuste = IIf(IsNumeric(txtAjuste.Text), txtAjuste.Text, 0)
                'KMN 31/08/2012
                .valorIgv = txtPorImpuesto.Text

                .calculoTmh = txtTMH.Text
                .calculoH2o = txtH20.Text
                .calculoTms = txtTMS.Text
                .calculoMerma = nupdMerma.Value
                .calculoTMSN = txtTMSN.Text
                .calculoCargoAjuste = IIf(IsNumeric(txtAjuste.Text), txtAjuste.Text, 0)


                .H2O = IIf(cbxHumedad.Checked, 1, 0)

                If dtPeriodo.Value.Month > 9 Then
                    .periodoComercial = dtPeriodo.Value.Year.ToString + dtPeriodo.Value.Month.ToString
                Else
                    .periodoComercial = dtPeriodo.Value.Year.ToString + "0" + dtPeriodo.Value.Month.ToString
                End If


                If cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VINCULADA.Value Or cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VENTA.Value Then

                    .periodo = dtPeriodo.Value.Year.ToString + dtPeriodo.Value.Month.ToString

                    If dtPeriodo.Value.Month > 9 Then
                        .periodo = dtPeriodo.Value.Year.ToString + dtPeriodo.Value.Month.ToString
                    Else
                        .periodo = dtPeriodo.Value.Year.ToString + "0" + dtPeriodo.Value.Month.ToString
                    End If



                    If dtpPeriodoComercial.Value.Month > 9 Then
                        .periodoComercial = dtpPeriodoComercial.Value.Year.ToString + dtpPeriodoComercial.Value.Month.ToString
                    Else
                        .periodoComercial = dtpPeriodoComercial.Value.Year.ToString + "0" + dtpPeriodoComercial.Value.Month.ToString
                    End If

                    .costoOperativo = IIf(IsNumeric(txtCostoVenta.Text), txtCostoVenta.Text, 0)


                ElseIf cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.MEZCLA.Value And dgvLiquidacionTM.Rows.Count > 0 Then
                    Dim strperiodo As String = ""
                    Dim dvwGrilla As New DataView
                    dvwGrilla = CType(dgvLiquidacionTM.DataSource, DataView)
                    For Each drow As DataRow In dvwGrilla.Table.Rows
                        If drow.RowState <> DataRowState.Deleted Then
                            strperiodo = drow("periodo")
                        End If


                        Exit For
                    Next
                    .periodo = strperiodo

                    'periodo seleccionado por el usuario
                    If cbxPeriodo.Checked Then
                        If dtPeriodo.Value.Month > 9 Then
                            .periodo = dtPeriodo.Value.Year.ToString + dtPeriodo.Value.Month.ToString
                        Else
                            .periodo = dtPeriodo.Value.Year.ToString + "0" + dtPeriodo.Value.Month.ToString
                        End If
                        cbxPeriodo.Checked = False
                    End If

                End If

                .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                .uc = pBEUsuario.tablaDetId
                .um = pBEUsuario.tablaDetId
                .codigoAdministrador = cboAdministrador.SelectedValue ' pBEUsuario.tablaDetId

                '.Ajuste = IIf(IsNumeric(txtCostoOperativo.Text), txtCostoOperativo.Text, 0)

                ''@01    A03
                '.valorPP = CDbl(txtCostoOperativo.Text)
                '.valorPPSol = CDbl(txtValorSolesPP.Text)
                '.valorTipoCambioPP = CDbl(txtTipoCambioPP.Text)

                .costoVenta = IIf(IsNumeric(txtCostoVenta.Text), txtCostoVenta.Text, 0)
                .baseRc = BaseRc.Text
                .RcMas = Rcmas.Text
                .RcMenos = Rcmenos.Text
                .RcBaseCon = RcBasecon.Text
                .ContMas = ContMas.Text
                .ContMenos = ContMenos.Text

                oLiquidacionTX.LstLiquidacion.Add(oLiquidacionTX.oBELiquidacion)
            End With
            If pblnNuevo Or pblnCopia Then
                Return oLiquidacionTX.InsertarLiquidacion
            Else
                Return oLiquidacionTX.ModificarLiquidacion
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return 0
        End Try

    End Function

    Private Function GrabarPagables()
        Try
            oPagableTX.LstValorizadorPagable.Clear()
            oPagableTX.LstValorizadorPagableIns.Clear()
            oPagableTX.LstValorizadorPagableUpd.Clear()
            For Each row As DataGridViewRow In dgvPagables.Rows
                oPagableTX.NuevaEntidad()
                With oPagableTX.oBEValorizadorPagable
                    .contratoLoteId = pstrCorrelativo
                    .liquidacionId = pstrCorrelativoLiquidacion
                    ' .liquidacionTmId = pstrCorrelativoLiquidacionTM
                    .codigoElemento = row.Cells("Elem").Value
                    .leyPagable = row.Cells("ley").Value
                    .pagable = IIf(IsDBNull(row.Cells("pag").Value), 0, row.Cells("pag").Value) ' row.Cells("pag").Value KMN 04/09/2012
                    .codigoDeduccion = row.Cells("dgvTipo").Value.ToString
                    .deduccion = IIf(IsDBNull(row.Cells("ded").Value), 0, row.Cells("ded").Value) 'row.Cells("ded").Value KMN 04/09/2012
                    .proteccion = IIf(IsDBNull(row.Cells("prot").Value), 0, row.Cells("prot").Value) ' row.Cells("prot").Value KMN 04/09/2012
                    .refinacion = IIf(IsDBNull(row.Cells("rc").Value), 0, row.Cells("rc").Value) ' row.Cells("rc").Value KMN 04/09/2012
                    .codigoMercado = row.Cells("dgvMerc").Value.ToString
                    .codigoQpAjuste = IIf(IsDBNull(row.Cells("dgvQpAjuste").Value), "", row.Cells("dgvQpAjuste").Value) ' row.Cells("dgvQpAjuste").Value KMN 04/09/2012

                    .qpInicio = IIf(IsDBNull(row.Cells("qpInicio").Value), "01/01/1900", IIf(.codigoQpAjuste = "0000000001", "01/01/1900", row.Cells("qpInicio").Value)) ' IIf(.codigoQpAjuste = "0000000001", "01/01/1900", row.Cells("qpInicio").Value)
                    .qpFinal = IIf(IsDBNull(row.Cells("qpFinal").Value), "01/01/1900", IIf(.codigoQpAjuste = "0000000001", "01/01/1900", row.Cells("qpFinal").Value)) 'IIf(.codigoQpAjuste = "0000000001", "01/01/1900", row.Cells("qpFinal").Value)
                    .leymax = IIf(IsDBNull(row.Cells("leymax").Value), 0, row.Cells("leymax").Value) ' row.Cells("leymax").Value KMN 04/09/2012
                    .leymin = IIf(IsDBNull(row.Cells("leymin").Value), 0, row.Cells("leymin").Value) ' row.Cells("leymin").Value KMN 04/09/2012
                    .contenidoPagable = IIf(IsDBNull(row.Cells("contenido").Value), 0, row.Cells("contenido").Value) ' row.Cells("contenido").Value KMN 04/09/2012
                    .protCont = IIf(IsDBNull(row.Cells("ProtCont").Value), 0, row.Cells("ProtCont").Value)
                    .codigoQp = IIf(IsDBNull(row.Cells("dgvQP").Value), "", row.Cells("dgvQP").Value) ' row.Cells("dgvQP").Value KMN 04/09/2012
                    .precio = IIf(IsDBNull(row.Cells("precio").Value), 0, row.Cells("precio").Value) 'row.Cells("precio").Value KMN 04/09/2012
                    '.cuota = dtCuota.Value
                    .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                    .uc = pBEUsuario.tablaDetId
                    .um = pBEUsuario.tablaDetId

                    If IsDBNull(row.Cells("FinLey").Value) Then
                        .finLey = "0"
                    Else
                        .finLey = IIf((row.Cells("FinLey").Value), "1", "0")
                    End If

                    If IsDBNull(row.Cells("FinPrecio").Value) Then
                        .finPrecio = "0"
                    Else
                        .finPrecio = IIf((clsUT_Funcion.DbValueToNullable(Of Double)(row.Cells("FinPrecio").Value).GetValueOrDefault), "1", "0")
                    End If


                    'KMN 09/09/2012 -- cuando es sulfuro u oxido el precio debe ser ingresado por el usuario siempre, no se debe tomar el del precio base
                    If cboClase.SelectedValue = "0000000004" Or cboClase.SelectedValue = "0000000005" Then
                        If UCase(row.Cells("Elem").Value) = UCase(cboProducto.SelectedValue) Then
                            .finPrecio = "1"
                        End If
                    End If

                    '********************************************************************************************************
                    'validacion de OXIDO
                    If cboClase.SelectedValue = "0000000004" Or cboClase.SelectedValue = "0000000005" Then
                        .deduccion = 0
                        .proteccion = 0
                        .refinacion = 0
                    End If

                    '*********************************************************************************************************

                    If String.IsNullOrEmpty(row.Cells("liquidacionpagable").Value) Then
                        .liquidacionPagable = "" ' ObtenerCorrelativoPagable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                        oPagableTX.LstValorizadorPagableIns.Add(oPagableTX.oBEValorizadorPagable)
                    Else
                        If pblnCopia Or pblnNuevo Then
                            .liquidacionPagable = "" ' ObtenerCorrelativoPagable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                            oPagableTX.oBEValorizadorPagableIns = oPagableTX.oBEValorizadorPagable
                            oPagableTX.LstValorizadorPagableIns.Add(oPagableTX.oBEValorizadorPagableIns)
                        Else
                            .liquidacionPagable = row.Cells("liquidacionpagable").Value
                            oPagableTX.oBEValorizadorPagableUpd = oPagableTX.oBEValorizadorPagable
                            oPagableTX.LstValorizadorPagableUpd.Add(oPagableTX.oBEValorizadorPagableUpd)

                        End If
                    End If

                End With
            Next

            Return oPagableTX.InsertarPagable + oPagableTX.ModificarPagable
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return 0
        End Try
    End Function

    Private Function GrabarPenalizables()
        Try
            For Each row As DataGridViewRow In dgvPenalizable.Rows
                oPenalizableTX.NuevaEntidad()
                With oPenalizableTX.oBEValorizadorPenalizable
                    .contratoLoteId = pstrCorrelativo
                    .liquidacionId = pstrCorrelativoLiquidacion

                    .codigoElemento = row.Cells("ElemP").Value

                    If row.Cells("leyp").Value.ToString = "" Then .leyPenalizable = 0 Else .leyPenalizable = row.Cells("leyp").Value
                    If row.Cells("min").Value.ToString = "" Then .minimo = 0 Else .minimo = row.Cells("min").Value
                    If row.Cells("max").Value.ToString = "" Then .maximo = 0 Else .maximo = row.Cells("max").Value
                    If row.Cells("unid").Value.ToString = "" Then .unidadPenalizable = 0 Else .unidadPenalizable = row.Cells("unid").Value
                    If row.Cells("pen").Value.ToString = "" Then .penalidad = 0 Else .penalidad = row.Cells("pen").Value

                    If row.Cells("indley").Value.ToString = "" Then row.Cells("indley").Value = False

                    .indLey = IIf((row.Cells("indley").Value), "1", "0")
                    .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                    .uc = pBEUsuario.tablaDetId
                    .um = pBEUsuario.tablaDetId
                    If String.IsNullOrEmpty(row.Cells("liquidacionPenalizableId").Value) Then
                        .liquidacionPenalizableId = "" 'ObtenerCorrelativoPenalizable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                        oPenalizableTX.LstValorizadorPenalizableIns.Add(oPenalizableTX.oBEValorizadorPenalizable)
                    Else
                        If pblnCopia Or pblnNuevo Then
                            .liquidacionPenalizableId = "" ' ObtenerCorrelativoPenalizable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                            oPenalizableTX.LstValorizadorPenalizableIns.Add(oPenalizableTX.oBEValorizadorPenalizable)
                        Else
                            .liquidacionPenalizableId = row.Cells("liquidacionPenalizableId").Value
                            oPenalizableTX.LstValorizadorPenalizableUpd.Add(oPenalizableTX.oBEValorizadorPenalizable)
                        End If

                    End If
                End With
            Next
            Return oPenalizableTX.InsertarPenalizable + oPenalizableTX.ModificarPenalizable

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return 0
        End Try
    End Function

    Private Function GrabarAjustes()
        Try
            If cboTipo.SelectedValue <> "P" Then

                For Each row As DataGridViewRow In dgvAjustes.Rows
                    oLiquidacionDsctoTX.NuevaEntidad()
                    With oLiquidacionDsctoTX.oBELiquidacionDscto
                        .contratoLoteId = pstrCorrelativo
                        .liquidacionId = pstrCorrelativoLiquidacion
                        '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
                        .codigoDscto = row.Cells("codigoDscto").Value
                        .descri = row.Cells("descriDscto").Value
                        If row.Cells("importeDscto").Value.ToString() = "" Then
                            .importe = 0
                        Else
                            .importe = row.Cells("importeDscto").Value.ToString()
                        End If

                        .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                        .uc = pBEUsuario.tablaDetId
                        .um = pBEUsuario.tablaDetId
                        .observa = row.Cells("observa").Value.ToString()

                        If String.IsNullOrEmpty(row.Cells("liquidacionDsctoId").Value.ToString) Then
                            .liquidacionDsctoId = ""
                            oLiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)
                        Else
                            If pblnCopia Then
                                .liquidacionDsctoId = ""
                                oLiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)
                            Else
                                .liquidacionDsctoId = row.Cells("liquidacionDsctoId").Value
                                oLiquidacionDsctoTX.LstLiquidacionDsctoUpd.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)
                            End If
                        End If

                    End With
                Next
            End If
            Return oLiquidacionDsctoTX.InsertarDscto + oLiquidacionDsctoTX.ModificarDscto

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return 0
        End Try

    End Function

    Private Function GrabarServicios()
        Try
            For Each row As DataGridViewRow In dgvServicios.Rows
                oLiquidacionServicioTX.NuevaEntidad()
                With oLiquidacionServicioTX.oBELiquidacionServicio
                    .contratoLoteId = pstrCorrelativo
                    .liquidacionId = pstrCorrelativoLiquidacion
                    .codigoServicio = row.Cells("codigoServicio").Value
                    .descri = row.Cells("descriServicio").EditedFormattedValue
                    .importe = row.Cells("importeServicio").Value
                    .codigoCalculoServicio = row.Cells("dgvCalculoServicio").Value
                    .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                    .uc = pBEUsuario.tablaDetId
                    .um = pBEUsuario.tablaDetId

                    If IsDBNull(row.Cells("indservicio").Value) Then
                        .indservicio = "0"
                    ElseIf row.Cells("indservicio").Value = "" Then
                        .indservicio = "0"
                    ElseIf row.Cells("indservicio").Value = " " Then
                        .indservicio = "0"
                    Else
                        .indservicio = IIf((row.Cells("indservicio").Value), "1", "0")
                    End If


                    If String.IsNullOrEmpty(row.Cells("liquidacionServicioId").Value.ToString) Then
                        .liquidacionServicioId = ""
                        oLiquidacionServicioTX.LstLiquidacionservicioIns.Add(oLiquidacionServicioTX.oBELiquidacionServicio)
                    Else
                        If pblnCopia Then
                            .liquidacionServicioId = ""
                            oLiquidacionServicioTX.LstLiquidacionservicioIns.Add(oLiquidacionServicioTX.oBELiquidacionServicio)
                        Else
                            .liquidacionServicioId = row.Cells("liquidacionServicioId").Value
                            oLiquidacionServicioTX.LstLiquidacionservicioUpd.Add(oLiquidacionServicioTX.oBELiquidacionServicio)
                        End If
                    End If
                End With
            Next
            Return oLiquidacionServicioTX.Insertarservicio + oLiquidacionServicioTX.Modificarservicio

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return 0
        End Try
    End Function

    Private Function ValidarLote(Optional ByVal sTipoValidacion As String = "")

        Dim strmensaje As String = ""
        Try
            If txtNumeroLote.Text = "" Then
                strmensaje = strmensaje & "* Debe ingresar Numero de Lote" & vbCrLf
            End If

            If cboTipo.SelectedIndex < 0 Then
                strmensaje = strmensaje & "* Seleccione Tipo de Lote" & vbCrLf

            End If

            If cboProducto.SelectedIndex <= 0 Then
                strmensaje = strmensaje & "* Seleccione Producto" & vbCrLf

            End If
            If cboEmpresa.SelectedIndex <= 0 Then
                strmensaje = strmensaje & "* Seleccione Empresa" & vbCrLf

            End If
            If cboSocio.SelectedIndex < 0 Then
                strmensaje = strmensaje & "* Seleccione Socio de Negocio" & vbCrLf

            End If
            If String.IsNullOrEmpty(txtNumero.Text) Then
                strmensaje = strmensaje & "* Ingrese Numero de Contrato" & vbCrLf
                resaltarobjecto(txtNumero)
            End If
            If cboAdministrador.SelectedIndex < 0 Then
                strmensaje = strmensaje & "* Seleccione Administrador" & vbCrLf
            End If
            If cboTrader.SelectedIndex < 0 Then
                strmensaje = strmensaje & "* Seleccione Trader" & vbCrLf
            End If

            If pblnNuevo Or pblnCopia Then
                If Not String.IsNullOrEmpty(txtNumeroLote.Text) Then
                    oContratoLoteRO.oBEContratoLote.codigoTabla = "LOT"
                    oContratoLoteRO.oBEContratoLote.lote = txtNumeroLote.Text
                    oContratoLoteRO.VerificarNumeroLote()
                    If oContratoLoteRO.oBEContratoLote.contratoLoteId <> "" Then
                        strmensaje = strmensaje & "* Numero ya asignado al Lote : " & oContratoLoteRO.oBEContratoLote.contratoLoteId & vbCrLf
                        resaltarobjecto(txtNumeroLote)
                    End If
                End If

            End If
            If dvwPagable IsNot Nothing Then

                If dvwPagable.Table.Rows.Count <= 0 Then
                    strmensaje = strmensaje & "* Contrato Seleccionado no tiene Pagables" & vbCrLf
                End If
            Else
                strmensaje = strmensaje & "* Contrato Seleccionado no tiene Pagables" & vbCrLf
            End If

            '=============================================================================================================================
            Dim oBC_TablaDetRO As New clsBC_TablaDetRO

            'LOTE CERRADO
            'If sLOTE_CERRADO = "C" Then
            If cbxLOTE_CERRADO.Checked = True Then
                'MsgBox("No puede generar liquidación, el lote esta CERRADO", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                strmensaje = strmensaje & "* No puede modificar el lote , porque se encuentra CERRADO. " + Chr(10) & "(2 meses posterior a la FINAL)" & vbCrLf
            End If

            'ASO: asociar
            'DES: desasociar
            Select Case sTipoValidacion
                Case "ASO", "DES"
                    'LIQUIDACIONES EN PERIODOS CERRADOS
                    For i = 0 To dtLiquidacion.Rows.Count - 1
                        oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
                        oBC_TablaDetRO.oBETablaDet.tablaId = IIf(cboTipo.SelectedValue = "V", cboSocio.SelectedValue, cboEmpresa.SelectedValue)
                        oBC_TablaDetRO.oBETablaDet.tablaDetId = IIf(cboTipo.SelectedValue = "V", cboSocio.SelectedValue, cboEmpresa.SelectedValue)
                        oBC_TablaDetRO.oBETablaDet.campo6 = dtLiquidacion.Rows(i)("fechaRegistro").ToString.Substring(6, 4) & dtLiquidacion.Rows(i)("fechaRegistro").ToString.Substring(3, 2) 'dtLiquidacion.Rows(i)("fechaRegistro").ToString  .CellValue(i).Year.ToString + Microsoft.VisualBasic.Right("0" + dtLiquidacion.Columns("fechaRegistro").CellValue(i).Month.ToString, 2)
                        oBC_TablaDetRO.LeerListaToDSEstadoPeriodos()
                        If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows.Count > 0 Then
                            If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(0)("Int_flagDeclara").ToString = "1" Then
                                strmensaje = strmensaje & "* No puede asociar y/o desasociar rumas, porque el lote está DECLARADO en el período: " + dtLiquidacion.Rows(i)("fechaRegistro").ToString.Substring(6, 4) & "-" & dtLiquidacion.Rows(i)("fechaRegistro").ToString.Substring(3, 2) & vbCrLf '+ " está CERRADO" ', MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                                Exit For
                            End If
                        End If
                    Next
            End Select
            '=============================================================================================================================

            Select Case sTipoValidacion
                Case "ASO", "LIQ"

                    'VIGENCIA CONTRATO
                    Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
                    oBC_ContratoLoteRO.oBEContratoLote = New clsBE_ContratoLote
                    oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento = cboTipo.SelectedValue
                    oBC_ContratoLoteRO.oBEContratoLote.contrato = txtNumero.Text.TrimEnd
                    oBC_ContratoLoteRO.oBEContratoLote.codigoTabla = "CON"
                    oBC_ContratoLoteRO.oBEContratoLote.lote = ""
                    oBC_ContratoLoteRO.VerificarNumeroLote()

                    If oBC_ContratoLoteRO.oBEContratoLote.VigenciaFin < Date.Now Then
                        MsgBox("El contrato esta vencido, debe regularizar la fecha de vigencia", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                    End If


                    If oBC_ContratoLoteRO.oBEContratoLote.estado_con <> "1" And sTipoValidacion = "LIQ" Then
                        'MsgBox(oBC_ContratoLoteRO.oBEContratoLote.mensaje_con, MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                        strmensaje = strmensaje & oBC_ContratoLoteRO.oBEContratoLote.mensaje_con
                    End If
            End Select

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

    Private Shared Sub resaltarobjecto(ByVal txt As TextBox)
        If txt.BackColor <> Color.Orange Then
            txt.BackColor = Color.Khaki
        Else
            txt.BackColor = Color.White
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal cbo As ComboBox)
        If cbo.BackColor <> Color.Orange Then
            cbo.BackColor = Color.Khaki
        Else
            cbo.BackColor = Color.White
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal nupd As NumericUpDown)
        If nupd.BackColor <> Color.Orange Then
            nupd.BackColor = Color.Khaki
        Else
            nupd.BackColor = Color.White
        End If
    End Sub
    Private Sub ResaltarTodo()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is GroupBox Then
                For Each ctrl2 In ctrl.Controls
                    If TypeOf ctrl2 Is TextBox Or TypeOf ctrl2 Is ComboBox Or TypeOf ctrl2 Is NumericUpDown Then
                        ctrl2.BackColor = Color.White
                    End If
                Next
            End If
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is ComboBox Or TypeOf ctrl Is NumericUpDown Then
                ctrl.BackColor = Color.White
            End If
        Next
    End Sub


#Region "Eventos de Controles"

    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try

            ' Dim periodoFinal As String
            '@05    AINI
            If cboTipo.SelectedValue = "B" Or cboTipo.SelectedValue = "S" Or cboTipo.SelectedValue = "V" Then
                Dim periodoNuevo As String = dtPeriodo.Value.Year.ToString & Microsoft.VisualBasic.Right("0" & dtPeriodo.Value.Month.ToString, 2)
                Dim msg As String = ""

                Dim p As New clsBC_PeriodoRO
                If Not periodoNuevo = oLiquidacionRO.oBELiquidacion.periodo Then

                    If p.ValidaPeriodoCerrado(cboEmpresa.SelectedValue, oLiquidacionRO.oBELiquidacion.periodo) And Not pblnCopia Then
                        'If p.ValidaPeriodoCerrado(cboEmpresa.SelectedValue, periodoFinal) Then
                        ' Periodo Actual cerrado, mostramos mensaje
                        MsgBox("No se puede editar periodo actual [" & oLiquidacionRO.oBELiquidacion.periodo & "] dado que esta cerrado.", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                        Exit Sub
                        '@06    AINI
                    Else
                        ' Periodo actual no cerrado, verificamos condicion de periodo nuevo
                        If p.ValidaPeriodoCerrado(cboEmpresa.SelectedValue, periodoNuevo) Then
                            MsgBox("No se puede cambiar a este periodo [" & periodoNuevo & "] dado que esta cerrado.", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                            Exit Sub
                        End If
                        '@06    AFIN
                    End If

                ElseIf pblnCopia Then

                    ' Periodo actual no cerrado, verificamos condicion de periodo nuevo
                    If p.ValidaPeriodoCerrado(cboEmpresa.SelectedValue, periodoNuevo) Then
                        MsgBox("No se puede cambiar a este periodo [" & periodoNuevo & "] dado que esta cerrado.", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                        Exit Sub
                    End If

                End If

                ' Valida que periodo de Blend no sea mayor a Venta
                If p.ValidaPeriodoMezcla(txtCorrelativo.Text, cboTipo.SelectedValue, periodoNuevo) Then
                    If cboTipo.SelectedValue = "B" Then msg = "El periodo del Blend no puede ser mayor al periodo del Lote de Venta Asociado"
                    If cboTipo.SelectedValue = "S" Then msg = "El periodo de Venta no puede ser menor al periodo de Lote Blend Asociado"
                    MsgBox(msg, MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                    Exit Sub
                End If


            End If
            '@05    AFIN

            '@01    A01
            ''If cboTipo.SelectedValue = "P" And Not ValidarValoresPP() Then Exit Sub

            ' ResaltarTodo()

            'valida OXIDO
            If cboClase.SelectedValue = "0000000004" Or cboClase.SelectedValue = "0000000005" Then
                txtMaquila.Text = 0
            End If

            txtNumero.Focus()
            ResumenGeneral()

            If Not ValidarLote() Then Exit Sub
            If Not ValidarLiquidacion() Then Exit Sub

            Me.Cursor = Cursors.AppStarting
            txtNumeroLote.Focus()

            If pAccionFormulario = "" Then
                pAccionFormulario = "MLT"
            End If
            Grabacion()

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    ' ''@01    AINI
    ''Private Function ValidarValoresPP() As Boolean
    ''    Dim validacion = True
    ''    Dim message = ""
    ''    Dim nTrioPP = 0
    ''    Dim oBC_TablaDetRO As New clsBC_TablaDetRO

    ''    Dim oBE_TablaDet As New clsBE_TablaDet
    ''    oBE_TablaDet.tablaDetId = cboClase.SelectedValue
    ''    oBE_TablaDet.tablaId = "Clase"
    ''    oBC_TablaDetRO.oBETablaDet = oBE_TablaDet

    ''    oBC_TablaDetRO.LeerTablaDet()

    ''    If Not oBC_TablaDetRO.oBETablaDet.campo0 = "PP" Then
    ''        Return validacion
    ''    End If

    ''    If Not CDbl(txtCostoOperativo.Text) = 0.0 Then nTrioPP += 1
    ''    If Not CDbl(txtTipoCambioPP.Text) = 0.0 Then nTrioPP += 1
    ''    If Not CDbl(txtValorSolesPP.Text) = 0.0 Then nTrioPP += 1

    ''    If Not nTrioPP = 3 And Not nTrioPP = 0 Then
    ''        validacion = False
    ''        message += Chr(10) & "Ingrese los 3 campos [PP (Prod.Prop.)] , [Tipo cambio] y [PP (Soles)] o no ingrese ninguno."
    ''    End If

    ''    'If Not (RoundDown(RoundUp(CDbl(txtProduccionPropia.Text), 2) * RoundUp(CDbl(txtTipoCambioPP.Text), 2), 2) = RoundDown(CDbl(txtValorSolesPP.Text), 2)) And nTrioPP = 3 Then
    ''    '    validacion = False
    ''    '    message += Chr(10) & "El valor de [PP (Soles)] debe ser igual al producto entre [Tipo cambio] y [PP (Prod.Prop.)]"
    ''    'End If

    ''    If Not message = String.Empty Then
    ''        MsgBox(message, MsgBoxStyle.Exclamation, "Valorizador de Minerales")
    ''    End If

    ''    Return validacion
    ''End Function
    ' ''@01    AFIN

    Private Sub Grabacion()
        Try
            If GrabarRegistro() Then

                If pblnNuevo Then pblnNuevo = False

                pblnCopia = False

                RecargarForm()

                ResumenGeneral()

            End If

            pAccionFormulario = ""
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub RecargarForm()
        Try
            oContratoLoteTX = New clsBC_ContratoLoteTX
            oLiquidacionTX = New clsBC_LiquidacionTX
            oPagableTX = New clsBC_ValorizadorPagableTX
            oPenalizableTX = New clsBC_ValorizadorPenalizableTX
            oMovimientoTX = New clsBC_LogisticaMovimientoTX
            oLiquidacionServicioTX = New clsBC_LiquidacionServicioTX
            oLiquidacionDsctoTX = New clsBC_LiquidacionDsctoTX
            oLiquidacionTMTX = New clsBC_LiquidacionTmTX


            '*****************************************************************
            'Auditoria
            oContratoLoteTX.oBE_AuditoriaD = New clsBE_AuditoriaD
            oContratoLoteTX.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria
            oContratoLoteTX.oBE_AuditoriaD.IdMenu = "Edit Lote"

            oMovimientoTX.oBE_AuditoriaD = New clsBE_AuditoriaD
            oMovimientoTX.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria
            oMovimientoTX.oBE_AuditoriaD.IdMenu = "Edit Lote"
            '*****************************************************************


            dtPagable.Rows.Clear()
            dtPagable.Rows.Clear()
            dtPenalizable.Rows.Clear()
            'Me.Text = "Editando Lote-Administrador : " & pstrAdministrador
            ObtenerLote(pstrCorrelativo)
            Me.Text = "Editando Lote : " & cboTipo.Text & txtNumero.Text & "/" & txtNumeroLote.Text
            pstrCorrelativoLiquidacion = "0000000001"
            pstrCorrelativoLiquidacionTM = "0000000001"
            ObtenerLiquidacion(pstrCorrelativo)
            ObtenerLiquidacionDscto(pstrCorrelativo)
            ObtenerLiquidacionServicio(pstrCorrelativo)
            ObtenerLiquidacionTotal(pstrCorrelativo)
            ObtenerLiquidacionTM(pstrCorrelativo)
            ObtenerPagables(pstrCorrelativo)
            ObtenerPenalizables(pstrCorrelativo)
            btnContrato.Enabled = False
            'txtNumeroLote.ReadOnly = True
            cboSocio.Enabled = False
            cboCalidad.Enabled = True
            cboTrader.Enabled = False
            cboAdministrador.Enabled = False
            cboClase.Enabled = False
            'btnTrader.Enabled = False
            'dgvLiquidacion2.Columns("liquidacionID").Visible = False
            ValidarTipoMovimiento()
            tsbLiquidacion.Visible = True
            oLiquidacionTMTX.LstLiquidacionTm.Clear()
            oLiquidacionTMTX.LstLiquidacionTmDel.Clear()
            oLiquidacionTMTX.LstLiquidacionTmIns.Clear()
            oLiquidacionTMTX.LstLiquidacionTmUpd.Clear()
            oLiquidacionServicioTX.LstLiquidacionServicio.Clear()
            oLiquidacionServicioTX.LstLiquidacionservicioDel.Clear()
            oLiquidacionServicioTX.LstLiquidacionservicioIns.Clear()
            oLiquidacionServicioTX.LstLiquidacionservicioUpd.Clear()
            oLiquidacionDsctoTX.LstLiquidacionDscto.Clear()
            oLiquidacionDsctoTX.LstLiquidacionDsctoDel.Clear()
            oLiquidacionDsctoTX.LstLiquidacionDsctoIns.Clear()
            oLiquidacionDsctoTX.LstLiquidacionDsctoUpd.Clear()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Try
            'Actualizar los cambios hechos en la base de datos intermedia
            oMovimientoTX.ActualizaEstadoBtnCancelar(txtCorrelativo.Text, "0000000001") ' siempre es el actual
            pblnRetornaLotes = True
            If dgvLiquidacionTM.Rows.Count > 0 Then
                For Each row As DataGridViewRow In dgvLiquidacionTM.Rows
                    Dim id As String = dgvLiquidacionTM.Rows(row.Index).Cells("id").Value
                    Dim liquidaciontmid As String = dgvLiquidacionTM.Rows(row.Index).Cells("liquidaciontmid").Value


                    If String.IsNullOrEmpty(liquidaciontmid) Then
                        ActualizarEstadoLogistica(id)
                        oMovimientoTX.ActualizaEstadoLogisticaMovimiento()
                    End If
                Next

            End If
            Me.Dispose()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub CerrarFormulario()
        Try
            Dim blnCancelar As Boolean
            Dim oMovimientoTX As New clsBC_LogisticaMovimientoTX
            If pblnNuevo And dgvLiquidacionTM.Rows.Count > 0 Then blnCancelar = True
            If pblnNuevo And dgvAjustes.Rows.Count > 0 Then blnCancelar = True
            If pblnNuevo And dgvPagables.Rows.Count > 0 Then blnCancelar = True
            If pblnNuevo And dgvPenalizable.Rows.Count > 0 Then blnCancelar = True
            If blnCancelar Then
                If MsgBox("Esta seguro de cancelar el registro del lote", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For Each row As DataGridViewRow In dgvLiquidacionTM.Rows
                        oMovimientoTX.NuevaEntidad()
                        With oMovimientoTX.oBELogisticaMovimiento
                            .ID = row.Cells("id").Value
                            .EstadoVCM = ""
                            .ContratoLoteId = ""
                            oMovimientoTX.LstLogisticaMovimiento.Add(oMovimientoTX.oBELogisticaMovimiento)
                        End With
                    Next
                    oMovimientoTX.ActualizaEstadoLogisticaMovimiento()
                    Me.Dispose()
                End If
            Else
                Me.Dispose()
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbCancelarPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EditandoPenalizables()
    End Sub

    Private Sub tsbCancelarPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EditandoPagables()
    End Sub
#End Region

#Region "ContratoLote"

#End Region
#Region "Liquidacion"
    Private Function ValidarLiquidacion()
        Dim strmensaje As String = ""
        If nupdMerma.Value < 0 Then
            strmensaje = strmensaje & "* Ingrese Merma" & vbCrLf
            resaltarobjecto(nupdMerma)
        End If
        If nupdPorcentaje.Value < 0 Then
            strmensaje = strmensaje & "* Ingrese Porcentaje " & vbCrLf
            resaltarobjecto(nupdPorcentaje)
        End If
        If nupdPorcPago.Value < 0 Then
            strmensaje = strmensaje & "* Ingrese Porcentaje de Pago" & vbCrLf
            resaltarobjecto(nupdPorcPago)
        End If

        If String.IsNullOrEmpty(txtMaquila.Text) Then
            strmensaje = strmensaje & "* Ingrese Maquila" & vbCrLf
            resaltarobjecto(txtMaquila)
        End If
        If String.IsNullOrEmpty(txtbasepart.Text) Then
            strmensaje = strmensaje & "* Ingrese Base Participacion" & vbCrLf
            resaltarobjecto(txtbasepart)
        End If
        If String.IsNullOrEmpty(txtbase1.Text) Then
            strmensaje = strmensaje & "* Ingrese Base 1" & vbCrLf
            resaltarobjecto(txtbase1)
        End If
        If String.IsNullOrEmpty(txtbase2.Text) Then
            strmensaje = strmensaje & "* Ingrese Base 2" & vbCrLf
            resaltarobjecto(txtbase2)

        End If


        If String.IsNullOrEmpty(cboTrader.Text) Then
            strmensaje = strmensaje & "* Trader & vbCrLf"
            resaltarobjecto(cboTrader)

        End If


        If String.IsNullOrEmpty(cboAdministrador.Text) Then
            'strmensaje = strmensaje & "* Trader & vbCrLf"
            'resaltarobjecto(cboTrader)
            cboAdministrador.SelectedValue = pBEUsuario.tablaDetId
        End If


        If strmensaje.Length > 0 Then
            MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
            Return False
        End If
        Return True
    End Function
#End Region
#Region "Pagable"
    Private Sub EditandoPagables()
        Try
            lblneditandoPagable = Not lblneditandoPagable
            gpocontrato.Enabled = Not lblneditandoPagable
            gpocompania.Enabled = Not lblneditandoPagable
            gpoparticipacion.Enabled = Not lblneditandoPagable
            gpofacturacion.Enabled = Not lblneditandoPagable
            gpoparticipacion.Enabled = Not lblneditandoPagable
            gpomercaderia.Enabled = Not lblneditandoPagable
            'gpoterminos.Enabled = Not lblneditandoPagable
            gpoescalador.Enabled = Not lblneditandoPagable
            msMenu.Enabled = Not lblneditandoPagable
            tsMenu.Enabled = Not lblneditandoPagable

            gpopenalizable.Enabled = Not lblneditandoPagable
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

#End Region
#Region "Penalizable"
    Private Sub EditandoPenalizables()
        Try
            lblneditandoPenalizable = Not lblneditandoPenalizable
            gpocontrato.Enabled = Not lblneditandoPenalizable
            gpocompania.Enabled = Not lblneditandoPenalizable
            gpoparticipacion.Enabled = Not lblneditandoPenalizable
            gpofacturacion.Enabled = Not lblneditandoPenalizable
            gpoparticipacion.Enabled = Not lblneditandoPenalizable
            gpomercaderia.Enabled = Not lblneditandoPenalizable
            'gpoterminos.Enabled = Not lblneditandoPenalizable
            gpoescalador.Enabled = Not lblneditandoPenalizable
            msMenu.Enabled = Not lblneditandoPenalizable
            tsMenu.Enabled = Not lblneditandoPenalizable

            gpopagable.Enabled = Not lblneditandoPenalizable
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

#End Region



    Private Sub nupdPorcentaje_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        nupdPorcentaje.Select(0, nupdPorcentaje.Text.Length)
    End Sub
    Private Sub nupdPorcPago_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        nupdPorcPago.Select(0, nupdPorcPago.Text.Length)
    End Sub

    Private Sub txbGenerarLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarFormularioLiquidacion(pstrCorrelativo)
    End Sub

    Private Sub tsbAsociarTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAsociarTM.Click
        Try
            If String.IsNullOrEmpty(txtNumero.Text) Then
                MsgBox("Antes de asociar Rumas, primero debe asociar el lote a un Contrato", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Else

                If Not ValidarLote("ASO") Then Exit Sub

                'oLogisticaMovimientoRO.LstLogisticaMovimiento

                Dim DepositoSLC As String

                If cboDeposito.SelectedIndex >= 0 Then
                    DepositoSLC = cboDeposito.SelectedValue 'CType(cboDeposito.SelectedItem, clsBE_General).Codigo_Retorna
                Else
                    DepositoSLC = ""
                End If

                'KMN 16/10/2012
                Dim sLoteOrigen As String = ""
                If cboTipo.Text = "V" Then
                    sLoteOrigen = txtContratoLoteVenta.Text
                Else
                    If dgvLiquidacionTM.RowCount > 0 Then
                        If cboTipo.Text = "V" Then
                        Else
                            sLoteOrigen = dgvLiquidacionTM.Item("LOTE_ORIGEN", 0).Value.ToString
                        End If

                    End If
                End If


                Dim lFormulario As New frmIntermedia
                MostrarFormularioAsociacion(lFormulario, pstrCorrelativo, pstrCorrelativoLiquidacion, pstrCorrelativoLiquidacionTM, nupdMerma.Value, dtLiquidacionTM, cboTipo.SelectedValue, cboProducto.SelectedValue, cboSocio.SelectedValue, cboEmpresa.SelectedValue, DepositoSLC, sLoteOrigen, cboClase.SelectedValue, cboCategoria.SelectedValue)

                'KMN 31/08/2012
                'Valida que se haya seleccionado por lo menos una ruma
                If lFormulario.pAsociar Then

                    dvwLiquidacionTM = New DataView(dtLiquidacionTM)
                    dgvLiquidacionTM.AutoGenerateColumns = False
                    dgvLiquidacionTM.DataSource = dvwLiquidacionTM

                    'Inicio CJ02012017
                    If dgvPagables.Item("precio", 0).Value = 0 Then
                        ObtenerPagables(pstrCorrelativo + "C")
                    End If
                    'Fin CJ02012017
                    ResumenGeneral()

                    pAccionFormulario = "ARR"
                    tsbGuardar_Click(Nothing, Nothing)

                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    ''Private Sub CalculaLiquidacionTMTotal(ByVal dvwDataRowView As DataView)
    Private Sub CalculaLiquidacionTMTotal()
        Try
            dtLiquidacionTMTotal = oLiquidacionTMRO.DefineTablaLiquidacionTm

            Dim xTMH As Decimal
            Dim xH2O As Decimal
            Dim xTMS As Decimal
            Dim xMerma As Decimal
            Dim xTMSN As Decimal

            Dim _TMH As Decimal
            Dim _H2O As Decimal
            Dim _TMS As Decimal
            Dim _Merma As Decimal
            Dim _TMSN As Decimal

            Dim xPagCU As Decimal
            Dim xPagAG As Decimal
            Dim xPagAGoz As Decimal
            Dim xPagAU As Decimal
            Dim xPagAUoz As Decimal
            Dim xPagPB As Decimal
            Dim xPagZN As Decimal
            'Dim xPagSN As Decimal
            Dim xPagAS As Decimal
            Dim xPagSB As Decimal
            Dim xPagBI As Decimal
            Dim xPagHG As Decimal
            Dim xPagSIO2 As Decimal
            Dim xPagASSB As Decimal
            Dim xPagZNPB As Decimal

            Dim xPenCl As Decimal
            Dim xPenCd As Decimal
            Dim xPenF As Decimal
            Dim xPenS As Decimal
            Dim xPenFe As Decimal
            Dim xPenAl203 As Decimal
            Dim xPenCo As Decimal
            Dim xPenMo As Decimal
            Dim xPenP As Decimal
            Dim xPen20 As Decimal
            Dim xPen21 As Decimal
            Dim xPen22 As Decimal
            Dim xPen23 As Decimal
            Dim xPen24 As Decimal
            Dim xPen25 As Decimal
            Dim xPen26 As Decimal
            Dim xPen27 As Decimal
            Dim xPen28 As Decimal
            Dim xPen29 As Decimal
            Dim xPen30 As Decimal

            If dtLiquidacionTM Is Nothing Then

            Else
                For Each row As DataRow In dtLiquidacionTM.Rows
                    If row.RowState <> DataRowState.Deleted Then
                        _TMH = row.Item("TMH")
                        _H2O = 0

                        _TMS = Math.Round(_TMH - (_TMH * row.Item("h2o") / 100), 3)
                        '_TMS = Math.Round(_TMH - (_TMH * row.Item("h2o") / 100), 3) ' MH 01112011
                        '_TMS = Math.Round(_TMH - (_TMH * IIf(IsDBNull(row.Item("h2o")), 0, row.Item("h2o")) / 100), 3)
                        _Merma = nupdMerma.Value
                        _TMSN = _TMS - (_TMS * _Merma / 100)

                        xPagCU = xPagCU + (row.Item("PagCu") * _TMS)
                        xPagAG = xPagAG + (row.Item("PagAg") * _TMS)
                        xPagAGoz = xPagAGoz + (row.Item("PagAgOz") * _TMS)
                        xPagAU = xPagAU + (row.Item("PagAu") * _TMS)
                        xPagAUoz = xPagAUoz + (row.Item("PagAuOz") * _TMS)
                        xPagPB = xPagPB + (row.Item("PenPb") * _TMS)
                        xPagZN = xPagZN + (row.Item("PenZn") * _TMS)
                        'xPagSN = xPagSN + (row.Item("PenSn") * _TMSN)
                        xPagAS = xPagAS + (row.Item("PenAs") * _TMS)
                        xPagSB = xPagSB + (row.Item("PenSb") * _TMS)
                        xPagBI = xPagBI + (row.Item("PenBi") * _TMS)
                        xPagHG = xPagHG + (row.Item("PenHg") * _TMS)
                        xPagSIO2 = xPagSIO2 + (row.Item("PenSiO2") * _TMS)
                        xPagASSB = xPagASSB + (row.Item("Pen1") * _TMS)
                        xPagZNPB = xPagZNPB + (row.Item("Pen2") * _TMS)

                        xPenCl = xPenCl + (row.Item("PenCl") * _TMS)
                        xPenCd = xPenCd + (row.Item("PenCd") * _TMS)
                        xPenF = xPenF + (row.Item("PenF") * _TMS)
                        xPenS = xPenS + (row.Item("PenS") * _TMS)
                        xPenFe = xPenFe + (row.Item("PenFe") * _TMS)
                        xPenAl203 = xPenAl203 + (row.Item("PenAl203") * _TMS)
                        xPenCo = xPenCo + (row.Item("PenCo") * _TMS)
                        xPenMo = xPenMo + (row.Item("PenMo") * _TMS)
                        xPenP = xPenP + (row.Item("PenP") * _TMS)
                        xPen20 = xPen20 + (row.Item("Pen20") * _TMS)
                        xPen21 = xPen21 + (row.Item("Pen21") * _TMS)
                        xPen22 = xPen22 + (row.Item("Pen22") * _TMS)
                        'CJULCA - Penalizar Cu
                        ' xPen22 = xPen22 + (row.Item("PagCu") * _TMS)
                        'CJULCA  - Fin Penalizar Cu
                        xPen23 = xPen23 + (row.Item("Pen23") * _TMS)
                        xPen24 = xPen24 + (row.Item("Pen24") * _TMS)
                        xPen25 = xPen25 + (row.Item("Pen25") * _TMS)
                        xPen26 = xPen26 + (row.Item("Pen26") * _TMS)
                        xPen27 = xPen27 + (row.Item("Pen27") * _TMS)
                        xPen28 = xPen28 + (row.Item("Pen28") * _TMS)
                        xPen29 = xPen29 + (row.Item("Pen29") * _TMS)
                        xPen30 = xPen30 + (row.Item("Pen30") * _TMS)

                        xTMH = xTMH + _TMH
                        xTMS = xTMS + _TMS
                        xTMSN = xTMSN + _TMSN
                    End If

                Next

                xTMH = IIf(xTMH = 0, 1, xTMH)
                xTMS = IIf(xTMS = 0, 1, xTMS)
                xTMSN = IIf(xTMSN = 0, 1, xTMSN)

                'xH2O = IIf(xTMH = 0, 0, (xTMH - xTMS) / xTMH * 100)
                'xH2O = IIf(xTMH = 0, 0, (1 - Math.Round((xTMS / xTMH), 4)) * 100)
                xH2O = IIf(xTMH = 0, 0, Math.Round((1 - (xTMS / xTMH)) * 100, 4))

                xPagCU = IIf(xTMSN = 0, 0, xPagCU / xTMS)
                xPagAG = IIf(xTMSN = 0, 0, xPagAG / xTMS)
                xPagAGoz = IIf(xTMSN = 0, 0, xPagAGoz / xTMS)
                xPagAU = IIf(xTMSN = 0, 0, xPagAU / xTMS)
                xPagAUoz = IIf(xTMSN = 0, 0, xPagAUoz / xTMS)
                xPagPB = IIf(xTMSN = 0, 0, xPagPB / xTMS)
                xPagZN = IIf(xTMSN = 0, 0, xPagZN / xTMS)
                'xPagSN = IIf(xTMSN = 0, 0, xPagSN / xTMSN)
                xPagAS = IIf(xTMSN = 0, 0, xPagAS / xTMS)
                xPagSB = IIf(xTMSN = 0, 0, xPagSB / xTMS)
                xPagBI = IIf(xTMSN = 0, 0, xPagBI / xTMS)
                xPagHG = IIf(xTMSN = 0, 0, xPagHG / xTMS)
                xPagSIO2 = IIf(xTMSN = 0, 0, xPagSIO2 / xTMS)
                xPagASSB = IIf(xTMSN = 0, 0, xPagASSB / xTMS)
                xPagZNPB = IIf(xTMSN = 0, 0, xPagZNPB / xTMS)

                xPenCl = IIf(xTMSN = 0, 0, xPenCl / xTMS)
                xPenCd = IIf(xTMSN = 0, 0, xPenCd / xTMS)
                xPenF = IIf(xTMSN = 0, 0, xPenF / xTMS)
                xPenS = IIf(xTMSN = 0, 0, xPenS / xTMS)
                xPenFe = IIf(xTMSN = 0, 0, xPenFe / xTMS)
                xPenAl203 = IIf(xTMSN = 0, 0, xPenAl203 / xTMS)
                xPenCo = IIf(xTMSN = 0, 0, xPenCo / xTMS)
                xPenMo = IIf(xTMSN = 0, 0, xPenMo / xTMS)
                xPenP = IIf(xTMSN = 0, 0, xPenP / xTMS)
                xPen20 = IIf(xTMSN = 0, 0, xPen20 / xTMS)
                xPen21 = IIf(xTMSN = 0, 0, xPen21 / xTMS)
                xPen22 = IIf(xTMSN = 0, 0, xPen22 / xTMS)
                xPen23 = IIf(xTMSN = 0, 0, xPen23 / xTMS)
                xPen24 = IIf(xTMSN = 0, 0, xPen24 / xTMS)
                xPen25 = IIf(xTMSN = 0, 0, xPen25 / xTMS)
                xPen26 = IIf(xTMSN = 0, 0, xPen26 / xTMS)
                xPen27 = IIf(xTMSN = 0, 0, xPen27 / xTMS)
                xPen28 = IIf(xTMSN = 0, 0, xPen28 / xTMS)
                xPen29 = IIf(xTMSN = 0, 0, xPen29 / xTMS)
                xPen30 = IIf(xTMSN = 0, 0, xPen30 / xTMS)

                Dim RowTotal As DataRow
                RowTotal = dtLiquidacionTMTotal.NewRow()

                RowTotal.Item("id") = "1"
                RowTotal.Item("tmh") = xTMH.ToString
                RowTotal.Item("h2o") = xH2O.ToString
                RowTotal.Item("tms") = xTMS.ToString
                RowTotal.Item("merma") = xMerma.ToString
                RowTotal.Item("tmsn") = xTMSN.ToString

                RowTotal.Item("PagCu") = Math.Round(xPagCU, 4).ToString
                RowTotal.Item("PagAg") = Math.Round(xPagAG, 4).ToString()
                RowTotal.Item("PagAgOz") = Math.Round(xPagAGoz, 4).ToString()
                RowTotal.Item("PagAu") = Math.Round(xPagAU, 4).ToString()
                RowTotal.Item("PagAuOz") = Math.Round(xPagAUoz, 4).ToString()
                RowTotal.Item("PenPb") = Math.Round(xPagPB, 4).ToString()
                RowTotal.Item("PenZn") = Math.Round(xPagZN, 4).ToString()
                'RowTotal.Item("PenSn") = xPagSN.ToString()
                RowTotal.Item("PenAs") = Math.Round(xPagAS, 4).ToString()
                RowTotal.Item("PenSb") = Math.Round(xPagSB, 4).ToString()
                RowTotal.Item("PenBi") = Math.Round(xPagBI, 4).ToString()
                RowTotal.Item("PenHg") = Math.Round(xPagHG, 4).ToString()
                RowTotal.Item("PenSiO2") = Math.Round(xPagSIO2, 4).ToString()
                RowTotal.Item("Pen1") = Math.Round(xPagASSB, 4).ToString()
                RowTotal.Item("Pen2") = Math.Round(xPagZNPB, 4).ToString()


                RowTotal.Item("PenCl") = Math.Round(xPenCl, 4).ToString()
                RowTotal.Item("PenCd") = Math.Round(xPenCd, 4).ToString()
                RowTotal.Item("PenF") = Math.Round(xPenF, 4).ToString()
                RowTotal.Item("PenS") = Math.Round(xPenS, 4).ToString()
                RowTotal.Item("PenFe") = Math.Round(xPenFe, 4).ToString()
                RowTotal.Item("PenAl203") = Math.Round(xPenAl203, 4).ToString()
                RowTotal.Item("PenCo") = Math.Round(xPenCo, 4).ToString()
                RowTotal.Item("PenMo") = Math.Round(xPenMo, 4).ToString()
                RowTotal.Item("PenP") = Math.Round(xPenP, 4).ToString()
                RowTotal.Item("Pen20") = Math.Round(xPen20, 4).ToString()
                RowTotal.Item("Pen21") = Math.Round(xPen21, 4).ToString()
                RowTotal.Item("Pen22") = Math.Round(xPen22, 4).ToString()
                RowTotal.Item("Pen23") = Math.Round(xPen23, 4).ToString()
                RowTotal.Item("Pen24") = Math.Round(xPen24, 4).ToString()
                RowTotal.Item("Pen25") = Math.Round(xPen25, 4).ToString()
                RowTotal.Item("Pen26") = Math.Round(xPen26, 4).ToString()
                RowTotal.Item("Pen27") = Math.Round(xPen27, 4).ToString()
                RowTotal.Item("Pen28") = Math.Round(xPen28, 4).ToString()
                RowTotal.Item("Pen29") = Math.Round(xPen29, 4).ToString()
                RowTotal.Item("Pen30") = Math.Round(xPen30, 4).ToString()

                dtLiquidacionTMTotal.Rows.Add(RowTotal)

                dvwLiquidacionTMTotal = New DataView(dtLiquidacionTMTotal)
                dgvLiquidacionTMTotal.AutoGenerateColumns = False

                dgvLiquidacionTMTotal.DataSource = dvwLiquidacionTMTotal
                dgvLiquidacionTMTotal.Refresh()

                ActualizandoLeyes()
                ActualizandoPrecios()

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ActualizandoLeyes()
        Try
            If dtPagable Is Nothing Then

            Else
                For Each row As DataRow In dtPagable.Rows

                    If row.RowState.ToString = "Deleted" Then
                    Else
                        row.Item("leypagable") = IIf(row.Item("codigoelemento") = "CU" And Not IsDBNull(row.Item("indley")), dtLiquidacionTMTotal.Rows(0).Item("pagcu").ToString, IIf(IsDBNull(row.Item("leypagable")), 0, row.Item("leypagable")))
                        row.Item("leypagable") = IIf(row.Item("codigoelemento") = "PB" And Not IsDBNull(row.Item("indley")), dtLiquidacionTMTotal.Rows(0).Item("penpb").ToString, IIf(IsDBNull(row.Item("leypagable")), 0, row.Item("leypagable")))
                        row.Item("leypagable") = IIf(row.Item("codigoelemento") = "ZN" And Not IsDBNull(row.Item("indley")), dtLiquidacionTMTotal.Rows(0).Item("penzn").ToString, IIf(IsDBNull(row.Item("leypagable")), 0, row.Item("leypagable")))
                        row.Item("leypagable") = IIf(row.Item("codigoelemento") = "AG" And Not IsDBNull(row.Item("indley")), dtLiquidacionTMTotal.Rows(0).Item("pagag").ToString, IIf(IsDBNull(row.Item("leypagable")), 0, row.Item("leypagable")))
                        row.Item("leypagable") = IIf(row.Item("codigoelemento") = "AU" And Not IsDBNull(row.Item("indley")), dtLiquidacionTMTotal.Rows(0).Item("pagau").ToString, IIf(IsDBNull(row.Item("leypagable")), 0, row.Item("leypagable")))
                    End If
                Next
            End If

            If dtPenalizable Is Nothing Then

            Else

                For Each row As DataRow In dtPenalizable.Rows()

                    If row.RowState.ToString = "Deleted" Then

                    Else
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "AS", dtLiquidacionTMTotal.Rows(0).Item("penas").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "SB", dtLiquidacionTMTotal.Rows(0).Item("pensb").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "BI", dtLiquidacionTMTotal.Rows(0).Item("penbi").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "ZN", dtLiquidacionTMTotal.Rows(0).Item("penzn").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "PB", dtLiquidacionTMTotal.Rows(0).Item("penpb").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "HG", dtLiquidacionTMTotal.Rows(0).Item("penhg").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "SIO2", dtLiquidacionTMTotal.Rows(0).Item("pensio2").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "AS+SB", dtLiquidacionTMTotal.Rows(0).Item("pen1").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "ZN+PB", dtLiquidacionTMTotal.Rows(0).Item("pen2").ToString, row.Item("leypenalizable"))


                        'row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "SIO2", dtLiquidacionTMTotal.Rows(0).Item("pensio2").ToString, IIf(IsDBNull(row.Item("leypenalizable")), 0, row.Item("leypenalizable")))

                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "CL", dtLiquidacionTMTotal.Rows(0).Item("PenCl").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "CD", dtLiquidacionTMTotal.Rows(0).Item("PenCd").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "F", dtLiquidacionTMTotal.Rows(0).Item("PenF").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "S", dtLiquidacionTMTotal.Rows(0).Item("PenS").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "FE", dtLiquidacionTMTotal.Rows(0).Item("PenFe").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "AL203", dtLiquidacionTMTotal.Rows(0).Item("PenAl203").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "CO", dtLiquidacionTMTotal.Rows(0).Item("PenCo").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "MO", dtLiquidacionTMTotal.Rows(0).Item("PenMo").ToString, row.Item("leypenalizable"))
                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "P", dtLiquidacionTMTotal.Rows(0).Item("PenP").ToString, row.Item("leypenalizable"))


                        row.Item("leypenalizable") = IIf(row.Item("codigoelemento") = "H2o", dtLiquidacionTMTotal.Rows(0).Item("Pen21").ToString, row.Item("leypenalizable"))

                    End If

                Next

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ActualizandoPrecios()
        Try
            If dtPagable Is Nothing Then

            Else

                For Each row As DataRow In dtPagable.Rows
                    If row.RowState.ToString = "Deleted" Then
                    Else


                        Dim oTablaDetRO As New clsBC_TablaDetRO
                        oTablaDetRO.oBETablaDet.tablaId = "Metal"
                        oTablaDetRO.oBETablaDet.tablaDetId = row.Item("codigoelemento")
                        oTablaDetRO.LeerTablaDet()

                        If cboClase.SelectedValue = "0000000004" Or cboClase.SelectedValue = "0000000005" Then
                            'If row.Item("codigoelemento") = "CU" = cboProducto.SelectedValue Then
                            If UCase(row.Item("codigoelemento")) = UCase(cboProducto.SelectedValue) Then
                                row.Item("indpre") = "1"
                            End If
                        End If

                        If pblnNuevo Or pblnCopia Then

                            row.Item("precio") = IIf(row.Item("codigoelemento") = "CU" And IIf(IsDBNull(row.Item("indpre")), 0, row.Item("indpre")) = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                            row.Item("precio") = IIf(row.Item("codigoelemento") = "PB" And IIf(IsDBNull(row.Item("indpre")), 0, row.Item("indpre")) = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                            row.Item("precio") = IIf(row.Item("codigoelemento") = "ZN" And IIf(IsDBNull(row.Item("indpre")), 0, row.Item("indpre")) = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                            row.Item("precio") = IIf(row.Item("codigoelemento") = "AG" And IIf(IsDBNull(row.Item("indpre")), 0, row.Item("indpre")) = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                            row.Item("precio") = IIf(row.Item("codigoelemento") = "AU" And IIf(IsDBNull(row.Item("indpre")), 0, row.Item("indpre")) = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))


                        End If

                    End If
                Next
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try


    End Sub

    Private Sub ResumenGeneral()
        Try
            CalculaLiquidacionTMTotal()

            If dgvPagables.Rows.Count = 0 Then Exit Sub
            ResumenRumas()
            CalculoPagables()
            CalculoPenalizables()
            ResumenServicios()
            Dim dblBase1 As Double = txtbase1.Text
            Dim dblmas1 As Double = txtbasemas1.Text
            Dim dblmenos1 As Double = txtbasemenos1.Text
            Dim dblbase2 As Double = txtbase2.Text
            Dim dblmas2 As Double = txtbasemas2.Text
            Dim dblEscalador As Double
            Dim dblpp As Double
            Dim dblbase As Double = txtbasepart.Text
            Dim dblPorcPart As Double = nupdPorcentaje.Value
            Dim dblPagables As Double
            Dim dbltmsn As Double = txtTMSN.Text
            Dim dblValorVenta As Double
            Dim dblPrecioRef As Double


            If txtAjuste.Text = "." Or txtAjuste.Text = "-." Then
                txtAjuste.Text = "0"
            End If

            Dim dblAjuste As Double = CDbl(IIf(String.IsNullOrEmpty(txtAjuste.Text) Or txtAjuste.Text = "-", 0, txtAjuste.Text))
            Dim dblPrecioUnitario As Double
            Dim dblPorImpuesto As Double = IIf(String.IsNullOrEmpty(txtPorImpuesto.Text), 0, txtPorImpuesto.Text)
            Dim dblImpuesto As Double
            Dim dblTotal As Double
            Dim dblPorcPago As Double = nupdPorcPago.Value
            Dim dblTotalPagar As Double
            Dim dblTotalServicios As Double

            If dvwServicio IsNot Nothing Then
                'If dvwServicio.Count > 0 Then dblTotalServicios = "-" & dvwServicio.Table.Compute("Sum(importe)", "") 'txtTotalServicios.Text
                If dvwServicio.Count > 0 Then dblTotalServicios = dvwServicio.Table.Compute("Sum(importe)", "") * -1 'txtTotalServicios.Text
            End If


            Dim dblTotalAjustes As Double

            Dim dAdelantos As Double = 0
            Dim dOtrosDescuentos As Double = 0

            Try

                If dvwAjuste IsNot Nothing Then

                    dblTotalAjustes = IIf(dvwAjuste.Table.Rows.Count > 0, dvwAjuste.Table.Compute("Sum(importe)", ""), 0)
                Else
                    dblTotalAjustes = 0
                End If



                For i = 0 To dgvAjustes.RowCount - 1
                    If dgvAjustes.Item("codigoDscto", i).Value.ToString.ToUpper = "ADELANTO" Then
                        dAdelantos = dAdelantos + dgvAjustes.Item("ImporteDscto", i).Value.ToString
                    End If
                Next
                dOtrosDescuentos = dblTotalAjustes - dAdelantos

                dblTotalAjustes = dblTotalAjustes + oContratoLoteRO.oBEContratoLote.descuento + oContratoLoteRO.oBEContratoLote.detraccion

            Catch ex As Exception
                dvwAjuste = Nothing
                dblTotalAjustes = 0
            End Try

            If dvwPagable IsNot Nothing Then dblPagables = dvwPagable.Table.Compute("Sum(preciounitario)", "")
            Dim dblPenalizables As Double

            If dvwPenalizable IsNot Nothing Then
                If dvwPenalizable IsNot Nothing And dvwPenalizable.Table.Rows.Count > 0 Then
                    For Each row As DataRow In dvwPenalizable.Table.Rows
                        If row.RowState.ToString = "Deleted" Then
                        Else
                            dblPenalizables = dblPenalizables + row.Item("preciounitario")
                        End If
                    Next

                End If
            End If

            Dim dblParcial As Double
            Dim dbltotaltmsn As Double
            Dim dblneto As Double

            dblPrecio = dblPrecioEsc

            If dblPrecio < dblBase1 Then
                dblEscalador = 0
                ' dblEscalador = (dblPrecio - dblBase1) * dblmenos1
            ElseIf dblPrecio > dblBase1 And dblPrecio < dblbase2 Then
                dblEscalador = (dblPrecio - dblBase1) * dblmas1
            ElseIf dblPrecio > dblbase2 Then
                dblEscalador = (dblbase2 - dblBase1) * dblmas1 + (dblPrecio - dblbase2) * dblmas2
            ElseIf dblbase2 = 0 Then
                dblEscalador = (dblPrecio - dblBase1) * dblmas1
            End If
            dblpp = (dblPrecio - dblbase) * dblPorcPart

            'ctxtTotalServicios.Text = FormatNumber(dblTotalServicios, 2)

            dblTotalServicios = Convert.ToDouble(txtTotalServicios.Text) * -1
            ctxtTotalServicios.Text = Convert.ToDouble(txtTotalServicios.Text) * -1

            txtEscalador.Text = dblEscalador
            txtPP.Text = dblpp

            Dim dblMaquila As Double = IIf(String.IsNullOrEmpty(txtMaquila.Text), 0, txtMaquila.Text)
            dblParcial = IIf(dblMaquila > 0, "-" & dblMaquila, dblMaquila) + (dblEscalador * -1) + dblpp
            dbltotaltmsn = Math.Max(0, dblParcial + dblPagables + dblPenalizables + dblTotalServicios)


            'dbltotaltmsn = Math.Round(dbltotaltmsn, 4, MidpointRounding.AwayFromZero)
            txtTotalTMSN.Text = FormatNumber(dbltotaltmsn, 4)

            dbltotaltmsn = Math.Round(dbltotaltmsn, 3) 'FormatNumber(dbltotaltmsn, 3) ' Math.Round(dbltotaltmsn, 4)

            dblValorVenta = FormatNumber((dbltotaltmsn * dbltmsn) + dblAjuste, 2) ' Math.Round((dbltotaltmsn * dbltmsn) + dblAjuste, 2)
            'dblValorVenta = EnhancedMath.RoundDown((dbltotaltmsn * dbltmsn) + dblAjuste, 2)
            txtValor.Text = FormatNumber(dblValorVenta, 2)

            If dbltmsn > 0 Then
                dblPrecioUnitario = dblValorVenta / dbltmsn
            End If

            txtPUnitario.Text = FormatNumber(EnhancedMath.RoundDown(dblPrecioUnitario, 4), 4)

            dblImpuesto = dblValorVenta * dblPorImpuesto / 100
            txtImpuesto.Text = FormatNumber(dblImpuesto, 2)


            dblTotal = dblValorVenta + dblImpuesto
            txtTotal.Text = FormatNumber(dblTotal, 2)

            'CAMBIO A SOLICITUD DE BRUCE CORREO 18/04/2010
            'dblTotalPagar = (dblValorVenta * (dblPorcPago / 100) + dblImpuesto)

            dblTotalPagar = (dblValorVenta + dblImpuesto)


            Dim oBC_TablaDetRO As New clsBC_TablaDetRO
            oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
            oBC_TablaDetRO.oBETablaDet.tablaId = "empresa"
            oBC_TablaDetRO.LeerListaToDSTablaDet()

            Dim dPorcentajeDetraccion As Double
            For i = 0 To oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows.Count - 1
                If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(i)("tablaDetId") = cboEmpresa.SelectedValue Then
                    dPorcentajeDetraccion = oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(i)("campo7").ToString
                    Exit For
                End If
            Next
            'dPorcentajeDetraccion = (dblTotal - oContratoLoteRO.oBEContratoLote.adelanto) * (dPorcentajeDetraccion / 100)

            dPorcentajeDetraccion = (dblTotal - dAdelantos) * (dPorcentajeDetraccion / 100)


            If dPorcentajeDetraccion < oContratoLoteRO.oBEContratoLote.detraccion Then
                dPorcentajeDetraccion = oContratoLoteRO.oBEContratoLote.detraccion
            End If

            If pblnCopia Or cboCategoria.SelectedValue = "0000000002" Then  ' Si es Exportacion no tiene detraccion
                'txtNetoAPagar.Text = "0.00"
                dPorcentajeDetraccion = 0.0
            End If

            'KMN 05/03/2013
            txtAdelanto.Text = FormatNumber(dAdelantos, 2) 'FormatNumber(oContratoLoteRO.oBEContratoLote.adelanto, 2) 'FormatNumber(dblTotalPagar, 2)
            txtDescuentos.Text = FormatNumber(dOtrosDescuentos, 2) 'FormatNumber(oContratoLoteRO.oBEContratoLote.otrosDescuentos, 2) 'FormatNumber(dblTotalAjustes, 2)
            dblneto = dblTotalPagar - dblTotalAjustes
            txtDetraccion.Text = FormatNumber(dPorcentajeDetraccion, 2)


            If cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.MEZCLA.Value Then
                lblestadoliq.Text = pEstadoLiquidacion
            Else
                lblestadoliq.Text = "N/A"
            End If

            pEstadoLiquidacion = lblestadoliq.Text

            ''KMN 31/08/2012
            txtNumeroLote.Enabled = True
            ''cboClase.Enabled = True
            ''KMN 31/08/2012

            Dim sliquidacionId As String = ""

            bVisibleButtonsRumas = True
            If dtLiquidacion.Rows.Count > 0 Then

                For i = 0 To dtLiquidacion.Rows.Count - 1
                    If dtLiquidacion.Rows(i).Item("codigoCalculo").ToString = "PRV" Or dtLiquidacion.Rows(i).Item("codigoCalculo").ToString = "FIN" Then
                        'lblfechaliq.Text = dtLiquidacion.Rows(i).Item("fc")
                        lblestadoliq.Text = dtLiquidacion.Rows(i).Item("numerocalculo") & dtLiquidacion.Rows(i).Item("descri").ToString.Substring(0, 1)
                        pEstadoLiquidacion = lblestadoliq.Text
                    End If

                    'KMN 31/08/2012
                    txtNumeroLote.Enabled = False
                    cboClase.Enabled = False
                    'KMN 31/08/2012
                    'Exit For

                    If dtLiquidacion.Rows(i)("codigoCalculo") = "PRV" Or dtLiquidacion.Rows(i)("codigoCalculo") = "FIN" Or _
                        dtLiquidacion.Rows(i)("codigoCalculo") = "PRL" Or dtLiquidacion.Rows(i)("codigoCalculo") = "EST" Then
                        bVisibleButtonsRumas = False
                    End If
                Next
            End If

            tsAjuste.Visible = True

            If cboTipo.SelectedValue = "B" Then
                bVisibleButtonsRumas = True
            ElseIf cboTipo.SelectedValue = "V" Or cboTipo.SelectedValue = "S" Then

                'Valida asociacion de rumas: en caso exista PRV o FIN no se puede asociar ni desasociar
                If lblestadoliq.Text.Substring(1, 1) = "F" Then
                    bVisibleButtonsRumas = False
                Else
                    bVisibleButtonsRumas = True
                End If
            Else

                'Valida asociacion de rumas: en caso exista PRV o FIN no se puede asociar ni desasociar
                If lblestadoliq.Text.Substring(1, 1) = "F" Or lblestadoliq.Text.Substring(1, 1) = "P" Then
                    bVisibleButtonsRumas = False
                    tsAjuste.Visible = False
                Else
                    bVisibleButtonsRumas = True
                    tsAjuste.Visible = True
                End If
            End If

            tsRumas.Visible = bVisibleButtonsRumas


            If cboTipo.Text = "V" Then
                txtNumeroLote.ReadOnly = True

                'Doble vinculada - puedo crear lotes a demanda
                If txtNumero.Text.Substring(0, 1) = "V" & pblnCopia & pblnNuevo Then
                    txtNumeroLote.Enabled = True
                    txtNumeroLote.ReadOnly = False
                    btnVenta.Visible = False
                End If

            End If

            '29/01/2013
            'Valida depositos, en caso no exista ruma asociada no se puede modificar el deposito
            'solo para lotes de compra
            If cboTipo.SelectedValue = "P" Then
                If dgvLiquidacionTM.RowCount > 0 Then
                    cboDeposito.Enabled = False
                Else
                    cboDeposito.Enabled = True
                End If
            End If

            If pEstadoLiquidacion Is Nothing Or pEstadoLiquidacion = "" Or (pEstadoLiquidacion = "N/A" And dblPorcPago = 0) Then
                dblPorcPago = 100
            Else
                If pEstadoLiquidacion.Substring(1, 1) = "F" Then
                    dblPorcPago = 100
                End If
            End If

            Dim dPagados As Double = 0
            Dim sFechaCreacion As Date
            Dim sDetraccionAnterior As Double = 0

            For i = 0 To dgvDstoProvisionales.RowCount - 2

                'Cuando es lote de tipo venta, no se debe descontar las liquidaciones anteriores, los descuentos van en los adelantos
                'debido a que el valor real pagado por parte del cliente es menor al valor de la provisional
                If cboTipo.SelectedValue <> "S" Then
                    dPagados = dPagados + dgvDstoProvisionales.Item("PMontoNetoAPagar", i).Value.ToString
                End If

                sFechaCreacion = dgvDstoProvisionales.Item("Pfc", i).Value.ToString
            Next

            If sFechaCreacion <> "#12:00:00 AM#" And sFechaCreacion < "06/03/2013" Then
                dPorcentajeDetraccion = 0
            End If

            txtProvisional.Text = FormatNumber(dPagados, 2)
            'txtNetoAPagar.Text = FormatNumber(((dblValorVenta * (dblPorcPago / 100) + FormatNumber(dblImpuesto, 2) - dPorcentajeDetraccion - oContratoLoteRO.oBEContratoLote.adelanto)) - oContratoLoteRO.oBEContratoLote.otrosDescuentos, 2) 'FormatNumber(dblneto, 2)
            txtNetoAPagar.Text = FormatNumber(((dblValorVenta * (dblPorcPago / 100) + FormatNumber(dblImpuesto, 2) - dPorcentajeDetraccion - dAdelantos)) - dOtrosDescuentos - dPagados, 2) 'FormatNumber(dblneto, 2)

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub ResumenRumas()
        Try
            Dim dblTotalTMH As Double
            Dim dblTotalH2O As Double
            Dim dblTotalTMS As Double
            Dim dblTotalMerma As Double
            Dim dblTotalTMSN As Double
            If dvwLiquidacionTM IsNot Nothing Then
                If dvwLiquidacionTM.Count > 0 Then

                    dblTotalTMH = dvwLiquidacionTM.Table.Compute("Sum(tmh)", "")
                    dblTotalTMS = dvwLiquidacionTM.Table.Compute("Sum(tms)", "")
                    If dblTotalTMH = 0 Then
                        dblTotalH2O = 0
                    Else
                        dblTotalH2O = (1 - dblTotalTMS / dblTotalTMH) * 100
                    End If
                    dblTotalTMSN = Math.Round(dblTotalTMS, 3) - (dblTotalTMS * nupdMerma.Value / 100) 'dvwLiquidacionTM.Table.Compute("Sum(tmsn)", "")
                    dblTotalMerma = (1 - dblTotalTMSN / dblTotalTMS) * 100 'dvwLogisticaMovimiento.Table.Compute("Sum(tmh)", "")
                    ctxtTotalH2O.Text = FormatNumber(dblTotalH2O, 3)
                    ctxtTotalMerma.Text = FormatNumber(dblTotalMerma, 3)
                    ctxtTotalTMH.Text = FormatNumber(dblTotalTMH, 3)
                    ctxtTotalTMS.Text = FormatNumber(dblTotalTMS, 3)
                    ctxtTotalTMSN.Text = FormatNumber(dblTotalTMSN, 3)
                    txtTMH.Text = FormatNumber(dblTotalTMH, 3)
                    txtTMS.Text = FormatNumber(dblTotalTMS, 3)
                    'txtTMSN.Text = FormatNumber(Math.Round(dblTotalTMSN - 0.000049, 4), 4)
                    txtTMSN.Text = FormatNumber(dblTotalTMSN, 3)
                    txtH20.Text = FormatNumber(dblTotalH2O, 3)
                Else
                    txtTMH.Text = FormatNumber(0, 3)
                    txtTMS.Text = FormatNumber(0, 3)
                    txtTMSN.Text = FormatNumber(0, 3)
                    txtH20.Text = FormatNumber(0, 3)
                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub CargarAsociacionTM()
        Try
            'If dtLiquidacionTM Is Nothing Then
            Dim oLiquidacionTMRO As New clsBC_LiquidacionTmRO
            Dim dvwTablaIntermedia As DataView
            dtLiquidacionTM = oLiquidacionTMRO.DefineTablaLiquidacionTm ' GenericListToDataTable(oPagableTX.LstValorizadorPagableIns) 'oValorizadorPagableRO.DefinirTablaValorizadorPagable
            ' End If
            oLogisticaMovimientoRO.oBELogisticaMovimiento.ContratoLoteId = txtCorrelativo.Text
            dvwTablaIntermedia = New DataView(oLogisticaMovimientoRO.LeerListaToDSLogisticaMovimientoAsociado.Tables(0))


            dgvLiquidacionTM.AutoGenerateColumns = False
            dgvLiquidacionTM.DataSource = dvwLogisticaMovimiento
            EditarColumnasModificables(dgvLiquidacionTM, "")
            EditarColumnasModificables(dgvLiquidacionTMTotal, "")
            ResumenRumas()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbDesasociar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDesasociar.Click
        Try

            Dim oBC_LiquidacionTmRO As New clsBC_LiquidacionTmRO

            If Not ValidarLote("DES") Then Exit Sub

            If dgvLiquidacionTM.RowCount > 0 Then
                If MsgBox("Esta seguro de Eliminar los  Elementos  seleccionados", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then

                    '@02    A01
                    If Not validarDesasociacion() Then Exit Sub

                    For Each dgrow As DataGridViewRow In dgvLiquidacionTM.SelectedRows

                        If oBC_LiquidacionTmRO.BuscaLiquidacionTm_RumaLiquidada(pstrCorrelativo, dgrow.Cells("Codigo").Value) Then
                            MsgBox("No puede Desasociar dado que el lote contiene liquidaciones", MsgBoxStyle.Critical, "Valorizador Minerales")
                            Exit Sub
                        End If

                        'Dim id As String = dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value
                        Dim id As String = dgrow.Cells("id").Value ' dgvLiquidacionTM.Item("id", dgvLiquidacionTM.CurrentCell.RowIndex).Value
                        Dim liquidacionTmId As String = dgrow.Cells("liquidacionTmId").Value

                        If String.IsNullOrEmpty(id) Then
                            Dim drowP As DataRow
                            'drowP = BuscarenDatatable(dvwLiquidacionTM.Table, "id", dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value)
                            'drowP = BuscarenDatatable(dvwLiquidacionTM.Table, "id", id)
                            drowP = BuscarenDatatable(dvwLiquidacionTM.Table, "liquidacionTmId", liquidacionTmId)
                            drowP.Delete()
                        Else

                            If cboTipo.Text = "V" Then

                            Else
                                ActualizarEstadoLogisticaDesasociar(id)
                            End If


                            oLiquidacionTMTX.NuevaEntidad()
                            With oLiquidacionTMTX.oBELiquidacionTm
                                .contratoLoteId = pstrCorrelativo
                                .liquidacionId = pstrCorrelativoLiquidacion
                                .liquidacionTmId = dgrow.Cells("liquidacionTmId").Value ' dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("liquidacionTmId").Value
                                '.codigoElemento = fxgrdPagable.Rows(fxgrdPagable.Row).Item("codigoElemento")
                                'oLiquidacionTMTX.LstLiquidacionTm.Add(oLiquidacionTMTX.oBELiquidacionTm)
                                oLiquidacionTMTX.LstLiquidacionTmDel.Add(oLiquidacionTMTX.oBELiquidacionTm)
                            End With
                            'Public oBELiquidacionTm As clsBE_LiquidacionTm
                            Dim drowPen As DataRow
                            'drowPen = BuscarenDatatable(dvwLiquidacionTM.Table, "id", dgrow.Cells("id").Value) 'dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value)
                            drowPen = BuscarenDatatable(dvwLiquidacionTM.Table, "liquidacionTmId", dgrow.Cells("liquidacionTmId").Value) 'dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value)
                            If drowPen IsNot Nothing Then
                                drowPen.Delete()
                            End If

                        End If
                    Next

                End If
            End If

            ResumenGeneral()

            pAccionFormulario = "DRR"
            tsbGuardar_Click(Nothing, Nothing)

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    '@02    AINI
    Private Function validarDesasociacion() As Boolean
        Dim validacion As Boolean = True
        Dim message As String = ""





        '' Se verifica que el lote no tenga ningun registro de liquidacion
        'If Not CType(dgvLiquidacion.DataSource, DataTable).Rows.Count = 0 Then
        '    validacion = False
        '    message += Chr(10) & "No puede Desasociar dado que el lote contiene liquidaciones."
        'End If

        ' Se verifica si el periodo del lote no esta cerrado
        If cboTipo.Text = "B" Then
            Dim p As New clsBC_PeriodoRO
            If p.ValidaPeriodoCerrado(cboEmpresa.SelectedValue, oLiquidacionRO.oBELiquidacion.periodo) Then
                validacion = False
                message += Chr(10) & "No puede des-asociar despacho dado que el periodo [" & oLiquidacionRO.oBELiquidacion.periodo & "] de lote esta cerrado"
            End If
        End If

        If Not message = String.Empty Then
            MsgBox(message, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If


        Return validacion
    End Function
    '@02    AFIN

    Private Sub tsbAjusteAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAjusteAgregar.Click
        ''InsertarAjuste(tsCboAjuste.Text)

        ''KMN ADELANTOS
        '' Adelantos de vinculada  
        If cboTipo.SelectedValue = "P" Or cboTipo.SelectedValue = "V" Then
            'If tsCboAjuste.Text = "ADELANTO" Then
            If tsCboAjuste.Text = "ADELANTO" Or tsCboAjuste.Text = "DESCUENTO" Or tsCboAjuste.Text = "PLANTA" Then

                tsbGuardar_Click(Nothing, Nothing)


                Dim oLstFINANCIANDO_PRELIQ_INSERT As New List(Of clsBE_FINANCIANDO_PRELIQ)
                Dim oGeneral As New clsBC_GeneralRO
                Dim parametro As New Hashtable

                Dim ofrmAdelanto As New Adelanto
                Dim oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ

                ofrmAdelanto.contratoLoteId = pstrCorrelativo
                ofrmAdelanto.contrato = cboTipo.Text & txtNumero.Text
                ofrmAdelanto.lote = txtNumeroLote.Text
                ofrmAdelanto.proveedor_nombre = cboSocio.Text
                ofrmAdelanto.liquidacionId = pstrCorrelativoLiquidacion

                ofrmAdelanto.proveedor = cboSocio.SelectedValue
                ofrmAdelanto.empresa_grupo = cboEmpresa.SelectedValue


                'oBE_FINANCIANDO_PRELIQ.proveedor = cboSocio.SelectedValue
                'ofrmAdelanto.oBE_FINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
                ofrmAdelanto.oBE_FINANCIANDO_PRELIQ.proveedor = cboSocio.SelectedValue



                '***** ADELANTO
                If cboTipo.SelectedValue = "V" Then
                    Dim oBC_TablaDetRO As New clsBC_TablaDetRO
                    oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet

                    oBC_TablaDetRO.oBETablaDet.tablaId = "empresa"
                    oBC_TablaDetRO.LeerListaToDSTablaDet()

                    If oBC_TablaDetRO.oDSTablaDet.Tables.Count > 0 Then


                        For nContador = 0 To oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows.Count - 1
                            If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(nContador)("tablaDetId") = cboEmpresa.SelectedValue Then
                                ofrmAdelanto.proveedor = oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(nContador)("campo1")
                                ofrmAdelanto.oBE_FINANCIANDO_PRELIQ.proveedor = oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(nContador)("campo1")
                            End If

                            If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(nContador)("campo1") = cboSocio.SelectedValue Then
                                ofrmAdelanto.empresa_grupo = oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(nContador)("tablaDetId")
                            End If
                        Next

                    End If
                End If
                '***** ADELANTO




                If dgvAjustes.RowCount > 0 Then
                    nItem = IIf(IsDBNull(dgvAjustes.Rows(dgvAjustes.RowCount - 1).Cells("A_NRO").Value), 0, dgvAjustes.Rows(dgvAjustes.RowCount - 1).Cells("A_NRO").Value)
                End If

                ofrmAdelanto.txtItem.Text = nItem 'dgvAjustes.Rows(1).Cells("A_NRO").Value 'nItem
                ofrmAdelanto.ShowDialog()


                If ofrmAdelanto.bAsociar Then
                    nItem = ofrmAdelanto.txtItem.Text
                    tsbGuardar_Click(Nothing, Nothing)

                    MsgBox("Se Pre-Aplico satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                End If

            Else
                InsertarAjuste(tsCboAjuste.Text)
            End If
        Else
            InsertarAjuste(tsCboAjuste.Text)
        End If

    End Sub


    Private Sub DefinirAjustes()
        dtAjuste = oLiquidacionDsctoRO.DefinirTablaLiquidacionDscto
        'InsertarAjuste("ADELANTO")
        dgvAjustes.AutoGenerateColumns = False
        dgvAjustes.DataSource = dtAjuste

        dtAdelantoFactura = oLiquidacionDsctoRO.DefinirTablaLiquidacionDscto
        dgvAdelantosFacturas.AutoGenerateColumns = False
        dgvAdelantosFacturas.DataSource = dtAdelantoFactura

        If cboTipo.SelectedValue = "S" Or cboTipo.SelectedValue = "V" Then
            EditarColumnasModificables(dgvAjustes, "descriDscto,importeDscto,importeTotal")
        End If

    End Sub

    Private Sub DefinirServicios()

        dtServicio = oLiquidacionServicioRO.DefinirTablaLiquidacionServicio
        InsertarServicio("Analisis")
    End Sub
    Private Sub InsertarAjuste(ByVal codigo As String, Optional ByVal importe As Double = 0.0, Optional ByVal desc As String = "", Optional ByVal carta As String = "", Optional ByVal obs As String = "", Optional ByVal nro As Integer = Nothing)
        Try
            Dim drow As DataRow
            drow = dtAjuste.NewRow
            drow("codigoDscto") = codigo
            drow("importe") = importe
            drow("descri") = desc
            drow("cartaInstruccion") = carta
            drow("observa") = obs

            drow("nro") = nro
            dtAjuste.Rows.Add(drow)
            EditarColumnasModificables(dgvAjustes, "descridscto,importedscto")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub InsertarServicio(ByVal codigo As String, Optional ByVal importe As Double = 0.0, Optional ByVal desc As String = "")
        Try
            If dtServicio Is Nothing Then
                dtServicio = oLiquidacionServicioRO.DefinirTablaLiquidacionServicio
            End If
            Dim drow As DataRow
            drow = dtServicio.NewRow
            drow("codigoServicio") = codigo
            drow("importe") = importe
            drow("descri") = desc
            'KMN 31/08/2012
            If codigo = "Analisis" Then
                drow("codigoCalculoServicio") = "IMP"
            Else
                drow("codigoCalculoServicio") = "TMSN"
            End If
            'KMN 31/08/2012

            dtServicio.Rows.Add(drow)
            dvwServicio = New DataView(dtServicio)
            dgvServicios.AutoGenerateColumns = False
            dgvServicios.DataSource = dvwServicio
            EditarColumnasModificables(dgvServicios, "descriservicio,importeservicio,dgvCalculoServicio,indservicio")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ObtenerDatosContrato(ByVal strcorrelativo As String)
        Try
            'strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo3.ToString.Split(" ")(0)

            oContratoLoteRO.oBEContratoLote.contratoLoteId = strcorrelativo
            oContratoLoteRO.LeerContratoLote()
            txtNumero.Text = oContratoLoteRO.oBEContratoLote.contrato.Trim
            cboTipo.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoMovimiento
            cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad
            cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
            cboEmpresa.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoEmpresa
            cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
            cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
            cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto
            txtprocedencia.Text = oContratoLoteRO.oBEContratoLote.procedencia

            ObtenerLiquidacion(strcorrelativo)
            ObtenerPagables(strcorrelativo)
            ObtenerPenalizables(strcorrelativo)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub




    Private Sub btnContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContrato.Click
        Try
            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            Dim strCorrelativo As String
            'parametro("id_oferta") = 
            oGeneral.LstGeneral.Clear()
            MostrarFormularioAyuda(EnumFormAyuda.Contratos, oGeneral, False, parametro, , pBEUsuario.campo2)

            'btnVenta.Visible = True

            If Not oGeneral Is Nothing Then
                If oGeneral.LstGeneral.Count > 0 Then
                    If dgvPagables.Rows.Count > 0 Or dgvPenalizable.Rows.Count > 0 Then
                        If MsgBox("Esta seguro de cambiar el contrato asociado", MsgBoxStyle.YesNo, " Valorizador de Minerales") = MsgBoxResult.Yes Then
                            'strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo3.ToString
                            'strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo3.ToString.Split(" ")(0)
                            strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo4.ToString.Split(" ")(0)

                            oContratoLoteRO.oBEContratoLote.contratoLoteId = strCorrelativo
                            oContratoLoteRO.LeerContratoLote()
                            txtNumero.Text = oContratoLoteRO.oBEContratoLote.contrato.Trim
                            cboTipo.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoMovimiento


                            btnVenta.Visible = False

                            If oContratoLoteRO.oBEContratoLote.codigoMovimiento = TABLA_DE_MOVIMIENTOS.MEZCLA.Value Then
                                'txtNumeroLote.Text = Month(Now()) & "-" & oGeneral.LstGeneral.Item(0).NomCampo4
                                'txtNumeroLote.Text = Month(Now()) & "-" & oGeneral.LstGeneral.Item(0).NomCampo5
                                txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo5

                                cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                                cboClase.Enabled = False
                                cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad
                                btnCalidad.Enabled = False
                                'cboTrader.SelectedValue = oContratoLoteRO.oBEContratoLote.codigo
                                cboIncoterm.Enabled = False
                                cboDeposito.Enabled = False
                                lblmaquila.Visible = False
                                txtMaquila.Visible = False
                                CuGroupBox1.Visible = False
                                gpopenalizable.Visible = False
                                Dim strCadena As String = "Elem,Ley,Contenido"
                                For Each sCol As DataGridViewColumn In dgvPagables.Columns
                                    If InStr(strCadena, sCol.Name, CompareMethod.Text) > 0 Then
                                        sCol.Visible = True
                                    Else
                                        sCol.Visible = False
                                    End If
                                Next

                            ElseIf cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VENTA.Value Then

                                lblperiodo.Visible = True
                                dtPeriodo.Visible = True

                            ElseIf oContratoLoteRO.oBEContratoLote.codigoMovimiento = TABLA_DE_MOVIMIENTOS.VINCULADA.Value Then

                                lblperiodo.Visible = True
                                dtPeriodo.Visible = True

                                btnVenta.Visible = True
                                txtNumeroLote.Enabled = False
                            Else
                                'txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo4
                                txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo5
                                cboClase.Enabled = True
                                btnCalidad.Enabled = True
                                cboIncoterm.Enabled = False
                                cboDeposito.Enabled = False
                                lblmaquila.Visible = True
                                txtMaquila.Visible = True
                                CuGroupBox1.Visible = True
                                gpopenalizable.Visible = True
                            End If

                            txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo5

                            cboTipo.SelectedValue = CStr(oContratoLoteRO.oBEContratoLote.codigoMovimiento)
                            cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad
                            cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
                            cboEmpresa.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoEmpresa
                            cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
                            cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                            cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto
                            txtprocedencia.Text = oContratoLoteRO.oBEContratoLote.procedencia
                            ObtenerLiquidacion(strCorrelativo)
                            ObtenerPagables(strCorrelativo)
                            ObtenerPenalizables(strCorrelativo)
                        End If
                    Else
                        'strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo3.ToString
                        strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo4.ToString.Split(" ")(0)
                        'strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo4.ToString.Split(" ")(0)
                        oContratoLoteRO.oBEContratoLote.contratoLoteId = strCorrelativo
                        oContratoLoteRO.LeerContratoLote()

                        txtNumero.Text = oContratoLoteRO.oBEContratoLote.contrato.Trim
                        cboTipo.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoMovimiento


                        btnVenta.Visible = False

                        If oContratoLoteRO.oBEContratoLote.codigoMovimiento = TABLA_DE_MOVIMIENTOS.MEZCLA.Value Then
                            txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo5
                            cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                            cboClase.Enabled = False
                            cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad
                            btnCalidad.Enabled = False
                            'cboTrader.SelectedValue = oContratoLoteRO.oBEContratoLote.codigo
                            cboIncoterm.Enabled = False
                            cboDeposito.Enabled = False
                            lblmaquila.Visible = False
                            txtMaquila.Visible = False
                            CuGroupBox1.Visible = False
                            gpopenalizable.Visible = False
                            Dim strCadena As String = "Elem,Ley,Contenido"
                            For Each sCol As DataGridViewColumn In dgvPagables.Columns
                                If InStr(strCadena, sCol.Name, CompareMethod.Text) > 0 Then
                                    sCol.Visible = True
                                Else
                                    sCol.Visible = False
                                End If
                            Next
                        ElseIf cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VENTA.Value Then

                            lblperiodo.Visible = True
                            dtPeriodo.Visible = True

                        ElseIf oContratoLoteRO.oBEContratoLote.codigoMovimiento = TABLA_DE_MOVIMIENTOS.VINCULADA.Value Then

                            lblperiodo.Visible = True
                            dtPeriodo.Visible = True

                            btnVenta.Visible = True
                            txtNumeroLote.Enabled = False
                        Else
                            'txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo4
                            txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo5
                            cboClase.Enabled = True
                            btnCalidad.Enabled = True
                            cboIncoterm.Enabled = False
                            cboDeposito.Enabled = False
                            lblmaquila.Visible = True
                            txtMaquila.Visible = True
                            CuGroupBox1.Visible = True
                            gpopenalizable.Visible = True
                        End If

                        'obtiene correlativo
                        txtNumeroLote.Text = oGeneral.LstGeneral.Item(0).NomCampo5

                        cboTipo.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoMovimiento
                        cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad
                        cboEmpresa.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoEmpresa
                        cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
                        cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                        cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto
                        txtprocedencia.Text = oContratoLoteRO.oBEContratoLote.procedencia
                        ObtenerLiquidacion(strCorrelativo)
                        ObtenerPagables(strCorrelativo)
                        ObtenerPenalizables(strCorrelativo)
                    End If
                    'EditarColumnasModificables(dgvPagables, "ley,pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvAjuste")

                    Calculo_IGV()

                    'Dim oTablaDetRO As New clsBC_TablaDetRO
                    'oTablaDetRO.oBETablaDet.tablaId = "impuesto"
                    'oTablaDetRO.oBETablaDet.tablaDetId = "igv"
                    'oTablaDetRO.LeerTablaDet()
                    'txtPorImpuesto.Text = oTablaDetRO.oBETablaDet.descri.ToString()

                    ResumenGeneral()
                    NombrarEtiquetas()
                End If
            End If


            '*************************************************************************
            '20-01-2013: FIJACIONES
            tsbFijar.Visible = False

            '@01    D02
            'txtProduccionPropia.Visible = False
            'lblProduccionPropia.Visible = False

            Select Case cboTipo.SelectedValue
                Case "P"
                    txtNumeroLote.MaxLength = 3

                    '@01    D02
                    'txtProduccionPropia.Visible = True
                    'lblProduccionPropia.Visible = True

                Case "V"
                    txtNumeroLote.MaxLength = 10

                    'Doble vinculada - puedo crear lotes a demanda
                    If txtNumero.Text.Substring(0, 1) = "V" Then
                        txtNumeroLote.Enabled = True
                        txtNumeroLote.ReadOnly = False
                        btnVenta.Visible = False
                    End If



                Case "B"
                    txtNumeroLote.MaxLength = 5
                Case "S"
                    txtNumeroLote.MaxLength = 3
            End Select
            '*************************************************************************
            tsbFijar.Visible = False
            Select Case cboTipo.SelectedValue
                Case "P", "S"
                    txtNumeroLote.MaxLength = 3
                    tsbFijar.Visible = True
                Case "V"
                    txtNumeroLote.MaxLength = 10
                Case "B"
                    txtNumeroLote.MaxLength = 5
            End Select
            '*************************************************************************

            If cboTipo.SelectedValue = "P" Then
                tbcTerminos.TabPages.Add(tpProfitAndLoss)
            End If

            '' ''kmn vinvulada
            'txtNumeroLote.Enabled = True
            'txtNumeroLote.ReadOnly = False
            PermisoTabs()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbServiciosAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbServiciosAgregar.Click
        InsertarServicio(tsCboServicio.Text)
    End Sub

    Private Sub tsbAjusteEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAjusteEliminar.Click
        Try
            Dim sMensajeConfirmacion As String = "el Elemento  seleccionado"
            If dgvAjustes.RowCount > 0 Then

                If MsgBox("Esta seguro de Eliminar " & sMensajeConfirmacion, MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then

                    Dim oBC_FINANCIANDO_PRELIQ As New clsBC_FINANCIANDO_PRELIQRO
                    Dim sFLG_VALIDA As String = "0"

                    Dim liquidacionDsctoId As String = dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("liquidacionDsctoId").Value.ToString
                    If String.IsNullOrEmpty(liquidacionDsctoId) Then
                        Dim drowP As DataRow
                        drowP = BuscarenDatatable(dvwAjuste.Table, "nro", dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("nro").Value)
                        drowP.Delete()
                    Else
                        oLiquidacionDsctoTX.NuevaEntidad()
                        With oLiquidacionDsctoTX.oBELiquidacionDscto
                            .contratoLoteId = pstrCorrelativo
                            .liquidacionId = pstrCorrelativoLiquidacion
                            .liquidacionDsctoId = dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("liquidacionDsctoId").Value

                            If dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("A_NRO").Value.ToString() <> "" Then
                                .nro = dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("A_NRO").Value.ToString()
                            End If

                            '.codigoElemento = fxgrdPagable.Rows(fxgrdPagable.Row).Item("codigoElemento")
                            oLiquidacionDsctoTX.LstLiquidacionDsctoDel.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)
                        End With
                        Dim drowPen As DataRow
                        drowPen = BuscarenDatatable(dvwAjuste.Table, "liquidacionDsctoId", dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("liquidacionDsctoId").Value)
                        drowPen.Delete()
                        ' oPagableTX.EliminarPagable()
                    End If

                    'KMN(ADELANTOS)
                    ''En caso se elimine descuentos de tipo ADELANTO, se eliminan todos de su tipo
                    If cboTipo.SelectedValue = "P" Then 'If dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("codigoDscto").Value = "ADELANTO" Then
                        tsbGuardar_Click(Nothing, Nothing)
                    End If


                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbServiciosEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbServiciosEliminar.Click
        Try
            If dgvServicios.RowCount > 0 Then
                If MsgBox("Esta seguro de Eliminar el Elemento  seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                    ' dgvServicios.EndEdit()
                    Dim liquidacionServicioId As String = dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("liquidacionServicioId").Value.ToString
                    If String.IsNullOrEmpty(liquidacionServicioId) Then
                        Dim drowP As DataRow
                        drowP = BuscarenDatatable(dvwServicio.Table, "nro", dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("nro_servicio").Value)
                        drowP.Delete()
                    Else
                        oLiquidacionServicioTX.NuevaEntidad()
                        With oLiquidacionServicioTX.oBELiquidacionServicio
                            .contratoLoteId = pstrCorrelativo
                            .liquidacionId = pstrCorrelativoLiquidacion
                            .liquidacionServicioId = dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("liquidacionServicioId").Value
                            '.codigoElemento = fxgrdPagable.Rows(fxgrdPagable.Row).Item("codigoElemento")
                            oLiquidacionServicioTX.LstLiquidacionservicioDel.Add(oLiquidacionServicioTX.oBELiquidacionServicio)
                        End With
                        Dim drowPen As DataRow
                        drowPen = BuscarenDatatable(dvwServicio.Table, "liquidacionServicioId", dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("liquidacionServicioId").Value)
                        drowPen.Delete()
                    End If

                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub cboSocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSocio.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3
                    Dim oGeneral As New clsBC_GeneralRO
                    Dim parametro As New Hashtable
                    oGeneral.LstGeneral.Clear()
                    MostrarFormularioAyuda(EnumFormAyuda.Socio, oGeneral, False, parametro)
                    BuscarenComboBox(cboSocio, oGeneral.oBEGeneral.NomCampo1)
            End Select
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Dim buttonToolTip As New ToolTip()
    Private Sub cboSocio_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSocio.MouseHover
        buttonToolTip.ToolTipTitle = "Value"
        buttonToolTip.UseFading = True
        buttonToolTip.UseAnimation = True
        buttonToolTip.IsBalloon = True
        buttonToolTip.ShowAlways = True
        buttonToolTip.AutoPopDelay = 5000
        buttonToolTip.InitialDelay = 1000
        buttonToolTip.ReshowDelay = 0

        buttonToolTip.SetToolTip(cboSocio, cboSocio.Text)
    End Sub

    Private Sub cboSocio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSocio.SelectedIndexChanged
        Try

            txtContacto.Text = ""
            txtTelefono.Text = ""
            txtCorreo.Text = ""
            If cboSocio.SelectedIndex >= 0 Then
                If cboSocio.SelectedValue.ToString <> "SI.BE.clsBE_PUB_PERSONAS" Then
                    Dim oBC_PUB_PERSONASRO As New clsBC_PUB_PERSONASRO
                    oBC_PUB_PERSONASRO.LeerListaPUB_PERSONAS("", cboSocio.SelectedValue)
                    'oCombo.Items.Add(New ListViewItem("[Seleccione]", ""))

                    txtContacto.Text = oBC_PUB_PERSONASRO.LstPUB_PERSONAS(1).CONTACTO
                    txtTelefono.Text = oBC_PUB_PERSONASRO.LstPUB_PERSONAS(1).CELULAR1
                    txtCorreo.Text = oBC_PUB_PERSONASRO.LstPUB_PERSONAS(1).CORREO


                    If Len(oBC_PUB_PERSONASRO.LstPUB_PERSONAS(1).DIRECCION) < 10 Then
                        pDireccion = False
                    End If

                End If
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub cboEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEmpresa.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3
                    Dim oGeneral As New clsBC_GeneralRO
                    Dim parametro As New Hashtable
                    oGeneral.LstGeneral.Clear()
                    MostrarFormularioAyuda(EnumFormAyuda.Empresa, oGeneral, False, parametro)
                    BuscarenComboBox(cboEmpresa, oGeneral.oBEGeneral.NomCampo1)
            End Select
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbAgregarPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarPag.Click
        Try
            If ValidarPagable() Then
                'InsertarPagable(cboMetalPag.SelectedValue, nupdPagable.Value, cboDeducccion.SelectedValue, txtdeduccion.Text, txtRefinacion.Text, txtProteccion.Text, cboMercado.SelectedValue, cboQpTipo.SelectedValue, cboQpAjuste.SelectedValue)
                InsertarPagable(tsCboPagable.ComboBox.SelectedValue)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbEliminarPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarPag.Click
        Try
            If dgvPagables.RowCount > 0 Then
                If MsgBox("Esta seguro de Eliminar el Elemento  seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                    If pblnNuevo Or pblnCopia Then
                        Dim drow As DataRow
                        'drow = BuscarenDatatable(dvwPagable.Table, "liquidacionPagable", dgvPagables.Rows(dgvPagables.CurrentCell.RowIndex).Cells("liquidacionPagable").Value)
                        drow = BuscarenDatatable(dvwPagable.Table, "codigoElemento", dgvPagables.Rows(dgvPagables.CurrentCell.RowIndex).Cells("Elem").Value)
                        drow.Delete()
                    Else
                        If String.IsNullOrEmpty(dgvPagables.Rows(dgvPagables.CurrentCell.RowIndex).Cells("liquidacionPagable").Value) Then
                            Dim drowP As DataRow
                            drowP = BuscarenDatatable(dvwPagable.Table, "codigoElemento", dgvPagables.Rows(dgvPagables.CurrentCell.RowIndex).Cells("Elem").Value)
                            drowP.Delete()
                        Else

                        End If
                        oPagableTX.NuevaEntidad()
                        With oPagableTX.oBEValorizadorPagable
                            .contratoLoteId = pstrCorrelativo
                            .liquidacionId = pstrCorrelativoLiquidacion
                            .liquidacionPagable = dgvPagables.Rows(dgvPagables.CurrentCell.RowIndex).Cells("liquidacionPagable").Value
                            '.codigoElemento = fxgrdPagable.Rows(fxgrdPagable.Row).Item("codigoElemento")
                            oPagableTX.LstValorizadorPagableDel.Add(oPagableTX.oBEValorizadorPagable)
                        End With
                        Dim drowPen As DataRow
                        drowPen = BuscarenDatatable(dvwPagable.Table, "codigoElemento", dgvPagables.Rows(dgvPagables.CurrentCell.RowIndex).Cells("Elem").Value)
                        drowPen.Delete()
                        ' oPagableTX.EliminarPagable()
                    End If
                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbAgregarPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarPen.Click
        Try
            If ValidarPenalizable() Then
                'InsertarPenalizable(cboMetalPen.SelectedValue, nupdMinimo.Value, nupdMaximo.Value, txtUndPen.Text, txtPen.Text)
                InsertarPenalizable(tsCboPenalizable.ComboBox.SelectedValue)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbEliminarPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarPen.Click
        Try
            If dgvPenalizable.RowCount > 0 Then
                If MsgBox("Esta seguro de Eliminar el Elemento  seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                    If pblnNuevo Or pblnCopia Then
                        Dim drow As DataRow
                        'drow = BuscarenDatatable(dvwPagable.Table, "liquidacionPagable", dgvPagables.Rows(dgvPagables.CurrentCell.RowIndex).Cells("liquidacionPagable").Value)
                        drow = BuscarenDatatable(dvwPenalizable.Table, "codigoElemento", dgvPenalizable.Rows(dgvPenalizable.CurrentCell.RowIndex).Cells("ElemP").Value)
                        drow.Delete()
                    Else

                        Dim PasoElimina As String = "0"

                        If String.IsNullOrEmpty(dgvPenalizable.Rows(dgvPenalizable.CurrentCell.RowIndex).Cells("liquidacionPenalizableId").Value) Then
                            Dim drowP As DataRow
                            drowP = BuscarenDatatable(dvwPenalizable.Table, "codigoElemento", dgvPenalizable.Rows(dgvPenalizable.CurrentCell.RowIndex).Cells("ElemP").Value)
                            drowP.Delete()
                            PasoElimina = "1"
                        Else

                        End If

                        If dgvPenalizable.CurrentCell Is Nothing Then

                        Else

                            oPenalizableTX.NuevaEntidad()

                            With oPenalizableTX.oBEValorizadorPenalizable
                                .contratoLoteId = pstrCorrelativo
                                .liquidacionId = pstrCorrelativoLiquidacion
                                .liquidacionPenalizableId = dgvPenalizable.Rows(dgvPenalizable.CurrentCell.RowIndex).Cells("liquidacionPenalizableId").Value
                                '.codigoElemento = fxgrdPagable.Rows(fxgrdPagable.Row).Item("codigoElemento")
                                oPenalizableTX.LstValorizadorPenalizableDel.Add(oPenalizableTX.oBEValorizadorPenalizable)
                            End With
                        End If

                        If PasoElimina = "0" Then
                            Dim drowPen As DataRow
                            drowPen = BuscarenDatatable(dvwPenalizable.Table, "codigoElemento", dgvPenalizable.Rows(dgvPenalizable.CurrentCell.RowIndex).Cells("ElemP").Value)
                            drowPen.Delete()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub InsertarPagable(ByVal metal As String, Optional ByVal pagable As Double = 0, Optional ByVal codigodeduccion As String = "", Optional ByVal deduccion As Double = 0, Optional ByVal refinacion As Double = 0, Optional ByVal proteccion As Double = 0, Optional ByVal mercado As String = "", Optional ByVal codigoqptipo As String = "", Optional ByVal codigoqpajuste As String = "")
        Try
            If dtPagable Is Nothing Then
                Dim oPagableRO As New clsBC_ValorizadorPagableRO
                dtPagable = oPagableRO.DefineTablaValorizadorPagable ' GenericListToDataTable(oPagableTX.LstValorizadorPagableIns) 'oValorizadorPagableRO.DefinirTablaValorizadorPagable
            End If
            drowPagable = dtPagable.NewRow
            drowPagable("codigoElemento") = metal
            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "Metal"
            oTablaDetRO.oBETablaDet.tablaDetId = metal
            oTablaDetRO.LeerTablaDet()
            drowPagable("undfactor") = oTablaDetRO.oBETablaDet.campo14
            drowPagable("undpag") = oTablaDetRO.oBETablaDet.campo0
            drowPagable("factorpag") = oTablaDetRO.oBETablaDet.campo6
            drowPagable("undley") = oTablaDetRO.oBETablaDet.campo11
            drowPagable("factorley") = oTablaDetRO.oBETablaDet.campo12
            drowPagable("undded") = oTablaDetRO.oBETablaDet.campo1
            drowPagable("factorded") = oTablaDetRO.oBETablaDet.campo7
            drowPagable("undrc") = oTablaDetRO.oBETablaDet.campo2
            drowPagable("undprot") = oTablaDetRO.oBETablaDet.campo3
            drowPagable("protCont") = oTablaDetRO.oBETablaDet.campo21

            drowPagable("liquidacionPagable") = ""
            dtPagable.Rows.Add(drowPagable)
            dvwPagable = New DataView(dtPagable)
            dgvPagables.AutoGenerateColumns = False
            dgvPagables.DataSource = dvwPagable
            '--EditarColumnasModificables(dgvPagables, "ley,pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal")
            'EditarColumnasModificables(dgvPagables, "ley,pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")
            EditarColumnasModificables(dgvPagables, "pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Function ValidarPenalizable()
        Try
            Dim strmensaje As String = ""
            If tsCboPenalizable.ComboBox.SelectedIndex = 0 Then
                strmensaje = strmensaje & "* Seleccione Metal Penalizable" & vbCrLf
            End If

            Dim drow As DataRow
            If dvwPenalizable IsNot Nothing Then
                drow = BuscarenDatatable(dvwPenalizable.Table, "codigoElemento", tsCboPenalizable.ComboBox.SelectedValue)
                If drow IsNot Nothing Then
                    strmensaje = strmensaje & "* Penalizable ya registrado" & vbCrLf
                End If
            End If

            If strmensaje.Length > 0 Then
                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Return False
            End If
            Return True
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function

    Private Function ValidarPagable()
        Try
            Dim strmensaje As String = ""
            If cboTipo.SelectedValue <> TABLA_DE_MOVIMIENTOS.MEZCLA.Value Then
                If tsCboPagable.ComboBox.SelectedIndex = 0 Then
                    strmensaje = strmensaje & "* Seleccione Metal Pagable" & vbCrLf
                End If
            End If

            Dim drow As DataRow
            If dvwPagable IsNot Nothing Then
                drow = BuscarenDatatable(dvwPagable.Table, "codigoElemento", tsCboPagable.ComboBox.SelectedValue)
                If drow IsNot Nothing Then
                    strmensaje = strmensaje & "* Pagable ya registrado" & vbCrLf
                End If
            End If

            If strmensaje.Length > 0 Then
                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Return False
            End If
            Return True
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try

    End Function

    Private Sub InsertarPenalizable(ByVal metal As String, Optional ByVal minimo As Double = 0, Optional ByVal maximo As Double = 0, Optional ByVal unidad As Double = 0, Optional ByVal penalizable As Double = 0)
        Try
            If dtPenalizable Is Nothing Then
                Dim oPenalizableRO As New clsBC_ValorizadorPenalizableRO
                dtPenalizable = oPenalizableRO.DefinirTablaValorizadorPenalizable '.GenericListToDataTable(oPenalizableTX.LstValorizadorPenalizableIns) 'oValorizadorPagableRO.DefinirTablaValorizadorPagable
            End If

            drowPenalizable = dtPenalizable.NewRow
            drowPenalizable("codigoElemento") = metal
            drowPenalizable("liquidacionPenalizableId") = ""
            drowPenalizable("preciounitario") = "0"

            dtPenalizable.Rows.Add(drowPenalizable)
            dvwPenalizable = New DataView(dtPenalizable)


            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "Metal"
            oTablaDetRO.oBETablaDet.tablaDetId = metal
            oTablaDetRO.LeerTablaDet()
            drowPenalizable("undfactorp") = oTablaDetRO.oBETablaDet.campo14
            drowPenalizable("undpen") = oTablaDetRO.oBETablaDet.campo15

            dgvPenalizable.AutoGenerateColumns = False
            dgvPenalizable.DataSource = dvwPenalizable
            'EditarColumnasModificables(dgvPenalizable, "leyp,min,max,unid,pen,indLey")
            EditarColumnasModificables(dgvPenalizable, "min,max,unid,pen,indLey")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    ''' <summary>
    ''' Calcula el costo de los servicios
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub costoServicio()
        Dim oLiquidacionServicioTX As New clsBC_LiquidacionServicioTX
        Dim oBE_LiquidacionServicio As New clsBE_LiquidacionServicio

        oBE_LiquidacionServicio.contratoLoteId = pstrCorrelativo
        oBE_LiquidacionServicio.liquidacionId = pstrCorrelativoLiquidacion
        oBE_LiquidacionServicio.uc = pBEUsuario.tablaDetId

        oLiquidacionServicioTX.LstLiquidacionServicio.Add(oBE_LiquidacionServicio) '= oBE_LiquidacionServicio
        oLiquidacionServicioTX.CostoLiquidacionServicio()

        ObtenerLiquidacionServicio(pstrCorrelativo)

    End Sub


    Private Sub ResumenServicios()
        Try



            If dvwServicio IsNot Nothing Then

                Dim dblSrvTmsn As Double
                Dim dblSrvImporte As Double
                Dim dblTMSN As Double = txtTMSN.Text
                Dim strTipoCalculoServicio As String
                For Each row As DataGridViewRow In dgvServicios.Rows
                    strTipoCalculoServicio = row.Cells("dgvCalculoServicio").Value

                    If IsDBNull(row.Cells("importeservicio").Value) Then
                        row.Cells("importeservicio").Value = 0.0
                    End If

                    If strTipoCalculoServicio = "IMP" Then
                        If dblTMSN > 0 Then
                            dblSrvImporte = dblSrvImporte + (row.Cells("importeservicio").Value / dblTMSN)
                        End If
                    ElseIf strTipoCalculoServicio = "TMSN" Then
                        dblSrvTmsn = dblSrvTmsn + row.Cells("importeservicio").Value ''* dblTMSN
                    End If


                Next
                If dvwServicio.Count > 0 Then
                    txtSrvImporte.Text = FormatNumber(dblSrvImporte, 2)
                    txtSrvTMSN.Text = FormatNumber(dblSrvTmsn, 2)
                    'txtTotalServicios.Text = FormatNumber(dblSrvImporte + dblSrvTmsn, 2)
                    txtTotalServicios.Text = FormatNumber(dblSrvImporte + dblSrvTmsn, 4)
                End If
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub tbcTerminos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcTerminos.GotFocus
        Try

            'valida si es visible agregar rumas ficticias
            If cboTipo.SelectedValue = "S" Or cboTipo.SelectedValue = "T" Then
                tsAsociarRumaFicticia.Visible = True
            Else
                tsAsociarRumaFicticia.Visible = False
            End If

            'Valida Generacion de facturas
            If cboTipo.SelectedValue = "S" Then
                tslFactura.Visible = True
                tsbGenerarFactura.Visible = True
                tsbEliminarFactura.Visible = True

                'tslAdelantos.Visible = False
                'tsbAgregarAdelantos.Visible = False
                'tsbEliminarAdelantos.Visible = False
                'tsbGrabarAdelantos.Visible = False

            ElseIf cboTipo.SelectedValue = "V" Then
                tslFactura.Visible = True
                tsbGenerarFactura.Visible = True
                tsbEliminarFactura.Visible = True

                'tslAdelantos.Visible = True
                'tsbAgregarAdelantos.Visible = True
                'tsbEliminarAdelantos.Visible = True
                'tsbGrabarAdelantos.Visible = True
            Else
                tslFactura.Visible = False
                tsbGenerarFactura.Visible = False
                tsbEliminarFactura.Visible = False

                'tslAdelantos.Visible = False
                'tsbAgregarAdelantos.Visible = False
                'tsbEliminarAdelantos.Visible = False
                'tsbGrabarAdelantos.Visible = False
            End If


            'SendKeys.Send("{Enter}")
            txtNumero.Focus()
            ResumenGeneral()
            tsRumas.Visible = True

            ''valida la visualizacion de los botones de asociar
            ''tsRumas.Visible = bVisibleButtonsRumas
            tsAjuste.Visible = True
            tsServicios.Visible = True

            If cboTipo.SelectedValue = "B" Then
                tsRumas.Visible = True
            ElseIf cboTipo.SelectedValue = "V" Or cboTipo.SelectedValue = "S" Then
                'Valida asociacion de rumas: en caso exista PRV o FIN no se puede asociar ni desasociar
                If lblestadoliq.Text.Substring(1, 1) = "F" Then
                    tsRumas.Visible = False
                Else
                    tsRumas.Visible = True
                End If

            Else
                'Valida asociacion de rumas: en caso exista PRV o FIN no se puede asociar ni desasociar
                If lblestadoliq.Text.Substring(1, 1) = "F" Or lblestadoliq.Text.Substring(1, 1) = "P" Then
                    tsRumas.Visible = False
                    tsAjuste.Visible = False
                Else
                    tsRumas.Visible = True
                    tsAjuste.Visible = True
                End If
            End If


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub dgvAjustes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvAjustes.DataError, dgvDstoProvisionales.DataError
        MsgBox("Por favor ..... Verificar la informacion ingresada.", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
    End Sub

    Private Sub dgvAjustes_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvAjustes.RowStateChanged, dgvDstoProvisionales.RowStateChanged
        e.Row.Cells(0).Value = e.Row.Index + 1
    End Sub

    Private Sub dgvServicios_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvServicios.DataError
        MsgBox("Por favor ..... Verificar la informacion ingresada.", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
    End Sub

    Private Sub dgvServicios_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvServicios.RowStateChanged
        e.Row.Cells(0).Value = e.Row.Index + 1
    End Sub

    Private Sub dgvLiquidacionTM_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLiquidacionTM.CellEndEdit
        ResumenRumas()
    End Sub

    Private Sub dgvLiquidacionTM_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLiquidacionTM.CellEnter
        Try
            Dim sRow As DataGridViewRow = dgvLiquidacionTM.Rows(e.RowIndex)
            Dim dblTMS As Double
            Dim dblTMSH As Double
            Dim dblMerma As Double = nupdMerma.Value
            With sRow.Cells
                dblTMS = .Item("TMH").Value * (100 - .Item("h2o").Value) / 100 ' MH 01112011
                dblTMSH = dblTMS * (100 - dblMerma) / 100
                .Item("TMS").Value = dblTMS
                .Item("TMSN").Value = dblTMSH
            End With
            ResumenRumas()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub dgvLiquidacionTM_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvLiquidacionTM.RowStateChanged
        e.Row.Cells(0).Value = e.Row.Index + 1
    End Sub
    Private Sub CalculoRC()
        Dim dblModRc As Double = 0
        Dim dblRefinacion As Double = 0
        If (cboTipo.Text = "S" Or cboTipo.Text = "P") And (UCase(cboProducto.SelectedValue) = "PB" Or UCase(cboProducto.SelectedValue) = "ZN") Then

            Try
                dgvPagables.EndEdit()
                For Each srow As DataGridViewRow In dgvPagables.Rows

                    Dim dblBaseRc As Double = BaseRc.Text
                    Dim dblRcmas As Double = Rcmas.Text
                    Dim dblRcmenos As Double = Rcmenos.Text
                    Dim dblContmas As Double = ContMas.Text
                    Dim dblContmenos As Double = ContMenos.Text
                    Dim dblPrecioAg As Double = 0

                    ' Para calcular Escalador de Ag
                    If UCase((srow.Cells.Item("Elem").Value)) = UCase("Ag") Then
                        dblPrecioAg = srow.Cells.Item("precio").Value

                        If dblPrecioAg > dblBaseRc Then
                            dblModRc = (dblPrecioAg - dblBaseRc) * dblRcmas
                        End If

                        ' Obtener Deduccion según Ley de Ag
                        If srow.Cells.Item("LeyCambUnid").Value > RcBasecon.Text Then
                            dblRefinacion = dblContmenos
                        Else
                            dblRefinacion = dblContmas
                        End If

                    End If



                Next
                dblDeducRc = dblRefinacion + dblModRc
                'dgvPagables.Item("rc").value = dblModRc
            Catch ex As Exception
                oMensajeError.txtMensaje.Text = ex.ToString()
                oMensajeError.ShowDialog()
            End Try
        End If

    End Sub

    Private Sub CalculoPagables()
        CalculoRC()
        Try
            dgvPagables.EndEdit()
            For Each srow As DataGridViewRow In dgvPagables.Rows
                'Dim sRow As DataGridViewRow = dgvPagables.Rows(e.RowIndex)
                Dim strCodDed As String = srow.Cells.Item("dgvTipo").Value.ToString
                Dim dblPrecioUnitario As Double = 0
                Dim dblLey As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("ley").Value).GetValueOrDefault
                Dim dblfactorley As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("factorley").Value).GetValueOrDefault
                Dim dblPagable As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("pag").Value).GetValueOrDefault
                Dim dblfactorPagable As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("factorpag").Value).GetValueOrDefault
                Dim dblDeduccion As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("ded").Value).GetValueOrDefault
                Dim dblProteccion As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("prot").Value).GetValueOrDefault
                Dim dblfactorDeduccion As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("factorded").Value).GetValueOrDefault
                Dim dblfactorProt As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("factorprot").Value).GetValueOrDefault
                Dim dblRefinacion As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("rc").Value).GetValueOrDefault '* 2204.62
                Dim dblfactorrc As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("factorrc").Value).GetValueOrDefault
                Dim dblProtCont As Double = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("protCont").Value).GetValueOrDefault
                Dim dblContPagable As Double
                Dim dblTMSN As Double = txtTMSN.Text


                If cboTipo.Text = "B" Then
                    dblTMSN = txtCalculoTmsn.Text
                End If

                If UCase((srow.Cells.Item("Elem").Value)) = UCase("Ag") And dblDeducRc > 0 Then
                    dblRefinacion = dblDeducRc
                End If


                ''KMN 05/09/2012
                dblPrecio = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("precio").Value).GetValueOrDefault


                Dim dblCalculoPagables As Double
                Dim dblPAGar, dblPAApl, dblPACon, dblPASpg, dblPASre As Double

                dblPAGar = dblRefinacion * dblfactorrc
                dblPAApl = dblPrecio - (dblProteccion * dblfactorProt)



                If strCodDed.ToLower = "pre" Then
                    dblCalculoPagables = ((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion)) * (dblPagable / dblfactorPagable)
                    'dblCalculoPagables = Math.Round(dblCalculoPagables - 0.00005, 4)
                    dblCalculoPagables = Math.Max(0, Math.Round(IIf(dblCalculoPagables > 0, dblCalculoPagables - dblRedondedo, 0), 4, MidpointRounding.AwayFromZero)) 'Math.Max(0, Math.Round(dblCalculoPagables, 15))
                    dblContPagable = Math.Round(dblCalculoPagables * dblTMSN, 2)

                    dblPACon = Math.Max(0, ((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion)) * dblPagable / dblfactorPagable)
                    'dblPACon = Math.Max(0, Math.Round(dblPACon - dblRedondedo, 4, MidpointRounding.AwayFromZero))

                Else
                    dblCalculoPagables = Math.Max(0, Math.Min(((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion)), ((dblLey / dblfactorley) * (dblPagable / dblfactorPagable))))
                    'dblCalculoPagables = Math.Round(dblCalculoPagables - 0.000049, 4)
                    dblCalculoPagables = Math.Round(IIf(dblCalculoPagables > 0, dblCalculoPagables - dblRedondedo, 0), 4, MidpointRounding.AwayFromZero) ' Math.Round(dblCalculoPagables, 15)
                    dblContPagable = Math.Round(dblCalculoPagables * dblTMSN, 2)

                    dblPACon = Math.Max(0, Math.Min(((dblLey / dblfactorley) * (dblPagable / dblfactorPagable)), ((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion))))
                    'dblPACon = Math.Max(0, Math.Round(dblPACon - dblRedondedo, 4, MidpointRounding.AwayFromZero))

                End If

                If cboTipo.Text = "P" Then
                    dblPACon = dblPACon * dblProtCont
                End If


                'kmn 11/09/2012
                'Redondedo CON
                dblPACon = IIf(dblPACon > 0, EnhancedMath.RoundDown(dblPACon - dblRedondedo, 4), 0)
                dblPACon = Math.Round(dblPACon, 4)

                'Redondedo SPG
                dblPASpg = dblPACon * dblPAApl
                dblPASpg = IIf(dblPASpg > 0, EnhancedMath.RoundDown(dblPASpg - dblRedondedo, 4), 0)

                'Redondedo SRE
                dblPASre = dblPACon * dblPAGar
                dblPASre = IIf(dblPASre > 0, EnhancedMath.RoundDown(dblPASre - dblRedondedo, 4), 0)

                dblPrecioUnitario = Math.Round(dblPASpg - dblPASre, 4)

                If cboTipo.Text = "B" Then
                    dblPACon = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("calculoPagable").Value).GetValueOrDefault
                End If

                dblCalculoPagables = dblPACon
                dblContPagable = dblPACon * dblTMSN

                With srow.Cells
                    .Item("calculopagable").Value = dblCalculoPagables
                    .Item("contenido").Value = dblContPagable
                    .Item("pu").Value = dblPrecioUnitario

                    ' If UCase((srow.Cells.Item("Elem").Value)) = UCase("Ag") And (UCase(cboProducto.SelectedValue) = "PB" Or UCase(cboProducto.SelectedValue) = "ZN") Then
                    .Item("rc").Value = dblRefinacion
                    'End If

                    If Strings.Left(cboClase.Text, 5) = "Oxido" Or Strings.Left(cboClase.Text, 5) = "Sulfu" Then
                        .Item("contenido").Value = dblPagable * dblLey
                        .Item("pu").Value = (dblLey * dblPrecio) ''/ dblTMSN
                    End If
                End With

                If UCase(cboProducto.SelectedValue) = UCase((srow.Cells.Item("Elem").Value)) Then
                    dblPrecioEsc = dblPrecio
                End If


            Next


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub CalculoPenalizables()

        Try
            Dim strElemento As String = ""
            dgvPenalizable.EndEdit()
            For Each srow As DataGridViewRow In dgvPenalizable.Rows

                Dim dblLeyP As Double = IIf(IsDBNull(srow.Cells.Item("leyp").Value), 0, srow.Cells.Item("leyp").Value)
                Dim dblPen As Double = IIf(IsDBNull(srow.Cells.Item("pen").Value), 0, srow.Cells.Item("pen").Value)
                Dim dblUndPen As Double = IIf(IsDBNull(srow.Cells.Item("unid").Value), 0, srow.Cells.Item("unid").Value)
                Dim dblMinP As Double = IIf(IsDBNull(srow.Cells.Item("min").Value), 0, srow.Cells.Item("min").Value)
                Dim dblPrecioUnitario As Double = 0
                With srow.Cells
                    If dblMinP < dblLeyP Then
                        dblPrecioUnitario = (dblLeyP - dblMinP) * dblPen / dblUndPen
                    End If
                    If Double.IsNaN(dblPrecioUnitario) Then
                        dblPrecioUnitario = 0
                    End If
                    .Item("pup").Value = IIf(dblPrecioUnitario > 0, "-" & dblPrecioUnitario.ToString, 0)
                End With

            Next
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub txtAjuste_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAjuste.TextChanged
        ResumenGeneral()
    End Sub

    Private Sub txtPorImpuesto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorImpuesto.TextChanged
        ResumenGeneral()
    End Sub

    Private Sub btnsocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsocio.Click
        Try

            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            oGeneral.LstGeneral.Clear()
            MostrarFormularioAyuda(EnumFormAyuda.Socio, oGeneral, False, parametro)

            Obtener_ParametrosComboEN(cboSocio, "PUB_PERSONAS")
            If Not oGeneral.oBEGeneral.NomCampo4 Is Nothing Then
                cboSocio.SelectedValue = oGeneral.oBEGeneral.NomCampo4
            Else
                cboSocio.SelectedIndex = -1
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub nupdMerma_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nupdMerma.ValueChanged
        ResumenGeneral()
    End Sub

    Private Sub btnCalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalidad.Click
        Try
            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            oGeneral.LstGeneral.Clear()
            MostrarFormularioAyuda(EnumFormAyuda.Calidad, oGeneral, False, parametro)
            BuscarenComboBox(cboCalidad, oGeneral.oBEGeneral.NomCampo1)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub btnVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVenta.Click
        Try
            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            oGeneral.LstGeneral.Clear()
            parametro.Add("contratoVinculada", cboTipo.Text & txtNumero.Text)
            MostrarFormularioAyuda(EnumFormAyuda.VentaVinculada, oGeneral, False, parametro)

            txtContratoLoteVenta.Text = oGeneral.oBEGeneral.NomCampo1
            txtNumeroLote.Text = oGeneral.oBEGeneral.NomCampo2

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbResumen.Click
        Try
            txtNumero.Focus()
            ResumenGeneral()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub editlote_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oMovimientoTX.ActualizaEstadoBtnCancelar(txtCorrelativo.Text, "0000000001") ' siempre es el actual
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimirLiq.Click
        Try
            If dgvLiquidacion.RowCount > 0 Then
                'Dim lsLiquidacionId As String = dgvLiquidacion2.Rows(dgvLiquidacion2.CurrentCell.RowIndex).Cells(2).Value.ToString
                Dim lsLiquidacionId As String = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString()

                Dim sTipo As String
                If Strings.Left(cboClase.Text, 5) = "Oxido" Or Strings.Left(cboClase.Text, 5) = "Sulfu" Then
                    sTipo = "LiquidacionxP"
                Else
                    sTipo = "Liquidacion"
                End If

                Dim frm As New Visor
                frm.pContratoLoteId = txtCorrelativo.Text.Trim()
                frm.pLiquidacionId = lsLiquidacionId
                frm.pUserNombre = pBEUsuario.descri
                If Strings.Left(cboClase.Text, 5) = "Oxido" Or Strings.Left(cboClase.Text, 5) = "Sulfu" Then
                    frm.pTipo = "LiquidacionxP"
                Else
                    frm.pTipo = "Liquidacion"
                End If
                frm.Show()

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarLiq.Click
        Try
            If dgvLiquidacion.RowCount > 0 Then
                'Dim lsEliminar As String = dgvLiquidacion2.Rows(dgvLiquidacion2.CurrentCell.RowIndex).Cells(7).Value.ToString
                Dim lsEliminar As String = dgvLiquidacion.Columns("Eliminar").CellValue(dgvLiquidacion.Row).ToString()
                If lsEliminar = "1" Then

                    '@07    AINI
                    ''@04    AINI
                    'Dim oContratoRO As New clsBC_ContratoLoteRO
                    'Dim ContratoLoteBE As New clsBE_ContratoLote
                    'With ContratoLoteBE
                    '    .contratoLoteId = pstrCorrelativo
                    '    .liquidacionId = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString
                    '    .codigoEmpresa = cboEmpresa.SelectedValue.ToString
                    '    .periodo = dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).Year.ToString & Microsoft.VisualBasic.Right("0" + dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).Month.ToString, 2)
                    '    .codigoMovimiento = cboTipo.SelectedValue.ToString
                    '    .asientocontable = 0
                    'End With

                    'If oContratoRO.ExisteAsientoContableToLiquidacion(ContratoLoteBE) Then
                    '    MsgBox("No se puede eliminar esta liquidacion dado que ya posee un asiento contable generado.", MsgBoxStyle.Exclamation, "Valorizador Comercial de Minerales")
                    'End If
                    ''@04    AFIN
                    '@07    AFIN

                    'FLG_VALIDA = 2 cuando es registrado por los usuaios liquidadores
                    If dgvLiquidacion.Columns("FLG_VALIDA").CellValue(dgvLiquidacion.Row).ToString().Trim() = "0" Then _
                       ' Or dgvLiquidacion.Columns("PP_ESTADO").CellValue(dgvLiquidacion.Row).ToString().Trim() = "A" Then
                        MsgBox("No puede ser eliminado, ya ha sido aplicado comercialmente " & Chr(10) & "en la opción Aplicación Comercial", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")

                    ElseIf dgvLiquidacion.Columns("FLG_VALIDA").CellValue(dgvLiquidacion.Row).ToString().Trim() = "1" Then _
                        'Or dgvLiquidacion.Columns("PP_ESTADO").CellValue(dgvLiquidacion.Row).ToString().Trim() = "G" Then
                        MsgBox("No puede ser eliminado, ya ha sido provisionado contablemente", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                    Else

                        'LOTES EN PERIODOS CERRADOS
                        '@03    DINI
                        'Dim oBC_TablaDetRO As New clsBC_TablaDetRO '  LeerListaToDSEstadoPeriodos
                        'oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
                        'oBC_TablaDetRO.oBETablaDet.tablaId = IIf(cboTipo.SelectedValue = "V", cboSocio.SelectedValue, cboEmpresa.SelectedValue)
                        'oBC_TablaDetRO.oBETablaDet.campo6 = dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).Year.ToString + Microsoft.VisualBasic.Right("0" + dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).Month.ToString, 2)
                        'oBC_TablaDetRO.LeerListaToDSEstadoPeriodos()
                        'If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows.Count > 0 Then
                        '    If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(0)("Int_flagDeclara").ToString = "1" And cboTipo.SelectedValue <> "V" Then
                        '        MsgBox("No puede generar eliminar liquidación, el período: " + dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).Year.ToString + "-" + Microsoft.VisualBasic.Right("0" + dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).Month.ToString, 2) + " está CERRADO", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                        '        Exit Sub
                        '    End If
                        'End If
                        '@03    DFIN

                        '@03    AINI
                        Dim p As New clsBC_PeriodoRO
                        Dim periodoDescription = dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).Year.ToString & "-" & Microsoft.VisualBasic.Right("0" + dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).Month.ToString, 2)
                        Dim periodo As String = periodoDescription.Replace("-", "")
                        Dim empresaID As String = CType(cboEmpresa.Items(cboEmpresa.SelectedIndex), SI.BE.clsBE_General).Id_Retorna
                        If Not dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row) = "PRO" Then
                            If p.ValidaPeriodoCerrado(empresaID, periodo) Then
                                MsgBox("No se puede eliminar esta liquidacion dado que su periodo [" & periodoDescription & "] esta cerrado.", MsgBoxStyle.Exclamation, "Valorizador Comercial de Minerales")
                                Exit Sub
                            End If
                        End If
                        '@03    AFIN

                        If dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString().Trim() = "0" Or dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString().Trim() = "" Then
                            If MsgBox("Esta seguro de Eliminar el Elemento  seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                                'Dim lsLiquidacionId As String = dgvLiquidacion2.Rows(dgvLiquidacion2.CurrentCell.RowIndex).Cells(2).Value.ToString
                                Dim lsLiquidacionId As String = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString()
                                oLiquidacionRO.fnDelLiquidacion(txtCorrelativo.Text.Trim(), lsLiquidacionId)
                                ObtenerLiquidacionTotal(txtCorrelativo.Text.Trim())


                                pAccionFormulario = "ELQ"

                                Grabacion()

                            End If
                        Else
                            MsgBox("No puede eliminar la provisional, esta asociada con la factura " & dgvLiquidacion.Columns("codigoDocumento").CellValue(dgvLiquidacion.Row).ToString() & " " & dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString().Trim() & Chr(10), MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                        End If
                    End If
                Else
                    MsgBox("Solo se puede eliminar la ultima valorizacion", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardarLiq.Click
        Try
            Dim oLiquidacionROMod As New clsBC_LiquidacionRO
            If dgvLiquidacion.RowCount > 0 Then

                Dim oBC_TablaDetRO As New clsBC_TablaDetRO
                Dim bEstadoLiquidacion As Boolean = False
                Dim sMensaje As String = ""

                dgvLiquidacion.UpdateData()


                For a = 0 To dgvLiquidacion.Splits(0).Rows.Count - 1
                    Dim oLiquidacionROModx As New clsBC_LiquidacionRO
                    With oLiquidacionROModx.oBELiquidacion

                        oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
                        oBC_TablaDetRO.oBETablaDet.tablaDetId = IIf(cboTipo.SelectedValue = "V", cboSocio.SelectedValue, cboEmpresa.SelectedValue)
                        oBC_TablaDetRO.oBETablaDet.campo6 = dgvLiquidacion.Columns("fechaRegistro").CellValue(a).ToString().Substring(6, 4) + dgvLiquidacion.Columns("fechaRegistro").CellValue(a).ToString().Substring(3, 2)
                        oBC_TablaDetRO.LeerListaToDSEstadoPeriodos()

                        If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows.Count > 0 Then
                            If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(0)("Int_flagDeclara").ToString = "1" Then
                                bEstadoLiquidacion = True
                            Else
                                .contratoLoteId = txtCorrelativo.Text.Trim()
                                .liquidacionId = dgvLiquidacion.Columns("liquidacionId").CellValue(a).ToString()
                                .periodo = dgvLiquidacion.Columns("periodo").CellValue(a).ToString()
                                .codigoDocumento = dgvLiquidacion.Columns("codigoDocumento").CellValue(a).ToString()
                                .numeroDocumento = dgvLiquidacion.Columns("numeroDocumento").CellValue(a).ToString()
                                .fechaDocumento = Convert.ToDateTime(dgvLiquidacion.Columns("fechaDocumento").CellValue(a))
                                .valorPP = dgvLiquidacion.Columns("valorPP").CellValue(a).ToString()
                                .valorPPSol = dgvLiquidacion.Columns("valorPPSol").CellValue(a).ToString()

                                oLiquidacionROMod.LstLiquidacion.Add(oLiquidacionROModx.oBELiquidacion)
                            End If
                        Else
                            .contratoLoteId = txtCorrelativo.Text.Trim()
                            .liquidacionId = dgvLiquidacion.Columns("liquidacionId").CellValue(a).ToString()
                            .periodo = dgvLiquidacion.Columns("periodo").CellValue(a).ToString()
                            .codigoDocumento = dgvLiquidacion.Columns("codigoDocumento").CellValue(a).ToString()
                            .numeroDocumento = dgvLiquidacion.Columns("numeroDocumento").CellValue(a).ToString()
                            .fechaDocumento = Convert.ToDateTime(dgvLiquidacion.Columns("fechaDocumento").CellValue(a))
                            .valorPP = dgvLiquidacion.Columns("valorPP").CellValue(a).ToString()
                            .valorPPSol = dgvLiquidacion.Columns("valorPPSol").CellValue(a).ToString()

                            oLiquidacionROMod.LstLiquidacion.Add(oLiquidacionROModx.oBELiquidacion)

                        End If
                    End With
                Next a


                If bEstadoLiquidacion = True Then
                    MsgBox("No se puede modificar liquidaciones con PERÍODOS CERRADOS", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                    ObtenerLiquidacionTotal(txtCorrelativo.Text)

                Else
                    oLiquidacionROMod.fnModificarLiquidacion()
                    MsgBox("Grabado satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                End If

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub btnTrader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrader.Click
        Try
            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            oGeneral.LstGeneral.Clear()
            MostrarFormularioAyuda(EnumFormAyuda.Trader, oGeneral, False, parametro)
            BuscarenComboBox(cboTrader, oGeneral.oBEGeneral.NomCampo1)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub dgvPenalizable_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPenalizable.CellValueChanged
        Try
            If dgvPenalizable.Columns(e.ColumnIndex).Name = "Min" _
                Or dgvPenalizable.Columns(e.ColumnIndex).Name = "Max" _
                Or dgvPenalizable.Columns(e.ColumnIndex).Name = "Unid" _
                Or dgvPenalizable.Columns(e.ColumnIndex).Name = "Pen" Then

                CalculoPenalizables()
                ResumenGeneral()
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub dgvPagables_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellValueChanged
        Try
            If dgvPagables.Columns(e.ColumnIndex).Name = "dgvqpAjuste" Then
                Select Case dgvPagables.CurrentRow.Cells(e.ColumnIndex).EditedFormattedValue
                    Case "FIJADO"
                        dgvPagables.CurrentRow.Cells("qpInicio").Value = "FIJADO"
                        dgvPagables.CurrentRow.Cells("qpFinal").Value = "FIJADO"
                    Case "REGULAR"
                        dgvPagables.CurrentRow.Cells("qpInicio").Value = "01/01/1900"
                        dgvPagables.CurrentRow.Cells("qpFinal").Value = "01/01/1900"
                End Select

            ElseIf dgvPagables.Columns(e.ColumnIndex).Name = "Pag" _
                Or dgvPagables.Columns(e.ColumnIndex).Name = "Ded" _
                Or dgvPagables.Columns(e.ColumnIndex).Name = "RC" _
                Or dgvPagables.Columns(e.ColumnIndex).Name = "Prot" _
                Or dgvPagables.Columns(e.ColumnIndex).Name = "Precio" _
                Or dgvPagables.Columns(e.ColumnIndex).Name = "dgvTipo" _
                Or dgvPagables.Columns(e.ColumnIndex).Name = "ProtCont" Then

                If Not (dgvPagables.Item("ProtCont", e.RowIndex).Value >= 0.8 And dgvPagables.Item("ProtCont", e.RowIndex).Value <= 1) Then
                    ' dgvPagables.CurrentRow.Cells("ProtCont").Value = "1"
                Else
                    CalculoPagables()
                    ResumenGeneral()
                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub dgvPagables_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPagables.CellMouseClick
        Try
            If dgvPagables.Columns(e.ColumnIndex).Name = "dgvqpAjuste" Then
                Select Case dgvPagables.CurrentRow.Cells(e.ColumnIndex).EditedFormattedValue
                    Case "FIJADO"
                        dgvPagables.CurrentRow.Cells("qpInicio").Value = "FIJADO"
                        dgvPagables.CurrentRow.Cells("qpFinal").Value = "FIJADO"
                    Case "REGULAR"
                        dgvPagables.CurrentRow.Cells("qpInicio").Value = "01/01/1900"
                        dgvPagables.CurrentRow.Cells("qpFinal").Value = "01/01/1900"
                End Select
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLiquidacion.Click
        Try
            Dim padelanto As Decimal
            Dim ptotalliq As Decimal

            tsbGuardar_Click(Nothing, Nothing)

            padelanto = txtAdelanto.Text
            ptotalliq = txtTotal.Text

            'If padelanto > ptotalliq Then
            '    MsgBox("No puede generar liquidaciones, porque el monto del adelanto aplicado es mayor al monto de la liquidación", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
            '    Exit Sub
            'End If

            '  If ((Double.Parse(txtAdelanto.Text) + Double.Parse(txtDescuentos.Text)) > Double.Parse(txtTotal.Text)) And lblestadoliq.Text = "N/A" Then
            '     MsgBox("No puede generar liquidaciones, porque el monto del adelanto y/o descuento aplicado es mayor al monto de la liquidación", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
            '      Exit Sub
            '  End If

            If cboTipo.SelectedValue = "P" Then
                If Not ValidarLote("LIQ") Then
                    Return
                End If

                'Valida los documentos obligatorios
                Dim sMensajeValidacion As String = ValidarAdjuntarObligatorios()
                If sMensajeValidacion <> "" Then
                    MsgBox("Para proceder con la validación Contable debe adjuntar los siguientes documentos: " & Chr(10) & sMensajeValidacion, MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                End If

            End If

            If pDireccion = False Then
                MsgBox("No puede generar la liquidación, porque el proveedor no tiene registrada la dirección valida." + Chr(10) + "Ingresarla en el módulo de Maestro o solicitarlo a Contabilidad.", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Return
            End If

            ModLiquidacion.bRumaFicticia = False
            If dgvLiquidacionTM.RowCount > 0 Then
                For i = 0 To dgvLiquidacionTM.Rows.Count - 1
                    If dgvLiquidacionTM.Item("Codigo", i).Value = "RUMA" Then
                        ModLiquidacion.bRumaFicticia = True
                    End If
                Next
            End If

            ModLiquidacion.sTipoLote = cboTipo.SelectedValue
            ModLiquidacion.sNumeroLote = cboTipo.SelectedValue & txtNumero.Text & "/" & txtNumeroLote.Text

            ModLiquidacion.codLote = pstrCorrelativo
            ModLiquidacion.uc = pBEUsuario.tablaDetId
            ModLiquidacion.codTrader = cboTrader.SelectedValue
            ModLiquidacion.NomTrader = pBEUsuario.descri
            If Strings.Left(cboClase.Text, 5) = "Oxido" Or Strings.Left(cboClase.Text, 5) = "Sulfu" Then
                ModLiquidacion.Tipo = "LiquidacionxP"
            Else
                ModLiquidacion.Tipo = "Liquidacion"
            End If
            ModLiquidacion.ShowDialog()

            ObtenerLiquidacionTotal(pstrCorrelativo)
            ObtenerLiquidacionServicio(pstrCorrelativo)

            pAccionFormulario = "MTL"

            Grabacion()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Function ValidarAdjuntarObligatorios()

        Dim oBC_LiquidacionRO As New clsBC_LiquidacionRO
        Dim ntickets As Integer, nguias As Integer, nguiast As Integer, nnota As Integer, nEnsaye As Integer


        Dim sMensaje As String = ""
        Dim bDocumentoAdjunto As Boolean = False


        If cboCategoria.Text = "0000000005" Then Return ""

        ntickets = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrCorrelativo, pstrCorrelativoLiquidacion, "0000000003")
        nguias = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrCorrelativo, pstrCorrelativoLiquidacion, "0000000004")
        nguiast = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrCorrelativo, pstrCorrelativoLiquidacion, "0000000037")
        nnota = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrCorrelativo, pstrCorrelativoLiquidacion, "0000000009")
        nEnsaye = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrCorrelativo, pstrCorrelativoLiquidacion, "0000000010")

            If ntickets = 0 Then
                bDocumentoAdjunto = False
                sMensaje += "* " & "Debe completar la cantidad de Tickets" & Chr(10)
            End If

            If nguias = 0 Then
                bDocumentoAdjunto = False
                sMensaje += "* " & "Debe completar la cantidad de Guias" & Chr(10)
            End If

            If nguiast = 0 Then
                bDocumentoAdjunto = False
                sMensaje += "* " & "Debe completar la cantidad de Guias Transporte" & Chr(10)
            End If
            If nnota = 0 Then
                bDocumentoAdjunto = False
                sMensaje += "* " & "Debe adjuntar Nota de Romaneo" & Chr(10)
            End If
            If nEnsaye = 0 Then
                bDocumentoAdjunto = False
                sMensaje += "* " & "Debe adjuntar Reporte Ensaye" & Chr(10)
            End If

        Return sMensaje

    End Function


    Private Sub txtMaquila_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaquila.TextChanged
        ResumenGeneral()
    End Sub


    Private Sub dgvPagables_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvPagables.DataError

        MessageBox.Show("Error happened " & e.Context.ToString())

        If (e.Context = DataGridViewDataErrorContexts.Commit) Then
            MessageBox.Show("Commit error")
        End If
        If (e.Context = DataGridViewDataErrorContexts.CurrentCellChange) Then
            MessageBox.Show("Cell change")
        End If
        If (e.Context = DataGridViewDataErrorContexts.Parsing) Then
            MessageBox.Show("parsing error")
        End If
        If (e.Context = DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("leave control error")
        End If

        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "an error"
            view.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "an error"

            e.ThrowException = False
        End If
    End Sub

    Private Sub dgvLiquidacionTM_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles dgvLiquidacionTM.Scroll
        dgvLiquidacionTMTotal.HorizontalScrollingOffset = dgvLiquidacionTM.HorizontalScrollingOffset
    End Sub

    Private Sub dgvLiquidacionTMTotal_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles dgvLiquidacionTMTotal.Scroll
        dgvLiquidacionTM.HorizontalScrollingOffset = dgvLiquidacionTMTotal.HorizontalScrollingOffset
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged

        If cboTipo.SelectedValue.ToString = "V" Then
            Obtener_ParametrosComboEN(cboDeposito, "TB_LOCALIDAD")
            lblDeposito.Text = "Localidad"
        Else
            Obtener_ParametrosComboEN(cboDeposito, "COM_DEPOSITOS")
            lblDeposito.Text = "Deposito"
        End If
    End Sub

    Private Function lblVenta() As Object
        Throw New NotImplementedException
    End Function

    Private Sub btnAdministrador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministrador.Click
        Try
            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            oGeneral.LstGeneral.Clear()
            MostrarFormularioAyuda(EnumFormAyuda.Administrador, oGeneral, False, parametro)
            BuscarenComboBox(cboAdministrador, oGeneral.oBEGeneral.NomCampo1)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbGenerarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarFactura.Click
        Try
            Dim sLiquidacionID As String
            Dim sCodigoCalculo As String

            Dim nFilaSeleccionada As Integer
            Dim sTipoDocumento As String

            'Validar que exista liquidaaciones 
            If dgvLiquidacion.RowCount = 0 Then
                MsgBox("Primero debe generar liquidacion", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                Exit Sub
            End If


            'Validación de no imprimir notas sin tener registrado las facturas
            If dgvLiquidacion.Columns("numeroDocumento").CellValue(0).ToString() = "" Then
                MsgBox("No puede imprimir, porque no tiene registrado los datos de la factura", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                Exit Sub
            End If


            If dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString().Trim() = "0" Or dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString().Trim() = "" Then

                If MsgBox("Esta seguro de Generar el documento a la liquidación " & dgvLiquidacion.Columns("descri").CellValue(dgvLiquidacion.Row).ToString() & " " & dgvLiquidacion.Columns("numerocalculo").CellValue(dgvLiquidacion.Row).ToString(), MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then

                    sLiquidacionID = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString()
                    sCodigoCalculo = dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString()
                    sTipoDocumento = dgvLiquidacion.Columns("TipoDocumento").CellValue(dgvLiquidacion.Row).ToString()

                    If sTipoDocumento = "" Then
                        MsgBox("Solo puede generar Documentos Valorados de Facturas y Notas de Ajuste de liquidaciones Provisionales y Finales", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                    Else

                        nFilaSeleccionada = dgvLiquidacion.Row
                        GrabarAdelantoFactura(sLiquidacionID)
                        tsbGuardar_Click(Nothing, Nothing)



                        Dim pPrinter As New Drawing.Printing.PrinterSettings
                        pPrinter.PrinterName = "EPSON LX-300+ /II"

                        Dim oFactura As New frmFactura
                        oFactura.pContratoloteid = txtCorrelativo.Text.Trim() 'dgvLiquidacion.Columns("contratoloteId").CellValue(dgvLiquidacion.Row).ToString()
                        oFactura.pLiquidacionId = sLiquidacionID
                        oFactura.sTipoDocumentoValorado = sTipoDocumento 'sCodigoCalculo 'dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString()
                        oFactura.PrintDocument1.PrinterSettings = pPrinter


                        ''If oFactura.PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                        ''    oFactura.PrintDocument1.PrinterSettings = oFactura.PrintDocument1.PrinterSettings

                        oFactura.PrintDocument1.Print()

                        'Obtiene los datos de la ultima factura
                        Dim oBC_TablaDetRO As New clsBC_TablaDetRO
                        Dim oBC_TablaDetTX As New clsBC_TablaDetTX
                        Dim oBE_TablaDet As New clsBE_TablaDet
                        oBC_TablaDetRO.oBETablaDet.tablaId = "empresa"
                        oBC_TablaDetRO.oBETablaDet.tablaDetId = cboEmpresa.SelectedValue
                        oBC_TablaDetRO.LeerTablaDet()
                        oBE_TablaDet = oBC_TablaDetRO.oBETablaDet
                        'oBE_TablaDet.campo10 & " - " & oBE_TablaDet.campo11

                        'Actualiza los datos de la liquidaciion(numero de factura,fecha)
                        Dim oLiquidacionROMod As New clsBC_LiquidacionRO
                        With oLiquidacionROMod.oBELiquidacion
                            .contratoLoteId = txtCorrelativo.Text.Trim()
                            .liquidacionId = sLiquidacionID 'dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString() 'dgvLiquidacion.Columns("liquidacionId").CellValue(a).ToString()
                            '.periodo = dgvLiquidacion.Columns("periodo").CellValue(a).ToString()
                            .periodo = dgvLiquidacion.Columns("periodo").CellValue(nFilaSeleccionada).ToString()

                            If sTipoDocumento = "FT" Then
                                .numeroDocumento = oBE_TablaDet.campo10 & " - " & oBE_TablaDet.campo11
                            ElseIf sTipoDocumento = "ND" Then
                                .numeroDocumento = oBE_TablaDet.campo12 & " - " & oBE_TablaDet.campo13
                            ElseIf sTipoDocumento = "NA" Then
                                .numeroDocumento = oBE_TablaDet.campo14 & " - " & oBE_TablaDet.campo15
                            End If

                            .codigoDocumento = sTipoDocumento

                            .fechaDocumento = Convert.ToDateTime(dgvLiquidacion.Columns("fecha").CellValue(nFilaSeleccionada).ToString())
                            oLiquidacionROMod.LstLiquidacion.Add(oLiquidacionROMod.oBELiquidacion)
                        End With
                        oLiquidacionROMod.fnModificarLiquidacion()

                        'actualiza el correlativo de la factura
                        oBE_TablaDet = New clsBE_TablaDet
                        oBE_TablaDet.tablaId = "empresa"
                        oBE_TablaDet.tablaDetId = cboEmpresa.SelectedValue

                        oBE_TablaDet.campo10 = sTipoDocumento
                        oBE_TablaDet.campo12 = sTipoDocumento
                        oBE_TablaDet.campo14 = sTipoDocumento

                        oBC_TablaDetTX.LstTablaDet.Add(oBE_TablaDet)
                        oBC_TablaDetTX.ModificarTablaDet()

                        'actualiza la lista de liquidaciones
                        ObtenerLiquidacionTotal(txtCorrelativo.Text.Trim())
                        ObtenerLiquidacionDscto_AdelantosFactura(sLiquidacionID)

                        ''End If

                    End If
                End If
            Else
                MsgBox("La Factura  ya ha sido generada con el N° " & dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString(), MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


    Private Sub tsbEliminarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarFactura.Click

        If dgvLiquidacion.RowCount = 0 Then
            MsgBox("No existe liquidacion", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Exit Sub
        End If

        If dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString().Trim() = "0" Or dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString().Trim() = "" Then
            MsgBox("No existe Factura para la liquidacion Provisional " & dgvLiquidacion.Columns("numerocalculo").CellValue(dgvLiquidacion.Row).ToString(), MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Else
            If MsgBox("Esta seguro de Eliminar la fatura " & dgvLiquidacion.Columns("codigoDocumento").CellValue(dgvLiquidacion.Row).ToString() & " " & dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString().Trim() & Chr(10) & "de la provisional seleccionada?", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                Dim oLiquidacionROMod As New clsBC_LiquidacionRO
                With oLiquidacionROMod.oBELiquidacion
                    .contratoLoteId = txtCorrelativo.Text.Trim()
                    .liquidacionId = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString() 'dgvLiquidacion.Columns("liquidacionId").CellValue(a).ToString()
                    .periodo = dgvLiquidacion.Columns("periodo").CellValue(dgvLiquidacion.Row).ToString()
                    .codigoDocumento = "" 'dgvLiquidacion.Columns("codigoDocumento").CellValue(a).ToString()
                    .numeroDocumento = "0" 'oBE_TablaDet.campo10 & " - " & oBE_TablaDet.campo11 'dgvLiquidacion.Columns("numeroDocumento").CellValue(a).ToString()
                    .fechaDocumento = "01/01/1900" 'Convert.ToDateTime(dgvLiquidacion.Columns("fechaRegistro").CellValue(dgvLiquidacion.Row).ToString())
                    oLiquidacionROMod.LstLiquidacion.Add(oLiquidacionROMod.oBELiquidacion)
                End With
                oLiquidacionROMod.fnModificarLiquidacion()

                GrabarRegistro_AnulacionFactura(dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString(), dgvLiquidacion.Columns("codigoDocumento").CellValue(dgvLiquidacion.Row).ToString(), dgvLiquidacion.Columns("numeroDocumento").CellValue(dgvLiquidacion.Row).ToString(), dgvLiquidacion.Columns("fechaDocumento").CellValue(dgvLiquidacion.Row).ToString(), dgvLiquidacion.Columns("ValorNeto").CellValue(dgvLiquidacion.Row).ToString(), dgvLiquidacion.Columns("ValorIgv").CellValue(dgvLiquidacion.Row).ToString(), dgvLiquidacion.Columns("ValorTotal").CellValue(dgvLiquidacion.Row).ToString())
            End If
        End If
        'actualiza la lista de liquidaciones
        ObtenerLiquidacionTotal(txtCorrelativo.Text.Trim())
    End Sub

    Private Sub tsAsociarRumaFicticia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAsociarRumaFicticia.Click

        Dim oFactura As New frmFactura
        oFactura.txtMerma.Text = nupdMerma.Value
        oFactura.pdtLiquidacion = dtLiquidacionTM

        oFactura.txtTMHActual.Text = txtTMH.Text
        oFactura.txtH2OActual.Text = txtH20.Text
        oFactura.txtTMSActual.Text = txtTMS.Text
        oFactura.txtMermaActual.Text = nupdMerma.Value
        oFactura.txtTMNSActual.Text = txtTMSN.Text

        oFactura.txtMermaCalculado.Text = nupdMerma.Value

        '"TMH,H2O,PagCu,PagZn,PagPb,PagAg,PagAu,PenAs,PenSb,PenBi,PenZn,PenPb,PenHg,PenSiO2")

        oFactura.txtCUActual.Text = dgvLiquidacionTMTotal.Item("dgtxtCU", 0).Value
        oFactura.txtAUActual.Text = dgvLiquidacionTMTotal.Item("dgtxtAUoz", 0).Value
        oFactura.txtAGActual.Text = dgvLiquidacionTMTotal.Item("dgtxtAGoz", 0).Value
        oFactura.txtZNActual.Text = dgvLiquidacionTMTotal.Item("dgtxtZN", 0).Value
        oFactura.txtPBActual.Text = dgvLiquidacionTMTotal.Item("dgtxtPB", 0).Value

        oFactura.txtASActual.Text = dgvLiquidacionTMTotal.Item("dgtxtAS", 0).Value
        oFactura.txtSBActual.Text = dgvLiquidacionTMTotal.Item("dgtxtSB", 0).Value
        oFactura.txtBIActual.Text = dgvLiquidacionTMTotal.Item("dgtxtBI", 0).Value
        oFactura.txtSIO2.Text = dgvLiquidacionTMTotal.Item("dgtxtSIO2", 0).Value
        oFactura.txtHGActual.Text = dgvLiquidacionTMTotal.Item("dgtxtHG", 0).Value

        oFactura.txtClActual.Text = dgvLiquidacionTMTotal.Item("PenClTot", 0).Value
        oFactura.txtCdActual.Text = dgvLiquidacionTMTotal.Item("PenCdTot", 0).Value
        oFactura.txtFActual.Text = dgvLiquidacionTMTotal.Item("PenFTot", 0).Value
        oFactura.txtSActual.Text = dgvLiquidacionTMTotal.Item("PenSTot", 0).Value
        oFactura.txtFeActual.Text = dgvLiquidacionTMTotal.Item("PenFeTot", 0).Value
        oFactura.txtAl203Actual.Text = dgvLiquidacionTMTotal.Item("PenAl203Tot", 0).Value
        oFactura.txtCoActual.Text = dgvLiquidacionTMTotal.Item("PenCoTot", 0).Value
        oFactura.txtMoActual.Text = dgvLiquidacionTMTotal.Item("PenMoTot", 0).Value
        oFactura.txtPActual.Text = dgvLiquidacionTMTotal.Item("PenPTot", 0).Value


        oFactura.ShowDialog()


        If oFactura.pAsociar Then
            dvwLiquidacionTM = New DataView(dtLiquidacionTM)
            dgvLiquidacionTM.AutoGenerateColumns = False
            dgvLiquidacionTM.DataSource = dvwLiquidacionTM

            ResumenGeneral()
            tsbGuardar_Click(Nothing, Nothing)

        End If

        oFactura.Close()
    End Sub


    'Graba Facturas Anuladas
    Private Function GrabarRegistro_AnulacionFactura(ByVal sLiquidacionId As String, ByVal sCodigoDocumento As String, ByVal sNumeroFactura As String, ByVal sFechaEmision As String, ByVal sValorNeto As String, ByVal sValorIGV As String, ByVal sValorTotal As String)
        Try

            Dim oTablaDetTX As New clsBC_TablaDetTX

            Dim sTMH As String
            Dim sTMS As String
            Dim sTMNS As String
            Dim sPrecioUnitario As String

            Try

                'Obtien los datos a facturar
                Dim dsLiquidacion As DataSet
                With oLiquidacionRO.oBELiquidacion
                    .contratoLoteId = txtCorrelativo.Text
                    .liquidacionId = sLiquidacionId

                    oLiquidacionRO.LeerLiquidacuibToDSFactura()
                    dsLiquidacion = oLiquidacionRO.oDSLiquidacion
                End With


                With oLiquidacionRO.oBELiquidacion
                    .contratoLoteId = txtCorrelativo.Text
                    .liquidacionId = sLiquidacionId
                    oLiquidacionRO.LeerLiquidacion()

                    sTMH = oLiquidacionRO.oBELiquidacion.calculoTmh
                    sTMS = oLiquidacionRO.oBELiquidacion.calculoTms
                    sTMNS = oLiquidacionRO.oBELiquidacion.calculoTMSN

                    sPrecioUnitario = CDbl(sValorNeto) / CDbl(sTMNS)

                    With oTablaDetTX.oBETablaDet
                        .tablaId = "FacturaAnulada"
                        '.tablaDetId = cboTipo.SelectedValue & txtNumero.Text & "/" & txtNumeroLote.Text &
                        .descri = cboTipo.SelectedValue & txtNumero.Text & "/" & txtNumeroLote.Text & " - " & sCodigoDocumento & ": " & sNumeroFactura
                        .campo0 = txtCorrelativo.Text.Trim()
                        .campo1 = sLiquidacionId
                        .campo2 = cboTipo.SelectedValue & txtNumero.Text
                        .campo3 = txtNumeroLote.Text
                        .campo4 = cboSocio.Text
                        .campo5 = cboSocio.SelectedValue
                        .campo6 = cboEmpresa.Text
                        .campo7 = cboEmpresa.SelectedValue
                        .campo8 = sCodigoDocumento
                        .campo9 = sNumeroFactura
                        .campo10 = CDate(sFechaEmision)
                        .campo11 = FormatNumber(sTMH, 3)
                        .campo12 = FormatNumber(sTMS, 3)
                        .campo13 = FormatNumber(sTMNS, 3)
                        .campo14 = FormatNumber(sPrecioUnitario, 3)
                        .campo15 = FormatNumber(sValorNeto, 3)
                        .campo16 = txtPorImpuesto.Text 'FormatNumber(txtPorImpuesto.Text, 3)
                        .campo17 = FormatNumber(dsLiquidacion.Tables(0).Rows(0)("montoIGV").ToString, 3) 'FormatNumber(sValorIGV, 3)
                        .campo18 = FormatNumber(dsLiquidacion.Tables(0).Rows(0)("MontoNetoAPagar").ToString, 3) ' FormatNumber(sValorTotal, 3)

                        .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                        '.indicador = True
                        .uc = pBEUsuario.tablaDetId
                        .fc = Now.Date
                        oTablaDetTX.LstTablaDet.Add(oTablaDetTX.oBETablaDet)
                    End With

                End With
            Catch ex As Exception
                oMensajeError.txtMensaje.Text = ex.ToString()
                oMensajeError.ShowDialog()
            End Try

            Return oTablaDetTX.InsertarTablaDet()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function


    Private Sub InsertarFacturaAdelantos(ByVal codigo As String, Optional ByVal importe As Double = 0.0, Optional ByVal desc As String = "", Optional ByVal carta As String = "", Optional ByVal obs As String = "", Optional ByVal nro As Integer = Nothing)
        Try

            If dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString() <> "" Then
                Dim drow As DataRow
                drow = dtAdelantoFactura.NewRow
                drow("codigoDscto") = codigo
                drow("importe") = importe
                drow("descri") = desc
                drow("cartaInstruccion") = carta
                drow("observa") = obs

                drow("nro") = nro
                dtAdelantoFactura.Rows.Add(drow)
                EditarColumnasModificables(dgvAjustes, "descriDscto,importeDscto,importeTotal")
            Else
                MsgBox("Debe seleccionar una liquidación", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ObtenerLiquidacionDscto_AdelantosFactura(ByVal sLiquidacionId As String)
        Try
            Dim oBC_LiquidacionDsctoRO As New clsBC_LiquidacionDsctoRO
            With oBC_LiquidacionDsctoRO.oBELiquidacionDscto
                .contratoLoteId = txtCorrelativo.Text
                .liquidacionId = sLiquidacionId
                .liquidacionDsctoId = pstrCorrelativoLiquidacionDscto
                .codigoDscto = "AdelantoFactura"
                dtAdelantoFactura = oBC_LiquidacionDsctoRO.LeerListaToDSLiquidacionDscto.Tables(0)
                'dsPagable = dtPagable.DataSet
                dvwAdelantoFactura = New DataView(dtAdelantoFactura)
                'dvwAjuste = New DataView(oLiquidacionDsctoRO.LeerListaToDSLiquidacionDscto.Tables(0))
                dgvAdelantosFacturas.AutoGenerateColumns = False
                dgvAdelantosFacturas.DataSource = dvwAdelantoFactura
                ''EditarColumnasModificables(dgvAdelantosFacturas, "descriDscto")

            End With
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbAgregarAdelantos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        InsertarFacturaAdelantos("AdelantoFactura")
    End Sub


    Private Function GrabarAdelantoFactura(ByVal sLiquidacionId As String)
        Try
            Dim oBC_LiquidacionDsctoTX As New clsBC_LiquidacionDsctoTX
            For Each row As DataGridViewRow In dgvAdelantosFacturas.Rows
                oBC_LiquidacionDsctoTX.NuevaEntidad()
                With oBC_LiquidacionDsctoTX.oBELiquidacionDscto
                    .contratoLoteId = pstrCorrelativo
                    .liquidacionId = sLiquidacionId
                    '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
                    .codigoDscto = row.Cells("AF_CodigoDscto").Value
                    .descri = row.Cells("AF_NFact").Value
                    .observa = row.Cells("AF_Fecha").Value.ToString()
                    .importe = row.Cells("AF_Importe").Value
                    .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                    .uc = pBEUsuario.tablaDetId
                    .um = pBEUsuario.tablaDetId


                    If String.IsNullOrEmpty(row.Cells("AF_liquidacionDsctoId").Value.ToString) Then
                        .liquidacionDsctoId = ""
                        oBC_LiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oBC_LiquidacionDsctoTX.oBELiquidacionDscto)
                    Else
                        If pblnCopia Then
                            .liquidacionDsctoId = ""
                            oBC_LiquidacionDsctoTX.LstLiquidacionDsctoIns.Add(oBC_LiquidacionDsctoTX.oBELiquidacionDscto)
                        Else
                            .liquidacionDsctoId = row.Cells("AF_liquidacionDsctoId").Value
                            oBC_LiquidacionDsctoTX.LstLiquidacionDsctoUpd.Add(oBC_LiquidacionDsctoTX.oBELiquidacionDscto)
                        End If
                    End If

                End With
            Next
            'If pblnNuevo Or pblnCopia Then
            Return oBC_LiquidacionDsctoTX.InsertarDscto + oBC_LiquidacionDsctoTX.ModificarDscto

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return 0
        End Try

    End Function


    Private Sub dgvLiquidacion_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvLiquidacion.MouseClick
        ObtenerLiquidacionDscto_AdelantosFactura(dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString())
    End Sub


    Private Sub tsbGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'sLiquidacionID = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString()
        GrabarAdelantoFactura(dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString())
        'tsbGuardar_Click(Nothing, Nothing)
    End Sub

    Private Sub tsbEliminarAdelantos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim oBC_LiquidacionDsctoTX As New clsBC_LiquidacionDsctoTX
            Dim liquidacionId As String = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString()
            Dim sMensajeConfirmacion As String = "el Elemento  seleccionado"

            If liquidacionId = "" Then
                MsgBox("Debe seleccionar una liquidación", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Else
                If dgvAdelantosFacturas.RowCount > 0 Then
                    'If dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("codigoDscto").Value = "ADELANTO" Then
                    '    sMensajeConfirmacion = " TODOS los ADELANTOS asociados"
                    'End If
                    If MsgBox("Esta seguro de Eliminar " & sMensajeConfirmacion, MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                        Dim liquidacionDsctoId As String = dgvAdelantosFacturas.Rows(dgvAdelantosFacturas.CurrentCell.RowIndex).Cells("AF_liquidacionDsctoId").Value.ToString

                        If String.IsNullOrEmpty(liquidacionDsctoId) Then
                            Dim drowP As DataRow
                            drowP = BuscarenDatatable(dvwAdelantoFactura.Table, "nro", dgvAdelantosFacturas.Rows(dgvAdelantosFacturas.CurrentCell.RowIndex).Cells("AF_nro").Value)
                            drowP.Delete()
                        Else
                            oBC_LiquidacionDsctoTX.NuevaEntidad()
                            With oBC_LiquidacionDsctoTX.oBELiquidacionDscto
                                .contratoLoteId = pstrCorrelativo
                                .liquidacionId = liquidacionId
                                .liquidacionDsctoId = liquidacionDsctoId 'dgvAdelantosFacturas.Rows(dgvAdelantosFacturas.CurrentCell.RowIndex).Cells("AF_liquidacionDsctoId").Value
                                oBC_LiquidacionDsctoTX.LstLiquidacionDsctoDel.Add(oBC_LiquidacionDsctoTX.oBELiquidacionDscto)
                            End With
                            Dim drowPen As DataRow
                            drowPen = BuscarenDatatable(dvwAdelantoFactura.Table, "liquidacionDsctoId", liquidacionDsctoId)
                            drowPen.Delete()
                            ' oPagableTX.EliminarPagable()
                        End If

                        oBC_LiquidacionDsctoTX.EliminarDscto()
                    End If
                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Function CrearDirectorios(ByVal sContratoLoteId As String)

        If Not sContratoLoteId Is Nothing Then

            Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
            oBC_ContratoLoteRO.oBEContratoLote = New clsBE_ContratoLote
            oBC_ContratoLoteRO.oBEContratoLote.contratoLoteId = sContratoLoteId
            oBC_ContratoLoteRO.LeerContratoLote()

            Dim sRucEmpresa As String = oBC_ContratoLoteRO.oBEContratoLote.rucEmpresa
            Dim sRucSocio As String = oBC_ContratoLoteRO.oBEContratoLote.codigoSocio
            Dim sParametroRuta As String
            Dim sContrato As String = RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento) + RTrim(oBC_ContratoLoteRO.oBEContratoLote.contrato)
            Dim sLote As String = RTrim(oBC_ContratoLoteRO.oBEContratoLote.lote).Replace("/", "-")


            'Parametros de ruta de guardar archivos
            Dim oTablaDetRO = New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"
            oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
            oTablaDetRO.oBETablaDet.campo0 = RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento)
            oTablaDetRO.LeerListaToDSTablaDetCondicion()
            'sParametroRuta = oTablaDetRO.oBETablaDet.descri.ToString()
            sParametroRuta = oTablaDetRO.oDSTablaDet.Tables(0).Rows(0)("descri").ToString()

            Dim sRutaRucEmpresa As String = sParametroRuta + "\" + sRucEmpresa
            Dim sRutaRucSocio As String = sRutaRucEmpresa + "\" + sRucSocio
            Dim sRutaContrato As String = sRutaRucSocio + "\" + sContrato
            Dim sRutaLote As String = sRutaContrato + "\" + sContrato + "-" + sLote


            If System.IO.Directory.Exists(sRutaRucEmpresa) Then
                If System.IO.Directory.Exists(sRutaRucSocio) Then
                    If System.IO.Directory.Exists(sRutaContrato) Then
                        If System.IO.Directory.Exists(sRutaLote) Then
                        Else
                            System.IO.Directory.CreateDirectory(sRutaLote)
                        End If
                    Else
                        System.IO.Directory.CreateDirectory(sRutaContrato)
                        System.IO.Directory.CreateDirectory(sRutaLote)
                    End If
                Else
                    'System.IO.Directory.CreateDirectory(sRutaRucEmpresa)
                    System.IO.Directory.CreateDirectory(sRutaRucSocio)
                    System.IO.Directory.CreateDirectory(sRutaContrato)
                    System.IO.Directory.CreateDirectory(sRutaLote)
                End If
            Else
                System.IO.Directory.CreateDirectory(sRutaRucEmpresa)
                System.IO.Directory.CreateDirectory(sRutaRucSocio)
                System.IO.Directory.CreateDirectory(sRutaContrato)
                System.IO.Directory.CreateDirectory(sRutaLote)
            End If

            Return sRutaLote
        Else
            Return ""
        End If

        ''Return ""
    End Function


    Private Sub tsbArchivoLeyes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbArchivoLeyesLiq.Click
        Try
            CrearDirectorios(txtCorrelativo.Text)


            Dim rpcontratoLoteId As New ReportParameter()
            rpcontratoLoteId.Name = "contratoLoteId"
            rpcontratoLoteId.Values.Add(txtCorrelativo.Text)

            Dim rpliquidacionId As New ReportParameter()
            rpliquidacionId.Name = "liquidacionId"
            rpliquidacionId.Values.Add(dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString())

            Dim parameters() As ReportParameter = {rpcontratoLoteId, rpliquidacionId}


            Dim sArchivo As String
            Dim sRuta_Parametro As String
            'Parametros de ruta de guardar archivos
            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"
            oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
            oTablaDetRO.LeerTablaDet()
            sRuta_Parametro = oTablaDetRO.oBETablaDet.descri.ToString()

            'sArchivo = cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text.TrimEnd + "_" + dgvLiquidacion.Columns("numeroCalculo").CellValue(dgvLiquidacion.Row).ToString() + " " + dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString() + ".pdf"
            'sArchivo = pRucEmpresa + "_RELE_" + cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text.TrimEnd + "_" + dgvLiquidacion.Columns("numeroCalculo").CellValue(dgvLiquidacion.Row).ToString() + " " + dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString() + ".pdf"

            sArchivo = cboSocio.SelectedValue + "_RELE_" + cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text.TrimEnd + "-" + dgvLiquidacion.Columns("numeroCalculo").CellValue(dgvLiquidacion.Row).ToString() + "" + dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString() + ".pdf"

            sRuta_Parametro = sRuta_Parametro + "\" + pRucEmpresa + "\" + cboSocio.SelectedValue + "\" + cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "\" + cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text


            Dim oGenerarPDF As New frmGenerarPDF
            oGenerarPDF.pParametros = parameters
            oGenerarPDF.pRutaGenerarPDF = sRuta_Parametro + "\" + sArchivo
            'oGenerarPDF.pAbrilArchivo = True

            If System.IO.Directory.Exists(sRuta_Parametro) Then
                oGenerarPDF.bSaveFile = False


                'sArchivo = cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text.TrimEnd + "_" + dgvLiquidacion.Columns("numeroCalculo").CellValue(dgvLiquidacion.Row).ToString() + " " + dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString() + ".pdf"
                'digitalizacion
                Dim oBC_TB_DIG_INDICETX As New clsBC_TB_DIG_INDICETX
                Dim oBETB_DIG_INDICE = New clsBE_TB_DIG_INDICE
                oBETB_DIG_INDICE.ARCHIVO = sArchivo  'cboSocio.SelectedValue + "_RELE_" + cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text.TrimEnd + "_" + dgvLiquidacion.Columns("numeroCalculo").CellValue(dgvLiquidacion.Row).ToString() + " " + dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString() + ".pdf" 'sArchivo
                oBETB_DIG_INDICE.EMPRESA = pRucEmpresa
                oBETB_DIG_INDICE.CONTRATO = cboTipo.SelectedValue + txtNumero.Text
                oBETB_DIG_INDICE.LOTE = cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text
                oBETB_DIG_INDICE.NRO_DOC_INTERNO = cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text & "_" & dgvLiquidacion.Columns("numeroCalculo").CellValue(dgvLiquidacion.Row).ToString() + " " + dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString()
                oBETB_DIG_INDICE.PROVEEDOR = cboSocio.SelectedValue
                oBETB_DIG_INDICE.IDTIPODOC_DIG = "RELE"

                oBETB_DIG_INDICE.IDFLUJO = "VCM"
                oBETB_DIG_INDICE.LOTE_LIQ = cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text
                oBETB_DIG_INDICE.CONTRATO_LIQ = cboTipo.SelectedValue + txtNumero.Text.TrimEnd
                oBETB_DIG_INDICE.FECHA_DOC = Now
                oBETB_DIG_INDICE.LIQUIDACION = dgvLiquidacion.Columns("numeroCalculo").CellValue(dgvLiquidacion.Row).ToString() + " " + dgvLiquidacion.Columns("codigoCalculo").CellValue(dgvLiquidacion.Row).ToString()

                oBETB_DIG_INDICE.ESTADO = 0

                oBETB_DIG_INDICE.RUTA = pRucEmpresa + "\" + cboSocio.SelectedValue + "\" + cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "\" + cboTipo.SelectedValue + txtNumero.Text.TrimEnd + "-" + txtNumeroLote.Text

                oBETB_DIG_INDICE.ContratoLoteId = txtCorrelativo.Text
                oBETB_DIG_INDICE.LiquidacionId = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString()
                oBETB_DIG_INDICE.liquidacionAdjuntoId = "0000000008"

                oBETB_DIG_INDICE.uc = pBEUsuario.tablaDetId


                oBC_TB_DIG_INDICETX.LstTB_DIG_INDICE_INSERT.Add(oBETB_DIG_INDICE)
                oBC_TB_DIG_INDICETX.TB_DIG_INDICE_INSERT()

            Else
                oGenerarPDF.bSaveFile = True
            End If
            oGenerarPDF.pNombreReporte = "SustentoLeyes"
            oGenerarPDF.Show()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub dgvProfitLossLoteCalculado_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProfitLossLoteCalculado.CellFormatting
        Dim drv As DataGridViewRow
        If e.RowIndex >= 0 Then
            If e.RowIndex <= dgvProfitLossLoteCalculado.RowCount - 1 Then

                drv = dgvProfitLossLoteCalculado.Rows(e.RowIndex)

                If drv.Cells(0).Value = "PRE_TOTAL" Or drv.Cells(0).Value = "PRE_TOTAL_X_TMNS" Or drv.Cells(0).Value = "TOTAL_X_TMNS" Or drv.Cells(0).Value = "TOTAL" Then
                    e.CellStyle.BackColor = Color.LightGray
                ElseIf drv.Cells(0).Value = "SE01Sse" Then
                    e.CellStyle.BackColor = Color.LemonChiffon
                End If

            End If
        End If
    End Sub

    Private Sub dgvProfitLossLote_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProfitLossLote.CellFormatting
        Dim drv As DataGridViewRow
        If e.RowIndex >= 0 Then
            If e.RowIndex <= dgvProfitLossLote.RowCount - 1 Then

                drv = dgvProfitLossLote.Rows(e.RowIndex)

                If drv.Cells(0).Value = "Promedio" Then
                    e.CellStyle.BackColor = Color.LemonChiffon
                End If

            End If
        End If
    End Sub

    Private Sub tsbAbriCarpeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAbriCarpeta.Click
        Dim sParametro_Ruta As String = ""
        Dim sRuta As String

        Dim sProveedor As String = cboSocio.SelectedValue + "\"
        Dim sContrato As String = cboTipo.SelectedValue + txtNumero.Text + "\"
        Dim sLote As String = cboTipo.SelectedValue + txtNumero.Text + "-" + txtNumeroLote.Text + "\"

        sRuta = pRucEmpresa + "\" + sProveedor + sContrato + sLote

        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"
        oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
        oTablaDetRO.LeerTablaDet()
        sParametro_Ruta = oTablaDetRO.oBETablaDet.descri.ToString()

        If sRuta <> "" Then
            Dim processInfo As New ProcessStartInfo("explorer.exe", sParametro_Ruta & "\" & sRuta)
            Process.Start(processInfo)
        End If
    End Sub

    Private Sub tsbFijar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFijar.Click
        tsbGuardar_Click(Nothing, Nothing)

        Dim oFijaciones As New frmFijaciones
        oFijaciones.pPROVEEDOR = cboSocio.SelectedValue
        oFijaciones.nTMNS = txtTMSN.Text
        oFijaciones.pcontratoloteid = txtCorrelativo.Text
        oFijaciones.pliquidacionid = pstrCorrelativoLiquidacion

        oFijaciones.pcontrato = cboTipo.SelectedValue + txtNumero.Text
        oFijaciones.plocalizador = cboTipo.SelectedValue + txtNumero.Text + "/" + txtNumeroLote.Text

        oFijaciones.pCodigoClase = cboClase.SelectedText
        oFijaciones.pCodigoProducto = cboProducto.SelectedValue

        oFijaciones.ShowDialog()


        ObtenerPagables(txtCorrelativo.Text)
        ResumenGeneral()

    End Sub

    Private Sub tsbAsociarTraslado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAsociarTraslado.Click


        Try
            If String.IsNullOrEmpty(txtNumero.Text) Then
                MsgBox("Antes de asociar Rumas, primero debe asociar el lote a un Contrato", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Else

                If Not ValidarLote() Then Exit Sub

                Dim DepositoSLC As String

                If cboDeposito.SelectedIndex >= 0 Then
                    DepositoSLC = cboDeposito.SelectedValue
                Else
                    DepositoSLC = ""
                End If

                'KMN 16/10/2012
                Dim sLoteOrigen As String = ""
                If cboTipo.Text = "V" Then
                    sLoteOrigen = txtContratoLoteVenta.Text
                Else
                    If dgvLiquidacionTM.RowCount > 0 Then
                        If cboTipo.Text = "V" Then
                        Else
                            sLoteOrigen = dgvLiquidacionTM.Item("LOTE_ORIGEN", 0).Value.ToString
                        End If
                    End If
                End If


                Dim lFormulario As New frmIntermedia
                MostrarFormularioAsociacion(lFormulario, pstrCorrelativo, pstrCorrelativoLiquidacion, pstrCorrelativoLiquidacionTM, nupdMerma.Value, dtLiquidacionTM, cboTipo.SelectedValue, cboProducto.SelectedValue, cboSocio.SelectedValue, cboEmpresa.SelectedValue, DepositoSLC, sLoteOrigen, cboClase.SelectedValue, cboCategoria.SelectedValue)

                'KMN 31/08/2012
                'Valida que se haya seleccionado por lo menos una ruma
                If lFormulario.pAsociar Then

                    dvwLiquidacionTM = New DataView(dtLiquidacionTM)
                    dgvLiquidacionTM.AutoGenerateColumns = False

                    dgvLiquidacionTMTraslado.DataSource = dvwLiquidacionTM

                    ResumenGeneral()

                    pAccionFormulario = "ARR"
                    tsbGuardar_Click(Nothing, Nothing)

                End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub tsbGuardarContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardarContable.Click
        Try
            With oContratoLoteTX.oBEContratoLote
                .codigoTabla = TABLA.LOTE.Value
                .contratoLoteId = txtCorrelativo.Text
                .codigoMovimiento = cboTipo.SelectedValue
                .contrato = txtNumero.Text
                .codigoEmpresa = cboEmpresa.SelectedValue
                .codigoSocio = cboSocio.SelectedValue
                .lote = txtNumeroLote.Text
                .codigoClase = cboClase.SelectedValue

                .codigoProducto = cboProducto.SelectedValue
                .procedencia = txtprocedencia.Text
                .comentarios = txtComentarios.Text
                .codigoModo = cboModo.SelectedValue
                .codigoCalidad = cboCalidad.SelectedValue

                .categoria = cboCategoria.SelectedValue

                .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                .uc = pBEUsuario.tablaDetId
                .um = pBEUsuario.tablaDetId

                .LOTE_CERRADO = IIf(cbxLOTE_CERRADO.Checked, "", "C")

                oContratoLoteTX.LstContratoLote.Add(oContratoLoteTX.oBEContratoLote)

                oContratoLoteTX.ModificarContratoLote()
            End With

            MsgBox("Estado Contable grabado satisfactoriamente", MsgBoxStyle.Information, "Valorizador de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub Calculo_IGV()
        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "impuesto"
        oTablaDetRO.oBETablaDet.tablaDetId = "igv"
        oTablaDetRO.LeerTablaDet()

        'EXPORTACION (IGV 18%)
        If Not cboCategoria.SelectedValue Is Nothing Then
            If cboCategoria.SelectedValue.ToString = "0000000002" Then
                txtPorImpuesto.Text = 0
            Else
                txtPorImpuesto.Text = oTablaDetRO.oBETablaDet.descri.ToString()
            End If
        End If

    End Sub

    Private Sub cboCategoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCategoria.SelectedIndexChanged
        Calculo_IGV()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        RecargarForm()

        ResumenGeneral()
    End Sub

    '@01    AINI
    Private Sub cboClase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboClase.SelectedIndexChanged
        If Not cboClase.SelectedIndex = -1 Then
            ' Si es clase Produccion propia
            Dim oBC_TablaDetRO As New clsBC_TablaDetRO
            Dim oBE_TablaDet As New clsBE_TablaDet
            oBE_TablaDet.tablaDetId = cboClase.SelectedValue.ToString
            oBE_TablaDet.tablaId = "Clase"
            oBC_TablaDetRO.oBETablaDet = oBE_TablaDet

            oBC_TablaDetRO.LeerTablaDet()

            ''If oBC_TablaDetRO.oBETablaDet.campo0 = "PP" Then

            ''    ' If cboClase.SelectedValue.ToString = "0000000013" Or cboClase.SelectedValue.ToString = "0000000014" Then
            ''    ' Mostramos campos de valor para PP
            ''    txtCostoOperativo.Visible = True
            ''    lblProduccionPropia.Visible = True
            ''    txtTipoCambioPP.Visible = True
            ''    lblTipoCambioPP.Visible = True
            ''    txtValorSolesPP.Visible = True
            ''    lblValorSolesPP.Visible = True
            ''Else
            ''    ' Ocultamos campos de valor para PP
            ''    txtCostoOperativo.Visible = False
            ''    lblProduccionPropia.Visible = False
            ''    txtTipoCambioPP.Visible = False
            ''    lblTipoCambioPP.Visible = False
            ''    txtValorSolesPP.Visible = False
            ''    lblValorSolesPP.Visible = False
            ''End If
        End If
    End Sub
    '@01    AFIN





    Private Sub TabPage5_Click(sender As System.Object, e As System.EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub tsEditarRumaFicticia_Click(sender As System.Object, e As System.EventArgs) Handles tsEditarRumaFicticia.Click

        Dim oFactura As New frmFactura
        oFactura.txtMerma.Text = nupdMerma.Value
        oFactura.pdtLiquidacion = dtLiquidacionTM

        oFactura.txtTMHActual.Text = txtTMH.Text
        oFactura.txtH2OActual.Text = txtH20.Text
        oFactura.txtTMSActual.Text = txtTMS.Text
        oFactura.txtMermaActual.Text = nupdMerma.Value
        oFactura.txtTMNSActual.Text = txtTMSN.Text

        oFactura.txtMermaCalculado.Text = nupdMerma.Value

        '"TMH,H2O,PagCu,PagZn,PagPb,PagAg,PagAu,PenAs,PenSb,PenBi,PenZn,PenPb,PenHg,PenSiO2")

        oFactura.txtCUActual.Text = dgvLiquidacionTMTotal.Item("dgtxtCU", 0).Value
        oFactura.txtAUActual.Text = dgvLiquidacionTMTotal.Item("dgtxtAUoz", 0).Value
        oFactura.txtAGActual.Text = dgvLiquidacionTMTotal.Item("dgtxtAGoz", 0).Value
        oFactura.txtZNActual.Text = dgvLiquidacionTMTotal.Item("dgtxtZN", 0).Value
        oFactura.txtPBActual.Text = dgvLiquidacionTMTotal.Item("dgtxtPB", 0).Value

        oFactura.txtASActual.Text = dgvLiquidacionTMTotal.Item("dgtxtAS", 0).Value
        oFactura.txtSBActual.Text = dgvLiquidacionTMTotal.Item("dgtxtSB", 0).Value
        oFactura.txtBIActual.Text = dgvLiquidacionTMTotal.Item("dgtxtBI", 0).Value
        oFactura.txtSIO2.Text = dgvLiquidacionTMTotal.Item("dgtxtSIO2", 0).Value
        oFactura.txtHGActual.Text = dgvLiquidacionTMTotal.Item("dgtxtHG", 0).Value

        oFactura.txtClActual.Text = dgvLiquidacionTMTotal.Item("PenClTot", 0).Value
        oFactura.txtCdActual.Text = dgvLiquidacionTMTotal.Item("PenCdTot", 0).Value
        oFactura.txtFActual.Text = dgvLiquidacionTMTotal.Item("PenFTot", 0).Value
        oFactura.txtSActual.Text = dgvLiquidacionTMTotal.Item("PenSTot", 0).Value
        oFactura.txtFeActual.Text = dgvLiquidacionTMTotal.Item("PenFeTot", 0).Value
        oFactura.txtAl203Actual.Text = dgvLiquidacionTMTotal.Item("PenAl203Tot", 0).Value
        oFactura.txtCoActual.Text = dgvLiquidacionTMTotal.Item("PenCoTot", 0).Value
        oFactura.txtMoActual.Text = dgvLiquidacionTMTotal.Item("PenMoTot", 0).Value
        oFactura.txtPActual.Text = dgvLiquidacionTMTotal.Item("PenPTot", 0).Value

        oFactura.ShowDialog()

        If oFactura.pAsociar Then
            dvwLiquidacionTM = New DataView(dtLiquidacionTM)
            dgvLiquidacionTM.AutoGenerateColumns = False
            dgvLiquidacionTM.DataSource = dvwLiquidacionTM

            ResumenGeneral()
            tsbGuardar_Click(Nothing, Nothing)

        End If

        oFactura.Close()
    End Sub

    Private Sub dgvPagables_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellContentClick

    End Sub
End Class