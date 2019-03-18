Imports SI.PL.clsFuncion
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsGeneral
Imports SI.UT
Imports SI.BC
Imports System.Data
Imports System.Drawing.Drawing2D
Imports SI.BE
Imports SI.UT.clsUT_Enumerado

Public Class editcontrato
#Region "Variables Publicas"
    Public pblnNuevo As Boolean
    Public pblnCopia As Boolean
    Public pstrCorrelativo As String
    Public pstrCorrelativoLiquidacion As String
    Public pstrCorrelativoLiquidacionTM As String
#End Region
#Region "Variables Privadas"
    Private lblneditandoPagable As Boolean
    Private lblneditandoPenalizable As Boolean
    Private drowPenalizable As DataRow
    Private dtPenalizable As DataTable
    Private dsPenalizable As New DataSet
    Private dvwPenalizable As DataView
    Private drowPagable As DataRow
    Private dtPagable As DataTable
    Private dsPagable As New DataSet
    Private dvwPagable As DataView
    Private oContratoLoteRO As New clsBC_ContratoLoteRO
    Private oContratoLoteTX As New clsBC_ContratoLoteTX
    Private oValorizadorPenalizableRO As New clsBC_ValorizadorPenalizableRO
    Private oValorizadorPagableRO As New clsBC_ValorizadorPagableRO
    Private oLiquidacionRO As New clsBC_LiquidacionRO
    Private oLiquidacionTX As New clsBC_LiquidacionTX
    Private oPenalizableTX As New clsBC_ValorizadorPenalizableTX
    Private oPagableTX As New clsBC_ValorizadorPagableTX

    'control de errores
    Private oMensajeError As mensajeError = New mensajeError
#End Region
#Region "Eventos Formulario "
    Private Sub editcontrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            ConfiguraForm(Me)
            CargarParametros()

            If pblnNuevo Then
                pstrCorrelativo = Obtener_Correlativo(SI.PL.clsEnumerado.enumTipoCorrelativo.Contrato)
                pstrCorrelativoLiquidacion = Obtener_Correlativo("tbLiquidacion", "liquidacionID", "contratoloteid", pstrCorrelativo)
                pstrCorrelativoLiquidacionTM = Obtener_Correlativo("tbLiquidacion", "liquidacionID", "contratoloteid", pstrCorrelativo)
                txtCorrelativo.Text = pstrCorrelativo
                txtcorrelativoliquidacion.Text = pstrCorrelativoLiquidacion
                'dtPenalizable = oValorizadorPenalizableRO.DefinirTablaValorizadorPenalizable()
                'dsPenalizable.Tables.Add(dtPenalizable)
                'dtPagable = oValorizadorPagableRO.DefinirTablaValorizadorPagable
                'dsPagable.Tables.Add(dtPagable)
                Me.Cursor = Cursors.Default
                Me.Text = "Nuevo Contrato"
                tsbAsociarTM.Enabled = False
            ElseIf pblnCopia Then
                Dim strCorrelativo As String
                strCorrelativo = pstrCorrelativo
                pstrCorrelativo = Obtener_Correlativo(SI.PL.clsEnumerado.enumTipoCorrelativo.Contrato)
                ObtenerContrato(strCorrelativo)
                pstrCorrelativoLiquidacion = "0000000001"
                pstrCorrelativoLiquidacionTM = "0000000001"
                txtCorrelativo.Text = pstrCorrelativo
                txtcorrelativoliquidacion.Text = "0000000001"
                ObtenerLiquidacion(strCorrelativo)
                ObtenerPagables(strCorrelativo)
                ObtenerPenalizables(strCorrelativo)
                Me.Cursor = Cursors.Default
                Me.Text = "Copiando Contrato"
            Else
                Me.Text = "Editando Contrato"
                ObtenerContrato(pstrCorrelativo)
                pstrCorrelativoLiquidacion = "0000000001"
                pstrCorrelativoLiquidacionTM = "0000000001"
                ObtenerLiquidacion(pstrCorrelativo)
                ObtenerPagables(pstrCorrelativo)
                ObtenerPenalizables(pstrCorrelativo)

                cboTipo.Enabled = False
                cboProducto.Enabled = False
                txtNumero.Enabled = False

            End If


            If cboTipo.SelectedValue = "V" Then

                'gbPeriodo.Visible = True

                lblperiodo.Visible = True
                cboPeriodo.Visible = True

            Else
                'gbPeriodo.Visible = False
                lblperiodo.Visible = False
                cboPeriodo.Visible = False
            End If


            txtNumero.MaxLength = 4
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

        Select Case keyData
            Case Keys.Escape

                Me.Dispose()

        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)

    End Function

#End Region

    Private Sub ObtenerContrato(ByVal contratoloteid As String)
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
                cboClase.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoClase
                cboProducto.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoProducto

                cboCalidad.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoCalidad


                txtctaanualmax.Text = oContratoLoteRO.oBEContratoLote.tmAnualMaximo
                txtctaanualmin.Text = oContratoLoteRO.oBEContratoLote.tmAnualMinimo
                txtctamensmax.Text = oContratoLoteRO.oBEContratoLote.tmMensualMaximo
                txtctamensmin.Text = oContratoLoteRO.oBEContratoLote.tmMensualMinimo
                txtprocedencia.Text = .procedencia
                txtComentarios.Text = .comentarios
                cboModo.SelectedValue = .codigoModo

                txtref1.Text = .ref1

                cboCategoria.SelectedValue = oContratoLoteRO.oBEContratoLote.categoria

                'REVISAR
                '  cboTrader.SelectedValue = oContratoLoteRO.oBEContratoLote.codigoTRader
                'txtComentarios.Text = oContratoLoteRO.oBEContratoLote.comentaios
                dtVigenciaFin.Value = oContratoLoteRO.oBEContratoLote.VigenciaFin
                dtVigenciaInicio.Value = oContratoLoteRO.oBEContratoLote.VigenciaInicio
            End With
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub ObtenerLiquidacion(ByVal contratoloteid As String)
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
                cboModo.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoTasa
                nupdPorcentaje.Value = oLiquidacionRO.oBELiquidacion.pp
                cboIncoterm.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoIncoterm
                cboDeposito.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoDeposito
                cboTrader.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoTrader

                RcBase.Text = oLiquidacionRO.oBELiquidacion.baseRc
                RcBasemas.Text = oLiquidacionRO.oBELiquidacion.RcMas
                RcBasemenos.Text = oLiquidacionRO.oBELiquidacion.RcMenos
                BaseCont.Text = oLiquidacionRO.oBELiquidacion.RcBaseCon
                ContMas.Text = oLiquidacionRO.oBELiquidacion.ContMas
                ContMenos.Text = oLiquidacionRO.oBELiquidacion.ContMenos
                'REVISAR
                'cboContacto.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoContacto
                'txtprocedencia.Text = oLiquidacionRO.oBELiquidacion.procedencia

                cboPeriodo.SelectedValue = oLiquidacionRO.oBELiquidacion.periodo
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
            'Obtener_ParametrosCombo(cboDeposito, clsUT_Dominio.domTABLA_DE_DEPOSITO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboClase, clsUT_Dominio.domTABLA_DE_CLASES, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboProducto, clsUT_Dominio.domTABLA_DE_PRODUCTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosCombo(cboCalidad, "Calidad", SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            'Obtener_ParametrosCombo(cboSocio, clsUT_Dominio.domTABLA_DE_SOCIO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboTipo, clsUT_Dominio.domTABLA_DE_MOVIMIENTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IDCodigoDescripcion)
            Obtener_ParametrosCombo(cbotipoc, clsUT_Dominio.domTABLA_DE_MOVIMIENTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdCodigo)
            'Obtener_ParametrosCombo(cboMetalPen, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosCombo(cboMercado, clsUT_Dominio.domMERCADO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosCombo(cboMetalPag, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosCombo(cboDeducccion, clsUT_Dominio.domTIPO_DE_DEDUCCION, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosCombo(cboQpTipo, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosCombo(cboQpAjuste, clsUT_Dominio.domTIPO_DE_AJUSTE_DE_QP, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            ' cboSocio.ClearItems()
            '  Obtener_ParametrosC1Combo(C1cboSocio, clsUT_Dominio.domTABLA_DE_SOCIO, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosCombo(cboSocio, clsUT_Dominio.domTABLA_DE_SOCIO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosC1Combo(cbofa, clsUT_Dominio.domFACTURADOR, SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboModo, "Modo", SI.PL.clsEnumerado.enumPrimerValorCombo.Ninguno, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosCombo(cboTrader, clsUT_Dominio.domTRADER, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
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
            'Obtener_ParametrosGridView(dgvTipo, clsUT_Dominio.domTIPO_DE_DEDUCCION)


            ''Deposito, Localidad
            ''If cboTipo.SelectedValue = "V" Then
            ''    Obtener_ParametrosComboEN(cboDeposito, "TB_LOCALIDAD")
            ''Else
            ''    Obtener_ParametrosComboEN(cboDeposito, "COM_DEPOSITOS")
            ''End If
            Obtener_ParametrosComboEN(cboDeposito, "COM_DEPOSITOS")


            Obtener_ParametrosComboEN(cboSocio, "PUB_PERSONAS")
            Obtener_ParametrosGridView(dgvTipo, clsUT_Dominio.domTIPO_DE_DEDUCCION)

            Obtener_ParametrosGridView(dgvAjuste, clsUT_Dominio.domTIPO_DE_AJUSTE_DE_QP)
            Obtener_ParametrosGridView(dgvMerc, clsUT_Dominio.domMERCADO)
            ' Obtener_ParametrosGridView(dgvQP, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION)
            Obtener_ParametrosGridView(dgvQP, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION)
            Obtener_ParametrosCombo(tsCboPagable, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(tsCboPenalizable, clsUT_Dominio.domMETAL, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosCombo(cboCategoria, clsUT_Dominio.domTIPO_CATEGORIA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)


            EditarColumnasModificables(dgvPagables, "pag,leymin,leymax,dgvtipo,ded,rc,prot,precio,dgvMerc,dgvQP,dgvAjuste", , "ley")
            EditarColumnasModificables(dgvPenalizable, "min,max,unid,pen", , "leyp")


           
           ObtenerPeriodos()


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Function GrabarRegistro()
        Try
            With oContratoLoteTX.oBEContratoLote
                .codigoTabla = TABLA.CONTRATO.Value
                .contratoLoteId = cbotipoc.SelectedText & txtCorrelativo.Text
                .codigoMovimiento = cboTipo.SelectedValue
                .contrato = txtNumero.Text
                .codigoEmpresa = cboEmpresa.SelectedValue
                .codigoSocio = cboSocio.SelectedValue
                .codigoClase = cboClase.SelectedValue
                .codigoProducto = cboProducto.SelectedValue

                .codigoCalidad = cboCalidad.SelectedValue

                .categoria = cboCategoria.SelectedValue

                Dim d As Double
                d = txtctamensmax.Text
                .tmAnualMaximo = txtctaanualmax.Text
                .tmAnualMinimo = txtctaanualmin.Text
                .tmMensualMaximo = txtctamensmax.Text
                .tmMensualMinimo = txtctamensmin.Text
                .procedencia = txtprocedencia.Text
                .comentarios = txtComentarios.Text
                .codigoModo = cboModo.SelectedValue
                '.cuota = dtCuota.Value
                'REVISAR
                '.comentarios = txtComentarios.Text
                '.codigoTrader = cboTrader.SelectedValue
                .VigenciaInicio = dtVigenciaInicio.Value
                .VigenciaFin = dtVigenciaFin.Value

                .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                .uc = pBEUsuario.tablaDetId
                .um = pBEUsuario.tablaDetId
                oContratoLoteTX.LstContratoLote.Add(oContratoLoteTX.oBEContratoLote)


                .ref1 = txtref1.Text


                .categoria = cboCategoria.SelectedValue

            End With
            If pblnNuevo Then

                oContratoLoteTX.InsertarContratoLote()
                pstrCorrelativo = oContratoLoteTX.oBEContratoLote.contratoLoteId


                If pstrCorrelativo.Length <> 10 Then
                    MsgBox("No se pudo generar el contrato. Ya ha sido registrado en el módulo de ADELANTOS, " & pstrCorrelativo & " es diferente. Verificar", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                    oContratoLoteTX.LstContratoLote.Clear()
                    Return False
                End If

                Grabarliquidacion()
                GrabarLiquidacionTm()
                GrabarPagables()
                GrabarPenalizables()
                oPagableTX.EliminarPagable()
                oPenalizableTX.EliminarPenalizable()
                Return True
            ElseIf pblnCopia Then
                oContratoLoteTX.InsertarContratoLote()
                pstrCorrelativo = oContratoLoteTX.oBEContratoLote.contratoLoteId


                If pstrCorrelativo.Length <> 10 Then
                    MsgBox("No se pudo generar el contrato. Ya ha sido registrado en el módulo de ADELANTOS, " & pstrCorrelativo & " es diferente. Verificar", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                    oContratoLoteTX.LstContratoLote.Clear()
                    Return False
                End If

                Grabarliquidacion()
                GrabarLiquidacionTm()
                GrabarPagables()
                GrabarPenalizables()
                oPagableTX.EliminarPagable()
                oPenalizableTX.EliminarPenalizable()
                Return True
            Else
                oContratoLoteTX.ModificarContratoLote()
                Grabarliquidacion()
                GrabarPagables()
                GrabarPenalizables()
                oPagableTX.EliminarPagable()
                oPenalizableTX.EliminarPenalizable()
                Return True
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function

    Private Function GrabarLiquidacionTm()
        Try
            Dim oLiquidacionTMTX As New clsBC_LiquidacionTmTX
            With oLiquidacionTMTX.oBELiquidacionTm
                .contratoLoteId = pstrCorrelativo
                .liquidacionId = pstrCorrelativoLiquidacion
                .liquidacionTmId = pstrCorrelativoLiquidacionTM

                '.cuota = dtCuota.Value
                .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                .uc = pBEUsuario.tablaDetId
                .um = pBEUsuario.tablaDetId
                oLiquidacionTMTX.LstLiquidacionTm.Add(oLiquidacionTMTX.oBELiquidacionTm)
            End With
            If pblnNuevo Or pblnCopia Then
                Return oLiquidacionTMTX.InsertarLiquidacionTm
            Else
                Return oLiquidacionTMTX.ModificarLiquidacionTm
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function

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

                'REVISAR
                '.codigoContacto = cboContacto.SelectedValue
                '.procedencia = txtprocedencia.Text
                '''''.cuota = dtCuota.Value

                .periodo = cboPeriodo.SelectedValue

                .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                .uc = pBEUsuario.tablaDetId
                .um = pBEUsuario.tablaDetId
                .baseRc = RcBase.Text
                .RcMas = RcBasemas.Text
                .RcMenos = RcBasemenos.Text
                .RcBaseCon = BaseCont.Text
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
            Return False
        End Try
    End Function

    Private Function GrabarPagables()
        Try
            For Each row As DataRow In dvwPagable.Table.Rows
                If row.RowState <> DataRowState.Deleted Then
                    oPagableTX.NuevaEntidad()
                    With oPagableTX.oBEValorizadorPagable
                        .contratoLoteId = pstrCorrelativo
                        .liquidacionId = pstrCorrelativoLiquidacion
                        '  .liquidacionTmId = pstrCorrelativoLiquidacionTM
                        .codigoElemento = row.Item("codigoElemento").ToString
                        .codigoMercado = row.Item("codigomercado").ToString
                        '.qpInicio = SI.UT.clsUT_Funcion.FechaNull(row.Item("qpInicio"))
                        '.qpFinal = SI.UT.clsUT_Funcion.FechaNull(row.Item("qpFinal"))
                        .codigoDeduccion = row.Item("codigoDeduccion").ToString
                        .proteccion = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("proteccion")).GetValueOrDefault
                        .refinacion = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("refinacion")).GetValueOrDefault
                        .deduccion = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("deduccion")).GetValueOrDefault
                        .pagable = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("pagable")).GetValueOrDefault
                        .leyPagable = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("leyPagable")).GetValueOrDefault
                        .leymin = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("leymin")).GetValueOrDefault
                        .leymax = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("leymax")).GetValueOrDefault
                        .codigoQp = row.Item("codigoQp").ToString
                        .codigoQpAjuste = row.Item("codigoqpAjuste").ToString
                        '.cuota = dtCuota.Value
                        .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                        .uc = pBEUsuario.tablaDetId
                        .um = pBEUsuario.tablaDetId
                        .finLey = ""

                        ''KMN 10/09/2012
                        ' Se agrega la validacion cuando es oxido o sulfuro, el precio ya sea el final y tenga como valor por defecto cero
                        .finPrecio = ""
                        If cboProducto.SelectedValue = row.Item("codigoElemento").ToString Then
                            If cboClase.SelectedValue = "0000000004" Or cboClase.SelectedValue = "0000000005" Then
                                .finPrecio = "1"
                                .precio = 0
                            End If
                        End If

                        If String.IsNullOrEmpty(row.Item("liquidacionpagable")) Then
                            .liquidacionPagable = ObtenerCorrelativoPagable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                            oPagableTX.LstValorizadorPagableIns.Add(oPagableTX.oBEValorizadorPagable)
                        Else
                            If pblnCopia Then
                                .liquidacionPagable = ObtenerCorrelativoPagable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                                oPagableTX.LstValorizadorPagableIns.Add(oPagableTX.oBEValorizadorPagable)
                            Else
                                .liquidacionPagable = row.Item("liquidacionpagable")
                                oPagableTX.LstValorizadorPagableUpd.Add(oPagableTX.oBEValorizadorPagable)

                            End If
                        End If

                    End With
                End If
            Next

            Return oPagableTX.InsertarPagable + oPagableTX.ModificarPagable '+ oPagableTX.EliminarValorizadorPagable
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function

    Private Function GrabarPenalizables()
        Try
            If dvwPenalizable IsNot Nothing Then
                For Each row As DataRow In dvwPenalizable.Table.Rows
                    If row.RowState <> DataRowState.Deleted Then
                        oPenalizableTX.NuevaEntidad()
                        With oPenalizableTX.oBEValorizadorPenalizable
                            .contratoLoteId = pstrCorrelativo
                            .liquidacionId = pstrCorrelativoLiquidacion
                            ' .liquidacionTmId = pstrCorrelativoLiquidacionTM
                            .codigoElemento = row.Item("codigoElemento")
                            .minimo = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("minimo")).GetValueOrDefault
                            .maximo = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("maximo")).GetValueOrDefault
                            .unidadPenalizable = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("unidadpenalizable")).GetValueOrDefault
                            .penalidad = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("penalidad")).GetValueOrDefault
                            .leyPenalizable = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(row.Item("leyPenalizable")).GetValueOrDefault
                            .codigoEstado = TABLA_DE_ESTADOS.ACTIVO.Value
                            .uc = pBEUsuario.tablaDetId
                            .um = pBEUsuario.tablaDetId
                            .indLey = ""


                            'oPenalizableTX.LstValorizadorPenalizable.Add(oPenalizableTX.oBEValorizadorPenalizable)
                            If String.IsNullOrEmpty(row.Item("liquidacionPenalizableId")) Then
                                .liquidacionPenalizableId = ObtenerCorrelativoPenalizable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                                oPenalizableTX.LstValorizadorPenalizableIns.Add(oPenalizableTX.oBEValorizadorPenalizable)
                            Else
                                If pblnCopia Then
                                    .liquidacionPenalizableId = ObtenerCorrelativoPenalizable(pstrCorrelativo, pstrCorrelativoLiquidacion)
                                    oPenalizableTX.LstValorizadorPenalizableIns.Add(oPenalizableTX.oBEValorizadorPenalizable)
                                Else
                                    .liquidacionPenalizableId = row.Item("liquidacionPenalizableId")
                                    oPenalizableTX.LstValorizadorPenalizableUpd.Add(oPenalizableTX.oBEValorizadorPenalizable)
                                End If

                            End If
                        End With
                    End If

                Next


                'If pblnNuevo Or pblnCopia Then
                Return oPenalizableTX.InsertarPenalizable + oPenalizableTX.ModificarPenalizable
            End If

            'Else
            '    Return oPenalizableTX.ModificarValorizadorPenalizable
            'End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function

    Private Function ExisteContrato(ByVal contrato As String)
        Try
            Dim oContratoRO As New clsBC_ContratoLoteRO
            With oContratoRO.oBEContratoLote
                .codigoTabla = "CON"
                .contrato = contrato
            End With
            oContratoRO.VerificarNumeroContrato()
            If String.IsNullOrEmpty(oContratoRO.oBEContratoLote.contratoLoteId) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function

    Private Function ValidarContrato()
        Try
            Dim strmensaje As String = ""
            If cboTipo.SelectedIndex < 0 Then
                strmensaje = strmensaje & "* Seleccione Tipo de Contrato" & vbCrLf

            End If
            If cboClase.SelectedIndex <= 0 Then
                strmensaje = strmensaje & "* Seleccione Clase" & vbCrLf

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
            Else
                If pblnNuevo Or pblnCopia Then
                    If ExisteContrato(cboTipo.Text.Substring(0, 1) + txtNumero.Text.Trim) Then
                        strmensaje = strmensaje & "* Verifique Numero de Contrato, ya asignado a otro contrato" & vbCrLf
                    End If
                End If

            End If

            If String.IsNullOrEmpty(txtctaanualmin.Text) Then
                strmensaje = strmensaje & "* Ingrese Cuota Anual Minima" & vbCrLf
                resaltarobjecto(txtctaanualmin)
            End If
            If String.IsNullOrEmpty(txtctaanualmax.Text) Then
                strmensaje = strmensaje & "* Ingrese Cuota Anual Maxima" & vbCrLf
                resaltarobjecto(txtctaanualmax)
            End If
            If String.IsNullOrEmpty(txtctamensmin.Text) Then
                strmensaje = strmensaje & "* Ingrese Cuota Mensual Minima" & vbCrLf
                resaltarobjecto(txtctamensmin)
            End If
            If String.IsNullOrEmpty(txtctamensmax.Text) Then
                strmensaje = strmensaje & "* Ingrese Cuota Mensual Maxima" & vbCrLf
                resaltarobjecto(txtctamensmax)
            End If
            If dvwPagable IsNot Nothing Then

                If dvwPagable.Table.Rows.Count <= 0 Then
                    strmensaje = strmensaje & "* Ingrese Pagables" & vbCrLf
                End If
            Else
                strmensaje = strmensaje & "* Ingrese Pagables" & vbCrLf

            End If


            If String.IsNullOrEmpty(txtref1.Text) Then
                strmensaje = strmensaje & "* Ingrese Calidad" & vbCrLf
                resaltarobjecto(txtref1)
            End If


            'If dvwPenalizable IsNot Nothing Then
            '    If dvwPenalizable.Table.Rows.Count <= 0 Then
            '        strmensaje = strmensaje & "* Ingrese Penalizables" & vbCrLf
            '    End If
            'Else
            '    strmensaje = strmensaje & "* Ingrese Penalizables" & vbCrLf
            'End If

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
            If tsCboPagable.ComboBox.SelectedIndex = 0 Then
                strmensaje = strmensaje & "* Seleccione Metal Pagable" & vbCrLf
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
        Try
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
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


#Region "Eventos de Controles"
    'Private Sub tsbEditarPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    EditandoPagables()
    '    EditarPagable()
    'End Sub
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Try
            ' ResaltarTodo()
            If Not ValidarContrato() Then Exit Sub
            If Not ValidarLiquidacion() Then Exit Sub
            'If MsgBox("Esta seguro de guardar el registro", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
            'Then
            'If Not ValidarLiquidacion() Then Exit Sub
            If GrabarRegistro() Then
                '  MsgBox("Registro Guardado correctamente.")
                '  pblnRetornaContratos = True
                '  Me.Dispose()

                oPagableTX.LstValorizadorPagableIns = New List(Of clsBE_ValorizadorPagable)
                oPagableTX.LstValorizadorPagableUpd = New List(Of clsBE_ValorizadorPagable)
                oPagableTX.LstValorizadorPagableDel = New List(Of clsBE_ValorizadorPagable)

                oPenalizableTX.LstValorizadorPenalizableIns = New List(Of clsBE_ValorizadorPenalizable)
                oPenalizableTX.LstValorizadorPenalizableUpd = New List(Of clsBE_ValorizadorPenalizable)
                oPenalizableTX.LstValorizadorPenalizableDel = New List(Of clsBE_ValorizadorPenalizable)

                If pblnNuevo Then
                    pblnNuevo = False
                End If
                pblnCopia = False
                RecargarForm()
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
        'End If
    End Sub
    Private Sub RecargarForm()
        Try
            Me.Text = "Editando Contrato"
            ObtenerContrato(pstrCorrelativo)
            pstrCorrelativoLiquidacion = "0000000001"
            pstrCorrelativoLiquidacionTM = "0000000001"
            ObtenerLiquidacion(pstrCorrelativo)
            ObtenerPagables(pstrCorrelativo)
            ObtenerPenalizables(pstrCorrelativo)

            cboTipo.Enabled = False
            cboProducto.Enabled = False
            txtNumero.Enabled = False
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
                        oPagableTX.oBEValorizadorPagable = New clsBE_ValorizadorPagable
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

    Private Sub tsbGuardarPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ModificarPagable()
        EditandoPagables()
    End Sub

    Private Sub tsbEditarPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EditandoPenalizables()
    End Sub

    Private Sub tsbGuardarPen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EditandoPenalizables()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click, tsmSalir.Click
        pblnRetornaContratos = True
        Me.Dispose()
    End Sub

    Private Sub txtbase1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbase1.GotFocus

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
        Try
            lblneditandoPagable = Not lblneditandoPagable
            gpocontrato.Enabled = Not lblneditandoPagable
            gpocompania.Enabled = Not lblneditandoPagable
            gpoparticipacion.Enabled = Not lblneditandoPagable
            gpofacturacion.Enabled = Not lblneditandoPagable
            gpoparticipacion.Enabled = Not lblneditandoPagable
            gpomercaderia.Enabled = Not lblneditandoPagable
            gpoterminos.Enabled = Not lblneditandoPagable
            gpoescalador.Enabled = Not lblneditandoPagable
            msMenu.Enabled = Not lblneditandoPagable
            tsMenu.Enabled = Not lblneditandoPagable
            tsbAgregarPag.Enabled = Not lblneditandoPagable
            'tsbEditarPag.Enabled = Not lblneditandoPagable
            gpopenalizable.Enabled = Not lblneditandoPagable
            tsbEliminarPag.Enabled = Not lblneditandoPagable
            'fxgrdPagable.Enabled = Not lblneditandoPagable
            'tsbGuardarPag.Enabled = lblneditandoPagable
            'tsbCancelarPag.Enabled = lblneditandoPagable
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
            'drowPagable("codigodeduccion") = "previa"
            drowPagable("codigodeduccion") = ""
            drowPagable("liquidacionPagable") = ""

            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "Metal"
            oTablaDetRO.oBETablaDet.tablaDetId = metal
            oTablaDetRO.LeerTablaDet()
            drowPagable("undfactor") = oTablaDetRO.oBETablaDet.campo14
            drowPagable("undpag") = oTablaDetRO.oBETablaDet.campo0
            drowPagable("undded") = oTablaDetRO.oBETablaDet.campo1
            drowPagable("undrc") = oTablaDetRO.oBETablaDet.campo2
            drowPagable("undprot") = oTablaDetRO.oBETablaDet.campo3


            dtPagable.Rows.Add(drowPagable)
            dvwPagable = New DataView(dtPagable)
            dgvPagables.AutoGenerateColumns = False
            dgvPagables.DataSource = dvwPagable

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
            gpoterminos.Enabled = Not lblneditandoPenalizable
            gpoescalador.Enabled = Not lblneditandoPenalizable
            msMenu.Enabled = Not lblneditandoPenalizable
            tsMenu.Enabled = Not lblneditandoPenalizable
            tsbAgregarPen.Enabled = Not lblneditandoPenalizable
            'tsbEditarPen.Enabled = Not lblneditandoPenalizable
            gpopagable.Enabled = Not lblneditandoPenalizable
            tsbEliminarPen.Enabled = Not lblneditandoPenalizable
            'fxgrdPenalizable.Enabled = Not lblneditandoPenalizable
            'tsbGuardarPen.Enabled = lblneditandoPenalizable
            'tsbCancelarPen.Enabled = lblneditandoPenalizable
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub InsertarPenalizable(ByVal metal As String, Optional ByVal minimo As Double = 0, Optional ByVal maximo As Double = 0, Optional ByVal unidad As Double = 0, Optional ByVal penalizable As Double = 0)
        Try
            If dtPenalizable Is Nothing Then
                Dim oPenalizableRO As New clsBC_ValorizadorPenalizableRO
                dtPenalizable = oPenalizableRO.DefinirTablaValorizadorPenalizable '.GenericListToDataTable(oPenalizableTX.LstValorizadorPenalizableIns) 'oValorizadorPagableRO.DefinirTablaValorizadorPagable
            End If
            drowPenalizable = dtPenalizable.NewRow
            drowPenalizable("codigoElemento") = metal
            drowPenalizable("liquidacionPenalizableId") = ""


            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "Metal"
            oTablaDetRO.oBETablaDet.tablaDetId = metal
            oTablaDetRO.LeerTablaDet()
            drowPenalizable("undfactorp") = oTablaDetRO.oBETablaDet.campo14
            drowPenalizable("undpen") = oTablaDetRO.oBETablaDet.campo15


            dtPenalizable.Rows.Add(drowPenalizable)
            dvwPenalizable = New DataView(dtPenalizable)

            dgvPenalizable.AutoGenerateColumns = False
            dgvPenalizable.DataSource = dvwPenalizable

            ' dgvPenalizable.Columns("leyp").Width = 0
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

#End Region

    Private Sub nupdMaximo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        '  nupdMaximo.Select(0, nupdMaximo.Text.Length)
    End Sub
    Private Sub nupdMerma_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        nupdMerma.Select(0, nupdMerma.Text.Length)
    End Sub
    Private Sub nupdMinimo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        'nupdMinimo.Select(0, nupdMinimo.Text.Length)
    End Sub
    Private Sub nupdPagable_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)

        '  nupdPagable.Select(0, nupdPagable.Text.Length)
    End Sub
    Private Sub nupdPorcentaje_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupdPorcentaje.GotFocus

        nupdPorcentaje.Select(0, nupdPorcentaje.Text.Length)
    End Sub
    Private Sub nupdPorcPago_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nupdPorcPago.GotFocus

        nupdPorcPago.Select(0, nupdPorcPago.Text.Length)
    End Sub

    Private Sub cboMetalPag_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cboMetalPag.SelectedIndex > 0 Then
        '    Dim oParametroRO As New clsBC_TablaDetRO
        '    With oParametroRO.oBETablaDet
        '        .tablaId = clsUT_Dominio.domMETAL
        '        .tablaDetId = cboMetalPag.SelectedValue
        '    End With
        '    oParametroRO.LeerTablaDet()
        '    lblRefinacion.Text = "Refinación " & oParametroRO.oBETablaDet.campo0
        '    lblProteccion.Text = "Protección " & oParametroRO.oBETablaDet.campo0
        '    lblDeduccion.Text = "Deducción " & oParametroRO.oBETablaDet.campo0
        'End If
    End Sub

    Private Sub dgvPagables_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPagables.DataError

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
        Try
            txtContacto.Text = ""
            txtTelefono.Text = ""
            txtCorreo.Text = ""
            If cboSocio.SelectedIndex >= 0 Then
                If cboSocio.SelectedValue.ToString <> "SI.BE.clsBE_PUB_PERSONAS" Then
                    Dim oBC_PUB_PERSONASRO As New clsBC_PUB_PERSONASRO
                    oBC_PUB_PERSONASRO.LeerListaPUB_PERSONAS(cboSocio.SelectedValue)
                    'oCombo.Items.Add(New ListViewItem("[Seleccione]", ""))

                    txtContacto.Text = oBC_PUB_PERSONASRO.LstPUB_PERSONAS(0).CONTACTO
                    txtTelefono.Text = oBC_PUB_PERSONASRO.LstPUB_PERSONAS(0).CELULAR1
                    txtCorreo.Text = oBC_PUB_PERSONASRO.LstPUB_PERSONAS(0).CORREO
                End If
            End If


            ''If cboSocio.SelectedIndex >= 0 Then
            ''    Dim oTablaDetRO As New clsBC_TablaDetRO
            ''    oTablaDetRO.oBETablaDet.tablaId = "Socio"
            ''    oTablaDetRO.oBETablaDet.tablaDetId = CType(cboSocio.SelectedItem, clsBE_General).Codigo_Retorna
            ''    oTablaDetRO.LeerTablaDet()
            ''    txtContacto.Text = oTablaDetRO.oBETablaDet.campo0
            ''    txtTelefono.Text = oTablaDetRO.oBETablaDet.campo4
            ''    txtCorreo.Text = oTablaDetRO.oBETablaDet.campo5
            ''Else
            ''    txtContacto.Text = ""
            ''    txtTelefono.Text = ""
            ''    txtCorreo.Text = ""
            ''End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
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

    Private Sub btnsocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsocio.Click
        Try
            ''Dim oGeneral As New clsBC_GeneralRO
            ''Dim parametro As New Hashtable
            ''oGeneral.LstGeneral.Clear()
            ''MostrarFormularioAyuda(EnumFormAyuda.Socio, oGeneral, False, parametro)

            ''cboSocio.DataSource = Nothing
            ''Obtener_ParametrosCombo(cboSocio, clsUT_Dominio.domTABLA_DE_SOCIO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            ''BuscarenComboBox(cboSocio, oGeneral.oBEGeneral.NomCampo4)


            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            oGeneral.LstGeneral.Clear()
            MostrarFormularioAyuda(EnumFormAyuda.Socio, oGeneral, False, parametro)

            'cboSocio.DataSource = Nothing
            'Obtener_ParametrosCombo(cboSocio, clsUT_Dominio.domTABLA_DE_SOCIO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'BuscarenComboBox(cboSocio, oGeneral.oBEGeneral.NomCampo4)

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

    Private Sub dgvPagables_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellContentClick

    End Sub

    Private Sub btncalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalidad.Click
        Try
            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            oGeneral.LstGeneral.Clear()
            MostrarFormularioAyuda(EnumFormAyuda.Calidad, oGeneral, False, parametro)

            cboCalidad.DataSource = Nothing
            Obtener_ParametrosCombo(cboCalidad, "Calidad", SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            BuscarenComboBox(cboCalidad, oGeneral.oBEGeneral.NomCampo1)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim oGeneral As New clsBC_GeneralRO
            Dim parametro As New Hashtable
            oGeneral.LstGeneral.Clear()
            MostrarFormularioAyuda(EnumFormAyuda.Trader, oGeneral, False, parametro)

            cboTrader.DataSource = Nothing
            Obtener_ParametrosCombo(cboTrader, clsUT_Dominio.domTRADER, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            BuscarenComboBox(cboTrader, oGeneral.oBEGeneral.NomCampo1)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        cbotipoc.SelectedValue = cboTipo.SelectedValue

        If cboTipo.SelectedValue.ToString = "V" Then
            Obtener_ParametrosComboEN(cboDeposito, "TB_LOCALIDAD")
            lblDeposito.Text = "Localidad: "
        Else
            Obtener_ParametrosComboEN(cboDeposito, "COM_DEPOSITOS")
            lblDeposito.Text = "Deposito: "
        End If
    End Sub

    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo("A")

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"
    End Sub
   
End Class