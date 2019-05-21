Imports SI.UT
Imports SI.BC
Imports System.Data
Imports SI.BE

Public Class frmFactura

    Public pdtLiquidacion As DataTable
    Public pAsociar As Boolean
    Public bGenerarFactura As Boolean

    Public pContratoloteid As String
    Public pLiquidacionId As String
    Public pPeriodo As String

    Public sTipoDocumentoValorado As String

    ' Esta variable tiene que ser publica
    Dim linea As Integer = 1
    Private nRedondear As Integer = 4

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        ' Definimos el tipo de fuente y de mas
        Dim Fuente As New Font("arial", 10)
        Dim posicion As Integer = 180
        Dim format1 As New StringFormat()
        format1.LineAlignment = StringAlignment.Center
        format1.Alignment = StringAlignment.Far

        Dim displayRectangle1 As New Rectangle

        Dim oLiquidacionRO As New clsBC_LiquidacionRO
        Dim dsLiquidacion As DataSet



        Dim nCantidadDigitos As Integer = 13
        Dim sDigitosMaximo As String = "            "

        Dim sDia As String
        Dim sMes As String
        Dim sAnio As String

        Dim sComDescripcion As String
        Dim sDireccion As String
        Dim sRuc As String

        Dim sConcepto As String
        Dim sValorTexto As String

        Dim sPrecioUnitario As String
        Dim sValorNeto As String
        Dim sValorImpuesto As String
        Dim sValorIGV As String
        Dim sValorTotal As String


        Dim sMontoNeto As String
        Dim sMontoIGV As String
        Dim sMontoNetoAPagar As String

        Dim sTMH As String
        Dim sTMNS As String


        'Nota de credito / debito
        Dim sDia_Factura As String
        Dim sMes_Factura As String
        Dim sAnio_Factura As String
        Dim sNumero_Factura As String

        Dim sMotivo As String
        Dim sMotivo1 As String
        Dim sMotivo2 As String
        Dim sDenominacion_Factura As String
        'Dim sNumeroFactura As String


        'Obtien los datos a facturar
        With oLiquidacionRO.oBELiquidacion
            .contratoLoteId = pContratoloteid
            .liquidacionId = pLiquidacionId

            oLiquidacionRO.LeerLiquidacuibToDSFactura()
            dsLiquidacion = oLiquidacionRO.oDSLiquidacion
        End With


        If dsLiquidacion.Tables(0).Rows.Count > 0 Then
            sDia = dsLiquidacion.Tables(0).Rows(0)("dia").ToString
            sMes = dsLiquidacion.Tables(0).Rows(0)("mes").ToString
            sAnio = dsLiquidacion.Tables(0).Rows(0)("anio").ToString

            sComDescripcion = dsLiquidacion.Tables(0).Rows(0)("ComDescripcion").ToString
            sDireccion = dsLiquidacion.Tables(0).Rows(0)("ComDireccion").ToString
            sRuc = dsLiquidacion.Tables(0).Rows(0)("ComRUC").ToString

            sConcepto = dsLiquidacion.Tables(0).Rows(0)("Concepto").ToString
            sValorTexto = dsLiquidacion.Tables(0).Rows(0)("valorTexto").ToString

            sPrecioUnitario = dsLiquidacion.Tables(0).Rows(0)("PrecioUnitario").ToString
            sValorNeto = dsLiquidacion.Tables(0).Rows(0)("ValorNeto").ToString

            sValorImpuesto = dsLiquidacion.Tables(0).Rows(0)("ValorImpuesto").ToString
            sValorIGV = dsLiquidacion.Tables(0).Rows(0)("ValorIgv").ToString
            sValorTotal = dsLiquidacion.Tables(0).Rows(0)("ValorTotal").ToString

            sTMH = dsLiquidacion.Tables(0).Rows(0)("calculoTMH").ToString
            sTMNS = dsLiquidacion.Tables(0).Rows(0)("calculoTMSN").ToString



            sMontoNeto = dsLiquidacion.Tables(0).Rows(0)("montoNeto").ToString
            sMontoIGV = dsLiquidacion.Tables(0).Rows(0)("montoIGV").ToString
            sMontoNetoAPagar = dsLiquidacion.Tables(0).Rows(0)("MontoNetoAPagar").ToString


            'sNumero_Factura = dsLiquidacion.Tables(0).Rows(0)("NumeroFactura").ToString
            'sDenominacion_Factura = dsLiquidacion.Tables(0).Rows(0)("denominacion").ToString
        End If

        'obtiene los datos de la factura para las notas de creditos y debito
        If dsLiquidacion.Tables(1).Rows.Count > 0 Then
            sDia_Factura = dsLiquidacion.Tables(1).Rows(0)("diaFactura").ToString
            sMes_Factura = dsLiquidacion.Tables(1).Rows(0)("mesFactura").ToString
            sAnio_Factura = dsLiquidacion.Tables(1).Rows(0)("anioFactura").ToString

            sDenominacion_Factura = dsLiquidacion.Tables(1).Rows(0)("Denominacion").ToString
            sNumero_Factura = dsLiquidacion.Tables(1).Rows(0)("numeroDocumento").ToString

            'sMotivo = dsLiquidacion.Tables(1).Rows(0)("Motivo").ToString
            sMotivo1 = dsLiquidacion.Tables(1).Rows(0)("Motivo1").ToString
            sMotivo2 = dsLiquidacion.Tables(1).Rows(0)("Motivo2").ToString
        End If


        'sPrecioUnitario = sDigitosMaximo & Format(CDbl(sPrecioUnitario), "##,##0.00") 'FormatCurrency(sPrecioUnitario, 2)
        sPrecioUnitario = "  " & Format(CDbl(sPrecioUnitario), "##,##0.00") 'FormatCurrency(sPrecioUnitario, 2)
        sValorNeto = sDigitosMaximo & Format(CDbl(sValorNeto), "##,##0.00") 'FormatCurrency(sValorNeto, 2)
        sValorIGV = sDigitosMaximo & Format(CDbl(sValorIGV), "##,##0.00") ' FormatCurrency(sValorIGV, 2)
        sValorTotal = sDigitosMaximo & Format(CDbl(sValorTotal), "##,##0.00") 'FormatCurrency(sValorTotal, 2)


        sMontoNeto = sDigitosMaximo & Format(CDbl(sMontoNeto), "##,##0.00") 'FormatCurrency(sMontoNeto, 2)
        sMontoIGV = sDigitosMaximo & Format(CDbl(sMontoIGV), "##,##0.00") 'FormatCurrency(sMontoIGV, 2)
        sMontoNetoAPagar = sDigitosMaximo & Format(CDbl(sMontoNetoAPagar), "##,##0.00") 'FormatCurrency(sMontoNetoAPagar, 2)


        'formato de dolares
        'sPrecioUnitario = "$" & sPrecioUnitario.ToString().Substring(Len(sPrecioUnitario) - nCantidadDigitos, nCantidadDigitos)
        sPrecioUnitario = "$" & sPrecioUnitario '.ToString().Substring(Len(sPrecioUnitario) - nCantidadDigitos, nCantidadDigitos)
        sValorNeto = "$" & sValorNeto.ToString().Substring(Len(sValorNeto) - nCantidadDigitos, nCantidadDigitos)

        sValorIGV = "$" & sValorIGV.ToString().Substring(Len(sValorIGV) - nCantidadDigitos, nCantidadDigitos)
        sValorTotal = "$" & sValorTotal.ToString().Substring(Len(sValorTotal) - nCantidadDigitos, nCantidadDigitos)


        sMontoNeto = "$" & sMontoNeto.ToString().Substring(Len(sMontoNeto) - nCantidadDigitos, nCantidadDigitos)
        sMontoIGV = "$" & sMontoIGV.ToString().Substring(Len(sMontoIGV) - nCantidadDigitos, nCantidadDigitos)
        sMontoNetoAPagar = "$" & sMontoNetoAPagar.ToString().Substring(Len(sMontoNetoAPagar) - nCantidadDigitos, nCantidadDigitos)



        ''sPrecioUnitario = sDigitosMaximo & FormatCurrency(sPrecioUnitario, 2)
        ''sValorNeto = sDigitosMaximo & FormatCurrency(sValorNeto, 2)
        ''sValorIGV = sDigitosMaximo & FormatCurrency(sValorIGV, 2)
        ''sValorTotal = sDigitosMaximo & FormatCurrency(sValorTotal, 2)


        ''sMontoNeto = sDigitosMaximo & FormatCurrency(sMontoNeto, 2)
        ''sMontoIGV = sDigitosMaximo & FormatCurrency(sMontoIGV, 2)
        ''sMontoNetoAPagar = sDigitosMaximo & FormatCurrency(sMontoNetoAPagar, 2)


        ''sPrecioUnitario = sPrecioUnitario.ToString().Substring(Len(sPrecioUnitario) - nCantidadDigitos, nCantidadDigitos)
        ''sValorNeto = sValorNeto.ToString().Substring(Len(sValorNeto) - nCantidadDigitos, nCantidadDigitos)

        ''sValorIGV = sValorIGV.ToString().Substring(Len(sValorIGV) - nCantidadDigitos, nCantidadDigitos)
        ''sValorTotal = sValorTotal.ToString().Substring(Len(sValorTotal) - nCantidadDigitos, nCantidadDigitos)

       
        If sTipoDocumentoValorado = "FT" Then
            displayRectangle1 = New Rectangle(New Point(150, posicion + 690), New Size(400, 100))
            e.Graphics.DrawRectangle(Pens.White, displayRectangle1)

            'e.Graphics.DrawString("Fecha", Fuente, Brushes.Black, 50, posicion + 10)
            e.Graphics.DrawString(sDia, Fuente, Brushes.Black, 90, posicion + 10)
            e.Graphics.DrawString(sMes, Fuente, Brushes.Black, 170, posicion + 10)
            e.Graphics.DrawString(sAnio.Substring(2, 2), Fuente, Brushes.Black, 370, posicion + 10)

            e.Graphics.DrawString(sComDescripcion, Fuente, Brushes.Black, 150, posicion + 40)
            e.Graphics.DrawString(sDireccion, Fuente, Brushes.Black, 150, posicion + 70)
            e.Graphics.DrawString(sRuc, Fuente, Brushes.Black, 150, posicion + 100)

            e.Graphics.DrawString(sPrecioUnitario, Fuente, Brushes.Black, 650, posicion + 180, format1)
            e.Graphics.DrawString(sValorNeto, Fuente, Brushes.Black, 780, posicion + 180, format1)
            e.Graphics.DrawString(sConcepto, Fuente, Brushes.Black, 150, posicion + 180)


            ' ''adelantos
            ''Dim oLiquidacionDsctoRO As New clsBC_LiquidacionDsctoRO
            ''Dim dsLiquidacionDscto As DataSet
            ''Dim sAdelantoFactura As String

            ''oLiquidacionDsctoRO.oBELiquidacionDscto = New clsBE_LiquidacionDscto
            ''oLiquidacionDsctoRO.oBELiquidacionDscto.contratoLoteId = pContratoloteid
            ''oLiquidacionDsctoRO.oBELiquidacionDscto.liquidacionId = pLiquidacionId
            ''oLiquidacionDsctoRO.oBELiquidacionDscto.liquidacionDsctoId = "" 'pstrCorrelativoLiquidacionDscto
            ' ''oLiquidacionDsctoRO.oBELiquidacionDscto.codigoDscto = "AdelantoFactura"
            ''oLiquidacionDsctoRO.oBELiquidacionDscto.codigoDscto = "Adelanto"
            ''dsLiquidacionDscto = oLiquidacionDsctoRO.LeerListaToDSLiquidacionDscto

            ''If dsLiquidacionDscto.Tables(0).Rows.Count > 0 Then
            ''    For i = 0 To dsLiquidacionDscto.Tables(0).Rows.Count - 1
            ''        sAdelantoFactura = "Adelanto de Factura " & dsLiquidacionDscto.Tables(0).Rows(i)("descri").ToString() & " emitida el " & dsLiquidacionDscto.Tables(0).Rows(i)("observa").ToString()
            ''        e.Graphics.DrawString(sAdelantoFactura, Fuente, Brushes.Black, 150, posicion + 350 + (i + 1) * 20)

            ''        sAdelantoFactura = dsLiquidacionDscto.Tables(0).Rows(i)("importe").ToString()
            ''        e.Graphics.DrawString(sDigitosMaximo & FormatCurrency(sAdelantoFactura, 2), Fuente, Brushes.Black, 780, posicion + 350 + (i + 1) * 20, format1)
            ''    Next
            ''End If


            'adelantos
            Dim oTB_PROVIPREVRO As New clsBC_TB_PROVIPREVRO
            Dim dsTB_PROVIPREVRO As DataSet
            Dim sAdelantoFactura As String

            oTB_PROVIPREVRO.oBETB_PROVIPREV = New clsBE_TB_PROVIPREV
            oTB_PROVIPREVRO.oBETB_PROVIPREV.pContratoloteId = pContratoloteid
            oTB_PROVIPREVRO.oBETB_PROVIPREV.pLiquidacionId = pLiquidacionId
            oTB_PROVIPREVRO.LeerListaToDSPROVIPREV_ADELANTOS()

            dsTB_PROVIPREVRO = oTB_PROVIPREVRO.oDSTB_PROVIPREV

            If dsTB_PROVIPREVRO.Tables(0).Rows.Count > 0 Then
                For i = 0 To dsTB_PROVIPREVRO.Tables(0).Rows.Count - 1
                    sAdelantoFactura = "Adelanto de Factura " & dsTB_PROVIPREVRO.Tables(0).Rows(i)("TIPO_COMPR").ToString() & dsTB_PROVIPREVRO.Tables(0).Rows(i)("NUM_COMPR").ToString() & " emitida el " & dsTB_PROVIPREVRO.Tables(0).Rows(i)("FCH_COMPR") '.ToString()
                    e.Graphics.DrawString(sAdelantoFactura, Fuente, Brushes.Black, 150, posicion + 350 + (i + 1) * 20)

                    sAdelantoFactura = dsTB_PROVIPREVRO.Tables(0).Rows(i)("MONTO_LIQ").ToString()
                    e.Graphics.DrawString("-$" & sDigitosMaximo & FormatNumber(sAdelantoFactura, 2), Fuente, Brushes.Black, 780, posicion + 350 + (i + 1) * 20, format1)
                Next
            End If


            e.Graphics.DrawString(sValorTexto, Fuente, Brushes.Black, RectangleF.op_Implicit(displayRectangle1))

            ''e.Graphics.DrawString(sValorImpuesto, Fuente, Brushes.Black, 630, posicion + 810, format1)
            ''e.Graphics.DrawString(sValorNeto, Fuente, Brushes.Black, 780, posicion + 780, format1)
            ''e.Graphics.DrawString(sValorIGV, Fuente, Brushes.Black, 780, posicion + 810, format1)
            ''e.Graphics.DrawString(sValorTotal, Fuente, Brushes.Black, 780, posicion + 840, format1)


            e.Graphics.DrawString(sValorImpuesto, Fuente, Brushes.Black, 630, posicion + 810, format1)
            e.Graphics.DrawString(sMontoNeto, Fuente, Brushes.Black, 780, posicion + 780, format1)
            e.Graphics.DrawString(sMontoIGV, Fuente, Brushes.Black, 780, posicion + 810, format1)
            e.Graphics.DrawString(sMontoNetoAPagar, Fuente, Brushes.Black, 780, posicion + 840, format1)

        Else
            posicion = 200



            displayRectangle1 = New Rectangle(New Point(140, posicion + 200), New Size(400, 100))
            e.Graphics.DrawRectangle(Pens.White, displayRectangle1)

            'e.Graphics.DrawString("Fecha", Fuente, Brushes.Black, 50, posicion + 10)
            e.Graphics.DrawString(sDia, Fuente, Brushes.Black, 70, posicion - 60)
            e.Graphics.DrawString(sMes, Fuente, Brushes.Black, 150, posicion - 60)
            e.Graphics.DrawString(sAnio, Fuente, Brushes.Black, 280, posicion - 60)

            e.Graphics.DrawString(sComDescripcion, Fuente, Brushes.Black, 110, posicion - 32)
            e.Graphics.DrawString(sDireccion, Fuente, Brushes.Black, 110, posicion + -12)
            e.Graphics.DrawString(sRuc, Fuente, Brushes.Black, 110, posicion + 13)

            'datos de la factura
            e.Graphics.DrawString(sDenominacion_Factura, Fuente, Brushes.Black, 600, posicion + -12)
            e.Graphics.DrawString(sNumero_Factura, Fuente, Brushes.Black, 530, posicion + 13)







            ''e.Graphics.DrawString(sDia_Factura, Fuente, Brushes.Black, 690, posicion + 13)
            ''e.Graphics.DrawString(sMes_Factura, Fuente, Brushes.Black, 730, posicion + 13)
            ''e.Graphics.DrawString(sAnio_Factura, Fuente, Brushes.Black, 760, posicion + 13)



            e.Graphics.DrawString(sDia_Factura, Fuente, Brushes.Black, 680, posicion + 13)
            e.Graphics.DrawString(sMes_Factura, Fuente, Brushes.Black, 720, posicion + 13)
            e.Graphics.DrawString(sAnio_Factura, Fuente, Brushes.Black, 750, posicion + 13)



            'e.Graphics.DrawString(sPrecioUnitario, Fuente, Brushes.Black, 650, posicion + 160, format1)
            e.Graphics.DrawString(sMontoNeto, Fuente, Brushes.Black, 790, posicion + 100, format1)
            e.Graphics.DrawString(sConcepto & " con PU " & sPrecioUnitario, Fuente, Brushes.Black, 140, posicion + 90)

            'e.Graphics.DrawString(sMotivo, Fuente, Brushes.Black, 150, posicion + 310)
            e.Graphics.DrawString(sMotivo1, Fuente, Brushes.Black, 370, posicion + 273)
            e.Graphics.DrawString(sMotivo2, Fuente, Brushes.Black, 200, posicion + 288)

            e.Graphics.DrawString(sValorTexto, Fuente, Brushes.Black, RectangleF.op_Implicit(displayRectangle1))

            ''e.Graphics.DrawString(sValorImpuesto, Fuente, Brushes.Black, 650, posicion + 420, format1)
            ''e.Graphics.DrawString(sValorNeto, Fuente, Brushes.Black, 780, posicion + 390, format1)
            ''e.Graphics.DrawString(sValorIGV, Fuente, Brushes.Black, 780, posicion + 420, format1)
            ''e.Graphics.DrawString(sValorTotal, Fuente, Brushes.Black, 780, posicion + 450, format1)


            e.Graphics.DrawString(sValorImpuesto, Fuente, Brushes.Black, 640, posicion + 315, format1)
            e.Graphics.DrawString(sMontoNeto, Fuente, Brushes.Black, 790, posicion + 285, format1)
            e.Graphics.DrawString(sMontoIGV, Fuente, Brushes.Black, 790, posicion + 315, format1)
            e.Graphics.DrawString(sMontoNetoAPagar, Fuente, Brushes.Black, 790, posicion + 340, format1)
        End If


        ''If salto_pagina = True Then
        ''    e.HasMorePages = True
        ''Else
        ''    e.HasMorePages = False
        ''End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDocument1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If ValidarLiquidacion() Then

            Dim dRowLiquidacion As DataRow


            If pdtLiquidacion Is Nothing Then
                Dim oliquidacionTmRO As New clsBC_LiquidacionTmRO
                pdtLiquidacion = oliquidacionTmRO.DefineTablaLiquidacionTm
            End If

            dRowLiquidacion = pdtLiquidacion.NewRow
            dRowLiquidacion("liquidacionTmId") = ""
            dRowLiquidacion("id") = 0 '
            dRowLiquidacion("tmh") = txtTMHCalculado.Text  'fxgrdTM.Rows(i).Item("tmh")
            dRowLiquidacion("h2o") = txtH2OCalculado.Text ' SI.UT.clsUT_Funcion.DbValueToNullable(Of Double)(fxgrdTM.Rows(i).Item("h2o")).GetValueOrDefault
            dRowLiquidacion("tms") = txtTMSCalculado.Text ' H.Text * (100 - txtH20.Text) / 100 'dRowLiquidacion("tmh") * (100 - dRowLiquidacion("h2o")) / 100 ' MH 0112011
            dRowLiquidacion("tmsn") = txtTMNSCalculado.Text  '.Text * (100 - txtH20.Text) / 100 * (100 - nupdMerma.Value) / 100 'dRowLiquidacion("tms") * (100 - pdblMerma) / 100 'fxgrdTM.Rows(r.Index).Item("tmsn")' MH 0112011
            dRowLiquidacion("merma") = txtMermaCalculado.Text
            dRowLiquidacion("codigolote") = "RUMA" ' DTIM1301-000" ' fxgrdTM.Rows(i).Item("Ruma Actual")
            dRowLiquidacion("guia") = "0" 'fxgrdTM.Rows(i).Item("NRO_GUIAT")
            dRowLiquidacion("ticket") = "0" ' fxgrdTM.Rows(i).Item("TICKET")
            dRowLiquidacion("fecha_ingreso") = dtpFecha_ingreso.Text  'Now.Date ' SI.UT.clsUT_Funcion.FechaNullVista(fxgrdTM.Rows(i).Item("Recepcion"))

            dRowLiquidacion("PagCu") = txtCUCalculado.Text ' fxgrdTM.Rows(i).Item("Cu%")
            dRowLiquidacion("PagAg") = Math.Round(txtAGCalculado.Text * 31.1035 * 1.10231, 4) ' Math.Round(txtAGCalculado.Text / 31.1035 / 1.10231, 4) 'txtAG.Text '  fxgrdTM.Rows(i).Item("LEY_AG")
            dRowLiquidacion("PagAgOz") = txtAG.Text ' Math.Round(txtAG.Text / 31.1035 / 1.10231, 4)
            dRowLiquidacion("PagAu") = Math.Round(txtAUCalculado.Text * 31.1035 * 1.10231, 4) ' Math.Round(txtAUCalculado.Text / 31.1035 / 1.10231, 4) '  txtAU.Text 'fxgrdTM.Rows(i).Item("LEY_AU")
            dRowLiquidacion("PagAuOz") = txtAUCalculado.Text 'Math.Round(txtAU.Text / 31.1035 / 1.10231, 4)
            dRowLiquidacion("PenPb") = txtPBCalculado.Text 'fxgrdTM.Rows(i).Item("Pb%")
            dRowLiquidacion("PenZn") = txtZNCalculado.Text 'fxgrdTM.Rows(i).Item("Zn%")
            'dRowLiquidacion("PenSn") = fxgrdTM.Rows(i).Item("LEY_SN")
            dRowLiquidacion("PenAs") = txtASCalculado.Text  '0 'fxgrdTM.Rows(i).Item("As%")
            dRowLiquidacion("PenSb") = txtSBCalculado.Text  '0 'fxgrdTM.Rows(i).Item("Sb%")
            dRowLiquidacion("PenBi") = txtBICalculado.Text  '0 'fxgrdTM.Rows(i).Item("Bi%")
            dRowLiquidacion("PenHg") = txtHGCalculado.Text  '0 'fxgrdTM.Rows(i).Item("Hg-ppm")
            dRowLiquidacion("PenSiO2") = txtSIO2Calculado.Text  '0 'fxgrdTM.Rows(i).Item("SiO2%")
            dRowLiquidacion("Pen1") = CDec(txtASCalculado.Text) + CDec(txtSBCalculado.Text) '0 'fxgrdTM.Rows(i).Item("As+Sb%")
            dRowLiquidacion("Pen2") = CDec(txtZNCalculado.Text) + CDec(txtPBCalculado.Text) '0 'fxgrdTM.Rows(i).Item("Pb+Zn%")
            'dRowLiquidacion("periodo") = pPeriodo '"" 'fxgrdTM.Rows(i).Item("cuota")



            dRowLiquidacion("PenCl") = txtClCalculado.Text
            dRowLiquidacion("PenCd") = txtCdCalculado.Text
            dRowLiquidacion("PenF") = txtFCalculado.Text
            dRowLiquidacion("PenS") = txtSCalculado.Text
            dRowLiquidacion("PenFe") = txtFeCalculado.Text
            dRowLiquidacion("PenAl203") = txtAl203Calculado.Text
            dRowLiquidacion("PenCo") = txtCoCalculado.Text
            dRowLiquidacion("PenMo") = txtMoCalculado.Text
            dRowLiquidacion("PenP") = txtPCalculado.Text
            dRowLiquidacion("Pen20") = 0 ' txt20Calculado.Text
            dRowLiquidacion("Pen21") = 0 'txt21Calculado.Text
            dRowLiquidacion("Pen22") = 0 ' txt22Calculado.Text
            dRowLiquidacion("Pen23") = 0 ' txt23Calculado.Text
            dRowLiquidacion("Pen24") = 0 ' txt24Calculado.Text
            dRowLiquidacion("Pen25") = 0 ' txt25Calculado.Text
            dRowLiquidacion("Pen26") = 0 ' txt26Calculado.Text
            dRowLiquidacion("Pen27") = 0 ' txt27Calculado.Text
            dRowLiquidacion("Pen28") = 0 ' txt28Calculado.Text
            dRowLiquidacion("Pen29") = 0 ' txt29Calculado.Text
            dRowLiquidacion("Pen30") = 0 ' txt30Calculado.Text


            pdtLiquidacion.Rows.Add(dRowLiquidacion)
            'dato = fxgrdTM.Rows(i).Item("id")

            pAsociar = True
        End If

        Me.Dispose()
    End Sub

    Private Shared Sub resaltarobjecto(ByVal cbo As ComboBox)
        If cbo.BackColor <> Color.Orange Then
            cbo.BackColor = Color.Khaki
        Else
            cbo.BackColor = Color.White
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal txt As TextBox)
        If txt.BackColor <> Color.Orange Then
            txt.BackColor = Color.Khaki
        Else
            txt.BackColor = Color.White
        End If
    End Sub
    Private Shared Sub resaltarobjecto(ByVal nupd As NumericUpDown)
        If nupd.BackColor <> Color.Orange Then
            nupd.BackColor = Color.Khaki
        Else
            nupd.BackColor = Color.White
        End If
    End Sub

    Private Function ValidarLiquidacion()
        Dim strmensaje As String = ""
        'If txtMerma.Value < 0 Then
        '    strmensaje = strmensaje & "* Ingrese Merma" & vbCrLf
        '    resaltarobjecto(nupdMerma)
        'End If

        If String.IsNullOrEmpty(txtTMH.Text) Then
            strmensaje = strmensaje & "* Ingrese TMH" & vbCrLf
            resaltarobjecto(txtTMH)
        End If
        If String.IsNullOrEmpty(txtH20.Text) Then
            strmensaje = strmensaje & "* Ingrese H2O" & vbCrLf
            resaltarobjecto(txtH20)
        End If
        If String.IsNullOrEmpty(txtCU.Text) Then
            strmensaje = strmensaje & "* Ingrese CU" & vbCrLf
            resaltarobjecto(txtCU)
        End If
        If String.IsNullOrEmpty(txtAG.Text) Then
            strmensaje = strmensaje & "* Ingrese AG" & vbCrLf
            resaltarobjecto(txtAG)
        End If
        If String.IsNullOrEmpty(txtAU.Text) Then
            strmensaje = strmensaje & "* Ingrese AU"
            resaltarobjecto(txtAU)
        End If

        If strmensaje.Length > 0 Then
            MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Valorizador de Minerales")
            Return False
        End If
        Return True
    End Function

    Private Sub txtTMH_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTMH.TextChanged, txtH20.TextChanged, txtTMHCalculado.TextChanged, txtH2OCalculado.TextChanged, txtTMHActual.TextChanged, txtH2OActual.TextChanged
        If txtH20.Text <> "" And txtTMH.Text <> "" Then

            txtTMS.Text = FormatNumber(txtTMH.Text * (100 - txtH20.Text) / 100, 3)

            If txtTMHActual.Text <> "" And txtH2OActual.Text <> "" Then
                Dim dTMH As Double
                Dim dH2O As Double

                ' ''Valores calculados
                ''dTMH = FormatNumber(CDbl(txtTMH.Text) + CDbl(txtTMHActual.Text), 3)
                ''dH2O = FormatNumber((CDbl(txtTMH.Text) * CDbl(txtH20.Text) + CDbl(txtTMHActual.Text) * CDbl(txtH2OActual.Text)) / dTMH, 3)

                ''txtTMHCalculado.Text = FormatNumber(CDbl(txtTMH.Text) - CDbl(txtTMHActual.Text), 3)
                ''txtH2OCalculado.Text = dH2O
                ''txtTMSCalculado.Text = FormatNumber(txtTMHCalculado.Text * (100 - txtH2OCalculado.Text) / 100, 3)


                'Valores calculados
                dTMH = FormatNumber(CDbl(txtTMH.Text) + CDbl(txtTMHActual.Text), nRedondear)
                txtTMHCalculado.Text = FormatNumber(CDbl(txtTMH.Text) - CDbl(txtTMHActual.Text), nRedondear)
                
                dH2O = FormatNumber(((CDbl(txtH20.Text) * CDbl(txtTMH.Text)) - (CDbl(txtTMHActual.Text) * CDbl(txtH2OActual.Text))) / CDbl(txtTMHCalculado.Text), nRedondear)
                txtH2OCalculado.Text = dH2O
                txtTMSCalculado.Text = FormatNumber(CDbl(txtTMHCalculado.Text) * (100 - dH2O) / 100, 3)

                calculaLeyes()

            End If

        End If

    End Sub

    Private Sub txtTMS_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTMS.TextChanged, txtMerma.TextChanged, txtTMSCalculado.TextChanged, txtMermaCalculado.TextChanged, txtTMSActual.TextChanged, txtMermaActual.TextChanged
        If txtMerma.Text <> "" And txtTMS.Text <> "" Then
            txtTMSN.Text = FormatNumber(txtTMS.Text * (100 - txtMerma.Text) / 100, nRedondear)

            If txtMermaCalculado.Text <> "" And txtTMSCalculado.Text <> "" Then
                txtTMNSCalculado.Text = FormatNumber(txtTMSCalculado.Text * (100 - txtMermaCalculado.Text) / 100, nRedondear)
            End If

        End If
    End Sub

    Private Sub calculaLeyes()
        Dim dLeyCalculado As Double
        Dim dTMS As Double

        If txtTMS.Text <> "" And txtTMSActual.Text <> "" Then


            dTMS = FormatNumber(CDbl(txtTMS.Text) + CDbl(txtTMSActual.Text), nRedondear)

            If dTMS > 0 Then
                ''dLeyCalculado = FormatNumber((CDbl(txtTMS.Text) * CDbl(txtCU.Text) + CDbl(txtTMSActual.Text) * CDbl(txtCUActual.Text)) / dTMS, nRedondear)
                ''txtCUCalculado.Text = dLeyCalculado

                ''dLeyCalculado = FormatNumber((CDbl(txtTMS.Text) * CDbl(txtAU.Text) + CDbl(txtTMSActual.Text) * CDbl(txtAUActual.Text)) / dTMS, nRedondear)
                ''txtAUCalculado.Text = dLeyCalculado

                ''dLeyCalculado = FormatNumber((CDbl(txtTMS.Text) * CDbl(txtAG.Text) + CDbl(txtTMSActual.Text) * CDbl(txtAGActual.Text)) / dTMS, nRedondear)
                ''txtAGCalculado.Text = dLeyCalculado

                'Valores calculados
                'dTMH = FormatNumber(CDbl(txtTMH.Text) + CDbl(txtTMHActual.Text), nRedondear)
                'txtTMHCalculado.Text = FormatNumber(CDbl(txtTMH.Text) - CDbl(txtTMHActual.Text), nRedondear)

                'Pagables
                If txtCU.Text <> "" And txtCUActual.Text <> "" And txtCU.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtCU.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtCUActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtCUCalculado.Text = dLeyCalculado
                End If

                If txtAU.Text <> "" And txtAUActual.Text <> "" And txtAU.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtAU.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtAUActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtAUCalculado.Text = dLeyCalculado
                End If

                If txtAG.Text <> "" And txtAGActual.Text <> "" And txtAG.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtAG.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtAGActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtAGCalculado.Text = dLeyCalculado
                End If

                If txtZN.Text <> "" And txtZNActual.Text <> "" And txtZN.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtZN.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtZNActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtZNCalculado.Text = dLeyCalculado
                End If

                If txtPB.Text <> "" And txtPBActual.Text <> "" And txtPB.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtPB.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtPBActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtPBCalculado.Text = dLeyCalculado
                End If


                'Penalizables
                If txtAS.Text <> "" And txtASActual.Text <> "" And txtAS.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtAS.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtASActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtASCalculado.Text = dLeyCalculado
                End If

                If txtSB.Text <> "" And txtSBActual.Text <> "" And txtSB.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtSB.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtSBActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtSBCalculado.Text = dLeyCalculado
                End If

                If txtBI.Text <> "" And txtBIActual.Text <> "" And txtBI.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtBI.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtBIActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtBICalculado.Text = dLeyCalculado
                End If

                If txtSIO2.Text <> "" And txtSIO2Actual.Text <> "" And txtSIO2.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtSIO2.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtSIO2Actual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtSIO2Calculado.Text = dLeyCalculado
                End If

                If txtHG.Text <> "" And txtHGActual.Text <> "" And txtHG.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtHG.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtHGActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtHGCalculado.Text = dLeyCalculado
                End If





                If txtCl.Text <> "" And txtClActual.Text <> "" And txtCl.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtCl.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtClActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtClCalculado.Text = dLeyCalculado
                End If
                If txtCd.Text <> "" And txtCdActual.Text <> "" And txtCd.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtCd.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtCdActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtCdCalculado.Text = dLeyCalculado
                End If
                If txtF.Text <> "" And txtFActual.Text <> "" And txtF.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtF.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtFActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtFCalculado.Text = dLeyCalculado
                End If

                If txtS.Text <> "" And txtSActual.Text <> "" And txtS.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtS.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtSActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtSCalculado.Text = dLeyCalculado
                End If
                If txtFe.Text <> "" And txtFeActual.Text <> "" And txtFe.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtFe.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtFeActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtFeCalculado.Text = dLeyCalculado
                End If
                If txtAl203.Text <> "" And txtAl203Actual.Text <> "" And txtAl203.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtAl203.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtAl203Actual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtAl203Calculado.Text = dLeyCalculado
                End If
                If txtCo.Text <> "" And txtCoActual.Text <> "" And txtCo.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtCo.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtCoActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtCoCalculado.Text = dLeyCalculado
                End If
                If txtMo.Text <> "" And txtMoActual.Text <> "" And txtMo.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtMo.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtMoActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtMoCalculado.Text = dLeyCalculado
                End If

             If txtP.Text <> "" And txtPActual.Text <> "" And txtP.Text <> "." Then
                    dLeyCalculado = FormatNumber(((CDbl(txtP.Text) * CDbl(txtTMS.Text)) - (CDbl(txtTMSActual.Text) * CDbl(txtPActual.Text))) / CDbl(txtTMSCalculado.Text), nRedondear)
                    txtPCalculado.Text = dLeyCalculado
                End If

            End If
        End If
    End Sub

    Private Sub txtLeyes_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCU.TextChanged, txtAU.TextChanged, txtAG.TextChanged, txtZN.TextChanged, txtPB.TextChanged, _
        txtAS.TextChanged, txtSB.TextChanged, txtBI.TextChanged, txtSIO2.TextChanged, txtHG.TextChanged, _
        txtCl.TextChanged, txtCd.TextChanged, txtF.TextChanged, txtS.TextChanged, txtFe.TextChanged, txtAl203.TextChanged, txtCo.TextChanged, txtMo.TextChanged, txtP.TextChanged
        calculaLeyes()
    End Sub

End Class