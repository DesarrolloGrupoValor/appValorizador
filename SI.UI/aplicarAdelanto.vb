Imports SI.UT
Imports SI.UT.clsUT_Enumerado
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsFuncion
Imports SI.BC
Imports SI.BE
Imports System.Text

Imports Microsoft.Reporting.WinForms

''Imports iTextSharp
''Imports iTextSharp.text
''Imports iTextSharp.text.pdf
''Imports System.IO

Imports SI.PL.clsGeneral

Public Class aplicarAdelanto

#Region "Variables Privadas"
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private oDvwAyuda As New DataView
    'Private FontCourier As New Font("Courier New", 8.25)
    Private stylecodpartida As New DataGridViewCellStyle()



    Private sParametro_Ruta As String
    Private sRuta_Archivos As String

    Public sEstado As String = "REVI"

    Public sEstadoAprobadoDescripcion As String = "Revisado"
    Public sEstadoRechazadoDescripcion As String = "Rechazado"

    Public sEstadoAprobar As String
    Public sEstadoRechazar As String

    Public pLiquidacionEstadoDetalleId As Integer
    Public pLiquidacionEstadoId As Integer

    Public pstrContratoLoteId As String
    Public pstrLiquidacionId As String

    Private dtAdjuntarDocumento As DataTable
    Private dvwAdjuntarDocumento As DataView
    Private drowAdjuntarDocumento As DataRow



    Private sRuc_Empresa As String
    Private sRuta_Origen As String

    Private sCategoria As String


#End Region

#Region "Variables Publicas"

    Private dIGV As Double
    Private bModificacion As Boolean = False

    Public pstrNomFormulario As String
    Public pFormAyuda As EnumFormAyuda
    Public oGeneral As New clsBC_GeneralRO
    Public pblnMultiSelect As Boolean
    Public pstrTituloCodigo As String = "Codigo"
    Public pstrTituloDescripcion As String = "Descripcion"
    Public pParametros As New Hashtable
    Public pstrWhere As String = ""
    Public pstrFiltro As String
    Public pstrDominio As clsUT_Dominio
    Public pstrFiltroMovimiento As String

    Public Property contratoLoteId() As String
    Public Property liquidacionId() As String

    Public Property contrato() As String
    Public Property lote() As String
    Public Property proveedor() As String
    Public Property proveedor_nombre() As String

    Public Property oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ
    Public LstFINANCIANDO_PRELIQ_INSERT As New List(Of clsBE_FINANCIANDO_PRELIQ)


    Public Property bAsociar As Boolean = False


    Dim dAPLICA_SIGV As Double
    Dim dAPLICA_CIGV As Double

    Dim nRowIndex As Integer = -1



    Dim bSeleccion As Boolean = False
    Public LstDIG_INDICE As New List(Of clsBE_TB_DIG_INDICE)

#End Region

#Region "Propiedades"

#End Region

#Region "Eventos de Formulario"


    Private Sub aplicarAdelanto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized

        'Obtener el IGV
        Dim oBC_TablaDetRO As New clsBC_TablaDetRO
        Dim oBE_TablaDet As New clsBE_TablaDet
        oBE_TablaDet.tablaId = "impuesto"
        oBE_TablaDet.tablaDetId = "IGV"
        oBC_TablaDetRO.oBETablaDet = oBE_TablaDet
        oBC_TablaDetRO.LeerTablaDet()
        dIGV = Double.Parse(oBC_TablaDetRO.oBETablaDet.descri.ToString)

        cargarFiltros()


        'fxgrdContrato1.AutoGenerateColumns = False
        'dgvPreAplicacion.AutoGenerateColumns = False






        ''fxgFinanciando_preliq.Cols("contratoloteid").Visible = False
        ''fxgFinanciando_preliq.Cols("liquidacionid").Visible = False

        ''fxgFinanciando_preliq.Cols("empresa").Visible = False
        ''fxgFinanciando_preliq.Cols("proveedor_liq").Visible = False


        ''C1FlexGrid1.Cols("contratoloteid").Visible = False
        ''C1FlexGrid1.Cols("liquidacionid").Visible = False
        ''C1FlexGrid1.Cols("item").Visible = False
        ''C1FlexGrid1.Cols("empresa").Visible = False
        ''C1FlexGrid1.Cols("proveedor_liq").Visible = False


        ' ' ''ocultar los descuentos
        tcFinanciamiento.TabPages.RemoveByKey("tpDatos")
        ''tcFinanciamiento.TabPages.RemoveByKey("tpDescuento")


        CargarDatos()

        'AdjuntosPorEstado()


    End Sub

#End Region

#Region "Eventos de Controles"
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub


    Private Sub txtBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        valida_caracterSQL(sender, e)
    End Sub


#End Region

#Region "Rutinas Locales"

    Private Sub CargarDatos()


        Dim oBC_FINANCIANDO_PRELIQRO As New clsBC_FINANCIANDO_PRELIQRO

        Dim dsAyuda As New DataSet
        oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
        'oBC_FINANCIANDO_PRELIQRO.LeerListaFINANCIANDO_PRELIQ()
        oBC_FINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_PREAPLICA()
        'oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ.estado_fin = cboEstado.SelectedValue
        dsAyuda = oBC_FINANCIANDO_PRELIQRO.oDSFINANCIANDO_PRELIQ

        fxgFinanciando_preliq.DataSource = dsAyuda.Tables(0)

        fxgFinanciando_preliq.Cols("contratoloteid").Visible = False
        fxgFinanciando_preliq.Cols("liquidacionid").Visible = False

        fxgFinanciando_preliq.Cols("empresa").Visible = False
        fxgFinanciando_preliq.Cols("proveedor_liq").Visible = False


        fxgFinanciando_preliq.Cols("Nro OP").Visible = False


        fxgFinanciando_preliq.Cols("valorNeto").Visible = False
        fxgFinanciando_preliq.Cols("valorIgv").Visible = False
        fxgFinanciando_preliq.Cols("valorTotal").Visible = False


        C1FlexGrid1.Cols("contratoloteid").Visible = False
        C1FlexGrid1.Cols("liquidacionid").Visible = False
        C1FlexGrid1.Cols("item").Visible = False
        'C1FlexGrid1.Cols("empresa").Visible = False
        'C1FlexGrid1.Cols("proveedor_liq").Visible = False


        'C1FlexGrid1.Cols("nombre_provedor").Width = 200



        fxgFinanciando_preliq.Cols("item").Width = 35
        fxgFinanciando_preliq.Cols("Liq").Width = 40
        'fxgFinanciando_preliq.Cols("Nro OP").Width = 70
        fxgFinanciando_preliq.Cols("LoteVCM").Width = 70
        fxgFinanciando_preliq.Cols("Caja").Width = 70
        fxgFinanciando_preliq.Cols("Adelanto").Width = 70
        fxgFinanciando_preliq.Cols("Descuento").Width = 70
        fxgFinanciando_preliq.Cols("nombre_provedor").Width = 220

        'N2

        fxgFinanciando_preliq.Cols("Caja").Format = "N2"
        fxgFinanciando_preliq.Cols("Adelanto").Format = "N2"
        fxgFinanciando_preliq.Cols("Descuento").Format = "N2"



        ''fxgFinanciando_preliq.Cols("Caja").Visible = False
        ''fxgFinanciando_preliq.Cols("Adelanto").Visible = False
        ''fxgFinanciando_preliq.Cols("Descuento").Visible = False


        ''OBTIENE LOS DATOS DE LOS DOCUMENTOS
        fxgFinanciando_preliq.Cols("codigoDocumento").Visible = False
        fxgFinanciando_preliq.Cols("numeroDocumento").Visible = False
        fxgFinanciando_preliq.Cols("fechaDocumento").Visible = False

        'dgvPreAplicacion.DataSource = dsAyuda.Tables(0)


        'C1FlexGrid1.Cols("nombre_provedor").Visible = False
        'C1FlexGrid1.Cols("nombre_empresa").Visible = False
        'C1FlexGrid1.Cols("loteVCM").Visible = False


    End Sub



#End Region





    Private Sub cargarFiltros()

        Dim lstBE_General As New List(Of clsBE_General)
        Dim oBE_General As clsBE_General

        oBE_General = New clsBE_General
        oBE_General.NomCampo1 = ""
        oBE_General.NomCampo2 = "[Seleccione]"
        lstBE_General.Add(oBE_General)

        oBE_General = New clsBE_General
        oBE_General.NomCampo1 = "ID_TAD"
        oBE_General.NomCampo2 = "Td"
        lstBE_General.Add(oBE_General)

        oBE_General = New clsBE_General
        oBE_General.NomCampo1 = "NUM_COMPR"
        oBE_General.NomCampo2 = "Doc"
        lstBE_General.Add(oBE_General)

        oBE_General = New clsBE_General
        oBE_General.NomCampo1 = "FCH_PROGPAGO"
        oBE_General.NomCampo2 = "Fch OP"
        lstBE_General.Add(oBE_General)

        'cboFiltro1.DataSource = lstBE_General
        'cboFiltro1.ValueMember = "NomCampo1"
        'cboFiltro1.DisplayMember = "NomCampo2"

        'FACTURA
        Obtener_ParametrosCombo(cboTipoDocumento, clsUT_Dominio.domTABLA_DE_DOCUMENTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)




        ''ESTADO LIQUIDACION
        Obtener_ParametrosGridViewCampos(tipoAdjuntarDoc, "AdjuntarDoc", SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, "2", "Descripcion_Retorna", "Id_Retorna")

       

        ''Parametros de ruta de guardar archivos
        'Dim oTablaDetRO As New clsBC_TablaDetRO
        'oTablaDetRO = New clsBC_TablaDetRO
        'oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"
        'oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
        'oTablaDetRO.LeerTablaDet()
        'sParametro_Ruta = oTablaDetRO.oBETablaDet.descri.ToString()

    End Sub



    Private Sub ObtieneRuta()
        'Parametros de ruta de guardar archivos
        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO = New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"

        Select Case txtContrato.Text.Substring(0, 1)
            Case "P"
                oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
            Case "V"
                oTablaDetRO.oBETablaDet.tablaDetId = "0000000003"
            Case "S"
                oTablaDetRO.oBETablaDet.tablaDetId = "0000000002"
        End Select

        oTablaDetRO.LeerTablaDet()
        sParametro_Ruta = oTablaDetRO.oBETablaDet.descri.ToString()
    End Sub



    Private Sub tsbAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAplicar.Click
        Try
            fgxDescuento.EndUpdate()

            'VALIDACION CONTABLE
            If txtCantidadPagados.Text > 0 Then
                MsgBox("No se puede aplicar comercialmente." & Chr(10) & "Existe algún adelanto pendiente de pago.", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                Exit Sub
            End If

            'VALIDACION FLUJO
            If txtliquidacionEstadoId.Text <> "0" Then
                If txtEstadoId.Text = "FACT" Then
                    MsgBox("Todavía no puede aplicar comercialmente, debe ser Facturado en Nazca.", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                    Exit Sub
                End If
            End If

            'Para poder pasar al siguiente estado
            'sEstado = "VALI"

            'Valida los documentos obligatorios
            Dim sMensajeValidacion As String = ValidarAdjuntarObligatorios()
            If sMensajeValidacion <> "" Then
                MsgBox("No puede ser Revisado, porque" & Chr(10) & "debe adjuntar los siguientes documentos: " & Chr(10) & sMensajeValidacion, MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                Exit Sub
            End If

            If Not ValidarContrato("LIQ") Then Exit Sub


            'VALIDACION COMERCIAL
            For i = 1 To fgxDescuento.Rows.Count - 1
                If fgxDescuento.Rows(i)("DESCRIPCION") = "" Then
                    MsgBox("Debe ingresar la descripción", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                    Exit Sub
                End If

                ''If fgxDescuento.Rows(i)("FECHA_CARTA").ToString = "" Then
                ''    MsgBox("Debe ingresar la fecha de la carta", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                ''    'Exit Sub
                ''End If
            Next


            Dim oBC_TB_DESCUENTOS_LIQTX As New clsBC_TB_DESCUENTOS_LIQTX
            For i = 1 To fgxDescuento.Rows.Count - 1

                oBC_TB_DESCUENTOS_LIQTX.NuevaEntidad()

                With oBC_TB_DESCUENTOS_LIQTX.oBETB_DESCUENTOS_LIQ
                    .ITEM = fgxDescuento.Rows(i)("ITEM")
                    .SEC = fgxDescuento.Rows(i)("SEC")
                    .DESCRIPCION = fgxDescuento.Rows(i)("DESCRIPCION")
                    '.FECHA_CARTA = fgxDescuento.Rows(i)("FECHA_CARTA")


                    If fgxDescuento.Rows(i)("FECHA_CARTA").ToString = "" Then
                        .FECHA_CARTA = "01/01/1900"
                    Else
                        .FECHA_CARTA = fgxDescuento.Rows(i)("FECHA_CARTA")
                    End If

                    'moneda en soles
                    If fgxDescuento.Rows(i)("IMP_MONEDA") <> 0 Then
                        .IMP_MONEDA = fgxDescuento.Rows(i)("IMP_MONEDA")
                        .MONEDA = "MN"
                    Else
                        .IMP_MONEDA = 0
                        .MONEDA = ""
                    End If


                End With
                oBC_TB_DESCUENTOS_LIQTX.LstTB_DESCUENTOS_LIQ_INSERT.Add(oBC_TB_DESCUENTOS_LIQTX.oBETB_DESCUENTOS_LIQ)
            Next
            oBC_TB_DESCUENTOS_LIQTX.TB_DESCUENTOS_LIQ_UPDATE()




            '' ''---ESTADO LIQUIDACION
            ''sMensajeValidacion = ValidarAdjuntarObligatorios()

            ''If sMensajeValidacion = "" Then
            ''    GuardarEstado(sEstadoAprobar, sEstadoAprobadoDescripcion)

            ''Else
            ''    MsgBox("No puede ser " & sEstadoAprobadoDescripcion.ToUpper & ", porque" & Chr(10) & "debe adjuntar los siguientes documentos: " & Chr(10) & sMensajeValidacion, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            ''    Exit Sub
            ''End If
            '' ''---ESTADO LIQUIDACION




            'ADELANTOS
            If tcFinanciamiento.SelectedIndex = 0 Then
                If MsgBox("Esta seguro que desea aplicar", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                    Dim sValidarCampos As String = vaLidaCampos()
                    Dim nItem As Integer
                    Dim sEmpresa As String

                    If vaLidaCampos() = "" Then

                        Dim oBC_FINANCIANDO_PRELIQTX As New clsBC_FINANCIANDO_PRELIQTX
                        Dim oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ

                        With oBE_FINANCIANDO_PRELIQ
                            .sOperacion = "A"


                            .sContratoLoteId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "contratoloteid").ToString
                            .sLiquidacionId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "liquidacionId").ToString


                            .tipo_compr_liq = cboTipoDocumento.SelectedValue
                            .NUM_COMPR_LIQ = txtNumeroDocumento.Text
                            .dFechaLiquidacion = dtpFechaDocumento.Text

                            sEmpresa = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "empresa").ToString
                            nItem = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "item").ToString 'dgvPreAplicacion.SelectedRows(0).Cells("item").Value
                            .Item = nItem
                        End With

                        oBC_FINANCIANDO_PRELIQTX.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ





                        ''******************************************************************************************************************************************
                        ''KMN 2013/06/18 CAMBIAR
                        ''llama al sp que aplica el adelanto
                        Dim nExiste As Integer = oBC_FINANCIANDO_PRELIQTX.financiando_preliq_APLICA()
                        'Dim nExiste As Integer = 2326 ' oBC_FINANCIANDO_PRELIQTX.financiando_preliq_APLICA()
                        '************************************************************************
                        Dim sArchivo As String = ""

                        '**********************************************************************
                        'Obtiene la ruta en donde se genera el documento
                        Dim sRutas As String = ""
                        Dim oBC_TB_TABLAS_GEN As New clsBC_TB_TABLAS_GENRO
                        Dim dsTB_TABLAS_GEN As DataSet
                        oBC_TB_TABLAS_GEN.oBETB_TABLAS_GEN.clave = "10"
                        oBC_TB_TABLAS_GEN.oBETB_TABLAS_GEN.codigo = "006"
                        oBC_TB_TABLAS_GEN.LeerListaTB_TABLAS_GEN()
                        dsTB_TABLAS_GEN = oBC_TB_TABLAS_GEN.oDSTB_TABLAS_GEN
                        If dsTB_TABLAS_GEN.Tables(0).Rows.Count > 0 Then
                            sRutas = dsTB_TABLAS_GEN.Tables(0).Rows(0)("descripcion") & "\"
                        End If
                        '**********************************************************************

                        If nExiste > 0 Then


                            sArchivo = "LIQ_" & txtLoteVCM.Text.Replace("/", " - ") & lote & "_" & RTrim(txtNombre_Provedor.Text) & ".pdf"
                            'sArchivo = sRuc_Empresa & "_OCIE_" & nItem.ToString() & ".pdf"
                            sArchivo = txtRucSocio.Text & "_OCIE_" & nItem.ToString() & ".pdf"
                            'sArchivo = nItem.ToString() & ".pdf"

                            'digitalizacion
                            Dim oBC_TB_DIG_INDICETX As New clsBC_TB_DIG_INDICETX
                            Dim oBETB_DIG_INDICE = New clsBE_TB_DIG_INDICE
                            oBETB_DIG_INDICE.ARCHIVO = sArchivo
                            oBETB_DIG_INDICE.EMPRESA = sRuc_Empresa
                            oBETB_DIG_INDICE.CONTRATO = txtContrato.Text
                            oBETB_DIG_INDICE.LOTE = txtLote.Text
                            oBETB_DIG_INDICE.NRO_DOC_INTERNO = nItem.ToString
                            oBETB_DIG_INDICE.PROVEEDOR = txtRucSocio.Text
                            oBETB_DIG_INDICE.IDTIPODOC_DIG = "OCIE"

                            oBETB_DIG_INDICE.IDFLUJO = "VCM"
                            oBETB_DIG_INDICE.LOTE_LIQ = txtLote.Text
                            oBETB_DIG_INDICE.CONTRATO_LIQ = txtContrato.Text
                            oBETB_DIG_INDICE.FECHA_DOC = Now


                            oBETB_DIG_INDICE.RUTA = sRuc_Empresa + "\" + txtRucSocio.Text + "\" + txtContrato.Text + "\" + txtLote.Text

                            oBETB_DIG_INDICE.ContratoLoteId = pstrContratoLoteId
                            oBETB_DIG_INDICE.LiquidacionId = pstrLiquidacionId
                            oBETB_DIG_INDICE.liquidacionAdjuntoId = "0000000012"

                            oBETB_DIG_INDICE.liquidacionEstadoId = pLiquidacionEstadoId
                            oBETB_DIG_INDICE.liquidacionEstadoDetalleId = pLiquidacionEstadoDetalleId
                            oBETB_DIG_INDICE.uc = pBEUsuario.tablaDetId



                            'LstDIG_INDICE.Add(oBETB_DIG_INDICE)
                            oBC_TB_DIG_INDICETX.LstTB_DIG_INDICE_INSERT.Add(oBETB_DIG_INDICE)
                            oBC_TB_DIG_INDICETX.TB_DIG_INDICE_INSERT()


                            'digitalizacion


                            'Inserta el cierre
                            Dim oBC_TB_CIERRE_DOCTX As New clsBC_TB_CIERRE_DOCTX
                            oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Item_cierre = nItem
                            oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Archivo = sArchivo
                            'oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Archivo = nItem.ToString() & "_" & sArchivo ' nItem.ToString() & "_LIQ" & contrato & "-" & lote & "_" & proveedor_nombre & ".pdf"
                            oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Ruta = sArchivo

                            ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.IDITEM = oBC_TB_CIERRE_DOCTX.LstTB_CIERRE_DOC_INSERT(0).IDITEM
                            ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.IDTIPODOC_DIG = oBC_TB_CIERRE_DOCTX.LstTB_CIERRE_DOC_INSERT(0).IDTIPODOC_DIG

                            oBC_TB_CIERRE_DOCTX.LstTB_CIERRE_DOC_INSERT.Add(oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC)
                            oBC_TB_CIERRE_DOCTX.TB_CIERRE_DOC_INSERT()


                            Dim rpItem As New ReportParameter()
                            rpItem.Name = "ITEM"
                            rpItem.Values.Add(nItem)

                            Dim rpEmpresa As New ReportParameter()
                            rpEmpresa.Name = "empresa"
                            rpEmpresa.Values.Add(sEmpresa)

                            'Set the report parameters for the report
                            Dim parameters() As ReportParameter = {rpItem, rpEmpresa}

                            ' ''**********************************************************************
                            ' ''Obtiene la ruta en donde se genera el documento
                            ''Dim sRutas As String = ""
                            ''Dim oBC_TB_TABLAS_GEN As New clsBC_TB_TABLAS_GENRO
                            ''Dim dsTB_TABLAS_GEN As DataSet
                            ''oBC_TB_TABLAS_GEN.oBETB_TABLAS_GEN.clave = "10"
                            ''oBC_TB_TABLAS_GEN.oBETB_TABLAS_GEN.codigo = "006"
                            ''oBC_TB_TABLAS_GEN.LeerListaTB_TABLAS_GEN()
                            ''dsTB_TABLAS_GEN = oBC_TB_TABLAS_GEN.oDSTB_TABLAS_GEN
                            ''If dsTB_TABLAS_GEN.Tables(0).Rows.Count > 0 Then
                            ''    sRutas = dsTB_TABLAS_GEN.Tables(0).Rows(0)("descripcion") & "\"
                            ''End If
                            ' ''**********************************************************************

                            'sRutas = "F:\Informations\EJEMPLOS\Demo\"
                            Dim oGenerarPDF As New frmGenerarPDF
                            oGenerarPDF.pParametros = parameters
                            'oGenerarPDF.pRutaGenerarPDF = sRutas & nItem.ToString() & "_" & sArchivo
                            oGenerarPDF.pRutaGenerarPDF = sRutas + sRuc_Empresa + "\" + txtRucSocio.Text + "\" + txtContrato.Text + "\" + txtLote.Text + "\" + sArchivo
                            oGenerarPDF.pNombreReporte = "InterfaceAdelantosPreAplicados"
                            oGenerarPDF.Show()


                            If sArchivo <> "" Then
                                If tsbCboTipoAdjunto.Items.Count > 0 And tsbAdjuntar.Enabled = True Then
                                    tsbCboTipoAdjunto.SelectedIndex = 5
                                    'AgregarAdjunto(sRutas & nItem.ToString() & "_" & sArchivo)
                                    AgregarAdjunto(sRutas & sArchivo)
                                    tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0
                                End If

                            End If

                        End If





                        ''tsbFiltrar_Click(sender, e)
                        ''MsgBox("Se Aplicó satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")

                        If txtliquidacionEstadoId.Text = 0 Then
                            tsbFiltrar_Click(sender, e)
                            MsgBox("Se Aplicó satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                        Else
                            'pstrContratoLoteId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "contratoloteid").ToString
                            'pstrLiquidacionId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "liquidacionid").ToString
                            'ObtenerDatos()













                            Dim oBC_LiquidacionAdjuntoTX As New clsBC_LiquidacionAdjuntoTX

                            Dim sArchivoDestino As String
                            Dim sTipoAdjuntarDoc As String

                            Dim sArchivoACopiar As String

                            For i = 0 To dgvLiquidacionAdjunto.RowCount - 1

                                'valida que sea archivo nuevo
                                'If String.IsNullOrEmpty(dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionAdjuntoId").Value.ToString) Then
                                If dgvLiquidacionAdjunto.Item("ruta", i).Value <> "" Then
                                    sArchivoACopiar = dgvLiquidacionAdjunto.Item("ruta", i).Value
                                    sArchivoDestino = sParametro_Ruta & sRuta_Archivos & "\" & dgvLiquidacionAdjunto.Item("archivo", i).Value 'sArchivoDestino

                                    oBC_LiquidacionAdjuntoTX.NuevaEntidad()
                                    With oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto
                                        .liquidacionEstadoId = dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionEstadoId").Value
                                        .liquidacionEstadoDetalleId = dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionEstadoDetalleId").Value
                                        .tipoAdjuntarDoc = dgvLiquidacionAdjunto.Rows(i).Cells("tipoAdjuntarDoc").Value 'sTipoAdjuntarDoc 'dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("tipoAdjuntarDoc").Value
                                        .ruta = sArchivoDestino 'dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("ruta").Value
                                        .archivo = dgvLiquidacionAdjunto.Rows(i).Cells("archivo").Value
                                        .uc = pBEUsuario.tablaDetId

                                        oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Add(oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto)
                                    End With


                                    If dgvLiquidacionAdjunto.Rows(i).Cells("tipoAdjuntarDoc").Value <> "0000000008" And dgvLiquidacionAdjunto.Rows(i).Cells("tipoAdjuntarDoc").Value <> "0000000012" Then
                                        'crea los archivos nuevos
                                        If System.IO.File.Exists(sArchivoDestino) Then
                                            System.IO.File.Delete(sArchivoDestino)
                                        End If
                                        System.IO.File.Copy(sArchivoACopiar, sArchivoDestino)
                                    End If

                                End If

                            Next

                            'Elimina los archivos fisiscos
                            For Each oLiquidacionAdjunto As clsBE_LiquidacionAdjunto In oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar
                                sArchivoDestino = sRuta_Archivos & "\" & oLiquidacionAdjunto.archivo
                                System.IO.File.Delete(sArchivoDestino)
                            Next


                            ''kmn 21/08/2013
                            'oBC_LiquidacionAdjuntoTX.InsertaLiquidacionAdjunto()
                            oBC_LiquidacionAdjuntoTX.EliminaLiquidacionAdjunto()
                            oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Clear()
                            oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar.Clear()

                            Dim oLiquidacionEstadoDetalleTX As New clsBC_LiquidacionEstadoDetalleTX
                            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
                            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.contratoLoteId = pstrContratoLoteId
                            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionId = pstrLiquidacionId
                            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.usuarioId = pBEUsuario.tablaDetId
                            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.estadoId = "VALI"
                            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.observaciones = txtObservaciones.Text

                            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
                            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId = pLiquidacionEstadoDetalleId
                            'KMN ACTUALIZAR 21/08/2013
                            oLiquidacionEstadoDetalleTX.InsertaLiquidacionEstado()

                            ''ObtenerLiquidacionAdjunto()

                            MsgBox("La liquidación ha sido revisada satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                            'Me.Dispose()


                            tcFinanciamiento.SelectedTab = tpAdelantos
                            tsbFiltrar_Click(sender, e)




                            ' ''Dim oLiquidacionEstadoDetalleTX As New clsBC_LiquidacionEstadoDetalleTX
                            ' ''oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
                            ' ''oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.contratoLoteId = pstrContratoLoteId
                            ' ''oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionId = pstrLiquidacionId
                            ' ''oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.usuarioId = pBEUsuario.tablaDetId
                            ' ''oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.estadoId = "REV"
                            ' ''oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.observaciones = txtObservaciones.Text

                            ' ''oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
                            ' ''oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId = pLiquidacionEstadoDetalleId
                            '' ''oLiquidacionEstadoDetalleTX.InsertaLiquidacionEstado()


                            ' ''MsgBox("Se Aplicó satisfactoriamente. Debe adjuntar los documentos de sustento.", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                            ' ''tcFinanciamiento.SelectedTab = tpDatos
                            ' ''ObtenerDatos()


                            '' ''Adjunto el documento de OC
                            ' ''If sArchivo <> "" Then
                            ' ''    tsbCboTipoAdjunto.SelectedIndex = 5
                            ' ''    'AgregarAdjunto(sRutas & nItem.ToString() & "_" & sArchivo)
                            ' ''    AgregarAdjunto(sRutas & sArchivo)
                            ' ''    tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0
                            ' ''End If





                        End If

                        'tsbFiltrar_Click(sender, e)

                    Else

                        MsgBox(sValidarCampos, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                    End If

                    'CargarDatos()

                End If

                ' ''    'ESTADO LIQUIDACION
                ' ''ElseIf tcFinanciamiento.SelectedIndex = 1 Then

                ' ''    'Para poder pasar al siguiente estado
                ' ''    sEstado = "VALI"

                ' ''    'Valida los documentos obligatorios
                ' ''    sMensajeValidacion = ValidarAdjuntarObligatorios()
                ' ''    If sMensajeValidacion <> "" Then

                ' ''        MsgBox("No puede ser Revisado, porque" & Chr(10) & "debe adjuntar los siguientes documentos: " & Chr(10) & sMensajeValidacion, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                ' ''    Else




                ' ''        Dim oBC_LiquidacionAdjuntoTX As New clsBC_LiquidacionAdjuntoTX

                ' ''        Dim sArchivoDestino As String
                ' ''        Dim sTipoAdjuntarDoc As String

                ' ''        Dim sArchivoACopiar As String

                ' ''        For i = 0 To dgvLiquidacionAdjunto.RowCount - 1

                ' ''            'valida que sea archivo nuevo
                ' ''            If String.IsNullOrEmpty(dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionAdjuntoId").Value.ToString) Then
                ' ''                sArchivoACopiar = dgvLiquidacionAdjunto.Item("ruta", i).Value
                ' ''                sArchivoDestino = sParametro_Ruta & sRuta_Archivos & "\" & dgvLiquidacionAdjunto.Item("archivo", i).Value 'sArchivoDestino

                ' ''                oBC_LiquidacionAdjuntoTX.NuevaEntidad()
                ' ''                With oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto
                ' ''                    .liquidacionEstadoId = dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionEstadoId").Value
                ' ''                    .liquidacionEstadoDetalleId = dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionEstadoDetalleId").Value
                ' ''                    .tipoAdjuntarDoc = dgvLiquidacionAdjunto.Rows(i).Cells("tipoAdjuntarDoc").Value 'sTipoAdjuntarDoc 'dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("tipoAdjuntarDoc").Value
                ' ''                    .ruta = sArchivoDestino 'dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("ruta").Value
                ' ''                    .archivo = dgvLiquidacionAdjunto.Rows(i).Cells("archivo").Value
                ' ''                    .uc = pBEUsuario.tablaDetId

                ' ''                    oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Add(oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto)
                ' ''                End With

                ' ''                'crea los archivos nuevos
                ' ''                If System.IO.File.Exists(sArchivoDestino) Then
                ' ''                    System.IO.File.Delete(sArchivoDestino)
                ' ''                End If
                ' ''                System.IO.File.Copy(sArchivoACopiar, sArchivoDestino)
                ' ''            End If

                ' ''        Next

                ' ''        'Elimina los archivos fisiscos
                ' ''        For Each oLiquidacionAdjunto As clsBE_LiquidacionAdjunto In oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar
                ' ''            sArchivoDestino = sRuta_Archivos & "\" & oLiquidacionAdjunto.archivo
                ' ''            System.IO.File.Delete(sArchivoDestino)
                ' ''        Next

                ' ''        oBC_LiquidacionAdjuntoTX.InsertaLiquidacionAdjunto()
                ' ''        oBC_LiquidacionAdjuntoTX.EliminaLiquidacionAdjunto()
                ' ''        oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Clear()
                ' ''        oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar.Clear()

                ' ''        Dim oLiquidacionEstadoDetalleTX As New clsBC_LiquidacionEstadoDetalleTX
                ' ''        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
                ' ''        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.contratoLoteId = pstrContratoLoteId
                ' ''        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionId = pstrLiquidacionId
                ' ''        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.usuarioId = pBEUsuario.tablaDetId
                ' ''        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.estadoId = sEstado
                ' ''        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.observaciones = txtObservaciones.Text

                ' ''        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
                ' ''        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId = pLiquidacionEstadoDetalleId
                ' ''        'KMN ACTUALIZAR 21/08/2013
                ' ''        ''oLiquidacionEstadoDetalleTX.InsertaLiquidacionEstado()

                ' ''        ObtenerLiquidacionAdjunto()

                ' ''        MsgBox("La liquidación ha sido revisada satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                ' ''        'Me.Dispose()


                ' ''        tcFinanciamiento.SelectedTab = tpAdelantos
                ' ''        tsbFiltrar_Click(sender, e)
                ' ''    End If
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Function ValidarContrato(Optional ByVal sTipoValidacion As String = "")

        Dim strmensaje As String = ""
        Try

            '=============================================================================================================================
            Dim oBC_TablaDetRO As New clsBC_TablaDetRO
            '=============================================================================================================================

            'VIGENCIA CONTRATO
            Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
            oBC_ContratoLoteRO.oBEContratoLote = New clsBE_ContratoLote
            oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento = txtLoteVCM.Text.TrimEnd.Substring(1, 1)
            oBC_ContratoLoteRO.oBEContratoLote.contrato = txtLoteVCM.Text.TrimEnd
            oBC_ContratoLoteRO.oBEContratoLote.codigoTabla = "CON"
            oBC_ContratoLoteRO.oBEContratoLote.lote = ""
            oBC_ContratoLoteRO.VerificarNumeroLote()

            If oBC_ContratoLoteRO.oBEContratoLote.VigenciaFin < Date.Now Then
                MsgBox("El contrato esta vencido, debe regularizar la fecha de vigencia", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
            End If


            If oBC_ContratoLoteRO.oBEContratoLote.estado_con <> "1" Then
                'MsgBox(oBC_ContratoLoteRO.oBEContratoLote.mensaje_con, MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                strmensaje = strmensaje & oBC_ContratoLoteRO.oBEContratoLote.mensaje_con
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


    Private Function vaLidaCampos() As String
        Dim sMensaje As String = ""

        If txtNumeroDocumento.Text = "" Then
            sMensaje = sMensaje & "* Debe ingresar Numero de Documento" & Chr(10)
        End If

        If cboTipoDocumento.SelectedIndex = 0 Then
            sMensaje = sMensaje & "* Debe ingresar Tipo de Documento" & Chr(10)
        End If

        If dtpFechaDocumento.Text = "01/01/1900" Then
            sMensaje = sMensaje & "* Debe ingresar Fecha del Documento" & Chr(10)
        End If

        Return sMensaje
    End Function



    ''Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    Dim sValidarCampos As String = vaLidaCampos()
    ''    If vaLidaCampos() = "" Then

    ''        Dim oBC_FINANCIANDO_PRELIQTX As New clsBC_FINANCIANDO_PRELIQTX
    ''        Dim oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ

    ''        With oBE_FINANCIANDO_PRELIQ
    ''            .sOperacion = "A"
    ''            .Item = fxgrdContrato.Item(fxgrdContrato.RowSel, "item").ToString 'dgvPreAplicacion.SelectedRows(0).Cells("item").Value
    ''        End With

    ''        oBC_FINANCIANDO_PRELIQTX.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
    ''        oBC_FINANCIANDO_PRELIQTX.financiando_preliq_DELETE()
    ''        '************************************************************************


    ''        ' ''Inserta el cierre
    ''        ''Dim oBC_TB_CIERRE_DOCTX As New clsBC_TB_CIERRE_DOCTX
    ''        ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Item_cierre = 0
    ''        ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Archivo = 0 & "_LIQ" & contrato & "-" & lote & "_" & proveedor_nombre & ".pdf"
    ''        ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Ruta = "LIQ" & contrato & "-" & lote & "_" & proveedor_nombre & ".pdf"
    ''        ''oBC_TB_CIERRE_DOCTX.LstTB_CIERRE_DOC_INSERT.Add(oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC)
    ''        ''oBC_TB_CIERRE_DOCTX.TB_CIERRE_DOC_INSERT()

    ''        MsgBox("Se Aplico satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
    ''    Else

    ''        MsgBox(sValidarCampos, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
    ''    End If


    ''    ' ''Inserta el cierre
    ''    ''Dim oBC_TB_CIERRE_DOCTX As New clsBC_TB_CIERRE_DOCTX
    ''    ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Item_cierre = 0
    ''    ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Archivo = 0 & "_LIQ" & contrato & "-" & lote & "_" & proveedor_nombre & ".pdf"
    ''    ''oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC.Ruta = "LIQ" & contrato & "-" & lote & "_" & proveedor_nombre & ".pdf"
    ''    ''oBC_TB_CIERRE_DOCTX.LstTB_CIERRE_DOC_INSERT.Add(oBC_TB_CIERRE_DOCTX.oBETB_CIERRE_DOC)
    ''    ''oBC_TB_CIERRE_DOCTX.TB_CIERRE_DOC_INSERT()



    ''End Sub



    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    Private Sub tsbFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFiltrar.Click
        CargarDatos()
        Limpiar()
    End Sub


    Private Sub Limpiar()
        txtLoteVCM.Text = ""
        txtNombre_Empresa.Text = ""
        txtNombre_Provedor.Text = ""

        txtCajaChicaA.Text = ""
        txtAdelantoA.Text = ""
        txtDescuentoA.Text = ""

        txtValorNetoA.Text = ""
        txtValorIgvA.Text = ""
        txtValorTotalA.Text = ""

        txtNumeroDocumento.Text = ""
        cboTipoDocumento.SelectedIndex = 0

        dtpFechaDocumento.Value = "01/01/1900"


        txtObservaciones.Text = ""
        txtObservacionAnterior.Text = ""

    End Sub

    Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click
        'txtContrato.Text = ""
        'txtRuma.Text = ""
        'txtCondicion1.Text = ""

        'cboFiltro1.SelectedIndex = 0

        tsbFiltrar_Click(sender, e)

        'dgvPreAplicacion.DataSource = Nothing

        bSeleccion = False
        bAsociar = False

    End Sub



    Private Sub txtContrato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            tsbFiltrar_Click(sender, e)
        End If
    End Sub


    Private Sub CargarDatosAplicados()

        Dim oBC_FINANCIANDO_PRELIQRO As New clsBC_FINANCIANDO_PRELIQRO

        Dim dsAyuda As New DataSet
        oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
        'oBC_FINANCIANDO_PRELIQRO.LeerListaToDSAplicados()
        oBC_FINANCIANDO_PRELIQRO.LeerListaFINANCIANDO_PRELIQ()
        dsAyuda = oBC_FINANCIANDO_PRELIQRO.oDSFINANCIANDO_PRELIQ

        fxgFinanciando_preliq.DataSource = dsAyuda.Tables(0)

    End Sub



    Private Sub tsbRechazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRechazar.Click

        'Adelanto
        If tcFinanciamiento.SelectedIndex = 0 Then
            If MsgBox("Esta seguro de desea rechazar", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then


                If txtObservaciones.Text = "" Then
                    MsgBox("Debe ingresar la observación", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                    Exit Sub
                Else


                    Dim oLiquidacionEstadoDetalleTX As New clsBC_LiquidacionEstadoDetalleTX
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.contratoLoteId = pstrContratoLoteId
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionId = pstrLiquidacionId
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.usuarioId = pBEUsuario.tablaDetId
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.estadoId = "RHRE"
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.observaciones = txtObservaciones.Text

                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId = pLiquidacionEstadoDetalleId
                    'KMN ACTUALIZAR 21/08/2013
                    oLiquidacionEstadoDetalleTX.InsertaLiquidacionEstado()

                    'Dim oBC_FINANCIANDO_PRELIQTX As New clsBC_FINANCIANDO_PRELIQTX
                    'Dim oBE_FINANCIANDO_PRELIQ As New clsBE_FINANCIANDO_PRELIQ

                    'With oBE_FINANCIANDO_PRELIQ
                    '    .sOperacion = "D"
                    '    .Item = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "item").ToString 'dgvPreAplicacion.SelectedRows(0).Cells("item").Value
                    '    .sContratoLoteId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "contratoloteid").ToString 'dgvPreAplicacion.SelectedRows(0).Cells("item").Value
                    '    .sLiquidacionId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "liquidacionId").ToString 'dgvPreAplicacion.SelectedRows(0).Cells("item").Value
                    'End With

                    'oBC_FINANCIANDO_PRELIQTX.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ


                    ''envio de correo de rechazo de financiamiento
                    'enviarCorreoRechazo(fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "contratoloteid").ToString, fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "liquidacionId").ToString, fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "Nombre_Provedor").ToString, fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "LoteVCM").ToString)

                    'oBC_FINANCIANDO_PRELIQTX.financiando_preliq_DELETE()

                    MsgBox("Se Rechazó satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")

                    CargarDatos()
                    'CargarDatosAplicados()

                End If
            End If

                'Estado
            ElseIf tcFinanciamiento.SelectedIndex = 1 Then


            End If



    End Sub



    Private Sub enviarCorreoRechazo(ByVal sContratoLoteId As String, ByVal sLiquidacion As String, ByVal sProveedor As String, ByVal sLote As String)
        Dim nContar As Integer

        Dim sDestinatario As String = ""
        Dim sCuerpo As String = "Los adelantos y/o descuentos del lote " + sLote + " han sido rechazados comercialmente." + Chr(10) + "Proveedor: " + sProveedor + Chr(10) + Chr(10)
        Dim sAsunto As String = sLote + " Los adelantos y/o descuentos han sido rechazados"

        Dim oBC_TablaDetRO As clsBC_TablaDetRO

        Dim dsLiquidacionDscto As DataSet
        Dim oBC_LiquidacionDsctoRO As New clsBC_LiquidacionDsctoRO
        Dim oBC_LiquidacionRO As New clsBC_LiquidacionRO

        'Obtiene el detalle de los descuentos para ser mostrado en el corrreo
        oBC_LiquidacionDsctoRO.oBELiquidacionDscto = New clsBE_LiquidacionDscto
        oBC_LiquidacionDsctoRO.oBELiquidacionDscto.contratoLoteId = sContratoLoteId
        oBC_LiquidacionDsctoRO.oBELiquidacionDscto.liquidacionId = sLiquidacion
        dsLiquidacionDscto = oBC_LiquidacionDsctoRO.LeerListaToDSLiquidacionDscto()
        If dsLiquidacionDscto.Tables(0).Rows.Count > 0 Then
            For nContar = 0 To dsLiquidacionDscto.Tables(0).Rows.Count - 1
                sCuerpo += dsLiquidacionDscto.Tables(0).Rows(nContar)("codigoDscto").ToString + " -  " + dsLiquidacionDscto.Tables(0).Rows(nContar)("descri").ToString + " Importe: " + dsLiquidacionDscto.Tables(0).Rows(nContar)("importe").ToString + Chr(10)
                sDestinatario += dsLiquidacionDscto.Tables(0).Rows(nContar)("uc").ToString
            Next
        End If
        sCuerpo += Chr(10) + "Enviado desde el VCM."


        ' obtiene el usuario
        oBC_LiquidacionRO.oBELiquidacion = New clsBE_Liquidacion
        oBC_LiquidacionRO.oBELiquidacion.contratoLoteId = sContratoLoteId
        oBC_LiquidacionRO.oBELiquidacion.liquidacionId = sLiquidacion
        oBC_LiquidacionRO.LeerLiquidacion()

        'obtiene el e-mail
        oBC_TablaDetRO = New clsBC_TablaDetRO
        oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
        oBC_TablaDetRO.oBETablaDet.tablaId = "usuario"
        oBC_TablaDetRO.oBETablaDet.tablaDetId = oBC_LiquidacionRO.oBELiquidacion.uc
        oBC_TablaDetRO.LeerTablaDet()

        sDestinatario = oBC_TablaDetRO.oBETablaDet.campo4

        EnvioCorreo(sDestinatario, sAsunto, sCuerpo)

    End Sub

    Private Sub fxgFinanciando_preliq_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgFinanciando_preliq.DoubleClick
        pstrContratoLoteId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "contratoloteid").ToString
        pstrLiquidacionId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "liquidacionid").ToString


        ObtenerDatos()


        
    End Sub


    Private Sub fxgFinanciando_preliq_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgFinanciando_preliq.SelChange ', C1FlexGrid1.SelChange ', fgxDescuento.SelChange

        txtObservaciones.Text = ""
        txtObservacionAnterior.Text = ""

        If fxgFinanciando_preliq.Cols.Count > 5 Then
            If fxgFinanciando_preliq.RowSel > 0 Then
                Dim oBC_FINANCIANDO_PRELIQRO As New clsBC_FINANCIANDO_PRELIQRO
                Dim oBC_TB_DESCUENTOS_LIQRO As New clsBC_TB_DESCUENTOS_LIQRO

                Dim dsAyuda As New DataSet
                Dim dsTB_DESCUENTOS_LIQ As DataSet

                oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ = oBE_FINANCIANDO_PRELIQ
                'oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ.Item = fxgrdContrato.Item(fxgrdContrato.RowSel), "ITEM").ToString
                oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ.Item = fxgFinanciando_preliq.Rows(fxgFinanciando_preliq.RowSel).Item("ITEM").ToString

                oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ.sLiquidacionId = fxgFinanciando_preliq.Rows(fxgFinanciando_preliq.RowSel).Item("liquidacionID").ToString

                'oBC_FINANCIANDO_PRELIQRO.oBEFINANCIANDO_PRELIQ.Item = fxgrdContrato.CurrentRow.Cells("ITEM").Value  'dgvFinanciando_Preliq.Item("ITEM", dgvFinanciando_Preliq.CurrentRow.Cells ("ITEM").ToString
                oBC_FINANCIANDO_PRELIQRO.LeerListaToDSFINANCIANDO_DETALLE()
                dsAyuda = oBC_FINANCIANDO_PRELIQRO.oDSFINANCIANDO_PRELIQ

                'dgvPreAplicacion.DataSource = dsAyuda.Tables(0)
                C1FlexGrid1.DataSource = dsAyuda.Tables(0)





                C1FlexGrid1.Cols("contratoloteid").Visible = False
                C1FlexGrid1.Cols("liquidacionid").Visible = False
                C1FlexGrid1.Cols("item").Visible = False
                'C1FlexGrid1.Cols("empresa").Visible = False
                'C1FlexGrid1.Cols("proveedor_liq").Visible = False

                If dsAyuda.Tables(0).Rows.Count > 0 Then
                    txtCantidadPagados.Text = dsAyuda.Tables(0).Compute("sum(Pagado_CANTIDAD)", "")
                Else
                    txtCantidadPagados.Text = 0
                End If



                'C1FlexGrid1.Cols("nombre_provedor").Width = 200

                oBC_TB_DESCUENTOS_LIQRO.oBETB_DESCUENTOS_LIQ.ITEM = fxgFinanciando_preliq.Rows(fxgFinanciando_preliq.RowSel).Item("ITEM").ToString
                oBC_TB_DESCUENTOS_LIQRO.oBETB_DESCUENTOS_LIQ.EMPRESA = fxgFinanciando_preliq.Rows(fxgFinanciando_preliq.RowSel).Item("empresa").ToString
                oBC_TB_DESCUENTOS_LIQRO.LeerListaToDSTB_DESCUENTOS_LIQ()
                dsTB_DESCUENTOS_LIQ = oBC_TB_DESCUENTOS_LIQRO.oDSTB_DESCUENTOS_LIQ
                fgxDescuento.DataSource = dsTB_DESCUENTOS_LIQ.Tables(0)
                'C1FlexGrid2.AutoGenerateColumns = True

                Dim sCajas As String = "VR"
                Dim sAdelantos As String = "FT"

                Dim dCajas As Double = 0
                Dim dAdelantos As Double = 0



                ''For i = 0 To C1FlexGrid1.Rows.Count - 1
                ''    If RTrim(C1FlexGrid1.Rows(i).Item("TIPO_COMPR").ToString) = sCajas Then
                ''        dCajas = C1FlexGrid1.Rows(i).Item("MONTO_LIQ").ToString
                ''    End If

                ''    If RTrim(C1FlexGrid1.Rows(i).Item("TIPO_COMPR").ToString) = sAdelantos Then
                ''        dAdelantos = C1FlexGrid1.Rows(i).Item("MONTO_LIQ").ToString
                ''    End If
                ''Next


                ''For i = 0 To dgvPreAplicacion.Rows.Count - 1
                ''    If RTrim(dgvPreAplicacion.Item("TIPO_COMPR", i).Value.ToString()) = sCajas Then
                ''        dCajas = dgvPreAplicacion.Item("MONTO_LIQ", i).Value
                ''    End If

                ''    If RTrim(dgvPreAplicacion.Item("TIPO_COMPR", i).Value.ToString()) = sAdelantos Then
                ''        dAdelantos = dgvPreAplicacion.Item("MONTO_LIQ", i).Value
                ''    End If
                ''Next


                txtLoteVCM.Text = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "LoteVCM").ToString
                txtNombre_Empresa.Text = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "Nombre_Empresa").ToString
                txtNombre_Provedor.Text = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "Nombre_Provedor").ToString

                txtCajaChicaA.Text = FormatNumber(fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "caja").ToString, 2)
                txtAdelantoA.Text = FormatNumber(fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "adelanto").ToString, 2)
                txtDescuentoA.Text = FormatNumber(fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "descuento").ToString, 2)

                txtValorNetoA.Text = FormatNumber(fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "valorNeto").ToString, 2)
                txtValorIgvA.Text = FormatNumber(fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "valorIgv").ToString, 2)
                txtValorTotalA.Text = FormatNumber(fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "valorTotal").ToString, 2)


                cboTipoDocumento.SelectedValue = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "codigoDocumento").ToString
                txtNumeroDocumento.Text = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "numeroDocumento").ToString
                dtpFechaDocumento.Text = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "fechaDocumento").ToString


                '*******************
                'Obtiene los datos del seguimiento de liquidaciones en caso tuviese
                pstrContratoLoteId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "contratoloteid").ToString
                pstrLiquidacionId = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "liquidacionid").ToString


                sRuc_Empresa = fxgFinanciando_preliq.Item(fxgFinanciando_preliq.RowSel, "RUC_empresa").ToString

                ObtenerDatos()

                AdjuntosPorEstado()
                '*******************

            End If
        End If

        If txtEstadoId.Text = "REVI" Then
            tsbAdjuntar.Enabled = True
            tsbEliminarAdjunto.Enabled = True
        Else
            tsbAdjuntar.Enabled = False
            tsbEliminarAdjunto.Enabled = False
        End If

    End Sub





    ''SEGUIMIENTO ESTADO DE LIQUIDACION
    Private Sub ObtenerDatos(Optional ByVal bREV2 As Boolean = False)
        Try
            '************************************************************************************************
            ' ''Evalua si se ha generado la liquidacion con la nueva funcionalidad
            Dim dsLiquidacionEstadoDetalle As DataSet
            Dim oBC_LiquidacionEstadoDetalle As New clsBC_LiquidacionEstadoDetalleRO

            'Datos del estado de la liquidacion
            oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
            oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle.contratoLoteId = pstrContratoLoteId
            oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle.liquidacionId = pstrLiquidacionId
          
            oBC_LiquidacionEstadoDetalle.LeerLiquidacionEstadoDetalleDS_Sel_Adelanto()
            dsLiquidacionEstadoDetalle = oBC_LiquidacionEstadoDetalle.oDSLiquidacionEstadoDetalle

            If dsLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then

                pLiquidacionEstadoId = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("LiquidacionEstadoId").ToString
                txtliquidacionEstadoId.Text = pLiquidacionEstadoId

                pLiquidacionEstadoDetalleId = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("LiquidacionEstadoDetalleId").ToString

                oBC_LiquidacionEstadoDetalle = New clsBC_LiquidacionEstadoDetalleRO
                oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
                oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
                oBC_LiquidacionEstadoDetalle.LeerLiquidacionEstadoDetalleDS_Sel()
                dsLiquidacionEstadoDetalle = oBC_LiquidacionEstadoDetalle.oDSLiquidacionEstadoDetalle
                If dsLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                    txtRucEmpresa.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("fechaEstado").ToString
                    txtEstado.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("estadoDescripcion").ToString
                    txtEstadoId.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("estadoId").ToString
                    txtFechaEstado.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("fechaEstado").ToString

                    txtUsuario_Estado.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("Generado").ToString

                    txtObservaciones.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("observaciones").ToString
                    txtObservacionAnterior.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("observacionesAnteriores").ToString

                    sEstadoAprobar = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("EstadoAprobar").ToString
                    sEstadoRechazar = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("EstadoRechazar").ToString

                End If

                sCategoria = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("categoria").ToString

                'Datos de la liquidacion
                Dim dsLotesValorizados As DataSet
                Dim oBC_LotesValorizadosRO As New clsBC_LotesValorizadosRO
                oBC_LotesValorizadosRO.oBELotesValorizados = New clsBE_LoteValorizados
                oBC_LotesValorizadosRO.oBELotesValorizados.contratoLoteId = Me.pstrContratoLoteId
                oBC_LotesValorizadosRO.oBELotesValorizados.liquidacionId = Me.pstrLiquidacionId

                oBC_LotesValorizadosRO.LeerListaToDStbLotesValorizados_sel()
                dsLotesValorizados = oBC_LotesValorizadosRO.oDSLotesValorizados
                If dsLotesValorizados.Tables(0).Rows.Count > 0 Then
                    txtRucEmpresa.Text = dsLotesValorizados.Tables(0).Rows(0)("ComRUC").ToString
                    txtRazonSocialEmpresa.Text = dsLotesValorizados.Tables(0).Rows(0)("ComDescripcion").ToString

                    txtRucSocio.Text = dsLotesValorizados.Tables(0).Rows(0)("VenRUC").ToString
                    txtRazonSocialSocio.Text = dsLotesValorizados.Tables(0).Rows(0)("VenDescripcion").ToString
                    txtDireccionSocio.Text = dsLotesValorizados.Tables(0).Rows(0)("VenDireccion").ToString
                    txtCalidad.Text = dsLotesValorizados.Tables(0).Rows(0)("DesCalidad").ToString

                    txtContrato.Text = dsLotesValorizados.Tables(0).Rows(0)("NumContrato").ToString
                    txtLote.Text = dsLotesValorizados.Tables(0).Rows(0)("NumLote").ToString.TrimEnd
                    txtLiquidacion.Text = dsLotesValorizados.Tables(0).Rows(0)("Valorizacion").ToString
                    txtFechaLiquidacion.Text = dsLotesValorizados.Tables(0).Rows(0)("FecEmision").ToString

                    txtProducto.Text = dsLotesValorizados.Tables(0).Rows(0)("Producto").ToString
                    txtClase.Text = dsLotesValorizados.Tables(0).Rows(0)("codigoClase").ToString

                    txtLugarEntrega.Text = dsLotesValorizados.Tables(0).Rows(0)("LugEntrega").ToString
                    txtCierreLote.Text = dsLotesValorizados.Tables(0).Rows(0)("CieLote").ToString

                    txtUsuario.Text = dsLotesValorizados.Tables(0).Rows(0)("NomTrader").ToString




                End If


                oBC_LotesValorizadosRO.LeerListaToDStbLotesValorizados_valortotal_sel()
                dsLotesValorizados = oBC_LotesValorizadosRO.oDSLotesValorizados
                If dsLotesValorizados.Tables(0).Rows.Count > 0 Then
                    txtCantidad.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(0)("importe").ToString, 2)
                    txtAjuste.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(1)("importe").ToString, 2)
                    txtPrecioUnitatio.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(2)("importe").ToString, 2)
                    txtValorNeto.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(3)("importe").ToString, 2)
                    txtIgv.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(4)("importe").ToString, 2)
                    txtValorTotal.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(5)("importe").ToString, 2)
                    txtAdelanto.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(6)("importe").ToString, 2)
                    txtDetraccion.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(7)("importe").ToString, 2)
                    txtValorAntes.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(8)("importe").ToString, 2)
                End If


                oBC_LotesValorizadosRO.LeerListaToDStbLotesValorizados_netoapagar_sel()
                dsLotesValorizados = oBC_LotesValorizadosRO.oDSLotesValorizados
                If dsLotesValorizados.Tables(0).Rows.Count > 0 Then
                    txtMontoAPagar.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(0)("importe").ToString, 2)
                    txtPlanta.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(1)("importe").ToString, 2)
                    txtDescuentoA.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(2)("importe").ToString, 2)
                    txtProvisionales.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(3)("importe").ToString, 2)
                    txtAjusteIgv.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(4)("importe").ToString, 2)
                    txtTotalDescuentos.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(5)("importe").ToString, 2)
                    txtMontoNeto.Text = FormatNumber(dsLotesValorizados.Tables(0).Rows(6)("importe").ToString, 2)
                End If


                'Obtiene la ruta de los documentos adjuntos
                ObtieneRuta()


                'sRuta_Archivos = sParametro_Ruta + "\" + txtRucSocio.Text + "\" + txtContrato.Text + "\" + txtLote.Text
                sRuta_Archivos = "\" & txtRucEmpresa.Text + "\" & txtRucSocio.Text + "\" + txtContrato.Text + "\" + txtLote.Text

                sRuta_Origen = sParametro_Ruta + "\" + txtRucEmpresa.Text + "\" + txtRucSocio.Text




                'obtener adjuntos
                ObtenerLiquidacionAdjunto()

                'Obtener detalle de descuentos (Adelanto, Planta)
                ''ObtenerLiquidacionDscto()

                'Obtener documentos
                AdjuntosPorEstado()
            Else
                ''    ObtenerDatos(True)

                pLiquidacionEstadoId = 0
                txtEstadoId.Text = ""
                txtliquidacionEstadoId.Text = pLiquidacionEstadoId

                ObtenerLiquidacionAdjunto()

            End If


        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


    Private Sub AdjuntosPorEstado()
        'Cambo de documentos
        Dim dsoTablaDetRO As DataSet
        Dim dvoTablaDetRO As DataView
        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO = New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "AdjuntarDoc"
        oTablaDetRO.oBETablaDet.campo0 = txtEstadoId.Text

        dsoTablaDetRO = oTablaDetRO.LeerListaToDSTablaDetCondicion

        Dim anyRow As DataRow = dsoTablaDetRO.Tables(0).NewRow()
        anyRow.Item("descri") = "[Seleccione]"
        dsoTablaDetRO.Tables(0).Rows.Add(anyRow)

        dvoTablaDetRO = dsoTablaDetRO.Tables(0).DefaultView
        dvoTablaDetRO.Sort = "tablaDetId"

        tsbCboTipoAdjunto.ComboBox.DataSource = dvoTablaDetRO
        tsbCboTipoAdjunto.ComboBox.DisplayMember = "descri"
        tsbCboTipoAdjunto.ComboBox.ValueMember = "tablaDetId"
    End Sub

    Private Sub ObtenerLiquidacionAdjunto()
        Dim oLiquidacionAdjuntoRO As New clsBC_LiquidacionAdjuntoRO

        oLiquidacionAdjuntoRO.oBELiquidacionAdjunto = New clsBE_LiquidacionAdjunto
        oLiquidacionAdjuntoRO.oBELiquidacionAdjunto.liquidacionEstadoId = pLiquidacionEstadoId
        oLiquidacionAdjuntoRO.LeerLiquidacionAdjuntoDS_Sel()

        dtAdjuntarDocumento = oLiquidacionAdjuntoRO.oDSLiquidacionAdjunto.Tables(0)
        dvwAdjuntarDocumento = New DataView(dtAdjuntarDocumento)
        dgvLiquidacionAdjunto.DataSource = dvwAdjuntarDocumento

        'dgvLiquidacionAdjunto.DataSource = oLiquidacionAdjuntoRO.oDSLiquidacionAdjunto.Tables(0)
    End Sub

    ''Private Sub ObtenerLiquidacionDscto()
    ''    Dim oLiquidacionDsctoRO As New clsBC_LiquidacionDsctoRO
    ''    oLiquidacionDsctoRO.oBELiquidacionDscto = New clsBE_LiquidacionDscto
    ''    oLiquidacionDsctoRO.oBELiquidacionDscto.contratoLoteId = pstrContratoLoteId
    ''    oLiquidacionDsctoRO.oBELiquidacionDscto.liquidacionId = pstrLiquidacionId
    ''    dgvLiquidacionDscto.AutoGenerateColumns = False
    ''    dgvLiquidacionDscto.DataSource = oLiquidacionDsctoRO.LeerListaToDSLiquidacionDscto.Tables(0)
    ''End Sub


    Private Function ValidarAdjuntarObligatorios()
        Dim dsoTablaDetRO As DataSet

        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO = New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "AdjuntarDoc"
        oTablaDetRO.oBETablaDet.campo0 = sEstado 'txtEstadoId.Text
        dsoTablaDetRO = oTablaDetRO.LeerListaToDSTablaDetCondicion


        Dim oBC_LiquidacionRO As New clsBC_LiquidacionRO
        Dim nCantidad As Integer = oBC_LiquidacionRO.ObtenerCantidadLiquidaciones(pstrContratoLoteId)
        Dim ntickets As Integer, nguias As Integer, nguiast As Integer, nnota As Integer, nEnsaye As Integer


        Dim sMensaje As String = ""
        Dim bDocumentoAdjunto As Boolean = False


        If sCategoria = "0000000005" Then Return ""

        If nCantidad = 1 Then

            For i = 0 To dsoTablaDetRO.Tables(0).Rows.Count - 1
                If dsoTablaDetRO.Tables(0).Rows(i)("campo2").ToString = "1" Then
                    For j = 0 To dgvLiquidacionAdjunto.Rows.Count - 1
                        If dsoTablaDetRO.Tables(0).Rows(i)("tablaDetId").ToString = dgvLiquidacionAdjunto.Item("tipoAdjuntarDoc", j).Value Then
                            bDocumentoAdjunto = True
                            Exit For
                        End If
                    Next
                    If bDocumentoAdjunto = False Then
                        sMensaje += "* " & dsoTablaDetRO.Tables(0).Rows(i)("descri").ToString & Chr(10)
                    End If
                    bDocumentoAdjunto = False

                End If
            Next

            ntickets = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrContratoLoteId, pstrLiquidacionId, "0000000003")
            nguias = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrContratoLoteId, pstrLiquidacionId, "0000000004")
            nguiast = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrContratoLoteId, pstrLiquidacionId, "0000000037")
            nnota = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrContratoLoteId, pstrLiquidacionId, "0000000009")
            nEnsaye = oBC_LiquidacionRO.ObtenerCantidadAdjuntos(pstrContratoLoteId, pstrLiquidacionId, "0000000010")

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


        Else

            ''For i = 0 To dgvLiquidacionAdjunto.RowCount - 1
            ''    If dgvLiquidacionAdjunto.Item("tipoAdjuntarDoc", i).Value = "0000000002" Then
            ''        bDocumentoAdjunto = True

            ''        sMensaje += "* " & dsoTablaDetRO.Tables(0).Rows(i)("descri").ToString & Chr(10)
            ''        Exit For
            ''    End If
            ''Next
        End If

        Return sMensaje

    End Function


    Private Sub GuardarEstado(ByVal sEstado As String, ByVal sMensaje As String)
        Dim oBC_LiquidacionAdjuntoTX As New clsBC_LiquidacionAdjuntoTX

        Dim sArchivoDestino As String
        Dim sArchivoACopiar As String

        For i = 0 To dgvLiquidacionAdjunto.RowCount - 1

            'valida que sea archivo nuevo
            If String.IsNullOrEmpty(dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionAdjuntoId").Value.ToString) Then
                sArchivoACopiar = dgvLiquidacionAdjunto.Item("ruta", i).Value

                sArchivoDestino = sRuta_Archivos & "\" & dgvLiquidacionAdjunto.Item("archivo", i).Value 'sArchivoDestino


                oBC_LiquidacionAdjuntoTX.NuevaEntidad()
                With oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto
                    .liquidacionEstadoId = dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionEstadoId").Value
                    .liquidacionEstadoDetalleId = dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionEstadoDetalleId").Value
                    .tipoAdjuntarDoc = dgvLiquidacionAdjunto.Rows(i).Cells("tipoAdjuntarDoc").Value 'sTipoAdjuntarDoc 'dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("tipoAdjuntarDoc").Value
                    .ruta = sArchivoDestino 'dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("ruta").Value
                    .archivo = dgvLiquidacionAdjunto.Rows(i).Cells("archivo").Value
                    .uc = pBEUsuario.tablaDetId

                    oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Add(oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto)
                End With

                ' ''crea los archivos nuevos
                ''If System.IO.File.Exists(sArchivoDestino) Then
                ''    System.IO.File.Delete(sArchivoDestino)
                ''End If
                ''System.IO.File.Copy(sArchivoACopiar, sArchivoDestino)
            End If

        Next

        'Elimina los archivos fisiscos
        For Each oLiquidacionAdjunto As clsBE_LiquidacionAdjunto In oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar
            sArchivoDestino = sRuta_Archivos & "\" & oLiquidacionAdjunto.archivo
            System.IO.File.Delete(sArchivoDestino)
        Next

        oBC_LiquidacionAdjuntoTX.InsertaLiquidacionAdjunto()
        oBC_LiquidacionAdjuntoTX.EliminaLiquidacionAdjunto()
        oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Clear()
        oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar.Clear()


        Dim oLiquidacionEstadoDetalleTX As New clsBC_LiquidacionEstadoDetalleTX
        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.contratoLoteId = pstrContratoLoteId
        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionId = pstrLiquidacionId
        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.usuarioId = pBEUsuario.tablaDetId
        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.estadoId = sEstado
        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.observaciones = txtObservaciones.Text

        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
        oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId = pLiquidacionEstadoDetalleId

        oLiquidacionEstadoDetalleTX.InsertaLiquidacionEstado()

        ObtenerLiquidacionAdjunto()

        'MsgBox("La liquidación ha sido " & sMensaje & " satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Me.Dispose()
    End Sub

  
    ''Private Sub tsbAdjuntar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    Dim sArchivoOrigen As String

    ''    'valida tipo de documento
    ''    If tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0 Then
    ''        MsgBox("Debe seleccionar el tipo de documento ha adjuntar", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
    ''    Else

    ''        ' ''If ofdAdjuntar.ShowDialog = DialogResult.OK Then
    ''        ' ''    sArchivoOrigen = ofdAdjuntar.FileName
    ''        ' ''    AgregarAdjunto(sArchivoOrigen)
    ''        ' ''    tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0
    ''        ' ''End If




    ''    End If
    ''End Sub

    Private Sub tsbEliminarAdjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarAdjunto.Click
        Dim oBC_LiquidacionAdjuntoTX As New clsBC_LiquidacionAdjuntoTX

        'agrega en la lista para ser eliminado dsp        
        If Not String.IsNullOrEmpty(dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("liquidacionAdjuntoId").Value.ToString) Then

            'falta validar que solo se puede eliminar en el paso creado
            If dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("estadoId").Value <> sEstado Or sEstado = "FACT" Then
                MsgBox("No tiene permiso para eliminar el adjunto seleccionado, " & Chr(10) & "solo puede ser eliminado en el estado " & dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("estadoDescripcion").Value, MsgBoxStyle.OkOnly)
                Exit Sub
            End If


            If MsgBox("Esta seguro de eliminar el documento adjunto", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                oBC_LiquidacionAdjuntoTX.NuevaEntidad()
                With oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto
                    .liquidacionEstadoId = dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("liquidacionEstadoId").Value
                    .liquidacionEstadoDetalleId = dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("liquidacionEstadoDetalleId").Value
                    .liquidacionAdjuntoId = dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("liquidacionAdjuntoId").Value

                    .archivo = dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("archivo").Value

                    oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar.Add(oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto)
                End With


                ''Elimina de de la vista
                Dim drowTipoAdjuntar As DataRow
                drowTipoAdjuntar = BuscarenDatatable(dvwAdjuntarDocumento.Table, "orden", dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("orden").Value)
                drowTipoAdjuntar.Delete()




                'oBC_LiquidacionAdjuntoTX.InsertaLiquidacionAdjunto()
                oBC_LiquidacionAdjuntoTX.EliminaLiquidacionAdjunto()
                oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Clear()
                oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar.Clear()
            End If

        Else

            If dgvLiquidacionAdjunto.RowCount > 0 Then
                ''Elimina de de la vista
                Dim drowTipoAdjuntar As DataRow
                drowTipoAdjuntar = BuscarenDatatable(dvwAdjuntarDocumento.Table, "orden", dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("orden").Value)
                drowTipoAdjuntar.Delete()
            End If

        End If
    End Sub

    Private Sub AgregarAdjunto(ByVal sArchivoOrigen As String)
        Try

            Dim sTipoAdjunto As String = ""
            Dim dsTablaDetRO As DataSet
            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO = New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "AdjuntarDoc"
            'oTablaDetRO.oBETablaDet.campo0 = sEstado 'txtEstadoId.Text
            dsTablaDetRO = oTablaDetRO.LeerListaToDSTablaDet
            For i = 0 To dsTablaDetRO.Tables(0).Rows.Count - 1
                If dsTablaDetRO.Tables(0).Rows(i)("tablaDetId").ToString = tsbCboTipoAdjunto.ComboBox.SelectedValue Then
                    sTipoAdjunto = dsTablaDetRO.Tables(0).Rows(i)("campo1").ToString
                    Exit For
                End If

            Next


            If tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000008" Then
                sArchivoOrigen = ""
            End If



            drowAdjuntarDocumento = dtAdjuntarDocumento.NewRow
            drowAdjuntarDocumento("liquidacionEstadoId") = pLiquidacionEstadoId
            drowAdjuntarDocumento("liquidacionEstadoDetalleId") = pLiquidacionEstadoDetalleId
            drowAdjuntarDocumento("tipoAdjuntarDoc") = tsbCboTipoAdjunto.ComboBox.SelectedValue
            drowAdjuntarDocumento("ruta") = sArchivoOrigen
            'drowAdjuntarDocumento("archivo") = cboTipoAdjunto.SelectedValue & "-" & CopiarArchivo(sArchivoOrigen)
            drowAdjuntarDocumento("archivo") = CopiarArchivo(sArchivoOrigen) 'sTipoAdjunto & "-" & CopiarArchivo(sArchivoOrigen)

            drowAdjuntarDocumento("fc") = FormatDateTime(Now, DateFormat.ShortDate) ' & "" & FormatDateTime(Now, DateFormat.ShortTime)
            drowAdjuntarDocumento("uc_nombre") = pBEUsuario.descri

            dtAdjuntarDocumento.Rows.Add(drowAdjuntarDocumento)
            dvwAdjuntarDocumento = New DataView(dtAdjuntarDocumento)

            dgvLiquidacionAdjunto.AutoGenerateColumns = False
            dgvLiquidacionAdjunto.DataSource = dvwAdjuntarDocumento

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Function CopiarArchivo(ByVal sArchivoOrigen As String)

        Dim nLongitud As Integer
        Dim nCaracter As Integer

        nCaracter = sArchivoOrigen.LastIndexOf("\") + 1
        nLongitud = sArchivoOrigen.Length

        'Return sRuta_Archivos & "\" & sTipoAdjuntarDoc & "-" & sArchivoOrigen.Substring(nCaracter, nLongitud - nCaracter)
        Return sArchivoOrigen.Substring(nCaracter, nLongitud - nCaracter)

    End Function

    Private Sub dgvLiquidacionAdjunto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLiquidacionAdjunto.DoubleClick
        'If txtEstadoId.Text = "FACT" Then
        '    MsgBox("No tiene permiso de visualizar", MsgBoxStyle.OkOnly, "Estado Liquidación")
        'Else
        If Not String.IsNullOrEmpty(dgvLiquidacionAdjunto.CurrentRow.Cells("archivo").Value.ToString) Then
            Dim sArchivo As String = dgvLiquidacionAdjunto.CurrentRow.Cells("archivo").Value
            Dim sruta As String = dgvLiquidacionAdjunto.CurrentRow.Cells("ruta").Value

            If sruta = "" Then
                sruta = sParametro_Ruta + sRuta_Archivos & "\" & sArchivo
            End If

            Dim processInfo As New ProcessStartInfo("explorer.exe", sruta)
            Process.Start(processInfo)
        End If

        'End If
    End Sub

    ''Private Sub dgvLiquidacionAdjunto_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLiquidacionAdjunto.DoubleClick

    ''        If Not String.IsNullOrEmpty(dgvLiquidacionAdjunto.CurrentRow.Cells("archivo").Value.ToString) Then
    ''            Dim sArchivo As String = dgvLiquidacionAdjunto.CurrentRow.Cells("archivo").Value

    ''            Dim processInfo As New ProcessStartInfo("explorer.exe", sRuta_Archivos & "\" & sArchivo)
    ''            Process.Start(processInfo)
    ''        End If

    ''End Sub

    Private Sub tsbAdjuntar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAdjuntar.Click
        Try

      
        Dim sArchivoOrigen As String

        LstDIG_INDICE.Clear()

        If tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar el tipo de documento ha adjuntar", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Else
                '0000000002: FACTURA
                '0000000005: CARTA INSTRUCCION
                '0000000011: factura grupo
                '0000000018: liquidacion externa

                If tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000002" Or _
                    tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000005" Or _
                    tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000011" Or _
                    tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000018" Then


                    Dim oDocumentos As New frmDocumentos
                    Dim oTB_DIG_INDICE As clsBE_TB_DIG_INDICE
                    'Dim sCodigoDocumento As String

                    oDocumentos.sCodigoDocumento = tsbCboTipoAdjunto.ComboBox.SelectedValue
                    oDocumentos.txtTipo.Text = tsbCboTipoAdjunto.ComboBox.SelectedText
                    oDocumentos.pstrEmpresa = txtRucEmpresa.Text

                    oDocumentos.ShowDialog()


                    If oDocumentos.bRetorna = True Then

                        sArchivoOrigen = oDocumentos.txtAdjunto.Text
                        AgregarAdjunto(sArchivoOrigen)

                        oTB_DIG_INDICE = oDocumentos.oTB_DIG_INDICE

                        oTB_DIG_INDICE.EMPRESA = txtRucEmpresa.Text
                        'oTB_DIG_INDICE.IDTIPODOC_DIG = tsbCboTipoAdjunto.ComboBox.SelectedValue
                        oTB_DIG_INDICE.PROVEEDOR = txtRucSocio.Text
                        'oTB_DIG_INDICE.CONTRATO = txtContrato.Text
                        'oTB_DIG_INDICE.LOTE = txtLote.Text
                        oTB_DIG_INDICE.CONTRATO_LIQ = txtContrato.Text
                        oTB_DIG_INDICE.LOTE_LIQ = txtLote.Text
                        oTB_DIG_INDICE.LIQUIDACION = txtLiquidacion.Text

                        oTB_DIG_INDICE.RUTA = txtRucEmpresa.Text + "\" + txtRucSocio.Text + "\" + txtContrato.Text + "\" + txtLote.Text

                        oTB_DIG_INDICE.ContratoLoteId = pstrContratoLoteId
                        oTB_DIG_INDICE.LiquidacionId = pstrLiquidacionId
                        oTB_DIG_INDICE.liquidacionAdjuntoId = tsbCboTipoAdjunto.ComboBox.SelectedValue

                        oTB_DIG_INDICE.liquidacionEstadoId = txtliquidacionEstadoId.Text
                        oTB_DIG_INDICE.liquidacionEstadoDetalleId = pLiquidacionEstadoDetalleId
                        oTB_DIG_INDICE.uc = pBEUsuario.tablaDetId

                        LstDIG_INDICE.Add(oTB_DIG_INDICE)
                    End If

                    oDocumentos.bRetorna = False
                Else

                    Dim oListaDocumentos As New frmListaDocumentos
                    oListaDocumentos.pstrIDTIPODOC_DIG = tsbCboTipoAdjunto.ComboBox.SelectedValue
                    oListaDocumentos.sRuta_Origen = sRuta_Origen
                    oListaDocumentos.sRuta_Parametro = sParametro_Ruta

                    oListaDocumentos.sEMPRESA = txtRucEmpresa.Text
                    oListaDocumentos.sPROVEEDOR = txtRucSocio.Text
                    oListaDocumentos.pContratoLoteId = pstrContratoLoteId

                    If tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000008" Then
                        oListaDocumentos.pLiquidacionId = pstrLiquidacionId
                        oListaDocumentos.sRuta_Origen = sRuta_Origen + "\" + txtContrato.Text + "\" + txtLote.Text
                    End If

                    oListaDocumentos.ShowDialog()


                    If oListaDocumentos.bRetorna = True Then
                        For i = 0 To oListaDocumentos.LstDIG_INDICE.Count - 1
                            'insert todos los documentos

                            oListaDocumentos.LstDIG_INDICE(i).CONTRATO_LIQ = txtContrato.Text
                            oListaDocumentos.LstDIG_INDICE(i).LOTE_LIQ = txtLote.Text
                            oListaDocumentos.LstDIG_INDICE(i).LIQUIDACION = txtLiquidacion.Text

                            oListaDocumentos.LstDIG_INDICE(i).ContratoLoteId = pstrContratoLoteId
                            oListaDocumentos.LstDIG_INDICE(i).LiquidacionId = pstrLiquidacionId

                            oListaDocumentos.LstDIG_INDICE(i).liquidacionEstadoId = txtliquidacionEstadoId.Text
                            oListaDocumentos.LstDIG_INDICE(i).liquidacionEstadoDetalleId = pLiquidacionEstadoDetalleId
                            oListaDocumentos.LstDIG_INDICE(i).uc = pBEUsuario.tablaDetId

                            oListaDocumentos.LstDIG_INDICE(i).liquidacionAdjuntoId = tsbCboTipoAdjunto.ComboBox.SelectedValue

                            oListaDocumentos.LstDIG_INDICE(i).RUTA = txtRucEmpresa.Text + "\" + txtRucSocio.Text + "\" + txtContrato.Text + "\" + txtLote.Text

                            oListaDocumentos.LstDIG_INDICE(i).ESTADO = 2

                            LstDIG_INDICE.Add(oListaDocumentos.LstDIG_INDICE(i))

                            'solo muestra la ruta
                            'AgregarAdjunto(sRuta_Origen + "\" + oListaDocumentos.LstDIG_INDICE.Item(i).ARCHIVO.ToString)
                            If oListaDocumentos.LstDIG_INDICE.Item(i).RUTA_ORIGEN.ToString = "" Then
                                AgregarAdjunto(sRuta_Origen + "\" + oListaDocumentos.LstDIG_INDICE.Item(i).ARCHIVO.ToString)
                            Else
                                AgregarAdjunto(oListaDocumentos.LstDIG_INDICE.Item(i).RUTA_ORIGEN.ToString)
                            End If

                        Next
                    End If
                    oListaDocumentos.bRetorna = False

                End If
            tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0


            Dim oBC_TB_DIG_INDICETX As New clsBC_TB_DIG_INDICETX

            oBC_TB_DIG_INDICETX.LstTB_DIG_INDICE_INSERT = LstDIG_INDICE
            oBC_TB_DIG_INDICETX.TB_DIG_INDICE_INSERT()

            ObtenerLiquidacionAdjunto()
        End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

   

End Class