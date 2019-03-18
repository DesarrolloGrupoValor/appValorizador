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

Public Class frmGestionComercial

    Private oMensajeError As mensajeError = New mensajeError
    Private nGestionComercial As Integer

    Private Sub frmGestionComercial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ConfiguraForm(Me)
        CargarParametros()

        ObtenerRegistros()
    End Sub

    Private Sub CargarParametros()
        Try
             Obtener_ParametrosCombo(cboTipoDocumento, clsUT_Dominio.domTABLA_DE_DOCUMENTOS, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboEmisor, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosComboSP(cboMes, "MES")
            Obtener_ParametrosComboSP(cboAnio, "ANIO")

            Dim oTablaDetRO As New clsBC_TablaDetRO
            oTablaDetRO.oBETablaDet.tablaId = "impuesto"
            oTablaDetRO.oBETablaDet.tablaDetId = "igv"
            oTablaDetRO.LeerTablaDet()
            txtIgv.Text = oTablaDetRO.oBETablaDet.descri.ToString()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    Private Sub ObtenerRegistros()
        Dim dsGestionComercialRO As DataSet

        Dim oBC_GestionComercialRO As New clsBC_GestionComercialRO
        'oBC_GestionComercialRO.oBEGestionComercial.dFechaEmision = dtpFechaEmision.Text
        oBC_GestionComercialRO.LeerListaToDSGestionComercial_SelAll()
        dsGestionComercialRO = oBC_GestionComercialRO.oDSGestionComercial
        fgxGestionComercial_Registro_Sel.DataSource = dsGestionComercialRO.Tables(0)
        'fgxGestionComercial_Registro_Sel.AutoGenerateColumns = True

    End Sub

    Private Function ValidarObligatorios() As String
        Dim sRespuesta As String = ""

        If cboEmisor.SelectedIndex = 0 Then
            sRespuesta += "Debe seleccionar Emisor" + Chr(10)
        End If

        If cboEmpresa.SelectedIndex = 0 Then
            sRespuesta += "Debe seleccionar Empresa" + Chr(10)
        End If

        If cboMes.SelectedIndex = 0 Then
            sRespuesta += "Debe seleccionar Mes" + Chr(10)
        End If


        Return sRespuesta
    End Function

    Private Sub tsbConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsulta.Click
        Dim sRespuestaValidacion As String = ValidarObligatorios()

        If sRespuestaValidacion <> "" Then
            MsgBox(sRespuestaValidacion, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Else
            Dim oBC_GestionComercialRO As New clsBC_GestionComercialRO
            oBC_GestionComercialRO.oBEGestionComercial = New clsBE_GestionComercial
            oBC_GestionComercialRO.oBEGestionComercial.sEmpresa = cboEmpresa.SelectedValue
            oBC_GestionComercialRO.oBEGestionComercial.sMes = cboMes.SelectedValue
            oBC_GestionComercialRO.oBEGestionComercial.sAnio = cboAnio.SelectedValue
            oBC_GestionComercialRO.LeerListaToDSGestionComercial()

            fxgrdGestionComercial.AutoGenerateColumns = False
            fxgrdGestionComercial.DataSource = oBC_GestionComercialRO.oDSGestionComercial.Tables(0)

            If oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows.Count > 0 Then
                txtTMH.Text = FormatNumber(oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Compute("sum(TMH)", "").ToString, 2)
                txtTMS.Text = FormatNumber(oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Compute("sum(TMS)", "").ToString, 2)
                txtTMNS.Text = FormatNumber(oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Compute("sum(TMNS)", "").ToString, 2)

                calcularValorNeto()
            End If

        End If
    End Sub

    Private Sub txtComision_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtComision.TextChanged
        calcularValorNeto()
    End Sub

    Private Sub calcularValorNeto()
        If txtComision.Text <> "" And txtTMNS.Text <> "" Then
            txtValorNeto.Text = FormatNumber(txtTMNS.Text * txtComision.Text, 2)
        End If
    End Sub

    Private Sub txtValorNeto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtValorNeto.TextChanged
        If txtValorNeto.Text <> "" Then

            txtvalorIGV.Text = FormatNumber(CDbl(txtValorNeto.Text) * CDbl(txtIgv.Text) / 100, 2)
            txtValorTotal.Text = FormatNumber(CDbl(txtValorNeto.Text) + CDbl(txtvalorIGV.Text), 2)
        End If
    End Sub

    


    Private Function validarCampos() As String
        'Dim bRespuesta As Boolean
        Dim sMensaje As String = ""

        If cboEmisor.SelectedIndex = 0 Then
            sMensaje = sMensaje & "* Debe seleccionar Emisor " & Chr(10) & " "
        End If

        If cboEmpresa.SelectedIndex = 0 Then
            sMensaje = sMensaje & "* Debe seleccionar Empresa " & Chr(10) & " "
        End If

        If cboTipoDocumento.SelectedIndex = 0 Then
            sMensaje = sMensaje & "* Debe seleccionar tipo de documento " & Chr(10) & " "
        End If

        If txtNumeroDocumento.Text = "" Then
            sMensaje = sMensaje & "* Debe seleccionar Numero de documento " & Chr(10) & " "
        End If

        Return sMensaje
    End Function

    Private Sub GuardarRegistro()
        Dim oBC_GestionComercialTX As New clsBC_GestionComercialTX
        oBC_GestionComercialTX.oBEGestionComercial.dFechaEmision = dtpFechaEmision.Text


        oBC_GestionComercialTX.oBEGestionComercial.sMes = cboMes.SelectedValue
        oBC_GestionComercialTX.oBEGestionComercial.sMesDescripcion = cboMes.Text
        oBC_GestionComercialTX.oBEGestionComercial.sAnio = cboAnio.SelectedValue
        oBC_GestionComercialTX.oBEGestionComercial.sTipoDocumento = cboTipoDocumento.SelectedValue
        oBC_GestionComercialTX.oBEGestionComercial.sNumeroDcoumento = txtNumeroDocumento.Text
        oBC_GestionComercialTX.oBEGestionComercial.sEmpresa = cboEmisor.SelectedValue
        oBC_GestionComercialTX.oBEGestionComercial.sCliente = cboEmpresa.SelectedValue
        oBC_GestionComercialTX.oBEGestionComercial.nComision = txtComision.Text
        oBC_GestionComercialTX.oBEGestionComercial.sUc = pBEUsuario.tablaDetId

        If oBC_GestionComercialTX.GenerarGestionComercial_Ins() Then
            nGestionComercial = oBC_GestionComercialTX.oBEGestionComercial.nGestionComercialId

            MsgBox("El registro se guardó satisfactoriamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        End If


    End Sub

    Private Sub tsbGenerarFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarFactura.Click


        If tcGestionComercial.SelectedTab.Name <> tpRegistro.Name Then
            MsgBox("No se encuentra en la pestaña registro", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Exit Sub
        End If

        If nGestionComercial = 0 Then
            MsgBox("No se puede generar la factura, porque ha grabado el registro", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Exit Sub
        End If

        Dim pPrinter As New Drawing.Printing.PrinterSettings
        pPrinter.PrinterName = "EPSON LX-300+ /II"
        pdPrintDocument.PrinterSettings = pPrinter


        ''If pdPrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        ''    pdPrintDocument.PrinterSettings = pdPrintDocument.PrinterSettings
        ''End If

        pdPrintDocument.Print()


        ''Dim sMensaje As String = validarCampos()

        ''If sMensaje <> "" Then
        ''    MsgBox(sMensaje, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        ''Else

        ''    ''Dim pPrinter As New Drawing.Printing.PrinterSettings
        ''    ''pPrinter.PrinterName = "EPSON LX-300+ /II"
        ''    ''pdPrintDocument.PrinterSettings = pPrinter


        ''    If pdPrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
        ''        pdPrintDocument.PrinterSettings = pdPrintDocument.PrinterSettings
        ''        'pdPrintDocument.PrinterSettings = pPrinter
        ''        pdPrintDocument.Print()
        ''    End If

        ''End If
    End Sub

    Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrintDocument.PrintPage
        Dim Fuente As New Font("arial", 10)
        Dim posicion As Integer = 180
        Dim format1 As New StringFormat()
        format1.LineAlignment = StringAlignment.Center
        format1.Alignment = StringAlignment.Far


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

        Dim sValorSinIgv As String
        Dim sValorConIgv As String
        Dim sIgv As String
        Dim sValorImpuesto As String

        Dim sTMNS As String


        'Dim oBC_GestionComercialRO As New clsBC_GestionComercialRO
        ''oBC_GestionComercialRO.oBEGestionComercial.dFechaEmision = dtpFechaEmision.Text


        ''oBC_GestionComercialRO.oBEGestionComercial.sMes = cboMes.SelectedValue
        ''oBC_GestionComercialRO.oBEGestionComercial.sMesDescripcion = cboMes.SelectedText
        ''oBC_GestionComercialRO.oBEGestionComercial.sAnio = cboAnio.SelectedValue
        ''oBC_GestionComercialRO.oBEGestionComercial.sTipoDocumento = cboTipoDocumento.SelectedValue
        ''oBC_GestionComercialRO.oBEGestionComercial.sNumeroDcoumento = txtNumeroDocumento.Text
        ''oBC_GestionComercialRO.oBEGestionComercial.sEmpresa = cboEmisor.SelectedValue
        ''oBC_GestionComercialRO.oBEGestionComercial.sCliente = cboEmpresa.SelectedValue
        ''oBC_GestionComercialRO.oBEGestionComercial.nComision = txtComision.Text
        ''oBC_GestionComercialRO.oBEGestionComercial.sUc = pBEUsuario.tablaDetId

        ''oBC_GestionComercialRO.GenerarGestionComercial()


        'oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("diren").ToString()

        Dim oBC_GestionComercialRO As New clsBC_GestionComercialRO
        oBC_GestionComercialRO.oBEGestionComercial.nGestionComercialId = nGestionComercial
        oBC_GestionComercialRO.LeerListaToDSGestionComercial_SelAll()


        If oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows.Count > 0 Then
            sDia = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("diaEmision").ToString
            sMes = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("mesEmision").ToString
            sAnio = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("anioEmision").ToString

            sComDescripcion = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("Cliente").ToString
            sDireccion = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("Direccion").ToString
            sRuc = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("ClienteRuc").ToString

            sConcepto = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("concepto").ToString
            sValorTexto = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("ValorTexto").ToString

            sPrecioUnitario = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("comision").ToString

            sTMNS = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("TMNS").ToString

            sValorImpuesto = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("ImporteIGV").ToString

            sValorSinIgv = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("ValorSinIgv").ToString
            sIgv = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("Igv").ToString
            sValorConIgv = oBC_GestionComercialRO.oDSGestionComercial.Tables(0).Rows(0)("ValorConIgv").ToString

            sPrecioUnitario = "  " & Format(CDbl(sPrecioUnitario), "##,##0.00") 'FormatCurrency(sPrecioUnitario, 2)

            sPrecioUnitario = "$" & sPrecioUnitario

            sValorSinIgv = sDigitosMaximo & Format(CDbl(sValorSinIgv), "##,##0.00") 'FormatCurrency(sMontoNeto, 2)
            sIgv = sDigitosMaximo & Format(CDbl(sIgv), "##,##0.00") 'FormatCurrency(sMontoIGV, 2)
            sValorConIgv = sDigitosMaximo & Format(CDbl(sValorConIgv), "##,##0.00") 'FormatCurrency(sMontoNetoAPagar, 2)

            sValorSinIgv = "$" & sValorSinIgv.ToString().Substring(Len(sValorSinIgv) - nCantidadDigitos, nCantidadDigitos)
            sIgv = "$" & sIgv.ToString().Substring(Len(sIgv) - nCantidadDigitos, nCantidadDigitos)
            sValorConIgv = "$" & sValorConIgv.ToString().Substring(Len(sValorConIgv) - nCantidadDigitos, nCantidadDigitos)


            Dim displayRectangle1 As New Rectangle
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
            e.Graphics.DrawString(sValorSinIgv, Fuente, Brushes.Black, 780, posicion + 180, format1)
            e.Graphics.DrawString(sConcepto, Fuente, Brushes.Black, 150, posicion + 180)

            e.Graphics.DrawString(sValorTexto, Fuente, Brushes.Black, RectangleF.op_Implicit(displayRectangle1))

            e.Graphics.DrawString(sValorImpuesto, Fuente, Brushes.Black, 630, posicion + 810, format1)
            e.Graphics.DrawString(sValorSinIgv, Fuente, Brushes.Black, 780, posicion + 780, format1)
            e.Graphics.DrawString(sIgv, Fuente, Brushes.Black, 780, posicion + 810, format1)
            e.Graphics.DrawString(sValorConIgv, Fuente, Brushes.Black, 780, posicion + 840, format1)


            'obtiene la informacion de detalle de gestion comercial

            'oBC_GestionComercialRO = New clsBC_GestionComercialRO
            'oBC_GestionComercialRO.oBEGestionComercial.nGestionComercialId = nGestionComercial
            'oBC_GestionComercialRO.LeerListaToDSGestionComercial_Sel()

            'fxgrdGestionComercialExport.DataSource = oBC_GestionComercialRO.oDSGestionComercial.Tables(0)
            'Exportar()
        End If
    End Sub



    Private Sub Exportar()
        Try
            sfdSaveFileDialog.Filter = "Hojas de Excel|*.xls"
            sfdSaveFileDialog.FileName = cboMes.Text & "_" & cboAnio.Text & "_" & cboEmpresa.Text

            If sfdSaveFileDialog.ShowDialog = DialogResult.OK Then
                'fxgrdGestionComercialExport.SaveExcel(sfdSaveFileDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
                fxgrdGestionComercial.SaveExcel(sfdSaveFileDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)

                Dim processInfo As New ProcessStartInfo("explorer.exe", sfdSaveFileDialog.FileName)
                Process.Start(processInfo)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    

    Private Sub fgxGestionComercial_Registro_Sel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgxGestionComercial_Registro_Sel.DoubleClick
        tcGestionComercial.SelectedTab = tpRegistro

        dtpFechaEmision.Value = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("fechaEmision")

        cboMes.SelectedValue = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("mes")
        cboAnio.SelectedValue = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("anio")

        cboTipoDocumento.SelectedValue = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("TipoDocumento")
        txtNumeroDocumento.Text = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("NumeroDcoumento")

        cboEmisor.SelectedValue = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("EmpresaCodigo")
        cboEmpresa.SelectedValue = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("ClienteCodigo")

        txtComision.Text = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("comision")

        txtTMS.Text = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("TMS")
        txtTMH.Text = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("TMH")
        txtTMNS.Text = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("TMNS")

        txtValorNeto.Text = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("ValorSinIGV")
        txtvalorIGV.Text = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("Igv")
        txtValorTotal.Text = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("ValorConIgv")

        nGestionComercial = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("GestionComercialId")

        Dim dsGestionComercialRO As DataSet
        Dim oBC_GestionComercialRO As New clsBC_GestionComercialRO
        oBC_GestionComercialRO.oBEGestionComercial.nGestionComercialId = nGestionComercial
        oBC_GestionComercialRO.LeerListaToDSGestionComercial_Sel()

        dsGestionComercialRO = oBC_GestionComercialRO.oDSGestionComercial
        fxgrdGestionComercial.DataSource = dsGestionComercialRO.Tables(0)


        gbDatos.Enabled = False
    End Sub

    Private Sub Limpiar()
        gbDatos.Enabled = True

        tcGestionComercial.SelectedTab = tpRegistro

        'CargarParametros()
        nGestionComercial = 0

        cboMes.SelectedIndex = 0
        cboAnio.SelectedIndex = 0

        cboTipoDocumento.SelectedIndex = 0
        txtNumeroDocumento.Text = ""

        cboEmisor.SelectedIndex = 0
        cboEmpresa.SelectedIndex = 0

        txtComision.Text = ""

        txtTMS.Text = ""
        txtTMH.Text = ""
        txtTMNS.Text = ""

        txtValorNeto.Text = ""
        txtvalorIGV.Text = ""
        txtValorTotal.Text = ""


        'fxgrdGestionComercial.Clear()

        Dim dsGestionComercialRO As DataSet
        Dim oBC_GestionComercialRO As New clsBC_GestionComercialRO
        oBC_GestionComercialRO.oBEGestionComercial.nGestionComercialId = 0
        oBC_GestionComercialRO.LeerListaToDSGestionComercial_Sel()

        dsGestionComercialRO = oBC_GestionComercialRO.oDSGestionComercial
        fxgrdGestionComercial.DataSource = dsGestionComercialRO.Tables(0)


    End Sub

    Private Sub tsbNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNuevo.Click
        Limpiar()
    End Sub

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        ObtenerRegistros()
    End Sub


    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        Dim sMensaje As String = validarCampos()

        If sMensaje <> "" Then
            MsgBox(sMensaje, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Else
            GuardarRegistro()
            Limpiar()
        End If

        tcGestionComercial.SelectedTab = tpLista
        ObtenerRegistros()

    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click

        If nGestionComercial = 0 Then
            MsgBox("No existe registros a exportar", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Exit Sub
        End If

        Exportar()
    End Sub

    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click

        If tcGestionComercial.SelectedTab.Name <> tpLista.Name Then
            MsgBox("Debe seleccionar un registro en la pestaña Lista", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            Exit Sub
        End If


        If MsgBox("Esta seguro de anular el registro seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
            Dim oBC_GestionComercialTX As New clsBC_GestionComercialTX
            oBC_GestionComercialTX.oBEGestionComercial.nGestionComercialId = fgxGestionComercial_Registro_Sel.Rows(fgxGestionComercial_Registro_Sel.RowSel).Item("GestionComercialId")
            If oBC_GestionComercialTX.GenerarGestionComercial_Anu() Then
                MsgBox("El registro fue anulado correctamente", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                ObtenerRegistros()
            Else
                MsgBox("No se puedo anular el registro", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            End If


        End If
    End Sub

    
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Dispose()
    End Sub

End Class