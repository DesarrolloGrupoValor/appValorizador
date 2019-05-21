Imports System.Data
Imports SI.BC
Imports SI.UT
Imports SI.PL.clsProcedimientos
Imports SI.PL.clsGeneral
Imports SI.PL.clsFuncion
Imports System.Drawing.Drawing2D

Public Class contratos
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Private blnCarga As Boolean
    Private dataTableContrato As DataTable
    Private dvwContrato As DataView
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click, tsmSalir.Click
        Me.Dispose()
    End Sub

    Private Sub contratos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        'If pblnRetornaContratos Then
        '    ObtenerRegistros()
        '    pblnRetornaContratos = False
        'End If
    End Sub

    Private Sub contratos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
            CargarParametros()
            ObtenerRegistros()
            fxgrdContrato.AllowFiltering = True
            'fxgrdContrato.ApplyFilters = True

            Me.WindowState = FormWindowState.Maximized
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
            'Obtener_ParametrosGridView(dgvQP, clsUT_Dominio.domTIPO_DE_PERIODO_DE_COTIZACION)
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
    Private Sub ObtenerRegistros()
        Try
            blnCarga = False


            'kmn 31/08/2012
            Dim sFilterDefinition As String = fxgrdContrato.FilterDefinition
            Dim nRowSel As Integer = fxgrdContrato.RowSel
            Dim sRowFilter As String = ""
            If dvwContrato IsNot Nothing Then
                sRowFilter = dvwContrato.RowFilter
            End If
            'kmn 31/08/2012


            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoTabla = TABLA.CONTRATO.Value
            oContratoRO.oBEContratoLote.contratoLoteId = ""
            oContratoRO.oBEContratoLote.comentarios = pBEUsuario.campo2
            oContratoRO.oBEContratoLote.permiso = pBEUsuario.campo6
            dataTableContrato = oContratoRO.LeerListaToDSContrato.Tables(0)
            'dvwContrato = New DataView(oContratoRO.LeerListaToDSContrato.Tables(0))

            dvwContrato = New DataView(dataTableContrato)


            'kmn 31/08/2012
            dvwContrato.RowFilter = sRowFilter
            'kmn 31/08/2012

            fxgrdContrato.DataSource = dvwContrato
            ColumnasID(fxgrdContrato)
            ColumnasCodigo(fxgrdContrato)
            blnCarga = True
            fxgrdContrato_Click(Nothing, Nothing)
            fxgrdContrato_SelChange(Nothing, Nothing)

            'fxgrdContrato.Cols("tipocontrato").Visible = False
            'fxgrdContrato.Cols("producto").Visible = False

            'fxgrdContrato.Cols("cliente/proveedor").Width = 250


            'kmn 31/08/2012
            fxgrdContrato.FilterDefinition = sFilterDefinition

            Try
                fxgrdContrato.RowSel = nRowSel
            Catch ex As Exception
                fxgrdContrato.RowSel = 1
            End Try
            'kmn 31/08/2012

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub tsmNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmNuevo.Click, tsbNuevo.Click
        Try
            'If fxgrdContrato.RowSel >= 0 Then
            'Dim frm As New editcontrato
            'frm.MdiParent = Principal
            'frm.pblnNuevo = True
            'frm.WindowState = FormWindowState.Maximized
            ''frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
            ''frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("liquidacionId")
            ''frm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("liquidacionTmId")
            'frm.Show()
            ' MostrarFormulario(SI.PL.clsEnumerado.enumTipoFormulario.NuevoContrato)
            'End If
            Dim cdForm As New editcontrato
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
            If fxgrdContrato.Rows.Count > 0 Then
                Dim cdForm As New editcontrato
                cdForm.MdiParent = MdiParent
                cdForm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
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
                If fxgrdContrato.RowSel >= 1 And fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoloteid") IsNot Nothing Then
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
                    txtctaanualmin.Text = fxgrdContrato.Rows(fxgrdContrato.Row).Item("tmAnualMinimo").ToString
                    txtctaanualmax.Text = fxgrdContrato.Rows(fxgrdContrato.Row).Item("tmAnualMaximo").ToString
                    txtctamensmin.Text = fxgrdContrato.Rows(fxgrdContrato.Row).Item("tmMensualMinimo").ToString
                    txtctamensmax.Text = fxgrdContrato.Rows(fxgrdContrato.Row).Item("tmMensualMaximo").ToString
                    Dim dvwPagable As DataView
                    Dim oValorizadorPagableRO As New clsBC_ValorizadorPagableRO
                    ' oValorizadorPagableRO.oBEValorizadorPagable.liquidacionTmId = "0000000001"
                    oValorizadorPagableRO.oBEValorizadorPagable.liquidacionId = "0000000001"
                    oValorizadorPagableRO.oBEValorizadorPagable.contratoLoteId = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoloteid")
                    dvwPagable = New DataView(oValorizadorPagableRO.LeerListaToDSValorizadorPagable.Tables(0))
                    dgvPagables.AutoGenerateColumns = False
                    dgvPagables.DataSource = dvwPagable
                    'ColumnasCodigo(fxgrdPagable)
                    'ColumnasID(fxgrdPagable)
                    Dim dvwPenalizable
                    Dim oValorizadorPenalizableRO As New clsBC_ValorizadorPenalizableRO
                    ' oValorizadorPenalizableRO.oBEValorizadorPenalizable.liquidacionTmId = "0000000001"
                    oValorizadorPenalizableRO.oBEValorizadorPenalizable.liquidacionId = "0000000001"
                    oValorizadorPenalizableRO.oBEValorizadorPenalizable.contratoLoteId = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoloteid")
                    dvwPenalizable = New DataView(oValorizadorPenalizableRO.LeerListaToDSValorizadorPenalizable.Tables(0))
                    dgvPenalizable.AutoGenerateColumns = False
                    dgvPenalizable.DataSource = dvwPenalizable
                    'ColumnasCodigo(fxgrdPenablizable)
                    ' ColumnasID(fxgrdPenablizable)
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
                Dim cdForm As New editcontrato
                cdForm.MdiParent = MdiParent
                cdForm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
                cdForm.Show()
                ' MostrarFormulario(SI.PL.clsEnumerado.enumTipoFormulario.EditarContrato, , fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId"), True)
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub fxgrdContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fxgrdContrato.Click
        'ObtenerRegistros()
    End Sub

    'Private Sub contratos_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim BaseRectangle As New Rectangle(0, 0, Me.Width - 1, Me.Height - 1)

    '    Dim Gradient_Brush As New LinearGradientBrush(BaseRectangle, Me.BackColor, Color.LemonChiffon, LinearGradientMode.Vertical)
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
        ObtenerRegistros()
    End Sub

    Private Sub tsbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEliminar.Click
        Try
            If fxgrdContrato.RowSel > 0 Then

                Dim _contrato As String
                Dim _contratoloteid As String

                _contrato = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contrato")
                _contratoloteid = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoloteid")

                If MsgBox("Esta seguro de eliminar el registro seleccionado", MsgBoxStyle.YesNo, "Valorizador Comercial de Minerales") = MsgBoxResult.Yes Then
                    If ValidarContratoEliminar(_contrato) Then

                        Dim oContratoTX As New clsBC_ContratoLoteTX
                        With oContratoTX.oBEContratoLote
                            .contratoLoteId = _contratoloteid
                            oContratoTX.LstContratoLote.Add(oContratoTX.oBEContratoLote)
                        End With
                        oContratoTX.EliminarContratoLote()
                        ObtenerRegistros()
                    Else
                        MsgBox("El contrato seleccionado, no puede ser eliminado, por tener lotes asociados", vbOKOnly, "Valorizador Comercial de Minerales")
                    End If

                End If

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Function ValidarContratoEliminar(ByVal contrato As String)
        Try
            Dim oContratoLoteRO As New clsBC_ContratoLoteRO
            Dim dsresult As DataSet
            With oContratoLoteRO.oBEContratoLote
                .contrato = contrato
                .codigoTabla = "LOT"
                .comentarios = pBEUsuario.campo2

            End With
            dsresult = oContratoLoteRO.LeerListaToDSContrato()
            If dsresult IsNot Nothing Then
                If dsresult.Tables(0).Rows.Count > 1 Then
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
            Return False
        End Try
    End Function

    Private Sub tsbCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCopiar.Click
        Try
            If fxgrdContrato.RowSel >= 0 Then
                Dim cdForm As New editcontrato
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

    Private Sub tsbContratoLoteP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbContratoLoteP.Click
        Try
            If fxgrdContrato.RowSel >= 0 Then

                Dim cdForm As New editlote

                cdForm.MdiParent = MdiParent
                cdForm.pstrCorrelativo = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("contratoLoteId")
                cdForm.pstrAdministrador = fxgrdContrato.Rows(fxgrdContrato.RowSel).Item("trader")
                cdForm.pblnDesdeContrato = True
                cdForm.Show()

            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub dgvPagables_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPagables.DataError

    End Sub

    Private Sub tsMantenimiento_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsMantenimiento.ItemClicked

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'System.Windows.Forms.Clipboard.SetText(fxgrdContrato.Clip)



        ' Me.fxgrdContrato.ClipboardCopyMode =DataGridViewClipboardCopyMode.EnableWithoutHeaderText

        ' If Me.fxgrdContrato.getc.GetCellCount( _
        'DataGridViewElementStates.Selected) > 0 Then

        '     Try

        '         ' Add the selection to the clipboard.
        '         Clipboard.SetDataObject( _
        '             Me.fxgrdContrato.GetClipboardContent())

        '         ' Replace the text box contents with the clipboard text.
        '         'Me.TextBox1.Text = Clipboard.GetText()

        '     Catch ex As System.Runtime.InteropServices.ExternalException
        '         'Me.TextBox1.Text = _"The Clipboard could not be accessed. Please try again."
        '     End Try

        ' End If




    End Sub
    Private Sub ExportarExcel(ByVal poDataTable As DataTable)
        'Dim lsClassExcel As New ClassExcel


        ''/////////////////////////////
        ''// Creamos el Objeto Excel
        ''/////////////////////////////
        'Dim m_Excel
        'Dim objLibroExcel
        'Dim objHojaExcel
        'm_Excel = CreateObject("Excel.Application")
        'objLibroExcel = m_Excel.Workbooks.Add()
        'objHojaExcel = objLibroExcel.Worksheets(1)
        'objHojaExcel.Name = "Customers"
        'objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        'objHojaExcel.Activate()

        ''/////////////////////////////////////////////////////////
        ''// Definimos dos variables para controlar fila y columna
        ''/////////////////////////////////////////////////////////
        'Dim fila As Integer = 1
        'Dim columna As Integer = 1

        ''/////////////////////////////////////////////////
        ''// Armamos la linea con los títulos de columnas
        ''/////////////////////////////////////////////////
        'objHojaExcel.Range("A1").Select()
        'For Each dc In poDataTable.Columns
        '    objHojaExcel.Range(lsClassExcel.nombreColumna(columna) & 1).Value = dc.ColumnName
        '    columna += 1
        'Next
        'fila += 1

        ''/////////////////////////////////////////////
        ''// Le damos formato a la fila de los títulos
        ''/////////////////////////////////////////////
        'Dim objRango As Excel.Range = objHojaExcel.Range("A1:" & lsClassExcel.nombreColumna(poDataTable.Columns.Count) & "1")
        'objRango.Font.Bold = True
        'objRango.Cells.Interior.ColorIndex = 35

        'objRango.Cells.Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        'objRango.Cells.Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        'objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlLineStyleNone
        'objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        'objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        'objRango.Cells.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous

        ''//////////////////////////////////////////
        ''// Cargamos todas las filas del datatable
        ''//////////////////////////////////////////
        ''ProgressBar1.Maximum = ds.Tables(0).Rows.Count
        ''columna = 1
        ''ProgressBar1.Value = 0
        'For Each dr In poDataTable.Rows
        '    columna = 1
        '    For Each dc In poDataTable.Columns
        '        objHojaExcel.Range(lsClassExcel.nombreColumna(columna) & fila).Value = dr(dc.ColumnName)
        '        columna += 1
        '    Next
        '    fila += 1
        '    'ProgressBar1.Value += 1
        'Next

        ''//////////////////////////////////////
        ''// Ajustamos automaticamente el ancho
        ''// de todas las columnas utilizada
        ''//////////////////////////////////////
        'objRango = objHojaExcel.Range("A1:" & lsClassExcel.nombreColumna(poDataTable.Columns.Count) & poDataTable.Rows.Count.ToString)
        'objRango.Select()
        'objRango.Columns.AutoFit()

        ''/////////////////////////////////////
        ''// Le decimos a Excel que se muestre
        ''/////////////////////////////////////
        'MsgBox("Exportación a Excel completa", MsgBoxStyle.Information, ".:: solovb.net ::.")
        'm_Excel.Visible = True
    End Sub


    Private Sub fxgrdContrato_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fxgrdContrato.KeyDown
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
    Private Sub cboTipoContrato_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoContrato.SelectedIndexChanged
        FiltrarRegistros()
    End Sub
    Private Sub FiltrarRegistros()
        Try
            If dvwContrato IsNot Nothing Then
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

    Private Sub contratos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        ObtenerRegistros()

    End Sub

    Private Sub tsbLimpiarFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbLimpiarFiltro.Click
        Try
            cboProducto.SelectedIndex = 0
            cboTipoContrato.SelectedIndex = 0
            fxgrdContrato.FilterDefinition = "<ColumnFilters />"
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    Private Sub fxgrdContrato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fxgrdContrato.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            tsbModificar_Click(sender, e)
        End If
    End Sub

End Class
