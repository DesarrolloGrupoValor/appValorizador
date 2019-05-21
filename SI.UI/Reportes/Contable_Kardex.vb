Imports SI.BC
Imports SI.UT
Imports SI.BE
Imports SI.PL.clsFuncion

Public Class Contable_Kardex
    'control de errores
    Private oMensajeError As mensajeError = New mensajeError
    'Public pTipo As String

    Dim dvwRegistros As DataView

    'Private Sub Estimaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    ObtenerRegistros("", "")
    'End Sub

    Private Sub ObtenerRegistros(ByVal empresa As String, ByVal periodo As String)
        Try
            Dim sTipo As String
            Dim dsregistros As DataSet
            Dim oContratoRO As New clsBC_ContratoLoteRO
            oContratoRO.oBEContratoLote.codigoEmpresa = empresa 'cboEmpresa.SelectedValue
            oContratoRO.oBEContratoLote.comentarios = periodo 'Year(dtpPeriodo.Value) & IIf(Month(dtpPeriodo.Value).ToString.Length > 1, "", "0") & Month(dtpPeriodo.Value)

            sTipo = IIf(rbNuevo.Checked, "N", "A")

            dsregistros = oContratoRO.LeerListaToDSContable_Kardex(sTipo)
            dvwRegistros = New DataView(dsregistros.Tables(0))


            fxgrdContabilidad.AutoGenerateColumns = True
            fxgrdContabilidad.DataSource = dvwRegistros

            fxgrdContabilidad.Cols(9).Format = "N2"
            fxgrdContabilidad.Cols(10).Format = "N2"
            fxgrdContabilidad.Cols(11).Format = "N2"
            fxgrdContabilidad.Cols(12).Format = "N2"
            fxgrdContabilidad.Cols(13).Format = "N2"
            fxgrdContabilidad.Cols(14).Format = "N2"
            fxgrdContabilidad.Cols(15).Format = "N2"
            fxgrdContabilidad.Cols(16).Format = "N2"
            fxgrdContabilidad.Cols(17).Format = "N2"

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
            fxgrdContabilidad.SaveExcel(SaveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells)
        End If
    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click

        Me.Dispose()

    End Sub

    Private Sub tsbConsular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbConsular.Click
        Try
            If cboEmpresa.SelectedIndex < 1 Then
                MsgBox("Debe seleccionar empresa", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                Return
            End If

            If cboPeriodo.SelectedIndex < 1 Then
                MsgBox("Debe seleccionar periodo", MsgBoxStyle.Exclamation, "Valorizador de Minerales")
                Return
            End If

            ObtenerRegistros(cboEmpresa.SelectedValue, cboPeriodo.SelectedValue)
            MsgBox("Finalización satisfactoria de la obtención de la información. Período: " & cboPeriodo.SelectedValue, MsgBoxStyle.OkOnly, "Valorizador Comercial de Minerales")
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
    End Sub

    Private Sub Contable_Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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