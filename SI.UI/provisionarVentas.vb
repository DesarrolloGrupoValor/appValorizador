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

Public Class provisionarVentas

#Region "Variables Privadas"
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private oDvwAyuda As New DataView
    'Private FontCourier As New Font("Courier New", 8.25)
    Private stylecodpartida As New DataGridViewCellStyle()



    Private sParametro_Ruta As String
    Private sRuta_Archivos As String

    Public sEstadoId As String '= "REVI"

    Public sEstadoAprobadoDescripcion As String = "Revisado"
    Public sEstadoRechazadoDescripcion As String = "Rechazado"

    Public sEstadoAprobar As String
    Public sEstadoRechazar As String

    Public pLiquidacionEstadoDetalleId As Integer
    Public pLiquidacionEstadoId As Integer

    Public pstrItem As String
    Public pstrContratoLoteId As String
    Public pstrLiquidacionId As String

    Private dtAdjuntarDocumento As DataTable
    Private dvwAdjuntarDocumento As DataView
    Private drowAdjuntarDocumento As DataRow


    Public pstrCodigoEmpresa As String
    Public pstrPeriodo As String

    Private sRuc_Socio As String
    Private sRuc_Empresa As String
    Private sRuta_Origen As String
    Private sEmpresaFE As String = "0"
    Private sSERIE As String
    Private sOperacion As String = "026"
    Private sTipo As String
    Private sTipoDoc As String


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

        ObtenerRegistros()
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


        'AdjuntosPorEstado()
        ObtieneRuta()
        Label3.Text = DateTime.Now.ToString("dd/MM/yyyy")
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

        'FACTURA
        Obtener_ParametrosCombo(cboTipoDocumento, clsUT_Dominio.domTABLA_DE_DOCUMENTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

        ''ESTADO LIQUIDACION
        Obtener_ParametrosGridViewCampos(tipoAdjuntarDoc, "AdjuntarDoc", SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, "2", "Descripcion_Retorna", "Id_Retorna")

    End Sub



    Private Sub ObtieneRuta()
        'Parametros de ruta de guardar archivos
        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO = New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"

        Select Case txtLoteVCM.Text.Substring(0, 1)
            Case "P"
                oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
            Case "V"
                oTablaDetRO.oBETablaDet.tablaDetId = "0000000003"
            Case "S"
                oTablaDetRO.oBETablaDet.tablaDetId = "0000000002"
        End Select

        oTablaDetRO.LeerTablaDet()
        sParametro_Ruta = oTablaDetRO.oBETablaDet.descri.ToString() & "\"
    End Sub

    Private Sub ObtieneEmpresaFE()
        'Obtiene parametro si Empresas tiene flujo de Facturación Electrónica
        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO = New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "empresa"
        oTablaDetRO.oBETablaDet.tablaDetId = pstrCodigoEmpresa

        oTablaDetRO.LeerTablaDet()
        sEmpresaFE = oTablaDetRO.oBETablaDet.campo17.ToString()

    End Sub

    Private Sub ObtieneSerie()
        'Obtiene parametro si Serie por empresa de Facturación Electrónica
        Dim oSerieDocRO As New clsBC_TB_SERIE_DOCRO
        oSerieDocRO = New clsBC_TB_SERIE_DOCRO
        oSerieDocRO.oBETB_SERIE_DOC.EMPRESA = pstrCodigoEmpresa
        oSerieDocRO.oBETB_SERIE_DOC.OPERACION = sOperacion
        oSerieDocRO.oBETB_SERIE_DOC.TIPO = sTipo
        oSerieDocRO.oBETB_SERIE_DOC.TIPODOC = sTipoDoc

        oSerieDocRO.LeerTB_SERIE_DOC()
        sSerie = oSerieDocRO.oBETB_SERIE_DOC.SERIE.ToString()

    End Sub

    Private Sub tsbAplicar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAprobar.Click
        Try

            Dim DSactivaFe As New DataSet
            Dim SactivaFe As String = "0"
            Dim oTablaGenRO As New clsBC_TB_TABLAS_GENRO
            oTablaGenRO = New clsBC_TB_TABLAS_GENRO
            oTablaGenRO.oBETB_TABLAS_GEN.clave = "69"
            oTablaGenRO.oBETB_TABLAS_GEN.codigo = "01"
            oTablaGenRO.LeerListaTB_TABLAS_GEN()
            DSactivaFe = oTablaGenRO.oDSTB_TABLAS_GEN

            ' Si es Factura Electrónica
            ObtieneEmpresaFE()


            If DSactivaFe.Tables(0).Rows.Count > 0 Then
                'SactivaFe = DSactivaFe.Tables(0).Rows(0)("descripcion").ToString()
                SactivaFe = sEmpresaFE
            End If



            Dim sMensajeValidacion As String = ValidarAdjuntarObligatorios()
            If sMensajeValidacion <> "" Then
                MsgBox("No puede ser " & tsbAprobar.Text & ", porque" & Chr(10) & "debe adjuntar los siguientes documentos: " & Chr(10) & sMensajeValidacion, MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                Exit Sub
            End If

            Select Case sEstadoId

                'REVISA COMERCIAL(firma)
                Case "SAD1"
                    generarLiquidacionAuto(sRuc_Socio + "_LIQU_")

                    'IMPRIMIR EL DOCUMENTO (imprime y adjunta)
                Case "SREV"
                    If Not vaLidaCampos() Then Exit Sub
                    GuardaNumeroDocumento() 'ricardo enviado correlativo
                    If SactivaFe = "1" Then
                        If Not ProvisionVenta("U", pstrItem, "A") Then Exit Sub
                    End If

                Case "SVAL"
                    If Not vaLidaCampos() Then Exit Sub
                    GuardaNumeroDocumento() 'comercial imprime
                    If Not SactivaFe = "1" Then
                        If Not ProvisionVenta("U", pstrItem, "A") Then Exit Sub
                    End If

                Case "SIMP"

                Case Else


            End Select


            ' ***** Inicio adjuntar doc ****************************************************
            'ADJUNTAR TODOS LOS DOCUMENTOS
            Dim oBC_LiquidacionAdjuntoTX As New clsBC_LiquidacionAdjuntoTX
            Dim sArchivoDestino As String
            Dim sArchivoACopiar As String

            For i = 0 To dgvLiquidacionAdjunto.RowCount - 1
                'valida que sea archivo nuevo
                If dgvLiquidacionAdjunto.Item("ruta", i).Value <> "" Then
                    sArchivoACopiar = dgvLiquidacionAdjunto.Item("ruta", i).Value
                    sArchivoDestino = sParametro_Ruta & sRuta_Archivos & "\" & dgvLiquidacionAdjunto.Item("archivo", i).Value 'sArchivoDestino

                    oBC_LiquidacionAdjuntoTX.NuevaEntidad()
                    With oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto
                        .liquidacionEstadoId = dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionEstadoId").Value
                        .liquidacionEstadoDetalleId = dgvLiquidacionAdjunto.Rows(i).Cells("liquidacionEstadoDetalleId").Value
                        .tipoAdjuntarDoc = dgvLiquidacionAdjunto.Rows(i).Cells("tipoAdjuntarDoc").Value 'sTipoAdjuntarDoc 'dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("tipoAdjuntarDoc").Value
                        .ruta = "" 'sArchivoDestino 'dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("ruta").Value
                        .archivo = dgvLiquidacionAdjunto.Rows(i).Cells("archivo").Value
                        .uc = pBEUsuario.tablaDetId
                        oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Add(oBC_LiquidacionAdjuntoTX.oBELiquidacionAdjunto)
                    End With

                    If System.IO.File.Exists(sArchivoDestino) Then
                        System.IO.File.Delete(sArchivoDestino)
                    End If
                    System.IO.File.Copy(sArchivoACopiar, sArchivoDestino)
                End If
            Next
            oBC_LiquidacionAdjuntoTX.InsertaLiquidacionAdjunto()

            'Elimina los archivos fisiscos
            For Each oLiquidacionAdjunto As clsBE_LiquidacionAdjunto In oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar
                sArchivoDestino = sRuta_Archivos & "\" & oLiquidacionAdjunto.archivo
                System.IO.File.Delete(sArchivoDestino)
            Next

            oBC_LiquidacionAdjuntoTX.EliminaLiquidacionAdjunto()
            oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Insertar.Clear()
            oBC_LiquidacionAdjuntoTX.LstLiquidacionAdjunto_Eliminar.Clear()
            ' ***** Fin adjuntar doc ****************************************************


            Dim oLiquidacionEstadoDetalleTX As New clsBC_LiquidacionEstadoDetalleTX
            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.contratoLoteId = pstrContratoLoteId
            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionId = pstrLiquidacionId
            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.usuarioId = pBEUsuario.tablaDetId
            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.estadoId = sEstadoAprobar
            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.observaciones = txtObservaciones.Text

            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
            oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId = pLiquidacionEstadoDetalleId
            oLiquidacionEstadoDetalleTX.InsertaLiquidacionEstadoVenta()


            MsgBox("La liquidación ha sido " & tsbAprobar.Text & " satisfactoriamente", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")

            tsbFiltrar_Click(sender, e)

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Function vaLidaCampos() As Boolean
        Try
            Dim sMensaje As String = ""

            If txtNumeroDocumento.Text = "" Or RTrim(txtNumeroDocumento.Text) = "0" Then
                sMensaje = sMensaje & "* Debe ingresar Numero de Documento" & Chr(10)
            End If

            If cboTipoDocumento.SelectedIndex = 0 Then
                sMensaje = sMensaje & "* Debe ingresar Tipo de Documento" & Chr(10)
            End If

            If dtpFechaDocumento.Text = "1/01/1900" Then
                sMensaje = sMensaje & "* Debe ingresar Fecha del Documento" & Chr(10)
            End If

            'Label3.Text = DateTime.Now.ToString("dd/MM/yyyy")
            Dim DiasMaximo As Integer
            Dim txtDiasAntes As String
            Dim txtDiasDesp As String
            Dim difdias As Double
            Dim difdiasDesp As Integer
            Dim resta As TimeSpan = dtpFechaDocumento.Value.Subtract(DateTime.Now.ToString("dd/MM/yyyy"))
            txtDiasAntes = Math.Abs((CStr(resta.Days) - 1) * -1)
            txtDiasDesp = Math.Abs((CStr(resta.Days)) * -1)
            difdias = Convert.ToInt32((CStr(resta.Days) - 1) * -1)
            difdiasDesp = Convert.ToInt32((CStr(resta.Days)) * -1)

            Dim DiasPermitidos As New clsBC_FINANCIANDO_PRELIQRO
            DiasMaximo = DiasPermitidos.LeerDiasPermitidos()

            If difdias > DiasMaximo And difdias <> 0 Then
                MsgBox("Existe una diferencia de: " + txtDiasAntes + " dias que sobrepasa el limite permitido. " & vbNewLine & "¡Por favor, Revisar la fecha del doc.!", MsgBoxStyle.Exclamation, "Revisar Fecha")
                Return False
            End If
            If difdiasDesp < 1 And difdiasDesp <> 0 Then
                MsgBox("La fecha de registro del documento esta adelantada por " + txtDiasDesp + " dias que sobrepasa el limite permitido. " & vbNewLine & "¡Por favor, Revisar la fecha del doc.!", MsgBoxStyle.Exclamation, "Revisar Fecha")
                Return False
            End If

            If sMensaje = "" Then
                Return True
            Else
                MsgBox(sMensaje, MsgBoxStyle.Exclamation, "Valorizador Comercial de Minerales")
                Return False
            End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
        
    End Function

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    Private Sub tsbFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbFiltrar.Click
        'CargarDatos()
        PermisosDeBotones(False)

        ObtenerRegistros()

        Limpiar()
    End Sub


    Private Sub Limpiar()
        txtLoteVCM.Text = ""
        txtNombre_Empresa.Text = ""
        txtNombre_Provedor.Text = ""

        txtValorNetoA.Text = ""

        txtNumeroDocumento.Text = ""
        cboTipoDocumento.SelectedIndex = 0

        dtpFechaDocumento.Value = "01/01/1900"

        txtObservaciones.Text = ""

    End Sub

    Private Sub tsbLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiar.Click

        tsbFiltrar_Click(sender, e)

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

        fxgLiquidacionEstadoDetalle.DataSource = dsAyuda.Tables(0)

    End Sub



    Private Sub tsbRechazar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRechazar.Click

        'Adelanto
        If tcFinanciamiento.SelectedIndex = 0 Then
            If MsgBox("Esta seguro de desea rechazar", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then


                If txtObservaciones.Text = "" Then
                    MsgBox("Debe ingresar la observación", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                    Exit Sub
                Else

                    ''Select Case sEstadoId
                    ''    Case "SREV"
                    ''        If Not ProvisionVenta("U", pstrItem, "P") Then Exit Sub
                    ''End Select



                    Dim oLiquidacionEstadoDetalleTX As New clsBC_LiquidacionEstadoDetalleTX
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.contratoLoteId = pstrContratoLoteId
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionId = pstrLiquidacionId
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.usuarioId = pBEUsuario.tablaDetId
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.estadoId = sEstadoRechazar
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.observaciones = txtObservaciones.Text

                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
                    oLiquidacionEstadoDetalleTX.oBELiquidacionEstadoDetalle.liquidacionEstadoDetalleOrigenId = pLiquidacionEstadoDetalleId
                    'KMN ACTUALIZAR 21/08/2013
                    oLiquidacionEstadoDetalleTX.InsertaLiquidacionEstadoVenta()


                    MsgBox("Se Rechazó satisfactoriamente", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")

                    tsbFiltrar_Click(sender, e)

                End If
            End If


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


    Private Sub fxgLiquidacionEstadoDetalle_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgLiquidacionEstadoDetalle.SelChange ', C1FlexGrid1.SelChange ', fgxDescuento.SelChange

        txtObservaciones.Text = ""
        'txtObservacionAnterior.Text = ""

        If fxgLiquidacionEstadoDetalle.Cols.Count > 5 Then
            If fxgLiquidacionEstadoDetalle.RowSel > 0 Then

                pLiquidacionEstadoId = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "LiquidacionEstadoId").ToString
                pLiquidacionEstadoDetalleId = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "LiquidacionEstadoDetalleId").ToString
                sEstadoId = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "estadoId").ToString


                txtliquidacionEstadoId.Text = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "LiquidacionEstadoId").ToString

                sRuta_Archivos = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "empresa_ruc").ToString + "\" + _
                fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "socio_ruc").ToString + "\" + _
                fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "contrato").ToString + "\" + _
                fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "contrato").ToString + "-" + _
                                fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "lote").ToString.Replace("/", "-")

                txtLoteVCM.Text = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "LoteVCM").ToString
                'txtLoteVCM.Text = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "contrato").ToString + "-" + _
                'fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "lote").ToString()

                txtEstadoDescri.Text = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "estadoDescripcionOrigen").ToString

                txtNombre_Empresa.Text = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "empresa_nombre").ToString
                txtNombre_Provedor.Text = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "socio_nombre").ToString

                txtValorNetoA.Text = FormatNumber(fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "valorNeto").ToString, 2)

                cboTipoDocumento.SelectedValue = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "codigoDocumento").ToString
                txtNumeroDocumento.Text = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "numeroDocumento").ToString
                dtpFechaDocumento.Text = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "fechaDocumento").ToString

                '*******************
                'Obtiene los datos del seguimiento de liquidaciones en caso tuviese
                pstrContratoLoteId = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "contratoloteid").ToString
                pstrLiquidacionId = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "liquidacionid").ToString
                pstrItem = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "item").ToString

                sRuc_Socio = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "socio_ruc").ToString
                sRuc_Empresa = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "empresa_ruc").ToString
                pstrCodigoEmpresa = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "codigoEmpresa").ToString
                pstrPeriodo = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "periodo").ToString

                Dim dsLiquidacionEstadoDetalle As DataSet
                Dim oBC_LiquidacionEstadoDetalle As New clsBC_LiquidacionEstadoDetalleRO
                oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
                oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId

                oBC_LiquidacionEstadoDetalle.LeerLiquidacionEstadoDetalleDS_Sel()
                dsLiquidacionEstadoDetalle = oBC_LiquidacionEstadoDetalle.oDSLiquidacionEstadoDetalle

                If dsLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                    txtObservaciones.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("observaciones").ToString
                    'txtObservacionAnterior.Text = dsLiquidacionEstadoDetalle.Tables(0).Rows(0)("observacionesAnteriores").ToString
                End If

                AdjuntosPorEstado()
                
                ObtenerLiquidacionAdjunto()

                ObtenerLiquidacionEstadoDetalle_Sel_Seguimiento()

                ObtenerLiquidaciones()

                ObtenerDetalleAdelanto(pstrContratoLoteId, pstrLiquidacionId)

                PermisosDeBotones(False)
                ValidarPermisos()

            End If
        End If

    End Sub

    Private Sub ValidarPermisos()

        Dim oBC_TablaDetRO As New clsBC_TablaDetRO
        oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
        oBC_TablaDetRO.oBETablaDet.tablaId = "EstadoVenta"
        oBC_TablaDetRO.LeerListaToDSTablaDet()

        Dim dsTablaDetRO As DataSet = oBC_TablaDetRO.oDSTablaDet
        For i = 0 To dsTablaDetRO.Tables(0).Rows.Count - 1
            If dsTablaDetRO.Tables(0).Rows(i)("campo1").ToString = sEstadoId Then
                tsbAprobar.Text = dsTablaDetRO.Tables(0).Rows(i)("campo5").ToString

                'sEstadoId = dsTablaDetRO.Tables(0).Rows(i)("campo2").ToString
                If sEmpresaFE = "1" Then
                    sEstadoAprobar = dsTablaDetRO.Tables(0).Rows(i)("campo3").ToString
                Else
                    sEstadoAprobar = dsTablaDetRO.Tables(0).Rows(i)("campo8").ToString
                End If
                sEstadoRechazar = dsTablaDetRO.Tables(0).Rows(i)("campo4").ToString

                Exit For
            End If
        Next

        Dim dsRol_Usuario As DataSet
        Dim oBC_Rol_Usuario As New clsBC_Rol_UsuarioRO
        oBC_Rol_Usuario.oBERol_Usuario = New clsBE_Rol_Usuario
        oBC_Rol_Usuario.oBERol_Usuario.usuarioId = pBEUsuario.tablaDetId
        oBC_Rol_Usuario.LeerRol_UsuarioDS_Sel()
        dsRol_Usuario = oBC_Rol_Usuario.oDSRol_Usuario
        For i = 0 To dsRol_Usuario.Tables(0).Rows.Count - 1
            If dsRol_Usuario.Tables(0).Rows(i)("rolCodigo").ToString = "ADMI" Then
                PermisosDeBotones(True)
            End If

            'sRol_Usuario = dsRol_Usuario.Tables(0).Rows(i)("rolCodigo").ToString

            If dsRol_Usuario.Tables(0).Rows(i)("rolCodigo").ToString = sEstadoId Then

                PermisosDeBotones(True)
            End If
        Next

    End Sub

    Private Sub PermisosDeBotones(ByVal bActivar As Boolean)
        tsbAprobar.Enabled = bActivar
        tsbRechazar.Enabled = bActivar

        tsbAdjuntar.Enabled = bActivar
        tsbEliminarAdjunto.Enabled = bActivar

        tsbImprimir.Enabled = bActivar
    End Sub

    Private Sub AdjuntosPorEstado()
        'Cambo de documentos
        Dim dsoTablaDetRO As DataSet
        Dim dvoTablaDetRO As DataView
        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO = New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "AdjuntarDoc"
        oTablaDetRO.oBETablaDet.campo0 = sEstadoId 'txtEstadoId.Text

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

    End Sub

    Private Sub ObtenerLiquidaciones()
        Dim oLiquidacionRO As New clsBC_LiquidacionRO
        Dim oLiquidacion As New clsBE_Liquidacion
        oLiquidacion.contratoLoteId = fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "contratoloteid").ToString
        oLiquidacionRO.oBELiquidacion = oLiquidacion

        fgxLiquidaciones.AutoGenerateColumns = False
        'oLiquidacionRO.LeerListaLiquidacion()
        fgxLiquidaciones.DataSource = oLiquidacionRO.LeerListaToDSLiquidacion_Documento.Tables(0) '.Select("codigoCalculo in ('PRV','FIN') AND STATUS <> 'E'", "fechaRegistro")


    End Sub


    Private Function ValidarAdjuntarObligatorios()
        Dim dsoTablaDetRO As DataSet

        Dim oTablaDetRO As New clsBC_TablaDetRO
        oTablaDetRO = New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "AdjuntarDoc"
        oTablaDetRO.oBETablaDet.campo0 = sEstadoId 'txtEstadoId.Text
        dsoTablaDetRO = oTablaDetRO.LeerListaToDSTablaDetCondicion


        Dim oBC_LiquidacionRO As New clsBC_LiquidacionRO
        Dim nCantidad As Integer = oBC_LiquidacionRO.ObtenerCantidadLiquidaciones(pstrContratoLoteId)


        Dim sMensaje As String = ""
        Dim bDocumentoAdjunto As Boolean = False

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
        Else

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


    Private Sub tsbEliminarAdjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminarAdjunto.Click
        Dim oBC_LiquidacionAdjuntoTX As New clsBC_LiquidacionAdjuntoTX

        'agrega en la lista para ser eliminado dsp        
        If Not String.IsNullOrEmpty(dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("liquidacionAdjuntoId").Value.ToString) Then

            'falta validar que solo se puede eliminar en el paso creado
            If dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("estadoId").Value <> sEstadoId Or sEstadoId = "FACT" Then
                MsgBox("No tiene permiso para eliminar el adjunto seleccionado, " & Chr(10) & "solo puede ser eliminado en el estado " & dgvLiquidacionAdjunto.Rows(dgvLiquidacionAdjunto.CurrentCell.RowIndex).Cells("estadoDescripcion").Value, MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                Exit Sub
            End If


            If MsgBox("Esta seguro de eliminar el documento adjunto", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then

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

            Dim nExtension As Integer = sArchivoOrigen.LastIndexOf(".")
            Dim sExtension As String = sArchivoOrigen.Substring(nExtension, sArchivoOrigen.Length - nExtension)


            drowAdjuntarDocumento = dtAdjuntarDocumento.NewRow
            drowAdjuntarDocumento("liquidacionEstadoId") = pLiquidacionEstadoId
            drowAdjuntarDocumento("liquidacionEstadoDetalleId") = pLiquidacionEstadoDetalleId
            drowAdjuntarDocumento("tipoAdjuntarDoc") = tsbCboTipoAdjunto.ComboBox.SelectedValue
            drowAdjuntarDocumento("ruta") = sArchivoOrigen
            'drowAdjuntarDocumento("archivo") = cboTipoAdjunto.SelectedValue & "-" & CopiarArchivo(sArchivoOrigen)
            drowAdjuntarDocumento("archivo") = sRuc_Empresa + "_" + sTipoAdjunto + "_" + CopiarArchivo(sArchivoOrigen) 'sTipoAdjunto & "-" & CopiarArchivo(sArchivoOrigen)

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


    Private Sub tsbAdjuntar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAdjuntar.Click
        Try

            
            If tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0 Then
                MsgBox("Debe seleccionar el tipo de documento a adjuntar", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                Exit Sub
            End If


            If ofdAdjuntar.ShowDialog = DialogResult.OK Then
                AgregarAdjunto(ofdAdjuntar.FileName)
            End If

            tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0
            'ObtenerLiquidacionAdjunto()


            ' ''Dim sArchivoOrigen As String

            ' ''LstDIG_INDICE.Clear()

            ' ''If tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0 Then
            ' ''    MsgBox("Debe seleccionar el tipo de documento ha adjuntar", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            ' ''Else
            ' ''    '0000000002: FACTURA
            ' ''    '0000000005: CARTA INSTRUCCION
            ' ''    '0000000011: factura grupo
            ' ''    '0000000018: liquidacion externa

            ' ''    If tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000002" Or _
            ' ''        tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000005" Or _
            ' ''        tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000011" Or _
            ' ''        tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000018" Then


            ' ''        Dim oDocumentos As New frmDocumentos
            ' ''        Dim oTB_DIG_INDICE As clsBE_TB_DIG_INDICE
            ' ''        'Dim sCodigoDocumento As String

            ' ''        oDocumentos.sCodigoDocumento = tsbCboTipoAdjunto.ComboBox.SelectedValue
            ' ''        oDocumentos.txtTipo.Text = tsbCboTipoAdjunto.ComboBox.SelectedText
            ' ''        'oDocumentos.pstrEmpresa = txtRucEmpresa.Text

            ' ''        oDocumentos.ShowDialog()


            ' ''        If oDocumentos.bRetorna = True Then

            ' ''            sArchivoOrigen = oDocumentos.txtAdjunto.Text
            ' ''            AgregarAdjunto(sArchivoOrigen)

            ' ''            oTB_DIG_INDICE = oDocumentos.oTB_DIG_INDICE

            ' ''            'oTB_DIG_INDICE.EMPRESA = txtRucEmpresa.Text
            ' ''            'oTB_DIG_INDICE.IDTIPODOC_DIG = tsbCboTipoAdjunto.ComboBox.SelectedValue
            ' ''            'oTB_DIG_INDICE.PROVEEDOR = txtRucSocio.Text
            ' ''            'oTB_DIG_INDICE.CONTRATO_LIQ = txtContrato.Text
            ' ''            'oTB_DIG_INDICE.LOTE_LIQ = txtLote.Text
            ' ''            'oTB_DIG_INDICE.LIQUIDACION = txtLiquidacion.Text

            ' ''            'oTB_DIG_INDICE.RUTA = txtRucEmpresa.Text + "\" + txtRucSocio.Text + "\" + txtContrato.Text + "\" + txtLote.Text

            ' ''            oTB_DIG_INDICE.ContratoLoteId = pstrContratoLoteId
            ' ''            oTB_DIG_INDICE.LiquidacionId = pstrLiquidacionId
            ' ''            oTB_DIG_INDICE.liquidacionAdjuntoId = tsbCboTipoAdjunto.ComboBox.SelectedValue

            ' ''            'oTB_DIG_INDICE.liquidacionEstadoId = txtliquidacionEstadoId.Text
            ' ''            oTB_DIG_INDICE.liquidacionEstadoDetalleId = pLiquidacionEstadoDetalleId
            ' ''            oTB_DIG_INDICE.uc = pBEUsuario.tablaDetId

            ' ''            LstDIG_INDICE.Add(oTB_DIG_INDICE)
            ' ''        End If

            ' ''        oDocumentos.bRetorna = False
            ' ''    Else

            ' ''        Dim oListaDocumentos As New frmListaDocumentos
            ' ''        oListaDocumentos.pstrIDTIPODOC_DIG = tsbCboTipoAdjunto.ComboBox.SelectedValue
            ' ''        oListaDocumentos.sRuta_Origen = sRuta_Origen
            ' ''        oListaDocumentos.sRuta_Parametro = sParametro_Ruta

            ' ''        'oListaDocumentos.sEMPRESA = txtRucEmpresa.Text
            ' ''        'oListaDocumentos.sPROVEEDOR = txtRucSocio.Text
            ' ''        oListaDocumentos.pContratoLoteId = pstrContratoLoteId

            ' ''        If tsbCboTipoAdjunto.ComboBox.SelectedValue = "0000000008" Then
            ' ''            oListaDocumentos.pLiquidacionId = pstrLiquidacionId
            ' ''            'oListaDocumentos.sRuta_Origen = sRuta_Origen + "\" + txtContrato.Text + "\" + txtLote.Text
            ' ''        End If

            ' ''        oListaDocumentos.ShowDialog()


            ' ''        If oListaDocumentos.bRetorna = True Then
            ' ''            For i = 0 To oListaDocumentos.LstDIG_INDICE.Count - 1
            ' ''                'insert todos los documentos

            ' ''                'oListaDocumentos.LstDIG_INDICE(i).CONTRATO_LIQ = txtContrato.Text
            ' ''                'oListaDocumentos.LstDIG_INDICE(i).LOTE_LIQ = txtLote.Text
            ' ''                'oListaDocumentos.LstDIG_INDICE(i).LIQUIDACION = txtLiquidacion.Text

            ' ''                'oListaDocumentos.LstDIG_INDICE(i).ContratoLoteId = pstrContratoLoteId
            ' ''                'oListaDocumentos.LstDIG_INDICE(i).LiquidacionId = pstrLiquidacionId

            ' ''                'oListaDocumentos.LstDIG_INDICE(i).liquidacionEstadoId = txtliquidacionEstadoId.Text
            ' ''                'oListaDocumentos.LstDIG_INDICE(i).liquidacionEstadoDetalleId = pLiquidacionEstadoDetalleId
            ' ''                'oListaDocumentos.LstDIG_INDICE(i).uc = pBEUsuario.tablaDetId

            ' ''                'oListaDocumentos.LstDIG_INDICE(i).liquidacionAdjuntoId = tsbCboTipoAdjunto.ComboBox.SelectedValue

            ' ''                'oListaDocumentos.LstDIG_INDICE(i).RUTA = txtRucEmpresa.Text + "\" + txtRucSocio.Text + "\" + txtContrato.Text + "\" + txtLote.Text

            ' ''                oListaDocumentos.LstDIG_INDICE(i).ESTADO = 2

            ' ''                LstDIG_INDICE.Add(oListaDocumentos.LstDIG_INDICE(i))

            ' ''                'solo muestra la ruta
            ' ''                'AgregarAdjunto(sRuta_Origen + "\" + oListaDocumentos.LstDIG_INDICE.Item(i).ARCHIVO.ToString)
            ' ''                If oListaDocumentos.LstDIG_INDICE.Item(i).RUTA_ORIGEN.ToString = "" Then
            ' ''                    AgregarAdjunto(sRuta_Origen + "\" + oListaDocumentos.LstDIG_INDICE.Item(i).ARCHIVO.ToString)
            ' ''                Else
            ' ''                    AgregarAdjunto(oListaDocumentos.LstDIG_INDICE.Item(i).RUTA_ORIGEN.ToString)
            ' ''                End If

            ' ''            Next
            ' ''        End If
            ' ''        oListaDocumentos.bRetorna = False

            ' ''    End If
            ' ''    tsbCboTipoAdjunto.ComboBox.SelectedIndex = 0


            ' ''    Dim oBC_TB_DIG_INDICETX As New clsBC_TB_DIG_INDICETX

            ' ''    oBC_TB_DIG_INDICETX.LstTB_DIG_INDICE_INSERT = LstDIG_INDICE
            ' ''    oBC_TB_DIG_INDICETX.TB_DIG_INDICE_INSERT()

            ' ''    ObtenerLiquidacionAdjunto()
            ' ''End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub ObtenerRegistros()
        Try
            'blnCarga = False
            Dim oLiquidacionEstadoDetalleRO As New clsBC_LiquidacionEstadoDetalleRO

            'kmn 31/08/2012
            Dim sFilterDefinition As String = fxgLiquidacionEstadoDetalle.FilterDefinition
            Dim nRowSel As Integer = fxgLiquidacionEstadoDetalle.RowSel
            Dim sRowFilter As String = ""
            'If dvwContrato IsNot Nothing Then
            '    sRowFilter = dvwContrato.RowFilter
            'End If

            Dim dsLiquidacionEstadoDetalle As DataSet

            oLiquidacionEstadoDetalleRO.LeerLiquidacionEstadoDetalleDS_SelAll("S")

            dsLiquidacionEstadoDetalle = oLiquidacionEstadoDetalleRO.oDSLiquidacionEstadoDetalle '.Tables(0).DefaultView
            fxgLiquidacionEstadoDetalle.DataSource = dsLiquidacionEstadoDetalle.Tables(0)
            fxgLiquidacionEstadoDetalle.FilterDefinition = sFilterDefinition
            fxgLiquidacionEstadoDetalle.Sort(C1.Win.C1FlexGrid.SortFlags.Descending, 17)


            Try
                If dsLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                    fxgLiquidacionEstadoDetalle.RowSel = nRowSel
                End If
            Catch e As Exception
                fxgLiquidacionEstadoDetalle.RowSel = 1
            End Try
            'kmn 31/08/2012
            'fxgrdContrato.Cols("TMSN").Width = "dd"

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub

    Private Sub ObtenerLiquidacionEstadoDetalle_Sel_Seguimiento()

        Dim dsLiquidacionEstadoDetalle As DataSet
        Dim oBC_LiquidacionEstadoDetalle As New clsBC_LiquidacionEstadoDetalleRO
        oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle = New clsBE_LiquidacionEstadoDetalle
        oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle.liquidacionEstadoId = pLiquidacionEstadoId
        oBC_LiquidacionEstadoDetalle.oBELiquidacionEstadoDetalle.NRO_OP = ""
        oBC_LiquidacionEstadoDetalle.LeerLiquidacionEstadoDetalleDS_Sel_Seguimiento()
        dsLiquidacionEstadoDetalle = oBC_LiquidacionEstadoDetalle.oDSLiquidacionEstadoDetalle
        fgxSeguimiento.DataSource = dsLiquidacionEstadoDetalle.Tables(0)

    End Sub

    Private Function ProvisionVenta(ByVal pTIPO_OPERACION As String, ByVal pIDPROVI As Integer, ByVal pESTADO As String) As Boolean

        Try
            Dim oBC_TB_PROVIPREVTX As New clsBC_TB_PROVIPREVTX
            Dim oBE_TB_PROVIPREV As New clsBE_TB_PROVIPREV

            oBE_TB_PROVIPREV.pTIPO_OPERACION = pTIPO_OPERACION
            oBE_TB_PROVIPREV.pIDPROVI = pIDPROVI
            oBE_TB_PROVIPREV.pESTADO = pESTADO

            oBE_TB_PROVIPREV.PcontratoloteId = pstrContratoLoteId
            oBE_TB_PROVIPREV.pLiquidacionId = pstrLiquidacionId
            oBE_TB_PROVIPREV.pUsuarioId = pBEUsuario.tablaDetId
            oBC_TB_PROVIPREVTX.LstTB_PROVIPREV_INSERT.Add(oBE_TB_PROVIPREV)
            oBC_TB_PROVIPREVTX.PROVIPREV_IU()

            Return True
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try

    End Function

    Private Sub ImprimirDocumentoValorado()

        Dim pPrinter As New Drawing.Printing.PrinterSettings
        'pPrinter.PrinterName = "EPSON LX-300+ /II"
        pPrinter.PrinterName = "XC-COMERCIAL"
       

            Dim oFactura As New frmFactura
            oFactura.pContratoloteid = pstrContratoLoteId
            oFactura.pLiquidacionId = pstrLiquidacionId
            oFactura.sTipoDocumentoValorado = cboTipoDocumento.SelectedValue

        ''If oFactura.PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        ''    oFactura.PrintDocument1.PrinterSettings = oFactura.PrintDocument1.PrinterSettings

        oFactura.PrintDocument1.PrinterSettings = pPrinter

        'If oFactura.PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    oFactura.PrintDocument1.PrinterSettings = oFactura.PrintDocument1.PrinterSettings

        oFactura.PrintDocument1.Print()
        ''End If

        '' ''Obtiene los datos de la ultima factura
        ' ''Dim oBC_TablaDetRO As New clsBC_TablaDetRO
        ' ''Dim oBC_TablaDetTX As New clsBC_TablaDetTX
        ' ''Dim oBE_TablaDet As New clsBE_TablaDet
        ' ''oBC_TablaDetRO.oBETablaDet.tablaId = "empresa"
        ' ''oBC_TablaDetRO.oBETablaDet.tablaDetId = pstrCodigoEmpresa
        ' ''oBC_TablaDetRO.LeerTablaDet()
        ' ''oBE_TablaDet = oBC_TablaDetRO.oBETablaDet
        '' ''oBE_TablaDet.campo10 & " - " & oBE_TablaDet.campo11

        '' ''Actualiza los datos de la liquidaciion(numero de factura,fecha)
        ' ''Dim oLiquidacionROMod As New clsBC_LiquidacionRO
        ' ''With oLiquidacionROMod.oBELiquidacion
        ' ''    .contratoLoteId = pstrContratoLoteId 'txtCorrelativo.Text.Trim()
        ' ''    .liquidacionId = pstrLiquidacionId 'sLiquidacionID 'dgvLiquidacion.Columns("liquidacionId").CellValue(dgvLiquidacion.Row).ToString() 'dgvLiquidacion.Columns("liquidacionId").CellValue(a).ToString()
        ' ''    '.periodo = dgvLiquidacion.Columns("periodo").CellValue(a).ToString()
        ' ''    .periodo = pstrPeriodo

        ' ''    Select Case cboTipoDocumento.SelectedValue
        ' ''        Case "FT"
        ' ''            .numeroDocumento = oBE_TablaDet.campo10 & " - " & oBE_TablaDet.campo11
        ' ''        Case "ND"
        ' ''            .numeroDocumento = oBE_TablaDet.campo10 & " - " & oBE_TablaDet.campo13
        ' ''        Case "NA"
        ' ''            .numeroDocumento = oBE_TablaDet.campo10 & " - " & oBE_TablaDet.campo15
        ' ''    End Select

        ' ''    .codigoDocumento = cboTipoDocumento.SelectedValue
        ' ''    .fechaDocumento = Convert.ToDateTime(dtpFechaDocumento.Text)
        ' ''    oLiquidacionROMod.LstLiquidacion.Add(oLiquidacionROMod.oBELiquidacion)
        ' ''End With
        ' ''oLiquidacionROMod.fnModificarLiquidacion()

        '' ''actualiza el correlativo de la factura
        ' ''oBE_TablaDet = New clsBE_TablaDet
        ' ''oBE_TablaDet.tablaId = "empresa"
        ' ''oBE_TablaDet.tablaDetId = pstrCodigoEmpresa

        ' ''oBE_TablaDet.campo10 = cboTipoDocumento.SelectedValue
        ' ''oBE_TablaDet.campo12 = cboTipoDocumento.SelectedValue
        ' ''oBE_TablaDet.campo14 = cboTipoDocumento.SelectedValue

        '' ''oBC_TablaDetTX.oBETablaDet = oBE_TablaDet
        ' ''oBC_TablaDetTX.LstTablaDet.Add(oBE_TablaDet)
        ' ''oBC_TablaDetTX.ModificarTablaDet()

        '' '' ''actualiza la lista de liquidaciones
        ' '' ''ObtenerLiquidacionTotal(txtCorrelativo.Text.Trim())
        ' '' ''ObtenerLiquidacionDscto_AdelantosFactura(sLiquidacionID)
        '' ''End If
    End Sub


    Private Sub generarLiquidacionAuto(ByVal sPrefijo As String)
        Dim sParametroRuta As String

        Dim oTablaDetRO = New clsBC_TablaDetRO
        oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"
        'oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
        oTablaDetRO.oBETablaDet.campo0 = "FIRMAS" 'RTrim(txtContrato.Text).Substring(0, 1)
        oTablaDetRO.LeerListaToDSTablaDetCondicion()
        'sParametroRuta = oTablaDetRO.oBETablaDet.descri.ToString()
        sParametroRuta = oTablaDetRO.oDSTablaDet.Tables(0).Rows(0)("descri").ToString()

        Dim rpContratoLoteId As New ReportParameter()
        rpContratoLoteId.Name = "contratoLoteId"
        rpContratoLoteId.Values.Add(pstrContratoLoteId)

        Dim rpLiquidacionId As New ReportParameter()
        rpLiquidacionId.Name = "liquidacionId"
        rpLiquidacionId.Values.Add(pstrLiquidacionId)

        Dim rpUserNombre As New ReportParameter()
        rpUserNombre.Name = "UserNombre"
        rpUserNombre.Values.Add(pBEUsuario.descri)

        Dim rpUserAutorizador As New ReportParameter()
        rpUserAutorizador.Name = "UserAutorizador"
        rpUserAutorizador.Values.Add(sParametroRuta & "/" & pBEUsuario.campo5)
        'sParametroRuta & "/" & pBEUsuario.campo5

        'Set the report parameters for the report
        Dim parameters() As ReportParameter = {rpContratoLoteId, rpLiquidacionId, rpUserNombre, rpUserAutorizador}

        Dim sArchivo As String = txtLoteVCM.Text.Replace("/", "-") & "-" & fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "numeroCalculo").ToString & fxgLiquidacionEstadoDetalle.Item(fxgLiquidacionEstadoDetalle.RowSel, "codigoCalculo").ToString

        ''sArchivo = sArchivo & "_AUTO.pdf"
        sArchivo = sPrefijo & sArchivo & ".pdf"

        'FALTA SELECCIONAR EL TIPO DE LIQUIDACION
        Dim oGenerarPDF As New frmGenerarPDF
        oGenerarPDF.pParametros = parameters
        oGenerarPDF.pRutaGenerarPDF = sParametro_Ruta & sRuta_Archivos & "\" & sArchivo 'oBC_OpagoRO.oDSOpago.Tables(0).Rows(0)("NRO_OP").ToString & "_" & txtEstadoId.Text & ".PDF"
        oGenerarPDF.pNombreReporte = "LiquidacionAuto"
        oGenerarPDF.Show()

      
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimir.Click
        If Not vaLidaCampos() Then Exit Sub
        ImprimirDocumentoValorado()
    End Sub

    Private Sub GuardaNumeroDocumento()
        Try
            Dim oLiquidacionROMod As New clsBC_LiquidacionRO

            Dim oBC_TablaDetRO As New clsBC_TablaDetRO
            'Dim bEstadoLiquidacion As Boolean = False
            'Dim sMensaje As String = ""

            Dim oLiquidacionROModx As New clsBC_LiquidacionRO
            With oLiquidacionROModx.oBELiquidacion

                'oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
                'oBC_TablaDetRO.oBETablaDet.tablaDetId = IIf(cboTipo.SelectedValue = "V", cboSocio.SelectedValue, cboEmpresa.SelectedValue)
                'oBC_TablaDetRO.oBETablaDet.campo6 = dgvLiquidacion.Columns("fechaRegistro").CellValue(a).ToString().Substring(6, 4) + dgvLiquidacion.Columns("fechaRegistro").CellValue(a).ToString().Substring(3, 2)
                'oBC_TablaDetRO.LeerListaToDSEstadoPeriodos()

                .contratoLoteId = pstrContratoLoteId
                .liquidacionId = pstrLiquidacionId
                .periodo = pstrPeriodo '"201401" '.periodo
                .codigoDocumento = cboTipoDocumento.SelectedValue
                .numeroDocumento = txtNumeroDocumento.Text
                .fechaDocumento = dtpFechaDocumento.Value
                oLiquidacionROMod.LstLiquidacion.Add(oLiquidacionROModx.oBELiquidacion)
            End With

            oLiquidacionROMod.fnModificarLiquidacion()
            'MsgBox("Grabado satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")

            'If bEstadoLiquidacion = True Then
            '    MsgBox("No se puede modificar liquidaciones con PERÍDOS CERRADOS", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")

            'Else
            '    oLiquidacionROMod.fnModificarLiquidacion()
            '    MsgBox("Grabado satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            'End If

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub ObtenerDetalleAdelanto(ByVal sContratoloteId As String, ByVal sLiquidacionId As String)
        Dim oBC_PROVIPREVRO As New clsBC_TB_PROVIPREVRO
        Dim dsTB_PROVIPREV As DataSet

        'Adelantos
        oBC_PROVIPREVRO.oBETB_PROVIPREV = New clsBE_TB_PROVIPREV
        oBC_PROVIPREVRO.oBETB_PROVIPREV.pContratoloteId = sContratoloteId
        oBC_PROVIPREVRO.oBETB_PROVIPREV.pLiquidacionId = sLiquidacionId

        oBC_PROVIPREVRO.LeerListaToDSPROVIPREV_ADELANTOS()
        dsTB_PROVIPREV = oBC_PROVIPREVRO.oDSTB_PROVIPREV
        fgxFinanciando_PreLiq.DataSource = dsTB_PROVIPREV.Tables(0)
    End Sub

    Private Sub cboTipoDocumento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoDocumento.SelectedIndexChanged
        sTipoDoc = cboTipoDocumento.SelectedIndex

        If txtLoteVCM.Text.Length > 0 And sTipoDoc <> "0" And pstrCodigoEmpresa IsNot Nothing Then
            If txtNumeroDocumento.Text.Trim = "0" Or txtNumeroDocumento.Text.Trim = "" Or txtNumeroDocumento.Text.Length <= 4 Then
                sTipo = txtLoteVCM.Text.Substring(0, 1)
                ObtieneSerie()
                txtNumeroDocumento.Text = sSERIE
            End If
        End If

    End Sub
End Class