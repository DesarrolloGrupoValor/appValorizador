Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class Movimiento
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    'Private Sub Estimaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    ObtenerRegistros("", "")
    'End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String, ByVal periodoDestino As String)
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoEmpresa = empresa 'cboEmpresa.SelectedValue
            oContratoRO.oBEContratoLote.periodo_origen = periodo 'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)
            oContratoRO.oBEContratoLote.periodo_destino = periodoDestino 'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)


            dsregistros = oContratoRO.LeerListaToDSContable_Movimiento_New
            dvwRegistros = New DataView(dsregistros.Tables(0))


            fxgrdExtraccionBd.AutoGenerateColumns = False
            fxgrdExtraccionBd.DataSource = dvwRegistros


            IdentificaTMH_Valor_0()

        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()


        End Try
    End Sub

    'Private Sub tsMantenimiento_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    'End Sub

    Private Sub tsbExportarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExportarExcel.Click
        SaveFileDialog1.Filter = "Hojas de Excel|*.xls"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName.Length > 0 Then
            fxgrdExtraccionBd.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        '    ObtenerRegistros()
        Me.Dispose()

    End Sub
    Private Function Validar(Optional ByVal sTipoValidacion As String = "")

        Dim strmensaje As String = ""
        Try

            If cboEmpresa.SelectedIndex < 1 Then
                 strmensaje = strmensaje &"Debe seleccionar empresa"
            End If

            If cboPeriodo.SelectedIndex < 1 Then
                 strmensaje = strmensaje &"Debe seleccionar periodo"
            End If

            If CboPeriodoDestino.SelectedIndex < 1 Then
                strmensaje = strmensaje & "Debe seleccionar periodo Destino"
            End If

            If CboPeriodoDestino.SelectedValue < cboPeriodo.SelectedValue Then
                 strmensaje = strmensaje & "Periodo Destino no puede ser menor a Periodo Inicial"

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

    Private Sub tsbConsular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsular.Click

        Try
            If Validar(String.Empty) Then
                ObtenerRegistros(cboEmpresa.SelectedValue, cboPeriodo.SelectedValue, CboPeriodoDestino.SelectedValue)
                MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue & " - " & CboPeriodoDestino.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"

        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()
        CboPeriodoDestino.DataSource = dsPeriodo.Tables(0)
        CboPeriodoDestino.DisplayMember = "periodo"
        CboPeriodoDestino.ValueMember = "periodoId"

    End Sub

    Private Sub Movimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            ObtenerPeriodos()
            Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    'Identificar los ingresos por compras o por Producción Propia con tonelajes
    'y sin valores en soles y dólares.

    Private Sub IdentificaTMH_Valor_0()
        Dim rs As C1.Win.C1FlexGrid.CellStyle
        rs = fxgrdExtraccionBd.Styles.Add("RowColor")
        rs.BackColor = Color.Red

        For i = 1 To fxgrdExtraccionBd.Rows.Count - 3
            If fxgrdExtraccionBd.Item(i, "MOV_ORIGEN").ToString() = "P" And _
                fxgrdExtraccionBd.Item(i, "TIPO").ToString() = "2.COMPRAS" And _
                     fxgrdExtraccionBd.Item(i, "DOLAR_SI") = 0 And _
                     fxgrdExtraccionBd.Item(i, "SOLES_SI") = 0 And _
                     fxgrdExtraccionBd.Item(i, "SOLES_COMPRAS") = 0 And _
                     fxgrdExtraccionBd.Item(i, "DOLAR_COMPRAS") = 0 And _
                     fxgrdExtraccionBd.Item(i, "TMH_COMPRAS") > 0 Then
                fxgrdExtraccionBd.Rows(i).Style = fxgrdExtraccionBd.Styles("RowColor")
            End If

        Next
    End Sub

    '1 cruce ventas
    Private Sub tsmValida2_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida2.Click
        Try
            If Validar(String.Empty) Then
                Dim frm As New FrmMatrizAsientos

                frm.pTipoFormulario = "DIF_TMH_VENTAS"
                frm.empresaID = cboEmpresa.SelectedValue
                frm.periodo = cboPeriodo.SelectedValue
                frm.periodo_destino = CboPeriodoDestino.SelectedValue

                frm.Show()
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub

    '2 cuadre mezclas
    Private Sub tsmValida3_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida3.Click
        Try
            If Validar(String.Empty) Then
                Dim frmMatrizMezcla As New MatrizMezcla
                'frmMatrizMezcla.MdiParent = MdiParent
                frmMatrizMezcla.pTipo_Extraccion = "B"
                frmMatrizMezcla.pEmpresa = cboEmpresa.SelectedValue
                frmMatrizMezcla.pPeriodo = cboPeriodo.SelectedValue
                frmMatrizMezcla.Show()
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub

    '3 cruce saldos finales
    Private Sub tsmValida4_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida4.Click
        Try
            If Validar(String.Empty) Then
                Dim frm As New frmValidarSaldoFinal
                'frm.MdiParent = MdiParent
                frm.sPeriodo = cboPeriodo.SelectedValue
                frm.Show()
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub

    '4 mayorizacion de asientos
    Private Sub tsmValida5_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida5.Click
        Try
            If Validar(String.Empty) Then
                Dim frm As New FrmMatrizAsientos
                frm.pTipoFormulario = "MATRIZ_ASIENTOS"

                frm.empresaID = cboEmpresa.SelectedValue
                frm.periodo = cboPeriodo.SelectedValue.ToString.Substring(4, 2)
                frm.anio = cboPeriodo.SelectedValue.ToString.Substring(2, 2)
                frm.Show()
            End If
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try

    End Sub


    Private Sub tsmValida1_Click(sender As System.Object, e As System.EventArgs) Handles tsmValida1.Click
        Dim ofrmRumasPendientes As New frmRumasPendientes
        ofrmRumasPendientes.MdiParent = MdiParent
        ofrmRumasPendientes.Show()
    End Sub

End Class