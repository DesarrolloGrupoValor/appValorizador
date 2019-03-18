Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class Movimiento_OLD
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError

    Dim dvwRegistros As DataView

    'Private Sub Estimaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    ObtenerRegistros("", "")
    'End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoEmpresa = empresa 'cboEmpresa.SelectedValue
            oContratoRO.oBEContratoLote.comentarios = periodo 'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)

            dsregistros = oContratoRO.LeerListaToDSContable_Movimiento
            dvwRegistros = New DataView(dsregistros.Tables(0))


            'fxgrdExtraccionBd.AutoGenerateColumns = False
            fxgrdExtraccionBd.DataSource = dvwRegistros


            ''fxgrdExtraccionBd.Cols(3).Width = 120
            ''fxgrdExtraccionBd.Cols(5).Width = 300


            fxgrdExtraccionBd.Cols(6).Width = 120


            For nContador As Integer = 10 To 21 Step 1
                fxgrdExtraccionBd.Cols(nContador).Format = "N2"
                fxgrdExtraccionBd.Cols(nContador).Width = 110
            Next

            'fxgrdExtraccionBd.Cols(6).Format = "N2"
            'fxgrdExtraccionBd.Cols(7).Format = "N2"
            'fxgrdExtraccionBd.Cols(8).Format = "N2"

            ''fxgrdExtraccionBd.Refresh()
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

    'Private Sub gpoContratos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpoContratos.Enter

    'End Sub

    'Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged
    '    ObtenerRegistros("", "")
    'End Sub

    Private Sub tsbConsular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsular.Click
        Try
            If cboEmpresa.SelectedIndex < 1 Then
                MsgBox("Debe seleccionar empresa", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Return
            End If

            If cboPeriodo.SelectedIndex < 1 Then
                MsgBox("Debe seleccionar periodo", MsgBoxStyle.OkOnly, "Valorizador de Minerales")
                Return
            End If

            ObtenerRegistros(cboEmpresa.SelectedValue, cboPeriodo.SelectedValue)
            MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
        Catch ex As Exception
            oMensajeError.txtMensaje.Text = ex.ToString()
            oMensajeError.ShowDialog()
        End Try
    End Sub


    'Private Sub gpoContratos_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpoContratos.Enter
    '    Obtener_ParametrosCombo(cboEmpresa, clsUT_Dominio.domTABLA_DE_EMPRESA, SI.PL.clsEnumerado.enumPrimerValorCombo.Seleccione, SI.PL.clsEnumerado.enumTipoComboGrilla.IdDescripcion)
    'End Sub


    'Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
    '    If cboPeriodo.SelectedIndex > 0 Then
    '        ObtenerRegistros("", cboPeriodo.SelectedValue)
    '    End If
    'End Sub

    Private Sub ObtenerPeriodos()
        Dim dsPeriodo As DataSet
        Dim oBC_PeriodoRO As New clsBC_PeriodoRO
        dsPeriodo = oBC_PeriodoRO.ObtenerPeriodo()

        cboPeriodo.DataSource = dsPeriodo.Tables(0)
        cboPeriodo.DisplayMember = "periodo"
        cboPeriodo.ValueMember = "periodoId"
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

End Class