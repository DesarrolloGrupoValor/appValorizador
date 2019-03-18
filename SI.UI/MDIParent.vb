'@Comments;
'@01 20141014 BAL01 Mantenimiento de periodos

Imports System.Windows.Forms
Imports SI.PL.clsGeneral
Imports System.Drawing.Drawing2D
Imports System.Configuration

Imports System.IO




Public Class MDIParent


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub


    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cdForm As New contratos
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()
    End Sub

    Private Sub tsmiContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiContratos.Click
        Dim cdForm As New contratos
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()
    End Sub

    Private Sub tsmiNuevoContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevoContrato.Click
        Dim cdForm As New editcontrato
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me
        cdForm.pblnNuevo = True
        cdForm.Show()
    End Sub

    Private Sub tsbConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConfiguracion.Click
        Dim cdForm As New frmTabla
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()
    End Sub
    Private Sub tsmSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        If MsgBox("Esta seguro de salir del Sistema", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
            End

        End If
    End Sub
    Private Sub Principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Esta seguro de salir del Sistema", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub tsbContratos_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbContratos.ButtonClick
        Dim cdForm As New contratos
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()
    End Sub

    Private Sub tsmiNuevoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNuevoLote.Click
        Dim cdForm As New editlote
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me
        cdForm.pblnNuevo = True
        cdForm.Show()
    End Sub

    Private Sub LotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LotesToolStripMenuItem.Click
        Dim cdForm As New lotes
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me
        'cdForm.pblnNuevo = True
        cdForm.Show()
    End Sub

    Private Sub tsbLotes_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLotes.ButtonClick
        Dim cdForm As New lotes
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()
    End Sub

    Private Sub MDIParent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tslUsuario.Text = "Usuario : " & pBEUsuario.descri

        tslVersion.Text = SI.PL.clsGeneral.pstrVersion
        Me.BackgroundImage = CreateBackgroundGradient()

        PermisosOpciones()
    End Sub

    Private Sub PermisosOpciones()

        If pBEUsuario.campo6 = "1" Then

            'MenuStrip.Visible = False

            ToolsMenu.Visible = False

            tsmAplicarVentas.Visible = False
            tsmAplicarAdelantos.Visible = False

            tsbReporteComerciales.Visible = False
            tsbReportesContables.Visible = False
            tsbControlesInternos.Visible = False
            tsbConfiguracion.Visible = False

            tsbExtraccion.Visible = False

        End If


    End Sub

    'Private Sub MDIParent_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim BaseRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

    '    Dim Gradient_Brush As New LinearGradientBrush(BaseRectangle, SI.PL.clsGeneral.ColorForm, Color.White, LinearGradientMode.ForwardDiagonal)
    '    e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle)
    'End Sub
    Private Function CreateBackgroundGradient() As Bitmap
        Dim Img As New Bitmap(Me.Width, Me.Height)

        Dim Hght As Integer = Me.Height
        If Hght Mod 2 <> 0I Then Hght -= 1I
        If Hght > 2I Then
            Using e As Graphics = Graphics.FromImage(Img)
                Using b As New LinearGradientBrush(New Rectangle(0I, 0I, Me.Width, CInt(Hght / 2I)), Color.FromArgb(223, 170, 71), Color.LemonChiffon, Drawing2D.LinearGradientMode.Vertical)
                    e.FillRectangle(b, New Rectangle(0I, 0I, Me.Width, CInt(Hght / 2I)))
                End Using
                Using b As New LinearGradientBrush(New Rectangle(0I, CInt(Hght / 2I) - 1I, Me.Width, Me.Height), Color.LemonChiffon, Color.LemonChiffon, Drawing2D.LinearGradientMode.Vertical)
                    e.FillRectangle(b, New Rectangle(0I, CInt(Hght / 2), Me.Width, Me.Height))
                End Using
            End Using
        End If

        Return Img
    End Function
    Private Sub tsmConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmConfiguracion.Click
        Dim cdForm As New frmTabla
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()
    End Sub


    Private Sub tsmiComVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New browser
        'Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
        'frm.psurl = lsPagina + "ReportViewer.aspx?%2fLiquidacion%2fLiquidacion&rs:Command=Render"
        'frm.Show()

        'Dim frm As New ComposicionComercial

        'frm.MdiParent = Me
        'frm.Show()

    End Sub

    Private Sub tsmiConVenxNiveles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim frm As New ComposicionVentasNivel

        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub tsmiContyPrecios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New browser
        Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
        frm.psurl = lsPagina + "ReportViewer.aspx?%2fLiquidacion%2fLiquidacion&rs:Command=Render"
        frm.Show()
    End Sub




    Private Sub tsmiExtDeBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiExtDeBD.Click
        Dim frm As New ExtraccionBd
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmiKardex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiKardex.Click
        Dim frm As New Comercial_Kardex
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmiResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiResultado.Click
        Dim frm As New Comercial_Composicion
        frm.tipoReporte = "Resumen_Comercial"

        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub ComposicionComercialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComposicionComercialToolStripMenuItem.Click
        'Dim frm As New ComposicionComercial
        'frm.MdiParent = Me
        Dim frm As New Comercial_Composicion
        frm.tipoReporte = "Composicion_Venta"
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub ResumenDeVentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResumenDeVentasToolStripMenuItem.Click
        Dim frm As New Comercial_Composicion
        frm.tipoReporte = "CostoVentasSeg"
        frm.MdiParent = Me
        frm.Show()

    End Sub


    Private Sub tsmEntregasPorProveedorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tsmEntregasPorProveedorToolStripMenuItem.Click
        Dim frm As New Comercial_Composicion
        frm.tipoReporte = "Entregas_x_Proveedor"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ComposicionContableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComposicionContableToolStripMenuItem.Click
        'Dim frm As New ComposicionContable
        'frm.MdiParent = Me
        'frm.Show()
    End Sub
    Private Sub ComposicionMezclaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComposicionMezclaToolStripMenuItem.Click
        'Dim frm As New ComposicionMezcla
        'frm.MdiParent = Me
        Dim frm As New Comercial_Composicion
        frm.tipoReporte = "Composicion_Mezcla"
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub IndicadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndicadoresToolStripMenuItem.Click
        Dim frm As New Comercial_Composicion
        frm.tipoReporte = "Indicador_Comercial"
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub CoberturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoberturasToolStripMenuItem.Click
        Dim frm As New Coberturas
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub DesempeñoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesempeñoToolStripMenuItem.Click
        Dim frm As New Desempeño
        frm.MdiParent = Me
        frm.Show()
    End Sub




    Private Sub CuadreTMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuadreTMH.Click
        Dim frm As New CuadreTMH
        frm.MdiParent = Me
        frm.pTipoFormulario = "CUADRE_TMH"
        frm.Show()
    End Sub


    Private Sub estimaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles estimaciones.Click
        Dim frm As New Estimaciones
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub tsmiMezclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frm As New Mezcla
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmiDesxProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New DesempenhoProveedor
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmiBalxContenido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New browser
        Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
        frm.psurl = lsPagina + "ReportViewer.aspx?%2fLiquidacion%2fLiquidacion&rs:Command=Render"
        frm.Show()
    End Sub


    Private Sub tsmiAdelantos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New browser
        Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
        frm.psurl = lsPagina + "ReportViewer.aspx?%2fLiquidacion%2fLiquidacion&rs:Command=Render"
        frm.Show()
    End Sub



    Private Sub tsmiExposiciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Exposicion

        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New ComposicionVentas
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub tsPlanCuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPlanCuentas.Click
        Dim frm As New plancuentas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsConfigAsientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsConfigAsientos.Click
        Dim frm As New configasientos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim lsCadena = "&contratoLoteId=" & codLote() & "&liquidacionId=" & lsCodLiquidacion & "&UserNombre=" & NomTrader()
        Dim lsPagina As String = ConfigurationManager.AppSettings.Get("Urlreportes").ToString()
        Dim frm As New browser
        frm.psurl = lsPagina + "ReportViewer.aspx?%2fLiquidacion%2fContabilidad&rs:Command=Render"

        frm.Show()
    End Sub

    Private Sub GenerarAsientosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarAsientosToolStripMenuItem.Click
        Dim frm As New frmcontabilidad
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tsmNuevoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmNuevoLote.Click
        Dim cdForm As New editlote
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me
        cdForm.pblnNuevo = True
        cdForm.Show()

    End Sub

    Private Sub tsmLotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLotes.Click
        Dim cdForm As New lotes
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me
        'cdForm.pblnNuevo = True
        cdForm.Show()

    End Sub

    Private Sub tsmNuevoContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmNuevoContrato.Click
        Dim cdForm As New editcontrato
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me
        cdForm.pblnNuevo = True
        cdForm.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim cdForm As New contratos
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()

    End Sub

    Private Sub vinculada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vinculada.Click
        Dim cdForm As New Vinculada
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()
    End Sub

    Private Sub movimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles movimiento.Click
        Dim cdForm As New Movimiento
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        cdForm.MdiParent = Me

        cdForm.Show()
    End Sub

    Private Sub tsmCargarMezclas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCargarMezclas.Click
        
            Dim cdForm As New calcularLote
            cdForm.sTipoCalculo = "M"
            cdForm.MdiParent = Me

        cdForm.Show()

    End Sub

    Private Sub tsmCargarVinculadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCargarVinculadas.Click


        Dim cdForm As New calcularLote
        cdForm.sTipoCalculo = "V"
        cdForm.MdiParent = Me

        cdForm.Show()

    End Sub

    Private Sub tsmConsultaDepósitosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmConsultaDepósitosToolStripMenuItem.Click
        Dim oDeposito As New frmDeposito

        oDeposito.MdiParent = Me

        oDeposito.Show()
    End Sub

    Private Sub tsmAplicarAdelantos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAplicarAdelantos.Click
        Dim oAplicarAdelanto As New aplicarAdelanto
        oAplicarAdelanto.MdiParent = Me
        oAplicarAdelanto.Show()
    End Sub

    Private Sub tsmLotesValorizadosLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLotesValorizadosLog.Click
        Dim oLotesValorizadosLog As New frmLotesValorizadosLog
        oLotesValorizadosLog.MdiParent = Me
        oLotesValorizadosLog.Show()
    End Sub

    Private Sub tsbLotesValorizadosConVariaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLotesValorizadosConVariaciónToolStripMenuItem.Click
        Dim oLotesValorizadosVariacion As New frmLotesValorizadosVariacion
        oLotesValorizadosVariacion.MdiParent = Me
        oLotesValorizadosVariacion.Show()
    End Sub

    Private Sub tsmGestiónComercial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmGestiónComercial.Click
        Dim oGestionComercial As New frmGestionComercial
        oGestionComercial.MdiParent = Me
        oGestionComercial.Show()
    End Sub

    Private Sub tsRumasPendientesDeVincularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oRumasPendientesVincular As New frmRumasPendientesVincular
        oRumasPendientesVincular.MdiParent = Me
        oRumasPendientesVincular.Show()
    End Sub

    Private Sub GeneraciónQPsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneraciónQPsToolStripMenuItem.Click
        Dim oGenerarQPs As New GenerarQPs
        oGenerarQPs.MdiParent = Me
        oGenerarQPs.Show()
    End Sub

    Private Sub tsRumasVinculadasConLotesDeCompraPendientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oVinculadasComprasPendientes As New frmVinculadasComprasPendientes
        oVinculadasComprasPendientes.MdiParent = Me
        oVinculadasComprasPendientes.Show()
    End Sub

    Private Sub RumasPendientesDeLotizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RumasPendientesDeLotizarToolStripMenuItem.Click
        Dim ofrmRumasPendientes As New frmRumasPendientes
        ofrmRumasPendientes.MdiParent = Me
        ofrmRumasPendientes.Show()
    End Sub

    Private Sub tsmExecObjetsSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmExecObjetsSQL.Click
        Dim ofrmExecObjectsSQL As New frmExecObjectsSQL
        ofrmExecObjectsSQL.MdiParent = Me
        ofrmExecObjectsSQL.Show()
    End Sub

    Private Sub tsmPrecioDiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPrecioDiario.Click
        Dim ofrmPreciosDiarios As New frmPreciosDiarios
        ofrmPreciosDiarios.MdiParent = Me
        ofrmPreciosDiarios.Show()
    End Sub

  

    Private Sub tsExtracciónVCMCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExtraccionVCMCompras.Click
        Dim frmExtraccionVCM As New ExtraccionVCM
        frmExtraccionVCM.MdiParent = Me
        frmExtraccionVCM.pTipo_Extraccion = "P"
        frmExtraccionVCM.Show()
    End Sub

    Private Sub tsExtraccionVCMVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExtraccionVCMVenta.Click
        Dim frmExtraccionVCM As New ExtraccionVCM
        frmExtraccionVCM.MdiParent = Me
        frmExtraccionVCM.pTipo_Extraccion = "S"
        frmExtraccionVCM.Show()
    End Sub





    ''Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    ''    TextBox2.Text = Encrypt(TextBox1.Text)
    ''End Sub

    ''Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    ''    TextBox1.Text = Decrypt(TextBox2.Text)
    ''End Sub

    ''Public Function Encrypt(ByVal sCadena As String) As String
    ''    Dim encrypted As String = ""
    ''    Try
    ''        Dim bytes() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes("ZeroCool")

    ''        Dim cryptoProvider As New System.Security.Cryptography.DESCryptoServiceProvider
    ''        Dim memoryStream As New MemoryStream 'MemoryStream(Convert.FromBase64String(sCadena))
    ''        Dim cryptoStream As New System.Security.Cryptography.CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(bytes, bytes), System.Security.Cryptography.CryptoStreamMode.Write)
    ''        Dim writer As New StreamWriter(cryptoStream)
    ''        writer.Write(sCadena)
    ''        writer.Flush()
    ''        cryptoStream.FlushFinalBlock()
    ''        writer.Flush()
    ''        encrypted = Convert.ToBase64String(memoryStream.GetBuffer(), 0, Convert.ToInt16(memoryStream.Length))
    ''    Catch ex As Exception
    ''        encrypted = ""
    ''    End Try
    ''    Return encrypted
    ''End Function

    ''Public Function Decrypt(ByVal sCadena As String) As String
    ''    Dim decrypted As String = ""
    ''    Try
    ''        Dim bytes() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes("ZeroCool")

    ''        Dim cryptoProvider As New System.Security.Cryptography.DESCryptoServiceProvider()
    ''        Dim MemoryStream As New MemoryStream(Convert.FromBase64String(sCadena)) ' FromBase64String(input)

    ''        Dim cryptoStream As New System.Security.Cryptography.CryptoStream(MemoryStream, cryptoProvider.CreateDecryptor(bytes, bytes), System.Security.Cryptography.CryptoStreamMode.Read)
    ''        Dim reader As New StreamReader(cryptoStream)
    ''        decrypted = reader.ReadToEnd()
    ''    Catch ex As Exception

    ''        decrypted = ""
    ''    End Try

    ''    Return decrypted
    ''End Function

    Private Sub tsmKardexContable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmKardexContable.Click
        Dim frmContable_Kardex As New Contable_Kardex
        frmContable_Kardex.MdiParent = Me
        'frmContable_Kardex.pTipo = "N" 'nuevo (detallado)

        'If CType(sender, ToolStripMenuItem).Name = "tsmKardexContable" Then
        '    frmContable_Kardex.pTipo = "A" ' anterior
        'End If

        frmContable_Kardex.Show()
    End Sub


    Private Sub tsmAplicarVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAplicarVentas.Click
        Dim frmProvisionarVentas As New provisionarVentas
        frmProvisionarVentas.MdiParent = Me

        frmProvisionarVentas.Show()
    End Sub

    Private Sub tsExtraccionVCMDespacho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExtraccionVCMDespacho.Click
        Dim frmExtraccionVCM As New ExtraccionVCM
        frmExtraccionVCM.MdiParent = Me
        frmExtraccionVCM.pTipo_Extraccion = "B"
        frmExtraccionVCM.Show()
    End Sub

    Private Sub tsmDocumentosDeVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDocumentosDeVenta.Click
        Dim frmDocumentosVenta As New DocumentosVenta
        frmDocumentosVenta.MdiParent = Me
        frmDocumentosVenta.Show()
    End Sub

    Private Sub tsmHistorialVentaVinculada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmHistorialVentaVinculada.Click
        Dim frm As New Comercial_Composicion
        frm.tipoReporte = "CN_Historial_Venta"

        frm.MdiParent = Me
        frm.Show()
    End Sub
    '@01    AINI
    Private Sub PeriodoContableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodoContableToolStripMenuItem.Click
        Dim oTablaDetRO As New SI.BC.clsBC_TablaDetRO
        If Not oTablaDetRO.ValidarUsuarioToValidacionCTB(pBEUsuario.tablaDetId) Then
            ' Message
            MsgBox("No tiene permisos para la edicion de Periodo contable.", MsgBoxStyle.Information, "Valorizador Comercial de Minerales")
        Else
            Dim frm As New frmPeriodoContable
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub
    '@01    AFIN

    Private Sub ResumenIndicadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenIndicadoresToolStripMenuItem.Click

        Dim frm As New Comercial_Composicion
        frm.tipoReporte = "Indicadores_Resumen"
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub DetalleDeLiquidacionesPorLotesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DetalleDeLiquidacionesPorLotesToolStripMenuItem.Click
        Dim frm As New LiquidacionesLote
        frm.MdiParent = Me
        frm.Show()
    End Sub

    'Private Sub MatrizDeMezclaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MatrizDeMezclaToolStripMenuItem.Click

    '    Dim frmMatrizMezcla As New ReporteCompraVenta
    '    frmMatrizMezcla.MdiParent = Me
    '    frmMatrizMezcla.pTipo_Extraccion = "B"
    '    frmMatrizMezcla.Show()

    'End Sub

    Private Sub tsmEstadisticasVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEstadisticasVenta.Click
        Dim frmEstadisticaVenta As New EstadisticaVenta
        frmEstadisticaVenta.MdiParent = Me
        frmEstadisticaVenta.Show()
    End Sub

    Private Sub tsmLotesComprasConAsignaciónVentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles tsmLotesComprasConAsignaciónVentasToolStripMenuItem.Click
        Dim frmEstadisticaVenta As New ReporteCompraVenta
        'frmEstadisticaVenta.pTipo = "Compraventa"
        frmEstadisticaVenta.MdiParent = Me
        frmEstadisticaVenta.Show()
    End Sub

    Private Sub tsmRepaticionRentabilidad_Click(sender As System.Object, e As System.EventArgs) Handles tsmRepaticionRentabilidad.Click
        Dim frmEstadisticaVenta As New ReporteReparticionUtilidad
        'frmEstadisticaVenta.pTipo = "ReparticionRentabilidad"
        frmEstadisticaVenta.MdiParent = Me
        frmEstadisticaVenta.Show()
    End Sub

    Private Sub tsbControlesInternos_ButtonClick(sender As System.Object, e As System.EventArgs) Handles tsbControlesInternos.ButtonClick

    End Sub

    Private Sub LiquidacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LiquidacionesToolStripMenuItem.Click
        Dim frm As New Consulta_Liquidaciones
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
