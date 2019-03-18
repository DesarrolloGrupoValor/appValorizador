'Comments:
'@01 20141015 BAL01 Validacion, no se pueden generar liquidaciones PRV, FN si periodo de lote P,V,S esta cerrado
'@02 20141021 BAL01 Validacion, al generar liquidacion PRV o FIN, eliminar PRL en caso esten en el mismo periodo

Imports SI.PL.clsFuncion
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsGeneral
Imports SI.UT
Imports SI.BC
Imports System.Data
Imports System.Drawing.Drawing2D
Imports SI.BE
Imports SI.UT.clsUT_Enumerado
Imports System.Configuration

Imports Microsoft.Reporting.WinForms

Public Class ModLiquidacion
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Public Property codLote() As String
    Public Property uc() As String
    Public Property codTrader() As String
    Public Property NomTrader() As String
    Public Property Tipo() As String

    Public Property Observa() As Date

    Public Property bRumaFicticia As Boolean = False




    Public Property sTipoLote() As String
    Public Property sNumeroLote() As String



    Public oBC_ContratoLoteRO As New clsBC_ContratoLoteRO


    Private Sub ModLiquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subLlenarCbx()

        oBC_ContratoLoteRO.oBEContratoLote = New clsBE_ContratoLote
        oBC_ContratoLoteRO.oBEContratoLote.contratoLoteId = codLote()
        oBC_ContratoLoteRO.LeerContratoLote()

    End Sub

    Private Function ValidarLote()
        Dim strmensaje As String = ""

        Try
            'LOTES EN PERIODOS CERRADOS
            Dim oBC_TablaDetRO As New clsBC_TablaDetRO
            oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
            oBC_TablaDetRO.oBETablaDet.tablaId = IIf(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento = "V", oBC_ContratoLoteRO.oBEContratoLote.codigoSocio, oBC_ContratoLoteRO.oBEContratoLote.codigoEmpresa)
            oBC_TablaDetRO.oBETablaDet.campo6 = dtFecha.Value.Year.ToString + Microsoft.VisualBasic.Right("0" + dtFecha.Value.Month.ToString, 2)
            oBC_TablaDetRO.LeerListaToDSEstadoPeriodos()
            If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows.Count > 0 Then
                If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(0)("Int_flagDeclara").ToString = "1" Then
                    strmensaje = strmensaje & "* No puede generar la liquidación, el período: " + dtFecha.Value.Year.ToString + "-" + Microsoft.VisualBasic.Right("0" + dtFecha.Value.Month.ToString, 2) + " está CERRADO" & vbCrLf
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

    '@01    AINI
    Private Function ValidarPeriodoCerradoToLote() As Boolean
        Dim validacion As Boolean
        Dim p As New clsBC_PeriodoRO

        ' Verificamos el tipo de lote
        Dim nLiquidacionNoPermitida As Integer = 0
        If sTipoLote = "P" Or sTipoLote = "V" Or sTipoLote = "S" Then
            For a = 0 To C1TrueDBGrid1.Splits(0).Rows.Count - 1
                If C1TrueDBGrid1.Columns("Estado").CellValue(a).ToString().Trim() = "N" Then
                    If C1TrueDBGrid1.Columns("Marca").CellValue(a).ToString().Trim() = "True" Then
                        Dim tipoLiquidacion As String = C1TrueDBGrid1.Columns("TablaDetId").CellValue(a).ToString.Split("|")(0)
                        If tipoLiquidacion = "FIN" Or tipoLiquidacion = "PRV" Then
                            nLiquidacionNoPermitida += 1
                        End If
                    End If
                End If
            Next a

            If nLiquidacionNoPermitida > 0 Then
                Dim empresaID As String = oBC_ContratoLoteRO.oBEContratoLote.codigoEmpresa
                Dim periodo As String = dtFecha.Value.Year.ToString & Microsoft.VisualBasic.Right("0" + dtFecha.Value.Month.ToString, 2)
                validacion = p.ValidaPeriodoCerrado(empresaID, periodo)
            End If

            If validacion Then
                MsgBox("No se pueden generar liquidaciones PRV y/o FIN." & Chr(10) & "El periodo esta cerrado.", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
            End If

        End If
        Return validacion
    End Function
    '@01    AFIN

    '@02    AINI
    Private Function EliminarPRLs() As Boolean
        Dim validacion As Boolean
        Dim nLiquidacion As Integer = 0
        Dim p As New clsBC_PeriodoRO

        ' Obtenemos tipo de liquidacion a generar
        If sTipoLote = "P" Or sTipoLote = "V" Then
            For a = 0 To C1TrueDBGrid1.Splits(0).Rows.Count - 1
                If C1TrueDBGrid1.Columns("Estado").CellValue(a).ToString().Trim() = "N" Then
                    If C1TrueDBGrid1.Columns("Marca").CellValue(a).ToString().Trim() = "True" Then
                        Dim tipoLiquidacion As String = C1TrueDBGrid1.Columns("TablaDetId").CellValue(a).ToString.Split("|")(0)
                        If tipoLiquidacion = "FIN" Or tipoLiquidacion = "PRV" Then
                            nLiquidacion += 1
                        End If
                    End If
                End If
            Next a
        End If
        If nLiquidacion > 0 Then
            MsgBox("Dado que desea generar liquidaciones de tipo PRV y/o FIN; " _
                      & Chr(10) & "se eliminaran las PRL(s) registradas en el mismo periodo.",
                      MsgBoxStyle.Information, "Valorizador Comercial de Minerales")
            'Eliminar PRL(s)
            Dim periodo As String = dtFecha.Value.Year.ToString & Microsoft.VisualBasic.Right("0" + dtFecha.Value.Month.ToString, 2)
            p.EliminarPRLByPeriodo(codLote, periodo)
        End If
        Return validacion
    End Function
    '@02    AFIN

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Try


            Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO

            '@01    D01
            'If Not ValidarLote() Then Exit Sub

            '@01    A01
            If ValidarPeriodoCerradoToLote() Then Exit Sub

            Dim laDatos() As String
            'laDatos = cbxTipoLiquidacion.SelectedValue.ToString().Split("|")
            laDatos = "NULL|0|".Split("|")

            For a = 0 To C1TrueDBGrid1.Splits(0).Rows.Count - 1
                If C1TrueDBGrid1.Columns("Estado").CellValue(a).ToString().Trim() = "N" Then
                    If C1TrueDBGrid1.Columns("Marca").CellValue(a).ToString().Trim() = "True" Then
                        'laDatos = C1TrueDBGrid1.Columns("tablaDetId").CellValue(a).ToString().Trim().Split("|")

                        laDatos = (C1TrueDBGrid1.Columns("tablaDetId").CellValue(a).ToString().Trim() & "|" & C1TrueDBGrid1.Columns("descri").CellValue(a)).Split("|")

                        Exit For
                    End If
                End If
            Next a


            'KMN: 11/02/2014
            ''liquidacion de plomo ficticio
            'bRumaFicticia = False
            'KMN: 11/02/2014


            If laDatos(0) = "NULL" Then
                MessageBox.Show("Debe seleccionar una liquidacion")
            ElseIf dtFecha.Value < Observa Then
                MessageBox.Show("No puede generar la liquidación con fecha anterior al adelanto asociado")
                ''ElseIf laDatos(0) = "FIN" And bRumaFicticia = True Then
                ''    MsgBox("No puede generar Liquidacion de tipo FINAL, debe eliminar la RUMA ficticia", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Else

                ''ESTADO LIQUIDACION
                ''Dim sValidacionGenerarLiquidacion As String = validarGeneracionLiquidacion(codLote)
                ''If sValidacionGenerarLiquidacion <> "" Then
                ''    MsgBox(sValidacionGenerarLiquidacion, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                ''    Exit Sub
                ''End If


                ' ''***********************************************************************************************************************
                ' ''Validación de tickets y guias del MLC
                ''If laDatos(0) = "FIN" Or laDatos(0) = "PRV" Then
                ''    Dim sValidarDocumentosMLC As String = validarDocumentosMLC()
                ''    If sValidarDocumentosMLC <> "" Then
                ''        MsgBox("No puede liquidar porque " + Chr(10) + sValidarDocumentosMLC, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                ''        Return
                ''    End If
                ''End If
                ' ''***********************************************************************************************************************


                '***********************************************************************************************************************
                'Validacion de seleccion de leyes para generar liquidacion final
                If sTipoLote = "P" Or sTipoLote = "V" Or sTipoLote = "S" Then
                    'valida que las leyes estan marcadas en el MLC
                    If laDatos(0) = "FIN" Or laDatos(0) = "PRV" Then
                        Dim sMensajeValidacion As String

                        sMensajeValidacion = validarLeyesFinales(sTipoLote)
                        If sMensajeValidacion <> "" Then
                            MsgBox("No puede generar liquidación con Leyes Final. Las leyes deben ser marcadas en el MLC." + Chr(10) + sMensajeValidacion, MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                            Return
                        End If


                        If sTipoLote = "P" Or sTipoLote = "S" Then
                            sMensajeValidacion = validarFijacionesRango()
                            If sMensajeValidacion <> "" Then
                                'MsgBox("No puede generar liquidación." + Chr(10) + sMensajeValidacion, MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                                'Return
                            End If
                        End If

                        'If Not ValidarFijaciones() Then Exit Sub


                    End If
                End If
                '***********************************************************************************************************************

                '@02    A01
                EliminarPRLs()

                '************************************************
                'OK
                Dim lsCodLiquidacion As String = loclsBC_LiquidacionRO.fnCrearLiquidacion(codLote, _
                                                                                          Integer.Parse(laDatos(1)), laDatos(0), uc(), codTrader(), dtFecha.Value, "GLQ")
                '************************************************




                '********************************************************************************************************
                'Es para la generacion de auditoria
                'pAccionFormulario = "GLQ"

                '********************************************************************************************************

                ''Dim lsCodLiquidacion As String = loclsBC_LiquidacionRO.fnCrearLiquidacion(codLote, _
                ''                                                                          Integer.Parse(laDatos(1)), laDatos(0), uc(), codTrader(), dtFecha.Value)

                ''Dim frm As New browser
                ''Dim lsCadena = "&contratoLoteId=" & codLote() & "&liquidacionId=" & lsCodLiquidacion & "&UserNombre=" & NomTrader()
                ''Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
                ''frm.psurl = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2f" & Tipo() & "&rs:Command=Render" & lsCadena
                ''frm.Show()


                ''''ok

                '*******************************************************

                'Dim lsCodLiquidacion As String = "0000000001"

                'Actualizacion de financiamiento
                If sTipoLote = "P" And (laDatos(0) = "PRV" Or laDatos(0) = "FIN") Then
                    '*******************************************************
                    'actualizacion de financiamiento
                    Dim oBC_LiquidacionTX As New clsBC_LiquidacionTX
                    oBC_LiquidacionTX.oBELiquidacion = New clsBE_Liquidacion
                    oBC_LiquidacionTX.oBELiquidacion.contratoLoteId = codLote
                    oBC_LiquidacionTX.oBELiquidacion.liquidacionId = lsCodLiquidacion
                    oBC_LiquidacionTX.oBELiquidacion.uc = uc()

                    oBC_LiquidacionTX.Modificar_Liquidacion_Financiamiento()
                    '*******************************************************
                ElseIf (sTipoLote = "S" Or sTipoLote = "V") And (laDatos(0) = "PRV" Or laDatos(0) = "FIN") Then
                    Dim oBC_TB_PROVIPREVTX As New clsBC_TB_PROVIPREVTX
                    Dim oBE_TB_PROVIPREV As New clsBE_TB_PROVIPREV

                    oBE_TB_PROVIPREV.pTIPO_OPERACION = "I"
                    oBE_TB_PROVIPREV.pIDPROVI = 0
                    oBE_TB_PROVIPREV.pESTADO = "P"

                    oBE_TB_PROVIPREV.PcontratoloteId = codLote
                    oBE_TB_PROVIPREV.pLiquidacionId = lsCodLiquidacion
                    oBE_TB_PROVIPREV.pUsuarioId = pBEUsuario.tablaDetId
                    oBC_TB_PROVIPREVTX.LstTB_PROVIPREV_INSERT.Add(oBE_TB_PROVIPREV)
                    oBC_TB_PROVIPREVTX.PROVIPREV_IU()
                End If


                Dim frm As New Visor
                frm.pContratoLoteId = codLote()
                frm.pLiquidacionId = lsCodLiquidacion
                frm.pUserNombre = NomTrader()
                frm.pTipo = Tipo()



                'laDatos(0)
                Dim pContratoLiquidacion As String


                pContratoLiquidacion = oBC_ContratoLoteRO.oBEContratoLote.codigoSocio + "_LIQU_" + RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento) + RTrim(oBC_ContratoLoteRO.oBEContratoLote.contrato) + "-" + RTrim(oBC_ContratoLoteRO.oBEContratoLote.lote).Replace("/", "-") + "-" + laDatos(1) + laDatos(0) + ".pdf" 'pContratoLiquidacion



                'If sTipoLote = "P" And (laDatos(0) = "PRV" Or laDatos(0) = "FIN") Then
                If (laDatos(0) = "PRV" Or laDatos(0) = "FIN") Then
                    ''ESTADO LIQUIDACION
                    '***********************************************************************************************
                    ''Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO

                    ''oBC_ContratoLoteRO.oBEContratoLote = New clsBE_ContratoLote
                    ''oBC_ContratoLoteRO.oBEContratoLote.contratoLoteId = codLote()
                    ''oBC_ContratoLoteRO.LeerContratoLote()

                    ''pContratoLiquidacion = RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento) + RTrim(oBC_ContratoLoteRO.oBEContratoLote.contrato) + "-" + RTrim(oBC_ContratoLoteRO.oBEContratoLote.lote).Replace("/", "-") + "-" + laDatos(1) + laDatos(0) + ".pdf" 'pContratoLiquidacion
                    ' ''***********************************************************************************************

                    Dim oBC_LiquidacionEstadoTX As New clsBC_LiquidacionEstadoTX
                    oBC_LiquidacionEstadoTX.oBELiquidacionEstado = New clsBE_LiquidacionEstado
                    oBC_LiquidacionEstadoTX.oBELiquidacionEstado.contratoLoteId = codLote
                    oBC_LiquidacionEstadoTX.oBELiquidacionEstado.liquidacionId = lsCodLiquidacion
                    oBC_LiquidacionEstadoTX.oBELiquidacionEstado.codigoCalculo = laDatos(0)
                    oBC_LiquidacionEstadoTX.oBELiquidacionEstado.uc = uc()
                    oBC_LiquidacionEstadoTX.oBELiquidacionEstado.archivo = pContratoLiquidacion

                    oBC_LiquidacionEstadoTX.InsertarLiquidacionEstado()
                    '*******************************************************
                    ''ESTADO LIQUIDACION

                    '' ''*********************************************************************************************
                    ' ''***** estado liquidacion
                    ''frm.pContratoLiquidacion = pContratoLiquidacion 'laDatos(1) + laDatos(0) ESTADO LIQUIDACION
                    ' ''***** estado liquidacion
                End If

                'genera resumen de leyes
                If (laDatos(0) = "PRV" Or laDatos(0) = "FIN") Then
                    frm.pContratoLiquidacion = pContratoLiquidacion

                    CrearDirectorios(codLote)

                    'If sTipoLote = "P" Or sTipoLote = "V" Or sTipoLote = "S" Then
                    If sTipoLote = "P" Then
                        Dim rpcontratoLoteId As New ReportParameter()
                        rpcontratoLoteId.Name = "contratoLoteId"
                        rpcontratoLoteId.Values.Add(codLote)

                        Dim rpliquidacionId As New ReportParameter()
                        rpliquidacionId.Name = "liquidacionId"
                        rpliquidacionId.Values.Add(lsCodLiquidacion)

                        Dim parameters() As ReportParameter = {rpcontratoLoteId, rpliquidacionId}

                        Dim sArchivo As String
                        Dim sRuta_Parametro As String
                        'Parametros de ruta de guardar archivos
                        Dim oTablaDetRO As New clsBC_TablaDetRO
                        oTablaDetRO.oBETablaDet.tablaId = "EL_Ruta"

                        If sTipoLote = "P" Then
                            oTablaDetRO.oBETablaDet.tablaDetId = "0000000001"
                        ElseIf sTipoLote = "S" Then
                            oTablaDetRO.oBETablaDet.tablaDetId = "0000000002"
                        ElseIf sTipoLote = "V" Then
                            oTablaDetRO.oBETablaDet.tablaDetId = "0000000003"
                        End If

                        oTablaDetRO.LeerTablaDet()
                        sRuta_Parametro = oTablaDetRO.oBETablaDet.descri.ToString()

                        sArchivo = pContratoLiquidacion.Replace("LIQU", "RELE")
                        sRuta_Parametro = sRuta_Parametro + "\" + oBC_ContratoLoteRO.oBEContratoLote.rucEmpresa + "\" + oBC_ContratoLoteRO.oBEContratoLote.codigoSocio + "\" + RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento) + RTrim(oBC_ContratoLoteRO.oBEContratoLote.contrato) + "\" + RTrim(oBC_ContratoLoteRO.oBEContratoLote.codigoMovimiento) + RTrim(oBC_ContratoLoteRO.oBEContratoLote.contrato) + "-" + RTrim(oBC_ContratoLoteRO.oBEContratoLote.lote).Replace("/", "-") + "\" + sArchivo

                        Dim oGenerarPDF As New frmGenerarPDF
                        oGenerarPDF.pParametros = parameters
                        oGenerarPDF.pRutaGenerarPDF = sRuta_Parametro '+ "\" + sArchivo
                        oGenerarPDF.bSaveFile = False
                        oGenerarPDF.pAbrilArchivo = False
                        oGenerarPDF.pNombreReporte = "SustentoLeyes"

                        oGenerarPDF.Show()
                    End If

                Else
                    frm.pContratoLiquidacion = Nothing
                End If



                frm.Show()

                subLlenarCbx()
                Me.Dispose()


                ''If laDatos(0) = "FIN" Or laDatos(0) = "PRV" Then
                ''    envioDeCorreo(laDatos(2))
                ''End If









            End If


            ' ''If laDatos(0) = "NULL" Then
            ' ''    MessageBox.Show("Debe seleccionar una liquidacion")
            ' ''ElseIf dtFecha.Value < Observa Then
            ' ''    MessageBox.Show("No puede generar la liquidación con fecha anterior al adelanto asociado")
            ' ''Else
            ' ''    Dim lsCodLiquidacion As String = loclsBC_LiquidacionRO.fnCrearLiquidacion(codLote, _
            ' ''                                                                              Integer.Parse(laDatos(1)), laDatos(0), uc(), codTrader(), dtFecha.Value)


            ' ''    ''Dim frm As New browser

            ' ''    ''Dim lsCadena = "&contratoLoteId=" & codLote() & "&liquidacionId=" & lsCodLiquidacion & "&UserNombre=" & NomTrader()
            ' ''    ''Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()

            ' ''    ''frm.psurl = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2f" & Tipo() & "&rs:Command=Render" & lsCadena
            ' ''    ''frm.Show()


            ' ''    Dim frm As New Visor
            ' ''    frm.pContratoLoteId = codLote()
            ' ''    frm.pLiquidacionId = lsCodLiquidacion
            ' ''    frm.pUserNombre = NomTrader()
            ' ''    frm.pTipo = Tipo()
            ' ''    frm.Show()

            ' ''    subLlenarCbx()

            ' ''    Me.Dispose()
            ' ''End If












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


    Public Function validarGeneracionLiquidacion(ByVal sContratoLoteId As String) As String
        Dim sResultado As String = ""

        Dim oBC_LiquidacionEstadoDetalleRO As New clsBC_LiquidacionEstadoDetalleRO
        oBC_LiquidacionEstadoDetalleRO.oBE_LiquidacionEstado = New clsBE_LiquidacionEstado
        oBC_LiquidacionEstadoDetalleRO.oBE_LiquidacionEstado.contratoLoteId = sContratoLoteId
        oBC_LiquidacionEstadoDetalleRO.LeerListaToDSLiquidacionEstadoDetalle()

        If Not oBC_LiquidacionEstadoDetalleRO.oDSLiquidacionEstadoDetalle Is Nothing Then
            If oBC_LiquidacionEstadoDetalleRO.oDSLiquidacionEstadoDetalle.Tables(0).Rows.Count > 0 Then
                If oBC_LiquidacionEstadoDetalleRO.oDSLiquidacionEstadoDetalle.Tables(0).Rows(0)("estadoId") <> "" Then
                    sResultado = "No puede generar, debido a que existe un liquidación en proceso." & Chr(10) & "La liquidación " & oBC_LiquidacionEstadoDetalleRO.oDSLiquidacionEstadoDetalle.Tables(0).Rows(0)("Liquidacion") & " se encuentra en estado " & oBC_LiquidacionEstadoDetalleRO.oDSLiquidacionEstadoDetalle.Tables(0).Rows(0)("estadoDescripcion")
                End If
            End If
        End If

        Return sResultado
    End Function


    Private Sub subLlenarCbx()
        Try
            Dim loclsBC_LiquidacionRO As New clsBC_LiquidacionRO
            Dim dt As New DataTable
            Dim dtold As New DataTable
            Dim ColEstado As New DataColumn()
            Dim ColMarca As New DataColumn()
            Dim ColFecReg As New DataColumn

            'cbxTipoLiquidacion.DisplayMember = "descri"
            'cbxTipoLiquidacion.ValueMember = "tablaDetId"
            'cbxTipoLiquidacion.DataSource = loclsBC_LiquidacionRO.fnTipoLiquidacion(codLote)

            dt = loclsBC_LiquidacionRO.fnTipoLiquidacion(codLote)
            dtold = loclsBC_LiquidacionRO.fnTipoLiquidacionOld(codLote)

            ColMarca.ColumnName = "Marca"

            ColMarca.DefaultValue = 0
            dt.Columns.Add(ColMarca)


            ColFecReg.ColumnName = "Fecha"
            'dt.Columns.Add(ColFecReg)

            ColEstado.ColumnName = "Estado"
            ColEstado.DefaultValue = "N"
            dt.Columns.Add(ColEstado)



            Dim xDR As DataRow

            For Each xDR In dtold.Rows
                Dim newRow As DataRow = dt.NewRow()

                newRow(0) = xDR(0)
                newRow(1) = xDR(1)
                newRow(2) = xDR(2)
                newRow(3) = 1
                'newRow(4) = xDR(3)
                newRow(4) = "O"
                dt.Rows.Add(newRow)
                dt.AcceptChanges()

            Next xDR

            C1TrueDBGrid1.DataSource = dt

            C1TrueDBGrid1.Columns("Marca").Caption = "Marca"
            C1TrueDBGrid1.Columns("Marca").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            C1TrueDBGrid1.Columns("Marca").ValueItems.Translate = True
            'C1TrueDBGrid1.Columns("Marca").DataWidth = 10
            C1TrueDBGrid1.Columns("Marca").ValueItems.CycleOnClick = True


            Dim col As C1.Win.C1TrueDBGrid.C1DataColumn

            For Each col In C1TrueDBGrid1.Columns

                If col.DataField.ToString().Trim() = "Estado" Or col.DataField.ToString().Trim() = "tablaDetId" Or col.DataField.ToString().Trim() = "numero" Then
                    C1TrueDBGrid1.Splits(0).DisplayColumns(col).Visible = False
                End If
                If col.DataField.ToString().Trim() = "Marca" Then
                    C1TrueDBGrid1.Splits(0).DisplayColumns(col).Width = 40
                End If
            Next col
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub C1TrueDBGrid1_AfterColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1TrueDBGrid1.AfterColUpdate
        Try
            Dim col As New C1.Win.C1TrueDBGrid.C1DataColumn
            col = e.Column.DataColumn

            If C1TrueDBGrid1.Columns("Estado").Value = "N" Then


                For a = 0 To C1TrueDBGrid1.Splits(0).Rows.Count - 1
                    If C1TrueDBGrid1.Columns("Estado").CellValue(a).ToString().Trim() = "N" Then
                        If C1TrueDBGrid1.Columns("descri").Value.ToString().Trim() <> C1TrueDBGrid1.Columns("descri").CellValue(a).ToString().Trim() Then

                            If C1TrueDBGrid1.Columns("Marca").CellValue(a).ToString().Trim() = "True" Then
                                C1TrueDBGrid1.Columns("Marca").Value = 0
                                MessageBox.Show("No se puede seleccionar mas de 1 liquidacion")
                            End If

                        End If
                    End If
                Next a
            Else
                C1TrueDBGrid1.Columns("Marca").Value = 1
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ''Dim frm As New browser

            ''Dim lsCadena = "&contratoLoteId=" & codLote() & "&liquidacionId=" & "0000000001" & "&UserNombre=" & NomTrader()
            ''Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()

            ''frm.psurl = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2f" & Tipo() & "&rs:Command=Render" & lsCadena
            ''frm.Show()



            Dim frm As New Visor

            frm.pContratoLoteId = codLote()
            frm.pLiquidacionId = "0000000001"
            frm.pUserNombre = NomTrader()
            frm.pTipo = Tipo()
            'frm.psurl = "ReportViewer.aspx?%2fVCM%2f" & Tipo() & "&rs:Command=Render" & lsCadena
            'frm.psurl = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2f" & Tipo() & "&rs:Command=Render" & lsCadena
            frm.Show()


            'envioDeCorreo("Pre-liquidacion")



        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try


            Dim frm As New Visor

            frm.pContratoLoteId = codLote()
            frm.pLiquidacionId = "0000000001"
            frm.pUserNombre = NomTrader()
            frm.pTipo = Tipo()
            'frm.psurl = "ReportViewer.aspx?%2fVCM%2f" & Tipo() & "&rs:Command=Render" & lsCadena
            'frm.psurl = lsPagina + "ReportViewer.aspx?%2fVCM%2fCOMERCIAL%2f" & Tipo() & "&rs:Command=Render" & lsCadena
            frm.Show()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub envioDeCorreo(ByVal sTipoLiquidacion As String)
        If sTipoLote = "V" Then
            Dim dsTablaDetRO As DataSet
            Dim oBC_TablaDetRO As New clsBC_TablaDetRO
            oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
            oBC_TablaDetRO.oBETablaDet.tablaId = "usuario"
            'oBC_TablaDetRO.oBETablaDet.tablaDetId = pBEUsuario.tablaDetId
            oBC_TablaDetRO.LeerListaToDSTablaDet()

            dsTablaDetRO = oBC_TablaDetRO.oDSTablaDet
            'oBC_TablaDetRO.oBETablaDet.campo4 = "1"
            If dsTablaDetRO.Tables(0).Rows.Count > 0 Then
                For i = 0 To dsTablaDetRO.Tables(0).Rows.Count - 1
                    If dsTablaDetRO.Tables(0).Rows(i)("campo4") = "1" Then
                        EnvioCorreo(dsTablaDetRO.Tables(0).Rows(i)("campo3"), "Revision de la Liquidacion " & sNumeroLote, "Se ha generado la liquidacion " & sTipoLiquidacion & " de la vinculada " & sNumeroLote & ", revisar en el VCM para la generacion del documento valorado")
                    End If
                Next
            End If
        End If
    End Sub


    Private Function validarFijacionesRango() As String
        Dim sFijacionRango As String = ""

        Dim oBC_ValorizadorPagableRO As New clsBC_ValorizadorPagableRO
        Dim dsValorizadorPagable As DataSet

        'Obtiene las leyes pagables
        oBC_ValorizadorPagableRO.oBEValorizadorPagable = New clsBE_ValorizadorPagable
        oBC_ValorizadorPagableRO.oBEValorizadorPagable.contratoLoteId = codLote
        oBC_ValorizadorPagableRO.oBEValorizadorPagable.liquidacionId = "0000000001"
        dsValorizadorPagable = oBC_ValorizadorPagableRO.LeerListaToDSValorizadorPagable

        For i = 0 To dsValorizadorPagable.Tables(0).Rows.Count - 1
            If dsValorizadorPagable.Tables(0).Rows(i)("fijacion_rango") = "1" And dsValorizadorPagable.Tables(0).Rows(i)("indprecio") = "1" Then
                sFijacionRango += " * " + dsValorizadorPagable.Tables(0).Rows(i)("codigoElemento") & ": " & dsValorizadorPagable.Tables(0).Rows(i)("contenido_disponible") & Chr(10)
            End If
        Next

        'If sFijacionRango <> "" Then
        '    sFijacionRango = "El contenido fino está fuera del rango permitido para generar ajuste." + Chr(10) + "Debe generar operación en línea de fijación por los siguientes elementos: " + Chr(10) + sFijacionRango
        'End If

        Return sFijacionRango

    End Function


    'kmn
    Private Function validarLeyesFinales(ByVal sTipoLote As String) As String
        'Dim sFijacionRango As String = ""

        Dim sMensaje As String = ""

        Dim sContratoLoteId As String = codLote
        Dim sLiquidacionId As String = "0000000001"

        Dim oBC_LiquidacionRO As New clsBC_LiquidacionRO
        Dim oBC_LiquidacionTmRO As New clsBC_LiquidacionTmRO
        Dim oBC_ValorizadorPagableRO As New clsBC_ValorizadorPagableRO
        Dim oBC_ValorizadorPenalizableRO As New clsBC_ValorizadorPenalizableRO
        Dim oBC_COM_LOTE_MUESTRASLABRO As New clsBC_COM_LOTE_MUESTRASLABRO

        Dim dsLiquidacion As DataSet
        Dim dsLiquidacionTm As DataSet
        Dim dsValorizadorPagable As DataSet
        Dim dsValorizadorPenalizable As DataSet
        Dim dsCOM_LOTE_MUESTRASLAB As DataSet

        Dim sH2OFin As String = ""

        'Obtiene fin de humedad
        oBC_LiquidacionRO.oBELiquidacion = New clsBE_Liquidacion
        oBC_LiquidacionRO.oBELiquidacion.contratoLoteId = sContratoLoteId
        oBC_LiquidacionRO.oBELiquidacion.liquidacionId = sLiquidacionId
        dsLiquidacion = oBC_LiquidacionRO.LeerListaToDSLiquidacion
        If dsLiquidacion.Tables(0).Rows.Count > 0 Then
            sH2OFin = dsLiquidacion.Tables(0).Rows(0)("H2OFin").ToString()
        End If

        'Obtiene las rumas
        oBC_LiquidacionTmRO.oBELiquidacionTm = New clsBE_LiquidacionTm
        oBC_LiquidacionTmRO.oBELiquidacionTm.contratoLoteId = sContratoLoteId
        oBC_LiquidacionTmRO.oBELiquidacionTm.liquidacionId = sLiquidacionId
        dsLiquidacionTm = oBC_LiquidacionTmRO.LeerListaToDSLiquidacion

        'Obtiene las leyes pagables
        oBC_ValorizadorPagableRO.oBEValorizadorPagable = New clsBE_ValorizadorPagable
        oBC_ValorizadorPagableRO.oBEValorizadorPagable.contratoLoteId = sContratoLoteId
        oBC_ValorizadorPagableRO.oBEValorizadorPagable.liquidacionId = sLiquidacionId
        dsValorizadorPagable = oBC_ValorizadorPagableRO.LeerListaToDSValorizadorPagable

        'Obtiene las leyes penalizables
        oBC_ValorizadorPenalizableRO.oBEValorizadorPenalizable = New clsBE_ValorizadorPenalizable
        oBC_ValorizadorPenalizableRO.oBEValorizadorPenalizable.contratoLoteId = sContratoLoteId
        oBC_ValorizadorPenalizableRO.oBEValorizadorPenalizable.liquidacionId = sLiquidacionId
        dsValorizadorPenalizable = oBC_ValorizadorPenalizableRO.LeerListaToDSValorizadorPenalizable


        For i = 0 To dsLiquidacionTm.Tables(0).Rows.Count - 1
            'Obtiene las leyes del MLC, para ser validadas
            oBC_COM_LOTE_MUESTRASLABRO.oBECOM_LOTE_MUESTRASLAB = New clsBE_COM_LOTE_MUESTRASLAB
            oBC_COM_LOTE_MUESTRASLABRO.oBECOM_LOTE_MUESTRASLAB.COD_LOTE = dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString


            If dsLiquidacionTm.Tables(0).Rows(i)("ticket").ToString = "" And dsLiquidacionTm.Tables(0).Rows(i)("guia").ToString = "" Then
            Else
                If sTipoLote <> "S" Then
                    oBC_COM_LOTE_MUESTRASLABRO.oBECOM_LOTE_MUESTRASLAB.NRO_GUIA = dsLiquidacionTm.Tables(0).Rows(i)("ticket").ToString
                Else
                    oBC_COM_LOTE_MUESTRASLABRO.oBECOM_LOTE_MUESTRASLAB.NRO_GUIA = ""
                End If

                dsCOM_LOTE_MUESTRASLAB = oBC_COM_LOTE_MUESTRASLABRO.LeerListaToDSValidarLeyesFinales

                If dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows.Count > 0 Then
                    If sH2OFin = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MH2O").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", H2O." + Chr(10)
                    End If
                Else
                    sMensaje += " * La ruma " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & " tiene problemas en la TI, contactarse con sistemas." + Chr(10)
                    Return sMensaje
                End If


                'Pagables
                For j = 0 To dsValorizadorPagable.Tables(0).Rows.Count - 1
                    If dsValorizadorPagable.Tables(0).Rows(j)("codigoElemento").ToString = "CU" And dsValorizadorPagable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MCU").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de CU." + Chr(10)
                    End If
                    If dsValorizadorPagable.Tables(0).Rows(j)("codigoElemento").ToString = "AG" And dsValorizadorPagable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MAG").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de AG." + Chr(10)
                    End If
                    If dsValorizadorPagable.Tables(0).Rows(j)("codigoElemento").ToString = "AU" And dsValorizadorPagable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MAU").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de AU." + Chr(10)
                    End If
                    If dsValorizadorPagable.Tables(0).Rows(j)("codigoElemento").ToString = "PB" And dsValorizadorPagable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MPB").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de PB." + Chr(10)
                    End If
                    If dsValorizadorPagable.Tables(0).Rows(j)("codigoElemento").ToString = "ZN" And dsValorizadorPagable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MZN").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de ZN." + Chr(10)
                    End If
                Next


                'Penalizables
                For j = 0 To dsValorizadorPenalizable.Tables(0).Rows.Count - 1
                    If dsValorizadorPenalizable.Tables(0).Rows(j)("codigoElemento").ToString = "PB" And dsValorizadorPenalizable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MPB").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de PB." + Chr(10)
                    End If
                    If dsValorizadorPenalizable.Tables(0).Rows(j)("codigoElemento").ToString = "ZN" And dsValorizadorPenalizable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MZN").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de ZN." + Chr(10)
                    End If
                    If dsValorizadorPenalizable.Tables(0).Rows(j)("codigoElemento").ToString = "AS" And dsValorizadorPenalizable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MAS").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de AS." + Chr(10)
                    End If
                    If dsValorizadorPenalizable.Tables(0).Rows(j)("codigoElemento").ToString = "SB" And dsValorizadorPenalizable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MSB").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de SB." + Chr(10)
                    End If
                    If dsValorizadorPenalizable.Tables(0).Rows(j)("codigoElemento").ToString = "BI" And dsValorizadorPenalizable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MBI").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de BI." + Chr(10)
                    End If
                    If dsValorizadorPenalizable.Tables(0).Rows(j)("codigoElemento").ToString = "HG" And dsValorizadorPenalizable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MHG").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de HG." + Chr(10)
                    End If
                    If dsValorizadorPenalizable.Tables(0).Rows(j)("codigoElemento").ToString = "SIO2" And dsValorizadorPenalizable.Tables(0).Rows(j)("indley").ToString = "1" And dsCOM_LOTE_MUESTRASLAB.Tables(0).Rows(0)("MSIO2").ToString = "0" Then
                        sMensaje += " * De la ruma: " & dsLiquidacionTm.Tables(0).Rows(i)("codigoLote").ToString & ", ley de SIO2." + Chr(10)
                    End If
                Next



                ' ''Fijaciones
                ''If dsValorizadorPagable.Tables(0).Rows(j)("fijacion_rango") = "1" And dsValorizadorPagable.Tables(0).Rows(j)("indprecio") = "1" Then
                ''    sFijacionRango += " * " + dsValorizadorPagable.Tables(0).Rows(j)("codigoElemento") & ": " & dsValorizadorPagable.Tables(0).Rows(j)("contenido_disponible") & Chr(10)
                ''End If

                ''If sFijacionRango <> "" Then
                ''    sFijacionRango = "El contenido fino está fuera del rango permitido para generar ajuste." + Chr(10) + "Debe generar operación en línea de fijación por los siguientes elementos: " + Chr(10) + sFijacionRango
                ''End If

            End If

        Next

        ''If sFijacionRango <> "" Then
        ''    sMensaje += Chr(10) + Chr(10) + sFijacionRango
        ''End If

        Return sMensaje
    End Function


    Private Function validarDocumentosMLC() As String
        Dim sMensaje As String = ""
        'Dim sContratoLoteId As String = codLote
        'Dim sLiquidacionId As String = "0000000001"
        Dim oBC_TB_DIG_INDICERO As New clsBC_TB_DIG_INDICERO
        Dim dsTB_DIG_INDICERO As DataSet

        dsTB_DIG_INDICERO = oBC_TB_DIG_INDICERO.LeerListaToDSTB_DIG_INDICE_Sel_Archivo(codLote)

        If dsTB_DIG_INDICERO.Tables(0).Rows.Count > 0 Then
            For i = 0 To dsTB_DIG_INDICERO.Tables(0).Rows.Count - 1
                sMensaje += " * La ruma " & dsTB_DIG_INDICERO.Tables(0).Rows(i)("codigoLote").ToString & " con ticket " + dsTB_DIG_INDICERO.Tables(0).Rows(i)("ticket").ToString + " no tiene " + dsTB_DIG_INDICERO.Tables(0).Rows(i)("tipo").ToString + " adjunto" + Chr(10)
            Next
        End If

        Return sMensaje
    End Function



    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class