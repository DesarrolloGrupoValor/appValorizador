Imports SI.UT
Imports SI.UT.clsUT_Enumerado
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsFuncion
Imports SI.BC
Imports SI.BE
Imports System.Text

Imports SI.PL.clsGeneral

Public Class frmFijaciones

    ''Private drowPagable As DataRow
    ''Private dtPagable As DataTable
    ''Private dvwPagable As DataView

    ''Private sCodigoDscto As String = "ADELANTO"


    ''Private dFinanciando_Ajuste_CIGV As Double = 0.01

#Region "Variables Privadas"
    ''    'control de errores
    ''    Private oMensajeError As mensajeError = New mensajeError

    ''    Private oDvwAyuda As New DataView
    ''    Private FontCourier As New Font("Courier New", 8.25)
    ''    Private stylecodpartida As New DataGridViewCellStyle()
    Private sElemento As String

    Private oMensajeError As mensajeError = New mensajeError

    Private oValorizadorPagableRO As New clsBC_ValorizadorPagableRO

    Private dtPagable As DataTable
    'Private dsPagable As New DataSet
    Private dvwPagable As DataView



    Private oBE_TB_FJ_APLICACION As clsBE_TB_FJ_APLICACION
    Private oBC_TB_FJ_APLICACIONRO As clsBC_TB_FJ_APLICACIONRO
    Private oBC_TB_FJ_APLICACIONTX As clsBC_TB_FJ_APLICACIONTX


    Private dPrecioPonderado As Decimal
    Private dCantidadTotal As Decimal

    Private nRowSelectedPagable As Integer

#End Region

#Region "Variables Publicas"

    ''    Private dIGV As Double
    ''    Private bModificacion As Boolean = False

    ''    Public pstrNomFormulario As String
    ''    Public pFormAyuda As EnumFormAyuda
    ''    Public oGeneral As New clsBC_GeneralRO
    ''    Public pblnMultiSelect As Boolean
    ''    Public pstrTituloCodigo As String = "Codigo"
    ''    Public pstrTituloDescripcion As String = "Descripcion"
    ''    Public pParametros As New Hashtable
    ''    Public pstrWhere As String = ""
    ''    Public pstrFiltro As String
    ''    Public pstrDominio As clsUT_Dominio
    ''    Public pstrFiltroMovimiento As String

    ''    Public Property contratoLoteId() As String
    ''    Public Property liquidacionId() As String

    ''    Public Property contrato() As String
    ''    Public Property lote() As String
    Dim valorFijadoTotal, valorDisponible, indicePagable As Double

    Public Property pPROVEEDOR() As String
    'Public Property pContratoloteId() As String

    Public Property nTMNS() As Double


    Public Property pCodigoClase() As String
    Public Property pCodigoProducto() As String
    ''    Public Property proveedor_nombre() As String
    ''    Public Property empresa_grupo() As String

    ''    Public Property oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ
    ''    Public LstFINANCIANDO_PRELIQ_INSERT As New List(Of clsBE_FINANCIANDO_PRELIQ)


    ''    Public Property bAsociar As Boolean = False


    ''    Dim dAPLICA_SIGV As Double
    ''    Dim dAPLICA_CIGV As Double

    ''    Dim nRowIndex As Integer = -1



    ''    Dim bSeleccion As Boolean = False



    Public Property poc() As String
    Public Property pcontratoloteid() As String
    Public Property pliquidacionid() As String
    Public Property pcantidad() As Decimal
    Public Property pprecio() As Decimal
    'Private pusereg() As String
    Public Property plocalizador() As String
    Public Property pcontrato() As String
    Public Property pestado() As String
    Public Property pocid() As Integer

#End Region

    ''#Region "Propiedades"

    ''#End Region

#Region "Eventos de Formulario"

    Private Sub frmFijaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        valorFijadoTotal = 0
        valorDisponible = 0
        dgvFJ_FIJACION.AutoGenerateColumns = False
        dgvFJ_APLICACION.AutoGenerateColumns = False
        dgvFJ_APLICACION2.AutoGenerateColumns = False

        

        'Obtener_ParametrosCombo(cboElemento, clsUT_Dominio.domTABLA_DE_PRODUCTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

        Obtener_ParametrosGridView(dgvTipo, clsUT_Dominio.domTIPO_DE_DEDUCCION)
        ''Obtener_ParametrosGridView(dgvMerc, clsUT_Dominio.domMERCADO)
        ' ''Obtener_ParametrosGridView(dgvCalculoServicio, "CalculoServicio")

        ''Obtener_ParametrosGridView(dgvqpAjuste, clsUT_Dominio.domTIPO_DE_AJUSTE_DE_QP)
        ''Obtener_ParametrosGridView(dgvQP, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION)

        EditarColumnasModificables(dgvPagables, "dgvtipo,precio,FinPrecio")
        EditarColumnasModificables(dgvFJ_FIJACION, "FIJA_cbxAPLICAR,FIJA_APLICAR,APLICAR_AJUSTE_MAXIMO")
        EditarColumnasModificables(dgvFJ_APLICACION, "APLI_cbxAPLICAR")

        ObtenerPagables()
        CalculoPagables()
    End Sub

#End Region

#Region "Eventos de Controles"





#End Region

#Region "Rutinas Locales"

    Private Sub CargarDatos(ByVal sESTADO As String)

        Dim dsTB_FJ_FIJACIONRO, dsTB_FJ_FIJACIONRO2 As New DataSet
        Dim oBC_TB_FJ_FIJACIONRORO, oBC_TB_FJ_FIJACIONRORO2 As New clsBC_TB_FJ_FIJACIONRO
        'Dim oBE_TB_FJ_FIJACION As New clsBE_TB_FJ_FIJACION

        oBC_TB_FJ_FIJACIONRORO.oBETB_FJ_FIJACION.PROVEEDOR = pPROVEEDOR
        oBC_TB_FJ_FIJACIONRORO.oBETB_FJ_FIJACION.ELEMENTO = sElemento ' cboElemento.SelectedValue
        oBC_TB_FJ_FIJACIONRORO.oBETB_FJ_FIJACION.ESTADO = sESTADO ' cboElemento.SelectedValue
        oBC_TB_FJ_FIJACIONRORO.oBETB_FJ_FIJACION.CONTRATOLOTEID = pcontratoloteid
        dsTB_FJ_FIJACIONRO = oBC_TB_FJ_FIJACIONRORO.LeerListaToDSTB_FJ_FIJACION_Sel_Prov

        oBC_TB_FJ_FIJACIONRORO2.oBETB_FJ_FIJACION.PROVEEDOR = pPROVEEDOR
        oBC_TB_FJ_FIJACIONRORO2.oBETB_FJ_FIJACION.ELEMENTO = sElemento ' cboElemento.SelectedValue
        oBC_TB_FJ_FIJACIONRORO2.oBETB_FJ_FIJACION.ESTADO = sESTADO ' cboElemento.SelectedValue
        oBC_TB_FJ_FIJACIONRORO2.oBETB_FJ_FIJACION.CONTRATOLOTEID = pcontratoloteid
        dsTB_FJ_FIJACIONRO2 = oBC_TB_FJ_FIJACIONRORO2.LeerListaToDSTB_FJ_FIJACION_Sel


        If sESTADO = "A" Then
            dgvFJ_FIJACION.DataSource = dsTB_FJ_FIJACIONRO.Tables(0)
        ElseIf sESTADO = "P" Then
            dgvFJ_APLICACION.DataSource = dsTB_FJ_FIJACIONRO.Tables(0)

            If dsTB_FJ_FIJACIONRO.Tables(0).Rows.Count > 0 Then
                dPrecioPonderado = dsTB_FJ_FIJACIONRO.Tables(0).Compute("sum([PRECIO_PONDERADO]) ", "")
                dCantidadTotal = dsTB_FJ_FIJACIONRO.Tables(0).Compute("sum([CANTIDAD]) ", "")
            Else
                dPrecioPonderado = 0
                dCantidadTotal = 0
            End If
        Else
            dgvFJ_APLICACION2.DataSource = dsTB_FJ_FIJACIONRO2.Tables(0)
        End If


        'If dvwServicio.Count > 0 Then dblTotalServicios = dvwServicio.Table.Compute("Sum(importe)", "") * -1 'txtTotalServicios.Text

    End Sub


    Private Sub Limpiar()
        cbxOperacionLinea.Checked = False
        txtCantidad_Operacion.Text = 0
        txtPrecio_Operacion.Text = 0
    End Sub


    Private Sub ObtenerPagables()
        Try
            Dim nRowSelected As Integer

            If (dgvPagables.SelectedRows.Count = 0) Then
                nRowSelected = 0
            Else
                nRowSelected = dgvPagables.SelectedRows(0).Index
            End If

            With oValorizadorPagableRO.oBEValorizadorPagable
                .contratoLoteId = pcontratoloteid
                .liquidacionId = "0000000001"
            End With

            dtPagable = oValorizadorPagableRO.LeerListaToDSPagable.Tables(0)
            dvwPagable = New DataView(dtPagable)
            dgvPagables.AutoGenerateColumns = False
            dgvPagables.DataSource = dvwPagable

            dgvPagables.ClearSelection()
            nRowSelectedPagable = nRowSelected

            dgvPagables.Rows(nRowSelectedPagable).Selected = True
            actualizarDatos(nRowSelectedPagable)





            ''Dim dCantidad As Decimal = 0
            ''Dim dPrecioPonderado As Decimal = 0
            ''For i = 0 To dgvFJ_APLICACION.Rows.Count - 1
            ''    dCantidad += dgvFJ_APLICACION.Rows(i).Cells("APLI_CANTIDAD").Value + dgvFJ_APLICACION.Rows(i).Cells("APLI_APLICAR_AJUSTE_MAXIMO").Value

            ''    dPrecioPonderado += (dgvFJ_APLICACION.Rows(i).Cells("APLI_CANTIDAD").Value + dgvFJ_APLICACION.Rows(i).Cells("APLI_APLICAR_AJUSTE_MAXIMO").Value) * (dgvFJ_APLICACION.Rows(i).Cells("APLI_PRECIO").Value)
            ''Next
            ''dgvPagables.Rows(nRowSelectedPagable).Cells("precio_ponderado").Value = dPrecioPonderado / dCantidad


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub CalculoPagables()
        Try
            'Dim dblPrecio As Double

            dgvPagables.EndEdit()
            For Each srow As DataGridViewRow In dgvPagables.Rows
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
                Dim dblTMSN As Double = nTMNS


                ''KMN 05/09/2012
                'dblPrecio = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(srow.Cells.Item("precio").Value).GetValueOrDefault

                Dim dblCalculoPagables As Double
                Dim dblPAGar, dblPACon As Double
                ''Dim dblPAGar, dblPAApl, dblPACon, dblPASpg, dblPASre As Double


                dblPAGar = dblRefinacion * dblfactorrc
                'dblPAApl = dblPrecio - (dblProteccion * dblfactorProt)

                If strCodDed.ToLower = "pre" Then
                    dblCalculoPagables = ((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion)) * (dblPagable / dblfactorPagable)
                    dblCalculoPagables = Math.Max(0, Math.Round(IIf(dblCalculoPagables > 0, dblCalculoPagables, 0), 4, MidpointRounding.AwayFromZero)) 'Math.Max(0, Math.Round(dblCalculoPagables, 15))
                    dblContPagable = Math.Round(dblCalculoPagables * dblTMSN, 4)

                    dblPACon = Math.Max(0, ((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion)) * dblPagable / dblfactorPagable)

                Else
                    dblCalculoPagables = Math.Max(0, Math.Min(((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion)), ((dblLey / dblfactorley) * (dblPagable / dblfactorPagable))))
                    dblCalculoPagables = Math.Round(IIf(dblCalculoPagables > 0, dblCalculoPagables, 0), 4, MidpointRounding.AwayFromZero) ' Math.Round(dblCalculoPagables, 15)
                    dblContPagable = Math.Round(dblCalculoPagables * dblTMSN, 4)

                    dblPACon = Math.Max(0, Math.Min(((dblLey / dblfactorley) * (dblPagable / dblfactorPagable)), ((dblLey / dblfactorley) - (dblDeduccion / dblfactorDeduccion))))

                End If

                'kmn 11/09/2012
                dblPACon = IIf(dblPACon > 0, EnhancedMath.RoundDown(dblPACon, 4), 0)
                dblPACon = Math.Round(dblPACon, 4)

                ''dblPASpg = dblPACon * dblPAApl
                ''dblPASpg = IIf(dblPASpg > 0, EnhancedMath.RoundDown(dblPASpg, 4), 0)

                ''dblPASre = dblPACon * dblPAGar
                ''dblPASre = IIf(dblPASre > 0, EnhancedMath.RoundDown(dblPASre, 4), 0)

                ''dblPrecioUnitario = Math.Round(dblPASpg - dblPASre, 4)

                dblContPagable = dblPACon * dblTMSN
                dblCalculoPagables = dblPACon

                With srow.Cells
                    '.Item("calculopagable").Value = dblCalculoPagables
                    .Item("contenido").Value = dblContPagable
                    '.Item("pu").Value = dblPrecioUnitario

                    If pCodigoClase = "0000000004" Or pCodigoClase = "0000000005" Then

                        .Item("contenido").Value = dblPagable * dblLey
                        '.Item("pu").Value = (dblLey * dblPrecio) ''/ dblTMSN

                        'If cboProducto.SelectedValue = (srow.Cells.Item("Elem").Value) Then
                        '    .Item("FinPrecio").Value = "1"
                        'End If
                    End If

                End With


                ''If cboProducto.SelectedValue = (srow.Cells.Item("Elem").Value) Then
                ''    dblPrecioEsc = dblPrecio
                ''End If

            Next




        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub



#End Region



    ''Private Sub dgvFinanciamiento_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFJ_FIJACION.CellValueChanged

    ''    Select Case dgvFJ_FIJACION.Columns(e.ColumnIndex).Name
    ''        Case "cbxAplicar"

    ''        Case "FIJA_cbxAPLICAR"
    ''            If dgvFJ_FIJACION.CurrentRow.Cells(e.ColumnIndex).Value = True Then
    ''                dgvFJ_FIJACION.CurrentRow.Cells("FIJA_APLICAR").Value = dgvFJ_FIJACION.CurrentRow.Cells("FIJA_CANTIDAD").Value
    ''            End If

    ''    End Select

    ''End Sub


    Sub dgvFJ_FIJACION_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvFJ_FIJACION.CurrentCellDirtyStateChanged

        If dgvFJ_FIJACION.IsCurrentCellDirty Then
            dgvFJ_FIJACION.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    ''Private Sub cboElemento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboElemento.SelectedIndexChanged

    ''    If cboElemento.SelectedIndex > 0 Then
    ''        CargarDatos()
    ''    End If

    ''End Sub


    Private Sub actualizarDatos(ByVal nRowSelected As Integer)
        ''sElemento = dgvPagables.CurrentRow.Cells("Elem").Value 'dgvPagables.Columns(e.ColumnIndex).Name = "Elem"
        ''txtFinasLote.Text = dgvPagables.CurrentRow.Cells("contenido").Value

        sElemento = dgvPagables.Rows(nRowSelected).Cells("Elem").Value  '. .Columns(e.ColumnIndex).Name = "Elem"
        ''txtFinasLote.Text = dgvPagables.Rows(nRowSelected).Cells("contenido").Value

        CargarDatos("A")
        CargarDatos("P")
        CargarDatos("C")
        'For Each row In dgvFJ_APLICACION.Rows

        'Next
        'Dim oBC_TB_FJ_FIJACIONRO As New clsBC_TB_FJ_FIJACIONRO
        'oBC_TB_FJ_FIJACIONRO.oBETB_FJ_FIJACION = New clsBE_TB_FJ_FIJACION
        'oBC_TB_FJ_FIJACIONRO.oBETB_FJ_FIJACION.CANTIDAD = dgvPagables.Rows(nRowSelected).Cells("contenido").Value
        'txtAjusteMaximo.Text = oBC_TB_FJ_FIJACIONRO.Leer_FJ_AJUSTE_ESCALA

        If (pBEUsuario.tablaDetId = "0000000002") Or (pBEUsuario.tablaDetId = "0000000076") Or (pBEUsuario.tablaDetId = "0000000008") Then
            GroupBox4.Visible = True
            cbxOperacionLinea.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            txtElemento.Visible = True
            txtCantidad_Operacion.Visible = True
            txtPrecio_Operacion.Visible = True
        End If


        Dim dCantidad As Decimal = 0
        Dim dPrecioPonderado As Decimal = 0
        If dgvFJ_APLICACION.Rows.Count > 0 Then
            For i = 0 To dgvFJ_APLICACION.Rows.Count - 1
                If (dgvFJ_APLICACION.Rows(i).Cells("APLI_ESTADO").Value.Equals("P") Or dgvFJ_APLICACION.Rows(i).Cells("APLI_ESTADO").Value.Equals("A")) Then
                    dCantidad += dgvFJ_APLICACION.Rows(i).Cells("APLI_CANTIDAD").Value + dgvFJ_APLICACION.Rows(i).Cells("APLI_APLICAR_AJUSTE_MAXIMO").Value
                    dPrecioPonderado += (dgvFJ_APLICACION.Rows(i).Cells("APLI_CANTIDAD").Value + dgvFJ_APLICACION.Rows(i).Cells("APLI_APLICAR_AJUSTE_MAXIMO").Value) * (dgvFJ_APLICACION.Rows(i).Cells("APLI_PRECIO").Value)
                End If
            Next
            If dCantidad > 0 Then
                dgvPagables.Rows(nRowSelectedPagable).Cells("precio_ponderado").Value = dPrecioPonderado / dCantidad
            End If
        End If

        txtCantidad_Operacion.Text = FormatNumber(dgvPagables.Rows(nRowSelected).Cells("contenido_disponible").Value, 4)
        txtPrecio_Operacion.Text = FormatNumber(dgvPagables.Rows(nRowSelected).Cells("precio_ponderado").Value.ToString, 4)
        txtElemento.Text = sElemento
    End Sub


    Private Sub tsbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAgregar.Click
        'Dim oBE_TB_FJ_APLICACION As clsBE_TB_FJ_APLICACION
        'Dim oBC_TB_FJ_APLICACIONTX As New clsBC_TB_FJ_APLICACIONTX

        If dgvFJ_FIJACION.IsCurrentCellDirty Then
            dgvFJ_FIJACION.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

        Dim sMensaje As String = ""
        Dim nContador As Integer = 0
        'Operacion Linea
        If cbxOperacionLinea.Checked Then

            If txtPrecio_Operacion.Text = "" Then
                MsgBox("Debe ingresar el precio a fijar", MsgBoxStyle.Exclamation, "Valorizador Comercial de Minerales")
                Exit Sub
            End If

            Dim oBC_TB_FJ_FIJACIONTX As New clsBC_TB_FJ_FIJACIONTX
            Dim oBE_TB_FJ_FIJACION As New clsBE_TB_FJ_FIJACION

            oBE_TB_FJ_FIJACION.CONTRATOLOTEID = pcontratoloteid
            oBE_TB_FJ_FIJACION.LIQUIDACIONID = pliquidacionid
            oBE_TB_FJ_FIJACION.CANTIDAD = txtCantidad_Operacion.Text
            oBE_TB_FJ_FIJACION.PRECIO = txtPrecio_Operacion.Text

            oBE_TB_FJ_FIJACION.OPERADOR = pBEUsuario.campo3
            oBE_TB_FJ_FIJACION.ELEMENTO = dgvPagables.Rows(nRowSelectedPagable).Cells("Elem").Value

            oBC_TB_FJ_FIJACIONTX.LstTB_FJ_FIJACION_INSERT.Add(oBE_TB_FJ_FIJACION)
            oBC_TB_FJ_FIJACIONTX.TB_FJ_FIJACION_INSERT()

            nContador = 1
        Else
            oBC_TB_FJ_APLICACIONTX = New clsBC_TB_FJ_APLICACIONTX
            oBC_TB_FJ_APLICACIONRO = New clsBC_TB_FJ_APLICACIONRO

            'seleccion de fijaciones
            For Each row In dgvFJ_FIJACION.Rows
                'oDataGridViewCheckBoxColumn = CType(row.cells("cbxAplicar"), DataGridViewCheckBoxCell)

                ''oDataGridViewCheckBoxColumn.Value

                If CBool(row.Cells("fija_cbxAPLICAR").value) Then
                    nContador += 1

                    If row.cells("FIJA_APLICAR").value = 0 Then
                        sMensaje += Chr(10) + "*" + row.cells("FIJA_OC").value
                    Else

                        Dim valor_aFijo As Double = Convert.ToDouble(dgvPagables.CurrentRow.Cells("contenido_disponible").Value).ToString("#.0000")
                        Dim valor_tope As Double = Convert.ToDouble(dgvFJ_FIJACION.CurrentRow.Cells("FIJA_CANTIDAD").Value)
                        Dim valor_aRestar As Double = Convert.ToDouble(dgvFJ_FIJACION.CurrentRow.Cells("FIJA_APLICAR").Value)

                        If (valor_aRestar > valor_tope) Then
                            MessageBox.Show("¡El Valor a Aplicar no puede exceder la Cantidad Fijada!")
                            Return
                        End If

                        If (valor_aRestar > valor_aFijo) Then
                            MessageBox.Show("¡El valor a Aplicar Excede la Cantidad Disponible!")
                            Return
                        End If


                        oBE_TB_FJ_APLICACION = New clsBE_TB_FJ_APLICACION

                        oBE_TB_FJ_APLICACION.oc = row.cells("FIJA_OC").value
                        oBE_TB_FJ_APLICACION.contratoloteid = pcontratoloteid
                        oBE_TB_FJ_APLICACION.liquidacionid = pliquidacionid
                        oBE_TB_FJ_APLICACION.cantidad = row.cells("FIJA_APLICAR").value
                        oBE_TB_FJ_APLICACION.precio = row.cells("FIJA_PRECIO").value

                        oBE_TB_FJ_APLICACION.localizador = pcontrato
                        oBE_TB_FJ_APLICACION.contrato = plocalizador

                        oBE_TB_FJ_APLICACION.usereg = pBEUsuario.campo3

                        oBE_TB_FJ_APLICACION.estado = "P"
                        oBE_TB_FJ_APLICACION.id = row.cells("FIJA_ID").value

                        oBC_TB_FJ_APLICACIONTX.LstTB_FJ_APLICACIONIns.Add(oBE_TB_FJ_APLICACION)

                        MessageBox.Show("c", "hola")


                    End If

                End If

            Next
            oBC_TB_FJ_APLICACIONTX.InsertarLiquidacion()
        End If


        If sMensaje <> "" Then
            MsgBox("Debe ingresar el contenido a fijar para los siguientes OC:" + sMensaje, MsgBoxStyle.Exclamation, "Valorizador de Minerales")
        End If

        If nContador = 0 Then
            MsgBox("Debe seleccionar por lo menos una orden de fijación a aplicar" + sMensaje, MsgBoxStyle.Exclamation, "Valorizador de Minerales")
        End If


        ObtenerPagables()

        Limpiar()

        CargarDatos("A")
        CargarDatos("P")
        CargarDatos("C")

        'dgvPagables.Rows(indicePagable).Selected = True
        dgvPagables.CurrentCell = dgvPagables.Rows(indicePagable).Cells(0)

    End Sub

    ''Private Sub dgvFJ_FIJACION_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvFJ_FIJACION.SelectionChanged

    ''    txtFinasPorAplicar.Text = dgvFJ_FIJACION.CurrentRow.Cells("FIJA_CANTIDAD").Value
    ''    txtPrecio.Text = dgvFJ_FIJACION.CurrentRow.Cells("FIJA_PRECIO").Value

    ''End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            oBC_TB_FJ_APLICACIONTX = New clsBC_TB_FJ_APLICACIONTX
            oBC_TB_FJ_APLICACIONRO = New clsBC_TB_FJ_APLICACIONRO
            Dim aplicadoTotal As Double

            If MsgBox("¿ Está seguro que desea anular la aplicación ?", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then

                For Each row As DataGridViewRow In dgvFJ_APLICACION.Rows

                    If CBool(row.Cells("APLI_cbxAPLICAR").Value) Then

                        'APLI_ESTADO
                        If row.Cells("APLI_ESTADO").Value = "C" Then
                            MsgBox("No puede eliminar la fijación aplicada, porque se encuentra cerrada", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")
                            Exit Sub
                        End If


                        oBE_TB_FJ_APLICACION = New clsBE_TB_FJ_APLICACION

                        oBE_TB_FJ_APLICACION.oc = row.Cells("APLI_OC").Value
                        oBE_TB_FJ_APLICACION.usereg = pBEUsuario.campo3
                        oBE_TB_FJ_APLICACION.estado = "A"
                        oBE_TB_FJ_APLICACION.id = row.Cells("APLI_ID").Value

                        'oBE_TB_FJ_APLICACION.TIPOFIJACION = row.Cells("APLI_TIPOFIJACION").Value

                        oBC_TB_FJ_APLICACIONTX.LstTB_FJ_APLICACIONDel.Add(oBE_TB_FJ_APLICACION)

                        aplicadoTotal = aplicadoTotal + row.Cells("APLI_CANTIDAD").Value
                    End If
                Next

                oBC_TB_FJ_APLICACIONTX.EliminarLiquidacion()

                ObtenerPagables()
                valorDisponible = valorDisponible + aplicadoTotal

            End If
            ''CargarDatos("A")
            ''CargarDatos("P")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

        dgvPagables.CurrentCell = dgvPagables.Rows(indicePagable).Cells(0)

    End Sub

    Private Sub dgvPagables_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagables.CellClick
        indicePagable = e.RowIndex
        valorFijadoTotal = 0
        valorDisponible = 0
    End Sub

    Private Sub dgvPagables_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPagables.SelectionChanged
        'Dim nRowSelected As Integer
        If (dgvPagables.SelectedRows.Count = 0) Then
            nRowSelectedPagable = 0
        Else
            nRowSelectedPagable = dgvPagables.SelectedRows(0).Index
        End If

        actualizarDatos(nRowSelectedPagable)
    End Sub

    Private Sub dgvFJ_APLICACION_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvFJ_APLICACION.CellMouseUp
        dgvFJ_APLICACION.EndEdit()
    End Sub

    Private Sub dgvFJ_FIJACION_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvFJ_FIJACION.DataError

        'Try
        '    'dgvFJ_FIJACION.CurrentRow.Cells(e.ColumnIndex).Value = 0
        'Catch ex As Exception
        '    'oMensajeError.txtMensaje.Text = ex.ToString()
        '    'oMensajeError.ShowDialog()
        'End Try


    End Sub

    Private Sub dgvFJ_FIJACION_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFJ_FIJACION.CellValueChanged

        If dgvFJ_FIJACION.Columns(e.ColumnIndex).Name = "FIJA_cbxAPLICAR" Then
            Dim valorFijacion, valorFijado As Double

            'INCREMENTO EL VALOR DISPONIBLE AL DESMARCAR
            If (dgvFJ_FIJACION.CurrentRow.Cells("FIJA_cbxAPLICAR").Value = 0) Then
                valorDisponible = valorDisponible + dgvFJ_FIJACION.CurrentRow.Cells("FIJA_APLICAR").Value
                'dgvFJ_FIJACION.CurrentRow.Cells("FIJA_APLICAR").Value = 0
            Else
                If (valorFijadoTotal = 0) Then
                    valorDisponible = dgvPagables.CurrentRow.Cells("contenido_disponible").Value
                End If

                valorFijacion = dgvFJ_FIJACION.CurrentRow.Cells("FIJA_CANTIDAD").Value

                If (valorDisponible > valorFijacion) Then
                    dgvFJ_FIJACION.CurrentRow.Cells("FIJA_APLICAR").Value = valorFijacion
                End If

                If (valorDisponible <= valorFijacion) Then
                    dgvFJ_FIJACION.CurrentRow.Cells("FIJA_APLICAR").Value = valorDisponible
                End If


                For i = 0 To dgvFJ_APLICACION.Rows.Count - 1
                    valorFijado = dgvFJ_APLICACION.Rows(i).Cells("APLI_CANTIDAD").Value
                    valorFijadoTotal = valorFijadoTotal + valorFijado
                Next

                If (valorDisponible > valorFijado) Then
                    valorDisponible = valorDisponible - valorFijado
                End If

            End If
        End If


        If dgvPagables.Rows.Count > 0 Then
            If dgvPagables.Columns(e.ColumnIndex).Name = "FIJA_CANTIDAD" Then

                Dim dTotalAplica As Decimal = 0
                Dim dTotalFija As Decimal = 0

                For i = 0 To dgvFJ_FIJACION.Rows.Count - 1
                    dTotalFija += dgvFJ_FIJACION.Rows(i).Cells("FIJA_APLICAR").Value

                    If i = dgvFJ_FIJACION.CurrentRow.Index Then
                        If dgvFJ_FIJACION.Rows(i).Cells("FIJA_CANTIDAD").Value + dgvFJ_FIJACION.Rows(i).Cells("FIJA_AJUSTE_MAXIMO").Value < dgvFJ_FIJACION.CurrentRow.Cells("FIJA_APLICAR").Value Then
                            MsgBox("El contenido ingresado es mayor disponible.", MsgBoxStyle.Critical, "Valorizador de Minerales")
                            Exit Sub
                        End If
                    End If
                Next

                For i = 0 To dgvFJ_APLICACION.Rows.Count - 1
                    dTotalAplica += dgvFJ_APLICACION.Rows(i).Cells("APLI_CANTIDAD").Value
                Next

                If RoundUp(dgvPagables.Rows(nRowSelectedPagable).Cells("Contenido").Value, 4) < dTotalFija + dTotalAplica Then
                    dgvFJ_FIJACION.CurrentRow.Cells("FIJA_APLICAR").Value = 0
                    MsgBox("El contenido ingresado es mayor al permitido para el lote.", MsgBoxStyle.Critical, "Valorizador de Minerales")
                Else
                    dgvPagables.Rows(nRowSelectedPagable).Cells("contenido_disponible").Value = dgvPagables.Rows(nRowSelectedPagable).Cells("Contenido").Value - dTotalAplica - dTotalFija  'dgvPagables.Rows(nRowSelectedPagable).Cells("contenido_aplicado").Value - dgvPagables.Rows(nRowSelectedPagable).Cells("contenido_aplicado_temporal").Value
                    dgvPagables.Rows(nRowSelectedPagable).Cells("contenido_aplicado").Value = dTotalAplica + dTotalFija 'dgvPagables.Rows(nRowSelectedPagable).Cells("contenido_aplicado").Value + dgvPagables.Rows(nRowSelectedPagable).Cells("contenido_aplicado_temporal").Value

                    txtCantidad_Operacion.Text = FormatNumber(dgvPagables.Rows(nRowSelectedPagable).Cells("contenido_disponible").Value, 2)
                End If
            End If
        End If
    End Sub


    Private Function ValidarFijaciones()

        Dim sMensajeValidacion As String = ""
        For i = 0 To dgvPagables.Rows.Count - 1

            If dgvPagables.Rows(i).Cells("FinPrecio").Value.ToString = "1" And _
                dgvPagables.Rows(i).Cells("contenido_disponible").Value > dgvPagables.Rows(i).Cells("ajuste_maximo").Value Then
                'And dgvPagables.Rows(i).Cells("precio_ponderado").Value.ToString = "" Then

                sMensajeValidacion += Chr(10) + "* " + dgvPagables.Rows(i).Cells("Elem").Value + " por " + dgvPagables.Rows(i).Cells("contenido_disponible").Value.ToString + " " + dgvPagables.Rows(i).Cells("undcp").Value
            End If

        Next


        If sMensajeValidacion = "" Then
            Return True
        Else
            MsgBox("Debe generar operación en línea de fijación para: " + sMensajeValidacion, MsgBoxStyle.Exclamation, "Valorizador Comercial de Minerales")
            Return False
        End If


    End Function


    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        dgvPagables.EndEdit()

        Dim oPagableTX As New clsBC_ValorizadorPagableTX
        ' If Not ValidarFijaciones() Then Exit Sub
        Dim valor_aFijo As Double
        Dim flagFijado As Integer

        For Each row As DataGridViewRow In dgvPagables.Rows
            'If (clsUT_Funcion.DbValueToNullable(Of Double)(row.Cells("Fijacion").Value).GetValueOrDefault) = "1" Then

            valor_aFijo = row.Cells("contenido_disponible").Value
            'flagFijado = row.Cells("finprecio").Value

            If (IsDBNull(row.Cells("finprecio").Value)) Then
                flagFijado = 0
            Else
                flagFijado = row.Cells("finprecio").Value
            End If


            If (flagFijado = 1) And (valor_aFijo > 0.1) Then
                MessageBox.Show("¡Debe Aplicar todas las Finas Pagables para Proceder!")
                Return
            End If

            oPagableTX.NuevaEntidad()
            With oPagableTX.oBEValorizadorPagable
                .contratoLoteId = pcontratoloteid
                .liquidacionId = pliquidacionid
                .liquidacionPagable = row.Cells("liquidacionpagable").Value

                .precio = IIf(IsDBNull(row.Cells("precio_ponderado").Value), 0, row.Cells("precio_ponderado").Value)
                '.finPrecio = pcontratoloteid
                .um = pBEUsuario.tablaDetId
                '.finPrecio = IIf((clsUT_Funcion.DbValueToNullable(Of Double)(row.Cells("Fijacion").Value).GetValueOrDefault), "1", "0")

                'FinPrecio
                If IsDBNull(row.Cells("FinPrecio").Value) Then
                    .finPrecio = "0"
                Else
                    .finPrecio = IIf((clsUT_Funcion.DbValueToNullable(Of Double)(row.Cells("FinPrecio").Value).GetValueOrDefault), "1", "0")
                End If

            End With

            oPagableTX.LstValorizadorPagable.Add(oPagableTX.oBEValorizadorPagable)
            'End If
        Next

        oPagableTX.FijacionPreciosValorizadorPagable()

        'For Each row In dgvPagables.Rows
        '    valor_aFijo = Convert.ToDouble(dgvPagables.CurrentRow.Cells("contenido_disponible").Value)
        '    flagFijado = Convert.ToInt16(dgvPagables.CurrentRow.Cells("fijacion").Value)

        '    If (flagFijado = 1) And (valor_aFijo > 0) Then
        '        MessageBox.Show("¡Debe Aplicar todas las Finas Pagables para Proceder!")
        '        Return
        '    End If
        'Next

        Me.Close()
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Try
            Me.Dispose()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub frmFijaciones_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        'Dim value As String = dgvPagables.SelectedRows(0).Cells("contenido_disponible").Value.ToString()
        'Label4.Text = value
    End Sub


    Private Sub tsMenu_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsMenu.ItemClicked

    End Sub

    Private Sub dgvFJ_APLICACION_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFJ_APLICACION.CellContentClick

    End Sub

    Private Sub dgvFJ_APLICACION2_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFJ_APLICACION2.CellContentClick

    End Sub


    Private Sub cbxOperacionLinea_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxOperacionLinea.CheckedChanged

    End Sub

    Private Sub gpopagable_Enter(sender As System.Object, e As System.EventArgs) Handles gpopagable.Enter

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            oBC_TB_FJ_APLICACIONTX = New clsBC_TB_FJ_APLICACIONTX

            Dim ocAplicada As String
            Dim ocId As Integer

            ocAplicada = RTrim(LTrim((dgvFJ_APLICACION2.CurrentRow.Cells("OC").Value.ToString())))
            ocId = RTrim(LTrim((dgvFJ_APLICACION2.CurrentRow.Cells("id").Value)))

            If MsgBox("¿ Está seguro que desea DesAplicar la fijación Seleccionada ?", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then

                oBE_TB_FJ_APLICACION = New clsBE_TB_FJ_APLICACION

                oBE_TB_FJ_APLICACION.oc = ocAplicada
                oBE_TB_FJ_APLICACION.id = ocId
                oBE_TB_FJ_APLICACION.contratoloteid = pcontratoloteid

                oBC_TB_FJ_APLICACIONTX.LstTB_FJ_APLICACIONDel.Add(oBE_TB_FJ_APLICACION)

                oBC_TB_FJ_APLICACIONTX.EliminarLiquidacion2()

                ObtenerPagables()

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
End Class