'Comments:
'@01 20140924 BAL01 Se cambia referencia de columna Indice por Nombre
'@02 20141016 BAL01 No se puede eliminar lote en caso que tenga al menos una liquidacion cuyo asiento contable haya sido generado

Imports System.Data
Imports SI.BE
Imports SI.BC
Imports SI.UT
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsFuncion
Imports SI.PL.clsGeneral
Imports System.Drawing.Drawing2D

Public Class lotes
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError
    Private oLiquidacionRO As New clsBC_LiquidacionRO
    Private dtLiquidacion As DataTable



    Private blnCarga As Boolean
    Private dvwContrato As DataView
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click, tsmSalir.Click
        Me.Dispose()
    End Sub

    Private Sub lotes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'If pblnRetornalotes Then
        '    ObtenerRegistros()
        '    pblnRetornaLotes = False
        'End If
    End Sub

    Private Sub lotes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            ConfiguraForm(Me)

            'fxgrdContrato.Cols("codigotabla").Visible = False
            'fxgrdContrato.Cols("codigoempresa").Caption = "Empresa"
            'fxgrdContrato.Cols("codigosocio").Caption = "Socio"
            'fxgrdContrato.Cols("codigoMovimiento").Caption = "Movimiento"
            'fxgrdContrato.Cols("codigoclase").Caption = "Clase"
            'fxgrdContrato.Cols("codigoproducto").Caption = "producto"
            'fxgrdContrato.Cols("codigosocio").Caption = "Socio"

            fxgrdContrato.AutoGenerateColumns = False
            'ObtenerRegistros()

            CargarParametros()
            RadioButton1.Checked = True
            'RadioButton2_CheckedChanged(Nothing, Nothing)

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try


    End Sub
    Private Sub CargarParametros()
        Try
            Obtener_ParametrosCombo(cboTipoContrato, "movimiento", SI.PL.clsEnumerado.enumPrimerValorCombo.Todos, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            Obtener_ParametrosCombo(cboProducto, "producto", SI.PL.clsEnumerado.enumPrimerValorCombo.Todos, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
            'Obtener_ParametrosCombo(cboDeposito, clsUT_Dominio.domTABLA_DE_DEPOSITO, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)

            Obtener_ParametrosComboEN(cboDeposito, "COM_DEPOSITOS")


            Obtener_ParametrosGridView(dgvTipo, clsUT_Dominio.domTIPO_DE_DEDUCCION)
            Obtener_ParametrosGridView(dgvMerc, clsUT_Dominio.domMERCADO)
            Obtener_ParametrosGridView(dgvQP, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub
    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

    '    Select Case keyData
    '        Case Keys.Escape

    '            tsbSalir_Click(Nothing, Nothing)

    '    End Select
    '    Return MyBase.ProcessCmdKey(msg, keyData)

    'End Function
    Private Sub ObtenerRegistros(Optional ByVal tipo As String = "")
        Try
            blnCarga = False
            Dim oContratoRO As New clsBC_ContratoLoteRO

            'kmn 31/08/2012
            Dim sFilterDefinition As String = fxgrdContrato.FilterDefinition
            Dim nRowSel As Integer = fxgrdContrato.RowSel
            Dim sRowFilter As String = ""
            If dvwContrato IsNot Nothing Then
                sRowFilter = dvwContrato.RowFilter
            End If
            'kmn 31/08/2012

            If RadioButton2.Checked Then
                'cargar detgalleado
                'ObtenerRegistros("LOT")
                oContratoRO.oBEContratoLote.codigoTabla = "LOT"
            Else
                'cargar agrupado
                'ObtenerRegistros()
                oContratoRO.oBEContratoLote.codigoTabla = ""
            End If


            ' ''Auditoria
            ''oContratoRO.oBE_AuditoriaD = New clsBE_AuditoriaD
            ''oContratoRO.oBE_AuditoriaD.IdAuditoria = pBEUsuario.IdAuditoria

            oContratoRO.oBEContratoLote.comentarios = pBEUsuario.campo2
            oContratoRO.oBEContratoLote.permiso = pBEUsuario.campo6
            dvwContrato = New DataView(oContratoRO.LeerListaToDSContrato.Tables(0))

            'kmn 31/08/2012
            dvwContrato.RowFilter = sRowFilter
            'kmn 31/08/2012

            fxgrdContrato.DataSource = dvwContrato
            ColumnasID(fxgrdContrato)
            ColumnasCodigo(fxgrdContrato)
            blnCarga = True
            'fxgrdContrato_Click(Nothing, Nothing)
            fxgrdContrato_SelChange(Nothing, Nothing)


            fxgrdContrato.Cols("Estado").Visible = True


            ''fxgrdContrato.Cols(4).Width = 70
            ''fxgrdContrato.Cols(5).Width = 60
            ''fxgrdContrato.Cols(6).Width = 50
            ''fxgrdContrato.Cols(7).Width = 50 'CONTRATO
            ''fxgrdContrato.Cols(8).Width = 70 'LOTE
            ''fxgrdContrato.Cols(9).Width = 80

            ''fxgrdContrato.Cols(4).Visible = False
            ''fxgrdContrato.Cols(5).Visible = False
            ''fxgrdContrato.Cols(6).Visible = False

            ' ''fecha Liqu, calc Liq
            ''fxgrdContrato.Cols(31).Visible = True
            ''fxgrdContrato.Cols(31).Width = 50
            ' ''fxgrdContrato.Cols(31).Width = 80


            ''If fxgrdContrato.Cols("codTrader") Is Nothing Then
            ''Else
            ''    fxgrdContrato.Cols(10).Width = 70

            ''    fxgrdContrato.Cols("codTrader").Visible = False
            ''    fxgrdContrato.Cols("codAdministrador").Visible = False

            ''    fxgrdContrato.Cols("estado").Visible = True
            ''    fxgrdContrato.Cols("estado").Width = 40

            ''End If

            ''For Each col As C1.Win.C1FlexGrid.Column In fxgrdContrato.Cols

            ''    col.Format = "N3"

            ''    If fxgrdContrato.Cols.Count = 32 And col.Name = "Valor Actual" Then
            ''        col.Format = "N2"
            ''    End If

            ''    If fxgrdContrato.Cols.Count = 32 And (col.Name = "Recepcion" Or col.Name = "F. 1ra Liq") Then
            ''        'col.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            ''        col.Format = "dd/MM/yyyy"
            ''    End If

            ''Next


            ' ''fxgrdContrato.Cols(10).Width = 80
            ' ''fxgrdContrato.Cols(11).Width = 50
            ' ''fxgrdContrato.Cols(12).Width = 50
            ' ''fxgrdContrato.Cols(13).Width = 50
            ' ''fxgrdContrato.Cols(14).Width = 70
            ' ''fxgrdContrato.Cols(15).Width = 50
            ' ''fxgrdContrato.Cols(16).Width = 50

            ''If fxgrdContrato.Cols(1).Caption <> "" Then
            ''    fxgrdContrato.Cols("Cliente/Proveedor").Width = 300
            ''    fxgrdContrato.Cols("calidad").Width = 250
            ''    fxgrdContrato.Cols("TMH").Width = 60
            ''    fxgrdContrato.Cols("TMS").Width = 60
            ''    fxgrdContrato.Cols("TMSN").Width = 60
            ''End If

            'kmn 31/08/2012
            fxgrdContrato.FilterDefinition = sFilterDefinition

            Try
                fxgrdContrato.RowSel = nRowSel
            Catch e As Exception
                fxgrdContrato.RowSel = 1
            End Try
            'kmn 31/08/2012
            'fxgrdContrato.Cols("TMSN").Width = "dd"

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub
    Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmNuevo.Click, tsbNuevo.Click
        Try
            Dim cdForm As New editlote
            ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
            cdForm.MdiParent = MdiParent
            cdForm.pblnNuevo = True
            cdForm.Show()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub fxgrdContrato_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgrdContrato.DoubleClick
        Try
            If fxgrdContrato.RowSel >= 0 Then

                Dim cdForm As New editlote

                cdForm.MdiParent = MdiParent
                cdForm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
                cdForm.pstrAdministrador = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("Administrador")

                cdForm.pEstadoLiquidacion = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("estado")
                cdForm.Show()

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub fxgrdContrato_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fxgrdContrato.SelChange
        Try
            If fxgrdContrato.Rows.Count > 0 Then
                If Not blnCarga Then Exit Sub
                If fxgrdContrato.RowSel > 0 Then
                    'Dim dvwterminos As DataView
                    Dim oLiquidacionRO As New clsBC_LiquidacionRO
                    oLiquidacionRO.oBELiquidacion.contratoLoteId = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoloteid")
                    oLiquidacionRO.oBELiquidacion.liquidacionId = "0000000001"
                    oLiquidacionRO.LeerLiquidacion()
                    With oLiquidacionRO.oBELiquidacion

                        'Localidad: selecciona en la parte baja la localidad a la que pertenecde la vinculada
                        If fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("codigoMovimiento") = "V" Then
                            Obtener_ParametrosComboEN(cboDeposito, "TB_LOCALIDAD")
                        Else

                            Obtener_ParametrosComboEN(cboDeposito, "COM_DEPOSITOS")
                        End If

                        nupdMerma.Value = oLiquidacionRO.oBELiquidacion.porcentajeMerma
                        txtMaquila.Text = oLiquidacionRO.oBELiquidacion.maquila
                        txtbase1.Text = oLiquidacionRO.oBELiquidacion.base1
                        txtbasemas1.Text = oLiquidacionRO.oBELiquidacion.escaladorMas1
                        txtbasemenos1.Text = oLiquidacionRO.oBELiquidacion.escaladorMenos1
                        txtbase2.Text = oLiquidacionRO.oBELiquidacion.base2
                        txtbasemas2.Text = oLiquidacionRO.oBELiquidacion.escaladorMas2
                        txtbasemenos2.Text = oLiquidacionRO.oBELiquidacion.escaladorMenos2
                        txtbasepart.Text = oLiquidacionRO.oBELiquidacion.basepp
                        nupdPorcentaje.Value = oLiquidacionRO.oBELiquidacion.pp
                        nupdPorcPago.Value = oLiquidacionRO.oBELiquidacion.porcentajePago



                        txtMaquila2.Text = oLiquidacionRO.oBELiquidacion.maquila
                        txtMerma.Text = oLiquidacionRO.oBELiquidacion.porcentajeMerma
                        cboDeposito.SelectedValue = oLiquidacionRO.oBELiquidacion.codigoDeposito
                    End With

                    'dvwterminos = New DataView(oLiquidacionRO.LeerListaToDSLiquidacion.Tables(0))
                    'fxgrdTerminos.DataSource = dvwterminos
                    'ColumnasCodigo(fxgrdTerminos)
                    'ColumnasID(fxgrdTerminos)
                    'txtctaanualmin.Text = fxgrdContrato.Rows(fxgrdContrato.Row).Item("tmAnualMinimo").ToString
                    'txtctaanualmax.Text = fxgrdContrato.Rows(fxgrdContrato.Row).Item("tmAnualMaximo").ToString
                    'txtctamensmin.Text = fxgrdContrato.Rows(fxgrdContrato.Row).Item("tmMensualMinimo").ToString
                    'txtctamensmax.Text = fxgrdContrato.Rows(fxgrdContrato.Row).Item("tmMensualMaximo").ToString
                    Dim dvwPagable As DataView
                    Dim oValorizadorPagableRO As New clsBC_ValorizadorPagableRO
                    'oValorizadorPagableRO.oBEValorizadorPagable.liquidacionTmId = "0000000001"
                    oValorizadorPagableRO.oBEValorizadorPagable.liquidacionId = "0000000001"
                    oValorizadorPagableRO.oBEValorizadorPagable.contratoLoteId = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoloteid")
                    dvwPagable = New DataView(oValorizadorPagableRO.LeerListaToDSPagable.Tables(0))
                    dgvPagables.AutoGenerateColumns = False
                    dgvPagables.DataSource = dvwPagable
                    'ColumnasCodigo(fxgrdPagable)
                    ' ColumnasID(fxgrdPagable)
                    Dim dvwPenalizable
                    Dim oValorizadorPenalizableRO As New clsBC_ValorizadorPenalizableRO
                    'oValorizadorPenalizableRO.oBEValorizadorPenalizable.liquidacionTmId = "0000000001"
                    oValorizadorPenalizableRO.oBEValorizadorPenalizable.liquidacionId = "0000000001"
                    oValorizadorPenalizableRO.oBEValorizadorPenalizable.contratoLoteId = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoloteid")
                    dvwPenalizable = New DataView(oValorizadorPenalizableRO.LeerListaToDSPenalizable.Tables(0))
                    dgvPenalizable.AutoGenerateColumns = False
                    dgvPenalizable.DataSource = dvwPenalizable
                    'ColumnasCodigo(fxgrdPenablizable)
                    'ColumnasID(fxgrdPenablizable)
                End If

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificar.Click, tsmModificar.Click
        Try
            If fxgrdContrato.RowSel >= 0 Then
                'Dim frm As New editcontrato
                'frm.MdiParent = Principal
                '' frm.MdiParent = Principal
                'frm.pblnNuevo = False
                'frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
                ''frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("liquidacionId")
                ''frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("liquidacionTmId")
                'frm.Show()
                Dim cdForm As New editlote
                ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
                cdForm.MdiParent = MdiParent
                cdForm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
                cdForm.pstrAdministrador = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("Administrador")
                cdForm.Show()

                'MostrarFormulario(SI.PL.clsEnumerado.enumTipoFormulario.EditarContrato, , fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId"), True)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    'Private Sub contratos_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim BaseRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

    '    Dim Gradient_Brush As New LinearGradientBrush(BaseRectangle, SI.PL.clsGeneral.ColorForm, Color.White, LinearGradientMode.ForwardDiagonal)
    '    e.Graphics.FillRectangle(Gradient_Brush, BaseRectangle)
    'End Sub
    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean

    '    Select Case keyData
    '        Case Keys.Escape
    '            Me.Dispose()
    '    End Select
    '    Return MyBase.ProcessCmdKey(msg, keyData)

    'End Function

    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click, tsmRefrescar.Click

        RadioButton2_CheckedChanged(Nothing, Nothing)

        'ObtenerRegistros()
        'FiltrarRegistros()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If fxgrdContrato.RowSel > 0 Then
                Dim strcontratoloteid As String = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoloteid")
                Dim dsLiquidacionTotal As DataSet



                '@02    AINI
                ' No se puede eliminar lote en caso que tenga al menos una liquidacion cuyo asiento contable haya sido generado
                '@02    AFIN

                'LOTES EN PERIODOS CERRADOS
                If fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("LOTE_CERRADO").ToString = "C" Then
                    MsgBox("No puede eliminar el lote, esta cerrado", MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                    Exit Sub
                End If



                Dim oLiquidacionTotalRO As New clsBC_LiquidacionTotalRO
                oLiquidacionTotalRO.oBELiquidacionTotal = New clsBE_LiquidacionTotal
                With oLiquidacionTotalRO.oBELiquidacionTotal
                    .contratoLoteId = strcontratoloteid
                    dsLiquidacionTotal = oLiquidacionTotalRO.LeerListaToDSLiquidacionTotal
                End With

                If dsLiquidacionTotal.Tables(0).Rows.Count > 0 Then
                    If dsLiquidacionTotal.Tables(0).Rows(0)("FLG_VALIDA").ToString = "1" Then
                        MsgBox("No puede eliminar el lote, ya ha sido validado contablemente en el módulo de Adelantos", MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
                        Exit Sub
                    End If
                End If

                ' Agregar Validación Cuando quiere  eliminar el LOTE de periodo Cerrado
                Dim oBC_TablaDetRO As New clsBC_TablaDetRO
                Dim strmensaje As String = ""
                oLiquidacionRO.oBELiquidacion.contratoLoteId = strcontratoloteid
                oLiquidacionRO.oBELiquidacion.liquidacionId = "0000000001"
                oLiquidacionRO.LeerLiquidacion()

                Dim oBC_ContratoLoteRO As New clsBC_ContratoLoteRO
                oBC_ContratoLoteRO.oBEContratoLote = New clsBE_ContratoLote
                oBC_ContratoLoteRO.oBEContratoLote.contratoLoteId = strcontratoloteid
                oBC_ContratoLoteRO.LeerContratoLote()

                Dim CodEmpresa As String = oBC_ContratoLoteRO.oBEContratoLote.codigoEmpresa

                oBC_TablaDetRO.oBETablaDet = New clsBE_TablaDet
                oBC_TablaDetRO.oBETablaDet.tablaId = CodEmpresa
                oBC_TablaDetRO.oBETablaDet.tablaDetId = CodEmpresa
                oBC_TablaDetRO.oBETablaDet.campo6 = oLiquidacionRO.oBELiquidacion.periodo
                oBC_TablaDetRO.LeerListaToDSEstadoPeriodos()
                If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows.Count > 0 Then
                    If oBC_TablaDetRO.oDSTablaDet.Tables(0).Rows(0)("Int_flagDeclara").ToString = "1" Then
                        strmensaje = strmensaje & "* No puede Eliminar Lote, porque el período " + oLiquidacionRO.oBELiquidacion.periodo + " está CERRADO: " ', MsgBoxStyle.Critical, "Valorizador Comercial de Minerales")
                        MsgBox(strmensaje, MsgBoxStyle.Critical, "Valorizador de Minerales")
                        Exit Sub

                    End If
                End If
                'Se agregó validacion cuando quiere eliminar el Lote en periodo Cerrado


                'MH:22022012
                If MsgBox("Esta seguro de eliminar el registro seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                    Dim oContratoTX As New clsBC_ContratoLoteTX
                    With oContratoTX.oBEContratoLote
                        .contratoLoteId = strcontratoloteid
                        '--------------------------------------------------
                        oContratoTX.LstContratoLote.Add(oContratoTX.oBEContratoLote)
                    End With
                    oContratoTX.EliminarContratoLote()
                    ObtenerRegistros()
                End If

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub dgvPagables_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPagables.DataError

    End Sub


    Private Sub tsbCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCopiar.Click
        Try
            If fxgrdContrato.RowSel >= 0 Then
                Dim cdForm As New editlote
                cdForm.MdiParent = MdiParent
                cdForm.pblnCopia = True
                cdForm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
                'Dim frm As New editcontrato
                'frm.MdiParent = Principal
                '' frm.MdiParent = Principal
                'frm.pblnNuevo = False
                'frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
                ''frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("liquidacionId")
                ''frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("liquidacionTmId")
                'frm.Show()

                cdForm.Show()
                'MostrarFormulario(SI.PL.clsEnumerado.enumTipoFormulario.CopiarContrato, , fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId"), True)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbGenerarLiquidacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGenerarLiquidacion.Click
        Try
            '@01    D01
            'ModLiquidacion.codLote = fxgrdContrato.Item(fxgrdContrato.RowSel, 3)
            '@01    A01
            ModLiquidacion.codLote = fxgrdContrato.Item(fxgrdContrato.RowSel, "contratoloteid")

            ModLiquidacion.uc = pBEUsuario.tablaDetId

            '@01    D01
            'ModLiquidacion.codTrader = fxgrdContrato.Item(fxgrdContrato.RowSel, 27)
            '@01    A01
            ModLiquidacion.codTrader = fxgrdContrato.Item(fxgrdContrato.RowSel, "Trader")

            ModLiquidacion.NomTrader = pBEUsuario.descri
            ModLiquidacion.ShowDialog()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub fxgrdContrato_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fxgrdContrato.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.C
                    If e.Modifiers = Keys.Control Then
                        System.Windows.Forms.Clipboard.SetText(fxgrdContrato.Clip)
                    End If
            End Select
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsbLoteP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLoteP.Click
        'fxgrdContrato.SaveExcel("c:\ejemplo.xls")
    End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        Try
            sfDialog.Filter = "Hojas de Excel|*.xls"
            sfDialog.ShowDialog()
            If sfDialog.FileName.Length > 0 Then
                fxgrdContrato.SaveExcel(sfDialog.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        Try
            If RadioButton2.Checked Then
                'cargar detgalleado
                ObtenerRegistros("LOT")
            Else
                'cargar agrupado
                ObtenerRegistros()
            End If
            FiltrarRegistros()
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub cboTipoContrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoContrato.SelectedIndexChanged
        FiltrarRegistros()
    End Sub

    Private Sub FiltrarRegistros()
        Try
            If Not dvwContrato Is Nothing Then
                Dim strFiltro As String = ""
                If cboTipoContrato.SelectedIndex >= 0 Then
                    If cboTipoContrato.SelectedValue.ToString.Length > 0 Then
                        strFiltro = "codigoMovimiento='" & cboTipoContrato.SelectedValue.ToString & "'"
                    Else
                        strFiltro = ""
                    End If

                End If
                If cboProducto.SelectedIndex >= 0 Then
                    If cboProducto.SelectedValue.ToString.Length > 0 Then
                        strFiltro = IIf(strFiltro.Length > 0, strFiltro & " and ", "") & "codigoProducto='" & cboProducto.SelectedValue.ToString & "'"
                        'Else
                        '    strFiltro = ""
                    End If

                End If
                dvwContrato.RowFilter = strFiltro
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub cboProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProducto.SelectedIndexChanged
        FiltrarRegistros()
    End Sub

    Private Sub lotes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        If Not (RadioButton1.Checked = False And RadioButton2.Checked = False) Then
            ObtenerRegistros()
        End If
    End Sub

    Private Sub tsbLimpiarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiarFiltro.Click
        cboProducto.SelectedIndex = 0
        cboTipoContrato.SelectedIndex = 0
        fxgrdContrato.FilterDefinition = "<ColumnFilters />"
    End Sub

    Private Sub fxgrdContrato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fxgrdContrato.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            tsbModificar_Click(sender, e)
        End If
    End Sub

End Class
