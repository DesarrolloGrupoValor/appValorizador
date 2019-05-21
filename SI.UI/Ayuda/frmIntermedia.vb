'Comments:
'@01 20141010 BAL01 Validacion Intervalo de valor en pre-liquidación (CU% y/o H2O > 0).
'@02 20141010 BAL01 Validacion de asociacion; todos los componentes deben estar liquidados.
'@03 20141022 BAL01 Validacion de asociacion; no se permite asociar ruma cuyo periodo este cerrado.
'@04 20141117 BAL01 Validacion de asociacion; no se permite asociar ruma cuyo TMH disponible se haya excedido.

Imports SI.BC
Imports SI.BE
Imports System.Globalization
Imports SI.PL

Imports SI.PL.clsGeneral

Public Class frmIntermedia
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Public pstrCorrelativo As String
    Public pstrCorrelativoLiquidacion As String
    Public pstrCorrelativoLiquidacionTm As String
    Public pcodEmpresa As String
    Public pdtLiquidacion As DataTable
    Public pdblMerma As Double
    Public pstrTipoMovimiento As String
    Public pstrTipoProducto As String
    Public pstrSocio As String
    Public pstrEmpresa As String
    Public pstrDeposito As String

    Public pstrCodigoClase As String
    Public pstrCategoria As String

    'kmn 31/08/2012
    Public pAsociar As Boolean = False
    Public pLoteOrigen As String

    Dim oMovimientoRO As New clsBC_LogisticaMovimientoRO
    Dim oMovimientoTX As New clsBC_LogisticaMovimientoTX
    Dim dvwMovimiento As DataView
    Dim olstMovimiento As List(Of clsBE_LogisticaMovimiento)
    Dim dRowLiquidacion As DataRow
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub frmIntermedia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If pdtLiquidacion Is Nothing Then
                Dim oliquidacionTmRO As New clsBC_LiquidacionTmRO
                pdtLiquidacion = oliquidacionTmRO.DefineTablaLiquidacionTm
            End If
            ObtenerRegistros()
            'With fxgrdTM
            '    .Columns("ID").Visible = False
            '    .Columns("TMH").Visible = False
            '    .Columns("ContratoLoteId").Visible = False
            '    .Columns("ESTADO").Visible = False
            '    .Columns("LiquidacionId").Visible = False
            '    .Columns("LiquidacionTmId").Visible = False
            '    .Columns("ContratoLoteSuceroaId").Visible = False
            '    .Columns("EstadoVCM").Visible = False
            '    .Columns("TIPO_MOV").Visible = False
            '    .Columns("ESTADO_SLC").Visible = False
            fxgrdTM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.ListBox
            fxgrdTM.ShowCursor = True
            'End With
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    Private Sub ObtenerRegistros()
        Try
            oMovimientoRO.oBELogisticaMovimiento.TIPO_MOV = pstrTipoMovimiento
            oMovimientoRO.oBELogisticaMovimiento.ELEMENTO_MINERAL = pstrTipoProducto
            'oMovimientoRO.oBELogisticaMovimiento.EMPRESA_ORIGEN = pstrSocio

            oMovimientoRO.oBELogisticaMovimiento.EMP_PROV_CLIENTE = pstrSocio
            oMovimientoRO.oBELogisticaMovimiento.EMPRESA_CLI = pstrEmpresa
            oMovimientoRO.oBELogisticaMovimiento.COD_DEPOSITO = pstrDeposito


            oMovimientoRO.oBELogisticaMovimiento.LOTE_ORIGEN = pLoteOrigen


            oMovimientoRO.oBELogisticaMovimiento.TIPO_MINERAL = pstrCodigoClase

            oMovimientoRO.oBELogisticaMovimiento.CATEGORIA = pstrCategoria

            'oMovimientoRO.oBELogisticaMovimiento.EMPRESA = pcodEmpresa
            'oMovimientoRO.oBELogisticaMovimiento.
            Dim dsresult As DataSet
            dsresult = oMovimientoRO.LeerListaToDSLogisticaMovimiento
            If dsresult.Tables.Count > 0 Then
                dvwMovimiento = New DataView(dsresult.Tables(0))

                If pstrTipoMovimiento = "V" Then
                Else
                    dvwMovimiento.RowFilter = "ContratoLoteId='' AND LiquidacionId='' AND LiquidacionTmId=''"
                End If


                fxgrdTM.DataSource = dvwMovimiento

                clsFuncion.ColumnasID(fxgrdTM)
                clsFuncion.ColumnasCodigo(fxgrdTM)


                ''fxgrdTM.Cols(16).Visible = False
                ''fxgrdTM.Cols(17).Visible = False
                ''fxgrdTM.Cols(18).Visible = False
                ''fxgrdTM.Cols(19).Visible = False
                ''fxgrdTM.Cols(22).Visible = False
                ''fxgrdTM.Cols(24).Visible = False
                ''fxgrdTM.Cols(28).Visible = False
                ''fxgrdTM.Cols(36).Visible = False
                ''fxgrdTM.Cols(37).Visible = False
                ''fxgrdTM.Cols(39).Visible = False
                ''fxgrdTM.Cols(40).Visible = False
                ''fxgrdTM.Cols(41).Visible = False
                ''fxgrdTM.Cols(42).Visible = False
                ''fxgrdTM.Cols(49).Visible = False
                ''fxgrdTM.Cols(53).Visible = False


                ' ''calidad
                ''fxgrdTM.Cols(7).Width = 220

                ''fxgrdTM.Cols(8).Width = 65
                ''fxgrdTM.Cols(9).Width = 120
                ''fxgrdTM.Cols(11).Width = 70
                ''fxgrdTM.Cols(12).Width = 70

                ''fxgrdTM.Cols(13).Width = 90
                ''fxgrdTM.Cols(14).Width = 90
                ''fxgrdTM.Cols(15).Width = 90

                ''fxgrdTM.Cols(16).Width = 90

                ''fxgrdTM.Cols(21).Width = 70
                ''fxgrdTM.Cols(23).Width = 70
                ''fxgrdTM.Cols(25).Width = 70
                ''fxgrdTM.Cols(26).Width = 70
                ''fxgrdTM.Cols(27).Width = 70
                ''fxgrdTM.Cols(29).Width = 70
                ''fxgrdTM.Cols(30).Width = 70
                ''fxgrdTM.Cols(31).Width = 70
                ''fxgrdTM.Cols(32).Width = 70
                ''fxgrdTM.Cols(33).Width = 70
                ''fxgrdTM.Cols(34).Width = 70
                ''fxgrdTM.Cols(35).Width = 70
                ''fxgrdTM.Cols(38).Width = 70
                ' ''deposito
                ''fxgrdTM.Cols(43).Width = 90
                ''fxgrdTM.Cols(44).Width = 90

                ''fxgrdTM.Cols(45).Width = 70
                ' ''Empresa
                ''fxgrdTM.Cols(46).Width = 200
                ''fxgrdTM.Cols(47).Width = 200
                ''fxgrdTM.Cols(48).Width = 200

                ''fxgrdTM.Cols(50).Width = 90
                ''fxgrdTM.Cols(51).Width = 90
                ''fxgrdTM.Cols(54).Width = 70
                ''fxgrdTM.Cols(55).Width = 60






                fxgrdTM.Cols("VCM_lote_origen").Visible = False
                fxgrdTM.Cols("VCM_cod_lote").Visible = False
                fxgrdTM.Cols("VCM_lote_destino").Visible = False
                fxgrdTM.Cols("TICKET").Visible = False
                fxgrdTM.Cols("LEY_AG").Visible = False
                fxgrdTM.Cols("LEY_AU").Visible = False
                fxgrdTM.Cols("LEY_SN").Visible = False
                fxgrdTM.Cols("LEY_AUNW").Visible = False
                fxgrdTM.Cols("LEY_CUTOT").Visible = False
                fxgrdTM.Cols("LEY_CNNa").Visible = False
                fxgrdTM.Cols("LEY_CAL").Visible = False
                fxgrdTM.Cols("LEY_SOD").Visible = False
                fxgrdTM.Cols("N_ITEM").Visible = False
                fxgrdTM.Cols("NUM_CONTRATO").Visible = False
                fxgrdTM.Cols("NRO_GUIAT").Visible = False


                fxgrdTM.Cols("ELEMENTO_MINERAL").Visible = False
                fxgrdTM.Cols("TIPO_MINERAL").Visible = False

                fxgrdTM.Cols("EMP_PROV_CLIENTE").Visible = False
                fxgrdTM.Cols("EMPRESA_CLI").Visible = False


                'calidad
                fxgrdTM.Cols("Calidad").Width = 250

                fxgrdTM.Cols("Recepcion").Width = 65

                fxgrdTM.Cols("Vendedor").Width = 250
                fxgrdTM.Cols("Comprador").Width = 150

                fxgrdTM.Cols("TMH").Width = 70
                fxgrdTM.Cols("H2O").Width = 70

                fxgrdTM.Cols("Ruma Origen").Width = 90
                fxgrdTM.Cols("Ruma Actual").Width = 90
                fxgrdTM.Cols("Ruma Destino").Width = 90

                fxgrdTM.Cols("Guia").Width = 90

                fxgrdTM.Cols("Cu%").Width = 70
                fxgrdTM.Cols("Ag Oz").Width = 70
                fxgrdTM.Cols("Au Oz").Width = 70
                fxgrdTM.Cols("Pb%").Width = 70
                fxgrdTM.Cols("Zn%").Width = 70
                fxgrdTM.Cols("As%").Width = 70
                fxgrdTM.Cols("Sb%").Width = 70
                fxgrdTM.Cols("Bi%").Width = 70
                fxgrdTM.Cols("Hg-ppm").Width = 70
                fxgrdTM.Cols("SiO2%").Width = 70
                fxgrdTM.Cols("As+Sb%").Width = 70
                fxgrdTM.Cols("Pb+Zn%").Width = 70
                fxgrdTM.Cols("CuSol%").Width = 70
                'deposito
                fxgrdTM.Cols("Deposito Origen").Width = 100
                fxgrdTM.Cols("Deposito Destino").Width = 100

                fxgrdTM.Cols("Cuota").Width = 70
                'Empresa
                fxgrdTM.Cols("Empresa Origen").Width = 250
                fxgrdTM.Cols("Empresa Actual").Width = 250
                fxgrdTM.Cols("Empresa Destino").Width = 250

                fxgrdTM.Cols("Producto").Width = 90
                fxgrdTM.Cols("Clase").Width = 90
                fxgrdTM.Cols("Ruma Acum").Width = 70
                fxgrdTM.Cols("Tipo Mov").Width = 60



                If pstrTipoMovimiento <> "P" Then
                    fxgrdTM.Cols("Ruma Acum").Visible = False

                    'Comprador/Vendedor
                    fxgrdTM.Cols("Vendedor").Width = 120
                    fxgrdTM.Cols("Comprador").Width = 120

                    'Empresa
                    fxgrdTM.Cols("Empresa Origen").Width = 150
                    fxgrdTM.Cols("Empresa Actual").Width = 150
                    fxgrdTM.Cols("Empresa Destino").Width = 150
                End If


            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            '@01    A01
            If Not fxgrdTM.Rows.Count > 1 Then
                Me.Dispose()
                Exit Sub
            End If

            If MsgBox("Esta Seguro de Asociar los Registros Seleccionados", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then

                '@01    A01
                If Not validarIntervaloValorLey() Then Exit Sub

                '@02    A01
                If pstrTipoMovimiento = "B" And Not validarAsociacionComponentesLiquidados() Then Exit Sub

                '@03    A01
                If Not validarAsociacionRumasPeriodoNoCerrado() Then Exit Sub


                If Not validarAsociacionRumasPRL() Then Exit Sub

                '@04    A01
                If pstrTipoMovimiento = "P" And Not validarDisponibilidadAsociacion() Then Exit Sub

                'Dim r As C1.Win.C1FlexGrid.Row
                Dim i As Integer
                Dim sLoteOrigen As String = ""

                'Dim dato As String
                For i = 0 To fxgrdTM.Rows.Count - 1
                    If fxgrdTM.Rows(i).Selected And fxgrdTM.Rows(i).Visible Then
                        oMovimientoTX.NuevaEntidad()

                        'Valida que solo se puedan asocuiar del mismo blend
                        If pstrTipoMovimiento = "B" Then
                            If sLoteOrigen = "" Then
                                sLoteOrigen = RTrim(fxgrdTM.Rows(i).Item("Ruma Origen"))
                            End If
                            If sLoteOrigen <> RTrim(fxgrdTM.Rows(i).Item("Ruma Origen")) Then
                                pAsociar = False
                                pdtLiquidacion.Rows.Clear()

                                oMovimientoTX.LstLogisticaMovimiento.Clear()
                                MsgBox("Solo se pueden asociar rumas de la misma mezclas", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                                Exit Sub
                            End If
                            sLoteOrigen = RTrim(fxgrdTM.Rows(i).Item("Ruma Origen"))
                        End If

                        With oMovimientoTX.oBELogisticaMovimiento
                            .ID = fxgrdTM.Rows(i).Item("id")
                            '.EstadoVCM = "1"
                            .EstadoVCM = "3"
                            .ContratoLoteId = pstrCorrelativo
                            .LiquidacionId = ""
                            .LiquidacionTmId = ""
                            '.LiquidacionId = pstrCorrelativoLiquidacion
                            '.LiquidacionTmId = pstrCorrelativoLiquidacionTm
                            oMovimientoTX.LstLogisticaMovimiento.Add(oMovimientoTX.oBELogisticaMovimiento)
                        End With

                        dRowLiquidacion = pdtLiquidacion.NewRow
                        dRowLiquidacion("liquidacionTmId") = ""
                        dRowLiquidacion("id") = fxgrdTM.Rows(i).Item("id")
                        dRowLiquidacion("tmh") = fxgrdTM.Rows(i).Item("tmh")
                        dRowLiquidacion("h2o") = SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(fxgrdTM.Rows(i).Item("h2o")).GetValueOrDefault
                        dRowLiquidacion("tms") = dRowLiquidacion("tmh") * (100 - dRowLiquidacion("h2o")) / 100 ' MH 0112011
                        dRowLiquidacion("tmsn") = dRowLiquidacion("tms") * (100 - pdblMerma) / 100 'fxgrdTM.Rows(r.Index).Item("tmsn")' MH 0112011
                        dRowLiquidacion("merma") = pdblMerma
                        dRowLiquidacion("codigolote") = fxgrdTM.Rows(i).Item("Ruma Actual")
                        dRowLiquidacion("guia") = fxgrdTM.Rows(i).Item("NRO_GUIAT")
                        dRowLiquidacion("ticket") = fxgrdTM.Rows(i).Item("TICKET")
                        dRowLiquidacion("fecha_ingreso") = SI.UT.clsUT_Funcion.FechaNullVista(fxgrdTM.Rows(i).Item("Recepcion"))



                        dRowLiquidacion("PagCu") = fxgrdTM.Rows(i).Item("Cu%")
                        dRowLiquidacion("PagAg") = fxgrdTM.Rows(i).Item("LEY_AG")
                        dRowLiquidacion("PagAgOz") = Math.Round(fxgrdTM.Rows(i).Item("LEY_AG") / 31.1035 / 1.10231, 4)
                        dRowLiquidacion("PagAu") = fxgrdTM.Rows(i).Item("LEY_AU")
                        dRowLiquidacion("PagAuOz") = Math.Round(fxgrdTM.Rows(i).Item("LEY_AU") / 31.1035 / 1.10231, 4)
                        dRowLiquidacion("PenPb") = fxgrdTM.Rows(i).Item("Pb%")
                        dRowLiquidacion("PenZn") = fxgrdTM.Rows(i).Item("Zn%")
                        'dRowLiquidacion("PenSn") = fxgrdTM.Rows(i).Item("LEY_SN")
                        dRowLiquidacion("PenAs") = fxgrdTM.Rows(i).Item("As%")
                        dRowLiquidacion("PenSb") = fxgrdTM.Rows(i).Item("Sb%")
                        dRowLiquidacion("PenBi") = fxgrdTM.Rows(i).Item("Bi%")
                        dRowLiquidacion("PenHg") = fxgrdTM.Rows(i).Item("Hg-ppm")
                        dRowLiquidacion("PenSiO2") = fxgrdTM.Rows(i).Item("SiO2%")
                        dRowLiquidacion("Pen1") = fxgrdTM.Rows(i).Item("As+Sb%")
                        dRowLiquidacion("Pen2") = fxgrdTM.Rows(i).Item("Pb+Zn%")
                        dRowLiquidacion("periodo") = fxgrdTM.Rows(i).Item("cuota")


                        dRowLiquidacion("PenCl") = fxgrdTM.Rows(i).Item("PenCl")
                        dRowLiquidacion("PenCd") = fxgrdTM.Rows(i).Item("PenCd")
                        dRowLiquidacion("PenF") = fxgrdTM.Rows(i).Item("PenF")
                        dRowLiquidacion("PenS") = fxgrdTM.Rows(i).Item("PenS")
                        dRowLiquidacion("PenFe") = fxgrdTM.Rows(i).Item("PenFe")
                        dRowLiquidacion("PenAl203") = fxgrdTM.Rows(i).Item("PenAl203")
                        dRowLiquidacion("PenCo") = fxgrdTM.Rows(i).Item("PenCo")
                        dRowLiquidacion("PenMo") = fxgrdTM.Rows(i).Item("PenMo")
                        dRowLiquidacion("PenP") = fxgrdTM.Rows(i).Item("PenP")
                        dRowLiquidacion("Pen20") = fxgrdTM.Rows(i).Item("PenMn")
                        dRowLiquidacion("Pen21") = fxgrdTM.Rows(i).Item("Pen21")
                        dRowLiquidacion("Pen22") = fxgrdTM.Rows(i).Item("Pen22")
                        dRowLiquidacion("Pen23") = fxgrdTM.Rows(i).Item("Pen23")
                        dRowLiquidacion("Pen24") = fxgrdTM.Rows(i).Item("Pen24")
                        dRowLiquidacion("Pen25") = fxgrdTM.Rows(i).Item("Pen25")
                        dRowLiquidacion("Pen26") = fxgrdTM.Rows(i).Item("Pen26")
                        dRowLiquidacion("Pen27") = fxgrdTM.Rows(i).Item("Pen27")
                        dRowLiquidacion("Pen28") = fxgrdTM.Rows(i).Item("Pen28")
                        dRowLiquidacion("Pen29") = fxgrdTM.Rows(i).Item("Pen29")
                        dRowLiquidacion("Pen30") = fxgrdTM.Rows(i).Item("Pen30")


                        pdtLiquidacion.Rows.Add(dRowLiquidacion)
                        'dato = fxgrdTM.Rows(i).Item("id")

                        pAsociar = True

                    End If

                Next

                oMovimientoTX.oBE_AuditoriaD = New clsBE_AuditoriaD
                oMovimientoTX.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria


                If pstrTipoMovimiento = "V" Then
                Else
                    oMovimientoTX.ActualizaEstadoLogisticaMovimiento()
                End If

                'oMovimientoTX.ActualizaEstadoLogisticaMovimiento()

                Me.Dispose()



                'For Each r In fxgrdTM.Rows.Selected
                '    oMovimientoTX.NuevaEntidad()
                '    With oMovimientoTX.oBELogisticaMovimiento


                '        .ID = fxgrdTM.Rows(r.Index).Item("id")
                '        .EstadoVCM = "1"
                '        .ContratoLoteId = pstrCorrelativo
                '        .LiquidacionId = ""
                '        .LiquidacionTmId = ""
                '        '.LiquidacionId = pstrCorrelativoLiquidacion
                '        '.LiquidacionTmId = pstrCorrelativoLiquidacionTm
                '        oMovimientoTX.LstLogisticaMovimiento.Add(oMovimientoTX.oBELogisticaMovimiento)
                '    End With
                '    dRowLiquidacion = pdtLiquidacion.NewRow
                '    dRowLiquidacion("liquidacionTmId") = ""
                '    dRowLiquidacion("id") = fxgrdTM.Rows(r.Index).Item("id")
                '    dRowLiquidacion("tmh") = fxgrdTM.Rows(r.Index).Item("tmh_slc")
                '    dRowLiquidacion("h2o") = fxgrdTM.Rows(r.Index).Item("h2o")
                '    dRowLiquidacion("tms") = 0 ' dRowLiquidacion("tmh") * (100 - dRowLiquidacion("h2o")) / 100 ' MH 0112011
                '    dRowLiquidacion("tmsn") = 0 ' dRowLiquidacion("tms") * (100 - pdblMerma) / 100 'fxgrdTM.Rows(r.Index).Item("tmsn")' MH 0112011
                '    dRowLiquidacion("merma") = pdblMerma
                '    dRowLiquidacion("codigolote") = fxgrdTM.Rows(r.Index).Item("COD_LOTE")
                '    dRowLiquidacion("guia") = fxgrdTM.Rows(r.Index).Item("NRO_GUIAT")
                '    dRowLiquidacion("ticket") = fxgrdTM.Rows(r.Index).Item("TICKET")
                '    dRowLiquidacion("fecha_ingreso") = SI.UT.clsUT_Funcion.FechaNullVista(fxgrdTM.Rows(r.Index).Item("FECHA_APERTURA"))



                '    dRowLiquidacion("PagCu") = fxgrdTM.Rows(r.Index).Item("LEY_CU")
                '    dRowLiquidacion("PagAg") = fxgrdTM.Rows(r.Index).Item("LEY_AG")
                '    dRowLiquidacion("PagAu") = fxgrdTM.Rows(r.Index).Item("LEY_AU")
                '    dRowLiquidacion("PenPb") = fxgrdTM.Rows(r.Index).Item("LEY_PB")
                '    dRowLiquidacion("PenZn") = fxgrdTM.Rows(r.Index).Item("LEY_ZN")
                '    'dRowLiquidacion("PenSn") = fxgrdTM.Rows(r.Index).Item("LEY_SN")
                '    dRowLiquidacion("PenAs") = fxgrdTM.Rows(r.Index).Item("LEY_AS")
                '    dRowLiquidacion("PenSb") = fxgrdTM.Rows(r.Index).Item("LEY_SB")
                '    dRowLiquidacion("PenBi") = fxgrdTM.Rows(r.Index).Item("LEY_BI")
                '    dRowLiquidacion("PenHg") = fxgrdTM.Rows(r.Index).Item("LEY_HG")
                '    dRowLiquidacion("PenSiO2") = fxgrdTM.Rows(r.Index).Item("LEY_SIO2")
                '    dRowLiquidacion("Pen1") = fxgrdTM.Rows(r.Index).Item("LEY_AS_SB")
                '    dRowLiquidacion("Pen2") = fxgrdTM.Rows(r.Index).Item("LEY_ZN_PB")
                '    dRowLiquidacion("periodo") = fxgrdTM.Rows(r.Index).Item("periodo")

                '    pdtLiquidacion.Rows.Add(dRowLiquidacion)
                'Next
                '' For Each r In fxgrdTM.Rows.Selected
                ''For Each row As C1.Win.C1FlexGrid.Row In fxgrdTM.Rows.Selected

                '' Next
                ''For Each row As DataGridViewRow In dgvMantenimiento.SelectedRows

                ''Next
                'oMovimientoTX.ActualizaEstadoLogisticaMovimiento()
                'Me.Dispose()



            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    '@01    AINI
    Private Function validarIntervaloValorLey() As Boolean
        Dim validacion As Boolean = True
        Dim message As String = String.Empty

        'Obtenemos rumas seleccionadas
        For i = 0 To fxgrdTM.Rows.Count - 1
            If fxgrdTM.Rows(i).Selected And fxgrdTM.Rows(i).Visible Then
                If Not CDec(fxgrdTM.Rows(i).Item("CU%")) > 0 Or Not CDec(fxgrdTM.Rows(i).Item("H2O")) > 0 Then
                    message += Chr(10) & " - " & fxgrdTM.Rows(i).Item("Ruma Actual").ToString
                End If
            End If
        Next

        'Procesamos resultado
        If Not message = String.Empty Then
            validacion = False
            message = "Su selección contiene registros cuyos valores CU% y/o H20 no son mayores a cero." & _
                Chr(10) & "Revisar (Ruma Actual): " & message & Chr(10) & "No pueden ser asociados."
            MsgBox(message, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If

        Return validacion
    End Function
    '@01    AFIN

    '@02    AINI
    Private Function validarAsociacionComponentesLiquidados() As Boolean
        Dim validacion As Boolean = True
        Dim message As String = String.Empty

        'Obtenemos rumas seleccionadas
        For i = 0 To fxgrdTM.Rows.Count - 1
            If fxgrdTM.Rows(i).Selected And fxgrdTM.Rows(i).Visible Then
                Dim dt As DataTable = oMovimientoTX.validarLiquidacionRumasComponentes(fxgrdTM.Rows(i).Item("Ruma Origen").ToString)
                If Not dt Is Nothing Then
                    message += Chr(10) & Chr(10) & fxgrdTM.Rows(i).Item("Ruma Actual").ToString & " -" & fxgrdTM.Rows(i).Item("Ruma Origen").ToString & ":"
                    For j = 0 To dt.Rows.Count - 1
                        ' Lista de rumas no liquidadas y/o no lotizadas
                        message += Chr(10) & " - " & dt.Rows.Item(j).Item("COD_LOTE") & IIf(dt.Rows.Item(j).Item("ContratoLoteId").ToString = String.Empty, "(No lotizado)", "")
                    Next
                End If
            End If
        Next

        'Procesamos resultado
        If Not message = String.Empty Then
            validacion = False
            message = "Su selección (Despachos) contiene Rumas de compra no Liquidadas." & _
                Chr(10) & "Revisar: " & message & Chr(10) & "No pueden ser asociados."
            MsgBox(message, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If

        Return validacion
    End Function
    '@02    AFIN

    '@03    AINI
    Private Function validarAsociacionRumasPeriodoNoCerrado() As Boolean
        Dim validacion As Boolean = True
        Dim message As String = String.Empty

        'Obtenemos rumas seleccionadass
        For i = 0 To fxgrdTM.Rows.Count - 1
            If fxgrdTM.Rows(i).Selected And fxgrdTM.Rows(i).Visible Then

                Dim p As New clsBC_PeriodoRO
                Dim periodoDescription = CType(fxgrdTM.Rows(i).Item("Recepcion"), Date).Year.ToString & "-" & Microsoft.VisualBasic.Right("0" + CType(fxgrdTM.Rows(i).Item("Recepcion"), Date).Month.ToString, 2)

                If p.ValidaPeriodoCerrado(pstrEmpresa, periodoDescription.Replace("-", "")) Then
                    message += Chr(10) & fxgrdTM.Rows(i).Item("Ruma Actual").ToString & " [" & periodoDescription & "]"
                    validacion = False
                End If

            End If
        Next

        'Procesamos resultado
        If Not message = String.Empty Then
            validacion = False
            message = "Su selección contiene Rumas cuyos periodos (fecha de recepcion) estan cerrados." & _
                Chr(10) & "Revisar: " & Chr(10) & message & Chr(10) & "No pueden ser asociados."
            MsgBox(message, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If

        Return validacion
    End Function
    '@03    AFIN

    '@04    AINI
    Private Function validarDisponibilidadAsociacion() As Boolean
        Dim validacion As Boolean = True
        Dim message As String = String.Empty

        'Obtenemos rumas seleccionadas
        For i = 0 To fxgrdTM.Rows.Count - 1
            If fxgrdTM.Rows(i).Selected And fxgrdTM.Rows(i).Visible Then
                If Not oMovimientoTX.validarDisponibilidadAsociacion(fxgrdTM.Rows(i).Item("Ruma Actual").ToString) Then
                    message += Chr(10) & "-" & fxgrdTM.Rows(i).Item("Ruma Actual").ToString
                End If
            End If
        Next

        'Procesamos resultado
        If Not message = String.Empty Then
            validacion = False
            message = "Su selección contiene Rumas ya asociadas en su totalidad." & _
                Chr(10) & "Revisar: " & message & Chr(10) & "No pueden ser asociados."
            MsgBox(message, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If

        Return validacion
    End Function


    '20170922: No permite asociar rumas en periodos con preliquidacion
    Private Function validarAsociacionRumasPRL() As Boolean
        Dim validacion As Boolean = True
        Dim message As String = String.Empty

        Dim oBC_LiquidacionRO As New clsBC_LiquidacionRO
        Dim dtLiquidacion As DataTable

        With oBC_LiquidacionRO.oBELiquidacion
            .contratoLoteId = pstrCorrelativo
            .liquidacionId = pstrCorrelativoLiquidacion

            dtLiquidacion = oBC_LiquidacionRO.LeerListaToDSLiquidacion.Tables(0)

        End With


        'Obtenemos rumas seleccionadass
        For i = 0 To fxgrdTM.Rows.Count - 1
            If fxgrdTM.Rows(i).Selected And fxgrdTM.Rows(i).Visible Then

                Dim periodoDescription = CType(fxgrdTM.Rows(i).Item("Recepcion"), Date).Year.ToString & "-" & Microsoft.VisualBasic.Right("0" + CType(fxgrdTM.Rows(i).Item("Recepcion"), Date).Month.ToString, 2)

                If dtLiquidacion.Rows.Count > 0 Then



                    For Each row As DataRow In dtLiquidacion.Rows
                        'PRL y status!='E'
                        If row.Item("status") <> "E" And row.Item("codigoCalculo") = "PRL" Then
                            If periodoDescription = CType(row.Item("fechaRegistro"), Date).Year.ToString & "-" & Microsoft.VisualBasic.Right("0" + CType(row.Item("fechaRegistro"), Date).Month.ToString, 2) Then
                                message += Chr(10) & "-" & fxgrdTM.Rows(i).Item("Ruma Actual").ToString
                            End If
                        End If
                    Next
                End If

            End If
        Next

        'Procesamos resultado
        If Not message = String.Empty Then
            validacion = False
            message = "Su selección contiene Rumas cuyos periodos (fecha de recepcion) tiene PreLiquidaciones. Debe eliminar la Preliquidación." & _
                Chr(10) & "Revisar: " & Chr(10) & message & Chr(10) & "No pueden ser asociados."
            MsgBox(message, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If

        Return validacion




    End Function
    '@04    AFIN

    'Private Sub txtTMH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not String.IsNullOrEmpty(txtTMH.Text) Then
    '        Dim tmh As Double = CDbl(txtTMH.Text)
    '        dvwMovimiento.RowFilter = String.Format(CultureInfo.InvariantCulture.NumberFormat, "TMH_SLC >= {0}", tmh)
    '        '"TMH_SLC >= " & txtTMH.Text
    '    Else
    '        dvwMovimiento.RowFilter = ""
    '    End If
    'End Sub

    Private Sub fxgrdTM_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fxgrdTM.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.C
                    If e.Modifiers = Keys.Control Then
                        System.Windows.Forms.Clipboard.SetText(fxgrdTM.Clip)
                    End If
            End Select
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub fxgrdTM_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgrdTM.SelChange
        Dim dTMH As Double = 0
        Dim nCantidad As Integer = 0

        For i = 0 To fxgrdTM.Rows.Count - 1
            If fxgrdTM.Rows(i).Selected And fxgrdTM.Rows(i).Visible Then
                dTMH += fxgrdTM.Rows(i)("TMH")
                nCantidad += 1
            End If
        Next
        txtCantidad.Text = nCantidad
        txtSumaTMH.Text = dTMH

    End Sub
End Class