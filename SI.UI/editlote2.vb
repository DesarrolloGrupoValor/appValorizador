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

Public Class editlote2
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

#End Region
#Region "Eventos Formulario "
    Private Sub ValidarTipoMovimiento()
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


            ctxtTotalServicios.Visible = False
            txtTotalTMSN.Visible = False
            txtAjuste.Visible = False
            txtPUnitario.Visible = False
            txtPorImpuesto.Visible = False

            txtValor.Visible = False
            txtImpuesto.Visible = False
            txtTotal.Visible = False
            txtPagar.Visible = False
            txtDescuentos.Visible = False
            txtNeto.Visible = False

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


            Dim strCadena As String = "Elem,Ley,Contenido,Precio"
            For Each sCol As DataGridViewColumn In dgvPagables.Columns
                If InStr(strCadena, sCol.Name, CompareMethod.Text) > 0 Then
                    sCol.Visible = True
                Else
                    sCol.Visible = False
                End If
            Next
        ElseIf cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VINCULADA.Value Or cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VENTA.Value Then
            lblperiodo.Visible = True
            dtPeriodo.Visible = True
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
    Private Sub editcontrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ConfiguraForm(Me)
        CargarParametros()

        cboTipo.Enabled = False
        cboProducto.Enabled = False
        cboEmpresa.Enabled = False
        cboSocio.Enabled = False
        btnsocio.Enabled = False

        cboIncoterm.Enabled = False
        cboDeposito.Enabled = False

        If pblnDesdeContrato Then
            pblnNuevo = True
            Me.Text = "Nuevo Lote-Administrador : " & pstrAdministrador
            ObtenerLote(pstrCorrelativo, True)
            pstrCorrelativoLiquidacion = "0000000001"
            pstrCorrelativoLiquidacionTM = "0000000001"
            ObtenerLiquidacion(pstrCorrelativo)
            'KMN31/08/2012
            ''ObtenerLiquidacionDscto(pstrCorrelativo)
            ''ObtenerLiquidacionServicio(pstrCorrelativo)
            ''ObtenerLiquidacionTotal(pstrCorrelativo)
            ''ObtenerLiquidacionTM(pstrCorrelativo)
            'KMN31/08/2012
            ObtenerPagables(pstrCorrelativo)
            ObtenerPenalizables(pstrCorrelativo)
            'btnContrato.Enabled = False
            txtNumeroLote.ReadOnly = False
            cboSocio.Enabled = False
            cboCalidad.Enabled = True
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

        ElseIf pblnNuevo Then
            pstrCorrelativo = Obtener_Correlativo(SI.PL.clsEnumerado.enumTipoCorrelativo.Lote)
            pstrCorrelativoLiquidacion = Obtener_Correlativo("tbLiquidacion", "liquidacionID", "contratoloteid", pstrCorrelativo)
            pstrCorrelativoLiquidacionTM = Obtener_Correlativo("tbLiquidacion", "liquidacionID", "contratoloteid", pstrCorrelativo)
            txtCorrelativo.Text = pstrCorrelativo
            txtcorrelativoliquidacion.Text = pstrCorrelativoLiquidacion
            'dtPenalizable = oValorizadorPenalizableRO.DefinirTablaValorizadorPenalizable()
            'dsPenalizable.Tables.Add(dtPenalizable)
            'dtPagable = oValorizadorPagableRO.DefinirTablaValorizadorPagable
            'dsPagable.Tables.Add(dtPagable)
            Me.Cursor = Cursors.Default
            Me.Text = "Nuevo Lote"
            DefinirAjustes()
            DefinirServicios()
            dtLiquidacionTM = oLiquidacionTMRO.DefineTablaLiquidacionTm
            dtLiquidacion = oLiquidacionRO.DefinirTablaLiquidacion
            btnContrato.Enabled = True
            txtNumeroLote.ReadOnly = False
            cboSocio.Enabled = False
            cboCalidad.Enabled = True

            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "impuesto"
            oTablaDetRO.oBETablaDet.tablaDetId = "igv"
            oTablaDetRO.LeerTablaDet()
            txtPorImpuesto.Text = oTablaDetRO.oBETablaDet.descri.ToString()

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

            ObtenerLiquidacion(strCorrelativo)
            ObtenerLiquidacionDscto(strCorrelativo + "C")
            ObtenerLiquidacionServicio(strCorrelativo)
            'ObtenerLiquidacionTotal(strCorrelativo)
            ObtenerPagables(strCorrelativo + "C")
            ObtenerPenalizables(strCorrelativo + "C")
            Me.Cursor = Cursors.Default
            Me.Text = "Copiando Lote"
            btnContrato.Enabled = False
            txtNumeroLote.ReadOnly = False
            cboSocio.Enabled = False
            cboCalidad.Enabled = True
            ValidarTipoMovimiento()

        Else
            Me.Text = "Editando Lote-Administrador : " & pstrAdministrador
            ObtenerLote(pstrCorrelativo)
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

        txtpstrAdministrador.Text = pstrAdministrador

        'dgvPagables.Columns("contenido").Frozen = True
        'dgvPagables.Columns("pu").Frozen = True
        If cboTipo.SelectedValue = "B" Then
            Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO
            dgvComposicion.DataSource = loclsBC_LiquidacionRO.fnSelDTComposicion(txtCorrelativo.Text.Trim())
        Else
            tbcTerminos.TabPages.RemoveByKey("TabPage7")
        End If


        Select Case cboTipo.SelectedValue
            Case "P", "S", "V"
                txtNumeroLote.MaxLength = 3
            Case "B"
                txtNumeroLote.MaxLength = 5
        End Select


    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        Select Case keyData
            Case Keys.Escape
                CerrarFormulario()
            Case Keys.F11

                'dgvPenalizable_CellEnter(Nothing, Nothing)
                'dgvPenalizable_CellEnter(Nothing, e)
                ResumenGeneral()

        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

#End Region

    Private Sub ObtenerLote(ByVal contratoloteid As String, Optional ByVal bTipo As Boolean = False)
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

            'txtctaanualmax.Text = oContratoLoteRO.oBEContratoLote.tmAnualMaximo
            'txtctaanualmin.Text = oContratoLoteRO.oBEContratoLote.tmAnualMinimo
            'txtctamensmax.Text = oContratoLoteRO.oBEContratoLote.tmMensualMaximo
            'txtctamensmin.Text = oContratoLoteRO.oBEContratoLote.tmMensualMinimo

            'REVISAR
            '  cboTrader.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoTRader
            'txtComentarios.Text = oContratoLoteRO.oBEContratoLote.comentaios
            'dtVigenciaFin.Value = oContratoLoteRO.oBEContratoLote.vigenciaFina
            'dtVigenciaInicio.Value = oContratoLoteRO.oBEContratoLote.vigenciaInicio
        End With

    End Sub
    Private Sub ObtenerLiquidacion(ByVal contratoloteid As String)
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

            If oLiquidacionRO.oBELiquidacion.periodo = "" Then
                oLiquidacionRO.oBELiquidacion.periodo = "190001"
            End If

            dtPeriodo.Value = Convert.ToDateTime("01/" & oLiquidacionRO.oBELiquidacion.periodo.Substring(4, 2) + "/" & oLiquidacionRO.oBELiquidacion.periodo.Substring(0, 4))

            txtPorImpuesto.Text = oLiquidacionRO.oBELiquidacion.valorIgv


            cboModo.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoTasa
            nupdPorcentaje.Value = oLiquidacionRO.oBELiquidacion.pp
            cboIncoterm.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoIncoterm
            cboDeposito.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoDeposito

            cboTrader.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoTrader

            'REVISAR
            'cboContacto.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoContacto
            'txtprocedencia.Text = oLiquidacionRO.oBELiquidacion.procedencia
        End With
    End Sub
    Private Sub ObtenerLiquidacionTM(ByVal contratoloteid As String)
        With oLiquidacionTMRO.oBELiquidacionTm
            .contratoLoteId = contratoloteid
            .liquidacionId = pstrCorrelativoLiquidacion
            .liquidacionTmId = pstrCorrelativoLiquidacionTM
            'oLiquidacionTMRO.LeerLiquidacionTm()
            txtTMH.Text = .tmh
            txtTMS.Text = .tms
            txtTMSN.Text = .tmsn
            txtH20.Text = .h2o
            'REVISAR
            'cboContacto.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoContacto
            'txtprocedencia.Text = oLiquidacionRO.oBELiquidacion.procedencia
            dtLiquidacionTM = oLiquidacionTMRO.LeerListaToDSLiquidacion.Tables(0)
            'dsPagable = dtPagable.DataSet
            dvwLiquidacionTM = New DataView(dtLiquidacionTM)


            ''KMN 05/09/2012
            ''CalculaLiquidacionTMTotal(dvwLiquidacionTM)


            dgvLiquidacionTM.AutoGenerateColumns = False
            dgvLiquidacionTM.DataSource = dvwLiquidacionTM

            dgvLiquidacionTM.Columns(0).Width = 40

            dgvLiquidacionTM.Columns(1).Width = 130

            dgvLiquidacionTM.Columns(2).Width = 50
            dgvLiquidacionTM.Columns(3).Width = 50
            dgvLiquidacionTM.Columns(4).Width = 50
            dgvLiquidacionTM.Columns(5).Width = 110
            dgvLiquidacionTM.Columns(6).Width = 80
            dgvLiquidacionTM.Columns(7).Width = 100
            dgvLiquidacionTM.Columns(8).Width = 80
            dgvLiquidacionTM.Columns(9).Width = 120
            dgvLiquidacionTM.Columns(10).Width = 120


            'EditarColumnasModificables(dgvLiquidacionTM, "TMH,H2O,PagCu,PagZn,PagPb,PagAg,PagAu,PenAs,PenSb,PenBi,PenZn,PenPb,PenHg,PenSiO2")
            EditarColumnasModificables(dgvLiquidacionTM, "")
            EditarColumnasModificables(dgvLiquidacionTMTotal, "")
            dgvLiquidacionTM.Columns("PagAg").Visible = False
            dgvLiquidacionTM.Columns("PagAu").Visible = False
            'dvwAjuste = New DataView(oLiquidacionDsctoRO.LeerListaToDSLiquidacionDscto.Tables(0))
            'dgvRumas.AutoGenerateColumns = False
            'dgvRumas.DataSource = dvwLogisticaMovimiento
        End With
    End Sub
    Private Sub ObtenerLiquidacionDscto(ByVal contratoloteid As String)
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
            EditarColumnasModificables(dgvAjustes, "descriDscto,importeDscto")
        End With
    End Sub
    Private Sub ObtenerLiquidacionServicio(ByVal contratoloteid As String)
        With oLiquidacionServicioRO.oBELiquidacionServicio
            .contratoLoteId = contratoloteid
            .liquidacionId = pstrCorrelativoLiquidacion
            .liquidacionServicioId = pstrCorrelativoLiquidacionServicio
            dtServicio = oLiquidacionServicioRO.LeerListaToDSLiquidacionServicio.Tables(0)
            'dsPagable = dtPagable.DataSet
            dvwServicio = New DataView(dtServicio)
            'dvwServicio = New DataView(oLiquidacionServicioRO.LeerListaToDSLiquidacionServicio.Tables(0))
            dgvServicios.AutoGenerateColumns = False
            dgvServicios.DataSource = dvwServicio
            EditarColumnasModificables(dgvServicios, "descriServicio,importeServicio,dgvcalculoservicio")
        End With
    End Sub
    Private Sub ObtenerLiquidacionTotal(ByVal contratoloteid As String)
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
            dgvLiquidacion.Splits(0).DisplayColumns("Eliminar").Visible = False
            dgvLiquidacion.Splits(0).DisplayColumns("liquidacionid").Visible = False

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

            dgvLiquidacion.Columns("codigoDocumento").DropDown = C1TrueDBDropdown1
            dgvLiquidacion.Columns("codigoDocumento").ValueItems.Translate = True
            C1TrueDBDropdown1.ValueTranslate = True

        End With
    End Sub
    Private Sub ObtenerPagables(ByVal contratoloteid As String)
        With oValorizadorPagableRO.oBEValorizadorPagable
            .contratoLoteId = contratoloteid
            .liquidacionId = "0000000001"
        End With
        dtPagable = oValorizadorPagableRO.LeerListaToDSPagable.Tables(0)
        dvwPagable = New DataView(dtPagable)
        dgvPagables.AutoGenerateColumns = False
        dgvPagables.DataSource = dvwPagable

    End Sub
    Private Sub ObtenerPenalizables(ByVal contratoloteid As String)
        With oValorizadorPenalizableRO.oBEValorizadorPenalizable
            .contratoLoteId = contratoloteid
            .liquidacionId = "0000000001" 'pstrCorrelativoLiquidacion
        End With
        dtPenalizable = oValorizadorPenalizableRO.LeerListaToDSValorizadorPenalizable.Tables(0)
        dvwPenalizable = New DataView(dtPenalizable)
        dgvPenalizable.AutoGenerateColumns = False
        dgvPenalizable.DataSource = dvwPenalizable

    End Sub

    Private Sub CargarParametros()
        Obtener_ParametrosCombo(cboIncoterm, clsUT_Dominio.domTABLA_DE_INCOTERM, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboDeposito, clsUT_Dominio.domTABLA_DE_DEPOSITO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboClase, clsUT_Dominio.domTABLA_DE_CLASES, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboCalidad, "Calidad", SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboProducto, clsUT_Dominio.domTABLA_DE_PRODUCTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        'Obtener_ParametrosCombo(cboSocio, clsUT_Dominio.domTABLA_DE_SOCIO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        'Obtener_ParametrosCombo(cboTipo, clsUT_Dominio.domTABLA_DE_MOVIMIENTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion) MH 10112011
        If pBEUsuario.campo2.Length > 0 Then
            ObtenerTipoMovimientoCombo(cboTipo, pBEUsuario.campo2)
        Else
            ObtenerTipoMovimientoCombo(cboTipo)
        End If

        Obtener_ParametrosCombo(tsCboAjuste, clsUT_Dominio.domTABLA_DE_AJUSTES, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(tsCboServicio, clsUT_Dominio.domTABLA_DE_SERVICIOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

        'Obtener_ParametrosCombo(cboMetalPen, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        'Obtener_ParametrosCombo(cboMercado, clsUT_Dominio.domMERCADO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        'Obtener_ParametrosCombo(cboMetalPag, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        'Obtener_ParametrosCombo(cboDeducccion, clsUT_Dominio.domTIPO_DE_DEDUCCION, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        'Obtener_ParametrosCombo(cboQpTipo, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        'Obtener_ParametrosCombo(cboQpAjuste, clsUT_Dominio.domTIPO_DE_AJUSTE_DE_QP, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        ' C1cboSocio.ClearItems()
        ' Obtener_ParametrosC1Combo(C1cboSocio, clsUT_Dominio.domTABLA_DE_SOCIO, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboSocio, clsUT_Dominio.domTABLA_DE_SOCIO, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboModo, "Modo", SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IDCodigoDescripcion)
        'Obtener_ParametrosC1Combo(cbofa, clsUT_Dominio.domFACTURADOR, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(cboTrader, clsUT_Dominio.domTRADER, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        ' Obtener_ParametrosCombo(cboContacto, clsUT_Dominio.domTABLA_DE_CONTACTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        'C1Combo1.Columns(0).Caption = "Codigo"
        'C1Combo1.Columns(1).Caption = "Descripcion"
        'C1Combo1.Columns(2).Caption = "prueba"
        'C1Combo1.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownCombo
        'C1Combo1.DataMode = C1.Win.C1List.DataModeEnum.Normal

        'C1Combo1.Splits(0).DisplayColumns(3).Visible = False
        'C1Combo1.Rebind(False)
        'C1Combo1.Splits(0).DisplayColumns(4).Visible = False
        'C1Combo1.Splits(0).DisplayColumns(5).Visible = False
        'C1Combo1.Splits(0).DisplayColumns(6).Visible = False
        'C1Combo1.Splits(0).DisplayColumns(7).Visible = False
        'For Each cbocol As C1.Win.C1List.C1DataColumn In C1Combo1.Columns
        Obtener_ParametrosGridView(dgvTipo, clsUT_Dominio.domTIPO_DE_DEDUCCION)
        Obtener_ParametrosGridView(dgvMerc, clsUT_Dominio.domMERCADO)
        Obtener_ParametrosGridView(dgvCalculoServicio, "CalculoServicio")

        Obtener_ParametrosGridView(dgvqpAjuste, clsUT_Dominio.domTIPO_DE_AJUSTE_DE_QP)
        Obtener_ParametrosGridView(dgvQP, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION)

        Obtener_ParametrosCombo(tsCboPagable, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Obtener_ParametrosCombo(tsCboPenalizable, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        EditarColumnasModificables(dgvPenalizable, "min,max,unid,pen,indLey")
        'EditarColumnasModificables(dgvPenalizable, "leyp,min,max,unid,pen,indLey")
        EditarColumnasModificables(dgvPagables, "pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")
        'EditarColumnasModificables(dgvPagables, "ley,pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")
    End Sub


    Private Function GrabarRegistro()

        Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO

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

            '.tmAnualMaximo = txtctaanualmax.Text
            '.tmAnualMinimo = txtctaanualmin.Text
            '.tmMensualMaximo = txtctamensmax.Text
            '.tmMensualMinimo = txtctamensmin.Text
            '.cuota = dtCuota.Value
            'REVISAR
            '.comentarios = txtComentarios.Text
            '.codigoTrader = cboTrader.SelectedValue
            '.vigenciaInicio = dtVigenciaInicio.Value
            '.vigenciaFinal = dtVigenciaFin.Value

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

            'Actualizar los cambios hechos en la base de datos intermedia
            oMovimientoTX.ActualizaEstadoBtnOK(txtCorrelativo.Text, "0000000001") ' siempre es el actual

            'Return True
        End If


        loclsBC_LiquidacionRO.fnCalculaLote()
        loclsBC_LiquidacionRO.fnCalculaVinculada()
        loclsBC_LiquidacionRO.fnCalculaMezcla()
        loclsBC_LiquidacionRO.fnCalculaVinculada()
        loclsBC_LiquidacionRO.fnCalculaMezcla()
        loclsBC_LiquidacionRO.fnCalculaLote()

        Return True

    End Function
    Private Function GrabarLiquidacionTm()
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
                .guia = row.Cells("guia").Value
                .fecha_ingreso = row.Cells("ingreso").Value
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
        'If pblnNuevo Or pblnCopia Then
        Return oLiquidacionTMTX.InsertarLiquidacion + oLiquidacionTMTX.ModificarLiquidacionTm

    End Function

    Private Function GrabarEstadoLiquidacionTM()

    End Function
    Private Sub ActualizarEstadoLogistica(ByVal id As Integer, Optional ByVal contratoloteid As String = "", Optional ByVal estado As String = "", Optional ByVal liquidacionid As String = "", Optional ByVal liquidaciontmid As String = "")
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

    End Sub
    Private Sub ActualizarEstadoLogisticaDesasociar(ByVal piId As Long)
        oMovimientoTX.ActualizaEstadoLogisticaDesasociar(piId)
    End Sub
    Private Function Grabarliquidacion()

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

            If cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VINCULADA.Value Or cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VENTA.Value Then

                .periodo = dtPeriodo.Value.Year.ToString + dtPeriodo.Value.Month.ToString

                If dtPeriodo.Value.Month > 9 Then
                    .periodo = dtPeriodo.Value.Year.ToString + dtPeriodo.Value.Month.ToString
                Else
                    .periodo = dtPeriodo.Value.Year.ToString + "0" + dtPeriodo.Value.Month.ToString
                End If

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
            End If

            'REVISAR
            '.codigoContacto = cboContacto.SelectedValue
            '.procedencia = txtprocedencia.Text
            '''''.cuota = dtCuota.Value
            .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
            .uc = pBEUsuario.tablaDetId
            .um = pBEUsuario.tablaDetId
            .codigoAdministrador = pBEUsuario.tablaDetId
            oLiquidacionTX.LstLiquidacion.Add(oLiquidacionTX.oBELiquidacion)
        End With
        If pblnNuevo Or pblnCopia Then
            Return oLiquidacionTX.InsertarLiquidacion
        Else
            Return oLiquidacionTX.ModificarLiquidacion
        End If
    End Function
    Private Function GrabarPagables()
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

                ''.finLey = IIf(IsDBNull(row.Cells("FinLey").Value), "0", IIf((row.Cells("FinLey").Value), "1", "0")) ' IIf((row.Cells("FinLey").Value), "1", "0")
                ' ''.finPrecio = IIf((row.Cells("FinPrecio").Value), "1", "0")
                ''.finPrecio = IIf(IsDBNull(row.Cells("FinPrecio").Value), "0", IIf((clsUT_Funcion.DbValueToNullable(Of Double)(row.Cells("FinPrecio").Value).GetValueOrDefault), "1", "0")) ' IIf((clsUT_Funcion.DbValueToNullable(Of Double)(row.Cells("FinPrecio").Value).GetValueOrDefault), "1", "0")

                If String.IsNullOrEmpty(row.Cells("liquidacionpagable").Value) Then
                    .liquidacionPagable = "" ' ObtenerCorrelativoPagable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                    oPagableTX.LstValorizadorPagableIns.Add(oPagableTX.oBEValorizadorPagable)
                Else
                    If pblnCopia Or pblnNuevo Then
                        .liquidacionPagable = "" ' ObtenerCorrelativoPagable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                        oPagableTX.oBEValorizadorPagableins = oPagableTX.oBEValorizadorPagable
                        oPagableTX.LstValorizadorPagableIns.Add(oPagableTX.oBEValorizadorPagableIns)
                    Else
                        .liquidacionPagable = row.Cells("liquidacionpagable").Value
                        oPagableTX.oBEValorizadorPagableUpd = oPagableTX.oBEValorizadorPagable
                        oPagableTX.LstValorizadorPagableUpd.Add(oPagableTX.oBEValorizadorPagableUpd)

                    End If
                End If
                'If pblnNuevo Then
                '    .liquidacionPagable = ""
                '    oPagableTX.LstValorizadorPagableIns.Add(oPagableTX.oBEValorizadorPagable)
                'Else
                '    .liquidacionPagable = row.Cells("liquidacionpagable").Value
                '    oPagableTX.LstValorizadorPagableUpd.Add(oPagableTX.oBEValorizadorPagable)
                'End If

            End With
        Next

        Return oPagableTX.InsertarPagable + oPagableTX.ModificarPagable

    End Function
    Private Function GrabarPenalizables()

        For Each row As DataGridViewRow In dgvPenalizable.Rows
            oPenalizableTX.NuevaEntidad()
            With oPenalizableTX.oBEValorizadorPenalizable
                .contratoLoteId = pstrCorrelativo
                .liquidacionId = pstrCorrelativoLiquidacion
                ' .liquidacionTmId = pstrCorrelativoLiquidacionTM
                '.liquidacionPenalizableId = row.Cells("liquidacionPenalizableId").Value

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
                'If pblnNuevo Then
                '    .liquidacionPenalizableId = "" 'ObtenerCorrelativoPenalizable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                '    oPenalizableTX.LstValorizadorPenalizableIns.Add(oPenalizableTX.oBEValorizadorPenalizable)
                'Else
                '    .liquidacionPenalizableId = row.Cells("liquidacionPenalizableId").Value
                '    oPenalizableTX.LstValorizadorPenalizableUpd.Add(oPenalizableTX.oBEValorizadorPenalizable)
                'End If
            End With
        Next
        'If pblnNuevo Or pblnCopia Then
        Return oPenalizableTX.InsertarPenalizable + oPenalizableTX.ModificarPenalizable
        'Else
        '    Return oPenalizableTX.ModificarValorizadorPenalizable
        'End If
    End Function
    Private Function GrabarAjustes()
        For Each row As DataGridViewRow In dgvAjustes.Rows
            oLiquidacionDsctoTX.NuevaEntidad()
            With oLiquidacionDsctoTX.oBELiquidacionDscto
                .contratoLoteId = pstrCorrelativo
                .liquidacionId = pstrCorrelativoLiquidacion
                '.liquidacionDsctoId = Obtener_Correlativo("tbLiquidacionDscto", "liquidacionDsctoId", "contratoloteid", pstrCorrelativo, "liquidacionId", pstrCorrelativoLiquidacion)
                .codigoDscto = row.Cells("codigoDscto").Value
                .descri = row.Cells("descriDscto").Value
                .importe = row.Cells("importeDscto").Value
                .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                .uc = pBEUsuario.tablaDetId
                .um = pBEUsuario.tablaDetId
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
        'If pblnNuevo Or pblnCopia Then
        Return oLiquidacionDsctoTX.InsertarDscto + oLiquidacionDsctoTX.ModificarDscto
        'Else
        '    Return oPenalizableTX.ModificarValorizadorPenalizable
        'End If
    End Function
    Private Function GrabarServicios()
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
        'If pblnNuevo Or pblnCopia Then
        Return oLiquidacionServicioTX.Insertarservicio + oLiquidacionServicioTX.Modificarservicio
        'Else
        '    Return oPenalizableTX.ModificarValorizadorPenalizable
        'End If
    End Function
    Private Function ValidarLote()
        Dim strmensaje As String = ""

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
        'If dvwPenalizable IsNot Nothing Then
        '    If dvwPenalizable.Table.Rows.Count <= 0 Then
        '        strmensaje = strmensaje & "* Contrato Seleccionado no tiene Penalizables" & vbCrLf
        '    End If
        'Else
        '    strmensaje = strmensaje & "* Contrato Seleccionado no tiene Penalizables" & vbCrLf
        'End If

        If strmensaje.Length > 0 Then
            MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
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
        ' ResaltarTodo()

        txtNumero.Focus()

        'ObtenerLiquidacionTM(pstrCorrelativo)

        ResumenGeneral()

        If Not ValidarLote() Then Exit Sub
        If Not ValidarLiquidacion() Then Exit Sub

        'If MsgBox("Esta seguro de guardar el registro", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
        'Then
        'If Not ValidarLiquidacion() Then Exit Sub
        Me.Cursor = Cursors.AppStarting
        txtNumeroLote.Focus()

        Grabacion()

        Me.Cursor = Cursors.Default


        'End If
    End Sub

    Private Sub Grabacion()
        If GrabarRegistro() Then

            If pblnNuevo Then pblnNuevo = False

            pblnCopia = False

            RecargarForm()

            ResumenGeneral()

        End If
    End Sub


    Private Sub RecargarForm()

        oContratoLoteTX = New clsBC_ContratoLoteTX
        oLiquidacionTX = New clsBC_LiquidacionTX
        oPagableTX = New clsBC_ValorizadorPagableTX
        oPenalizableTX = New clsBC_ValorizadorPenalizableTX
        oMovimientoTX = New clsBC_LogisticaMovimientoTX
        oLiquidacionServicioTX = New clsBC_LiquidacionServicioTX
        oLiquidacionDsctoTX = New clsBC_LiquidacionDsctoTX
        oLiquidacionTMTX = New clsBC_LiquidacionTmTX



        dtPagable.Rows.Clear()
        dtPagable.Rows.Clear()
        dtPenalizable.Rows.Clear()
        Me.Text = "Editando Lote-Administrador : " & pstrAdministrador
        ObtenerLote(pstrCorrelativo)
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

        'oValorizadorPagableRO.LstValorizadorPagable.Clear()
        'oValorizadorPenalizableRO.LstValorizadorPenalizable.Clear()
    End Sub


    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click, tsmSalir.Click
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
    End Sub
    Private Sub CerrarFormulario()
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
    End Sub
    Private Sub txtbase1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

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
        If strmensaje.Length > 0 Then
            MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
            Return False
        End If
        Return True
    End Function
#End Region
#Region "Pagable"
    Private Sub EditandoPagables()
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

    End Sub

#End Region
#Region "Penalizable"
    Private Sub EditandoPenalizables()
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

    End Sub

#End Region



    Private Sub nupdPorcentaje_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        nupdPorcentaje.Select(0, nupdPorcentaje.Text.Length)
    End Sub
    Private Sub nupdPorcPago_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupdPorcPago.GotFocus

        nupdPorcPago.Select(0, nupdPorcPago.Text.Length)
    End Sub

    Private Sub txtNumero_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown, txtNumeroLote.KeyDown
        'Select Case e.KeyCode
        '    Case Keys.F4
        '        Dim oGeneral As New clsBC_GeneralRO
        '        Dim parametro As New Hashtable
        '        Dim strCorrelativo As String
        '        'parametro("id_oferta") = 
        '        oGeneral.LstGeneral.Clear()
        '        MostrarFormularioAyuda(EnumFormAyuda.Contratos, oGeneral, False, parametro)
        '        If Not oGeneral Is Nothing Then
        '            If oGeneral.LstGeneral.Count > 0 Then
        '                If dgvPagables.Rows.Count > 0 Or dgvPenalizable.Rows.Count > 0 Then
        '                    If MsgBox("Esta seguro de cambiar el contrato asociado", MsgBoxStyle.YesNo, " Valorizador de Minerales") = MsgBoxResult.Yes Then
        '                        strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo1.ToString
        '                        oContratoLoteRO.oBEContratoLote.contratoLoteId = strCorrelativo
        '                        oContratoLoteRO.LeerContratoLote()
        '                        txtNumero.Text = oContratoLoteRO.oBEContratoLote.contrato.Trim
        '                        cboTipo.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoMovimiento

        '                        cboEmpresa.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoEmpresa
        '                        cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
        '                        'cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
        '                        cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto
        '                        'txtctaanualmax.Text = oContratoLoteRO.oBEContratoLote.tmAnualMaximo
        '                        'txtctaanualmin.Text = oContratoLoteRO.oBEContratoLote.tmAnualMinimo
        '                        'txtctamensmax.Text = oContratoLoteRO.oBEContratoLote.tmMensualMaximo
        '                        'txtctamensmin.Text = oContratoLoteRO.oBEContratoLote.tmMensualMinimo
        '                        ObtenerPagables(strCorrelativo)
        '                        ObtenerPenalizables(strCorrelativo)
        '                    End If
        '                Else
        '                    strCorrelativo = oGeneral.LstGeneral.Item(0).NomCampo1.ToString
        '                    oContratoLoteRO.oBEContratoLote.contratoLoteId = strCorrelativo
        '                    oContratoLoteRO.LeerContratoLote()
        '                    txtNumero.Text = oContratoLoteRO.oBEContratoLote.contrato.Trim
        '                    cboTipo.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoMovimiento

        '                    cboEmpresa.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoEmpresa
        '                    cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
        '                    'cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
        '                    cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto
        '                    'txtctaanualmax.Text = oContratoLoteRO.oBEContratoLote.tmAnualMaximo
        '                    'txtctaanualmin.Text = oContratoLoteRO.oBEContratoLote.tmAnualMinimo
        '                    'txtctamensmax.Text = oContratoLoteRO.oBEContratoLote.tmMensualMaximo
        '                    'txtctamensmin.Text = oContratoLoteRO.oBEContratoLote.tmMensualMinimo
        '                    ObtenerPagables(strCorrelativo)
        '                    ObtenerPenalizables(strCorrelativo)
        '                End If


        '            End If
        '        End If
        'End Select
    End Sub

    Private Sub dgvPagables_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellEndEdit

    End Sub




    Private Sub dgvPagables_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPagables.DataError

    End Sub

    Private Sub txbGenerarLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MostrarFormularioLiquidacion(pstrCorrelativo)
    End Sub

    Private Sub tsbAsociarTM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAsociarTM.Click
        If String.IsNullOrEmpty(txtNumero.Text) Then
            MsgBox("Antes de asociar Rumas, primero debe asociar el lote a un Contrato", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Else
            'oLogisticaMovimientoRO.LstLogisticaMovimiento

            Dim DepositoSLC As String

            If cboDeposito.SelectedIndex >= 0 Then
                Dim oTablaDetRO As New clsBC_TablaDetRO
                oTablaDetRO.oBETablaDet.tablaId = "Deposito"
                oTablaDetRO.oBETablaDet.tablaDetId = CType(cboDeposito.SelectedItem, clsBE_General).Codigo_Retorna
                oTablaDetRO.LeerTablaDet()
                DepositoSLC = oTablaDetRO.oBETablaDet.campo0
            Else
                DepositoSLC = ""
            End If


            'If cboTipo.Text = "S" Then
            '    MostrarFormularioAsociacion(pstrCorrelativo, pstrCorrelativoLiquidacion, pstrCorrelativoLiquidacionTM, nupdMerma.Value, dtLiquidacionTM, cboTipo.SelectedValue, cboProducto.SelectedValue, DepositoSLC)
            'Else
            '    MostrarFormularioAsociacion(pstrCorrelativo, pstrCorrelativoLiquidacion, pstrCorrelativoLiquidacionTM, nupdMerma.Value, dtLiquidacionTM, cboTipo.SelectedValue, cboProducto.SelectedValue, cboSocio.SelectedValue)
            'End If

            Dim lFormulario As New frmIntermedia
            MostrarFormularioAsociacion(lFormulario, pstrCorrelativo, pstrCorrelativoLiquidacion, pstrCorrelativoLiquidacionTM, nupdMerma.Value, dtLiquidacionTM, cboTipo.SelectedValue, cboProducto.SelectedValue, cboSocio.SelectedValue, cboEmpresa.SelectedValue, DepositoSLC)

            'KMN 31/08/2012
            'Valida que se haya seleccionado por lo menos una ruma
            If lFormulario.pAsociar Then

                dvwLiquidacionTM = New DataView(dtLiquidacionTM)
                dgvLiquidacionTM.AutoGenerateColumns = False



                dgvLiquidacionTM.DataSource = dvwLiquidacionTM
                'CargarAsociacionTM()
                'EditarColumnasModificables(dgvLiquidacionTM, "TMH,H2O,PagCu,PagZn,PagPb,PagAg,PagAu,PenAs,PenSb,PenBi,PenZn,PenPb,PenHg,PenSiO2")
                'CalculoPagables()
                'ResumenRumas()
                'ResumenServicios()
                ResumenGeneral()

                tsbGuardar_Click(Nothing, Nothing)

            End If
        End If

    End Sub

    ''Private Sub CalculaLiquidacionTMTotal(ByVal dvwDataRowView As DataView)
    Private Sub CalculaLiquidacionTMTotal()
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

        If dtLiquidacionTM Is Nothing Then

        Else
            For Each row As DataRow In dtLiquidacionTM.Rows
                If row.RowState <> DataRowState.Deleted Then
                    _TMH = row.Item("TMH")
                    _H2O = 0
                    _TMS = Math.Round(_TMH - (_TMH * row.Item("h2o") / 100), 3) ' MH 01112011
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

                    xTMH = xTMH + _TMH
                    xTMS = xTMS + _TMS
                    xTMSN = xTMSN + _TMSN
                End If



            Next

            xTMH = IIf(xTMH = 0, 1, xTMH)
            xTMS = IIf(xTMS = 0, 1, xTMS)
            xTMSN = IIf(xTMSN = 0, 1, xTMSN)

            xH2O = IIf(xTMH = 0, 0, (xTMH - xTMS) / xTMH * 100)

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






            ' ''KMN 04/09/2012
            ' ''Agrega los totales en la liquidacionTM
            ''Dim dvliquidacionTMTotales As DataView = dvwDataRowView
            ''Dim drliquidacionTMTotales As DataRowView = dvliquidacionTMTotales.AddNew()

            ''drliquidacionTMTotales("id") = "100"
            ''drliquidacionTMTotales("tmh") = xTMH.ToString
            ''drliquidacionTMTotales("h2o") = xH2O.ToString
            ''drliquidacionTMTotales("tms") = xTMS.ToString
            ''drliquidacionTMTotales("merma") = xMerma.ToString
            ''drliquidacionTMTotales("tmsn") = xTMSN.ToString

            ''drliquidacionTMTotales("PagCu") = Math.Round(xPagCU, 4).ToString
            ''drliquidacionTMTotales("PagAg") = Math.Round(xPagAG, 4).ToString()
            ''drliquidacionTMTotales("PagAgOz") = Math.Round(xPagAGoz, 4).ToString()
            ''drliquidacionTMTotales("PagAu") = Math.Round(xPagAU, 4).ToString()
            ''drliquidacionTMTotales("PagAuOz") = Math.Round(xPagAUoz, 4).ToString()
            ''drliquidacionTMTotales("PenPb") = Math.Round(xPagPB, 4).ToString()
            ''drliquidacionTMTotales("PenZn") = Math.Round(xPagZN, 4).ToString()
            ' ''newRow("PenSn") = xPagSN.ToString()
            ''drliquidacionTMTotales("PenAs") = Math.Round(xPagAS, 4).ToString()
            ''drliquidacionTMTotales("PenSb") = Math.Round(xPagSB, 4).ToString()
            ''drliquidacionTMTotales("PenBi") = Math.Round(xPagBI, 4).ToString()
            ''drliquidacionTMTotales("PenHg") = Math.Round(xPagHG, 4).ToString()
            ''drliquidacionTMTotales("PenSiO2") = Math.Round(xPagSIO2, 4).ToString()
            ''drliquidacionTMTotales("Pen1") = Math.Round(xPagASSB, 4).ToString()
            ''drliquidacionTMTotales("Pen2") = Math.Round(xPagZNPB, 4).ToString()

            ''drliquidacionTMTotales.EndEdit()

            ' ''dvwDataRowView = dvliquidacionTMTotales
            ' ''KMN 04/09/2012




            dtLiquidacionTMTotal.Rows.Add(RowTotal)

            dvwLiquidacionTMTotal = New DataView(dtLiquidacionTMTotal)
            dgvLiquidacionTMTotal.AutoGenerateColumns = False

            dgvLiquidacionTMTotal.DataSource = dvwLiquidacionTMTotal
            dgvLiquidacionTMTotal.Refresh()

            dgvLiquidacionTMTotal.Columns(0).Width = 170
            dgvLiquidacionTMTotal.Columns(1).Width = 50
            dgvLiquidacionTMTotal.Columns(2).Width = 50
            dgvLiquidacionTMTotal.Columns(3).Width = 50
            dgvLiquidacionTMTotal.Columns(4).Width = 80
            dgvLiquidacionTMTotal.Columns(5).Width = 110
            dgvLiquidacionTMTotal.Columns(6).Width = 100
            dgvLiquidacionTMTotal.Columns(7).Width = 80
            dgvLiquidacionTMTotal.Columns(8).Width = 120
            dgvLiquidacionTMTotal.Columns(9).Width = 120

            ActualizandoLeyes()

            ActualizandoPrecios()

        End If



    End Sub

    Private Sub ActualizandoLeyes()

        If dtPagable Is Nothing Then

        Else
            For Each row As DataRow In dtPagable.Rows

                If row.RowState.ToString = "Deleted" Then
                Else
                    ''row.Item("leypagable") = IIf(row.Item("codigoelemento") = "CU" And Not row.Item("indley"), dtLiquidacionTMTotal.Rows(0).Item("pagcu").ToString, row.Item("leypagable"))
                    ''row.Item("leypagable") = IIf(row.Item("codigoelemento") = "PB" And Not row.Item("indley"), dtLiquidacionTMTotal.Rows(0).Item("penpb").ToString, row.Item("leypagable"))
                    ''row.Item("leypagable") = IIf(row.Item("codigoelemento") = "ZN" And Not row.Item("indley"), dtLiquidacionTMTotal.Rows(0).Item("penzn").ToString, row.Item("leypagable"))
                    ''row.Item("leypagable") = IIf(row.Item("codigoelemento") = "AG" And Not row.Item("indley"), dtLiquidacionTMTotal.Rows(0).Item("pagag").ToString, row.Item("leypagable"))
                    ''row.Item("leypagable") = IIf(row.Item("codigoelemento") = "AU" And Not row.Item("indley"), dtLiquidacionTMTotal.Rows(0).Item("pagau").ToString, row.Item("leypagable"))


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

                End If

            Next

        End If

    End Sub

    Private Sub ActualizandoPrecios()
        Try
            If dtPagable Is Nothing Then

            Else


                For Each row As DataRow In dtPagable.Rows

                    Dim oTablaDetRO As New clsBC_TablaDetRO
                    oTablaDetRO.oBETablaDet.tablaId = "Metal"
                    oTablaDetRO.oBETablaDet.tablaDetId = row.Item("codigoelemento")
                    oTablaDetRO.LeerTablaDet()

                    row.Item("precio") = IIf(row.Item("codigoelemento") = "CU" And row.Item("indpre") = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                    row.Item("precio") = IIf(row.Item("codigoelemento") = "PB" And row.Item("indpre") = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                    row.Item("precio") = IIf(row.Item("codigoelemento") = "ZN" And row.Item("indpre") = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                    row.Item("precio") = IIf(row.Item("codigoelemento") = "AG" And row.Item("indpre") = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                    row.Item("precio") = IIf(row.Item("codigoelemento") = "AU" And row.Item("indpre") = 0, oTablaDetRO.oBETablaDet.campo4.ToString, row.Item("precio"))
                Next
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub ResumenGeneral()

        'KMN 04/09/2012
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
            If dvwServicio.Count > 0 Then dblTotalServicios = "-" & dvwServicio.Table.Compute("Sum(importe)", "") 'txtTotalServicios.Text
        End If


        Dim dblTotalAjustes As Double


        Try

            If dvwAjuste IsNot Nothing Then

                dblTotalAjustes = IIf(dvwAjuste.Table.Rows.Count > 0, dvwAjuste.Table.Compute("Sum(importe)", ""), 0)
            Else
                dblTotalAjustes = 0
            End If
            If oContratoLoteRO.oBEContratoLote.descuento <> "" Then
                dblTotalAjustes = dblTotalAjustes + oContratoLoteRO.oBEContratoLote.descuento
            End If
        Catch ex As Exception
            dvwAjuste = Nothing
            dblTotalAjustes = 0
        End Try

        If dvwPagable IsNot Nothing Then dblPagables = dvwPagable.Table.Compute("Sum(preciounitario)", "")
        Dim dblPenalizables As Double
        If dvwPenalizable IsNot Nothing And dvwPenalizable.Table.Rows.Count > 0 Then


            For Each row As DataRow In dvwPenalizable.Table.Rows

                If row.RowState.ToString = "Deleted" Then
                Else
                    dblPenalizables = dblPenalizables + row.Item("preciounitario")
                End If

            Next

            'dblPenalizables = dvwPenalizable.Table.Compute("Sum(preciounitario)", "")


        End If

        Dim dblParcial As Double
        Dim dbltotaltmsn As Double
        Dim dblneto As Double

        dblPrecio = dblPrecioEsc

        If dblPrecio < dblBase1 Then
            dblEscalador = (dblPrecio - dblBase1) * dblmenos1
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



        txtTotalTMSN.Text = FormatNumber(dbltotaltmsn, 4)

        dblValorVenta = Math.Round((dbltotaltmsn * dbltmsn) + dblAjuste, 2)
        txtValor.Text = FormatNumber(dblValorVenta, 2)

        If dbltmsn > 0 Then
            dblPrecioUnitario = dblValorVenta / dbltmsn
        End If

        txtPUnitario.Text = FormatNumber(dblPrecioUnitario, 3)

        dblImpuesto = dblValorVenta * dblPorImpuesto / 100
        txtImpuesto.Text = FormatNumber(dblImpuesto, 2)


        dblTotal = dblValorVenta + dblImpuesto
        txtTotal.Text = FormatNumber(dblTotal, 2)

        'CAMBIO A SOLICITUD DE BRUCE CORREO 18/04/2010
        'dblTotalPagar = (dblValorVenta * (dblPorcPago / 100) + dblImpuesto)

        dblTotalPagar = (dblValorVenta + dblImpuesto)

        txtPagar.Text = FormatNumber(dblTotalPagar, 2)
        txtDescuentos.Text = FormatNumber(dblTotalAjustes, 2)
        dblneto = dblTotalPagar - dblTotalAjustes
        txtNeto.Text = FormatNumber(dblneto, 2)

        lblestadoliq.Text = "N/A"

        'KMN 31/08/2012
        txtNumeroLote.Enabled = True
        cboClase.Enabled = True
        'KMN 31/08/2012

        If dtLiquidacion.Rows.Count > 0 Then
            ' Dim dvwliq As DataView
            ' dvwliq = New DataView(dtLiquidacion)
            'dvwliq.Sort = "liquidacionid DESC"
            For i = dtLiquidacion.Rows.Count - 1 To 0 Step -1
                lblfechaliq.Text = dtLiquidacion.Rows(i).Item("fc")
                lblestadoliq.Text = dtLiquidacion.Rows(i).Item("numerocalculo") & dtLiquidacion.Rows(i).Item("descri").ToString.Substring(0, 1)

                'KMN 31/08/2012
                txtNumeroLote.Enabled = False
                cboClase.Enabled = False
                'KMN 31/08/2012
                Exit For
            Next

        End If

    End Sub
    Private Sub ResumenRumas()
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
                dblTotalTMSN = dblTotalTMS - (dblTotalTMS * nupdMerma.Value / 100) 'dvwLiquidacionTM.Table.Compute("Sum(tmsn)", "")
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
    End Sub
    Private Sub CargarAsociacionTM()
        'If dtLiquidacionTM Is Nothing Then
        Dim oLiquidacionTMRO As New clsBC_LiquidacionTmRO
        Dim dvwTablaIntermedia As DataView
        dtLiquidacionTM = oLiquidacionTMRO.DefineTablaLiquidacionTm ' GenericListToDataTable(oPagableTX.LstValorizadorPagableIns) 'oValorizadorPagableRO.DefinirTablaValorizadorPagable
        ' End If
        oLogisticaMovimientoRO.oBELogisticaMovimiento.ContratoLoteId = txtCorrelativo.Text
        dvwTablaIntermedia = New DataView(oLogisticaMovimientoRO.LeerListaToDSLogisticaMovimientoAsociado.Tables(0))
        'dvwLogisticaMovimiento.RowFilter = "EstadoVCM='1' and ContratoLoteId='" & txtCorrelativo.Text & "'"
        'For Each row As DataRow In dvwLogisticaMovimiento.Table.Rows
        '    If row.Item("EstadoVCM") = "1" And row.Item("ContratoLoteId").ToString = txtCorrelativo.Text Then
        '        Dim drow As DataRow
        '        drow = dtLiquidacionTM.NewRow
        '        drow.Item("id") = row.Item("id")
        '        drow.Item("tmh") = row.Item("tmh_slc")
        '        drow.Item("H2O") = row.Item("H2O")
        '        drow.Item("tms") = row.Item("tmh_slc") * (100 - row.Item("H2O")) / 100
        '        drow.Item("merma") = 1 'row.Item("")
        '        drow.Item("tmsn") = drow.Item("tms") * (100 - "1") / 100
        '        drow.Item("guia") = row.Item("nro_documento")
        '        drow.Item("ticket") = row.Item("ticket")
        '        drow.Item("codigo") = row.Item("cod_lote")
        '        dtLiquidacionTM.Rows.Add(drow)
        '    End If
        'Next
        'dtLiquidacionTM.Rows.Add(drowPenalizable)
        ' dvwLogisticaMovimiento = New DataView(dtLiquidacionTM)

        '  dgvRumas.AutoGenerateColumns = False
        'dgvRumas.DataSource = dvwLogisticaMovimiento




        'KMN 04/09/2012
        'dvwLogisticaMovimiento
        ''Obtiene los totales
        ''CalculaLiquidacionTMTotal(dvwLogisticaMovimiento)
        'KMN 04/09/2012





        dgvLiquidacionTM.AutoGenerateColumns = False
        dgvLiquidacionTM.DataSource = dvwLogisticaMovimiento
        'EditarColumnasModificables(dgvLiquidacionTM, "tmh,h2o,merma")
        EditarColumnasModificables(dgvLiquidacionTM, "")
        EditarColumnasModificables(dgvLiquidacionTMTotal, "")
        ResumenRumas()
        '  dgvRumas.DataSource = dtLiquidacionTM
        ' dgvRumas.Refresh()
        'With dgvRumas
        '    .Columns("ID").Visible = False
        'End With
        ' EditarColumnasModificables(dgvRumas, "0,1,2,3,4,5,6,7,8", True)
    End Sub









    Private Sub CargarLiquidacionTM()
        'For Each row As DataRow In dvwmovimiento

        'Next
        'Dim drow As DataRow
        'drow = dtLiquidacionTM.NewRow

    End Sub
    Private Sub tsbDesasociar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbDesasociar.Click

        If dgvLiquidacionTM.RowCount > 0 Then
            If MsgBox("Esta seguro de Eliminar los  Elementos  seleccionados", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                For Each dgrow As DataGridViewRow In dgvLiquidacionTM.SelectedRows
                    'Dim id As String = dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value
                    Dim id As String = dgrow.Cells("id").Value ' dgvLiquidacionTM.Item("id", dgvLiquidacionTM.CurrentCell.RowIndex).Value
                    If String.IsNullOrEmpty(id) Then
                        Dim drowP As DataRow
                        'drowP = BuscarenDatatable(dvwLiquidacionTM.Table, "id", dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value)
                        drowP = BuscarenDatatable(dvwLiquidacionTM.Table, "id", id)
                        drowP.Delete()
                    Else
                        ActualizarEstadoLogisticaDesasociar(id)
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
                        drowPen = BuscarenDatatable(dvwLiquidacionTM.Table, "id", dgrow.Cells("id").Value) 'dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value)
                        If drowPen IsNot Nothing Then
                            drowPen.Delete()
                        End If


                        ' oPagableTX.EliminarPagable()
                    End If
                Next
                'ObtenerLiquidacionTM(pstrCorrelativo)
                ''Dim id As String = dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value
                'Dim id As String = dgvLiquidacionTM.Item("id", dgvLiquidacionTM.CurrentCell.RowIndex).Value
                'If String.IsNullOrEmpty(id) Then
                '    Dim drowP As DataRow
                '    'drowP = BuscarenDatatable(dvwLiquidacionTM.Table, "id", dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value)
                '    drowP = BuscarenDatatable(dvwLiquidacionTM.Table, "id", id)
                '    drowP.Delete()
                'Else
                '    ActualizarEstadoLogisticaDesasociar(id)
                '    oLiquidacionTMTX.NuevaEntidad()
                '    With oLiquidacionTMTX.oBELiquidacionTm
                '        .contratoLoteId = pstrCorrelativo
                '        .liquidacionId = pstrCorrelativoLiquidacion
                '        .liquidacionTmId = dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("liquidacionTmId").Value
                '        '.codigoElemento = fxgrdPagable.Rows(fxgrdPagable.Row).Item("codigoElemento")
                '        'oLiquidacionTMTX.LstLiquidacionTm.Add(oLiquidacionTMTX.oBELiquidacionTm)
                '        oLiquidacionTMTX.LstLiquidacionTmDel.Add(oLiquidacionTMTX.oBELiquidacionTm)
                '    End With
                '    'Public oBELiquidacionTm As clsBE_LiquidacionTm
                '    Dim drowPen As DataRow
                '    drowPen = BuscarenDatatable(dvwLiquidacionTM.Table, "id", dgvLiquidacionTM.Rows(dgvLiquidacionTM.CurrentCell.RowIndex).Cells("id").Value)
                '    drowPen.Delete()
                '    ' oPagableTX.EliminarPagable()
                'End If
            End If
        End If

        ResumenGeneral()

        tsbGuardar_Click(Nothing, Nothing)


    End Sub


    Private Sub tsbAjusteAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAjusteAgregar.Click
        InsertarAjuste(tsCboAjuste.Text)
    End Sub
    Private Sub DefinirAjustes()

        dtAjuste = oLiquidacionDsctoRO.DefinirTablaLiquidacionDscto
        InsertarAjuste("Adelanto")
        dgvAjustes.AutoGenerateColumns = False
        dgvAjustes.DataSource = dtAjuste
    End Sub
    Private Sub DefinirServicios()

        dtServicio = oLiquidacionServicioRO.DefinirTablaLiquidacionServicio
        InsertarServicio("Analisis")
        'InsertarAjuste("Adelanto")
        'dgvAjustes.AutoGenerateColumns = False
        'dgvAjustes.DataSource = dtAjuste
    End Sub
    Private Sub InsertarAjuste(ByVal codigo As String, Optional ByVal importe As Double = 0.0, Optional ByVal desc As String = "", Optional ByVal carta As String = "", Optional ByVal obs As String = "")
        Dim drow As DataRow
        drow = dtAjuste.NewRow
        drow("codigoDscto") = codigo
        drow("importe") = importe
        drow("descri") = desc
        drow("cartaInstruccion") = carta
        drow("observa") = obs
        dtAjuste.Rows.Add(drow)
        EditarColumnasModificables(dgvAjustes, "descridscto,importedscto")
    End Sub
    Private Sub InsertarServicio(ByVal codigo As String, Optional ByVal importe As Double = 0.0, Optional ByVal desc As String = "")
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
        EditarColumnasModificables(dgvServicios, "descriservicio,importeservicio,dgvCalculoServicio")
    End Sub

    Private Sub ObtenerDatosContrato(ByVal strcorrelativo As String)
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
        'txtctaanualmax.Text = oContratoLoteRO.oBEContratoLote.tmAnualMaximo
        'txtctaanualmin.Text = oContratoLoteRO.oBEContratoLote.tmAnualMinimo
        'txtctamensmax.Text = oContratoLoteRO.oBEContratoLote.tmMensualMaximo
        'txtctamensmin.Text = oContratoLoteRO.oBEContratoLote.tmMensualMinimo
        ObtenerLiquidacion(strcorrelativo)
        ObtenerPagables(strcorrelativo)
        ObtenerPenalizables(strcorrelativo)
    End Sub




    Private Sub btnContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContrato.Click

        Dim oGeneral As New clsBC_GeneralRO
        Dim parametro As New Hashtable
        Dim strCorrelativo As String
        'parametro("id_oferta") = 
        oGeneral.LstGeneral.Clear()
        MostrarFormularioAyuda(EnumFormAyuda.Contratos, oGeneral, False, parametro, , pBEUsuario.campo2)
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
                        If oContratoLoteRO.oBEContratoLote.codigoMovimiento = TABLA_DE_MOVIMIENTOS.MEZCLA.Value Then
                            'txtNumeroLote.Text = Month(Now()) & "-" & oGeneral.LstGeneral.Item(0).NomCampo4
                            txtNumeroLote.Text = Month(Now()) & "-" & oGeneral.LstGeneral.Item(0).NomCampo5

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
                        ElseIf oContratoLoteRO.oBEContratoLote.codigoMovimiento = TABLA_DE_MOVIMIENTOS.VINCULADA.Value Or cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VENTA.Value Then
                            lblperiodo.Visible = True
                            dtPeriodo.Visible = True
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


                        cboTipo.SelectedValue = CStr(oContratoLoteRO.oBEContratoLote.codigoMovimiento)
                        cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad
                        cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
                        cboEmpresa.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoEmpresa
                        cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
                        cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                        cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto
                        txtprocedencia.Text = oContratoLoteRO.oBEContratoLote.procedencia
                        'txtctaanualmax.Text = oContratoLoteRO.oBEContratoLote.tmAnualMaximo
                        'txtctaanualmin.Text = oContratoLoteRO.oBEContratoLote.tmAnualMinimo
                        'txtctamensmax.Text = oContratoLoteRO.oBEContratoLote.tmMensualMaximo
                        'txtctamensmin.Text = oContratoLoteRO.oBEContratoLote.tmMensualMinimo
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
                    If oContratoLoteRO.oBEContratoLote.codigoMovimiento = TABLA_DE_MOVIMIENTOS.MEZCLA.Value Then
                        'txtNumeroLote.Text = Month(Now()) & "-" & oGeneral.LstGeneral.Item(0).NomCampo4
                        txtNumeroLote.Text = Month(Now()) & "-" & oGeneral.LstGeneral.Item(0).NomCampo5
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
                    ElseIf oContratoLoteRO.oBEContratoLote.codigoMovimiento = TABLA_DE_MOVIMIENTOS.VINCULADA.Value Or cboTipo.SelectedValue = TABLA_DE_MOVIMIENTOS.VENTA.Value Then
                        lblperiodo.Visible = True
                        dtPeriodo.Visible = True
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

                    cboTipo.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoMovimiento
                    cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad
                    cboEmpresa.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoEmpresa
                    cboSocio.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoSocio
                    cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                    cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto
                    txtprocedencia.Text = oContratoLoteRO.oBEContratoLote.procedencia
                    'txtctaanualmax.Text = oContratoLoteRO.oBEContratoLote.tmAnualMaximo
                    'txtctaanualmin.Text = oContratoLoteRO.oBEContratoLote.tmAnualMinimo
                    'txtctamensmax.Text = oContratoLoteRO.oBEContratoLote.tmMensualMaximo
                    'txtctamensmin.Text = oContratoLoteRO.oBEContratoLote.tmMensualMinimo
                    ObtenerLiquidacion(strCorrelativo)
                    ObtenerPagables(strCorrelativo)
                    ObtenerPenalizables(strCorrelativo)
                End If
                'EditarColumnasModificables(dgvPagables, "ley,pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvAjuste")

                Dim oTablaDetRO As New clsBC_TablaDetRO
                oTablaDetRO.oBETablaDet.tablaId = "impuesto"
                oTablaDetRO.oBETablaDet.tablaDetId = "igv"
                oTablaDetRO.LeerTablaDet()
                txtPorImpuesto.Text = oTablaDetRO.oBETablaDet.descri.ToString()

                ResumenGeneral()
                NombrarEtiquetas()
            End If
        End If

        Select Case cboTipo.SelectedValue
            Case "P", "S", "V"
                txtNumeroLote.MaxLength = 3
            Case "B"
                txtNumeroLote.MaxLength = 5
        End Select


    End Sub

    Private Sub tsbServiciosAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbServiciosAgregar.Click
        InsertarServicio(tsCboServicio.Text)
    End Sub

    Private Sub tsbAjusteEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAjusteEliminar.Click
        If dgvAjustes.RowCount > 0 Then
            If MsgBox("Esta seguro de Eliminar el Elemento  seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
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
                        '.codigoElemento = fxgrdPagable.Rows(fxgrdPagable.Row).Item("codigoElemento")
                        oLiquidacionDsctoTX.LstLiquidacionDsctoDel.Add(oLiquidacionDsctoTX.oBELiquidacionDscto)
                    End With
                    Dim drowPen As DataRow
                    drowPen = BuscarenDatatable(dvwAjuste.Table, "liquidacionDsctoId", dgvAjustes.Rows(dgvAjustes.CurrentCell.RowIndex).Cells("liquidacionDsctoId").Value)
                    drowPen.Delete()
                    ' oPagableTX.EliminarPagable()
                End If

            End If
        End If

    End Sub

    Private Sub tsbServiciosEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbServiciosEliminar.Click
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
                    ' oPagableTX.EliminarPagable()
                End If
                'If pblnNuevo Or pblnCopia Then
                '    Dim drow As DataRow
                '    'drow = BuscarenDatatable(dvwPagable.Table, "liquidacionPagable", dgvPagables.Rows(dgvPagables.CurrentCell.RowIndex).Cells("liquidacionPagable").Value)
                '    drow = BuscarenDatatable(dvwServicio.Table, "codigoServicio", dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("codigoServicio").Value)
                '    drow.Delete()
                'Else
                '    If String.IsNullOrEmpty(dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("liquidacionServicioId").Value) Then
                '        Dim drowP As DataRow
                '        drowP = BuscarenDatatable(dvwServicio.Table, "codigoServicio", dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("codigoServicio").Value)
                '        drowP.Delete()
                '    Else

                '    End If
                '    With oLiquidacionServicioTX.oBELiquidacionServicio
                '        .contratoLoteId = pstrCorrelativo
                '        .liquidacionId = pstrCorrelativoLiquidacion
                '        .liquidacionServicioId = dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("liquidacionServicioId").Value
                '        '.codigoElemento = fxgrdPagable.Rows(fxgrdPagable.Row).Item("codigoElemento")
                '        oLiquidacionServicioTX.LstLiquidacionservicioDel.Add(oLiquidacionServicioTX.oBELiquidacionServicio)
                '    End With
                '    Dim drowPen As DataRow
                '    drowPen = BuscarenDatatable(dvwServicio.Table, "codigoServicio", dgvServicios.Rows(dgvServicios.CurrentCell.RowIndex).Cells("codigoServicio").Value)
                '    drowPen.Delete()
                '    ' oPagableTX.EliminarPagable()
                'End If
            End If
        End If

    End Sub

    Private Sub cboSocio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSocio.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Dim oGeneral As New clsBC_GeneralRO
                Dim parametro As New Hashtable
                oGeneral.LstGeneral.Clear()
                MostrarFormularioAyuda(EnumFormAyuda.Socio, oGeneral, False, parametro)
                BuscarenComboBox(cboSocio, oGeneral.oBEGeneral.NomCampo1)
        End Select
    End Sub

    Private Sub cboSocio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSocio.SelectedIndexChanged
        If cboSocio.SelectedIndex >= 0 Then
            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "Socio"
            oTablaDetRO.oBETablaDet.tablaDetId = CType(cboSocio.SelectedItem, clsBE_General).Codigo_Retorna
            oTablaDetRO.LeerTablaDet()
            txtContacto.Text = oTablaDetRO.oBETablaDet.campo0

            txtContacto.Text = oTablaDetRO.oBETablaDet.campo0
            txtTelefono.Text = oTablaDetRO.oBETablaDet.campo4
            txtCorreo.Text = oTablaDetRO.oBETablaDet.campo5

        Else
            txtContacto.Text = ""
            txtTelefono.Text = ""
            txtCorreo.Text = ""
        End If
    End Sub

    Private Sub cboEmpresa_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboEmpresa.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                Dim oGeneral As New clsBC_GeneralRO
                Dim parametro As New Hashtable
                oGeneral.LstGeneral.Clear()
                MostrarFormularioAyuda(EnumFormAyuda.Empresa, oGeneral, False, parametro)
                BuscarenComboBox(cboEmpresa, oGeneral.oBEGeneral.NomCampo1)
        End Select
    End Sub

    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged

    End Sub

    Private Sub tsbAgregarPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarPag.Click
        If ValidarPagable() Then
            'InsertarPagable(cboMetalPag.SelectedValue, nupdPagable.Value, cboDeducccion.SelectedValue, txtdeduccion.Text, txtRefinacion.Text, txtProteccion.Text, cboMercado.SelectedValue, cboQpTipo.SelectedValue, cboQpAjuste.SelectedValue)
            InsertarPagable(tsCboPagable.ComboBox.SelectedValue)
        End If
    End Sub

    Private Sub tsbEliminarPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarPag.Click
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
    End Sub

    Private Sub tsbAgregarPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregarPen.Click
        If ValidarPenalizable() Then
            'InsertarPenalizable(cboMetalPen.SelectedValue, nupdMinimo.Value, nupdMaximo.Value, txtUndPen.Text, txtPen.Text)
            InsertarPenalizable(tsCboPenalizable.ComboBox.SelectedValue)
        End If
    End Sub

    Private Sub tsbEliminarPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarPen.Click
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
    End Sub
    Private Sub InsertarPagable(ByVal metal As String, Optional ByVal pagable As Double = 0, Optional ByVal codigodeduccion As String = "", Optional ByVal deduccion As Double = 0, Optional ByVal refinacion As Double = 0, Optional ByVal proteccion As Double = 0, Optional ByVal mercado As String = "", Optional ByVal codigoqptipo As String = "", Optional ByVal codigoqpajuste As String = "")

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
        drowPagable("liquidacionPagable") = ""
        dtPagable.Rows.Add(drowPagable)
        dvwPagable = New DataView(dtPagable)
        dgvPagables.AutoGenerateColumns = False
        dgvPagables.DataSource = dvwPagable
        '--EditarColumnasModificables(dgvPagables, "ley,pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal")
        'EditarColumnasModificables(dgvPagables, "ley,pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")
        EditarColumnasModificables(dgvPagables, "pag,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvqpAjuste,qpinicio,qpfinal,FinLey,FinPrecio")
    End Sub
    Private Function ValidarPenalizable()

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
    End Function

    Private Function ValidarPagable()
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
    End Function
    Private Sub InsertarPenalizable(ByVal metal As String, Optional ByVal minimo As Double = 0, Optional ByVal maximo As Double = 0, Optional ByVal unidad As Double = 0, Optional ByVal penalizable As Double = 0)

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
    End Sub



    Private Sub ResumenServicios()
        If dvwServicio IsNot Nothing Then
            'Dim tdbgServicios As DataView = Nothing
            'tdbgServicios.DataSource = dvwServicio
            '' tdbgServicios.SetDataBinding(dvwServicio, "codigoservicio", True)
            'OcultarColumnas(tdbgServicios, "codigoServicio,descri,importe", True)

            'tdbgServicios.Columns(0).Caption = "Servicio"

            'tdbgServicios.Columns(1).Caption = "Concepto"
            'tdbgServicios.Columns(2).Caption = "Importe"
            '' tdbgServicios.Columns("importe").Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Sum
            '' tdbgServicios.Columns("importe").NumberFormat = "c"
            ''tdbgServicios.GroupedColumns.Clear()
            '' tdbgServicios.GroupStyle.GradientMode = C1.Win.C1TrueDBGrid.GradientModeEnum.BackwardDiagonal
            ''tdbgServicios.GroupedColumns.Add(tdbgServicios.Columns("codigoservicio"))
            'tdbgServicios.ColumnFooters = True
            'tdbgServicios.Columns("importe").FooterText = True
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
                txtTotalServicios.Text = FormatNumber(dblSrvImporte + dblSrvTmsn, 2)
            End If
        End If


    End Sub


    Private Sub tbcTerminos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbcTerminos.GotFocus

        'SendKeys.Send("{Enter}")

        txtNumero.Focus()

        ResumenGeneral()

        tsRumas.Visible = True
        tsAjuste.Visible = True
        tsServicios.Visible = True

    End Sub

    Private Sub dgvAjustes_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvAjustes.DataError
        MsgBox("Por favor ..... Verificar la informacion ingresada.", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
    End Sub
    Private Sub dgvAjustes_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvAjustes.RowStateChanged
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
    End Sub

    Private Sub dgvLiquidacionTM_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvLiquidacionTM.DataError

    End Sub

    Private Sub dgvLiquidacionTM_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvLiquidacionTM.RowStateChanged
        e.Row.Cells(0).Value = e.Row.Index + 1
    End Sub
    Private Sub dgvPagables_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellEnter


    End Sub
    Private Sub CalculoPagables()
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
            Dim dblContPagable As Double
            Dim dblTMSN As Double = txtTMSN.Text

            If cboTipo.Text = "B" Then
                dblTMSN = txtCalculoTmsn.Text
            End If

            dblPrecio = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("precio").Value).GetValueOrDefault

            Dim dblCalculoPagables As Double
            If strCodDed.ToLower = "pre" Then
                dblCalculoPagables = ((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion)) * (dblPagable / dblfactorPagable)
                'dblCalculoPagables = Math.Round(dblCalculoPagables - 0.00005, 4)
                dblCalculoPagables = Math.Max(0, Math.Round(dblCalculoPagables, 15))
                dblContPagable = dblCalculoPagables * dblTMSN
            Else
                dblCalculoPagables = Math.Max(0, Math.Min(((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion)), ((dblLey / dblfactorley) * (dblPagable / dblfactorPagable))))
                'dblCalculoPagables = Math.Round(dblCalculoPagables - 0.000049, 4)
                dblCalculoPagables = Math.Round(dblCalculoPagables, 15)
                dblContPagable = dblCalculoPagables * dblTMSN
            End If
            dblPrecioUnitario = Math.Max(0, dblCalculoPagables * (dblPrecio - ((dblRefinacion + dblProteccion) * dblfactorProt)))
            With srow.Cells
                .Item("calculopagable").Value = dblCalculoPagables
                .Item("contenido").Value = dblContPagable
                .Item("pu").Value = dblPrecioUnitario

                If Strings.Left(cboClase.Text, 5) = "Oxido" Or Strings.Left(cboClase.Text, 5) = "Sulfu" Then

                    .Item("contenido").Value = dblPagable * dblLey
                    .Item("pu").Value = (dblLey * dblPrecio) ''/ dblTMSN


                End If

            End With

            If cboProducto.SelectedValue = (srow.Cells.Item("Elem").Value) Then
                dblPrecioEsc = dblPrecio
            End If

        Next
    End Sub
    Private Sub CalculoPenalizables()

        Try
            Dim strElemento As String = ""
            dgvPenalizable.EndEdit()
            For Each srow As DataGridViewRow In dgvPenalizable.Rows

                Dim dblLeyP As Double = srow.Cells.Item("leyp").Value
                Dim dblPen As Double = srow.Cells.Item("pen").Value
                Dim dblUndPen As Double = srow.Cells.Item("unid").Value
                Dim dblMinP As Double = srow.Cells.Item("min").Value
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

        End Try



    End Sub

    'Private Sub dgvPagables_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellContentClick

    'End Sub

    'Private Sub dgvPenalizable_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPenalizable.CellEndEdit
    '    ResumenGeneral()
    'End Sub

    'Private Sub dgvPenalizable_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPenalizable.CellEnter
    '    ResumenGeneral()
    'End Sub

    'Private Sub txtMaquila_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaquila.TextChanged
    '    ResumenGeneral()
    'End Sub

    Private Sub txtAjuste_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAjuste.TextChanged
        ResumenGeneral()
    End Sub

    Private Sub txtPorImpuesto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPorImpuesto.TextChanged
        ResumenGeneral()
    End Sub

    'Private Sub txtPorcPago_TextChanged(sender As System.Object, e As System.EventArgs)
    '    ResumenGeneral()
    'End Sub

    Private Sub btnsocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsocio.Click
        Dim oGeneral As New clsBC_GeneralRO
        Dim parametro As New Hashtable
        oGeneral.LstGeneral.Clear()
        MostrarFormularioAyuda(EnumFormAyuda.Socio, oGeneral, False, parametro)
        BuscarenComboBox(cboSocio, oGeneral.oBEGeneral.NomCampo1)
    End Sub


    Private Sub nupdMerma_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nupdMerma.ValueChanged
        ResumenGeneral()

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage6.Click

    End Sub

    Private Sub tsbServiciosEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbServiciosEliminar.Click

    End Sub

    Private Sub btnCalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalidad.Click
        Dim oGeneral As New clsBC_GeneralRO
        Dim parametro As New Hashtable
        oGeneral.LstGeneral.Clear()
        MostrarFormularioAyuda(EnumFormAyuda.Calidad, oGeneral, False, parametro)
        BuscarenComboBox(cboCalidad, oGeneral.oBEGeneral.NomCampo1)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbResumen.Click

        txtNumero.Focus()

        'ObtenerLiquidacionTM(pstrCorrelativo)

        ResumenGeneral()

    End Sub

    Private Sub editlote_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        oMovimientoTX.ActualizaEstadoBtnCancelar(txtCorrelativo.Text, "0000000001") ' siempre es el actual
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If dgvLiquidacion.RowCount > 0 Then
            'Dim lsLiquidacionId As String = dgvLiquidacion2.Rows(dgvLiquidacion2.CurrentCell.RowIndex).Cells(2).Value.ToString
            Dim lsLiquidacionId As String = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString()

            Dim frm As New browser

            Dim lsCadena = "&contratoLoteId=" & txtCorrelativo.Text.Trim() & "&liquidacionId=" & lsLiquidacionId & "&UserNombre=" & pBEUsuario.descri
            Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
            'MH 17012012
            'frm.psurl = lsPagina + "ReportViewer.aspx?%2fLiquidacion%2fLiquidacion&rs:Command=Render" & lsCadena
            frm.psurl = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2fLiquidacion&rs:Command=Render" & lsCadena
            frm.Show()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If dgvLiquidacion.RowCount > 0 Then
            'Dim lsEliminar As String = dgvLiquidacion2.Rows(dgvLiquidacion2.CurrentCell.RowIndex).Cells(7).Value.ToString
            Dim lsEliminar As String = dgvLiquidacion.Columns("Eliminar").CellValue(dgvLiquidacion.Row).ToString()
            If lsEliminar = "1" Then
                If MsgBox("Esta seguro de Eliminar el Elemento  seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                    'Dim lsLiquidacionId As String = dgvLiquidacion2.Rows(dgvLiquidacion2.CurrentCell.RowIndex).Cells(2).Value.ToString
                    Dim lsLiquidacionId As String = dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString()
                    oLiquidacionRO.fnDelLiquidacion(txtCorrelativo.Text.Trim(), lsLiquidacionId)
                    ObtenerLiquidacionTotal(txtCorrelativo.Text.Trim())

                    Grabacion()

                End If
            Else
                MsgBox("Solo se puede eliminar la ultima valorizacion", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            End If
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim oLiquidacionROMod As New clsBC_LiquidacionRO
        If dgvLiquidacion.RowCount > 0 Then

            dgvLiquidacion.UpdateData()


            For a = 0 To dgvLiquidacion.Splits(0).Rows.Count - 1

                Dim oLiquidacionROModx As New clsBC_LiquidacionRO

                With oLiquidacionROModx.oBELiquidacion
                    .contratoLoteId = txtCorrelativo.Text.Trim()
                    .liquidacionId = dgvLiquidacion.Columns("liquidacionId").CellValue(a).ToString()
                    .periodo = dgvLiquidacion.Columns("periodo").CellValue(a).ToString()
                    .codigoDocumento = dgvLiquidacion.Columns("codigoDocumento").CellValue(a).ToString()
                    .numeroDocumento = dgvLiquidacion.Columns("numeroDocumento").CellValue(a).ToString()
                    .fechaDocumento = Convert.ToDateTime(dgvLiquidacion.Columns("fechaDocumento").CellValue(a))
                    oLiquidacionROMod.LstLiquidacion.Add(oLiquidacionROModx.oBELiquidacion)
                End With

            Next a

            oLiquidacionROMod.fnModificarLiquidacion()

            MsgBox("Grabado satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If
    End Sub



    Private Sub btnTrader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrader.Click
        Dim oGeneral As New clsBC_GeneralRO
        Dim parametro As New Hashtable
        oGeneral.LstGeneral.Clear()
        MostrarFormularioAyuda(EnumFormAyuda.Trader, oGeneral, False, parametro)
        BuscarenComboBox(cboTrader, oGeneral.oBEGeneral.NomCampo1)
    End Sub

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click

    End Sub

    Private Sub dgvPagables_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellContentClick

    End Sub

    Private Sub dgvPagables_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellValueChanged

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
    End Sub


    Private Sub dgvPagables_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPagables.CellMouseClick
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
    End Sub

    Private Sub tsbLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLiquidacion.Click

        tsbGuardar_Click(Nothing, Nothing)

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

        Grabacion()

    End Sub

    Private Sub editlote_MaximizedBoundsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub

    Private Sub dgvLiquidacionTM_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLiquidacionTM.CellContentClick

    End Sub

    Private Sub txtMaquila_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaquila.TextChanged
        ResumenGeneral()
    End Sub

    Private Sub txtNumeroLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumeroLote.TextChanged

    End Sub

    Private Sub dgvServicios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicios.CellContentClick

    End Sub

    Private Sub dgvAjustes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAjustes.CellContentClick

    End Sub
End Class